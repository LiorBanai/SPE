Public Class GUI_model_chart_value
    Private Sub TextChanging(ByVal sender As Object, ByVal e As System.EventArgs) Handles r.TextChanged, s.TextChanged, bc.TextChanged, mu.ValueChanged
        If (mu.Text <> "") AndAlso (r.Text <> "") AndAlso (s.Text <> "") AndAlso (bc.Text <> "") Then
            Label_chart_value.Text = Math.Round(models_calculations.Grillage_model.model_functions.polynomial_CUBIC_SPLINE_interpolation(r.Text, s.Text, bc.Text, mu.Text), 6)
        End If
    End Sub
    Private Sub mu_TextChanging(ByVal sender As Object, ByVal e As System.EventArgs) Handles mu.ValueChanged
        If mu.Value < 10 Then
            mu.Increment = 0.01
        ElseIf mu.Value > 10 And mu.Value < 50 Then
            mu.Increment = 1
        Else
            mu.Increment = 10
        End If
    End Sub
End Class