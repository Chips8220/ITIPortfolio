<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTranslator
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
        Me.radMother = New System.Windows.Forms.RadioButton()
        Me.radFather = New System.Windows.Forms.RadioButton()
        Me.radSister = New System.Windows.Forms.RadioButton()
        Me.radBrother = New System.Windows.Forms.RadioButton()
        Me.grpEnglish = New System.Windows.Forms.GroupBox()
        Me.lblTranslate = New System.Windows.Forms.Label()
        Me.getLang = New System.Windows.Forms.ComboBox()
        Me.lblTranslated = New System.Windows.Forms.Label()
        Me.btnTranslate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpEnglish.SuspendLayout()
        Me.SuspendLayout()
        '
        'radMother
        '
        Me.radMother.AutoSize = True
        Me.radMother.Location = New System.Drawing.Point(6, 19)
        Me.radMother.Name = "radMother"
        Me.radMother.Size = New System.Drawing.Size(58, 17)
        Me.radMother.TabIndex = 0
        Me.radMother.TabStop = True
        Me.radMother.Text = "&Mother"
        Me.radMother.UseVisualStyleBackColor = True
        '
        'radFather
        '
        Me.radFather.AutoSize = True
        Me.radFather.Location = New System.Drawing.Point(6, 42)
        Me.radFather.Name = "radFather"
        Me.radFather.Size = New System.Drawing.Size(55, 17)
        Me.radFather.TabIndex = 1
        Me.radFather.TabStop = True
        Me.radFather.Text = "&Father"
        Me.radFather.UseVisualStyleBackColor = True
        '
        'radSister
        '
        Me.radSister.AutoSize = True
        Me.radSister.Location = New System.Drawing.Point(6, 65)
        Me.radSister.Name = "radSister"
        Me.radSister.Size = New System.Drawing.Size(51, 17)
        Me.radSister.TabIndex = 2
        Me.radSister.TabStop = True
        Me.radSister.Text = "&Sister"
        Me.radSister.UseVisualStyleBackColor = True
        '
        'radBrother
        '
        Me.radBrother.AutoSize = True
        Me.radBrother.Location = New System.Drawing.Point(6, 90)
        Me.radBrother.Name = "radBrother"
        Me.radBrother.Size = New System.Drawing.Size(59, 17)
        Me.radBrother.TabIndex = 3
        Me.radBrother.TabStop = True
        Me.radBrother.Text = "&Brother"
        Me.radBrother.UseVisualStyleBackColor = True
        '
        'grpEnglish
        '
        Me.grpEnglish.Controls.Add(Me.radMother)
        Me.grpEnglish.Controls.Add(Me.radBrother)
        Me.grpEnglish.Controls.Add(Me.radFather)
        Me.grpEnglish.Controls.Add(Me.radSister)
        Me.grpEnglish.Location = New System.Drawing.Point(12, 12)
        Me.grpEnglish.Name = "grpEnglish"
        Me.grpEnglish.Size = New System.Drawing.Size(102, 113)
        Me.grpEnglish.TabIndex = 4
        Me.grpEnglish.TabStop = False
        Me.grpEnglish.Text = "English"
        '
        'lblTranslate
        '
        Me.lblTranslate.AutoSize = True
        Me.lblTranslate.Location = New System.Drawing.Point(136, 12)
        Me.lblTranslate.Name = "lblTranslate"
        Me.lblTranslate.Size = New System.Drawing.Size(66, 13)
        Me.lblTranslate.TabIndex = 5
        Me.lblTranslate.Text = "T&ranslate to:"
        '
        'getLang
        '
        Me.getLang.FormattingEnabled = True
        Me.getLang.Items.AddRange(New Object() {"Tagalog", "Japanese", "Chinese"})
        Me.getLang.Location = New System.Drawing.Point(139, 28)
        Me.getLang.Name = "getLang"
        Me.getLang.Size = New System.Drawing.Size(88, 21)
        Me.getLang.TabIndex = 6
        '
        'lblTranslated
        '
        Me.lblTranslated.Location = New System.Drawing.Point(136, 56)
        Me.lblTranslated.Name = "lblTranslated"
        Me.lblTranslated.Size = New System.Drawing.Size(91, 53)
        Me.lblTranslated.TabIndex = 7
        '
        'btnTranslate
        '
        Me.btnTranslate.Location = New System.Drawing.Point(250, 13)
        Me.btnTranslate.Name = "btnTranslate"
        Me.btnTranslate.Size = New System.Drawing.Size(75, 23)
        Me.btnTranslate.TabIndex = 8
        Me.btnTranslate.Text = "&Translate"
        Me.btnTranslate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(250, 43)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmTranslator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 141)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnTranslate)
        Me.Controls.Add(Me.lblTranslated)
        Me.Controls.Add(Me.getLang)
        Me.Controls.Add(Me.lblTranslate)
        Me.Controls.Add(Me.grpEnglish)
        Me.Name = "frmTranslator"
        Me.Text = "Translator"
        Me.grpEnglish.ResumeLayout(False)
        Me.grpEnglish.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents radMother As RadioButton
    Friend WithEvents radFather As RadioButton
    Friend WithEvents radSister As RadioButton
    Friend WithEvents radBrother As RadioButton
    Friend WithEvents grpEnglish As GroupBox
    Friend WithEvents lblTranslate As Label
    Friend WithEvents getLang As ComboBox
    Friend WithEvents lblTranslated As Label
    Friend WithEvents btnTranslate As Button
    Friend WithEvents btnExit As Button
End Class
