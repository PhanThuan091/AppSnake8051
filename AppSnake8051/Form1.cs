using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSnake8051
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            label1.Text = "Home";
            panel1_Top.BackColor = Color.Tomato;
        }


        private void btnEasy_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Easy());
            label1.Text = btnEasy.Text;
            panel1_Top.BackColor = Color.RoyalBlue;
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Medium());
            label1.Text = btnMedium.Text;
            panel1_Top.BackColor = Color.Gold;
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Hard());
            label1.Text = btnHard.Text;
            panel1_Top.BackColor = Color.Crimson;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            OpenChildForm(new About());
            label1.Text = btnAbout.Text;
        }

        
    }
}
