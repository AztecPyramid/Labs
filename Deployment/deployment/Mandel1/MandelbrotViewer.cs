#region Using directive

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

#endregion

namespace DevelopMentor.Mandelbrot
{
   public partial class MandelbrotViewer : UserControl
   {
      public MandelbrotViewer()
      {
         InitializeComponent();
      }

      private void button1_Click(object sender, EventArgs e)
      {
               
      }

      private void configureButton_Click(object sender, EventArgs e)
      {
         Configurator c = new Configurator();
         c.MaxIterations = this.basicFractalViewer1.MaxIterations;
         if (c.ShowDialog() == DialogResult.OK)
         {
            basicFractalViewer1.MaxIterations = c.MaxIterations;
            basicFractalViewer1.SetDirty();
         }
      }
   }
}