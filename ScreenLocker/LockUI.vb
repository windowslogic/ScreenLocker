﻿Public Class LockUI

    Private Sub LockUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "Only " + Environment.UserDomainName + "\" + Environment.UserName + " can unlock this computer."
    End Sub

    Private Sub Form_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Main.message.Length = 0 Then
            MsgBox("This computer has been locked by ScreenLocker." + vbNewLine + "The user has not left a help message.")
        Else MsgBox("This computer has been locked by ScreenLocker." + vbNewLine + "Help message left by user: " + Main.message)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = Main.password Then
            Main.Close()
        Else MsgBox("Incorrect password!")
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox1.PasswordChar = ""
        ElseIf CheckBox1.Checked = False Then
            TextBox1.PasswordChar = "*"
        End If
    End Sub
End Class