<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TopUp
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
        Me.boxAmount = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.boxCardID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.boxStation = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'boxAmount
        '
        Me.boxAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.boxAmount.Location = New System.Drawing.Point(200, 105)
        Me.boxAmount.Name = "boxAmount"
        Me.boxAmount.Size = New System.Drawing.Size(209, 31)
        Me.boxAmount.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 24)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Amount"
        '
        'boxCardID
        '
        Me.boxCardID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.boxCardID.Location = New System.Drawing.Point(200, 45)
        Me.boxCardID.MaxLength = 10
        Me.boxCardID.Name = "boxCardID"
        Me.boxCardID.Size = New System.Drawing.Size(209, 31)
        Me.boxCardID.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(104, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 24)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Card ID"
        '
        'btnCreate
        '
        Me.btnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCreate.Location = New System.Drawing.Point(148, 228)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(210, 61)
        Me.btnCreate.TabIndex = 20
        Me.btnCreate.Text = "Top Up"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'boxStation
        '
        Me.boxStation.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.boxStation.Location = New System.Drawing.Point(200, 167)
        Me.boxStation.MaxLength = 5
        Me.boxStation.Name = "boxStation"
        Me.boxStation.Size = New System.Drawing.Size(209, 31)
        Me.boxStation.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(110, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 24)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Station"
        '
        'TopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 322)
        Me.Controls.Add(Me.boxStation)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.boxAmount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.boxCardID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCreate)
        Me.Name = "TopUp"
        Me.Text = "Top Up"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents boxAmount As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents boxCardID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCreate As Button
    Friend WithEvents boxStation As TextBox
    Friend WithEvents Label3 As Label
End Class
