#region Using directives

using System;
using System.Xml;
using System.Xml.Serialization;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using Complex = Neocranium.Fractals.ComplexDouble;

#endregion

namespace Neocranium.Fractals
{
   /// <remarks>
   /// This class renders a mandelbrot into a fractal. Every 250msec
   /// it fires a progress event.  If you want to access the bitmap
   /// while rendering call Pause, do your stuff, then call Resume
   /// </remarks>
   public class Mandelbrot
   {
      #region Palette stuff


      #endregion

      #region Rendering
      public void RenderRow(double real, double imaginary, double realIncrement, int MaxIterations, int[] Palette, ref int[] pixels)
      {
         for (int x = 0; x < pixels.Length; x++)
         {
            Complex z = new Complex(0, 0);
            Complex c = new Complex(real + x * realIncrement, imaginary);

            int reps = 1;
            do
            {
               z.SquareAndAdd(c);
               reps++;

            } while (reps <= MaxIterations && z.GetSquaredModulus() < 4.0f);

            if (reps < MaxIterations)
            {
               pixels[x] = Palette[(reps % Palette.Length - 1) + 1];
            }
            else
            {
               pixels[x] = Palette[0];
            }

         }
      }
      #endregion
   }
}
