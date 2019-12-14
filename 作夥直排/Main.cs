using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Ionic.Zip;
using System.Xml;
using System.Collections;
using System.Globalization;
using System.Resources;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.International.Converters.TraditionalChineseToSimplifiedConverter;
using System.Xml.XPath;
using HtmlAgilityPack;
using System.Collections.Generic;
using ChoHoe;
using System.ComponentModel;

namespace ChoHoeBV
{

    public partial class Form1 : MetroFramework.Forms.MetroForm
    {


        BackgroundWorker bw = new BackgroundWorker();
        BackgroundWorker bwBatch = new BackgroundWorker();
        BackgroundWorker bwConvert = new BackgroundWorker();
        BackgroundWorker bwConvertBatch = new BackgroundWorker();


        
        //單本專用ㄉ變數R
        Book abook = new Book();
        //多本專用ㄉ變數
        List<Book> batchBookList = new List<Book>();
        List<string[]> rows = new List<string[]>();

        //ResourceManager Rm = new ResourceManager("作夥直排_Csharp_ver.Strings", Assembly.GetExecutingAssembly());
 
        bool ToTradictional =true ;
        bool BatchToTradictional = true;

        AboutBox1 about = new AboutBox1();

        ToolTip toolTip = new ToolTip();

        public Form1()
        {
            InitializeComponent();
            Convert_Btn.Enabled = false;
            Logger.logger.Info("🦄//////////////////🦄 - App Started - 🧛///////////////////////🧛");
            
            toolTip.SetToolTip(IfDoModifyPageDirection_Chkbox, "預設會強制指定為由右而左，直排小說的翻頁方向。");
            SetInitialValue();
           
            //呼叫語言func

          
            this.StyleManager = metroStyleManager1;


            NewVersionCheck versionCheck=new NewVersionCheck();
          _=  versionCheck.HasnewAsync();
           
         
        }

        private void SetInitialValue()
        {
            IfDoToChineseChkbox.Checked = ChoHoe.Properties.Settings.Default.ChineseConvert;
            IfDoModifyPageDirection_Chkbox.Checked = ChoHoe.Properties.Settings.Default.IfChangePageDirection;
            PageRTL_Radio.Checked = ChoHoe.Properties.Settings.Default.PageDirection;
            PageLTR_Radio.Checked = !ChoHoe.Properties.Settings.Default.PageDirection;
            IfReplacePicture_Chkbox.Checked = ChoHoe.Properties.Settings.Default.ReplaceImg;
            IfConvertMobi_Chkbox.Checked = ChoHoe.Properties.Settings.Default.ConvertMobi;
            IfEmbdedFont_Chkbox.Checked = ChoHoe.Properties.Settings.Default.EmbedFont;
            ToTraditionValue_Cmd.Text= ChoHoe.Properties.Settings.Default.ToTriditional ? ">" : "<";
            ToTradictional = ChoHoe.Properties.Settings.Default.ToTriditional;

            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(LoadBack_RunWorkerCompleted);
            bw.DoWork += new DoWorkEventHandler(LoadBackgroundworker_DoWork);



            bwConvert.RunWorkerCompleted += new RunWorkerCompletedEventHandler(ConvertBack_RunWorkerCompleted);
            bwConvert.DoWork += new DoWorkEventHandler(ConvertBackgroundworker_DoWork);
            bwConvert.WorkerSupportsCancellation = true;

            bwConvertBatch.RunWorkerCompleted += new RunWorkerCompletedEventHandler(ConvertBackBatch_RunWorkerCompleted);
            bwConvertBatch.DoWork += new DoWorkEventHandler(ConvertBatchBackgroundworker_DoWork);
            Convert_Batch.Enabled = false;
            bwConvertBatch.WorkerSupportsCancellation = true;




            bwBatch.DoWork += new DoWorkEventHandler(LoadBatchBackgroundworker_DoWork);
            bwBatch.RunWorkerCompleted += new RunWorkerCompletedEventHandler(LoadBackBatch_RunWorkerCompleted);



        }
            
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void ToTraditionValue_Cmd_Click(object sender, EventArgs e)
        {
            
            if (ToTraditionValue_Cmd.Text == ">")
            {
                ToTraditionValue_Cmd.Text = "<";

                ChoHoe.Properties.Settings.Default.ToTriditional = ToTradictional = false;
            }
            else
            {
                ToTraditionValue_Cmd.Text = ">";
                ChoHoe.Properties.Settings.Default.ToTriditional = ToTradictional = true;
            }
            ChoHoe.Properties.Settings.Default.Save();
        }

 
      

        private void Batch_ToTraditionValue_Cmd_Click(object sender, EventArgs e)
        {
          
            if (Batch_ToTraditionValue_Cmd.Text == ">")
            {
                Batch_ToTraditionValue_Cmd.Text = "<";
                BatchToTradictional = false;
                
            }
            else
            {
                Batch_ToTraditionValue_Cmd.Text = ">";
                BatchToTradictional = true;
            }
        }

        private void Load_Click(object sender, EventArgs e)
        {
            Convert_Btn.Enabled = false;
            Logger.logger.Info(System.Environment.NewLine+$"///////////////Open File///////////////"+System.Environment.NewLine+"////////////////////////////////");
            Logger.logger.Debug("開啟檔案");
            OpenFileDialog Import_File = new OpenFileDialog
            {
                Filter = "EPUB檔案|*.epub",
                Title = "請選擇一個epub檔案"
            };
            if (Import_File.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                // bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
                

                inprogressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
                inprogressBar.MarqueeAnimationSpeed = 30;
                abook = new Book();
                Logger.logger.Trace($"{Import_File.SafeFileName}");
                
                Logger.logger.Trace("開始讀取檔案");

                bw.RunWorkerAsync(argument: Import_File.FileName);
                //abook.Load(Import_File.FileName);
                //fileimport.load( Import_File.FileName);
               
                //g_unzipDirectory = fileimport.g_tempuncompressedpath;
            }


        }


        
        

        private void TabPage_Single_Click(object sender, EventArgs e)
        {

        }
        private void Convert_Click(object sender, EventArgs e)
        {
            
            Convert_Btn.Enabled = false;
            StatusLabel.Text = "轉檔中...";
            
            inprogressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            inprogressBar.MarqueeAnimationSpeed = 30;
            

            //Logger.logger.Trace($"{}");
            
            Logger.logger.Trace("開始轉檔");

            Convert_Btn.Enabled = false;
           
            bwConvert.RunWorkerAsync(argument: IfDoModifyPageDirection_Chkbox.Checked);


        }
       

        private void ClearDirectory(string path)
        {
            if (Directory.Exists(path))
            {
                System.IO.DirectoryInfo di = new DirectoryInfo(path);

                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }
            }
            else
            {
                Directory.CreateDirectory(path);
            }
          
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Setting setting=new Setting())
            {
                setting.Show();
            }
            
            
            //aboutboxxx.Show(); 
        }

        private void Load_Batch_Click(object sender, EventArgs e)
        {
            OpenFileDialog Import_File = new OpenFileDialog
            {
                Filter = "EPUB檔案|*.epub",
                Title = "請選擇一個epub檔案",
                Multiselect = true
            };


            if (Import_File.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {

                return;
                
             

            }

            inprogressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            inprogressBar.MarqueeAnimationSpeed = 30;
            BatchGridView.ColumnCount = 2;
            BatchGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BatchGridView.RowHeadersVisible = false;
            BatchGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BatchGridView.Columns[0].Name = "書名";
            BatchGridView.Columns[1].Name = "作者";
            StatusLabel.Text = "讀取中...";

            
            bwBatch.RunWorkerAsync(Import_File);

        }

        private void Convert_Batch_Click(object sender, EventArgs e)
        {
            Convert_Batch.Enabled = false;
            StatusLabel.Text = "轉檔中...";
           


            inprogressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            inprogressBar.MarqueeAnimationSpeed = 30;


            //Logger.logger.Trace($"{}");
            
            Logger.logger.Trace("開始轉檔");

            
            bwConvertBatch.RunWorkerAsync(argument: IfDoModifyPageDirection_Chkbox.Checked);
        }

        private void PageRTL_Radio_CheckedChanged(object sender, EventArgs e)
        {
            if (PageRTL_Radio.Checked)
            {
                ChoHoe.Properties.Settings.Default.PageDirection= PageRTL_Radio.Checked;
                ChoHoe.Properties.Settings.Default.Save();
            }
        }

        private void PageLTR_Radio_CheckedChanged(object sender, EventArgs e)
        {
            if (PageLTR_Radio.Checked)
            {
                ChoHoe.Properties.Settings.Default.PageDirection = PageLTR_Radio.Checked;
                ChoHoe.Properties.Settings.Default.Save();
            }
        }

        private void IfDoToTriditionChkbox_CheckChanged(object sender, EventArgs e)
        {
            ChoHoe.Properties.Settings.Default.ChineseConvert = IfDoToChineseChkbox.Checked;
            ChoHoe.Properties.Settings.Default.Save();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ChoHoe.Properties.Settings.Default.Save();
        }

        private void IfDoModifyPageDirection_Chkbox_CheckedChanged(object sender, EventArgs e)
        {
            ChoHoe.Properties.Settings.Default.IfChangePageDirection = IfDoModifyPageDirection_Chkbox.Checked;
            ChoHoe.Properties.Settings.Default.Save();
        }

        private void IfReplacePicture_Chkbox_CheckedChanged(object sender, EventArgs e)
        {
            ChoHoe.Properties.Settings.Default.ReplaceImg = IfReplacePicture_Chkbox.Checked;
            ChoHoe.Properties.Settings.Default.Save();
        }

        private void IfConvertMobi_Chkbox_CheckedChanged(object sender, EventArgs e)
        {
            ChoHoe.Properties.Settings.Default.ConvertMobi = IfConvertMobi_Chkbox.Checked;
            ChoHoe.Properties.Settings.Default.Save();
        }

        private void IfEmbdedFont_Chkbox_CheckedChanged(object sender, EventArgs e)
        {
            ChoHoe.Properties.Settings.Default.EmbedFont = IfEmbdedFont_Chkbox.Checked;
            ChoHoe.Properties.Settings.Default.Save();
        }
        private void LoadBackgroundworker_DoWork(object sender, DoWorkEventArgs e)
        {
            
            string path = (string)e.Argument;
         
            abook.Load(path);
        }

        private void LoadBatchBackgroundworker_DoWork(object sender, DoWorkEventArgs e)
        {
            OpenFileDialog paths = (OpenFileDialog)e.Argument;


            foreach (string name in paths.FileNames)
            {

                Book abooks = new Book();
                abooks.Load(name);
                
              //  Batch_grid.Rows.Add(new object[] { abooks.GetTitle() });

                string[] row1 = new string[] { abooks.GetTitle(), abooks.GetAuthor() };
                rows.Add(row1);
               // BatchGridView.Rows.Add(row1);
                batchBookList.Add(abooks);

            }

          
        }
        private void LoadBackBatch_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            foreach (string[] row in rows)
            {
                BatchGridView.Rows.Add(row);
            }
            // Title_Imported_TextBox.Text = debugstring;
            StatusLabel.Text = "讀取完畢。";
            Convert_Batch.Enabled = true;
            inprogressBar.MarqueeAnimationSpeed = 0;
            inprogressBar.Value = 0;
        }
        private void ConvertBackgroundworker_DoWork(object sender, DoWorkEventArgs e)
        {

            bool Modifypage = (bool)e.Argument;

           

            if (Modifypage)
            {
                abook.Convert(IfDoToChineseChkbox.Checked, ToTradictional, PageRTL_Radio.Checked, IfConvertMobi_Chkbox.Checked, IfEmbdedFont_Chkbox.Checked, IfReplacePicture_Chkbox.Checked, Author_Imported_TextBox.Text, Title_Imported_TextBox.Text);
            }
            else
            {
                abook.Convert(IfDoToChineseChkbox.Checked, ToTradictional, true, IfConvertMobi_Chkbox.Checked, IfEmbdedFont_Chkbox.Checked, IfReplacePicture_Chkbox.Checked, Author_Imported_TextBox.Text, Title_Imported_TextBox.Text);
            }


            e.Cancel = true;
            return;

           
        }
        private void LoadBack_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Author_Imported_TextBox.Text = abook.GetAuthor();
            Title_Imported_TextBox.Text = abook.GetTitle();
            Convert_Btn.Enabled = true;
            int index =ChoHoe.Properties.Settings.Default.DebugBookIndex;
          //  string debugstring = $"偵錯用書本 編號 #{index}";
            ChoHoe.Properties.Settings.Default.DebugBookIndex = ++index;
            ChoHoe.Properties.Settings.Default.Save();

           // Title_Imported_TextBox.Text = debugstring;
            StatusLabel.Text = "讀取完畢。";
            inprogressBar.MarqueeAnimationSpeed = 0;
            inprogressBar.Value = 0;
        }
        private void ConvertBack_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Author_Imported_TextBox.Text = "";
            Title_Imported_TextBox.Text = "";
            Convert_Btn.Enabled = false;
 
            StatusLabel.Text = "轉檔完畢。";
            ClearDirectory("temp");
            inprogressBar.MarqueeAnimationSpeed = 0;
            inprogressBar.Value = 0;
        }



        private void ConvertBatchBackgroundworker_DoWork(object sender, DoWorkEventArgs e)
        {

            bool Modifypage = (bool)e.Argument;

            foreach (Book item in batchBookList)
            {
                if (Modifypage)
                {
                    item.Convert(Batch_IfDoToChineseChkbox.Checked, BatchToTradictional, Batch_PageRTL_Radio.Checked, Batch_IfConvertMobi_Chkbox.Checked, Batch_IfEmbdedFont_Chkbox.Checked, Batch_IfReplacePicture_Chkbox.Checked, item.GetAuthor(), item.GetTitle());
                }
                else
                {
                    item.Convert(Batch_IfDoToChineseChkbox.Checked, BatchToTradictional, true, Batch_IfConvertMobi_Chkbox.Checked, Batch_IfEmbdedFont_Chkbox.Checked, Batch_IfReplacePicture_Chkbox.Checked, item.GetAuthor(), item.GetTitle());
                }
            }

         


            e.Cancel = true;
            return;


        }
        private void ConvertBackBatch_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
      
            Convert_Batch.Enabled = false;

            StatusLabel.Text = "轉檔完畢。";
            ClearDirectory("temp");
            inprogressBar.MarqueeAnimationSpeed = 0;
            inprogressBar.Value = 0;
        }










        private void SetCustomizeLocalizationWord_cmd_Click(object sender, EventArgs e)
        {

        }

        private void SettingCmd_Click(object sender, EventArgs e)
        {
           
            Setting settingForm = new Setting();
            settingForm.Show();
        }

        private void Batch_grid_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {


        }

        private void Batch_grid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
             foreach (DataGridViewRow item in Batch_grid.Rows)
            {
                if (item.Selected==true)
                {
                    batchBookList.RemoveAt(item.Index);
                }
            }
        }

    

        private void DataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }

        private void About_cmd_Click(object sender, EventArgs e)
        {
           about.Show();
            

        }

        private void Bookdelete_cmd_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in BatchGridView.SelectedRows)
            {
                
                batchBookList.RemoveAt(item.Index);
                
            }
            foreach (DataGridViewRow item in BatchGridView.SelectedRows)
            {

                BatchGridView.Rows.RemoveAt(item.Index);

            }

        }

        private void Batch_IfDoToChineseChkbox_CheckedChanged(object sender, EventArgs e)
        {
            ChoHoe.Properties.Settings.Default.Batch_ChineseConvert = Batch_IfDoToChineseChkbox.Checked;
            ChoHoe.Properties.Settings.Default.Save();
        }

        private void Batch_IfDoModifyPageDirection_Chkbox_CheckedChanged(object sender, EventArgs e)
        {
            ChoHoe.Properties.Settings.Default.Batch_IfChangePageDirection = Batch_IfDoModifyPageDirection_Chkbox.Checked;
            ChoHoe.Properties.Settings.Default.Save();
        }

        private void Batch_IfConvertMobi_Chkbox_CheckedChanged(object sender, EventArgs e)
        {
            ChoHoe.Properties.Settings.Default.Batch_ConvertMobi = Batch_IfConvertMobi_Chkbox.Checked;
            ChoHoe.Properties.Settings.Default.Save();
        }

        private void Batch_IfReplacePicture_Chkbox_CheckedChanged(object sender, EventArgs e)
        {
            ChoHoe.Properties.Settings.Default.Batch_ReplaceImg = Batch_IfReplacePicture_Chkbox.Checked;
            ChoHoe.Properties.Settings.Default.Save();
        }

        private void Batch_IfEmbdedFont_Chkbox_CheckedChanged(object sender, EventArgs e)
        {
            ChoHoe.Properties.Settings.Default.Batch_EmbedFont
                =Batch_IfEmbdedFont_Chkbox.Checked;
            ChoHoe.Properties.Settings.Default.Save();
        }

        private void Batch_PageRTL_Radio_CheckedChanged(object sender, EventArgs e)
        {
            if (Batch_PageRTL_Radio.Checked)
            {
                ChoHoe.Properties.Settings.Default.Batch_PageDirection = Batch_PageRTL_Radio.Checked;
                ChoHoe.Properties.Settings.Default.Save();
            }
        }



        private void Batch_PageLTR_Radio_CheckedChanged(object sender, EventArgs e)
        {
            if (Batch_PageLTR_Radio.Checked)
            {
                ChoHoe.Properties.Settings.Default.Batch_PageDirection= Batch_PageLTR_Radio.Checked;
                ChoHoe.Properties.Settings.Default.Save();
            }
        }
        
    }

}
