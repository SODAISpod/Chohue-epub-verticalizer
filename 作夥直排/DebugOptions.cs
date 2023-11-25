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
    public partial class DebugOptions : Form
    {
        public DebugOptions()
        {
            InitializeComponent();
        }

        private void Btn_LoadXHtml_Click(object sender, EventArgs e)
        {

            ChoHoe.Properties.Settings.Default.Batch_DONOTVerticalize = true;

            ChoHoe.Properties.Settings.Default.Batch_ChineseConvert = true;
            ChoHoe.Properties.Settings.Default.Batch_ToTriditional = false;

            ChoHoe.Properties.Settings.Default.Batch_IfChangePageDirection = true;
            ChoHoe.Properties.Settings.Default.Batch_PageDirection = true;//ltr
            ChoHoe.Properties.Settings.Default.Batch_ReplaceImg = true;
            ChoHoe.Properties.Settings.Default.Batch_DONOTVerticalize = true;
            ChoHoe.Properties.Settings.Default.Batch_ConvertMobi = true;
            ChoHoe.Properties.Settings.Default.Batch_ConvertKepub = true;

            ChoHoe.Properties.Settings.Default.Batch_EmbedFont = true;
            //ToTradictional = ChoHoe.Properties.Settings.Default.ToTriditional;
            //ChoHoe.Properties.Settings.Default.Batch_RemoveCss = true;
            //ChoHoe.Properties.Settings.Default.Batch_RemoveStylesheet = true;
            //ChoHoe.Properties.Settings.Default.Batch_AddCustomizeCSS = true;
            ChoHoe.Properties.Settings.Default.Batch_ReplaceTwPunctuation = true;
            ChoHoe.Properties.Settings.Default.Batch_TurncateTitle = true;
            
            ChoHoe.Properties.Settings.Default.DecodeHtmlBeforeParsing = true;

            
            ((Form1)Owner).SetInitialValue();
        }

        private void btn_disableAllOption_Click(object sender, EventArgs e)
        {
            ChoHoe.Properties.Settings.Default.Batch_DONOTVerticalize = !true;

            ChoHoe.Properties.Settings.Default.Batch_ChineseConvert = !true;
            ChoHoe.Properties.Settings.Default.Batch_ToTriditional = !false;

            ChoHoe.Properties.Settings.Default.Batch_IfChangePageDirection = !true;
            ChoHoe.Properties.Settings.Default.Batch_PageDirection = !true;//ltr
            ChoHoe.Properties.Settings.Default.Batch_ReplaceImg = !true;
            ChoHoe.Properties.Settings.Default.Batch_DONOTVerticalize = !true;
            ChoHoe.Properties.Settings.Default.Batch_ConvertMobi = !true;
            ChoHoe.Properties.Settings.Default.Batch_ConvertKepub = !true;

            ChoHoe.Properties.Settings.Default.Batch_EmbedFont = !true;
            //ToTradictional = ChoHoe.Properties.Settings.Default.ToTriditional;
            //ChoHoe.Properties.Settings.Default.Batch_RemoveCss = true;
            //ChoHoe.Properties.Settings.Default.Batch_RemoveStylesheet = true;
            //ChoHoe.Properties.Settings.Default.Batch_AddCustomizeCSS = true;
            ChoHoe.Properties.Settings.Default.Batch_ReplaceTwPunctuation = !true;
            ChoHoe.Properties.Settings.Default.Batch_TurncateTitle = !true;

            ChoHoe.Properties.Settings.Default.DecodeHtmlBeforeParsing = !true;


            ((Form1)Owner).SetInitialValue();
        }

        private void btn_disableConvert_Click(object sender, EventArgs e)
        {
            ChoHoe.Properties.Settings.Default.Batch_ConvertMobi = !true;
            ChoHoe.Properties.Settings.Default.Batch_ConvertKepub = !true;
            ((Form1)Owner).SetInitialValue();
        }

        private void btn_enableConvert_Click(object sender, EventArgs e)
        {
            ChoHoe.Properties.Settings.Default.Batch_ConvertMobi = true;
            ChoHoe.Properties.Settings.Default.Batch_ConvertKepub = true;
            ((Form1)Owner).SetInitialValue();
        }
    }
}
