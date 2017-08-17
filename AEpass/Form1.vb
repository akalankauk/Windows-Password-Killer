Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator) Then
            MsgBox("Done! PC Password Was Changed!")
        Else
            MsgBox("Sorry!I Do Not Have Admin Privileges To Change PC Password.[Please Run Me As Administrator ]#AE Dev")
            Application.Exit()
        End If
        Dim textvar As String = TextBox2.Text
        Dim textvar2 As String = TextBox1.Text
        Dim Command As String
        Command = "net user" & " " & textvar & " " & textvar2
        Shell("cmd /k" & Command, 1, True)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Command As String
        Command = "net user"
        Shell("cmd /k" & Command, 1, True)
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim url As String = "https://github.com/akalankauk"
        Process.Start(url)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim Command As String
        Dim textvar As String = TextBox2.Text
        Command = "net user" & " " & textvar
        Shell("cmd /k" & Command, 1, True)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MessageBox.Show("Make Your Pc Volume 50%-40%. :D | Use at your own risk!", _
                        "Important!")
        My.Computer.Audio.Play(My.Resources.AEdev, AudioPlayMode.BackgroundLoop)
    End Sub
End Class
