Imports MySql.Data.MySqlClient
Imports System.Data
Public Class NewRegister
    Public newcid As String = ""
    Public chooseExist As Boolean = False
    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        If Not chooseExist Then
            newcid = assignCID()
            Dim strSQL As String = "INSERT INTO customer(`CID`, `CFirstName`, `CLastName`, `C_SAddress`, `C_SDistrict`, `C_District`, 
                                `C_Province`, `C_PostalCode`, `CDOB`, `CNID`, `CTelNo`) values('" + newcid + "',
                                '" & Me.boxFirstName.Text & "', '" & Me.boxLastName.Text & "', '" & Me.boxAddress.Text & "', '" & Me.boxSDistrict.Text & "',
                                '" & Me.boxDistrict.Text & "', '" & Me.boxProvince.Text & "', '" & Me.boxCode.Text & "', '" & Me.boxBirthday.Text & "',
                                '" & Me.boxNID.Text & "', '" & Me.boxNumber.Text & "');"
            DataConnect.insertUpdateDeleteDB(strSQL)
        End If

        Dim strSQL2 As String = "INSERT INTO `cts02`.`ticket` (`TicketID`,`CardID`, `PurDate`, `Type`, `CID`, `TStatus`)
                                VALUES (" + Microsoft.VisualBasic.Chr(34) + DataConnect.assignTicketID() + Microsoft.VisualBasic.Chr(34) + ", " +
                                Microsoft.VisualBasic.Chr(34) + DataConnect.assignCardID() + Microsoft.VisualBasic.Chr(34) + ", NOW(), " +
                                Microsoft.VisualBasic.Chr(34) + "r" + Microsoft.VisualBasic.Chr(34) +
                                ", " + Microsoft.VisualBasic.Chr(34) + newcid + Microsoft.VisualBasic.Chr(34) + ", " + Microsoft.VisualBasic.Chr(34) +
                                "ready" + Microsoft.VisualBasic.Chr(34) + ");"
        DataConnect.insertUpdateDeleteDB(strSQL2)
        MessageBox.Show("New Register Card Created!", "Register Card", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Function assignCID() As String
        Dim cidTable As DataTable = DataConnect.getTableFromDB("SELECT MAX(cid) FROM customer;")
        If (cidTable.Rows.Count <= 0) Then
            Return "CR00000001"
        Else
            Return "CR" + (Val(cidTable.Rows(0)(0).Substring(2, 8)) + 1).ToString("00000000")
        End If

    End Function


    Private Sub NewRegister_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MainMenu.Show()
    End Sub

    Private Sub NewRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        boxBirthday.Format = DateTimePickerFormat.Custom
        boxBirthday.CustomFormat = "yyyy-MM-dd"

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MainMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        boxAddress.ResetText()
        boxBirthday.ResetText()
        boxFirstName.ResetText()
        boxLastName.ResetText()
        boxNID.ResetText()
        boxNumber.ResetText()
        boxCode.ResetText()
        boxDistrict.ResetText()
        boxProvince.ResetText()
        boxSDistrict.ResetText()
        boxAddress.ReadOnly = False
        boxBirthday.Enabled = True
        boxFirstName.ReadOnly = False
        boxLastName.ReadOnly = False
        boxNID.ReadOnly = False
        boxNumber.ReadOnly = False
        boxCode.ReadOnly = False
        boxDistrict.ReadOnly = False
        boxProvince.ReadOnly = False
        boxSDistrict.ReadOnly = False
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        SearchCustomer.Show()
    End Sub
End Class