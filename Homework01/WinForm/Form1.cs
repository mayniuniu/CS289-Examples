using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            outputLabel.Text = String.Format("{0} 的基本資料\n身高: {1} ft\n" +
                "體重: {2} lbs", nameTextbox.Text, heightTextbox.Text, weightTextbox.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            outputLabel.Text = "";
        }
    }
}