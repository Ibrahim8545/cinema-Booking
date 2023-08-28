using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp150
{

    //intro video and timer to connect the time show

    public partial class Form1 : Form
    {
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (counter < 101)
            {

                counter++;
                return;
            }
            else if (counter < 110)
            {
                counter++;
                return;
            }
            Form2 f = new Form2();
            timer2.Enabled = false;
            this.Visible = false;
          
           
            this.Visible=false;
            f.ShowDialog();
           
        }
    }
}
