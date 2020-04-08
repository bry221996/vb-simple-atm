<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionOptionForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBalanceButton = New System.Windows.Forms.Button()
        Me.WithdrawButton = New System.Windows.Forms.Button()
        Me.DepositButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Fira Code", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(0, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(750, 33)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "What do you want to do today ?"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(0, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(750, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Welcome !"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBalanceButton
        '
        Me.CheckBalanceButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CheckBalanceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CheckBalanceButton.FlatAppearance.BorderSize = 0
        Me.CheckBalanceButton.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBalanceButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.CheckBalanceButton.Location = New System.Drawing.Point(125, 139)
        Me.CheckBalanceButton.Name = "CheckBalanceButton"
        Me.CheckBalanceButton.Size = New System.Drawing.Size(150, 100)
        Me.CheckBalanceButton.TabIndex = 9
        Me.CheckBalanceButton.Text = "Check Balance"
        Me.CheckBalanceButton.UseVisualStyleBackColor = False
        '
        'WithdrawButton
        '
        Me.WithdrawButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.WithdrawButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.WithdrawButton.FlatAppearance.BorderSize = 0
        Me.WithdrawButton.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WithdrawButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.WithdrawButton.Location = New System.Drawing.Point(295, 139)
        Me.WithdrawButton.Name = "WithdrawButton"
        Me.WithdrawButton.Size = New System.Drawing.Size(150, 100)
        Me.WithdrawButton.TabIndex = 10
        Me.WithdrawButton.Text = "Withdraw"
        Me.WithdrawButton.UseVisualStyleBackColor = False
        '
        'DepositButton
        '
        Me.DepositButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.DepositButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.DepositButton.FlatAppearance.BorderSize = 0
        Me.DepositButton.Font = New System.Drawing.Font("Fira Code", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepositButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.DepositButton.Location = New System.Drawing.Point(468, 139)
        Me.DepositButton.Name = "DepositButton"
        Me.DepositButton.Size = New System.Drawing.Size(150, 100)
        Me.DepositButton.TabIndex = 11
        Me.DepositButton.Text = "Deposit"
        Me.DepositButton.UseVisualStyleBackColor = False
        '
        'TransactionOptionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(750, 300)
        Me.ControlBox = False
        Me.Controls.Add(Me.DepositButton)
        Me.Controls.Add(Me.WithdrawButton)
        Me.Controls.Add(Me.CheckBalanceButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TransactionOptionForm"
        Me.Text = "TransactionOptionForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBalanceButton As Button
    Friend WithEvents WithdrawButton As Button
    Friend WithEvents DepositButton As Button
End Class
