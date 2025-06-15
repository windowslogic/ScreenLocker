Public Class Main
    Public Shared password As String
    Public Shared message As String
    Dim Times As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Times = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles AboutButton.Click
        MsgBox("ScreenLocker " + My.Application.Info.Version.ToString + " by Eri/Noxyntious" + Environment.NewLine + "Licensed under MIT")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles LockButton.Click
        If TextBox1.TextLength = 0 Then
            MsgBox("Set a password first!")
        ElseIf TextBox1.Text = TextBox2.Text Then
            If Times = 0 Then
                MsgBox("Not a good idea to set the message as the password." + vbNewLine + "If you really want to though, click the Lock button again.")
                Times = 1
            Else GoTo Lock
            End If
        Else
Lock:
            password = TextBox1.Text
            message = TextBox2.Text
            Me.Hide()
            Backdrop.Show()
            LockUI.Show()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox1.PasswordChar = ""
        ElseIf CheckBox1.Checked = False Then
            TextBox1.PasswordChar = "*"
        End If
    End Sub
End Class
