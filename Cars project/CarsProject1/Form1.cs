using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsProject1
{
    public partial class Form1 : Form
    {
            int sum = 0;
        int totalSum = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==0)
            {
                pictureBox1.Image = Properties.Resources.captur_easy_life_gt_line_big_jpg_ximg_l_full_m_smart;
                label1.Text = "Базова цена: 19 460лв.";
                sum = 19460;
            }
            if (comboBox1.SelectedIndex==1)
            {
                pictureBox1.Image = Properties.Resources.Renault_Captur_phase2_Malaysia_side_view_800x450_jpg_ximg_l_full_m_smart;
                label1.Text = "Базова цена: 22 480лв.";
                sum = 22480;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                pictureBox1.Image = Properties.Resources._8134;
                label1.Text = "Базова цена: 25 300лв.";
                sum = 25300;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked)
            {
                totalSum = sum;
                totalSum += 100;
                                
            }
            
            if (checkBox2.Checked)
            {
                totalSum = sum;
                totalSum += 300;
                if (checkBox1.Checked)
                {
                    totalSum += 100;
                }
                if (checkBox3.Checked)
                {
                    totalSum += 500;
                }
            }
            if (checkBox3.Checked)
            {
                totalSum = sum;
                totalSum += 500;
                if (checkBox2.Checked)
                {
                    totalSum += 300;
                }
                if (checkBox1.Checked)
                {
                    totalSum += 100;
                }
            }
            label4.Text = totalSum.ToString();
        }
    }
}
