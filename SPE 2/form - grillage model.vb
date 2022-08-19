Public Class GUI_grillage_model
    '*********** GENERAL PARAMETERS ****************
    Dim DB_form As New GUI_Database 'DATABASE form
    Dim pre_plate_ok As Boolean = False
    Dim pre_stiffeners_ok As Boolean = False
    Dim pre_physical_ok As Boolean = False
    Dim Process_ok As Boolean = False
    Dim current_moment As Single = 0
    Dim current_area As Single = 0
    Dim current_center As Single = 0
    '*********** Grillage MODEL PARAMETERS ****************
    Dim a As Single = 0
    Dim b As Single = 0
    Dim t As Single = 0
    Dim stiffeners_r As Byte = 0 'longitudinal beans
    Dim stiffeners_s As Byte = 0 'transverse beams s>=r
    Dim stiffeners_Ir As Single = 0
    Dim stiffeners_Is As Single = 0
    Dim stiffeners_Ar As Single = 0
    Dim stiffeners_As As Single = 0
    Dim stiffeners_Yr As Single = 0
    Dim stiffeners_Ys As Single = 0


    Dim BC_type As Byte = 0
    Dim geo_type As Byte = 0
    Dim Young_Modulus As Single = 0
    Dim ni As Single = 0
    Dim P As Single = 0
    Private Sub grillage_model_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Combobox_geo_select.Text = Combobox_geo_select.Items(0).ToString
        ComboBox_num_center_units.Text = ComboBox_num_center_units.Items(0).ToString
        ComboBox_num_area_units.Text = ComboBox_num_area_units.Items(0).ToString
        ComboBox_num_moment_units.Text = ComboBox_num_moment_units.Items(0).ToString
        ComboBox_P_units.Text = ComboBox_P_units.Items(0).ToString
        TreeView_steps.ExpandAll()
        GUI_update_locations()
        Panel_right.Visible = True
        Process_ok = True
    End Sub
    Public Shared Function data_ok(ByVal number As String) As Boolean
        If (IsNumeric(number) = True) AndAlso (number > 0) Then
            Return True
        Else
            Return False
        End If
    End Function
    Sub GUI_update_locations()
        Dim pos1 As Integer = 10
        Dim pos2 As Integer = 10
        Dim pos3 As Integer = 10
        Dim pos4 As Integer = 10
        Dim pos5 As Integer = 10
        Dim pos6 As Integer = 10
        Dim pos7 As Integer = 10
        CheckBox1.Visible = True
        If CheckBox1.Checked Then
            pos1 = CheckBox1.Location.Y + CheckBox1.Height + 0
            GroupBox_plate.Location = New Point(GroupBox_plate.Location.X, pos1)
            GroupBox_plate.Visible = True
            pos1 += GroupBox_plate.Height + 20
        Else
            pos1 = CheckBox1.Location.Y + CheckBox1.Height + 20
            GroupBox_plate.Visible = False
        End If
        CheckBox2.Visible = True
        CheckBox2.Location = New Point(CheckBox2.Location.X, pos1)
        If CheckBox2.Checked Then
            pos2 = pos1 + CheckBox2.Height + 0
            GroupBox_stiffeners_whole.Location = New Point(GroupBox_stiffeners_whole.Location.X, pos2)
            GroupBox_stiffeners_whole.Visible = True
            pos2 += GroupBox_stiffeners_whole.Height + 20
        Else
            pos2 = pos1 + CheckBox2.Height + 20
            GroupBox_stiffeners_whole.Visible = False
        End If
        CheckBox3.Visible = True
        CheckBox3.Location = New Point(CheckBox3.Location.X, pos2)
        If CheckBox3.Checked Then
            pos3 = pos2 + CheckBox3.Height + 0
            GroupBox_BC.Location = New Point(GroupBox_BC.Location.X, pos3)
            GroupBox_BC.Visible = True
            pos3 += GroupBox_BC.Height + 20
        Else
            pos3 = pos2 + CheckBox3.Height + 20
            GroupBox_BC.Visible = False
        End If
        CheckBox4.Visible = True
        CheckBox4.Location = New Point(CheckBox4.Location.X, pos3)
        If CheckBox4.Checked Then
            pos4 = pos3 + CheckBox4.Height + 0
            GroupBox_summary.Location = New Point(GroupBox_summary.Location.X, pos4)
            GroupBox_summary.Visible = True
            pos4 += GroupBox_summary.Height + 20
        Else
            pos4 = pos3 + CheckBox4.Height + 20
            GroupBox_summary.Visible = False
        End If
        CheckBox5.Visible = True
        CheckBox5.Location = New Point(CheckBox5.Location.X, pos4)
        If CheckBox5.Checked Then
            pos5 = pos4 + CheckBox5.Height + 0
            GroupBox_results.Location = New Point(GroupBox_results.Location.X, pos5)
            GroupBox_results.Visible = True
            pos5 += GroupBox_results.Height + 20
        Else
            pos5 = pos4 + CheckBox5.Height + 20
            GroupBox_results.Visible = False
        End If
        CheckBox6.Visible = True
        CheckBox6.Location = New Point(CheckBox6.Location.X, pos5)
        If CheckBox6.Checked Then
            pos6 = pos5 + CheckBox6.Height + 0
            GroupBox_export.Location = New Point(GroupBox_export.Location.X, pos6)
            GroupBox_export.Visible = True
            pos6 += GroupBox_export.Height + 20
        Else
            pos6 = pos5 + CheckBox6.Height + 20
            GroupBox_export.Visible = False
        End If
        CheckBox7.Visible = True
        CheckBox7.Location = New Point(CheckBox7.Location.X, pos6)
        If CheckBox7.Checked Then
            pos7 = pos6 + CheckBox7.Height + 0
            GroupBox_ADINA.Location = New Point(GroupBox_ADINA.Location.X, pos7)
            GroupBox_ADINA.Visible = True
            pos7 += pos6 + GroupBox_ADINA.Height + 20
        Else
            pos7 = pos6 + CheckBox6.Height + 20
            GroupBox_ADINA.Visible = False
        End If
    End Sub
    Private Sub CheckBoxes_states(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged, CheckBox2.CheckedChanged, CheckBox3.CheckedChanged, CheckBox4.CheckedChanged, CheckBox5.CheckedChanged, CheckBox6.CheckedChanged, CheckBox7.CheckedChanged
        GUI_update_locations()
    End Sub
    Private Sub TreeView_steps_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView_steps.AfterSelect
        Select Case TreeView_steps.SelectedNode.Text
            Case TreeView_steps.Nodes(0).Text
                CheckBox1.Checked = False
                CheckBox2.Checked = False
                CheckBox3.Checked = False
                CheckBox4.Checked = False
                CheckBox5.Checked = False
                CheckBox6.Checked = False
                CheckBox7.Checked = False
            Case TreeView_steps.Nodes(0).Nodes(0).Text
                CheckBox1.Checked = True
                CheckBox2.Checked = False
                CheckBox3.Checked = False
                CheckBox4.Checked = False
                CheckBox5.Checked = False
                CheckBox6.Checked = False
                CheckBox7.Checked = False
            Case TreeView_steps.Nodes(0).Nodes(1).Text

                CheckBox1.Checked = False
                CheckBox2.Checked = True
                CheckBox3.Checked = False
                CheckBox4.Checked = False
                CheckBox5.Checked = False
                CheckBox6.Checked = False
                CheckBox7.Checked = False
            Case TreeView_steps.Nodes(0).Nodes(2).Text

                CheckBox1.Checked = False
                CheckBox2.Checked = False
                CheckBox3.Checked = True
                CheckBox4.Checked = False
                CheckBox5.Checked = False
                CheckBox6.Checked = False
                CheckBox7.Checked = False
            Case TreeView_steps.Nodes(1).Text

                CheckBox1.Checked = False
                CheckBox2.Checked = False
                CheckBox3.Checked = False
                CheckBox4.Checked = False
                CheckBox5.Checked = False
                CheckBox6.Checked = False
                CheckBox7.Checked = False
            Case TreeView_steps.Nodes(1).Nodes(0).Text

                CheckBox1.Checked = False
                CheckBox2.Checked = False
                CheckBox3.Checked = False
                CheckBox4.Checked = True
                CheckBox5.Checked = False
                CheckBox6.Checked = False
                CheckBox7.Checked = False
            Case TreeView_steps.Nodes(1).Nodes(1).Text

                CheckBox1.Checked = False
                CheckBox2.Checked = False
                CheckBox3.Checked = False
                CheckBox4.Checked = False
                CheckBox5.Checked = True
                CheckBox6.Checked = False
                CheckBox7.Checked = False
            Case TreeView_steps.Nodes(2).Text

                CheckBox1.Checked = False
                CheckBox2.Checked = False
                CheckBox3.Checked = False
                CheckBox4.Checked = False
                CheckBox5.Checked = False
                CheckBox6.Checked = False
                CheckBox7.Checked = False
            Case TreeView_steps.Nodes(2).Nodes(0).Text

                CheckBox1.Checked = False
                CheckBox2.Checked = False
                CheckBox3.Checked = False
                CheckBox4.Checked = False
                CheckBox5.Checked = False
                CheckBox6.Checked = True
                CheckBox7.Checked = False
            Case TreeView_steps.Nodes(2).Nodes(1).Text

                CheckBox1.Checked = False
                CheckBox2.Checked = False
                CheckBox3.Checked = False
                CheckBox4.Checked = False
                CheckBox5.Checked = False
                CheckBox6.Checked = False
                CheckBox7.Checked = True
        End Select
    End Sub
    Private Sub plates_parameters(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numeric_plate_long.ValueChanged, numeric_plate_short.ValueChanged, numeric_plate_t.ValueChanged

        If CType(sender, NumericUpDown).Name = "numeric_plate_long" Then
            If numeric_plate_short.Value > numeric_plate_long.Value Then
                numeric_plate_short.Value = numeric_plate_long.Value
            End If
        Else
            If numeric_plate_short.Value > numeric_plate_long.Value Then
                numeric_plate_long.Value = numeric_plate_short.Value
            End If

        End If
        set_parameters()
    End Sub
    Private Sub physical_properties()
        '**********************************************************'
        If data_ok(TextBox_P_input.Text) Then
            If ComboBox_P_units.Text = ComboBox_P_units.Items(0).ToString Then
                P = TextBox_P_input.Text
            ElseIf ComboBox_P_units.Text = ComboBox_P_units.Items(1).ToString Then
                P = TextBox_P_input.Text * 10 ^ 3
            ElseIf ComboBox_P_units.Text = ComboBox_P_units.Items(2).ToString Then
                P = TextBox_P_input.Text * 10 ^ 6
            Else
                'general_settings.messages.read_msg(14)
                'general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                'Process_ok = False
            End If
        Else
            general_settings.messages.read_msg(15)
            general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
            pre_physical_ok = False
            P = 0
        End If
        '**********************************************************'
        If data_ok(TextBox_E_input.Text) Then
            Young_Modulus = TextBox_E_input.Text * 10 ^ 9
        Else
            general_settings.messages.read_msg(16)
            general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
            pre_physical_ok = False
            Young_Modulus = 0
        End If
        '**********************************************************'
        If data_ok(TextBox_ni_input.Text) Then
            ni = TextBox_ni_input.Text
        Else
            general_settings.messages.read_msg(17)
            general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
            pre_physical_ok = False
            ni = 0
        End If
        If numeric_BC_input.Value = 1 Or numeric_BC_input.Value = 2 Or numeric_BC_input.Value = 3 Or numeric_BC_input.Value = 4 Then
            BC_type = numeric_BC_input.Value
        Else
            general_settings.messages.read_msg(18)
            general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
            pre_physical_ok = False
            BC_type = 0
        End If

        set_parameters()
    End Sub
    Private Sub set_parameters()

        '*********** Plate's section ****************
        If data_ok(numeric_plate_long.Value) Then
            b = numeric_plate_long.Value
        Else
            b = 0
        End If
        If data_ok(numeric_plate_short.Value) Then
            a = numeric_plate_short.Value
        Else
            a = 0
        End If
        If data_ok(numeric_plate_t.Value) Then
            t = numeric_plate_t.Value / 1000
        Else
            t = 0
        End If
        If a <> 0 AndAlso b <> 0 AndAlso t <> 0 Then
            pre_plate_ok = True
            TreeView_steps.Nodes(0).Nodes(0).ImageIndex = 1
            TreeView_steps.Nodes(0).Nodes(0).SelectedImageIndex = 1
        Else
            pre_plate_ok = False
            TreeView_steps.Nodes(0).Nodes(0).ImageIndex = 0
            TreeView_steps.Nodes(0).Nodes(0).SelectedImageIndex = 0
        End If
        '*********** END Plate's section ****************
        ''*********** Stiffeners' section ****************
        ' ********Update GUI stiffeners*****
        If stiffeners_Is <> 0 AndAlso stiffeners_As <> 0 AndAlso stiffeners_Ys <> 0 AndAlso stiffeners_Ir <> 0 AndAlso stiffeners_Ar <> 0 AndAlso stiffeners_Yr <> 0 AndAlso stiffeners_r > 0 AndAlso stiffeners_s > 0 Then
            pre_stiffeners_ok = True
            TreeView_steps.Nodes(0).Nodes(1).ImageIndex = 1
            TreeView_steps.Nodes(0).Nodes(1).SelectedImageIndex = 1
        Else
            pre_stiffeners_ok = False
            TreeView_steps.Nodes(0).Nodes(1).ImageIndex = 0
            TreeView_steps.Nodes(0).Nodes(1).SelectedImageIndex = 0
        End If
        ' ********END Update GUI stiffeners*****
        '********Update GUI PYSICAL properties*****
        If Young_Modulus <> 0 AndAlso ni <> 0 AndAlso P <> 0 AndAlso BC_type <> 0 Then
            pre_physical_ok = True
            TreeView_steps.Nodes(0).Nodes(2).ImageIndex = 1
            TreeView_steps.Nodes(0).Nodes(2).SelectedImageIndex = 1
        Else
            pre_physical_ok = False
            TreeView_steps.Nodes(0).Nodes(2).ImageIndex = 0
            TreeView_steps.Nodes(0).Nodes(2).SelectedImageIndex = 0
        End If

        If Process_ok Then
            models_calculations.Grillage_model.model_variables.a = a
            models_calculations.Grillage_model.model_variables.b = b
            models_calculations.Grillage_model.model_variables.t = t
            models_calculations.Grillage_model.model_variables.r = stiffeners_r
            models_calculations.Grillage_model.model_variables.s = stiffeners_s
            models_calculations.Grillage_model.model_variables.Ir_stiffeners = stiffeners_Ir
            models_calculations.Grillage_model.model_variables.Is_stiffeners = stiffeners_Is
            models_calculations.Grillage_model.model_variables.Yr_stiffeners = stiffeners_Yr
            models_calculations.Grillage_model.model_variables.Ys_stiffeners = stiffeners_Ys
            models_calculations.Grillage_model.model_variables.Ar_stiffeners = stiffeners_Ar
            models_calculations.Grillage_model.model_variables.As_stiffeners = stiffeners_As
            models_calculations.Grillage_model.model_variables.BC = BC_type
            models_calculations.Grillage_model.model_variables.P = P
            models_calculations.Grillage_model.model_variables.E = Young_Modulus
            models_calculations.Grillage_model.model_variables.ni = ni
            update_summary_gui()

        End If
    End Sub
    Private Sub update_summary_gui()
        numeric_a.Value = models_calculations.Grillage_model.model_variables.a
        numeric_b.Value = models_calculations.Grillage_model.model_variables.b
        numeric_t.Value = models_calculations.Grillage_model.model_variables.t * 1000
        numeric_s_sum.Value = models_calculations.Grillage_model.model_variables.s
        numeric_r_sum.Value = models_calculations.Grillage_model.model_variables.r
        TextBox_Ir_stiffeners.Text = models_calculations.Grillage_model.model_variables.Ir_stiffeners
        TextBox_Is_stiffeners.Text = models_calculations.Grillage_model.model_variables.Is_stiffeners
        TextBox_Yr_stiffeners.Text = models_calculations.Grillage_model.model_variables.Yr_stiffeners
        TextBox_Ys_stiffeners.Text = models_calculations.Grillage_model.model_variables.Ys_stiffeners
        TextBox_Ar_stiffeners.Text = models_calculations.Grillage_model.model_variables.Ar_stiffeners
        TextBox_As_stiffeners.Text = models_calculations.Grillage_model.model_variables.As_stiffeners
        numeric_case_input.Value = models_calculations.Grillage_model.model_variables.BC
        TextBox_P.Text = models_calculations.Grillage_model.model_variables.P
        TextBox_E.Text = Math.Round(models_calculations.Grillage_model.model_variables.E / 10 ^ 9, 2)
        TextBox_ni.Text = models_calculations.Grillage_model.model_variables.ni
    End Sub

    Private Sub physical_properties_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_P_input.KeyPress, TextBox_E_input.KeyPress, TextBox_ni_input.KeyPress
        physical_properties()
    End Sub
    Private Sub Combobox_geo_select_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combobox_geo_select.SelectedIndexChanged
        If (Combobox_geo_select.Text = Combobox_geo_select.Items(0).ToString) Then
            PictureBox_Geo_blade.Visible = True
            PictureBox_Geo_L.Visible = False
            PictureBox_Geo_T.Visible = False
            PictureBox_Geo_I.Visible = False
            Label_geo_w.Visible = False
            MaskedTextBox_geo_w.Visible = False
            Label_unit_mm05.Visible = False
            Label_geo_t.Visible = False
            MaskedTextBox_geo_t.Visible = False
            Label_unit_mm04.Visible = False
            Label_geo_b.Text = "Length b"
            Label_geo_d.Text = "Height d"
            Label_geo_t.Text = "Thickness t"
            Label_geo_w.Text = "Thickness w"
        ElseIf (Combobox_geo_select.Text = Combobox_geo_select.Items(1).ToString) Then
            PictureBox_Geo_blade.Visible = False
            PictureBox_Geo_L.Visible = True
            PictureBox_Geo_T.Visible = False
            PictureBox_Geo_I.Visible = False
            Label_geo_w.Visible = False
            MaskedTextBox_geo_w.Visible = False
            Label_unit_mm05.Visible = False
            Label_geo_t.Visible = True
            MaskedTextBox_geo_t.Visible = True
            Label_unit_mm04.Visible = True
            Label_geo_b.Text = "Length b"
            Label_geo_d.Text = "Height d"
            Label_geo_t.Text = "Thickness t"
            Label_geo_w.Text = "Thickness w"
        ElseIf (Combobox_geo_select.Text = Combobox_geo_select.Items(2).ToString) Then
            PictureBox_Geo_blade.Visible = False
            PictureBox_Geo_L.Visible = False
            PictureBox_Geo_T.Visible = True
            PictureBox_Geo_I.Visible = False
            Label_geo_w.Visible = True
            MaskedTextBox_geo_w.Visible = True
            Label_unit_mm05.Visible = True
            Label_geo_t.Visible = True
            MaskedTextBox_geo_t.Visible = True
            Label_unit_mm04.Visible = True
            Label_geo_b.Text = "Length b"
            Label_geo_d.Text = "Height d"
            Label_geo_t.Text = "Thickness t"
            Label_geo_w.Text = "Thickness w"
        ElseIf (Combobox_geo_select.Text = Combobox_geo_select.Items(3).ToString) Then
            PictureBox_Geo_blade.Visible = False
            PictureBox_Geo_L.Visible = False
            PictureBox_Geo_T.Visible = False
            PictureBox_Geo_I.Visible = True
            Label_geo_w.Visible = True
            MaskedTextBox_geo_w.Visible = True
            Label_unit_mm05.Visible = True
            Label_geo_t.Visible = True
            MaskedTextBox_geo_t.Visible = True
            Label_unit_mm04.Visible = True
            Label_geo_b.Text = "Length b"
            Label_geo_d.Text = "Height d"
            Label_geo_t.Text = "Thickness t"
            Label_geo_w.Text = "Thickness w"
        End If
    End Sub


    Private Sub update_moment_of_inertia_box(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox_geo_b.TextChanged, MaskedTextBox_geo_d.TextChanged, MaskedTextBox_geo_t.TextChanged, MaskedTextBox_geo_w.TextChanged
        If (Combobox_geo_select.Text = Combobox_geo_select.Items(0).ToString) Then
            If (MaskedTextBox_geo_b.Text.Length > 30) Or (MaskedTextBox_geo_d.Text.Length > 30) Then
                general_settings.messages.read_msg(5)
                general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
            Else
                If data_ok(MaskedTextBox_geo_b.Text) = True And data_ok(MaskedTextBox_geo_d.Text) = True Then
                    If Math.Round(models_calculations.general_functions.moment_of_inertia(MaskedTextBox_geo_b.Text, MaskedTextBox_geo_d.Text, 0, 0, "|") * 100 ^ 4, 3) = 0 Then
                        TextBox_Geo_result.Text = Math.Round(models_calculations.general_functions.moment_of_inertia(MaskedTextBox_geo_b.Text, MaskedTextBox_geo_d.Text, 0, 0, "|") * 100 ^ 4, 8)
                    Else
                        TextBox_Geo_result.Text = Math.Round(models_calculations.general_functions.moment_of_inertia(MaskedTextBox_geo_b.Text, MaskedTextBox_geo_d.Text, 0, 0, "|") * 100 ^ 4, 3)
                    End If
                Else
                    TextBox_Geo_result.Text = "N/A"
                End If
            End If
        ElseIf (Combobox_geo_select.Text = Combobox_geo_select.Items(2).ToString) Then
            If (MaskedTextBox_geo_b.Text.Length > 30) Or (MaskedTextBox_geo_d.Text.Length > 30) Or (MaskedTextBox_geo_t.Text.Length > 30) Or (MaskedTextBox_geo_w.Text.Length > 30) Then
                general_settings.messages.read_msg(5)
                general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
            Else
                If general_functions.check_data(MaskedTextBox_geo_b.Text) = True And general_functions.check_data(MaskedTextBox_geo_d.Text) = True And general_functions.check_data(MaskedTextBox_geo_t.Text) = True And general_functions.check_data(MaskedTextBox_geo_w.Text) = True Then
                    If Math.Round(models_calculations.general_functions.moment_of_inertia(MaskedTextBox_geo_b.Text, MaskedTextBox_geo_d.Text, MaskedTextBox_geo_t.Text, MaskedTextBox_geo_w.Text, "T") * 100 ^ 4, 3) = 0 Then
                        TextBox_Geo_result.Text = Math.Round(models_calculations.general_functions.moment_of_inertia(MaskedTextBox_geo_b.Text, MaskedTextBox_geo_d.Text, MaskedTextBox_geo_t.Text, MaskedTextBox_geo_w.Text, "T") * 100 ^ 4, 8)
                    Else
                        TextBox_Geo_result.Text = Math.Round(models_calculations.general_functions.moment_of_inertia(MaskedTextBox_geo_b.Text, MaskedTextBox_geo_d.Text, MaskedTextBox_geo_t.Text, MaskedTextBox_geo_w.Text, "T") * 100 ^ 4, 3)
                    End If
                Else
                    TextBox_Geo_result.Text = "N/A"
                End If
            End If
        ElseIf (Combobox_geo_select.Text = Combobox_geo_select.Items(1).ToString) Then
            If (MaskedTextBox_geo_b.Text.Length > 30) Or (MaskedTextBox_geo_d.Text.Length > 30) Or (MaskedTextBox_geo_t.Text.Length > 30) Then
                general_settings.messages.read_msg(5)
                general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
            Else
                If general_functions.check_data(MaskedTextBox_geo_b.Text) = True And general_functions.check_data(MaskedTextBox_geo_d.Text) = True And general_functions.check_data(MaskedTextBox_geo_t.Text) = True Then
                    If Math.Round(models_calculations.general_functions.moment_of_inertia(MaskedTextBox_geo_b.Text, MaskedTextBox_geo_d.Text, MaskedTextBox_geo_t.Text, 0, "L") * 100 ^ 4, 3) = 0 Then
                        TextBox_Geo_result.Text = Math.Round(models_calculations.general_functions.moment_of_inertia(MaskedTextBox_geo_b.Text, MaskedTextBox_geo_d.Text, MaskedTextBox_geo_t.Text, 0, "L") * 100 ^ 4, 8)
                    Else
                        TextBox_Geo_result.Text = Math.Round(models_calculations.general_functions.moment_of_inertia(MaskedTextBox_geo_b.Text, MaskedTextBox_geo_d.Text, MaskedTextBox_geo_t.Text, 0, "L") * 100 ^ 4, 3)
                    End If
                Else
                    TextBox_Geo_result.Text = "N/A"
                End If
            End If
        ElseIf (Combobox_geo_select.Text = Combobox_geo_select.Items(3).ToString) Then
            If (MaskedTextBox_geo_b.Text.Length > 30) Or (MaskedTextBox_geo_d.Text.Length > 30) Or (MaskedTextBox_geo_t.Text.Length > 30) Or (MaskedTextBox_geo_w.Text.Length > 30) Then
                general_settings.messages.read_msg(5)
                general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
            Else
                If general_functions.check_data(MaskedTextBox_geo_b.Text) = True And general_functions.check_data(MaskedTextBox_geo_d.Text) = True And general_functions.check_data(MaskedTextBox_geo_t.Text) = True And general_functions.check_data(MaskedTextBox_geo_w.Text) = True Then
                    If Math.Round(models_calculations.general_functions.moment_of_inertia(MaskedTextBox_geo_b.Text, MaskedTextBox_geo_d.Text, MaskedTextBox_geo_t.Text, MaskedTextBox_geo_w.Text, "I") * 100 ^ 4, 3) = 0 Then
                        TextBox_Geo_result.Text = Math.Round(models_calculations.general_functions.moment_of_inertia(MaskedTextBox_geo_b.Text, MaskedTextBox_geo_d.Text, MaskedTextBox_geo_t.Text, MaskedTextBox_geo_w.Text, "I") * 100 ^ 4, 8)
                    Else
                        TextBox_Geo_result.Text = Math.Round(models_calculations.general_functions.moment_of_inertia(MaskedTextBox_geo_b.Text, MaskedTextBox_geo_d.Text, MaskedTextBox_geo_t.Text, MaskedTextBox_geo_w.Text, "I") * 100 ^ 4, 3)
                    End If
                Else
                    TextBox_Geo_result.Text = "N/A"
                End If
            End If
        Else
        End If
    End Sub

    Private Sub Button_Geo_selected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Geo_selected.Click
        '********* Blade stiffeners *****************
        If (Combobox_geo_select.Text = Combobox_geo_select.Items(0).ToString) Then
            If data_ok(MaskedTextBox_geo_b.Text) AndAlso data_ok(MaskedTextBox_geo_d.Text) Then
                current_moment = CSng(models_calculations.general_functions.moment_of_inertia(MaskedTextBox_geo_b.Text, MaskedTextBox_geo_d.Text, 0, 0, "|"))
                current_area = CSng(models_calculations.general_functions.Area(MaskedTextBox_geo_b.Text, MaskedTextBox_geo_d.Text, 0, 0, "|"))
                current_center = CSng(models_calculations.general_functions.centroid(MaskedTextBox_geo_b.Text, MaskedTextBox_geo_d.Text, 0, 0, "|"))
            Else
                current_moment = 0
                current_area = 0
                current_center = 0
                general_settings.messages.read_msg(6)
                general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
            End If
            '********* T stiffeners *****************
        ElseIf (Combobox_geo_select.Text = Combobox_geo_select.Items(2).ToString) Then
            If data_ok(MaskedTextBox_geo_b.Text) = True AndAlso data_ok(MaskedTextBox_geo_d.Text) AndAlso data_ok(MaskedTextBox_geo_t.Text) AndAlso data_ok(MaskedTextBox_geo_w.Text) Then
                current_moment = CSng(models_calculations.general_functions.moment_of_inertia(MaskedTextBox_geo_b.Text, MaskedTextBox_geo_d.Text, MaskedTextBox_geo_t.Text, MaskedTextBox_geo_w.Text, "T"))
                current_area = CSng(models_calculations.general_functions.Area(MaskedTextBox_geo_b.Text, MaskedTextBox_geo_d.Text, MaskedTextBox_geo_t.Text, MaskedTextBox_geo_w.Text, "T"))
                current_center = CSng(models_calculations.general_functions.centroid(MaskedTextBox_geo_b.Text, MaskedTextBox_geo_d.Text, MaskedTextBox_geo_t.Text, MaskedTextBox_geo_w.Text, "T"))
            Else
                current_moment = 0
                current_area = 0
                current_center = 0
                general_settings.messages.read_msg(6)
                general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
            End If
            '********* L stiffeners *****************
        ElseIf (Combobox_geo_select.Text = Combobox_geo_select.Items(1).ToString) Then
            If data_ok(MaskedTextBox_geo_b.Text) AndAlso data_ok(MaskedTextBox_geo_d.Text) AndAlso data_ok(MaskedTextBox_geo_t.Text) Then
                current_moment = CSng(models_calculations.general_functions.moment_of_inertia(MaskedTextBox_geo_b.Text, MaskedTextBox_geo_d.Text, MaskedTextBox_geo_t.Text, 0, "L"))
                current_area = CSng(models_calculations.general_functions.Area(MaskedTextBox_geo_b.Text, MaskedTextBox_geo_d.Text, MaskedTextBox_geo_t.Text, 0, "L"))
                current_center = CSng(models_calculations.general_functions.centroid(MaskedTextBox_geo_b.Text, MaskedTextBox_geo_d.Text, MaskedTextBox_geo_t.Text, 0, "L"))
            Else
                current_moment = 0
                current_area = 0
                current_center = 0
                general_settings.messages.read_msg(6)
                general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
            End If
            '********* I stiffeners *****************
        ElseIf (Combobox_geo_select.Text = Combobox_geo_select.Items(3).ToString) Then
            If data_ok(MaskedTextBox_geo_b.Text) AndAlso data_ok(MaskedTextBox_geo_d.Text) AndAlso data_ok(MaskedTextBox_geo_t.Text) AndAlso data_ok(MaskedTextBox_geo_w.Text) Then
                current_moment = CSng(models_calculations.general_functions.moment_of_inertia(MaskedTextBox_geo_b.Text, MaskedTextBox_geo_d.Text, MaskedTextBox_geo_t.Text, MaskedTextBox_geo_w.Text, "I"))
                current_area = CSng(models_calculations.general_functions.Area(MaskedTextBox_geo_b.Text, MaskedTextBox_geo_d.Text, MaskedTextBox_geo_t.Text, MaskedTextBox_geo_w.Text, "I"))
                current_center = CSng(models_calculations.general_functions.centroid(MaskedTextBox_geo_b.Text, MaskedTextBox_geo_d.Text, MaskedTextBox_geo_t.Text, MaskedTextBox_geo_w.Text, "I"))
            Else
                current_moment = 0
                current_area = 0
                current_center = 0
                general_settings.messages.read_msg(6)
                general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
            End If
        End If

        ' ********save data to stiffeners parameters*****
        If CheckBox_short.Checked Then ' s beam
            stiffeners_Ir = current_moment
            stiffeners_Ar = current_area
            stiffeners_Yr = current_center
        End If
        If CheckBox_long.Checked Then
            stiffeners_Is = current_moment
            stiffeners_As = current_area
            stiffeners_Ys = current_center
        End If
        ' ********END save data to stiffeners parameters*****
        ' ********Update GUI stiffeners*****
        If (CheckBox_long.Checked Or CheckBox_short.Checked) Then
            If stiffeners_Is <> 0 AndAlso stiffeners_As <> 0 AndAlso stiffeners_Ys <> 0 Then
                PictureBox_S.Image = My.Resources.icon_check
            Else
                PictureBox_S.Image = My.Resources.icon_x
            End If
            If stiffeners_Ir <> 0 AndAlso stiffeners_Ar <> 0 AndAlso stiffeners_Yr <> 0 Then
                PictureBox_R.Image = My.Resources.icon_check
            Else
                PictureBox_R.Image = My.Resources.icon_x
            End If
        Else
            MsgBox("No stifffener was selected", MsgBoxStyle.Exclamation, "Nothing was changed")
        End If
        ' ********END Update GUI stiffeners*****
        set_parameters()

    End Sub

    Private Sub stiffeners_count_update(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numeric_S.ValueChanged, numeric_R.ValueChanged

        If numeric_S.Value > numeric_R.Value Then
            If CType(sender, NumericUpDown).Name = "numeric_R" Then
                numeric_S.Value = numeric_R.Value
            Else
                numeric_R.Value = numeric_S.Value
            End If
        End If
        stiffeners_r = numeric_R.Value
        stiffeners_s = numeric_S.Value
        set_parameters()
        update_summary_gui()
    End Sub
    Private Sub select_type_of_input(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radiobutton_select_geometric.CheckedChanged, Radiobutton_select_DB.CheckedChanged, Radiobutton_select_numeric.CheckedChanged
        If Radiobutton_select_DB.Checked = True Then
            Groupbox_geometric_input.Visible = False
            GroupBox_numeric_input.Visible = False
            groupBox_DB_input.Visible = True
        ElseIf Radiobutton_select_numeric.Checked = True Then
            Groupbox_geometric_input.Visible = False
            GroupBox_numeric_input.Visible = True
            groupBox_DB_input.Visible = False
        ElseIf Radiobutton_select_geometric.Checked = True Then
            Groupbox_geometric_input.Visible = True
            GroupBox_numeric_input.Visible = False
            groupBox_DB_input.Visible = False
        Else
            MsgBox("ERROR: Input method must be selected")
        End If
    End Sub
    Private Sub Button_DB_select01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_DB_select01.Click, Button_DB_select02.Click, Button_DB_select03.Click, PictureBox_DB_pic02.Click, PictureBox_DB_pic01.Click
        general_settings.controls_Library.DB_moment = Me.TextBox_db_moment
        general_settings.controls_Library.DB_area = Me.TextBox_db_area
        general_settings.controls_Library.DB_centroid = Me.TextBox_db_center
        If DB_form.IsDisposed = True Then
            DB_form = New GUI_Database
        End If
        DB_form.Show()
        general_settings.controls_Library.form_change = Me
        general_settings.controls_Library.DB_update.Visible = True
        general_settings.controls_Library.DB_cancel.Visible = True
        Me.Enabled = False
    End Sub


    Private Sub Button_DB_selected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_DB_selected.Click
        If data_ok(TextBox_db_moment.Text) AndAlso data_ok(TextBox_db_area.Text) AndAlso data_ok(TextBox_db_center.Text) Then
            current_moment = CSng(TextBox_db_moment.Text) / 100 ^ 4
            current_area = CSng(TextBox_db_area.Text) / 100 ^ 2
            current_center = CSng(TextBox_db_center.Text) / 100
        Else
            general_settings.messages.read_msg(6)
            general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
        End If
        ' ********save data to stiffeners parameters*****
        If CheckBox_short.Checked Then ' r beam
            stiffeners_Ir = current_moment
            stiffeners_Ar = current_area
            stiffeners_Yr = current_center
        End If
        If CheckBox_long.Checked Then
            stiffeners_Is = current_moment
            stiffeners_As = current_area
            stiffeners_Ys = current_center
        End If
        ' ********END save data to stiffeners parameters*****
        ' ********Update GUI stiffeners*****
        If (CheckBox_long.Checked Or CheckBox_short.Checked) Then
            If stiffeners_Is <> 0 AndAlso stiffeners_As <> 0 AndAlso stiffeners_Ys <> 0 Then
                PictureBox_S.Image = My.Resources.icon_check
            Else
                PictureBox_S.Image = My.Resources.icon_x
            End If
            If stiffeners_Ir <> 0 AndAlso stiffeners_Ar <> 0 AndAlso stiffeners_Yr <> 0 Then
                PictureBox_R.Image = My.Resources.icon_check
            Else
                PictureBox_R.Image = My.Resources.icon_x
            End If
        Else
            MsgBox("No stifffener was selected", MsgBoxStyle.Exclamation, "Nothing was changed")
        End If
        ' ********END Update GUI stiffeners*****
        set_parameters()
    End Sub

    Private Sub Button_num_selected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_num_selected.Click
        Process_ok = True
        If (TextBox_num_moment.Text.Length > 30) Or (TextBox_num_area.Text.Length > 30) Or (TextBox_num_center.Text.Length > 30) Then
            general_settings.messages.read_msg(5)
            general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
            Process_ok = False
            current_moment = 0
            current_area = 0
            current_center = 0
        Else
            If data_ok(TextBox_num_moment.Text) AndAlso data_ok(TextBox_num_area.Text) AndAlso data_ok(TextBox_num_center.Text) Then
                '************ Checking units for moment *******************
                If (ComboBox_num_moment_units.Text = ComboBox_num_moment_units.Items(1).ToString) Then
                    current_moment = CSng(TextBox_num_moment.Text) / 100 ^ 4
                ElseIf (ComboBox_num_moment_units.Text = ComboBox_num_moment_units.Items(0).ToString) Then
                    current_moment = CSng(TextBox_num_moment.Text) / 1000 ^ 4
                ElseIf (ComboBox_num_moment_units.Text = ComboBox_num_moment_units.Items(2).ToString) Then
                    current_moment = CSng(TextBox_num_moment.Text)
                Else
                    general_settings.messages.read_msg(7)
                    general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                    Process_ok = False
                    current_moment = 0
                End If
                '************ Checking units for area *******************
                If (ComboBox_num_area_units.Text = ComboBox_num_area_units.Items(1).ToString) Then
                    current_area = CSng(TextBox_num_area.Text) / 100 ^ 2
                ElseIf (ComboBox_num_area_units.Text = ComboBox_num_area_units.Items(0).ToString) Then
                    current_area = CSng(TextBox_num_area.Text) / 1000 ^ 2
                ElseIf (ComboBox_num_area_units.Text = ComboBox_num_area_units.Items(2).ToString) Then
                    current_area = CSng(TextBox_num_area.Text)
                Else
                    general_settings.messages.read_msg(8) ' incorrect numeric values
                    general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                    Process_ok = False
                    current_area = 0
                End If
                '************ Checking units for center *******************
                If (ComboBox_num_center_units.Text = ComboBox_num_center_units.Items(1)) Then
                    current_center = CSng(TextBox_num_center.Text) / 100
                ElseIf (ComboBox_num_center_units.Text = ComboBox_num_center_units.Items(0).ToString) Then
                    current_center = CSng(TextBox_num_center.Text) / 1000
                ElseIf (ComboBox_num_center_units.Text = ComboBox_num_center_units.Items(2).ToString) Then
                    current_center = CSng(TextBox_num_center.Text)
                Else
                    general_settings.messages.read_msg(9)
                    general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                    Process_ok = False
                    current_center = 0
                End If
            Else
                general_settings.messages.read_msg(6)
                general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                current_moment = 0
                current_area = 0
                current_center = 0
            End If
        End If
        ' ********save data to stiffeners parameters*****
        If CheckBox_short.Checked Then ' r beam
            stiffeners_Ir = current_moment
            stiffeners_Ar = current_area
            stiffeners_Yr = current_center
        End If
        If CheckBox_long.Checked Then
            stiffeners_Is = current_moment
            stiffeners_As = current_area
            stiffeners_Ys = current_center
        End If
        ' ********END save data to stiffeners parameters*****
        ' ********Update GUI stiffeners*****
        If (CheckBox_long.Checked Or CheckBox_short.Checked) Then
            If stiffeners_Is <> 0 AndAlso stiffeners_As <> 0 AndAlso stiffeners_Ys <> 0 Then
                PictureBox_S.Image = My.Resources.icon_check
            Else
                PictureBox_S.Image = My.Resources.icon_x
            End If
            If stiffeners_Ir <> 0 AndAlso stiffeners_Ar <> 0 AndAlso stiffeners_Yr <> 0 Then
                PictureBox_R.Image = My.Resources.icon_check
            Else
                PictureBox_R.Image = My.Resources.icon_x
            End If
        Else
            MsgBox("No stifffener was selected", MsgBoxStyle.Exclamation, "Nothing was changed")
        End If
        ' ********END Update GUI stiffeners*****
        set_parameters()
    End Sub
    Private Sub Button_BC_type(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_case01.Click, Button_case02.Click, Button_case03.Click, Button_case04.Click
        If CType(sender, Button).Name = "Button_case01" Then
            numeric_BC_input.Value = 1
        ElseIf CType(sender, Button).Name = "Button_case02" Then
            numeric_BC_input.Value = 2
        ElseIf CType(sender, Button).Name = "Button_case03" Then
            numeric_BC_input.Value = 3
        ElseIf CType(sender, Button).Name = "Button_case04" Then
            numeric_BC_input.Value = 4
        End If
        physical_properties()
        set_parameters()
    End Sub




    Private Sub numeric_BC_input_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numeric_BC_input.ValueChanged
        physical_properties()
    End Sub

    Private Sub ComboBox_P_units_SelectedindexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox_P_units.SelectedIndexChanged
        If GroupBox_BC.Visible Then
            physical_properties()
        End If
    End Sub

    Private Sub Button_compute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_compute.Click
        models_calculations.Grillage_model.model_functions.main_function(models_calculations.Grillage_model.model_variables.a, models_calculations.Grillage_model.model_variables.b, models_calculations.Grillage_model.model_variables.t, models_calculations.Grillage_model.model_variables.r, models_calculations.Grillage_model.model_variables.s, models_calculations.Grillage_model.model_variables.Ir_stiffeners, models_calculations.Grillage_model.model_variables.Is_stiffeners, models_calculations.Grillage_model.model_variables.Ar_stiffeners, models_calculations.Grillage_model.model_variables.As_stiffeners, models_calculations.Grillage_model.model_variables.Yr_stiffeners, models_calculations.Grillage_model.model_variables.Ys_stiffeners, models_calculations.Grillage_model.model_variables.BC, models_calculations.Grillage_model.model_variables.E, models_calculations.Grillage_model.model_variables.ni, models_calculations.Grillage_model.model_variables.P)
        Textbox_results_Deflection.Text = Math.Round(models_calculations.Grillage_model.model_variables.Result * 1000, CInt(NumericUpDown_SD_deflection.Value)) & " [mm]"
    End Sub

    Private Sub NumericUpDown_SD_deflection_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown_SD_deflection.ValueChanged
        Textbox_results_Deflection.Text = Math.Round(models_calculations.Grillage_model.model_variables.Result * 1000, CInt(NumericUpDown_SD_deflection.Value)) & " [mm]"
    End Sub

End Class