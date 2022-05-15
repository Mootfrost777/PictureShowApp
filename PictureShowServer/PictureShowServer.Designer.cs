namespace PictureShowServer
{
    partial class PictureShowServer
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miConfigure = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileInit = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileStart = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileStop = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miConfigureMulticast = new System.Windows.Forms.ToolStripMenuItem();
            this.miConfigureShow = new System.Windows.Forms.ToolStripMenuItem();
            this.miConfigurePictures = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonPictures = new System.Windows.Forms.Button();
            this.buttonInit = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.statusBar = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.miConfigure,
            this.miHelp});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(440, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFileInit,
            this.miFileStart,
            this.miFileStop,
            this.miFileExit});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(37, 20);
            this.miFile.Text = "File";
            // 
            // miConfigure
            // 
            this.miConfigure.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miConfigureMulticast,
            this.miConfigureShow,
            this.miConfigurePictures});
            this.miConfigure.Name = "miConfigure";
            this.miConfigure.Size = new System.Drawing.Size(72, 20);
            this.miConfigure.Text = "Configure";
            // 
            // miHelp
            // 
            this.miHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miHelpAbout});
            this.miHelp.Name = "miHelp";
            this.miHelp.Size = new System.Drawing.Size(44, 20);
            this.miHelp.Text = "Help";
            // 
            // miFileInit
            // 
            this.miFileInit.Name = "miFileInit";
            this.miFileInit.Size = new System.Drawing.Size(180, 22);
            this.miFileInit.Text = "Init";
            this.miFileInit.Click += new System.EventHandler(this.OnInit);
            // 
            // miFileStart
            // 
            this.miFileStart.Enabled = false;
            this.miFileStart.Name = "miFileStart";
            this.miFileStart.Size = new System.Drawing.Size(180, 22);
            this.miFileStart.Text = "Start";
            this.miFileStart.Click += new System.EventHandler(this.OnStart);
            // 
            // miFileStop
            // 
            this.miFileStop.Enabled = false;
            this.miFileStop.Name = "miFileStop";
            this.miFileStop.Size = new System.Drawing.Size(180, 22);
            this.miFileStop.Text = "Stop";
            this.miFileStop.Click += new System.EventHandler(this.OnStop);
            // 
            // miFileExit
            // 
            this.miFileExit.Name = "miFileExit";
            this.miFileExit.Size = new System.Drawing.Size(180, 22);
            this.miFileExit.Text = "Exit";
            this.miFileExit.Click += new System.EventHandler(this.OnExit);
            // 
            // miConfigureMulticast
            // 
            this.miConfigureMulticast.Name = "miConfigureMulticast";
            this.miConfigureMulticast.Size = new System.Drawing.Size(180, 22);
            this.miConfigureMulticast.Text = "Multicast Session";
            this.miConfigureMulticast.Click += new System.EventHandler(this.OnConfigureMulticast);
            // 
            // miConfigureShow
            // 
            this.miConfigureShow.Name = "miConfigureShow";
            this.miConfigureShow.Size = new System.Drawing.Size(180, 22);
            this.miConfigureShow.Text = "Show Timings";
            this.miConfigureShow.Click += new System.EventHandler(this.OnConfigureShow);
            // 
            // miConfigurePictures
            // 
            this.miConfigurePictures.Name = "miConfigurePictures";
            this.miConfigurePictures.Size = new System.Drawing.Size(180, 22);
            this.miConfigurePictures.Text = "Pictures";
            this.miConfigurePictures.Click += new System.EventHandler(this.OnConfigurePictures);
            // 
            // miHelpAbout
            // 
            this.miHelpAbout.Name = "miHelpAbout";
            this.miHelpAbout.Size = new System.Drawing.Size(180, 22);
            this.miHelpAbout.Text = "About";
            this.miHelpAbout.Click += new System.EventHandler(this.OnHelpAbout);
            // 
            // buttonPictures
            // 
            this.buttonPictures.Location = new System.Drawing.Point(12, 39);
            this.buttonPictures.Name = "buttonPictures";
            this.buttonPictures.Size = new System.Drawing.Size(100, 23);
            this.buttonPictures.TabIndex = 1;
            this.buttonPictures.Text = "Pictures...";
            this.buttonPictures.UseVisualStyleBackColor = true;
            this.buttonPictures.Click += new System.EventHandler(this.OnConfigurePictures);
            // 
            // buttonInit
            // 
            this.buttonInit.Location = new System.Drawing.Point(118, 39);
            this.buttonInit.Name = "buttonInit";
            this.buttonInit.Size = new System.Drawing.Size(100, 23);
            this.buttonInit.TabIndex = 2;
            this.buttonInit.Text = "Init";
            this.buttonInit.UseVisualStyleBackColor = true;
            this.buttonInit.Click += new System.EventHandler(this.OnInit);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(224, 39);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(100, 23);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start Show";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.OnStart);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(330, 39);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(100, 23);
            this.buttonStop.TabIndex = 4;
            this.buttonStop.Text = "Stop Show";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.OnStop);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 68);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(418, 270);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 344);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(418, 23);
            this.progressBar.TabIndex = 6;
            // 
            // statusBar
            // 
            this.statusBar.AutoSize = true;
            this.statusBar.Location = new System.Drawing.Point(13, 374);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(68, 13);
            this.statusBar.TabIndex = 7;
            this.statusBar.Text = "Information...";
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // PictureShowServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 398);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonInit);
            this.Controls.Add(this.buttonPictures);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "PictureShowServer";
            this.Text = "Picture Show Server";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miFileInit;
        private System.Windows.Forms.ToolStripMenuItem miFileStart;
        private System.Windows.Forms.ToolStripMenuItem miFileStop;
        private System.Windows.Forms.ToolStripMenuItem miFileExit;
        private System.Windows.Forms.ToolStripMenuItem miConfigure;
        private System.Windows.Forms.ToolStripMenuItem miConfigureMulticast;
        private System.Windows.Forms.ToolStripMenuItem miConfigureShow;
        private System.Windows.Forms.ToolStripMenuItem miConfigurePictures;
        private System.Windows.Forms.ToolStripMenuItem miHelp;
        private System.Windows.Forms.ToolStripMenuItem miHelpAbout;
        private System.Windows.Forms.Button buttonPictures;
        private System.Windows.Forms.Button buttonInit;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label statusBar;
        private System.Windows.Forms.ImageList imageList;
    }
}

