Public Class EnterPage
    Private Sub EnterPage_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MainMenu.Show()
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim ticketId As DataTable = DataConnect.getTableFromDB("select max(ticketid) from ticket where cardid = " + Microsoft.VisualBasic.Chr(34) +
                                                                Me.boxCardID.Text + Microsoft.VisualBasic.Chr(34))
        Dim ticketType As DataTable = DataConnect.getTableFromDB("select type from ticket where ticketid = " + Microsoft.VisualBasic.Chr(34) + ticketId.Rows(0)(0) +
                                                                 Microsoft.VisualBasic.Chr(34))
        If ticketType.Rows(0)(0) = "r" Then
            Dim checkStatus As DataTable = DataConnect.getTableFromDB("select Tstatus from ticket where ticketid = '" + ticketId.Rows(0)(0) + "'")
            If Not checkStatus.Rows(0)(0) = "ready" Then
                MessageBox.Show("This Card is not Ready to Use", "Invalid Card", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim bal As Integer = DataConnect.getBalance(ticketId.Rows(0)(0))
            If bal < 10 Then
                MessageBox.Show("Insufficient Balance (Your balance : " + bal.ToString + ")", "Register Card", MessageBoxButtons.OK, MessageBoxIcon.Information)
                With boxCardID
                    .Focus()
                    .SelectAll()
                End With
                Exit Sub
            End If
            MessageBox.Show("Your current balance is " + bal.ToString, "Register Card", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DataConnect.insertUpdateDeleteDB("INSERT INTO `cts02`.`triplog`(`TicketID`,`TripSeq`,`Time`,`Date`,`Status`,`SID`)
                                             VALUES(" + Microsoft.VisualBasic.Chr(34) + ticketId.Rows(0)(0) + Microsoft.VisualBasic.Chr(34) +
                                             ", " + Microsoft.VisualBasic.Chr(34) + DataConnect.assignTripSeq(ticketId.Rows(0)(0)) + Microsoft.VisualBasic.Chr(34) +
                                             ", NOW(), NOW(), " + Microsoft.VisualBasic.Chr(34) + "enter" + Microsoft.VisualBasic.Chr(34) +
                                             ", " + Microsoft.VisualBasic.Chr(34) + Me.boxStation.Text + Microsoft.VisualBasic.Chr(34) + ");")
            DataConnect.insertUpdateDeleteDB("UPDATE ticket SET TStatus = " + Microsoft.VisualBasic.Chr(34) + "inuse" + Microsoft.VisualBasic.Chr(34) +
                                             "WHERE TicketID = " + Microsoft.VisualBasic.Chr(34) + ticketId.Rows(0)(0) + Microsoft.VisualBasic.Chr(34) + ";")
        ElseIf ticketType.Rows(0)(0) = "n" Then
            Dim checkStatus As DataTable = DataConnect.getTableFromDB("select Tstatus from ticket where ticketid = '" + ticketId.Rows(0)(0) + "'")
            If Not checkStatus.Rows(0)(0) = "paid" Then
                MessageBox.Show("This Card is not Ready to Use", "Invalid Card", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim bal As Integer = DataConnect.getBalance(ticketId.Rows(0)(0))
            If bal < 10 Then
                MessageBox.Show("Insufficient Balance (Your balance : " + bal.ToString + ")", "Non-Register Card", MessageBoxButtons.OK, MessageBoxIcon.Information)
                With boxCardID
                    .Focus()
                    .SelectAll()
                End With
                Exit Sub
            End If
            MessageBox.Show("Your current balance is " + bal.ToString, "Non-Register Card", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DataConnect.insertUpdateDeleteDB("INSERT INTO `cts02`.`triplog`(`TicketID`,`TripSeq`,`Time`,`Date`,`Status`,`SID`)
                                             VALUES(" + Microsoft.VisualBasic.Chr(34) + ticketId.Rows(0)(0) + Microsoft.VisualBasic.Chr(34) +
                                             ", " + Microsoft.VisualBasic.Chr(34) + DataConnect.assignTripSeq(ticketId.Rows(0)(0)) + Microsoft.VisualBasic.Chr(34) +
                                             ", NOW(), NOW(), " + Microsoft.VisualBasic.Chr(34) + "enter" + Microsoft.VisualBasic.Chr(34) +
                                             ", " + Microsoft.VisualBasic.Chr(34) + Me.boxStation.Text + Microsoft.VisualBasic.Chr(34) + ");")
            DataConnect.insertUpdateDeleteDB("UPDATE ticket SET TStatus = " + Microsoft.VisualBasic.Chr(34) + "inuse" + Microsoft.VisualBasic.Chr(34) +
                                             "WHERE TicketID = " + Microsoft.VisualBasic.Chr(34) + ticketId.Rows(0)(0) + Microsoft.VisualBasic.Chr(34) + ";")
        End If
    End Sub
End Class