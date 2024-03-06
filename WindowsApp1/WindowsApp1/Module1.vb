
Imports System.Data.Odbc

Module Module1
    Public cn As OdbcConnection
    Public cmd As OdbcCommand
    Public dr As OdbcDataReader
    Public sql As String

    Public Sub openCon()
        cn = New OdbcConnection("DSN=db_uniresidence")

        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If
    End Sub

End Module
