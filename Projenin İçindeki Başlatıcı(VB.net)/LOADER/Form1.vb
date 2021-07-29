Imports System.IO
Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim appPath As String = Application.StartupPath()
        appPath = appPath + "\Project"
        If Directory.Exists(appPath) Then
            My.Computer.FileSystem.DeleteDirectory("C:\Projector\Proje\Project", FileIO.DeleteDirectoryOption.DeleteAllContents)
            My.Computer.FileSystem.CreateDirectory("C:\Projector\Proje\Project")
            My.Computer.FileSystem.CopyDirectory(appPath, "C:\Projector\Proje\Project")
            Shell("C:\Projector\Projector\RUNNER.exe")
            Close()
        End If
    End Sub
End Class
