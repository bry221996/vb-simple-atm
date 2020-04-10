Public Class PinForm
    Dim mouse_move As System.Drawing.Point
    Dim pin As String = ""
    Dim attempts As Integer = 0

    Private Sub PinForm_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        mouse_move = New Point(-e.X, -e.Y)
    End Sub

    Private Sub PinForm_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            Dim mposition As Point
            mposition = Control.MousePosition
            mposition.Offset(mouse_move.X, mouse_move.Y)
            Me.Location = mposition
        End If
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        Me.Close()
    End Sub

    Private Sub InputNumberClick(sender As Label, e As EventArgs) Handles Input0.Click, Input1.Click, Input2.Click, Input3.Click, Input4.Click, Input5.Click, Input6.Click, Input7.Click, Input8.Click, Input9.Click
        If (attempts < 3) Then
            ErrorMessage.Visible = False
            If (pin.Length < 4) Then
                pin = pin + sender.Text
                UpdatePinDisplay()
            End If
        End If
    End Sub

    Private Sub Input_MouseDown(sender As Label, e As MouseEventArgs) Handles Input0.MouseDown, Input1.MouseDown, Input2.MouseDown, Input3.MouseDown, Input4.MouseDown, Input5.MouseDown, Input6.MouseDown, Input7.MouseDown, Input8.MouseDown, Input9.MouseDown
        If (pin.Length < 4) Then
            sender.BackColor = Color.FromArgb(255, 255, 255)
        End If
    End Sub

    Private Sub Inputs_MouseUp(sender As Label, e As MouseEventArgs) Handles InputClear.MouseUp, InputEnter.MouseUp, Input0.MouseUp, Input1.MouseUp, Input2.MouseUp, Input3.MouseUp, Input4.MouseUp, Input5.MouseUp, Input6.MouseUp, Input7.MouseUp, Input8.MouseUp, Input9.MouseUp
        sender.BackColor = Color.FromArgb(96, 200, 137)
    End Sub

    Private Sub InputClear_Click(sender As Object, e As EventArgs) Handles InputClear.Click
        ClearPin()
    End Sub

    Private Sub InputClear_MouseDown(sender As Object, e As EventArgs) Handles InputClear.MouseDown
        If (pin.Length) Then
            sender.BackColor = Color.FromArgb(255, 255, 255)
        End If
    End Sub

    Private Sub InputEnter_MouseDown(sender As Object, e As EventArgs) Handles InputEnter.MouseDown
        If (pin.Length = 4) Then
            sender.BackColor = Color.FromArgb(255, 255, 255)
        End If
    End Sub

    Private Sub UpdatePinDisplay()
        For i As Integer = 1 To pin.Length
            Dim pinName As String = "Pin" + i.ToString()
            Dim PinLabel As Label = Me.Controls(pinName)
            PinLabel.Text = "*"
        Next
    End Sub

    Private Sub ClearPin()
        pin = ""
        For i As Integer = 1 To 4
            Dim pinName As String = "Pin" + i.ToString()
            Dim PinLabel As Label = Me.Controls(pinName)
            PinLabel.Text = "-"
        Next
    End Sub

    Private Sub InputEnter_Click(sender As Object, e As EventArgs) Handles InputEnter.Click
        If (pin.Length = 4) Then
            If (pin = "0000") Then
                Me.Hide()
                MainForm.Show()
            Else
                ClearPin()
                attempts = attempts + 1
                Dim message As String = "Invalid Pin. "
                If (attempts = 3) Then
                    message = message + "Already exceed the maximum attempt"
                End If
                ErrorMessage.Text = message
                ErrorMessage.Visible = True
            End If
        End If
    End Sub

    Private Sub PinForm_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If (e.KeyCode = Keys.Escape) And (attempts = 3) Then
            ErrorMessage.Visible = False
            attempts = 0
        End If
    End Sub

    Private Sub PinForm_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        ClearPin()
        attempts = 0
    End Sub
End Class
