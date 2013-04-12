using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PetShopClient.PetShopBackEnd;
using System.ServiceModel;

namespace PetShopClient
{
    public partial class Main : Form
    {
        PetShopServiceContractClient proxy = new PetShopServiceContractClient();

        public Main()
        {
            InitializeComponent();

            proxy.Open();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (proxy.State != CommunicationState.Closed)
                {
                    proxy.Close();
                }
            }
            catch
            {
                proxy.Abort();
            }
        }

        private void UpdateStatus()
        {
            AccountBalance balance = proxy.GetAccountBalance();
            Inventory inventory = proxy.GetInventory();

            _lblBalance.Text = balance.Balance.ToString();

            _cmbAnimals.Items.Clear();
            _grdInventory.Rows.Clear();

            foreach (KeyValuePair<string, AnimalDetails> entry in inventory.Items)
            {
                _cmbAnimals.Items.Add(entry.Key);
                _grdInventory.Rows.Add(entry.Key, entry.Value.InStock, entry.Value.Price);
            }

            _cmbAnimals.SelectedIndex = 0;
        }

        private void _btnOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.ProductName = _cmbAnimals.SelectedItem.ToString();
            order.Quantity = (int)_udQuantity.Value;

            try
            {
                proxy.PlaceOrder(order);
                MessageBox.Show("Thanks for your order", "DM PetShop");
            }
            catch (FaultException<OrderFault> ex)
            {
                MessageBox.Show(ex.Detail.Description, ex.Reason.ToString());
            }
            
            UpdateStatus();
        }
    }
}