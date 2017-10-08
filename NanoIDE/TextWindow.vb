Public Class TextWindow
    Dim origText

    Public Function SetText(BoxText As String)
        origText = BoxText
        TextArea.Text = BoxText
        Return BoxText
    End Function
    Private Sub TextWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.UseLightTheme Then
            TextArea.ForeColor = Color.Black
            TextArea.BackColor = Color.FromArgb(234, 234, 236)
            Me.BackColor = Color.White
        End If
    End Sub

    Private Sub TextArea_TextChanged(sender As Object, e As EventArgs) Handles TextArea.TextChanged
        If Not TextArea.Text = origText Then
            TextArea.Text = origText
        End If
    End Sub
End Class