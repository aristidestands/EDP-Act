Imports MySql.Data.MySqlClient
Public Class login


    REM  Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    REM End Sub

    REM  Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    REM  End Sub

    REM Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
    REM    If txtUsername.Text = "user" And txtPassword.Text = "user1" Then
    REM        MsgBox("Login Successfully!")
    REM        txtUsername.Text = ""
    REM        txtPassword.Text = ""
    REM        landing.Show()
    REM    Me.Hide()


    REM    Else
    REM       MsgBox("Wrong Input User!")
    REM       txtUsername.Text = ""
    REM       txtPassword.Text = ""
    REM  End If


    REM End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (txtUsername.Text = "") Then
            MsgBox("Enter Username")
            Exit Sub
        End If
        If (txtPassword.Text = "") Then
            MsgBox("Enter Password")
            Exit Sub
        End If
        With Me
            Call Connect_to_DB()
            Dim mycomm As New MySqlCommand
            Dim myreader As MySqlDataReader

            Dim mysql As String
            mysql = "select * from users where username='" & txtUsername.Text & "' and password='" & txtPassword.Text & "'"

            mycomm.Connection = myconn
            mycomm.CommandText = mysql

            myreader = mycomm.ExecuteReader
            If myreader.HasRows Then
                .Hide()
                landing.Show()
                myconn.Close()
            Else
                MessageBox.Show("Invalid username or password!")
                myconn.Close()
            End If
        End With
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub


End Class
