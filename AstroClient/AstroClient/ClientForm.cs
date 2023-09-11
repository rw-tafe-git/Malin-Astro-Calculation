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
using System.ServiceModel;
using System.Diagnostics;

namespace AstroClient
{
    public partial class ClientForm : Form
    {
        // Create a channel reference
        IAstroContract channel;

        public ClientForm()
        {
            InitializeComponent();

            //Initialise the service model channel
            string address = "net.pipe://localhost/pipespacemaths";
            NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
            EndpointAddress ep = new EndpointAddress(address);
            channel = ChannelFactory<IAstroContract>.CreateChannel(binding, ep);
        }

        private void Display(string[] data)
        {
            ListViewItem lvi = new ListViewItem(data[0]);
            lvi.SubItems.Add(data[1]);
            lvi.SubItems.Add(data[2]);
            lvi.SubItems.Add(data[3]);
            ListViewOutput.Items.Add(lvi);
        }

        private void ButtonCalculateVelocity_Click(object sender, EventArgs e)
        {
            double velocity = channel.StarVelocity(double.Parse(InputObserved.Text), double.Parse(InputRest.Text));

            //string[] data = new string[] { "velocity", "distance", "kelvin", "horizon" };
            string[] data = new string[] { velocity.ToString("0.00 m/s"), "", "", "" };
            Display(data);
        }

        private void ButtonCalculateDistance_Click(object sender, EventArgs e)
        {
            double starDistance = channel.StarDistance(double.Parse(InputParallax.Text));

            string[] data = new string[] { "", starDistance.ToString(), "", "" };
            Display(data);
        }

        private void ButtonCalculateTemperature_Click(object sender, EventArgs e)
        {
            double temperature = channel.TemperatureInKelvin(double.Parse(InputCelsius.Text));

            string[] data = new string[] { "", "", temperature.ToString(), "" };
            Display(data);
        }

        private void ButtonCalculateHorizon_Click(object sender, EventArgs e)
        {
            double eventHorizon = channel.EventHorizon(double.Parse(InputMass.Text));

            string[] data = new string[] { "", "", "", eventHorizon.ToString() };
            Display(data);
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

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) 
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
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
                    this.BackgroundImage = Properties.Resources.flag_english;

                    break;
                case "French":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-FR");
                    ButtonEnglish.Enabled = true;
                    ButtonFrench.Enabled = false;
                    ButtonGerman.Enabled = true;
                    this.BackgroundImage = Properties.Resources.flag_french;

                    break;
                case "German":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("de-DE");
                    ButtonEnglish.Enabled = true;
                    ButtonFrench.Enabled = true;
                    ButtonGerman.Enabled = false;
                    this.BackgroundImage = Properties.Resources.flag_german;

                    break;
            }
        }

        private void MenuLight_Click(object sender, EventArgs e)
        {
            BackColor = SystemColors.Control;
        }

        private void MenuDark_Click(object sender, EventArgs e)
        {
            BackColor = SystemColors.InactiveCaption;
        }
    }
}
