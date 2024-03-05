using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18.uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            maskTC.Mask = "00000000000";
            masktelefon.Mask = "(999) 000 00 00";
            maskdtarihi.Mask = "00 / 00 / 0000";
            maskkart.Mask = "0000 - 0000 - 0000 - 0000";
            maskIP.Mask = "###.###.###.###";
        }
    }
}
