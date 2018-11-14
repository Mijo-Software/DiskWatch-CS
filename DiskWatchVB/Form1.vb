Public Class Form1

    Private Sub FileSystemWatcher1_Changed(ByVal sender As System.Object, ByVal e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher1.Changed
        ListView1.Items.Add(e.FullPath & " wurde geändert | " & DateAndTime.DateString & "/" & TimeOfDay).ForeColor = Color.Blue
        ListView1.EnsureVisible(ListView1.Items.Count - 1)
        ListView1.Update()
    End Sub

    Private Sub FileSystemWatcher1_Created(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher1.Created
        ListView1.Items.Add(e.FullPath & " wurde erstellt | " & DateAndTime.DateString & "/" & TimeOfDay).ForeColor = Color.Green

        If NotifyIcon1.Visible = True Then
            If CheckBox1.Checked = True Then
                NotifyIcon1.BalloonTipText = e.FullPath & " wurde erstellt"
                NotifyIcon1.ShowBalloonTip(3000)
            Else

            End If

        End If
        ListView1.EnsureVisible(ListView1.Items.Count - 1)
        ListView1.Update()
    End Sub

    Private Sub FileSystemWatcher1_Deleted(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher1.Deleted
        ListView1.Items.Add(e.FullPath & " wurde gelöscht | " & DateAndTime.DateString & "/" & TimeOfDay).ForeColor = Color.Red
        ListView1.EnsureVisible(ListView1.Items.Count - 1)
        ListView1.Update()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Computer.FileSystem.Drives.Item(0).Name
        FileSystemWatcher1.Path = TextBox1.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FolderBrowserDialog1.ShowDialog()
        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath) Then
            TextBox1.Text = FolderBrowserDialog1.SelectedPath
            FileSystemWatcher1.Path = TextBox1.Text
        Else

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListView1.Items.Clear()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        SaveFileDialog1.ShowDialog()

        Using SW As New System.IO.StreamWriter(SaveFileDialog1.FileName)
            Dim line As String
            Dim values As New List(Of String)
            For Each LVI As ListViewItem In ListView1.Items
                values.Clear()
                For i As Integer = 0 To LVI.SubItems.Count - 1
                    values.Add(LVI.SubItems(i).Text)
                Next
                line = String.Join(",", values.ToArray)
                SW.WriteLine(line)
            Next
        End Using

    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Hide()
            NotifyIcon1.Visible = True

        End If
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        NotifyIcon1.Visible = False
        Me.Show()
        Me.WindowState = FormWindowState.Normal

    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://wincrypt.org")

    End Sub
End Class
