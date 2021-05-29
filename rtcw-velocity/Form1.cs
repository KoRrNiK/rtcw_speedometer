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


        private void timer1_Tick(object sender, EventArgs e)
        {
            processOpen = processOpen = m.OpenProcess("WolfSP");

            if (processOpen)
            {
                float value = m.ReadFloat("cgamex86.dll+FAFBC");
                int newvalue = (int)value;

                velocity_value.Text = newvalue.ToString();

            }
            else
            {
                velocity_value.Text = "N/A";
            }


        }


        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (FontFamily font in FontFamily.Families)
            {
                comboBox1.Items.Add(font.Name.ToString());
            }

            this.BackColor = Color.FromArgb(0, 255, 0);
            velocity_value.Text = "N/A";


            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        int mouseX = 0, mouseY = 0;
        bool mouseDown;

    
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.SetDesktopLocation(MousePosition.X - mouseX, MousePosition.Y - mouseY);
            }
        }


      
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                velocity_value.Font = new Font(comboBox1.Text, velocity_value.Font.Size);
            }
            catch { }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseX = e.X;
            mouseY = e.Y;
        }

    }
}
