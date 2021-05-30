using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace rtcw_velocity
{
    public partial class Form1 : Form
    {

        public Mem m = new Mem();

        public Form1()
        {
            InitializeComponent();
        }

        bool processOpen = false;
        bool isShow = false;
        bool isShowRecord = true;

        int pID = 0;

        int r = 252;
        int g = 3;
        int b = 3;

        float userMaxSpeed = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            processOpen = processOpen = m.OpenProcess("WolfSP");
            pID = m.GetProcIdFromName("WolfSP");

            if (processOpen)
            {
                float value = m.ReadFloat("cgamex86.dll+FAFBC");
                int newvalue = (int)value;

                userMaxSpeed = Math.Max(userMaxSpeed, value);

                int newmaxvalue = (int)userMaxSpeed;

                velocity_value.Text = newvalue.ToString();

                if (!isShowRecord)
                {
                    maxspeedlabel.Text = newmaxvalue.ToString();
                    recordspeedlabel.Text = "Max Speed:";
                }
                else
                {
                    maxspeedlabel.Text = "";
                    recordspeedlabel.Text = "";
                }


                processOpenLabel.ForeColor = Color.Green;
                processOpenLabel.Text = "Game Found";

                processID.ForeColor = Color.Green;
                processID.Text = pID.ToString();

                Properties.Settings.Default.maxspeed = userMaxSpeed;
                Properties.Settings.Default.Save();



            }
            else
            {
                velocity_value.Text = "N/A";

                processOpenLabel.ForeColor = Color.DarkRed;
                processOpenLabel.Text = "N/A";
            }


        }


        private void Form1_Load(object sender, EventArgs e)
        {

            timer3.Start();

            settingsPanel.Hide();

            foreach (FontFamily font in FontFamily.Families)
            {
                comboBox1.Items.Add(font.Name.ToString());
            }

            panel1.BackColor = Properties.Settings.Default.BackgroundColor;
            panel2.BackColor = Properties.Settings.Default.BackgroundColor;
            backgroundColor.BackColor = Properties.Settings.Default.BackgroundColor;

            velocity_value.ForeColor = Properties.Settings.Default.ColorText;
            maxspeedlabel.ForeColor = Properties.Settings.Default.ColorText;
            recordspeedlabel.ForeColor = Properties.Settings.Default.ColorText;
            fontColor.BackColor = Properties.Settings.Default.ColorText;

            velocity_value.Font = Properties.Settings.Default.Font;
            maxspeedlabel.Font = Properties.Settings.Default.Font;
            recordspeedlabel.Font = Properties.Settings.Default.Font;
            maxspeedlabel.Font = new Font(maxspeedlabel.Font.Name, 9, maxspeedlabel.Font.Style);
            recordspeedlabel.Font = new Font(recordspeedlabel.Font.Name, 9, recordspeedlabel.Font.Style);

            isShowRecord = Properties.Settings.Default.viewmaxspeed;
            button4.ForeColor = Color.FromArgb(isShowRecord ? 170 : 0, isShowRecord ? 0 : 240, 0);

            userMaxSpeed = Properties.Settings.Default.maxspeed;

            var cvt = new FontConverter();
            string s = cvt.ConvertToString(velocity_value.Font);
            Font f = cvt.ConvertFromString(s) as Font;
            comboBox1.Text = s;
            fontNameLabel.Text = s;


            velocity_value.Text = "N/A";


            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown && (settingsPanel.Width >= 150|| settingsPanel.Width <= 0))
            {
                this.SetDesktopLocation(!isShow ? MousePosition.X - mouseX : MousePosition.X - ( mouseX + 155 ), MousePosition.Y - mouseY);
            }
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
  
  
            if (settingsPanel.Visible)
            {
                isShow = false;
                timer2.Start();

            }
            else
            {
                isShow = true;
                settingsPanel.Show();
                timer2.Start();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                velocity_value.Font = new Font(comboBox1.Text, velocity_value.Font.Size);

                maxspeedlabel.Font = velocity_value.Font;
                maxspeedlabel.Font = new Font(maxspeedlabel.Font.Name, 9, maxspeedlabel.Font.Style);

                recordspeedlabel.Font = maxspeedlabel.Font;
                recordspeedlabel.Font = new Font(recordspeedlabel.Font.Name, 9, recordspeedlabel.Font.Style);


                var cvt = new FontConverter();
                string s = cvt.ConvertToString(velocity_value.Font);
                Font f = cvt.ConvertFromString(s) as Font;

                fontNameLabel.Text = s;
                Properties.Settings.Default.Font = velocity_value.Font;



                Properties.Settings.Default.Save();
            }
            catch { }
        }
     
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isShow)
            {
                if (settingsPanel.Width >= 150)
                {
                    timer2.Stop();
                }
                settingsPanel.Width += 30;
            } else{
                if (settingsPanel.Width <= 0)
                {
                    settingsPanel.Hide();
                    timer2.Stop();
                }
                settingsPanel.Width -= 30;
            }
        }

        private void backgroundColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog();

            if(colorPicker.ShowDialog() == DialogResult.OK)
            {
                backgroundColor.BackColor = colorPicker.Color;
                
                panel1.BackColor = colorPicker.Color;
                panel2.BackColor = colorPicker.Color;

                Properties.Settings.Default.BackgroundColor = panel1.BackColor;

                Properties.Settings.Default.Save();

            }
        }

        private void fontColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog();

            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                fontColor.BackColor = colorPicker.Color;

                velocity_value.ForeColor = colorPicker.Color;
                recordspeedlabel.ForeColor = colorPicker.Color;
                maxspeedlabel.ForeColor = colorPicker.Color;
                
                Properties.Settings.Default.ColorText = velocity_value.ForeColor;
                Properties.Settings.Default.Save();

            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseX = e.X;
            mouseY = e.Y;
            
        }


        // COLORS TITTLE

        private void timer3_Tick(object sender, EventArgs e)
        {
            g += 5;
            tittleProgram.ForeColor = Color.FromArgb(r, g, b);
            if (g <= 252)
            {
                timer3.Stop();
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            r -= 5;
            tittleProgram.ForeColor = Color.FromArgb(r, g, b);
            if (r <= 3)
            {
                timer4.Stop();
                timer5.Start();
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            b += 5;
            tittleProgram.ForeColor = Color.FromArgb(r, g, b);
            if (b >= 252)
            {
                timer5.Stop();
                timer6.Start();
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            g -= 5;
            tittleProgram.ForeColor = Color.FromArgb(r, g, b);
            if (g <= 3)
            {
                timer6.Stop();
                timer7.Start();
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            r += 5;
            tittleProgram.ForeColor = Color.FromArgb(r, g, b);
            if (r >= 252)
            {
                timer7.Stop();
                timer8.Start();
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            b -= 5;
            tittleProgram.ForeColor = Color.FromArgb(r, g, b);
            if (b <= 3)
            {
                timer8.Stop();
                timer3.Start();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            isShowRecord =! isShowRecord;

            Properties.Settings.Default.viewmaxspeed = isShowRecord;
            Properties.Settings.Default.Save();

            button4.ForeColor = Color.FromArgb(isShowRecord ? 170 : 0, isShowRecord ? 0 : 240, 0);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            userMaxSpeed = 0;
        }

        private void up_bar_button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
