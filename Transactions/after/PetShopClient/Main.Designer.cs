namespace PetShopClient
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.label1 = new System.Windows.Forms.Label();
            this._lblBalance = new System.Windows.Forms.Label();
            this._grdInventory = new System.Windows.Forms.DataGridView();
            this._cmbAnimals = new System.Windows.Forms.ComboBox();
            this._udQuantity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._btnOrder = new System.Windows.Forms.Button();
            this.Animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._grdInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._udQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Balance:";
            // 
            // _lblBalance
            // 
            this._lblBalance.AutoSize = true;
            this._lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblBalance.Location = new System.Drawing.Point(127, 9);
            this._lblBalance.Name = "_lblBalance";
            this._lblBalance.Size = new System.Drawing.Size(27, 20);
            this._lblBalance.TabIndex = 1;
            this._lblBalance.Text = "__";
            // 
            // _grdInventory
            // 
            this._grdInventory.AllowUserToAddRows = false;
            this._grdInventory.AllowUserToDeleteRows = false;
            this._grdInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._grdInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Animal,
            this.InStock,
            this.Price});
            this._grdInventory.Location = new System.Drawing.Point(12, 114);
            this._grdInventory.Name = "_grdInventory";
            this._grdInventory.ReadOnly = true;
            this._grdInventory.Size = new System.Drawing.Size(303, 84);
            this._grdInventory.TabIndex = 2;
            // 
            // _cmbAnimals
            // 
            this._cmbAnimals.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbAnimals.FormattingEnabled = true;
            this._cmbAnimals.Location = new System.Drawing.Point(16, 70);
            this._cmbAnimals.Name = "_cmbAnimals";
            this._cmbAnimals.Size = new System.Drawing.Size(138, 21);
            this._cmbAnimals.TabIndex = 3;
            // 
            // _udQuantity
            // 
            this._udQuantity.Location = new System.Drawing.Point(174, 70);
            this._udQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._udQuantity.Name = "_udQuantity";
            this._udQuantity.Size = new System.Drawing.Size(49, 20);
            this._udQuantity.TabIndex = 4;
            this._udQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Animal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantity";
            // 
            // _btnOrder
            // 
            this._btnOrder.Location = new System.Drawing.Point(240, 67);
            this._btnOrder.Name = "_btnOrder";
            this._btnOrder.Size = new System.Drawing.Size(75, 23);
            this._btnOrder.TabIndex = 7;
            this._btnOrder.Text = "Order";
            this._btnOrder.UseVisualStyleBackColor = true;
            this._btnOrder.Click += new System.EventHandler(this._btnOrder_Click);
            // 
            // Animal
            // 
            this.Animal.HeaderText = "Animal";
            this.Animal.Name = "Animal";
            this.Animal.ReadOnly = true;
            // 
            // InStock
            // 
            this.InStock.HeaderText = "In Stock";
            this.InStock.Name = "InStock";
            this.InStock.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 220);
            this.Controls.Add(this._btnOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._udQuantity);
            this.Controls.Add(this._cmbAnimals);
            this.Controls.Add(this._grdInventory);
            this.Controls.Add(this._lblBalance);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "PetShop Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this._grdInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._udQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _lblBalance;
        private System.Windows.Forms.DataGridView _grdInventory;
        private System.Windows.Forms.ComboBox _cmbAnimals;
        private System.Windows.Forms.NumericUpDown _udQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button _btnOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn InStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}

