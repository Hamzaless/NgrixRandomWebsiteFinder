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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TopMost != RWF.topMost)
                TopMost = RWF.topMost;
            if (RWF.working_domains.Count <= 0)
            {
                listBox1.Items.Clear();
            }
            else
            {

                listBox1.Items.Clear();
                foreach (string domain in RWF.working_domains)
                {
                    listBox1.Items.Add(domain);
                }
            }
            string[] lines = File.ReadAllLines("working_domains.txt");
            foreach (string line in lines)
            {
                if (!RWF.working_domains.Contains(line))
                {
                    RWF.working_domains.Add(line);
                }
                if (!listBox1.Items.Contains(line))
                {
                    listBox1.Items.Add(line);
                }
            }
            foreach (string domain in RWF.working_domains)
            {
                if (!lines.Contains(domain))
                {
                    File.AppendAllText("working_domains.txt", domain + Environment.NewLine);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            RWF.topMost = checkBox1.Checked;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
