﻿using System;
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
    public partial class Setting : MetroFramework.Forms.MetroForm
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

            tgUseBuiltin.Checked = ChoHoe.Properties.Settings.Default.Setting_UseBuiltinIMG;
            ReloadImg();
            
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
            ExtensionChecker.CheckAll();
            if (!ExtensionChecker.calibreStatus)
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
            ExtensionChecker.CheckAll();
            if (!ExtensionChecker.kindleGenStatus)
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
                ChoHoe.Properties.Settings.Default.KindlegenPath =  KinglegenPath.SelectedPath;
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

            ExtensionChecker.CheckAll();
            if (!ExtensionChecker.pandocStatus)
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
                ChoHoe.Properties.Settings.Default.PandocPath =  PandocPath.SelectedPath;
                ChoHoe.Properties.Settings.Default.Save();
                CheckPandocPathIsValid();

            }
        }

        private void Mobi_manual_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://kiicho.cc/Chohue/sidebar/manual.php?utm_source=Chehue&utm_medium=InApp&utm_campaign=InSetting_Plugin_mobi&utm_content=manual_install_plugin#v-pills-install");
        }

        private void Epub_manual_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://kiicho.cc/Chohue/sidebar/manual.php?utm_source=Chehue&utm_medium=InApp&utm_campaign=InSetting_Plugin_epub&utm_content=manual_install_plugin#v-pills-install");
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            CheckCalibrePathIsValid();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            CheckKindlegenPathIsValid();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            CheckPandocPathIsValid();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://kiicho.cc/Chohue/sidebar/manual.php?utm_source=Chehue&utm_medium=InApp&utm_campaign=InSetting_Plugin_mobi&utm_content=manual_install_plugin#v-pills-install");
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://kiicho.cc/Chohue/sidebar/manual.php?utm_source=Chehue&utm_medium=InApp&utm_campaign=InSetting_Plugin_epub&utm_content=manual_install_plugin#v-pills-install");
        }

        private void tgUseBuiltin_CheckedChanged(object sender, EventArgs e)
        {

            ChoHoe.Properties.Settings.Default.Setting_UseBuiltinIMG = tgUseBuiltin.Checked;
            ChoHoe.Properties.Settings.Default.Save();
            ReloadImg();


        }

        private void btnLoadIMG_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;*.bmp;";
            if (openFile.ShowDialog()==DialogResult.OK)
            {
                string path=openFile.FileName;

                ChoHoe.Properties.Settings.Default.Setting_CustomizedIMGPath = path;
                ChoHoe.Properties.Settings.Default.Save();
                ReloadImg();

            }
        }
        private void ReloadImg()
        {
            lbReplaceIMG.Text = Path.GetFileName(ChoHoe.Properties.Settings.Default.Setting_CustomizedIMGPath);
            try
            {
                if (!tgUseBuiltin.Checked)
                {
                    pb_ReplaceIMG.Load(ChoHoe.Properties.Settings.Default.Setting_CustomizedIMGPath);
                }
                else
                {
                    pb_ReplaceIMG.Image = ChoHoe.Properties.Resources.Replacement_Image;
                }
            }
            catch (Exception)
            {

                DoLog.logger.Error("Can't load replacement img");
            }
        }

        private void Setting_Load(object sender, EventArgs e)
        {

        }
    }
}
