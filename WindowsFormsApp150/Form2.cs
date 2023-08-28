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
using System.Net.Http.Headers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace WindowsFormsApp150
{

    //Take user name and password and call from login class
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection cn=new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\event pro\WindowsFormsApp150\WindowsFormsApp150\Database2.mdf"";Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            
        }



            private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();   
            textBox2.Clear();
        }
        //close program
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string username, password;
            username = textBox1.Text;
            password = textBox2.Text;


            login l = new login();
            l.User = username;
            l.Password = password;

            if (l.check())
            {
                Form5 f = new Form5();
                this.Visible = false;
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("The name or password may be incorrect");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
