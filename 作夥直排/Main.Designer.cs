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
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.InprogressBar = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSetting = new MetroFramework.Controls.MetroButton();
            this.btnAbout = new MetroFramework.Controls.MetroButton();
            this.RunningLogo = new System.Windows.Forms.PictureBox();
            this.tbLogWindow = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbReplaceTWpunctuation = new MetroFramework.Controls.MetroCheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BatchGridView)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RunningLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Silver;
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
            // Form1
            // 
            this.AcceptButton = this.btnConvertBatch;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RunningLogo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLogWindow);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnConvertBatch);
            this.Controls.Add(this.btnLoadBatch);
            this.Controls.Add(this.cbReplaceTWpunctuation);
            this.Controls.Add(this.cbRemoveCss);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cbReplacePictureBatch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbEmbdedFontBatch);
            this.Controls.Add(this.InprogressBar);
            this.Controls.Add(this.BatchGridView);
            this.Controls.Add(this.cbModifyPageDirectionBatch);
            this.Controls.Add(this.cbConvertMobiBatch);
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
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RunningLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        public MetroFramework.Components.MetroStyleManager metroStyleManager1;
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
    }
}

