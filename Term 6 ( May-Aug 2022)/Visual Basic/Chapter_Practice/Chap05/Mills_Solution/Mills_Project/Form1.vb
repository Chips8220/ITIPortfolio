Public Class Main_form
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Ext_Click(sender As Object, e As EventArgs) Handles Ext.Click
        Me.Close()
    End Sub

    Private Sub Tot_Score_TextChanged(sender As Object, e As EventArgs) Handles Tot_Score.TextChanged


    End Sub

    Private Sub Num_Scoretxt_TextChanged(sender As Object, e As EventArgs) Handles Num_Scoretxt.TextChanged

    End Sub
    Private Sub Avg_Scoretxt_TextChanged(sender As Object, e As EventArgs) Handles Avg_Scoretxt.TextChanged

    End Sub

    Private Sub Rcrd_Score_Click(sender As Object, e As EventArgs) Handles Rcrd_Score.Click
        Dim TotScore As Integer
        Integer.TryParse(Tot_Score.Text, TotScore)
        Dim SingleScore As Integer
        Integer.TryParse(ListScore.SelectedItem, SingleScore)
        TotScore += SingleScore
        Tot_Score.Text = TotScore

        Dim numScore As Integer
        Integer.TryParse(Num_Scoretxt.Text, numScore)
        numScore += 1
        Num_Scoretxt.Text = numScore

        Dim AvgScore As Double
        Double.TryParse(Avg_Scoretxt.Text, AvgScore)
        AvgScore = TotScore / numScore
        Avg_Scoretxt.Text = AvgScore
    End Sub

End Class
