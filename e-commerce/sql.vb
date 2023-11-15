Imports System.Data
Imports System.Data.SqlClient

Module sql

    Friend cn As New SqlConnection("Data Source=shutx;Initial Catalog=Product;Integrated Security=SSPI")
    Friend cmd As New SqlCommand
    Friend da As New SqlDataAdapter
    Friend ds As New DataSet
    Friend DR As SqlDataReader
    Friend sql As String = ""

End Module
