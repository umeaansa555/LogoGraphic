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

            //g.RotateTransform(45);
            g.FillRectangle(redBrush, 150, 30, 50, 50);
            //g.RotateTransform(45);
            g.FillRectangle(redBrush, 130, 90, 50, 50);

            
            //g.TranslateTransform(60, 60);
            g.FillRectangle(blueBrush, 0, 0, 50, 100);

            g.FillEllipse(whiteBrush, 50, 25, 25, 25);
            g.FillEllipse(whiteBrush, 70, 25, 25, 25);

            g.TranslateTransform(300, 300);
            g.RotateTransform(-45);
            g.DrawString("Domino's Pizza", drawFont, whiteBrush, 0, 0);
        }
    }
}
