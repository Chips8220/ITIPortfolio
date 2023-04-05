Public Class DiscountFrm
    Private Sub Exitbtn_Click(sender As Object, e As EventArgs) Handles Exitbtn.Click
        Me.Close()
    End Sub

    Private Sub Discountbtn_Click(sender As Object, e As EventArgs) Handles Discountbtn.Click
        If Pricetxt.Text >= 0 Then
            For Discount As Double = 0.1 To 0.4 Step 0.05
                Disclist.Items.Add(String.Format("{0:p0}: {1:C2}", Discount, Pricetxt.Text * Discount))
                NewPricelist.Items.Add(String.Format("For {0:p0} : {1:C2}", Discount, Pricetxt.Text - (Pricetxt.Text * Discount)))

            Next Discount
        End If
    End Sub

    Private Sub Pricetxt_TextChanged(sender As Object, e As EventArgs) Handles Pricetxt.TextChanged
        Disclist.Items.Clear()
    End Sub

End Class
