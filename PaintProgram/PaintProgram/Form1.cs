using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
        }
        bool canPaint = false;
        Graphics g;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            canPaint = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            canPaint = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(canPaint)
            {
                SolidBrush s = new SolidBrush(Color.Purple);
                g.FillEllipse(s,e.X,e.Y,Convert.ToInt32(toolStripTextBox1.Text), Convert.ToInt32(toolStripTextBox1.Text));
            }
        }
    }
}
