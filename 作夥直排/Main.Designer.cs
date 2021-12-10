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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.TabPageSingle = new MetroFramework.Controls.MetroTabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnLocalizationCustomizeToggle = new MetroFramework.Controls.MetroButton();
            this.btnCustomizeCssToggle = new MetroFramework.Controls.MetroButton();
            this.btnLocalizationCustomize = new MetroFramework.Controls.MetroButton();
            this.btnCustomizeCss = new MetroFramework.Controls.MetroButton();
            this.samePage = new MetroFramework.Controls.MetroCheckBox();
            this.cbEmbdedFont = new MetroFramework.Controls.MetroCheckBox();
            this.btnConvert = new MetroFramework.Controls.MetroButton();
            this.cbReplacePicture = new MetroFramework.Controls.MetroCheckBox();
            this.cbModifyPageDirection = new MetroFramework.Controls.MetroCheckBox();
            this.cbConvertMobi = new MetroFramework.Controls.MetroCheckBox();
            this.cbToChinese = new MetroFramework.Controls.MetroCheckBox();
            this.btnLoad = new MetroFramework.Controls.MetroButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoPageRTL = new MetroFramework.Controls.MetroRadioButton();
            this.rdoPageLTR = new MetroFramework.Controls.MetroRadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblHintTitleEditable = new MetroFramework.Controls.MetroLabel();
            this.lblAuthor = new MetroFramework.Controls.MetroLabel();
            this.lblTittle = new MetroFramework.Controls.MetroLabel();
            this.txtAuthor = new MetroFramework.Controls.MetroTextBox();
            this.txtTittle = new MetroFramework.Controls.MetroTextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.ST_Label = new MetroFramework.Controls.MetroLabel();
            this.btnToTraditionValue = new MetroFramework.Controls.MetroButton();
            this.CT_Label = new MetroFramework.Controls.MetroLabel();
            this.TabPageBatch = new MetroFramework.Controls.MetroTabPage();
            this.cbRemoveCss = new MetroFramework.Controls.MetroCheckBox();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.BatchGridView = new System.Windows.Forms.DataGridView();
            this.cbReplacePictureBatch = new MetroFramework.Controls.MetroCheckBox();
            this.cbEmbdedFontBatch = new MetroFramework.Controls.MetroCheckBox();
            this.btnConvertBatch = new MetroFramework.Controls.MetroButton();
            this.cbModifyPageDirectionBatch = new MetroFramework.Controls.MetroCheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.RunningLogo = new System.Windows.Forms.PictureBox();
            this.rdoPageRTLBatch = new MetroFramework.Controls.MetroRadioButton();
            this.rdoPageLTRBatch = new MetroFramework.Controls.MetroRadioButton();
            this.cbConvertMobiBatch = new MetroFramework.Controls.MetroCheckBox();
            this.cbChineseBatch = new MetroFramework.Controls.MetroCheckBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.ST_Label_Batch = new MetroFramework.Controls.MetroLabel();
            this.btnToTraditionValueBatch = new MetroFramework.Controls.MetroButton();
            this.CT_Label_Batch = new MetroFramework.Controls.MetroLabel();
            this.gvBatch = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoadBatch = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.InprogressBar = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSetting = new MetroFramework.Controls.MetroButton();
            this.btnAbout = new MetroFramework.Controls.MetroButton();
            this.TabControl1.SuspendLayout();
            this.TabPageSingle.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.TabPageBatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BatchGridView)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RunningLogo)).BeginInit();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPageSingle);
            this.TabControl1.Controls.Add(this.TabPageBatch);
            this.TabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
            resources.ApplyResources(this.TabControl1, "TabControl1");
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 1;
            this.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl1.UseSelectable = true;
            // 
            // TabPageSingle
            // 
            this.TabPageSingle.Controls.Add(this.groupBox6);
            this.TabPageSingle.Controls.Add(this.samePage);
            this.TabPageSingle.Controls.Add(this.cbEmbdedFont);
            this.TabPageSingle.Controls.Add(this.btnConvert);
            this.TabPageSingle.Controls.Add(this.cbReplacePicture);
            this.TabPageSingle.Controls.Add(this.cbModifyPageDirection);
            this.TabPageSingle.Controls.Add(this.cbConvertMobi);
            this.TabPageSingle.Controls.Add(this.cbToChinese);
            this.TabPageSingle.Controls.Add(this.btnLoad);
            this.TabPageSingle.Controls.Add(this.groupBox3);
            this.TabPageSingle.Controls.Add(this.groupBox4);
            this.TabPageSingle.Controls.Add(this.GroupBox1);
            this.TabPageSingle.HorizontalScrollbarBarColor = true;
            this.TabPageSingle.HorizontalScrollbarHighlightOnWheel = false;
            this.TabPageSingle.HorizontalScrollbarSize = 2;
            resources.ApplyResources(this.TabPageSingle, "TabPageSingle");
            this.TabPageSingle.Name = "TabPageSingle";
            this.TabPageSingle.VerticalScrollbarBarColor = true;
            this.TabPageSingle.VerticalScrollbarHighlightOnWheel = false;
            this.TabPageSingle.VerticalScrollbarSize = 3;
            this.TabPageSingle.Click += new System.EventHandler(this.TabPage_Single_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox6.Controls.Add(this.btnLocalizationCustomizeToggle);
            this.groupBox6.Controls.Add(this.btnCustomizeCssToggle);
            this.groupBox6.Controls.Add(this.btnLocalizationCustomize);
            this.groupBox6.Controls.Add(this.btnCustomizeCss);
            resources.ApplyResources(this.groupBox6, "groupBox6");
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.TabStop = false;
            // 
            // btnLocalizationCustomizeToggle
            // 
            resources.ApplyResources(this.btnLocalizationCustomizeToggle, "btnLocalizationCustomizeToggle");
            this.btnLocalizationCustomizeToggle.Name = "btnLocalizationCustomizeToggle";
            this.btnLocalizationCustomizeToggle.UseSelectable = true;
            // 
            // btnCustomizeCssToggle
            // 
            resources.ApplyResources(this.btnCustomizeCssToggle, "btnCustomizeCssToggle");
            this.btnCustomizeCssToggle.Name = "btnCustomizeCssToggle";
            this.btnCustomizeCssToggle.UseSelectable = true;
            // 
            // btnLocalizationCustomize
            // 
            resources.ApplyResources(this.btnLocalizationCustomize, "btnLocalizationCustomize");
            this.btnLocalizationCustomize.Name = "btnLocalizationCustomize";
            this.btnLocalizationCustomize.UseSelectable = true;
            this.btnLocalizationCustomize.Click += new System.EventHandler(this.SetCustomizeLocalizationWord_cmd_Click);
            // 
            // btnCustomizeCss
            // 
            resources.ApplyResources(this.btnCustomizeCss, "btnCustomizeCss");
            this.btnCustomizeCss.Name = "btnCustomizeCss";
            this.btnCustomizeCss.UseSelectable = true;
            // 
            // samePage
            // 
            resources.ApplyResources(this.samePage, "samePage");
            this.samePage.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.samePage.Name = "samePage";
            this.samePage.UseSelectable = true;
            this.samePage.CheckedChanged += new System.EventHandler(this.cbEmbdedFont_CheckedChanged);
            // 
            // cbEmbdedFont
            // 
            resources.ApplyResources(this.cbEmbdedFont, "cbEmbdedFont");
            this.cbEmbdedFont.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.cbEmbdedFont.Name = "cbEmbdedFont";
            this.cbEmbdedFont.UseSelectable = true;
            this.cbEmbdedFont.CheckedChanged += new System.EventHandler(this.cbEmbdedFont_CheckedChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.SystemColors.Desktop;
            resources.ApplyResources(this.btnConvert, "btnConvert");
            this.btnConvert.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnConvert.UseSelectable = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // cbReplacePicture
            // 
            resources.ApplyResources(this.cbReplacePicture, "cbReplacePicture");
            this.cbReplacePicture.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.cbReplacePicture.Name = "cbReplacePicture";
            this.cbReplacePicture.UseSelectable = true;
            this.cbReplacePicture.CheckedChanged += new System.EventHandler(this.cbReplacePicture_CheckedChanged);
            // 
            // cbModifyPageDirection
            // 
            resources.ApplyResources(this.cbModifyPageDirection, "cbModifyPageDirection");
            this.cbModifyPageDirection.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.cbModifyPageDirection.Name = "cbModifyPageDirection";
            this.cbModifyPageDirection.UseSelectable = true;
            this.cbModifyPageDirection.CheckedChanged += new System.EventHandler(this.cbModifyPageDirection_CheckedChanged);
            // 
            // cbConvertMobi
            // 
            resources.ApplyResources(this.cbConvertMobi, "cbConvertMobi");
            this.cbConvertMobi.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.cbConvertMobi.Name = "cbConvertMobi";
            this.cbConvertMobi.UseSelectable = true;
            this.cbConvertMobi.CheckedChanged += new System.EventHandler(this.cbConvertMobi_CheckedChanged);
            // 
            // cbToChinese
            // 
            resources.ApplyResources(this.cbToChinese, "cbToChinese");
            this.cbToChinese.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.cbToChinese.Name = "cbToChinese";
            this.cbToChinese.UseSelectable = true;
            this.cbToChinese.CheckedChanged += new System.EventHandler(this.cbToChinese_CheckChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLoad.CausesValidation = false;
            resources.ApplyResources(this.btnLoad, "btnLoad");
            this.btnLoad.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnLoad.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnLoad.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnLoad.UseSelectable = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.rdoPageRTL);
            this.groupBox3.Controls.Add(this.rdoPageLTR);
            this.groupBox3.Controls.Add(this.label3);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // rdoPageRTL
            // 
            resources.ApplyResources(this.rdoPageRTL, "rdoPageRTL");
            this.rdoPageRTL.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rdoPageRTL.Name = "rdoPageRTL";
            this.rdoPageRTL.UseSelectable = true;
            this.rdoPageRTL.CheckedChanged += new System.EventHandler(this.rdoPageRTL_CheckedChanged);
            // 
            // rdoPageLTR
            // 
            resources.ApplyResources(this.rdoPageLTR, "rdoPageLTR");
            this.rdoPageLTR.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rdoPageLTR.Name = "rdoPageLTR";
            this.rdoPageLTR.UseSelectable = true;
            this.rdoPageLTR.CheckedChanged += new System.EventHandler(this.rdoPageLTR_CheckedChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Controls.Add(this.lblHintTitleEditable);
            this.groupBox4.Controls.Add(this.lblAuthor);
            this.groupBox4.Controls.Add(this.lblTittle);
            this.groupBox4.Controls.Add(this.txtAuthor);
            this.groupBox4.Controls.Add(this.txtTittle);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // lblHintTitleEditable
            // 
            resources.ApplyResources(this.lblHintTitleEditable, "lblHintTitleEditable");
            this.lblHintTitleEditable.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblHintTitleEditable.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblHintTitleEditable.Name = "lblHintTitleEditable";
            // 
            // lblAuthor
            // 
            resources.ApplyResources(this.lblAuthor, "lblAuthor");
            this.lblAuthor.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAuthor.Name = "lblAuthor";
            // 
            // lblTittle
            // 
            resources.ApplyResources(this.lblTittle, "lblTittle");
            this.lblTittle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTittle.Name = "lblTittle";
            // 
            // txtAuthor
            // 
            // 
            // 
            // 
            this.txtAuthor.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtAuthor.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.txtAuthor.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.txtAuthor.CustomButton.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("resource.Margin")));
            this.txtAuthor.CustomButton.Name = "";
            this.txtAuthor.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.txtAuthor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAuthor.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.txtAuthor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAuthor.CustomButton.UseSelectable = true;
            this.txtAuthor.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.txtAuthor.Lines = new string[0];
            resources.ApplyResources(this.txtAuthor, "txtAuthor");
            this.txtAuthor.MaxLength = 32767;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.PasswordChar = '\0';
            this.txtAuthor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAuthor.SelectedText = "";
            this.txtAuthor.SelectionLength = 0;
            this.txtAuthor.SelectionStart = 0;
            this.txtAuthor.ShortcutsEnabled = true;
            this.txtAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAuthor.UseSelectable = true;
            this.txtAuthor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAuthor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTittle
            // 
            // 
            // 
            // 
            this.txtTittle.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.txtTittle.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode1")));
            this.txtTittle.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.txtTittle.CustomButton.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("resource.Margin1")));
            this.txtTittle.CustomButton.Name = "";
            this.txtTittle.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.txtTittle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTittle.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.txtTittle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTittle.CustomButton.UseSelectable = true;
            this.txtTittle.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible1")));
            this.txtTittle.Lines = new string[0];
            resources.ApplyResources(this.txtTittle, "txtTittle");
            this.txtTittle.MaxLength = 32767;
            this.txtTittle.Name = "txtTittle";
            this.txtTittle.PasswordChar = '\0';
            this.txtTittle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTittle.SelectedText = "";
            this.txtTittle.SelectionLength = 0;
            this.txtTittle.SelectionStart = 0;
            this.txtTittle.ShortcutsEnabled = true;
            this.txtTittle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTittle.UseSelectable = true;
            this.txtTittle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTittle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GroupBox1.Controls.Add(this.ST_Label);
            this.GroupBox1.Controls.Add(this.btnToTraditionValue);
            this.GroupBox1.Controls.Add(this.CT_Label);
            resources.ApplyResources(this.GroupBox1, "GroupBox1");
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.TabStop = false;
            // 
            // ST_Label
            // 
            resources.ApplyResources(this.ST_Label, "ST_Label");
            this.ST_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ST_Label.Name = "ST_Label";
            // 
            // btnToTraditionValue
            // 
            resources.ApplyResources(this.btnToTraditionValue, "btnToTraditionValue");
            this.btnToTraditionValue.Name = "btnToTraditionValue";
            this.btnToTraditionValue.UseSelectable = true;
            this.btnToTraditionValue.Click += new System.EventHandler(this.btnToTraditionValue_Click);
            // 
            // CT_Label
            // 
            resources.ApplyResources(this.CT_Label, "CT_Label");
            this.CT_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.CT_Label.Name = "CT_Label";
            // 
            // TabPageBatch
            // 
            this.TabPageBatch.Controls.Add(this.cbRemoveCss);
            this.TabPageBatch.Controls.Add(this.btnDelete);
            this.TabPageBatch.Controls.Add(this.BatchGridView);
            this.TabPageBatch.Controls.Add(this.cbReplacePictureBatch);
            this.TabPageBatch.Controls.Add(this.cbEmbdedFontBatch);
            this.TabPageBatch.Controls.Add(this.btnConvertBatch);
            this.TabPageBatch.Controls.Add(this.cbModifyPageDirectionBatch);
            this.TabPageBatch.Controls.Add(this.groupBox5);
            this.TabPageBatch.Controls.Add(this.cbConvertMobiBatch);
            this.TabPageBatch.Controls.Add(this.cbChineseBatch);
            this.TabPageBatch.Controls.Add(this.GroupBox2);
            this.TabPageBatch.Controls.Add(this.gvBatch);
            this.TabPageBatch.Controls.Add(this.btnLoadBatch);
            this.TabPageBatch.HorizontalScrollbarBarColor = true;
            this.TabPageBatch.HorizontalScrollbarHighlightOnWheel = false;
            this.TabPageBatch.HorizontalScrollbarSize = 2;
            resources.ApplyResources(this.TabPageBatch, "TabPageBatch");
            this.TabPageBatch.Name = "TabPageBatch";
            this.TabPageBatch.VerticalScrollbarBarColor = true;
            this.TabPageBatch.VerticalScrollbarHighlightOnWheel = false;
            this.TabPageBatch.VerticalScrollbarSize = 3;
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
            this.groupBox5.Controls.Add(this.RunningLogo);
            this.groupBox5.Controls.Add(this.rdoPageRTLBatch);
            this.groupBox5.Controls.Add(this.rdoPageLTRBatch);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // RunningLogo
            // 
            resources.ApplyResources(this.RunningLogo, "RunningLogo");
            this.RunningLogo.Name = "RunningLogo";
            this.RunningLogo.TabStop = false;
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
            // gvBatch
            // 
            this.gvBatch.AllowUserToResizeRows = false;
            this.gvBatch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvBatch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvBatch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvBatch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvBatch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvBatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBatch.ColumnHeadersVisible = false;
            this.gvBatch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.gvBatch.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvBatch.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvBatch.EnableHeadersVisualStyles = false;
            resources.ApplyResources(this.gvBatch, "gvBatch");
            this.gvBatch.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvBatch.Name = "gvBatch";
            this.gvBatch.ReadOnly = true;
            this.gvBatch.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvBatch.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gvBatch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gvBatch.RowTemplate.Height = 24;
            this.gvBatch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvBatch.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.Batch_grid_RowsRemoved);
            this.gvBatch.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.Batch_grid_RowStateChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // btnLoadBatch
            // 
            resources.ApplyResources(this.btnLoadBatch, "btnLoadBatch");
            this.btnLoadBatch.Name = "btnLoadBatch";
            this.btnLoadBatch.UseSelectable = true;
            this.btnLoadBatch.Click += new System.EventHandler(this.btnLoadBatch_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
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
            resources.ApplyResources(this.btnSetting, "btnSetting");
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.UseSelectable = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAbout.BackgroundImage = global::ChoHoe.Properties.Resources.outline_info_black_36dp;
            resources.ApplyResources(this.btnAbout, "btnAbout");
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.UseSelectable = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.InprogressBar);
            this.Controls.Add(this.TabControl1);
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl1.ResumeLayout(false);
            this.TabPageSingle.ResumeLayout(false);
            this.TabPageSingle.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.TabPageBatch.ResumeLayout(false);
            this.TabPageBatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BatchGridView)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RunningLogo)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal MetroFramework.Controls.MetroTabPage TabPageSingle;
        internal MetroFramework.Controls.MetroButton btnConvert;
        internal MetroFramework.Controls.MetroCheckBox cbConvertMobi;
        internal MetroFramework.Controls.MetroCheckBox cbToChinese;
        internal MetroFramework.Controls.MetroButton btnLoad;
        internal MetroFramework.Controls.MetroTextBox txtTittle;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal MetroFramework.Controls.MetroButton btnToTraditionValue;
        internal MetroFramework.Controls.MetroLabel CT_Label;
        internal MetroFramework.Controls.MetroTextBox txtAuthor;
        internal MetroFramework.Controls.MetroLabel lblTittle;
        internal MetroFramework.Controls.MetroLabel lblAuthor;
        internal MetroFramework.Controls.MetroTabPage TabPageBatch;
        internal MetroFramework.Controls.MetroButton btnConvertBatch;
        internal MetroFramework.Controls.MetroCheckBox cbConvertMobiBatch;
        internal MetroFramework.Controls.MetroCheckBox cbChineseBatch;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal MetroFramework.Controls.MetroLabel ST_Label_Batch;
        internal MetroFramework.Controls.MetroButton btnToTraditionValueBatch;
        internal MetroFramework.Controls.MetroLabel CT_Label_Batch;
        internal MetroFramework.Controls.MetroGrid gvBatch;
        internal MetroFramework.Controls.MetroButton btnLoadBatch;
        private MetroFramework.Controls.MetroCheckBox cbModifyPageDirection;
        private MetroFramework.Controls.MetroRadioButton rdoPageLTR;
        private MetroFramework.Controls.MetroRadioButton rdoPageRTL;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroCheckBox cbModifyPageDirectionBatch;
        internal System.Windows.Forms.GroupBox groupBox5;
        private MetroFramework.Controls.MetroRadioButton rdoPageRTLBatch;
        private MetroFramework.Controls.MetroRadioButton rdoPageLTRBatch;
        private MetroFramework.Controls.MetroCheckBox cbEmbdedFont;
        internal MetroFramework.Controls.MetroLabel ST_Label;
        public MetroFramework.Components.MetroStyleManager metroStyleManager1;
        public MetroFramework.Controls.MetroLabel lblHintTitleEditable;
        public MetroFramework.Controls.MetroTabControl TabControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private MetroFramework.Controls.MetroCheckBox cbEmbdedFontBatch;
        private MetroFramework.Controls.MetroCheckBox cbReplacePictureBatch;
        private MetroFramework.Controls.MetroCheckBox cbReplacePicture;
        private System.Windows.Forms.GroupBox groupBox6;
        private MetroFramework.Controls.MetroButton btnLocalizationCustomizeToggle;
        private MetroFramework.Controls.MetroButton btnCustomizeCssToggle;
        private MetroFramework.Controls.MetroButton btnLocalizationCustomize;
        private MetroFramework.Controls.MetroButton btnCustomizeCss;
        public System.Windows.Forms.ProgressBar InprogressBar;
        private System.Windows.Forms.Label lblStatus;
        private MetroFramework.Controls.MetroButton btnSetting;
        private System.Windows.Forms.DataGridView BatchGridView;
        private MetroFramework.Controls.MetroButton btnAbout;
        private MetroFramework.Controls.MetroButton btnDelete;
        private System.Windows.Forms.PictureBox RunningLogo;
        private MetroFramework.Controls.MetroCheckBox samePage;
        private MetroFramework.Controls.MetroCheckBox cbRemoveCss;
    }
}

