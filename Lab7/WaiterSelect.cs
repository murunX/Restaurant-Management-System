﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class WaiterSelect : Form
    {
        public WaiterSelect()
        {
            InitializeComponent();
        }
        public string WaiterName;

        
        private void b_Click(object sender, EventArgs e)
        {
            WaiterName = (sender as Guna.UI2.WinForms.Guna2Button).Text.ToString();
            this.Close();
        }

        private void WaiterSelect_Load(object sender, EventArgs e)
        {
        string qry = "Select * from worker where wRole = 'Зөөгч' ";
        SqlCommand cmd = new SqlCommand(qry, MainClass.con);
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);

        foreach (DataRow row in dt.Rows)
        {
            Guna.UI2.WinForms.Guna2Button b = new Guna.UI2.WinForms.Guna2Button();
            b.Text = row["wName"].ToString();
            b.Width = 150;
            b.Height = 50;
            b.FillColor = Color.FromArgb(243, 85, 126);
            b.HoverState.FillColor = Color.FromArgb(50, 55, 89);

            b.Click += new EventHandler(b_Click);
            flowLayoutPanel1.Controls.Add(b);
        }
    }
    }
}
