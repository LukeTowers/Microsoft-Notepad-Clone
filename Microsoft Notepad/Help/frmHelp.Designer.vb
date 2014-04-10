<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHelp))
        Me.tbCntrlHelp = New System.Windows.Forms.TabControl()
        Me.tbFAQ = New System.Windows.Forms.TabPage()
        Me.rtfHelpDisplay = New System.Windows.Forms.RichTextBox()
        Me.tlstrpFAQs = New System.Windows.Forms.ToolStrip()
        Me.btnNtpdFAQ = New System.Windows.Forms.ToolStripButton()
        Me.btnEdtingFAQ = New System.Windows.Forms.ToolStripButton()
        Me.btnPrntingFAQ = New System.Windows.Forms.ToolStripButton()
        Me.tbSupport = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.txtProblem = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.btnNotepadFAQ = New System.Windows.Forms.ToolStripButton()
        Me.btnEditingFAQ = New System.Windows.Forms.ToolStripButton()
        Me.btnPrintingFAQ = New System.Windows.Forms.ToolStripButton()
        Me.tbCntrlHelp.SuspendLayout()
        Me.tbFAQ.SuspendLayout()
        Me.tlstrpFAQs.SuspendLayout()
        Me.tbSupport.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbCntrlHelp
        '
        Me.tbCntrlHelp.Controls.Add(Me.tbFAQ)
        Me.tbCntrlHelp.Controls.Add(Me.tbSupport)
        Me.tbCntrlHelp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbCntrlHelp.Location = New System.Drawing.Point(0, 0)
        Me.tbCntrlHelp.Name = "tbCntrlHelp"
        Me.tbCntrlHelp.SelectedIndex = 0
        Me.tbCntrlHelp.Size = New System.Drawing.Size(641, 262)
        Me.tbCntrlHelp.TabIndex = 0
        '
        'tbFAQ
        '
        Me.tbFAQ.Controls.Add(Me.rtfHelpDisplay)
        Me.tbFAQ.Controls.Add(Me.tlstrpFAQs)
        Me.tbFAQ.Location = New System.Drawing.Point(4, 22)
        Me.tbFAQ.Name = "tbFAQ"
        Me.tbFAQ.Padding = New System.Windows.Forms.Padding(3)
        Me.tbFAQ.Size = New System.Drawing.Size(633, 236)
        Me.tbFAQ.TabIndex = 0
        Me.tbFAQ.Text = "FAQ"
        Me.tbFAQ.ToolTipText = "Frequently Asked Questions"
        '
        'rtfHelpDisplay
        '
        Me.rtfHelpDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtfHelpDisplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtfHelpDisplay.Location = New System.Drawing.Point(61, 3)
        Me.rtfHelpDisplay.Name = "rtfHelpDisplay"
        Me.rtfHelpDisplay.ReadOnly = True
        Me.rtfHelpDisplay.Size = New System.Drawing.Size(569, 230)
        Me.rtfHelpDisplay.TabIndex = 0
        Me.rtfHelpDisplay.TabStop = False
        Me.rtfHelpDisplay.Text = "Welcome to Help and Support." & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Please check out one of the FAQ options on the left" & _
    " before sending your question to support."
        '
        'tlstrpFAQs
        '
        Me.tlstrpFAQs.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.tlstrpFAQs.Dock = System.Windows.Forms.DockStyle.Left
        Me.tlstrpFAQs.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tlstrpFAQs.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNtpdFAQ, Me.btnEdtingFAQ, Me.btnPrntingFAQ})
        Me.tlstrpFAQs.Location = New System.Drawing.Point(3, 3)
        Me.tlstrpFAQs.Name = "tlstrpFAQs"
        Me.tlstrpFAQs.Size = New System.Drawing.Size(58, 230)
        Me.tlstrpFAQs.TabIndex = 0
        Me.tlstrpFAQs.Text = "ToolStrip1"
        '
        'btnNtpdFAQ
        '
        Me.btnNtpdFAQ.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnNtpdFAQ.Image = CType(resources.GetObject("btnNtpdFAQ.Image"), System.Drawing.Image)
        Me.btnNtpdFAQ.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNtpdFAQ.Name = "btnNtpdFAQ"
        Me.btnNtpdFAQ.Size = New System.Drawing.Size(55, 19)
        Me.btnNtpdFAQ.Text = "Notepad"
        Me.btnNtpdFAQ.ToolTipText = "FAQ about Notepad"
        '
        'btnEdtingFAQ
        '
        Me.btnEdtingFAQ.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnEdtingFAQ.Image = CType(resources.GetObject("btnEdtingFAQ.Image"), System.Drawing.Image)
        Me.btnEdtingFAQ.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEdtingFAQ.Name = "btnEdtingFAQ"
        Me.btnEdtingFAQ.Size = New System.Drawing.Size(55, 19)
        Me.btnEdtingFAQ.Text = "Editing"
        Me.btnEdtingFAQ.ToolTipText = "FAQ about Editing"
        '
        'btnPrntingFAQ
        '
        Me.btnPrntingFAQ.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnPrntingFAQ.Image = CType(resources.GetObject("btnPrntingFAQ.Image"), System.Drawing.Image)
        Me.btnPrntingFAQ.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrntingFAQ.Name = "btnPrntingFAQ"
        Me.btnPrntingFAQ.Size = New System.Drawing.Size(55, 19)
        Me.btnPrntingFAQ.Text = "Printing"
        Me.btnPrntingFAQ.ToolTipText = "FAQ about Printing"
        '
        'tbSupport
        '
        Me.tbSupport.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbSupport.Controls.Add(Me.PictureBox1)
        Me.tbSupport.Controls.Add(Me.btnSend)
        Me.tbSupport.Controls.Add(Me.txtProblem)
        Me.tbSupport.Controls.Add(Me.txtEmail)
        Me.tbSupport.Controls.Add(Me.lblEmail)
        Me.tbSupport.Controls.Add(Me.lblInstructions)
        Me.tbSupport.Location = New System.Drawing.Point(4, 22)
        Me.tbSupport.Name = "tbSupport"
        Me.tbSupport.Padding = New System.Windows.Forms.Padding(3)
        Me.tbSupport.Size = New System.Drawing.Size(633, 236)
        Me.tbSupport.TabIndex = 1
        Me.tbSupport.Text = "Support"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.Notepad.My.Resources.Resources.SpprtPic
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(138, 230)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'btnSend
        '
        Me.btnSend.Enabled = False
        Me.btnSend.Location = New System.Drawing.Point(550, 210)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 3
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'txtProblem
        '
        Me.txtProblem.Location = New System.Drawing.Point(150, 52)
        Me.txtProblem.Multiline = True
        Me.txtProblem.Name = "txtProblem"
        Me.txtProblem.Size = New System.Drawing.Size(475, 152)
        Me.txtProblem.TabIndex = 2
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(389, 6)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(236, 20)
        Me.txtEmail.TabIndex = 1
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(147, 9)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(236, 13)
        Me.lblEmail.TabIndex = 1
        Me.lblEmail.Text = "Enter email where you can be reached(required):"
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Location = New System.Drawing.Point(147, 36)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(161, 13)
        Me.lblInstructions.TabIndex = 0
        Me.lblInstructions.Text = "Enter the details of your problem:"
        '
        'btnNotepadFAQ
        '
        Me.btnNotepadFAQ.CheckOnClick = True
        Me.btnNotepadFAQ.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnNotepadFAQ.Image = CType(resources.GetObject("btnNotepadFAQ.Image"), System.Drawing.Image)
        Me.btnNotepadFAQ.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNotepadFAQ.Name = "btnNotepadFAQ"
        Me.btnNotepadFAQ.Size = New System.Drawing.Size(55, 19)
        Me.btnNotepadFAQ.Text = "Notepad"
        Me.btnNotepadFAQ.ToolTipText = "FAQ about Notepad"
        '
        'btnEditingFAQ
        '
        Me.btnEditingFAQ.CheckOnClick = True
        Me.btnEditingFAQ.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnEditingFAQ.Image = CType(resources.GetObject("btnEditingFAQ.Image"), System.Drawing.Image)
        Me.btnEditingFAQ.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditingFAQ.Name = "btnEditingFAQ"
        Me.btnEditingFAQ.Size = New System.Drawing.Size(55, 19)
        Me.btnEditingFAQ.Text = "Editing"
        Me.btnEditingFAQ.ToolTipText = "FAQ about editing"
        '
        'btnPrintingFAQ
        '
        Me.btnPrintingFAQ.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnPrintingFAQ.Image = CType(resources.GetObject("btnPrintingFAQ.Image"), System.Drawing.Image)
        Me.btnPrintingFAQ.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrintingFAQ.Name = "btnPrintingFAQ"
        Me.btnPrintingFAQ.Size = New System.Drawing.Size(55, 19)
        Me.btnPrintingFAQ.Text = "Printing"
        Me.btnPrintingFAQ.ToolTipText = "FAQ about printing"
        '
        'frmHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 262)
        Me.Controls.Add(Me.tbCntrlHelp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmHelp"
        Me.ShowInTaskbar = False
        Me.Text = "Help and Support"
        Me.tbCntrlHelp.ResumeLayout(False)
        Me.tbFAQ.ResumeLayout(False)
        Me.tbFAQ.PerformLayout()
        Me.tlstrpFAQs.ResumeLayout(False)
        Me.tlstrpFAQs.PerformLayout()
        Me.tbSupport.ResumeLayout(False)
        Me.tbSupport.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbCntrlHelp As System.Windows.Forms.TabControl
    Friend WithEvents tbFAQ As System.Windows.Forms.TabPage
    Friend WithEvents tbSupport As System.Windows.Forms.TabPage
    Friend WithEvents tlstrpFAQs As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNotepadFAQ As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEditingFAQ As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrintingFAQ As System.Windows.Forms.ToolStripButton
    Friend WithEvents rtfHelpDisplay As System.Windows.Forms.RichTextBox
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents txtProblem As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnNtpdFAQ As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEdtingFAQ As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrntingFAQ As System.Windows.Forms.ToolStripButton
End Class
