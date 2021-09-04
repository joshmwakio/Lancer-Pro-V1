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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            List<Color> sectorColors = new List<Color>();
            Color[] colors = new Color[6];
            colors[0] = Color.FromArgb(112, 173, 71);
            colors[1] = Color.FromArgb(68, 114, 196);
            colors[2] = Color.FromArgb(255, 192, 0);
            colors[3] = Color.FromArgb(165, 165, 165);
            colors[4] = Color.FromArgb(132, 226, 150);
            colors[5] = Color.FromArgb(150, 43, 4, 78);
            sectorColors.AddRange(colors);
            bunifuPieChart1.BackgroundColor = sectorColors;
        }
    }
}
