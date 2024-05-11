using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NgrixRandomWebsiteFinder
{
    public partial class ThreadForm : Form
    {
        public ThreadForm()
        {
            InitializeComponent();
        }

        private void ThreadForm_Load(object sender, EventArgs e)
        {

        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            TopMost = RWF.topMost;
            timer1.Stop();
            string random_extension = RandomURLGenerator.GetRandomExtension();
            for (int i = 0; i < 6; i++)
            {
                label1.Text = "Trying; " + random_extension + " " + i + "/5";
                string random_url = RandomURLGenerator.GenerateRandomURL(random_extension);
                if (RWF.tried_domains.Contains(random_url))
                {
                    random_url = RandomURLGenerator.GenerateRandomURL(random_extension);
                }
                RWF.tried_domains.Add(random_url);

                // Asenkron işlemi Task.Run ile arka planda çalıştır
                var task = Task.Run(async () => await CheckWebsiteAccessibility("http://" + random_url));

                if (await task)
                {
                    RWF.working_domains.Add("http://" + random_url);
                    listBox1.Items.Add("http://" + random_url + " working!");
                }
                else
                {
                    listBox1.Items.Add("http://" + random_url + " not w");
                }

                int nItems = (int)(listBox1.Height / listBox1.ItemHeight);
                listBox1.TopIndex = listBox1.Items.Count - nItems;
            }
            timer1.Start();
        }


        static async Task<bool> CheckWebsiteAccessibility(string url)
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Timeout = 1000; 
                request.Method = "HEAD";

                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    return response.StatusCode == HttpStatusCode.Accepted || response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.GatewayTimeout; // Eğer website ulaşılabilirse true döndürülür.
                }
            }
            catch (WebException)
            {
                return false;
            }
        }
    }
}
