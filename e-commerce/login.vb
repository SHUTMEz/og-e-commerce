Imports System.Data.SqlClient

Public Class login
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Connect()
        Dim sql = String.Format("SELECT * FROM `Members` WHERE Email = '{0}' AND Password = '{1}'", Me.Email.Text, Me.Password.Text)
        Dim da = New SqlDataAdapter(sql, cn)
        Dim ds = New DataSet
        da.Fill(ds, "Members")

        If ds.Tables("Members").Rows.Count <= 0 Then
            MsgBox("Login Error!")
            Email.Text = ""
            Password.Text = ""
            Return
        Else
            MsgBox("Login Success!")
            Me.Hide()
        End If
    End Sub
End Class