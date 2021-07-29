Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim arguments As String = Command()
        If Not arguments = String.Empty Then
            Dim tempstr = arguments.Replace("""", "")
            My.Computer.FileSystem.CopyFile(tempstr, "C:\Projector\Proje\OD\projem.pjx")
            Shell("C:\Projector\Projector\decompress.exe")
            Close()


        End If
    End Sub


End Class
