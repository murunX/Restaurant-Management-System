using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace Lab7
{
    public partial class Tailan : Form
    {
        private PrintDocument printDocument = new PrintDocument();
        private string documentContents;

        public Tailan()
        {
            InitializeComponent();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
        }

        private void Tailan_Load(object sender, EventArgs e)
        {
            Reports.SelectedIndex = 0;
            ExecuteSearch();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ExecuteSearch();
        }

        private void ExecuteSearch()
        {
            DateTime selectedDate = dateTimePicker1.Value.Date;

            string searchText = txtSearch.Text.Trim();

            SqlCommand cmd;
            string selectedReport = Reports.SelectedItem.ToString();
            switch (selectedReport)
            {
                case "Тайлан 1":
                    cmd = new SqlCommand("Tailan1", MainClass.con);
                    cmd.Parameters.AddWithValue("@Year", selectedDate.Year);
                    cmd.Parameters.AddWithValue("@Month", selectedDate.Month);
                    cmd.Parameters.AddWithValue("@Name", "%" + searchText + "%");
                    break;
                case "Тайлан 2":
                    cmd = new SqlCommand("Tailan2", MainClass.con);
                    cmd.Parameters.AddWithValue("@Year", selectedDate.Year);
                    cmd.Parameters.AddWithValue("@Month", selectedDate.Month);
                    cmd.Parameters.AddWithValue("@Name", "%" + searchText + "%");
                    break;
                case "Тайлан 3":
                    cmd = new SqlCommand("Tailan3", MainClass.con);
                    cmd.Parameters.AddWithValue("@Year", selectedDate.Year);
                    cmd.Parameters.AddWithValue("@Month", selectedDate.Month);
                    break;
                case "Тайлан 4":
                    cmd = new SqlCommand("Tailan4", MainClass.con);
                    cmd.Parameters.AddWithValue("@Year", selectedDate.Year);
                    break;
                default:
                    cmd = new SqlCommand("Tailan1", MainClass.con);
                    cmd.Parameters.AddWithValue("@Year", selectedDate.Year);
                    cmd.Parameters.AddWithValue("@Month", selectedDate.Month);
                    cmd.Parameters.AddWithValue("@Name", "%" + searchText + "%");
                    break;
            }
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            guna2DataGridView1.DataSource = dt;

            // Prepare document contents for printing
            documentContents = "";
            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                {
                    documentContents += row[col.ColumnName].ToString() + "\t";
                }
                documentContents += "\n";
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ExecuteSearch();
        }

        private void Reports_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExecuteSearch();
        }

      

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(documentContents, new Font("Arial", 12), Brushes.Black, 100, 100);

        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            /*PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }*/

            
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Хоол Захиалгын систем Тайлан";
            printer.SubTitle = string.Format("Он Сар Өдөр: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Б.Ихмөрөн";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(guna2DataGridView1);
        }
    }
}
