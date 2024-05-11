using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NgrixRandomWebsiteFinder
{
    public partial class LogoForm : Form
    {
        public LogoForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TopMost != RWF.topMost)
            TopMost = RWF.topMost;
        }
    }
}
