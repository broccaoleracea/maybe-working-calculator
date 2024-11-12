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
    public partial class LuasPerPanjang : UserControl
    {
        public LuasPerPanjang()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            var val1 = (int)numParam1.Value;
            var val2 = (int)numParam2.Value;
            var result = val1 * val2;
            lblResult.Text =  result.ToString();
        }
    }
}
