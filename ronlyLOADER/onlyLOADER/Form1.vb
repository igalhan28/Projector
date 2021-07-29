Imports System.IO
Public Class Form1



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        My.Computer.FileSystem.DeleteDirectory("C:\Projector\Proje\OP", FileIO.DeleteDirectoryOption.DeleteAllContents)
        Directory.CreateDirectory("C:\Projector\Proje\OP")
        My.Computer.FileSystem.CopyDirectory("C:\Projector\Proje\onlyRedit\OD\DC\", "C:\Projector\Proje\only")
        Shell("C:\Projector\Projector\onlyCreator.exe")
        My.Computer.FileSystem.DeleteDirectory("C:\Projector\Proje\OD", FileIO.DeleteDirectoryOption.DeleteAllContents)
        Directory.CreateDirectory("C:\Projector\Proje\OD")
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
