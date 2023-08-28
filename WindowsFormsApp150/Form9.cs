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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp150
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        SqlConnection cn=new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\cinema event\event pro\WindowsFormsApp150\WindowsFormsApp150\Database2.mdf"";Integrated Security=True");


        private void Form9_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Bigshow2", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "datetime";
        }
        //button back to menu of film if you choose wrong film

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            this.Visible = false;
            form.ShowDialog();
        }
        //choose time of film  from database

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Form4 f = new Form4();
                this.Visible = false;
                f.ShowDialog();
            }
            else
            {
                Form11 form = new Form11(); 
                this.Visible = false;   
                form.ShowDialog();
            }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
