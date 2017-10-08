Imports System.IO
Imports System.Net
Imports Newtonsoft.Json

Public Class Editor
    Dim FileContent
    Dim DialogBoxResult
    Dim CurrentLine = 1
    Dim SelectionIndex = 0
    Dim CurrentCol = 0
    Dim UpdateError As Exception = Nothing

    Public Function HandleKeyEvent(e As KeyEventArgs)
        If e.KeyCode = Keys.A And My.Computer.Keyboard.CtrlKeyDown Then ' Select All
            TextArea.SelectAll()
            e.Handled = True
        ElseIf e.KeyCode = Keys.f11 Then ' Full Screen
            If My.Forms.Editor.FormBorderStyle = FormBorderStyle.Sizable Then
                My.Forms.Editor.FormBorderStyle = FormBorderStyle.None
                My.Forms.Editor.WindowState = FormWindowState.Maximized
            Else
                My.Forms.Editor.FormBorderStyle = FormBorderStyle.Sizable
                My.Forms.Editor.WindowState = FormWindowState.Normal
            End If
        ElseIf e.KeyCode = Keys.O And My.Computer.Keyboard.CtrlKeyDown Then ' Open file
            If Not ((OpenFileDialog.FileName = "") And (TextArea.Text = "")) Then
                DialogBoxResult = MsgBox("Save changes to current file?", MsgBoxStyle.YesNoCancel)
                ' Yes = 6
                ' No = 7
                ' Cancel = 2
            Else
                DialogBoxResult = 7
            End If
            If Not (DialogBoxResult = 2) Then
                If DialogBoxResult = 6 Then
                    SaveFileDialog.ShowDialog()
                End If
                OpenFileDialog.InitialDirectory = Environment.GetEnvironmentVariable("USERPROFILE")
                OpenFileDialog.ShowDialog()
            End If
        ElseIf e.KeyCode = Keys.S And My.Computer.Keyboard.CtrlKeyDown Then ' Save File
            SaveFileDialog.InitialDirectory = OpenFileDialog.FileName
            SaveFileDialog.ShowDialog()
        ElseIf e.KeyCode = Keys.N And My.Computer.Keyboard.CtrlKeyDown Then ' New File
            Me.Cursor = Cursors.WaitCursor
            If Not ((OpenFileDialog.FileName = "") And (TextArea.Text = "")) Then
                DialogBoxResult = MsgBox("Save changes to current file?", MsgBoxStyle.YesNoCancel)
                ' Yes = 6
                ' No = 7
                ' Cancel = 2
            Else
                DialogBoxResult = 7
            End If
            If Not (DialogBoxResult = 2) Then
                If DialogBoxResult = 6 Then
                    SaveFileDialog.ShowDialog()
                End If
                Status.Text = "Creating new file..."
                TextArea.Text = ""
                Status.Text = "Ready"
            End If
            Me.Cursor = Cursors.Default
        ElseIf e.KeyCode = Keys.R And My.Computer.Keyboard.CtrlKeyDown Then ' Run File
            My.Forms.Editor.SaveFileDialog.InitialDirectory = My.Forms.Editor.OpenFileDialog.FileName
            My.Forms.Editor.SaveFileDialog.ShowDialog()
            If My.Forms.Editor.SaveFileDialog.FileName = "" Then

            End If
            Try
                Process.Start("cmd", "/C cd \ & /K start " & Convert.ToString(My.Forms.Editor.SaveFileDialog.FileName))
            Catch ex As Exception
                MsgBox("Failed to run file " & My.Forms.Editor.SaveFileDialog.FileName & vbCrLf & vbCrLf & ex.ToString, vbCritical)
            End Try
        ElseIf e.KeyCode = Keys.F1 Then ' Show Help
            Process.Start("https://github.com/Nanomotion/Nano-IDE/wiki")
        ElseIf (e.KeyCode = Keys.Oemcomma Or e.KeyCode = Keys.Decimal) And My.Computer.Keyboard.CtrlKeyDown Then ' Show settings
            Settings.Show()
        End If
        Return 0
    End Function

    Private Sub ContextMenuRequest(sender As Object, e As EventArgs) Handles ContextMenuLabel.Click, NotifMenuLabel.Click
        ContextMenu1.Show()
        ContextMenu1.Location = New Point(MousePosition.X - 2, MousePosition.Y - 2)
        ContextMenu1.BringToFront()
        ContextMenu1.Timer1.Start()
    End Sub

    Private Sub OpenFileLabel_Click(sender As Object, e As EventArgs)
        If Not ((OpenFileDialog.FileName = "") And (TextArea.Text = "")) Then
            DialogBoxResult = MsgBox("Save changes to current file?", MsgBoxStyle.YesNoCancel)
            ' Yes = 6
            ' No = 7
            ' Cancel = 2
        Else
            DialogBoxResult = 7
        End If
        If Not (DialogBoxResult = 2) Then
            If DialogBoxResult = 6 Then
                SaveFileDialog.ShowDialog()
            End If
            OpenFileDialog.InitialDirectory = Environment.GetEnvironmentVariable("USERPROFILE")
            OpenFileDialog.ShowDialog()
        End If
    End Sub

    Private Sub OpenFileDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog.FileOk
        Status.Text = "Opening " & OpenFileDialog.FileName & "..."
        Me.Cursor = Cursors.WaitCursor
        TextArea.ReadOnly = True
        Try
            FileContent = File.ReadAllText(OpenFileDialog.FileName)
            TextArea.Text = FileContent
            Me.Text = OpenFileDialog.FileName & " - Nano IDE"
            Status.Text = "Editing " & OpenFileDialog.FileName
        Catch ex As Exception
            MsgBox("An error occurred while trying to open " & OpenFileDialog.FileName & vbCrLf & vbCrLf & ex.ToString, vbCritical)
            Status.Text = "Failed to open " & OpenFileDialog.FileName
        End Try
        TextArea.ReadOnly = False
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub SaveFileDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog.FileOk
        Status.Text = "Saving file..."
        Me.Cursor = Cursors.WaitCursor
        TextArea.ReadOnly = True
        Try
            File.WriteAllText(SaveFileDialog.FileName, TextArea.Text)
            MsgBox("Successfully saved file!", MsgBoxStyle.Information)
            Status.Text = "Saved " & SaveFileDialog.FileName
        Catch ex As Exception
            MsgBox("Couldn't save file!" & vbCrLf & vbCrLf & ex.ToString, vbCritical)
            Status.Text = "Couldn't open " & SaveFileDialog.FileName
        End Try
        Me.Cursor = Cursors.Default
        TextArea.ReadOnly = False
    End Sub

    Private Sub SaveFileLabel_Click(sender As Object, e As EventArgs)
        SaveFileDialog.InitialDirectory = OpenFileDialog.FileName
        SaveFileDialog.ShowDialog()
    End Sub

    Private Sub NewFileLabel_Click(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.WaitCursor
        If Not ((OpenFileDialog.FileName = "") And (TextArea.Text = "")) Then
            DialogBoxResult = MsgBox("Save changes to current file?", MsgBoxStyle.YesNoCancel)
            ' Yes = 6
            ' No = 7
            ' Cancel = 2
        Else
            DialogBoxResult = 7
        End If
        If Not (DialogBoxResult = 2) Then
            If DialogBoxResult = 6 Then
                SaveFileDialog.ShowDialog()
            End If
            Status.Text = "Creating new file..."
            TextArea.Text = ""
            Status.Text = "Created new file"
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Editor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not ((OpenFileDialog.FileName = "") And (TextArea.Text = "")) Then
            DialogBoxResult = MsgBox("Save changes to current file?", MsgBoxStyle.YesNoCancel)
            ' Yes = 6
            ' No = 7
            ' Cancel = 2
        Else
            DialogBoxResult = 7
        End If
        If DialogBoxResult = 2 Then
            e.Cancel = True
        Else
            If DialogBoxResult = 6 Then
                SaveFileDialog.ShowDialog()
            End If
            e.Cancel = False
        End If
    End Sub

    Private Sub Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Check for updates and render theme
        NotifPanel.Hide()
        Me.Show()
        Application.DoEvents()
        If My.Settings.CheckUpdatesOnLaunch Then
            Try
                Dim Client As WebClient = New WebClient()
                Client.Headers.Add("User-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2;)")
                Dim CheckReleases As String = Client.DownloadString("https://api.github.com/repos/Nanomotion/Nano-IDE/releases?per_page=1")
                Dim ReleaseObj = JsonConvert.DeserializeObject(Of List(Of Release))(CheckReleases)
                Dim LatestRelease = ReleaseObj.First()
                If Not ("v" + My.Application.Info.Version.ToString).StartsWith(LatestRelease.tag_name) Then
                    If My.Settings.ShowUpdateNotifs Then
                        NotifPanel.BackColor = Color.FromArgb(67, 181, 129)
                        NotifLabel.Text = "A new update for NanoIDE is available"
                        AddHandler NotifLabel.Click, AddressOf UpdateNoticeClick
                        NotifPanel.Show()
                    End If
                    Debug.Print("A new update is available")
                End If
            Catch ex As Exception
                If My.Settings.ShowUpdateNotifs Then
                    NotifPanel.BackColor = Color.FromArgb(240, 71, 71)
                    NotifLabel.Text = "Failed to check for updates"
                    UpdateError = ex
                    AddHandler NotifLabel.Click, AddressOf UpdateCheckFailed
                    NotifPanel.Show()
                End If
                Debug.Print(ex.ToString)

            End Try
        End If
        If My.Settings.UseLightTheme Then
            TextArea.ForeColor = Color.Black
            TextArea.BackColor = Color.FromArgb(234, 234, 236)
            ContextMenuLabel.ForeColor = Color.Black
            TopMenu.BackColor = Color.White
            Me.BackColor = Color.White
        End If
        Status.Text = "Ready"
    End Sub

    Private Sub TextArea_KeyDown(sender As Object, e As KeyEventArgs) Handles TextArea.KeyDown, Me.KeyDown
        HandleKeyEvent(e)
    End Sub

    Private Sub SettingsIcon_Click(sender As Object, e As EventArgs) Handles SettingsIcon.Click
        Settings.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        NotifPanel.Hide()
        NotifPanel.BackColor = Color.FromArgb(250, 166, 26)
    End Sub

    Private Sub UpdateNoticeClick(sender As Object, e As EventArgs)
        Process.Start("https://github.com/Nanomotion/Nano-IDE/releases")
        NotifPanel.Hide()
        RemoveHandler NotifLabel.Click, AddressOf UpdateNoticeClick
    End Sub

    Private Sub UpdateCheckFailed(sender As Object, e As EventArgs)
        NotifPanel.Hide()
        MsgBox("An error occurred while trying to check for updates:" & vbCrLf & vbCrLf &
               UpdateError.ToString & vbCrLf & vbCrLf &
               "This feature can be optionally disabled in Settings under the Updates section.")
        RemoveHandler NotifLabel.Click, AddressOf UpdateCheckFailed
    End Sub
End Class

Public Class Author
    Public Property login As String
    Public Property id As Integer
    Public Property avatar_url As String
    Public Property gravatar_id As String
    Public Property url As String
    Public Property html_url As String
    Public Property followers_url As String
    Public Property following_url As String
    Public Property gists_url As String
    Public Property starred_url As String
    Public Property subscriptions_url As String
    Public Property organizations_url As String
    Public Property repos_url As String
    Public Property events_url As String
    Public Property received_events_url As String
    Public Property type As String
    Public Property site_admin As Boolean
End Class

Public Class Release
    Public Property url As String
    Public Property assets_url As String
    Public Property upload_url As String
    Public Property html_url As String
    Public Property id As Integer
    Public Property tag_name As String
    Public Property target_commitish As String
    Public Property name As String
    Public Property draft As Boolean
    Public Property author As Author
    Public Property prerelease As Boolean
    Public Property created_at As DateTime
    Public Property published_at As DateTime
    Public Property assets As Object()
    Public Property tarball_url As String
    Public Property zipball_url As String
    Public Property body As String
End Class
