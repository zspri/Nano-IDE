Public Class Settings
    Dim DialogBoxResult

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("https://github.com/Nanomotion/Nano-IDE/wiki")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Process.Start("https://github.com/Nanomotion/Nano-IDE/issues")
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "Nano IDE v" & My.Application.Info.Version.ToString & vbCrLf & My.Application.Info.Copyright & vbCrLf & "Powered by GitHub"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Customization.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Process.Start("https://github.com")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Updater.Show()
    End Sub
End Class