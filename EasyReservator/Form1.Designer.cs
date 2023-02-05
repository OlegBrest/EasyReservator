namespace EasyReservator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dirsWorkedTextBox = new System.Windows.Forms.TextBox();
            this.filesWorkedTextBox = new System.Windows.Forms.TextBox();
            this.filesFindedTextBox = new System.Windows.Forms.TextBox();
            this.dirsFindedTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.currentDirTextBox = new System.Windows.Forms.TextBox();
            this.currentFileTextBox = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.deleteEmptyDirCheckBox = new System.Windows.Forms.CheckBox();
            this.deleteCheckBox = new System.Windows.Forms.CheckBox();
            this.autoRenameCheckBox = new System.Windows.Forms.CheckBox();
            this.copyTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.savePathButton = new System.Windows.Forms.Button();
            this.savePathTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.excludeDirsListBox = new System.Windows.Forms.ListBox();
            this.excludeAddButton = new System.Windows.Forms.Button();
            this.excludeDelButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.scanedDirsListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.InterfaceUpdater = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.progressBar);
            this.panel1.Controls.Add(this.stopButton);
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 506);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.dirsWorkedTextBox);
            this.panel6.Controls.Add(this.filesWorkedTextBox);
            this.panel6.Controls.Add(this.filesFindedTextBox);
            this.panel6.Controls.Add(this.dirsFindedTextBox);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.currentDirTextBox);
            this.panel6.Controls.Add(this.currentFileTextBox);
            this.panel6.Location = new System.Drawing.Point(4, 336);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(644, 138);
            this.panel6.TabIndex = 10;
            // 
            // dirsWorkedTextBox
            // 
            this.dirsWorkedTextBox.Location = new System.Drawing.Point(291, 3);
            this.dirsWorkedTextBox.Name = "dirsWorkedTextBox";
            this.dirsWorkedTextBox.ReadOnly = true;
            this.dirsWorkedTextBox.Size = new System.Drawing.Size(83, 20);
            this.dirsWorkedTextBox.TabIndex = 13;
            // 
            // filesWorkedTextBox
            // 
            this.filesWorkedTextBox.Location = new System.Drawing.Point(291, 26);
            this.filesWorkedTextBox.Name = "filesWorkedTextBox";
            this.filesWorkedTextBox.ReadOnly = true;
            this.filesWorkedTextBox.Size = new System.Drawing.Size(83, 20);
            this.filesWorkedTextBox.TabIndex = 13;
            // 
            // filesFindedTextBox
            // 
            this.filesFindedTextBox.Location = new System.Drawing.Point(95, 26);
            this.filesFindedTextBox.Name = "filesFindedTextBox";
            this.filesFindedTextBox.ReadOnly = true;
            this.filesFindedTextBox.Size = new System.Drawing.Size(83, 20);
            this.filesFindedTextBox.TabIndex = 13;
            // 
            // dirsFindedTextBox
            // 
            this.dirsFindedTextBox.Location = new System.Drawing.Point(95, 3);
            this.dirsFindedTextBox.Name = "dirsFindedTextBox";
            this.dirsFindedTextBox.ReadOnly = true;
            this.dirsFindedTextBox.Size = new System.Drawing.Size(83, 20);
            this.dirsFindedTextBox.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Найдено файлов";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(184, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Обработано файлов";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(186, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Обработано папок";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Найдено папок";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Текущая папка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Текущий файл";
            // 
            // currentDirTextBox
            // 
            this.currentDirTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.currentDirTextBox.Location = new System.Drawing.Point(6, 73);
            this.currentDirTextBox.Name = "currentDirTextBox";
            this.currentDirTextBox.ReadOnly = true;
            this.currentDirTextBox.Size = new System.Drawing.Size(628, 20);
            this.currentDirTextBox.TabIndex = 9;
            // 
            // currentFileTextBox
            // 
            this.currentFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.currentFileTextBox.Location = new System.Drawing.Point(6, 112);
            this.currentFileTextBox.Name = "currentFileTextBox";
            this.currentFileTextBox.ReadOnly = true;
            this.currentFileTextBox.Size = new System.Drawing.Size(628, 20);
            this.currentFileTextBox.TabIndex = 9;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(11, 480);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(475, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 8;
            this.progressBar.Visible = false;
            // 
            // stopButton
            // 
            this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(573, 480);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 7;
            this.stopButton.Text = "Остановить";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.Location = new System.Drawing.Point(492, 480);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Начать";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.deleteEmptyDirCheckBox);
            this.panel5.Controls.Add(this.deleteCheckBox);
            this.panel5.Controls.Add(this.autoRenameCheckBox);
            this.panel5.Controls.Add(this.copyTypeComboBox);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(3, 257);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(645, 72);
            this.panel5.TabIndex = 6;
            // 
            // deleteEmptyDirCheckBox
            // 
            this.deleteEmptyDirCheckBox.AutoSize = true;
            this.deleteEmptyDirCheckBox.Location = new System.Drawing.Point(334, 47);
            this.deleteEmptyDirCheckBox.Name = "deleteEmptyDirCheckBox";
            this.deleteEmptyDirCheckBox.Size = new System.Drawing.Size(138, 17);
            this.deleteEmptyDirCheckBox.TabIndex = 3;
            this.deleteEmptyDirCheckBox.Text = "удалить пустые папки";
            this.deleteEmptyDirCheckBox.UseVisualStyleBackColor = true;
            // 
            // deleteCheckBox
            // 
            this.deleteCheckBox.AutoSize = true;
            this.deleteCheckBox.Location = new System.Drawing.Point(212, 47);
            this.deleteCheckBox.Name = "deleteCheckBox";
            this.deleteCheckBox.Size = new System.Drawing.Size(116, 17);
            this.deleteCheckBox.TabIndex = 3;
            this.deleteCheckBox.Text = "удалить оригинал";
            this.deleteCheckBox.UseVisualStyleBackColor = true;
            // 
            // autoRenameCheckBox
            // 
            this.autoRenameCheckBox.AutoSize = true;
            this.autoRenameCheckBox.Checked = true;
            this.autoRenameCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoRenameCheckBox.Location = new System.Drawing.Point(10, 47);
            this.autoRenameCheckBox.Name = "autoRenameCheckBox";
            this.autoRenameCheckBox.Size = new System.Drawing.Size(196, 17);
            this.autoRenameCheckBox.TabIndex = 2;
            this.autoRenameCheckBox.Text = "автопереименование дубликатов";
            this.autoRenameCheckBox.UseVisualStyleBackColor = true;
            // 
            // copyTypeComboBox
            // 
            this.copyTypeComboBox.FormattingEnabled = true;
            this.copyTypeComboBox.Items.AddRange(new object[] {
            "С сохранением путей",
            "Сортировать по типам файлов",
            "Всё в 1 папку"});
            this.copyTypeComboBox.Location = new System.Drawing.Point(8, 17);
            this.copyTypeComboBox.Name = "copyTypeComboBox";
            this.copyTypeComboBox.Size = new System.Drawing.Size(627, 21);
            this.copyTypeComboBox.TabIndex = 1;
            this.copyTypeComboBox.Text = "С сохранением путей";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Способ копирования";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.filterTextBox);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(3, 202);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(645, 48);
            this.panel4.TabIndex = 5;
            // 
            // filterTextBox
            // 
            this.filterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.filterTextBox.Location = new System.Drawing.Point(8, 16);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(627, 20);
            this.filterTextBox.TabIndex = 1;
            this.filterTextBox.Text = "*.doc;*.docx";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Фильтр по типам файлов, разделитель \";\" например *.doc;*.docx;*.xls";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.savePathButton);
            this.panel3.Controls.Add(this.savePathTextBox);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(3, 147);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(645, 48);
            this.panel3.TabIndex = 4;
            // 
            // savePathButton
            // 
            this.savePathButton.Location = new System.Drawing.Point(605, 17);
            this.savePathButton.Name = "savePathButton";
            this.savePathButton.Size = new System.Drawing.Size(30, 20);
            this.savePathButton.TabIndex = 5;
            this.savePathButton.Text = "...";
            this.savePathButton.UseVisualStyleBackColor = true;
            this.savePathButton.Click += new System.EventHandler(this.savePathButton_Click);
            // 
            // savePathTextBox
            // 
            this.savePathTextBox.Location = new System.Drawing.Point(8, 18);
            this.savePathTextBox.Name = "savePathTextBox";
            this.savePathTextBox.Size = new System.Drawing.Size(591, 20);
            this.savePathTextBox.TabIndex = 4;
            this.savePathTextBox.Text = "c:\\tmp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Путь для сохранения";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.excludeDirsListBox);
            this.panel7.Controls.Add(this.excludeAddButton);
            this.panel7.Controls.Add(this.excludeDelButton);
            this.panel7.Location = new System.Drawing.Point(333, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(315, 137);
            this.panel7.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(74, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(184, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Исключаемые папки при удалении";
            // 
            // excludeDirsListBox
            // 
            this.excludeDirsListBox.FormattingEnabled = true;
            this.excludeDirsListBox.Items.AddRange(new object[] {
            "C:\\Windows",
            "C:\\Program Files",
            "C:\\Program Files (x86)",
            "C:\\ProgramData"});
            this.excludeDirsListBox.Location = new System.Drawing.Point(8, 20);
            this.excludeDirsListBox.Name = "excludeDirsListBox";
            this.excludeDirsListBox.Size = new System.Drawing.Size(208, 108);
            this.excludeDirsListBox.TabIndex = 2;
            // 
            // excludeAddButton
            // 
            this.excludeAddButton.Location = new System.Drawing.Point(222, 20);
            this.excludeAddButton.Name = "excludeAddButton";
            this.excludeAddButton.Size = new System.Drawing.Size(86, 42);
            this.excludeAddButton.TabIndex = 1;
            this.excludeAddButton.Text = "Добавить путь";
            this.excludeAddButton.UseVisualStyleBackColor = true;
            this.excludeAddButton.Click += new System.EventHandler(this.excludeAddButton_Click);
            // 
            // excludeDelButton
            // 
            this.excludeDelButton.Location = new System.Drawing.Point(223, 73);
            this.excludeDelButton.Name = "excludeDelButton";
            this.excludeDelButton.Size = new System.Drawing.Size(85, 42);
            this.excludeDelButton.TabIndex = 1;
            this.excludeDelButton.Text = "Удалить путь";
            this.excludeDelButton.UseVisualStyleBackColor = true;
            this.excludeDelButton.Click += new System.EventHandler(this.excludeDelButton_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.scanedDirsListBox);
            this.panel2.Controls.Add(this.addButton);
            this.panel2.Controls.Add(this.delButton);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 137);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Сканируемые папки";
            // 
            // scanedDirsListBox
            // 
            this.scanedDirsListBox.FormattingEnabled = true;
            this.scanedDirsListBox.Location = new System.Drawing.Point(8, 20);
            this.scanedDirsListBox.Name = "scanedDirsListBox";
            this.scanedDirsListBox.Size = new System.Drawing.Size(219, 108);
            this.scanedDirsListBox.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(233, 20);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(86, 42);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Добавить путь";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(233, 73);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(85, 42);
            this.delButton.TabIndex = 1;
            this.delButton.Text = "Удалить путь";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // InterfaceUpdater
            // 
            this.InterfaceUpdater.WorkerSupportsCancellation = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 506);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(667, 545);
            this.Name = "MainForm";
            this.Text = "Простой резерватор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ListBox scanedDirsListBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button savePathButton;
        private System.Windows.Forms.TextBox savePathTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox copyTypeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.CheckBox deleteCheckBox;
        private System.Windows.Forms.CheckBox autoRenameCheckBox;
        private System.Windows.Forms.TextBox currentFileTextBox;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox dirsWorkedTextBox;
        private System.Windows.Forms.TextBox filesWorkedTextBox;
        private System.Windows.Forms.TextBox filesFindedTextBox;
        private System.Windows.Forms.TextBox dirsFindedTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox currentDirTextBox;
        private System.ComponentModel.BackgroundWorker InterfaceUpdater;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox excludeDirsListBox;
        private System.Windows.Forms.Button excludeAddButton;
        private System.Windows.Forms.Button excludeDelButton;
        private System.Windows.Forms.CheckBox deleteEmptyDirCheckBox;
    }
}

