using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Checkout : Form
    {
        public Checkout()
        {
            InitializeComponent();
        }

        public double amt;
        public int MainID = 0;
        private void Checkout_Load(object sender, EventArgs e)
        {
            txtBillAmount.Text = amt.ToString();
        }

        private void txtRecieved_TextChanged(object sender, EventArgs e)
        {
            double amt = 0;
            double receipt = 0;
            double change = 0;

            double.TryParse(txtBillAmount.Text, out amt);
            double.TryParse(txtRecieved.Text, out receipt);

            change = Math.Abs( amt - receipt);

            txtChange.Text = change.ToString();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string qry = @"Update tblMain set total=@total, received=@rec,change=@change, status='Төлсөн' where MainID=@id ";
            Hashtable ht = new Hashtable();
            ht.Add("@id", MainID);
            ht.Add("@total", txtBillAmount.Text);
            ht.Add("@rec", txtRecieved.Text);
            ht.Add("@change", txtChange.Text);

            if (MainClass.SQL(qry, ht) > 0)
            {
                MessageBox.Show("Амжиллтай");
                this.Close(); 
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
