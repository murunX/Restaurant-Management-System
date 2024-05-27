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
    public partial class TableAdd : Form
    {
        public TableAdd()
        {
            InitializeComponent();
        }
        public int id = 0;
        private void TableAdd_Load(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0)
            {
                qry = "Insert into tables Values(@Name)";
            }
            else
            {
                qry = "Update tables Set tname = @Name where tid = @id";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);
            if (MainClass.SQL(qry, ht) > 0)
            {
                MessageBox.Show("Амжиллтай хадгаллаа");
                id = 0;
                txtName.Text = "";
                txtName.Focus();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
