﻿using NLog;
using System;
using System.Net.Http;
using System.Threading;
using System.Windows.Forms;
using SonPN.Utilities.Download;

namespace UI
{
    public partial class Main : Form
    {
        private readonly Logger _logger = LogManager.GetCurrentClassLogger();
        public Main()
        {
            InitializeComponent();
        }

        private void btn_browseExcelFile_Click(object sender, EventArgs e)
        {
            _logger.Trace("Invoked.");
            openFileDialogExcel.ShowDialog();
            richTextBoxExcelFile.Text = openFileDialogExcel.FileName;

        }

        private void btn_process_Click(object sender, EventArgs e)
        {
            _logger.Trace("Invoked.");
            HttpClient client = new HttpClient();
            DownloadMain downloadMan = new DownloadMain(client);

            using (ManualResetEvent resetEvent = new ManualResetEvent(false))
            {
                string excelFile = richTextBoxExcelFile.Text;
                string localFolder = richTextBoxLocalFolder.Text;

                ThreadPool.QueueUserWorkItem(
                    item =>
                    {
                        downloadMan.Execute(excelFile, localFolder, 1, 2, 8);
                        resetEvent.Set();
                    });

                btn_process.Text = "Vui lòng chờ.";
                btn_process.Enabled = false;

                resetEvent.WaitOne();
                btn_process.Text = "Tải ảnh";
                btn_process.Enabled = true;
            }

        }

        private void btn_browseLocalFolder_Click(object sender, EventArgs e)
        {
            _logger.Trace("Invoked.");
            folderBrowserDialogLocalFolder.ShowDialog();
            richTextBoxLocalFolder.Text = folderBrowserDialogLocalFolder.SelectedPath;
        }
    }
}
