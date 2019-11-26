Public Class TopUp
    Private Sub TopUp_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MainMenu.Show()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim balTable As New DataTable
        Dim ticketId As DataTable = DataConnect.getTableFromDB("select max(ticketid) from ticket where cardid = " + Microsoft.VisualBasic.Chr(34) +
                                                                Me.boxCardID.Text + Microsoft.VisualBasic.Chr(34))

        If (ticketId.Rows(0)(0) = "") Then
            MessageBox.Show("Please Enter the Card ID", "No Card ID", MessageBoxButtons.OK, MessageBoxIcon.Error)
            With boxCardID
                .Focus()
                .SelectAll()
            End With
            Exit Sub
        End If
        If (boxAmount.Text = "") Then
            MessageBox.Show("Please Enter the Amount", "No Amount", MessageBoxButtons.OK, MessageBoxIcon.Error)
            With boxAmount
                .Focus()
                .SelectAll()
            End With
            Exit Sub
        End If
        If (Int(boxAmount.Text) < 20 Or Int(boxAmount.Text) > 1000) Then
            MessageBox.Show("Invalid Amount", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error)
            With boxAmount
                .Focus()
                .SelectAll()
            End With
            Exit Sub
        End If
        If DataConnect.checkCol(ticketId.Rows(0)(0), "TicketID", "type", "ticket", "n") Then
            MessageBox.Show("Non-Register Card Cannot Top Up", "Invalid Card", MessageBoxButtons.OK, MessageBoxIcon.Error)
            With boxCardID
                .Focus()
                .SelectAll()
            End With
            Exit Sub
        End If
        If (Int(boxAmount.Text) + DataConnect.getBalance(ticketId.Rows(0)(0)) > 3000) Then
            MessageBox.Show("Balance Cannot Be More Than 3000", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error)
            With boxAmount
                .Focus()
                .SelectAll()
            End With
            Exit Sub
        End If


        Dim strSQL As String = "INSERT INTO `cts02`.`tictop` (`TicketID`, `TicSeq`, `Amount`, `TransacDate`, `TransacTime`, `SID`)
                                VALUES (" + Microsoft.VisualBasic.Chr(34) + ticketId.Rows(0)(0) + Microsoft.VisualBasic.Chr(34) + ", " + assignTicSeqTictop(ticketId.Rows(0)(0)) + ", " + Me.boxAmount.Text + ", NOW(), NOW(), " + Microsoft.VisualBasic.Chr(34) + Me.boxStation.Text + Microsoft.VisualBasic.Chr(34) + "); "
        DataConnect.insertUpdateDeleteDB(strSQL)
        Dim bal As Integer = DataConnect.getBalance(ticketId.Rows(0)(0))
        MessageBox.Show("Your New Balance is " + bal.ToString, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Exit Sub
    End Sub

    Private Sub boxStation_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles boxStation.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnCreate_Click(sender, e)
        End If
    End Sub
End Class