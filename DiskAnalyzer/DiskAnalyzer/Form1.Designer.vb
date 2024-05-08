<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtPath = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.txtFileTypes = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.ClearAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Button3 = New System.Windows.Forms.Button
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.Label4 = New System.Windows.Forms.Label
        Me.CreatedCheck = New System.Windows.Forms.CheckBox
        Me.RenamedCheck = New System.Windows.Forms.CheckBox
        Me.DeletedCheck = New System.Windows.Forms.CheckBox
        Me.ChangedCheck = New System.Windows.Forms.CheckBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.SubDirectoryCheck = New System.Windows.Forms.CheckBox
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Folder to Monitor:"
        '
        'TxtPath
        '
        Me.TxtPath.BackColor = System.Drawing.SystemColors.Window
        Me.TxtPath.Location = New System.Drawing.Point(12, 28)
        Me.TxtPath.Name = "TxtPath"
        Me.TxtPath.Size = New System.Drawing.Size(316, 20)
        Me.TxtPath.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(194, 377)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Scan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(273, 377)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtFileTypes
        '
        Me.txtFileTypes.BackColor = System.Drawing.SystemColors.Window
        Me.txtFileTypes.Location = New System.Drawing.Point(12, 75)
        Me.txtFileTypes.Name = "txtFileTypes"
        Me.txtFileTypes.Size = New System.Drawing.Size(338, 20)
        Me.txtFileTypes.TabIndex = 5
        Me.txtFileTypes.Text = "*.*"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "File Types to Monitor:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 14)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Result:"
        '
        'ListBox1
        '
        Me.ListBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 200)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(338, 160)
        Me.ListBox1.TabIndex = 8
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem, Me.ToolStripMenuItem1, Me.ClearAllToolStripMenuItem, Me.BackupToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(114, 76)
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
        '
        'ClearAllToolStripMenuItem
        '
        Me.ClearAllToolStripMenuItem.Name = "ClearAllToolStripMenuItem"
        Me.ClearAllToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClearAllToolStripMenuItem.Text = "Clear"
        '
        'BackupToolStripMenuItem
        '
        Me.BackupToolStripMenuItem.Name = "BackupToolStripMenuItem"
        Me.BackupToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BackupToolStripMenuItem.Text = "Backup"
        '
        'Button3
        '
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button3.Location = New System.Drawing.Point(326, 27)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(24, 21)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Parameters:"
        '
        'CreatedCheck
        '
        Me.CreatedCheck.AutoSize = True
        Me.CreatedCheck.BackColor = System.Drawing.SystemColors.Window
        Me.CreatedCheck.Checked = True
        Me.CreatedCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CreatedCheck.Location = New System.Drawing.Point(2, 2)
        Me.CreatedCheck.Name = "CreatedCheck"
        Me.CreatedCheck.Size = New System.Drawing.Size(63, 17)
        Me.CreatedCheck.TabIndex = 16
        Me.CreatedCheck.Text = "Created"
        Me.CreatedCheck.UseVisualStyleBackColor = False
        '
        'RenamedCheck
        '
        Me.RenamedCheck.AutoSize = True
        Me.RenamedCheck.BackColor = System.Drawing.SystemColors.Window
        Me.RenamedCheck.Checked = True
        Me.RenamedCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RenamedCheck.Location = New System.Drawing.Point(2, 32)
        Me.RenamedCheck.Name = "RenamedCheck"
        Me.RenamedCheck.Size = New System.Drawing.Size(72, 17)
        Me.RenamedCheck.TabIndex = 18
        Me.RenamedCheck.Text = "Renamed"
        Me.RenamedCheck.UseVisualStyleBackColor = False
        '
        'DeletedCheck
        '
        Me.DeletedCheck.AutoSize = True
        Me.DeletedCheck.BackColor = System.Drawing.SystemColors.Window
        Me.DeletedCheck.Checked = True
        Me.DeletedCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.DeletedCheck.Location = New System.Drawing.Point(2, 17)
        Me.DeletedCheck.Name = "DeletedCheck"
        Me.DeletedCheck.Size = New System.Drawing.Size(63, 17)
        Me.DeletedCheck.TabIndex = 17
        Me.DeletedCheck.Text = "Deleted"
        Me.DeletedCheck.UseVisualStyleBackColor = False
        '
        'ChangedCheck
        '
        Me.ChangedCheck.AutoSize = True
        Me.ChangedCheck.BackColor = System.Drawing.SystemColors.Window
        Me.ChangedCheck.Checked = True
        Me.ChangedCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChangedCheck.Location = New System.Drawing.Point(83, 3)
        Me.ChangedCheck.Name = "ChangedCheck"
        Me.ChangedCheck.Size = New System.Drawing.Size(66, 17)
        Me.ChangedCheck.TabIndex = 19
        Me.ChangedCheck.Text = "Modified"
        Me.ChangedCheck.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.SubDirectoryCheck)
        Me.Panel1.Controls.Add(Me.ChangedCheck)
        Me.Panel1.Controls.Add(Me.RenamedCheck)
        Me.Panel1.Controls.Add(Me.DeletedCheck)
        Me.Panel1.Controls.Add(Me.CreatedCheck)
        Me.Panel1.Location = New System.Drawing.Point(12, 122)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(338, 53)
        Me.Panel1.TabIndex = 21
        '
        'SubDirectoryCheck
        '
        Me.SubDirectoryCheck.AutoSize = True
        Me.SubDirectoryCheck.BackColor = System.Drawing.SystemColors.Window
        Me.SubDirectoryCheck.Checked = True
        Me.SubDirectoryCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SubDirectoryCheck.Location = New System.Drawing.Point(83, 17)
        Me.SubDirectoryCheck.Name = "SubDirectoryCheck"
        Me.SubDirectoryCheck.Size = New System.Drawing.Size(98, 17)
        Me.SubDirectoryCheck.TabIndex = 20
        Me.SubDirectoryCheck.Text = "Sub Directories"
        Me.SubDirectoryCheck.UseVisualStyleBackColor = False
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "txt"
        Me.SaveFileDialog1.DereferenceLinks = False
        Me.SaveFileDialog1.FileName = "Backup"
        Me.SaveFileDialog1.Filter = "Text Files (*.txt) | *.txt"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 420)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFileTypes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtPath)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(378, 458)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(378, 458)
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Disk Anaylyzer"
        Me.TopMost = True
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtPath As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtFileTypes As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents FileSystemWatcher1 As System.IO.FileSystemWatcher
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ChangedCheck As System.Windows.Forms.CheckBox
    Friend WithEvents RenamedCheck As System.Windows.Forms.CheckBox
    Friend WithEvents DeletedCheck As System.Windows.Forms.CheckBox
    Friend WithEvents CreatedCheck As System.Windows.Forms.CheckBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents SubDirectoryCheck As System.Windows.Forms.CheckBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClearAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
