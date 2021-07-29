Imports System.IO
Module Module1

    Sub Main()
        Console.Title = "TABBER"
        Console.WriteLine("TAB ekleniyor lütfen bekleyin...")
        Dim x As Long = 2
xdon:

        If Not Directory.Exists("C:\Projector\Proje\only\Projem\OP\TAB" + Convert.ToString(x)) Then
            My.Computer.FileSystem.CopyDirectory("C:\Projector\Samples\onlyTABBER", "C:\Projector\Proje\only\Projem\OP")
            My.Computer.FileSystem.RenameDirectory("C:\Projector\Proje\only\Projem\OP\TAB", "TAB" + Convert.ToString(x))
        Else
            x += 1
            GoTo xdon
        End If

    End Sub

End Module
