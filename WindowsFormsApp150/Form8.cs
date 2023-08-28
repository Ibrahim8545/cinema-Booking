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
    //choose time from database

    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        SqlConnection cn=new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\cinema event\event pro\WindowsFormsApp150\WindowsFormsApp150\Database2.mdf"";Integrated Security=True");

        //connection to data base

        private void Form8_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Bigshow1", cn);
        
            DataTable dt = new DataTable();

            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "time";
        }
        //choose time of film  from database

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)

            {
                Form3 f3 = new Form3();
                this.Visible = false;
                f3.ShowDialog();
            }
            else
            
            
            {
                Form10 f10 = new Form10();
                this.Visible = false;
                f10.ShowDialog();
            }
        }
        //button back to menu of film if you choose wrong film

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f2=new Form5();    
            this.Visible=false; 
            f2.ShowDialog();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
