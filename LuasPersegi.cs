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
    public partial class LuasPersegi : UserControl
    {
        public LuasPersegi()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int val1 = (int)numParam1.Value;
            int result = val1 * val1;
            lblResult.Text = result.ToString();
        }
    }
}
