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
    //this form contain film and when you click go to choose time

    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
        //when click on this button got to choose time of film

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 f=new Form8();
            this.Visible = false;
            f.ShowDialog();
        }
        ////when click on this button got to choose time of another film

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 f = new Form9();
            this.Visible = false;
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form14 fm14= new Form14();
            this.Visible = false;
            fm14.ShowDialog();
        }
    }
}
