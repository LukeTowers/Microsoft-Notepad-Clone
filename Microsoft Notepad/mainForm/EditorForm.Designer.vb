<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditorForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditorForm))
        Me.MainMenu = New System.Windows.Forms.MainMenu(Me.components)
        Me.fileMenu = New System.Windows.Forms.MenuItem()
        Me.newTool = New System.Windows.Forms.MenuItem()
        Me.addFileTool = New System.Windows.Forms.MenuItem()
        Me.openTool = New System.Windows.Forms.MenuItem()
        Me.saveTool = New System.Windows.Forms.MenuItem()
        Me.saveAsTool = New System.Windows.Forms.MenuItem()
        Me.mnuDvdr1 = New System.Windows.Forms.MenuItem()
        Me.pageSetupTool = New System.Windows.Forms.MenuItem()
        Me.printTool = New System.Windows.Forms.MenuItem()
        Me.mnuDvdr2 = New System.Windows.Forms.MenuItem()
        Me.exitTool = New System.Windows.Forms.MenuItem()
        Me.editMenu = New System.Windows.Forms.MenuItem()
        Me.undoTool = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.cutTool = New System.Windows.Forms.MenuItem()
        Me.copyTool = New System.Windows.Forms.MenuItem()
        Me.pasteTool = New System.Windows.Forms.MenuItem()
        Me.deleteTool = New System.Windows.Forms.MenuItem()
        Me.mnuDvdr4 = New System.Windows.Forms.MenuItem()
        Me.findTool = New System.Windows.Forms.MenuItem()
        Me.findNextTool = New System.Windows.Forms.MenuItem()
        Me.replaceTool = New System.Windows.Forms.MenuItem()
        Me.mnuDvdr5 = New System.Windows.Forms.MenuItem()
        Me.selectAllTool = New System.Windows.Forms.MenuItem()
        Me.timeDateTool = New System.Windows.Forms.MenuItem()
        Me.formatMenu = New System.Windows.Forms.MenuItem()
        Me.wordWrapTool = New System.Windows.Forms.MenuItem()
        Me.fontTool = New System.Windows.Forms.MenuItem()
        Me.viewMenu = New System.Windows.Forms.MenuItem()
        Me.chooseClrTool = New System.Windows.Forms.MenuItem()
        Me.helpMenu = New System.Windows.Forms.MenuItem()
        Me.helpTool = New System.Windows.Forms.MenuItem()
        Me.mnuDvdr6 = New System.Windows.Forms.MenuItem()
        Me.aboutTool = New System.Windows.Forms.MenuItem()
        Me.applicationRefreshTimer = New System.Windows.Forms.Timer(Me.components)
        Me.pageSetupDialog = New System.Windows.Forms.PageSetupDialog()
        Me.mainDocument = New System.Drawing.Printing.PrintDocument()
        Me.printDialog = New System.Windows.Forms.PrintDialog()
        Me.txtMain = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'MainMenu
        '
        Me.MainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.fileMenu, Me.editMenu, Me.formatMenu, Me.viewMenu, Me.helpMenu})
        '
        'fileMenu
        '
        Me.fileMenu.Index = 0
        Me.fileMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.newTool, Me.addFileTool, Me.openTool, Me.saveTool, Me.saveAsTool, Me.mnuDvdr1, Me.pageSetupTool, Me.printTool, Me.mnuDvdr2, Me.exitTool})
        Me.fileMenu.Text = "&File"
        '
        'newTool
        '
        Me.newTool.Index = 0
        Me.newTool.Shortcut = System.Windows.Forms.Shortcut.CtrlN
        Me.newTool.Text = "&New"
        '
        'addFileTool
        '
        Me.addFileTool.Index = 1
        Me.addFileTool.Shortcut = System.Windows.Forms.Shortcut.CtrlQ
        Me.addFileTool.Text = "&Add File..."
        '
        'openTool
        '
        Me.openTool.Index = 2
        Me.openTool.Shortcut = System.Windows.Forms.Shortcut.CtrlO
        Me.openTool.Text = "&Open..."
        '
        'saveTool
        '
        Me.saveTool.Index = 3
        Me.saveTool.Shortcut = System.Windows.Forms.Shortcut.CtrlS
        Me.saveTool.Text = "&Save"
        '
        'saveAsTool
        '
        Me.saveAsTool.Index = 4
        Me.saveAsTool.Text = "&Save As..."
        '
        'mnuDvdr1
        '
        Me.mnuDvdr1.Index = 5
        Me.mnuDvdr1.Text = "-"
        '
        'pageSetupTool
        '
        Me.pageSetupTool.Index = 6
        Me.pageSetupTool.Text = "&Page Setup"
        '
        'printTool
        '
        Me.printTool.Index = 7
        Me.printTool.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.printTool.Text = "&Print..."
        '
        'mnuDvdr2
        '
        Me.mnuDvdr2.Index = 8
        Me.mnuDvdr2.Text = "-"
        '
        'exitTool
        '
        Me.exitTool.Index = 9
        Me.exitTool.Text = "&Exit"
        '
        'editMenu
        '
        Me.editMenu.Index = 1
        Me.editMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.undoTool, Me.MenuItem2, Me.cutTool, Me.copyTool, Me.pasteTool, Me.deleteTool, Me.mnuDvdr4, Me.findTool, Me.findNextTool, Me.replaceTool, Me.mnuDvdr5, Me.selectAllTool, Me.timeDateTool})
        Me.editMenu.Text = "&Edit"
        '
        'undoTool
        '
        Me.undoTool.Index = 0
        Me.undoTool.Shortcut = System.Windows.Forms.Shortcut.CtrlZ
        Me.undoTool.Text = "&Undo"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "-"
        '
        'cutTool
        '
        Me.cutTool.Index = 2
        Me.cutTool.Shortcut = System.Windows.Forms.Shortcut.CtrlX
        Me.cutTool.Text = "&Cut"
        '
        'copyTool
        '
        Me.copyTool.Index = 3
        Me.copyTool.Shortcut = System.Windows.Forms.Shortcut.CtrlC
        Me.copyTool.Text = "&Copy"
        '
        'pasteTool
        '
        Me.pasteTool.Index = 4
        Me.pasteTool.Shortcut = System.Windows.Forms.Shortcut.CtrlV
        Me.pasteTool.Text = "&Paste"
        '
        'deleteTool
        '
        Me.deleteTool.Index = 5
        Me.deleteTool.Text = "&Delete"
        '
        'mnuDvdr4
        '
        Me.mnuDvdr4.Index = 6
        Me.mnuDvdr4.Text = "-"
        '
        'findTool
        '
        Me.findTool.Index = 7
        Me.findTool.Shortcut = System.Windows.Forms.Shortcut.CtrlF
        Me.findTool.Text = "&Find..."
        '
        'findNextTool
        '
        Me.findNextTool.Index = 8
        Me.findNextTool.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.findNextTool.Text = "&Find Next"
        '
        'replaceTool
        '
        Me.replaceTool.Index = 9
        Me.replaceTool.Shortcut = System.Windows.Forms.Shortcut.CtrlH
        Me.replaceTool.Text = "&Replace"
        '
        'mnuDvdr5
        '
        Me.mnuDvdr5.Index = 10
        Me.mnuDvdr5.Text = "-"
        '
        'selectAllTool
        '
        Me.selectAllTool.Index = 11
        Me.selectAllTool.Shortcut = System.Windows.Forms.Shortcut.CtrlA
        Me.selectAllTool.Text = "&Select All"
        '
        'timeDateTool
        '
        Me.timeDateTool.Index = 12
        Me.timeDateTool.Shortcut = System.Windows.Forms.Shortcut.CtrlD
        Me.timeDateTool.Text = "&Time/Date"
        '
        'formatMenu
        '
        Me.formatMenu.Index = 2
        Me.formatMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.wordWrapTool, Me.fontTool})
        Me.formatMenu.Text = "&Format"
        '
        'wordWrapTool
        '
        Me.wordWrapTool.Checked = True
        Me.wordWrapTool.Index = 0
        Me.wordWrapTool.Text = "&Word Wrap"
        '
        'fontTool
        '
        Me.fontTool.Index = 1
        Me.fontTool.Text = "&Font..."
        '
        'viewMenu
        '
        Me.viewMenu.Index = 3
        Me.viewMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.chooseClrTool})
        Me.viewMenu.Text = "&View"
        '
        'chooseClrTool
        '
        Me.chooseClrTool.Index = 0
        Me.chooseClrTool.Shortcut = System.Windows.Forms.Shortcut.CtrlW
        Me.chooseClrTool.Text = "&Colour Chooser"
        '
        'helpMenu
        '
        Me.helpMenu.Index = 4
        Me.helpMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.helpTool, Me.mnuDvdr6, Me.aboutTool})
        Me.helpMenu.Text = "&Help"
        '
        'helpTool
        '
        Me.helpTool.Index = 0
        Me.helpTool.Shortcut = System.Windows.Forms.Shortcut.F1
        Me.helpTool.Text = "&View Help"
        '
        'mnuDvdr6
        '
        Me.mnuDvdr6.Index = 1
        Me.mnuDvdr6.Text = "-"
        '
        'aboutTool
        '
        Me.aboutTool.Index = 2
        Me.aboutTool.Text = "&About Notepad"
        '
        'applicationRefreshTimer
        '
        Me.applicationRefreshTimer.Enabled = True
        '
        'pageSetupDialog
        '
        Me.pageSetupDialog.Document = Me.mainDocument
        '
        'mainDocument
        '
        Me.mainDocument.DocumentName = "Untitled"
        '
        'printDialog
        '
        Me.printDialog.Document = Me.mainDocument
        Me.printDialog.UseEXDialog = True
        '
        'txtMain
        '
        Me.txtMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMain.Location = New System.Drawing.Point(0, 0)
        Me.txtMain.Multiline = True
        Me.txtMain.Name = "txtMain"
        Me.txtMain.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtMain.Size = New System.Drawing.Size(440, 224)
        Me.txtMain.TabIndex = 1
        '
        'EditorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 224)
        Me.Controls.Add(Me.txtMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.MainMenu
        Me.Name = "EditorForm"
        Me.Text = "Notepad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainMenu As System.Windows.Forms.MainMenu
    Friend WithEvents fileMenu As System.Windows.Forms.MenuItem
    Friend WithEvents newTool As System.Windows.Forms.MenuItem
    Friend WithEvents openTool As System.Windows.Forms.MenuItem
    Friend WithEvents saveTool As System.Windows.Forms.MenuItem
    Friend WithEvents saveAsTool As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDvdr1 As System.Windows.Forms.MenuItem
    Friend WithEvents pageSetupTool As System.Windows.Forms.MenuItem
    Friend WithEvents printTool As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDvdr2 As System.Windows.Forms.MenuItem
    Friend WithEvents exitTool As System.Windows.Forms.MenuItem
    Friend WithEvents editMenu As System.Windows.Forms.MenuItem
    Friend WithEvents formatMenu As System.Windows.Forms.MenuItem
    Friend WithEvents viewMenu As System.Windows.Forms.MenuItem
    Friend WithEvents helpMenu As System.Windows.Forms.MenuItem
    Friend WithEvents undoTool As System.Windows.Forms.MenuItem
    Friend WithEvents cutTool As System.Windows.Forms.MenuItem
    Friend WithEvents copyTool As System.Windows.Forms.MenuItem
    Friend WithEvents pasteTool As System.Windows.Forms.MenuItem
    Friend WithEvents deleteTool As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDvdr4 As System.Windows.Forms.MenuItem
    Friend WithEvents findTool As System.Windows.Forms.MenuItem
    Friend WithEvents findNextTool As System.Windows.Forms.MenuItem
    Friend WithEvents replaceTool As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDvdr5 As System.Windows.Forms.MenuItem
    Friend WithEvents selectAllTool As System.Windows.Forms.MenuItem
    Friend WithEvents timeDateTool As System.Windows.Forms.MenuItem
    Friend WithEvents wordWrapTool As System.Windows.Forms.MenuItem
    Friend WithEvents fontTool As System.Windows.Forms.MenuItem
    Friend WithEvents helpTool As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDvdr6 As System.Windows.Forms.MenuItem
    Friend WithEvents aboutTool As System.Windows.Forms.MenuItem
    Friend WithEvents applicationRefreshTimer As System.Windows.Forms.Timer
    Friend WithEvents pageSetupDialog As System.Windows.Forms.PageSetupDialog
    Friend WithEvents mainDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents printDialog As System.Windows.Forms.PrintDialog
    Friend WithEvents txtMain As System.Windows.Forms.TextBox
    Friend WithEvents addFileTool As System.Windows.Forms.MenuItem
    Friend WithEvents chooseClrTool As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem

End Class
