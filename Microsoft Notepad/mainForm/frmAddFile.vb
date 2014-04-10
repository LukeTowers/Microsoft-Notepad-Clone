Public Class frmAddFile
    'This is one of the improvements I am adding to my clone of MS Notepad
    'It is a file combiner to combine the contents of a file with the current
    'file being edited in the editorform

    Private Sub btnOpen_Click(sender As System.Object, e As System.EventArgs) Handles btnOpen.Click
        'Open a file and display it in the txtFilePreview textbox
        Notepad.FileManipulation.OpenFileForAdding(txtFilePreview)
        'Allow the user to change the text in the txtpreview textbox
        txtFilePreview.Enabled = True
        'Allow the user to add the file
        btnAdd.Enabled = True
    End Sub
    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        If rdBtnBegining.Checked = True Then
            AddToBegining()
        ElseIf rdBtnSelected.Checked = True Then
            ReplaceSelectedText()
        ElseIf rdBtnEnd.Checked = True Then
            AddToEnd()
        End If
    End Sub
    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub AddToBegining()
        'Declare a temporary string to hold the combined file until it is sent to the editor form
        Dim tempString As String
        'Load the string with the value of txtFilePreview.Text
        tempString = txtFilePreview.Text & " "
        'Add the value of txtMain to the string so that the file chosen to be added is now at the 
        'begining of the string and the original file is now at the end
        tempString += EditorForm.txtMain.Text
        'Display this new, combined string in the editor form
        EditorForm.txtMain.Text = tempString
        'Close the addfile form
        Me.Close()
    End Sub
    Private Sub ReplaceSelectedText()
        'Determine whether or not there is selected text in the editor form
        If EditorForm.txtMain.SelectionLength > 0 Then
            'If yes then replace it with the file chosen
            EditorForm.txtMain.SelectedText = " " & txtFilePreview.Text & " "
            'then close the frm add
            Me.Close()
        Else
            MsgBox("ERROR: No text is selected.")
        End If
    End Sub
    Private Sub AddToEnd()
        'Declare a temporary string to hold the combined file until it is sent to the editor form
        Dim tempString As String
        'Load the string with the value of txtMain.Text
        tempString = EditorForm.txtMain.Text & " "
        'Add the value of the chosen file to the end of the string
        tempString += txtFilePreview.Text
        'Display the combined file in the editorform
        EditorForm.txtMain.Text = tempString
        'close the frmadd
        Me.Close()
    End Sub

End Class