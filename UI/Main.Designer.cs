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
            this.folderBrowserDialogLocalFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.label_attention = new System.Windows.Forms.Label();
            this.label_attention2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_browseExcelFile
            // 
            this.btn_browseExcelFile.Location = new System.Drawing.Point(713, 35);
            this.btn_browseExcelFile.Name = "btn_browseExcelFile";
            this.btn_browseExcelFile.Size = new System.Drawing.Size(75, 23);
            this.btn_browseExcelFile.TabIndex = 0;
            this.btn_browseExcelFile.Text = "Tìm kiếm file";
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
            this.label_excelPath.Text = "File excel";
            // 
            // btn_process
            // 
            this.btn_process.Location = new System.Drawing.Point(330, 266);
            this.btn_process.Name = "btn_process";
            this.btn_process.Size = new System.Drawing.Size(172, 70);
            this.btn_process.TabIndex = 3;
            this.btn_process.Text = "Tải ảnh";
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
            this.lbl_localFolder.Text = "Thư mục lưu trữ";
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
            this.btn_browseLocalFolder.Text = "Tìm kiếm folder";
            this.btn_browseLocalFolder.UseVisualStyleBackColor = true;
            this.btn_browseLocalFolder.Click += new System.EventHandler(this.btn_browseLocalFolder_Click);
            // 
            // label_attention
            // 
            this.label_attention.AutoSize = true;
            this.label_attention.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_attention.ForeColor = System.Drawing.Color.Crimson;
            this.label_attention.Location = new System.Drawing.Point(234, 127);
            this.label_attention.Name = "label_attention";
            this.label_attention.Size = new System.Drawing.Size(401, 25);
            this.label_attention.TabIndex = 7;
            this.label_attention.Text = "Đường dẫn đến ảnh ở cột 1 trong file EXCEL.";
            // 
            // label_attention2
            // 
            this.label_attention2.AutoSize = true;
            this.label_attention2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_attention2.ForeColor = System.Drawing.Color.Crimson;
            this.label_attention2.Location = new System.Drawing.Point(234, 175);
            this.label_attention2.Name = "label_attention2";
            this.label_attention2.Size = new System.Drawing.Size(384, 25);
            this.label_attention2.TabIndex = 8;
            this.label_attention2.Text = "Tên ảnh để lưu lại ở cột 2 trong file EXCEL.";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 411);
            this.Controls.Add(this.label_attention2);
            this.Controls.Add(this.label_attention);
            this.Controls.Add(this.btn_browseLocalFolder);
            this.Controls.Add(this.richTextBoxLocalFolder);
            this.Controls.Add(this.lbl_localFolder);
            this.Controls.Add(this.btn_process);
            this.Controls.Add(this.label_excelPath);
            this.Controls.Add(this.richTextBoxExcelFile);
            this.Controls.Add(this.btn_browseExcelFile);
            this.Name = "Main";
            this.Text = "Downloader";
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
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogLocalFolder;
        private System.Windows.Forms.Label label_attention;
        private System.Windows.Forms.Label label_attention2;
    }
}

