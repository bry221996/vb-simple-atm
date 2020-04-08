Public Class MainForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        PinForm.Show()
    End Sub

    Private Sub MainForm_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        Display(TransactionOptionForm)
    End Sub

    Private Sub Display(ByVal panel As Form)
        MainPanel.Controls.Clear()
        panel.TopLevel = False
        panel.Show()
        MainPanel.Controls.Add(panel)
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class