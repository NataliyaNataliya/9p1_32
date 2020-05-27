using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
