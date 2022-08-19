Public Class GUI_first_run
    Private Sub Button_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_next.Click
        If CheckBox_accept.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Stiffened Plates Evaluator", "First run", False)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Stiffened Plates Evaluator", "Current model", "orthotropic plate model")
            Dim GUI_languages_selection As New GUI_languages_selection
            GUI_languages_selection.Show()
            Me.Close()
        Else
            Dim msg_style As MsgBoxStyle = MsgBoxStyle.Critical + MsgBoxStyle.OkOnly
            Dim msg_title As String = "Unable to continue"
            Dim msg_text As String = "In order to proceed you need to accept the DISCLAIMER OF WARRANTIES and LIMIT OF LIABILITY"
            MsgBox(msg_text, msg_style, msg_title)
        End If
    End Sub
End Class