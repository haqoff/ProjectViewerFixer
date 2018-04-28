namespace ProjectViewerFixer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.msBar = new System.Windows.Forms.MenuStrip();
            this.iOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.pMain = new System.Windows.Forms.Panel();
            this.lblNameFolder = new System.Windows.Forms.Label();
            this.lblCountData = new System.Windows.Forms.Label();
            this.pFind = new System.Windows.Forms.Panel();
            this.lblFind = new System.Windows.Forms.Label();
            this.msBar.SuspendLayout();
            this.pMain.SuspendLayout();
            this.pFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // msBar
            // 
            this.msBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iOpen});
            this.msBar.Location = new System.Drawing.Point(0, 0);
            this.msBar.Name = "msBar";
            this.msBar.Size = new System.Drawing.Size(484, 24);
            this.msBar.TabIndex = 0;
            this.msBar.Text = "menuStrip1";
            // 
            // iOpen
            // 
            this.iOpen.Name = "iOpen";
            this.iOpen.Size = new System.Drawing.Size(107, 20);
            this.iOpen.Text = "Открыть проект";
            this.iOpen.Click += new System.EventHandler(this.iOpen_Click);
            // 
            // pMain
            // 
            this.pMain.Controls.Add(this.pFind);
            this.pMain.Controls.Add(this.lblCountData);
            this.pMain.Controls.Add(this.lblNameFolder);
            this.pMain.Enabled = false;
            this.pMain.Location = new System.Drawing.Point(12, 36);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(460, 402);
            this.pMain.TabIndex = 1;
            // 
            // lblNameFolder
            // 
            this.lblNameFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNameFolder.Location = new System.Drawing.Point(0, 0);
            this.lblNameFolder.Name = "lblNameFolder";
            this.lblNameFolder.Size = new System.Drawing.Size(460, 23);
            this.lblNameFolder.TabIndex = 0;
            this.lblNameFolder.Text = "Имя папки:";
            this.lblNameFolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountData
            // 
            this.lblCountData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountData.Location = new System.Drawing.Point(0, 23);
            this.lblCountData.Name = "lblCountData";
            this.lblCountData.Size = new System.Drawing.Size(460, 23);
            this.lblCountData.TabIndex = 1;
            this.lblCountData.Text = "Количество данных:";
            this.lblCountData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pFind
            // 
            this.pFind.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pFind.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pFind.Controls.Add(this.lblFind);
            this.pFind.Location = new System.Drawing.Point(3, 59);
            this.pFind.Name = "pFind";
            this.pFind.Size = new System.Drawing.Size(454, 155);
            this.pFind.TabIndex = 2;
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Location = new System.Drawing.Point(13, -2);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(41, 13);
            this.lblFind.TabIndex = 0;
            this.lblFind.Text = "Найти:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.msBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "ProjectViewerFixer";
            this.msBar.ResumeLayout(false);
            this.msBar.PerformLayout();
            this.pMain.ResumeLayout(false);
            this.pFind.ResumeLayout(false);
            this.pFind.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msBar;
        private System.Windows.Forms.ToolStripMenuItem iOpen;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Label lblCountData;
        private System.Windows.Forms.Label lblNameFolder;
        private System.Windows.Forms.Panel pFind;
        private System.Windows.Forms.Label lblFind;
    }
}

