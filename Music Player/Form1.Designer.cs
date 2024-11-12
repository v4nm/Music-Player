namespace Music_Player
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelPlaylist = new System.Windows.Forms.Panel();
            this.buttonExportPlaylist = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonMainPlaylist = new System.Windows.Forms.Button();
            this.panelMedia = new System.Windows.Forms.Panel();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonMusicDownload = new System.Windows.Forms.Button();
            this.buttonMainMedia = new System.Windows.Forms.Button();
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panelSideMenu.SuspendLayout();
            this.panelPlaylist.SuspendLayout();
            this.panelMedia.SuspendLayout();
            this.panelPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panelChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(30)))));
            this.panelSideMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelSideMenu.Controls.Add(this.panelPlaylist);
            this.panelSideMenu.Controls.Add(this.buttonMainPlaylist);
            this.panelSideMenu.Controls.Add(this.panelMedia);
            this.panelSideMenu.Controls.Add(this.buttonMainMedia);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(199, 395);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelPlaylist
            // 
            this.panelPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.panelPlaylist.Controls.Add(this.buttonExportPlaylist);
            this.panelPlaylist.Controls.Add(this.button6);
            this.panelPlaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPlaylist.Location = new System.Drawing.Point(0, 191);
            this.panelPlaylist.Name = "panelPlaylist";
            this.panelPlaylist.Size = new System.Drawing.Size(199, 101);
            this.panelPlaylist.TabIndex = 4;
            // 
            // buttonExportPlaylist
            // 
            this.buttonExportPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.buttonExportPlaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonExportPlaylist.FlatAppearance.BorderSize = 0;
            this.buttonExportPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExportPlaylist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.buttonExportPlaylist.Location = new System.Drawing.Point(0, 45);
            this.buttonExportPlaylist.Name = "buttonExportPlaylist";
            this.buttonExportPlaylist.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonExportPlaylist.Size = new System.Drawing.Size(199, 45);
            this.buttonExportPlaylist.TabIndex = 2;
            this.buttonExportPlaylist.Text = "Экспорт плейлиста";
            this.buttonExportPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExportPlaylist.UseVisualStyleBackColor = false;
            this.buttonExportPlaylist.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.button6.Location = new System.Drawing.Point(0, 0);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(199, 45);
            this.button6.TabIndex = 1;
            this.button6.Text = "Новый плейлист";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonMainPlaylist
            // 
            this.buttonMainPlaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMainPlaylist.FlatAppearance.BorderSize = 0;
            this.buttonMainPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMainPlaylist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.buttonMainPlaylist.Location = new System.Drawing.Point(0, 146);
            this.buttonMainPlaylist.Name = "buttonMainPlaylist";
            this.buttonMainPlaylist.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonMainPlaylist.Size = new System.Drawing.Size(199, 45);
            this.buttonMainPlaylist.TabIndex = 3;
            this.buttonMainPlaylist.Text = "Плейлист";
            this.buttonMainPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMainPlaylist.UseVisualStyleBackColor = true;
            this.buttonMainPlaylist.Click += new System.EventHandler(this.buttonMainPlaylist_Click);
            // 
            // panelMedia
            // 
            this.panelMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.panelMedia.Controls.Add(this.buttonOpenFile);
            this.panelMedia.Controls.Add(this.buttonMusicDownload);
            this.panelMedia.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMedia.Location = new System.Drawing.Point(0, 45);
            this.panelMedia.Name = "panelMedia";
            this.panelMedia.Size = new System.Drawing.Size(199, 101);
            this.panelMedia.TabIndex = 2;
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.buttonOpenFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOpenFile.FlatAppearance.BorderSize = 0;
            this.buttonOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.buttonOpenFile.Location = new System.Drawing.Point(0, 45);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonOpenFile.Size = new System.Drawing.Size(199, 45);
            this.buttonOpenFile.TabIndex = 2;
            this.buttonOpenFile.Text = "Открыть файл";
            this.buttonOpenFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOpenFile.UseVisualStyleBackColor = false;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonMusicDownload
            // 
            this.buttonMusicDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.buttonMusicDownload.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMusicDownload.FlatAppearance.BorderSize = 0;
            this.buttonMusicDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMusicDownload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.buttonMusicDownload.Location = new System.Drawing.Point(0, 0);
            this.buttonMusicDownload.Name = "buttonMusicDownload";
            this.buttonMusicDownload.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonMusicDownload.Size = new System.Drawing.Size(199, 45);
            this.buttonMusicDownload.TabIndex = 1;
            this.buttonMusicDownload.Text = "Загрузить музыку";
            this.buttonMusicDownload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMusicDownload.UseVisualStyleBackColor = false;
            this.buttonMusicDownload.Click += new System.EventHandler(this.buttonMusicDownload_Click);
            // 
            // buttonMainMedia
            // 
            this.buttonMainMedia.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMainMedia.FlatAppearance.BorderSize = 0;
            this.buttonMainMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMainMedia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.buttonMainMedia.Location = new System.Drawing.Point(0, 0);
            this.buttonMainMedia.Name = "buttonMainMedia";
            this.buttonMainMedia.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonMainMedia.Size = new System.Drawing.Size(199, 45);
            this.buttonMainMedia.TabIndex = 1;
            this.buttonMainMedia.Text = "Файл";
            this.buttonMainMedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMainMedia.UseVisualStyleBackColor = true;
            this.buttonMainMedia.Click += new System.EventHandler(this.buttonMainMedia_Click);
            // 
            // panelPlayer
            // 
            this.panelPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.panelPlayer.Controls.Add(this.button4);
            this.panelPlayer.Controls.Add(this.button3);
            this.panelPlayer.Controls.Add(this.button2);
            this.panelPlayer.Controls.Add(this.button1);
            this.panelPlayer.Controls.Add(this.trackBar2);
            this.panelPlayer.Controls.Add(this.trackBar1);
            this.panelPlayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPlayer.ForeColor = System.Drawing.Color.Transparent;
            this.panelPlayer.Location = new System.Drawing.Point(199, 293);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(540, 102);
            this.panelPlayer.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Music_Player.Properties.Resources.stop;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(249, 27);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 35);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Music_Player.Properties.Resources.play;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(210, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 35);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Music_Player.Properties.Resources.rewind;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(169, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 35);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Music_Player.Properties.Resources.forward__2_;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(290, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // trackBar2
            // 
            this.trackBar2.Dock = System.Windows.Forms.DockStyle.Right;
            this.trackBar2.Location = new System.Drawing.Point(495, 0);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(45, 102);
            this.trackBar2.TabIndex = 1;
            // 
            // trackBar1
            // 
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.Location = new System.Drawing.Point(63, 0);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(391, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(30)))));
            this.panelChildForm.Controls.Add(this.listBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(199, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(540, 293);
            this.panelChildForm.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(30)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(26, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(487, 234);
            this.listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(739, 395);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelPlayer);
            this.Controls.Add(this.panelSideMenu);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.panelSideMenu.ResumeLayout(false);
            this.panelPlaylist.ResumeLayout(false);
            this.panelMedia.ResumeLayout(false);
            this.panelPlayer.ResumeLayout(false);
            this.panelPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button buttonMainMedia;
        private System.Windows.Forms.Panel panelPlaylist;
        private System.Windows.Forms.Button buttonExportPlaylist;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonMainPlaylist;
        private System.Windows.Forms.Panel panelMedia;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonMusicDownload;
        private System.Windows.Forms.Panel panelPlayer;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

