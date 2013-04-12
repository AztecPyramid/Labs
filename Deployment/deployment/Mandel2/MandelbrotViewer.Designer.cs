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
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.button1 = new System.Windows.Forms.Button();
         this.fractalViewer1 = new DevelopMentor.Fractals.FractalViewer();
         this.SuspendLayout();
// 
// label1
// 
         this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                     | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.White;
         this.label1.Location = new System.Drawing.Point(22, 4);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(202, 24);
         this.label1.TabIndex = 1;
         this.label1.Text = "Mandelbrot version 2.0";
// 
// label2
// 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(22, 35);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(135, 14);
         this.label2.TabIndex = 2;
         this.label2.Text = "Click and Drag to Zoom In";
// 
// label3
// 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(22, 56);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(122, 14);
         this.label3.TabIndex = 3;
         this.label3.Text = "Right click to Zoom Out";
// 
// button1
// 
         this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.button1.ForeColor = System.Drawing.Color.Black;
         this.button1.Location = new System.Drawing.Point(475, 26);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(84, 23);
         this.button1.TabIndex = 4;
         this.button1.Text = "Configure...";
         this.button1.Click += new System.EventHandler(this.button1_Click);
// 
// fractalViewer1
// 
         this.fractalViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                     | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.fractalViewer1.Location = new System.Drawing.Point(22, 77);
         this.fractalViewer1.MaxIterations = 100;
         this.fractalViewer1.Name = "fractalViewer1";
         this.fractalViewer1.Size = new System.Drawing.Size(537, 434);
         this.fractalViewer1.TabIndex = 5;
         this.fractalViewer1.Text = "fractalViewer1";
         this.fractalViewer1.ViewportWidth = 3;
// 
// MandelbrotViewer
// 
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
         this.Controls.Add(this.fractalViewer1);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.ForeColor = System.Drawing.Color.White;
         this.Name = "MandelbrotViewer";
         this.Size = new System.Drawing.Size(581, 526);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Button button1;
      private DevelopMentor.Fractals.FractalViewer fractalViewer1;
   }
}
