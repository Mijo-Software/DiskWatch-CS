namespace DiskwatchCS
{
  partial class Form
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
			this.FileSystemWatcher = new System.IO.FileSystemWatcher();
			this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.listviewWatch = new System.Windows.Forms.ListView();
			this.columnHeaderIconState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderTimestamp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ColumnHeaderPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.imageList = new System.Windows.Forms.ImageList(this.components);
			this.buttonSaveList = new System.Windows.Forms.Button();
			this.buttonDeleteList = new System.Windows.Forms.Button();
			this.textboxPath = new System.Windows.Forms.TextBox();
			this.checkboxMinimizeToSystemtray = new System.Windows.Forms.CheckBox();
			this.buttonCopyToClipboard = new System.Windows.Forms.Button();
			this.buttonShowInfos = new System.Windows.Forms.Button();
			this.buttonOpenFolder = new System.Windows.Forms.Button();
			this.buttonDriveC = new System.Windows.Forms.Button();
			this.buttonStop = new System.Windows.Forms.Button();
			this.buttonStart = new System.Windows.Forms.Button();
			this.labelPath = new System.Windows.Forms.Label();
			this.labelFilesCreated = new System.Windows.Forms.Label();
			this.labelFilesDeleted = new System.Windows.Forms.Label();
			this.labelFilesChanged = new System.Windows.Forms.Label();
			this.labelFilesRenamed = new System.Windows.Forms.Label();
			this.groupBoxStatistics = new System.Windows.Forms.GroupBox();
			this.labelTimeEndMeasured = new System.Windows.Forms.Label();
			this.labelRuntimeMeasured = new System.Windows.Forms.Label();
			this.labelTimeBeginMeasured = new System.Windows.Forms.Label();
			this.labelCounterFiles = new System.Windows.Forms.Label();
			this.labelRuntime = new System.Windows.Forms.Label();
			this.labelTimeEnd = new System.Windows.Forms.Label();
			this.labelTimeBegin = new System.Windows.Forms.Label();
			this.labelFiles = new System.Windows.Forms.Label();
			this.labelCounterFilesRenamedPercent = new System.Windows.Forms.Label();
			this.labelCounterFilesChangedPercent = new System.Windows.Forms.Label();
			this.labelCounterFilesDeletedPercent = new System.Windows.Forms.Label();
			this.labelCounterFilesCreatedPercent = new System.Windows.Forms.Label();
			this.labelCounterFilesRenamed = new System.Windows.Forms.Label();
			this.labelCounterFilesChanged = new System.Windows.Forms.Label();
			this.labelCounterFilesDeleted = new System.Windows.Forms.Label();
			this.labelCounterFilesCreated = new System.Windows.Forms.Label();
			this.checkboxHoldOnTop = new System.Windows.Forms.CheckBox();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.labelInformation = new System.Windows.Forms.ToolStripStatusLabel();
			((System.ComponentModel.ISupportInitialize)(this.FileSystemWatcher)).BeginInit();
			this.groupBoxStatistics.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// FileSystemWatcher
			// 
			this.FileSystemWatcher.EnableRaisingEvents = true;
			this.FileSystemWatcher.IncludeSubdirectories = true;
			this.FileSystemWatcher.Path = "C:\\";
			this.FileSystemWatcher.SynchronizingObject = this;
			this.FileSystemWatcher.Changed += new System.IO.FileSystemEventHandler(this.FileSystemWatcher_Changed);
			this.FileSystemWatcher.Created += new System.IO.FileSystemEventHandler(this.FileSystemWatcher_Created);
			this.FileSystemWatcher.Deleted += new System.IO.FileSystemEventHandler(this.FileSystemWatcher_Deleted);
			this.FileSystemWatcher.Renamed += new System.IO.RenamedEventHandler(this.FileSystemWatcher_Renamed);
			// 
			// SaveFileDialog
			// 
			this.SaveFileDialog.Filter = "Text-Datei|*.txt";
			// 
			// NotifyIcon
			// 
			this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
			this.NotifyIcon.Text = "Diskwatch CS";
			this.NotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
			// 
			// listviewWatch
			// 
			this.listviewWatch.AccessibleDescription = "Zeigt die Liste der behandelten Dateien an";
			this.listviewWatch.AccessibleName = "Liste der Dateien";
			this.listviewWatch.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
			this.listviewWatch.AllowColumnReorder = true;
			this.listviewWatch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listviewWatch.BackColor = System.Drawing.Color.White;
			this.listviewWatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listviewWatch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderIconState,
            this.columnHeaderTimestamp,
            this.ColumnHeaderPath});
			this.listviewWatch.HideSelection = false;
			this.listviewWatch.Location = new System.Drawing.Point(9, 114);
			this.listviewWatch.Name = "listviewWatch";
			this.listviewWatch.ShowItemToolTips = true;
			this.listviewWatch.Size = new System.Drawing.Size(762, 294);
			this.listviewWatch.SmallImageList = this.imageList;
			this.listviewWatch.TabIndex = 7;
			this.listviewWatch.UseCompatibleStateImageBehavior = false;
			this.listviewWatch.View = System.Windows.Forms.View.Details;
			this.listviewWatch.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.listviewWatch.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.listviewWatch.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.listviewWatch.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// columnHeaderIconState
			// 
			this.columnHeaderIconState.Text = "";
			this.columnHeaderIconState.Width = 20;
			// 
			// columnHeaderTimestamp
			// 
			this.columnHeaderTimestamp.Text = "Zeitstempel";
			this.columnHeaderTimestamp.Width = 150;
			// 
			// ColumnHeaderPath
			// 
			this.ColumnHeaderPath.Text = "Pfad";
			this.ColumnHeaderPath.Width = 500;
			// 
			// imageList
			// 
			this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
			this.imageList.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList.Images.SetKeyName(0, "add.png");
			this.imageList.Images.SetKeyName(1, "delete.png");
			this.imageList.Images.SetKeyName(2, "pencil.png");
			this.imageList.Images.SetKeyName(3, "textfield_rename.png");
			// 
			// buttonSaveList
			// 
			this.buttonSaveList.AccessibleDescription = "Speichert die Protokollierungstabelle in eine Textdatei";
			this.buttonSaveList.AccessibleName = "Liste speichern";
			this.buttonSaveList.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonSaveList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSaveList.Location = new System.Drawing.Point(576, 414);
			this.buttonSaveList.Name = "buttonSaveList";
			this.buttonSaveList.Size = new System.Drawing.Size(95, 23);
			this.buttonSaveList.TabIndex = 12;
			this.buttonSaveList.Text = "Liste speichern";
			this.toolTip.SetToolTip(this.buttonSaveList, "Speichert die Protokollierungstabelle in eine Textdatei");
			this.buttonSaveList.UseVisualStyleBackColor = true;
			this.buttonSaveList.Click += new System.EventHandler(this.ButtonSaveList_Click);
			this.buttonSaveList.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSaveList.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonSaveList.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSaveList.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonDeleteList
			// 
			this.buttonDeleteList.AccessibleDescription = "Löscht den Inhalt der Protokollierungstabelle";
			this.buttonDeleteList.AccessibleName = "Liste löschen";
			this.buttonDeleteList.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonDeleteList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonDeleteList.Location = new System.Drawing.Point(678, 414);
			this.buttonDeleteList.Name = "buttonDeleteList";
			this.buttonDeleteList.Size = new System.Drawing.Size(95, 23);
			this.buttonDeleteList.TabIndex = 13;
			this.buttonDeleteList.Text = "Liste löschen";
			this.toolTip.SetToolTip(this.buttonDeleteList, "Löscht den Inhalt der Protokollierungstabelle");
			this.buttonDeleteList.UseVisualStyleBackColor = true;
			this.buttonDeleteList.Click += new System.EventHandler(this.ButtonDeleteList_Click);
			this.buttonDeleteList.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonDeleteList.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonDeleteList.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonDeleteList.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// textboxPath
			// 
			this.textboxPath.AccessibleDescription = "Gibt den Pfad des zu überwachenden Verzeichnisses zurück";
			this.textboxPath.AccessibleName = "Pfad des zu überwachenden Verzeichnisses";
			this.textboxPath.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.textboxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textboxPath.Location = new System.Drawing.Point(166, 88);
			this.textboxPath.Name = "textboxPath";
			this.textboxPath.ReadOnly = true;
			this.textboxPath.Size = new System.Drawing.Size(606, 20);
			this.textboxPath.TabIndex = 6;
			this.toolTip.SetToolTip(this.textboxPath, "Gibt den Pfad des zu überwachenden Verzeichnisses zurück");
			this.textboxPath.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.textboxPath.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.textboxPath.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.textboxPath.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// checkboxMinimizeToSystemtray
			// 
			this.checkboxMinimizeToSystemtray.AccessibleDescription = "Minimiert das Programm in den Systemtray, wenn das Feld ausgewählt wurde";
			this.checkboxMinimizeToSystemtray.AccessibleName = "In den Systemtray minimieren";
			this.checkboxMinimizeToSystemtray.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
			this.checkboxMinimizeToSystemtray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.checkboxMinimizeToSystemtray.AutoSize = true;
			this.checkboxMinimizeToSystemtray.Checked = true;
			this.checkboxMinimizeToSystemtray.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkboxMinimizeToSystemtray.Location = new System.Drawing.Point(204, 414);
			this.checkboxMinimizeToSystemtray.Name = "checkboxMinimizeToSystemtray";
			this.checkboxMinimizeToSystemtray.Size = new System.Drawing.Size(162, 17);
			this.checkboxMinimizeToSystemtray.TabIndex = 9;
			this.checkboxMinimizeToSystemtray.Text = "In den Systemtray minimieren";
			this.toolTip.SetToolTip(this.checkboxMinimizeToSystemtray, "Minimiert das Programm in den Systemtray, wenn das Feld ausgewählt wurde");
			this.checkboxMinimizeToSystemtray.UseVisualStyleBackColor = true;
			this.checkboxMinimizeToSystemtray.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.checkboxMinimizeToSystemtray.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.checkboxMinimizeToSystemtray.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.checkboxMinimizeToSystemtray.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonCopyToClipboard
			// 
			this.buttonCopyToClipboard.AccessibleDescription = "Kopiert die Protokollierungstabelle in die Windows-Zwschenablage";
			this.buttonCopyToClipboard.AccessibleName = "In die Zwischenablage kopieren";
			this.buttonCopyToClipboard.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonCopyToClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCopyToClipboard.Location = new System.Drawing.Point(399, 414);
			this.buttonCopyToClipboard.Name = "buttonCopyToClipboard";
			this.buttonCopyToClipboard.Size = new System.Drawing.Size(171, 23);
			this.buttonCopyToClipboard.TabIndex = 11;
			this.buttonCopyToClipboard.Text = "In die Zwischenablage kopieren";
			this.toolTip.SetToolTip(this.buttonCopyToClipboard, "Kopiert die Protokollierungstabelle in die Windows-Zwschenablage");
			this.buttonCopyToClipboard.UseVisualStyleBackColor = true;
			this.buttonCopyToClipboard.Click += new System.EventHandler(this.ButtonCopyToClipboard_Click);
			this.buttonCopyToClipboard.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonCopyToClipboard.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonCopyToClipboard.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonCopyToClipboard.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonShowInfos
			// 
			this.buttonShowInfos.AccessibleDescription = "Gibt Hinweise zum Programm aus";
			this.buttonShowInfos.AccessibleName = "Hinweise zum Programm";
			this.buttonShowInfos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonShowInfos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonShowInfos.Location = new System.Drawing.Point(10, 414);
			this.buttonShowInfos.Name = "buttonShowInfos";
			this.buttonShowInfos.Size = new System.Drawing.Size(75, 23);
			this.buttonShowInfos.TabIndex = 8;
			this.buttonShowInfos.Text = "Infos";
			this.toolTip.SetToolTip(this.buttonShowInfos, "Gibt Hinweise zum Programm aus");
			this.buttonShowInfos.UseVisualStyleBackColor = true;
			this.buttonShowInfos.Click += new System.EventHandler(this.ButtonShowInfos_Click);
			this.buttonShowInfos.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonShowInfos.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonShowInfos.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonShowInfos.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonOpenFolder
			// 
			this.buttonOpenFolder.AccessibleDescription = "Wählt einen spezifischen Ordner zur Überwachung aus";
			this.buttonOpenFolder.AccessibleName = "Verzeichnis wählen";
			this.buttonOpenFolder.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonOpenFolder.Image = global::DiskWatchCS.Properties.Resources.folder_vertical_open_32;
			this.buttonOpenFolder.Location = new System.Drawing.Point(85, 12);
			this.buttonOpenFolder.Name = "buttonOpenFolder";
			this.buttonOpenFolder.Size = new System.Drawing.Size(70, 70);
			this.buttonOpenFolder.TabIndex = 1;
			this.buttonOpenFolder.Text = "&Verzeichnis";
			this.buttonOpenFolder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.buttonOpenFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.toolTip.SetToolTip(this.buttonOpenFolder, "Wählt einen spezifischen Ordner zur Überwachung aus");
			this.buttonOpenFolder.UseVisualStyleBackColor = true;
			this.buttonOpenFolder.Click += new System.EventHandler(this.ButtonOpenFolder_Click);
			this.buttonOpenFolder.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonOpenFolder.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonOpenFolder.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonOpenFolder.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonDriveC
			// 
			this.buttonDriveC.AccessibleDescription = "Wählt die Festplatte C:\\ zur Überwachung aus";
			this.buttonDriveC.AccessibleName = "Festplatte auswählen";
			this.buttonDriveC.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonDriveC.Image = global::DiskWatchCS.Properties.Resources.drive_32;
			this.buttonDriveC.Location = new System.Drawing.Point(9, 12);
			this.buttonDriveC.Name = "buttonDriveC";
			this.buttonDriveC.Size = new System.Drawing.Size(70, 70);
			this.buttonDriveC.TabIndex = 0;
			this.buttonDriveC.Text = "&C:\\";
			this.buttonDriveC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.buttonDriveC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.toolTip.SetToolTip(this.buttonDriveC, "Wählt die Festplatte C:\\ zur Überwachung aus");
			this.buttonDriveC.UseVisualStyleBackColor = true;
			this.buttonDriveC.Click += new System.EventHandler(this.ButtonDriveC_Click);
			this.buttonDriveC.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonDriveC.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonDriveC.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonDriveC.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonStop
			// 
			this.buttonStop.AccessibleDescription = "Stoppt die Überwachung";
			this.buttonStop.AccessibleName = "Überwachung stoppen";
			this.buttonStop.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonStop.Image = global::DiskWatchCS.Properties.Resources.control_stop_blue_32;
			this.buttonStop.Location = new System.Drawing.Point(702, 12);
			this.buttonStop.Name = "buttonStop";
			this.buttonStop.Size = new System.Drawing.Size(70, 70);
			this.buttonStop.TabIndex = 4;
			this.buttonStop.Text = "Sto&p";
			this.buttonStop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.buttonStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.toolTip.SetToolTip(this.buttonStop, "Stoppt die Überwachung");
			this.buttonStop.UseVisualStyleBackColor = true;
			this.buttonStop.Click += new System.EventHandler(this.ButtonStop_Click);
			this.buttonStop.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonStop.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonStop.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonStop.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonStart
			// 
			this.buttonStart.AccessibleDescription = "Startet die Überwachung";
			this.buttonStart.AccessibleName = "Überwachung starten";
			this.buttonStart.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonStart.Image = global::DiskWatchCS.Properties.Resources.control_play_blue_32;
			this.buttonStart.Location = new System.Drawing.Point(626, 12);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(70, 70);
			this.buttonStart.TabIndex = 3;
			this.buttonStart.Text = "&Start";
			this.buttonStart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.buttonStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.toolTip.SetToolTip(this.buttonStart, "Startet die Überwachung");
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
			this.buttonStart.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonStart.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonStart.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonStart.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelPath
			// 
			this.labelPath.AccessibleDescription = "Label für das zu überwachende Verzeichnis";
			this.labelPath.AccessibleName = "Label für das zu überwachende Verzeichnis";
			this.labelPath.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelPath.AutoSize = true;
			this.labelPath.BackColor = System.Drawing.Color.Transparent;
			this.labelPath.Location = new System.Drawing.Point(6, 91);
			this.labelPath.Name = "labelPath";
			this.labelPath.Size = new System.Drawing.Size(159, 13);
			this.labelPath.TabIndex = 5;
			this.labelPath.Text = "&Zu überwachendes Verzeichnis:";
			// 
			// labelFilesCreated
			// 
			this.labelFilesCreated.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelFilesCreated.AutoSize = true;
			this.labelFilesCreated.BackColor = System.Drawing.Color.Transparent;
			this.labelFilesCreated.Location = new System.Drawing.Point(6, 16);
			this.labelFilesCreated.Name = "labelFilesCreated";
			this.labelFilesCreated.Size = new System.Drawing.Size(87, 13);
			this.labelFilesCreated.TabIndex = 0;
			this.labelFilesCreated.Text = "Erstellte Dateien:";
			// 
			// labelFilesDeleted
			// 
			this.labelFilesDeleted.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelFilesDeleted.AutoSize = true;
			this.labelFilesDeleted.BackColor = System.Drawing.Color.Transparent;
			this.labelFilesDeleted.Location = new System.Drawing.Point(6, 29);
			this.labelFilesDeleted.Name = "labelFilesDeleted";
			this.labelFilesDeleted.Size = new System.Drawing.Size(98, 13);
			this.labelFilesDeleted.TabIndex = 3;
			this.labelFilesDeleted.Text = "Gelöschte Dateien:";
			// 
			// labelFilesChanged
			// 
			this.labelFilesChanged.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelFilesChanged.AutoSize = true;
			this.labelFilesChanged.BackColor = System.Drawing.Color.Transparent;
			this.labelFilesChanged.Location = new System.Drawing.Point(6, 42);
			this.labelFilesChanged.Name = "labelFilesChanged";
			this.labelFilesChanged.Size = new System.Drawing.Size(102, 13);
			this.labelFilesChanged.TabIndex = 6;
			this.labelFilesChanged.Text = "Veränderte Dateien:";
			// 
			// labelFilesRenamed
			// 
			this.labelFilesRenamed.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelFilesRenamed.AutoSize = true;
			this.labelFilesRenamed.BackColor = System.Drawing.Color.Transparent;
			this.labelFilesRenamed.Location = new System.Drawing.Point(6, 55);
			this.labelFilesRenamed.Name = "labelFilesRenamed";
			this.labelFilesRenamed.Size = new System.Drawing.Size(111, 13);
			this.labelFilesRenamed.TabIndex = 9;
			this.labelFilesRenamed.Text = "Umbenannte Dateien:";
			// 
			// groupBoxStatistics
			// 
			this.groupBoxStatistics.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.groupBoxStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxStatistics.Controls.Add(this.labelTimeEndMeasured);
			this.groupBoxStatistics.Controls.Add(this.labelRuntimeMeasured);
			this.groupBoxStatistics.Controls.Add(this.labelTimeBeginMeasured);
			this.groupBoxStatistics.Controls.Add(this.labelCounterFiles);
			this.groupBoxStatistics.Controls.Add(this.labelRuntime);
			this.groupBoxStatistics.Controls.Add(this.labelTimeEnd);
			this.groupBoxStatistics.Controls.Add(this.labelTimeBegin);
			this.groupBoxStatistics.Controls.Add(this.labelFiles);
			this.groupBoxStatistics.Controls.Add(this.labelCounterFilesRenamedPercent);
			this.groupBoxStatistics.Controls.Add(this.labelCounterFilesChangedPercent);
			this.groupBoxStatistics.Controls.Add(this.labelCounterFilesDeletedPercent);
			this.groupBoxStatistics.Controls.Add(this.labelCounterFilesCreatedPercent);
			this.groupBoxStatistics.Controls.Add(this.labelCounterFilesRenamed);
			this.groupBoxStatistics.Controls.Add(this.labelCounterFilesChanged);
			this.groupBoxStatistics.Controls.Add(this.labelCounterFilesDeleted);
			this.groupBoxStatistics.Controls.Add(this.labelCounterFilesCreated);
			this.groupBoxStatistics.Controls.Add(this.labelFilesCreated);
			this.groupBoxStatistics.Controls.Add(this.labelFilesRenamed);
			this.groupBoxStatistics.Controls.Add(this.labelFilesDeleted);
			this.groupBoxStatistics.Controls.Add(this.labelFilesChanged);
			this.groupBoxStatistics.Location = new System.Drawing.Point(161, 12);
			this.groupBoxStatistics.Name = "groupBoxStatistics";
			this.groupBoxStatistics.Size = new System.Drawing.Size(459, 70);
			this.groupBoxStatistics.TabIndex = 2;
			this.groupBoxStatistics.TabStop = false;
			this.groupBoxStatistics.Text = "Statistik der Dateioperationen";
			// 
			// labelTimeEndMeasured
			// 
			this.labelTimeEndMeasured.AccessibleDescription = "Zeigt den Zeitpunkt des Überwachungsende an";
			this.labelTimeEndMeasured.AccessibleName = "Ende der Überwachung";
			this.labelTimeEndMeasured.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelTimeEndMeasured.AutoSize = true;
			this.labelTimeEndMeasured.BackColor = System.Drawing.Color.Transparent;
			this.labelTimeEndMeasured.Location = new System.Drawing.Point(372, 55);
			this.labelTimeEndMeasured.Name = "labelTimeEndMeasured";
			this.labelTimeEndMeasured.Size = new System.Drawing.Size(62, 13);
			this.labelTimeEndMeasured.TabIndex = 19;
			this.labelTimeEndMeasured.Text = "00h00m00s";
			this.toolTip.SetToolTip(this.labelTimeEndMeasured, "Zeigt den Zeitpunkt des Überwachungsende an");
			this.labelTimeEndMeasured.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelTimeEndMeasured.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelTimeEndMeasured.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelTimeEndMeasured.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelRuntimeMeasured
			// 
			this.labelRuntimeMeasured.AccessibleDescription = "Zeigt die aktuelle Dauer der Überwachung an";
			this.labelRuntimeMeasured.AccessibleName = "Aktuelle Laufzeit";
			this.labelRuntimeMeasured.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelRuntimeMeasured.AutoSize = true;
			this.labelRuntimeMeasured.BackColor = System.Drawing.Color.Transparent;
			this.labelRuntimeMeasured.Location = new System.Drawing.Point(372, 42);
			this.labelRuntimeMeasured.Name = "labelRuntimeMeasured";
			this.labelRuntimeMeasured.Size = new System.Drawing.Size(62, 13);
			this.labelRuntimeMeasured.TabIndex = 17;
			this.labelRuntimeMeasured.Text = "00h00m00s";
			this.toolTip.SetToolTip(this.labelRuntimeMeasured, "Zeigt die aktuelle Dauer der Überwachung an");
			this.labelRuntimeMeasured.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelRuntimeMeasured.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelRuntimeMeasured.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelRuntimeMeasured.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelTimeBeginMeasured
			// 
			this.labelTimeBeginMeasured.AccessibleDescription = "Zeigt den Zeitpunkt des Überwachungsbeginn an";
			this.labelTimeBeginMeasured.AccessibleName = "Beginn der Überwachung";
			this.labelTimeBeginMeasured.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelTimeBeginMeasured.AutoSize = true;
			this.labelTimeBeginMeasured.BackColor = System.Drawing.Color.Transparent;
			this.labelTimeBeginMeasured.Location = new System.Drawing.Point(372, 29);
			this.labelTimeBeginMeasured.Name = "labelTimeBeginMeasured";
			this.labelTimeBeginMeasured.Size = new System.Drawing.Size(62, 13);
			this.labelTimeBeginMeasured.TabIndex = 15;
			this.labelTimeBeginMeasured.Text = "00h00m00s";
			this.toolTip.SetToolTip(this.labelTimeBeginMeasured, "Zeigt den Zeitpunkt des Überwachungsbeginn an");
			this.labelTimeBeginMeasured.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelTimeBeginMeasured.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelTimeBeginMeasured.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelTimeBeginMeasured.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelCounterFiles
			// 
			this.labelCounterFiles.AccessibleDescription = "Zeigt die Anzahl der Dateien an, die während der Überwachung behandelt worden sin" +
    "d";
			this.labelCounterFiles.AccessibleName = "Anzahl der Dateien";
			this.labelCounterFiles.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelCounterFiles.AutoSize = true;
			this.labelCounterFiles.BackColor = System.Drawing.Color.Transparent;
			this.labelCounterFiles.Location = new System.Drawing.Point(372, 16);
			this.labelCounterFiles.Name = "labelCounterFiles";
			this.labelCounterFiles.Size = new System.Drawing.Size(55, 13);
			this.labelCounterFiles.TabIndex = 13;
			this.labelCounterFiles.Text = "00000000";
			this.toolTip.SetToolTip(this.labelCounterFiles, "Zeigt die Anzahl der Dateien an, die während der Überwachung behandelt worden sin" +
        "d");
			this.labelCounterFiles.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelCounterFiles.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelCounterFiles.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelCounterFiles.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelRuntime
			// 
			this.labelRuntime.AccessibleDescription = "Label für aktuelle Laufzeit";
			this.labelRuntime.AccessibleName = "Label für aktuelle Laufzeit";
			this.labelRuntime.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelRuntime.AutoSize = true;
			this.labelRuntime.BackColor = System.Drawing.Color.Transparent;
			this.labelRuntime.Location = new System.Drawing.Point(235, 42);
			this.labelRuntime.Name = "labelRuntime";
			this.labelRuntime.Size = new System.Drawing.Size(88, 13);
			this.labelRuntime.TabIndex = 16;
			this.labelRuntime.Text = "Aktuelle Laufzeit:";
			// 
			// labelTimeEnd
			// 
			this.labelTimeEnd.AccessibleDescription = "Label für Ende der Überwachung";
			this.labelTimeEnd.AccessibleName = "Label für Ende der Überwachung";
			this.labelTimeEnd.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelTimeEnd.AutoSize = true;
			this.labelTimeEnd.BackColor = System.Drawing.Color.Transparent;
			this.labelTimeEnd.Location = new System.Drawing.Point(235, 55);
			this.labelTimeEnd.Name = "labelTimeEnd";
			this.labelTimeEnd.Size = new System.Drawing.Size(123, 13);
			this.labelTimeEnd.TabIndex = 18;
			this.labelTimeEnd.Text = "Ende der Überwachung:";
			// 
			// labelTimeBegin
			// 
			this.labelTimeBegin.AccessibleDescription = "Label für den Beginn der Überwachung";
			this.labelTimeBegin.AccessibleName = "Label für den Beginn der Überwachung";
			this.labelTimeBegin.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelTimeBegin.AutoSize = true;
			this.labelTimeBegin.BackColor = System.Drawing.Color.Transparent;
			this.labelTimeBegin.Location = new System.Drawing.Point(235, 29);
			this.labelTimeBegin.Name = "labelTimeBegin";
			this.labelTimeBegin.Size = new System.Drawing.Size(131, 13);
			this.labelTimeBegin.TabIndex = 14;
			this.labelTimeBegin.Text = "Beginn der Überwachung:";
			// 
			// labelFiles
			// 
			this.labelFiles.AccessibleDescription = "Label für Anzahl der Dateien";
			this.labelFiles.AccessibleName = "Label für Anzahl der Dateien";
			this.labelFiles.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelFiles.AutoSize = true;
			this.labelFiles.BackColor = System.Drawing.Color.Transparent;
			this.labelFiles.Location = new System.Drawing.Point(235, 16);
			this.labelFiles.Name = "labelFiles";
			this.labelFiles.Size = new System.Drawing.Size(100, 13);
			this.labelFiles.TabIndex = 12;
			this.labelFiles.Text = "Anzahl der Dateien:";
			// 
			// labelCounterFilesRenamedPercent
			// 
			this.labelCounterFilesRenamedPercent.AccessibleDescription = "Zeigt den Prozentsatz der umbenannten Dateien im Verhältnis aller behandelten Dat" +
    "eien an";
			this.labelCounterFilesRenamedPercent.AccessibleName = "Prozentzahl der umbenannten Dateien";
			this.labelCounterFilesRenamedPercent.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelCounterFilesRenamedPercent.AutoSize = true;
			this.labelCounterFilesRenamedPercent.BackColor = System.Drawing.Color.Transparent;
			this.labelCounterFilesRenamedPercent.Location = new System.Drawing.Point(175, 55);
			this.labelCounterFilesRenamedPercent.Name = "labelCounterFilesRenamedPercent";
			this.labelCounterFilesRenamedPercent.Size = new System.Drawing.Size(54, 13);
			this.labelCounterFilesRenamedPercent.TabIndex = 11;
			this.labelCounterFilesRenamedPercent.Text = "00.0000%";
			this.toolTip.SetToolTip(this.labelCounterFilesRenamedPercent, "Zeigt den Prozentsatz der umbenannten Dateien im Verhältnis aller behandelten Dat" +
        "eien an");
			this.labelCounterFilesRenamedPercent.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelCounterFilesRenamedPercent.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelCounterFilesRenamedPercent.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelCounterFilesRenamedPercent.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelCounterFilesChangedPercent
			// 
			this.labelCounterFilesChangedPercent.AccessibleDescription = "Zeigt den Prozentsatz der veränderten Dateien im Verhältnis aller behandelten Dat" +
    "eien an";
			this.labelCounterFilesChangedPercent.AccessibleName = "Prozentsatz der veränderten Dateien";
			this.labelCounterFilesChangedPercent.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelCounterFilesChangedPercent.AutoSize = true;
			this.labelCounterFilesChangedPercent.BackColor = System.Drawing.Color.Transparent;
			this.labelCounterFilesChangedPercent.Location = new System.Drawing.Point(175, 42);
			this.labelCounterFilesChangedPercent.Name = "labelCounterFilesChangedPercent";
			this.labelCounterFilesChangedPercent.Size = new System.Drawing.Size(54, 13);
			this.labelCounterFilesChangedPercent.TabIndex = 8;
			this.labelCounterFilesChangedPercent.Text = "00.0000%";
			this.toolTip.SetToolTip(this.labelCounterFilesChangedPercent, "Zeigt den Prozentsatz der veränderten Dateien im Verhältnis aller behandelten Dat" +
        "eien an");
			this.labelCounterFilesChangedPercent.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelCounterFilesChangedPercent.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelCounterFilesChangedPercent.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelCounterFilesChangedPercent.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelCounterFilesDeletedPercent
			// 
			this.labelCounterFilesDeletedPercent.AccessibleDescription = "Zeigt den Prozentsatz der gelöschten Dateien im Verhältnis aller behandelten Date" +
    "ien an";
			this.labelCounterFilesDeletedPercent.AccessibleName = "Prozentsatz der gelöschten Dateien";
			this.labelCounterFilesDeletedPercent.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelCounterFilesDeletedPercent.AutoSize = true;
			this.labelCounterFilesDeletedPercent.BackColor = System.Drawing.Color.Transparent;
			this.labelCounterFilesDeletedPercent.Location = new System.Drawing.Point(175, 29);
			this.labelCounterFilesDeletedPercent.Name = "labelCounterFilesDeletedPercent";
			this.labelCounterFilesDeletedPercent.Size = new System.Drawing.Size(54, 13);
			this.labelCounterFilesDeletedPercent.TabIndex = 5;
			this.labelCounterFilesDeletedPercent.Text = "00.0000%";
			this.toolTip.SetToolTip(this.labelCounterFilesDeletedPercent, "Zeigt den Prozentsatz der gelöschten Dateien im Verhältnis aller behandelten Date" +
        "ien an");
			this.labelCounterFilesDeletedPercent.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelCounterFilesDeletedPercent.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelCounterFilesDeletedPercent.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelCounterFilesDeletedPercent.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelCounterFilesCreatedPercent
			// 
			this.labelCounterFilesCreatedPercent.AccessibleDescription = "Zeigt den Prozentsatz der erstellten Dateien im Verhältnis aller behandelten Date" +
    "ien an";
			this.labelCounterFilesCreatedPercent.AccessibleName = "Prozentsatz der erstellten Dateien";
			this.labelCounterFilesCreatedPercent.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelCounterFilesCreatedPercent.AutoSize = true;
			this.labelCounterFilesCreatedPercent.BackColor = System.Drawing.Color.Transparent;
			this.labelCounterFilesCreatedPercent.Location = new System.Drawing.Point(175, 16);
			this.labelCounterFilesCreatedPercent.Name = "labelCounterFilesCreatedPercent";
			this.labelCounterFilesCreatedPercent.Size = new System.Drawing.Size(54, 13);
			this.labelCounterFilesCreatedPercent.TabIndex = 2;
			this.labelCounterFilesCreatedPercent.Text = "00.0000%";
			this.toolTip.SetToolTip(this.labelCounterFilesCreatedPercent, "Zeigt den Prozentsatz der erstellten Dateien im Verhältnis aller behandelten Date" +
        "ien an");
			this.labelCounterFilesCreatedPercent.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelCounterFilesCreatedPercent.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelCounterFilesCreatedPercent.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelCounterFilesCreatedPercent.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelCounterFilesRenamed
			// 
			this.labelCounterFilesRenamed.AccessibleDescription = "Zeigt die Anzahl der Dateien an, die während der Überwachung umbenannt worden sin" +
    "d";
			this.labelCounterFilesRenamed.AccessibleName = "Anzahl der umbenannten Dateien";
			this.labelCounterFilesRenamed.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelCounterFilesRenamed.AutoSize = true;
			this.labelCounterFilesRenamed.BackColor = System.Drawing.Color.Transparent;
			this.labelCounterFilesRenamed.Location = new System.Drawing.Point(126, 55);
			this.labelCounterFilesRenamed.Name = "labelCounterFilesRenamed";
			this.labelCounterFilesRenamed.Size = new System.Drawing.Size(43, 13);
			this.labelCounterFilesRenamed.TabIndex = 10;
			this.labelCounterFilesRenamed.Text = "000000";
			this.toolTip.SetToolTip(this.labelCounterFilesRenamed, "Zeigt die Anzahl der Dateien an, die während der Überwachung umbenannt worden sin" +
        "d");
			this.labelCounterFilesRenamed.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelCounterFilesRenamed.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelCounterFilesRenamed.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelCounterFilesRenamed.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelCounterFilesChanged
			// 
			this.labelCounterFilesChanged.AccessibleDescription = "Zeigt die Anzahl der Dateien an, die während der Überwachung verändert worden sin" +
    "d";
			this.labelCounterFilesChanged.AccessibleName = "Anzahl der veränderten Dateien";
			this.labelCounterFilesChanged.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelCounterFilesChanged.AutoSize = true;
			this.labelCounterFilesChanged.BackColor = System.Drawing.Color.Transparent;
			this.labelCounterFilesChanged.Location = new System.Drawing.Point(126, 42);
			this.labelCounterFilesChanged.Name = "labelCounterFilesChanged";
			this.labelCounterFilesChanged.Size = new System.Drawing.Size(43, 13);
			this.labelCounterFilesChanged.TabIndex = 7;
			this.labelCounterFilesChanged.Text = "000000";
			this.toolTip.SetToolTip(this.labelCounterFilesChanged, "Zeigt die Anzahl der Dateien an, die während der Überwachung verändert worden sin" +
        "d");
			this.labelCounterFilesChanged.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelCounterFilesChanged.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelCounterFilesChanged.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelCounterFilesChanged.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelCounterFilesDeleted
			// 
			this.labelCounterFilesDeleted.AccessibleDescription = "Zeigt die Anzahl der Dateien an, die während der Überwachung gelöscht worden sind" +
    "";
			this.labelCounterFilesDeleted.AccessibleName = "Anzahl der gelöschten Dateien";
			this.labelCounterFilesDeleted.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelCounterFilesDeleted.AutoSize = true;
			this.labelCounterFilesDeleted.BackColor = System.Drawing.Color.Transparent;
			this.labelCounterFilesDeleted.Location = new System.Drawing.Point(126, 29);
			this.labelCounterFilesDeleted.Name = "labelCounterFilesDeleted";
			this.labelCounterFilesDeleted.Size = new System.Drawing.Size(43, 13);
			this.labelCounterFilesDeleted.TabIndex = 4;
			this.labelCounterFilesDeleted.Text = "000000";
			this.toolTip.SetToolTip(this.labelCounterFilesDeleted, "Zeigt die Anzahl der Dateien an, die während der Überwachung gelöscht worden sind" +
        "");
			this.labelCounterFilesDeleted.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelCounterFilesDeleted.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelCounterFilesDeleted.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelCounterFilesDeleted.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelCounterFilesCreated
			// 
			this.labelCounterFilesCreated.AccessibleDescription = "Zeigt die Anzahl der Dateien an, die während der Überwachung erstellt worden sind" +
    "";
			this.labelCounterFilesCreated.AccessibleName = "Anzahl de Dateien";
			this.labelCounterFilesCreated.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelCounterFilesCreated.AutoSize = true;
			this.labelCounterFilesCreated.BackColor = System.Drawing.Color.Transparent;
			this.labelCounterFilesCreated.Location = new System.Drawing.Point(126, 16);
			this.labelCounterFilesCreated.Name = "labelCounterFilesCreated";
			this.labelCounterFilesCreated.Size = new System.Drawing.Size(43, 13);
			this.labelCounterFilesCreated.TabIndex = 1;
			this.labelCounterFilesCreated.Text = "000000";
			this.toolTip.SetToolTip(this.labelCounterFilesCreated, "Zeigt die Anzahl der Dateien an, die während der Überwachung erstellt worden sind" +
        "");
			this.labelCounterFilesCreated.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelCounterFilesCreated.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelCounterFilesCreated.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelCounterFilesCreated.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// checkboxHoldOnTop
			// 
			this.checkboxHoldOnTop.AccessibleDescription = "Hält das Programm in den Vordergrund, wenn das Feld ausgewählt wurde";
			this.checkboxHoldOnTop.AccessibleName = "Fenster in den Vordergrund halten";
			this.checkboxHoldOnTop.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
			this.checkboxHoldOnTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.checkboxHoldOnTop.AutoSize = true;
			this.checkboxHoldOnTop.Checked = true;
			this.checkboxHoldOnTop.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkboxHoldOnTop.Location = new System.Drawing.Point(204, 429);
			this.checkboxHoldOnTop.Name = "checkboxHoldOnTop";
			this.checkboxHoldOnTop.Size = new System.Drawing.Size(186, 17);
			this.checkboxHoldOnTop.TabIndex = 10;
			this.checkboxHoldOnTop.Text = "Fenster in den Vordergrund halten";
			this.toolTip.SetToolTip(this.checkboxHoldOnTop, "Hält das Programm in den Vordergrund, wenn das Feld ausgewählt wurde");
			this.checkboxHoldOnTop.UseVisualStyleBackColor = true;
			this.checkboxHoldOnTop.CheckedChanged += new System.EventHandler(this.CheckboxHoldOnTop_CheckedChanged);
			this.checkboxHoldOnTop.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.checkboxHoldOnTop.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.checkboxHoldOnTop.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.checkboxHoldOnTop.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// timer
			// 
			this.timer.Tick += new System.EventHandler(this.Timer_Tick);
			// 
			// toolTip
			// 
			this.toolTip.IsBalloon = true;
			this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.toolTip.ToolTipTitle = "Hinweis";
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelInformation});
			this.statusStrip.Location = new System.Drawing.Point(0, 449);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.ShowItemToolTips = true;
			this.statusStrip.Size = new System.Drawing.Size(784, 22);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 14;
			this.statusStrip.TabStop = true;
			this.statusStrip.Text = "Informationstext";
			// 
			// labelInformation
			// 
			this.labelInformation.AutoToolTip = true;
			this.labelInformation.Name = "labelInformation";
			this.labelInformation.Size = new System.Drawing.Size(95, 17);
			this.labelInformation.Text = "Informationstext";
			// 
			// Form
			// 
			this.AccessibleDescription = "Fenster der Anwendung";
			this.AccessibleName = "Fenster der Anwendung";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 471);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.checkboxHoldOnTop);
			this.Controls.Add(this.groupBoxStatistics);
			this.Controls.Add(this.labelPath);
			this.Controls.Add(this.buttonStart);
			this.Controls.Add(this.buttonStop);
			this.Controls.Add(this.buttonDriveC);
			this.Controls.Add(this.buttonShowInfos);
			this.Controls.Add(this.buttonCopyToClipboard);
			this.Controls.Add(this.buttonOpenFolder);
			this.Controls.Add(this.listviewWatch);
			this.Controls.Add(this.buttonSaveList);
			this.Controls.Add(this.buttonDeleteList);
			this.Controls.Add(this.textboxPath);
			this.Controls.Add(this.checkboxMinimizeToSystemtray);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(800, 510);
			this.Name = "Form";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DiskWatch CS";
			this.Load += new System.EventHandler(this.Form_Load);
			this.SizeChanged += new System.EventHandler(this.Form_SizeChanged);
			((System.ComponentModel.ISupportInitialize)(this.FileSystemWatcher)).EndInit();
			this.groupBoxStatistics.ResumeLayout(false);
			this.groupBoxStatistics.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    internal System.IO.FileSystemWatcher FileSystemWatcher;
    internal System.Windows.Forms.Button buttonOpenFolder;
    internal System.Windows.Forms.ListView listviewWatch;
    internal System.Windows.Forms.Button buttonSaveList;
    internal System.Windows.Forms.Button buttonDeleteList;
    internal System.Windows.Forms.TextBox textboxPath;
    internal System.Windows.Forms.CheckBox checkboxMinimizeToSystemtray;
    internal System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
    internal System.Windows.Forms.SaveFileDialog SaveFileDialog;
    internal System.Windows.Forms.NotifyIcon NotifyIcon;
    private System.Windows.Forms.Button buttonCopyToClipboard;
    private System.Windows.Forms.Button buttonShowInfos;
    private System.Windows.Forms.ColumnHeader columnHeaderTimestamp;
    private System.Windows.Forms.ColumnHeader ColumnHeaderPath;
    private System.Windows.Forms.ColumnHeader columnHeaderIconState;
    internal System.Windows.Forms.Button buttonDriveC;
    internal System.Windows.Forms.Button buttonStart;
    internal System.Windows.Forms.Button buttonStop;
    private System.Windows.Forms.Label labelPath;
    private System.Windows.Forms.GroupBox groupBoxStatistics;
    private System.Windows.Forms.Label labelCounterFilesCreated;
    private System.Windows.Forms.Label labelFilesCreated;
    private System.Windows.Forms.Label labelFilesRenamed;
    private System.Windows.Forms.Label labelFilesDeleted;
    private System.Windows.Forms.Label labelFilesChanged;
    private System.Windows.Forms.Label labelCounterFilesRenamed;
    private System.Windows.Forms.Label labelCounterFilesChanged;
    private System.Windows.Forms.Label labelCounterFilesDeleted;
    private System.Windows.Forms.Label labelCounterFilesRenamedPercent;
    private System.Windows.Forms.Label labelCounterFilesChangedPercent;
    private System.Windows.Forms.Label labelCounterFilesDeletedPercent;
    private System.Windows.Forms.Label labelCounterFilesCreatedPercent;
    private System.Windows.Forms.Label labelFiles;
    private System.Windows.Forms.Label labelTimeBegin;
    private System.Windows.Forms.Label labelTimeEndMeasured;
    private System.Windows.Forms.Label labelRuntimeMeasured;
    private System.Windows.Forms.Label labelTimeBeginMeasured;
    private System.Windows.Forms.Label labelCounterFiles;
    private System.Windows.Forms.Label labelRuntime;
    private System.Windows.Forms.Label labelTimeEnd;
    internal System.Windows.Forms.CheckBox checkboxHoldOnTop;
    private System.Windows.Forms.Timer timer;
    private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.ImageList imageList;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel labelInformation;
	}
}

