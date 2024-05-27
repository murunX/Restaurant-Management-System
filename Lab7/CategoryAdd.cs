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
    public partial class CategoryAdd : Form
    {
        public CategoryAdd()
        {
            InitializeComponent();
        }
        public int id = 0;
        private void frmTableAdd_Load(object sender, EventArgs e)
        {

        }

        public void saveBtn_Click(object sender, EventArgs e)
        {
            string qry = "";
            
            if(id == 0)
            {
                qry = "Insert into category Values(@Name)";
            }
            else
            {
                qry = "Update category Set catName = @Name where catID = @id";
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
