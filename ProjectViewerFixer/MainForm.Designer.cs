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
            this.miProject = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miClose = new System.Windows.Forms.ToolStripMenuItem();
            this.pMain = new System.Windows.Forms.Panel();
            this.btnFindAndReplace = new System.Windows.Forms.Button();
            this.btnFindAndShow = new System.Windows.Forms.Button();
            this.gbReplace = new System.Windows.Forms.GroupBox();
            this.lblReplacePrice = new System.Windows.Forms.Label();
            this.cbReplacePackage = new System.Windows.Forms.ComboBox();
            this.tbReplacePrice = new System.Windows.Forms.TextBox();
            this.lblReplaceBrand = new System.Windows.Forms.Label();
            this.lblReplaceCategory = new System.Windows.Forms.Label();
            this.cbReplaceBrand = new System.Windows.Forms.ComboBox();
            this.cbReplaceSize = new System.Windows.Forms.ComboBox();
            this.lblReplacePackage = new System.Windows.Forms.Label();
            this.cbReplaceCategory = new System.Windows.Forms.ComboBox();
            this.lblReplaceSize = new System.Windows.Forms.Label();
            this.gbFind = new System.Windows.Forms.GroupBox();
            this.lblFindPrice = new System.Windows.Forms.Label();
            this.tbFindPrice = new System.Windows.Forms.TextBox();
            this.cbFindPackage = new System.Windows.Forms.ComboBox();
            this.lblFindBrand = new System.Windows.Forms.Label();
            this.lblFindCategory = new System.Windows.Forms.Label();
            this.cbFindBrand = new System.Windows.Forms.ComboBox();
            this.cbFindSize = new System.Windows.Forms.ComboBox();
            this.lblFindPackage = new System.Windows.Forms.Label();
            this.cbFindCategory = new System.Windows.Forms.ComboBox();
            this.lblFindSize = new System.Windows.Forms.Label();
            this.lblCountData = new System.Windows.Forms.Label();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.msBar.SuspendLayout();
            this.pMain.SuspendLayout();
            this.gbReplace.SuspendLayout();
            this.gbFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // msBar
            // 
            this.msBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miProject});
            this.msBar.Location = new System.Drawing.Point(0, 0);
            this.msBar.Name = "msBar";
            this.msBar.Size = new System.Drawing.Size(484, 24);
            this.msBar.TabIndex = 0;
            this.msBar.Text = "menuStrip1";
            // 
            // miProject
            // 
            this.miProject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOpen,
            this.miClose});
            this.miProject.Name = "miProject";
            this.miProject.Size = new System.Drawing.Size(59, 20);
            this.miProject.Text = "Проект";
            // 
            // miOpen
            // 
            this.miOpen.Name = "miOpen";
            this.miOpen.Size = new System.Drawing.Size(121, 22);
            this.miOpen.Text = "Открыть";
            this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
            // 
            // miClose
            // 
            this.miClose.Enabled = false;
            this.miClose.Name = "miClose";
            this.miClose.Size = new System.Drawing.Size(121, 22);
            this.miClose.Text = "Закрыть";
            this.miClose.Click += new System.EventHandler(this.miClose_Click);
            // 
            // pMain
            // 
            this.pMain.Controls.Add(this.btnFindAndReplace);
            this.pMain.Controls.Add(this.btnFindAndShow);
            this.pMain.Controls.Add(this.gbReplace);
            this.pMain.Controls.Add(this.gbFind);
            this.pMain.Controls.Add(this.lblCountData);
            this.pMain.Controls.Add(this.lblProjectName);
            this.pMain.Enabled = false;
            this.pMain.Location = new System.Drawing.Point(12, 36);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(460, 402);
            this.pMain.TabIndex = 1;
            // 
            // btnFindAndReplace
            // 
            this.btnFindAndReplace.Location = new System.Drawing.Point(275, 376);
            this.btnFindAndReplace.Name = "btnFindAndReplace";
            this.btnFindAndReplace.Size = new System.Drawing.Size(119, 23);
            this.btnFindAndReplace.TabIndex = 12;
            this.btnFindAndReplace.Text = "Найти и заменить";
            this.btnFindAndReplace.UseVisualStyleBackColor = true;
            this.btnFindAndReplace.Click += new System.EventHandler(this.btnFindAndReplace_Click);
            // 
            // btnFindAndShow
            // 
            this.btnFindAndShow.Location = new System.Drawing.Point(65, 376);
            this.btnFindAndShow.Name = "btnFindAndShow";
            this.btnFindAndShow.Size = new System.Drawing.Size(119, 23);
            this.btnFindAndShow.TabIndex = 11;
            this.btnFindAndShow.Text = "Найти и показать";
            this.btnFindAndShow.UseVisualStyleBackColor = true;
            this.btnFindAndShow.Click += new System.EventHandler(this.btnFindAndShow_Click);
            // 
            // gbReplace
            // 
            this.gbReplace.Controls.Add(this.lblReplacePrice);
            this.gbReplace.Controls.Add(this.cbReplacePackage);
            this.gbReplace.Controls.Add(this.tbReplacePrice);
            this.gbReplace.Controls.Add(this.lblReplaceBrand);
            this.gbReplace.Controls.Add(this.lblReplaceCategory);
            this.gbReplace.Controls.Add(this.cbReplaceBrand);
            this.gbReplace.Controls.Add(this.cbReplaceSize);
            this.gbReplace.Controls.Add(this.lblReplacePackage);
            this.gbReplace.Controls.Add(this.cbReplaceCategory);
            this.gbReplace.Controls.Add(this.lblReplaceSize);
            this.gbReplace.Location = new System.Drawing.Point(3, 214);
            this.gbReplace.Name = "gbReplace";
            this.gbReplace.Size = new System.Drawing.Size(454, 156);
            this.gbReplace.TabIndex = 10;
            this.gbReplace.TabStop = false;
            this.gbReplace.Text = "Заменить на:";
            // 
            // lblReplacePrice
            // 
            this.lblReplacePrice.AutoSize = true;
            this.lblReplacePrice.Location = new System.Drawing.Point(4, 133);
            this.lblReplacePrice.Name = "lblReplacePrice";
            this.lblReplacePrice.Size = new System.Drawing.Size(34, 13);
            this.lblReplacePrice.TabIndex = 16;
            this.lblReplacePrice.Text = "Price:";
            // 
            // cbReplacePackage
            // 
            this.cbReplacePackage.FormattingEnabled = true;
            this.cbReplacePackage.Location = new System.Drawing.Point(62, 76);
            this.cbReplacePackage.Name = "cbReplacePackage";
            this.cbReplacePackage.Size = new System.Drawing.Size(386, 21);
            this.cbReplacePackage.Sorted = true;
            this.cbReplacePackage.TabIndex = 5;
            this.cbReplacePackage.Leave += new System.EventHandler(this.OnComboboxLeave);
            // 
            // tbReplacePrice
            // 
            this.tbReplacePrice.Location = new System.Drawing.Point(62, 130);
            this.tbReplacePrice.Name = "tbReplacePrice";
            this.tbReplacePrice.Size = new System.Drawing.Size(386, 20);
            this.tbReplacePrice.TabIndex = 15;
            // 
            // lblReplaceBrand
            // 
            this.lblReplaceBrand.AutoSize = true;
            this.lblReplaceBrand.Location = new System.Drawing.Point(4, 106);
            this.lblReplaceBrand.Name = "lblReplaceBrand";
            this.lblReplaceBrand.Size = new System.Drawing.Size(38, 13);
            this.lblReplaceBrand.TabIndex = 8;
            this.lblReplaceBrand.Text = "Brand:";
            // 
            // lblReplaceCategory
            // 
            this.lblReplaceCategory.AutoSize = true;
            this.lblReplaceCategory.Location = new System.Drawing.Point(4, 24);
            this.lblReplaceCategory.Name = "lblReplaceCategory";
            this.lblReplaceCategory.Size = new System.Drawing.Size(52, 13);
            this.lblReplaceCategory.TabIndex = 2;
            this.lblReplaceCategory.Text = "Category:";
            // 
            // cbReplaceBrand
            // 
            this.cbReplaceBrand.FormattingEnabled = true;
            this.cbReplaceBrand.Location = new System.Drawing.Point(62, 103);
            this.cbReplaceBrand.Name = "cbReplaceBrand";
            this.cbReplaceBrand.Size = new System.Drawing.Size(386, 21);
            this.cbReplaceBrand.Sorted = true;
            this.cbReplaceBrand.TabIndex = 7;
            this.cbReplaceBrand.Leave += new System.EventHandler(this.OnComboboxLeave);
            // 
            // cbReplaceSize
            // 
            this.cbReplaceSize.FormattingEnabled = true;
            this.cbReplaceSize.Location = new System.Drawing.Point(62, 49);
            this.cbReplaceSize.Name = "cbReplaceSize";
            this.cbReplaceSize.Size = new System.Drawing.Size(386, 21);
            this.cbReplaceSize.Sorted = true;
            this.cbReplaceSize.TabIndex = 3;
            this.cbReplaceSize.Leave += new System.EventHandler(this.OnComboboxLeave);
            // 
            // lblReplacePackage
            // 
            this.lblReplacePackage.AutoSize = true;
            this.lblReplacePackage.Location = new System.Drawing.Point(4, 79);
            this.lblReplacePackage.Name = "lblReplacePackage";
            this.lblReplacePackage.Size = new System.Drawing.Size(53, 13);
            this.lblReplacePackage.TabIndex = 6;
            this.lblReplacePackage.Text = "Package:";
            // 
            // cbReplaceCategory
            // 
            this.cbReplaceCategory.FormattingEnabled = true;
            this.cbReplaceCategory.Location = new System.Drawing.Point(62, 21);
            this.cbReplaceCategory.Name = "cbReplaceCategory";
            this.cbReplaceCategory.Size = new System.Drawing.Size(386, 21);
            this.cbReplaceCategory.Sorted = true;
            this.cbReplaceCategory.TabIndex = 1;
            this.cbReplaceCategory.Leave += new System.EventHandler(this.OnComboboxLeave);
            // 
            // lblReplaceSize
            // 
            this.lblReplaceSize.AutoSize = true;
            this.lblReplaceSize.Location = new System.Drawing.Point(4, 52);
            this.lblReplaceSize.Name = "lblReplaceSize";
            this.lblReplaceSize.Size = new System.Drawing.Size(30, 13);
            this.lblReplaceSize.TabIndex = 4;
            this.lblReplaceSize.Text = "Size:";
            // 
            // gbFind
            // 
            this.gbFind.Controls.Add(this.lblFindPrice);
            this.gbFind.Controls.Add(this.tbFindPrice);
            this.gbFind.Controls.Add(this.cbFindPackage);
            this.gbFind.Controls.Add(this.lblFindBrand);
            this.gbFind.Controls.Add(this.lblFindCategory);
            this.gbFind.Controls.Add(this.cbFindBrand);
            this.gbFind.Controls.Add(this.cbFindSize);
            this.gbFind.Controls.Add(this.lblFindPackage);
            this.gbFind.Controls.Add(this.cbFindCategory);
            this.gbFind.Controls.Add(this.lblFindSize);
            this.gbFind.Location = new System.Drawing.Point(3, 49);
            this.gbFind.Name = "gbFind";
            this.gbFind.Size = new System.Drawing.Size(454, 159);
            this.gbFind.TabIndex = 9;
            this.gbFind.TabStop = false;
            this.gbFind.Text = "Найти:";
            // 
            // lblFindPrice
            // 
            this.lblFindPrice.AutoSize = true;
            this.lblFindPrice.Location = new System.Drawing.Point(4, 133);
            this.lblFindPrice.Name = "lblFindPrice";
            this.lblFindPrice.Size = new System.Drawing.Size(34, 13);
            this.lblFindPrice.TabIndex = 14;
            this.lblFindPrice.Text = "Price:";
            // 
            // tbFindPrice
            // 
            this.tbFindPrice.Location = new System.Drawing.Point(62, 130);
            this.tbFindPrice.Name = "tbFindPrice";
            this.tbFindPrice.Size = new System.Drawing.Size(386, 20);
            this.tbFindPrice.TabIndex = 13;
            // 
            // cbFindPackage
            // 
            this.cbFindPackage.FormattingEnabled = true;
            this.cbFindPackage.Location = new System.Drawing.Point(62, 76);
            this.cbFindPackage.Name = "cbFindPackage";
            this.cbFindPackage.Size = new System.Drawing.Size(386, 21);
            this.cbFindPackage.Sorted = true;
            this.cbFindPackage.TabIndex = 5;
            this.cbFindPackage.Leave += new System.EventHandler(this.OnComboboxLeave);
            // 
            // lblFindBrand
            // 
            this.lblFindBrand.AutoSize = true;
            this.lblFindBrand.Location = new System.Drawing.Point(4, 106);
            this.lblFindBrand.Name = "lblFindBrand";
            this.lblFindBrand.Size = new System.Drawing.Size(38, 13);
            this.lblFindBrand.TabIndex = 8;
            this.lblFindBrand.Text = "Brand:";
            // 
            // lblFindCategory
            // 
            this.lblFindCategory.AutoSize = true;
            this.lblFindCategory.Location = new System.Drawing.Point(4, 24);
            this.lblFindCategory.Name = "lblFindCategory";
            this.lblFindCategory.Size = new System.Drawing.Size(52, 13);
            this.lblFindCategory.TabIndex = 2;
            this.lblFindCategory.Text = "Category:";
            // 
            // cbFindBrand
            // 
            this.cbFindBrand.FormattingEnabled = true;
            this.cbFindBrand.Location = new System.Drawing.Point(62, 103);
            this.cbFindBrand.Name = "cbFindBrand";
            this.cbFindBrand.Size = new System.Drawing.Size(386, 21);
            this.cbFindBrand.Sorted = true;
            this.cbFindBrand.TabIndex = 7;
            this.cbFindBrand.Leave += new System.EventHandler(this.OnComboboxLeave);
            // 
            // cbFindSize
            // 
            this.cbFindSize.FormattingEnabled = true;
            this.cbFindSize.Location = new System.Drawing.Point(62, 49);
            this.cbFindSize.Name = "cbFindSize";
            this.cbFindSize.Size = new System.Drawing.Size(386, 21);
            this.cbFindSize.Sorted = true;
            this.cbFindSize.TabIndex = 3;
            this.cbFindSize.Leave += new System.EventHandler(this.OnComboboxLeave);
            // 
            // lblFindPackage
            // 
            this.lblFindPackage.AutoSize = true;
            this.lblFindPackage.Location = new System.Drawing.Point(4, 79);
            this.lblFindPackage.Name = "lblFindPackage";
            this.lblFindPackage.Size = new System.Drawing.Size(53, 13);
            this.lblFindPackage.TabIndex = 6;
            this.lblFindPackage.Text = "Package:";
            // 
            // cbFindCategory
            // 
            this.cbFindCategory.FormattingEnabled = true;
            this.cbFindCategory.Location = new System.Drawing.Point(62, 21);
            this.cbFindCategory.Name = "cbFindCategory";
            this.cbFindCategory.Size = new System.Drawing.Size(386, 21);
            this.cbFindCategory.Sorted = true;
            this.cbFindCategory.TabIndex = 1;
            this.cbFindCategory.Leave += new System.EventHandler(this.OnComboboxLeave);
            // 
            // lblFindSize
            // 
            this.lblFindSize.AutoSize = true;
            this.lblFindSize.Location = new System.Drawing.Point(4, 52);
            this.lblFindSize.Name = "lblFindSize";
            this.lblFindSize.Size = new System.Drawing.Size(30, 13);
            this.lblFindSize.TabIndex = 4;
            this.lblFindSize.Text = "Size:";
            // 
            // lblCountData
            // 
            this.lblCountData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountData.Location = new System.Drawing.Point(0, 23);
            this.lblCountData.Name = "lblCountData";
            this.lblCountData.Size = new System.Drawing.Size(460, 23);
            this.lblCountData.TabIndex = 1;
            this.lblCountData.Text = "Количество файлов данных:";
            this.lblCountData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProjectName
            // 
            this.lblProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProjectName.Location = new System.Drawing.Point(0, 0);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(460, 23);
            this.lblProjectName.TabIndex = 0;
            this.lblProjectName.Text = "Имя проекта:";
            this.lblProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.gbReplace.ResumeLayout(false);
            this.gbReplace.PerformLayout();
            this.gbFind.ResumeLayout(false);
            this.gbFind.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msBar;
        private System.Windows.Forms.ToolStripMenuItem miProject;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Label lblCountData;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.GroupBox gbReplace;
        private System.Windows.Forms.ComboBox cbReplacePackage;
        private System.Windows.Forms.Label lblReplaceBrand;
        private System.Windows.Forms.Label lblReplaceCategory;
        private System.Windows.Forms.ComboBox cbReplaceBrand;
        private System.Windows.Forms.ComboBox cbReplaceSize;
        private System.Windows.Forms.Label lblReplacePackage;
        private System.Windows.Forms.ComboBox cbReplaceCategory;
        private System.Windows.Forms.Label lblReplaceSize;
        private System.Windows.Forms.GroupBox gbFind;
        private System.Windows.Forms.ComboBox cbFindPackage;
        private System.Windows.Forms.Label lblFindBrand;
        private System.Windows.Forms.Label lblFindCategory;
        private System.Windows.Forms.ComboBox cbFindBrand;
        private System.Windows.Forms.ComboBox cbFindSize;
        private System.Windows.Forms.Label lblFindPackage;
        private System.Windows.Forms.ComboBox cbFindCategory;
        private System.Windows.Forms.Label lblFindSize;
        private System.Windows.Forms.Button btnFindAndReplace;
        private System.Windows.Forms.Button btnFindAndShow;
        private System.Windows.Forms.Label lblReplacePrice;
        private System.Windows.Forms.TextBox tbReplacePrice;
        private System.Windows.Forms.Label lblFindPrice;
        private System.Windows.Forms.TextBox tbFindPrice;
        private System.Windows.Forms.ToolStripMenuItem miOpen;
        private System.Windows.Forms.ToolStripMenuItem miClose;
    }
}

