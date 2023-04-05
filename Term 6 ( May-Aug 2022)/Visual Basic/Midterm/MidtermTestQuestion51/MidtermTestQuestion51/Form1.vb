Public Class Form1
    Public Sub GradeAvg()
        Dim acc As Double
        Dim avg As Double
        For grade As Double = 0 To ListBox1.Items.Count
            acc += grade
        Next grade
        avg = acc / ListBox1.Items.Count
        TextBox1.Text = ToString("The average grade is: " + avg)
    End Sub
End Class




