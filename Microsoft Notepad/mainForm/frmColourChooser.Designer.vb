<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmColourChooser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmColourChooser))
        Me.grpBoxBackColour = New System.Windows.Forms.GroupBox()
        Me.lblBckgrndClr = New System.Windows.Forms.Label()
        Me.btnChooseBckgrnd = New System.Windows.Forms.Button()
        Me.clrBackground = New System.Windows.Forms.PictureBox()
        Me.grpBoxTextColour = New System.Windows.Forms.GroupBox()
        Me.lblForeClr = New System.Windows.Forms.Label()
        Me.btnChooseForeClr = New System.Windows.Forms.Button()
        Me.clrText = New System.Windows.Forms.PictureBox()
        Me.lbltxtPreview = New System.Windows.Forms.Label()
        Me.txtClrPreview = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDefault = New System.Windows.Forms.Button()
        Me.grpBoxBackColour.SuspendLayout()
        CType(Me.clrBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBoxTextColour.SuspendLayout()
        CType(Me.clrText, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpBoxBackColour
        '
        Me.grpBoxBackColour.Controls.Add(Me.lblBckgrndClr)
        Me.grpBoxBackColour.Controls.Add(Me.btnChooseBckgrnd)
        Me.grpBoxBackColour.Controls.Add(Me.clrBackground)
        Me.grpBoxBackColour.Location = New System.Drawing.Point(12, 12)
        Me.grpBoxBackColour.Name = "grpBoxBackColour"
        Me.grpBoxBackColour.Size = New System.Drawing.Size(200, 80)
        Me.grpBoxBackColour.TabIndex = 0
        Me.grpBoxBackColour.TabStop = False
        Me.grpBoxBackColour.Text = "Background Colour"
        '
        'lblBckgrndClr
        '
        Me.lblBckgrndClr.AutoSize = True
        Me.lblBckgrndClr.Location = New System.Drawing.Point(113, 10)
        Me.lblBckgrndClr.Name = "lblBckgrndClr"
        Me.lblBckgrndClr.Size = New System.Drawing.Size(81, 13)
        Me.lblBckgrndClr.TabIndex = 0
        Me.lblBckgrndClr.Text = "Colour Preview:"
        '
        'btnChooseBckgrnd
        '
        Me.btnChooseBckgrnd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChooseBckgrnd.Location = New System.Drawing.Point(6, 19)
        Me.btnChooseBckgrnd.Name = "btnChooseBckgrnd"
        Me.btnChooseBckgrnd.Size = New System.Drawing.Size(85, 51)
        Me.btnChooseBckgrnd.TabIndex = 1
        Me.btnChooseBckgrnd.Text = "Choose Background Colour..."
        Me.btnChooseBckgrnd.UseVisualStyleBackColor = True
        '
        'clrBackground
        '
        Me.clrBackground.BackColor = System.Drawing.Color.White
        Me.clrBackground.Location = New System.Drawing.Point(116, 26)
        Me.clrBackground.Name = "clrBackground"
        Me.clrBackground.Size = New System.Drawing.Size(78, 37)
        Me.clrBackground.TabIndex = 0
        Me.clrBackground.TabStop = False
        '
        'grpBoxTextColour
        '
        Me.grpBoxTextColour.Controls.Add(Me.lblForeClr)
        Me.grpBoxTextColour.Controls.Add(Me.btnChooseForeClr)
        Me.grpBoxTextColour.Controls.Add(Me.clrText)
        Me.grpBoxTextColour.Location = New System.Drawing.Point(219, 13)
        Me.grpBoxTextColour.Name = "grpBoxTextColour"
        Me.grpBoxTextColour.Size = New System.Drawing.Size(202, 79)
        Me.grpBoxTextColour.TabIndex = 1
        Me.grpBoxTextColour.TabStop = False
        Me.grpBoxTextColour.Text = "Text Colour"
        '
        'lblForeClr
        '
        Me.lblForeClr.AutoSize = True
        Me.lblForeClr.Location = New System.Drawing.Point(113, 9)
        Me.lblForeClr.Name = "lblForeClr"
        Me.lblForeClr.Size = New System.Drawing.Size(81, 13)
        Me.lblForeClr.TabIndex = 0
        Me.lblForeClr.Text = "Colour Preview:"
        '
        'btnChooseForeClr
        '
        Me.btnChooseForeClr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChooseForeClr.Location = New System.Drawing.Point(6, 18)
        Me.btnChooseForeClr.Name = "btnChooseForeClr"
        Me.btnChooseForeClr.Size = New System.Drawing.Size(85, 51)
        Me.btnChooseForeClr.TabIndex = 2
        Me.btnChooseForeClr.Text = "Choose Text Colour..."
        Me.btnChooseForeClr.UseVisualStyleBackColor = True
        '
        'clrText
        '
        Me.clrText.BackColor = System.Drawing.Color.Black
        Me.clrText.Location = New System.Drawing.Point(116, 25)
        Me.clrText.Name = "clrText"
        Me.clrText.Size = New System.Drawing.Size(78, 37)
        Me.clrText.TabIndex = 1
        Me.clrText.TabStop = False
        '
        'lbltxtPreview
        '
        Me.lbltxtPreview.AutoSize = True
        Me.lbltxtPreview.Location = New System.Drawing.Point(12, 99)
        Me.lbltxtPreview.Name = "lbltxtPreview"
        Me.lbltxtPreview.Size = New System.Drawing.Size(72, 13)
        Me.lbltxtPreview.TabIndex = 0
        Me.lbltxtPreview.Text = "Text Preview:"
        '
        'txtClrPreview
        '
        Me.txtClrPreview.Location = New System.Drawing.Point(12, 115)
        Me.txtClrPreview.Multiline = True
        Me.txtClrPreview.Name = "txtClrPreview"
        Me.txtClrPreview.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtClrPreview.Size = New System.Drawing.Size(409, 106)
        Me.txtClrPreview.TabIndex = 3
        Me.txtClrPreview.Text = "This is what it will look like."
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(184, 227)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(346, 227)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnDefault
        '
        Me.btnDefault.Location = New System.Drawing.Point(265, 227)
        Me.btnDefault.Name = "btnDefault"
        Me.btnDefault.Size = New System.Drawing.Size(75, 23)
        Me.btnDefault.TabIndex = 5
        Me.btnDefault.Text = "Default"
        Me.btnDefault.UseVisualStyleBackColor = True
        '
        'frmColourChooser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 262)
        Me.Controls.Add(Me.btnDefault)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtClrPreview)
        Me.Controls.Add(Me.lbltxtPreview)
        Me.Controls.Add(Me.grpBoxTextColour)
        Me.Controls.Add(Me.grpBoxBackColour)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmColourChooser"
        Me.Text = "Colour Chooser"
        Me.grpBoxBackColour.ResumeLayout(False)
        Me.grpBoxBackColour.PerformLayout()
        CType(Me.clrBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBoxTextColour.ResumeLayout(False)
        Me.grpBoxTextColour.PerformLayout()
        CType(Me.clrText, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpBoxBackColour As System.Windows.Forms.GroupBox
    Friend WithEvents lblBckgrndClr As System.Windows.Forms.Label
    Friend WithEvents btnChooseBckgrnd As System.Windows.Forms.Button
    Friend WithEvents clrBackground As System.Windows.Forms.PictureBox
    Friend WithEvents grpBoxTextColour As System.Windows.Forms.GroupBox
    Friend WithEvents lblForeClr As System.Windows.Forms.Label
    Friend WithEvents btnChooseForeClr As System.Windows.Forms.Button
    Friend WithEvents clrText As System.Windows.Forms.PictureBox
    Friend WithEvents lbltxtPreview As System.Windows.Forms.Label
    Friend WithEvents txtClrPreview As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnDefault As System.Windows.Forms.Button
End Class
