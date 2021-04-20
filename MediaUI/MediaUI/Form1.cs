using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void customizeDesign()
        {
            panelMediaSubmenu.Visible = false;
            panelPlaylistSubmenu.Visible = false;
            panelToolsSubmenu.Visible = false;
            //...
        }

        private void hideSubmenu()
        {
            if (panelMediaSubmenu.Visible == true)
                panelMediaSubmenu.Visible = false;
            if (panelPlaylistSubmenu.Visible == true)
                panelPlaylistSubmenu.Visible = false;
            if (panelToolsSubmenu.Visible == true)
                panelToolsSubmenu.Visible = false;
        }

        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
                
                
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubmenu(panelMediaSubmenu);
        }
        #region MediaSubmenu
        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
            //...
            //your code
            //..
            hideSubmenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //...
            //your code
            //..
            hideSubmenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //...
            //your code
            //..
            hideSubmenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //...
            //your code
            //..
            hideSubmenu();
        }
#endregion MediaSubmenu
        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubmenu(panelPlaylistSubmenu);
        }
        #region PlayListSubmenu
        private void button9_Click(object sender, EventArgs e)
        {
            //...
            //your code
            //..
            hideSubmenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //...
            //your code
            //..
            hideSubmenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //...
            //your code
            //..
            hideSubmenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //...
            //your code
            //..
            hideSubmenu();
        }
        #endregion PlayListSubmenu
        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
            //...
            //your code
            //..
            hideSubmenu();
        }
        
        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubmenu(panelToolsSubmenu);
        }
        #region ToolsSubmenu
        private void button15_Click(object sender, EventArgs e)
        {
            //...
            //your code
            //..
            hideSubmenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //...
            //your code
            //..
            hideSubmenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //...
            //your code
            //..
            hideSubmenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //...
            //your code
            //..
            hideSubmenu();
        }
        #endregion ToolsSubmenu
        private void btnHelp_Click(object sender, EventArgs e)
        {
            //...
            //your code
            //..
            hideSubmenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
