Public Module models_calculations
#Region "general functions"
    Public Class general_functions
        Public Shared Function centroid(ByVal b As Single, ByVal d As Single, ByVal t As Single, ByVal w As Single, ByVal type As String) As Single
            If type = "|" Then
                centroid = (d / 2) * 10 ^ -3
            ElseIf type = "T" Then
                centroid = (d + t - (b * t ^ 2 + w * d * (2 * t + d)) / (2 * (t * b + w * d))) * 10 ^ -3
            ElseIf type = "L" Then
                centroid = (d - (d ^ 2 + b * t - t ^ 2) / (2 * (b + d - t))) * 10 ^ -3
            ElseIf type = "I" Then
                centroid = (t + d / 2) * 10 ^ -3
            End If
        End Function
        Public Shared Function Area(ByVal b As Single, ByVal d As Single, ByVal t As Single, ByVal w As Single, ByVal type As String) As Single
            'input: millimeters Output: meters
            If type = "|" Then
                Area = (b * d) * 10 ^ -6
            ElseIf (type = "T") Then
                Area = (t * b + w * d) * 10 ^ -6
            ElseIf (type = "L") Then
                Area = t * (b + d - t) * 10 ^ -6
            ElseIf (type = "I") Then
                Area = (2 * b * t + w * d) * 10 ^ -6
            End If

        End Function
        Public Shared Function moment_of_inertia(ByVal b As Single, ByVal d As Single, ByVal t As Single, ByVal w As Single, ByVal type As String) As Single
            'Input: millimeters Output: meters
            Dim A As Single
            Dim Y As Single
            If type = "|" Then
                Return (1 / 12 * b * d ^ 3) * 10 ^ -12
            ElseIf type = "T" Then
                A = t * b + w * d
                Y = ((b * t ^ 2 + w * d * (2 * t + d)) / (2 * (t * b + w * d)))
                Return (b / 3 * (d + t) ^ 3 - d ^ 3 / 3 * (b - w) - A * (d + t - Y) ^ 2) * 10 ^ -12
            ElseIf type = "L" Then
                A = t * (b + d - t)
                Y = centroid(b, d, t, 0, "L") * 1000
                Return 1 / 3 * (t * Y ^ 3 + b * (d - Y) ^ 3 - (b - t) * (d - Y - t) ^ 3) * 10 ^ -12
            ElseIf type = "I" Then
                A = (2 * t * b + w * d)
                Y = centroid(b, d, t, w, "I") * 1000
                Return (b * (d + 2 * t) ^ 3 / 12 - (b - w) * d ^ 3 / 12) * 10 ^ -12
            End If
        End Function
        Public Shared Function moment_of_inertia_of_section(ByVal t As Single, ByVal lamda As Single, ByVal A_stiffener As Single, ByVal Y_stiffener As Single, ByVal I_stiffener As Single) As Single
            Dim A_plate As Single = t * lamda
            Dim y_plate As Single = t / 2
            Dim I_plate As Single = lamda * t ^ 3 / 12
            Dim Y As Single = (A_plate * y_plate + A_stiffener * (t + Y_stiffener)) / (A_plate + A_stiffener)
            moment_of_inertia_of_section = I_plate + A_plate * (Y - t / 2) ^ 2 + I_stiffener + A_stiffener * (Y - (t + Y_stiffener)) ^ 2
        End Function
    End Class
#End Region
#Region "Orthotropic Plate Model"
    Public Class Orthotropic_model
        Public Class model_variables
            Public Shared current_limit As UInteger = UInteger.MaxValue
            Public Shared current_count As UInteger = 0
            Public Shared a As Single = 0
            Public Shared b As Single = 0
            Public Shared t As Single = 0
            Public Shared Na As UShort = 0
            Public Shared Nb As UShort = 0
            Public Shared Ina_stiffeners As Single = 0
            Public Shared Inb_stiffeners As Single = 0
            Public Shared Ia_stiffener As Single = 0
            Public Shared Ib_stiffener As Single = 0
            Public Shared Ana_stiffeners As Single = 0
            Public Shared Anb_stiffeners As Single = 0
            Public Shared Aa_stiffener As Single = 0
            Public Shared Ab_stiffener As Single = 0
            Public Shared Yna_stiffeners As Single = 0
            Public Shared Ynb_stiffeners As Single = 0
            Public Shared Ya_stiffener As Single = 0
            Public Shared Yb_stiffener As Single = 0
            Public Shared C As Byte = 0
            Public Shared geo_type As Byte = 0
            Public Shared E As Double = 0
            Public Shared ni As Single = 0
            Public Shared P As Single = 0
            Public Shared Ina As Single = 0
            Public Shared Inb As Single = 0
            Public Shared Ia As Single = 0
            Public Shared Ib As Single = 0
            Public Shared Ia_small As Single = 0
            Public Shared Ib_small As Single = 0
            Public Shared Ipa As Single = 0
            Public Shared Ipb As Single = 0
            Public Shared lamda_a As Single = 0
            Public Shared lamda_b As Single = 0
            Public Shared Sa As Single = 0
            Public Shared Sb As Single = 0
            Public Shared ro As Single = 0
            Public Shared eta As Single = 0
            Public Shared K As Single = 0
            Public Shared Result As Single = 0
        End Class
        Public Class model_functions
            Protected Shared Function effective_breadth(ByVal L As Single, ByVal S As Single, ByVal indicator As Byte) As Single
                'The interpolation polynomial is:
                'lamda/S=-0.0004*(L/S)^4+0.0112*(L/S)^3-0.1243*(L/S)^2+0.6149*(L/S)-0.0991
                If ((L / S) < 10) Then
                    If (indicator = 0) Then 'The edge are not fixed
                        effective_breadth = S * (-0.00037116165315 * (L / S) ^ 4 + 0.01117005359459 * (L / S) ^ 3 - 0.12427949727216 * (L / S) ^ 2 + 0.61493315094325 * (L / S) - 0.09913539566537)
                    Else ' The edge are fixed
                        effective_breadth = S * (-0.00037116165315 * (0.58 * L / S) ^ 4 + 0.01117005359459 * (0.58 * L / S) ^ 3 - 0.12427949727216 * (0.58 * L / S) ^ 2 + 0.61493315094325 * (0.58 * L / S) - 0.09913539566537)
                    End If
                Else
                    effective_breadth = S * 1.08
                End If
            End Function
            Protected Shared Function interpolation_value(ByVal low_value As Single, ByVal high_value As Single, ByVal eta As Single) As Single
                If eta < 0.5 Then
                    interpolation_value = 2 * (high_value - low_value) * eta + low_value
                ElseIf eta > 0.5 Then
                    interpolation_value = 2 * (high_value - low_value) * eta + 2 * low_value + _
                    -high_value
                Else
                    interpolation_value = 0
                End If
            End Function
            Protected Shared Function polynomial_value(ByVal ro As Single, ByVal eta As Single, ByVal C As Single) As Single

                Dim low_value As Single
                Dim high_value As Single

                Select Case C
                    Case 1
                        If ro > 4 Then
                            polynomial_value = 0.013
                        Else
                            If (eta = 0) Then
                                polynomial_value = -0.00004454795065 * ro ^ 6 + _
                                                    0.00083815777717 * ro ^ 5 + _
                                                   -0.00662904226193 * ro ^ 4 + _
                                                    0.02867351518552 * ro ^ 3 + _
                                                   -0.07209929798593 * ro ^ 2 + _
                                                    0.09844961909519 * ro + _
                                                   -0.04098496019946
                            ElseIf (eta > 0) And (eta < 0.5) Then
                                low_value = -0.00004454795065 * ro ^ 6 + _
                                             0.00083815777717 * ro ^ 5 + _
                                            -0.00662904226193 * ro ^ 4 + _
                                             0.02867351518552 * ro ^ 3 + _
                                            -0.07209929798593 * ro ^ 2 + _
                                             0.09844961909519 * ro + _
                                            -0.04098496019946
                                high_value = 0.00002243655583 * ro ^ 5 + _
                                            -0.00045924181785 * ro ^ 4 + _
                                             0.00383486304547 * ro ^ 3 + _
                                            -0.01628219981246 * ro ^ 2 + _
                                             0.03483341410769 * ro + _
                                            -0.01655814297732
                                polynomial_value = interpolation_value(low_value, high_value, eta)
                            ElseIf (eta = 0.5) Then
                                polynomial_value = 0.00002243655583 * ro ^ 5 + _
                                                  -0.00045924181785 * ro ^ 4 + _
                                                   0.00383486304547 * ro ^ 3 + _
                                                  -0.01628219981246 * ro ^ 2 + _
                                                   0.03483341410769 * ro + _
                                                  -0.01655814297732
                            ElseIf (eta > 0.5) And (eta < 1) Then
                                low_value = 0.00002243655583 * ro ^ 5 + _
                                           -0.00045924181785 * ro ^ 4 + _
                                            0.00383486304547 * ro ^ 3 + _
                                           -0.01628219981246 * ro ^ 2 + _
                                            0.03483341410769 * ro + _
                                           -0.01655814297732
                                high_value = -0.00004217362008 * ro ^ 4 + _
                                              0.00080161259983 * ro ^ 3 + _
                                             -0.00569643121764 * ro ^ 2 + _
                                              0.01814886046275 * ro + _
                                              -0.00917385462892
                                polynomial_value = interpolation_value(low_value, high_value, eta)
                            ElseIf (eta = 1) Then
                                polynomial_value = -0.00004217362008 * ro ^ 4 + _
                                                    0.00080161259983 * ro ^ 3 + _
                                                   -0.00569643121764 * ro ^ 2 + _
                                                    0.01814886046275 * ro + _
                                                   -0.00917385462892
                            End If
                        End If
                    Case 2
                        If ro > 4 Then
                            polynomial_value = 0.013
                        Else
                            If (eta = 0) Then
                                polynomial_value = 0.0001177602276 * ro ^ 6 + _
                                                  -0.00217504214134 * ro ^ 5 + _
                                                   0.01601266822801 * ro ^ 4 + _
                                                  -0.05901567401907 * ro ^ 3 + _
                                                   0.11005573471706 * ro ^ 2 + _
                                                  -0.08751175090651 * ro + _
                                                   0.02521023518085
                            ElseIf (eta > 0) And (eta < 0.5) Then
                                low_value = 0.0001177602276 * ro ^ 6 + _
                                                  -0.00217504214134 * ro ^ 5 + _
                                                   0.01601266822801 * ro ^ 4 + _
                                                  -0.05901567401907 * ro ^ 3 + _
                                                   0.11005573471706 * ro ^ 2 + _
                                                  -0.08751175090651 * ro + _
                                                   0.02521023518085
                                high_value = 0.00006595396166 * ro ^ 6 + _
                                            -0.00123151509796 * ro ^ 5 + _
                                             0.00922016726091 * ro ^ 4 + _
                                            -0.03481662396601 * ro ^ 3 + _
                                             0.0668869947395 * ro ^ 2 + _
                                            -0.0534795102743 * ro + _
                                             0.01565022720959
                                polynomial_value = interpolation_value(low_value, high_value, eta)
                            ElseIf (eta = 0.5) Then
                                polynomial_value = 0.00006595396166 * ro ^ 6 + _
                                                  -0.00123151509796 * ro ^ 5 + _
                                                   0.00922016726091 * ro ^ 4 + _
                                                  -0.03481662396601 * ro ^ 3 + _
                                                   0.0668869947395 * ro ^ 2 + _
                                                  -0.0534795102743 * ro + _
                                                   0.01565022720959
                            ElseIf (eta > 0.5) And (eta < 1) Then
                                low_value = 0.00006595396166 * ro ^ 6 + _
                                                  -0.00123151509796 * ro ^ 5 + _
                                                   0.00922016726091 * ro ^ 4 + _
                                                  -0.03481662396601 * ro ^ 3 + _
                                                   0.0668869947395 * ro ^ 2 + _
                                                  -0.0534795102743 * ro + _
                                                   0.01565022720959
                                high_value = 0.00002497483438 * ro ^ 6 + _
                                                  -0.00051011319251 * ro ^ 5 + _
                                                   0.00417539050452 * ro ^ 4 + _
                                                  -0.01716450532838 * ro ^ 3 + _
                                                   0.03535703180792 * ro ^ 2 + _
                                                  -0.02778016017091 * ro + _
                                                   0.00779121946069
                                polynomial_value = interpolation_value(low_value, high_value, eta)
                            ElseIf (eta = 1) Then
                                polynomial_value = 0.00002497483438 * ro ^ 6 + _
                                                  -0.00051011319251 * ro ^ 5 + _
                                                   0.00417539050452 * ro ^ 4 + _
                                                  -0.01716450532838 * ro ^ 3 + _
                                                   0.03535703180792 * ro ^ 2 + _
                                                  -0.02778016017091 * ro + _
                                                   0.00779121946069
                            End If
                        End If
                    Case 3

                        If (eta = 0) Then
                            If ro < 2.6 Then
                                polynomial_value = -0.00010132105513 * ro ^ 6 + _
                                                    0.00090983323253 * ro ^ 5 + _
                                                   -0.00349821311625 * ro ^ 4 + _
                                                    0.00811876565967 * ro ^ 3 + _
                                                   -0.01305942450426 * ro ^ 2 + _
                                                    0.01310321884844 * ro + _
                                                   -0.00277313623735
                            Else
                                polynomial_value = 0.0026
                            End If
                        ElseIf (eta > 0) And (eta < 0.5) Then
                            If ro < 2.2 Then
                                low_value = -0.00010132105513 * ro ^ 6 + _
                                             0.00090983323253 * ro ^ 5 + _
                                            -0.00349821311625 * ro ^ 4 + _
                                             0.00811876565967 * ro ^ 3 + _
                                            -0.01305942450426 * ro ^ 2 + _
                                             0.01310321884844 * ro + _
                                            -0.00277313623735
                                high_value = -0.00208031525949 * ro ^ 6 + _
                                              0.02257834389866 * ro ^ 5 + _
                                             -0.10035576793757 * ro ^ 4 + _
                                              0.23416845347947 * ro ^ 3 + _
                                             -0.30348293295288 * ro ^ 2 + _
                                              0.20813729813335 * ro + _
                                             -0.05666507665922
                                polynomial_value = interpolation_value(low_value, high_value, eta)
                            ElseIf ro > 2.2 And ro < 2.6 Then
                                low_value = -0.00010132105513 * ro ^ 6 + _
                                             0.00090983323253 * ro ^ 5 + _
                                            -0.00349821311625 * ro ^ 4 + _
                                             0.00811876565967 * ro ^ 3 + _
                                            -0.01305942450426 * ro ^ 2 + _
                                             0.01310321884844 * ro + _
                                            -0.00277313623735
                                high_value = 0.0026
                                polynomial_value = interpolation_value(low_value, high_value, eta)
                            Else
                                polynomial_value = 0.0026
                            End If

                        ElseIf (eta = 0.5) Then
                            If ro < 2.2 Then
                                polynomial_value = -0.00208031525949 * ro ^ 6 + _
                                                    0.02257834389866 * ro ^ 5 + _
                                                   -0.10035576793757 * ro ^ 4 + _
                                                    0.23416845347947 * ro ^ 3 + _
                                                   -0.30348293295288 * ro ^ 2 + _
                                                    0.20813729813335 * ro + _
                                                   -0.05666507665922
                            Else
                                polynomial_value = 0.0026
                            End If

                        ElseIf (eta > 0.5) And (eta < 1) Then
                            If ro < 2.2 Then
                                low_value = -0.00208031525949 * ro ^ 6 + _
                                             0.02257834389866 * ro ^ 5 + _
                                            -0.10035576793757 * ro ^ 4 + _
                                             0.23416845347947 * ro ^ 3 + _
                                            -0.30348293295288 * ro ^ 2 + _
                                             0.20813729813335 * ro + _
                                            -0.05666507665922
                                high_value = -0.00084434211738 * ro ^ 6 + _
                                              0.00891741356304 * ro ^ 5 + _
                                             -0.0384132603732 * ro ^ 4 + _
                                              0.08662758135551 * ro ^ 3 + _
                                             -0.10886221370731 * ro ^ 2 + _
                                              0.07389386797709 * ro + _
                                             -0.01941890892078
                                polynomial_value = interpolation_value(low_value, high_value, eta)
                            Else
                                polynomial_value = 0.0026
                            End If

                        ElseIf (eta = 1) Then
                            If ro < 2.2 Then
                                polynomial_value = -0.00084434211738 * ro ^ 6 + _
                                                    0.00891741356304 * ro ^ 5 + _
                                                   -0.0384132603732 * ro ^ 4 + _
                                                    0.08662758135551 * ro ^ 3 + _
                                                   -0.10886221370731 * ro ^ 2 + _
                                                    0.07389386797709 * ro + _
                                                    -0.01941890892078
                            Else
                                polynomial_value = 0.0026
                            End If
                        End If
                    Case 4
                        If ro < 2 Then
                            polynomial_value = -0.01225490197339 * ro ^ 6 + _
                                                0.10708898955272 * ro ^ 5 + _
                                               -0.38188159915535 * ro ^ 4 + _
                                                0.71034810831952 * ro ^ 3 + _
                                               -0.72721965445476 * ro ^ 2 + _
                                                0.39094494203961 * ro + _
                                               -0.08572509246484
                        Else
                            polynomial_value = 0.0026
                        End If
                End Select

            End Function
            Public Shared Function main_function(ByVal a As Single, _
                                        ByVal b As Single, _
                                        ByVal t As Single, _
                                        ByVal Na As Byte, _
                                        ByVal Nb As Byte, _
                                        ByVal Ina_stiffeners As Single, _
                                        ByVal Inb_stiffeners As Single, _
                                        ByVal Ia_stiffener As Single, _
                                        ByVal Ib_stiffener As Single, _
                                        ByVal Ana_stiffeners As Single, _
                                        ByVal Anb_stiffeners As Single, _
                                        ByVal Aa_stiffener As Single, _
                                        ByVal Ab_stiffener As Single, _
                                        ByVal Yna_stiffeners As Single, _
                                        ByVal Ynb_stiffeners As Single, _
                                        ByVal Ya_stiffener As Single, _
                                        ByVal Yb_stiffener As Single, _
                                        ByVal C As Byte, _
                                        ByVal geo_type As Byte, _
                                        ByVal E As Double, _
                                        ByVal ni As Single, _
                                       ByVal P As Single) As Single
                If model_variables.current_count < model_variables.current_limit Then
                    model_variables.Sb = a / (Nb + 1)
                    model_variables.Sa = b / (Na + 1)
                    If (C = 1) Then
                        model_variables.lamda_a = effective_breadth(a, model_variables.Sa, 0)
                        model_variables.lamda_b = effective_breadth(b, model_variables.Sb, 0)
                    ElseIf (C = 2) Then
                        model_variables.lamda_a = effective_breadth(a, model_variables.Sa, 1)
                        model_variables.lamda_b = effective_breadth(b, model_variables.Sb, 0)
                    ElseIf (C = 3) Then
                        model_variables.lamda_a = effective_breadth(a, model_variables.Sa, 0)
                        model_variables.lamda_b = effective_breadth(b, model_variables.Sb, 1)
                    ElseIf (C = 4) Then
                        model_variables.lamda_a = effective_breadth(a, model_variables.Sa, 1)
                        model_variables.lamda_b = effective_breadth(b, model_variables.Sb, 1)
                    End If
                    model_variables.Ipa = model_variables.lamda_a * t ^ 3 / 12
                    model_variables.Ipb = model_variables.lamda_b * t ^ 3 / 12
                    model_variables.Ina = general_functions.moment_of_inertia_of_section(model_variables.t, model_variables.lamda_a, model_variables.Ana_stiffeners, model_variables.Yna_stiffeners, model_variables.Ina_stiffeners)
                    model_variables.Inb = general_functions.moment_of_inertia_of_section(model_variables.t, model_variables.lamda_b, model_variables.Anb_stiffeners, model_variables.Ynb_stiffeners, model_variables.Inb_stiffeners)
                    model_variables.Ia = general_functions.moment_of_inertia_of_section(model_variables.t, model_variables.lamda_a, model_variables.Aa_stiffener, model_variables.Ya_stiffener, model_variables.Ia_stiffener)
                    model_variables.Ib = general_functions.moment_of_inertia_of_section(model_variables.t, model_variables.lamda_b, Ab_stiffener, model_variables.Yb_stiffener, model_variables.Ib_stiffener)
                    Select Case geo_type
                        Case 1
                            model_variables.Ia_small = model_variables.t ^ 3 / (12 * (1 - model_variables.ni ^ 3))
                            model_variables.Ib_small = model_variables.Ia_small

                            model_variables.ro = model_variables.a / model_variables.b
                            model_variables.eta = 1

                        Case 2
                            model_variables.Ia_small = 0
                            model_variables.Ib_small = model_variables.Inb / model_variables.Sb
                            model_variables.ro = 100

                        Case 3

                            model_variables.Ia_small = 2 * model_variables.Ia / model_variables.b
                            model_variables.Ib_small = model_variables.Inb / model_variables.Sb + 2 * ((model_variables.Ib - model_variables.Inb) / model_variables.a)
                            model_variables.ro = model_variables.a / model_variables.b * Math.Sqrt(model_variables.Ib_small / model_variables.Ia_small)
                            model_variables.eta = 0.124 * Math.Sqrt((model_variables.Ipb) ^ 2 * b / (model_variables.Ia * model_variables.Inb * model_variables.Sa))

                        Case 4
                            model_variables.Ia_small = model_variables.Ina / model_variables.Sa + 2 * ((model_variables.Ia - model_variables.Ina) / model_variables.b)
                            model_variables.Ib_small = model_variables.Inb / model_variables.Sb + 2 * ((model_variables.Ib - model_variables.Inb) / model_variables.a)
                            model_variables.ro = model_variables.a / model_variables.b * (model_variables.Ib_small / model_variables.Ia_small) ^ (0.25)
                            'If ro < 1 Then
                            'ro = a / b * (Ia_small / Ib_small) ^ (0.25)
                            'Ib_small = Ia_small
                            'End If
                            model_variables.eta = Math.Sqrt(model_variables.Ipa * model_variables.Ipb / (model_variables.Ina * model_variables.Inb))

                    End Select
                    model_variables.K = polynomial_value(model_variables.ro, model_variables.eta, model_variables.C)
                    models_calculations.Orthotropic_model.model_variables.Result = model_variables.K * model_variables.P * model_variables.b ^ 4 / (model_variables.E * model_variables.Ib_small)
                    If model_variables.Result <> 0 Or model_variables.Result <> Single.NaN Then
                        model_variables.current_count += 1
                    End If
                Else
                    ' TO BE COMPLETE LATER
                    Dim msg_style As MsgBoxStyle = MsgBoxStyle.Critical
                    Dim msg_title As String = "Unable to proceed"
                    Dim msg_text As String = "The number of allowed anlayses per run have passed" & vbCr & "Restart the program to used the model again"
                    MsgBox(msg_text, msg_style, msg_title)
                    Return -1
                End If
            End Function
        End Class
    End Class
#End Region
#Region "Grillage Model"
    Public Class Grillage_model
        Public Class model_variables
            Public Shared current_limit As UInteger = UInteger.MaxValue
            Public Shared current_count As UInteger = 0
            Public Shared a As Single = 0 ' length of R stiffeners
            Public Shared b As Single = 0 ' length of S stiffeners
            Public Shared t As Single = 0 ' Thickness of plate/panel
            Public Shared r As Single = 0 ' number of R stiffeners
            Public Shared s As Single = 0 ' number of S stiffeners
            ' requirement01: r >= s ' TO BE COMPLETE LATER
            Public Shared Ir_stiffeners As Single = 0 ' moment of inertia or R stiffeners
            Public Shared Is_stiffeners As Single = 0 ' moment of inertia or S stiffeners
            Public Shared Ar_stiffeners As Single = 0 ' Area or R stiffeners
            Public Shared As_stiffeners As Single = 0 ' Area or S stiffeners
            Public Shared Yr_stiffeners As Single = 0 ' Centriod or R stiffeners
            Public Shared Ys_stiffeners As Single = 0 ' Centriod or S stiffeners
            Public Shared I_r As Single = 0 ' moment of inertia or R section
            Public Shared I_s As Single = 0 ' moment of inertia or S section
            Public Shared BC As Byte = 0 ' type of boundary condition
            Public Shared c As Single = 0 ' spacing of S beams
            Public Shared d As Single = 0 ' spacing of R beams
            Public Shared E As Double = 0
            Public Shared ni As Single = 0
            Public Shared P As Single = 0
            Public Shared mu As Single = 0
            Public Shared lamda As Single = 0
            Public Shared Result As Single = 0
            Public Shared Chart_value As Single = 0

        End Class
        Public Class model_functions
            Protected Shared left, right As Integer
            Protected Shared Sub SPLINE_set_range(ByVal n As Single, ByVal t() As Single, ByVal tval As Single)
                Dim i As Byte = 0
                For i = 2 To n - 1
                    If (tval < CSng(t.GetValue(i))) Then
                        left = i - 1
                        right = i
                        Exit For
                    Else
                        left = n - 1
                        right = n
                    End If
                Next
            End Sub
            Public Shared Function polynomial_CUBIC_SPLINE_interpolation(ByVal r As Single, ByVal s As Single, ByVal BC_case As Byte, ByVal tval As Single) As Single
                Dim t() As Single
                Dim y() As Single
                Dim ypp() As Single
                Dim n As Integer
                Dim low, high As Single

                Dim K00_n_rXS As Byte = 15
                Dim K00_range_rXs() As Single = {0.01, 200}
                Dim K00_x_rXs() As Single = {0.01, 0.02, 0.05, 0.1, 0.2, 0.25, 0.5, 1, 2, 5, 10, 20, 50, 100, 200}
                Dim K00_y_rXs() As Single = {0.00015, 0.00028, 0.00075, 0.00145, 0.0026, 0.0032, 0.0054, 0.008, 0.0108, 0.0133, 0.0143, 0.0146, 0.0142, 0.0136, 0.0132}
                Dim K00_ypp_rXs() As Single = {0.20678, 0.20678, -0.087012, -0.04563, 0.030397, -0.031121, -0.0081881, -0.0030749, -0.0010811, -0.000025441, -0.000029935, 0.00000052545, -0.000000089518, 0.00000013119, 0.00000013119}

                Dim K00_n_rX3 As Byte = 14
                Dim K00_range_rX3() As Single = {0.05, 500}
                Dim K00_x_rX3() As Single = {0.05, 0.1, 0.2, 0.25, 0.5, 1, 2, 5, 10, 20, 50, 100, 200, 500}
                Dim K00_y_rX3() As Single = {0.0007, 0.00135, 0.00245, 0.0029, 0.005, 0.0074, 0.0098, 0.0123, 0.0132, 0.0136, 0.0135, 0.0132, 0.0128, 0.0123}
                Dim K00_ypp_rX3() As Single = {-0.025129, -0.025129, -0.032048, 0.0025481, -0.014106, -0.0021567, -0.00087694, -0.000075931, -0.000014859, -0.0000014566, 0.00000017077, 0.0000000075245, 0.000000012043, 0.000000012043}

                Dim K00_n_rX1 As Byte = 15
                Dim K00_range_rX1() As Single = {0.02, 500}
                Dim K00_x_rX1() As Single = {0.02, 0.05, 0.1, 0.2, 0.25, 0.5, 1, 2, 5, 10, 20, 50, 100, 200, 500}
                Dim K00_y_rX1() As Single = {0.00024, 0.0006, 0.00114, 0.0021, 0.0025, 0.0041, 0.0062, 0.0083, 0.0103, 0.0112, 0.0116, 0.0115, 0.0113, 0.0109, 0.0104}
                Dim K00_ypp_rX1() As Single = {-0.035514, -0.035514, -0.0090455, -0.027106, -0.011272, -0.0059266, -0.0029843, -0.00068393, -0.000048106, -0.000019702, -0.0000008403, 0.00000014153, -0.0000000287, 0.000000015336, 0.000000015336}


                Dim K01_n_rXS As Byte = 15
                Dim K01_range_rXs() As Single = {0.01, 200}
                Dim K01_x_rXs() As Single = {0.01, 0.02, 0.05, 0.1, 0.2, 0.25, 0.5, 1, 2, 5, 10, 20, 50, 100, 200}
                Dim K01_y_rXs() As Single = {0.000025, 0.00005, 0.00015, 0.0003, 0.0006, 0.00071, 0.0016, 0.0026, 0.0046, 0.0082, 0.0109, 0.0128, 0.0139, 0.01385, 0.0133}
                Dim K01_ypp_rXs() As Single = {0.065105, 0.065105, -0.028648, 0.012609, -0.023505, 0.019808, -0.010199, 0.0019724, -0.00081777, -0.000076737, -0.000055777, -0.0000042994, -0.00000060905, 0.0000000086316, 0.0000000086316}

                Dim K01_n_rX3 As Byte = 8
                Dim K01_range_rX3() As Single = {1, 200}
                Dim K01_x_rX3() As Single = {1, 2, 5, 10, 20, 50, 100, 200}
                Dim K01_y_rX3() As Single = {0.0025, 0.0044, 0.0078, 0.0104, 0.0123, 0.0134, 0.0134, 0.013}
                Dim K01_ypp_rX3() As Single = {-0.00046813, -0.00046813, -0.00012895, -0.000042471, -0.0000061088, -0.00000021942, -0.000000032572, -0.000000032572}

                Dim K01_n_rX1 As Byte = 13
                Dim K01_range_rX1() As Single = {0.1, 500}
                Dim K01_x_rX1() As Single = {0.1, 0.2, 0.25, 0.5, 1, 2, 5, 10, 20, 50, 100, 200, 500}
                Dim K01_y_rX1() As Single = {0.00026, 0.0005, 0.00061, 0.0013, 0.0021, 0.0037, 0.0065, 0.0087, 0.0103, 0.0113, 0.0114, 0.011, 0.0105}
                Dim K01_ypp_rX1() As Single = {-0.0040819, -0.0040819, 0.0086552, -0.0065161, 0.0013007, -0.00064394, -0.000049714, -0.000046551, -0.0000034908, -0.00000050771, -0.000000040862, 0.000000016442, 0.000000016442}

                Dim K10_n_rXS As Byte = 15
                Dim K10_range_rXs() As Single = {0.01, 500}
                Dim K10_x_rXs() As Single = {0.01, 0.02, 0.05, 0.1, 0.2, 0.5, 1, 2, 5, 10, 20, 50, 100, 200, 500}
                Dim K10_y_rXs() As Single = {0.00016, 0.00029, 0.00065, 0.0011, 0.00165, 0.00235, 0.0027, 0.0029, 0.00295, 0.00288, 0.00276, 0.00265, 0.00261, 0.00261, 0.00261}
                Dim K10_ypp_rXs() As Single = {-0.036608, -0.036608, -0.090175, -0.049476, -0.016486, -0.0028794, -0.0004945, -0.000076815, 0.0000030046, -0.00000032588, 0.00000067536, -0.000000025665, 0.000000020911, -0.000000001901, -0.000000001901}

                Dim K10_n_3X3 As Byte = 11
                Dim K10_range_3X3() As Single = {0.05, 100}
                Dim K10_x_3X3() As Single = {0.05, 0.1, 0.2, 0.5, 1, 2, 5, 10, 20, 50, 100}
                Dim K10_y_3X3() As Single = {0.0006, 0.000105, 0.00155, 0.00225, 0.0026, 0.0028, 0.0029, 0.00288, 0.00276, 0.00272, 0.00268}
                Dim K10_ypp_3X3() As Single = {0.46262, 0.46262, -0.15816, 0.025218, -0.0054032, 0.00060035, -0.00013321, 0.000021258, -0.0000019684, 0.00000029643, 0.00000029643}

                Dim K10_n_rX1 As Byte = 14
                Dim K10_range_rX1() As Single = {0.02, 500}
                Dim K10_x_rX1() As Single = {0.02, 0.05, 0.1, 0.2, 0.5, 1, 2, 5, 10, 20, 50, 100, 200, 500}
                Dim K10_y_rX1() As Single = {0.00025, 0.00052, 0.0009, 0.0014, 0.00208, 0.0025, 0.00275, 0.00288, 0.00287, 0.00285, 0.00275, 0.00271, 0.00265, 0.00261}
                Dim K10_ypp_rX1() As Single = {-0.033246, -0.033246, -0.041664, -0.014386, -0.0024157, -0.00075813, -0.000057782, -0.0000065386, 0.0000011929, -0.00000030934, 0.00000016061, -0.000000024355, 0.0000000047596, 0.0000000047596}

                Dim K11_n_rXS As Byte = 14
                Dim K11_range_rXs() As Single = {0.01, 200}
                Dim K11_x_rXs() As Single = {0.01, 0.02, 0.05, 0.1, 0.2, 0.5, 1, 2, 5, 10, 20, 50, 100, 200}
                Dim K11_y_rXs() As Single = {0.000025, 0.00005, 0.00015, 0.00029, 0.00055, 0.0011, 0.00165, 0.0022, 0.0027, 0.00285, 0.00283, 0.0027, 0.00265, 0.00265}
                Dim K11_ypp_rXs() As Single = {0.066757, 0.066757, -0.033605, 0.0034824, -0.0056446, -0.0014419, -0.00079915, -0.00018161, -0.000016004, -0.0000038248, 0.00000027638, 0.000000071276, 0.0000000060905, 0.0000000060905}

                Dim K11_n_rX1 As Byte = 8
                Dim K11_range_rX1() As Single = {0.05, 10}
                Dim K11_x_rX1() As Single = {0.05, 0.1, 0.2, 0.5, 1, 2, 5, 10}
                Dim K11_y_rX1() As Single = {0.00014, 0.00025, 0.00045, 0.00094, 0.00145, 0.002, 0.0026, 0.0028}
                Dim K11_ypp_rX1() As Single = {-0.0029406, -0.0029406, -0.0017079, -0.0017987, -0.0005793, -0.00018273, -0.000019609, -0.000019609}

                If BC_case = 1 Then
                    If s = 3 Then
                        t = K00_x_rX3
                        y = K00_y_rX3
                        ypp = K00_ypp_rX3
                        low = K00_range_rX3.GetValue(0)
                        high = K00_range_rX3.GetValue(1)
                    ElseIf s = 1 Then
                        t = K00_x_rX1
                        y = K00_y_rX1
                        ypp = K00_ypp_rX1
                        low = K00_range_rX1.GetValue(0)
                        high = K00_range_rX1.GetValue(1)
                    Else
                        t = K00_x_rXs
                        y = K00_y_rXs
                        ypp = K00_ypp_rXs
                        low = K00_range_rXs.GetValue(0)
                        high = K00_range_rXs.GetValue(1)
                    End If

                ElseIf BC_case = 2 Then
                    If s = 3 Then
                        t = K01_x_rX3
                        y = K01_y_rX3
                        ypp = K01_ypp_rX3
                        low = K01_range_rX3.GetValue(0)
                        high = K01_range_rX3.GetValue(1)
                    ElseIf s = 1 Then
                        t = K01_x_rX1
                        y = K01_y_rX1
                        ypp = K01_ypp_rX1
                        low = K01_range_rX1.GetValue(0)
                        high = K01_range_rX1.GetValue(1)
                    Else
                        t = K01_x_rXs
                        y = K01_y_rXs
                        ypp = K01_ypp_rXs
                        low = K01_range_rXs.GetValue(0)
                        high = K01_range_rXs.GetValue(1)
                    End If

                ElseIf BC_case = 3 Then
                    If (s = 3) AndAlso (r = 3) Then
                        t = K10_x_3X3
                        y = K10_y_3X3
                        ypp = K10_ypp_3X3
                        low = K10_range_3X3.GetValue(0)
                        high = K10_range_3X3.GetValue(1)
                    ElseIf s = 1 Then
                        t = K10_x_rX1
                        y = K10_y_rX1
                        ypp = K10_ypp_rX1
                        low = K10_range_rX1.GetValue(0)
                        high = K10_range_rX1.GetValue(1)
                    Else
                        t = K10_x_rXs
                        y = K10_y_rXs
                        ypp = K10_ypp_rXs
                        low = K10_range_rXs.GetValue(0)
                        high = K10_range_rXs.GetValue(1)
                    End If

                ElseIf BC_case = 4 Then
                    If s = 1 Then
                        t = K11_x_rX1
                        y = K11_y_rX1
                        ypp = K11_ypp_rX1
                        low = K11_range_rX1.GetValue(0)
                        high = K11_range_rX1.GetValue(1)
                    Else
                        t = K11_x_rXs
                        y = K11_y_rXs
                        ypp = K11_ypp_rXs
                        low = K11_range_rXs.GetValue(0)
                        high = K11_range_rXs.GetValue(1)
                    End If
                End If
                If (BC_case = 1) Or (BC_case = 2) Or (BC_case = 3) Or (BC_case = 4) Then
                    n = y.Length - 1
                    If tval <= high And tval >= low Then
                        Grillage_model.model_functions.SPLINE_set_range(n, t, tval)
                        Dim dt As Single = tval - CSng(t.GetValue(left))
                        Dim h As Single = t.GetValue(right) - t.GetValue(left)
                        Dim yval As Single = y.GetValue(left) + dt * ((y.GetValue(right) - y.GetValue(left)) / h - (ypp.GetValue(right) / 6.0 + ypp.GetValue(left) / 3.0) * h + dt * (0.5 * ypp.GetValue(left) + dt * ((ypp.GetValue(right) - ypp.GetValue(left)) / (6.0 * h))))
                        Dim ypval As Single = (y.GetValue(right) - y.GetValue(left)) / h - (ypp.GetValue(right) / 6.0 + ypp.GetValue(left) / 3.0) * h + dt * (ypp.GetValue(left) + dt * (0.5 * (ypp.GetValue(right) - ypp.GetValue(left)) / h))
                        Dim yppval As Single = ypp.GetValue(left) + dt * (ypp.GetValue(right) - ypp.GetValue(left)) / h
                        Return yval
                    Else
                        ' TO BE COMPLETE LATER value is out of range
                        Dim msg_style As MsgBoxStyle = MsgBoxStyle.Critical
                        Dim msg_title As String = "Error(Out of Range)"
                        Dim msg_text As String = "Chart value is out of range for this problem"
                        MsgBox(msg_text, msg_style, msg_title)
                    End If
                Else
                    ' TO BE COMPLETE LATER bc case is out of range
                End If
            End Function
            Protected Shared Function moment_of_inertia_of_section(ByVal t As Single, ByVal breadth As Single, ByVal A_stiffener As Single, ByVal Y_stiffener As Single, ByVal I_stiffener As Single) As Single
                Dim A_plate As Single = t * breadth
                Dim y_plate As Single = t / 2
                Dim I_plate As Single = breadth * t ^ 3 / 12
                Dim Y As Single = (A_plate * y_plate + A_stiffener * (t + Y_stiffener)) / (A_plate + A_stiffener)
                moment_of_inertia_of_section = I_plate + A_plate * (Y - t / 2) ^ 2 + I_stiffener + A_stiffener * (Y - (t + Y_stiffener)) ^ 2
            End Function
            Public Shared Function main_function(ByVal a As Single, _
                                        ByVal b As Single, _
                                        ByVal t As Single, _
                                        ByVal r As Single, _
                                        ByVal s As Single, _
                                        ByVal Ir_stiffeners As Single, _
                                        ByVal Is_stiffeners As Single, _
                                        ByVal Ar_stiffeners As Single, _
                                        ByVal As_stiffeners As Single, _
                                        ByVal Yr_stiffeners As Single, _
                                        ByVal Ys_stiffeners As Single, _
                                        ByVal BC As Byte, _
                                        ByVal E As Double, _
                                        ByVal ni As Single, _
                                       ByVal P As Single) As Single
                If model_variables.current_count < model_variables.current_limit Then
                    If r >= s Then
                        model_variables.c = a / (s + 1)
                        model_variables.d = b / (r + 1)
                        Dim effective_breadth_r As Single = model_variables.d / 2
                        Dim effective_breadth_s As Single = model_variables.c / 2
                        model_variables.I_r = moment_of_inertia_of_section(t, effective_breadth_r, Ar_stiffeners, Yr_stiffeners, Ir_stiffeners)
                        model_variables.I_s = moment_of_inertia_of_section(t, effective_breadth_s, As_stiffeners, Ys_stiffeners, Is_stiffeners)
                        model_variables.lamda = ((b) ^ 3 * (model_variables.I_r)) / ((a) ^ 3 * (model_variables.I_s))
                        model_variables.mu = model_variables.lamda * (r + 1) / (s + 1)
                        model_variables.Chart_value = polynomial_CUBIC_SPLINE_interpolation(r, s, BC, model_variables.mu)
                        model_variables.Result = ((model_variables.Chart_value) * (s + 1) * (P) * (model_variables.c) * (model_variables.d) * (a) ^ 3) / ((E) * (model_variables.I_r))
                        If model_variables.Result <> 0 Or model_variables.Result <> Single.NaN Then
                            model_variables.current_count += 1
                            Return model_variables.Result
                        End If
                    Else
                        ' TO BE COMPLETE LATER
                        Dim msg_style As MsgBoxStyle = MsgBoxStyle.Critical
                        Dim msg_title As String = "Error"
                        Dim msg_text As String = "r beams should be greater or equal the s beams"
                        MsgBox(msg_text, msg_style, msg_title)
                        Return -1
                    End If
                Else
                    ' TO BE COMPLETE LATER
                    Dim msg_style As MsgBoxStyle = MsgBoxStyle.Critical
                    Dim msg_title As String = "Unable to proceed"
                    Dim msg_text As String = "The number of allowed anlayses per run have passed" & vbCr & "Restart the program to used the model again"
                    MsgBox(msg_text, msg_style, msg_title)
                    Return -1
                End If
            End Function
        End Class
    End Class
#End Region
End Module
