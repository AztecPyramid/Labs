using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Developoly.Common;


namespace Developoly.Client
{
	/// <summary>
	/// Summary description for ResultForm.
	/// </summary>
	public class ResultForm : System.Windows.Forms.Form
	{
		IGame gameObj;
		private int _chanceId = 0;
		private int _CCId = 0;

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblPosition;
		private System.Windows.Forms.Label lblCredit;
		private System.Windows.Forms.Label lblDebit;
		private System.Windows.Forms.Button btnPurchase;
		private System.Windows.Forms.Button BtnChance;
		private System.Windows.Forms.Button BtnCC;
		private System.Windows.Forms.Label lblConsequence;
		private System.Windows.Forms.Button BtnOk;
		private System.Windows.Forms.CheckBox checkBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ResultForm(IGame game)
		{
			this.gameObj = game;
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblPosition = new System.Windows.Forms.Label();
			this.lblCredit = new System.Windows.Forms.Label();
			this.lblDebit = new System.Windows.Forms.Label();
			this.btnPurchase = new System.Windows.Forms.Button();
			this.BtnChance = new System.Windows.Forms.Button();
			this.BtnCC = new System.Windows.Forms.Button();
			this.lblConsequence = new System.Windows.Forms.Label();
			this.BtnOk = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Player landed on:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(124, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "Player receives:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(136, 32);
			this.label3.TabIndex = 2;
			this.label3.Text = "Player must pay:";
			// 
			// lblPosition
			// 
			this.lblPosition.Location = new System.Drawing.Point(168, 16);
			this.lblPosition.Name = "lblPosition";
			this.lblPosition.Size = new System.Drawing.Size(184, 24);
			this.lblPosition.TabIndex = 3;
			this.lblPosition.Text = "Position";
			// 
			// lblCredit
			// 
			this.lblCredit.Location = new System.Drawing.Point(168, 48);
			this.lblCredit.Name = "lblCredit";
			this.lblCredit.Size = new System.Drawing.Size(184, 24);
			this.lblCredit.TabIndex = 5;
			this.lblCredit.Text = "Credit";
			// 
			// lblDebit
			// 
			this.lblDebit.Location = new System.Drawing.Point(168, 80);
			this.lblDebit.Name = "lblDebit";
			this.lblDebit.Size = new System.Drawing.Size(184, 24);
			this.lblDebit.TabIndex = 6;
			this.lblDebit.Text = "Debit";
			// 
			// btnPurchase
			// 
			this.btnPurchase.Location = new System.Drawing.Point(472, 16);
			this.btnPurchase.Name = "btnPurchase";
			this.btnPurchase.Size = new System.Drawing.Size(168, 32);
			this.btnPurchase.TabIndex = 3;
			this.btnPurchase.Text = "Purchase";
			this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
			// 
			// BtnChance
			// 
			this.BtnChance.Location = new System.Drawing.Point(16, 128);
			this.BtnChance.Name = "BtnChance";
			this.BtnChance.Size = new System.Drawing.Size(152, 32);
			this.BtnChance.TabIndex = 1;
			this.BtnChance.Text = "Chance";
			this.BtnChance.Click += new System.EventHandler(this.BtnChance_Click);
			// 
			// BtnCC
			// 
			this.BtnCC.Location = new System.Drawing.Point(16, 176);
			this.BtnCC.Name = "BtnCC";
			this.BtnCC.Size = new System.Drawing.Size(152, 32);
			this.BtnCC.TabIndex = 2;
			this.BtnCC.Text = "Community Chest";
			this.BtnCC.Click += new System.EventHandler(this.BtnCC_Click);
			// 
			// lblConsequence
			// 
			this.lblConsequence.BackColor = System.Drawing.Color.SandyBrown;
			this.lblConsequence.Location = new System.Drawing.Point(184, 128);
			this.lblConsequence.Name = "lblConsequence";
			this.lblConsequence.Size = new System.Drawing.Size(456, 80);
			this.lblConsequence.TabIndex = 10;
			this.lblConsequence.Text = "Consequence";
			// 
			// BtnOk
			// 
			this.BtnOk.Location = new System.Drawing.Point(256, 248);
			this.BtnOk.Name = "BtnOk";
			this.BtnOk.Size = new System.Drawing.Size(136, 32);
			this.BtnOk.TabIndex = 0;
			this.BtnOk.Text = "OK";
			this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(16, 224);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(112, 32);
			this.checkBox1.TabIndex = 12;
			this.checkBox1.TabStop = false;
			this.checkBox1.Text = "ReThrow";
			// 
			// ResultForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
			this.ClientSize = new System.Drawing.Size(656, 316);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.BtnOk);
			this.Controls.Add(this.lblConsequence);
			this.Controls.Add(this.BtnCC);
			this.Controls.Add(this.BtnChance);
			this.Controls.Add(this.btnPurchase);
			this.Controls.Add(this.lblDebit);
			this.Controls.Add(this.lblCredit);
			this.Controls.Add(this.lblPosition);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "ResultForm";
			this.Text = "ThrowResult";
			this.ResumeLayout(false);

		}
		#endregion

		protected  override void  OnLoad(System.EventArgs e)
		{
			btnPurchase.Enabled = false;
			BtnChance.Enabled = false;
			BtnCC.Enabled = false;

			_chanceId = 0;
			_CCId = 0;

			GameMessage consequence = this.gameObj.GetConsequence();

			lblCredit.Text = "";
			lblDebit.Text = "";
			lblConsequence.Text = "";
			lblPosition.Text = this.gameObj.Board.Rows[consequence.position]["property"].ToString();

			switch ((GameEnum)consequence.opCode)
			{
				case GameEnum.goToJail:
					lblConsequence.Text  = "Go to Jail!!";
					break;
				case GameEnum.chance:
					lblConsequence.Text = "You have landed on chance, please select";
					BtnChance.Enabled = true;
					break;
				case GameEnum.communityChest :
					lblConsequence.Text = "You have landed on CommunityChest, please select";
					BtnCC.Enabled = true;
					break;
				case GameEnum.pay:
					lblDebit.Text = string.Format("{0}", consequence.amount.ToString() );
					break;
				case GameEnum.collect :
					lblCredit.Text = string.Format("{0}", consequence.amount.ToString());
					break;
				case GameEnum.freeParking:
					break;
				case GameEnum.purchaseProperty:
					if (consequence.propertyId > 0)
					{
						btnPurchase.Enabled = true;
					}
					break;
			}
		}
		private void btnPurchase_Click(object sender, System.EventArgs e)
		{
			GameMessage consequence = this.gameObj.GetConsequence();
			this.gameObj.Consequence( consequence );
			btnPurchase.Enabled = false;
			if (consequence.opCode == GameEnum.insufficientFunds)
			{
				MessageBox.Show("Insufficient funds to purchase property");
			}
			else
			{
				if (consequence.opCode == GameEnum.fail)
				{
					MessageBox.Show("Property already purchased by another player");
				}
			}
		}

		private void BtnChance_Click(object sender, System.EventArgs e)
		{
			DataRow chance = this.gameObj.Chance;
			lblConsequence.Text = chance["instruction"].ToString();
			_chanceId = (int)chance["id"];
			BtnChance.Enabled = false;
		}

		private void BtnCC_Click(object sender, System.EventArgs e)
		{
			DataRow communityChest = this.gameObj.CommunityChest;
			lblConsequence.Text = communityChest["instruction"].ToString();
			_CCId = (int)communityChest["id"];
			BtnCC.Enabled = false;
		}

		private void BtnOk_Click(object sender, System.EventArgs e)
		{
			GameMessage consequence = this.gameObj.GetConsequence();
			if (consequence.opCode != GameEnum.success && btnPurchase.Enabled == false)
			{
				consequence.chanceId = _chanceId;
				consequence.communityChestId = _CCId;
				this.gameObj.Consequence( consequence );
			}
			Close();
		}

	}
}
