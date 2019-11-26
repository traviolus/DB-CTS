Public Class ViewHistory
    Private Sub ViewHistory_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MainMenu.Show()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim typeTable, purTable As New DataTable
        Dim ticketId As DataTable = DataConnect.getTableFromDB("select max(ticketid) from ticket where cardid = " + Microsoft.VisualBasic.Chr(34) +
                                                                Me.boxCardID.Text + Microsoft.VisualBasic.Chr(34))
        typeTable = DataConnect.getTableFromDB("select type from ticket where ticketid = " + Microsoft.VisualBasic.Chr(34) + ticketId.Rows(0)(0) + Microsoft.VisualBasic.Chr(34))
        Dim bal As Integer = DataConnect.getBalance(ticketId.Rows(0)(0))
        purTable = DataConnect.getTableFromDB("select purDate from ticket where  ticketid = " + Microsoft.VisualBasic.Chr(34) + ticketId.Rows(0)(0) + Microsoft.VisualBasic.Chr(34))
        History.typeTable = typeTable
        History.bal = bal
        History.purTable = purTable
        History.Show()
        Me.Hide()
        Me.boxCardID.ResetText()
    End Sub

    Private Sub boxCardID_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles boxCardID.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnView_Click(sender, e)
        End If
    End Sub

End Class