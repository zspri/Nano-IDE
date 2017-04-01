Public Class SplashScreen
    Public Function SpamRefresh(ByVal Times As Integer)
        For tmp = 0 To Times
            Me.Refresh()
            Me.Update()
            Application.DoEvents()
            tmp = tmp + 1
        Next
        Return 0
    End Function

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "Version " & My.Application.Info.Version.ToString & vbCrLf & My.Application.Info.Copyright
        SpamRefresh(2000)
    End Sub
End Class