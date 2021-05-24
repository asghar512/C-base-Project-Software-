using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        List<Panel> list = new List<Panel>();
        int index;
        public static DataGridViewRow selectedRowToPrint = null;

        public Form2()
        {
            InitializeComponent();
            panel2.Visible = false;
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FRAJE0P;Initial Catalog=asghar;Integrated Security=True");

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        public void display()
        {
            con.Open();
            string query = "select * from data";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            query = "select * from data";
            adapter = new SqlDataAdapter(query, con);
            DataTable dt1 = new DataTable();
            adapter.Fill(dt1);
            dataGridView3.DataSource = dt1;
            con.Close();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || textBox10.Text == "" || comboBox4.Text == "" || comboBox5.Text == "" || textBox9.Text == "")
            {
                MessageBox.Show("please enter all fields ");
            }
            else 
            {
                con.Open();
                string query = "insert into data values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox10.Text + "','" + comboBox4.Text + "','" + comboBox5.Text + "','" + textBox9.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox12.Text + "','" + textBox11.Text + "')";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.SelectCommand.ExecuteNonQuery();
                con.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                textBox10.Text = "";
                comboBox4.Text = "";
                comboBox5.Text = "";
                textBox9.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                MessageBox.Show("insert data sucessfully ");
            
            }
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            display();

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "delete from data where name='" + textBox1.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            adapter.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("deleted data sucessfully ");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "update data set name='" + textBox2.Text + "' where name='" + textBox1.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            adapter.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("updted  data sucessfully ");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from data where name='" + textBox1.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            ////list.Add(panel1);
            ////list.Add(panel2);
            ////list[index].BringToFront();
            //display();
            //System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"C:\Users\Dell\Downloads\afreen.wav");
            //sp.Play();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            comboBox5.Visible = true;
            //panel2.Controls.Add(addcourse.Instance);
            //addcourse.Instance.Dock = DockStyle.Fill;
            //addcourse.Instance.Show();
            //addcourse.Instance.BringToFront();
            if(index<list.Count-1)
            {
                list[++index].BringToFront();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            comboBox5.Visible = false;
            label13.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            //panel2.Controls.Add(addcourse.Instance);
            //addcourse.Instance.Dock = DockStyle.Fill;
            //addcourse.Instance.Show();
            //addcourse.Instance.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            //panel2.Controls.Add(addcourse.Instance);
            //addcourse.Instance.Dock = DockStyle.Fill;
            //addcourse.Instance.Show();
            //addcourse.Instance.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            // button search
            
            dataGridView2.Refresh();
            con.Open();
            string query = "select * from data where REGNO =" + textBox4.Text + "";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //if (dataGridView2.SelectedRows.Count > 0)
            //{
            //    DataGridViewRow row = dataGridView2.SelectedRows[0];
            //    string name = row.Cells[0].Value.ToString();
            //    string contact = row.Cells[1].Value.ToString();
            //    string model = row.Cells[2].Value.ToString();
            //    string ram = row.Cells[3].Value.ToString();
            //    string battery = row.Cells[4].Value.ToString();
            //    string screen = row.Cells[5].Value.ToString();
            //    string motherboard = row.Cells[6].Value.ToString();
            //    string adopter = row.Cells[7].Value.ToString();
            //    string problem = row.Cells[8].Value.ToString();
            //    string purchse = row.Cells[9].Value.ToString();
            //    //string name1 = textBox5.Text;
            //    //string contact1 = textBox6.Text;

            //    con.Open();
            //    //string query = "insert into mehdi values('" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
            //    string query = "insert into mehdi values ('" + name + "', '" + name1 + "'," + contact + "," + contact1 + "," + ram + ",'" + model + "','" + battery + "','" + screen + "','" + motherboard + "','" + adopter + "','" + problem + "','" + purchse + "')";
            //    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            //    adapter.SelectCommand.ExecuteNonQuery();
            //    con.Close();
            //    display();
            //}

            int regno = int.Parse(dataGridView2.SelectedRows[0].Cells[0].Value.ToString());

            string query = "UPDATE data SET approved= '" + textBox12.Text + "', BILL = " + int.Parse(textBox11.Text) + " WHERE REGNO = " + regno;
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Approve by and bill added!", "Success");
            //Form2_Load(sender, e);

            dataGridView2.Refresh();
            con.Open();
            query = "select * from data where REGNO =" + regno;
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();


        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //printDocument1.Print();
            selectedRowToPrint = dataGridView1.SelectedRows[0];
            PrintForm pf = new PrintForm();
            pf.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            selectedRowToPrint = dataGridView2.SelectedRows[0];
            printform1 pf = new printform1();
            pf.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
           
        }
       
    }
}
