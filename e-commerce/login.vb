Imports System.Data
Imports System.Data.SqlClient

Public Class login

    Dim cn As New SqlConnection("Data Source=localhost;Initial Catalog=Marathon;Integrated Security=SSPI")
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim dr As SqlDataReader
    Dim sql As String = ""

    Friend Sub dbConnect()
        If cn.State = ConnectionState.Closed Then
            cn.Open()
        Else : MsgBox("Can't connect to Database!")
        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try

            sql = "SELECT * FROM Members WHERE Email = @Email AND Password = @Password"
            da = New SqlDataAdapter(sql, cn)
            da.SelectCommand.Parameters.AddWithValue("@Email", Me.txtEmail.Text)
            da.SelectCommand.Parameters.AddWithValue("@Password", Me.txtPassword.Text)

            da.Fill(ds, "Members")

            If ds.Tables("Members").Rows.Count <= 0 Then
                MsgBox("Login ไม่สำเร็จ.")
                txtPassword.Text = ""
            Else
                Me.Hide()
                Stock.Show()
                Stock.lblName.Text = ds.Tables("Members").Rows(0)("Firstname").ToString() + " " + ds.Tables("Members").Rows(0)("Lastname").ToString()
                Stock.lblEmail.Text = txtEmail.Text
            End If
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnect()
    End Sub
End Class