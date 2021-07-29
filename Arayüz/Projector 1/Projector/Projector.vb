Public Class Projector

    Private Sub Button2_Click(sender As Object, e As EventArgs)


    End Sub







    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Form1.Close()

    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Shell("C:\Projector\Projector\Creator.exe")
        Form1.Close()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Shell("C:/Projector/Projector/RUNNER.exe")
        Form1.Close()
    End Sub
End Class