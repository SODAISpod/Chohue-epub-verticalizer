namespace ChoHoeBV
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbRemoveCss = new MetroFramework.Controls.MetroCheckBox();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.BatchGridView = new System.Windows.Forms.DataGridView();
            this.cbReplacePictureBatch = new MetroFramework.Controls.MetroCheckBox();
            this.cbEmbdedFontBatch = new MetroFramework.Controls.MetroCheckBox();
            this.btnConvertBatch = new MetroFramework.Controls.MetroButton();
            this.cbModifyPageDirectionBatch = new MetroFramework.Controls.MetroCheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdoPageRTLBatch = new MetroFramework.Controls.MetroRadioButton();
            this.rdoPageLTRBatch = new MetroFramework.Controls.MetroRadioButton();
            this.cbConvertMobiBatch = new MetroFramework.Controls.MetroCheckBox();
            this.cbChineseBatch = new MetroFramework.Controls.MetroCheckBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.ST_Label_Batch = new MetroFramework.Controls.MetroLabel();
            this.btnToTraditionValueBatch = new MetroFramework.Controls.MetroButton();
            this.CT_Label_Batch = new MetroFramework.Controls.MetroLabel();
            this.btnLoadBatch = new MetroFramework.Controls.MetroButton();
            this.tipRemoveCSS = new MetroFramework.Components.MetroStyleManager(this.components);
            this.InprogressBar = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSetting = new MetroFramework.Controls.MetroButton();
            this.btnAbout = new MetroFramework.Controls.MetroButton();
            this.RunningLogo = new System.Windows.Forms.PictureBox();
            this.tbLogWindow = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbReplaceTWpunctuation = new MetroFramework.Controls.MetroCheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOpenFolder = new MetroFramework.Controls.MetroButton();
            this.tipOpenFolder = new MetroFramework.Components.MetroToolTip();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lbVersion = new System.Windows.Forms.Label();
            this.cbConvertKepub = new MetroFramework.Controls.MetroCheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.cbAddCustomizeCSS = new MetroFramework.Controls.MetroCheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbRemoveStylesheet = new MetroFramework.Controls.MetroCheckBox();
            this.cbDONOTVerticalize = new MetroFramework.Controls.MetroCheckBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BatchGridView)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipRemoveCSS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RunningLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // cbRemoveCss
            // 
            resources.ApplyResources(this.cbRemoveCss, "cbRemoveCss");
            this.cbRemoveCss.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.cbRemoveCss.Name = "cbRemoveCss";
            this.cbRemoveCss.UseSelectable = true;
            this.cbRemoveCss.CheckedChanged += new System.EventHandler(this.cbRemoveCss_CheckedChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Tomato;
            this.btnDelete.BackgroundImage = global::ChoHoe.Properties.Resources.baseline_close_white_18dp;
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // BatchGridView
            // 
            this.BatchGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BatchGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BatchGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.BatchGridView, "BatchGridView");
            this.BatchGridView.Name = "BatchGridView";
            this.BatchGridView.RowTemplate.Height = 24;
            this.BatchGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.BatchGridView_CellValueChanged);
            this.BatchGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DataGridView1_RowsRemoved);
            // 
            // cbReplacePictureBatch
            // 
            resources.ApplyResources(this.cbReplacePictureBatch, "cbReplacePictureBatch");
            this.cbReplacePictureBatch.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.cbReplacePictureBatch.Name = "cbReplacePictureBatch";
            this.cbReplacePictureBatch.UseSelectable = true;
            this.cbReplacePictureBatch.CheckedChanged += new System.EventHandler(this.cbReplacePictureBatch_CheckedChanged);
            // 
            // cbEmbdedFontBatch
            // 
            resources.ApplyResources(this.cbEmbdedFontBatch, "cbEmbdedFontBatch");
            this.cbEmbdedFontBatch.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.cbEmbdedFontBatch.Name = "cbEmbdedFontBatch";
            this.cbEmbdedFontBatch.UseSelectable = true;
            this.cbEmbdedFontBatch.CheckedChanged += new System.EventHandler(this.cbEmbdedFontBatch_CheckedChanged);
            // 
            // btnConvertBatch
            // 
            resources.ApplyResources(this.btnConvertBatch, "btnConvertBatch");
            this.btnConvertBatch.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnConvertBatch.Name = "btnConvertBatch";
            this.btnConvertBatch.UseSelectable = true;
            this.btnConvertBatch.Click += new System.EventHandler(this.btnConvertBatch_Click);
            // 
            // cbModifyPageDirectionBatch
            // 
            resources.ApplyResources(this.cbModifyPageDirectionBatch, "cbModifyPageDirectionBatch");
            this.cbModifyPageDirectionBatch.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.cbModifyPageDirectionBatch.Name = "cbModifyPageDirectionBatch";
            this.cbModifyPageDirectionBatch.UseSelectable = true;
            this.cbModifyPageDirectionBatch.CheckedChanged += new System.EventHandler(this.cbModifyPageDirectionBatch_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox5.Controls.Add(this.rdoPageRTLBatch);
            this.groupBox5.Controls.Add(this.rdoPageLTRBatch);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // rdoPageRTLBatch
            // 
            resources.ApplyResources(this.rdoPageRTLBatch, "rdoPageRTLBatch");
            this.rdoPageRTLBatch.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rdoPageRTLBatch.Name = "rdoPageRTLBatch";
            this.rdoPageRTLBatch.UseSelectable = true;
            this.rdoPageRTLBatch.CheckedChanged += new System.EventHandler(this.rdoPageRTLBatch_CheckedChanged);
            // 
            // rdoPageLTRBatch
            // 
            resources.ApplyResources(this.rdoPageLTRBatch, "rdoPageLTRBatch");
            this.rdoPageLTRBatch.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rdoPageLTRBatch.Name = "rdoPageLTRBatch";
            this.rdoPageLTRBatch.UseSelectable = true;
            this.rdoPageLTRBatch.CheckedChanged += new System.EventHandler(this.rdoPageLTRBatch_CheckedChanged);
            // 
            // cbConvertMobiBatch
            // 
            resources.ApplyResources(this.cbConvertMobiBatch, "cbConvertMobiBatch");
            this.cbConvertMobiBatch.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.cbConvertMobiBatch.Name = "cbConvertMobiBatch";
            this.cbConvertMobiBatch.UseSelectable = true;
            this.cbConvertMobiBatch.CheckedChanged += new System.EventHandler(this.cbConvertMobiBatch_CheckedChanged);
            // 
            // cbChineseBatch
            // 
            resources.ApplyResources(this.cbChineseBatch, "cbChineseBatch");
            this.cbChineseBatch.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.cbChineseBatch.Name = "cbChineseBatch";
            this.cbChineseBatch.UseSelectable = true;
            this.cbChineseBatch.CheckedChanged += new System.EventHandler(this.cbChineseBatch_CheckedChanged);
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GroupBox2.Controls.Add(this.ST_Label_Batch);
            this.GroupBox2.Controls.Add(this.btnToTraditionValueBatch);
            this.GroupBox2.Controls.Add(this.CT_Label_Batch);
            resources.ApplyResources(this.GroupBox2, "GroupBox2");
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.TabStop = false;
            // 
            // ST_Label_Batch
            // 
            resources.ApplyResources(this.ST_Label_Batch, "ST_Label_Batch");
            this.ST_Label_Batch.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ST_Label_Batch.Name = "ST_Label_Batch";
            // 
            // btnToTraditionValueBatch
            // 
            this.btnToTraditionValueBatch.FontSize = MetroFramework.MetroButtonSize.Tall;
            resources.ApplyResources(this.btnToTraditionValueBatch, "btnToTraditionValueBatch");
            this.btnToTraditionValueBatch.Name = "btnToTraditionValueBatch";
            this.btnToTraditionValueBatch.UseSelectable = true;
            this.btnToTraditionValueBatch.Click += new System.EventHandler(this.btnToTraditionValueBatch_Click);
            // 
            // CT_Label_Batch
            // 
            resources.ApplyResources(this.CT_Label_Batch, "CT_Label_Batch");
            this.CT_Label_Batch.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.CT_Label_Batch.Name = "CT_Label_Batch";
            // 
            // btnLoadBatch
            // 
            this.btnLoadBatch.FontSize = MetroFramework.MetroButtonSize.Tall;
            resources.ApplyResources(this.btnLoadBatch, "btnLoadBatch");
            this.btnLoadBatch.Name = "btnLoadBatch";
            this.btnLoadBatch.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnLoadBatch.UseSelectable = true;
            this.btnLoadBatch.Click += new System.EventHandler(this.btnLoadBatch_Click);
            // 
            // tipRemoveCSS
            // 
            this.tipRemoveCSS.Owner = this;
            this.tipRemoveCSS.Style = MetroFramework.MetroColorStyle.Silver;
            // 
            // InprogressBar
            // 
            resources.ApplyResources(this.InprogressBar, "InprogressBar");
            this.InprogressBar.Name = "InprogressBar";
            // 
            // lblStatus
            // 
            resources.ApplyResources(this.lblStatus, "lblStatus");
            this.lblStatus.Name = "lblStatus";
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.White;
            this.btnSetting.BackgroundImage = global::ChoHoe.Properties.Resources.settings_suggest_FILL0_wght200_GRAD200_opsz24;
            resources.ApplyResources(this.btnSetting, "btnSetting");
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.UseSelectable = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.White;
            this.btnAbout.BackgroundImage = global::ChoHoe.Properties.Resources.info_FILL0_wght200_GRAD200_opsz24;
            resources.ApplyResources(this.btnAbout, "btnAbout");
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.UseSelectable = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // RunningLogo
            // 
            resources.ApplyResources(this.RunningLogo, "RunningLogo");
            this.RunningLogo.Name = "RunningLogo";
            this.RunningLogo.TabStop = false;
            // 
            // tbLogWindow
            // 
            this.tbLogWindow.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbLogWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.tbLogWindow, "tbLogWindow");
            this.tbLogWindow.Name = "tbLogWindow";
            this.tbLogWindow.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cbReplaceTWpunctuation
            // 
            resources.ApplyResources(this.cbReplaceTWpunctuation, "cbReplaceTWpunctuation");
            this.cbReplaceTWpunctuation.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.cbReplaceTWpunctuation.Name = "cbReplaceTWpunctuation";
            this.cbReplaceTWpunctuation.UseSelectable = true;
            this.cbReplaceTWpunctuation.CheckedChanged += new System.EventHandler(this.cbReplaceTWpunctuation_CheckedChanged);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.BackgroundImage = global::ChoHoe.Properties.Resources.folder_FILL0_wght200_GRAD200_opsz24;
            resources.ApplyResources(this.btnOpenFolder, "btnOpenFolder");
            this.btnOpenFolder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.UseSelectable = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // tipOpenFolder
            // 
            this.tipOpenFolder.AutoPopDelay = 5000;
            this.tipOpenFolder.InitialDelay = 300;
            this.tipOpenFolder.ReshowDelay = 100;
            this.tipOpenFolder.Style = MetroFramework.MetroColorStyle.Blue;
            this.tipOpenFolder.StyleManager = null;
            this.tipOpenFolder.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ChoHoe.Properties.Resources.translate_FILL0_wght200_GRAD200_opsz24;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ChoHoe.Properties.Resources.auto_stories_FILL0_wght200_GRAD200_opsz24;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ChoHoe.Properties.Resources.move_down_FILL0_wght200_GRAD200_opsz24;
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::ChoHoe.Properties.Resources.font_download_FILL0_wght200_GRAD200_opsz24;
            resources.ApplyResources(this.pictureBox6, "pictureBox6");
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::ChoHoe.Properties.Resources.css_FILL0_wght200_GRAD200_opsz24;
            resources.ApplyResources(this.pictureBox7, "pictureBox7");
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::ChoHoe.Properties.Resources.mop_FILL0_wght200_GRAD200_opsz24;
            resources.ApplyResources(this.pictureBox8, "pictureBox8");
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.TabStop = false;
            // 
            // lbVersion
            // 
            resources.ApplyResources(this.lbVersion, "lbVersion");
            this.lbVersion.Name = "lbVersion";
            // 
            // cbConvertKepub
            // 
            resources.ApplyResources(this.cbConvertKepub, "cbConvertKepub");
            this.cbConvertKepub.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.cbConvertKepub.Name = "cbConvertKepub";
            this.cbConvertKepub.UseSelectable = true;
            this.cbConvertKepub.CheckedChanged += new System.EventHandler(this.cbConvertKepub_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbConvertMobiBatch);
            this.groupBox1.Controls.Add(this.cbConvertKepub);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ChoHoe.Properties.Resources.image_not_supported_FILL0_wght200_GRAD200_opsz24;
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            // 
            // cbAddCustomizeCSS
            // 
            resources.ApplyResources(this.cbAddCustomizeCSS, "cbAddCustomizeCSS");
            this.cbAddCustomizeCSS.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.cbAddCustomizeCSS.Name = "cbAddCustomizeCSS";
            this.cbAddCustomizeCSS.UseSelectable = true;
            this.cbAddCustomizeCSS.CheckedChanged += new System.EventHandler(this.cbAddCustomizeCSS_CheckedChanged);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbRemoveStylesheet);
            this.groupBox3.Controls.Add(this.cbRemoveCss);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.cbAddCustomizeCSS);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // cbRemoveStylesheet
            // 
            resources.ApplyResources(this.cbRemoveStylesheet, "cbRemoveStylesheet");
            this.cbRemoveStylesheet.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.cbRemoveStylesheet.Name = "cbRemoveStylesheet";
            this.cbRemoveStylesheet.UseSelectable = true;
            this.cbRemoveStylesheet.CheckedChanged += new System.EventHandler(this.cbRemoveStylesheet_CheckedChanged);
            // 
            // cbDONOTVerticalize
            // 
            resources.ApplyResources(this.cbDONOTVerticalize, "cbDONOTVerticalize");
            this.cbDONOTVerticalize.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.cbDONOTVerticalize.Name = "cbDONOTVerticalize";
            this.cbDONOTVerticalize.UseSelectable = true;
            this.cbDONOTVerticalize.CheckedChanged += new System.EventHandler(this.cbDONOTVerticalize_CheckedChanged);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::ChoHoe.Properties.Resources.format_align_justify_FILL0_wght200_GRAD200_opsz24;
            resources.ApplyResources(this.pictureBox9, "pictureBox9");
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnConvertBatch;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RunningLogo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLogWindow);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnConvertBatch);
            this.Controls.Add(this.btnLoadBatch);
            this.Controls.Add(this.cbDONOTVerticalize);
            this.Controls.Add(this.cbReplaceTWpunctuation);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cbReplacePictureBatch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbEmbdedFontBatch);
            this.Controls.Add(this.InprogressBar);
            this.Controls.Add(this.BatchGridView);
            this.Controls.Add(this.cbModifyPageDirectionBatch);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.cbChineseBatch);
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BatchGridView)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipRemoveCSS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RunningLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal MetroFramework.Controls.MetroButton btnConvertBatch;
        internal MetroFramework.Controls.MetroCheckBox cbConvertMobiBatch;
        internal MetroFramework.Controls.MetroCheckBox cbChineseBatch;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal MetroFramework.Controls.MetroLabel ST_Label_Batch;
        internal MetroFramework.Controls.MetroButton btnToTraditionValueBatch;
        internal MetroFramework.Controls.MetroLabel CT_Label_Batch;
        internal MetroFramework.Controls.MetroButton btnLoadBatch;
        private MetroFramework.Controls.MetroCheckBox cbModifyPageDirectionBatch;
        internal System.Windows.Forms.GroupBox groupBox5;
        private MetroFramework.Controls.MetroRadioButton rdoPageRTLBatch;
        private MetroFramework.Controls.MetroRadioButton rdoPageLTRBatch;
        public MetroFramework.Components.MetroStyleManager tipRemoveCSS;
        private MetroFramework.Controls.MetroCheckBox cbEmbdedFontBatch;
        private MetroFramework.Controls.MetroCheckBox cbReplacePictureBatch;
        public System.Windows.Forms.ProgressBar InprogressBar;
        private System.Windows.Forms.Label lblStatus;
        private MetroFramework.Controls.MetroButton btnSetting;
        private System.Windows.Forms.DataGridView BatchGridView;
        private MetroFramework.Controls.MetroButton btnAbout;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroCheckBox cbRemoveCss;
        private System.Windows.Forms.PictureBox RunningLogo;
        private System.Windows.Forms.TextBox tbLogWindow;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroCheckBox cbReplaceTWpunctuation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnOpenFolder;
        private MetroFramework.Components.MetroToolTip tipOpenFolder;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbVersion;
        internal MetroFramework.Controls.MetroCheckBox cbConvertKepub;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroCheckBox cbAddCustomizeCSS;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroCheckBox cbRemoveStylesheet;
        private System.Windows.Forms.PictureBox pictureBox9;
        private MetroFramework.Controls.MetroCheckBox cbDONOTVerticalize;
    }
}

