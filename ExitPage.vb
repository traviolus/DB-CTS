Public Class ExitPage
    Private Sub ExitPage_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MainMenu.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim ticketId As DataTable = DataConnect.getTableFromDB("select max(ticketid) from ticket where cardid = " + Microsoft.VisualBasic.Chr(34) +
                                                                Me.boxCardID.Text + Microsoft.VisualBasic.Chr(34))
        Dim checkStatus As DataTable = DataConnect.getTableFromDB("select Tstatus from ticket where ticketid = '" + ticketId.Rows(0)(0) + "'")
        If Not checkStatus.Rows(0)(0) = "inuse" Then
            MessageBox.Show("This Card is not In Use", "Invalid Card", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim tripSeq As DataTable = DataConnect.getTableFromDB("select max(tripseq) from triplog where ticketid = " + Microsoft.VisualBasic.Chr(34) + ticketId.Rows(0)(0) + Microsoft.VisualBasic.Chr(34))
        Dim stin As DataTable = DataConnect.getTableFromDB("select sid from triplog where ticketid = " + Microsoft.VisualBasic.Chr(34) + ticketId.Rows(0)(0) +
                                                           Microsoft.VisualBasic.Chr(34) + " and status = " + Microsoft.VisualBasic.Chr(34) + "enter" + Microsoft.VisualBasic.Chr(34) +
                                                           " and tripseq = (select max(tripseq) from triplog where ticketid = " + Microsoft.VisualBasic.Chr(34) + ticketId.Rows(0)(0) + Microsoft.VisualBasic.Chr(34) + ")")
        Dim stout As String = Me.boxStation.Text
        Dim fare As Integer = fareCal(stin.Rows(0)(0), stout)
        Dim ticketType As DataTable = DataConnect.getTableFromDB("select type from ticket where ticketid = " + Microsoft.VisualBasic.Chr(34) + ticketId.Rows(0)(0) +
                                                                Microsoft.VisualBasic.Chr(34))

        If ticketType.Rows(0)(0) = "r" Then
            Dim bal As Integer = DataConnect.getBalance(ticketId.Rows(0)(0))
            If bal < fare Then
                MessageBox.Show("Insufficient Balance" + Environment.NewLine + "Your Current Balance is " + bal.ToString + " (Fare: " + fare.ToString + ")", "Insufficient Balance", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            DataConnect.insertUpdateDeleteDB("INSERT INTO `cts02`.`triplog`(`TicketID`,`TripSeq`,`Time`,`Date`,`Status`,`SID`)
                                             VALUES(" + Microsoft.VisualBasic.Chr(34) + ticketId.Rows(0)(0) + Microsoft.VisualBasic.Chr(34) +
                                            ", " + Microsoft.VisualBasic.Chr(34) + tripSeq.Rows(0)(0).ToString + Microsoft.VisualBasic.Chr(34) +
                                            ", NOW(), NOW(), " + Microsoft.VisualBasic.Chr(34) + "exit" + Microsoft.VisualBasic.Chr(34) +
                                            ", " + Microsoft.VisualBasic.Chr(34) + Me.boxStation.Text + Microsoft.VisualBasic.Chr(34) + ");")
            DataConnect.insertUpdateDeleteDB("UPDATE ticket SET TStatus = " + Microsoft.VisualBasic.Chr(34) + "ready" + Microsoft.VisualBasic.Chr(34) +
                                            "WHERE TicketID = " + Microsoft.VisualBasic.Chr(34) + ticketId.Rows(0)(0) + Microsoft.VisualBasic.Chr(34) + ";")
            DataConnect.insertUpdateDeleteDB("INSERT INTO `cts02`.`ticded`(`TicketID`,`TicSeq`,`Amount`,`TransacDate`,`TransacTime`,`SID`)
                                             VALUES(" + Microsoft.VisualBasic.Chr(34) + ticketId.Rows(0)(0) + Microsoft.VisualBasic.Chr(34) +
                                            ", " + Microsoft.VisualBasic.Chr(34) + DataConnect.assignTicSeqTicded(ticketId.Rows(0)(0)) + Microsoft.VisualBasic.Chr(34) +
                                            ", " + fare.ToString + ", NOW(), NOW(), " + Microsoft.VisualBasic.Chr(34) + stout + Microsoft.VisualBasic.Chr(34) + ");")
            MessageBox.Show("Your current balance is " + DataConnect.getBalance(ticketId.Rows(0)(0)).ToString + " (Fare: " + fare.ToString + ")", "Register Card", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        If ticketType.Rows(0)(0) = "n" Then
            Dim bal As Integer = DataConnect.getBalance(ticketId.Rows(0)(0))
            If bal < fare Then
                MessageBox.Show("Insufficient Balance" + Environment.NewLine + "Your Current Balance is " + bal.ToString + " (Fare: " + fare.ToString + ")", "Insufficient Balance", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            DataConnect.insertUpdateDeleteDB("INSERT INTO `cts02`.`triplog`(`TicketID`,`TripSeq`,`Time`,`Date`,`Status`,`SID`)
                                             VALUES(" + Microsoft.VisualBasic.Chr(34) + ticketId.Rows(0)(0) + Microsoft.VisualBasic.Chr(34) +
                                            ", " + Microsoft.VisualBasic.Chr(34) + tripSeq.Rows(0)(0).ToString + Microsoft.VisualBasic.Chr(34) +
                                            ", NOW(), NOW(), " + Microsoft.VisualBasic.Chr(34) + "exit" + Microsoft.VisualBasic.Chr(34) +
                                            ", " + Microsoft.VisualBasic.Chr(34) + Me.boxStation.Text + Microsoft.VisualBasic.Chr(34) + ");")
            DataConnect.insertUpdateDeleteDB("UPDATE ticket SET TStatus = " + Microsoft.VisualBasic.Chr(34) + "empty" + Microsoft.VisualBasic.Chr(34) +
                                            "WHERE TicketID = " + Microsoft.VisualBasic.Chr(34) + ticketId.Rows(0)(0) + Microsoft.VisualBasic.Chr(34) + ";")
            DataConnect.insertUpdateDeleteDB("INSERT INTO `cts02`.`ticded`(`TicketID`,`TicSeq`,`Amount`,`TransacDate`,`TransacTime`,`SID`)
                                             VALUES(" + Microsoft.VisualBasic.Chr(34) + ticketId.Rows(0)(0) + Microsoft.VisualBasic.Chr(34) +
                                            ", " + Microsoft.VisualBasic.Chr(34) + DataConnect.assignTicSeqTicded(ticketId.Rows(0)(0)) + Microsoft.VisualBasic.Chr(34) +
                                            ", " + bal.ToString + ", NOW(), NOW(), " + Microsoft.VisualBasic.Chr(34) + stout + Microsoft.VisualBasic.Chr(34) + ");")
            MessageBox.Show("Exit Success!", "Non-Register Card", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Function fareCal(stin As String, stout As String) As Integer
        Dim ent As Integer = stin.Substring(2, 3)
        Dim ext As Integer = stout.Substring(2, 3)
        If ent = ext Then
            Return 10
        End If

        Dim max, min, nst, fare As New Integer
        If ent > ext Then
            max = ent
            min = ext
        Else
            max = ext
            min = ent
        End If
        Dim fare1 As Integer = max - min
        Dim fare2 As Integer = (23 - max) + min
        If fare1 < fare2 Then
            nst = fare1
        Else
            nst = fare2
        End If
        fare = 10 + (nst - 1)
        If fare > 22 Then
            Return 22
        Else
            Return fare
        End If
    End Function

End Class