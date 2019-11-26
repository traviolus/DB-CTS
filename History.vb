
Public Class History

    Public typeTable, purTable As DataTable
    Public bal As Integer
    Private Sub History_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MainMenu.Show()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Dim frm As New MainMenu
        Me.Close()
    End Sub

    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If typeTable.Rows(0)(0) = "r" Then
            Me.lblType.Text = "Register"
        ElseIf typeTable.Rows(0)(0) = "n" Then
            Me.lblType.Text = "Non-Register"
        End If
        Me.lblBal.Text = bal.ToString
        Me.lblPurDate.Text = purTable.Rows(0)(0).ToString.Substring(0, 10)
    End Sub

End Class