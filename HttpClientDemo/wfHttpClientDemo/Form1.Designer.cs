﻿namespace wfHttpClientDemo
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxSiteUrl = new System.Windows.Forms.TextBox();
            this.labelSiteAdress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNodes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSingleNode = new System.Windows.Forms.TextBox();
            this.buttonfillsa = new System.Windows.Forms.Button();
            this.buttonfilln = new System.Windows.Forms.Button();
            this.buttonfillsn = new System.Windows.Forms.Button();
            this.dataGridViewMainForm = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrlPoster = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMainForm)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(433, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "parse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxSiteUrl
            // 
            this.textBoxSiteUrl.Location = new System.Drawing.Point(85, 12);
            this.textBoxSiteUrl.Name = "textBoxSiteUrl";
            this.textBoxSiteUrl.Size = new System.Drawing.Size(282, 20);
            this.textBoxSiteUrl.TabIndex = 1;
            // 
            // labelSiteAdress
            // 
            this.labelSiteAdress.AutoSize = true;
            this.labelSiteAdress.Location = new System.Drawing.Point(12, 15);
            this.labelSiteAdress.Name = "labelSiteAdress";
            this.labelSiteAdress.Size = new System.Drawing.Size(63, 13);
            this.labelSiteAdress.TabIndex = 3;
            this.labelSiteAdress.Text = "Site Adress:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nodes:";
            // 
            // textBoxNodes
            // 
            this.textBoxNodes.Location = new System.Drawing.Point(85, 42);
            this.textBoxNodes.Name = "textBoxNodes";
            this.textBoxNodes.Size = new System.Drawing.Size(282, 20);
            this.textBoxNodes.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "SingleNode:";
            // 
            // textBoxSingleNode
            // 
            this.textBoxSingleNode.Location = new System.Drawing.Point(85, 72);
            this.textBoxSingleNode.Name = "textBoxSingleNode";
            this.textBoxSingleNode.Size = new System.Drawing.Size(282, 20);
            this.textBoxSingleNode.TabIndex = 1;
            // 
            // buttonfillsa
            // 
            this.buttonfillsa.Location = new System.Drawing.Point(373, 12);
            this.buttonfillsa.Name = "buttonfillsa";
            this.buttonfillsa.Size = new System.Drawing.Size(75, 23);
            this.buttonfillsa.TabIndex = 5;
            this.buttonfillsa.Text = "fill";
            this.buttonfillsa.UseVisualStyleBackColor = true;
            this.buttonfillsa.Click += new System.EventHandler(this.buttonfillsa_Click);
            // 
            // buttonfilln
            // 
            this.buttonfilln.Location = new System.Drawing.Point(373, 41);
            this.buttonfilln.Name = "buttonfilln";
            this.buttonfilln.Size = new System.Drawing.Size(75, 23);
            this.buttonfilln.TabIndex = 5;
            this.buttonfilln.Text = "fill";
            this.buttonfilln.UseVisualStyleBackColor = true;
            this.buttonfilln.Click += new System.EventHandler(this.buttonfilln_Click);
            // 
            // buttonfillsn
            // 
            this.buttonfillsn.Location = new System.Drawing.Point(373, 70);
            this.buttonfillsn.Name = "buttonfillsn";
            this.buttonfillsn.Size = new System.Drawing.Size(75, 23);
            this.buttonfillsn.TabIndex = 5;
            this.buttonfillsn.Text = "fill";
            this.buttonfillsn.UseVisualStyleBackColor = true;
            this.buttonfillsn.Click += new System.EventHandler(this.buttonfillsn_Click);
            // 
            // dataGridViewMainForm
            // 
            this.dataGridViewMainForm.AllowUserToAddRows = false;
            this.dataGridViewMainForm.AllowUserToDeleteRows = false;
            this.dataGridViewMainForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMainForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.UrlPoster});
            this.dataGridViewMainForm.Location = new System.Drawing.Point(15, 127);
            this.dataGridViewMainForm.Name = "dataGridViewMainForm";
            this.dataGridViewMainForm.ReadOnly = true;
            this.dataGridViewMainForm.Size = new System.Drawing.Size(431, 407);
            this.dataGridViewMainForm.TabIndex = 6;
            // 
            // number
            // 
            this.number.HeaderText = "#";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // UrlPoster
            // 
            this.UrlPoster.HeaderText = "URL";
            this.UrlPoster.Name = "UrlPoster";
            this.UrlPoster.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 546);
            this.Controls.Add(this.dataGridViewMainForm);
            this.Controls.Add(this.buttonfillsn);
            this.Controls.Add(this.buttonfilln);
            this.Controls.Add(this.buttonfillsa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSiteAdress);
            this.Controls.Add(this.textBoxSingleNode);
            this.Controls.Add(this.textBoxNodes);
            this.Controls.Add(this.textBoxSiteUrl);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMainForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxSiteUrl;
        private System.Windows.Forms.Label labelSiteAdress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNodes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSingleNode;
        private System.Windows.Forms.Button buttonfillsa;
        private System.Windows.Forms.Button buttonfilln;
        private System.Windows.Forms.Button buttonfillsn;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrlPoster;
        public System.Windows.Forms.DataGridView dataGridViewMainForm;
    }
}

