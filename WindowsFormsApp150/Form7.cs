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
    //form of ticket of second film

    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        //this button if you would to return to book another table

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            this.Visible = false;
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            this.Visible = false;
            form.ShowDialog();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show($"Done", "confirmation message", MessageBoxButtons.OK);
        }

    }
}

