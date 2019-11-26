<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewRegister
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.boxFirstName = New System.Windows.Forms.TextBox()
        Me.boxLastName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.boxAddress = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.boxBirthday = New System.Windows.Forms.DateTimePicker()
        Me.boxNID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.boxNumber = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.boxSDistrict = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.boxDistrict = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.boxProvince = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.boxCode = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(316, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "New Customer Info"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(80, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name"
        '
        'boxFirstName
        '
        Me.boxFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.boxFirstName.Location = New System.Drawing.Point(199, 91)
        Me.boxFirstName.Multiline = True
        Me.boxFirstName.Name = "boxFirstName"
        Me.boxFirstName.Size = New System.Drawing.Size(209, 36)
        Me.boxFirstName.TabIndex = 0
        '
        'boxLastName
        '
        Me.boxLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.boxLastName.Location = New System.Drawing.Point(575, 91)
        Me.boxLastName.Multiline = True
        Me.boxLastName.Name = "boxLastName"
        Me.boxLastName.Size = New System.Drawing.Size(209, 36)
        Me.boxLastName.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(456, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Last Name"
        '
        'boxAddress
        '
        Me.boxAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.boxAddress.Location = New System.Drawing.Point(199, 156)
        Me.boxAddress.Multiline = True
        Me.boxAddress.Name = "boxAddress"
        Me.boxAddress.Size = New System.Drawing.Size(585, 36)
        Me.boxAddress.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(101, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 24)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(104, 358)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 24)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Birthday"
        '
        'boxBirthday
        '
        Me.boxBirthday.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.boxBirthday.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.boxBirthday.Location = New System.Drawing.Point(199, 353)
        Me.boxBirthday.Name = "boxBirthday"
        Me.boxBirthday.Size = New System.Drawing.Size(209, 35)
        Me.boxBirthday.TabIndex = 7
        Me.boxBirthday.Value = New Date(2019, 11, 16, 0, 0, 0, 0)
        '
        'boxNID
        '
        Me.boxNID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.boxNID.Location = New System.Drawing.Point(517, 353)
        Me.boxNID.MaxLength = 13
        Me.boxNID.Multiline = True
        Me.boxNID.Name = "boxNID"
        Me.boxNID.Size = New System.Drawing.Size(267, 36)
        Me.boxNID.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(466, 358)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 24)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "ID"
        '
        'boxNumber
        '
        Me.boxNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.boxNumber.Location = New System.Drawing.Point(199, 418)
        Me.boxNumber.MaxLength = 10
        Me.boxNumber.Multiline = True
        Me.boxNumber.Name = "boxNumber"
        Me.boxNumber.Size = New System.Drawing.Size(209, 36)
        Me.boxNumber.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(42, 423)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 24)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Phone Number"
        '
        'btnCreate
        '
        Me.btnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCreate.Location = New System.Drawing.Point(335, 488)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(210, 61)
        Me.btnCreate.TabIndex = 10
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnReset.Location = New System.Drawing.Point(587, 500)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(168, 36)
        Me.btnReset.TabIndex = 11
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnBack.Location = New System.Drawing.Point(124, 500)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(168, 36)
        Me.btnBack.TabIndex = 12
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'boxSDistrict
        '
        Me.boxSDistrict.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.boxSDistrict.Location = New System.Drawing.Point(199, 222)
        Me.boxSDistrict.Multiline = True
        Me.boxSDistrict.Name = "boxSDistrict"
        Me.boxSDistrict.Size = New System.Drawing.Size(209, 36)
        Me.boxSDistrict.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(77, 226)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 24)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Sub-District"
        '
        'boxDistrict
        '
        Me.boxDistrict.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.boxDistrict.Location = New System.Drawing.Point(575, 221)
        Me.boxDistrict.Multiline = True
        Me.boxDistrict.Name = "boxDistrict"
        Me.boxDistrict.Size = New System.Drawing.Size(209, 36)
        Me.boxDistrict.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(486, 225)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 24)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "District"
        '
        'boxProvince
        '
        Me.boxProvince.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.boxProvince.Location = New System.Drawing.Point(199, 287)
        Me.boxProvince.Multiline = True
        Me.boxProvince.Name = "boxProvince"
        Me.boxProvince.Size = New System.Drawing.Size(209, 36)
        Me.boxProvince.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(97, 291)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 24)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Province"
        '
        'boxCode
        '
        Me.boxCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.boxCode.Location = New System.Drawing.Point(575, 287)
        Me.boxCode.MaxLength = 5
        Me.boxCode.Multiline = True
        Me.boxCode.Name = "boxCode"
        Me.boxCode.Size = New System.Drawing.Size(209, 36)
        Me.boxCode.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(444, 291)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(111, 24)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Postal Code"
        '
        'btnSelect
        '
        Me.btnSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSelect.Location = New System.Drawing.Point(608, 31)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(176, 36)
        Me.btnSelect.TabIndex = 25
        Me.btnSelect.Text = "Select From Existing"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'NewRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 585)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.boxCode)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.boxProvince)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.boxDistrict)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.boxSDistrict)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.boxNumber)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.boxNID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.boxBirthday)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.boxAddress)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.boxLastName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.boxFirstName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NewRegister"
        Me.Text = "New Register Ticket"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents boxFirstName As TextBox
    Friend WithEvents boxLastName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents boxAddress As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents boxBirthday As DateTimePicker
    Friend WithEvents boxNID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents boxNumber As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents boxSDistrict As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents boxDistrict As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents boxProvince As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents boxCode As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnSelect As Button
End Class
