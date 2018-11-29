using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prutsen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }




        public void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] values = { rateTXT.Text, cmdrateTXT.Text, updaterateTXT.Text, interpTXT.Text, interp_ratioTXT.Text, lagcompenTXT.Text};

            WriteCFGfile.WriteMain(values);
        }



        private void label1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("This is your upload/download bandwidth in bytes. " + Environment.NewLine + "Recommended: 768432", label1.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Max number of command packets sent to server per seconds.(Tickrate) " + Environment.NewLine + "Recommended: 128", label2.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Number of packets per second of updates you are requesting from the server.(Tickrate) " + Environment.NewLine + "Recommended: 128", label2.Text);

        }

        private void label4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Sets the interpolation amount" + Environment.NewLine + "Recommended settings based off ping:" + Environment.NewLine + "1-30: cl_interp 0.007813" + Environment.NewLine + "30-60: cl_interp 0.015625" + Environment.NewLine + "60-90: cl_interp 0.015625" + Environment.NewLine + "90+: cl_interp 0.03125", label2.Text);

        }

        private void label5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Sets the interpolation amount." + Environment.NewLine + "Recommended settings based off ping:" + Environment.NewLine + "1-60 : cl_interp_ratio 1" + Environment.NewLine + "60+ : cl_interp_ratio 2", label2.Text);
        }



        private void loadOptimizedSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rateTXT.Text = "768432";
            cmdrateTXT.Text = "128";
            updaterateTXT.Text = "128";
            interpTXT.Text = "0.007813";
            interp_ratioTXT.Text = "1";
            lagcompenTXT.Text = "1";
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Perform server side lag compensation of weapon firing events." + Environment.NewLine + "Recommended: 1", label2.Text);

        }






















        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            crosshairgen chForm = new crosshairgen();

            // Show the settings form
            chForm.Show();
        }
    }
}
