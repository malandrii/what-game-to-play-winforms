﻿namespace WhatGameToPlay
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listBoxAvailableGames = new System.Windows.Forms.ListBox();
            this.labelPresentPeople = new System.Windows.Forms.Label();
            this.labelAvailableGames = new System.Windows.Forms.Label();
            this.buttonRandomAvailableGame = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.textBox = new System.Windows.Forms.TextBox();
            this.pictureBoxSmile = new System.Windows.Forms.PictureBox();
            this.pictureBoxFireworks = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMessagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showConfirmationMessagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeIntoAccountPeopleNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rouletteInsteadProgressbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CelebrateRandomGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveDeletedGamesDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telegramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.youtubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSmile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFireworks)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxAvailableGames
            // 
            this.listBoxAvailableGames.FormattingEnabled = true;
            this.listBoxAvailableGames.Location = new System.Drawing.Point(206, 71);
            this.listBoxAvailableGames.Name = "listBoxAvailableGames";
            this.listBoxAvailableGames.Size = new System.Drawing.Size(301, 225);
            this.listBoxAvailableGames.TabIndex = 6;
            this.listBoxAvailableGames.DoubleClick += new System.EventHandler(this.ListBoxAvailableGames_DoubleClick);
            // 
            // labelPresentPeople
            // 
            this.labelPresentPeople.AutoSize = true;
            this.labelPresentPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPresentPeople.Location = new System.Drawing.Point(12, 35);
            this.labelPresentPeople.Name = "labelPresentPeople";
            this.labelPresentPeople.Size = new System.Drawing.Size(160, 24);
            this.labelPresentPeople.TabIndex = 10;
            this.labelPresentPeople.Text = "Present players:";
            // 
            // labelAvailableGames
            // 
            this.labelAvailableGames.AutoSize = true;
            this.labelAvailableGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvailableGames.Location = new System.Drawing.Point(275, 35);
            this.labelAvailableGames.Name = "labelAvailableGames";
            this.labelAvailableGames.Size = new System.Drawing.Size(169, 24);
            this.labelAvailableGames.TabIndex = 11;
            this.labelAvailableGames.Text = "Available games:";
            // 
            // buttonRandomAvailableGame
            // 
            this.buttonRandomAvailableGame.Location = new System.Drawing.Point(166, 335);
            this.buttonRandomAvailableGame.Name = "buttonRandomAvailableGame";
            this.buttonRandomAvailableGame.Size = new System.Drawing.Size(168, 28);
            this.buttonRandomAvailableGame.TabIndex = 12;
            this.buttonRandomAvailableGame.Text = "Random available game";
            this.buttonRandomAvailableGame.UseVisualStyleBackColor = true;
            this.buttonRandomAvailableGame.Click += new System.EventHandler(this.ButtonRandomAvailableGame_Click);
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(166, 369);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(168, 20);
            this.textBox.TabIndex = 13;
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBoxSmile
            // 
            this.pictureBoxSmile.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSmile.Image")));
            this.pictureBoxSmile.Location = new System.Drawing.Point(232, 233);
            this.pictureBoxSmile.Name = "pictureBoxSmile";
            this.pictureBoxSmile.Size = new System.Drawing.Size(298, 185);
            this.pictureBoxSmile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSmile.TabIndex = 14;
            this.pictureBoxSmile.TabStop = false;
            this.pictureBoxSmile.Visible = false;
            // 
            // pictureBoxFireworks
            // 
            this.pictureBoxFireworks.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFireworks.Image")));
            this.pictureBoxFireworks.Location = new System.Drawing.Point(0, 233);
            this.pictureBoxFireworks.Name = "pictureBoxFireworks";
            this.pictureBoxFireworks.Size = new System.Drawing.Size(317, 185);
            this.pictureBoxFireworks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFireworks.TabIndex = 15;
            this.pictureBoxFireworks.TabStop = false;
            this.pictureBoxFireworks.Visible = false;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.themeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(530, 24);
            this.menuStrip.TabIndex = 16;
            this.menuStrip.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerListToolStripMenuItem,
            this.gameListToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // playerListToolStripMenuItem
            // 
            this.playerListToolStripMenuItem.Name = "playerListToolStripMenuItem";
            this.playerListToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.playerListToolStripMenuItem.Text = "Player List";
            this.playerListToolStripMenuItem.Click += new System.EventHandler(this.PeopleListToolStripMenuItem_Click);
            // 
            // gameListToolStripMenuItem
            // 
            this.gameListToolStripMenuItem.Name = "gameListToolStripMenuItem";
            this.gameListToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.gameListToolStripMenuItem.Text = "Games List";
            this.gameListToolStripMenuItem.Click += new System.EventHandler(this.GamesListToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showMessagesToolStripMenuItem,
            this.showConfirmationMessagesToolStripMenuItem,
            this.takeIntoAccountPeopleNumberToolStripMenuItem,
            this.rouletteInsteadProgressbarToolStripMenuItem,
            this.CelebrateRandomGameToolStripMenuItem,
            this.SaveDeletedGamesDataToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // showMessagesToolStripMenuItem
            // 
            this.showMessagesToolStripMenuItem.Checked = true;
            this.showMessagesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showMessagesToolStripMenuItem.Name = "showMessagesToolStripMenuItem";
            this.showMessagesToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.showMessagesToolStripMenuItem.Text = "Show messages";
            this.showMessagesToolStripMenuItem.Click += new System.EventHandler(this.ShowMessagesToolStripMenuItem_Click);
            // 
            // showConfirmationMessagesToolStripMenuItem
            // 
            this.showConfirmationMessagesToolStripMenuItem.Checked = true;
            this.showConfirmationMessagesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showConfirmationMessagesToolStripMenuItem.Name = "showConfirmationMessagesToolStripMenuItem";
            this.showConfirmationMessagesToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.showConfirmationMessagesToolStripMenuItem.Text = "Show confirmation messages";
            this.showConfirmationMessagesToolStripMenuItem.Click += new System.EventHandler(this.ShowConfirmationMessagesToolStripMenuItem_Click);
            // 
            // takeIntoAccountPeopleNumberToolStripMenuItem
            // 
            this.takeIntoAccountPeopleNumberToolStripMenuItem.Checked = true;
            this.takeIntoAccountPeopleNumberToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.takeIntoAccountPeopleNumberToolStripMenuItem.Name = "takeIntoAccountPeopleNumberToolStripMenuItem";
            this.takeIntoAccountPeopleNumberToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.takeIntoAccountPeopleNumberToolStripMenuItem.Text = "Take into account number of people";
            this.takeIntoAccountPeopleNumberToolStripMenuItem.Click += new System.EventHandler(this.TakeIntoAccountPeopleNumberToolStripMenuItem_Click);
            // 
            // rouletteInsteadProgressbarToolStripMenuItem
            // 
            this.rouletteInsteadProgressbarToolStripMenuItem.Name = "rouletteInsteadProgressbarToolStripMenuItem";
            this.rouletteInsteadProgressbarToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.rouletteInsteadProgressbarToolStripMenuItem.Text = "Use progressbar instead of roulette";
            this.rouletteInsteadProgressbarToolStripMenuItem.Click += new System.EventHandler(this.RouletteInsteadProgressbarToolStripMenuItem_Click);
            // 
            // CelebrateRandomGameToolStripMenuItem
            // 
            this.CelebrateRandomGameToolStripMenuItem.Name = "CelebrateRandomGameToolStripMenuItem";
            this.CelebrateRandomGameToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.CelebrateRandomGameToolStripMenuItem.Text = "Celebrate random game";
            this.CelebrateRandomGameToolStripMenuItem.Click += new System.EventHandler(this.CelebrateRandomGameToolStripMenuItem_Click);
            // 
            // SaveDeletedGamesDataToolStripMenuItem
            // 
            this.SaveDeletedGamesDataToolStripMenuItem.Name = "SaveDeletedGamesDataToolStripMenuItem";
            this.SaveDeletedGamesDataToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.SaveDeletedGamesDataToolStripMenuItem.Text = "Save deleted games data";
            this.SaveDeletedGamesDataToolStripMenuItem.Click += new System.EventHandler(this.SaveDeletedGamesDataToolStripMenuItem_Click);
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whiteToolStripMenuItem,
            this.darkToolStripMenuItem,
            this.telegramToolStripMenuItem,
            this.discordToolStripMenuItem,
            this.youtubeToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // whiteToolStripMenuItem
            // 
            this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            this.whiteToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.whiteToolStripMenuItem.Text = "White";
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.darkToolStripMenuItem.Text = "Dark";
            // 
            // telegramToolStripMenuItem
            // 
            this.telegramToolStripMenuItem.Name = "telegramToolStripMenuItem";
            this.telegramToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.telegramToolStripMenuItem.Text = "Telegram";
            // 
            // discordToolStripMenuItem
            // 
            this.discordToolStripMenuItem.Name = "discordToolStripMenuItem";
            this.discordToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.discordToolStripMenuItem.Text = "Discord";
            // 
            // youtubeToolStripMenuItem
            // 
            this.youtubeToolStripMenuItem.Name = "youtubeToolStripMenuItem";
            this.youtubeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.youtubeToolStripMenuItem.Text = "YouTube";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(166, 369);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(168, 20);
            this.progressBar.TabIndex = 17;
            this.progressBar.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(530, 419);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.buttonRandomAvailableGame);
            this.Controls.Add(this.labelAvailableGames);
            this.Controls.Add(this.labelPresentPeople);
            this.Controls.Add(this.listBoxAvailableGames);
            this.Controls.Add(this.pictureBoxSmile);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.pictureBoxFireworks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "What game to play?";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSmile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFireworks)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ListBox listBoxAvailableGames;
        private System.Windows.Forms.Label labelPresentPeople;
        private System.Windows.Forms.Label labelAvailableGames;
        private System.Windows.Forms.Button buttonRandomAvailableGame;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.PictureBox pictureBoxSmile;
        private System.Windows.Forms.PictureBox pictureBoxFireworks;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showConfirmationMessagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeIntoAccountPeopleNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameListToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ToolStripMenuItem rouletteInsteadProgressbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CelebrateRandomGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveDeletedGamesDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMessagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telegramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem youtubeToolStripMenuItem;
    }
}

