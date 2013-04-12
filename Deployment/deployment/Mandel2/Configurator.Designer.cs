namespace DevelopMentor.Mandelbrot
{
   partial class Configurator
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
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.label1 = new System.Windows.Forms.Label();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.button1 = new System.Windows.Forms.Button();
         this.button2 = new System.Windows.Forms.Button();
         this.label2 = new System.Windows.Forms.Label();
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
// 
// groupBox1
// 
         this.groupBox1.Controls.Add(this.label2);
         this.groupBox1.Controls.Add(this.label1);
         this.groupBox1.Controls.Add(this.textBox1);
         this.groupBox1.Location = new System.Drawing.Point(13, 13);
         this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(239, 84);
         this.groupBox1.TabIndex = 0;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Settings";
// 
// label1
// 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(7, 22);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(82, 14);
         this.label1.TabIndex = 1;
         this.label1.Text = "Max Iterations:";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
// 
// textBox1
// 
         this.textBox1.Location = new System.Drawing.Point(176, 22);
         this.textBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(57, 20);
         this.textBox1.TabIndex = 0;
// 
// button1
// 
         this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.button1.Location = new System.Drawing.Point(176, 105);
         this.button1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
         this.button1.Name = "button1";
         this.button1.TabIndex = 1;
         this.button1.Text = "Cancel";
         this.button1.Click += new System.EventHandler(this.button1_Click);
// 
// button2
// 
         this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.button2.Location = new System.Drawing.Point(94, 105);
         this.button2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
         this.button2.Name = "button2";
         this.button2.TabIndex = 2;
         this.button2.Text = "OK";
         this.button2.Click += new System.EventHandler(this.button2_Click);
// 
// label2
// 
         this.label2.Location = new System.Drawing.Point(7, 44);
         this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(206, 29);
         this.label2.TabIndex = 2;
         this.label2.Text = "Maximum number of times to iterate over each point before giving up";
// 
// Configurator
// 
         this.ClientSize = new System.Drawing.Size(263, 137);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.groupBox1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Name = "Configurator";
         this.Text = "Configuration";
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.Label label2;
   }
}