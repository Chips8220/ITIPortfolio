<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSodDepot
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
        Me.GrpCalc = New System.Windows.Forms.GroupBox()
        Me.txtSodPrice = New System.Windows.Forms.TextBox()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.lblSodPrice = New System.Windows.Forms.Label()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GrpCalc.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpCalc
        '
        Me.GrpCalc.Controls.Add(Me.txtSodPrice)
        Me.GrpCalc.Controls.Add(Me.txtWidth)
        Me.GrpCalc.Controls.Add(Me.txtLength)
        Me.GrpCalc.Controls.Add(Me.lblSodPrice)
        Me.GrpCalc.Controls.Add(Me.lblWidth)
        Me.GrpCalc.Controls.Add(Me.lblLength)
        Me.GrpCalc.Location = New System.Drawing.Point(42, 54)
        Me.GrpCalc.Name = "GrpCalc"
        Me.GrpCalc.Size = New System.Drawing.Size(306, 78)
        Me.GrpCalc.TabIndex = 0
        Me.GrpCalc.TabStop = False
        '
        'txtSodPrice
        '
        Me.txtSodPrice.Location = New System.Drawing.Point(202, 36)
        Me.txtSodPrice.Name = "txtSodPrice"
        Me.txtSodPrice.Size = New System.Drawing.Size(54, 20)
        Me.txtSodPrice.TabIndex = 5
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(102, 36)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(54, 20)
        Me.txtWidth.TabIndex = 4
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(10, 37)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(54, 20)
        Me.txtLength.TabIndex = 3
        '
        'lblSodPrice
        '
        Me.lblSodPrice.AutoSize = True
        Me.lblSodPrice.Location = New System.Drawing.Point(199, 20)
        Me.lblSodPrice.Name = "lblSodPrice"
        Me.lblSodPrice.Size = New System.Drawing.Size(107, 13)
        Me.lblSodPrice.TabIndex = 2
        Me.lblSodPrice.Text = "&Sod price (per sq yd):"
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Location = New System.Drawing.Point(99, 20)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(65, 13)
        Me.lblWidth.TabIndex = 1
        Me.lblWidth.Text = "&Width (feet):"
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Location = New System.Drawing.Point(7, 20)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(70, 13)
        Me.lblLength.TabIndex = 0
        Me.lblLength.Text = "&Length (feet):"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(49, 177)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(61, 13)
        Me.lblTotal.TabIndex = 1
        Me.lblTotal.Text = "Total Price:"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(52, 194)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 2
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(175, 177)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(82, 40)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(263, 177)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(85, 40)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmSodDepot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 253)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.GrpCalc)
        Me.Name = "frmSodDepot"
        Me.Text = "Sod Depot"
        Me.GrpCalc.ResumeLayout(False)
        Me.GrpCalc.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GrpCalc As GroupBox
    Friend WithEvents txtSodPrice As TextBox
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents txtLength As TextBox
    Friend WithEvents lblSodPrice As Label
    Friend WithEvents lblWidth As Label
    Friend WithEvents lblLength As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
End Class
