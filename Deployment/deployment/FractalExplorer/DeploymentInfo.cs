#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

#endregion

namespace FractalExplorer
{
   partial class DeploymentInfo : Form
   {
      public DeploymentInfo()
      {

         InitializeComponent();

         foreach(AssemblyName name in GetType().Assembly.GetReferencedAssemblies())
         {
            int idx = comboBox1.Items.Add(name);
            if (name.Name == "DevelopMentor.Mandelbrot")
               comboBox1.SelectedItem = name;
         }
      }         

      private void button1_Click(object sender, EventArgs e)
      {
         Close();
      }

      string BuildString(byte[] bytes)
      {
         StringBuilder sb = new StringBuilder(32);
         foreach (byte b in bytes)
         {
            sb.Append(string.Format("{0:x}", b));
         }

         return sb.ToString();
      }

      private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
      {
         AssemblyName Expected = comboBox1.SelectedItem as AssemblyName;
         Assembly asm = Assembly.Load(Expected);
         AssemblyName Loaded = asm.GetName();

         dataGridView1.Rows.Clear();
         dataGridView1.Rows.Add("Name", Expected.Name, Loaded.Name);
         dataGridView1.Rows.Add("Version", Expected.Version.ToString(), Loaded.Version.ToString());
         dataGridView1.Rows.Add("Culture", Expected.CultureInfo.DisplayName, Loaded.CultureInfo.DisplayName);
         dataGridView1.Rows.Add("PublicKeyToken",
            (Expected.GetPublicKeyToken() == null) ? "null" : BuildString(Expected.GetPublicKeyToken()),
            (Loaded.GetPublicKeyToken() == null)   ? "null" : BuildString(Loaded.GetPublicKeyToken()));

         label3.Text = asm.CodeBase;
         label4.Text = asm.Location;
      }
   }
}