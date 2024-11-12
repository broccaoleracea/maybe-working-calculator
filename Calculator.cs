using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc_app
{
    public partial class Calculator : Form
    {
        private Main mainForm;

        public Calculator(Main parentForm)
        {
            InitializeComponent();
            mainForm = parentForm;
        }

        private void Calculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Show();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int val1 = (int)numParam1.Value;
            int val2 = (int)numParam2.Value;
            int result = val1 + val2;
            lblResult.Text = result.ToString();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            int val1 = (int)numParam1.Value;
            int val2 = (int)numParam2.Value;
            int result = val1 - val2;
            lblResult.Text = result.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            int val1 = (int)numParam1.Value;
            int val2 = (int)numParam2.Value;
            if (val2 == 0)
            {
                MessageBox.Show("Diving by zero is not allowed.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int result = val1 / val2;
                lblResult.Text = result.ToString();
            }
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            int val1 = (int)numParam1.Value;
            int val2 = (int)numParam2.Value;
            int result = val1 * val2;
            lblResult.Text = result.ToString();
        }
    }
}
