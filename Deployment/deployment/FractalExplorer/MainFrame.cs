#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
#endregion

namespace FractalExplorer
{
   public partial class MainFrame : Form
   {
      public MainFrame()
      {
         InitializeComponent();
      }
 
	   private void newToolStripMenuItem_Click(object sender, EventArgs e)
	   {
		   MDIChild child = new MDIChild();
		   child.MdiParent = this;
		   child.Show();
	   }

	   private void deploymentInfoToolStripMenuItem_Click(object sender, EventArgs e)
	   {
		   DeploymentInfo info = new DeploymentInfo();
		   info.ShowDialog();
	   }

	   private void exitToolStripMenuItem_Click(object sender, EventArgs e)
	   {
		   Close();
	   }
   }
}