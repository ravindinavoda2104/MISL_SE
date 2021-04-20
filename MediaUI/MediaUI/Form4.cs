using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MediaUI
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar1.Increment(1);
            if(progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                Form1 form = new Form1();
                timer1.Stop();
                form.Show();
                this.Hide();

               
            }

            
        }
        
            
    }
}
