Public Class frmSodDepot


    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim Rect As Rectangle
        Dim SqFt As Integer
        Dim totalPrice As Double
        'creating new rectangle
        Rect = New Rectangle(txtLength.Text, txtWidth.Text)
        'calculate sq ft
        SqFt = Rect.GetArea
        'calculate price
        totalPrice = SqFt * txtSodPrice.Text
        'display
        txtTotal.Text = totalPrice.ToString("C2")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
