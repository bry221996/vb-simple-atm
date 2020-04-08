Public Class PinForm
    Dim mouse_move As System.Drawing.Point
    Dim pin As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

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
        pin = pin + sender.Text
        Console.WriteLine(pin)
    End Sub

End Class
