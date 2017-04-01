Public Class Settings
    Dim DialogBoxResult

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("https://github.com/Nanomotion/Nano-IDE/wiki")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Process.Start("https://github.com/Nanomotion/Nano-IDE/issues")
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "Nano IDE v" & My.Application.Info.Version.ToString & vbCrLf & My.Application.Info.Copyright
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Customization.Show()
    End Sub
End Class