namespace wfHttpClientDemo
{
    partial class ViewDataGridForm
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
            this.dataGridViewURL = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewURL)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewURL
            // 
            this.dataGridViewURL.AllowUserToAddRows = false;
            this.dataGridViewURL.AllowUserToDeleteRows = false;
            this.dataGridViewURL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewURL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.urlImage,
            this.image});
            this.dataGridViewURL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewURL.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewURL.Name = "dataGridViewURL";
            this.dataGridViewURL.Size = new System.Drawing.Size(800, 450);
            this.dataGridViewURL.TabIndex = 0;
            this.dataGridViewURL.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewURL_CellDoubleClick);
            // 
            // number
            // 
            this.number.HeaderText = "#";
            this.number.Name = "number";
            // 
            // urlImage
            // 
            this.urlImage.HeaderText = "URL";
            this.urlImage.Name = "urlImage";
            // 
            // image
            // 
            this.image.HeaderText = "IMG";
            this.image.Name = "image";
            this.image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ViewDataGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewURL);
            this.Name = "ViewDataGridForm";
            this.Text = "ViewDataGridForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewURL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridViewURL;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlImage;
        private System.Windows.Forms.DataGridViewImageColumn image;
    }
}