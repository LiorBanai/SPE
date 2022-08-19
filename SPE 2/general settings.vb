Imports System
Imports System.IO
Public Class general_settings
    'Public Shared Sub load_settings_from_file()
    'Dim found As Integer = 0
    'Dim current_line As String = ""
    'Dim current_key As String = ""
    'Dim current_text As String = ""
    'Dim found_lang As Boolean = False
    'Dim lang_file As String = ""
    '    If File.Exists("config.ini") = False Then
    ''**************************msg to follow
    '    Else
    '        Using sr As StreamReader = New StreamReader("config.ini", System.Text.Encoding.Default)
    '            current_line = language_settings.read_line_from_file(sr, 1)
    '            While Not (current_line Is Nothing) 'there is text
    '                found = current_line.IndexOf("=")
    '                If (found > 0) Then
    '                    current_key = current_line.Substring(0, found).Trim() 'name
    '                    current_text = (current_line.Substring((found + 1)).Trim())
    '                    Select Case current_key
    ''***language settings ************
    '                        Case "current_language"
    '                            language_settings.language_current_file = current_text
    '                            found_lang = True
    '                        Case "remember_lang"
    '                            language_settings.lang_remember = CBool(current_text)
    '                        Case "first_run"
    '                            configurations.First_run = CBool(current_text)
    '                    End Select
    '                End If
    '                current_line = language_settings.read_line_from_file(sr, 1)
    '            End While
    '            sr.Close()
    '        End Using
    '    End If

    'End Sub
    'Public Shared Sub save_settings_to_file()
    '    Using sw As StreamWriter = New StreamWriter("config.ini", False)
    '        sw.WriteLine("Last update at " & DateTime.Now)
    '        sw.WriteLine("First_run=" & configurations.First_run)
    '        sw.WriteLine("remember_lang=" & language_settings.lang_remember)
    '        sw.WriteLine("current_language=" & language_settings.language_current_file)
    '        sw.Close()
    '    End Using
    'End Sub
    Public Class general_variables
        Public Shared orthotropic_count_results As Single = 0
        Public Shared Grillage_count_results As Single = 0
        Public Shared current_model As String = "orthotropic plate model"
    End Class
    Public Shared Sub load_settings_from_registry()
        '****** CURRENT MODEL READING *********
        If Not (My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Stiffened Plates Evaluator", "Current model", Nothing) Is Nothing) Then
            general_settings.general_variables.current_model = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Stiffened Plates Evaluator", "Current model", "orthotropic plate model")
        End If
        '****** END CURRENT MODEL READING *********

        '****** LANGUAGE FILE READING *********
        If Not (My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Stiffened Plates Evaluator", "Current file", Nothing) Is Nothing) Then
            language_settings.language_current_file = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Stiffened Plates Evaluator", "Current file", "default_eng.ini")
        End If
        '****** END LANGUAGE FILE READING *********
        '****** REMEMBER LANGUAGE READING *********
        If Not (My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Stiffened Plates Evaluator", "remember language", Nothing) Is Nothing) Then
            language_settings.language_remember = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Stiffened Plates Evaluator", "remember language", "false")
        End If
        '****** END REMEMBER LANGUAGE READING *********
        '******  COUNTER READING *********
        If Not (My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Stiffened Plates Evaluator", "orthotropic count results", Nothing) Is Nothing) Then
            general_settings.general_variables.orthotropic_count_results = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Stiffened Plates Evaluator", "orthotropic count results", 0)
        End If
        If Not (My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Stiffened Plates Evaluator", "grillage count results", Nothing) Is Nothing) Then
            general_settings.general_variables.Grillage_count_results = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Stiffened Plates Evaluator", "grillage count results", 0)
        End If
        '******  END COUNTER READING *********
        If language_settings.language_remember = False Then
            language_settings.language_current_file = "default_eng.ini"
        End If
        If File.Exists(language_settings.language_current_file) = False Then
            If File.Exists("default_eng.ini") = False Then
                If File.Exists("default_heb.ini") = False Then
                    ' no text file exist!!!!!!!!!
                Else
                    language_settings.language_current_file = "default_heb.ini"
                End If
            Else
                language_settings.language_current_file = "default_eng.ini"
            End If
        End If
    End Sub
    Public Shared Sub save_settings_to_registry()
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Stiffened Plates Evaluator", "Last updated", DateTime.Now)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Stiffened Plates Evaluator", "Current file", language_settings.language_current_file)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Stiffened Plates Evaluator", "remember language", language_settings.language_remember)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Stiffened Plates Evaluator", "orthotropic count results", general_settings.general_variables.orthotropic_count_results)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Stiffened Plates Evaluator", "grillage count results", general_settings.general_variables.Grillage_count_results)
        If general_settings.general_variables.current_model = Nothing Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Stiffened Plates Evaluator", "Current model", "orthotropic plate model")
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Stiffened Plates Evaluator", "Current model", general_settings.general_variables.current_model)
        End If
    End Sub
    Public Class controls_Library
        Public Shared numeric_case As NumericUpDown
        Public Shared current_lang As String = "english"
        Public Shared status_form As Form
        Public Shared luncher_form As Form
        Public Shared DB_moment As TextBox
        Public Shared DB_area As TextBox
        Public Shared DB_centroid As TextBox
        Public Shared DB_update As Button
        Public Shared DB_cancel As Button
        Public Shared form_change As Form
        Public Shared GUI_Launcher As Form
        Public Shared FEA_result_from_status As Form
        Public Shared FEA_result_from_status_case01 As RadioButton
        Public Shared FEA_result_from_status_case02 As RadioButton
        Public Shared FEA_result_from_status_case03 As RadioButton
        Public Shared FEA_result_from_status_case04 As RadioButton
        Public Shared remember_lang As Boolean = True
    End Class
    Public Class messages
        Public Shared msg_text As String = ""
        Public Shared msg_title As String = ""
        Public Shared msg_style As MsgBoxStyle
        Public Shared msg_res As MsgBoxResult
        Public Shared Function read_msg(ByVal num As Byte) As Boolean
            If language_settings.language_RTL_layout = True Then
                Select Case num
                    Case 1
                        msg_style = MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading
                        msg_title = language_settings.msg001
                        msg_text = language_settings.msg002
                    Case 2
                        msg_style = MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading
                        msg_title = language_settings.msg001
                        msg_text = language_settings.msg003
                    Case 3
                        msg_style = MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading
                        msg_title = language_settings.msg001
                        msg_text = language_settings.msg004
                    Case 4
                        msg_style = MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.YesNo
                        msg_title = language_settings.msg005
                        msg_text = language_settings.msg006 + Chr(13) + language_settings.msg007
                    Case 5 'Overflow warning
                        msg_style = MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading
                        msg_title = language_settings.msg008
                        msg_text = language_settings.msg009 + Chr(13) + language_settings.msg010
                    Case 6 'Inputs texts are inccorect
                        msg_style = MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading
                        msg_title = language_settings.msg001
                        msg_text = language_settings.msg011
                    Case 7 ' incorrect moment unit for nuneric input
                        msg_style = MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading
                        msg_title = language_settings.msg001
                        msg_text = language_settings.msg012
                    Case 8 ' incorrect area  unit for nuneric input
                        msg_style = MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading
                        msg_title = language_settings.msg001
                        msg_text = language_settings.msg013
                    Case 9 ' incorrect center  unit for nuneric input
                        msg_style = MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading
                        msg_title = language_settings.msg001
                        msg_text = language_settings.msg014
                    Case 10 'נתוני החיזוק המרכזי האורכי עבור התמונה
                        msg_style = MsgBoxStyle.OkOnly + MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading
                        msg_title = language_settings.msg015
                        msg_text = language_settings.msg016 + Chr(13) + language_settings.msg017 + CStr(Math.Round(models_calculations.Orthotropic_model.model_variables.Ia_stiffener * 100 ^ 4, 4)) + language_settings.unit_centimeter4 + Chr(13) + language_settings.msg018 + " " + CStr(Math.Round(models_calculations.Orthotropic_model.model_variables.Aa_stiffener * 100 ^ 2, 4)) + language_settings.unit_centimeter2 + Chr(13) + language_settings.msg019 + CStr(models_calculations.Orthotropic_model.model_variables.Ya_stiffener * 100) + language_settings.unit_centimeter
                    Case 11 'נתוני החיזוק המרכזי הרוחבי עבור התמונה
                        msg_style = MsgBoxStyle.OkOnly + MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading
                        msg_title = language_settings.msg020
                        msg_text = language_settings.msg021 + Chr(13) + language_settings.msg017 + CStr(Math.Round(models_calculations.Orthotropic_model.model_variables.Ib_stiffener * 100 ^ 4, 4)) + language_settings.unit_centimeter4 + Chr(13) + language_settings.msg018 + " " + CStr(Math.Round(models_calculations.Orthotropic_model.model_variables.Ab_stiffener * 100 ^ 2, 4)) + language_settings.unit_centimeter2 + Chr(13) + language_settings.msg019 + CStr(models_calculations.Orthotropic_model.model_variables.Yb_stiffener * 100) + language_settings.unit_centimeter
                    Case 12 'נתוני החיזוקים הלא מרכזיים האורכיים עבור התמונה
                        msg_style = MsgBoxStyle.OkOnly + MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading
                        msg_title = language_settings.msg022
                        msg_text = language_settings.msg023 + Chr(13) + language_settings.msg017 + CStr(Math.Round(models_calculations.Orthotropic_model.model_variables.Ina_stiffeners * 100 ^ 4, 4)) + language_settings.unit_centimeter4 + Chr(13) + language_settings.msg018 + CStr(Math.Round(models_calculations.Orthotropic_model.model_variables.Ana_stiffeners * 100 ^ 2, 4)) + language_settings.unit_centimeter2 + Chr(13) + language_settings.msg019 + CStr(models_calculations.Orthotropic_model.model_variables.Yna_stiffeners * 100) + language_settings.unit_centimeter
                    Case 13 'נתוני החיזוקים הלא מרכזיים הרוחביים עבור התמונה
                        msg_style = MsgBoxStyle.OkOnly + MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading
                        msg_title = language_settings.msg024
                        msg_text = language_settings.msg025 + Chr(13) + language_settings.msg017 + CStr(Math.Round(models_calculations.Orthotropic_model.model_variables.Inb_stiffeners * 100 ^ 4, 4)) + language_settings.unit_centimeter4 + Chr(13) + language_settings.msg018 + CStr(Math.Round(models_calculations.Orthotropic_model.model_variables.Anb_stiffeners * 100 ^ 2, 4)) + language_settings.unit_centimeter2 + Chr(13) + language_settings.msg019 + CStr(models_calculations.Orthotropic_model.model_variables.Ynb_stiffeners * 100) + language_settings.unit_centimeter
                    Case 14 'pressure units are incorrect
                        msg_style = MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading
                        msg_title = language_settings.msg001
                        msg_text = language_settings.msg026
                    Case 15 'pressure value is incorrect
                        msg_style = MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading
                        msg_title = language_settings.msg001
                        msg_text = language_settings.msg027
                    Case 16 'Young modulus is incorect
                        msg_style = MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading
                        msg_title = language_settings.msg001
                        msg_text = language_settings.msg028
                    Case 17 'poission is incorect
                        msg_style = MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading
                        msg_title = language_settings.msg001
                        msg_text = language_settings.msg029
                    Case 18 'BC is incorrect
                        msg_style = MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading
                        msg_title = language_settings.msg001
                        msg_text = language_settings.msg030

                    Case 19
                        msg_style = MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading
                        msg_title = language_settings.msg049
                        msg_text = language_settings.msg050 + Chr(13) + language_settings.msg051
                    Case 20 'מספר חיזוקים לא תקין
                        msg_style = MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading
                        msg_title = language_settings.msg001
                        msg_text = language_settings.msg052
                    Case 21 'numeric data incorrect - Ia
                        msg_style = MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading
                        msg_title = language_settings.msg001
                        msg_text = language_settings.msg053
                    Case 22 'numeric data incorrect - Ina
                        msg_style = MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading
                        msg_title = language_settings.msg001
                        msg_text = language_settings.msg054
                    Case 23 'numeric data incorrect - Ib
                        msg_style = MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading
                        msg_title = language_settings.msg001
                        msg_text = language_settings.msg055
                    Case 24 'numeric data incorrect - Inb
                        msg_style = MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading
                        msg_title = language_settings.msg001
                        msg_text = language_settings.msg056
                    Case 25 ' data updated
                        msg_style = MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading
                        msg_title = language_settings.msg057
                        msg_text = language_settings.msg058
                    Case 26 ' data not updated
                        msg_style = MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading
                        msg_title = language_settings.msg059
                        msg_text = language_settings.msg060
                    Case 27 ' current Language information
                        msg_style = MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading
                        msg_title = language_settings.msg070
                        msg_text = language_settings.msg071 + " " + language_settings.lang_name + Chr(13) + language_settings.msg072 + " " + language_settings.language_current_file + _
                        Chr(13) + language_settings.msg073 + " " + CStr(language_settings.language_RTL_layout) + Chr(13) + language_settings.msg074 + " " + language_settings.lang_comment1 + _
                        Chr(13) + language_settings.msg075 + " " + language_settings.lang_comment2 + Chr(13) + language_settings.msg076 + " " + language_settings.lang_comment3 + Chr(13) + language_settings.msg077 + " " + language_settings.lang_comment4

                End Select
            ElseIf language_settings.language_RTL_layout = False Then
                Select Case num 'english layout
                    Case 1
                        msg_style = MsgBoxStyle.Critical
                        msg_title = language_settings.msg001
                        msg_text = language_settings.msg002
                    Case 2
                        msg_style = MsgBoxStyle.Critical
                        msg_title = language_settings.msg001
                        msg_text = language_settings.msg003
                    Case 3
                        msg_style = MsgBoxStyle.Critical
                        msg_title = language_settings.msg001
                        msg_text = language_settings.msg004
                    Case 4
                        msg_style = MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo
                        msg_title = language_settings.msg005
                        msg_text = language_settings.msg006
                    Case 5 'Overflow warning
                        msg_style = MsgBoxStyle.Critical
                        msg_title = language_settings.msg008
                        msg_text = language_settings.msg009 + Chr(13) + language_settings.msg010
                    Case 6 'Inputs texts are inccorect
                        msg_style = MsgBoxStyle.Critical
                        msg_title = language_settings.msg001
                        msg_text = language_settings.msg011

                    Case 7 ' incorrect moment unit for nuneric input
                        msg_style = MsgBoxStyle.Critical
                        msg_title = language_settings.msg001
                        msg_text = language_settings.msg012

                    Case 8 ' incorrect area  unit for nuneric input
                        msg_style = MsgBoxStyle.Critical
                        msg_title = language_settings.msg001
                        msg_text = language_settings.msg013

                    Case 9 ' incorrect center  unit for nuneric input
                        msg_style = MsgBoxStyle.Critical
                        msg_title = language_settings.msg001
                        msg_text = language_settings.msg014

                    Case 10 'נתוני החיזוק המרכזי האורכי עבור התמונה
                        msg_style = MsgBoxStyle.OkOnly + MsgBoxStyle.Information
                        msg_title = language_settings.msg015
                        msg_text = language_settings.msg016 + Chr(13) + language_settings.msg017 + CStr(Math.Round(models_calculations.Orthotropic_model.model_variables.Ia_stiffener * 100 ^ 4, 4)) + language_settings.unit_centimeter4 + Chr(13) + language_settings.msg018 + " " + CStr(Math.Round(models_calculations.Orthotropic_model.model_variables.Aa_stiffener * 100 ^ 2, 4)) + language_settings.unit_centimeter2 + Chr(13) + language_settings.msg019 + CStr(models_calculations.Orthotropic_model.model_variables.Ya_stiffener * 100) + language_settings.unit_centimeter

                    Case 11 'נתוני החיזוק המרכזי הרוחבי עבור התמונה
                        msg_style = MsgBoxStyle.OkOnly + MsgBoxStyle.Information
                        msg_title = language_settings.msg020
                        msg_text = language_settings.msg021 + Chr(13) + language_settings.msg017 + CStr(Math.Round(models_calculations.Orthotropic_model.model_variables.Ib_stiffener * 100 ^ 4, 4)) + language_settings.unit_centimeter4 + Chr(13) + language_settings.msg018 + " " + CStr(Math.Round(models_calculations.Orthotropic_model.model_variables.Ab_stiffener * 100 ^ 2, 4)) + language_settings.unit_centimeter2 + Chr(13) + language_settings.msg019 + CStr(models_calculations.Orthotropic_model.model_variables.Yb_stiffener * 100) + language_settings.unit_centimeter

                    Case 12 'נתוני החיזוקים הלא מרכזיים האורכיים עבור התמונה
                        msg_style = MsgBoxStyle.OkOnly + MsgBoxStyle.Information
                        msg_title = language_settings.msg022
                        msg_text = language_settings.msg023 + Chr(13) + language_settings.msg017 + CStr(Math.Round(models_calculations.Orthotropic_model.model_variables.Ina_stiffeners * 100 ^ 4, 4)) + language_settings.unit_centimeter4 + Chr(13) + language_settings.msg018 + CStr(Math.Round(models_calculations.Orthotropic_model.model_variables.Ana_stiffeners * 100 ^ 2, 4)) + language_settings.unit_centimeter2 + Chr(13) + language_settings.msg019 + CStr(models_calculations.Orthotropic_model.model_variables.Yna_stiffeners * 100) + language_settings.unit_centimeter

                    Case 13 'נתוני החיזוקים הלא מרכזיים הרוחביים עבור התמונה
                        msg_style = MsgBoxStyle.OkOnly + MsgBoxStyle.Information
                        msg_title = language_settings.msg024
                        msg_text = language_settings.msg025 + Chr(13) + language_settings.msg017 + CStr(Math.Round(models_calculations.Orthotropic_model.model_variables.Inb_stiffeners * 100 ^ 4, 4)) + language_settings.unit_centimeter4 + Chr(13) + language_settings.msg018 + CStr(Math.Round(models_calculations.Orthotropic_model.model_variables.Anb_stiffeners * 100 ^ 2, 4)) + language_settings.unit_centimeter2 + Chr(13) + language_settings.msg019 + CStr(models_calculations.Orthotropic_model.model_variables.Ynb_stiffeners * 100) + language_settings.unit_centimeter

                    Case 14 'pressure units are incorrect
                        msg_style = MsgBoxStyle.Critical + MsgBoxStyle.Information
                        msg_title = language_settings.msg001
                        msg_text = language_settings.msg026

                        '"היחידות שנבחרו עבור הלחץ אינן תקינות"
                    Case 15 'pressure value is incorrect
                        msg_style = MsgBoxStyle.Critical + MsgBoxStyle.Information
                        msg_title = language_settings.msg001
                        msg_text = language_settings.msg027
                        '"הערך עבור הלחץ הפועל על הפלטה אינו ערך מספרי תקין"
                    Case 16 'Young modulus is incorect
                        msg_style = MsgBoxStyle.Critical + MsgBoxStyle.Information
                        msg_title = language_settings.msg001
                        msg_text = language_settings.msg028
                        '"הערך עבור מודול אלסטיות אינו ערך מספרי תקין"
                    Case 17 'poission is incorect
                        msg_style = MsgBoxStyle.Critical + MsgBoxStyle.Information
                        msg_title = language_settings.msg001
                        msg_text = language_settings.msg029
                        '"הערך עבור יחס פואסון אינו ערך מספרי תקין"
                    Case 18 'BC is incorrect
                        msg_style = MsgBoxStyle.Critical + MsgBoxStyle.Information
                        msg_title = language_settings.msg001
                        msg_text = language_settings.msg030
                        '"יש לבחור ערך שלם בין אחד עד ארבע עבור סוג תנאי השפה"

                    Case 19
                        msg_style = MsgBoxStyle.Critical + MsgBoxStyle.Information
                        msg_title = language_settings.msg049
                        msg_text = language_settings.msg050 + Chr(13) + language_settings.msg051
                    Case 20 'מספר חיזוקים לא תקין
                        msg_style = MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading
                        msg_title = language_settings.msg001
                        msg_text = language_settings.msg052
                    Case 21 'numeric data incorrect - Ia
                        msg_style = MsgBoxStyle.Critical
                        msg_title = language_settings.msg001
                        msg_text = language_settings.msg053
                    Case 22 'numeric data incorrect - Ina
                        msg_style = MsgBoxStyle.Critical
                        msg_title = language_settings.msg001
                        msg_text = language_settings.msg054
                    Case 23 'numeric data incorrect - Ib
                        msg_style = MsgBoxStyle.Critical
                        msg_title = language_settings.msg001
                        msg_text = language_settings.msg055
                    Case 24 'numeric data incorrect - Inb
                        msg_style = MsgBoxStyle.Critical
                        msg_title = language_settings.msg001
                        msg_text = language_settings.msg056
                    Case 25 ' data updated
                        msg_style = MsgBoxStyle.Information
                        msg_title = language_settings.msg057
                        msg_text = language_settings.msg058
                    Case 26 ' data not updated
                        msg_style = MsgBoxStyle.Information
                        msg_title = language_settings.msg059
                        msg_text = language_settings.msg060
                    Case 27 ' current Language information
                        msg_style = MsgBoxStyle.Information
                        msg_title = language_settings.msg070
                        msg_text = language_settings.msg071 + " " + language_settings.lang_name + Chr(13) + language_settings.msg072 + " " + language_settings.language_current_file + _
                        Chr(13) + language_settings.msg073 + " " + CStr(language_settings.language_RTL_layout) + Chr(13) + language_settings.msg074 + " " + language_settings.lang_comment1 + _
                        Chr(13) + language_settings.msg075 + " " + language_settings.lang_comment2 + Chr(13) + language_settings.msg076 + " " + language_settings.lang_comment3 + Chr(13) + language_settings.msg077 + " " + language_settings.lang_comment4
                End Select
            Else
                msg_text = "Language setting is missing."
                msg_title = "Unable to display message"
                msg_style = MsgBoxStyle.Critical + MsgBoxStyle.OkOnly
            End If
            Return True
        End Function
    End Class

End Class
