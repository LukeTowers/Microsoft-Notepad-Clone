Public Class frmHelp
    'FAQ button code
    Private Sub btnNtpdFAQ_Click(sender As System.Object, e As System.EventArgs) Handles btnNtpdFAQ.Click
        'Uncheck all the buttons
        uncheckAllButtons()
        'Scroll to the begining
        rtfHelpDisplay.ScrollToCaret()
        'Check the appropiate button
        btnNtpdFAQ.Checked = True
        Notepad.FileManipulation.OpenRTFResource(My.Resources.ntpdHelpFile, rtfHelpDisplay)
    End Sub
    Private Sub btnEdtingFAQ_Click(sender As System.Object, e As System.EventArgs) Handles btnEdtingFAQ.Click
        'Uncheck all the buttons
        uncheckAllButtons()
        'Scroll to the begining
        rtfHelpDisplay.ScrollToCaret()
        'Check the appropiate button
        btnEdtingFAQ.Checked = True
        Notepad.FileManipulation.OpenRTFResource(My.Resources.editHelpFile, rtfHelpDisplay)
    End Sub
    Private Sub btnPrntingFAQ_Click(sender As System.Object, e As System.EventArgs) Handles btnPrntingFAQ.Click
        'Uncheck all the buttons
        uncheckAllButtons()
        'Scroll to the begining
        rtfHelpDisplay.ScrollToCaret()
        'Check the appropiate button
        btnPrntingFAQ.Checked = True
        Notepad.FileManipulation.OpenRTFResource(My.Resources.printingHelpFile, rtfHelpDisplay)
    End Sub
    Private Sub uncheckAllButtons()
        btnNtpdFAQ.Checked = False
        btnEdtingFAQ.Checked = False
        btnPrntingFAQ.Checked = False
    End Sub

    'Support code
    Private Sub btnSend_Click(sender As System.Object, e As System.EventArgs) Handles btnSend.Click
        Notepad.Help.sendUserRequest(txtProblem.Text, txtEmail.Text)
    End Sub
    Private Sub txtEmail_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtEmail.TextChanged
        If txtEmail.Text = "" Or txtProblem.Text = "" Then
            btnSend.Enabled = False
        Else
            btnSend.Enabled = True
        End If
    End Sub
    Private Sub txtProblem_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtProblem.TextChanged
        If txtEmail.Text = "" Or txtProblem.Text = "" Then
            btnSend.Enabled = False
        Else
            btnSend.Enabled = True
        End If
    End Sub

End Class