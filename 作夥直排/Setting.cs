using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChoHoe
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
            if(ChoHoe.Properties.Settings.Default.UseCalibre==true)
            {
                OutputMobiUsingCalibre.Checked = true;

            }
            else
            {
                OutputMobiUsingKindlegen.Checked = true;
            }
            CheckKindlegenPathIsValid();
            CheckCalibrePathIsValid();
            CheckPandocPathIsValid();
            linklbPacdoc.Text = ChoHoe.Properties.Settings.Default.PandocPath;
            LinkLBCalibrePath.Text = ChoHoe.Properties.Settings.Default.CalibrePath;
            LinkLBKinflegenPath.Text = ChoHoe.Properties.Settings.Default.KindlegenPath;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FolderBrowserDialog CalibrePath = new FolderBrowserDialog();
            if (CalibrePath.ShowDialog()==DialogResult.OK)
            {
                LinkLBCalibrePath.Text = CalibrePath.SelectedPath;
                ChoHoe.Properties.Settings.Default.CalibrePath = CalibrePath.SelectedPath;
                ChoHoe.Properties.Settings.Default.Save();
                CheckCalibrePathIsValid();

            }
        }
        private bool CheckCalibrePathIsValid()
        {
            string ExeName = "ebook-convert.exe";
            string CalibrePath = ChoHoe.Properties.Settings.Default.CalibrePath;
            if (!File.Exists(CalibrePath + "\\" + ExeName))
            {
                CalibrePathValidResult.Text = "路徑無效!";
                return false;
            }
            CalibrePathValidResult.Text = "✓";
            return true;

        }

        private void linkLBCalibrePathCheck_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckCalibrePathIsValid();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckKindlegenPathIsValid();
        }

        private bool CheckKindlegenPathIsValid()
        {
            string ExeName = "kindlegen.exe";
            string KindlegenPath = ChoHoe.Properties.Settings.Default.KindlegenPath;
            if (!File.Exists(KindlegenPath + "\\" + ExeName))
            {
                KindlegenPathValidResult.Text = "路徑無效!";
                return false;
            }
            KindlegenPathValidResult.Text = "✓";
            return true;
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FolderBrowserDialog KinglegenPath = new FolderBrowserDialog();
            if (KinglegenPath.ShowDialog() == DialogResult.OK)
            {
                LinkLBKinflegenPath.Text = KinglegenPath.SelectedPath;
                ChoHoe.Properties.Settings.Default.KindlegenPath = KinglegenPath.SelectedPath;
                ChoHoe.Properties.Settings.Default.Save();
                CheckKindlegenPathIsValid();

            }
        }

        private void OutputMobiUsingCalibre_CheckedChanged(object sender, EventArgs e)
        {
            if (OutputMobiUsingCalibre.Checked)
            {
                ChoHoe.Properties.Settings.Default.UseCalibre = true;
                ChoHoe.Properties.Settings.Default.Save();
            }
            else
            {
                ChoHoe.Properties.Settings.Default.UseCalibre = false;
                ChoHoe.Properties.Settings.Default.Save();
            }
     
        }

        private void OutputMobiUsingKindlegen_CheckedChanged(object sender, EventArgs e)
        {
            if (OutputMobiUsingCalibre.Checked)
            {
                ChoHoe.Properties.Settings.Default.UseCalibre = true;
                ChoHoe.Properties.Settings.Default.Save();
            }
            else
            {
                ChoHoe.Properties.Settings.Default.UseCalibre = false;
                ChoHoe.Properties.Settings.Default.Save();
            }

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckPandocPathIsValid();
        }

        private bool CheckPandocPathIsValid()
        {
            string ExeName = "pandoc.exe";
            string PandocPath = ChoHoe.Properties.Settings.Default.PandocPath;
            if (!File.Exists(PandocPath + "\\" + ExeName))
            {
                PandocPathValidResult.Text = "路徑無效!";
                return false;
            }
            PandocPathValidResult.Text = "✓";
            return true;
        }

        private void linklbPacdoc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FolderBrowserDialog PandocPath = new FolderBrowserDialog();
            if (PandocPath.ShowDialog() == DialogResult.OK)
            {
                linklbPacdoc.Text = PandocPath.SelectedPath;
                ChoHoe.Properties.Settings.Default.PandocPath = PandocPath.SelectedPath;
                ChoHoe.Properties.Settings.Default.Save();
                CheckPandocPathIsValid();

            }
        }

        private void mobi_manual_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://kiicho.cc/Chohue/sidebar/manual.php?utm_source=Chehue&utm_medium=InSetting&utm_campaign=Plugin_mobi&utm_content=manual_install_plugin#v-pills-install");
        }

        private void epub_manual_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://kiicho.cc/Chohue/sidebar/manual.php?utm_source=Chehue&utm_medium=InSetting&utm_campaign=Plugin_epub&utm_content=manual_install_plugin#v-pills-install");
        }
    }
}
