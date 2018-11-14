using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiskwatchCS
{
  public partial class Form : System.Windows.Forms.Form
  {

    long longintCounterFiles, longintCounterFilesChanged, longintCounterFilesDeleted, longintCounterFilesCreated, longintCounterFilesRenamed;
    bool isStarting;
    DateTime dtStartMeasurements, dtEndMeasurements;

    public Form()
    {
      InitializeComponent();
    }

    private void buttonOpenFolder_Click(object sender, EventArgs e)
    {
      if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
      {
        if (Directory.Exists(FolderBrowserDialog.SelectedPath))
        {
          textboxPath.Text = FolderBrowserDialog.SelectedPath;
          FileSystemWatcher.Path = textboxPath.Text;
        }
      }
    }

    private void buttonSaveList_Click(object sender, EventArgs e)
    {
      if (SaveFileDialog.ShowDialog() == DialogResult.OK)
      {
        using (StreamWriter sw = new StreamWriter(SaveFileDialog.FileName))
        {
          string line;
          foreach (ListViewItem lvi in listviewWatch.Items)
          {
            line = "Die Datei '" + lvi.SubItems[2].ToString().Remove(lvi.SubItems[2].ToString().Length - 1).Remove(0,18) + "' wurde zum Zeitpunkt " + lvi.SubItems[1].ToString().Remove(lvi.SubItems[1].ToString().Length - 1).Remove(0, 18) + " ";
            switch (lvi.ImageIndex)
            {
              case 0: line = line + "erstellt."; break;
              case 1: line = line + "gelöscht."; break;
              case 2: line = line + "geändert."; break;
              case 3: line = line + "umbenannt."; break;
              default: line = line + "offenbar nicht verändert."; break;
            }
            sw.WriteLine(line);
          }
        }
      }
    }

    private void buttonDeleteList_Click(object sender, EventArgs e)
    {
      listviewWatch.Items.Clear();
      longintCounterFilesCreated = 0;
      longintCounterFilesDeleted = 0;
      longintCounterFilesChanged = 0;
      longintCounterFilesRenamed = 0;
      labelCounterFiles.Text = "0";
      labelCounterFilesCreated.Text = "0";
      labelCounterFilesDeleted.Text = "0";
      labelCounterFilesChanged.Text = "0";
      labelCounterFilesRenamed.Text = "0";
    }

    private void Form_Load(object sender, EventArgs e)
    {
      textboxPath.Text = "C:\\";
      FileSystemWatcher.Path = textboxPath.Text;
      listviewWatch.GridLines = true;
      isStarting = true;
      checkboxHoldOnTop.Checked = false;
      checkboxMinimizeToSystemtray.Checked = false;
      buttonStart.Enabled = false;
      labelCounterFiles.Text = "0";
      labelCounterFilesCreated.Text = "0";
      labelCounterFilesDeleted.Text = "0";
      labelCounterFilesRenamed.Text = "0";
      labelCounterFilesDeleted.Text = "0";
      dtStartMeasurements = DateTime.Now;
      labelTimeBeginMeasured.Text = dtStartMeasurements.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo) + " hms";
      labelTimeEndMeasured.Text = "";
      timer.Start();
    }

    private void FileSystemWatcher_Created(object sender, FileSystemEventArgs e)
    {
      if (isStarting)
      {
        if (NotifyIcon.Visible)
        {
          NotifyIcon.BalloonTipText = e.FullPath + " wurde erstellt.";
          NotifyIcon.ShowBalloonTip(3000);
        }
        ListViewItem lvi = new ListViewItem();
        lvi.ImageIndex = 0;
        lvi.ToolTipText = "Datei wurde erstellt";
        lvi.ForeColor = Color.Green;
        lvi.SubItems.Add(DateTime.Now.ToString("yyyyMMddHHmmss.fffffff", System.Globalization.DateTimeFormatInfo.InvariantInfo));
        lvi.SubItems.Add(e.FullPath);
        listviewWatch.Items.Add(lvi);
        listviewWatch.EnsureVisible(listviewWatch.Items.Count - 1);
        listviewWatch.Update();
        longintCounterFilesCreated++;
        longintCounterFiles = longintCounterFilesCreated + longintCounterFilesChanged + longintCounterFilesRenamed + longintCounterFilesDeleted;
        labelCounterFilesCreated.Text = longintCounterFilesCreated.ToString();
        labelCounterFilesCreatedPercent.Text = (longintCounterFilesCreated / (float)longintCounterFiles * 100.0).ToString("00.0000") + "%";
        labelCounterFiles.Text = longintCounterFiles.ToString();
      }
    }

    private void FileSystemWatcher_Deleted(object sender, FileSystemEventArgs e)
    {
      if (isStarting)
      {
        ListViewItem lvi = new ListViewItem();
        lvi.ImageIndex = 1;
        lvi.ToolTipText = "Datei wurde gelöscht";
        lvi.ForeColor = Color.Red;
        lvi.SubItems.Add(DateTime.Now.ToString("yyyyMMddHHmmss.fffffff", System.Globalization.DateTimeFormatInfo.InvariantInfo));
        lvi.SubItems.Add(e.FullPath);
        listviewWatch.Items.Add(lvi);
        listviewWatch.EnsureVisible(listviewWatch.Items.Count - 1);
        listviewWatch.Update();
        longintCounterFilesDeleted++;
        longintCounterFiles = longintCounterFilesCreated + longintCounterFilesChanged + longintCounterFilesRenamed + longintCounterFilesDeleted;
        labelCounterFilesDeleted.Text = longintCounterFilesDeleted.ToString();
        labelCounterFilesDeletedPercent.Text = (longintCounterFilesDeleted / (float)longintCounterFiles * 100.0).ToString("00.0000") + "%";
        labelCounterFiles.Text = longintCounterFiles.ToString();
      }
    }

    private void FileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
    {
      if (isStarting)
      {
        ListViewItem lvi = new ListViewItem();
        lvi.ImageIndex = 2;
        lvi.ToolTipText = "Datei wurde verändert";
        lvi.ForeColor = Color.Blue;
        lvi.SubItems.Add(DateTime.Now.ToString("yyyyMMddHHmmss.fffffff", System.Globalization.DateTimeFormatInfo.InvariantInfo));
        lvi.SubItems.Add(e.FullPath);
        listviewWatch.Items.Add(lvi);
        listviewWatch.EnsureVisible(listviewWatch.Items.Count - 1);
        listviewWatch.Update();
        longintCounterFilesChanged++;
        longintCounterFiles = longintCounterFilesCreated + longintCounterFilesChanged + longintCounterFilesRenamed + longintCounterFilesDeleted;
        labelCounterFilesChanged.Text = longintCounterFilesChanged.ToString();
        labelCounterFilesChangedPercent.Text = (longintCounterFilesChanged / (float)longintCounterFiles * 100.0).ToString("00.0000") + "%";
        labelCounterFiles.Text = longintCounterFiles.ToString();
      }
    }

    private void FileSystemWatcher_Renamed(object sender, RenamedEventArgs e)
    {
      if (isStarting)
      {
        ListViewItem lvi = new ListViewItem();
        lvi.ImageIndex = 3;
        lvi.ToolTipText = "Datei wurde umbenannt";
        lvi.ForeColor = Color.Black;
        lvi.SubItems.Add(DateTime.Now.ToString("yyyyMMddHHmmss.fffffff", System.Globalization.DateTimeFormatInfo.InvariantInfo));
        lvi.SubItems.Add(e.FullPath);
        listviewWatch.Items.Add(lvi);
        listviewWatch.EnsureVisible(listviewWatch.Items.Count - 1);
        listviewWatch.Update();
        longintCounterFilesRenamed++;
        longintCounterFiles = longintCounterFilesCreated + longintCounterFilesChanged + longintCounterFilesRenamed + longintCounterFilesDeleted;
        labelCounterFilesRenamed.Text = longintCounterFilesRenamed.ToString();
        labelCounterFilesRenamedPercent.Text = (longintCounterFilesRenamed / (float)longintCounterFiles * 100.0).ToString("00.0000") + "%";
        labelCounterFiles.Text = longintCounterFiles.ToString();
      }
    }

    private void Form_SizeChanged(object sender, EventArgs e)
    {
      if (this.WindowState == FormWindowState.Minimized)
      {
        if (checkboxMinimizeToSystemtray.Checked)
        {
          this.Hide();
          NotifyIcon.Visible = true;
        }
      }
    }

    private void buttonStart_Click(object sender, EventArgs e)
    {
      isStarting = true;
      buttonStart.Enabled = false;
      buttonStop.Enabled = true;
      timer.Start();
      dtStartMeasurements = DateTime.Now;
      labelTimeBeginMeasured.Text = dtStartMeasurements.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo) + " hms";
      labelTimeEndMeasured.Text = "";
    }

    private void buttonStop_Click(object sender, EventArgs e)
    {
      isStarting = false;
      buttonStart.Enabled = true;
      buttonStop.Enabled = false;
      timer.Stop();
      dtEndMeasurements = DateTime.Now;
      labelTimeEndMeasured.Text = dtEndMeasurements.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo) + " hms";
    }

    private void checkboxHoldOnTop_CheckedChanged(object sender, EventArgs e)
    {
      if (checkboxHoldOnTop.Checked) this.TopMost = true; else this.TopMost = false;
    }

    private void timer_Tick(object sender, EventArgs e)
    {
      //labelRuntimeMeasured.Text = (DateTime.Now - dtStartMeasurements).ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo) + " hms";
      labelRuntimeMeasured.Text = (DateTime.Now - dtStartMeasurements).ToString();
    }

    private void buttonDriveC_Click(object sender, EventArgs e)
    {
      textboxPath.Text = "C:\\";
      FileSystemWatcher.Path = textboxPath.Text;
    }

    private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      NotifyIcon.Visible = false;
      this.Show();
      this.WindowState = FormWindowState.Normal;
    }

    private void buttonCopyToClipboard_Click(object sender, EventArgs e)
    {
      String line = "";
      foreach (ListViewItem lvi in listviewWatch.Items)
      {     
        line = line + "Die Datei '" + lvi.SubItems[2].ToString().Remove(lvi.SubItems[2].ToString().Length - 1).Remove(0, 18) + "' wurde zum Zeitpunkt " + lvi.SubItems[1].ToString().Remove(lvi.SubItems[1].ToString().Length - 1).Remove(0, 18) + " ";
        switch (lvi.ImageIndex)
        {
          case 0: line = line + "erstellt."; break;
          case 1: line = line + "gelöscht."; break;
          case 2: line = line + "geändert."; break;
          case 3: line = line + "umbenannt."; break;
          default: line = line + "offenbar nicht verändert."; break;
        }
        line = line + "\r\n";
      }
      System.Windows.Forms.Clipboard.SetText(line);
    }

    private void buttonShowInfos_Click(object sender, EventArgs e)
    {
      DiskWatchCS.AboutBoxForm formAboutBox = new DiskWatchCS.AboutBoxForm();
      formAboutBox.ShowDialog();
    }
  }
}
