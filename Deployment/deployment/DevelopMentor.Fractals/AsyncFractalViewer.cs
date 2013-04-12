#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using Neocranium.Fractals;
using Complex = Neocranium.Fractals.ComplexDouble;
using System.Drawing.Imaging;
using System.Threading;

#endregion


namespace DevelopMentor.Fractals
{
   public partial class AsyncFractalViewer : Control
   {
      #region Fields and properties
     
      //The bitmap. Duh.
      Bitmap _Bitmap;

      //Look at the pretty colors!
      static int[] Palette = CreatePalette();

      //This timer fires while the background thread is rendering
      System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();

      //This lock is used to synchronize access between the main UI thread
      //and the background rendering thread.
      object BitmapSyncLock = new object();


      //Background thread that is doing the rendering.
      Thread RenderThread;

      //Call HaltRendering to set this to true.  The background thread uses
      //this to abort.
      bool CancelPending = false;
      bool Rendering = false;


      private Complex _Center = new Complex(0, 0);
      [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
      public Complex Center
      {
         get { return _Center; }
         set { _Center = value; }
      }

      private double _Scale = 3.0;
      public double ViewportWidth
      {
         get { return _Scale; }
         set { _Scale = value; }
      }


      private int _MaxIterations = 100;
      public int MaxIterations
      {
         get { return _MaxIterations; }
         set { _MaxIterations = value; }
      }

      //to avoid having to lock on MaxIterations we just
      //copy it to __MaxIterations whenever we begin a new
      //rendering
      private int __MaxIterations;

      #endregion


      public AsyncFractalViewer()
      {
         bHaveMouse = false;
         this.SetStyle( ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
         
         //when this timer fires we just invalidate
         timer1.Interval = 250;
         timer1.Tick += delegate { Invalidate(); };
         timer1.Enabled = false;

         this.Disposed +=new EventHandler(AsyncFractalViewer_Disposed);

      }



      static int[] CreatePalette()
      {
         int[] palette = new int[256];
         palette[0] = (int)Color.Black.ToArgb();

         for (int i = 1; i < 256; i++)
         {
            palette[i] = (int)Color.FromArgb((i < 128) ? (i * 2) : (255 - (i - 128) * 2), i, (255 - i)).ToArgb();
         }

         return palette;
      }

      protected override void OnCreateControl()
      {
         Form f = this.FindForm();
         if (f != null)
         {
            this.FindForm().ResizeBegin += FormResizeBegin;
            this.FindForm().ResizeEnd += FormResizeEnd;
         }
         BeginRendering();
      }


      protected override void OnPaint(PaintEventArgs pe)
      {
         if (!Rendering)
            timer1.Stop();

         lock (BitmapSyncLock)
         {
            if (_Bitmap != null)
            {
               try
               {
                  pe.Graphics.DrawImage(_Bitmap, new Point(0, 0));
               }
               catch (Exception e)
               {
                  MessageBox.Show(e.ToString());
               }
            }
         }
      }

      #region Background rendering management

      protected void FormResizeBegin(object sender, EventArgs e)
      {
         Debug.WriteLine("ResizeBegin");
         Monitor.Enter(BitmapSyncLock);
      }


      protected void FormResizeEnd(object sender, EventArgs e)
      {
         Debug.WriteLine("ResizeEnd");
         Monitor.Exit(BitmapSyncLock);

         bool shouldAbort = false;

         lock (BitmapSyncLock)
         {
            if ((_Bitmap == null) || (Width > _Bitmap.Width || Height > _Bitmap.Height))
            {
               shouldAbort = true;
            }
         }

         if (shouldAbort)
         {
            HaltRendering();
            BeginRendering();
         }

      }

      public void SetDirty()
      {
         HaltRendering();
         BeginRendering();
      }

      //If the window dimensions changed we allocate a bitmap that's sized to fit
      //our new window dimensions.
      void ReallocBitmap()
      {
         lock (BitmapSyncLock)
         {
            if (_Bitmap != null)
            {
               _Bitmap.Dispose();
            }

            _Bitmap = new Bitmap(Width, Height, PixelFormat.Format32bppArgb);
         }
      }

      void HaltRendering()
      {
         timer1.Stop();
         CancelPending = true;
         if(RenderThread!=null)
            RenderThread.Join();

         CancelPending = false;
      }

      void BeginRendering()
      {
         //copy this value into a slot that should
         //only be accessed from the render thread.
         __MaxIterations = MaxIterations;

         ReallocBitmap();

         RenderThread = new Thread(Render);
         RenderThread.Name = "Render thread";
         Rendering = true;
         RenderThread.Start();
         timer1.Start();
      }

      void Render()
      {
         Stopwatch sw = new Stopwatch();
         sw.Start();

         try
         {
            Mandelbrot Generator = new Mandelbrot();

            if (CancelPending)
               return;

            int height = 0;
            int width = 0;
            lock (BitmapSyncLock)
            {
               height = _Bitmap.Height;
               width = _Bitmap.Width;
            }


            double increment = (double)ViewportWidth / (double)width;
            double left = Center.real - (width / 2) * increment;
            double row = Center.imaginary - (height / 2) * increment;

            int[] pixels = new int[width];

            for (int y = 0; y < height; y++)
            {
               if (CancelPending)
                  return;

               Generator.RenderRow(left, row, increment, __MaxIterations, Palette, ref pixels);

               if (CancelPending)
                  return;

               lock (BitmapSyncLock)
               {
                  for (int x = 0; x < width; x++)
                  {
                     _Bitmap.SetPixel(x, y, Color.FromArgb(pixels[x]));
                  }
               }

               row += increment;
            }

            Invalidate();
         }
         finally
         {
            sw.Stop();
            Debug.WriteLine(sw.Elapsed);
            Rendering = false;
         }
      }

      #endregion

      #region TrackRectangle management
      bool bHaveMouse;
      Point ptLast = new Point();
      Point ptOriginal = new Point();

      protected override void OnMouseDown(MouseEventArgs e)
      {
         HaltRendering();

         if (DesignMode)
            return;

         if (e.Button == MouseButtons.Left)
         {
            bHaveMouse = true;
            ptOriginal.X = e.X;
            ptOriginal.Y = e.Y;
            ptLast.X = -1;
            ptLast.Y = -1;
         }
         else if (e.Button == MouseButtons.Right)
         {
            ZoomOut(e);
            bHaveMouse = false;
         }
      }
      private void ZoomOut(MouseEventArgs e)
      {
         //Center = FromPixel(e.Location);
         ViewportWidth *= 5;
         HaltRendering();
         BeginRendering();
      }

      protected override void OnMouseMove(MouseEventArgs e)
      {
         if (DesignMode)
            return;

         Point point1 = new Point();
         point1.X = e.X;
         point1.Y = e.Y;
         if (bHaveMouse)
         {
            if (ptLast.X != -1)
            {
               DrawSelectionRectangle(ptOriginal, ptLast);
            }
            ptLast = point1;
            DrawSelectionRectangle(ptOriginal, point1);
         }
      }

      Complex FromPixel(Point p)
      {
         int Width;
         int Height;
         if (_Bitmap != null)
         {
            Width = _Bitmap.Width;
            Height = _Bitmap.Height;
         }
         else
         {
            Width = this.Width;
            Height = this.Height;
         }
         double increment = (double)ViewportWidth / (double)Width;
         Point centerPixel = new Point(Width / 2, Height / 2);
         int xdelta = p.X - centerPixel.X;
         int ydelta = p.Y - centerPixel.Y;

         return Center + new Complex(xdelta * increment, ydelta * increment);
      }

      protected override void OnMouseUp(MouseEventArgs e)
      {
         if (DesignMode)
            return;

         if (bHaveMouse)
         {
            bHaveMouse = false;
            if (ptLast.X != -1 && Math.Abs(ptOriginal.X - e.X) > 5 && Math.Abs(ptOriginal.Y - e.Y) > 5) //"Debounce" the mouse
            {
               Point point1 = new Point();
               point1.X = e.X;
               point1.Y = e.Y;
               DrawSelectionRectangle(ptOriginal, ptLast);

               Point SelectionCenter = new Point((ptLast.X + ptOriginal.X) / 2,
                                                (ptLast.Y + ptOriginal.Y) / 2);

               double xratio = (double)Math.Abs(ptLast.X - ptOriginal.X) / Width;
               double yratio = (double)Math.Abs(ptLast.Y - ptOriginal.Y) / Height;
               double newratio = Math.Max(xratio, yratio);

               Center = FromPixel(SelectionCenter);
               ViewportWidth *= newratio;
            }
            else
               Center = FromPixel(e.Location);


            ptLast.X = -1;
            ptLast.Y = -1;
            ptOriginal.X = -1;
            ptOriginal.Y = -1;

            BeginRendering();
         }
      }

      private void DrawSelectionRectangle(Point p1, Point p2)
      {
         Rectangle rectangle1 = new Rectangle();
         p1 = PointToScreen(p1);
         p2 = PointToScreen(p2);
         if (p1.X < p2.X)
         {
            rectangle1.X = p1.X;
            rectangle1.Width = p2.X - p1.X;
         }
         else
         {
            rectangle1.X = p2.X;
            rectangle1.Width = p1.X - p2.X;
         }
         if (p1.Y < p2.Y)
         {
            rectangle1.Y = p1.Y;
            rectangle1.Height = p2.Y - p1.Y;
         }
         else
         {
            rectangle1.Y = p2.Y;
            rectangle1.Height = p1.Y - p2.Y;
         }
         ControlPaint.DrawReversibleFrame(rectangle1, Color.White, FrameStyle.Dashed);
      }
      #endregion

      void AsyncFractalViewer_Disposed(object sender, EventArgs e)
      {
         HaltRendering();
      }
   }
}
