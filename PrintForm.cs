using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class PrintForm : Form
    {
        DataGridViewRow row = null;
        public PrintForm()
        {
            InitializeComponent();
        }

        private void PrintForm_Load(object sender, EventArgs e)
        {
            this.row = Form2.selectedRowToPrint;
            label1.Text = this.row.Cells[0].Value.ToString();
            label2.Text = this.row.Cells[1].Value.ToString();
            label3.Text = this.row.Cells[2].Value.ToString();
            label5.Text = this.row.Cells[3].Value.ToString();
            label6.Text = this.row.Cells[4].Value.ToString();
            label7.Text = this.row.Cells[5].Value.ToString();
            label8.Text = this.row.Cells[6].Value.ToString();
            label9.Text = this.row.Cells[7].Value.ToString();
            label10.Text = this.row.Cells[8].Value.ToString();
            label11.Text = this.row.Cells[9].Value.ToString();
            label16.Text = this.row.Cells[10].Value.ToString();
            label17.Text = this.row.Cells[11].Value.ToString();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //printDocument1.Print();
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //MessageBox.Show("aaa");
            Bitmap bm = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bm, new Rectangle(0, 0, this.Width, this.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
