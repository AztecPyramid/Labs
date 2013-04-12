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
   public class BasicFractalViewer : Control
   {
      #region Fields and Properties
      Bitmap _Bitmap;
      Mandelbrot Generator = new Mandelbrot();
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

      static int[] Palette;

      static BasicFractalViewer() 
      {
         Palette = new int[]
         {
            Color.Black.ToArgb(),
            Color.Yellow.ToArgb(),
            Color.Blue.ToArgb(),
            Color.Red.ToArgb(),
         };
      }

      public BasicFractalViewer()
      {
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
            RenderInternal();
         else
         {
            if (Width > _Bitmap.Width || Height > _Bitmap.Height)
               RenderInternal();
         }
      }

      public void SetDirty()
      {
         RenderInternal();
      }

      public void SetPalette(int[] Palette)
      {
      }

      void RenderInternal()
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
               _Bitmap.SetPixel(x, y, Color.FromArgb(pixels[x]));
            }
         }

         sw.Stop();
         //Debug.WriteLine(sw.Elapsed);

         Invalidate();
         Cursor.Current = Cursors.Arrow;
      }


      
      protected override void  OnMouseDown(MouseEventArgs e)
      {
         if (MouseButtons == MouseButtons.Left)
            ZoomIn(FromPixel(e.Location));
         else if (MouseButtons == MouseButtons.Right)
            ZoomOut(FromPixel(e.Location));
      }

      private void ZoomIn(Complex center)
      {
         Center = center;
         ViewportWidth /= 2;
         RenderInternal();
      }

      private void ZoomOut(Complex center)
      {
         Center = center;
         ViewportWidth *= 2;
         RenderInternal();
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
   }
}
