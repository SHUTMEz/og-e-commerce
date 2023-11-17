Imports System.Data.SqlClient

Public Class Stock
    Dim cn As New SqlConnection("Data Source=localhost;Initial Catalog=Marathon;Integrated Security=SSPI")
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim dr As SqlDataReader
    Dim sql As String = ""

    Private Sub Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnect()
    End Sub
    Friend Sub dbConnect()
        If cn.State = ConnectionState.Closed Then
            cn.Open()
        Else : MsgBox("Can't connect to Database!")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        Home.Show()
    End Sub
End Class