namespace FractalExplorer
{
   partial class MDIChild
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
         this.mandelbrotViewer1 = new DevelopMentor.Mandelbrot.MandelbrotViewer();
         this.SuspendLayout();
// 
// mandelbrotViewer1
// 
         this.mandelbrotViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.mandelbrotViewer1.Location = new System.Drawing.Point(0, 0);
         this.mandelbrotViewer1.Name = "mandelbrotViewer1";
         this.mandelbrotViewer1.Size = new System.Drawing.Size(587, 595);
         this.mandelbrotViewer1.TabIndex = 0;
// 
// MDIChild
// 
         this.ClientSize = new System.Drawing.Size(587, 595);
         this.Controls.Add(this.mandelbrotViewer1);
         this.Name = "MDIChild";
         this.Text = "MDIChild";
         this.ResumeLayout(false);

      }

      #endregion

      private DevelopMentor.Mandelbrot.MandelbrotViewer mandelbrotViewer1;









   }
}