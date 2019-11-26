<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TripHistory
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
        Me.lstvHistory = New System.Windows.Forms.ListView()
        Me.boxCardID = New System.Windows.Forms.TextBox()
        Me.btnView = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstvHistory
        '
        Me.lstvHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lstvHistory.HideSelection = False
        Me.lstvHistory.Location = New System.Drawing.Point(12, 74)
        Me.lstvHistory.Name = "lstvHistory"
        Me.lstvHistory.Size = New System.Drawing.Size(937, 364)
        Me.lstvHistory.TabIndex = 0
        Me.lstvHistory.UseCompatibleStateImageBehavior = False
        '
        'boxCardID
        '
        Me.boxCardID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.boxCardID.Location = New System.Drawing.Point(415, 21)
        Me.boxCardID.MaxLength = 10
        Me.boxCardID.Name = "boxCardID"
        Me.boxCardID.Size = New System.Drawing.Size(181, 31)
        Me.boxCardID.TabIndex = 1
        '
        'btnView
        '
        Me.btnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnView.Location = New System.Drawing.Point(576, 22)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(98, 31)
        Me.btnView.TabIndex = 2
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        Me.btnView.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(329, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Card ID"
        '
        'TripHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.boxCardID)
        Me.Controls.Add(Me.lstvHistory)
        Me.Name = "TripHistory"
        Me.Text = "Trip History"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstvHistory As ListView
    Friend WithEvents boxCardID As TextBox
    Friend WithEvents btnView As Button
    Friend WithEvents Label1 As Label
End Class
