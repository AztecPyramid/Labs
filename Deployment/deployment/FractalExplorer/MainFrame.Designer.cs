namespace FractalExplorer
{
   partial class MainFrame
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
		  this.menuStrip1 = new System.Windows.Forms.MenuStrip();
		  this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		  this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		  this.deploymentInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		  this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		  this.menuStrip1.SuspendLayout();
		  this.SuspendLayout();
		  // 
		  // menuStrip1
		  // 
		  this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
		  this.menuStrip1.Location = new System.Drawing.Point(0, 0);
		  this.menuStrip1.Name = "menuStrip1";
		  this.menuStrip1.Size = new System.Drawing.Size(954, 24);
		  this.menuStrip1.TabIndex = 5;
		  this.menuStrip1.Text = "menuStrip1";
		  // 
		  // fileToolStripMenuItem
		  // 
		  this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.deploymentInfoToolStripMenuItem,
            this.exitToolStripMenuItem});
		  this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
		  this.fileToolStripMenuItem.Text = "&File";
		  // 
		  // newToolStripMenuItem
		  // 
		  this.newToolStripMenuItem.Name = "newToolStripMenuItem";
		  this.newToolStripMenuItem.Text = "&New";
		  this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
		  // 
		  // deploymentInfoToolStripMenuItem
		  // 
		  this.deploymentInfoToolStripMenuItem.Name = "deploymentInfoToolStripMenuItem";
		  this.deploymentInfoToolStripMenuItem.Text = "&Deployment Info ...";
		  this.deploymentInfoToolStripMenuItem.Click += new System.EventHandler(this.deploymentInfoToolStripMenuItem_Click);
		  // 
		  // exitToolStripMenuItem
		  // 
		  this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
		  this.exitToolStripMenuItem.Text = "E&xit";
		  this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
		  // 
		  // MainFrame
		  // 
		  this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
		  this.ClientSize = new System.Drawing.Size(954, 676);
		  this.Controls.Add(this.menuStrip1);
		  this.IsMdiContainer = true;
		  this.MainMenuStrip = this.menuStrip1;
		  this.Name = "MainFrame";
		  this.Text = "FractalExplorer";
		  this.menuStrip1.ResumeLayout(false);
		  this.ResumeLayout(false);
		  this.PerformLayout();

      }

      #endregion

	   private System.Windows.Forms.MenuStrip menuStrip1;
	   private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
	   private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
	   private System.Windows.Forms.ToolStripMenuItem deploymentInfoToolStripMenuItem;
	   private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

  }
}

