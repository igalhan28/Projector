Imports System.IO
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FolderBrowserDialog1.ShowDialog()
        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
tekrar:
        If Not Directory.Exists(FolderBrowserDialog1.SelectedPath + "\Projem") Then
            My.Computer.FileSystem.MoveDirectory("C:\Projector\Proje\exco", FolderBrowserDialog1.SelectedPath)
            My.Computer.FileSystem.CopyDirectory("C:\Projector\Samples\Projexample\exco", "C:\Projector\Proje\exco")
            SetAttr(FolderBrowserDialog1.SelectedPath + "\Projem\Project ", FileAttribute.Hidden)
            Dim nope As StreamReader = New StreamReader(FolderBrowserDialog1.SelectedPath + "\Projem\Project\pron.txt")
            Dim vor As String = nope.ReadLine
            My.Computer.FileSystem.RenameFile(FolderBrowserDialog1.SelectedPath + "\Projem\LOADER.exe", vor + ".exe")
            nope.Close()
            My.Computer.FileSystem.RenameDirectory(FolderBrowserDialog1.SelectedPath + "\Projem", vor)
            Timer1.Enabled = False
            Close()
        Else
            Hide()
            Timer1.Enabled = False
            Dim sonuc As DialogResult = MessageBox.Show("Lütfen Seçilen Klasörden Projem Klasörünü Çekin", "Uyarı", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
            If sonuc = DialogResult.Retry Then
                GoTo tekrar
            Else
                Close()

            End If


        End If


    End Sub


End Class
