Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class Form1
    Dim MySqlCon As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim READER As MySqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MySqlCon = New MySqlConnection
        MySqlCon.ConnectionString = "server=127.0.0.1;userid=root;password='';database=hansdb"

        Try
            MySqlCon.Open()
            MessageBox.Show("Connection Successful")
            MySqlCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            MySqlCon.Close()
        End Try
    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        MySqlCon = New MySqlConnection
        MySqlCon.ConnectionString = "server=127.0.0.1;userid=root;password='';database=hansdb"
        Dim READER As MySqlDataReader

        Try
            MySqlCon.Open()
            Dim Query As String
            Query = "select * from hansdb.edata where user_name = '" & inpUN.Text & "' and password = '" & inpPas.Text & "'"
            COMMAND = New MySqlCommand(Query, MySqlCon)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0

            While READER.Read
                count = count + 1
            End While

            If count = 1 Then
                MessageBox.Show("Username and password are correct")
                Form2.Show()
                Me.Hide()

            ElseIf count > 1 Then
                MessageBox.Show("Username and password are Duplicate")
            Else
                MessageBox.Show("Username and password are not correct")
            End If
            MySqlCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            MySqlCon.Close()
        End Try
    End Sub
End Class
