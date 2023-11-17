Imports System.Data
Imports System.Data.SqlClient

Module sql

    Friend cn As New SqlConnection("Data Source=localhost;Initial Catalog=Marathon;Integrated Security=SSPI")
    Friend cmd As New SqlCommand
    Friend da As New SqlDataAdapter
    Friend ds As New DataSet
    Friend DR As SqlDataReader
    Friend sql As String = ""

    Friend Sub Connect()
        If cn.State = ConnectionState.Closed Then
            cn.Open()
        Else : MsgBox("Can't connect to Database!")
        End If
    End Sub

End Module
