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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<Double> marketShareData = new List<double>();
            Double[] shareDataPercentage = { 34.43, 87.21, 12.65, 54.22, 21, 78 };
            marketShareData.AddRange(shareDataPercentage);
            bunifuPieChart1.Data = marketShareData;
        }
    }
}
