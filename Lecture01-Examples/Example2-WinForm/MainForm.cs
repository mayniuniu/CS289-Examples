using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example2_WinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text ="Hello " + nameTextBox.Text;
            //MessageBox.Show("Hello " + nameTextBox.Text);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            messageLabel.Text = "";
        }
    }
}
