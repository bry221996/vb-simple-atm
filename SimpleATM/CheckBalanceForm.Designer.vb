<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckBalanceForm
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
        Me.BalanceText = New System.Windows.Forms.Label()
        Me.BackLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(-5, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(740, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Hi!, Your current balance is :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BalanceText
        '
        Me.BalanceText.Font = New System.Drawing.Font("Fira Code", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BalanceText.ForeColor = System.Drawing.SystemColors.Window
        Me.BalanceText.Location = New System.Drawing.Point(-1, 114)
        Me.BalanceText.Name = "BalanceText"
        Me.BalanceText.Size = New System.Drawing.Size(736, 33)
        Me.BalanceText.TabIndex = 7
        Me.BalanceText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BackLabel
        '
        Me.BackLabel.AutoSize = True
        Me.BackLabel.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackLabel.ForeColor = System.Drawing.SystemColors.Window
        Me.BackLabel.Location = New System.Drawing.Point(284, 250)
        Me.BackLabel.Name = "BackLabel"
        Me.BackLabel.Size = New System.Drawing.Size(179, 20)
        Me.BackLabel.TabIndex = 9
        Me.BackLabel.Text = "Back to main menu"
        '
        'CheckBalanceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(750, 300)
        Me.Controls.Add(Me.BackLabel)
        Me.Controls.Add(Me.BalanceText)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CheckBalanceForm"
        Me.Text = "CheckBalanceForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BalanceText As Label
    Friend WithEvents BackLabel As Label
End Class
