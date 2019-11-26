Public Class TripHistory

    Dim arr As String() = New String(9) {}
    Dim itm As ListViewItem() = New ListViewItem(200) {}

    Private Sub ViewHistory_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MainMenu.Show()
    End Sub

    Private Sub boxCardID_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles boxCardID.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnView_Click(sender, e)
        End If
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Me.lstvHistory.Clear()
        lstvHistory.Columns.Clear()
        lstvHistory.HideSelection = False
        lstvHistory.Columns.Add("Pur. Date", 80)
        lstvHistory.Columns.Add("Type", 110)
        lstvHistory.Columns.Add("Status", 65)
        lstvHistory.Columns.Add("Station In", 155)
        lstvHistory.Columns.Add("Station Out", 155)
        lstvHistory.Columns.Add("Date In", 100)
        lstvHistory.Columns.Add("Time In", 70)
        lstvHistory.Columns.Add("Date Out", 100)
        lstvHistory.Columns.Add("Time Out", 75)
        lstvHistory.FullRowSelect = True
        lstvHistory.View = View.Details

        Dim query As String = "SELECT PurDate, Type, Status, SName_IN, SName_OUT, DATE_IN, TIME_IN, DATE_OUT, TIME_OUT FROM triphistory where CardID = '" & Me.boxCardID.Text & "'"
        Dim table As DataTable = DataConnect.getTableFromDB(query)

        For i As Integer = 0 To table.Rows.Count - 1
            arr(0) = table.Rows(i)(0).ToString().Substring(0, 10)
            arr(1) = table.Rows(i)(1).ToString()
            arr(2) = table.Rows(i)(2).ToString()
            arr(3) = table.Rows(i)(3).ToString()
            arr(4) = table.Rows(i)(4).ToString()
            arr(5) = table.Rows(i)(5).ToString()
            arr(6) = table.Rows(i)(6).ToString()
            arr(7) = table.Rows(i)(7).ToString()
            arr(8) = table.Rows(i)(8).ToString()
            itm(0) = New ListViewItem(arr)
            lstvHistory.Items.Add(itm(0))
        Next
    End Sub

    Private Sub TripHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lstvHistory.Clear()
        lstvHistory.Columns.Clear()
        lstvHistory.HideSelection = False
        lstvHistory.Columns.Add("Pur. Date", 80)
        lstvHistory.Columns.Add("Type", 110)
        lstvHistory.Columns.Add("Status", 65)
        lstvHistory.Columns.Add("Station In", 155)
        lstvHistory.Columns.Add("Station Out", 155)
        lstvHistory.Columns.Add("Date In", 100)
        lstvHistory.Columns.Add("Time In", 70)
        lstvHistory.Columns.Add("Date Out", 100)
        lstvHistory.Columns.Add("Time Out", 75)
        lstvHistory.FullRowSelect = True
        lstvHistory.View = View.Details
    End Sub

    Private Sub boxCardID_TextChanged(sender As Object, e As EventArgs) Handles boxCardID.TextChanged
        If boxCardID.Text.Trim().Length() = 10 Then
            btnView_Click(sender, e)
        ElseIf boxCardID.Text.Trim().Length() < 10 Then
            TripHistory_Load(sender, e)
        End If
    End Sub
End Class