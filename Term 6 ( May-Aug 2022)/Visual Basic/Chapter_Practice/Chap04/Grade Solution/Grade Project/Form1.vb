Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Calc.Click
        If percent.Text >= 60 Then
            PorF.Text = "P"
        Else
            PorF.Text = "F"
        End If
        percent.Text += "%"
    End Sub

    Private Sub percent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles percent.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
