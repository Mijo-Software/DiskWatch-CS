using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using DiskWatchCS.Properties;

namespace DiskwatchCS
{
  /// <summary>
  /// MainForm
  /// </summary>
  public partial class Form : System.Windows.Forms.Form
  {
    private long counterFiles;
    private long counterFilesChanged;
    private long counterFilesDeleted;
    private long counterFilesCreated;
    private long counterFilesRenamed;
    private bool isStarting;
    private DateTime startMeasurements;

    /// <summary>
		/// Culture info
		/// </summary>
		private static readonly CultureInfo culture = CultureInfo.CurrentUICulture;

    /// <summary>
    /// Constructor
    /// </summary>
    public Form() => InitializeComponent();

    /// <summary>
		/// Set a specific text to the status bar
		/// </summary>
		/// <param name="text">text with some information</param>
		private void SetStatusbarText(string text) => labelInformation.Text = text;

    /// <summary>
		/// Detect the accessibility description to set as information text in the status bar
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void SetStatusbar_Enter(object sender, EventArgs e) => SetStatusbarText(text: ((Control)sender).AccessibleDescription);

    /// <summary>
    /// Clear the information text of the status bar
    /// </summary>
    /// <param name="sender">object sender</param>
    /// <param name="e">event arguments</param>
    /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
    private void ClearStatusbar_Leave(object sender, EventArgs e) => SetStatusbarText(text: string.Empty);

    /// <summary>
    /// Indicate a specific directory
    /// </summary>
    /// <param name="sender">object sender</param>
    /// <param name="e">event arguments</param>
    /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
    private void ButtonOpenFolder_Click(object sender, EventArgs e)
    {
      if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
      {
        if (Directory.Exists(path: FolderBrowserDialog.SelectedPath))
        {
          textboxPath.Text = FolderBrowserDialog.SelectedPath;
          FileSystemWatcher.Path = textboxPath.Text;
        }
      }
    }

    /// <summary>
    /// Save the list
    /// </summary>
    /// <param name="sender">object sender</param>
    /// <param name="e">event arguments</param>
    /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
    private void ButtonSaveList_Click(object sender, EventArgs e)
    {
      if (SaveFileDialog.ShowDialog() == DialogResult.OK)
      {
        using (StreamWriter sw = new StreamWriter(path: SaveFileDialog.FileName))
        {
          string line;
          foreach (ListViewItem lvi in listviewWatch.Items)
          {
            line = $"Die Datei '{lvi.SubItems[index: 2].ToString().Remove(startIndex: lvi.SubItems[index: 2].ToString().Length - 1).Remove(startIndex: 0, count: 18)}' wurde zum Zeitpunkt {lvi.SubItems[index: 1].ToString().Remove(startIndex: lvi.SubItems[index: 1].ToString().Length - 1).Remove(startIndex: 0, count: 18)} ";
            switch (lvi.ImageIndex)
            {
              case 0: line += "erstellt."; break;
              case 1: line += "gelöscht."; break;
              case 2: line += "geändert."; break;
              case 3: line += "umbenannt."; break;
              default: line += "offenbar nicht verändert."; break;
            }
            sw.WriteLine(value: line);
          }
        }
      }
    }

    /// <summary>
    /// Delete the list
    /// </summary>
    /// <param name="sender">object sender</param>
    /// <param name="e">event arguments</param>
    /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
    private void ButtonDeleteList_Click(object sender, EventArgs e)
    {
      listviewWatch.Items.Clear();
      counterFilesCreated = 0;
      counterFilesDeleted = 0;
      counterFilesChanged = 0;
      counterFilesRenamed = 0;
      labelCounterFiles.Text = Resources.zero;
      labelCounterFilesCreated.Text = Resources.zero;
      labelCounterFilesDeleted.Text = Resources.zero;
      labelCounterFilesChanged.Text = Resources.zero;
      labelCounterFilesRenamed.Text = Resources.zero;
    }

    /// <summary>
    /// Load the form
    /// </summary>
    /// <param name="sender">object sender</param>
    /// <param name="e">event arguments</param>
    /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
    private void Form_Load(object sender, EventArgs e)
    {
      labelInformation.Text = string.Empty;
      textboxPath.Text = Resources.driveC;
      FileSystemWatcher.Path = textboxPath.Text;
      listviewWatch.GridLines = true;
      isStarting = true;
      checkboxHoldOnTop.Checked = false;
      checkboxMinimizeToSystemtray.Checked = false;
      buttonStart.Enabled = false;
      labelCounterFiles.Text = Resources.zero;
      labelCounterFilesCreated.Text = Resources.zero;
      labelCounterFilesDeleted.Text = Resources.zero;
      labelCounterFilesChanged.Text = Resources.zero;
      labelCounterFilesRenamed.Text = Resources.zero;
      startMeasurements = DateTime.Now;
      labelTimeBeginMeasured.Text = $"{startMeasurements.ToString(format: Resources.HHmmss, provider: culture)} hms";
      labelTimeEndMeasured.Text = string.Empty;
      timer.Start();
    }

    /// <summary>
    /// Update the list while a file was created
    /// </summary>
    /// <param name="sender">object sender</param>
    /// <param name="e">event arguments</param>
    /// <remarks>The parameters <paramref name="sender"/> is not needed, but must be indicated.</remarks>
    private void FileSystemWatcher_Created(object sender, FileSystemEventArgs e)
    {
      if (isStarting)
      {
        if (NotifyIcon.Visible)
        {
          NotifyIcon.BalloonTipText = $"{e.FullPath} wurde erstellt.";
          NotifyIcon.ShowBalloonTip(timeout: 3000);
        }
        ListViewItem lvi = new ListViewItem
        {
          ImageIndex = 0,
          ToolTipText = "Datei wurde erstellt",
          ForeColor = Color.Green
        };
        lvi.SubItems.Add(text: DateTime.Now.ToString(format: Resources.yyyyMMddHHmmssfffffff, provider: culture));
        lvi.SubItems.Add(text: e.FullPath);
        listviewWatch.Items.Add(value: lvi);
        listviewWatch.EnsureVisible(index: listviewWatch.Items.Count - 1);
        listviewWatch.Update();
        counterFilesCreated++;
        counterFiles = counterFilesCreated + counterFilesChanged + counterFilesRenamed + counterFilesDeleted;
        labelCounterFilesCreated.Text = counterFilesCreated.ToString(provider: culture);
        labelCounterFilesCreatedPercent.Text = $"{(counterFilesCreated / (float)counterFiles * 100.0).ToString(format: Resources.zeroSix, provider: culture)}%";
        labelCounterFiles.Text = counterFiles.ToString(provider: culture);
      }
    }

    /// <summary>
    /// Update the list while a file was deleted
    /// </summary>
    /// <param name="sender">object sender</param>
    /// <param name="e">event arguments</param>
    /// <remarks>The parameters <paramref name="sender"/> is not needed, but must be indicated.</remarks>
    private void FileSystemWatcher_Deleted(object sender, FileSystemEventArgs e)
    {
      if (isStarting)
      {
        ListViewItem lvi = new ListViewItem
        {
          ImageIndex = 1,
          ToolTipText = "Datei wurde gelöscht",
          ForeColor = Color.Red
        };
        lvi.SubItems.Add(text: DateTime.Now.ToString(format: Resources.yyyyMMddHHmmssfffffff, provider: culture));
        lvi.SubItems.Add(text: e.FullPath);
        listviewWatch.Items.Add(value: lvi);
        listviewWatch.EnsureVisible(index: listviewWatch.Items.Count - 1);
        listviewWatch.Update();
        counterFilesDeleted++;
        counterFiles = counterFilesCreated + counterFilesChanged + counterFilesRenamed + counterFilesDeleted;
        labelCounterFilesDeleted.Text = counterFilesDeleted.ToString(provider: culture);
        labelCounterFilesDeletedPercent.Text = $"{(counterFilesDeleted / (float)counterFiles * 100.0).ToString(format: Resources.zeroSix, provider: culture)}%";
        labelCounterFiles.Text = counterFiles.ToString(provider: culture);
      }
    }

    /// <summary>
    /// Update the list while a file was changed
    /// </summary>
    /// <param name="sender">object sender</param>
    /// <param name="e">event arguments</param>
    /// <remarks>The parameters <paramref name="sender"/> is not needed, but must be indicated.</remarks>
    private void FileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
    {
      if (isStarting)
      {
        ListViewItem lvi = new ListViewItem
        {
          ImageIndex = 2,
          ToolTipText = "Datei wurde verändert",
          ForeColor = Color.Blue
        };
        lvi.SubItems.Add(text: DateTime.Now.ToString(format: Resources.yyyyMMddHHmmssfffffff, provider: culture));
        lvi.SubItems.Add(text: e.FullPath);
        listviewWatch.Items.Add(value: lvi);
        listviewWatch.EnsureVisible(index: listviewWatch.Items.Count - 1);
        listviewWatch.Update();
        counterFilesChanged++;
        counterFiles = counterFilesCreated + counterFilesChanged + counterFilesRenamed + counterFilesDeleted;
        labelCounterFilesChanged.Text = counterFilesChanged.ToString(provider: culture);
        labelCounterFilesChangedPercent.Text = $"{(counterFilesChanged / (float)counterFiles * 100.0).ToString(format: Resources.zeroSix, provider: culture)}%";
        labelCounterFiles.Text = counterFiles.ToString(provider: culture);
      }
    }

    /// <summary>
    /// Update the list while a file was renamed
    /// </summary>
    /// <param name="sender">object sender</param>
    /// <param name="e">event arguments</param>
    /// <remarks>The parameters <paramref name="sender"/> is not needed, but must be indicated.</remarks>
    private void FileSystemWatcher_Renamed(object sender, RenamedEventArgs e)
    {
      if (isStarting)
      {
        ListViewItem lvi = new ListViewItem
        {
          ImageIndex = 3,
          ToolTipText = "Datei wurde umbenannt",
          ForeColor = Color.Black
        };
        lvi.SubItems.Add(text: DateTime.Now.ToString(format: Resources.yyyyMMddHHmmssfffffff, provider: culture));
        lvi.SubItems.Add(text: e.FullPath);
        listviewWatch.Items.Add(value: lvi);
        listviewWatch.EnsureVisible(index: listviewWatch.Items.Count - 1);
        listviewWatch.Update();
        counterFilesRenamed++;
        counterFiles = counterFilesCreated + counterFilesChanged + counterFilesRenamed + counterFilesDeleted;
        labelCounterFilesRenamed.Text = counterFilesRenamed.ToString(provider: culture);
        labelCounterFilesRenamedPercent.Text = $"{(counterFilesRenamed / (float)counterFiles * 100.0).ToString(format: Resources.zeroSix, provider: culture)}%";
        labelCounterFiles.Text = counterFiles.ToString(provider: culture);
      }
    }

    /// <summary>
    /// Minimize to tray
    /// </summary>
    /// <param name="sender">object sender</param>
    /// <param name="e">event arguments</param>
    /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
    private void Form_SizeChanged(object sender, EventArgs e)
    {
      if (WindowState == FormWindowState.Minimized)
      {
        if (checkboxMinimizeToSystemtray.Checked)
        {
          Hide();
          NotifyIcon.Visible = true;
        }
      }
    }

    /// <summary>
    /// Start the watching
    /// </summary>
    /// <param name="sender">object sender</param>
    /// <param name="e">event arguments</param>
    /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
    private void ButtonStart_Click(object sender, EventArgs e)
    {
      isStarting = true;
      buttonStart.Enabled = false;
      buttonStop.Enabled = true;
      timer.Start();
      startMeasurements = DateTime.Now;
      labelTimeBeginMeasured.Text = $"{startMeasurements.ToString(format: Resources.HHmmss, provider: culture)} hms";
      labelTimeEndMeasured.Text = string.Empty;
    }

    /// <summary>
    /// Stop the watching
    /// </summary>
    /// <param name="sender">object sender</param>
    /// <param name="e">event arguments</param>
    /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
    private void ButtonStop_Click(object sender, EventArgs e)
    {
      isStarting = false;
      buttonStart.Enabled = true;
      buttonStop.Enabled = false;
      timer.Stop();
      labelTimeEndMeasured.Text = $"{startMeasurements.ToString(format: Resources.HHmmss, provider: culture)} hms";
    }

    /// <summary>
    /// Hold the window in foreground
    /// </summary>
    /// <param name="sender">object sender</param>
    /// <param name="e">event arguments</param>
    /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
    private void CheckboxHoldOnTop_CheckedChanged(object sender, EventArgs e) => TopMost = checkboxHoldOnTop.Checked;

    /// <summary>
    /// Measure the current runtime
    /// </summary>
    /// <param name="sender">object sender</param>
    /// <param name="e">event arguments</param>
    /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
    private void Timer_Tick(object sender, EventArgs e) => labelRuntimeMeasured.Text = (DateTime.Now - startMeasurements).ToString();

    /// <summary>
    /// Indicate the drive C:
    /// </summary>
    /// <param name="sender">object sender</param>
    /// <param name="e">event arguments</param>
    /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
    private void ButtonDriveC_Click(object sender, EventArgs e)
    {
      textboxPath.Text = Resources.driveC;
      FileSystemWatcher.Path = textboxPath.Text;
    }

    /// <summary>
    /// Open the window from the notify tray icon
    /// </summary>
    /// <param name="sender">object sender</param>
    /// <param name="e">event arguments</param>
    /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
    private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      NotifyIcon.Visible = false;
      Show();
      WindowState = FormWindowState.Normal;
    }

    /// <summary>
    /// Copy the list to the clipboard
    /// </summary>
    /// <param name="sender">object sender</param>
    /// <param name="e">event arguments</param>
    /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
    private void ButtonCopyToClipboard_Click(object sender, EventArgs e)
    {
      string line = string.Empty;
      foreach (ListViewItem lvi in listviewWatch.Items)
      {
        line = $"{line}Die Datei '{lvi.SubItems[index: 2].ToString().Remove(startIndex: lvi.SubItems[index: 2].ToString().Length - 1).Remove(startIndex: 0, count: 18)}' wurde zum Zeitpunkt {lvi.SubItems[index: 1].ToString().Remove(startIndex: lvi.SubItems[index: 1].ToString().Length - 1).Remove(startIndex: 0, count: 18)} ";
        switch (lvi.ImageIndex)
        {
          case 0: line += "erstellt."; break;
          case 1: line += "gelöscht."; break;
          case 2: line += "geändert."; break;
          case 3: line += "umbenannt."; break;
          default: line += "offenbar nicht verändert."; break;
        }
        line += "\r\n";
      }
      Clipboard.SetText(text: line);
    }

    /// <summary>
    /// Show the information window
    /// </summary>
    /// <param name="sender">object sender</param>
    /// <param name="e">event arguments</param>
    /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
    private void ButtonShowInfos_Click(object sender, EventArgs e)
    {
      using (DiskWatchCS.AboutBoxForm formAboutBox = new DiskWatchCS.AboutBoxForm())
      {
        formAboutBox.ShowDialog();
      }
    }
  }
}
