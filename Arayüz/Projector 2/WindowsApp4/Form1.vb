Imports System.IO
Public Class Form1
    '      -----                                                                                    --------    -------- 
    '    ---------                                                                                  --------    --------
    '     -------                                                                                   --------    --------                                        
    '-----------------                                                                      -----   --------    --------                               -------  --------          
    '-----------------                                                     -------------    -----   --------    --------                               -------  -------- ------------
    '    ---------                                 ----                 ------------------- -----   --------    --------                     -----------------  ----------------------
    '    ---------                     ---------   -----            ----------------------------    --------    --------    ---------     --------------------  -----------------------
    '    ---------                ----------------------            ---------           --------    --------    --------  -------------   --------------------  --------       --------     
    '    ---------            ---------------------------           --------            --------    --------    ------------------------- --------    --------  --------       --------
    '    ---------            ---------             -------         --------            --------    --------    ------------------------- --------    --------  --------       --------
    '    ---------            ---------              -------        --------            --------    --------    --------         -------- --------    --------  --------       --------
    '-----------------        ---------               -------       --------            --------    --------    --------         -------- --------    --------  --------       --------
    '-----------------         ---------               ------       --------            --------    --------    --------         -------- --------    --------  --------       --------
    '-----------------          ----------------------------        -----------------------------   --------    --------         --------   ----------------    --------       --------        
    '-----------------               --------------------             ------------------------
    '                                          ---------
    '                                          ---------
    '                                           ---------
    '                                           ---------
    '                                           ---------
    '                                           --------    
    '                             ------------------------           
    '                               --------------------
    '                                  ---------------





    Private Sub ToolStripSplitButton1_ButtonClick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Close()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub OLANIAÇToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub URDELEToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub KLASÖRSEÇToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub AÇToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Shell("C:\Projector\Projector\RUNNER.exe")
        Close()
    End Sub

    Private Sub ExUYUMLULUKMODUToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub KLASİKToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        Shell("C:\Projector\Projector\Creator.exe")
        Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles Button1.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then MessageBox.Show("Right click")

        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Shell("C:\Projector\Projector\Creator.exe")
            Close()
        End If

    End Sub

    Private Sub Button2_MouseDown(sender As Object, e As MouseEventArgs) Handles Button2.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Shell("C:\Projector\Projector\onlyCreator.exe")
            Close()
        End If
        If e.Button = System.Windows.Forms.MouseButtons.Right Then

            OpenFileDialog1.ShowDialog()
            File.Copy(OpenFileDialog1.FileName, "C:\Projector\Proje\onlyRedit\OD\redit.pjx")
            Shell("C:\Projector\Projector\ordecompressor.exe")
        End If
    End Sub

    Private Sub Button4_MouseDown(sender As Object, e As MouseEventArgs) Handles Button4.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Shell("C:\Projector\Projector\exCreator.exe")
            Close()
        End If
    End Sub

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
