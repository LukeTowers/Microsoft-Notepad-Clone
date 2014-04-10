Public Class frmColourChooser
    Dim bckgrndClr As Color = EditorForm.txtMain.BackColor
    Dim TextClr As Color = EditorForm.txtMain.ForeColor

    Private Sub frmColourChooser_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Load the preview panes with the proper colours
        clrBackground.BackColor = EditorForm.txtMain.BackColor
        clrText.BackColor = EditorForm.txtMain.ForeColor
        'Load the txtPreview with the proper colours
        txtClrPreview.ForeColor = TextClr
        txtClrPreview.BackColor = bckgrndClr
    End Sub

    Private Sub btnChooseBckgrnd_Click(sender As System.Object, e As System.EventArgs) Handles btnChooseBckgrnd.Click
        'Load the user-chosen background colour
        bckgrndClr = Notepad.Editing.ChooseColour()
        'Change the setting Background colour to the chosen colour
        My.Settings.BackgroundColour = bckgrndClr
        'Display the preview to the user
        clrBackground.BackColor = bckgrndClr
        txtClrPreview.BackColor = bckgrndClr
    End Sub
    Private Sub btnChooseForeClr_Click(sender As System.Object, e As System.EventArgs) Handles btnChooseForeClr.Click
        'Load the user-chosen text colour
        TextClr = Notepad.Editing.ChooseColour()
        'Change the setting Textcolour to the chosen colour
        My.Settings.TextColour = TextClr
        'Display the preview to the user
        clrText.BackColor = TextClr
        txtClrPreview.ForeColor = TextClr
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        'Set the colour of the textbox in editor form to the colours chosen
        EditorForm.txtMain.BackColor = bckgrndClr
        EditorForm.txtMain.ForeColor = TextClr
        'Close the form
        Me.Close()
    End Sub
    Private Sub btnDefault_Click(sender As System.Object, e As System.EventArgs) Handles btnDefault.Click
        'Load the default colours
        bckgrndClr = Color.White
        TextClr = Color.Black
        'Change the setting Background colour to the default colour
        My.Settings.BackgroundColour = bckgrndClr
        My.Settings.TextColour = TextClr
        'Display the preview to the user
        clrBackground.BackColor = bckgrndClr
        clrText.BackColor = TextClr
        txtClrPreview.BackColor = bckgrndClr
        txtClrPreview.ForeColor = TextClr
        'Set the colour of the textbox in editor form to the colours chosen
        EditorForm.txtMain.BackColor = bckgrndClr
        EditorForm.txtMain.ForeColor = TextClr
        'Close the form
        Me.Close()
    End Sub
    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        'Close the form
        Me.Close()
    End Sub


End Class