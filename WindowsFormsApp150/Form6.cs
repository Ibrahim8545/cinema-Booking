using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp150
{    
    //form of ticket of first film

    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }


        //this button if you would to return to book another table

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            this.Visible = false;
            form.ShowDialog();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Done", "confirmation message", MessageBoxButtons.OK);

        }
    }
}
