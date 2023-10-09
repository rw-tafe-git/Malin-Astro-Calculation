namespace AstroClient
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.ListViewOutput = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.InputRest = new System.Windows.Forms.TextBox();
            this.InputObserved = new System.Windows.Forms.TextBox();
            this.ButtonCalculateVelocity = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InputParallax = new System.Windows.Forms.TextBox();
            this.ButtonCalculateDistance = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.InputCelsius = new System.Windows.Forms.TextBox();
            this.ButtonCalculateTemperature = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.InputMass = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.InputMass2 = new System.Windows.Forms.TextBox();
            this.ButtonCalculateHorizon = new System.Windows.Forms.Button();
            this.ButtonGerman = new System.Windows.Forms.Button();
            this.ButtonFrench = new System.Windows.Forms.Button();
            this.ButtonEnglish = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.MenuBackgroundColour = new System.Windows.Forms.MenuItem();
            this.MenuLight = new System.Windows.Forms.MenuItem();
            this.MenuDark = new System.Windows.Forms.MenuItem();
            this.MenuCustom = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.InputName = new System.Windows.Forms.TextBox();
            this.ButtonTheme = new System.Windows.Forms.Button();
            this.ButtonLanguage = new System.Windows.Forms.Button();
            this.ButtonColours = new System.Windows.Forms.Button();
            this.ButtonFontColour = new System.Windows.Forms.Button();
            this.ButtonFontStyle = new System.Windows.Forms.Button();
            this.ButtonDark = new System.Windows.Forms.Button();
            this.ButtonLight = new System.Windows.Forms.Button();
            this.ButtonCustom = new System.Windows.Forms.Button();
            this.ButtonColour = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputMass)).BeginInit();
            this.SuspendLayout();
            // 
            // ListViewOutput
            // 
            resources.ApplyResources(this.ListViewOutput, "ListViewOutput");
            this.ListViewOutput.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.ListViewOutput.HideSelection = false;
            this.ListViewOutput.Name = "ListViewOutput";
            this.ListViewOutput.UseCompatibleStateImageBehavior = false;
            this.ListViewOutput.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // columnHeader4
            // 
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // columnHeader5
            // 
            resources.ApplyResources(this.columnHeader5, "columnHeader5");
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.InputRest);
            this.groupBox1.Controls.Add(this.InputObserved);
            this.groupBox1.Controls.Add(this.ButtonCalculateVelocity);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // InputRest
            // 
            resources.ApplyResources(this.InputRest, "InputRest");
            this.InputRest.Name = "InputRest";
            this.InputRest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // InputObserved
            // 
            resources.ApplyResources(this.InputObserved, "InputObserved");
            this.InputObserved.Name = "InputObserved";
            this.InputObserved.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // ButtonCalculateVelocity
            // 
            resources.ApplyResources(this.ButtonCalculateVelocity, "ButtonCalculateVelocity");
            this.ButtonCalculateVelocity.Name = "ButtonCalculateVelocity";
            this.ButtonCalculateVelocity.UseVisualStyleBackColor = true;
            this.ButtonCalculateVelocity.Click += new System.EventHandler(this.ButtonCalculateVelocity_Click);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.InputParallax);
            this.groupBox2.Controls.Add(this.ButtonCalculateDistance);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // InputParallax
            // 
            resources.ApplyResources(this.InputParallax, "InputParallax");
            this.InputParallax.Name = "InputParallax";
            this.InputParallax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // ButtonCalculateDistance
            // 
            resources.ApplyResources(this.ButtonCalculateDistance, "ButtonCalculateDistance");
            this.ButtonCalculateDistance.Name = "ButtonCalculateDistance";
            this.ButtonCalculateDistance.UseVisualStyleBackColor = true;
            this.ButtonCalculateDistance.Click += new System.EventHandler(this.ButtonCalculateDistance_Click);
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.InputCelsius);
            this.groupBox3.Controls.Add(this.ButtonCalculateTemperature);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // InputCelsius
            // 
            resources.ApplyResources(this.InputCelsius, "InputCelsius");
            this.InputCelsius.Name = "InputCelsius";
            this.InputCelsius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // ButtonCalculateTemperature
            // 
            resources.ApplyResources(this.ButtonCalculateTemperature, "ButtonCalculateTemperature");
            this.ButtonCalculateTemperature.Name = "ButtonCalculateTemperature";
            this.ButtonCalculateTemperature.UseVisualStyleBackColor = true;
            this.ButtonCalculateTemperature.Click += new System.EventHandler(this.ButtonCalculateTemperature_Click);
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.InputMass);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.InputMass2);
            this.groupBox4.Controls.Add(this.ButtonCalculateHorizon);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // InputMass
            // 
            resources.ApplyResources(this.InputMass, "InputMass");
            this.InputMass.Name = "InputMass";
            this.InputMass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // InputMass2
            // 
            resources.ApplyResources(this.InputMass2, "InputMass2");
            this.InputMass2.Name = "InputMass2";
            this.InputMass2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // ButtonCalculateHorizon
            // 
            resources.ApplyResources(this.ButtonCalculateHorizon, "ButtonCalculateHorizon");
            this.ButtonCalculateHorizon.Name = "ButtonCalculateHorizon";
            this.ButtonCalculateHorizon.UseVisualStyleBackColor = true;
            this.ButtonCalculateHorizon.Click += new System.EventHandler(this.ButtonCalculateHorizon_Click);
            // 
            // ButtonGerman
            // 
            resources.ApplyResources(this.ButtonGerman, "ButtonGerman");
            this.ButtonGerman.BackgroundImage = global::AstroClient.Properties.Resources.flag_german;
            this.ButtonGerman.Name = "ButtonGerman";
            this.ButtonGerman.UseVisualStyleBackColor = true;
            this.ButtonGerman.Click += new System.EventHandler(this.ButtonGerman_Click);
            // 
            // ButtonFrench
            // 
            resources.ApplyResources(this.ButtonFrench, "ButtonFrench");
            this.ButtonFrench.BackgroundImage = global::AstroClient.Properties.Resources.flag_french;
            this.ButtonFrench.Name = "ButtonFrench";
            this.ButtonFrench.UseVisualStyleBackColor = true;
            this.ButtonFrench.Click += new System.EventHandler(this.ButtonFrench_Click);
            // 
            // ButtonEnglish
            // 
            resources.ApplyResources(this.ButtonEnglish, "ButtonEnglish");
            this.ButtonEnglish.BackgroundImage = global::AstroClient.Properties.Resources.flag_english;
            this.ButtonEnglish.Name = "ButtonEnglish";
            this.ButtonEnglish.UseVisualStyleBackColor = true;
            this.ButtonEnglish.Click += new System.EventHandler(this.ButtonEnglish_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1});
            resources.ApplyResources(this.MainMenu, "MainMenu");
            // 
            // menuItem1
            // 
            resources.ApplyResources(this.menuItem1, "menuItem1");
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuBackgroundColour,
            this.menuItem3,
            this.menuItem4});
            // 
            // MenuBackgroundColour
            // 
            resources.ApplyResources(this.MenuBackgroundColour, "MenuBackgroundColour");
            this.MenuBackgroundColour.Index = 0;
            this.MenuBackgroundColour.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuLight,
            this.MenuDark,
            this.MenuCustom});
            // 
            // MenuLight
            // 
            resources.ApplyResources(this.MenuLight, "MenuLight");
            this.MenuLight.Index = 0;
            this.MenuLight.Click += new System.EventHandler(this.ButtonLight_Click);
            // 
            // MenuDark
            // 
            resources.ApplyResources(this.MenuDark, "MenuDark");
            this.MenuDark.Index = 1;
            this.MenuDark.Click += new System.EventHandler(this.ButtonDark_Click);
            // 
            // MenuCustom
            // 
            resources.ApplyResources(this.MenuCustom, "MenuCustom");
            this.MenuCustom.Index = 2;
            this.MenuCustom.Click += new System.EventHandler(this.ButtonCustom_Click);
            // 
            // menuItem3
            // 
            resources.ApplyResources(this.menuItem3, "menuItem3");
            this.menuItem3.Index = 1;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem8,
            this.menuItem9});
            // 
            // menuItem2
            // 
            resources.ApplyResources(this.menuItem2, "menuItem2");
            this.menuItem2.Index = 0;
            this.menuItem2.Click += new System.EventHandler(this.ButtonEnglish_Click);
            // 
            // menuItem8
            // 
            resources.ApplyResources(this.menuItem8, "menuItem8");
            this.menuItem8.Index = 1;
            this.menuItem8.Click += new System.EventHandler(this.ButtonFrench_Click);
            // 
            // menuItem9
            // 
            resources.ApplyResources(this.menuItem9, "menuItem9");
            this.menuItem9.Index = 2;
            this.menuItem9.Click += new System.EventHandler(this.ButtonGerman_Click);
            // 
            // menuItem4
            // 
            resources.ApplyResources(this.menuItem4, "menuItem4");
            this.menuItem4.Index = 2;
            this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem5,
            this.menuItem6,
            this.menuItem7});
            // 
            // menuItem5
            // 
            resources.ApplyResources(this.menuItem5, "menuItem5");
            this.menuItem5.Index = 0;
            this.menuItem5.Click += new System.EventHandler(this.ButtonColour_Click);
            // 
            // menuItem6
            // 
            resources.ApplyResources(this.menuItem6, "menuItem6");
            this.menuItem6.Index = 1;
            this.menuItem6.Click += new System.EventHandler(this.ButtonFontColour_Click);
            // 
            // menuItem7
            // 
            resources.ApplyResources(this.menuItem7, "menuItem7");
            this.menuItem7.Index = 2;
            this.menuItem7.Click += new System.EventHandler(this.ButtonFontStyle_Click);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // InputName
            // 
            resources.ApplyResources(this.InputName, "InputName");
            this.InputName.Name = "InputName";
            // 
            // ButtonTheme
            // 
            resources.ApplyResources(this.ButtonTheme, "ButtonTheme");
            this.ButtonTheme.Name = "ButtonTheme";
            this.ButtonTheme.UseVisualStyleBackColor = true;
            this.ButtonTheme.Click += new System.EventHandler(this.ButtonTheme_Click);
            // 
            // ButtonLanguage
            // 
            resources.ApplyResources(this.ButtonLanguage, "ButtonLanguage");
            this.ButtonLanguage.Name = "ButtonLanguage";
            this.ButtonLanguage.UseVisualStyleBackColor = true;
            this.ButtonLanguage.Click += new System.EventHandler(this.ButtonLanguage_Click);
            // 
            // ButtonColours
            // 
            resources.ApplyResources(this.ButtonColours, "ButtonColours");
            this.ButtonColours.Name = "ButtonColours";
            this.ButtonColours.UseVisualStyleBackColor = true;
            this.ButtonColours.Click += new System.EventHandler(this.ButtonColours_Click);
            // 
            // ButtonFontColour
            // 
            resources.ApplyResources(this.ButtonFontColour, "ButtonFontColour");
            this.ButtonFontColour.Name = "ButtonFontColour";
            this.ButtonFontColour.UseVisualStyleBackColor = true;
            this.ButtonFontColour.Click += new System.EventHandler(this.ButtonFontColour_Click);
            // 
            // ButtonFontStyle
            // 
            resources.ApplyResources(this.ButtonFontStyle, "ButtonFontStyle");
            this.ButtonFontStyle.Name = "ButtonFontStyle";
            this.ButtonFontStyle.UseVisualStyleBackColor = true;
            this.ButtonFontStyle.Click += new System.EventHandler(this.ButtonFontStyle_Click);
            // 
            // ButtonDark
            // 
            resources.ApplyResources(this.ButtonDark, "ButtonDark");
            this.ButtonDark.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ButtonDark.Name = "ButtonDark";
            this.ButtonDark.UseVisualStyleBackColor = false;
            this.ButtonDark.Click += new System.EventHandler(this.ButtonDark_Click);
            // 
            // ButtonLight
            // 
            resources.ApplyResources(this.ButtonLight, "ButtonLight");
            this.ButtonLight.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonLight.Name = "ButtonLight";
            this.ButtonLight.UseVisualStyleBackColor = false;
            this.ButtonLight.Click += new System.EventHandler(this.ButtonLight_Click);
            // 
            // ButtonCustom
            // 
            resources.ApplyResources(this.ButtonCustom, "ButtonCustom");
            this.ButtonCustom.Name = "ButtonCustom";
            this.ButtonCustom.UseVisualStyleBackColor = true;
            this.ButtonCustom.Click += new System.EventHandler(this.ButtonCustom_Click);
            // 
            // ButtonColour
            // 
            resources.ApplyResources(this.ButtonColour, "ButtonColour");
            this.ButtonColour.Name = "ButtonColour";
            this.ButtonColour.UseVisualStyleBackColor = true;
            this.ButtonColour.Click += new System.EventHandler(this.ButtonColour_Click);
            // 
            // ClientForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonTheme);
            this.Controls.Add(this.ButtonLanguage);
            this.Controls.Add(this.ButtonColours);
            this.Controls.Add(this.ButtonDark);
            this.Controls.Add(this.ButtonLight);
            this.Controls.Add(this.ButtonFontColour);
            this.Controls.Add(this.InputName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ButtonFrench);
            this.Controls.Add(this.ButtonEnglish);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ListViewOutput);
            this.Controls.Add(this.ButtonCustom);
            this.Controls.Add(this.ButtonGerman);
            this.Controls.Add(this.ButtonFontStyle);
            this.Controls.Add(this.ButtonColour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Menu = this.MainMenu;
            this.Name = "ClientForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputMass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListViewOutput;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button ButtonEnglish;
        private System.Windows.Forms.Button ButtonFrench;
        private System.Windows.Forms.Button ButtonGerman;
        private System.Windows.Forms.Button ButtonCalculateVelocity;
        private System.Windows.Forms.Button ButtonCalculateDistance;
        private System.Windows.Forms.Button ButtonCalculateTemperature;
        private System.Windows.Forms.Button ButtonCalculateHorizon;
        private System.Windows.Forms.TextBox InputRest;
        private System.Windows.Forms.TextBox InputObserved;
        private System.Windows.Forms.TextBox InputParallax;
        private System.Windows.Forms.TextBox InputCelsius;
        private System.Windows.Forms.TextBox InputMass2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown InputMass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MainMenu MainMenu;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem MenuBackgroundColour;
        private System.Windows.Forms.MenuItem MenuLight;
        private System.Windows.Forms.MenuItem MenuDark;
        private System.Windows.Forms.MenuItem MenuCustom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox InputName;
        private System.Windows.Forms.Button ButtonTheme;
        private System.Windows.Forms.Button ButtonLanguage;
        private System.Windows.Forms.Button ButtonColours;
        private System.Windows.Forms.Button ButtonFontColour;
        private System.Windows.Forms.Button ButtonFontStyle;
        private System.Windows.Forms.Button ButtonDark;
        private System.Windows.Forms.Button ButtonLight;
        private System.Windows.Forms.Button ButtonCustom;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button ButtonColour;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem7;
    }
}

