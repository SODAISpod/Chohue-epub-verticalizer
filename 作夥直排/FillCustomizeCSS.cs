using ExCSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChoHoe
{
    public partial class FillCustomizeCSS : MetroFramework.Forms.MetroForm
    {
        public FillCustomizeCSS()
        {
            InitializeComponent();
        }

        private void rtb_CSS_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            ChoHoe.Properties.Settings.Default.CustomizedCSS=rtb_CSS.Text;
            ChoHoe.Properties.Settings.Default.Save();
        }

        private void FillCustomizeCSS_Load(object sender, EventArgs e)
        {
            rtb_CSS.Text = ChoHoe.Properties.Settings.Default.CustomizedCSS;
        }
    }
}
