using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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

        private void CurPathInfoButtonTymoshenko_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Current Path Information: {Directory.GetCurrentDirectory()}");
        }
    }
}
