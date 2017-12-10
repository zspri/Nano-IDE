Imports System.Net

Public Class Update
    Private Function CheckUpdates()
        Try
            Dim Client As WebClient = New WebClient()
            Client.Headers.Add("User-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2;)")
            Dim CheckReleases As String = Client.DownloadString("https://api.github.com/repos/Nanomotion/Nano-IDE/releases?per_page=1")
            Dim ReleaseObj = JsonConvert.DeserializeObject(Of List(Of Release))(CheckReleases)
            Dim LatestRelease = ReleaseObj.First()
            If Not ("v" + My.Application.Info.Version.ToString).StartsWith(LatestRelease.tag_name) Then
                MsgBox("A new version of NanoIDE is available: " & LatestRelease.tag_name & vbCrLf & vbCrLf & vbCrLf & vbCrLf & "Download it from https://github.com/Nanomotion/Nano-IDE", vbInformation)
                Me.Close()
                Debug.Print("A new update is available")
            Else
                MsgBox("You have the latest version of NanoIDE. (" + LatestRelease.tag_name + ")", vbInformation)
            End If
        Catch ex As Exception
            MsgBox("Failed to check for updates!" & vbCrLf & vbCrLf & ex.ToString, vbCritical)
            Me.Close()
            Debug.Print(ex.ToString)
        End Try
        Return 0
    End Function

    Private Sub Update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressValue.Location = New Point(ProgressValue.Width * -1, -1)
        Timer1.Start()
        'CheckUpdates()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressValue.Location = New Point(ProgressValue.Location.X + 5, -1)
        If ProgressValue.Location.X > NewProgressBar.Width Then
            ProgressValue.Location = New Point(ProgressValue.Width * -1, -1)
        End If
    End Sub
End Class