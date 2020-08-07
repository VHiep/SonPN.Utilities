namespace UI
{
    partial class Main
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
            this.btn_browseExcelFile = new System.Windows.Forms.Button();
            this.openFileDialogExcel = new System.Windows.Forms.OpenFileDialog();
            this.richTextBoxExcelFile = new System.Windows.Forms.RichTextBox();
            this.lbl_excelFile = new System.Windows.Forms.Label();
            this.label_excelPath = new System.Windows.Forms.Label();
            this.btn_process = new System.Windows.Forms.Button();
            this.lbl_localFolder = new System.Windows.Forms.Label();
            this.richTextBoxLocalFolder = new System.Windows.Forms.RichTextBox();
            this.btn_browseLocalFolder = new System.Windows.Forms.Button();
            this.numericUpDownUrlIndex = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownImageNameIndex = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxThread = new System.Windows.Forms.NumericUpDown();
            this.lbl_uriIndex = new System.Windows.Forms.Label();
            this.lbl_imageNameIndex = new System.Windows.Forms.Label();
            this.lbl_maxThread = new System.Windows.Forms.Label();
            this.folderBrowserDialogLocalFolder = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUrlIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImageNameIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxThread)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_browseExcelFile
            // 
            this.btn_browseExcelFile.Location = new System.Drawing.Point(713, 35);
            this.btn_browseExcelFile.Name = "btn_browseExcelFile";
            this.btn_browseExcelFile.Size = new System.Drawing.Size(75, 23);
            this.btn_browseExcelFile.TabIndex = 0;
            this.btn_browseExcelFile.Text = "Browse File";
            this.btn_browseExcelFile.UseVisualStyleBackColor = true;
            this.btn_browseExcelFile.Click += new System.EventHandler(this.btn_browseExcelFile_Click);
            // 
            // openFileDialogExcel
            // 
            this.openFileDialogExcel.FileName = "openFileDialogExcel";
            // 
            // richTextBoxExcelFile
            // 
            this.richTextBoxExcelFile.Location = new System.Drawing.Point(169, 37);
            this.richTextBoxExcelFile.Name = "richTextBoxExcelFile";
            this.richTextBoxExcelFile.Size = new System.Drawing.Size(517, 23);
            this.richTextBoxExcelFile.TabIndex = 1;
            this.richTextBoxExcelFile.Text = "";
            // 
            // lbl_excelFile
            // 
            this.lbl_excelFile.Location = new System.Drawing.Point(0, 0);
            this.lbl_excelFile.Name = "lbl_excelFile";
            this.lbl_excelFile.Size = new System.Drawing.Size(100, 23);
            this.lbl_excelFile.TabIndex = 0;
            // 
            // label_excelPath
            // 
            this.label_excelPath.AutoSize = true;
            this.label_excelPath.Location = new System.Drawing.Point(65, 40);
            this.label_excelPath.Name = "label_excelPath";
            this.label_excelPath.Size = new System.Drawing.Size(52, 13);
            this.label_excelPath.TabIndex = 2;
            this.label_excelPath.Text = "Excel File";
            // 
            // btn_process
            // 
            this.btn_process.Location = new System.Drawing.Point(330, 266);
            this.btn_process.Name = "btn_process";
            this.btn_process.Size = new System.Drawing.Size(172, 70);
            this.btn_process.TabIndex = 3;
            this.btn_process.Text = "Process";
            this.btn_process.UseVisualStyleBackColor = true;
            this.btn_process.Click += new System.EventHandler(this.btn_process_Click);
            // 
            // lbl_localFolder
            // 
            this.lbl_localFolder.AutoSize = true;
            this.lbl_localFolder.Location = new System.Drawing.Point(65, 85);
            this.lbl_localFolder.Name = "lbl_localFolder";
            this.lbl_localFolder.Size = new System.Drawing.Size(65, 13);
            this.lbl_localFolder.TabIndex = 4;
            this.lbl_localFolder.Text = "Local Folder";
            // 
            // richTextBoxLocalFolder
            // 
            this.richTextBoxLocalFolder.Location = new System.Drawing.Point(169, 82);
            this.richTextBoxLocalFolder.Name = "richTextBoxLocalFolder";
            this.richTextBoxLocalFolder.Size = new System.Drawing.Size(517, 23);
            this.richTextBoxLocalFolder.TabIndex = 5;
            this.richTextBoxLocalFolder.Text = "";
            // 
            // btn_browseLocalFolder
            // 
            this.btn_browseLocalFolder.Location = new System.Drawing.Point(713, 80);
            this.btn_browseLocalFolder.Name = "btn_browseLocalFolder";
            this.btn_browseLocalFolder.Size = new System.Drawing.Size(75, 23);
            this.btn_browseLocalFolder.TabIndex = 6;
            this.btn_browseLocalFolder.Text = "Browse Folder";
            this.btn_browseLocalFolder.UseVisualStyleBackColor = true;
            this.btn_browseLocalFolder.Click += new System.EventHandler(this.btn_browseLocalFolder_Click);
            // 
            // numericUpDownUrlIndex
            // 
            this.numericUpDownUrlIndex.Location = new System.Drawing.Point(169, 125);
            this.numericUpDownUrlIndex.Name = "numericUpDownUrlIndex";
            this.numericUpDownUrlIndex.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownUrlIndex.TabIndex = 7;
            // 
            // numericUpDownImageNameIndex
            // 
            this.numericUpDownImageNameIndex.Location = new System.Drawing.Point(169, 152);
            this.numericUpDownImageNameIndex.Name = "numericUpDownImageNameIndex";
            this.numericUpDownImageNameIndex.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownImageNameIndex.TabIndex = 8;
            // 
            // numericUpDownMaxThread
            // 
            this.numericUpDownMaxThread.Location = new System.Drawing.Point(169, 179);
            this.numericUpDownMaxThread.Name = "numericUpDownMaxThread";
            this.numericUpDownMaxThread.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMaxThread.TabIndex = 9;
            // 
            // lbl_uriIndex
            // 
            this.lbl_uriIndex.AutoSize = true;
            this.lbl_uriIndex.Location = new System.Drawing.Point(65, 132);
            this.lbl_uriIndex.Name = "lbl_uriIndex";
            this.lbl_uriIndex.Size = new System.Drawing.Size(49, 13);
            this.lbl_uriIndex.TabIndex = 10;
            this.lbl_uriIndex.Text = "Uri Index";
            // 
            // lbl_imageNameIndex
            // 
            this.lbl_imageNameIndex.AutoSize = true;
            this.lbl_imageNameIndex.Location = new System.Drawing.Point(65, 159);
            this.lbl_imageNameIndex.Name = "lbl_imageNameIndex";
            this.lbl_imageNameIndex.Size = new System.Drawing.Size(64, 13);
            this.lbl_imageNameIndex.TabIndex = 11;
            this.lbl_imageNameIndex.Text = "Name Index";
            // 
            // lbl_maxThread
            // 
            this.lbl_maxThread.AutoSize = true;
            this.lbl_maxThread.Location = new System.Drawing.Point(65, 186);
            this.lbl_maxThread.Name = "lbl_maxThread";
            this.lbl_maxThread.Size = new System.Drawing.Size(64, 13);
            this.lbl_maxThread.TabIndex = 12;
            this.lbl_maxThread.Text = "Max Thread";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 411);
            this.Controls.Add(this.lbl_maxThread);
            this.Controls.Add(this.lbl_imageNameIndex);
            this.Controls.Add(this.lbl_uriIndex);
            this.Controls.Add(this.numericUpDownMaxThread);
            this.Controls.Add(this.numericUpDownImageNameIndex);
            this.Controls.Add(this.numericUpDownUrlIndex);
            this.Controls.Add(this.btn_browseLocalFolder);
            this.Controls.Add(this.richTextBoxLocalFolder);
            this.Controls.Add(this.lbl_localFolder);
            this.Controls.Add(this.btn_process);
            this.Controls.Add(this.label_excelPath);
            this.Controls.Add(this.richTextBoxExcelFile);
            this.Controls.Add(this.btn_browseExcelFile);
            this.Name = "Main";
            this.Text = "Downloader";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUrlIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImageNameIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxThread)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_browseExcelFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogExcel;
        private System.Windows.Forms.RichTextBox richTextBoxExcelFile;
        private System.Windows.Forms.Label lbl_excelFile;
        private System.Windows.Forms.Label label_excelPath;
        private System.Windows.Forms.Button btn_process;
        private System.Windows.Forms.Label lbl_localFolder;
        private System.Windows.Forms.RichTextBox richTextBoxLocalFolder;
        private System.Windows.Forms.Button btn_browseLocalFolder;
        private System.Windows.Forms.NumericUpDown numericUpDownUrlIndex;
        private System.Windows.Forms.NumericUpDown numericUpDownImageNameIndex;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxThread;
        private System.Windows.Forms.Label lbl_uriIndex;
        private System.Windows.Forms.Label lbl_imageNameIndex;
        private System.Windows.Forms.Label lbl_maxThread;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogLocalFolder;
    }
}

