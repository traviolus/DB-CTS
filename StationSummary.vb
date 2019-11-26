Public Class StationSummary

    Private Sub ViewHistory_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MainMenu.Show()
    End Sub


    Private Sub StationSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvData.DataSource = DataConnect.getTableFromDB("SELECT * FROM StationView")
        dgvData.Sort(dgvData.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
    End Sub
End Class