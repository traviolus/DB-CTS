<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewSummary
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.boxFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.boxTo = New System.Windows.Forms.DateTimePicker()
        Me.btnView = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblInc = New System.Windows.Forms.Label()
        Me.lblTrip = New System.Windows.Forms.Label()
        Me.lblAvg = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 24)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "  Date      From"
        '
        'boxFrom
        '
        Me.boxFrom.CustomFormat = ""
        Me.boxFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.boxFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.boxFrom.Location = New System.Drawing.Point(213, 44)
        Me.boxFrom.Name = "boxFrom"
        Me.boxFrom.Size = New System.Drawing.Size(209, 35)
        Me.boxFrom.TabIndex = 35
        Me.boxFrom.Value = New Date(2019, 11, 25, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(162, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 24)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "To"
        '
        'boxTo
        '
        Me.boxTo.CustomFormat = ""
        Me.boxTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.boxTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.boxTo.Location = New System.Drawing.Point(213, 107)
        Me.boxTo.Name = "boxTo"
        Me.boxTo.Size = New System.Drawing.Size(209, 35)
        Me.boxTo.TabIndex = 37
        Me.boxTo.Value = New Date(2019, 11, 26, 0, 0, 0, 0)
        '
        'btnView
        '
        Me.btnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnView.Location = New System.Drawing.Point(474, 57)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(228, 73)
        Me.btnView.TabIndex = 38
        Me.btnView.Text = "View Summary"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(215, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 29)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Total Income :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(250, 254)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 29)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Total Trip :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(87, 320)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(293, 29)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Average Income Per Trip :"
        '
        'lblInc
        '
        Me.lblInc.AutoSize = True
        Me.lblInc.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblInc.Location = New System.Drawing.Point(386, 186)
        Me.lblInc.Name = "lblInc"
        Me.lblInc.Size = New System.Drawing.Size(247, 29)
        Me.lblInc.TabIndex = 42
        Me.lblInc.Text = "__________________"
        '
        'lblTrip
        '
        Me.lblTrip.AutoSize = True
        Me.lblTrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTrip.Location = New System.Drawing.Point(386, 254)
        Me.lblTrip.Name = "lblTrip"
        Me.lblTrip.Size = New System.Drawing.Size(247, 29)
        Me.lblTrip.TabIndex = 43
        Me.lblTrip.Text = "__________________"
        '
        'lblAvg
        '
        Me.lblAvg.AutoSize = True
        Me.lblAvg.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblAvg.Location = New System.Drawing.Point(386, 320)
        Me.lblAvg.Name = "lblAvg"
        Me.lblAvg.Size = New System.Drawing.Size(247, 29)
        Me.lblAvg.TabIndex = 44
        Me.lblAvg.Text = "__________________"
        '
        'ViewSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 396)
        Me.Controls.Add(Me.lblAvg)
        Me.Controls.Add(Me.lblTrip)
        Me.Controls.Add(Me.lblInc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.boxTo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.boxFrom)
        Me.Controls.Add(Me.Label2)
        Me.Name = "ViewSummary"
        Me.Text = "View Summary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents boxFrom As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents boxTo As DateTimePicker
    Friend WithEvents btnView As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblInc As Label
    Friend WithEvents lblTrip As Label
    Friend WithEvents lblAvg As Label
End Class
