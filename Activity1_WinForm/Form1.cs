using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity1_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Activity # 1";
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "Jhon Eric Aton";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
        }

        private void btnSection_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "BSIT 1-1";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
