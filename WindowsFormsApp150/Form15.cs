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
namespace WindowsFormsApp150
{
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }
        SqlConnection cn =new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\cinema event\event pro\WindowsFormsApp150\WindowsFormsApp150\Database2.mdf"";Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            
                cn.Open();
                string x = textBox1.Text;
                SqlDataAdapter da = new SqlDataAdapter("select UserName , Staffname from Login where UserName='" + x + "' ", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Enter valid name");
            }

            cn.Close();






        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 fm5= new Form5();
            this.Visible = false;
            fm5.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
