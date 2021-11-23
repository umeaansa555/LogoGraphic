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

            Font drawFont = new Font("Arial", 10, FontStyle.Bold);

            SolidBrush whiteBrush = new SolidBrush(Color.White);

            g.Clear(Color.Black);

            g.TranslateTransform(40, 60);
            g.RotateTransform(45);
            g.FillRectangle(redBrush, 0, 0, 50, 50);
            g.ResetTransform();

            g.TranslateTransform(40, 60);
            g.RotateTransform(45);
            g.FillRectangle(redBrush, 100, 90, 50, 50);
            g.ResetTransform();


            g.TranslateTransform(230, 200);
            g.RotateTransform(45);
            g.FillRectangle(blueBrush, 0, 0, 50, 100);
            g.ResetTransform();

            g.FillEllipse(whiteBrush, 100, 100, 25, 25);
            g.FillEllipse(whiteBrush, 150, 50, 25, 25);

            g.TranslateTransform(140, 150);
            g.RotateTransform(-45);
            g.DrawString("Domino's Pizza", drawFont, whiteBrush, 0, 0);
            g.ResetTransform();

        }
    }
}
