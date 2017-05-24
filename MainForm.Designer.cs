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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.shotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shotAndSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playPauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.btnShot = new System.Windows.Forms.Button();
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
            this.saveImageDialog = new System.Windows.Forms.SaveFileDialog();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnOpenOutputDir = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStrip__PeopleAmount = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip__CorrectionSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip__CorrectionX = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip__CorrectionY = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnClearMasks = new System.Windows.Forms.Button();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.captureArea)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.tabCtrlMasks.SuspendLayout();
            this.tabMasks__Hair.SuspendLayout();
            this.tabMasks__Eye.SuspendLayout();
            this.tabMasks__Chin.SuspendLayout();
            this.groupBoxCorrection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCorrectionSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCorrectionY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCorrectionX)).BeginInit();
            this.statusStrip.SuspendLayout();
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
            this.captureArea.Size = new System.Drawing.Size(820, 617);
            this.captureArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.captureArea.TabIndex = 0;
            this.captureArea.TabStop = false;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.serviceToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1097, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDirToolStripMenuItem,
            this.toolStripSeparator,
            this.shotToolStripMenuItem,
            this.shotAndSaveToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "&Файл";
            // 
            // openDirToolStripMenuItem
            // 
            this.openDirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openDirToolStripMenuItem.Image")));
            this.openDirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openDirToolStripMenuItem.Name = "openDirToolStripMenuItem";
            this.openDirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openDirToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.openDirToolStripMenuItem.Text = "&Открыть папку со снимками";
            this.openDirToolStripMenuItem.Click += new System.EventHandler(this.openDirToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(290, 6);
            // 
            // shotToolStripMenuItem
            // 
            this.shotToolStripMenuItem.Name = "shotToolStripMenuItem";
            this.shotToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.shotToolStripMenuItem.Text = "Сделать снимок";
            this.shotToolStripMenuItem.Click += new System.EventHandler(this.shotToolStripMenuItem_Click);
            // 
            // shotAndSaveToolStripMenuItem
            // 
            this.shotAndSaveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("shotAndSaveToolStripMenuItem.Image")));
            this.shotAndSaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.shotAndSaveToolStripMenuItem.Name = "shotAndSaveToolStripMenuItem";
            this.shotAndSaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.shotAndSaveToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.shotAndSaveToolStripMenuItem.Text = "&Сделать снимок и сохранить как";
            this.shotAndSaveToolStripMenuItem.Click += new System.EventHandler(this.shotAndSaveToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(290, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.exitToolStripMenuItem.Text = "Вы&ход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playPauseToolStripMenuItem,
            this.toolStripSeparator4,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.serviceToolStripMenuItem.Text = "&Сервис";
            // 
            // playPauseToolStripMenuItem
            // 
            this.playPauseToolStripMenuItem.Name = "playPauseToolStripMenuItem";
            this.playPauseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.playPauseToolStripMenuItem.Text = "Пауза";
            this.playPauseToolStripMenuItem.Click += new System.EventHandler(this.playPauseToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "&Настройки";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
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
            this.btnPlayPause.Location = new System.Drawing.Point(944, 27);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(99, 34);
            this.btnPlayPause.TabIndex = 2;
            this.btnPlayPause.Text = "Пауза";
            this.btnPlayPause.UseVisualStyleBackColor = true;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // btnShot
            // 
            this.btnShot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShot.Location = new System.Drawing.Point(839, 27);
            this.btnShot.Name = "btnShot";
            this.btnShot.Size = new System.Drawing.Size(99, 34);
            this.btnShot.TabIndex = 3;
            this.btnShot.Text = "Сделать снимок";
            this.btnShot.UseVisualStyleBackColor = true;
            this.btnShot.Click += new System.EventHandler(this.btnShot_Click);
            // 
            // tabCtrlMasks
            // 
            this.tabCtrlMasks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCtrlMasks.Controls.Add(this.tabMasks__Hair);
            this.tabCtrlMasks.Controls.Add(this.tabMasks__Eye);
            this.tabCtrlMasks.Controls.Add(this.tabMasks__Chin);
            this.tabCtrlMasks.Location = new System.Drawing.Point(839, 67);
            this.tabCtrlMasks.Name = "tabCtrlMasks";
            this.tabCtrlMasks.SelectedIndex = 0;
            this.tabCtrlMasks.Size = new System.Drawing.Size(246, 279);
            this.tabCtrlMasks.TabIndex = 7;
            this.tabCtrlMasks.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabCtrlMasks_Selecting);
            // 
            // tabMasks__Hair
            // 
            this.tabMasks__Hair.AutoScroll = true;
            this.tabMasks__Hair.Controls.Add(this.listViewHair);
            this.tabMasks__Hair.Location = new System.Drawing.Point(4, 22);
            this.tabMasks__Hair.Name = "tabMasks__Hair";
            this.tabMasks__Hair.Padding = new System.Windows.Forms.Padding(3);
            this.tabMasks__Hair.Size = new System.Drawing.Size(238, 253);
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
            this.listViewHair.Size = new System.Drawing.Size(225, 240);
            this.listViewHair.TabIndex = 0;
            this.listViewHair.UseCompatibleStateImageBehavior = false;
            this.listViewHair.SelectedIndexChanged += new System.EventHandler(this.listViewHair_SelectedIndexChanged);
            // 
            // imageListHair
            // 
            this.imageListHair.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListHair.ImageSize = new System.Drawing.Size(160, 160);
            this.imageListHair.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabMasks__Eye
            // 
            this.tabMasks__Eye.AutoScroll = true;
            this.tabMasks__Eye.Controls.Add(this.listViewEye);
            this.tabMasks__Eye.Location = new System.Drawing.Point(4, 22);
            this.tabMasks__Eye.Name = "tabMasks__Eye";
            this.tabMasks__Eye.Padding = new System.Windows.Forms.Padding(3);
            this.tabMasks__Eye.Size = new System.Drawing.Size(238, 253);
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
            this.listViewEye.Size = new System.Drawing.Size(226, 241);
            this.listViewEye.TabIndex = 1;
            this.listViewEye.UseCompatibleStateImageBehavior = false;
            this.listViewEye.SelectedIndexChanged += new System.EventHandler(this.listViewEye_SelectedIndexChanged);
            // 
            // imageListEye
            // 
            this.imageListEye.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListEye.ImageSize = new System.Drawing.Size(160, 160);
            this.imageListEye.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabMasks__Chin
            // 
            this.tabMasks__Chin.AutoScroll = true;
            this.tabMasks__Chin.Controls.Add(this.listViewChin);
            this.tabMasks__Chin.Location = new System.Drawing.Point(4, 22);
            this.tabMasks__Chin.Name = "tabMasks__Chin";
            this.tabMasks__Chin.Size = new System.Drawing.Size(238, 253);
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
            this.listViewChin.Size = new System.Drawing.Size(226, 240);
            this.listViewChin.TabIndex = 2;
            this.listViewChin.UseCompatibleStateImageBehavior = false;
            this.listViewChin.SelectedIndexChanged += new System.EventHandler(this.listViewChin_SelectedIndexChanged);
            // 
            // imageListChin
            // 
            this.imageListChin.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListChin.ImageSize = new System.Drawing.Size(160, 160);
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
            this.groupBoxCorrection.Location = new System.Drawing.Point(839, 380);
            this.groupBoxCorrection.Name = "groupBoxCorrection";
            this.groupBoxCorrection.Size = new System.Drawing.Size(242, 264);
            this.groupBoxCorrection.TabIndex = 7;
            this.groupBoxCorrection.TabStop = false;
            this.groupBoxCorrection.Text = "Корректировка";
            // 
            // trackBarCorrectionSize
            // 
            this.trackBarCorrectionSize.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBarCorrectionSize.Location = new System.Drawing.Point(6, 38);
            this.trackBarCorrectionSize.Maximum = 20;
            this.trackBarCorrectionSize.Name = "trackBarCorrectionSize";
            this.trackBarCorrectionSize.Size = new System.Drawing.Size(230, 45);
            this.trackBarCorrectionSize.TabIndex = 5;
            this.trackBarCorrectionSize.Value = 10;
            this.trackBarCorrectionSize.Scroll += new System.EventHandler(this.trackBarCorrectionSize_Scroll);
            // 
            // lblCorrectionSize
            // 
            this.lblCorrectionSize.AutoSize = true;
            this.lblCorrectionSize.Location = new System.Drawing.Point(99, 16);
            this.lblCorrectionSize.Name = "lblCorrectionSize";
            this.lblCorrectionSize.Size = new System.Drawing.Size(46, 13);
            this.lblCorrectionSize.TabIndex = 4;
            this.lblCorrectionSize.Text = "Размер";
            // 
            // lblCorrectionY
            // 
            this.lblCorrectionY.AutoSize = true;
            this.lblCorrectionY.Location = new System.Drawing.Point(57, 190);
            this.lblCorrectionY.Name = "lblCorrectionY";
            this.lblCorrectionY.Size = new System.Drawing.Size(73, 13);
            this.lblCorrectionY.TabIndex = 3;
            this.lblCorrectionY.Text = "Вертикально";
            // 
            // trackBarCorrectionY
            // 
            this.trackBarCorrectionY.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBarCorrectionY.Location = new System.Drawing.Point(6, 139);
            this.trackBarCorrectionY.Maximum = 16;
            this.trackBarCorrectionY.Name = "trackBarCorrectionY";
            this.trackBarCorrectionY.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarCorrectionY.Size = new System.Drawing.Size(45, 117);
            this.trackBarCorrectionY.TabIndex = 1;
            this.trackBarCorrectionY.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarCorrectionY.Value = 8;
            this.trackBarCorrectionY.Scroll += new System.EventHandler(this.trackBarCorrectionY_Scroll);
            // 
            // trackBarCorrectionX
            // 
            this.trackBarCorrectionX.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBarCorrectionX.Location = new System.Drawing.Point(6, 106);
            this.trackBarCorrectionX.Maximum = 20;
            this.trackBarCorrectionX.Name = "trackBarCorrectionX";
            this.trackBarCorrectionX.Size = new System.Drawing.Size(230, 45);
            this.trackBarCorrectionX.TabIndex = 1;
            this.trackBarCorrectionX.Value = 10;
            this.trackBarCorrectionX.Scroll += new System.EventHandler(this.trackBarCorrectionX_Scroll);
            // 
            // lblCorrectionX
            // 
            this.lblCorrectionX.AutoSize = true;
            this.lblCorrectionX.Location = new System.Drawing.Point(79, 86);
            this.lblCorrectionX.Name = "lblCorrectionX";
            this.lblCorrectionX.Size = new System.Drawing.Size(84, 13);
            this.lblCorrectionX.TabIndex = 0;
            this.lblCorrectionX.Text = "Горизонтально";
            // 
            // saveImageDialog
            // 
            this.saveImageDialog.DefaultExt = "jpg";
            this.saveImageDialog.Filter = "JPEG files (*.jpg)|*.jpg|Bitmap files (*.bmp)|*.bmp|PNG files (*.png)|*.png";
            this.saveImageDialog.Title = "Сохранить снимок";
            // 
            // openImageDialog
            // 
            this.openImageDialog.DefaultExt = "jpg";
            this.openImageDialog.Filter = "JPEG files (*.jpg)|*.jpg|Bitmap files (*.bmp)|*.bmp|PNG files (*.png)|*.png";
            this.openImageDialog.Title = "Открыть изображение";
            // 
            // timer
            // 
            this.timer.Interval = 30;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnOpenOutputDir
            // 
            this.btnOpenOutputDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenOutputDir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpenOutputDir.Image = global::FaceUp.Properties.Resources.folder_ico;
            this.btnOpenOutputDir.Location = new System.Drawing.Point(1049, 27);
            this.btnOpenOutputDir.Name = "btnOpenOutputDir";
            this.btnOpenOutputDir.Size = new System.Drawing.Size(36, 34);
            this.btnOpenOutputDir.TabIndex = 8;
            this.btnOpenOutputDir.UseVisualStyleBackColor = true;
            this.btnOpenOutputDir.Click += new System.EventHandler(this.btnOpenOutputDir_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStrip__PeopleAmount,
            this.statusStrip__CorrectionSize,
            this.statusStrip__CorrectionX,
            this.statusStrip__CorrectionY});
            this.statusStrip.Location = new System.Drawing.Point(0, 647);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1097, 22);
            this.statusStrip.TabIndex = 9;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusStrip__PeopleAmount
            // 
            this.statusStrip__PeopleAmount.Name = "statusStrip__PeopleAmount";
            this.statusStrip__PeopleAmount.Size = new System.Drawing.Size(119, 17);
            this.statusStrip__PeopleAmount.Text = "Людей на снимке:  0";
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
            this.statusStrip__CorrectionX.Size = new System.Drawing.Size(156, 17);
            this.statusStrip__CorrectionX.Text = "Корректировка по оси X: 0 ";
            // 
            // statusStrip__CorrectionY
            // 
            this.statusStrip__CorrectionY.Name = "statusStrip__CorrectionY";
            this.statusStrip__CorrectionY.Size = new System.Drawing.Size(156, 17);
            this.statusStrip__CorrectionY.Text = "Корректировка по оси Y:  0";
            // 
            // btnClearMasks
            // 
            this.btnClearMasks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearMasks.Location = new System.Drawing.Point(839, 351);
            this.btnClearMasks.Name = "btnClearMasks";
            this.btnClearMasks.Size = new System.Drawing.Size(246, 23);
            this.btnClearMasks.TabIndex = 10;
            this.btnClearMasks.Text = "Очистить маску";
            this.btnClearMasks.UseVisualStyleBackColor = true;
            this.btnClearMasks.Click += new System.EventHandler(this.btnClearMasks_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.helpToolStripMenuItem.Text = "Справка";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 669);
            this.Controls.Add(this.btnClearMasks);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnOpenOutputDir);
            this.Controls.Add(this.tabCtrlMasks);
            this.Controls.Add(this.groupBoxCorrection);
            this.Controls.Add(this.btnPlayPause);
            this.Controls.Add(this.btnShot);
            this.Controls.Add(this.captureArea);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(1113, 708);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FaceUp!";
            ((System.ComponentModel.ISupportInitialize)(this.captureArea)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabCtrlMasks.ResumeLayout(false);
            this.tabMasks__Hair.ResumeLayout(false);
            this.tabMasks__Eye.ResumeLayout(false);
            this.tabMasks__Chin.ResumeLayout(false);
            this.groupBoxCorrection.ResumeLayout(false);
            this.groupBoxCorrection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCorrectionSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCorrectionY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCorrectionX)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox captureArea;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Button btnShot;
        private System.Windows.Forms.GroupBox groupBoxCorrection;
        private System.Windows.Forms.TabControl tabCtrlMasks;
        private System.Windows.Forms.TabPage tabMasks__Hair;
        private System.Windows.Forms.TabPage tabMasks__Eye;
        private System.Windows.Forms.TabPage tabMasks__Chin;
        private System.Windows.Forms.Label lblCorrectionY;
        private System.Windows.Forms.TrackBar trackBarCorrectionY;
        private System.Windows.Forms.TrackBar trackBarCorrectionX;
        private System.Windows.Forms.Label lblCorrectionX;
        private System.Windows.Forms.ListView listViewHair;
        private System.Windows.Forms.ImageList imageListHair;
        private System.Windows.Forms.ImageList imageListEye;
        private System.Windows.Forms.ImageList imageListChin;
        private System.Windows.Forms.ListView listViewEye;
        private System.Windows.Forms.ListView listViewChin;
        private System.Windows.Forms.TrackBar trackBarCorrectionSize;
        private System.Windows.Forms.Label lblCorrectionSize;
        private System.Windows.Forms.SaveFileDialog saveImageDialog;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnOpenOutputDir;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem shotAndSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shotToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playPauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusStrip__PeopleAmount;
        private System.Windows.Forms.ToolStripStatusLabel statusStrip__CorrectionSize;
        private System.Windows.Forms.ToolStripStatusLabel statusStrip__CorrectionX;
        private System.Windows.Forms.ToolStripStatusLabel statusStrip__CorrectionY;
        private System.Windows.Forms.Button btnClearMasks;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;

    }
}

