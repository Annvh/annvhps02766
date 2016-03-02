Imports System.Data.SqlClient

Module HelpVB
    Public ds As New DataSet

    Public Connectionstring As String = "Data Source=K8OTZ8J18KBFPCT\SQLEXPRESS;Initial Catalog=annvhps02766;Integrated Security=True"

    Public Sub ExecuteNonQuery(sql As String)
        Dim Connection As New SqlConnection(Connectionstring)
        Dim Command As New SqlCommand(sql, Connection)
        Connection.Open()
        Command.ExecuteNonQuery()
        Connection.Close()
    End Sub

    Public Sub Connect(sql As String, TableName As String)
        Dim Connection As New SqlConnection(Connectionstring)
        Dim DataAdapter As New SqlDataAdapter(sql, Connection)
        If ds.Tables.Contains(TableName) Then
            ds.Tables(TableName).Clear()
        End If
        DataAdapter.Fill(ds, TableName)
    End Sub
End Module
