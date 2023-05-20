using ChoHoe;
using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Windows.Foundation.Collections;

namespace ChoHoeBV
{
    
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private readonly BackgroundWorker bw = new BackgroundWorker();
        private readonly BackgroundWorker bwBatch = new BackgroundWorker();
        private readonly BackgroundWorker bwConvert = new BackgroundWorker();
        private readonly BackgroundWorker bwConvertBatch = new BackgroundWorker();



        //單本專用ㄉ變數R
        Book abook = new Book();
        //多本專用ㄉ變數
        List<Book> batchBookList = new List<Book>();
        List<string[]> rows = new List<string[]>();

        //ResourceManager Rm = new ResourceManager("作夥直排_Csharp_ver.Strings", Assembly.GetExecutingAssembly());

        bool ToTradictional = true;
        bool BatchToTradictional = true;
     


        ToolTip toolTip = new ToolTip();

        
        public Form1()
        {
            InitializeComponent();
            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.UnhandledException += new UnhandledExceptionEventHandler(ChExceptionHandler);

            
            //btnConvert.Enabled = false;
            Logger.logger.Info("🦄//////////////////🦄 - App Started - 🦄///////////////////////🦄");

            const string Caption = "預設會強制指定為由右而左，直排小說的翻頁方向。";
            //toolTip.SetToolTip(cbModifyPageDirection, Caption);
            SetInitialValue();

            //呼叫語言func


            this.StyleManager = metroStyleManager1;


            NewVersionCheck versionCheck = new NewVersionCheck();
            _ = versionCheck.HasnewAsync();



            // Listen to notification activation
            ToastNotificationManagerCompat.OnActivated += toastArgs =>
            {
                // Obtain the arguments from the notification
                ToastArguments args = ToastArguments.Parse(toastArgs.Argument);

                // Obtain any user input (text boxes, menu selections) from the notification
                //ValueSet userInput = toastArgs.UserInput;
                switch (args["action"])
                {
                    case "open":
                        System.Diagnostics.Process.Start("https://kiicho.cc/Chohue?utm_source=Chehue&utm_medium=InApp&utm_campaign=UpdateNotification");
                        break;
                    case "ignoreThisOne":
                        ChoHoe.Properties.Settings.Default.IgnoreVersion = args["version"];
                        ChoHoe.Properties.Settings.Default.Save();
                        break;

                }
                
                //MessageBox.Show(toastArgs.Argument);

                // Need to dispatch to UI thread if performing UI operations
                
            };



        }
        static void ChExceptionHandler(object sender, UnhandledExceptionEventArgs args)
        {
            Exception e = (Exception)args.ExceptionObject;
            Logger.logger.Error(e, "Error:");

        }

        private void SetInitialValue()
        {
            //metroframwork無法在裡面塞image
            //cbChineseBatch.Image = ChoHoe.Properties.Resources.translate_FILL0_wght200_GRAD200_opsz24;
            //cbChineseBatch.ImageAlign = ContentAlignment.MiddleLeft;
            //btnConvertBatch.Image = Image.FromFile("C:\\Users\\\\Downloads\\translate_FILL0_wght200_GRAD200_opsz24.png");
            //btnConvertBatch.ImageAlign = ContentAlignment.MiddleLeft;
            

            //cbToChinese.Checked = ChoHoe.Properties.Settings.Default.ChineseConvert;
            cbChineseBatch.Checked = ChoHoe.Properties.Settings.Default.Batch_ChineseConvert;
            cbModifyPageDirectionBatch.Checked = ChoHoe.Properties.Settings.Default.Batch_IfChangePageDirection;
            //rdoPageRTL.Checked = ChoHoe.Properties.Settings.Default.PageDirection;
            //rdoPageLTR.Checked = !ChoHoe.Properties.Settings.Default.PageDirection;
            cbReplacePictureBatch.Checked = ChoHoe.Properties.Settings.Default.Batch_ReplaceImg;

            cbConvertMobiBatch.Checked = ChoHoe.Properties.Settings.Default.Batch_ConvertMobi;

            cbEmbdedFontBatch.Checked = ChoHoe.Properties.Settings.Default.Batch_EmbedFont;
            btnToTraditionValueBatch.Text = ChoHoe.Properties.Settings.Default.Batch_ToTriditional ? ">" : "<";
            //ToTradictional = ChoHoe.Properties.Settings.Default.ToTriditional;
            cbRemoveCss.Checked = ChoHoe.Properties.Settings.Default.Batch_RemoveCss;
            cbReplaceTWpunctuation.Checked = ChoHoe.Properties.Settings.Default.Batch_ReplaceTwPunctuation;
            tipOpenFolder.SetToolTip(btnOpenFolder, "開啟輸出資料夾");
            tipOpenFolder.SetToolTip(btnDelete, "移除書本");
            
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            lbVersion.Text= $"{Assembly.GetEntryAssembly().GetName().Version.ToString()}";
            




            bwConvert.WorkerSupportsCancellation = true;

            bwConvertBatch.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Convert_Batch_RunWorker_Completed);
            bwConvertBatch.DoWork += new DoWorkEventHandler(Convert_Batch_Backgroundworker_DoWork);
            btnConvertBatch.Enabled = false;
            bwConvertBatch.WorkerSupportsCancellation = true;




            bwBatch.DoWork += new DoWorkEventHandler(Load_Batch_Backgroundworker_DoWork);
            bwBatch.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Load_Batch_RunWorker_Completed);





        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }





        private void btnToTraditionValueBatch_Click(object sender, EventArgs e)
        {

            if (btnToTraditionValueBatch.Text == ">")
            {
                btnToTraditionValueBatch.Text = "<";
                BatchToTradictional = true;

            }
            else
            {
                btnToTraditionValueBatch.Text = ">";
                BatchToTradictional = false;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //btnConvert.Enabled = false;
            Logger.logger.Info(System.Environment.NewLine + $"///////////////Open File///////////////" + System.Environment.NewLine + "////////////////////////////////");
            Logger.logger.Info("開啟檔案");

            using (OpenFileDialog Import_File = new OpenFileDialog())
            {

                Import_File.Filter = "EPUB、TXT檔案|*.epub;*.txt"; ;
                Import_File.Title = "請選擇一個電子書檔案";
                if (Import_File.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    // bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);

                    runningUi("載入中...", true);
                    InprogressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
                    InprogressBar.MarqueeAnimationSpeed = 30;

                    abook = new Book();
                    Logger.logger.Info($"{Import_File.SafeFileName}");

                    Logger.logger.Info("開始讀取檔案");

                    bw.RunWorkerAsync(argument: Import_File.FileName);
                    //abook.Load(Import_File.FileName);
                    //fileimport.load( Import_File.FileName);

                    //g_unzipDirectory = fileimport.g_tempuncompressedpath;
                }

            }



        }





        private void TabPage_Single_Click(object sender, EventArgs e)
        {

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

        private void btnSetting_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Setting setting = new Setting())
            {
                setting.Show();
            }


            //aboutboxxx.Show(); 
        }

        private void btnLoadBatch_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog Import_File = new OpenFileDialog())
            {

                Import_File.Filter = "EPUB、TXT 檔案|*.epub;*.txt|EPUB 檔案|*.epub|TXT 檔案|*.txt";
                Import_File.Title = "請選擇一個電子書檔案";
                Import_File.Multiselect = true;


                if (Import_File.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                {

                    return;



                }


                RunningLogo.Visible = true;

                InprogressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
                InprogressBar.MarqueeAnimationSpeed = 30;
                BatchGridView.ColumnCount = 2;
                BatchGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                BatchGridView.RowHeadersVisible = false;
                BatchGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                BatchGridView.Columns[0].Name = "書名";
                BatchGridView.Columns[1].Name = "作者";
                lblStatus.Text = "讀取中...";


                bwBatch.RunWorkerAsync(Import_File);
            }






        }

        private void btnConvertBatch_Click(object sender, EventArgs e)
        {
            btnConvertBatch.Enabled = false;

            runningUi("轉檔中...", true);




            //Logger.logger.Trace($"{}");

            Logger.logger.Info("開始轉檔");

            Tuple<bool, bool> variables = new Tuple<bool, bool>(cbModifyPageDirectionBatch.Checked, cbRemoveCss.Checked);

            bwConvertBatch.RunWorkerAsync(argument: variables);
        }

       

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ChoHoe.Properties.Settings.Default.Save();
        }



        

        private void Load_Batch_Backgroundworker_DoWork(object sender, DoWorkEventArgs e)
        {
            OpenFileDialog paths = (OpenFileDialog)e.Argument;


            foreach (string name in paths.FileNames)
            {
                Book abooks = new Book();
                this.Invoke(new MethodInvoker(delegate {
                    runningUi($"正在載入：{Path.GetFileName(name)}", true);


                }));

                switch (abooks.Load(name))
                {
                    case LoadResult.success:
                        string[] row1 = new string[] { abooks.GetTitle(), abooks.GetAuthor() };

                        rows.Add(row1);

                        //batchBookList.Clear();
                        batchBookList.Add(abooks);
                        this.Invoke(new MethodInvoker(delegate {
                            runningUi($"成功{System.Environment.NewLine}{Logger.GetErrorMessage()}", true);


                        }));
                        break;
                    case LoadResult.fail:
                        this.Invoke(new MethodInvoker(delegate {
                            runningUi($"失敗:{System.Environment.NewLine}{Logger.GetErrorMessage()}", true);


                        }));
                        break;
                    case LoadResult.failPandocReturnError2to3:
                        this.Invoke(new MethodInvoker(delegate {
                            runningUi($"Pandoc在轉換EPUB版本2至3時發生錯誤", true);}));
                        break;

                }


            }
        }
        private void Load_Batch_RunWorker_Completed(object sender, RunWorkerCompletedEventArgs e)
        {

            BatchGridViewClearThenAdd();
            // Title_Imported_TextBox.Text = debugstring;

            runningUi("讀取完畢。", false);

            btnConvertBatch.Enabled = true;
            BatchGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            new ToastContentBuilder()
           .AddArgument("action", "viewConversation")
           .AddArgument("conversationId", "9813")
           .AddText("載入完成！")
           .AddText("隨時可以開始轉檔！")

           .Show();

        }

    





        private void Convert_Batch_Backgroundworker_DoWork(object sender, DoWorkEventArgs e)
        {

            Tuple<bool, bool> para = (Tuple<bool, bool>)e.Argument;
            bool Modifypage = para.Item1;
            bool RemoveCss = para.Item2;

  

            foreach (Book item in batchBookList)
            {
                this.Invoke(new MethodInvoker(delegate {
                    runningUi($"正在轉換：{item.GetTitle()}",true );


                }));
                item.IsRemoveCss(RemoveCss);
                if (Modifypage)
                {
                    item.Convert(cbChineseBatch.Checked, BatchToTradictional, rdoPageRTLBatch.Checked, cbConvertMobiBatch.Checked, cbEmbdedFontBatch.Checked, cbReplacePictureBatch.Checked, item.GetAuthor(), item.GetTitle(),cbReplaceTWpunctuation.Checked);
                }
                else
                {
                    item.Convert(cbChineseBatch.Checked, BatchToTradictional, true, cbConvertMobiBatch.Checked, cbEmbdedFontBatch.Checked, cbReplacePictureBatch.Checked, item.GetAuthor(), item.GetTitle(), cbReplaceTWpunctuation.Checked);
                }
            }
            e.Cancel = true;
            return;
        }
        private void Convert_Batch_RunWorker_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            btnConvertBatch.Enabled = false;



            AllClear();

            runningUi("轉檔完畢。", false);
            ClearDirectory("temp");
            BatchGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            new ToastContentBuilder()
                   .AddArgument("action", "viewConversation")
                   .AddArgument("conversationId", "9813")
                   .AddText("轉檔完成！")
                   
                   .Show();

        }





        private void SetCustomizeLocalizationWord_cmd_Click(object sender, EventArgs e)
        {

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Setting settingForm = new Setting();

            settingForm.Show();
        }

        private void Batch_grid_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {


        }

        private void Batch_grid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            //foreach (DataGridViewRow item in gvBatch.Rows)
            //{
            //    if (item.Selected == true)
            //    {
            //        batchBookList.RemoveAt(item.Index);
            //    }
            //}
        }



        private void DataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Show();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Logger.logger.Info($"Deleting selected boooks, Total rows: {BatchGridView.RowCount}, Selected rows count: {BatchGridView.SelectedRows.Count}");

            //list
            int min = -1;
            int max = -1;
            int range = 0;
            bool single = false;
            //find the selected range
            if (BatchGridView.SelectedRows.Count == 0)
            {
                return;

            }
            if (BatchGridView.RowCount - 1 == BatchGridView.SelectedRows[0].Index && BatchGridView.SelectedRows.Count == 1)
            {
                return;
            }
            foreach (DataGridViewRow item in BatchGridView.SelectedRows)
            {
                if (min == -1)
                {
                    min = item.Index;
                }
                else if (item.Index < min)
                {
                    min = item.Index;
                }
                if (max == -1)
                {
                    max = item.Index;
                }
                else if (item.Index > max)
                {
                    max = item.Index;
                }
            }
            Logger.logger.Info($"min: {min}");

            range = max - min + 1;
            //Check if the last empty one selected.
            if (min + range == BatchGridView.RowCount)
            {
                range--;
            }



            if (batchBookList.Count != 0 && BatchGridView.Rows.Count != 0 && rows.Count != 0)
            {

                batchBookList.RemoveRange(min, range);
                for (int i = 0; i < range; i++)
                {
                    BatchGridView.Rows.RemoveAt(min);
                }
                rows.RemoveRange(min, range);
            }
            else
            {
                return;
            }

        }

        private void cbChineseBatch_CheckedChanged(object sender, EventArgs e)
        {
            ChoHoe.Properties.Settings.Default.Batch_ChineseConvert = cbChineseBatch.Checked;
            ChoHoe.Properties.Settings.Default.Save();
        }

        private void cbModifyPageDirectionBatch_CheckedChanged(object sender, EventArgs e)
        {
            ChoHoe.Properties.Settings.Default.Batch_IfChangePageDirection = cbModifyPageDirectionBatch.Checked;
            ChoHoe.Properties.Settings.Default.Save();
        }

        private void cbConvertMobiBatch_CheckedChanged(object sender, EventArgs e)
        {
            ChoHoe.Properties.Settings.Default.Batch_ConvertMobi = cbConvertMobiBatch.Checked;
            ChoHoe.Properties.Settings.Default.Save();
        }

        private void cbReplacePictureBatch_CheckedChanged(object sender, EventArgs e)
        {
            ChoHoe.Properties.Settings.Default.Batch_ReplaceImg = cbReplacePictureBatch.Checked;
            ChoHoe.Properties.Settings.Default.Save();
        }

        private void cbEmbdedFontBatch_CheckedChanged(object sender, EventArgs e)
        {
            ChoHoe.Properties.Settings.Default.Batch_EmbedFont
                = cbEmbdedFontBatch.Checked;
            ChoHoe.Properties.Settings.Default.Save();
        }

        private void rdoPageRTLBatch_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPageRTLBatch.Checked)
            {
                ChoHoe.Properties.Settings.Default.Batch_PageDirection = rdoPageRTLBatch.Checked;
                ChoHoe.Properties.Settings.Default.Save();
            }
        }



        private void rdoPageLTRBatch_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPageLTRBatch.Checked)
            {
                ChoHoe.Properties.Settings.Default.Batch_PageDirection = rdoPageLTRBatch.Checked;
                ChoHoe.Properties.Settings.Default.Save();
            }
        }
        private void runningUi(string message, bool enabled)
        {
            tbLogWindow.AppendText($"{System.Environment.NewLine}{message}");
            
            lblStatus.Text = message;
            RunningLogo.Visible = enabled;
            if (enabled)
            {
                InprogressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
                InprogressBar.MarqueeAnimationSpeed = 30;
            }
            else
            {
                InprogressBar.MarqueeAnimationSpeed = 0;
                InprogressBar.Value = 0;
            }



        }

        private void cbRemoveCss_CheckedChanged(object sender, EventArgs e)
        {
            ChoHoe.Properties.Settings.Default.Batch_RemoveCss
                = cbRemoveCss.Checked;
            ChoHoe.Properties.Settings.Default.Save();
        }
        /// <summary>
        /// Clear the BatchGridView Before Add.
        /// </summary>
        private void BatchGridViewClearThenAdd()
        {
            BatchGridView.Rows.Clear();
            foreach (string[] row in rows)
            {

                BatchGridView.Rows.Add(row);
            }
        }
        /// <summary>
        /// Add rows into BatchGridView
        /// </summary>
        private void BatchGridViewAdd()
        {
            foreach (string[] row in rows)
            {

                BatchGridView.Rows.Add(row);
            }
        }
        /// <summary>
        /// Clear everything loaded
        /// BatchGridView.Rows, list <book>, Rows.
        /// </summary>
        private void AllClear()
        {
            rows.Clear();
            batchBookList.Clear();
            BatchGridView.Rows.Clear();
        }

        private void BatchGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (batchBookList.Count<= e.RowIndex)
            {
                return;
            }
            int index = e.RowIndex;
            batchBookList[index].SetAuthor(BatchGridView.Rows[index].Cells[1].Value.ToString());
            batchBookList[index].SetTitle(BatchGridView.Rows[index].Cells[0].Value.ToString());

        }

        private void cbReplaceTWpunctuation_CheckedChanged(object sender, EventArgs e)
        {
            ChoHoe.Properties.Settings.Default.Batch_ReplaceTwPunctuation
                                    = cbReplaceTWpunctuation.Checked;
            ChoHoe.Properties.Settings.Default.Save();
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("output"))
            {
                Process.Start("output");

            }
            else
            {

                new ToastContentBuilder()
                    .AddArgument("action", "viewConversation")
                    .AddArgument("conversationId", "9813")
                    .AddText("輸出資料夾還沒建立！")
                    .AddText("試著進行一次轉檔看看！")
                    .Show();

            }
        }
    }
}
