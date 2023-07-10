using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YouTubeDownloader.Library;

namespace YouTubeDownloader.Winforms
{
    public partial class MainForm : Form
    {
        private int _mouseinX, _mouseinY, _mouseX, _mouseY;
        private bool _mouseDown = false;
        public MainForm()
        {
            InitializeComponent();

            var outputFolder = Properties.Settings.Default.OutputFolder;
            if (!string.IsNullOrEmpty(outputFolder))
            {
                outputTextBox.Text = outputFolder;
            }
        }

        private async void downloadButton_Click(object sender, EventArgs e)
        {
            urlTextBox.Text = urlTextBox.Text.Trim();
            outputTextBox.Text = outputTextBox.Text.Trim();

            if (!Directory.Exists(outputTextBox.Text))
            {
                statusLabel.Text = "Please enter a valid output folder.";
            }

            statusLabel.ResetText();

            IDownloader downloader = new YtDlpDownloader();

            VideoDownloadOptions options = new()
            {
                URL = urlTextBox.Text,
                OutputFolder = outputTextBox.Text,
                FileType = mp3Button.Checked ? FileType.MP3 : FileType.MP4
            };

            var response = await downloader.Download(options);

            string status = "";

            switch (response)
            {
                case DownloadResponse.Success:
                    status = "File downloaded successfully.";
                    break;
                case DownloadResponse.InvalidUrl:
                    status = "Invalid URL.";
                    break;
                case DownloadResponse.Error:
                    status = "An error occurred.";
                    break;
                default:
                    break;
            }

            statusLabel.Text = status;

            Properties.Settings.Default.OutputFolder = outputTextBox.Text;
            Properties.Settings.Default.Save();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            outputTextBox.Text = folderBrowserDialog.SelectedPath;
        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _mouseinX = MousePosition.X - Bounds.X;
            _mouseinY = MousePosition.Y - Bounds.Y;
        }

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                _mouseX = MousePosition.X - _mouseinX;
                _mouseY = MousePosition.Y - _mouseinY;

                this.SetDesktopLocation(_mouseX, _mouseY);
            }
        }

        private void TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
        }
    }
}
