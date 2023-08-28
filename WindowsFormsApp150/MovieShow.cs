using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp150
{
    public partial class MovieShow : Form
    {
        public MovieShow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f= new Form3();
            this.Visible = false;
            f.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f= new Form4();
            this.Visible = false;   
            f.ShowDialog();
        }
    }
}
