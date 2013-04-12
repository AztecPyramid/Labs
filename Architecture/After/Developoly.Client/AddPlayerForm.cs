using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Developoly.Client
{
	/// <summary>
	/// Summary description for AddPlayerForm.
	/// </summary>
	public class AddPlayerForm : System.Windows.Forms.Form
	{
		string[] currentPlayers; // used to check adding a unique name

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button BtnOK;
		private System.Windows.Forms.Button BtnCancel;
		private System.Windows.Forms.Label errorLabel;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AddPlayerForm(string[] players)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			this.currentPlayers = players;
			this.textBox1.Text = GetDefaultName();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.BtnOK = new System.Windows.Forms.Button();
			this.BtnCancel = new System.Windows.Forms.Button();
			this.errorLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(24, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Player Name";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(24, 32);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(240, 26);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "";
			this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
			// 
			// BtnOK
			// 
			this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.BtnOK.Location = new System.Drawing.Point(32, 104);
			this.BtnOK.Name = "BtnOK";
			this.BtnOK.Size = new System.Drawing.Size(96, 32);
			this.BtnOK.TabIndex = 2;
			this.BtnOK.Text = "OK";
			// 
			// BtnCancel
			// 
			this.BtnCancel.CausesValidation = false;
			this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.BtnCancel.Location = new System.Drawing.Point(168, 104);
			this.BtnCancel.Name = "BtnCancel";
			this.BtnCancel.Size = new System.Drawing.Size(96, 32);
			this.BtnCancel.TabIndex = 3;
			this.BtnCancel.Text = "Cancel";
			// 
			// errorLabel
			// 
			this.errorLabel.CausesValidation = false;
			this.errorLabel.ForeColor = System.Drawing.Color.Red;
			this.errorLabel.Location = new System.Drawing.Point(32, 72);
			this.errorLabel.Name = "errorLabel";
			this.errorLabel.Size = new System.Drawing.Size(240, 23);
			this.errorLabel.TabIndex = 4;
			this.errorLabel.Text = "The player name must be unique.";
			this.errorLabel.Visible = false;
			// 
			// AddPlayerForm
			// 
			this.AcceptButton = this.BtnOK;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.BtnCancel;
			this.CausesValidation = false;
			this.ClientSize = new System.Drawing.Size(292, 166);
			this.Controls.Add(this.errorLabel);
			this.Controls.Add(this.BtnCancel);
			this.Controls.Add(this.BtnOK);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddPlayerForm";
			this.Text = "AddPlayer";
			this.ResumeLayout(false);

		}
		#endregion


		public string PlayerName
		{
			get{return this.textBox1.Text;}
		}

		private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			// the player name must be unique
			if(IsNamePresent(this.textBox1.Text))
			{
				this.errorLabel.Visible = true;
				e.Cancel = true;
			}
		}

		private bool IsNamePresent(string name)
		{
			return (Array.IndexOf(this.currentPlayers, name) >=0 );
		}
		
		private string GetDefaultName()
		{
			int i =0;
			string p = "Player";
			string s;
			while(true)
			{
				i++;
				s = p+i;
				if( ! IsNamePresent(s))
				{
					break;
				}
			}
			return s;
		}
	}
}
