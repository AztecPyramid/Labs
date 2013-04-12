#region Using directive

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Diagnostics;

#endregion

namespace DevelopMentor.Mandelbrot
{
   public partial class MandelbrotViewer : UserControl
   {
      public MandelbrotViewer()
      {
         InitializeComponent();
         SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
      }


      protected override void OnPaint(PaintEventArgs e)
      {
         
         using (LinearGradientBrush b = new LinearGradientBrush(
            new Point(ClientRectangle.Left, ClientRectangle.Top),
            new Point(ClientRectangle.Right, ClientRectangle.Bottom),
            Color.White, Color.Gray))
         {
            e.Graphics.FillRectangle(b, ClientRectangle);
         }
      }


      private void button1_Click(object sender, EventArgs e)
      {
         Configurator c = new Configurator();
         c.MaxIterations = this.asyncFractalViewer1.MaxIterations;
         if (c.ShowDialog() == DialogResult.OK)
         {
            asyncFractalViewer1.MaxIterations = c.MaxIterations;
            asyncFractalViewer1.SetDirty();
         }

      }
   }
}