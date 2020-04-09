namespace wfHttpClientDemo
{
    partial class ViewHtmlForm
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
            this.textBoxViewHtml = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxViewHtml
            // 
            this.textBoxViewHtml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxViewHtml.Location = new System.Drawing.Point(0, 0);
            this.textBoxViewHtml.Multiline = true;
            this.textBoxViewHtml.Name = "textBoxViewHtml";
            this.textBoxViewHtml.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxViewHtml.Size = new System.Drawing.Size(800, 450);
            this.textBoxViewHtml.TabIndex = 0;
            // 
            // ViewHtmlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxViewHtml);
            this.Name = "ViewHtmlForm";
            this.Text = "ViewHtmlForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxViewHtml;
    }
}