using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp150
{
    internal class login
    {
        private SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\cinema event\event pro\WindowsFormsApp150\WindowsFormsApp150\Database2.mdf"";Integrated Security=True");
        private string user, password;
  
        
        public string User
        {
            get { return user; }
            set { this.user = value; }
        }
        public string Password
        {
            get { return password; }
            set { this.password = value; }
        }
        public bool check()
        {
            try
            {
                cn.Open();
                string Query = "select * from Login where username = '" + this.user + "' AND password = '" + this.Password + "'";
                SqlCommand cmd = new SqlCommand(Query, cn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                SqlDataReader sdr = cmd.ExecuteReader();


                if (dt.Rows.Count >0)
                {
                    cn.Close();
                    return true;
                }

                return false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Try again");
                return false;
            }

        }
    }
}
