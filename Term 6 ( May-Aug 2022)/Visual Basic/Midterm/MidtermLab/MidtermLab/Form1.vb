Public Class FrmCalculator
    Dim num1 As String
    Dim num2 As String
    Dim Op As String
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, Btn0.Click
        lblData.Text += CType(sender, Button).Text
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Op = "+"
        num1 = lblData.Text
        lblData.Text = ""
        num2 = lblData.Text
        lblData.Text = "+"

    End Sub


    Private Sub BtnSub_Click(sender As Object, e As EventArgs) Handles BtnSub.Click
        Op = "-"
        num1 = lblData.Text
        lblData.Text = ""
        num2 = lblData.Text
        lblData.Text = "-"
    End Sub

    Private Sub btnMulti_Click(sender As Object, e As EventArgs) Handles btnMulti.Click
        Op = "*"
        num1 = lblData.Text
        lblData.Text = ""
        num2 = lblData.Text
        lblData.Text = "*"
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        Op = "/"
        num1 = lblData.Text
        lblData.Text = ""
        num2 = lblData.Text
        lblData.Text = "/"
    End Sub
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        num2 = lblData.Text.Substring(1)

        lblData.Text = ""
        Select Case Op
            Case "+"
                lblData.Text = Integer.Parse(num1) + Integer.Parse(num2)
            Case "-"
                lblData.Text = Integer.Parse(num1) - Integer.Parse(num2)
            Case "*"
                lblData.Text = Integer.Parse(num1) * Integer.Parse(num2)
            Case "/"
                lblData.Text = Integer.Parse(num1) / Integer.Parse(num2)
            Case Else
                MessageBox.Show("Please select Operator.")
        End Select


    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        lblData.Text = ""
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        lblData.Text = lblData.Text.Substring(0, lblData.Text.Length - 1)
    End Sub
End Class