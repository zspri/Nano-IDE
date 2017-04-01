Public Class ContextMenu1
    Dim DialogBoxResult
    Dim IgnoreClose As Boolean = False

    Private Sub ContextMenu1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = MousePosition
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not Me.ClientRectangle.Contains(Me.PointToClient(Control.MousePosition)) Then
            If Not IgnoreClose Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub NewFileLabel_Click(sender As Object, e As EventArgs) Handles NewFileLabel.Click
        IgnoreClose = True
        If Not ((My.Forms.Editor.OpenFileDialog.FileName = "") And (My.Forms.Editor.TextArea.Text = "")) Then
            DialogBoxResult = MsgBox("Save changes to current file?", MsgBoxStyle.YesNoCancel)
            ' Yes = 6
            ' No = 7
            ' Cancel = 2
        Else
            DialogBoxResult = 7
        End If
        If Not (DialogBoxResult = 2) Then
            If DialogBoxResult = 6 Then
                My.Forms.Editor.SaveFileDialog.ShowDialog()
            End If
            My.Forms.Editor.TextArea.Text = ""
        End If
        IgnoreClose = False
    End Sub

    Private Sub OpenFileLabel_Click(sender As Object, e As EventArgs) Handles OpenFileLabel.Click
        IgnoreClose = True
        If Not ((My.Forms.Editor.OpenFileDialog.FileName = "") And (My.Forms.Editor.TextArea.Text = "")) Then
            DialogBoxResult = MsgBox("Save changes to current file?", MsgBoxStyle.YesNoCancel)
            ' Yes = 6
            ' No = 7
            ' Cancel = 2
        Else
            DialogBoxResult = 7
        End If
        If Not (DialogBoxResult = 2) Then
            If DialogBoxResult = 6 Then
                My.Forms.Editor.SaveFileDialog.ShowDialog()
            End If
            My.Forms.Editor.OpenFileDialog.InitialDirectory = Environment.GetEnvironmentVariable("USERPROFILE")
            My.Forms.Editor.OpenFileDialog.ShowDialog()
        End If
        IgnoreClose = False
    End Sub

    Private Sub SaveFileLabel_Click(sender As Object, e As EventArgs) Handles SaveFileLabel.Click
        IgnoreClose = True
        My.Forms.Editor.SaveFileDialog.InitialDirectory = My.Forms.Editor.OpenFileDialog.FileName
        My.Forms.Editor.SaveFileDialog.ShowDialog()
        IgnoreClose = False
    End Sub

    Private Sub SaveAsFileLabel_Click(sender As Object, e As EventArgs) Handles SaveAsFileLabel.Click
        IgnoreClose = True
        My.Forms.Editor.SaveFileDialog.InitialDirectory = My.Forms.Editor.OpenFileDialog.FileName
        My.Forms.Editor.SaveFileDialog.ShowDialog()
        IgnoreClose = True
    End Sub

    Private Sub RunFileLabel_Click(sender As Object, e As EventArgs) Handles RunFileLabel.Click
        IgnoreClose = True
        My.Forms.Editor.SaveFileDialog.InitialDirectory = My.Forms.Editor.OpenFileDialog.FileName
        My.Forms.Editor.SaveFileDialog.ShowDialog()
        Try
            Process.Start(My.Forms.Editor.OpenFileDialog.FileName)
        Catch
            MsgBox("Failed to run file!", vbCritical)
        End Try
        IgnoreClose = False
    End Sub

    Private Sub HelpLabel_Click(sender As Object, e As EventArgs) Handles HelpLabel.Click
        Process.Start("https://github.com/Nanomotion/Nano-IDE/wiki")
    End Sub

    Private Sub ReportAnIssueLabel_Click(sender As Object, e As EventArgs) Handles ReportAnIssueLabel.Click
        Process.Start("https://github.com/Nanomotion/Nano-IDE/issues")
    End Sub

    Private Sub FullScreenLabel_Click(sender As Object, e As EventArgs) Handles FullScreenLabel.Click
        If My.Forms.Editor.FormBorderStyle = FormBorderStyle.Sizable Then
            My.Forms.Editor.FormBorderStyle = FormBorderStyle.None
            My.Forms.Editor.WindowState = FormWindowState.Maximized
        Else
            My.Forms.Editor.FormBorderStyle = FormBorderStyle.Sizable
            My.Forms.Editor.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub SettingsLabel_Click(sender As Object, e As EventArgs) Handles SettingsLabel.Click
        Settings.Show()
    End Sub

    Private Sub SelectAllLabel_Click(sender As Object, e As EventArgs) Handles SelectAllLabel.Click
        My.Forms.Editor.TextArea.SelectAll()
        Me.Close()
    End Sub
End Class