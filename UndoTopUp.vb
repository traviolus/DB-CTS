Public Class UndoTopUp
    Private Sub UndoTopUp_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MainMenu.Show()
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        Dim ticket As DataTable = DataConnect.getTableFromDB("select max(ticketid) from ticket where cardid = " + Microsoft.VisualBasic.Chr(34) +
                                                                Me.boxCardID.Text + Microsoft.VisualBasic.Chr(34))
        Dim ticketID As String = ticket.Rows(0)(0)
        Dim data As DataTable = DataConnect.getTableFromDB("SELECT * from checktopup where ticketid = " + Microsoft.VisualBasic.Chr(34) + ticketID + Microsoft.VisualBasic.Chr(34))
        If Not data.Rows(0)(3) = "TOPUP" Then
            MessageBox.Show("Cannot Undo", "Invalid Card", MessageBoxButtons.OK, MessageBoxIcon.Error)
            With boxCardID
                .Focus()
                .SelectAll()
            End With
            Exit Sub
        End If
        DataConnect.insertUpdateDeleteDB("DELETE FROM tictop where ticketid = " + Microsoft.VisualBasic.Chr(34) + ticketID + Microsoft.VisualBasic.Chr(34) +
                                         " and ticseq = " + Microsoft.VisualBasic.Chr(34) + data.Rows(0)(1).ToString + Microsoft.VisualBasic.Chr(34))
        MessageBox.Show("Undo Success! Current Balance is " + DataConnect.getBalance(ticketID).ToString + " (Amount : " + data.Rows(0)(2).ToString + ")", "Undo Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub boxCardID_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles boxCardID.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnUndo_Click(sender, e)
        End If
    End Sub
End Class