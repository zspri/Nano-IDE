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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DialogBoxResult = ColorDialog.ShowDialog()
        If DialogBoxResult = 1 Then
            Me.Cursor = Cursors.WaitCursor
            My.Forms.Editor.TopMenu.BackColor = ColorDialog.Color
            My.Settings.BackColor = ColorDialog.Color
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DialogBoxResult = ColorDialog.ShowDialog()
        If DialogBoxResult = 1 Then
            Me.Cursor = Cursors.WaitCursor
            My.Forms.Editor.TopMenu.ForeColor = ColorDialog.Color
            My.Settings.ForeColor = ColorDialog.Color
            Me.Cursor = Cursors.Default
        End If
    End Sub
End Class