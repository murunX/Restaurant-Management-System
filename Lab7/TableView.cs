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
    public partial class TableView : Form
    {
        public TableView()
        {
            InitializeComponent();
        }

        public void getData()
        {
            string qry = "Select * from tables where tname like '%" + txtSearch.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);

            MainClass.LoadData(qry, guna2DataGridView1, lb);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackGround(new TableAdd());
           // TableAdd frm = new TableAdd();
            //frm.ShowDialog();
            getData();
        }


       

        private void TableView_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            getData();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
            {
                TableAdd frm = new TableAdd();
                frm.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                frm.txtName.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvName"].Value);
                //frm.ShowDialog();
                MainClass.BlurBackGround(frm);
                getData();
            }
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                DialogResult dialogResult = MessageBox.Show("Устгахдаа итгэлтэй байна уу", "Анхааруулга!", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                    string qry = "Delete from tables where tid = " + id + "";
                    Hashtable ht = new Hashtable();
                    MainClass.SQL(qry, ht);

                    MessageBox.Show("Амжиллтай устгалаа");
                    getData();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }
    }
}
