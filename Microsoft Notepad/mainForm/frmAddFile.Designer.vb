<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddFile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddFile))
        Me.txtFilePreview = New System.Windows.Forms.TextBox()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblPreview = New System.Windows.Forms.Label()
        Me.pnlOpen = New System.Windows.Forms.Panel()
        Me.grpBxOptions = New System.Windows.Forms.GroupBox()
        Me.rdBtnEnd = New System.Windows.Forms.RadioButton()
        Me.rdBtnSelected = New System.Windows.Forms.RadioButton()
        Me.rdBtnBegining = New System.Windows.Forms.RadioButton()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.pnlOpen.SuspendLayout()
        Me.grpBxOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtFilePreview
        '
        Me.txtFilePreview.Enabled = False
        Me.txtFilePreview.Location = New System.Drawing.Point(12, 91)
        Me.txtFilePreview.Multiline = True
        Me.txtFilePreview.Name = "txtFilePreview"
        Me.txtFilePreview.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtFilePreview.Size = New System.Drawing.Size(155, 169)
        Me.txtFilePreview.TabIndex = 2
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(237, 30)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 1
        Me.btnOpen.Text = "Open..."
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblInstructions.Location = New System.Drawing.Point(0, 0)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(293, 26)
        Me.lblInstructions.TabIndex = 0
        Me.lblInstructions.Text = "Choose a file to add to the current document, then select an " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "option and press A" & _
    "dd."
        '
        'lblPreview
        '
        Me.lblPreview.AutoSize = True
        Me.lblPreview.Location = New System.Drawing.Point(9, 75)
        Me.lblPreview.Name = "lblPreview"
        Me.lblPreview.Size = New System.Drawing.Size(67, 13)
        Me.lblPreview.TabIndex = 0
        Me.lblPreview.Text = "File Preview:"
        '
        'pnlOpen
        '
        Me.pnlOpen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlOpen.Controls.Add(Me.btnOpen)
        Me.pnlOpen.Controls.Add(Me.lblInstructions)
        Me.pnlOpen.Location = New System.Drawing.Point(12, 12)
        Me.pnlOpen.Name = "pnlOpen"
        Me.pnlOpen.Size = New System.Drawing.Size(319, 60)
        Me.pnlOpen.TabIndex = 0
        '
        'grpBxOptions
        '
        Me.grpBxOptions.Controls.Add(Me.rdBtnEnd)
        Me.grpBxOptions.Controls.Add(Me.rdBtnSelected)
        Me.grpBxOptions.Controls.Add(Me.rdBtnBegining)
        Me.grpBxOptions.Location = New System.Drawing.Point(174, 75)
        Me.grpBxOptions.Name = "grpBxOptions"
        Me.grpBxOptions.Size = New System.Drawing.Size(157, 156)
        Me.grpBxOptions.TabIndex = 0
        Me.grpBxOptions.TabStop = False
        Me.grpBxOptions.Text = "Options"
        '
        'rdBtnEnd
        '
        Me.rdBtnEnd.AutoSize = True
        Me.rdBtnEnd.Checked = True
        Me.rdBtnEnd.Location = New System.Drawing.Point(6, 62)
        Me.rdBtnEnd.Name = "rdBtnEnd"
        Me.rdBtnEnd.Size = New System.Drawing.Size(95, 17)
        Me.rdBtnEnd.TabIndex = 5
        Me.rdBtnEnd.TabStop = True
        Me.rdBtnEnd.Text = "Add to the end"
        Me.rdBtnEnd.UseVisualStyleBackColor = True
        '
        'rdBtnSelected
        '
        Me.rdBtnSelected.AutoSize = True
        Me.rdBtnSelected.Location = New System.Drawing.Point(6, 39)
        Me.rdBtnSelected.Name = "rdBtnSelected"
        Me.rdBtnSelected.Size = New System.Drawing.Size(146, 17)
        Me.rdBtnSelected.TabIndex = 4
        Me.rdBtnSelected.Text = "Replace the selected text"
        Me.rdBtnSelected.UseVisualStyleBackColor = True
        '
        'rdBtnBegining
        '
        Me.rdBtnBegining.AutoSize = True
        Me.rdBtnBegining.Location = New System.Drawing.Point(6, 16)
        Me.rdBtnBegining.Name = "rdBtnBegining"
        Me.rdBtnBegining.Size = New System.Drawing.Size(117, 17)
        Me.rdBtnBegining.TabIndex = 3
        Me.rdBtnBegining.Text = "Add to the begining"
        Me.rdBtnBegining.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Enabled = False
        Me.btnAdd.Location = New System.Drawing.Point(174, 237)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(71, 23)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(251, 237)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmAddFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 272)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.grpBxOptions)
        Me.Controls.Add(Me.lblPreview)
        Me.Controls.Add(Me.txtFilePreview)
        Me.Controls.Add(Me.pnlOpen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAddFile"
        Me.Text = "Add File"
        Me.pnlOpen.ResumeLayout(False)
        Me.pnlOpen.PerformLayout()
        Me.grpBxOptions.ResumeLayout(False)
        Me.grpBxOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFilePreview As System.Windows.Forms.TextBox
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents lblPreview As System.Windows.Forms.Label
    Friend WithEvents pnlOpen As System.Windows.Forms.Panel
    Friend WithEvents grpBxOptions As System.Windows.Forms.GroupBox
    Friend WithEvents rdBtnEnd As System.Windows.Forms.RadioButton
    Friend WithEvents rdBtnSelected As System.Windows.Forms.RadioButton
    Friend WithEvents rdBtnBegining As System.Windows.Forms.RadioButton
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
