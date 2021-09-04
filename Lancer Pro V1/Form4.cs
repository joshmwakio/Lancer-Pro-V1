using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lancer_Pro_V1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bunifuDropdown1.SelectedIndex == 0)
            {
                bunifuPieChart1.HoverBorderColor = Color.Black;
            }
            else if (bunifuDropdown1.SelectedIndex == 1)
            {
                bunifuPieChart1.HoverBorderColor = Color.ForestGreen;
            }
            else if (bunifuDropdown1.SelectedIndex == 2)
            {
                bunifuPieChart1.HoverBorderColor = Color.Purple;
            }
            else
            {
                bunifuPieChart1.HoverBorderColor = Color.Yellow;
            }
        }

        private void bunifuDropdown2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bunifuDropdown2.SelectedIndex == 0)
            {
                bunifuPieChart1.HoverBackgroundColor = Color.Black;
            }
            else if (bunifuDropdown2.SelectedIndex == 1)
            {
                bunifuPieChart1.HoverBackgroundColor = Color.White;
            }
            else
            {
                bunifuPieChart1.HoverBackgroundColor = Color.Yellow;
            }
        }

        private void bunifuHSlider1_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            bunifuPieChart1.HoverBorderWidth = bunifuHSlider1.Value;
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
