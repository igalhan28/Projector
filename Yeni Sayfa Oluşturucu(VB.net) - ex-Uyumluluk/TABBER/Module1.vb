Imports System.IO
Module Module1

    Sub Main()
        Console.Title = "TABBER"
        Console.WriteLine("TAB ekleniyor lütfen bekleyin...")
        Dim x As Long = 2
xdon:
        If Not Directory.Exists("C:\Projector\Proje\exco\Projem\Project\TAB" + Convert.ToString(x)) Then
            My.Computer.FileSystem.CopyDirectory("C:\Projector\Samples\exTABBER", "C:\Projector\Proje\exco\Projem\Project")
            My.Computer.FileSystem.RenameDirectory("C:\Projector\Proje\exco\Projem\Project\TAB", "TAB" + Convert.ToString(x))
        Else
            x += 1
            GoTo xdon
        End If

    End Sub

End Module
