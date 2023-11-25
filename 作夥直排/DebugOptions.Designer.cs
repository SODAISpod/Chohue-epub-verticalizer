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
            // DebugOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 450);
            this.Controls.Add(this.Btn_LoadXHtml);
            this.Name = "DebugOptions";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton Btn_LoadXHtml;
    }
}