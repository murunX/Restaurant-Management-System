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
    public partial class ProductView : Form
    {
        public ProductView()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void getData()
        {
            string qry = "select pID , pName , pPrice,CategoryID, c.catName from product p inner join category c on c.catID = p.CategoryID where pName like '%" + txtSearch.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvPrice);
            lb.Items.Add(dgvcatId);
            lb.Items.Add(dgvcat);


            MainClass.LoadData(qry, guna2DataGridView1, lb);
        }
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
            {
                ProductAdd frm = new ProductAdd();
                frm.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                frm.cID = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvcatID"].Value);
                
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
                    string qry = "Delete from product where pid = " + id + "";
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackGround(new ProductAdd());
            // TableAdd frm = new TableAdd();
            //frm.ShowDialog();
            getData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            getData();
        }

        private void ProductView_Load(object sender, EventArgs e)
        {
            getData();
        }
    }
}
