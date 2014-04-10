Public Class findReplaceForm

    Private Sub btnFind_Click(sender As System.Object, e As System.EventArgs) Handles btnFind.Click
        Notepad.Editing.FindText(Notepad.Editing.targetPosition + 1, EditorForm.txtMain, textToFind, chkCase.Checked)
    End Sub
    Private Sub btnReplace_Click(sender As System.Object, e As System.EventArgs) Handles btnReplace.Click
        Notepad.Editing.ReplaceText(Notepad.Editing.targetPosition + 1, EditorForm.txtMain, textToFind, chkCase.Checked, ReplaceText)
    End Sub
    Private Sub btnReplaceAll_Click(sender As System.Object, e As System.EventArgs) Handles btnReplaceAll.Click
        Notepad.Editing.ReplaceAll(EditorForm.txtMain, textToFind, chkCase.Checked, ReplaceText)
    End Sub

   
    Private Sub textToFind_TextChanged(sender As System.Object, e As System.EventArgs) Handles textToFind.TextChanged
        'if the findtextbox isn't empty then
        If textToFind.Text <> "" Then
            'Enable the buttons
            btnFind.Enabled = True
            btnReplace.Enabled = True
            btnReplaceAll.Enabled = True
        ElseIf textToFind.Text = "" Then
            'Disable the buttons
            btnFind.Enabled = False
            btnReplace.Enabled = False
            btnReplaceAll.Enabled = False
        End If
    End Sub
End Class