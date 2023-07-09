namespace ChoHoe
{
    partial class FillCustomizeCSS
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
            this.rtb_CSS = new System.Windows.Forms.RichTextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb_CSS
            // 
            this.rtb_CSS.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_CSS.Location = new System.Drawing.Point(23, 73);
            this.rtb_CSS.Name = "rtb_CSS";
            this.rtb_CSS.Size = new System.Drawing.Size(514, 406);
            this.rtb_CSS.TabIndex = 0;
            this.rtb_CSS.Text = "";
            this.rtb_CSS.TextChanged += new System.EventHandler(this.rtb_CSS_TextChanged);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Save.Location = new System.Drawing.Point(462, 494);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 41);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "儲存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // FillCustomizeCSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(568, 560);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.rtb_CSS);
            this.Name = "FillCustomizeCSS";
            this.Text = "填入自訂的 CSS";
            this.Load += new System.EventHandler(this.FillCustomizeCSS_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_CSS;
        private System.Windows.Forms.Button btn_Save;
    }
}