
namespace rtcw_velocity
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.fontNameLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tittleProgram = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.processOpenLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.processID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fontColor = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundColor = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.velocity_value = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.maxspeedlabel = new System.Windows.Forms.Label();
            this.recordspeedlabel = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.timer7 = new System.Windows.Forms.Timer(this.components);
            this.timer8 = new System.Windows.Forms.Timer(this.components);
            this.settingsPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundColor)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 11;
            this.comboBox1.Location = new System.Drawing.Point(55, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(89, 19);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // settingsPanel
            // 
            this.settingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.settingsPanel.Controls.Add(this.button4);
            this.settingsPanel.Controls.Add(this.button3);
            this.settingsPanel.Controls.Add(this.fontNameLabel);
            this.settingsPanel.Controls.Add(this.panel5);
            this.settingsPanel.Controls.Add(this.panel4);
            this.settingsPanel.Controls.Add(this.panel3);
            this.settingsPanel.Controls.Add(this.processOpenLabel);
            this.settingsPanel.Controls.Add(this.label8);
            this.settingsPanel.Controls.Add(this.processID);
            this.settingsPanel.Controls.Add(this.label5);
            this.settingsPanel.Controls.Add(this.fontColor);
            this.settingsPanel.Controls.Add(this.label4);
            this.settingsPanel.Controls.Add(this.label3);
            this.settingsPanel.Controls.Add(this.label2);
            this.settingsPanel.Controls.Add(this.backgroundColor);
            this.settingsPanel.Controls.Add(this.comboBox1);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.settingsPanel.Location = new System.Drawing.Point(0, 0);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(150, 242);
            this.settingsPanel.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(14, 155);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 27;
            this.button4.Text = "Max Speed";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(85)))));
            this.button3.Location = new System.Drawing.Point(13, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "Reset Speed";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // fontNameLabel
            // 
            this.fontNameLabel.AutoSize = true;
            this.fontNameLabel.Font = new System.Drawing.Font("Segoe UI", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fontNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(85)))));
            this.fontNameLabel.Location = new System.Drawing.Point(55, 79);
            this.fontNameLabel.Name = "fontNameLabel";
            this.fontNameLabel.Size = new System.Drawing.Size(40, 10);
            this.fontNameLabel.TabIndex = 24;
            this.fontNameLabel.Text = "name Font:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 240);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(147, 2);
            this.panel5.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.tittleProgram);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 33);
            this.panel4.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 10);
            this.label1.TabIndex = 23;
            this.label1.Text = "by KoRrNiK";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.panel6.Location = new System.Drawing.Point(5, 17);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(118, 1);
            this.panel6.TabIndex = 22;
            // 
            // tittleProgram
            // 
            this.tittleProgram.AutoSize = true;
            this.tittleProgram.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tittleProgram.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tittleProgram.Location = new System.Drawing.Point(2, 3);
            this.tittleProgram.Name = "tittleProgram";
            this.tittleProgram.Size = new System.Drawing.Size(118, 15);
            this.tittleProgram.TabIndex = 21;
            this.tittleProgram.Text = "RtCW - Speedometer";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(147, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 242);
            this.panel3.TabIndex = 20;
            // 
            // processOpenLabel
            // 
            this.processOpenLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.processOpenLabel.AutoSize = true;
            this.processOpenLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.processOpenLabel.Font = new System.Drawing.Font("Montserrat", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.processOpenLabel.ForeColor = System.Drawing.Color.Maroon;
            this.processOpenLabel.Location = new System.Drawing.Point(56, 218);
            this.processOpenLabel.Name = "processOpenLabel";
            this.processOpenLabel.Size = new System.Drawing.Size(18, 10);
            this.processOpenLabel.TabIndex = 19;
            this.processOpenLabel.Text = "N/A";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(3, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 10);
            this.label8.TabIndex = 18;
            this.label8.Text = "Process Open:";
            // 
            // processID
            // 
            this.processID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.processID.AutoSize = true;
            this.processID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.processID.Font = new System.Drawing.Font("Montserrat", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.processID.ForeColor = System.Drawing.Color.Maroon;
            this.processID.Location = new System.Drawing.Point(71, 228);
            this.processID.Name = "processID";
            this.processID.Size = new System.Drawing.Size(18, 10);
            this.processID.TabIndex = 17;
            this.processID.Text = "N/A";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(3, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 10);
            this.label5.TabIndex = 16;
            this.label5.Text = "WolfSP Process ID:";
            // 
            // fontColor
            // 
            this.fontColor.BackColor = System.Drawing.Color.Red;
            this.fontColor.Location = new System.Drawing.Point(93, 128);
            this.fontColor.Name = "fontColor";
            this.fontColor.Size = new System.Drawing.Size(25, 15);
            this.fontColor.TabIndex = 13;
            this.fontColor.TabStop = false;
            this.fontColor.Click += new System.EventHandler(this.fontColor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(15, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Font Color:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(15, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "BG Color:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Font:";
            // 
            // backgroundColor
            // 
            this.backgroundColor.BackColor = System.Drawing.Color.Red;
            this.backgroundColor.Location = new System.Drawing.Point(93, 101);
            this.backgroundColor.Name = "backgroundColor";
            this.backgroundColor.Size = new System.Drawing.Size(25, 15);
            this.backgroundColor.TabIndex = 8;
            this.backgroundColor.TabStop = false;
            this.backgroundColor.Click += new System.EventHandler(this.backgroundColor_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(150, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 33);
            this.panel1.TabIndex = 10;
            this.panel1.DoubleClick += new System.EventHandler(this.panel1_DoubleClick);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(187, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 24);
            this.button2.TabIndex = 1;
            this.button2.Text = "–";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(212, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "✖";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // velocity_value
            // 
            this.velocity_value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.velocity_value.AutoSize = true;
            this.velocity_value.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.velocity_value.Font = new System.Drawing.Font("Montserrat Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.velocity_value.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.velocity_value.Location = new System.Drawing.Point(0, 122);
            this.velocity_value.Name = "velocity_value";
            this.velocity_value.Size = new System.Drawing.Size(221, 66);
            this.velocity_value.TabIndex = 0;
            this.velocity_value.Text = "velocity";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lime;
            this.panel2.Controls.Add(this.maxspeedlabel);
            this.panel2.Controls.Add(this.recordspeedlabel);
            this.panel2.Controls.Add(this.velocity_value);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(150, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 209);
            this.panel2.TabIndex = 11;
            // 
            // maxspeedlabel
            // 
            this.maxspeedlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.maxspeedlabel.AutoSize = true;
            this.maxspeedlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxspeedlabel.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maxspeedlabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.maxspeedlabel.Location = new System.Drawing.Point(88, 176);
            this.maxspeedlabel.Name = "maxspeedlabel";
            this.maxspeedlabel.Size = new System.Drawing.Size(78, 16);
            this.maxspeedlabel.TabIndex = 2;
            this.maxspeedlabel.Text = "max.value";
            // 
            // recordspeedlabel
            // 
            this.recordspeedlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.recordspeedlabel.AutoSize = true;
            this.recordspeedlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recordspeedlabel.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.recordspeedlabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.recordspeedlabel.Location = new System.Drawing.Point(6, 176);
            this.recordspeedlabel.Name = "recordspeedlabel";
            this.recordspeedlabel.Size = new System.Drawing.Size(85, 16);
            this.recordspeedlabel.TabIndex = 1;
            this.recordspeedlabel.Text = "Max Speed:";
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // timer7
            // 
            this.timer7.Tick += new System.EventHandler(this.timer7_Tick);
            // 
            // timer8
            // 
            this.timer8.Tick += new System.EventHandler(this.timer8_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(388, 242);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.settingsPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RtCW - Speedometer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundColor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label velocity_value;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox backgroundColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox fontColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label processOpenLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label processID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label tittleProgram;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label fontNameLabel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.Timer timer7;
        private System.Windows.Forms.Timer timer8;
        private System.Windows.Forms.Label recordspeedlabel;
        private System.Windows.Forms.Label maxspeedlabel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}

