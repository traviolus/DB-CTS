Imports MySql.Data.MySqlClient
Public Class SearchCustomer
    Private Sub SearchCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvData.DataSource = DataConnect.getTableFromDB("SELECT * FROM customer")
    End Sub
    Private Sub boxSearch_TextChanged(sender As Object, e As EventArgs) Handles boxSearch.TextChanged
        Dim dt As DataTable = DataConnect.getTableFromDB("SELECT * FROM customer WHERE CONCAT_WS(CFirstName, CLastName, CNID, CTelNo) LIKE " +
                                                         Microsoft.VisualBasic.Chr(34) + "%" + boxSearch.Text + "%" + Microsoft.VisualBasic.Chr(34))
        dgvData.DataSource = dt
    End Sub
    Private Sub dgvData_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellContentDoubleClick
        NewRegister.boxFirstName.Text = dgvData.CurrentRow.Cells(1).Value
        NewRegister.boxLastName.Text = dgvData.CurrentRow.Cells(2).Value
        NewRegister.boxAddress.Text = dgvData.CurrentRow.Cells(3).Value
        NewRegister.boxSDistrict.Text = dgvData.CurrentRow.Cells(4).Value
        NewRegister.boxDistrict.Text = dgvData.CurrentRow.Cells(5).Value
        NewRegister.boxProvince.Text = dgvData.CurrentRow.Cells(6).Value
        NewRegister.boxCode.Text = dgvData.CurrentRow.Cells(7).Value
        NewRegister.boxBirthday.Value = dgvData.CurrentRow.Cells(8).Value
        NewRegister.boxNID.Text = dgvData.CurrentRow.Cells(9).Value
        NewRegister.boxNumber.Text = dgvData.CurrentRow.Cells(10).Value
        NewRegister.boxFirstName.ReadOnly = True
        NewRegister.boxLastName.ReadOnly = True
        NewRegister.boxAddress.ReadOnly = True
        NewRegister.boxSDistrict.ReadOnly = True
        NewRegister.boxDistrict.ReadOnly = True
        NewRegister.boxProvince.ReadOnly = True
        NewRegister.boxCode.ReadOnly = True
        NewRegister.boxBirthday.Enabled = False
        NewRegister.boxNID.ReadOnly = True
        NewRegister.boxNumber.ReadOnly = True
        NewRegister.chooseExist = True
        NewRegister.newcid = dgvData.CurrentRow.Cells(0).Value.ToString
        Me.Close()
    End Sub
End Class