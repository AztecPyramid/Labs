namespace DevelopMentor.Mandelbrot
{
   partial class MandelbrotViewer
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

      #region Component Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.label1 = new System.Windows.Forms.Label();
         this.button1 = new System.Windows.Forms.Button();
         this.panel1 = new System.Windows.Forms.Panel();
         this.asyncFractalViewer1 = new DevelopMentor.Fractals.AsyncFractalViewer();
         this.panel1.SuspendLayout();
         this.SuspendLayout();
// 
// label1
// 
         this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                     | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.label1.AutoSize = true;
         this.label1.BackColor = System.Drawing.Color.Transparent;
         this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(13, 12);
         this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(179, 18);
         this.label1.TabIndex = 1;
         this.label1.Text = "Mandelbrot version 3.0";
// 
// button1
// 
         this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.button1.Location = new System.Drawing.Point(519, 7);
         this.button1.Name = "button1";
         this.button1.TabIndex = 3;
         this.button1.Text = "Configure...";
         this.button1.Click += new System.EventHandler(this.button1_Click);
// 
// panel1
// 
         this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                     | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.panel1.Controls.Add(this.asyncFractalViewer1);
         this.panel1.Location = new System.Drawing.Point(13, 44);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(581, 457);
         this.panel1.TabIndex = 4;
// 
// asyncFractalViewer1
// 
         this.asyncFractalViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.asyncFractalViewer1.Location = new System.Drawing.Point(0, 0);
         this.asyncFractalViewer1.MaxIterations = 100;
         this.asyncFractalViewer1.Name = "asyncFractalViewer1";
         this.asyncFractalViewer1.Size = new System.Drawing.Size(577, 453);
         this.asyncFractalViewer1.TabIndex = 0;
         this.asyncFractalViewer1.Text = "asyncFractalViewer1";
         this.asyncFractalViewer1.ViewportWidth = 3;
// 
// MandelbrotViewer
// 
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.label1);
         this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
         this.Name = "MandelbrotViewer";
         this.Size = new System.Drawing.Size(600, 513);
         this.panel1.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Panel panel1;
      private DevelopMentor.Fractals.AsyncFractalViewer asyncFractalViewer1;
   }
}
