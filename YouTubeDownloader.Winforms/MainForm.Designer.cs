
namespace YouTubeDownloader.Winforms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.downloadButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.minimizeButton = new FontAwesome.Sharp.IconButton();
            this.closeButton = new FontAwesome.Sharp.IconButton();
            this.titleLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.statusLabel = new System.Windows.Forms.Label();
            this.fileTypePanel = new System.Windows.Forms.Panel();
            this.mp4Button = new System.Windows.Forms.RadioButton();
            this.mp3Button = new System.Windows.Forms.RadioButton();
            this.TitleBar.SuspendLayout();
            this.fileTypePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // urlTextBox
            // 
            this.urlTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.urlTextBox.Location = new System.Drawing.Point(139, 198);
            this.urlTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(405, 26);
            this.urlTextBox.TabIndex = 0;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputTextBox.Location = new System.Drawing.Point(139, 263);
            this.outputTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(405, 26);
            this.outputTextBox.TabIndex = 1;
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.urlLabel.Location = new System.Drawing.Point(139, 175);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(38, 19);
            this.urlLabel.TabIndex = 2;
            this.urlLabel.Text = "URL:";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputLabel.Location = new System.Drawing.Point(139, 240);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(95, 19);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.Text = "Output folder:";
            // 
            // downloadButton
            // 
            this.downloadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(67)))));
            this.downloadButton.FlatAppearance.BorderSize = 0;
            this.downloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadButton.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.downloadButton.Location = new System.Drawing.Point(260, 392);
            this.downloadButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(181, 47);
            this.downloadButton.TabIndex = 4;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = false;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // browseButton
            // 
            this.browseButton.BackColor = System.Drawing.Color.White;
            this.browseButton.FlatAppearance.BorderSize = 0;
            this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseButton.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.browseButton.ForeColor = System.Drawing.Color.Black;
            this.browseButton.Location = new System.Drawing.Point(550, 263);
            this.browseButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(113, 26);
            this.browseButton.TabIndex = 5;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.Red;
            this.TitleBar.Controls.Add(this.minimizeButton);
            this.TitleBar.Controls.Add(this.closeButton);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(800, 27);
            this.TitleBar.TabIndex = 6;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.TitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.minimizeButton.IconColor = System.Drawing.Color.White;
            this.minimizeButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.minimizeButton.IconSize = 25;
            this.minimizeButton.Location = new System.Drawing.Point(711, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(45, 30);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.closeButton.IconColor = System.Drawing.Color.White;
            this.closeButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.closeButton.IconSize = 25;
            this.closeButton.Location = new System.Drawing.Point(755, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Rotation = 90D;
            this.closeButton.Size = new System.Drawing.Size(45, 30);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(139, 74);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(405, 58);
            this.titleLabel.TabIndex = 7;
            this.titleLabel.Text = "YouTube Downloader";
            // 
            // statusLabel
            // 
            this.statusLabel.Location = new System.Drawing.Point(175, 459);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(345, 50);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fileTypePanel
            // 
            this.fileTypePanel.Controls.Add(this.mp4Button);
            this.fileTypePanel.Controls.Add(this.mp3Button);
            this.fileTypePanel.Location = new System.Drawing.Point(219, 311);
            this.fileTypePanel.Name = "fileTypePanel";
            this.fileTypePanel.Size = new System.Drawing.Size(259, 57);
            this.fileTypePanel.TabIndex = 9;
            // 
            // mp4Button
            // 
            this.mp4Button.Appearance = System.Windows.Forms.Appearance.Button;
            this.mp4Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(67)))));
            this.mp4Button.Checked = true;
            this.mp4Button.Dock = System.Windows.Forms.DockStyle.Right;
            this.mp4Button.FlatAppearance.BorderSize = 0;
            this.mp4Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mp4Button.Location = new System.Drawing.Point(144, 0);
            this.mp4Button.Name = "mp4Button";
            this.mp4Button.Size = new System.Drawing.Size(115, 57);
            this.mp4Button.TabIndex = 1;
            this.mp4Button.TabStop = true;
            this.mp4Button.Text = "MP4";
            this.mp4Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mp4Button.UseVisualStyleBackColor = false;
            // 
            // mp3Button
            // 
            this.mp3Button.Appearance = System.Windows.Forms.Appearance.Button;
            this.mp3Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(67)))));
            this.mp3Button.Dock = System.Windows.Forms.DockStyle.Left;
            this.mp3Button.FlatAppearance.BorderSize = 0;
            this.mp3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mp3Button.Location = new System.Drawing.Point(0, 0);
            this.mp3Button.Name = "mp3Button";
            this.mp3Button.Size = new System.Drawing.Size(115, 57);
            this.mp3Button.TabIndex = 0;
            this.mp3Button.TabStop = true;
            this.mp3Button.Text = "MP3";
            this.mp3Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mp3Button.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.fileTypePanel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.urlTextBox);
            this.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "YouTube Downloader";
            this.TitleBar.ResumeLayout(false);
            this.fileTypePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Label titleLabel;
        private FontAwesome.Sharp.IconButton closeButton;
        private FontAwesome.Sharp.IconButton minimizeButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Panel fileTypePanel;
        private System.Windows.Forms.RadioButton mp4Button;
        private System.Windows.Forms.RadioButton mp3Button;
    }
}

