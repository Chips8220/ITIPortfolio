<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Score = New System.Windows.Forms.Label()
        Me.Total_Score = New System.Windows.Forms.Label()
        Me.Num_Scores = New System.Windows.Forms.Label()
        Me.AVG_Score = New System.Windows.Forms.Label()
        Me.Tot_Score = New System.Windows.Forms.TextBox()
        Me.Num_Scoretxt = New System.Windows.Forms.TextBox()
        Me.Avg_Scoretxt = New System.Windows.Forms.TextBox()
        Me.Rcrd_Score = New System.Windows.Forms.Button()
        Me.Nxt_Skater = New System.Windows.Forms.Button()
        Me.Ext = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListScore = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Score
        '
        Me.Score.AutoSize = True
        Me.Score.Location = New System.Drawing.Point(0, 0)
        Me.Score.Name = "Score"
        Me.Score.Size = New System.Drawing.Size(38, 13)
        Me.Score.TabIndex = 0
        Me.Score.Text = "Score:"
        '
        'Total_Score
        '
        Me.Total_Score.AutoSize = True
        Me.Total_Score.Location = New System.Drawing.Point(3, 2)
        Me.Total_Score.Name = "Total_Score"
        Me.Total_Score.Size = New System.Drawing.Size(65, 13)
        Me.Total_Score.TabIndex = 1
        Me.Total_Score.Text = "Total Score:"
        '
        'Num_Scores
        '
        Me.Num_Scores.AutoSize = True
        Me.Num_Scores.Location = New System.Drawing.Point(3, 57)
        Me.Num_Scores.Name = "Num_Scores"
        Me.Num_Scores.Size = New System.Drawing.Size(95, 13)
        Me.Num_Scores.TabIndex = 2
        Me.Num_Scores.Text = "Number of Scores:"
        '
        'AVG_Score
        '
        Me.AVG_Score.AutoSize = True
        Me.AVG_Score.Location = New System.Drawing.Point(3, 114)
        Me.AVG_Score.Name = "AVG_Score"
        Me.AVG_Score.Size = New System.Drawing.Size(79, 13)
        Me.AVG_Score.TabIndex = 3
        Me.AVG_Score.Text = "Average score:"
        '
        'Tot_Score
        '
        Me.Tot_Score.Location = New System.Drawing.Point(6, 18)
        Me.Tot_Score.Name = "Tot_Score"
        Me.Tot_Score.ReadOnly = True
        Me.Tot_Score.Size = New System.Drawing.Size(76, 20)
        Me.Tot_Score.TabIndex = 4
        '
        'Num_Scoretxt
        '
        Me.Num_Scoretxt.Location = New System.Drawing.Point(6, 73)
        Me.Num_Scoretxt.Name = "Num_Scoretxt"
        Me.Num_Scoretxt.ReadOnly = True
        Me.Num_Scoretxt.Size = New System.Drawing.Size(76, 20)
        Me.Num_Scoretxt.TabIndex = 4
        '
        'Avg_Scoretxt
        '
        Me.Avg_Scoretxt.Location = New System.Drawing.Point(6, 130)
        Me.Avg_Scoretxt.Name = "Avg_Scoretxt"
        Me.Avg_Scoretxt.ReadOnly = True
        Me.Avg_Scoretxt.Size = New System.Drawing.Size(76, 20)
        Me.Avg_Scoretxt.TabIndex = 4
        '
        'Rcrd_Score
        '
        Me.Rcrd_Score.Location = New System.Drawing.Point(80, 12)
        Me.Rcrd_Score.Name = "Rcrd_Score"
        Me.Rcrd_Score.Size = New System.Drawing.Size(96, 23)
        Me.Rcrd_Score.TabIndex = 5
        Me.Rcrd_Score.Text = "Record score"
        Me.Rcrd_Score.UseVisualStyleBackColor = True
        '
        'Nxt_Skater
        '
        Me.Nxt_Skater.Location = New System.Drawing.Point(182, 12)
        Me.Nxt_Skater.Name = "Nxt_Skater"
        Me.Nxt_Skater.Size = New System.Drawing.Size(96, 23)
        Me.Nxt_Skater.TabIndex = 5
        Me.Nxt_Skater.Text = "Next Skater"
        Me.Nxt_Skater.UseVisualStyleBackColor = True
        '
        'Ext
        '
        Me.Ext.Location = New System.Drawing.Point(284, 12)
        Me.Ext.Name = "Ext"
        Me.Ext.Size = New System.Drawing.Size(71, 23)
        Me.Ext.TabIndex = 5
        Me.Ext.Text = "Exit"
        Me.Ext.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Avg_Scoretxt)
        Me.GroupBox1.Controls.Add(Me.Num_Scoretxt)
        Me.GroupBox1.Controls.Add(Me.Tot_Score)
        Me.GroupBox1.Controls.Add(Me.AVG_Score)
        Me.GroupBox1.Controls.Add(Me.Total_Score)
        Me.GroupBox1.Controls.Add(Me.Num_Scores)
        Me.GroupBox1.Location = New System.Drawing.Point(80, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(110, 168)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'ListScore
        '
        Me.ListScore.FormattingEnabled = True
        Me.ListScore.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.ListScore.Location = New System.Drawing.Point(4, 19)
        Me.ListScore.Name = "ListScore"
        Me.ListScore.Size = New System.Drawing.Size(70, 186)
        Me.ListScore.TabIndex = 8
        '
        'Main_form
        '
        Me.AcceptButton = Me.Rcrd_Score
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 241)
        Me.Controls.Add(Me.ListScore)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Ext)
        Me.Controls.Add(Me.Nxt_Skater)
        Me.Controls.Add(Me.Rcrd_Score)
        Me.Controls.Add(Me.Score)
        Me.Name = "Main_form"
        Me.Text = "Mills Skating Rink"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Score As Label
    Friend WithEvents Total_Score As Label
    Friend WithEvents Num_Scores As Label
    Friend WithEvents AVG_Score As Label
    Friend WithEvents Tot_Score As TextBox
    Friend WithEvents Num_Scoretxt As TextBox
    Friend WithEvents Avg_Scoretxt As TextBox
    Friend WithEvents Rcrd_Score As Button
    Friend WithEvents Nxt_Skater As Button
    Friend WithEvents Ext As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ListScore As ListBox
End Class
