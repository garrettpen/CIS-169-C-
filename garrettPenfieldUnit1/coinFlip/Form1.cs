using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coinFlip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            
        private void exitButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showTailsButton_Click(object sender, EventArgs e)
        {
            headsPicture.Visible = false;
            tailsPicture.Visible = true;
        }

        private void showHeadsButton_Click(object sender, EventArgs e)
        {
            tailsPicture.Visible = false;
            headsPicture.Visible = true;
        }
    }
}
