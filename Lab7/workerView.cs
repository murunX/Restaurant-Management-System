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
    public partial class workerView : Form
    {
        public workerView()
        {
            InitializeComponent();
        }
        public void getData()
        {
            string qry = "Select * from worker where wName like '%" + txtSearch.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvPhone);
            lb.Items.Add(dgvRole);


            MainClass.LoadData(qry, guna2DataGridView1, lb);
        }
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
            {
                workerAdd frm = new workerAdd();
                frm.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                frm.txtName.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvName"].Value);
                frm.txtPhone.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvPhone"].Value);
                frm.cbRole.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvRole"].Value);
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
                    string qry = "Delete from worker where wid = " + id + "";
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
            MainClass.BlurBackGround(new workerAdd());
            // TableAdd frm = new TableAdd();
            //frm.ShowDialog();
            getData();
        }

        private void workerView_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            getData();
        }
    }
}