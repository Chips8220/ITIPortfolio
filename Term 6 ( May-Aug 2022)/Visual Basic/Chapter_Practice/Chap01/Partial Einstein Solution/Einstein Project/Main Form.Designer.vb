<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.picEinstein = New System.Windows.Forms.PictureBox()
        CType(Me.picEinstein, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(28, 296)
        Me.btnShow.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(115, 30)
        Me.btnShow.TabIndex = 1
        Me.btnShow.Text = "&Show equation"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnHide
        '
        Me.btnHide.Location = New System.Drawing.Point(149, 296)
        Me.btnHide.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(115, 30)
        Me.btnHide.TabIndex = 2
        Me.btnHide.Text = "&Hide equation"
        Me.btnHide.UseVisualStyleBackColor = True
        '
        'picEinstein
        '
        Me.picEinstein.Image = Global.Einstein_Project.My.Resources.Resources.Einstein
        Me.picEinstein.Location = New System.Drawing.Point(28, 30)
        Me.picEinstein.Name = "picEinstein"
        Me.picEinstein.Size = New System.Drawing.Size(184, 242)
        Me.picEinstein.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEinstein.TabIndex = 3
        Me.picEinstein.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 341)
        Me.Controls.Add(Me.picEinstein)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.btnShow)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Einstein's Famous Equation"
        CType(Me.picEinstein, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnShow As Button
    Friend WithEvents btnHide As Button
    Friend WithEvents picEinstein As PictureBox
End Class
