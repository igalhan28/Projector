Public Class Editor

    Dim i As Integer

    Private Sub sellektör()
        ResimSeç.ShowDialog()
        Try
            AltResim.Image = Image.FromFile(ResimSeç.FileName)
        Catch ex As Exception
            AltResim.Visible = False
            anavideo.Visible = True
            anavideo.URL = ResimSeç.FileName
        End Try
    End Sub

     
    Private Sub lifesaver()
        Başlık.SaveFile("C:\igalhan\ProjectorStudio\UH\stüdyo\S" + Convert.ToString(i) + "başlık.plog")
        Metin2.SaveFile("C:\igalhan\ProjectorStudio\UH\stüdyo\S" + Convert.ToString(i) + "metin.plog")

    End Sub
    Private Sub Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vrl.Enabled = True
        i = 1
        Dim X As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim Y As Integer = Screen.PrimaryScreen.Bounds.Width
        Height = X
        Width = Y
        SaçTarayıcı.Navigate("http://www.google.com")


    End Sub

    Private Sub Editor_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Home.Close()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles KapatŞunu.Click
        Home.Close()

    End Sub

    Private Sub ToolStripDropDownButton2_Click(sender As Object, e As EventArgs) Handles LightSaver.Click
        lifesaver()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles AltResim.Click
        sellektör()
    End Sub

    Private Sub anavideo_ClickEvent(sender As Object, e As AxWMPLib._WMPOCXEvents_ClickEvent)
        sellektör()
    End Sub

    Private Sub ÜstResim_Click(sender As Object, e As EventArgs) Handles ÜstResim.Click
        ResimSeç.ShowDialog()
        ÜstResim.Image = Image.FromFile(ResimSeç.FileName)

    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles Projector.Click
        About.Show()
    End Sub

    Private Sub YürüGit_Click(sender As Object, e As EventArgs) Handles YürüGit.Click
        SaçTarayıcı.Navigate(LinkAt.Text)
    End Sub



    Private Sub yokol_Tick(sender As Object, e As EventArgs) Handles yokol.Tick



        If Opacity >= 0.01 Then
            Opacity -= 0.01
        Else
            vrl.Enabled = True
            yokol.Enabled = False
        End If

    End Sub

    Private Sub AnaEkran_Enter(sender As Object, e As EventArgs) Handles AnaEkran.Enter

        Me.ResimSeç.FileName = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)


    End Sub

    Private Sub vrl_Tick(sender As Object, e As EventArgs) Handles vrl.Tick


        If Opacity <= Convert.ToDouble(TrackBar1.Value) / 100 Then
            Opacity += 0.01
        Else

            vrl.Enabled = False
            yokol.Enabled = False
        End If
    End Sub

    Private Sub FadeInAndOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FadeInAndOutToolStripMenuItem.Click
        yokol.Enabled = True
    End Sub

    Private Sub GeriZekalı_Click(sender As Object, e As EventArgs) Handles GeriZekalı.Click
        SaçTarayıcı.GoBack()
    End Sub

    Private Sub İleriZekalı_Click(sender As Object, e As EventArgs) Handles İleriZekalı.Click
        SaçTarayıcı.GoForward()
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Opacity = Convert.ToDouble(TrackBar1.Value) / 100
        Label2.Text = "%" + Convert.ToString(TrackBar1.Value)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub


End Class