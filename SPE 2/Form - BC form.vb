Public Class GUI_BC_select
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents case03 As System.Windows.Forms.Button
    Friend WithEvents case04 As System.Windows.Forms.Button
    Friend WithEvents case02 As System.Windows.Forms.Button
    Friend WithEvents case01 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(GUI_BC_select))
        Me.case03 = New System.Windows.Forms.Button
        Me.case04 = New System.Windows.Forms.Button
        Me.case02 = New System.Windows.Forms.Button
        Me.case01 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'case03
        '
        Me.case03.Image = CType(resources.GetObject("case03.Image"), System.Drawing.Image)
        Me.case03.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.case03.Location = New System.Drawing.Point(240, 144)
        Me.case03.Name = "case03"
        Me.case03.Size = New System.Drawing.Size(232, 124)
        Me.case03.TabIndex = 6
        '
        'case04
        '
        Me.case04.Image = CType(resources.GetObject("case04.Image"), System.Drawing.Image)
        Me.case04.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.case04.Location = New System.Drawing.Point(4, 144)
        Me.case04.Name = "case04"
        Me.case04.Size = New System.Drawing.Size(228, 124)
        Me.case04.TabIndex = 7
        '
        'case02
        '
        Me.case02.Image = CType(resources.GetObject("case02.Image"), System.Drawing.Image)
        Me.case02.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.case02.Location = New System.Drawing.Point(4, 8)
        Me.case02.Name = "case02"
        Me.case02.Size = New System.Drawing.Size(228, 128)
        Me.case02.TabIndex = 5
        '
        'case01
        '
        Me.case01.Image = CType(resources.GetObject("case01.Image"), System.Drawing.Image)
        Me.case01.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.case01.Location = New System.Drawing.Point(240, 8)
        Me.case01.Name = "case01"
        Me.case01.Size = New System.Drawing.Size(232, 128)
        Me.case01.TabIndex = 4
        '
        'BC_form
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(480, 276)
        Me.Controls.Add(Me.case03)
        Me.Controls.Add(Me.case04)
        Me.Controls.Add(Me.case02)
        Me.Controls.Add(Me.case01)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(486, 304)
        Me.Name = "BC_form"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "תנאי שפה: הצגה ובחירה"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Function GUI_set() As Boolean
        Dim msg01 As String
        Dim msg02 As String
        Dim msg03 As String
        Dim msg04 As String
        Dim toolTip1 As New ToolTip
        toolTip1.AutoPopDelay = 5000
        toolTip1.InitialDelay = 100
        toolTip1.ReshowDelay = 0
        toolTip1.ShowAlways = True
        Me.RightToLeft = language_settings.language_RTL
        Me.RightToLeftLayout = language_settings.language_RTL_layout
        Me.Text = language_settings.msg068 + " (" + language_settings.msg069 + " " + CStr(models_calculations.Orthotropic_model.model_variables.C) + ")"
        msg01 = language_settings.msg061 + Chr(13) + language_settings.msg062
        msg02 = language_settings.msg063 + Chr(13) + language_settings.msg064
        msg03 = language_settings.msg065 + Chr(13) + language_settings.msg066
        msg04 = language_settings.msg067
        toolTip1.SetToolTip(Me.case01, msg01)
        toolTip1.SetToolTip(Me.case02, msg02)
        toolTip1.SetToolTip(Me.case03, msg03)
        toolTip1.SetToolTip(Me.case04, msg04)
    End Function
    Private Sub BC_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GUI_set()
    End Sub
    Private Sub case01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles case01.Click
        models_calculations.Orthotropic_model.model_variables.C = 1
        Me.Close()
    End Sub
    Private Sub case02_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles case02.Click
        models_calculations.Orthotropic_model.model_variables.C = 2
        Me.Close()
    End Sub
    Private Sub case03_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles case03.Click
        models_calculations.Orthotropic_model.model_variables.C = 3
        Me.Close()
    End Sub
    Private Sub case04_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles case04.Click
        models_calculations.Orthotropic_model.model_variables.C = 4
        Me.Close()
    End Sub
    Private Sub GUI_BC_select_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        general_settings.controls_Library.numeric_case.Value = models_calculations.Orthotropic_model.model_variables.C
    End Sub
End Class
