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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Done", "confirmation message", MessageBoxButtons.OK);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            this.Visible = false;
            form.ShowDialog();
        }
    }
    }

