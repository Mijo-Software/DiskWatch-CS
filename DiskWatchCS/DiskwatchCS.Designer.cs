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
      this.buttonOpenFolder = new System.Windows.Forms.Button();
      this.listviewWatch = new System.Windows.Forms.ListView();
      this.ColumnHeaderPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.buttonSaveList = new System.Windows.Forms.Button();
      this.buttonDeleteList = new System.Windows.Forms.Button();
      this.textboxPath = new System.Windows.Forms.TextBox();
      this.checkboxStayToSystemtray = new System.Windows.Forms.CheckBox();
      this.buttonCopyToClipboard = new System.Windows.Forms.Button();
      this.buttonShowInfos = new System.Windows.Forms.Button();
      this.buttonShowStatistics = new System.Windows.Forms.Button();
      this.columnHeaderTimestamp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeaderIconState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.imageList = new System.Windows.Forms.ImageList(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.FileSystemWatcher)).BeginInit();
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
      // buttonOpenFolder
      // 
      this.buttonOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonOpenFolder.Location = new System.Drawing.Point(667, 13);
      this.buttonOpenFolder.Name = "buttonOpenFolder";
      this.buttonOpenFolder.Size = new System.Drawing.Size(75, 23);
      this.buttonOpenFolder.TabIndex = 1;
      this.buttonOpenFolder.Text = "Verzeichnis";
      this.buttonOpenFolder.UseVisualStyleBackColor = true;
      this.buttonOpenFolder.Click += new System.EventHandler(this.buttonOpenFolder_Click);
      // 
      // listviewWatch
      // 
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
      this.listviewWatch.Location = new System.Drawing.Point(20, 41);
      this.listviewWatch.Name = "listviewWatch";
      this.listviewWatch.ShowItemToolTips = true;
      this.listviewWatch.Size = new System.Drawing.Size(722, 287);
      this.listviewWatch.SmallImageList = this.imageList;
      this.listviewWatch.TabIndex = 2;
      this.listviewWatch.UseCompatibleStateImageBehavior = false;
      this.listviewWatch.View = System.Windows.Forms.View.Details;
      // 
      // ColumnHeaderPath
      // 
      this.ColumnHeaderPath.Text = "Pfad";
      this.ColumnHeaderPath.Width = 500;
      // 
      // buttonSaveList
      // 
      this.buttonSaveList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonSaveList.Location = new System.Drawing.Point(546, 334);
      this.buttonSaveList.Name = "buttonSaveList";
      this.buttonSaveList.Size = new System.Drawing.Size(95, 23);
      this.buttonSaveList.TabIndex = 7;
      this.buttonSaveList.Text = "Liste speichern";
      this.buttonSaveList.UseVisualStyleBackColor = true;
      this.buttonSaveList.Click += new System.EventHandler(this.buttonSaveList_Click);
      // 
      // buttonDeleteList
      // 
      this.buttonDeleteList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonDeleteList.Location = new System.Drawing.Point(647, 334);
      this.buttonDeleteList.Name = "buttonDeleteList";
      this.buttonDeleteList.Size = new System.Drawing.Size(95, 23);
      this.buttonDeleteList.TabIndex = 8;
      this.buttonDeleteList.Text = "Liste löschen";
      this.buttonDeleteList.UseVisualStyleBackColor = true;
      this.buttonDeleteList.Click += new System.EventHandler(this.buttonDeleteList_Click);
      // 
      // textboxPath
      // 
      this.textboxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textboxPath.Location = new System.Drawing.Point(20, 15);
      this.textboxPath.Name = "textboxPath";
      this.textboxPath.ReadOnly = true;
      this.textboxPath.Size = new System.Drawing.Size(641, 20);
      this.textboxPath.TabIndex = 0;
      // 
      // checkboxStayToSystemtray
      // 
      this.checkboxStayToSystemtray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.checkboxStayToSystemtray.AutoSize = true;
      this.checkboxStayToSystemtray.Checked = true;
      this.checkboxStayToSystemtray.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkboxStayToSystemtray.Location = new System.Drawing.Point(231, 338);
      this.checkboxStayToSystemtray.Name = "checkboxStayToSystemtray";
      this.checkboxStayToSystemtray.Size = new System.Drawing.Size(132, 17);
      this.checkboxStayToSystemtray.TabIndex = 5;
      this.checkboxStayToSystemtray.Text = "Systemtray Information";
      this.checkboxStayToSystemtray.UseVisualStyleBackColor = true;
      // 
      // buttonCopyToClipboard
      // 
      this.buttonCopyToClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonCopyToClipboard.Location = new System.Drawing.Point(369, 334);
      this.buttonCopyToClipboard.Name = "buttonCopyToClipboard";
      this.buttonCopyToClipboard.Size = new System.Drawing.Size(171, 23);
      this.buttonCopyToClipboard.TabIndex = 6;
      this.buttonCopyToClipboard.Text = "In die Zwischenablage kopieren";
      this.buttonCopyToClipboard.UseVisualStyleBackColor = true;
      this.buttonCopyToClipboard.Click += new System.EventHandler(this.buttonCopyToClipboard_Click);
      // 
      // buttonShowInfos
      // 
      this.buttonShowInfos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.buttonShowInfos.Location = new System.Drawing.Point(20, 334);
      this.buttonShowInfos.Name = "buttonShowInfos";
      this.buttonShowInfos.Size = new System.Drawing.Size(75, 23);
      this.buttonShowInfos.TabIndex = 3;
      this.buttonShowInfos.Text = "Infos";
      this.buttonShowInfos.UseVisualStyleBackColor = true;
      this.buttonShowInfos.Click += new System.EventHandler(this.buttonShowInfos_Click);
      // 
      // buttonShowStatistics
      // 
      this.buttonShowStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.buttonShowStatistics.Location = new System.Drawing.Point(101, 334);
      this.buttonShowStatistics.Name = "buttonShowStatistics";
      this.buttonShowStatistics.Size = new System.Drawing.Size(75, 23);
      this.buttonShowStatistics.TabIndex = 4;
      this.buttonShowStatistics.Text = "Statistik";
      this.buttonShowStatistics.UseVisualStyleBackColor = true;
      this.buttonShowStatistics.Click += new System.EventHandler(this.buttonShowStatistics_Click);
      // 
      // columnHeaderTimestamp
      // 
      this.columnHeaderTimestamp.Text = "Zeitstempel";
      this.columnHeaderTimestamp.Width = 150;
      // 
      // columnHeaderIconState
      // 
      this.columnHeaderIconState.Text = "";
      this.columnHeaderIconState.Width = 20;
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
      // Form
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(762, 371);
      this.Controls.Add(this.buttonShowStatistics);
      this.Controls.Add(this.buttonShowInfos);
      this.Controls.Add(this.buttonCopyToClipboard);
      this.Controls.Add(this.buttonOpenFolder);
      this.Controls.Add(this.listviewWatch);
      this.Controls.Add(this.buttonSaveList);
      this.Controls.Add(this.buttonDeleteList);
      this.Controls.Add(this.textboxPath);
      this.Controls.Add(this.checkboxStayToSystemtray);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Form";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "DiskWatch CS";
      this.Load += new System.EventHandler(this.Form_Load);
      this.SizeChanged += new System.EventHandler(this.Form_SizeChanged);
      ((System.ComponentModel.ISupportInitialize)(this.FileSystemWatcher)).EndInit();
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
    internal System.Windows.Forms.CheckBox checkboxStayToSystemtray;
    internal System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
    internal System.Windows.Forms.SaveFileDialog SaveFileDialog;
    internal System.Windows.Forms.NotifyIcon NotifyIcon;
    private System.Windows.Forms.Button buttonCopyToClipboard;
    private System.Windows.Forms.Button buttonShowInfos;
    private System.Windows.Forms.Button buttonShowStatistics;
    private System.Windows.Forms.ColumnHeader columnHeaderTimestamp;
    private System.Windows.Forms.ColumnHeader ColumnHeaderPath;
    private System.Windows.Forms.ColumnHeader columnHeaderIconState;
    private System.Windows.Forms.ImageList imageList;
  }
}

