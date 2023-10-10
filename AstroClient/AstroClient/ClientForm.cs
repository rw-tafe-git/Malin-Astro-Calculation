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
        // Student Riley, id 30002737, Date: 23/08/2023
        // Assessment Task 2

        /// <summary>
        /// Client application
        /// </summary>

        // Create a channel reference
        IAstroContract channel;

        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colourDialog1;

        private bool themeMenuOpen = true;
        private bool languageMenuOpen = true;
        private bool coloursMenuOpen = true;

        public ClientForm()
        {
            InitializeComponent();

            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colourDialog1 = new System.Windows.Forms.ColorDialog();

            //Initialise the service model channel
            string address = "net.pipe://localhost/pipespacemaths";
            NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
            EndpointAddress ep = new EndpointAddress(address);
            channel = ChannelFactory<IAstroContract>.CreateChannel(binding, ep);
        }

        private void ClearAllTextBoxes()
        {
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
                tb.Clear();
            foreach (GroupBox gb in this.Controls.OfType<GroupBox>())
            {
                foreach (TextBox tb in gb.Controls.OfType<TextBox>())
                    tb.Clear();
            }
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
            try
            {
                double velocity = channel.StarVelocity(double.Parse(InputObserved.Text), double.Parse(InputRest.Text));

                //string[] data = new string[] { "velocity", "distance", "kelvin", "horizon" };
                string[] data = new string[] { InputName.Text, velocity.ToString("0.00 m/s"), "", "", "" };
                Display(data);
                ClearAllTextBoxes();
            }
            catch
            {
                MessageBox.Show("Failed to do calculation, make sure the server is running and that all required fields are filled", "Calculation Error");
            }
        }

        private void ButtonCalculateDistance_Click(object sender, EventArgs e)
        {
            try
            {
                double starDistance = channel.StarDistance(double.Parse(InputParallax.Text));

                string[] data = new string[] { InputName.Text, "", starDistance.ToString(), "", "" };
                Display(data);
                ClearAllTextBoxes();
            }
            catch
            {
                MessageBox.Show("Failed to do calculation, make sure the server is running and that all required fields are filled", "Calculation Error");
            }
        }

        private void ButtonCalculateTemperature_Click(object sender, EventArgs e)
        {
            try
            {
                double temperature = channel.TemperatureInKelvin(double.Parse(InputCelsius.Text));

                string[] data = new string[] { InputName.Text, "", "", temperature.ToString(), "" };
                Display(data);
                ClearAllTextBoxes();
            }
            catch
            {
                MessageBox.Show("Failed to do calculation, make sure the server is running and that all required fields are filled", "Calculation Error");
            }
        }

        private void ButtonCalculateHorizon_Click(object sender, EventArgs e)
        {
            try
            {
                double eventHorizon = channel.EventHorizon(double.Parse(InputMass.Text));

                string[] data = new string[] { InputName.Text, "", "", "", eventHorizon.ToString() };
                Display(data);
                ClearAllTextBoxes();
            }
            catch
            {
                MessageBox.Show("Failed to do calculation, make sure the server is running and that all required fields are filled", "Calculation Error");
            }
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
                e.Handled = true;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
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
                    //this.BackgroundImage = Properties.Resources.flag_english;

                    break;
                case "French":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-FR");
                    ButtonEnglish.Enabled = true;
                    ButtonFrench.Enabled = false;
                    ButtonGerman.Enabled = true;
                    //this.BackgroundImage = Properties.Resources.flag_french;

                    break;
                case "German":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("de-DE");
                    ButtonEnglish.Enabled = true;
                    ButtonFrench.Enabled = true;
                    ButtonGerman.Enabled = false;
                    //this.BackgroundImage = Properties.Resources.flag_german;

                    break;
            }
            Controls.Clear();
            InitializeComponent();
        }

        private void ButtonLight_Click(object sender, EventArgs e)
        {
            BackColor = SystemColors.Control;

            foreach (Button button in this.Controls.OfType<Button>())
                button.UseVisualStyleBackColor = true;
            foreach (Label label in this.Controls.OfType<Label>())
                label.ForeColor = SystemColors.ControlText;

            foreach (GroupBox gb in this.Controls.OfType<GroupBox>())
            {
                foreach (Button button in gb.Controls.OfType<Button>())
                    button.UseVisualStyleBackColor = true;

                foreach (Label label in gb.Controls.OfType<Label>())
                    label.ForeColor = SystemColors.ControlText;
            }
        }

        private void ButtonDark_Click(object sender, EventArgs e)
        {
            BackColor = SystemColors.ControlDark;

            foreach (Button button in this.Controls.OfType<Button>())
                button.UseVisualStyleBackColor = true;
            foreach (Label label in this.Controls.OfType<Label>())
                label.ForeColor = SystemColors.ControlText;

            foreach (GroupBox gb in this.Controls.OfType<GroupBox>())
            {
                foreach (Button button in gb.Controls.OfType<Button>())
                    button.UseVisualStyleBackColor = true;

                foreach (Label label in gb.Controls.OfType<Label>())
                    label.ForeColor = SystemColors.ControlText;
            }
        }

        private void ButtonColour_Click(object sender, EventArgs e)
        {
            if (colourDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Color myColor = colourDialog1.Color;

                foreach (Button label in this.Controls.OfType<Button>())
                    label.BackColor = myColor;
                foreach (GroupBox gb in this.Controls.OfType<GroupBox>())
                {
                    foreach (Button label in gb.Controls.OfType<Button>())
                        label.BackColor = myColor;
                }
            }
        }

        private void ButtonCustom_Click(object sender, EventArgs e)
        {
            if (colourDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Color myColor = colourDialog1.Color;
                this.BackColor = myColor;
                Byte r = (byte)(255 - BackColor.R);
                Byte g = (byte)(255 - BackColor.G);
                Byte b = (byte)(255 - BackColor.B);

                myColor = Color.FromArgb(r, g, b);

                foreach (Label label in this.Controls.OfType<Label>())
                    label.ForeColor = Color.FromArgb(r, g, b);
                foreach (GroupBox gb in this.Controls.OfType<GroupBox>())
                {
                    gb.ForeColor = Color.FromArgb(r, g, b);

                    foreach (Label label in gb.Controls.OfType<Label>())
                        label.ForeColor = Color.FromArgb(r, g, b);
                }
            }
        }

        private void ButtonFontColour_Click(object sender, EventArgs e)
        {
            if (colourDialog1.ShowDialog() != DialogResult.Cancel)
            {
                foreach (Label label in this.Controls.OfType<Label>()) 
                    label.ForeColor = colourDialog1.Color;
                foreach (GroupBox gb in this.Controls.OfType<GroupBox>())
                {
                    gb.ForeColor = colourDialog1.Color;

                    foreach (Label label in gb.Controls.OfType<Label>())
                        label.ForeColor = colourDialog1.Color;
                }
            }
        }

        private void ButtonFontStyle_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                foreach (Label label in this.Controls.OfType<Label>())
                    label.Font = fontDialog1.Font;
                foreach (GroupBox gb in this.Controls.OfType<GroupBox>())
                {
                    gb.Font = fontDialog1.Font;

                    foreach (Label label in gb.Controls.OfType<Label>())
                        label.Font = fontDialog1.Font;
                }
            }
        }

        private void ButtonTheme_Click(object sender, EventArgs e)
        {
            themeMenuOpen = !themeMenuOpen;

            ButtonLight.Visible = themeMenuOpen;
            ButtonDark.Visible = themeMenuOpen;
            ButtonCustom.Visible = themeMenuOpen;
        }

        private void ButtonLanguage_Click(object sender, EventArgs e)
        {
            languageMenuOpen = !languageMenuOpen;

            ButtonEnglish.Visible = languageMenuOpen;
            ButtonFrench.Visible = languageMenuOpen;
            ButtonGerman.Visible = languageMenuOpen;
        }

        private void ButtonColours_Click(object sender, EventArgs e)
        {
            coloursMenuOpen = !coloursMenuOpen;

            ButtonColour.Visible = coloursMenuOpen;
            ButtonFontColour.Visible = coloursMenuOpen;
            ButtonFontStyle.Visible = coloursMenuOpen;
        }
    }
}
