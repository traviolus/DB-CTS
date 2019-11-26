<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class History
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
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblBal = New System.Windows.Forms.Label()
        Me.lblPurDate = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lblType.Location = New System.Drawing.Point(217, 49)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(77, 25)
        Me.lblType.TabIndex = 0
        Me.lblType.Text = "Label1"
        Me.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBal
        '
        Me.lblBal.AutoSize = True
        Me.lblBal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lblBal.Location = New System.Drawing.Point(217, 103)
        Me.lblBal.Name = "lblBal"
        Me.lblBal.Size = New System.Drawing.Size(77, 25)
        Me.lblBal.TabIndex = 1
        Me.lblBal.Text = "Label2"
        Me.lblBal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPurDate
        '
        Me.lblPurDate.AutoSize = True
        Me.lblPurDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lblPurDate.Location = New System.Drawing.Point(217, 156)
        Me.lblPurDate.Name = "lblPurDate"
        Me.lblPurDate.Size = New System.Drawing.Size(77, 25)
        Me.lblPurDate.TabIndex = 2
        Me.lblPurDate.Text = "Label3"
        Me.lblPurDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(156, 223)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(115, 39)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.Label1.Location = New System.Drawing.Point(45, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Purchase Date :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.Label2.Location = New System.Drawing.Point(109, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Balance :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.Label3.Location = New System.Drawing.Point(87, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Card Type :"
        '
        'History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 296)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblPurDate)
        Me.Controls.Add(Me.lblBal)
        Me.Controls.Add(Me.lblType)
        Me.Name = "History"
        Me.Text = "History"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblType As Label
    Friend WithEvents lblBal As Label
    Friend WithEvents lblPurDate As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
