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
          this.configureButton = new System.Windows.Forms.Button();
          this.basicFractalViewer1 = new DevelopMentor.Fractals.BasicFractalViewer();
          this.SuspendLayout();
          // 
          // label1
          // 
          this.label1.AutoSize = true;
          this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.label1.Location = new System.Drawing.Point(18, 12);
          this.label1.Name = "label1";
          this.label1.Size = new System.Drawing.Size(111, 13);
          this.label1.TabIndex = 1;
          this.label1.Text = "Mandelbrot version 1.0";
          // 
          // label2
          // 
          this.label2.AutoSize = true;
          this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.label2.Location = new System.Drawing.Point(18, 33);
          this.label2.Name = "label2";
          this.label2.Size = new System.Drawing.Size(100, 13);
          this.label2.TabIndex = 2;
          this.label2.Text = "Left click to Zoom In";
          // 
          // label3
          // 
          this.label3.AutoSize = true;
          this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.label3.Location = new System.Drawing.Point(18, 52);
          this.label3.Name = "label3";
          this.label3.Size = new System.Drawing.Size(116, 13);
          this.label3.TabIndex = 3;
          this.label3.Text = "Right Click to Zoom Out";
          // 
          // configureButton
          // 
          this.configureButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
          this.configureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.configureButton.Location = new System.Drawing.Point(473, 33);
          this.configureButton.Name = "configureButton";
          this.configureButton.Size = new System.Drawing.Size(86, 23);
          this.configureButton.TabIndex = 4;
          this.configureButton.Text = "Configure...";
          this.configureButton.Click += new System.EventHandler(this.configureButton_Click);
          // 
          // basicFractalViewer1
          // 
          this.basicFractalViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Left)
                      | System.Windows.Forms.AnchorStyles.Right)));
          this.basicFractalViewer1.Location = new System.Drawing.Point(13, 73);
          this.basicFractalViewer1.MaxIterations = 100;
          this.basicFractalViewer1.Name = "basicFractalViewer1";
          this.basicFractalViewer1.Size = new System.Drawing.Size(546, 272);
          this.basicFractalViewer1.TabIndex = 0;
          this.basicFractalViewer1.Text = "basicFractalViewer1";
          this.basicFractalViewer1.ViewportWidth = 3;
          // 
          // MandelbrotViewer
          // 
          this.Controls.Add(this.configureButton);
          this.Controls.Add(this.label3);
          this.Controls.Add(this.label2);
          this.Controls.Add(this.label1);
          this.Controls.Add(this.basicFractalViewer1);
          this.Font = new System.Drawing.Font("Mangal", 8F);
          this.Name = "MandelbrotViewer";
          this.Size = new System.Drawing.Size(576, 360);
          this.ResumeLayout(false);
          this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label2;
       private System.Windows.Forms.Button configureButton;
       private DevelopMentor.Fractals.BasicFractalViewer basicFractalViewer1;
   }
}
