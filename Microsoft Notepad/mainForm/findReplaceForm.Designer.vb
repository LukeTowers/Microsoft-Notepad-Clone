<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class findReplaceForm
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
        Me.lblFind = New System.Windows.Forms.Label()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnReplaceAll = New System.Windows.Forms.Button()
        Me.btnReplace = New System.Windows.Forms.Button()
        Me.lblReplace = New System.Windows.Forms.Label()
        Me.chkCase = New System.Windows.Forms.CheckBox()
        Me.textToFind = New System.Windows.Forms.TextBox()
        Me.ReplaceText = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblFind
        '
        Me.lblFind.AutoSize = True
        Me.lblFind.Location = New System.Drawing.Point(4, 12)
        Me.lblFind.Name = "lblFind"
        Me.lblFind.Size = New System.Drawing.Size(56, 13)
        Me.lblFind.TabIndex = 0
        Me.lblFind.Text = "Find what:"
        '
        'btnFind
        '
        Me.btnFind.Enabled = False
        Me.btnFind.Location = New System.Drawing.Point(262, 7)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(75, 23)
        Me.btnFind.TabIndex = 3
        Me.btnFind.Text = "Find Next"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(262, 88)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnReplaceAll
        '
        Me.btnReplaceAll.Enabled = False
        Me.btnReplaceAll.Location = New System.Drawing.Point(262, 61)
        Me.btnReplaceAll.Name = "btnReplaceAll"
        Me.btnReplaceAll.Size = New System.Drawing.Size(75, 23)
        Me.btnReplaceAll.TabIndex = 5
        Me.btnReplaceAll.Text = "Replace All"
        Me.btnReplaceAll.UseVisualStyleBackColor = True
        '
        'btnReplace
        '
        Me.btnReplace.Enabled = False
        Me.btnReplace.Location = New System.Drawing.Point(262, 34)
        Me.btnReplace.Name = "btnReplace"
        Me.btnReplace.Size = New System.Drawing.Size(75, 23)
        Me.btnReplace.TabIndex = 6
        Me.btnReplace.Text = "Replace"
        Me.btnReplace.UseVisualStyleBackColor = True
        '
        'lblReplace
        '
        Me.lblReplace.AutoSize = True
        Me.lblReplace.Location = New System.Drawing.Point(4, 38)
        Me.lblReplace.Name = "lblReplace"
        Me.lblReplace.Size = New System.Drawing.Size(72, 13)
        Me.lblReplace.TabIndex = 7
        Me.lblReplace.Text = "Replace with:"
        '
        'chkCase
        '
        Me.chkCase.AutoSize = True
        Me.chkCase.Location = New System.Drawing.Point(7, 67)
        Me.chkCase.Name = "chkCase"
        Me.chkCase.Size = New System.Drawing.Size(82, 17)
        Me.chkCase.TabIndex = 8
        Me.chkCase.Text = "Match case"
        Me.chkCase.UseVisualStyleBackColor = True
        '
        'textToFind
        '
        Me.textToFind.Location = New System.Drawing.Point(82, 9)
        Me.textToFind.Name = "textToFind"
        Me.textToFind.Size = New System.Drawing.Size(174, 20)
        Me.textToFind.TabIndex = 10
        '
        'ReplaceText
        '
        Me.ReplaceText.Location = New System.Drawing.Point(82, 35)
        Me.ReplaceText.Name = "ReplaceText"
        Me.ReplaceText.Size = New System.Drawing.Size(174, 20)
        Me.ReplaceText.TabIndex = 11
        '
        'findReplaceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 118)
        Me.Controls.Add(Me.ReplaceText)
        Me.Controls.Add(Me.textToFind)
        Me.Controls.Add(Me.chkCase)
        Me.Controls.Add(Me.lblReplace)
        Me.Controls.Add(Me.btnReplace)
        Me.Controls.Add(Me.btnReplaceAll)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.lblFind)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "findReplaceForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Find"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFind As System.Windows.Forms.Label
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnReplaceAll As System.Windows.Forms.Button
    Friend WithEvents btnReplace As System.Windows.Forms.Button
    Friend WithEvents lblReplace As System.Windows.Forms.Label
    Friend WithEvents chkCase As System.Windows.Forms.CheckBox
    Friend WithEvents textToFind As System.Windows.Forms.TextBox
    Friend WithEvents ReplaceText As System.Windows.Forms.TextBox
End Class
