using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eniato
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void painelHeader_paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush linearGradientBrush =
            new LinearGradientBrush(painelHeader.ClientRectangle, Color.FromArgb(57, 106, 252), Color.FromArgb(41, 72, 255), 45);

            ColorBlend cblend = new ColorBlend(3);
            cblend.Colors = new Color[2] { Color.FromArgb(57, 106, 252), Color.FromArgb(41, 72, 255) };
            cblend.Positions = new float[2] { 0f, 1f };

            linearGradientBrush.InterpolationColors = cblend;

            e.Graphics.FillRectangle(linearGradientBrush, painelHeader.ClientRectangle);
        }

    }
}
