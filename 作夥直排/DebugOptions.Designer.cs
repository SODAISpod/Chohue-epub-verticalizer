namespace ChoHoe
{
    partial class DebugOptions
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
            this.Btn_LoadXHtml = new MetroFramework.Controls.MetroButton();
            this.btn_enableAllOption = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_disableAllOption = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_disableConvert = new MetroFramework.Controls.MetroButton();
            this.btn_enableConvert = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_LoadXHtml
            // 
            this.Btn_LoadXHtml.Location = new System.Drawing.Point(32, 34);
            this.Btn_LoadXHtml.Name = "Btn_LoadXHtml";
            this.Btn_LoadXHtml.Size = new System.Drawing.Size(120, 23);
            this.Btn_LoadXHtml.TabIndex = 0;
            this.Btn_LoadXHtml.Text = "Btn_LoadXHtml";
            this.Btn_LoadXHtml.UseSelectable = true;
            this.Btn_LoadXHtml.Click += new System.EventHandler(this.Btn_LoadXHtml_Click);
            // 
            // btn_enableAllOption
            // 
            this.btn_enableAllOption.Location = new System.Drawing.Point(32, 63);
            this.btn_enableAllOption.Name = "btn_enableAllOption";
            this.btn_enableAllOption.Size = new System.Drawing.Size(120, 23);
            this.btn_enableAllOption.TabIndex = 0;
            this.btn_enableAllOption.Text = "Enable All Option";
            this.btn_enableAllOption.UseSelectable = true;
            this.btn_enableAllOption.Click += new System.EventHandler(this.Btn_LoadXHtml_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "LTR, TC > SC, No CSS";
            // 
            // btn_disableAllOption
            // 
            this.btn_disableAllOption.Location = new System.Drawing.Point(32, 92);
            this.btn_disableAllOption.Name = "btn_disableAllOption";
            this.btn_disableAllOption.Size = new System.Drawing.Size(120, 23);
            this.btn_disableAllOption.TabIndex = 0;
            this.btn_disableAllOption.Text = "Disable All Option";
            this.btn_disableAllOption.UseSelectable = true;
            this.btn_disableAllOption.Click += new System.EventHandler(this.btn_disableAllOption_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChoHoe.Properties.Resources.工作區域_1__5_;
            this.pictureBox1.Location = new System.Drawing.Point(69, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 405);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_disableConvert
            // 
            this.btn_disableConvert.Location = new System.Drawing.Point(32, 121);
            this.btn_disableConvert.Name = "btn_disableConvert";
            this.btn_disableConvert.Size = new System.Drawing.Size(120, 23);
            this.btn_disableConvert.TabIndex = 0;
            this.btn_disableConvert.Text = "Disable Convert";
            this.btn_disableConvert.UseSelectable = true;
            this.btn_disableConvert.Click += new System.EventHandler(this.btn_disableConvert_Click);
            // 
            // btn_enableConvert
            // 
            this.btn_enableConvert.Location = new System.Drawing.Point(32, 150);
            this.btn_enableConvert.Name = "btn_enableConvert";
            this.btn_enableConvert.Size = new System.Drawing.Size(120, 23);
            this.btn_enableConvert.TabIndex = 0;
            this.btn_enableConvert.Text = "Enable Convert";
            this.btn_enableConvert.UseSelectable = true;
            this.btn_enableConvert.Click += new System.EventHandler(this.btn_enableConvert_Click);
            // 
            // DebugOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_enableConvert);
            this.Controls.Add(this.btn_disableConvert);
            this.Controls.Add(this.btn_disableAllOption);
            this.Controls.Add(this.btn_enableAllOption);
            this.Controls.Add(this.Btn_LoadXHtml);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DebugOptions";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton Btn_LoadXHtml;
        private MetroFramework.Controls.MetroButton btn_enableAllOption;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btn_disableAllOption;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btn_disableConvert;
        private MetroFramework.Controls.MetroButton btn_enableConvert;
    }
}