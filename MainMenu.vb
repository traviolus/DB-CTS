Imports MySql.Data.MySqlClient
Imports System.Data
Public Class MainMenu
    Private Sub btnNewNonRegister_Click(sender As Object, e As EventArgs) Handles btnNewNonRegister.Click
        NewNonRegister.Show()
        Me.Hide()
    End Sub

    Private Sub btnNewRegister_Click(sender As Object, e As EventArgs) Handles btnNewRegister.Click
        NewRegister.Show()
        Me.Hide()
    End Sub

    Private Sub btnTopup_Click(sender As Object, e As EventArgs) Handles btnTopup.Click
        TopUp.Show()
        Me.Hide()
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        ViewHistory.Show()
        Me.Hide()
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        EnterPage.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ExitPage.Show()
        Me.Hide()
    End Sub

    Private Sub btnSummary_Click(sender As Object, e As EventArgs) Handles btnSummary.Click
        ViewSummary.Show()
        Me.Hide()
    End Sub

    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        Dim objConn As New MySqlConnection
        Dim objCmd As New MySqlCommand
        Dim strConnString, strSQL As String

        strConnString = "Server=localhost;User Id=root; Password=travrvn620; Database=cts02; Pooling=false"
        objConn.ConnectionString = strConnString
        objConn.Open()

        Dim intNumRows As Integer
        strSQL = "SELECT * FROM customer WHERE CFirstName = '" & Me.txtName.Text & "' AND CLastName = '" & Me.txtPass.Text & "'"
        MsgBox(strSQL)
        objCmd = New MySqlCommand(strSQL, objConn)
        intNumRows = objCmd.ExecuteScalar()

        objConn.Close()
        objConn = Nothing

    End Sub

    Private Sub btnTrip_Click(sender As Object, e As EventArgs) Handles btnTrip.Click
        TripHistory.Show()
        Me.Hide()
    End Sub

    Private Sub btnStation_Click(sender As Object, e As EventArgs) Handles btnStation.Click
        StationSummary.Show()
        Me.Hide()
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        UndoTopUp.Show()
        Me.Hide()
    End Sub
End Class
