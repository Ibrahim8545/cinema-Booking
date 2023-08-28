using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp150
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\cinema event\event pro\WindowsFormsApp150\WindowsFormsApp150\Database2.mdf"";Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlDataAdapter da=new SqlDataAdapter("select  Staffname , UserName from Login", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            try
            {
                cn.Open();
                string x = textBox1.Text;

                // Use parameterized query to avoid SQL injection
                string query = "DELETE FROM Login WHERE UserName = @UserName";
                SqlCommand command = new SqlCommand(query, cn);
                command.Parameters.AddWithValue("@UserName", x);
                int rowsAffected = command.ExecuteNonQuery();
               
            }
            catch(SqlException ex)
            {
                MessageBox.Show("valid username");
            }
            finally
            {
                cn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            try
            {
                cn.Open();
                string x = textBox2.Text;
                string y = textBox3.Text;
                string z = textBox4.Text;
                string query = "INSERT INTO Login (UserName, Password, Staffname) VALUES (@Value1, @Value2, @Value3)";
                SqlCommand command = new SqlCommand(query, cn);
                command.Parameters.AddWithValue("@Value1", x);
                command.Parameters.AddWithValue("@Value2", y);
                command.Parameters.AddWithValue("@Value3", z);

                command.ExecuteNonQuery();
               
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                cn.Close();
            }

          

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form15 f=new Form15();  
            this.Visible= false;
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 fm5 = new Form5();
            this.Visible = false;
            fm5.ShowDialog();
        }
    }
}
