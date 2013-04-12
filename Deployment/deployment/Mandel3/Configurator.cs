#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

#endregion

namespace DevelopMentor.Mandelbrot
{
   partial class Configurator : Form
   {

      public int MaxIterations
      {
         get { return int.Parse(textBox1.Text); }
         set { textBox1.Text = value.ToString(); }
      }

      public Configurator()
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

      private void button2_Click(object sender, EventArgs e)
      {
         DialogResult = DialogResult.OK;
         Close();
      }

      private void button1_Click(object sender, EventArgs e)
      {
         DialogResult = DialogResult.Cancel;
         Close();
      }
   }
}