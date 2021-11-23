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

            Font drawFont = new Font("Arial", 12, FontStyle.Bold);

            SolidBrush whiteBrush = new SolidBrush(Color.White);

            g.Clear(Color.Black);

            g.TranslateTransform(150, 90);
            g.RotateTransform(45);
            g.FillRectangle(redBrush, 0, 0, 50, 50);
            g.ResetTransform();

            g.TranslateTransform(190, 50);
            g.RotateTransform(45);
            g.FillRectangle(redBrush, 0, 0, 50, 50);
            g.ResetTransform();


            g.TranslateTransform(230, 100);
            g.RotateTransform(45);
            g.FillRectangle(blueBrush, 0, 0, 50, 100);
            g.ResetTransform();

            g.FillEllipse(whiteBrush, 130, 130, 15, 15);
            g.FillEllipse(whiteBrush, 160, 70, 15, 15);

            g.TranslateTransform(170, 170);
            g.RotateTransform(-45);
            g.DrawString("Domino's\nPizza", drawFont, whiteBrush, 0, 0);
            g.ResetTransform();

        }
    }
}
