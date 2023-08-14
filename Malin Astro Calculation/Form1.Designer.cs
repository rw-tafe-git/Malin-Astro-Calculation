namespace Malin_Astro_Calculation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(251, 66);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Star Velocity";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(12, 108);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(251, 69);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Start Distance";
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(12, 203);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(251, 68);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Temperature";
            // 
            // groupBox4
            // 
            groupBox4.Location = new Point(12, 324);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(251, 85);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Event Horizon";
            // 
            // button1
            // 
            button1.Location = new Point(297, 353);
            button1.Name = "button1";
            button1.Size = new Size(135, 56);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(459, 353);
            button2.Name = "button2";
            button2.Size = new Size(135, 56);
            button2.TabIndex = 5;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(627, 353);
            button3.Name = "button3";
            button3.Size = new Size(135, 56);
            button3.TabIndex = 6;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listView1.Location = new Point(297, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(465, 335);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Test";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button button1;
        private Button button2;
        private Button button3;
        private ListView listView1;
        private ColumnHeader columnHeader1;
    }
}