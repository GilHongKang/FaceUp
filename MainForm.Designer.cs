namespace FaceUp
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose ( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.captureArea = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shotAndSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playPauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.btnShot = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStrip__PeopleAmount = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip__CorrectionSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip__CorrectionX = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip__CorrectionY = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabCtrlMasks = new System.Windows.Forms.TabControl();
            this.tabMasks__Hair = new System.Windows.Forms.TabPage();
            this.listViewHair = new System.Windows.Forms.ListView();
            this.imageListHair = new System.Windows.Forms.ImageList(this.components);
            this.tabMasks__Eye = new System.Windows.Forms.TabPage();
            this.listViewEye = new System.Windows.Forms.ListView();
            this.imageListEye = new System.Windows.Forms.ImageList(this.components);
            this.tabMasks__Chin = new System.Windows.Forms.TabPage();
            this.listViewChin = new System.Windows.Forms.ListView();
            this.imageListChin = new System.Windows.Forms.ImageList(this.components);
            this.groupBoxCorrection = new System.Windows.Forms.GroupBox();
            this.trackBarCorrectionSize = new System.Windows.Forms.TrackBar();
            this.lblCorrectionSize = new System.Windows.Forms.Label();
            this.lblCorrectionY = new System.Windows.Forms.Label();
            this.trackBarCorrectionY = new System.Windows.Forms.TrackBar();
            this.trackBarCorrectionX = new System.Windows.Forms.TrackBar();
            this.lblCorrectionX = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.captureArea)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tabCtrlMasks.SuspendLayout();
            this.tabMasks__Hair.SuspendLayout();
            this.tabMasks__Eye.SuspendLayout();
            this.tabMasks__Chin.SuspendLayout();
            this.groupBoxCorrection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCorrectionSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCorrectionY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCorrectionX)).BeginInit();
            this.SuspendLayout();
            // 
            // captureArea
            // 
            this.captureArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.captureArea.BackColor = System.Drawing.Color.Gainsboro;
            this.captureArea.Location = new System.Drawing.Point(13, 27);
            this.captureArea.Name = "captureArea";
            this.captureArea.Size = new System.Drawing.Size(839, 581);
            this.captureArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.captureArea.TabIndex = 0;
            this.captureArea.TabStop = false;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managementToolStripMenuItem,
            this.serviceToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1079, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.shotToolStripMenuItem,
            this.shotAndSaveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.managementToolStripMenuItem.Text = "Управление";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.openToolStripMenuItem.Text = "Открыть...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // shotToolStripMenuItem
            // 
            this.shotToolStripMenuItem.Name = "shotToolStripMenuItem";
            this.shotToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.shotToolStripMenuItem.Text = "Сделать снимок";
            // 
            // shotAndSaveToolStripMenuItem
            // 
            this.shotAndSaveToolStripMenuItem.Name = "shotAndSaveToolStripMenuItem";
            this.shotAndSaveToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.shotAndSaveToolStripMenuItem.Text = "Сделать снимок и сохранить как...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(259, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.exitToolStripMenuItem.Text = "Выйти";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playPauseToolStripMenuItem,
            this.toolStripSeparator2,
            this.settingsToolStripMenuItem1,
            this.infoToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.serviceToolStripMenuItem.Text = "Сервис";
            // 
            // playPauseToolStripMenuItem
            // 
            this.playPauseToolStripMenuItem.Name = "playPauseToolStripMenuItem";
            this.playPauseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.playPauseToolStripMenuItem.Text = "Пауза";
            this.playPauseToolStripMenuItem.Click += new System.EventHandler(this.playPauseToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem1.Text = "Настройки";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.infoToolStripMenuItem.Text = "Справка";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlayPause.Location = new System.Drawing.Point(976, 27);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(91, 34);
            this.btnPlayPause.TabIndex = 2;
            this.btnPlayPause.Text = "Пауза";
            this.btnPlayPause.UseVisualStyleBackColor = true;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // btnShot
            // 
            this.btnShot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShot.Location = new System.Drawing.Point(858, 27);
            this.btnShot.Name = "btnShot";
            this.btnShot.Size = new System.Drawing.Size(112, 34);
            this.btnShot.TabIndex = 3;
            this.btnShot.Text = "Сделать снимок";
            this.btnShot.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStrip__PeopleAmount,
            this.statusStrip__CorrectionSize,
            this.statusStrip__CorrectionX,
            this.statusStrip__CorrectionY});
            this.statusStrip.Location = new System.Drawing.Point(0, 633);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1079, 22);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusStrip__PeopleAmount
            // 
            this.statusStrip__PeopleAmount.Name = "statusStrip__PeopleAmount";
            this.statusStrip__PeopleAmount.Size = new System.Drawing.Size(116, 17);
            this.statusStrip__PeopleAmount.Text = "Людей на снимке: 0";
            // 
            // statusStrip__CorrectionSize
            // 
            this.statusStrip__CorrectionSize.Name = "statusStrip__CorrectionSize";
            this.statusStrip__CorrectionSize.Size = new System.Drawing.Size(81, 17);
            this.statusStrip__CorrectionSize.Text = "Размер: 100%";
            // 
            // statusStrip__CorrectionX
            // 
            this.statusStrip__CorrectionX.Name = "statusStrip__CorrectionX";
            this.statusStrip__CorrectionX.Size = new System.Drawing.Size(153, 17);
            this.statusStrip__CorrectionX.Text = "Корректировка по оси X: 0";
            // 
            // statusStrip__CorrectionY
            // 
            this.statusStrip__CorrectionY.Name = "statusStrip__CorrectionY";
            this.statusStrip__CorrectionY.Size = new System.Drawing.Size(153, 17);
            this.statusStrip__CorrectionY.Text = "Корректировка по оси Y: 0";
            // 
            // tabCtrlMasks
            // 
            this.tabCtrlMasks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCtrlMasks.Controls.Add(this.tabMasks__Hair);
            this.tabCtrlMasks.Controls.Add(this.tabMasks__Eye);
            this.tabCtrlMasks.Controls.Add(this.tabMasks__Chin);
            this.tabCtrlMasks.Location = new System.Drawing.Point(858, 67);
            this.tabCtrlMasks.Name = "tabCtrlMasks";
            this.tabCtrlMasks.SelectedIndex = 0;
            this.tabCtrlMasks.Size = new System.Drawing.Size(209, 271);
            this.tabCtrlMasks.TabIndex = 7;
            // 
            // tabMasks__Hair
            // 
            this.tabMasks__Hair.AutoScroll = true;
            this.tabMasks__Hair.Controls.Add(this.listViewHair);
            this.tabMasks__Hair.Location = new System.Drawing.Point(4, 22);
            this.tabMasks__Hair.Name = "tabMasks__Hair";
            this.tabMasks__Hair.Padding = new System.Windows.Forms.Padding(3);
            this.tabMasks__Hair.Size = new System.Drawing.Size(201, 245);
            this.tabMasks__Hair.TabIndex = 0;
            this.tabMasks__Hair.Text = "Волосы";
            this.tabMasks__Hair.UseVisualStyleBackColor = true;
            // 
            // listViewHair
            // 
            this.listViewHair.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewHair.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewHair.LargeImageList = this.imageListHair;
            this.listViewHair.Location = new System.Drawing.Point(7, 7);
            this.listViewHair.Name = "listViewHair";
            this.listViewHair.Size = new System.Drawing.Size(188, 232);
            this.listViewHair.TabIndex = 0;
            this.listViewHair.UseCompatibleStateImageBehavior = false;
            this.listViewHair.SelectedIndexChanged += new System.EventHandler(this.listViewHair_SelectedIndexChanged);
            // 
            // imageListHair
            // 
            this.imageListHair.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListHair.ImageSize = new System.Drawing.Size(120, 120);
            this.imageListHair.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabMasks__Eye
            // 
            this.tabMasks__Eye.AutoScroll = true;
            this.tabMasks__Eye.Controls.Add(this.listViewEye);
            this.tabMasks__Eye.Location = new System.Drawing.Point(4, 22);
            this.tabMasks__Eye.Name = "tabMasks__Eye";
            this.tabMasks__Eye.Padding = new System.Windows.Forms.Padding(3);
            this.tabMasks__Eye.Size = new System.Drawing.Size(201, 245);
            this.tabMasks__Eye.TabIndex = 1;
            this.tabMasks__Eye.Text = "Глаза";
            this.tabMasks__Eye.UseVisualStyleBackColor = true;
            // 
            // listViewEye
            // 
            this.listViewEye.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewEye.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewEye.LargeImageList = this.imageListEye;
            this.listViewEye.Location = new System.Drawing.Point(6, 6);
            this.listViewEye.Name = "listViewEye";
            this.listViewEye.Size = new System.Drawing.Size(188, 233);
            this.listViewEye.TabIndex = 1;
            this.listViewEye.UseCompatibleStateImageBehavior = false;
            this.listViewEye.SelectedIndexChanged += new System.EventHandler(this.listViewEye_SelectedIndexChanged);
            // 
            // imageListEye
            // 
            this.imageListEye.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListEye.ImageSize = new System.Drawing.Size(120, 120);
            this.imageListEye.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabMasks__Chin
            // 
            this.tabMasks__Chin.AutoScroll = true;
            this.tabMasks__Chin.Controls.Add(this.listViewChin);
            this.tabMasks__Chin.Location = new System.Drawing.Point(4, 22);
            this.tabMasks__Chin.Name = "tabMasks__Chin";
            this.tabMasks__Chin.Size = new System.Drawing.Size(201, 245);
            this.tabMasks__Chin.TabIndex = 2;
            this.tabMasks__Chin.Text = "Подбородок";
            this.tabMasks__Chin.UseVisualStyleBackColor = true;
            // 
            // listViewChin
            // 
            this.listViewChin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewChin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewChin.LargeImageList = this.imageListChin;
            this.listViewChin.Location = new System.Drawing.Point(6, 6);
            this.listViewChin.Name = "listViewChin";
            this.listViewChin.Size = new System.Drawing.Size(188, 232);
            this.listViewChin.TabIndex = 2;
            this.listViewChin.UseCompatibleStateImageBehavior = false;
            this.listViewChin.SelectedIndexChanged += new System.EventHandler(this.listViewChin_SelectedIndexChanged);
            // 
            // imageListChin
            // 
            this.imageListChin.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListChin.ImageSize = new System.Drawing.Size(120, 120);
            this.imageListChin.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBoxCorrection
            // 
            this.groupBoxCorrection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCorrection.Controls.Add(this.trackBarCorrectionSize);
            this.groupBoxCorrection.Controls.Add(this.lblCorrectionSize);
            this.groupBoxCorrection.Controls.Add(this.lblCorrectionY);
            this.groupBoxCorrection.Controls.Add(this.trackBarCorrectionY);
            this.groupBoxCorrection.Controls.Add(this.trackBarCorrectionX);
            this.groupBoxCorrection.Controls.Add(this.lblCorrectionX);
            this.groupBoxCorrection.Location = new System.Drawing.Point(858, 344);
            this.groupBoxCorrection.Name = "groupBoxCorrection";
            this.groupBoxCorrection.Size = new System.Drawing.Size(209, 264);
            this.groupBoxCorrection.TabIndex = 7;
            this.groupBoxCorrection.TabStop = false;
            this.groupBoxCorrection.Text = "Корректировка";
            // 
            // trackBarCorrectionSize
            // 
            this.trackBarCorrectionSize.Location = new System.Drawing.Point(6, 38);
            this.trackBarCorrectionSize.Maximum = 16;
            this.trackBarCorrectionSize.Name = "trackBarCorrectionSize";
            this.trackBarCorrectionSize.Size = new System.Drawing.Size(193, 45);
            this.trackBarCorrectionSize.TabIndex = 5;
            this.trackBarCorrectionSize.Value = 8;
            this.trackBarCorrectionSize.Scroll += new System.EventHandler(this.trackBarCorrectionSize_Scroll);
            // 
            // lblCorrectionSize
            // 
            this.lblCorrectionSize.AutoSize = true;
            this.lblCorrectionSize.Location = new System.Drawing.Point(78, 16);
            this.lblCorrectionSize.Name = "lblCorrectionSize";
            this.lblCorrectionSize.Size = new System.Drawing.Size(46, 13);
            this.lblCorrectionSize.TabIndex = 4;
            this.lblCorrectionSize.Text = "Размер";
            // 
            // lblCorrectionY
            // 
            this.lblCorrectionY.AutoSize = true;
            this.lblCorrectionY.Location = new System.Drawing.Point(61, 191);
            this.lblCorrectionY.Name = "lblCorrectionY";
            this.lblCorrectionY.Size = new System.Drawing.Size(73, 13);
            this.lblCorrectionY.TabIndex = 3;
            this.lblCorrectionY.Text = "Вертикально";
            // 
            // trackBarCorrectionY
            // 
            this.trackBarCorrectionY.Location = new System.Drawing.Point(6, 139);
            this.trackBarCorrectionY.Maximum = 12;
            this.trackBarCorrectionY.Name = "trackBarCorrectionY";
            this.trackBarCorrectionY.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarCorrectionY.Size = new System.Drawing.Size(45, 117);
            this.trackBarCorrectionY.TabIndex = 2;
            this.trackBarCorrectionY.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarCorrectionY.Value = 6;
            this.trackBarCorrectionY.Scroll += new System.EventHandler(this.trackBarCorrectionY_Scroll);
            // 
            // trackBarCorrectionX
            // 
            this.trackBarCorrectionX.Location = new System.Drawing.Point(6, 106);
            this.trackBarCorrectionX.Maximum = 16;
            this.trackBarCorrectionX.Name = "trackBarCorrectionX";
            this.trackBarCorrectionX.Size = new System.Drawing.Size(193, 45);
            this.trackBarCorrectionX.TabIndex = 1;
            this.trackBarCorrectionX.Value = 8;
            this.trackBarCorrectionX.Scroll += new System.EventHandler(this.trackBarCorrectionX_Scroll);
            // 
            // lblCorrectionX
            // 
            this.lblCorrectionX.AutoSize = true;
            this.lblCorrectionX.Location = new System.Drawing.Point(61, 86);
            this.lblCorrectionX.Name = "lblCorrectionX";
            this.lblCorrectionX.Size = new System.Drawing.Size(84, 13);
            this.lblCorrectionX.TabIndex = 0;
            this.lblCorrectionX.Text = "Горизонтально";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 655);
            this.Controls.Add(this.tabCtrlMasks);
            this.Controls.Add(this.groupBoxCorrection);
            this.Controls.Add(this.btnPlayPause);
            this.Controls.Add(this.btnShot);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.captureArea);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(1095, 694);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FaceUp!";
            ((System.ComponentModel.ISupportInitialize)(this.captureArea)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabCtrlMasks.ResumeLayout(false);
            this.tabMasks__Hair.ResumeLayout(false);
            this.tabMasks__Eye.ResumeLayout(false);
            this.tabMasks__Chin.ResumeLayout(false);
            this.groupBoxCorrection.ResumeLayout(false);
            this.groupBoxCorrection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCorrectionSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCorrectionY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCorrectionX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox captureArea;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shotAndSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Button btnShot;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusStrip__PeopleAmount;
        private System.Windows.Forms.GroupBox groupBoxCorrection;
        private System.Windows.Forms.TabControl tabCtrlMasks;
        private System.Windows.Forms.TabPage tabMasks__Hair;
        private System.Windows.Forms.TabPage tabMasks__Eye;
        private System.Windows.Forms.TabPage tabMasks__Chin;
        private System.Windows.Forms.Label lblCorrectionY;
        private System.Windows.Forms.TrackBar trackBarCorrectionY;
        private System.Windows.Forms.TrackBar trackBarCorrectionX;
        private System.Windows.Forms.Label lblCorrectionX;
        private System.Windows.Forms.ToolStripStatusLabel statusStrip__CorrectionX;
        private System.Windows.Forms.ToolStripStatusLabel statusStrip__CorrectionY;
        private System.Windows.Forms.ListView listViewHair;
        private System.Windows.Forms.ImageList imageListHair;
        private System.Windows.Forms.ImageList imageListEye;
        private System.Windows.Forms.ImageList imageListChin;
        private System.Windows.Forms.ToolStripStatusLabel statusStrip__CorrectionSize;
        private System.Windows.Forms.ListView listViewEye;
        private System.Windows.Forms.ListView listViewChin;
        private System.Windows.Forms.TrackBar trackBarCorrectionSize;
        private System.Windows.Forms.Label lblCorrectionSize;
        private System.Windows.Forms.ToolStripMenuItem playPauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem shotToolStripMenuItem;

    }
}

