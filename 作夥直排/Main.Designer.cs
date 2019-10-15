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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.languagecombobox = new System.Windows.Forms.ComboBox();
            this.TabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.TabPage_Single = new MetroFramework.Controls.MetroTabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.IfCustomizeLocalizationWord_cmd = new MetroFramework.Controls.MetroButton();
            this.IfCustomizeCss_cmd = new MetroFramework.Controls.MetroButton();
            this.SetCustomizeLocalizationWord_cmd = new MetroFramework.Controls.MetroButton();
            this.SetCustomizeCss_cmd = new MetroFramework.Controls.MetroButton();
            this.IfEmbdedFont_Chkbox = new MetroFramework.Controls.MetroCheckBox();
            this.Make_Btn = new MetroFramework.Controls.MetroButton();
            this.IfReplacePicture_Chkbox = new MetroFramework.Controls.MetroCheckBox();
            this.IfDoModifyPageDirection_Chkbox = new MetroFramework.Controls.MetroCheckBox();
            this.IfConvertMobi_Chkbox = new MetroFramework.Controls.MetroCheckBox();
            this.IfDoToChineseChkbox = new MetroFramework.Controls.MetroCheckBox();
            this.OpenBtn_Single = new MetroFramework.Controls.MetroButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PageRTL_Radio = new MetroFramework.Controls.MetroRadioButton();
            this.PageLTR_Radio = new MetroFramework.Controls.MetroRadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Notice_Title_Can_Edit = new MetroFramework.Controls.MetroLabel();
            this.Author_Label = new MetroFramework.Controls.MetroLabel();
            this.Book_Tittle_Lebel = new MetroFramework.Controls.MetroLabel();
            this.Author_Imported_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.Title_Imported_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.ST_Label = new MetroFramework.Controls.MetroLabel();
            this.ToTraditionValue_Cmd = new MetroFramework.Controls.MetroButton();
            this.CT_Label = new MetroFramework.Controls.MetroLabel();
            this.TabPage_Batch = new MetroFramework.Controls.MetroTabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.replacepic_batch_Chkbox = new MetroFramework.Controls.MetroCheckBox();
            this.batch_embemed_check = new MetroFramework.Controls.MetroCheckBox();
            this.Make_Batch = new MetroFramework.Controls.MetroButton();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.Convert_to_Mobi_Chkbox_Batch = new MetroFramework.Controls.MetroCheckBox();
            this.Language_Convert_Chkbox_Batch = new MetroFramework.Controls.MetroCheckBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.ST_Label_Batch = new MetroFramework.Controls.MetroLabel();
            this.Language_Convert_TCT_Switcher_Btn_Batch = new MetroFramework.Controls.MetroButton();
            this.CT_Label_Batch = new MetroFramework.Controls.MetroLabel();
            this.Batch_grid = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenBtn_Batch = new MetroFramework.Controls.MetroButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.inprogressBar = new System.Windows.Forms.ProgressBar();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SettingCmd = new MetroFramework.Controls.MetroButton();
            this.TabControl1.SuspendLayout();
            this.TabPage_Single.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.TabPage_Batch.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Batch_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // languagecombobox
            // 
            this.languagecombobox.FormattingEnabled = true;
            this.languagecombobox.Items.AddRange(new object[] {
            resources.GetString("languagecombobox.Items"),
            resources.GetString("languagecombobox.Items1")});
            resources.ApplyResources(this.languagecombobox, "languagecombobox");
            this.languagecombobox.Name = "languagecombobox";
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage_Single);
            this.TabControl1.Controls.Add(this.TabPage_Batch);
            this.TabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
            resources.ApplyResources(this.TabControl1, "TabControl1");
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 1;
            this.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl1.UseSelectable = true;
            // 
            // TabPage_Single
            // 
            this.TabPage_Single.Controls.Add(this.groupBox6);
            this.TabPage_Single.Controls.Add(this.IfEmbdedFont_Chkbox);
            this.TabPage_Single.Controls.Add(this.Make_Btn);
            this.TabPage_Single.Controls.Add(this.IfReplacePicture_Chkbox);
            this.TabPage_Single.Controls.Add(this.IfDoModifyPageDirection_Chkbox);
            this.TabPage_Single.Controls.Add(this.IfConvertMobi_Chkbox);
            this.TabPage_Single.Controls.Add(this.IfDoToChineseChkbox);
            this.TabPage_Single.Controls.Add(this.OpenBtn_Single);
            this.TabPage_Single.Controls.Add(this.groupBox3);
            this.TabPage_Single.Controls.Add(this.groupBox4);
            this.TabPage_Single.Controls.Add(this.GroupBox1);
            this.TabPage_Single.HorizontalScrollbarBarColor = true;
            this.TabPage_Single.HorizontalScrollbarHighlightOnWheel = false;
            this.TabPage_Single.HorizontalScrollbarSize = 2;
            resources.ApplyResources(this.TabPage_Single, "TabPage_Single");
            this.TabPage_Single.Name = "TabPage_Single";
            this.TabPage_Single.VerticalScrollbarBarColor = true;
            this.TabPage_Single.VerticalScrollbarHighlightOnWheel = false;
            this.TabPage_Single.VerticalScrollbarSize = 3;
            this.TabPage_Single.Click += new System.EventHandler(this.TabPage_Single_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox6.Controls.Add(this.IfCustomizeLocalizationWord_cmd);
            this.groupBox6.Controls.Add(this.IfCustomizeCss_cmd);
            this.groupBox6.Controls.Add(this.SetCustomizeLocalizationWord_cmd);
            this.groupBox6.Controls.Add(this.SetCustomizeCss_cmd);
            resources.ApplyResources(this.groupBox6, "groupBox6");
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.TabStop = false;
            // 
            // IfCustomizeLocalizationWord_cmd
            // 
            resources.ApplyResources(this.IfCustomizeLocalizationWord_cmd, "IfCustomizeLocalizationWord_cmd");
            this.IfCustomizeLocalizationWord_cmd.Name = "IfCustomizeLocalizationWord_cmd";
            this.IfCustomizeLocalizationWord_cmd.UseSelectable = true;
            // 
            // IfCustomizeCss_cmd
            // 
            resources.ApplyResources(this.IfCustomizeCss_cmd, "IfCustomizeCss_cmd");
            this.IfCustomizeCss_cmd.Name = "IfCustomizeCss_cmd";
            this.IfCustomizeCss_cmd.UseSelectable = true;
            // 
            // SetCustomizeLocalizationWord_cmd
            // 
            resources.ApplyResources(this.SetCustomizeLocalizationWord_cmd, "SetCustomizeLocalizationWord_cmd");
            this.SetCustomizeLocalizationWord_cmd.Name = "SetCustomizeLocalizationWord_cmd";
            this.SetCustomizeLocalizationWord_cmd.UseSelectable = true;
            this.SetCustomizeLocalizationWord_cmd.Click += new System.EventHandler(this.SetCustomizeLocalizationWord_cmd_Click);
            // 
            // SetCustomizeCss_cmd
            // 
            resources.ApplyResources(this.SetCustomizeCss_cmd, "SetCustomizeCss_cmd");
            this.SetCustomizeCss_cmd.Name = "SetCustomizeCss_cmd";
            this.SetCustomizeCss_cmd.UseSelectable = true;
            // 
            // IfEmbdedFont_Chkbox
            // 
            resources.ApplyResources(this.IfEmbdedFont_Chkbox, "IfEmbdedFont_Chkbox");
            this.IfEmbdedFont_Chkbox.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.IfEmbdedFont_Chkbox.Name = "IfEmbdedFont_Chkbox";
            this.IfEmbdedFont_Chkbox.UseSelectable = true;
            this.IfEmbdedFont_Chkbox.CheckedChanged += new System.EventHandler(this.IfEmbdedFont_Chkbox_CheckedChanged);
            // 
            // Make_Btn
            // 
            this.Make_Btn.BackColor = System.Drawing.SystemColors.Desktop;
            this.Make_Btn.FontSize = MetroFramework.MetroButtonSize.Tall;
            resources.ApplyResources(this.Make_Btn, "Make_Btn");
            this.Make_Btn.Name = "Make_Btn";
            this.Make_Btn.Style = MetroFramework.MetroColorStyle.Lime;
            this.Make_Btn.UseSelectable = true;
            this.Make_Btn.Click += new System.EventHandler(this.Make_Btn_Click);
            // 
            // IfReplacePicture_Chkbox
            // 
            resources.ApplyResources(this.IfReplacePicture_Chkbox, "IfReplacePicture_Chkbox");
            this.IfReplacePicture_Chkbox.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.IfReplacePicture_Chkbox.Name = "IfReplacePicture_Chkbox";
            this.IfReplacePicture_Chkbox.UseSelectable = true;
            this.IfReplacePicture_Chkbox.CheckedChanged += new System.EventHandler(this.IfReplacePicture_Chkbox_CheckedChanged);
            // 
            // IfDoModifyPageDirection_Chkbox
            // 
            resources.ApplyResources(this.IfDoModifyPageDirection_Chkbox, "IfDoModifyPageDirection_Chkbox");
            this.IfDoModifyPageDirection_Chkbox.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.IfDoModifyPageDirection_Chkbox.Name = "IfDoModifyPageDirection_Chkbox";
            this.IfDoModifyPageDirection_Chkbox.UseSelectable = true;
            this.IfDoModifyPageDirection_Chkbox.CheckedChanged += new System.EventHandler(this.IfDoModifyPageDirection_Chkbox_CheckedChanged);
            // 
            // IfConvertMobi_Chkbox
            // 
            resources.ApplyResources(this.IfConvertMobi_Chkbox, "IfConvertMobi_Chkbox");
            this.IfConvertMobi_Chkbox.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.IfConvertMobi_Chkbox.Name = "IfConvertMobi_Chkbox";
            this.IfConvertMobi_Chkbox.UseSelectable = true;
            this.IfConvertMobi_Chkbox.CheckedChanged += new System.EventHandler(this.IfConvertMobi_Chkbox_CheckedChanged);
            // 
            // IfDoToChineseChkbox
            // 
            resources.ApplyResources(this.IfDoToChineseChkbox, "IfDoToChineseChkbox");
            this.IfDoToChineseChkbox.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.IfDoToChineseChkbox.Name = "IfDoToChineseChkbox";
            this.IfDoToChineseChkbox.UseSelectable = true;
            this.IfDoToChineseChkbox.CheckedChanged += new System.EventHandler(this.IfDoToTriditionChkbox_CheckChanged);
            // 
            // OpenBtn_Single
            // 
            this.OpenBtn_Single.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.OpenBtn_Single.CausesValidation = false;
            this.OpenBtn_Single.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.OpenBtn_Single.ForeColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.OpenBtn_Single, "OpenBtn_Single");
            this.OpenBtn_Single.Name = "OpenBtn_Single";
            this.OpenBtn_Single.Style = MetroFramework.MetroColorStyle.Lime;
            this.OpenBtn_Single.Theme = MetroFramework.MetroThemeStyle.Light;
            this.OpenBtn_Single.UseSelectable = true;
            this.OpenBtn_Single.Click += new System.EventHandler(this.OpenBtn_Single_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.PageRTL_Radio);
            this.groupBox3.Controls.Add(this.PageLTR_Radio);
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
            resources.ApplyResources(this.PageRTL_Radio, "PageRTL_Radio");
            this.PageRTL_Radio.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.PageRTL_Radio.Name = "PageRTL_Radio";
            this.PageRTL_Radio.UseSelectable = true;
            this.PageRTL_Radio.CheckedChanged += new System.EventHandler(this.PageRTL_Radio_CheckedChanged);
            // 
            // PageLTR_Radio
            // 
            resources.ApplyResources(this.PageLTR_Radio, "PageLTR_Radio");
            this.PageLTR_Radio.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.PageLTR_Radio.Name = "PageLTR_Radio";
            this.PageLTR_Radio.UseSelectable = true;
            this.PageLTR_Radio.CheckedChanged += new System.EventHandler(this.PageLTR_Radio_CheckedChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Controls.Add(this.Notice_Title_Can_Edit);
            this.groupBox4.Controls.Add(this.Author_Label);
            this.groupBox4.Controls.Add(this.Book_Tittle_Lebel);
            this.groupBox4.Controls.Add(this.Author_Imported_TextBox);
            this.groupBox4.Controls.Add(this.Title_Imported_TextBox);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // Notice_Title_Can_Edit
            // 
            resources.ApplyResources(this.Notice_Title_Can_Edit, "Notice_Title_Can_Edit");
            this.Notice_Title_Can_Edit.FontSize = MetroFramework.MetroLabelSize.Small;
            this.Notice_Title_Can_Edit.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Notice_Title_Can_Edit.Name = "Notice_Title_Can_Edit";
            // 
            // Author_Label
            // 
            resources.ApplyResources(this.Author_Label, "Author_Label");
            this.Author_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Author_Label.Name = "Author_Label";
            // 
            // Book_Tittle_Lebel
            // 
            resources.ApplyResources(this.Book_Tittle_Lebel, "Book_Tittle_Lebel");
            this.Book_Tittle_Lebel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Book_Tittle_Lebel.Name = "Book_Tittle_Lebel";
            // 
            // Author_Imported_TextBox
            // 
            // 
            // 
            // 
            this.Author_Imported_TextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.Author_Imported_TextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.Author_Imported_TextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.Author_Imported_TextBox.CustomButton.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("resource.Margin")));
            this.Author_Imported_TextBox.CustomButton.Name = "";
            this.Author_Imported_TextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.Author_Imported_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Author_Imported_TextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.Author_Imported_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Author_Imported_TextBox.CustomButton.UseSelectable = true;
            this.Author_Imported_TextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.Author_Imported_TextBox.Lines = new string[0];
            resources.ApplyResources(this.Author_Imported_TextBox, "Author_Imported_TextBox");
            this.Author_Imported_TextBox.MaxLength = 32767;
            this.Author_Imported_TextBox.Name = "Author_Imported_TextBox";
            this.Author_Imported_TextBox.PasswordChar = '\0';
            this.Author_Imported_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Author_Imported_TextBox.SelectedText = "";
            this.Author_Imported_TextBox.SelectionLength = 0;
            this.Author_Imported_TextBox.SelectionStart = 0;
            this.Author_Imported_TextBox.ShortcutsEnabled = true;
            this.Author_Imported_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Author_Imported_TextBox.UseSelectable = true;
            this.Author_Imported_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Author_Imported_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Title_Imported_TextBox
            // 
            // 
            // 
            // 
            this.Title_Imported_TextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.Title_Imported_TextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode1")));
            this.Title_Imported_TextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.Title_Imported_TextBox.CustomButton.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("resource.Margin1")));
            this.Title_Imported_TextBox.CustomButton.Name = "";
            this.Title_Imported_TextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.Title_Imported_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Title_Imported_TextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.Title_Imported_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Title_Imported_TextBox.CustomButton.UseSelectable = true;
            this.Title_Imported_TextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible1")));
            this.Title_Imported_TextBox.Lines = new string[0];
            resources.ApplyResources(this.Title_Imported_TextBox, "Title_Imported_TextBox");
            this.Title_Imported_TextBox.MaxLength = 32767;
            this.Title_Imported_TextBox.Name = "Title_Imported_TextBox";
            this.Title_Imported_TextBox.PasswordChar = '\0';
            this.Title_Imported_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Title_Imported_TextBox.SelectedText = "";
            this.Title_Imported_TextBox.SelectionLength = 0;
            this.Title_Imported_TextBox.SelectionStart = 0;
            this.Title_Imported_TextBox.ShortcutsEnabled = true;
            this.Title_Imported_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Title_Imported_TextBox.UseSelectable = true;
            this.Title_Imported_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Title_Imported_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GroupBox1.Controls.Add(this.ST_Label);
            this.GroupBox1.Controls.Add(this.ToTraditionValue_Cmd);
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
            resources.ApplyResources(this.ToTraditionValue_Cmd, "ToTraditionValue_Cmd");
            this.ToTraditionValue_Cmd.Name = "ToTraditionValue_Cmd";
            this.ToTraditionValue_Cmd.UseSelectable = true;
            this.ToTraditionValue_Cmd.Click += new System.EventHandler(this.ToTraditionValue_Cmd_Click);
            // 
            // CT_Label
            // 
            resources.ApplyResources(this.CT_Label, "CT_Label");
            this.CT_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.CT_Label.Name = "CT_Label";
            // 
            // TabPage_Batch
            // 
            this.TabPage_Batch.Controls.Add(this.label2);
            this.TabPage_Batch.Controls.Add(this.replacepic_batch_Chkbox);
            this.TabPage_Batch.Controls.Add(this.batch_embemed_check);
            this.TabPage_Batch.Controls.Add(this.Make_Batch);
            this.TabPage_Batch.Controls.Add(this.metroCheckBox1);
            this.TabPage_Batch.Controls.Add(this.groupBox5);
            this.TabPage_Batch.Controls.Add(this.Convert_to_Mobi_Chkbox_Batch);
            this.TabPage_Batch.Controls.Add(this.Language_Convert_Chkbox_Batch);
            this.TabPage_Batch.Controls.Add(this.GroupBox2);
            this.TabPage_Batch.Controls.Add(this.Batch_grid);
            this.TabPage_Batch.Controls.Add(this.OpenBtn_Batch);
            this.TabPage_Batch.HorizontalScrollbarBarColor = true;
            this.TabPage_Batch.HorizontalScrollbarHighlightOnWheel = false;
            this.TabPage_Batch.HorizontalScrollbarSize = 2;
            resources.ApplyResources(this.TabPage_Batch, "TabPage_Batch");
            this.TabPage_Batch.Name = "TabPage_Batch";
            this.TabPage_Batch.VerticalScrollbarBarColor = true;
            this.TabPage_Batch.VerticalScrollbarHighlightOnWheel = false;
            this.TabPage_Batch.VerticalScrollbarSize = 3;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // replacepic_batch_Chkbox
            // 
            resources.ApplyResources(this.replacepic_batch_Chkbox, "replacepic_batch_Chkbox");
            this.replacepic_batch_Chkbox.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.replacepic_batch_Chkbox.Name = "replacepic_batch_Chkbox";
            this.replacepic_batch_Chkbox.UseSelectable = true;
            // 
            // batch_embemed_check
            // 
            resources.ApplyResources(this.batch_embemed_check, "batch_embemed_check");
            this.batch_embemed_check.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.batch_embemed_check.Name = "batch_embemed_check";
            this.batch_embemed_check.UseSelectable = true;
            // 
            // Make_Batch
            // 
            resources.ApplyResources(this.Make_Batch, "Make_Batch");
            this.Make_Batch.Name = "Make_Batch";
            this.Make_Batch.UseSelectable = true;
            this.Make_Batch.Click += new System.EventHandler(this.Make_Batch_Click);
            // 
            // metroCheckBox1
            // 
            resources.ApplyResources(this.metroCheckBox1, "metroCheckBox1");
            this.metroCheckBox1.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.UseSelectable = true;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox5.Controls.Add(this.metroRadioButton1);
            this.groupBox5.Controls.Add(this.metroRadioButton2);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // metroRadioButton1
            // 
            resources.ApplyResources(this.metroRadioButton1, "metroRadioButton1");
            this.metroRadioButton1.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.UseSelectable = true;
            // 
            // metroRadioButton2
            // 
            resources.ApplyResources(this.metroRadioButton2, "metroRadioButton2");
            this.metroRadioButton2.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.UseSelectable = true;
            // 
            // Convert_to_Mobi_Chkbox_Batch
            // 
            resources.ApplyResources(this.Convert_to_Mobi_Chkbox_Batch, "Convert_to_Mobi_Chkbox_Batch");
            this.Convert_to_Mobi_Chkbox_Batch.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.Convert_to_Mobi_Chkbox_Batch.Name = "Convert_to_Mobi_Chkbox_Batch";
            this.Convert_to_Mobi_Chkbox_Batch.UseSelectable = true;
            // 
            // Language_Convert_Chkbox_Batch
            // 
            resources.ApplyResources(this.Language_Convert_Chkbox_Batch, "Language_Convert_Chkbox_Batch");
            this.Language_Convert_Chkbox_Batch.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.Language_Convert_Chkbox_Batch.Name = "Language_Convert_Chkbox_Batch";
            this.Language_Convert_Chkbox_Batch.UseSelectable = true;
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GroupBox2.Controls.Add(this.ST_Label_Batch);
            this.GroupBox2.Controls.Add(this.Language_Convert_TCT_Switcher_Btn_Batch);
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
            // Language_Convert_TCT_Switcher_Btn_Batch
            // 
            resources.ApplyResources(this.Language_Convert_TCT_Switcher_Btn_Batch, "Language_Convert_TCT_Switcher_Btn_Batch");
            this.Language_Convert_TCT_Switcher_Btn_Batch.Name = "Language_Convert_TCT_Switcher_Btn_Batch";
            this.Language_Convert_TCT_Switcher_Btn_Batch.UseSelectable = true;
            this.Language_Convert_TCT_Switcher_Btn_Batch.Click += new System.EventHandler(this.Language_Convert_TCT_Switcher_Btn_Batch_Click);
            // 
            // CT_Label_Batch
            // 
            resources.ApplyResources(this.CT_Label_Batch, "CT_Label_Batch");
            this.CT_Label_Batch.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.CT_Label_Batch.Name = "CT_Label_Batch";
            // 
            // Batch_grid
            // 
            this.Batch_grid.AllowUserToResizeRows = false;
            this.Batch_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Batch_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Batch_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Batch_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Batch_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.Batch_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Batch_grid.ColumnHeadersVisible = false;
            this.Batch_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.Batch_grid.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Batch_grid.DefaultCellStyle = dataGridViewCellStyle15;
            this.Batch_grid.EnableHeadersVisualStyles = false;
            resources.ApplyResources(this.Batch_grid, "Batch_grid");
            this.Batch_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Batch_grid.Name = "Batch_grid";
            this.Batch_grid.ReadOnly = true;
            this.Batch_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Batch_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.Batch_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Batch_grid.RowTemplate.Height = 24;
            this.Batch_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle14;
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // OpenBtn_Batch
            // 
            resources.ApplyResources(this.OpenBtn_Batch, "OpenBtn_Batch");
            this.OpenBtn_Batch.Name = "OpenBtn_Batch";
            this.OpenBtn_Batch.UseSelectable = true;
            this.OpenBtn_Batch.Click += new System.EventHandler(this.OpenBtn_Batch_Click);
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
            // 
            // inprogressBar
            // 
            resources.ApplyResources(this.inprogressBar, "inprogressBar");
            this.inprogressBar.Name = "inprogressBar";
            // 
            // StatusLabel
            // 
            resources.ApplyResources(this.StatusLabel, "StatusLabel");
            this.StatusLabel.Name = "StatusLabel";
            // 
            // SettingCmd
            // 
            resources.ApplyResources(this.SettingCmd, "SettingCmd");
            this.SettingCmd.Name = "SettingCmd";
            this.SettingCmd.UseSelectable = true;
            this.SettingCmd.Click += new System.EventHandler(this.SettingCmd_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SettingCmd);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.inprogressBar);
            this.Controls.Add(this.languagecombobox);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.TabControl1);
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl1.ResumeLayout(false);
            this.TabPage_Single.ResumeLayout(false);
            this.TabPage_Single.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.TabPage_Batch.ResumeLayout(false);
            this.TabPage_Batch.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Batch_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.ComboBox languagecombobox;
        internal MetroFramework.Controls.MetroTabPage TabPage_Single;
        internal MetroFramework.Controls.MetroButton Make_Btn;
        internal MetroFramework.Controls.MetroCheckBox IfConvertMobi_Chkbox;
        internal MetroFramework.Controls.MetroCheckBox IfDoToChineseChkbox;
        internal MetroFramework.Controls.MetroButton OpenBtn_Single;
        internal MetroFramework.Controls.MetroTextBox Title_Imported_TextBox;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal MetroFramework.Controls.MetroButton ToTraditionValue_Cmd;
        internal MetroFramework.Controls.MetroLabel CT_Label;
        internal MetroFramework.Controls.MetroTextBox Author_Imported_TextBox;
        internal MetroFramework.Controls.MetroLabel Book_Tittle_Lebel;
        internal MetroFramework.Controls.MetroLabel Author_Label;
        internal MetroFramework.Controls.MetroTabPage TabPage_Batch;
        internal MetroFramework.Controls.MetroButton Make_Batch;
        internal MetroFramework.Controls.MetroCheckBox Convert_to_Mobi_Chkbox_Batch;
        internal MetroFramework.Controls.MetroCheckBox Language_Convert_Chkbox_Batch;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal MetroFramework.Controls.MetroLabel ST_Label_Batch;
        internal MetroFramework.Controls.MetroButton Language_Convert_TCT_Switcher_Btn_Batch;
        internal MetroFramework.Controls.MetroLabel CT_Label_Batch;
        internal MetroFramework.Controls.MetroGrid Batch_grid;
        internal MetroFramework.Controls.MetroButton OpenBtn_Batch;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private MetroFramework.Controls.MetroCheckBox IfDoModifyPageDirection_Chkbox;
        private MetroFramework.Controls.MetroRadioButton PageLTR_Radio;
        private MetroFramework.Controls.MetroRadioButton PageRTL_Radio;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        internal System.Windows.Forms.GroupBox groupBox5;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroCheckBox IfEmbdedFont_Chkbox;
        internal MetroFramework.Controls.MetroLabel ST_Label;
        public MetroFramework.Components.MetroStyleManager metroStyleManager1;
        public MetroFramework.Controls.MetroLabel Notice_Title_Can_Edit;
        public MetroFramework.Controls.MetroTabControl TabControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private MetroFramework.Controls.MetroCheckBox batch_embemed_check;
        private MetroFramework.Controls.MetroCheckBox replacepic_batch_Chkbox;
        private MetroFramework.Controls.MetroCheckBox IfReplacePicture_Chkbox;
        private System.Windows.Forms.GroupBox groupBox6;
        private MetroFramework.Controls.MetroButton IfCustomizeLocalizationWord_cmd;
        private MetroFramework.Controls.MetroButton IfCustomizeCss_cmd;
        private MetroFramework.Controls.MetroButton SetCustomizeLocalizationWord_cmd;
        private MetroFramework.Controls.MetroButton SetCustomizeCss_cmd;
        public System.Windows.Forms.ProgressBar inprogressBar;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton SettingCmd;
    }
}

