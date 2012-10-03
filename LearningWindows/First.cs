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

        /// <summary>
        /// Initialises the object
        /// </summary>

        public First()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Concludes the program running when the exit button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void bExit_Click(object sender, EventArgs e)
        {
            exit();
        }

        /// <summary>
        /// Colcludes te program running when the exit menu option is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void mIExit_Click(object sender, EventArgs e)
        {
            exit();
        }

        /// <summary>
        /// Exit helper method
        /// </summary>

        private void exit()
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// Displays temporary message when the start button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void bStart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You only live once.", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
