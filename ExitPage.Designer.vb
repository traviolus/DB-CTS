<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExitPage
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
        Me.boxStation = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.boxCardID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'boxStation
        '
        Me.boxStation.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.boxStation.Location = New System.Drawing.Point(159, 102)
        Me.boxStation.MaxLength = 5
        Me.boxStation.Name = "boxStation"
        Me.boxStation.Size = New System.Drawing.Size(209, 31)
        Me.boxStation.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 24)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Station"
        '
        'boxCardID
        '
        Me.boxCardID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.boxCardID.Location = New System.Drawing.Point(159, 42)
        Me.boxCardID.MaxLength = 10
        Me.boxCardID.Name = "boxCardID"
        Me.boxCardID.Size = New System.Drawing.Size(209, 31)
        Me.boxCardID.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(63, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 24)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Card ID"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnExit.Location = New System.Drawing.Point(103, 166)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(210, 61)
        Me.btnExit.TabIndex = 30
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'ExitPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 267)
        Me.Controls.Add(Me.boxStation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.boxCardID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "ExitPage"
        Me.Text = "Exit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents boxStation As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents boxCardID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnExit As Button
End Class
