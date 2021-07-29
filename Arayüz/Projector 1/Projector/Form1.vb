Public Class Form1


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If True Then

            ProgressBar1.Increment(11)
        End If
        If True Then
            ProgressBar1.Increment(11)
        End If
        If True Then
            ProgressBar1.Increment(11)
        End If
        If True Then
            ProgressBar1.Increment(11)
        End If
        If True Then
            ProgressBar1.Increment(11)
        End If
        If True Then
            ProgressBar1.Increment(11)
        End If
        If True Then
            ProgressBar1.Increment(11)
        End If
        If True Then
            ProgressBar1.Increment(11)
        End If
        If True Then
            My.Computer.FileSystem.DeleteDirectory("C:\Projector\Proje\Compile", FileIO.DeleteDirectoryOption.DeleteAllContents)
            My.Computer.FileSystem.CopyDirectory("C:\Projector\Samples\Projexample\Compile", "C:\Projector\Proje\Compile")
            ProgressBar1.Increment(12)
        End If
        If ProgressBar1.Value = 100 Then
            Projector.Show()
            Me.Hide()
            Timer1.Stop()

        End If
    End Sub


End Class
