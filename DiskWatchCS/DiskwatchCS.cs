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

    long longintCounterFilesChanged, longintCounterFilesDeleted, longintCounterFilesCreated, longintCounterFilesRenamed;

    public Form()
    {
      InitializeComponent();
    }

    private void buttonOpenFolder_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog.ShowDialog();
      if (Directory.Exists(FolderBrowserDialog.SelectedPath))
      {
        textboxPath.Text = FolderBrowserDialog.SelectedPath;
        FileSystemWatcher.Path = textboxPath.Text;
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
      longintCounterFilesChanged = 0;
      longintCounterFilesDeleted = 0;
      longintCounterFilesCreated = 0;
      longintCounterFilesRenamed = 0;
    }

    private void Form_Load(object sender, EventArgs e)
    {
      textboxPath.Text = "C:\\";
      FileSystemWatcher.Path = textboxPath.Text;
      listviewWatch.GridLines = true;
    }

    private void FileSystemWatcher_Created(object sender, FileSystemEventArgs e)
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
    }

    private void FileSystemWatcher_Deleted(object sender, FileSystemEventArgs e)
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
    }

    private void FileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
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
    }

    private void FileSystemWatcher_Renamed(object sender, RenamedEventArgs e)
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
    }

    private void Form_SizeChanged(object sender, EventArgs e)
    {
      if (this.WindowState == FormWindowState.Minimized)
      {
        if (checkboxStayToSystemtray.Checked)
        {
          this.Hide();
          NotifyIcon.Visible = true;
        }
      }
    }

    private void buttonShowStatistics_Click(object sender, EventArgs e)
    {
      long longintCounter = longintCounterFilesCreated + longintCounterFilesChanged + longintCounterFilesRenamed + longintCounterFilesDeleted;
      MessageBox.Show(longintCounter.ToString() + " Dateienoperationen wurden ausgeführt:\r\r" +
        "Erstellt: " + longintCounterFilesCreated.ToString() + " (" + (longintCounterFilesCreated / (float)longintCounter * 100.0).ToString("0.00") + "%)\r" +
        "Verändert: " + longintCounterFilesChanged.ToString() + " (" + (longintCounterFilesChanged / (float)longintCounter * 100.0).ToString("0.00") + "%)\r" +
        "Umbenannt: " + longintCounterFilesRenamed.ToString() + " (" + (longintCounterFilesRenamed / (float)longintCounter * 100.0).ToString("0.00") + "%)\r" +
        "Gelöscht: " + longintCounterFilesDeleted.ToString() + " (" + (longintCounterFilesDeleted / (float)longintCounter * 100.0).ToString("0.00") + "%)\r", "Statistik"
      );
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
