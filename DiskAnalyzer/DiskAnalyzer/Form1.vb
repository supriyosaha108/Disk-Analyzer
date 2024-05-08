Public Class Form1
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button1.Text = "Stop" Then
            MsgBox("Pleae terminate the scan", MsgBoxStyle.Critical)
        Else
            End
        End If
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Button1.Text = "Stop" Then
            e.Cancel = True : MsgBox("Pleae terminate the scan", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileSystemWatcher1.IncludeSubdirectories = False
        FileSystemWatcher1.EnableRaisingEvents = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "Scan" Then
            If TxtPath.Text.Trim.Length = 0 Then
                MsgBox("Please select a folder to monitor for file changes", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            If txtFileTypes.Text.Trim.Length = 0 Then
                MsgBox("Please specify the file types to monitor", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            FileSystemWatcher1.Filter = txtFileTypes.Text.Trim
            FileSystemWatcher1.Path = TxtPath.Text.Trim
            FileSystemWatcher1.NotifyFilter = IO.NotifyFilters.CreationTime Or IO.NotifyFilters.LastWrite Or IO.NotifyFilters.LastAccess Or IO.NotifyFilters.FileName
            FileSystemWatcher1.IncludeSubdirectories = SubDirectoryCheck.Checked
            FileSystemWatcher1.EnableRaisingEvents = True
            Panel1.Enabled = False : TxtPath.Enabled = False : Button3.Enabled = False : txtFileTypes.Enabled = False : Button1.Text = "Stop"
        Else
            FileSystemWatcher1.EnableRaisingEvents = False
            FileSystemWatcher1.IncludeSubdirectories = False
            Panel1.Enabled = True : TxtPath.Enabled = True : Button3.Enabled = True : txtFileTypes.Enabled = True : Button1.Text = "Scan"
        End If
    End Sub

    Private Sub FileSystemWatcher1_Changed(ByVal sender As System.Object, ByVal e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher1.Changed
        If ChangedCheck.Checked = True Then ListBox1.Items.Add(e.ChangeType.ToString & vbTab & e.FullPath)
    End Sub

    Private Sub FileSystemWatcher1_Renamed(ByVal sender As Object, ByVal e As System.IO.RenamedEventArgs) Handles FileSystemWatcher1.Renamed
        If RenamedCheck.Checked = True Then ListBox1.Items.Add("Renamed" & " " & e.OldFullPath & " TO " & e.FullPath)
    End Sub

    Private Sub FileSystemWatcher1_Error(ByVal sender As Object, ByVal e As System.IO.ErrorEventArgs) Handles FileSystemWatcher1.Error
        If FileSystemWatcher1.EnableRaisingEvents Then
            FileSystemWatcher1.EnableRaisingEvents = False
            FileSystemWatcher1.InternalBufferSize = 2 * _
              FileSystemWatcher1.InternalBufferSize
            FileSystemWatcher1.EnableRaisingEvents = True
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        FolderBrowserDialog1.ShowDialog()
        TxtPath.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub FileSystemWatcher1_Created(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher1.Created
        If CreatedCheck.Checked = True Then ListBox1.Items.Add(e.ChangeType.ToString & vbTab & e.FullPath)
    End Sub

    Private Sub FileSystemWatcher1_Deleted(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher1.Deleted
        If DeletedCheck.Checked = True Then ListBox1.Items.Add(e.ChangeType.ToString & vbTab & e.FullPath)
    End Sub
    Private Sub ClearAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearAllToolStripMenuItem.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        If ListBox1.SelectedItem <> "" Then Clipboard.SetText(ListBox1.SelectedItem)
    End Sub

    Private Sub BackupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackupToolStripMenuItem.Click
        If Button1.Text = "Stop" Then
            MsgBox("Pleae terminate the scan", MsgBoxStyle.Critical)
        Else
            If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim SaveFile As System.IO.StreamWriter = New System.IO.StreamWriter(SaveFileDialog1.FileName)
                For Each c In ListBox1.Items
                    SaveFile.WriteLine(c.ToString)
                Next
                SaveFile.Close()
                MsgBox("Exported to " & SaveFileDialog1.FileName, MsgBoxStyle.Information)
            End If
        End If
    End Sub
End Class
