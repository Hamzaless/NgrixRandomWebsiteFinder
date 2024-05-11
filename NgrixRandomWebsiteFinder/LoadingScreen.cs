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
    public partial class LoadingScreen : Form
    {
        public LoadingScreen()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private async void LoadingScreen_Load(object sender, EventArgs e)
        {
            string fileContent = await System.IO.File.ReadAllTextAsync("domain_extensions.json");
            dynamic domain_extensions = Newtonsoft.Json.JsonConvert.DeserializeObject(fileContent);
            int maxvalue = 0;
            await Task.Run(() =>
            {
                foreach (var item in domain_extensions)
                {
                    maxvalue++;
                }
            });
            SetMaxValue(maxvalue);

            await Task.Run(() =>
            {
                foreach (var item in domain_extensions)
                {
                    RWF.domain_extensions.Add(item.extension, item.type);
                    IncreaseProgressBar(1);
                    ChangeStatus($"Loading domain extensions... {guna2ProgressBar1.Value}/{guna2ProgressBar1.Maximum}");
                }
            });
            StartMenu s = new StartMenu();
            s.Show();
            this.Hide();
        }

        private void UpdateProgressBar(int value)
        {
            guna2ProgressBar1.Value = value;
        }

        private void SetMaxValue(int value)
        {
            guna2ProgressBar1.Maximum = value;
        }

        public void IncreaseProgressBar(int value)
        {
            guna2ProgressBar1.Value += value;
        }

        public void SetProgressBarValue(int value)
        {
            guna2ProgressBar1.Value = value;
        }

        public void ChangeStatus(string status)
        {
            label1.Text = status;
        }
    }
}
