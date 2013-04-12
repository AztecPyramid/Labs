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
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
// 
// groupBox1
// 
         this.groupBox1.Controls.Add(this.label1);
         this.groupBox1.Controls.Add(this.textBox1);
         this.groupBox1.Location = new System.Drawing.Point(13, 13);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(203, 65);
         this.groupBox1.TabIndex = 0;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Settings";
// 
// label1
// 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(18, 31);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(78, 14);
         this.label1.TabIndex = 1;
         this.label1.Text = "Max Iterations:";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
// 
// textBox1
// 
         this.textBox1.Location = new System.Drawing.Point(128, 29);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(57, 20);
         this.textBox1.TabIndex = 0;
// 
// button1
// 
         this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.button1.Location = new System.Drawing.Point(141, 98);
         this.button1.Name = "button1";
         this.button1.TabIndex = 1;
         this.button1.Text = "Cancel";
         this.button1.Click += new System.EventHandler(this.button1_Click);
// 
// button2
// 
         this.button2.Location = new System.Drawing.Point(59, 98);
         this.button2.Name = "button2";
         this.button2.TabIndex = 2;
         this.button2.Text = "OK";
         this.button2.Click += new System.EventHandler(this.button2_Click);
// 
// Configurator
// 
         this.AcceptButton = this.button2;
         this.CancelButton = this.button1;
         this.ClientSize = new System.Drawing.Size(243, 133);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.groupBox1);
         this.Name = "Configurator";
         this.Text = "Configurator";
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
   }
}