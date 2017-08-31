namespace LaboratorioRepaso_Andoni_Zamora
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agragarCarpetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenarPorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenarPorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.durasiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToSearch = new System.Windows.Forms.ToolStripTextBox();
            this.songName = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.songList = new System.Windows.Forms.ListBox();
            this.reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.panelAgregar = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.albumBox = new System.Windows.Forms.TextBox();
            this.durationBox = new System.Windows.Forms.TextBox();
            this.artistBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.playlistPanel = new System.Windows.Forms.Panel();
            this.palylistList = new System.Windows.Forms.ListBox();
            this.panelResult = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.albumResult = new System.Windows.Forms.TextBox();
            this.durationResult = new System.Windows.Forms.TextBox();
            this.artistResult = new System.Windows.Forms.TextBox();
            this.nameResult = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.volumeStatus = new System.Windows.Forms.TrackBar();
            this.songStatus = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureSong = new System.Windows.Forms.PictureBox();
            this.volumeButton = new System.Windows.Forms.PictureBox();
            this.stopButton = new System.Windows.Forms.PictureBox();
            this.playButton = new System.Windows.Forms.PictureBox();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reproductor)).BeginInit();
            this.panelAgregar.SuspendLayout();
            this.playlistPanel.SuspendLayout();
            this.panelResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Modern No. 20", 11.25F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ordenarPorToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.itemToSearch});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(370, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.agragarCarpetaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(68, 23);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // agragarCarpetaToolStripMenuItem
            // 
            this.agragarCarpetaToolStripMenuItem.Name = "agragarCarpetaToolStripMenuItem";
            this.agragarCarpetaToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.agragarCarpetaToolStripMenuItem.Text = "Agragar carpeta";
            this.agragarCarpetaToolStripMenuItem.Click += new System.EventHandler(this.agragarCarpetaToolStripMenuItem_Click);
            // 
            // ordenarPorToolStripMenuItem
            // 
            this.ordenarPorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verPlaylistToolStripMenuItem,
            this.ordenarPorToolStripMenuItem1});
            this.ordenarPorToolStripMenuItem.Name = "ordenarPorToolStripMenuItem";
            this.ordenarPorToolStripMenuItem.Size = new System.Drawing.Size(69, 23);
            this.ordenarPorToolStripMenuItem.Text = "Playlist";
            // 
            // verPlaylistToolStripMenuItem
            // 
            this.verPlaylistToolStripMenuItem.Name = "verPlaylistToolStripMenuItem";
            this.verPlaylistToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.verPlaylistToolStripMenuItem.Text = "Ver Playlist";
            this.verPlaylistToolStripMenuItem.Click += new System.EventHandler(this.verPlaylistToolStripMenuItem_Click);
            // 
            // ordenarPorToolStripMenuItem1
            // 
            this.ordenarPorToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombreToolStripMenuItem,
            this.durasiónToolStripMenuItem});
            this.ordenarPorToolStripMenuItem1.Name = "ordenarPorToolStripMenuItem1";
            this.ordenarPorToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.ordenarPorToolStripMenuItem1.Text = "Ordenar por";
            // 
            // nombreToolStripMenuItem
            // 
            this.nombreToolStripMenuItem.Name = "nombreToolStripMenuItem";
            this.nombreToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.nombreToolStripMenuItem.Text = "Nombre";
            this.nombreToolStripMenuItem.Click += new System.EventHandler(this.nombreToolStripMenuItem_Click);
            // 
            // durasiónToolStripMenuItem
            // 
            this.durasiónToolStripMenuItem.Name = "durasiónToolStripMenuItem";
            this.durasiónToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.durasiónToolStripMenuItem.Text = "Duración";
            this.durasiónToolStripMenuItem.Click += new System.EventHandler(this.durasiónToolStripMenuItem_Click);
            // 
            // itemToSearch
            // 
            this.itemToSearch.Name = "itemToSearch";
            this.itemToSearch.Size = new System.Drawing.Size(100, 23);
            // 
            // songName
            // 
            this.songName.AutoSize = true;
            this.songName.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songName.Location = new System.Drawing.Point(12, 237);
            this.songName.Name = "songName";
            this.songName.Size = new System.Drawing.Size(91, 18);
            this.songName.TabIndex = 6;
            this.songName.Text = "Bienvenido";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(348, 206);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.songList);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(340, 176);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado Global";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // songList
            // 
            this.songList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.songList.FormattingEnabled = true;
            this.songList.ItemHeight = 17;
            this.songList.Location = new System.Drawing.Point(3, 3);
            this.songList.Name = "songList";
            this.songList.Size = new System.Drawing.Size(334, 170);
            this.songList.TabIndex = 0;
            this.songList.SelectedIndexChanged += new System.EventHandler(this.songList_SelectedIndexChanged);
            // 
            // reproductor
            // 
            this.reproductor.Enabled = true;
            this.reproductor.Location = new System.Drawing.Point(0, 375);
            this.reproductor.Name = "reproductor";
            this.reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("reproductor.OcxState")));
            this.reproductor.Size = new System.Drawing.Size(232, 48);
            this.reproductor.TabIndex = 8;
            this.reproductor.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.reproductor_PlayStateChange);
            // 
            // panelAgregar
            // 
            this.panelAgregar.Controls.Add(this.button2);
            this.panelAgregar.Controls.Add(this.albumBox);
            this.panelAgregar.Controls.Add(this.durationBox);
            this.panelAgregar.Controls.Add(this.artistBox);
            this.panelAgregar.Controls.Add(this.nameBox);
            this.panelAgregar.Controls.Add(this.button1);
            this.panelAgregar.Controls.Add(this.label2);
            this.panelAgregar.Controls.Add(this.label5);
            this.panelAgregar.Controls.Add(this.label4);
            this.panelAgregar.Controls.Add(this.label3);
            this.panelAgregar.Controls.Add(this.label1);
            this.panelAgregar.Location = new System.Drawing.Point(6, 29);
            this.panelAgregar.Name = "panelAgregar";
            this.panelAgregar.Size = new System.Drawing.Size(360, 318);
            this.panelAgregar.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 11.25F);
            this.button2.Location = new System.Drawing.Point(214, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // albumBox
            // 
            this.albumBox.Font = new System.Drawing.Font("Modern No. 20", 11.25F);
            this.albumBox.Location = new System.Drawing.Point(142, 182);
            this.albumBox.Name = "albumBox";
            this.albumBox.Size = new System.Drawing.Size(100, 24);
            this.albumBox.TabIndex = 2;
            // 
            // durationBox
            // 
            this.durationBox.Font = new System.Drawing.Font("Modern No. 20", 11.25F);
            this.durationBox.Location = new System.Drawing.Point(142, 154);
            this.durationBox.Name = "durationBox";
            this.durationBox.ReadOnly = true;
            this.durationBox.Size = new System.Drawing.Size(100, 24);
            this.durationBox.TabIndex = 2;
            // 
            // artistBox
            // 
            this.artistBox.Font = new System.Drawing.Font("Modern No. 20", 11.25F);
            this.artistBox.Location = new System.Drawing.Point(142, 127);
            this.artistBox.Name = "artistBox";
            this.artistBox.Size = new System.Drawing.Size(100, 24);
            this.artistBox.TabIndex = 2;
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Modern No. 20", 11.25F);
            this.nameBox.Location = new System.Drawing.Point(142, 97);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 24);
            this.nameBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 11.25F);
            this.button1.Location = new System.Drawing.Point(115, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Agregar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 11.25F);
            this.label5.Location = new System.Drawing.Point(70, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Album";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 11.25F);
            this.label4.Location = new System.Drawing.Point(53, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Duración";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 11.25F);
            this.label3.Location = new System.Drawing.Point(68, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Artista";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 11.25F);
            this.label1.Location = new System.Drawing.Point(64, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // playlistPanel
            // 
            this.playlistPanel.Controls.Add(this.palylistList);
            this.playlistPanel.Location = new System.Drawing.Point(11, 55);
            this.playlistPanel.Name = "playlistPanel";
            this.playlistPanel.Size = new System.Drawing.Size(355, 184);
            this.playlistPanel.TabIndex = 10;
            // 
            // palylistList
            // 
            this.palylistList.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.palylistList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palylistList.Font = new System.Drawing.Font("Modern No. 20", 11.25F);
            this.palylistList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.palylistList.FormattingEnabled = true;
            this.palylistList.ItemHeight = 17;
            this.palylistList.Location = new System.Drawing.Point(0, 0);
            this.palylistList.Name = "palylistList";
            this.palylistList.Size = new System.Drawing.Size(355, 184);
            this.palylistList.TabIndex = 2;
            this.palylistList.SelectedIndexChanged += new System.EventHandler(this.palylistList_SelectedIndexChanged);
            // 
            // panelResult
            // 
            this.panelResult.Controls.Add(this.button5);
            this.panelResult.Controls.Add(this.button4);
            this.panelResult.Controls.Add(this.button3);
            this.panelResult.Controls.Add(this.albumResult);
            this.panelResult.Controls.Add(this.durationResult);
            this.panelResult.Controls.Add(this.artistResult);
            this.panelResult.Controls.Add(this.nameResult);
            this.panelResult.Controls.Add(this.label7);
            this.panelResult.Controls.Add(this.label8);
            this.panelResult.Controls.Add(this.label9);
            this.panelResult.Controls.Add(this.label10);
            this.panelResult.Controls.Add(this.label6);
            this.panelResult.Location = new System.Drawing.Point(2, 29);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(364, 318);
            this.panelResult.TabIndex = 11;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(49, 248);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 30);
            this.button5.TabIndex = 13;
            this.button5.Text = "A Playlist";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(139, 248);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 30);
            this.button4.TabIndex = 13;
            this.button4.Text = "Reproducir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 11.25F);
            this.button3.Location = new System.Drawing.Point(231, 248);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 30);
            this.button3.TabIndex = 13;
            this.button3.Text = "Aceptar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // albumResult
            // 
            this.albumResult.Font = new System.Drawing.Font("Modern No. 20", 11.25F);
            this.albumResult.Location = new System.Drawing.Point(127, 187);
            this.albumResult.Name = "albumResult";
            this.albumResult.ReadOnly = true;
            this.albumResult.Size = new System.Drawing.Size(189, 24);
            this.albumResult.TabIndex = 9;
            // 
            // durationResult
            // 
            this.durationResult.Font = new System.Drawing.Font("Modern No. 20", 11.25F);
            this.durationResult.Location = new System.Drawing.Point(127, 159);
            this.durationResult.Name = "durationResult";
            this.durationResult.ReadOnly = true;
            this.durationResult.Size = new System.Drawing.Size(189, 24);
            this.durationResult.TabIndex = 10;
            // 
            // artistResult
            // 
            this.artistResult.Font = new System.Drawing.Font("Modern No. 20", 11.25F);
            this.artistResult.Location = new System.Drawing.Point(127, 132);
            this.artistResult.Name = "artistResult";
            this.artistResult.ReadOnly = true;
            this.artistResult.Size = new System.Drawing.Size(189, 24);
            this.artistResult.TabIndex = 11;
            // 
            // nameResult
            // 
            this.nameResult.Font = new System.Drawing.Font("Modern No. 20", 11.25F);
            this.nameResult.Location = new System.Drawing.Point(127, 102);
            this.nameResult.Name = "nameResult";
            this.nameResult.ReadOnly = true;
            this.nameResult.Size = new System.Drawing.Size(189, 24);
            this.nameResult.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 11.25F);
            this.label7.Location = new System.Drawing.Point(55, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Album";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 11.25F);
            this.label8.Location = new System.Drawing.Point(38, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Duración";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 11.25F);
            this.label9.Location = new System.Drawing.Point(53, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Artista";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 11.25F);
            this.label10.Location = new System.Drawing.Point(49, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Resultados";
            // 
            // volumeStatus
            // 
            this.volumeStatus.AllowDrop = true;
            this.volumeStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volumeStatus.Location = new System.Drawing.Point(246, 297);
            this.volumeStatus.Maximum = 100;
            this.volumeStatus.Name = "volumeStatus";
            this.volumeStatus.Size = new System.Drawing.Size(104, 45);
            this.volumeStatus.TabIndex = 12;
            this.volumeStatus.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volumeStatus.ValueChanged += new System.EventHandler(this.volumeStatus_ValueChanged);
            // 
            // songStatus
            // 
            this.songStatus.Location = new System.Drawing.Point(12, 256);
            this.songStatus.Maximum = 100;
            this.songStatus.Name = "songStatus";
            this.songStatus.Size = new System.Drawing.Size(344, 45);
            this.songStatus.TabIndex = 13;
            this.songStatus.TabStop = false;
            this.songStatus.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureSong
            // 
            this.pictureSong.Image = global::LaboratorioRepaso_Andoni_Zamora.Properties.Resources.Button_12_51r;
            this.pictureSong.Location = new System.Drawing.Point(15, 278);
            this.pictureSong.Name = "pictureSong";
            this.pictureSong.Size = new System.Drawing.Size(61, 69);
            this.pictureSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureSong.TabIndex = 17;
            this.pictureSong.TabStop = false;
            // 
            // volumeButton
            // 
            this.volumeButton.Image = global::LaboratorioRepaso_Andoni_Zamora.Properties.Resources.unnamed;
            this.volumeButton.Location = new System.Drawing.Point(204, 288);
            this.volumeButton.Name = "volumeButton";
            this.volumeButton.Size = new System.Drawing.Size(40, 41);
            this.volumeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.volumeButton.TabIndex = 5;
            this.volumeButton.TabStop = false;
            // 
            // stopButton
            // 
            this.stopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopButton.Image = global::LaboratorioRepaso_Andoni_Zamora.Properties.Resources.Button_5_121;
            this.stopButton.Location = new System.Drawing.Point(140, 277);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(57, 70);
            this.stopButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.stopButton.TabIndex = 4;
            this.stopButton.TabStop = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // playButton
            // 
            this.playButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playButton.Image = global::LaboratorioRepaso_Andoni_Zamora.Properties.Resources.Button_3_512;
            this.playButton.Location = new System.Drawing.Point(77, 277);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(57, 70);
            this.playButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playButton.TabIndex = 2;
            this.playButton.TabStop = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::LaboratorioRepaso_Andoni_Zamora.Properties.Resources.Button_12_512;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Image = global::LaboratorioRepaso_Andoni_Zamora.Properties.Resources._698627_icon_111_search_512;
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(39, 23);
            this.buscarToolStripMenuItem.Text = ":";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 353);
            this.Controls.Add(this.panelResult);
            this.Controls.Add(this.panelAgregar);
            this.Controls.Add(this.playlistPanel);
            this.Controls.Add(this.reproductor);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.songName);
            this.Controls.Add(this.volumeButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.volumeStatus);
            this.Controls.Add(this.pictureSong);
            this.Controls.Add(this.songStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Nono Media";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reproductor)).EndInit();
            this.panelAgregar.ResumeLayout(false);
            this.panelAgregar.PerformLayout();
            this.playlistPanel.ResumeLayout(false);
            this.panelResult.ResumeLayout(false);
            this.panelResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.PictureBox playButton;
        private System.Windows.Forms.PictureBox stopButton;
        private System.Windows.Forms.PictureBox volumeButton;
        private System.Windows.Forms.Label songName;
        private System.Windows.Forms.ToolStripMenuItem ordenarPorToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripMenuItem ordenarPorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem durasiónToolStripMenuItem;
        private AxWMPLib.AxWindowsMediaPlayer reproductor;
        private System.Windows.Forms.Panel panelAgregar;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox albumBox;
        private System.Windows.Forms.TextBox durationBox;
        private System.Windows.Forms.TextBox artistBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel playlistPanel;
        private System.Windows.Forms.ListBox palylistList;
        private System.Windows.Forms.ToolStripMenuItem verPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agragarCarpetaToolStripMenuItem;
        private System.Windows.Forms.ListBox songList;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox itemToSearch;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox albumResult;
        private System.Windows.Forms.TextBox durationResult;
        private System.Windows.Forms.TextBox artistResult;
        private System.Windows.Forms.TextBox nameResult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar volumeStatus;
        private System.Windows.Forms.TrackBar songStatus;
        private System.Windows.Forms.PictureBox pictureSong;
        private System.Windows.Forms.Timer timer1;
    }
}

