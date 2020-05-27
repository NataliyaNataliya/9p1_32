using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Дмитрий лучший преподаватель в мире :)!","Инфо",MessageBoxButtons.OK,MessageBoxIcon.Warning);
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
    }
}
