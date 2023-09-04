using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstroClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonEnglish_Click(object sender, EventArgs e)
        {
            ChangeLanguage("English");
        }

        private void ButtonFrench_Click(object sender, EventArgs e)
        {
            ChangeLanguage("French");
        }

        private void ButtonGerman_Click(object sender, EventArgs e)
        {
            ChangeLanguage("German");
        }

        private void ChangeLanguage(string language)
        {
            switch (language)
            {
                case "English":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
                    ButtonEnglish.Enabled = false;
                    ButtonFrench.Enabled = true;
                    ButtonGerman.Enabled = true;
                    //this.BackgroundImage = Properties.Resources.Flag_of_US;

                    break;
                case "French":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-FR");
                    ButtonEnglish.Enabled = false;
                    ButtonFrench.Enabled = true;
                    ButtonGerman.Enabled = true;
                    //this.BackgroundImage = Properties.Resources.Flag_of_US;

                    break;
                case "German":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("de-DE");
                    ButtonEnglish.Enabled = false;
                    ButtonFrench.Enabled = true;
                    ButtonGerman.Enabled = true;
                    //this.BackgroundImage = Properties.Resources.Flag_of_US;

                    break;
            }
        }
    }
}
