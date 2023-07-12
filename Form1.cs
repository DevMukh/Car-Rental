using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace final_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string User_Name = textBox1.Text;
            string Password = textBox2.Text;
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8650KBT;Initial Catalog = Final_Project; Integrated Security=true");
            string query = "SELECT * FROM MainPanel WHERE User_Name='" + User_Name + "' AND Password='" + Password + "'";
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(query,conn);
            DataTable datable = new DataTable();
            da.Fill(datable);


            if (datable.Rows.Count > 0)
            {

                MessageBox.Show("You login Successfully...");
                Report r = new Report();

                r.Show();
            }
            else
            {
                MessageBox.Show("Sorry not found..");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
        }
    }
}
