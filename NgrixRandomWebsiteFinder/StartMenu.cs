namespace NgrixRandomWebsiteFinder
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        private void StartMenu_Load(object sender, EventArgs e)
        {
            foreach (var website in RWF.domain_extensions)
            {
                listBox1.Items.Add(website);

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < 11; i++)
            {
                list.Add(i.ToString());
            }

            foreach (var item in list)
            {
                switch (item)
                {
                    case "1":
                        LogoForm form = new LogoForm();
                        form.StartPosition = FormStartPosition.Manual;
                        form.Text = "Ngrix RWF - https://ngrix.space";
                        form.MaximizeBox = false;
                        form.MinimizeBox = false;
                        form.Location = RWF.logoForm;
                        form.Size = new Size(300, 350);
                        form.Show();
                        break;
                    case "2":
                        Form form2 = new ThreadForm();
                        form2.StartPosition = FormStartPosition.Manual;
                        form2.Text = "Ngrix RWF - Thread 1";
                        form2.MaximizeBox = false;
                        form2.MinimizeBox = false;
                        form2.Location = RWF.thread2Form;
                        form2.Size = new Size(300, 350);
                        form2.Show();
                        break;
                        case "3":
                        Form form3 = new ThreadForm();
                        form3.StartPosition = FormStartPosition.Manual;
                        form3.Text = "Ngrix RWF - Thread 2";
                        form3.MaximizeBox = false;
                        form3.MinimizeBox = false;
                        form3.Location = RWF.thread3Form;
                        form3.Size = new Size(300, 350);
                        form3.Show();
                        break;
                        case "4":
                        Form form4 = new ThreadForm();
                        form4.StartPosition = FormStartPosition.Manual;
                        form4.Text = "Ngrix RWF - Thread 3";
                        form4.MaximizeBox = false;
                        form4.MinimizeBox = false;
                        form4.Location = RWF.thread4Form;
                        form4.Size = new Size(300, 350);
                        form4.Show();
                        break;
                        case "5":
                        Form form5 = new ThreadForm();
                        form5.StartPosition = FormStartPosition.Manual;
                        form5.Text = "Ngrix RWF - Thread 4";
                        form5.MaximizeBox = false;
                        form5.MinimizeBox = false;

                        form5.Location = RWF.thread5Form;
                        form5.Size = new Size(300, 350);
                        form5.Show();
                        break;
                        case "6":
                        Form form6 = new ThreadForm();
                        form6.StartPosition = FormStartPosition.Manual;
                        form6.Text = "Ngrix RWF - Thread 5";
                        form6.MaximizeBox = false;
                        form6.MinimizeBox = false;
                        form6.Location = RWF.thread6Form;
                        form6.Size = new Size(300, 350);
                        form6.Show();
                        break;
                        case "7":
                        Form form7 = new MainPage();
                        form7.StartPosition = FormStartPosition.Manual;
                        form7.Text = "Ngrix RWF - Main";
                        form7.MaximizeBox = false;
                        form7.MinimizeBox = false;
                        form7.Location = RWF.main;
                        form7.Size = new Size(300, 350);
                        form7.Show();
                        break;
                        case "8":
                        Form form8 = new ThreadForm();
                        form8.StartPosition = FormStartPosition.Manual;
                        form8.Text = "Ngrix RWF - Thread 6";
                        form8.MaximizeBox = false;
                        form8.MinimizeBox = false;
                        form8.Location = RWF.thread8Form;
                        form8.Size = new Size(300, 350);
                        form8.Show();
                        break;
                        case "9":
                        Form form9 = new ThreadForm();
                        form9.StartPosition = FormStartPosition.Manual;
                        form9.Text = "Ngrix RWF - Thread 7";
                        form9.MaximizeBox = false;
                        form9.MinimizeBox = false;
                        form9.Location = RWF.thread9Form;
                        form9.Size = new Size(300, 350);
                        form9.Show();
                        break;
                        case "10":
                        Form form10 = new ThreadForm();
                        form10.StartPosition = FormStartPosition.Manual;
                        form10.Text = "Ngrix RWF - Thread 8";
                        form10.MaximizeBox = false;
                        form10.Location = RWF.thread10Form;
                            form10.Size = new Size(300, 350);
                            form10.Show();
                        break;
                        case "11":
                        Form form11 = new ThreadForm();
                        form11.StartPosition = FormStartPosition.Manual;
                        form11.Text = "Ngrix RWF - Thread 9";
                        form11.MaximizeBox = false;
                        form11.Location = RWF.thread11Form;
                        form11.Size = new Size(300, 350);
                        form11.Show();
                        break;
                }
                this.Hide();
            }

        }
    }
}
