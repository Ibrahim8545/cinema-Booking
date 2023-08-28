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

    public partial class Form10 : Form

    {
        //seat of first first film and second time

        private Button lastClickedButton;
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }
        //button of seat when booking this seat the color of seat change to red

        private void button1_Click(object sender, EventArgs e)
        {
            lastClickedButton = (Button)sender;
            lastClickedButton.BackColor = Color.Red;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            lastClickedButton = (Button)sender;
            lastClickedButton.BackColor = Color.Red;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            lastClickedButton = (Button)sender;
            lastClickedButton.BackColor = Color.Red;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            lastClickedButton = (Button)sender;
            lastClickedButton.BackColor = Color.Red;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            lastClickedButton = (Button)sender;
            lastClickedButton.BackColor = Color.Red;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            lastClickedButton = (Button)sender;
            lastClickedButton.BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lastClickedButton = (Button)sender;
            lastClickedButton.BackColor = Color.Red;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            lastClickedButton = (Button)sender;
            lastClickedButton.BackColor = Color.Red;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            lastClickedButton = (Button)sender;
            lastClickedButton.BackColor = Color.Red;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lastClickedButton = (Button)sender;
            lastClickedButton.BackColor = Color.Red;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            lastClickedButton = (Button)sender;
            lastClickedButton.BackColor = Color.Red;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            lastClickedButton = (Button)sender;
            lastClickedButton.BackColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lastClickedButton = (Button)sender;
            lastClickedButton.BackColor = Color.Red;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            lastClickedButton = (Button)sender;
            lastClickedButton.BackColor = Color.Red;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            lastClickedButton = (Button)sender;
            lastClickedButton.BackColor = Color.Red;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            lastClickedButton = (Button)sender;
            lastClickedButton.BackColor = Color.Red;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            lastClickedButton = (Button)sender;
            lastClickedButton.BackColor = Color.Red;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            lastClickedButton = (Button)sender;
            lastClickedButton.BackColor = Color.Red;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lastClickedButton = (Button)sender;
            lastClickedButton.BackColor = Color.Red;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lastClickedButton = (Button)sender;
            lastClickedButton.BackColor = Color.Red;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            lastClickedButton = (Button)sender;
            lastClickedButton.BackColor = Color.Red;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            lastClickedButton = (Button)sender;
            lastClickedButton.BackColor = Color.Red;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            lastClickedButton = (Button)sender;
            lastClickedButton.BackColor = Color.Red;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            lastClickedButton = (Button)sender;
            lastClickedButton.BackColor = Color.Red;
        }
        //this button to print ticket and contain button if you would return to book another ticket

        private void button31_Click(object sender, EventArgs e)
        {

            if (lastClickedButton != null)
            {
                MessageBox.Show($"Reservation done", "confirmation message", MessageBoxButtons.OK);
                Form12 form = new Form12();
                this.Visible = false;
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("No reservation", "confirmation message", MessageBoxButtons.OK);
            }
        }
    }
}
