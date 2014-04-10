<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Me.picCuBeLogo = New System.Windows.Forms.PictureBox()
        Me.lblProduct = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.lblLicence = New System.Windows.Forms.Label()
        Me.lnkLblTerms = New System.Windows.Forms.LinkLabel()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblCurrentUser = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        CType(Me.picCuBeLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCuBeLogo
        '
        Me.picCuBeLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.picCuBeLogo.Location = New System.Drawing.Point(9, 9)
        Me.picCuBeLogo.Name = "picCuBeLogo"
        Me.picCuBeLogo.Size = New System.Drawing.Size(310, 84)
        Me.picCuBeLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCuBeLogo.TabIndex = 0
        Me.picCuBeLogo.TabStop = False
        '
        'lblProduct
        '
        Me.lblProduct.AutoSize = True
        Me.lblProduct.Location = New System.Drawing.Point(70, 99)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(77, 13)
        Me.lblProduct.TabIndex = 0
        Me.lblProduct.Text = "CuBe Notepad"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(71, 120)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(108, 13)
        Me.lblVersion.TabIndex = 2
        Me.lblVersion.Text = "Version: OpenSource"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Notepad.My.Resources.Resources.ntpdLogo
        Me.PictureBox1.Location = New System.Drawing.Point(9, 99)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.Location = New System.Drawing.Point(71, 141)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(115, 13)
        Me.lblCopyright.TabIndex = 4
        Me.lblCopyright.Text = "Open Source Software"
        '
        'lblLicence
        '
        Me.lblLicence.AutoSize = True
        Me.lblLicence.Location = New System.Drawing.Point(6, 171)
        Me.lblLicence.Name = "lblLicence"
        Me.lblLicence.Size = New System.Drawing.Size(168, 13)
        Me.lblLicence.TabIndex = 5
        Me.lblLicence.Text = "This Product is licenced under the"
        '
        'lnkLblTerms
        '
        Me.lnkLblTerms.AutoSize = True
        Me.lnkLblTerms.Location = New System.Drawing.Point(6, 184)
        Me.lnkLblTerms.Name = "lnkLblTerms"
        Me.lnkLblTerms.Size = New System.Drawing.Size(237, 13)
        Me.lnkLblTerms.TabIndex = 6
        Me.lnkLblTerms.TabStop = True
        Me.lnkLblTerms.Text = "CuBe Laboratories Open-Source Software Terms"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(9, 201)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(19, 13)
        Me.lblTo.TabIndex = 7
        Me.lblTo.Text = "to:"
        '
        'lblCurrentUser
        '
        Me.lblCurrentUser.AutoSize = True
        Me.lblCurrentUser.Location = New System.Drawing.Point(34, 201)
        Me.lblCurrentUser.Name = "lblCurrentUser"
        Me.lblCurrentUser.Size = New System.Drawing.Size(66, 13)
        Me.lblCurrentUser.TabIndex = 8
        Me.lblCurrentUser.Text = "Current User"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(241, 199)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 9
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 234)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lblCurrentUser)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.lnkLblTerms)
        Me.Controls.Add(Me.lblLicence)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblProduct)
        Me.Controls.Add(Me.picCuBeLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbout"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        Me.TopMost = True
        CType(Me.picCuBeLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picCuBeLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblProduct As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblCopyright As System.Windows.Forms.Label
    Friend WithEvents lblLicence As System.Windows.Forms.Label
    Friend WithEvents lnkLblTerms As System.Windows.Forms.LinkLabel
    Friend WithEvents lblTo As System.Windows.Forms.Label
    Friend WithEvents lblCurrentUser As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button

End Class
