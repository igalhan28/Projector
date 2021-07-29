Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.FileSystem.DeleteDirectory("C:\Projector\Proje\OC\Projem", FileIO.DeleteDirectoryOption.DeleteAllContents)
        My.Computer.FileSystem.CopyDirectory("C:\Projector\Samples\Projexample\only", "C:\Projector\Proje\only")
        Close()
    End Sub
End Class
