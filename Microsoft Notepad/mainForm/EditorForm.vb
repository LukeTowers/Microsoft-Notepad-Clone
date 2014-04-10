Public Class EditorForm
    Public DocumentName As String = "Untitled"
    Public DocumentPath As String

    'Code to run on the opnening of the main form(the program)
    Private Sub mainForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Load the user settings from the last time it was opened
        Notepad.FileManipulation.LoadUserSettings()
        'Check if the program has been opened by a file being double clicked
        'if so the open it
        Notepad.FileManipulation.OpenDoubleClickedFile(txtMain)
    End Sub
    'Code to run on the closing of the main form
    Private Sub mainForm_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Check if the document has been modified
        If txtMain.Modified = True Then
            'Ask the user if they want ro save the changes before closing
            Dim saveChanges As MsgBoxResult = MsgBox("Do you want to save the changes to " & DocumentName & "?", MsgBoxStyle.YesNoCancel, "Notepad")
            If saveChanges = MsgBoxResult.No Then 'If no, then continue on shutting the program down
            ElseIf saveChanges = MsgBoxResult.Cancel Then 'If cancel, then stop the shutdown process and allow the user to continue editing
                e.Cancel = True
            ElseIf saveChanges = MsgBoxResult.Yes Then 'If yes, then save the file, and shut down the program
                Notepad.FileManipulation.Save(txtMain)
            End If
        Else 'if it hasn't, then "Houston we are clear for shutdown." :)
        End If
        'Save the current program settings
        Notepad.FileManipulation.SaveUserSettings()
        'End the program using the end statement to close everything opened by the program
        End
    End Sub

    'This code is run to update the user interface
    Private Sub applicationRefreshTimer_Tick(sender As System.Object, e As System.EventArgs) Handles applicationRefreshTimer.Tick
        'All of this code would be better placed in places other than a timer which will probably slow down the
        'the program a bit, but I am on a very tight schedule, so look for version 1.00.002 in the summer!

        'Run the check for the availibility of the cut,copy,delete buttons
        If txtMain.SelectionLength < 0 Then
            cutTool.Enabled = False
            copyTool.Enabled = False
            deleteTool.Enabled = False
        ElseIf txtMain.SelectionLength > 0 Then
            cutTool.Enabled = True
            copyTool.Enabled = True
            deleteTool.Enabled = True
        End If

        'Run the check for the availibility of the paste button
        If Clipboard.ContainsText Then
            pasteTool.Enabled = True
        Else
            pasteTool.Enabled = False
        End If

        'Run the check for the availibility of the find,findnext,replace,selectall buttons
        If txtMain.Text = Nothing Then
            findTool.Enabled = False
            findNextTool.Enabled = False
            replaceTool.Enabled = False
            selectAllTool.Enabled = False
        Else
            findTool.Enabled = True
            findNextTool.Enabled = True
            replaceTool.Enabled = True
            selectAllTool.Enabled = True
        End If
        'Set the printing settings to the name of the document
        mainDocument.DocumentName = DocumentName
        'Update the user interface by displaying the current document name by the editorform's title
        Me.Text = DocumentName & " - Notepad"
    End Sub


    'File Menu button code
    'each button calls the sub it is assigned to from the Notepad class
    Private Sub newTool_Click(sender As System.Object, e As System.EventArgs) Handles newTool.Click
        Notepad.FileManipulation.NewDocument(txtMain)
    End Sub
    Private Sub addFileTool_Click(sender As System.Object, e As System.EventArgs) Handles addFileTool.Click
        frmAddFile.Show()
    End Sub
    Private Sub openTool_Click(sender As System.Object, e As System.EventArgs) Handles openTool.Click
        Notepad.FileManipulation.Open(txtMain)
    End Sub
    Private Sub saveTool_Click(sender As System.Object, e As System.EventArgs) Handles saveTool.Click
        Notepad.FileManipulation.Save(txtMain)
    End Sub
    Private Sub saveAsTool_Click(sender As System.Object, e As System.EventArgs) Handles saveAsTool.Click
        Notepad.FileManipulation.SaveAs(txtMain)
    End Sub
    'Printing code; it works as far as I have tested it
    Private Sub pageSetupTool_Click(sender As System.Object, e As System.EventArgs) Handles pageSetupTool.Click
        pageSetupDialog.ShowDialog()
    End Sub
    Private Sub printTool_Click(sender As System.Object, e As System.EventArgs) Handles printTool.Click
        If printDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            mainDocument.Print()
        End If
    End Sub
    Private Sub mainDocument_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles mainDocument.PrintPage
        e.Graphics.DrawString(txtMain.Text, txtMain.Font, Brushes.Black, 100, 100)
    End Sub
    Private Sub exitTool_Click(sender As System.Object, e As System.EventArgs) Handles exitTool.Click
        Me.Close()
    End Sub


    'Edit Menu button code
    'each button calls the sub it is assigned to from the Notepad class
    Private Sub chooseClrTool_Click(sender As System.Object, e As System.EventArgs) Handles chooseClrTool.Click
        frmColourChooser.Show()
    End Sub
    Private Sub undoTool_Click(sender As System.Object, e As System.EventArgs) Handles undoTool.Click
        Notepad.Editing.Undo(txtMain)
    End Sub
    Private Sub cutTool_Click(sender As System.Object, e As System.EventArgs) Handles cutTool.Click
        Notepad.Editing.Cut(txtMain)
    End Sub
    Private Sub copyTool_Click(sender As System.Object, e As System.EventArgs) Handles copyTool.Click
        Notepad.Editing.Copy(txtMain)
    End Sub
    Private Sub pasteTool_Click(sender As System.Object, e As System.EventArgs) Handles pasteTool.Click
        Notepad.Editing.Paste(txtMain)
    End Sub
    Private Sub deleteTool_Click(sender As System.Object, e As System.EventArgs) Handles deleteTool.Click
        txtMain.SelectedText = ""
    End Sub
    Private Sub selectAllTool_Click(sender As System.Object, e As System.EventArgs) Handles selectAllTool.Click
        Notepad.Editing.SelectAll(txtMain)
    End Sub
    Private Sub timeDateTool_Click(sender As System.Object, e As System.EventArgs) Handles timeDateTool.Click
        Notepad.Editing.insertDateTime(txtMain)
    End Sub
    Private Sub findTool_Click(sender As System.Object, e As System.EventArgs) Handles findTool.Click
        findReplaceForm.Show()
    End Sub
    Private Sub findNextTool_Click(sender As System.Object, e As System.EventArgs) Handles findNextTool.Click
        findReplaceForm.Show()
    End Sub
    Private Sub replaceTool_Click(sender As System.Object, e As System.EventArgs) Handles replaceTool.Click
        findReplaceForm.Show()
    End Sub

    'Format Menu button code
    'each button calls the sub it is assigned to from the Notepad class
    Private Sub wordWrapTool_Click(sender As System.Object, e As System.EventArgs) Handles wordWrapTool.Click
        Notepad.Editing.ChangeWordWrap()
    End Sub
    Private Sub fontTool_Click(sender As System.Object, e As System.EventArgs) Handles fontTool.Click
        Notepad.Editing.ChooseFont(txtMain)
    End Sub

    'Help menu button code
    'Each button calls the form it is assigned to
    Private Sub helpTool_Click(sender As System.Object, e As System.EventArgs) Handles helpTool.Click
        frmHelp.Show()
    End Sub
    Private Sub aboutTool_Click(sender As System.Object, e As System.EventArgs) Handles aboutTool.Click
        frmAbout.Show()
    End Sub

End Class