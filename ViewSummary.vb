Public Class ViewSummary
    Private Sub ViewHistory_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MainMenu.Show()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim income As DataTable = DataConnect.getTableFromDB("select sum(amount) from tictop where transacdate between " + "'" + Me.boxFrom.Text + "'" + " and " + "'" + Me.boxTo.Text + "'")
        Me.lblInc.Text = income.Rows(0)(0)
        Dim trip As DataTable = DataConnect.getTableFromDB("select count(*) from triplog where status = 'exit' and date between" + "'" + Me.boxFrom.Text + "'" + " and " + "'" + Me.boxTo.Text + "'")
        Me.lblTrip.Text = trip.Rows(0)(0)
        Me.lblAvg.Text = (Double.Parse(income.Rows(0)(0)) / Double.Parse(trip.Rows(0)(0))).ToString
    End Sub

    Private Sub ViewSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        boxFrom.Format = DateTimePickerFormat.Custom
        boxFrom.CustomFormat = "yyyy-MM-dd"
        boxTo.Format = DateTimePickerFormat.Custom
        boxTo.CustomFormat = "yyyy-MM-dd"
    End Sub
End Class