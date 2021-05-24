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
    public partial class printform1 : Form
    {
        DataGridViewRow row = null;
        public printform1()
        {
            InitializeComponent();
        }

        private void printform1_Load(object sender, EventArgs e)
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
            label36.Text = this.row.Cells[12].Value.ToString();
            label35.Text = this.row.Cells[13].Value.ToString();
           
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bm, new Rectangle(0, 0, this.Width, this.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}
