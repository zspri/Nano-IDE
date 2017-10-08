Imports System.IO

Public Class Settings

    Dim loaded As Boolean = False
    Dim DialogBoxResult
    Dim FileContent

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "Nano IDE v" & My.Application.Info.Version.ToString & vbCrLf & My.Application.Info.Copyright
        NotifPanel.Hide()
        If My.Settings.UseLightTheme Then
            CheckBox1.Checked = True
            Me.BackColor = Color.White
            Me.ForeColor = Color.Black
            TextArea.BackColor = Color.FromArgb(234, 234, 236)
            TextArea.ForeColor = Color.Black
        End If
        CheckBox2.Checked = My.Settings.ShowUpdateNotifs
        CheckBox3.Checked = My.Settings.CheckUpdatesOnLaunch
        loaded = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("This feature isn't available yet!", MsgBoxStyle.Critical)
    End Sub

    Private Sub TextArea_TextChanged(sender As Object, e As EventArgs) Handles TextArea.TextChanged
        TextArea.Text = "Your editor should look something like this"
    End Sub

    Private Sub UseLightThemeUpdate(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If loaded Then
            My.Settings.UseLightTheme = CheckBox1.Checked
            NotifPanel.Show()
        End If
    End Sub

    Private Sub RestartRequest(sender As Object, e As EventArgs) Handles RestartLabel.Click
        Process.Start("cmd", "/c /min timeout -t 3 & start NanoIDE.exe")
        Editor.Close()
    End Sub

    Private Sub OpenConfigFile(sender As Object, e As EventArgs) Handles Button2.Click
        If Not ((Editor.OpenFileDialog.FileName = "") And (TextArea.Text = "")) Then
            DialogBoxResult = MsgBox("Save changes to current file?", MsgBoxStyle.YesNoCancel)
            ' Yes = 6
            ' No = 7
            ' Cancel = 2
        Else
            DialogBoxResult = 7
        End If
        If Not (DialogBoxResult = 2) Then
            If DialogBoxResult = 6 Then
                Editor.SaveFileDialog.ShowDialog()
            End If
            Editor.Status.Text = "Opening App.config..."
            Me.Cursor = Cursors.WaitCursor
            TextArea.ReadOnly = True
            Try
                FileContent = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "NanoIDE.exe.config"))
                TextArea.Text = FileContent
                Me.Text = "Configuration - Nano IDE"
                Editor.Status.Text = "Editing Configuration"
            Catch ex As Exception
                MsgBox("An error occurred while trying to open the config file:" & vbCrLf & vbCrLf & ex.ToString, vbCritical)
                Editor.Status.Text = "Failed to open configuration"
            End Try
            TextArea.ReadOnly = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub ShowUpdateNotifs(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If loaded Then
            My.Settings.ShowUpdateNotifs = CheckBox2.Checked
            NotifPanel.Show()
        End If
    End Sub

    Private Sub CheckForUpdates(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Process.Start(Path.Combine(Directory.GetCurrentDirectory(), "update.exe"))
            Editor.Close()
        Catch ex As Exception
            MsgBox("The update program is either not supported in this release or is corrupt", vbCritical)
        End Try
    End Sub

    Private Sub CheckUpdatesOnLaunch(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If loaded Then
            My.Settings.CheckUpdatesOnLaunch = CheckBox3.Checked
            NotifPanel.Show()
        End If
    End Sub
End Class