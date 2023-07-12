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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8650KBT;Initial Catalog = Final_Project; Integrated Security=true");
            conn.Open();
            string signup = "INSERT INTO MainPanel(User_Name, First_Name, Last_Name, Password, Email, Admin_Id) VALUES (@User_Name, @First_Name, @Last_Name, @Password, @Email, @Admin_Id)";
            SqlCommand commond = new SqlCommand(signup, conn);
            commond.Parameters.AddWithValue("@User_Name", textBox1.Text);
            commond.Parameters.AddWithValue("@First_Name", textBox4.Text);
            commond.Parameters.AddWithValue("@Last_Name", textBox5.Text);
            commond.Parameters.AddWithValue("@Password", textBox2.Text);
            commond.Parameters.AddWithValue("@Email", textBox3.Text);
            commond.Parameters.AddWithValue("@Admin_Id", textBox6.Text);
            commond.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Sign Up Successfully ...");
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
    }
}
