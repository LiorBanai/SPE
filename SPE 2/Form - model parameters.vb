Public Class GUI_model_parameters
    Private Sub GUI_set(ByVal new_lang As String)
        ComboBox_current_model.Items.Clear()
        ComboBox_current_model.Items.Insert(0, language_settings.model_orthotropic)
        ComboBox_current_model.Items.Insert(1, language_settings.model_grillage)
        ComboBox_current_model.RightToLeft = language_settings.language_RTL
        GroupBox_model.RightToLeft = language_settings.language_RTL
        Label_long.Text = language_settings.breadth_b.Substring(language_settings.breadth_b.Length - 1)
        Label_short.Text = language_settings.length_a.Substring(language_settings.length_a.Length - 1)
        Label_model.Text = language_settings.models_parameters_model
        Me.Text = language_settings.models_parameters_title & " (" & Me.Tag & ")"
        If Me.Tag = "grillage model" Then
            Me.Text = language_settings.models_parameters_title & " (" & language_settings.model_grillage & ")"
            GroupBox_model.Text = language_settings.model_grillage
            RTB_comments.Text = language_settings.parameters_grillage_line01 & vbCr & _
                                language_settings.parameters_grillage_line02 & vbCr & _
                                language_settings.parameters_grillage_line03 & vbCr & _
                                language_settings.parameters_grillage_line04 & vbCr & _
                                language_settings.parameters_grillage_line05 & vbCr & _
                                language_settings.parameters_grillage_line06 & vbCr & _
                                language_settings.parameters_grillage_line07 & vbCr & _
                                language_settings.parameters_grillage_line08 & vbCr & _
                                language_settings.parameters_grillage_line09 & vbCr & _
                                language_settings.parameters_grillage_line10 & vbCr & _
                                language_settings.parameters_grillage_line11 & vbCr & _
                                language_settings.parameters_grillage_line12 & vbCr & _
                                language_settings.parameters_grillage_line13 & vbCr & _
                                language_settings.parameters_grillage_line14 & vbCr & _
                                language_settings.parameters_grillage_line15 & vbCr & _
                                language_settings.parameters_grillage_line16 & vbCr & _
                                language_settings.parameters_grillage_line17 & vbCr & _
                                language_settings.parameters_grillage_line18 & vbCr & _
                                language_settings.parameters_grillage_line19 & vbCr & _
                                language_settings.parameters_grillage_line20
        ElseIf Me.Tag = "orthotropic plate model" Then
            Me.Text = language_settings.models_parameters_title & " (" & language_settings.model_orthotropic & ")"
            GroupBox_model.Text = language_settings.model_orthotropic
            RTB_comments.Text = language_settings.parameters_ortho_line01 & vbCr & _
                                language_settings.parameters_ortho_line02 & vbCr & _
                                language_settings.parameters_ortho_line03 & vbCr & _
                                language_settings.parameters_ortho_line04 & vbCr & _
                                language_settings.parameters_ortho_line05 & vbCr & _
                                language_settings.parameters_ortho_line06 & vbCr & _
                                language_settings.parameters_ortho_line07 & vbCr & _
                                language_settings.parameters_ortho_line08 & vbCr & _
                                language_settings.parameters_ortho_line09 & vbCr & _
                                language_settings.parameters_ortho_line10 & vbCr & _
                                language_settings.parameters_ortho_line11 & vbCr & _
                                language_settings.parameters_ortho_line12 & vbCr & _
                                language_settings.parameters_ortho_line13 & vbCr & _
                                language_settings.parameters_ortho_line14 & vbCr & _
                                language_settings.parameters_ortho_line15 & vbCr & _
                                language_settings.parameters_ortho_line16 & vbCr & _
                                language_settings.parameters_ortho_line17 & vbCr & _
                                language_settings.parameters_ortho_line18 & vbCr & _
                                language_settings.parameters_ortho_line19 & vbCr & _
                                language_settings.parameters_ortho_line20
        End If
    End Sub
    Private Sub ComboBox_current_model_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_current_model.SelectedIndexChanged
        If ComboBox_current_model.Text = language_settings.model_orthotropic Then
            Me.Tag = "orthotropic plate model"
            GUI_set(language_settings.language_current_file)
        ElseIf ComboBox_current_model.Text = language_settings.model_grillage Then
            Me.Tag = "grillage model"
            GUI_set(language_settings.language_current_file)
        End If

    End Sub

    Private Sub GUI_model_parameters_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        GUI_set(language_settings.language_current_file)
    End Sub
End Class