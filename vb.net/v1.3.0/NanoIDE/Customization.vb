Public Class Customization
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
End Class