Imports System.io
Public Class GUI_last_result
    Sub GUI_set(ByVal new_lang As String)
        language_settings.read_language(new_lang)
        Me.RightToLeft = language_settings.language_RTL
        Me.RightToLeftLayout = language_settings.language_RTL_layout
        RadioButton_default_english.Text = language_settings.results_panel3_RadioButton_default_english
        RadioButton_other_language.Text = language_settings.results_panel3_RadioButton_other_language
        GroupBox_choose_language.Text = language_settings.results_panel3_GroupBox_choose_language
        Button_update.Text = language_settings.results_panel3_Button_update
        button_results_save.Text = language_settings.results_panel3_button_results_save
        Button_update.RightToLeft = language_settings.language_RTL
        RadioButton_default_english.RightToLeft = language_settings.language_RTL
        RadioButton_other_language.RightToLeft = language_settings.language_RTL
        GroupBox_choose_language.RightToLeft = language_settings.language_RTL
        button_results_save.RightToLeft = language_settings.language_RTL
        If RadioButton_default_english.Checked = True Then
            button_results_save.RightToLeft = Windows.Forms.RightToLeft.No
        Else
            button_results_save.RightToLeft = language_settings.language_RTL
        End If
        ' ORTHOTROPIC PLATE MODEL
        If Me.Tag = "orthotropic plate model" Then
            Me.Text = language_settings.last_orthotropic_text
            TSSLabel_count.Text = language_settings.model_count & " " & general_settings.general_variables.orthotropic_count_results
            ' GRILLAGE  MODEL
        ElseIf Me.Tag = "grillage model" Then
            Me.Text = language_settings.last_grillage_text
            TSSLabel_count.Text = language_settings.model_count & " " & general_settings.general_variables.Grillage_count_results
        Else
            ' TO BE COMPLETE LATER
        End If
    End Sub
    Private Sub Button_clear(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_update.Click
        RichTextBox_last_result.Clear()
        If RadioButton_default_english.Checked = True Then
            text_feed_default_english()
        ElseIf RadioButton_other_language.Checked = True Then
            text_feed_current_language()
        End If
    End Sub
    Private Sub Button_results_save_text(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_results_save.Click
        ' Create a SaveFileDialog to request a path and file name to save to.
        Dim saveFile1 As New SaveFileDialog

        ' Initialize the SaveFileDialog to specify the TXT extension for the file.
        saveFile1.DefaultExt = "*.txt"
        saveFile1.Filter = "Text Files|*.txt"

        ' Determine if the user selected a file name from the saveFileDialog.
        If (saveFile1.ShowDialog() = System.Windows.Forms.DialogResult.OK) _
            And (saveFile1.FileName.Length) > 0 Then

            ' Save the contents of the RichTextBox into the file.
            RichTextBox_last_result.SaveFile(saveFile1.FileName, _
                RichTextBoxStreamType.PlainText)
        End If
    End Sub
    Private Sub text_feed_current_language()
        If Me.Tag = "orthotropic plate model" Then
            Dim text_results As String = ""
            text_results = My.Application.Info.Title & " " & DateTime.Now.ToString + Chr(13) + "====================================================================================" + Chr(13) + _
            language_settings.results_panel3_results_text00_ortho + vbCr + language_settings.results_panel3_results_text01 + Chr(13) + Chr(13) + language_settings.results_panel3_results_text02
            If models_calculations.Orthotropic_model.model_variables.geo_type = 1 Then
                text_results += language_settings.results_panel3_results_text03
            ElseIf models_calculations.Orthotropic_model.model_variables.geo_type = 2 Then
                text_results += language_settings.results_panel3_results_text04
            ElseIf models_calculations.Orthotropic_model.model_variables.geo_type = 3 Then
                text_results += language_settings.results_panel3_results_text05
            ElseIf models_calculations.Orthotropic_model.model_variables.geo_type = 4 Then
                text_results += language_settings.results_panel3_results_text06
            Else
                text_results += language_settings.last_orthotropic_results_text01 + vbCr + language_settings.last_orthotropic_results_text02
            End If
            text_results += Chr(13) + Chr(13) + language_settings.results_panel3_results_text07 + Chr(13) + _
            vbTab + language_settings.results_panel3_results_text08 + " " + CStr(models_calculations.Orthotropic_model.model_variables.a) + " " + language_settings.unit_meter + Chr(13) + _
            vbTab + language_settings.results_panel3_results_text09 + " " + CStr(models_calculations.Orthotropic_model.model_variables.b) + " " + language_settings.unit_meter + Chr(13) + _
            vbTab + language_settings.results_panel3_results_text10 + " " + CStr(models_calculations.Orthotropic_model.model_variables.t * 1000) + " " + language_settings.unit_millimeter + Chr(13) + _
            Chr(13) + language_settings.results_panel3_results_text11 + " " + Chr(13) + _
            vbTab + language_settings.results_panel3_results_text12 + " " + CStr(models_calculations.Orthotropic_model.model_variables.P) + " " + language_settings.unit_Pa + Chr(13) + _
            vbTab + language_settings.results_panel3_results_text13 + " " + CStr(models_calculations.Orthotropic_model.model_variables.E / 10 ^ 9) + " " + language_settings.unit_GPa + Chr(13) + _
            vbTab + language_settings.results_panel3_results_text14 + " " + CStr(models_calculations.Orthotropic_model.model_variables.ni) + Chr(13)
            If models_calculations.Orthotropic_model.model_variables.C = 1 Then
                text_results += vbTab + language_settings.results_panel3_results_text15 + Chr(13)
            ElseIf models_calculations.Orthotropic_model.model_variables.C = 2 Then
                text_results += vbTab + language_settings.results_panel3_results_text16 + Chr(13)
            ElseIf models_calculations.Orthotropic_model.model_variables.C = 3 Then
                text_results += vbTab + language_settings.results_panel3_results_text17 + Chr(13)
            ElseIf models_calculations.Orthotropic_model.model_variables.C = 4 Then
                text_results += vbTab + language_settings.results_panel3_results_text18 + Chr(13)
            End If
            text_results += Chr(13) + language_settings.results_panel3_results_text19 + Chr(13) + _
            vbTab + language_settings.results_panel3_results_text20 + " " + CStr(models_calculations.Orthotropic_model.model_variables.Na) + Chr(13) + _
            vbTab + language_settings.results_panel3_results_text21 + " " + CStr(models_calculations.Orthotropic_model.model_variables.Nb) + Chr(13) + Chr(13) + _
            language_settings.results_panel3_results_text22 + Chr(13) + _
            vbTab & language_settings.results_panel3_results_text23 & vbCr & _
            vbTab & vbTab & language_settings.results_panel3_results_text24 & vbCr & _
            vbTab & vbTab & vbTab & language_settings.results_panel3_results_text25 + " " & CStr(models_calculations.Orthotropic_model.model_variables.Ia_stiffener) & language_settings.unit_meter4 & vbCr & _
            vbTab & vbTab & vbTab & language_settings.results_panel3_results_text26 & CStr(models_calculations.Orthotropic_model.model_variables.Aa_stiffener) & language_settings.unit_meter2 & vbCr & _
            vbTab & vbTab & vbTab & language_settings.results_panel3_results_text27 + CStr(models_calculations.Orthotropic_model.model_variables.Ya_stiffener) & language_settings.unit_meter & vbCr & vbCr & _
            vbTab & vbTab & language_settings.results_panel3_results_text28 & Chr(13) & _
            vbTab & vbTab & vbTab & language_settings.results_panel3_results_text25 & CStr(models_calculations.Orthotropic_model.model_variables.Ina_stiffeners) & language_settings.unit_meter4 & vbCr & _
            vbTab & vbTab & vbTab & language_settings.results_panel3_results_text26 & CStr(models_calculations.Orthotropic_model.model_variables.Ana_stiffeners) & language_settings.unit_meter2 & vbCr & _
            vbTab & vbTab & vbTab & language_settings.results_panel3_results_text27 + CStr(models_calculations.Orthotropic_model.model_variables.Yna_stiffeners) & language_settings.unit_meter & vbCr & vbCr & _
            vbTab & language_settings.results_panel3_results_text29 + Chr(13) + _
            vbTab & vbTab & language_settings.results_panel3_results_text24 & vbCr & _
            vbTab & vbTab & vbTab & language_settings.results_panel3_results_text25 & CStr(models_calculations.Orthotropic_model.model_variables.Ib_stiffener) & language_settings.unit_meter4 & vbCr & _
            vbTab & vbTab & vbTab & language_settings.results_panel3_results_text26 & CStr(models_calculations.Orthotropic_model.model_variables.Ab_stiffener) & language_settings.unit_meter2 & vbCr & _
            vbTab & vbTab & vbTab & language_settings.results_panel3_results_text27 + CStr(models_calculations.Orthotropic_model.model_variables.Yb_stiffener) & language_settings.unit_meter & vbCr & vbCr & _
            vbTab & vbTab & language_settings.results_panel3_results_text28 & Chr(13) & _
            vbTab & vbTab & vbTab & language_settings.results_panel3_results_text25 & CStr(models_calculations.Orthotropic_model.model_variables.Inb_stiffeners) & language_settings.unit_meter4 & vbCr & _
            vbTab & vbTab & vbTab & language_settings.results_panel3_results_text26 & CStr(models_calculations.Orthotropic_model.model_variables.Anb_stiffeners) & language_settings.unit_meter2 & vbCr & _
            vbTab & vbTab & vbTab & language_settings.results_panel3_results_text27 + CStr(models_calculations.Orthotropic_model.model_variables.Ynb_stiffeners) & language_settings.unit_meter & vbCr & vbCr & _
            "====================================================================================" + Chr(13) + language_settings.results_panel3_results_text30 + Chr(13) + _
            language_settings.results_panel3_results_text31 + " " + CStr(models_calculations.Orthotropic_model.model_variables.Sa) + " " + language_settings.unit_meter + Chr(13) + _
            language_settings.results_panel3_results_text32 + " " + CStr(models_calculations.Orthotropic_model.model_variables.Sb) + " " + language_settings.unit_meter + Chr(13) + _
            language_settings.results_panel3_results_text33 + " " + CStr(models_calculations.Orthotropic_model.model_variables.lamda_a) + " " + language_settings.unit_meter + Chr(13) + _
            language_settings.results_panel3_results_text34 + " " + CStr(models_calculations.Orthotropic_model.model_variables.lamda_b) + " " + language_settings.unit_meter + Chr(13) + _
            language_settings.results_panel3_results_text35 + " " + CStr(models_calculations.Orthotropic_model.model_variables.Ipa) + " " + language_settings.unit_meter4 + Chr(13) + _
            language_settings.results_panel3_results_text36 + " " + CStr(models_calculations.Orthotropic_model.model_variables.Ipb) + " " + language_settings.unit_meter4 + Chr(13) + _
            language_settings.results_panel3_results_text37 + " " + CStr(models_calculations.Orthotropic_model.model_variables.Ina) + " " + language_settings.unit_meter4 + Chr(13) + _
            language_settings.results_panel3_results_text38 + " " + CStr(models_calculations.Orthotropic_model.model_variables.Inb) + " " + language_settings.unit_meter4 + Chr(13) + _
            language_settings.results_panel3_results_text39 + " " + CStr(models_calculations.Orthotropic_model.model_variables.Ia) + " " + language_settings.unit_meter4 + Chr(13) + _
            language_settings.results_panel3_results_text40 + " " + CStr(models_calculations.Orthotropic_model.model_variables.Ib) + " " + language_settings.unit_meter4 + Chr(13) + _
            language_settings.results_panel3_results_text41 + " " + CStr(models_calculations.Orthotropic_model.model_variables.Ia_small) + " " + language_settings.unit_meter4 + Chr(13) + _
            language_settings.results_panel3_results_text42 + " " + CStr(models_calculations.Orthotropic_model.model_variables.Ib_small) + " " + language_settings.unit_meter4 + Chr(13) + _
            language_settings.results_panel3_results_text43 + " " + CStr(models_calculations.Orthotropic_model.model_variables.ro) + " " + language_settings.results_panel3_results_text47 + Chr(13) + _
            language_settings.results_panel3_results_text44 + " " + CStr(models_calculations.Orthotropic_model.model_variables.eta) + " " + language_settings.results_panel3_results_text47 + Chr(13) + _
            language_settings.results_panel3_results_text45 + " " + CStr(models_calculations.Orthotropic_model.model_variables.K) + " " + language_settings.results_panel3_results_text47 + Chr(13) + _
            language_settings.results_panel3_results_text46 + " " + CStr(Math.Round(models_calculations.Orthotropic_model.model_variables.Result * 1000, 2)) + " " + language_settings.unit_millimeter + Chr(13)
            RichTextBox_last_result.RightToLeft = language_settings.language_RTL
            RichTextBox_last_result.Text += text_results
        ElseIf Me.Tag = "grillage model" Then
            Dim text_results As String = ""
            text_results = My.Application.Info.Title & " " & DateTime.Now.ToString + Chr(13) + "====================================================================================" + Chr(13) + _
             language_settings.results_panel3_results_text00_grillage & vbCr & _
            language_settings.results_panel3_results_text01 & Chr(13) + Chr(13) + language_settings.results_panel3_results_text07 + Chr(13) + _
            vbTab + language_settings.results_panel3_results_text08 + CStr(models_calculations.Grillage_model.model_variables.a) + language_settings.unit_meter + Chr(13) + _
            vbTab + language_settings.results_panel3_results_text09 + CStr(models_calculations.Grillage_model.model_variables.b) + language_settings.unit_meter + Chr(13) + _
            vbTab + language_settings.results_panel3_results_text10 + CStr(models_calculations.Grillage_model.model_variables.t * 1000) + language_settings.unit_millimeter + Chr(13) + _
            Chr(13) + language_settings.results_panel3_results_text11 + Chr(13) + _
            vbTab + language_settings.results_panel3_results_text12 + CStr(models_calculations.Grillage_model.model_variables.P) + language_settings.unit_Pa + Chr(13) + _
            vbTab + language_settings.results_panel3_results_text13 + CStr(models_calculations.Grillage_model.model_variables.E / 10 ^ 9) + language_settings.unit_GPa + Chr(13) + _
            vbTab + language_settings.results_panel3_results_text14 + CStr(models_calculations.Grillage_model.model_variables.ni) + Chr(13)
            If models_calculations.Grillage_model.model_variables.BC = 1 Then
                text_results += vbTab + language_settings.results_panel3_results_text15 + Chr(13)
            ElseIf models_calculations.Grillage_model.model_variables.BC = 2 Then
                text_results += vbTab + language_settings.results_panel3_results_text16 + Chr(13)
            ElseIf models_calculations.Grillage_model.model_variables.BC = 3 Then
                text_results += vbTab + language_settings.results_panel3_results_text17 + Chr(13)
            ElseIf models_calculations.Grillage_model.model_variables.BC = 4 Then
                text_results += vbTab + language_settings.results_panel3_results_text18 + Chr(13)
            End If
            '*******STIFFENERS *****
            text_results += Chr(13) + language_settings.results_panel3_results_text19 + Chr(13) + _
            vbTab + language_settings.last_grillage_text01 + CStr(models_calculations.Grillage_model.model_variables.s) + Chr(13) + _
            vbTab + language_settings.last_grillage_text02 + CStr(models_calculations.Grillage_model.model_variables.r) + Chr(13) + Chr(13) + _
            language_settings.results_panel3_results_text22 & vbCr & _
            vbTab & language_settings.results_panel3_results_text23 & vbCr & _
            vbTab & vbTab & language_settings.results_panel3_results_text25 & CStr(models_calculations.Grillage_model.model_variables.Is_stiffeners) & language_settings.unit_meter4 & vbCr & _
            vbTab & vbTab & language_settings.results_panel3_results_text26 & CStr(models_calculations.Grillage_model.model_variables.As_stiffeners) & language_settings.unit_meter2 & vbCr & _
            vbTab & vbTab & language_settings.results_panel3_results_text27 + CStr(models_calculations.Grillage_model.model_variables.Ys_stiffeners) & language_settings.unit_meter & vbCr & vbCr & _
            vbTab & language_settings.results_panel3_results_text29 + Chr(13) + _
            vbTab & vbTab & language_settings.results_panel3_results_text25 & CStr(models_calculations.Grillage_model.model_variables.Ir_stiffeners) & language_settings.unit_meter4 & vbCr & _
            vbTab & vbTab & language_settings.results_panel3_results_text26 & CStr(models_calculations.Grillage_model.model_variables.Ar_stiffeners) & language_settings.unit_meter2 & vbCr & _
            vbTab & vbTab & language_settings.results_panel3_results_text27 + CStr(models_calculations.Grillage_model.model_variables.Yr_stiffeners) & language_settings.unit_meter & vbCr & vbCr & _
            "====================================================================================" + Chr(13) + _
            language_settings.last_grillage_text03 + Chr(13) + _
            language_settings.last_grillage_text04 + CStr(models_calculations.Grillage_model.model_variables.c) + language_settings.unit_meter + Chr(13) + _
            language_settings.last_grillage_text05 + CStr(models_calculations.Grillage_model.model_variables.d) + language_settings.unit_meter + Chr(13) + _
            language_settings.last_grillage_text06 + CStr(models_calculations.Grillage_model.model_variables.lamda) + language_settings.unit_meter + Chr(13) + _
            language_settings.last_grillage_text07 + CStr(models_calculations.Grillage_model.model_variables.mu) + language_settings.unit_meter + Chr(13) + _
            language_settings.last_grillage_text08 + CStr(models_calculations.Grillage_model.model_variables.I_r) + language_settings.unit_meter4 + Chr(13) + _
            language_settings.last_grillage_text09 + CStr(models_calculations.Grillage_model.model_variables.I_s) + language_settings.unit_meter4 + Chr(13) + _
            language_settings.last_grillage_text10 + CStr(models_calculations.Grillage_model.model_variables.Chart_value) + "" + Chr(13) + _
            language_settings.results_panel3_results_text46 + CStr(Math.Round(models_calculations.Grillage_model.model_variables.Result * 1000, 2)) + language_settings.unit_millimeter + Chr(13)
            RichTextBox_last_result.RightToLeft = language_settings.language_RTL
            RichTextBox_last_result.Text += text_results
        End If
    End Sub
    Private Sub text_feed_default_english()
        If Me.Tag = "orthotropic plate model" Then
            Dim text_results As String = ""
            text_results = My.Application.Info.Title & " " & DateTime.Now.ToString + Chr(13) + "====================================================================================" + Chr(13) + "*********** RESULTS OBTAINED USING THE ORTHOTROPIC PLATE MODEL ****************" + vbCr + _
            "Input data:" + Chr(13) + Chr(13) + "Geometric configuration: "
            If models_calculations.Orthotropic_model.model_variables.geo_type = 1 Then
                text_results += "Plate without stiffeners"
            ElseIf models_calculations.Orthotropic_model.model_variables.geo_type = 2 Then
                text_results += "Plate with transverse stiffeners only"
            ElseIf models_calculations.Orthotropic_model.model_variables.geo_type = 3 Then
                text_results += "Plate with transverse stiffeners and central longitudinal stiffener"
            ElseIf models_calculations.Orthotropic_model.model_variables.geo_type = 4 Then
                text_results += "Plate with longitudinal and transverse stiffeners"
            Else
                text_results += "No geometric configuration could be detected." + Chr(13) + "Either the model hasn't been used yet or the model parameters have been re-initialized/cleared."
            End If
            text_results += Chr(13) + Chr(13) + "Plate data:" + Chr(13) + _
            vbTab + "Length (a): " + CStr(models_calculations.Orthotropic_model.model_variables.a) + " [m]" + Chr(13) + _
            vbTab + "Width (b): " + CStr(models_calculations.Orthotropic_model.model_variables.b) + " [m]" + Chr(13) + _
            vbTab + "Thickness (t): " + CStr(models_calculations.Orthotropic_model.model_variables.t * 1000) + " [mm]" + Chr(13) + _
            Chr(13) + "Boundary conditions, Load and Material properties: " + Chr(13) + _
            vbTab + "Uniform pressure: " + CStr(models_calculations.Orthotropic_model.model_variables.P) + " [Pa]" + Chr(13) + _
            vbTab + "Young's modulus: " + CStr(models_calculations.Orthotropic_model.model_variables.E / 10 ^ 9) + " [GPa]" + Chr(13) + _
            vbTab + "Poisson’s ratio: " + CStr(models_calculations.Orthotropic_model.model_variables.ni) + Chr(13)
            If models_calculations.Orthotropic_model.model_variables.C = 1 Then
                text_results += vbTab + "Boundary conditions: All edges are Simply Supported" + Chr(13)
            ElseIf models_calculations.Orthotropic_model.model_variables.C = 2 Then
                text_results += vbTab + "Boundary conditions: Both short edges are fixed and both long edges are simply supported." + Chr(13)
            ElseIf models_calculations.Orthotropic_model.model_variables.C = 3 Then
                text_results += vbTab + "Boundary conditions: Both long edges are fixed and both short edges are simply supported." + Chr(13)
            ElseIf models_calculations.Orthotropic_model.model_variables.C = 4 Then
                text_results += vbTab + "Boundary conditions: All four edges are fixed/clamped (All six degrees of freedom are fixed at the edges)." + Chr(13)
            End If

            '*******STIFFENERS *****
            text_results += Chr(13) + "Stiffeners:" + Chr(13) + _
            vbTab + "Number of longitudinal stiffeners (Na): " + CStr(models_calculations.Orthotropic_model.model_variables.Na) + Chr(13) + _
            vbTab + "Number of transverse stiffeners (Nb): " + CStr(models_calculations.Orthotropic_model.model_variables.Nb) + Chr(13) + Chr(13) + _
            "Stiffeners' properties:" & vbCr & _
            vbTab & "longitudinal stiffeners" & vbCr & _
            vbTab & vbTab & "Central stiffener:" & vbCr & _
            vbTab & vbTab & vbTab & "Moment of inertia: " & CStr(models_calculations.Orthotropic_model.model_variables.Ia_stiffener) & " [" & "m^4" & "]" & vbCr & _
            vbTab & vbTab & vbTab & "Area of cross section: " & CStr(models_calculations.Orthotropic_model.model_variables.Aa_stiffener) & " [" & "m²" & "]" & vbCr & _
            vbTab & vbTab & vbTab & "Centroid of cross section: " + CStr(models_calculations.Orthotropic_model.model_variables.Ya_stiffener) & " [" & "m" & "]" & vbCr & vbCr & _
            vbTab & vbTab & "Non-Central stiffeners:" & Chr(13) & _
            vbTab & vbTab & vbTab & "Moment of inertia: " & CStr(models_calculations.Orthotropic_model.model_variables.Ina_stiffeners) & " [" & "m^4" & "]" & vbCr & _
            vbTab & vbTab & vbTab & "Area of cross section: " & CStr(models_calculations.Orthotropic_model.model_variables.Ana_stiffeners) & " [" & "m²" & "]" & vbCr & _
            vbTab & vbTab & vbTab & "Centroid of cross section: " + CStr(models_calculations.Orthotropic_model.model_variables.Yna_stiffeners) & " [" & "m" & "]" & vbCr & vbCr & _
            vbTab & "Transverse stiffeners" + Chr(13) + _
            vbTab & vbTab & "Central stiffener:" + Chr(13) + _
            vbTab & vbTab & vbTab & "Moment of inertia: " & CStr(models_calculations.Orthotropic_model.model_variables.Ib_stiffener) & " [" & "m^4" & "]" & vbCr & _
            vbTab & vbTab & vbTab & "Area of cross section: " & CStr(models_calculations.Orthotropic_model.model_variables.Ab_stiffener) & " [" & "m²" & "]" & vbCr & _
            vbTab & vbTab & vbTab & "Centroid of cross section: " + CStr(models_calculations.Orthotropic_model.model_variables.Yb_stiffener) & " [" & "m" & "]" & vbCr & vbCr & _
            vbTab & vbTab & "Non-Central stiffeners:" & Chr(13) & _
            vbTab & vbTab & vbTab & "Moment of inertia: " & CStr(models_calculations.Orthotropic_model.model_variables.Inb_stiffeners) & " [" & "m^4" & "]" & vbCr & _
            vbTab & vbTab & vbTab & "Area of cross section: " & CStr(models_calculations.Orthotropic_model.model_variables.Anb_stiffeners) & " [" & "m²" & "]" & vbCr & _
            vbTab & vbTab & vbTab & "Centroid of cross section: " + CStr(models_calculations.Orthotropic_model.model_variables.Ynb_stiffeners) & " [" & "m" & "]" & vbCr & vbCr & _
            "====================================================================================" + Chr(13) + _
            "Orthotropic Model's Intermediates Calculations:" + Chr(13) + _
            "Sa: " + CStr(models_calculations.Orthotropic_model.model_variables.Sa) + " [m]" + Chr(13) + _
            "Sb: " + CStr(models_calculations.Orthotropic_model.model_variables.Sb) + " [m]" + Chr(13) + _
            "Lambda (a): " + CStr(models_calculations.Orthotropic_model.model_variables.lamda_a) + " [m]" + Chr(13) + _
            "Lambda (b): " + CStr(models_calculations.Orthotropic_model.model_variables.lamda_b) + " [m]" + Chr(13) + _
            "moment of inertia of plate only (longer edge - Ipa): " + CStr(models_calculations.Orthotropic_model.model_variables.Ipa) + " [m^4]" + Chr(13) + _
            "moment of inertia of plate only (shorter edge - Ipb): " + CStr(models_calculations.Orthotropic_model.model_variables.Ipb) + " [m^4]" + Chr(13) + _
            "moment of inertia of section (non-central longitudinal stiffeners - Ina): " + CStr(models_calculations.Orthotropic_model.model_variables.Ina) + " [m^4]" + Chr(13) + _
            "moment of inertia of section (non-central transverse stiffeners - Inb): " + CStr(models_calculations.Orthotropic_model.model_variables.Inb) + " [m^4]" + Chr(13) + _
            "moment of inertia of section (central longitudinal stiffener - Ia): " + CStr(models_calculations.Orthotropic_model.model_variables.Ia) + " [m^4]" + Chr(13) + _
            "moment of inertia of section (central transverse stiffener - Ib): " + CStr(models_calculations.Orthotropic_model.model_variables.Ib) + " [m^4]" + Chr(13) + _
            "moment of inertia (estimated stiffening of longer edge of plate - ia): " + CStr(models_calculations.Orthotropic_model.model_variables.Ia_small) + " [m^4]" + Chr(13) + _
            "moment of inertia (estimated stiffening of shorter edge of plate - ib): " + CStr(models_calculations.Orthotropic_model.model_variables.Ib_small) + " [m^4]" + Chr(13) + _
            "Ro: " + CStr(models_calculations.Orthotropic_model.model_variables.ro) + " [-]" + Chr(13) + _
            "Eta: " + CStr(models_calculations.Orthotropic_model.model_variables.eta) + " [-]" + Chr(13) + _
            "K value (linear estimation used): " + CStr(models_calculations.Orthotropic_model.model_variables.K) + " [-]" + Chr(13) + _
            "Maximum deflection: " + CStr(Math.Round(models_calculations.Orthotropic_model.model_variables.Result * 1000, 2)) + " [mm]" + Chr(13)
            RichTextBox_last_result.RightToLeft = Windows.Forms.RightToLeft.No
            RichTextBox_last_result.Text += text_results
        ElseIf Me.Tag = "grillage model" Then
            Dim text_results As String = ""
            text_results = My.Application.Info.Title & " " & DateTime.Now.ToString + Chr(13) + "====================================================================================" + Chr(13) + "*********** RESULTS OBTAINED USING THE GRILLAGE MODEL  **************************" & vbCr & _
            "Input data:" & Chr(13) + Chr(13) + "Plate data:" + Chr(13) + _
            vbTab + "Length (a): " + CStr(models_calculations.Grillage_model.model_variables.a) + " [m]" + Chr(13) + _
            vbTab + "Width (b): " + CStr(models_calculations.Grillage_model.model_variables.b) + " [m]" + Chr(13) + _
            vbTab + "Thickness (t): " + CStr(models_calculations.Grillage_model.model_variables.t * 1000) + " [mm]" + Chr(13) + _
            Chr(13) + "Boundary conditions, Load and Material properties: " + Chr(13) + _
            vbTab + "Uniform pressure: " + CStr(models_calculations.Grillage_model.model_variables.P) + " [Pa]" + Chr(13) + _
            vbTab + "Young's modulus: " + CStr(models_calculations.Grillage_model.model_variables.E / 10 ^ 9) + " [GPa]" + Chr(13) + _
            vbTab + "Poisson’s ratio: " + CStr(models_calculations.Grillage_model.model_variables.ni) + Chr(13)
            If models_calculations.Grillage_model.model_variables.BC = 1 Then
                text_results += vbTab + "Boundary conditions: All edges are Simply Supported" + Chr(13)
            ElseIf models_calculations.Grillage_model.model_variables.BC = 2 Then
                text_results += vbTab + "Boundary conditions: Both short edges are fixed and both long edges are simply supported." + Chr(13)
            ElseIf models_calculations.Grillage_model.model_variables.BC = 3 Then
                text_results += vbTab + "Boundary conditions: Both long edges are fixed and both short edges are simply supported." + Chr(13)
            ElseIf models_calculations.Grillage_model.model_variables.BC = 4 Then
                text_results += vbTab + "Boundary conditions: All four edges are fixed/clamped (All six degrees of freedom are fixed at the edges)." + Chr(13)
            End If
            '*******STIFFENERS *****
            text_results += Chr(13) + "Stiffeners:" + Chr(13) + _
            vbTab + "Number of longitudinal stiffeners (s beams): " + CStr(models_calculations.Grillage_model.model_variables.s) + Chr(13) + _
            vbTab + "Number of transverse stiffeners (r beams): " + CStr(models_calculations.Grillage_model.model_variables.r) + Chr(13) + Chr(13) + _
            "Stiffeners' properties:" & vbCr & _
            vbTab & "longitudinal stiffeners" & vbCr & _
            vbTab & vbTab & "Moment of inertia: " & CStr(models_calculations.Grillage_model.model_variables.Is_stiffeners) & " [" & "m^4" & "]" & vbCr & _
            vbTab & vbTab & "Area of cross section: " & CStr(models_calculations.Grillage_model.model_variables.As_stiffeners) & " [" & "m²" & "]" & vbCr & _
            vbTab & vbTab & "Centroid of cross section: " + CStr(models_calculations.Grillage_model.model_variables.Ys_stiffeners) & " [" & "m" & "]" & vbCr & vbCr & _
            vbTab & "Transverse stiffeners" + Chr(13) + _
            vbTab & vbTab & "Moment of inertia: " & CStr(models_calculations.Grillage_model.model_variables.Ir_stiffeners) & " [" & "m^4" & "]" & vbCr & _
            vbTab & vbTab & "Area of cross section: " & CStr(models_calculations.Grillage_model.model_variables.Ar_stiffeners) & " [" & "m²" & "]" & vbCr & _
            vbTab & vbTab & "Centroid of cross section: " + CStr(models_calculations.Grillage_model.model_variables.Yr_stiffeners) & " [" & "m" & "]" & vbCr & vbCr & _
            "====================================================================================" + Chr(13) + _
            "Grillage Model's Intermediates Calculations:" + Chr(13) + _
            "c (spacing of s beams): " + CStr(models_calculations.Grillage_model.model_variables.c) + " [m]" + Chr(13) + _
            "d (spacing of r beams): " + CStr(models_calculations.Grillage_model.model_variables.d) + " [m]" + Chr(13) + _
            "Lambda: " + CStr(models_calculations.Grillage_model.model_variables.lamda) + " [m]" + Chr(13) + _
            "Mu: " + CStr(models_calculations.Grillage_model.model_variables.mu) + " [m]" + Chr(13) + _
            "moment of inertia of section (r beams - Ir): " + CStr(models_calculations.Grillage_model.model_variables.I_s) + " [m^4]" + Chr(13) + _
            "moment of inertia of section (r beams - Is): " + CStr(models_calculations.Grillage_model.model_variables.I_s) + " [m^4]" + Chr(13) + _
            "Chart's value: " + CStr(models_calculations.Grillage_model.model_variables.Chart_value) + "" + Chr(13) + _
            "Maximum deflection: " + CStr(Math.Round(models_calculations.Grillage_model.model_variables.Result * 1000, 2)) + " [mm]" + Chr(13)
            RichTextBox_last_result.RightToLeft = Windows.Forms.RightToLeft.No
            RichTextBox_last_result.Text += text_results
        End If
    End Sub
    Private Sub Picture_heb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Picture_heb.Click
        GUI_set("default_heb.ini")
        language_settings.language_current_file = "default_heb.ini"
            general_settings.controls_Library.luncher_form.Activate()
        Me.Focus()
    End Sub
    Private Sub Picture_eng_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Picture_eng.Click
        If File.Exists("default_eng.ini") = True Then
            GUI_set("default_eng.ini")
            language_settings.language_current_file = "default_eng.ini"
            general_settings.controls_Library.luncher_form.Activate()
            Me.Focus()
        Else
            'message to follow
        End If
    End Sub

    Public Sub GUI_last_result_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GUI_set(language_settings.language_current_file)
        RichTextBox_last_result.Clear()
        If RadioButton_default_english.Checked = True Then
            text_feed_default_english()
        ElseIf RadioButton_other_language.Checked = True Then
            text_feed_current_language()
        End If
    End Sub
End Class