using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace Lab7
{
    public partial class workerAdd : Form
    {
        public workerAdd()
        {
            InitializeComponent();
        }
        public int id = 0;
        private void workerAdd_Load(object sender, EventArgs e)
        {

        }

        public void saveBtn_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0)
            {
                qry = "Insert into worker Values(@name,@phone,@role)";
            }
            else
            {
                qry = "Update worker Set wName = @name , wPhone = @phone , wRole = @role where wID = @id";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);
            ht.Add("@Phone", txtPhone.Text);
            ht.Add("@role", cbRole.Text);
            if (MainClass.SQL(qry, ht) > 0)
            {
                MessageBox.Show("Амжиллтай хадгаллаа");
                id = 0;
                txtName.Text = "";
                txtPhone.Text = "";
                cbRole.SelectedIndex = -1;
                txtName.Focus();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
