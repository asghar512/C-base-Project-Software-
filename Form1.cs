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
    public partial class Form1 : Form
    {
        //System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public Form1()
        {
            InitializeComponent();
            //player.SoundLocation="afreen.mp3";
            
        }
         
        public void display()
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FRAJE0P;Initial Catalog=asghar;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter("select * from loginform where username='" + textBox1.Text + "'and password ='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("you login sucessfully");
                Form2 form = new Form2();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("invalid username or password try again");
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            display();
            //player.Play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100,0,0,0);
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
