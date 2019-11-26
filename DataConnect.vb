Imports MySql.Data.MySqlClient

Module DataConnect
    Dim SQLPath As String = "Server=localhost;User Id=root; Password=travrvn620; Database=cts02; Pooling=false; Allow User Variables=True"

    Function connectDB(query As String) As MySqlCommand
        Dim connection As New MySqlConnection(SQLPath)
        connection.Open()
        Dim command As New MySqlCommand(query, connection)
        connection.Close()
        Return command
    End Function

    Function assignTicketID() As String
        Dim ticketTable As DataTable = DataConnect.getTableFromDB("SELECT MAX(TicketID) FROM ticket;")
        If ticketTable.Rows.Count <= 0 Then
            Return "TK00000001"
        ElseIf (IsDBNull(ticketTable.Rows(0)(0))) Then
            Return "TK00000001"
        Else
            Return "TK" + (Val(ticketTable.Rows(0)(0).Substring(2, 8)) + 1).ToString("00000000")
        End If
    End Function

    Function assignCardID() As String
        Dim cardTable As DataTable = DataConnect.getTableFromDB("SELECT MAX(CardID) FROM ticket;")
        If cardTable.Rows.Count <= 0 Then
            Return "CD00000001"
        ElseIf (IsDBNull(cardTable.Rows(0)(0))) Then
            Return "CD00000001"
        Else
            Return "CD" + (Val(cardTable.Rows(0)(0).Substring(2, 8)) + 1).ToString("00000000")
        End If
    End Function

    Function assignTicSeqTictop(TicketID As String) As String
        Dim ticseqTable As DataTable = DataConnect.getTableFromDB("select IFNULL(max(ticseq), 0) from tictop where ticketid = " + Microsoft.VisualBasic.Chr(34) + TicketID + Microsoft.VisualBasic.Chr(34))
        Return Val(ticseqTable.Rows(0)(0)) + 1
    End Function

    Function assignTicSeqTicded(TicketID As String) As String
        Dim ticseqTable As DataTable = DataConnect.getTableFromDB("select IFNULL(max(ticseq), 0) from ticded where ticketid = " + Microsoft.VisualBasic.Chr(34) + TicketID + Microsoft.VisualBasic.Chr(34))
        Return Val(ticseqTable.Rows(0)(0)) + 1
    End Function

    Function assignTripSeq(TicketID As String) As String
        Dim tripseqTable As DataTable = DataConnect.getTableFromDB("select IFNULL(max(tripseq), 0) from triplog where ticketid = " + Microsoft.VisualBasic.Chr(34) + TicketID + Microsoft.VisualBasic.Chr(34))
        Return Val(tripseqTable.Rows(0)(0)) + 1
    End Function

    Function getTableFromDB(query As String) As DataTable
        Dim objConn As New MySqlConnection
        Dim connection As New MySqlConnection(SQLPath)
        connection.Open()
        Dim table As New DataTable()
        Dim objCmd = New MySqlCommand(query, connection)
        Dim objAdapter As New MySqlDataAdapter(objCmd)
        objAdapter.Fill(table)
        connection.Close()
        Return table
    End Function

    Function getBalance(TicketID As String) As Integer
        Dim balTable As New DataTable
        Dim checkDed As Boolean = isNullTicded(TicketID)
        Dim checkTop As Boolean = isNullTicTop(TicketID)
        If checkDed And checkTop Then
            Return 0
        ElseIf checkDed Then
            balTable = DataConnect.getTableFromDB("select @a := (select sum(amount) from tictop where ticketid = " + Microsoft.VisualBasic.Chr(34) + TicketID + Microsoft.VisualBasic.Chr(34) + ");")
        Else
            balTable = DataConnect.getTableFromDB("select @a := (select sum(amount) from tictop where ticketid = " + Microsoft.VisualBasic.Chr(34) + TicketID + Microsoft.VisualBasic.Chr(34) + ") - (select sum(amount) from ticded where ticketid = " + Microsoft.VisualBasic.Chr(34) + TicketID + Microsoft.VisualBasic.Chr(34) + ");")
        End If
        Return Int(balTable.Rows(0)(0))
    End Function

    Function checkCol(id As String, colid As String, col As String, table As String, comp As String) As Boolean
        Dim datTable As DataTable = DataConnect.getTableFromDB("select " + col + " from " + table + " where " + colid + " = " + Microsoft.VisualBasic.Chr(34) + id + Microsoft.VisualBasic.Chr(34) + ";")
        If datTable.Rows(0)(0) = comp Then
            Return True
        Else
            Return False
        End If
    End Function

    Function isNullCol(id As String, colid As String, col As String, table As String) As Boolean
        Dim queryString As String = "select " + col + " from " + table + " where " + colid + " = " + Microsoft.VisualBasic.Chr(34) + id + Microsoft.VisualBasic.Chr(34) + ";"
        Using connection As New MySqlConnection(SQLPath)
            Dim command As New MySqlCommand(queryString, connection)
            connection.Open()
            Dim reader As MySqlDataReader = command.ExecuteReader()
            Try
                If reader.Read() Then
                    Return False
                Else
                    Return True
                End If
            Finally
                reader.Close()
            End Try
        End Using
    End Function

    Function isNullTicded(TicketID As String) As Boolean
        Dim queryString As String = " select * from ticded where ticketid = " + Microsoft.VisualBasic.Chr(34) + TicketID + Microsoft.VisualBasic.Chr(34) + ";"
        Using connection As New MySqlConnection(SQLPath)
            Dim command As New MySqlCommand(queryString, connection)
            connection.Open()
            Dim reader As MySqlDataReader = command.ExecuteReader()
            Try
                If reader.Read() Then
                    Return False
                Else
                    Return True
                End If
            Finally
                reader.Close()
            End Try
        End Using
    End Function

    Function isNullTicTop(TicketID As String) As Boolean
        Dim queryString As String = " select * from tictop where ticketid = " + Microsoft.VisualBasic.Chr(34) + TicketID + Microsoft.VisualBasic.Chr(34) + ";"
        Using connection As New MySqlConnection(SQLPath)
            Dim command As New MySqlCommand(queryString, connection)
            connection.Open()
            Dim reader As MySqlDataReader = command.ExecuteReader()
            Try
                If reader.Read() Then
                    Return False
                Else
                    Return True
                End If
            Finally
                reader.Close()
            End Try
        End Using
    End Function

    Sub insertUpdateDeleteDB(query As String)
        'Dim connection As New SqlConnection(SQLPath)
        'Dim command As New SqlCommand
        'Try
        '    connection.Open()
        '    command = New SqlCommand(query, connection)
        '    command.ExecuteNonQuery()
        'Catch ex As Common.DbException
        '    MsgBox(ex.ToString)
        'Finally
        '    connection.Close()
        'End Try

        Dim connection As New MySqlConnection(SQLPath)
        connection.Open()
        Dim command As New MySqlCommand(query, connection)
        command.ExecuteNonQuery()
        connection.Close()
    End Sub
End Module
