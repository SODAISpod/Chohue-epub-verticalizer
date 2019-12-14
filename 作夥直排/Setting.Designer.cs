namespace ChoHoe
{
    partial class Setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mobi_manual = new System.Windows.Forms.LinkLabel();
            this.OutputMobiUsingKindlegen = new System.Windows.Forms.RadioButton();
            this.OutputMobiUsingCalibre = new System.Windows.Forms.RadioButton();
            this.KindlegenPathValidResult = new System.Windows.Forms.Label();
            this.linkLBKindlegenPathCheck = new System.Windows.Forms.LinkLabel();
            this.LinkLBKinflegenPath = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.CalibrePathValidResult = new System.Windows.Forms.Label();
            this.linkLBCalibrePathCheck = new System.Windows.Forms.LinkLabel();
            this.LinkLBCalibrePath = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PandocPathValidResult = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linklbPacdoc = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.epub_manual = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mobi_manual);
            this.groupBox1.Controls.Add(this.OutputMobiUsingKindlegen);
            this.groupBox1.Controls.Add(this.OutputMobiUsingCalibre);
            this.groupBox1.Controls.Add(this.KindlegenPathValidResult);
            this.groupBox1.Controls.Add(this.linkLBKindlegenPathCheck);
            this.groupBox1.Controls.Add(this.LinkLBKinflegenPath);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CalibrePathValidResult);
            this.groupBox1.Controls.Add(this.linkLBCalibrePathCheck);
            this.groupBox1.Controls.Add(this.LinkLBCalibrePath);
            this.groupBox1.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // mobi_manual
            // 
            resources.ApplyResources(this.mobi_manual, "mobi_manual");
            this.mobi_manual.Name = "mobi_manual";
            this.mobi_manual.TabStop = true;
            this.mobi_manual.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.mobi_manual_LinkClicked);
            // 
            // OutputMobiUsingKindlegen
            // 
            resources.ApplyResources(this.OutputMobiUsingKindlegen, "OutputMobiUsingKindlegen");
            this.OutputMobiUsingKindlegen.Name = "OutputMobiUsingKindlegen";
            this.OutputMobiUsingKindlegen.TabStop = true;
            this.OutputMobiUsingKindlegen.UseVisualStyleBackColor = true;
            this.OutputMobiUsingKindlegen.CheckedChanged += new System.EventHandler(this.OutputMobiUsingKindlegen_CheckedChanged);
            // 
            // OutputMobiUsingCalibre
            // 
            resources.ApplyResources(this.OutputMobiUsingCalibre, "OutputMobiUsingCalibre");
            this.OutputMobiUsingCalibre.Name = "OutputMobiUsingCalibre";
            this.OutputMobiUsingCalibre.TabStop = true;
            this.OutputMobiUsingCalibre.UseVisualStyleBackColor = true;
            this.OutputMobiUsingCalibre.CheckedChanged += new System.EventHandler(this.OutputMobiUsingCalibre_CheckedChanged);
            // 
            // KindlegenPathValidResult
            // 
            resources.ApplyResources(this.KindlegenPathValidResult, "KindlegenPathValidResult");
            this.KindlegenPathValidResult.ForeColor = System.Drawing.Color.Red;
            this.KindlegenPathValidResult.Name = "KindlegenPathValidResult";
            // 
            // linkLBKindlegenPathCheck
            // 
            resources.ApplyResources(this.linkLBKindlegenPathCheck, "linkLBKindlegenPathCheck");
            this.linkLBKindlegenPathCheck.Name = "linkLBKindlegenPathCheck";
            this.linkLBKindlegenPathCheck.TabStop = true;
            this.linkLBKindlegenPathCheck.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // LinkLBKinflegenPath
            // 
            resources.ApplyResources(this.LinkLBKinflegenPath, "LinkLBKinflegenPath");
            this.LinkLBKinflegenPath.Name = "LinkLBKinflegenPath";
            this.LinkLBKinflegenPath.TabStop = true;
            this.LinkLBKinflegenPath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // CalibrePathValidResult
            // 
            resources.ApplyResources(this.CalibrePathValidResult, "CalibrePathValidResult");
            this.CalibrePathValidResult.ForeColor = System.Drawing.Color.Red;
            this.CalibrePathValidResult.Name = "CalibrePathValidResult";
            // 
            // linkLBCalibrePathCheck
            // 
            resources.ApplyResources(this.linkLBCalibrePathCheck, "linkLBCalibrePathCheck");
            this.linkLBCalibrePathCheck.Name = "linkLBCalibrePathCheck";
            this.linkLBCalibrePathCheck.TabStop = true;
            this.linkLBCalibrePathCheck.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLBCalibrePathCheck_LinkClicked);
            // 
            // LinkLBCalibrePath
            // 
            resources.ApplyResources(this.LinkLBCalibrePath, "LinkLBCalibrePath");
            this.LinkLBCalibrePath.Name = "LinkLBCalibrePath";
            this.LinkLBCalibrePath.TabStop = true;
            this.LinkLBCalibrePath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel1);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.epub_manual);
            this.groupBox3.Controls.Add(this.PandocPathValidResult);
            this.groupBox3.Controls.Add(this.linkLabel2);
            this.groupBox3.Controls.Add(this.linklbPacdoc);
            this.groupBox3.Controls.Add(this.label3);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // PandocPathValidResult
            // 
            resources.ApplyResources(this.PandocPathValidResult, "PandocPathValidResult");
            this.PandocPathValidResult.ForeColor = System.Drawing.Color.Red;
            this.PandocPathValidResult.Name = "PandocPathValidResult";
            // 
            // linkLabel2
            // 
            resources.ApplyResources(this.linkLabel2, "linkLabel2");
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.TabStop = true;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linklbPacdoc
            // 
            resources.ApplyResources(this.linklbPacdoc, "linklbPacdoc");
            this.linklbPacdoc.Name = "linklbPacdoc";
            this.linklbPacdoc.TabStop = true;
            this.linklbPacdoc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbPacdoc_LinkClicked);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // epub_manual
            // 
            resources.ApplyResources(this.epub_manual, "epub_manual");
            this.epub_manual.Name = "epub_manual";
            this.epub_manual.TabStop = true;
            this.epub_manual.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.epub_manual_LinkClicked);
            // 
            // Setting
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Setting";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLBCalibrePathCheck;
        private System.Windows.Forms.LinkLabel LinkLBCalibrePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CalibrePathValidResult;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label PandocPathValidResult;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linklbPacdoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label KindlegenPathValidResult;
        private System.Windows.Forms.LinkLabel linkLBKindlegenPathCheck;
        private System.Windows.Forms.LinkLabel LinkLBKinflegenPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton OutputMobiUsingKindlegen;
        private System.Windows.Forms.RadioButton OutputMobiUsingCalibre;
        private System.Windows.Forms.LinkLabel mobi_manual;
        private System.Windows.Forms.LinkLabel epub_manual;
    }
}