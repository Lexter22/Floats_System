﻿Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblFloats.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim password As String = "1234"

        If txtPassword.Text = password And txtUsername.Text = "Rianne " Then
            MessageBox.Show("WELCOME RIANNE")
        Else
            MessageBox.Show("WRONG PASSWORD")

        End If
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblPassword.Click

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub
End Class
