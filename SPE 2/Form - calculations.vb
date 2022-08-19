Public Class GUI_calculations
    Dim OPM As New models_calculations.Orthotropic_model
    Dim GM As New models_calculations.Grillage_model
    Private Sub GUI_calculations_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TreeView_steps.ExpandAll()
    End Sub
End Class