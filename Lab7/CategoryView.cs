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
    public partial class CategoryView : Form
    {
        public CategoryView()
        {
            InitializeComponent();
        }

        public void getData()
        {
            string qry = "Select * from category where catName like '%"+txtSearch.Text+"%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);

            MainClass.LoadData(qry, guna2DataGridView1, lb);
        }

        public void frmTable_Load(object sender, EventArgs e)
        {
            getData();
        }
        

       
        public void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackGround(new CategoryAdd());
            // CategoryAdd frm = new CategoryAdd();
            //frm.ShowDialog();
            getData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            getData();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
            {
                CategoryAdd frm = new CategoryAdd();
                frm.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                frm.txtName.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvName"].Value);
                MainClass.BlurBackGround(frm);
                getData();
            }
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                DialogResult dialogResult = MessageBox.Show("Устгахдаа итгэлтэй байна уу", "Анхааруулга!", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                    string qry = "Delete from category where catID = " + id + "";
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
