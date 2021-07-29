Imports System.Threading
Public Class Home
    Dim koyuGri As Color


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Close()
    End Sub

    Private Sub Label3_MouseEnter(sender As Object, e As EventArgs) Handles Label3.MouseEnter
        Label3.BackColor = koyuGri


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CurrentThread As Thread = Thread.CurrentThread
        CurrentThread.Priority = ThreadPriority.Highest
        Dim CurrentProcess As Process = Process.GetCurrentProcess
        CurrentProcess.PriorityClass = ProcessPriorityClass.RealTime
        koyuGri = Label3.BackColor
        Label3.BackColor = Color.Black



    End Sub

    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave
        Label3.BackColor = Color.Black
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Hide()
        Visual_Layer.Show()
        Editor.Show()
    End Sub


End Class
