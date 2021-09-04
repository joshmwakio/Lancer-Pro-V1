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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bunifuChartCanvas1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel42_Click(object sender, EventArgs e)
        {

        }
        Random randomData = new Random();
        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Double> dataList = new List<double>()
            {
                randomData.Next(51,94),
                randomData.Next(21,94),
                randomData.Next(61,94),
                randomData.Next(41,94),
                randomData.Next(31,94),
                randomData.Next(1,94)
           
            };
            bunifuPieChart1.Data = dataList;

            bunifuChartCanvas5.Update();
            bunifuLabel20.Text = dataList[0].ToString()+"%";
            bunifuLabel21.Text = dataList[1].ToString()+"%";
            bunifuLabel23.Text = dataList[2].ToString()+"%";
            bunifuLabel25.Text = dataList[3].ToString()+"%";
            bunifuLabel27.Text = dataList[4].ToString()+"%";
            bunifuLabel29.Text = dataList[5].ToString()+"%";
        }
    }
}
