using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassIO;

namespace Reading_and_Writing_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                //Reader r = new Reader(ofd.FileName);
                //MessageBox.Show(r.ReadInt32().ToString("x"));
                Writer w = new Writer(ofd.FileName);
                w.WriteUnicodString("Hello");
                w.Close();
            }
        }
    }
}
