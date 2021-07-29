Imports System.IO
Public Class Form1



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        My.Computer.FileSystem.DeleteDirectory("C:\Projector\Proje\OP", FileIO.DeleteDirectoryOption.DeleteAllContents)
        Directory.CreateDirectory("C:\Projector\Proje\OP")
        My.Computer.FileSystem.CopyDirectory("C:\Projector\Proje\OD\DC\Projem\OP", "C:\Projector\Proje\OP")
        Shell("C:\Projector\Projector\onlyRUNNER.exe")
        My.Computer.FileSystem.DeleteDirectory("C:\Projector\Proje\OD", FileIO.DeleteDirectoryOption.DeleteAllContents)
        Directory.CreateDirectory("C:\Projector\Proje\OD")
        Close()
    End Sub
End Class
