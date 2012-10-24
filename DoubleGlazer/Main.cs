using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DoubleGlazer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbHeight.SelectedIndex) != -1 && Convert.ToInt32(cmbWidth.SelectedIndex) != -1)
            {
             //   var result = MessageBox.Show("Height: " + cmbHeight.SelectedItem.ToString() + " & Width: " + cmbWidth.SelectedItem.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                var result = MessageBox.Show("Glass Area: " + Convert.ToString(Convert.ToInt32(txtbHeight.Text) * Convert.ToInt32(txtbWidth.Text)));
                if (result == DialogResult.OK)
                {
                    Environment.Exit(0);
                } // if
            } // if
        }

        private void txtbWidth_Enter(object sender, EventArgs e)
        {
            if (txtbWidth.Text.Equals("0"))
            {
                txtbWidth.Text = "";
                txtbWidth.ForeColor = Color.Black;
            } // if
        }

        private void txtbHeight_Enter(object sender, EventArgs e)
        {
            if (txtbHeight.Text.Equals("0"))
            {
                txtbHeight.Text = "";
                txtbHeight.ForeColor = Color.Black;
            } // if
        }
    }
}
