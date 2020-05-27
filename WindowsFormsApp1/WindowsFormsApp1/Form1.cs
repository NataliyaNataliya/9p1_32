using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        ToolStripLabel timeLabel;
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AddStatusStrip();
        }

        private void buttonClick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Дмитрий лучший преподаватель в мире :)!","Инфо",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void CurPathInfoButtonTymoshenko_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Current Path Information: {Directory.GetCurrentDirectory()}");
        }
        private void buttonChangeColor_Click(object sender, EventArgs e)
        {
            string color = comboBoxChangeColor.Text;
            switch (color)
            {
                case "Default":
                    this.BackColor = SystemColors.Control;
                    break;
                case "White":
                    this.BackColor = Color.White;
                    break;
                case "Black":
                    this.BackColor = Color.Black;
                    break;
                case "Yellow":
                    this.BackColor = Color.Yellow;
                    break;
                case "Green":
                    this.BackColor = Color.Green;
                    break;
                case "Blue":
                    this.BackColor = Color.Blue;
                    break;
                case "Red":
                    this.BackColor = Color.Red;
                    break;
                case "Purple":
                    this.BackColor = Color.Purple;
                    break;
                case "Pink":
                    this.BackColor = Color.Pink;
                    break;
            }
        }
        private void buttonCloseApp_Click(object sender, EventArgs e)
        {
            double seconds = Convert.ToDouble(textBoxCloseApp.Text) * 1000;
            System.Timers.Timer timerClose = new System.Timers.Timer(seconds);
            timerClose.Elapsed += Timer_Elapsed;
            timerClose.Start();
        }

        private static void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Application.Exit();
        }
        
        public void AddStatusStrip()
        {
            StatusStrip ss = new StatusStrip();
            timeLabel = new ToolStripLabel();

            ss.Items.Add(timeLabel);

            Timer timer = new Timer() { Interval = 1000 };
            timer.Tick += timer_Tick;
            timer.Start();

            this.Controls.Add(ss);
        }

        void timer_Tick(object sender, EventArgs e)
        {
            
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
