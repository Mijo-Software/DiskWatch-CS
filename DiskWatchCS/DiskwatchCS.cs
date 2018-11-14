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
          foreach (ListViewItem lvi in listviewWatch.Items)
          {
            sw.WriteLine(lvi.ToString());
          }
        }
      }
    }

    private void buttonDeleteList_Click(object sender, EventArgs e)
    {
      listviewWatch.Items.Clear();
    }

    private void Form_Load(object sender, EventArgs e)
    {
      textboxPath.Text = "C:\\";
      FileSystemWatcher.Path = textboxPath.Text;
    }

    private void FileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
    {
      //listviewWatch.Items.Add(e.FullPath & " wurde geändert | " & DateAndTime.DateString & "/" & TimeOfDay).ForeColor = Color.Blue;
      listviewWatch.Items.Add(e.FullPath + " wurde geändert | " + DateTime.Now.ToString("yyyyMMddHHmmss.fff", System.Globalization.DateTimeFormatInfo.InvariantInfo)).ForeColor = Color.Blue;
      listviewWatch.EnsureVisible(listviewWatch.Items.Count - 1);
      listviewWatch.Update();
    }

    private void FileSystemWatcher_Created(object sender, FileSystemEventArgs e)
    {
      listviewWatch.Items.Add(e.FullPath + " wurde erstellt | " + DateTime.Now.ToString("yyyyMMddHHmmss.fff", System.Globalization.DateTimeFormatInfo.InvariantInfo)).ForeColor = Color.Green;

      if (NotifyIcon.Visible)
      {
        NotifyIcon.BalloonTipText = e.FullPath + " wurde erstellt.";
        NotifyIcon.ShowBalloonTip(3000);
      }
      listviewWatch.EnsureVisible(listviewWatch.Items.Count - 1);
      listviewWatch.Update();
    }

    private void FileSystemWatcher_Deleted(object sender, FileSystemEventArgs e)
    {
      listviewWatch.Items.Add(e.FullPath + " wurde gelöscht | " + DateTime.Now.ToString("yyyyMMddHHmmss.fff", System.Globalization.DateTimeFormatInfo.InvariantInfo)).ForeColor = Color.Red;
      listviewWatch.EnsureVisible(listviewWatch.Items.Count - 1);
      listviewWatch.Update();
    }

    private void FileSystemWatcher_Renamed(object sender, RenamedEventArgs e)
    {
      listviewWatch.Items.Add(e.FullPath + " wurde umbenannt | " + DateTime.Now.ToString("yyyyMMddHHmmss.ffffff", System.Globalization.DateTimeFormatInfo.InvariantInfo)).ForeColor = Color.Black;
      listviewWatch.EnsureVisible(listviewWatch.Items.Count - 1);
      listviewWatch.Update();
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
        line = line + lvi.ToString() + "\r\n";
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
