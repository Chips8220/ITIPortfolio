<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DiscountFrm
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
        Me.Disclist = New System.Windows.Forms.ListBox()
        Me.Pricetxt = New System.Windows.Forms.TextBox()
        Me.Pricelable = New System.Windows.Forms.Label()
        Me.Discountedlable = New System.Windows.Forms.Label()
        Me.Discountbtn = New System.Windows.Forms.Button()
        Me.Exitbtn = New System.Windows.Forms.Button()
        Me.NewPricelist = New System.Windows.Forms.ListBox()
        Me.NewPricelbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Disclist
        '
        Me.Disclist.FormattingEnabled = True
        Me.Disclist.Location = New System.Drawing.Point(131, 35)
        Me.Disclist.Name = "Disclist"
        Me.Disclist.Size = New System.Drawing.Size(120, 95)
        Me.Disclist.TabIndex = 0
        '
        'Pricetxt
        '
        Me.Pricetxt.Location = New System.Drawing.Point(131, 9)
        Me.Pricetxt.Name = "Pricetxt"
        Me.Pricetxt.Size = New System.Drawing.Size(100, 20)
        Me.Pricetxt.TabIndex = 1
        '
        'Pricelable
        '
        Me.Pricelable.AutoSize = True
        Me.Pricelable.Location = New System.Drawing.Point(12, 9)
        Me.Pricelable.Name = "Pricelable"
        Me.Pricelable.Size = New System.Drawing.Size(84, 13)
        Me.Pricelable.TabIndex = 2
        Me.Pricelable.Text = "Enter The Price:"
        '
        'Discountedlable
        '
        Me.Discountedlable.AutoSize = True
        Me.Discountedlable.Location = New System.Drawing.Point(12, 35)
        Me.Discountedlable.Name = "Discountedlable"
        Me.Discountedlable.Size = New System.Drawing.Size(74, 13)
        Me.Discountedlable.TabIndex = 3
        Me.Discountedlable.Text = "The Discount:"
        '
        'Discountbtn
        '
        Me.Discountbtn.Location = New System.Drawing.Point(228, 283)
        Me.Discountbtn.Name = "Discountbtn"
        Me.Discountbtn.Size = New System.Drawing.Size(75, 23)
        Me.Discountbtn.TabIndex = 4
        Me.Discountbtn.Text = "Discount!"
        Me.Discountbtn.UseVisualStyleBackColor = True
        '
        'Exitbtn
        '
        Me.Exitbtn.Location = New System.Drawing.Point(228, 323)
        Me.Exitbtn.Name = "Exitbtn"
        Me.Exitbtn.Size = New System.Drawing.Size(75, 23)
        Me.Exitbtn.TabIndex = 5
        Me.Exitbtn.Text = "Exit"
        Me.Exitbtn.UseVisualStyleBackColor = True
        '
        'NewPricelist
        '
        Me.NewPricelist.FormattingEnabled = True
        Me.NewPricelist.Location = New System.Drawing.Point(131, 145)
        Me.NewPricelist.Name = "NewPricelist"
        Me.NewPricelist.Size = New System.Drawing.Size(172, 95)
        Me.NewPricelist.TabIndex = 6
        '
        'NewPricelbl
        '
        Me.NewPricelbl.AutoSize = True
        Me.NewPricelbl.Location = New System.Drawing.Point(12, 145)
        Me.NewPricelbl.Name = "NewPricelbl"
        Me.NewPricelbl.Size = New System.Drawing.Size(59, 13)
        Me.NewPricelbl.TabIndex = 7
        Me.NewPricelbl.Text = "New Price:"
        '
        'DiscountFrm
        '
        Me.AcceptButton = Me.Discountbtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 371)
        Me.Controls.Add(Me.NewPricelbl)
        Me.Controls.Add(Me.NewPricelist)
        Me.Controls.Add(Me.Exitbtn)
        Me.Controls.Add(Me.Discountbtn)
        Me.Controls.Add(Me.Discountedlable)
        Me.Controls.Add(Me.Pricelable)
        Me.Controls.Add(Me.Pricetxt)
        Me.Controls.Add(Me.Disclist)
        Me.Name = "DiscountFrm"
        Me.Text = "Discount The Price"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Disclist As ListBox
    Friend WithEvents Pricetxt As TextBox
    Friend WithEvents Pricelable As Label
    Friend WithEvents Discountedlable As Label
    Friend WithEvents Discountbtn As Button
    Friend WithEvents Exitbtn As Button
    Friend WithEvents NewPricelist As ListBox
    Friend WithEvents NewPricelbl As Label
End Class
