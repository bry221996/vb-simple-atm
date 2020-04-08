<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PinForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.InputEnter = New System.Windows.Forms.Label()
        Me.Input3 = New System.Windows.Forms.Label()
        Me.Input2 = New System.Windows.Forms.Label()
        Me.Input1 = New System.Windows.Forms.Label()
        Me.Input4 = New System.Windows.Forms.Label()
        Me.Input5 = New System.Windows.Forms.Label()
        Me.Input6 = New System.Windows.Forms.Label()
        Me.Input9 = New System.Windows.Forms.Label()
        Me.Input8 = New System.Windows.Forms.Label()
        Me.Input7 = New System.Windows.Forms.Label()
        Me.InputClear = New System.Windows.Forms.Label()
        Me.Input0 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Pin1 = New System.Windows.Forms.Label()
        Me.Pin2 = New System.Windows.Forms.Label()
        Me.Pin4 = New System.Windows.Forms.Label()
        Me.Pin3 = New System.Windows.Forms.Label()
        Me.ErrorMessage = New System.Windows.Forms.Label()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Fira Code", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(16, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SIMPLE ATM"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Fira Code", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(22, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(753, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Please Enter Your PIN"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'InputEnter
        '
        Me.InputEnter.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.InputEnter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InputEnter.Font = New System.Drawing.Font("Fira Code", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputEnter.ForeColor = System.Drawing.SystemColors.Window
        Me.InputEnter.Location = New System.Drawing.Point(437, 375)
        Me.InputEnter.Name = "InputEnter"
        Me.InputEnter.Size = New System.Drawing.Size(50, 35)
        Me.InputEnter.TabIndex = 15
        Me.InputEnter.Text = "ENTER"
        Me.InputEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Input3
        '
        Me.Input3.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Input3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Input3.Font = New System.Drawing.Font("Fira Code", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Input3.ForeColor = System.Drawing.SystemColors.Window
        Me.Input3.Location = New System.Drawing.Point(437, 242)
        Me.Input3.Name = "Input3"
        Me.Input3.Size = New System.Drawing.Size(50, 35)
        Me.Input3.TabIndex = 6
        Me.Input3.Text = "3"
        Me.Input3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Input2
        '
        Me.Input2.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Input2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Input2.Font = New System.Drawing.Font("Fira Code", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Input2.ForeColor = System.Drawing.SystemColors.Window
        Me.Input2.Location = New System.Drawing.Point(381, 242)
        Me.Input2.Name = "Input2"
        Me.Input2.Size = New System.Drawing.Size(50, 35)
        Me.Input2.TabIndex = 5
        Me.Input2.Text = "2"
        Me.Input2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Input1
        '
        Me.Input1.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Input1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Input1.Font = New System.Drawing.Font("Fira Code", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Input1.ForeColor = System.Drawing.SystemColors.Window
        Me.Input1.Location = New System.Drawing.Point(325, 242)
        Me.Input1.Name = "Input1"
        Me.Input1.Size = New System.Drawing.Size(50, 35)
        Me.Input1.TabIndex = 4
        Me.Input1.Text = "1"
        Me.Input1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Input4
        '
        Me.Input4.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Input4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Input4.Font = New System.Drawing.Font("Fira Code", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Input4.ForeColor = System.Drawing.SystemColors.Window
        Me.Input4.Location = New System.Drawing.Point(325, 286)
        Me.Input4.Name = "Input4"
        Me.Input4.Size = New System.Drawing.Size(50, 35)
        Me.Input4.TabIndex = 7
        Me.Input4.Text = "4"
        Me.Input4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Input5
        '
        Me.Input5.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Input5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Input5.Font = New System.Drawing.Font("Fira Code", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Input5.ForeColor = System.Drawing.SystemColors.Window
        Me.Input5.Location = New System.Drawing.Point(381, 286)
        Me.Input5.Name = "Input5"
        Me.Input5.Size = New System.Drawing.Size(50, 35)
        Me.Input5.TabIndex = 8
        Me.Input5.Text = "5"
        Me.Input5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Input6
        '
        Me.Input6.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Input6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Input6.Font = New System.Drawing.Font("Fira Code", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Input6.ForeColor = System.Drawing.SystemColors.Window
        Me.Input6.Location = New System.Drawing.Point(437, 286)
        Me.Input6.Name = "Input6"
        Me.Input6.Size = New System.Drawing.Size(50, 35)
        Me.Input6.TabIndex = 9
        Me.Input6.Text = "6"
        Me.Input6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Input9
        '
        Me.Input9.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Input9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Input9.Font = New System.Drawing.Font("Fira Code", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Input9.ForeColor = System.Drawing.SystemColors.Window
        Me.Input9.Location = New System.Drawing.Point(437, 330)
        Me.Input9.Name = "Input9"
        Me.Input9.Size = New System.Drawing.Size(50, 35)
        Me.Input9.TabIndex = 12
        Me.Input9.Text = "9"
        Me.Input9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Input8
        '
        Me.Input8.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Input8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Input8.Font = New System.Drawing.Font("Fira Code", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Input8.ForeColor = System.Drawing.SystemColors.Window
        Me.Input8.Location = New System.Drawing.Point(381, 330)
        Me.Input8.Name = "Input8"
        Me.Input8.Size = New System.Drawing.Size(50, 35)
        Me.Input8.TabIndex = 11
        Me.Input8.Text = "8"
        Me.Input8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Input7
        '
        Me.Input7.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Input7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Input7.Font = New System.Drawing.Font("Fira Code", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Input7.ForeColor = System.Drawing.SystemColors.Window
        Me.Input7.Location = New System.Drawing.Point(325, 330)
        Me.Input7.Name = "Input7"
        Me.Input7.Size = New System.Drawing.Size(50, 35)
        Me.Input7.TabIndex = 10
        Me.Input7.Text = "7"
        Me.Input7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'InputClear
        '
        Me.InputClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.InputClear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InputClear.Font = New System.Drawing.Font("Fira Code", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputClear.ForeColor = System.Drawing.SystemColors.Window
        Me.InputClear.Location = New System.Drawing.Point(325, 375)
        Me.InputClear.Name = "InputClear"
        Me.InputClear.Size = New System.Drawing.Size(50, 35)
        Me.InputClear.TabIndex = 13
        Me.InputClear.Text = "CLEAR"
        Me.InputClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Input0
        '
        Me.Input0.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Input0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Input0.Font = New System.Drawing.Font("Fira Code", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Input0.ForeColor = System.Drawing.SystemColors.Window
        Me.Input0.Location = New System.Drawing.Point(381, 375)
        Me.Input0.Name = "Input0"
        Me.Input0.Size = New System.Drawing.Size(50, 35)
        Me.Input0.TabIndex = 14
        Me.Input0.Text = "0"
        Me.Input0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Fira Code", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.Window
        Me.Label15.Location = New System.Drawing.Point(750, 10)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(25, 25)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "x"
        '
        'Pin1
        '
        Me.Pin1.AutoSize = True
        Me.Pin1.Font = New System.Drawing.Font("Fira Code", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pin1.ForeColor = System.Drawing.SystemColors.Window
        Me.Pin1.Location = New System.Drawing.Point(321, 159)
        Me.Pin1.Name = "Pin1"
        Me.Pin1.Size = New System.Drawing.Size(37, 40)
        Me.Pin1.TabIndex = 17
        Me.Pin1.Text = "-"
        '
        'Pin2
        '
        Me.Pin2.AutoSize = True
        Me.Pin2.Font = New System.Drawing.Font("Fira Code", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pin2.ForeColor = System.Drawing.SystemColors.Window
        Me.Pin2.Location = New System.Drawing.Point(364, 159)
        Me.Pin2.Name = "Pin2"
        Me.Pin2.Size = New System.Drawing.Size(37, 40)
        Me.Pin2.TabIndex = 18
        Me.Pin2.Text = "-"
        '
        'Pin4
        '
        Me.Pin4.AutoSize = True
        Me.Pin4.Font = New System.Drawing.Font("Fira Code", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pin4.ForeColor = System.Drawing.SystemColors.Window
        Me.Pin4.Location = New System.Drawing.Point(450, 159)
        Me.Pin4.Name = "Pin4"
        Me.Pin4.Size = New System.Drawing.Size(37, 40)
        Me.Pin4.TabIndex = 20
        Me.Pin4.Text = "-"
        '
        'Pin3
        '
        Me.Pin3.AutoSize = True
        Me.Pin3.Font = New System.Drawing.Font("Fira Code", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pin3.ForeColor = System.Drawing.SystemColors.Window
        Me.Pin3.Location = New System.Drawing.Point(407, 159)
        Me.Pin3.Name = "Pin3"
        Me.Pin3.Size = New System.Drawing.Size(37, 40)
        Me.Pin3.TabIndex = 19
        Me.Pin3.Text = "-"
        '
        'ErrorMessage
        '
        Me.ErrorMessage.Font = New System.Drawing.Font("Fira Code", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorMessage.ForeColor = System.Drawing.Color.OrangeRed
        Me.ErrorMessage.Location = New System.Drawing.Point(23, 199)
        Me.ErrorMessage.Name = "ErrorMessage"
        Me.ErrorMessage.Size = New System.Drawing.Size(752, 25)
        Me.ErrorMessage.TabIndex = 21
        Me.ErrorMessage.Text = "Invalid Pin"
        Me.ErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ErrorMessage.Visible = False
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'PinForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.ErrorMessage)
        Me.Controls.Add(Me.Pin4)
        Me.Controls.Add(Me.Pin3)
        Me.Controls.Add(Me.Pin2)
        Me.Controls.Add(Me.Pin1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.InputEnter)
        Me.Controls.Add(Me.Input0)
        Me.Controls.Add(Me.InputClear)
        Me.Controls.Add(Me.Input9)
        Me.Controls.Add(Me.Input8)
        Me.Controls.Add(Me.Input7)
        Me.Controls.Add(Me.Input6)
        Me.Controls.Add(Me.Input5)
        Me.Controls.Add(Me.Input4)
        Me.Controls.Add(Me.Input3)
        Me.Controls.Add(Me.Input2)
        Me.Controls.Add(Me.Input1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PinForm"
        Me.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simple ATM"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents InputEnter As Label
    Friend WithEvents Input3 As Label
    Friend WithEvents Input2 As Label
    Friend WithEvents Input1 As Label
    Friend WithEvents Input4 As Label
    Friend WithEvents Input5 As Label
    Friend WithEvents Input6 As Label
    Friend WithEvents Input9 As Label
    Friend WithEvents Input8 As Label
    Friend WithEvents Input7 As Label
    Friend WithEvents InputClear As Label
    Friend WithEvents Input0 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Pin1 As Label
    Friend WithEvents Pin2 As Label
    Friend WithEvents Pin4 As Label
    Friend WithEvents Pin3 As Label
    Friend WithEvents ErrorMessage As Label
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
End Class
