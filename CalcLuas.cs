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
    public partial class CalcLuas : Form
    {
        private Main mainForm;
        public CalcLuas(Main mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LuasPersegi luasPersegi = new LuasPersegi();
            panel1.Controls.Clear();
            panel1.Controls.Add(luasPersegi);
            luasPersegi.Dock=DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LuasPerPanjang luasPerPanjang = new LuasPerPanjang();
            panel1.Controls.Clear();
            panel1.Controls.Add(luasPerPanjang);
            luasPerPanjang.Dock = DockStyle.Fill;
        }

        private void CalcLuas_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Show();
        }
    }
}
