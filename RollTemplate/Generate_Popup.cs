using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RollTemplate
{
    public partial class Generate_Popup : Form
    {
        public Generate_Popup()
        {
            InitializeComponent();
        }

        public void InitializeScreen (string value)
        {
            textBox1.Text = value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }
    }
}
