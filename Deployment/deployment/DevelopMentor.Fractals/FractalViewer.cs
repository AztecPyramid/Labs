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
   public partial class FractalViewer : Control
   {
      #region Fields and Properties
      Bitmap _Bitmap;
      Mandelbrot Generator = new Mandelbrot();
      static int[] Palette;
      System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

      private Complex _Center = new Complex(0, 0);
      private double _Scale = 3.0;

      [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
      public Complex Center
      {
         get { return _Center; }
         set { _Center = value; }
      }

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
      #endregion

      static FractalViewer()
      {
         Palette = new int[]
         {
            Color.Black.ToArgb(),
            Color.Blue.ToArgb(),
            Color.MediumBlue.ToArgb(),
            Color.Purple.ToArgb(),
            Color.DarkBlue.ToArgb(),
            Color.LimeGreen.ToArgb(),
            Color.Green.ToArgb(),
            Color.DarkGreen.ToArgb(),
            Color.Khaki.ToArgb(),
            Color.Yellow.ToArgb(),
            Color.LightYellow.ToArgb(),
            Color.Orange.ToArgb(),
            Color.White.ToArgb(),
            Color.Pink.ToArgb(),
            Color.Red.ToArgb(),
            Color.DarkRed.ToArgb()
         };

      }

      public FractalViewer()
      {
         bHaveMouse = false;
         this.SetStyle(ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
      }


      protected override void OnPaint(PaintEventArgs pe)
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

      protected override void OnSizeChanged(EventArgs e)
      {
      
         if (_Bitmap == null)
            Render();
         else 
         {
            if (Width > _Bitmap.Width || Height > _Bitmap.Height)
               Render();
         }
      }

      public void SetDirty()
      {
         Render();
      }

      void Render()
      {
         Cursor.Current = Cursors.WaitCursor;

         if (_Bitmap != null)
         {
            _Bitmap.Dispose();
         }

         _Bitmap = new Bitmap(Width, Height, PixelFormat.Format32bppArgb);

         double increment = (double)ViewportWidth / (double)_Bitmap.Width;
         double left = Center.real - (_Bitmap.Width / 2) * increment;
         double row = Center.imaginary - (_Bitmap.Height / 2) * increment;

         int[] pixels = new int[_Bitmap.Width];

         Stopwatch sw = new Stopwatch();
         sw.Start();

         for (int y = 0; y < _Bitmap.Height; y++)
         {
            Generator.RenderRow(left, row, increment, MaxIterations, Palette, ref pixels);
            row += increment;

            for (int x = 0; x < _Bitmap.Width; x++)
            {
               _Bitmap.SetPixel(x,y, Color.FromArgb(pixels[x]));
            }
         }

         sw.Stop();
         Debug.WriteLine(sw.Elapsed);
         
         Invalidate();
         Cursor.Current = Cursors.Arrow;
      }

      #region TrackRectangle management
      bool bHaveMouse;
      Point ptLast = new Point();
      Point ptOriginal = new Point();

      protected override void OnMouseDown(MouseEventArgs e)
      {
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
         Render();
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

            Render();
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
   }
}
