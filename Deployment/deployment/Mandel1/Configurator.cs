#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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