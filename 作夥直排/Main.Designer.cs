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
            this.chkbEmbdedFont = new MetroFramework.Controls.MetroCheckBox();
            this.btnConvert = new MetroFramework.Controls.MetroButton();
            this.chkbReplacePicture = new MetroFramework.Controls.MetroCheckBox();
            this.chkbModifyPageDirection = new MetroFramework.Controls.MetroCheckBox();
            this.chkbConvertMobi = new MetroFramework.Controls.MetroCheckBox();
            this.chkbToChinese = new MetroFramework.Controls.MetroCheckBox();
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
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.BatchGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.chkbReplacePictureBatch = new MetroFramework.Controls.MetroCheckBox();
            this.chkbEmbdedFontBatch = new MetroFramework.Controls.MetroCheckBox();
            this.btnConvertBatch = new MetroFramework.Controls.MetroButton();
            this.chkbModifyPageDirectionBatch = new MetroFramework.Controls.MetroCheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdoPageRTLBatch = new MetroFramework.Controls.MetroRadioButton();
            this.rdoPageLTRBatch = new MetroFramework.Controls.MetroRadioButton();
            this.chkbConvertMobiBatch = new MetroFramework.Controls.MetroCheckBox();
            this.chkbChineseBatch = new MetroFramework.Controls.MetroCheckBox();
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
            this.RunningLogo = new System.Windows.Forms.PictureBox();
            this.samePage = new MetroFramework.Controls.MetroCheckBox();
            this.TabControl1.SuspendLayout();
            this.TabPageSingle.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.TabPageBatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BatchGridView)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RunningLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPageSingle);
            this.TabControl1.Controls.Add(this.TabPageBatch);
            this.TabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
            resources.ApplyResources(this.TabControl1, "TabControl1");
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl1.UseSelectable = true;
            // 
            // TabPage_Single
            // 
            this.TabPageSingle.Controls.Add(this.groupBox6);
            this.TabPageSingle.Controls.Add(this.samePage);
            this.TabPageSingle.Controls.Add(this.chkbEmbdedFont);
            this.TabPageSingle.Controls.Add(this.btnConvert);
            this.TabPageSingle.Controls.Add(this.chkbReplacePicture);
            this.TabPageSingle.Controls.Add(this.chkbModifyPageDirection);
            this.TabPageSingle.Controls.Add(this.chkbConvertMobi);
            this.TabPageSingle.Controls.Add(this.chkbToChinese);
            this.TabPageSingle.Controls.Add(this.btnLoad);
            this.TabPageSingle.Controls.Add(this.groupBox3);
            this.TabPageSingle.Controls.Add(this.groupBox4);
            this.TabPageSingle.Controls.Add(this.GroupBox1);
            this.TabPageSingle.HorizontalScrollbarBarColor = true;
            this.TabPageSingle.HorizontalScrollbarHighlightOnWheel = false;
            this.TabPageSingle.HorizontalScrollbarSize = 2;
            resources.ApplyResources(this.TabPageSingle, "TabPage_Single");
            this.TabPageSingle.Name = "TabPage_Single";
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
            // IfCustomizeLocalizationWord_cmd
            // 
            resources.ApplyResources(this.btnLocalizationCustomizeToggle, "IfCustomizeLocalizationWord_cmd");
            this.btnLocalizationCustomizeToggle.Name = "IfCustomizeLocalizationWord_cmd";
            this.btnLocalizationCustomizeToggle.UseSelectable = true;
            // 
            // IfCustomizeCss_cmd
            // 
            resources.ApplyResources(this.btnCustomizeCssToggle, "IfCustomizeCss_cmd");
            this.btnCustomizeCssToggle.Name = "IfCustomizeCss_cmd";
            this.btnCustomizeCssToggle.UseSelectable = true;
            // 
            // SetCustomizeLocalizationWord_cmd
            // 
            resources.ApplyResources(this.btnLocalizationCustomize, "SetCustomizeLocalizationWord_cmd");
            this.btnLocalizationCustomize.Name = "SetCustomizeLocalizationWord_cmd";
            this.btnLocalizationCustomize.UseSelectable = true;
            this.btnLocalizationCustomize.Click += new System.EventHandler(this.SetCustomizeLocalizationWord_cmd_Click);
            // 
            // SetCustomizeCss_cmd
            // 
            resources.ApplyResources(this.btnCustomizeCss, "SetCustomizeCss_cmd");
            this.btnCustomizeCss.Name = "SetCustomizeCss_cmd";
            this.btnCustomizeCss.UseSelectable = true;
            // 
            // IfEmbdedFont_Chkbox
            // 
            resources.ApplyResources(this.chkbEmbdedFont, "IfEmbdedFont_Chkbox");
            this.chkbEmbdedFont.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.chkbEmbdedFont.Name = "IfEmbdedFont_Chkbox";
            this.chkbEmbdedFont.UseSelectable = true;
            this.chkbEmbdedFont.CheckedChanged += new System.EventHandler(this.chkbEmbdedFont_CheckedChanged);
            // 
            // Convert_Btn
            // 
            this.btnConvert.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnConvert.FontSize = MetroFramework.MetroButtonSize.Tall;
            resources.ApplyResources(this.btnConvert, "Convert_Btn");
            this.btnConvert.Name = "Convert_Btn";
            this.btnConvert.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnConvert.UseSelectable = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // IfReplacePicture_Chkbox
            // 
            resources.ApplyResources(this.chkbReplacePicture, "IfReplacePicture_Chkbox");
            this.chkbReplacePicture.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.chkbReplacePicture.Name = "IfReplacePicture_Chkbox";
            this.chkbReplacePicture.UseSelectable = true;
            this.chkbReplacePicture.CheckedChanged += new System.EventHandler(this.chkbReplacePicture_CheckedChanged);
            // 
            // IfDoModifyPageDirection_Chkbox
            // 
            resources.ApplyResources(this.chkbModifyPageDirection, "IfDoModifyPageDirection_Chkbox");
            this.chkbModifyPageDirection.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.chkbModifyPageDirection.Name = "IfDoModifyPageDirection_Chkbox";
            this.chkbModifyPageDirection.UseSelectable = true;
            this.chkbModifyPageDirection.CheckedChanged += new System.EventHandler(this.chkbModifyPageDirection_CheckedChanged);
            // 
            // IfConvertMobi_Chkbox
            // 
            resources.ApplyResources(this.chkbConvertMobi, "IfConvertMobi_Chkbox");
            this.chkbConvertMobi.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.chkbConvertMobi.Name = "IfConvertMobi_Chkbox";
            this.chkbConvertMobi.UseSelectable = true;
            this.chkbConvertMobi.CheckedChanged += new System.EventHandler(this.chkbConvertMobi_CheckedChanged);
            // 
            // IfDoToChineseChkbox
            // 
            resources.ApplyResources(this.chkbToChinese, "IfDoToChineseChkbox");
            this.chkbToChinese.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.chkbToChinese.Name = "IfDoToChineseChkbox";
            this.chkbToChinese.UseSelectable = true;
            this.chkbToChinese.CheckedChanged += new System.EventHandler(this.chkbToChinese_CheckChanged);
            // 
            // Load_cmd
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLoad.CausesValidation = false;
            this.btnLoad.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnLoad.ForeColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.btnLoad, "Load_cmd");
            this.btnLoad.Name = "Load_cmd";
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
            // PageRTL_Radio
            // 
            resources.ApplyResources(this.rdoPageRTL, "PageRTL_Radio");
            this.rdoPageRTL.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rdoPageRTL.Name = "PageRTL_Radio";
            this.rdoPageRTL.UseSelectable = true;
            this.rdoPageRTL.CheckedChanged += new System.EventHandler(this.rdoPageRTL_CheckedChanged);
            // 
            // PageLTR_Radio
            // 
            resources.ApplyResources(this.rdoPageLTR, "PageLTR_Radio");
            this.rdoPageLTR.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rdoPageLTR.Name = "PageLTR_Radio";
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
            // Notice_Title_Can_Edit
            // 
            resources.ApplyResources(this.lblHintTitleEditable, "Notice_Title_Can_Edit");
            this.lblHintTitleEditable.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblHintTitleEditable.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblHintTitleEditable.Name = "Notice_Title_Can_Edit";
            // 
            // Author_Label
            // 
            resources.ApplyResources(this.lblAuthor, "Author_Label");
            this.lblAuthor.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAuthor.Name = "Author_Label";
            // 
            // Book_Tittle_Lebel
            // 
            resources.ApplyResources(this.lblTittle, "Book_Tittle_Lebel");
            this.lblTittle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTittle.Name = "Book_Tittle_Lebel";
            // 
            // Author_Imported_TextBox
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
            resources.ApplyResources(this.txtAuthor, "Author_Imported_TextBox");
            this.txtAuthor.MaxLength = 32767;
            this.txtAuthor.Name = "Author_Imported_TextBox";
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
            // Title_Imported_TextBox
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
            resources.ApplyResources(this.txtTittle, "Title_Imported_TextBox");
            this.txtTittle.MaxLength = 32767;
            this.txtTittle.Name = "Title_Imported_TextBox";
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
            // ToTraditionValue_Cmd
            // 
            resources.ApplyResources(this.btnToTraditionValue, "ToTraditionValue_Cmd");
            this.btnToTraditionValue.Name = "ToTraditionValue_Cmd";
            this.btnToTraditionValue.UseSelectable = true;
            this.btnToTraditionValue.Click += new System.EventHandler(this.btnToTraditionValue_Click);
            // 
            // CT_Label
            // 
            resources.ApplyResources(this.CT_Label, "CT_Label");
            this.CT_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.CT_Label.Name = "CT_Label";
            // 
            // TabPage_Batch
            // 
            this.TabPageBatch.Controls.Add(this.btnDelete);
            this.TabPageBatch.Controls.Add(this.BatchGridView);
            this.TabPageBatch.Controls.Add(this.label2);
            this.TabPageBatch.Controls.Add(this.chkbReplacePictureBatch);
            this.TabPageBatch.Controls.Add(this.chkbEmbdedFontBatch);
            this.TabPageBatch.Controls.Add(this.btnConvertBatch);
            this.TabPageBatch.Controls.Add(this.chkbModifyPageDirectionBatch);
            this.TabPageBatch.Controls.Add(this.groupBox5);
            this.TabPageBatch.Controls.Add(this.chkbConvertMobiBatch);
            this.TabPageBatch.Controls.Add(this.chkbChineseBatch);
            this.TabPageBatch.Controls.Add(this.GroupBox2);
            this.TabPageBatch.Controls.Add(this.gvBatch);
            this.TabPageBatch.Controls.Add(this.btnLoadBatch);
            this.TabPageBatch.HorizontalScrollbarBarColor = true;
            this.TabPageBatch.HorizontalScrollbarHighlightOnWheel = false;
            this.TabPageBatch.HorizontalScrollbarSize = 2;
            resources.ApplyResources(this.TabPageBatch, "TabPage_Batch");
            this.TabPageBatch.Name = "TabPage_Batch";
            this.TabPageBatch.VerticalScrollbarBarColor = true;
            this.TabPageBatch.VerticalScrollbarHighlightOnWheel = false;
            this.TabPageBatch.VerticalScrollbarSize = 3;
            // 
            // bookdelete_cmd
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Tomato;
            this.btnDelete.BackgroundImage = global::ChoHoe.Properties.Resources.baseline_close_white_18dp;
            resources.ApplyResources(this.btnDelete, "bookdelete_cmd");
            this.btnDelete.Name = "bookdelete_cmd";
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
            this.BatchGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DataGridView1_RowsRemoved);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // Batch_IfReplacePicture_Chkbox
            // 
            resources.ApplyResources(this.chkbReplacePictureBatch, "Batch_IfReplacePicture_Chkbox");
            this.chkbReplacePictureBatch.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.chkbReplacePictureBatch.Name = "Batch_IfReplacePicture_Chkbox";
            this.chkbReplacePictureBatch.UseSelectable = true;
            this.chkbReplacePictureBatch.CheckedChanged += new System.EventHandler(this.chkbReplacePictureBatch_CheckedChanged);
            // 
            // Batch_IfEmbdedFont_Chkbox
            // 
            resources.ApplyResources(this.chkbEmbdedFontBatch, "Batch_IfEmbdedFont_Chkbox");
            this.chkbEmbdedFontBatch.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.chkbEmbdedFontBatch.Name = "Batch_IfEmbdedFont_Chkbox";
            this.chkbEmbdedFontBatch.UseSelectable = true;
            this.chkbEmbdedFontBatch.CheckedChanged += new System.EventHandler(this.chkbEmbdedFontBatch_CheckedChanged);
            // 
            // Convert_Batch
            // 
            resources.ApplyResources(this.btnConvertBatch, "Convert_Batch");
            this.btnConvertBatch.Name = "Convert_Batch";
            this.btnConvertBatch.UseSelectable = true;
            this.btnConvertBatch.Click += new System.EventHandler(this.btnConvertBatch_Click);
            // 
            // Batch_IfDoModifyPageDirection_Chkbox
            // 
            resources.ApplyResources(this.chkbModifyPageDirectionBatch, "Batch_IfDoModifyPageDirection_Chkbox");
            this.chkbModifyPageDirectionBatch.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.chkbModifyPageDirectionBatch.Name = "Batch_IfDoModifyPageDirection_Chkbox";
            this.chkbModifyPageDirectionBatch.UseSelectable = true;
            this.chkbModifyPageDirectionBatch.CheckedChanged += new System.EventHandler(this.chkbModifyPageDirectionBatch_CheckedChanged);
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
            // Batch_PageRTL_Radio
            // 
            resources.ApplyResources(this.rdoPageRTLBatch, "Batch_PageRTL_Radio");
            this.rdoPageRTLBatch.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rdoPageRTLBatch.Name = "Batch_PageRTL_Radio";
            this.rdoPageRTLBatch.UseSelectable = true;
            this.rdoPageRTLBatch.CheckedChanged += new System.EventHandler(this.rdoPageRTLBatch_CheckedChanged);
            // 
            // Batch_PageLTR_Radio
            // 
            resources.ApplyResources(this.rdoPageLTRBatch, "Batch_PageLTR_Radio");
            this.rdoPageLTRBatch.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rdoPageLTRBatch.Name = "Batch_PageLTR_Radio";
            this.rdoPageLTRBatch.UseSelectable = true;
            this.rdoPageLTRBatch.CheckedChanged += new System.EventHandler(this.rdoPageLTRBatch_CheckedChanged);
            // 
            // Batch_IfConvertMobi_Chkbox
            // 
            resources.ApplyResources(this.chkbConvertMobiBatch, "Batch_IfConvertMobi_Chkbox");
            this.chkbConvertMobiBatch.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.chkbConvertMobiBatch.Name = "Batch_IfConvertMobi_Chkbox";
            this.chkbConvertMobiBatch.UseSelectable = true;
            this.chkbConvertMobiBatch.CheckedChanged += new System.EventHandler(this.chkbConvertMobiBatch_CheckedChanged);
            // 
            // Batch_IfDoToChineseChkbox
            // 
            resources.ApplyResources(this.chkbChineseBatch, "Batch_IfDoToChineseChkbox");
            this.chkbChineseBatch.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.chkbChineseBatch.Name = "Batch_IfDoToChineseChkbox";
            this.chkbChineseBatch.UseSelectable = true;
            this.chkbChineseBatch.CheckedChanged += new System.EventHandler(this.chkbChineseBatch_CheckedChanged);
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
            // Batch_ToTraditionValue_Cmd
            // 
            resources.ApplyResources(this.btnToTraditionValueBatch, "Batch_ToTraditionValue_Cmd");
            this.btnToTraditionValueBatch.Name = "Batch_ToTraditionValue_Cmd";
            this.btnToTraditionValueBatch.UseSelectable = true;
            this.btnToTraditionValueBatch.Click += new System.EventHandler(this.btnToTraditionValueBatch_Click);
            // 
            // CT_Label_Batch
            // 
            resources.ApplyResources(this.CT_Label_Batch, "CT_Label_Batch");
            this.CT_Label_Batch.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.CT_Label_Batch.Name = "CT_Label_Batch";
            // 
            // Batch_grid
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
            resources.ApplyResources(this.gvBatch, "Batch_grid");
            this.gvBatch.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvBatch.Name = "Batch_grid";
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
            // Load_Batch_cmd
            // 
            resources.ApplyResources(this.btnLoadBatch, "Load_Batch_cmd");
            this.btnLoadBatch.Name = "Load_Batch_cmd";
            this.btnLoadBatch.UseSelectable = true;
            this.btnLoadBatch.Click += new System.EventHandler(this.btnLoadBatch_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
            // 
            // inprogressBar
            // 
            resources.ApplyResources(this.InprogressBar, "inprogressBar");
            this.InprogressBar.Name = "inprogressBar";
            // 
            // StatusLabel
            // 
            resources.ApplyResources(this.lblStatus, "StatusLabel");
            this.lblStatus.Name = "StatusLabel";
            // 
            // SettingCmd
            // 
            resources.ApplyResources(this.btnSetting, "SettingCmd");
            this.btnSetting.Name = "SettingCmd";
            this.btnSetting.UseSelectable = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // about_cmd
            // 
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAbout.BackgroundImage = global::ChoHoe.Properties.Resources.outline_info_black_36dp;
            resources.ApplyResources(this.btnAbout, "about_cmd");
            this.btnAbout.Name = "about_cmd";
            this.btnAbout.UseSelectable = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // runningLogo
            // 
            resources.ApplyResources(this.RunningLogo, "runningLogo");
            this.RunningLogo.Name = "runningLogo";
            this.RunningLogo.TabStop = false;
            // 
            // samePage
            // 
            resources.ApplyResources(this.samePage, "samePage");
            this.samePage.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.samePage.Name = "samePage";
            this.samePage.UseSelectable = true;
            this.samePage.CheckedChanged += new System.EventHandler(this.chkbEmbdedFont_CheckedChanged);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RunningLogo);
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
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RunningLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal MetroFramework.Controls.MetroTabPage TabPageSingle;
        internal MetroFramework.Controls.MetroButton btnConvert;
        internal MetroFramework.Controls.MetroCheckBox chkbConvertMobi;
        internal MetroFramework.Controls.MetroCheckBox chkbToChinese;
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
        internal MetroFramework.Controls.MetroCheckBox chkbConvertMobiBatch;
        internal MetroFramework.Controls.MetroCheckBox chkbChineseBatch;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal MetroFramework.Controls.MetroLabel ST_Label_Batch;
        internal MetroFramework.Controls.MetroButton btnToTraditionValueBatch;
        internal MetroFramework.Controls.MetroLabel CT_Label_Batch;
        internal MetroFramework.Controls.MetroGrid gvBatch;
        internal MetroFramework.Controls.MetroButton btnLoadBatch;
        private MetroFramework.Controls.MetroCheckBox chkbModifyPageDirection;
        private MetroFramework.Controls.MetroRadioButton rdoPageLTR;
        private MetroFramework.Controls.MetroRadioButton rdoPageRTL;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroCheckBox chkbModifyPageDirectionBatch;
        internal System.Windows.Forms.GroupBox groupBox5;
        private MetroFramework.Controls.MetroRadioButton rdoPageRTLBatch;
        private MetroFramework.Controls.MetroRadioButton rdoPageLTRBatch;
        private MetroFramework.Controls.MetroCheckBox chkbEmbdedFont;
        internal MetroFramework.Controls.MetroLabel ST_Label;
        public MetroFramework.Components.MetroStyleManager metroStyleManager1;
        public MetroFramework.Controls.MetroLabel lblHintTitleEditable;
        public MetroFramework.Controls.MetroTabControl TabControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private MetroFramework.Controls.MetroCheckBox chkbEmbdedFontBatch;
        private MetroFramework.Controls.MetroCheckBox chkbReplacePictureBatch;
        private MetroFramework.Controls.MetroCheckBox chkbReplacePicture;
        private System.Windows.Forms.GroupBox groupBox6;
        private MetroFramework.Controls.MetroButton btnLocalizationCustomizeToggle;
        private MetroFramework.Controls.MetroButton btnCustomizeCssToggle;
        private MetroFramework.Controls.MetroButton btnLocalizationCustomize;
        private MetroFramework.Controls.MetroButton btnCustomizeCss;
        public System.Windows.Forms.ProgressBar InprogressBar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton btnSetting;
        private System.Windows.Forms.DataGridView BatchGridView;
        private MetroFramework.Controls.MetroButton btnAbout;
        private MetroFramework.Controls.MetroButton btnDelete;
        private System.Windows.Forms.PictureBox RunningLogo;
        private MetroFramework.Controls.MetroCheckBox samePage;
    }
}

