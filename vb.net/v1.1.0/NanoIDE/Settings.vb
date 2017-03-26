Public Class Settings
    Dim DialogBoxResult

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DialogBoxResult = FontDialog.ShowDialog()
        If DialogBoxResult = 1 Then
            Me.Cursor = Cursors.WaitCursor
            My.Forms.Editor.TextArea.Font = FontDialog.Font
            My.Settings.Font = FontDialog.Font
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub FontDialog_Apply(sender As Object, e As EventArgs) Handles FontDialog.Apply
        Me.Cursor = Cursors.WaitCursor
        My.Forms.Editor.TextArea.Font = FontDialog.Font
        My.Settings.Font = FontDialog.Font
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("https://github.com/Nanomotion/Nano-IDE/wiki")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Process.Start("https://github.com/Nanomotion/Nano-IDE/issues")
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "Nano IDE v" & My.Application.Info.Version.ToString & vbCrLf & My.Application.Info.Copyright
    End Sub
End Class