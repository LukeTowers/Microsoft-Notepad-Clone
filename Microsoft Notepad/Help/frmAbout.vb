Public Class frmAbout

    Private Sub frmAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblCurrentUser.Text = Notepad.Help.currentUser
    End Sub
    Private Sub lnkLblTerms_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkLblTerms.LinkClicked
        MsgBox("Sorry, haven't written them yet. Basically, don't pass this off as your own, give credit to who it is due, you're allowed to make lots of copies, don't sell THIS version to anyone(You can modify it then sell it if you like, just don't forget to credit the appropiate people) and have fun.")
    End Sub

    Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click
        'close the form
        Me.Close()
    End Sub
End Class
