Public Class Visual_Layer
    Private Sub Visual_Layer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim X As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim Y As Integer = Screen.PrimaryScreen.Bounds.Height
        Height = Y
        Width = X
    End Sub
End Class