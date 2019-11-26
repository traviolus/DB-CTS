<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewNonRegister
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
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.boxCardID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.boxAmount = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.boxStation = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCreate
        '
        Me.btnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCreate.Location = New System.Drawing.Point(151, 231)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(210, 61)
        Me.btnCreate.TabIndex = 15
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'boxCardID
        '
        Me.boxCardID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.boxCardID.Location = New System.Drawing.Point(204, 44)
        Me.boxCardID.MaxLength = 10
        Me.boxCardID.Name = "boxCardID"
        Me.boxCardID.Size = New System.Drawing.Size(209, 31)
        Me.boxCardID.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(108, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 24)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Card ID"
        '
        'boxAmount
        '
        Me.boxAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.boxAmount.Location = New System.Drawing.Point(204, 104)
        Me.boxAmount.Name = "boxAmount"
        Me.boxAmount.Size = New System.Drawing.Size(209, 31)
        Me.boxAmount.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(103, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 24)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Amount"
        '
        'boxStation
        '
        Me.boxStation.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.boxStation.Location = New System.Drawing.Point(204, 166)
        Me.boxStation.MaxLength = 5
        Me.boxStation.Name = "boxStation"
        Me.boxStation.Size = New System.Drawing.Size(209, 31)
        Me.boxStation.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(113, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 24)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Station"
        '
        'NewNonRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 327)
        Me.Controls.Add(Me.boxStation)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.boxAmount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.boxCardID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCreate)
        Me.Name = "NewNonRegister"
        Me.Text = "New Non-Register Ticket"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCreate As Button
    Friend WithEvents boxCardID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents boxAmount As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents boxStation As TextBox
    Friend WithEvents Label3 As Label
End Class
