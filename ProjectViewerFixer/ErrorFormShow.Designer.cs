namespace ProjectViewerFixer
{
    partial class ErrorFormShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorFormShow));
            this.dgvErrors = new System.Windows.Forms.DataGridView();
            this.cbShowOnlyFiles = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrors)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvErrors
            // 
            this.dgvErrors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvErrors.Location = new System.Drawing.Point(12, 12);
            this.dgvErrors.Name = "dgvErrors";
            this.dgvErrors.Size = new System.Drawing.Size(617, 235);
            this.dgvErrors.TabIndex = 0;
            // 
            // cbShowOnlyFiles
            // 
            this.cbShowOnlyFiles.AutoSize = true;
            this.cbShowOnlyFiles.Location = new System.Drawing.Point(12, 258);
            this.cbShowOnlyFiles.Name = "cbShowOnlyFiles";
            this.cbShowOnlyFiles.Size = new System.Drawing.Size(208, 17);
            this.cbShowOnlyFiles.TabIndex = 1;
            this.cbShowOnlyFiles.Text = "Показать только различные файлы";
            this.cbShowOnlyFiles.UseVisualStyleBackColor = true;
            this.cbShowOnlyFiles.CheckedChanged += new System.EventHandler(this.cbShowOnlyFiles_CheckedChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(328, 254);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // ErrorFormShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 287);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cbShowOnlyFiles);
            this.Controls.Add(this.dgvErrors);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(657, 325);
            this.Name = "ErrorFormShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Найдены ошибки:";
            this.Load += new System.EventHandler(this.ErrorFormShow_Load);
            this.Resize += new System.EventHandler(this.ErrorFormShow_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvErrors;
        private System.Windows.Forms.CheckBox cbShowOnlyFiles;
        private System.Windows.Forms.Button btnOk;
    }
}