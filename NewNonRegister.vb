Public Class NewNonRegister
    Private Sub NewNonRegister_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MainMenu.Show()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim cardID As String = Me.boxCardID.Text
        Dim nullCard As Boolean = DataConnect.isNullCol(cardID, "CardID", "CardID", "ticket")
        Dim emptyCard As New Boolean
        Dim errorMsg As String = "This card is already registered!"
        If Not nullCard Then
            emptyCard = DataConnect.checkCol(cardID, "CardID", "Tstatus", "ticket", "empty")
            If emptyCard Then
                nullCard = True
            ElseIf DataConnect.checkCol(cardID, "CardID", "type", "ticket", "n") Then
                errorMsg = "This card is not empty!"
            End If
        End If
        If Int(boxAmount.Text) > 20 Or Int(boxAmount.Text) < 10 Then
            MessageBox.Show("Invalid Amount", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error)
            With boxAmount
                .Focus()
                .SelectAll()
            End With
            Exit Sub
        End If

        If nullCard Then
            Dim ticketID As String = DataConnect.assignTicketID()
            Dim strSQL As String = "INSERT INTO `cts02`.`ticket` (`TicketID`,`CardID`, `PurDate`, `Type`, `CID`, `TStatus`)
                                VALUES (" + Microsoft.VisualBasic.Chr(34) + ticketID + Microsoft.VisualBasic.Chr(34) + ", " +
                                Microsoft.VisualBasic.Chr(34) + cardID + Microsoft.VisualBasic.Chr(34) + ", NOW(), " +
                                Microsoft.VisualBasic.Chr(34) + "n" + Microsoft.VisualBasic.Chr(34) +
                                ", NULL, " + Microsoft.VisualBasic.Chr(34) + "paid" + Microsoft.VisualBasic.Chr(34) + ");"
            Dim strSQL2 As String = "INSERT INTO `cts02`.`tictop` (`TicketID`, `TicSeq`, `Amount`, `TransacDate`, `TransacTime`, `SID`)
                                VALUES (" + Microsoft.VisualBasic.Chr(34) + ticketID + Microsoft.VisualBasic.Chr(34) + ", " + assignTicSeqTictop(ticketID) +
                                    ", " + Me.boxAmount.Text + ", NOW(), NOW(), " + Microsoft.VisualBasic.Chr(34) + Me.boxStation.Text +
                                    Microsoft.VisualBasic.Chr(34) + ");"
            DataConnect.insertUpdateDeleteDB(strSQL)
            DataConnect.insertUpdateDeleteDB(strSQL2)
            MessageBox.Show("New Non-Register Card Created!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(errorMsg, "Invalid Card", MessageBoxButtons.OK, MessageBoxIcon.Error)
            With boxCardID
                .Focus()
                .SelectAll()
            End With
        End If
    End Sub
End Class