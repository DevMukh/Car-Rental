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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 goback = new Form1();
            this.Hide();
            goback.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8650KBT;Initial Catalog = Final_Project; Integrated Security=true");
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Rent_Detail", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Rent_Detail");
            dataGridView1.DataSource = ds.Tables["Rent_Detail"].DefaultView;
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8650KBT;Initial Catalog = Final_Project; Integrated Security=true");
            conn.Open();
            string insertquery = "INSERT INTO Rent_Detail(Rent_ID, Vechile_No, C_Name, PickUp, Return_T, t_Days, Per_Day, Total,Payment, Milage, Gas_Level) VALUES (@Rent_ID, @Vechile_No, @C_Name, @PickUp, @Return_T, @t_Days, @Per_Day, @Total,@Payment, @Milage, @Gas_Level)";

            SqlCommand commond = new SqlCommand(insertquery, conn);
            commond.Parameters.AddWithValue("Rent_ID", int.Parse(textBox2.Text));
            commond.Parameters.AddWithValue("@Vechile_No", int.Parse(textBox3.Text));
            commond.Parameters.AddWithValue("@C_Name", textBox4.Text);
            commond.Parameters.AddWithValue("@PickUp", textBox5.Text);
            commond.Parameters.AddWithValue("@Return_T", textBox6.Text);
            commond.Parameters.AddWithValue("@t_Days", int.Parse(textBox7.Text));
            commond.Parameters.AddWithValue("@Per_Day", int.Parse(textBox8.Text));
            commond.Parameters.AddWithValue("@Total", int.Parse(textBox9.Text));
            commond.Parameters.AddWithValue("@Payment", textBox10.Text);
            commond.Parameters.AddWithValue("@Milage", int.Parse(textBox11.Text));
            commond.Parameters.AddWithValue("@Gas_Level", comboBox1.Text);
            commond.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Inserted data successfully...");


            //here to apply clear 
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            comboBox1.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8650KBT;Initial Catalog = Final_Project; Integrated Security=true");
            conn.Open();
            string update = "UPDATE Rent_Detail SET Vechile_No = @Vechile_No,C_Name = @C_Name,PickUp = @PickUp,   Return_T = @Return_T,   t_Days = @t_Days,   Per_Day = @Per_Day,   Total = @Total,   Payment = @Payment,   Milage = @Milage,   Gas_Level = @Gas_Level WHERE Rent_ID = @Rent_ID";
            SqlCommand commond = new SqlCommand(update, conn);
            commond.Parameters.AddWithValue("Rent_ID", int.Parse(textBox2.Text));
            commond.Parameters.AddWithValue("@Vechile_No", int.Parse(textBox3.Text));
            commond.Parameters.AddWithValue("@C_Name", textBox4.Text);
            commond.Parameters.AddWithValue("@PickUp", textBox5.Text);
            commond.Parameters.AddWithValue("@Return_T", textBox6.Text);
            commond.Parameters.AddWithValue("@t_Days", int.Parse(textBox7.Text));
            commond.Parameters.AddWithValue("@Per_Day", int.Parse(textBox8.Text));
            commond.Parameters.AddWithValue("@Total", int.Parse(textBox9.Text));
            commond.Parameters.AddWithValue("@Payment", textBox10.Text);
            commond.Parameters.AddWithValue("@Milage", int.Parse(textBox11.Text));
            commond.Parameters.AddWithValue("@Gas_Level", comboBox1.Text);
            commond.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Update data successfully...");
            //here to apply clear 
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            comboBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8650KBT;Initial Catalog = Final_Project; Integrated Security=true");
            conn.Open();
            string deleteQuery = "DELETE FROM Rent_Detail WHERE Rent_ID = @Rent_ID";
            SqlCommand commond = new SqlCommand(deleteQuery, conn);
            commond.Parameters.AddWithValue("Rent_ID", int.Parse(textBox2.Text));
            commond.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Delete data successfully...");
            //here to apply clear 
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            comboBox1.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
        }
    }
}

