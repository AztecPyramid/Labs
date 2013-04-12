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
	/// Summary description for Form1.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		IGame gameObj;

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button BtnAddPlayer;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ListBox listPlayers;
		private System.Windows.Forms.Button BtnStart;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button BtnThrow;
		private System.Windows.Forms.Label lblCash;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ListBox lstProperties;
		private System.Windows.Forms.GroupBox GrpPlayer;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public MainForm(IGame gameObj)
		{
			this.gameObj = gameObj;
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.BtnStart = new System.Windows.Forms.Button();
			this.listPlayers = new System.Windows.Forms.ListBox();
			this.label5 = new System.Windows.Forms.Label();
			this.BtnAddPlayer = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.BtnThrow = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.GrpPlayer = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.lstProperties = new System.Windows.Forms.ListBox();
			this.label6 = new System.Windows.Forms.Label();
			this.lblCash = new System.Windows.Forms.Label();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.GrpPlayer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.BtnStart);
			this.groupBox1.Controls.Add(this.listPlayers);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.BtnAddPlayer);
			this.groupBox1.Location = new System.Drawing.Point(16, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(192, 320);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Game";
			// 
			// BtnStart
			// 
			this.BtnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.BtnStart.Location = new System.Drawing.Point(16, 264);
			this.BtnStart.Name = "BtnStart";
			this.BtnStart.Size = new System.Drawing.Size(160, 32);
			this.BtnStart.TabIndex = 1;
			this.BtnStart.Text = "Start";
			this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
			// 
			// listPlayers
			// 
			this.listPlayers.Location = new System.Drawing.Point(16, 104);
			this.listPlayers.Name = "listPlayers";
			this.listPlayers.Size = new System.Drawing.Size(160, 134);
			this.listPlayers.TabIndex = 6;
			this.listPlayers.SelectedIndexChanged += new System.EventHandler(this.listPlayers_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(16, 72);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(120, 16);
			this.label5.TabIndex = 5;
			this.label5.Text = "Players";
			// 
			// BtnAddPlayer
			// 
			this.BtnAddPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.BtnAddPlayer.Location = new System.Drawing.Point(16, 32);
			this.BtnAddPlayer.Name = "BtnAddPlayer";
			this.BtnAddPlayer.Size = new System.Drawing.Size(160, 32);
			this.BtnAddPlayer.TabIndex = 0;
			this.BtnAddPlayer.Text = "Add Player";
			this.BtnAddPlayer.Click += new System.EventHandler(this.BtnAddPlayer_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.BtnThrow);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(280, 24);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(280, 128);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Total";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.Location = new System.Drawing.Point(168, 32);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(16, 23);
			this.label8.TabIndex = 4;
			this.label8.Text = "=";
			// 
			// BtnThrow
			// 
			this.BtnThrow.Enabled = false;
			this.BtnThrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.BtnThrow.Location = new System.Drawing.Point(72, 80);
			this.BtnThrow.Name = "BtnThrow";
			this.BtnThrow.Size = new System.Drawing.Size(120, 24);
			this.BtnThrow.TabIndex = 0;
			this.BtnThrow.Text = "Throw";
			this.BtnThrow.Click += new System.EventHandler(this.BtnThrow_Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(200, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Total";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(96, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Dice 2";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(24, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Dice 1";
			// 
			// GrpPlayer
			// 
			this.GrpPlayer.Controls.Add(this.label7);
			this.GrpPlayer.Controls.Add(this.lstProperties);
			this.GrpPlayer.Controls.Add(this.label6);
			this.GrpPlayer.Controls.Add(this.lblCash);
			this.GrpPlayer.Location = new System.Drawing.Point(280, 152);
			this.GrpPlayer.Name = "GrpPlayer";
			this.GrpPlayer.Size = new System.Drawing.Size(280, 184);
			this.GrpPlayer.TabIndex = 2;
			this.GrpPlayer.TabStop = false;
			this.GrpPlayer.Text = "Player";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 40);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(48, 23);
			this.label7.TabIndex = 3;
			this.label7.Text = "Money:";
			// 
			// lstProperties
			// 
			this.lstProperties.Location = new System.Drawing.Point(120, 40);
			this.lstProperties.Name = "lstProperties";
			this.lstProperties.Size = new System.Drawing.Size(152, 134);
			this.lstProperties.TabIndex = 2;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(120, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(152, 24);
			this.label6.TabIndex = 1;
			this.label6.Text = "Properties";
			// 
			// lblCash
			// 
			this.lblCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblCash.Location = new System.Drawing.Point(8, 64);
			this.lblCash.Name = "lblCash";
			this.lblCash.Size = new System.Drawing.Size(88, 24);
			this.lblCash.TabIndex = 0;
			this.lblCash.Text = "0";
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(16, 376);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(544, 176);
			this.dataGrid1.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(16, 352);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 16);
			this.label4.TabIndex = 4;
			this.label4.Text = "Board";
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(576, 572);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dataGrid1);
			this.Controls.Add(this.GrpPlayer);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "Developoly";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.GrpPlayer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);
		}
		#endregion

		private void BtnAddPlayer_Click(object sender, System.EventArgs e)
		{
			if( AddPlayer() )
			{
				UpdatePlayerList();
			}
		}

		private bool AddPlayer()
		{
			AddPlayerForm frmAddPlayer = new AddPlayerForm(this.gameObj.PlayerNames);
			DialogResult r = frmAddPlayer.ShowDialog();
			bool isPlayer=false;
			if(DialogResult.OK == r)
			{
				isPlayer = this.gameObj.AddPlayer(frmAddPlayer.PlayerName);
			}
			return isPlayer;
		}

		private void UpdatePlayerList()
		{
			listPlayers.DataSource = this.gameObj.Players;
			if(listPlayers.SelectedIndex > 0)
				listPlayers.SelectedIndex = 0;
		}

		private void BtnStart_Click(object sender, System.EventArgs e)
		{
			dataGrid1.DataSource = this.gameObj.Board;
			this.BtnAddPlayer.Enabled = false;
			this.BtnStart.Enabled = false;
			this.BtnThrow.Enabled = true;
			this.BtnThrow.Focus();
		}

		private void listPlayers_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			ShowPlayer(listPlayers.SelectedItem.ToString());
		}

		private void ShowPlayer(string playerName)
		{
			if( (null != playerName ) && (string.Empty != playerName))
			{
				Player selectedPlayer = this.gameObj.GetPlayer(playerName);
				GrpPlayer.Text = string.Format("Player: {0}", selectedPlayer.Name );
				lblCash.Text = string.Format("{0}", selectedPlayer.Money.ToString() );
				lstProperties.Items.Clear();
				foreach (int propertyId in selectedPlayer.Properties)
				{
					lstProperties.Items.Add( this.gameObj.Board.Rows[propertyId]["property"].ToString().Trim() );
				}
                if (this.dataGrid1.DataSource != null)
                {
                    this.dataGrid1.CurrentRowIndex = selectedPlayer.Position;
                }

			}
		}

		private void BtnThrow_Click(object sender, System.EventArgs e)
		{
			int[] dice = RollDice();
			ShowDice( dice );
			AdvancePlayer(dice);
		}

		private int[] RollDice()
		{
			// Thow dice
			int numberOfDice = 2;
			int[] dice = new int[numberOfDice];

			Random rnd = new Random();
			dice[0] = rnd.Next(1,6);
			dice[1] = rnd.Next(1,6);
			return dice;
		}

		private void ShowDice(int[] dice)
		{
			label1.Text = System.Convert.ToString(dice[0]);
			label2.Text =  System.Convert.ToString(dice[1]);

			int total = dice[0] + dice[1];
			label3.Text =  System.Convert.ToString(total);
		}

		private void AdvancePlayer(int[] dice)
		{
			// For the selected player in players list throw dice and advance (or not)
			if (listPlayers.SelectedIndex > -1)
			{
				string playerName = listPlayers.SelectedItem.ToString();
				int total = dice[0]+dice[1];

				this.gameObj.Advance( playerName, total);
				ResultForm results = new ResultForm(this.gameObj);
				results.ShowDialog();

				ShowPlayer(playerName);
			}
		}
	}
}
