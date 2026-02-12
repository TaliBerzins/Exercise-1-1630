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

namespace WindowsForms_Exercise_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string length = textBox1.Text;
            string width = textBox2.Text;
            string sqFootCost = textBox3.Text;
            int floorLength = Convert.ToInt32(length);
            int floorWidth = Convert.ToInt32(width);
            double sqFootCostInt = Convert.ToDouble(sqFootCost);
            const double feetPerHour = 40;
            const double costPerHour = 40;
            int floorSize = floorLength * floorWidth;
            double floorCost = sqFootCostInt * floorSize;
            double installationTime = floorSize / feetPerHour;
            double installationCost = costPerHour * installationTime;
            label5.Text = "Cost of total floorSize of " + floorSize + ": $" + floorCost;
            label6.Text = "Number of hours to install the floor: " + installationTime + " At a cost of $" + installationCost;
            label7.Text = "The total finished cost of the new floor is: $" + (installationCost + floorCost);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void label5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
