using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AddControls(new frmHome());
            HomeBtn.Checked = true;
        }


        static Form1 _obj;
        public static Form1 instance
        {
            get { if (_obj == null) { _obj = new Form1(); } return _obj; } 
        }
        
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        { 

        }

        public void AddControls(Form f)
        {
            CenterPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            CenterPanel.Controls.Add(f);
            f.Show();

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            AddControls(new frmHome());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            AddControls(new CategoryView());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            AddControls(new TableView());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _obj = this;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            AddControls(new workerView());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            AddControls(new ProductView());
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            POS pos = new POS();
            pos.Show();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            AddControls(new KitchenView());
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            AddControls(new Tailan());
        }
    }
}
