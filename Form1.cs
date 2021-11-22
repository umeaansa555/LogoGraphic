using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogoGraphic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);

            Font drawFont = new Font("Arial", 16, FontStyle.Bold);

            SolidBrush whiteBrush = new SolidBrush(Color.White);

            g.Clear(Color.Black);

            g.FillRectangle(redBrush, 30, 30, 100, 200);
            g.FillRectangle(blueBrush, 30, 30, 100, 200);
            g.DrawString("Domino's Pizza", drawFont, whiteBrush, 50, 40);

        }
    }
}
