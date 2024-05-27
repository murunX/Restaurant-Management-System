using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class POS : Form
    {
        public POS()
        {
            InitializeComponent();
        }

        public int MainID = 0;
        public string OrderType;
        public int detailID = 0 ;
        private void POS_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.BorderStyle = BorderStyle.FixedSingle;
            AddCategory();

            ProductPanel.Controls.Clear();
            LoadProducts();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddCategory()
        {
            string qry = "Select * from Category";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Guna.UI2.WinForms.Guna2Button b = new Guna.UI2.WinForms.Guna2Button();
                    b.FillColor = Color.FromArgb(94, 148, 255);
                    b.Size = new Size(170, 45);
                    b.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                    b.Text = row["catName"].ToString();

                    b.Click += new EventHandler(b_Click);

                    CategoryPanel.Controls.Add(b);
                }
            }
        }

        private void b_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button b = (Guna.UI2.WinForms.Guna2Button)sender;
            if(b.Text == "All Categories")
            {
                txtSearch.Text = "1";
                txtSearch.Text = "";
                return;
            }
            
            foreach (var item in ProductPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.PCategory.ToLower().Contains(b.Text.Trim().ToLower());
            }
        }

        private void addItems(string id,String proID ,string name ,string cat, string price,Image pimage)
        {
            var w = new ucProduct()
            {
                Pname = name,
                PPrice = price,
                PCategory = cat,
                PImage = pimage,
                id = Convert.ToInt32(proID)
            };
            ProductPanel.Controls.Add(w);

            w.onSelect += (ss, ee) =>
            {
                var wdg = (ucProduct)ss;

                foreach (DataGridViewRow Item in guna2DataGridView1.Rows)
                {
                    if (Convert.ToInt32(Item.Cells["dgvproID"].Value) == wdg.id)
                    {
                        Item.Cells["dgvQty"].Value = int.Parse(Item.Cells["dgvQty"].Value.ToString()) + 1;
                        Item.Cells["dgvAmount"].Value = int.Parse(Item.Cells["dgvQty"].Value.ToString()) *
                        double.Parse(Item.Cells["dgvPrice"].Value.ToString());
                        return;
                    }
                }
                guna2DataGridView1.Rows.Add(new object[] {0, 0, wdg.id, wdg.Pname, 1, wdg.PPrice, wdg.PPrice });
                GetTotal();
            };
        }

        private void LoadProducts()
        {
            string qry = "Select * from product as p inner join category on catId = p.CategoryID";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach(DataRow item in dt.Rows)
            {
                Byte[] imagearray = (byte[])item["pImage"];
                byte[] immagebytearray = imagearray;

                addItems("0",item["pID"].ToString(), item["pName"].ToString(), item["catName"].ToString()
                    , item["pPrice"].ToString(),Image.FromStream(new MemoryStream(imagearray)));
            }
        }

       

        private void guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
                int count = 0;

                foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                {
                    count++;
                    row.Cells[0].Value = count;
                }
            
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            foreach (var item in ProductPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.Pname.ToLower().Contains(txtSearch.Text.Trim().ToLower());
            }
        }

        public void GetTotal()
        {
            double tot = 0;
            lblTotal.Text = "";
            foreach(DataGridViewRow item in guna2DataGridView1.Rows)
            {
                tot += double.Parse(item.Cells["dgvAmount"].Value.ToString());
            }

            lblTotal.Text = tot.ToString("N2");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lblTalbe.Text = "";
            lblWaiter.Text = "";
            lblTalbe.Visible = false;
            lblWaiter.Visible = false;
            guna2DataGridView1.Rows.Clear();
            MainID = 0;
            lblTotal.Text = "";
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            lblTalbe.Text = "";
            lblWaiter.Text = "";
            lblTalbe.Visible = false;
            lblWaiter.Visible = false;
            OrderType = "Хүргэх";
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            lblTalbe.Text = "";
            lblWaiter.Text = "";
            lblTalbe.Visible = false;
            lblWaiter.Visible = false;
            OrderType = "Авах";
        }

        private void btnDin_Click(object sender, EventArgs e)
        {
            OrderType = "Идэх";
            TableSelect frm = new TableSelect();
            MainClass.BlurBackGround(frm);
            if (frm.TableName != "")
            {
                lblTalbe.Text = frm.TableName;
                lblTalbe.Visible = true;
            }
            else
            {
                lblTalbe.Text = "";
                lblTalbe.Visible = false;
            }

            WaiterSelect frm2 = new WaiterSelect();
            MainClass.BlurBackGround(frm2);
            if (frm2.WaiterName != "")
            {
                lblWaiter.Text = frm2.WaiterName;
                lblWaiter.Visible = true;
            }
            else
            {
                lblWaiter.Text = "";
                lblWaiter.Visible = false;
            }

        }

        private void btnKot_Click(object sender, EventArgs e)
        {
            string qry1 = "";
            string qry2 = "";
            

            if(MainID == 0)
            {
                qry1 = @"INSERT INTO tblMain Values(@aDate, @aTime, @TableName, @WaiterName, @status, @orderType, @total, @received, @change);
                               Select SCOPE_IDENTITY();";
            }
            else
            {
                qry1 = @"UPDATE tblMain SET status = @status, total = @total, received = @received, change = @change WHERE MainID = @ID ";
            }

            SqlCommand cmd = new SqlCommand(qry1, MainClass.con);
            cmd.Parameters.AddWithValue("@ID",MainID);
            cmd.Parameters.AddWithValue("@aDate",Convert.ToDateTime(DateTime.Now.Date));
            cmd.Parameters.AddWithValue("@aTime",DateTime.Now.ToShortTimeString());
            cmd.Parameters.AddWithValue("@TableName",lblTalbe.Text);
            cmd.Parameters.AddWithValue("@WaiterName",lblWaiter.Text);
            cmd.Parameters.AddWithValue("@status","Бэлэн бус");
            cmd.Parameters.AddWithValue("@orderType", OrderType);
            cmd.Parameters.AddWithValue("@total",Convert.ToDouble(lblTotal.Text));
            cmd.Parameters.AddWithValue("@received",Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@change",Convert.ToDouble(0));

            if(MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
            if (MainID == 0) { MainID = Convert.ToInt32(cmd.ExecuteScalar()); } else { cmd.ExecuteNonQuery(); }
            if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }

           foreach (DataGridViewRow row in guna2DataGridView1.Rows)
           {
                    detailID = Convert.ToInt32(row.Cells["dgvid"].Value);

           if (detailID == 0)
           {
                    qry2 = @"Insert into tblDetails Values(@MainID,@proID,@qty,@price,@amount)";

           }
                    else
           {
                     qry2 = @"Update tblDetails Set proID = @proID, qty = @qty, price = @price, amount = @amount where DetailID = @ID ";
           }

                    SqlCommand cmd2 = new SqlCommand(qry2, MainClass.con);
                    cmd2.Parameters.AddWithValue("@ID", detailID);
                    cmd2.Parameters.AddWithValue("@MainID", MainID);
                    cmd2.Parameters.AddWithValue("@proID", Convert.ToInt32(row.Cells["dgvproID"].Value));
                    cmd2.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["dgvQty"].Value));
                    cmd2.Parameters.AddWithValue("@price", Convert.ToDouble(row.Cells["dgvPrice"].Value));
                    cmd2.Parameters.AddWithValue("@amount", Convert.ToDouble(row.Cells["dgvAmount"].Value));

                    if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
                    cmd2.ExecuteNonQuery();
                    if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }

                  
                }
            guna2MessageDialog1.Show("Амжиллтай хадгаллаа");
            MainID = 0;
            detailID = 0;
            guna2DataGridView1.Rows.Clear();

            lblTalbe.Text = "";
            lblWaiter.Text = "";
            lblTalbe.Visible = false;
            lblWaiter.Visible = false;
            lblTotal.Text = "0.0";
        }

        public int id = 0;
        private void btnBill_Click(object sender, EventArgs e)
        {
            BillList frm = new BillList();
            MainClass.BlurBackGround(frm);

            if(frm.MainID > 0)
            {
                id = frm.MainID;
                LoadEntries();
            }
        }

        private void LoadEntries()
        {
            string qry = @"Select * from tblMain as m 
                              inner join tblDetails as d on m.MainID = d.MainID
                              inner join product as p on p.pID = d.proID
                                    Where m.MainID = "+id+"";
            SqlCommand cmd2 = new SqlCommand(qry, MainClass.con);
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);

            if (dt2.Rows[0]["OrderType"].ToString() == "Хүргэх")
            {
                btnDelivery.Checked = true;
                lblWaiter.Visible = false;
                lblTalbe.Visible = false;
            }
            else if (dt2.Rows[0]["OrderType"].ToString() == "Авах")
            {
                btnTake.Checked = true;
                lblWaiter.Visible = false;
                lblTalbe.Visible = false;

            }
            else
            {
                btnDin.Checked = true;
                lblWaiter.Visible = true;
                lblTalbe.Visible = true;

            }

                guna2DataGridView1.Rows.Clear();

            foreach(DataRow Item in dt2.Rows)
            {
                lblTalbe.Text = Item["TableName"].ToString();
                lblWaiter.Text = Item["WaiterName"].ToString();
                string detailId = Item["DetailID"].ToString();
                string proName = Item["pName"].ToString();
                string proId = Item["proID"].ToString();
                string qty = Item["qty"].ToString();
                string price = Item["price"].ToString();
                string amount = Item["amount"].ToString();

                object[] obj = {0,detailId,proId,proName,qty,price,amount };
                guna2DataGridView1.Rows.Add(obj);
            }
            GetTotal();
        }

        private void saveCheckout_Click(object sender, EventArgs e)
        {
            Checkout frm = new Checkout();
            frm.MainID = id;
            frm.amt = Convert.ToDouble(lblTotal.Text);
            MainClass.BlurBackGround(frm);
            MessageBox.Show("Амжиллтай");
            MainID = 0;
            guna2DataGridView1.Rows.Clear();
            lblTalbe.Text = "";
            lblWaiter.Text = "";
            lblTalbe.Visible = false;
            lblWaiter.Visible = false;
            lblTotal.Text = "0.0";
        }
    }
}
