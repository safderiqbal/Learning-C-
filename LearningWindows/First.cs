using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LearningWindows
{
    public partial class First : Form
    {
        public First()
        {
            InitializeComponent();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            exit();
        }

        private void mIExit_Click(object sender, EventArgs e)
        {
            exit();
        }

        private void exit()
        {
            Environment.Exit(0);
        }

        private void mINew_Click(object sender, EventArgs e)
        {
            //exit();
        }
    }
}
