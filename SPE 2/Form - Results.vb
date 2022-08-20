Imports System
Imports System.IO
Public Class GUI_Data_and_Results
    Inherits System.Windows.Forms.Form 'System.Windows.Forms.Form 

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
    Friend WithEvents label_t As System.Windows.Forms.Label
    Friend WithEvents label_b As System.Windows.Forms.Label
    Friend WithEvents label_a As System.Windows.Forms.Label
    Friend WithEvents label_short As System.Windows.Forms.Label
    Friend WithEvents label_long As System.Windows.Forms.Label
    Friend WithEvents data_units As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel ' System.Windows.Forms.Panel
    Friend WithEvents ListView_steps As System.Windows.Forms.ListView 'System.Windows.Forms.ListView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel ' System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel ' System.Windows.Forms.Panel
    Friend WithEvents GroupBox_stiffeners_number As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox_stiffeners_data As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox_numeric_stiffeners As System.Windows.Forms.GroupBox
    Friend WithEvents Button_save_stiffeners As System.Windows.Forms.Button
    Friend WithEvents groupbox_plate_geo As System.Windows.Forms.GroupBox
    Friend WithEvents label_unit_mm01 As System.Windows.Forms.Label
    Friend WithEvents label_unit_m02 As System.Windows.Forms.Label
    Friend WithEvents label_unit_m01 As System.Windows.Forms.Label
    Friend WithEvents groupbox_general As System.Windows.Forms.GroupBox
    Friend WithEvents Label_pressure As System.Windows.Forms.Label
    Friend WithEvents label_ni As System.Windows.Forms.Label
    Friend WithEvents Label_E As System.Windows.Forms.Label
    Friend WithEvents Label_BC As System.Windows.Forms.Label
    Friend WithEvents GroupBox_stiffeners As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox_stiffeners_geometric As System.Windows.Forms.GroupBox
    Friend WithEvents Label_GPa As System.Windows.Forms.Label
    Friend WithEvents combobox_P_units As System.Windows.Forms.ComboBox
    Friend WithEvents textbox_P_input As System.Windows.Forms.TextBox
    Friend WithEvents textbox_ni_input As System.Windows.Forms.TextBox
    Friend WithEvents textbox_E_input As System.Windows.Forms.TextBox
    Friend WithEvents numeric_case_input As System.Windows.Forms.NumericUpDown
    Friend WithEvents label_title As System.Windows.Forms.Label
    Friend WithEvents numeric_short As System.Windows.Forms.NumericUpDown
    Friend WithEvents numeric_long As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label_geometric As System.Windows.Forms.Label
    Friend WithEvents Button_data_change As System.Windows.Forms.Button
    Friend WithEvents Label_data_unit As System.Windows.Forms.Label
    Friend WithEvents Button_data_more As System.Windows.Forms.Button
    Friend WithEvents Label_transverse01 As System.Windows.Forms.Label
    Friend WithEvents Label_non_central02 As System.Windows.Forms.Label
    Friend WithEvents Label_central02 As System.Windows.Forms.Label
    Friend WithEvents Label_longitudinals01 As System.Windows.Forms.Label
    Friend WithEvents Label_non_central01 As System.Windows.Forms.Label
    Friend WithEvents Label_central01 As System.Windows.Forms.Label
    Friend WithEvents Picture_eng_panel1 As System.Windows.Forms.PictureBox
    Friend WithEvents Picture_heb_panel1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox_b As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_nb As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_a As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_na As System.Windows.Forms.TextBox
    Friend WithEvents numeric_t As System.Windows.Forms.NumericUpDown
    Friend WithEvents numeric_b As System.Windows.Forms.NumericUpDown
    Friend WithEvents numeric_a As System.Windows.Forms.NumericUpDown
    Friend WithEvents button_BC_select As System.Windows.Forms.Button
    Friend WithEvents ImageList_listview As System.Windows.Forms.ImageList
    Friend WithEvents RichTextBox_results As System.Windows.Forms.RichTextBox
    Friend WithEvents Button_compute As System.Windows.Forms.Button
    Friend WithEvents Textbox_results As System.Windows.Forms.TextBox
    Friend WithEvents label_msg01 As System.Windows.Forms.Label
    Friend WithEvents Button_more_error As System.Windows.Forms.Button
    Friend WithEvents TextBox_Inb_d As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Ina_d As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Ia_d As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Ib_d As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Inb_b As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Ina_b As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Ia_b As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Ib_b As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox_Inb As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_Ib As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_Ina As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_Ia As System.Windows.Forms.CheckBox
    Friend WithEvents Picture_eng_panel2 As System.Windows.Forms.PictureBox
    Friend WithEvents Picture_heb_panel2 As System.Windows.Forms.PictureBox
    Friend WithEvents Picture_eng_panel3 As System.Windows.Forms.PictureBox
    Friend WithEvents Picture_heb_panel3 As System.Windows.Forms.PictureBox
    Friend WithEvents textbox_geo_type As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel 'System.Windows.Forms.Panel
    Friend WithEvents Label_Adina As System.Windows.Forms.Label
    Friend WithEvents Picture_eng_panel4 As System.Windows.Forms.PictureBox
    Friend WithEvents Picture_heb_panel4 As System.Windows.Forms.PictureBox
    Friend WithEvents RichTextBox_adina_msg As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox_model_qualify As System.Windows.Forms.RichTextBox
    Friend WithEvents Button_feed_ADINA As System.Windows.Forms.Button
    Friend WithEvents Button_Run_ADINA As System.Windows.Forms.Button
    Friend WithEvents RichTextBox_result_for_saving As System.Windows.Forms.RichTextBox
    Friend WithEvents button_results_save As System.Windows.Forms.Button
    Friend WithEvents button_results_clear As System.Windows.Forms.Button
    Friend WithEvents Label_mm_msg As System.Windows.Forms.Label
    Friend WithEvents Label_transverse02 As System.Windows.Forms.Label
    Friend WithEvents Label_non_central04 As System.Windows.Forms.Label
    Friend WithEvents Label_central04 As System.Windows.Forms.Label
    Friend WithEvents Label_longitudinals02 As System.Windows.Forms.Label
    Friend WithEvents Label_non_central03 As System.Windows.Forms.Label
    Friend WithEvents Label_central03 As System.Windows.Forms.Label
    Friend WithEvents Label_b_change As System.Windows.Forms.Label
    Friend WithEvents Label_d_change As System.Windows.Forms.Label
    Friend WithEvents PictureBox01 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox02 As System.Windows.Forms.PictureBox
    Friend WithEvents SplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox_choose_language As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton_other_language As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_default_english As System.Windows.Forms.RadioButton
    Friend WithEvents Button_update As System.Windows.Forms.Button
    Friend WithEvents GroupBox_update As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton_add_replace As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_add_after As System.Windows.Forms.RadioButton
    Friend WithEvents Label_affiliated As System.Windows.Forms.Label
    Friend WithEvents Label_SD As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown_SD As System.Windows.Forms.NumericUpDown
    Friend WithEvents PictureBox_figures As System.Windows.Forms.PictureBox
    Friend WithEvents Button_view_parameters As System.Windows.Forms.Button
    Friend WithEvents GroupBox_creation_type As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton_fast As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_normal As System.Windows.Forms.RadioButton
    Friend WithEvents button_results_save_HTML As System.Windows.Forms.Button
    Friend WithEvents RichTextBox_result_for_saving_HTML As System.Windows.Forms.RichTextBox
    Friend WithEvents ImageList_model As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Data Summary"}, 3, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("David", 12.0!))
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Maximum Deflection Result"}, 2, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("David", 12.0!))
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"model calculation"}, 4, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("David", 12.0!))
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Create ADINA Model"}, 5, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("David", 12.0!))
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI_Data_and_Results))
        Me.groupbox_plate_geo = New System.Windows.Forms.GroupBox()
        Me.Button_view_parameters = New System.Windows.Forms.Button()
        Me.label_unit_mm01 = New System.Windows.Forms.Label()
        Me.label_unit_m02 = New System.Windows.Forms.Label()
        Me.label_unit_m01 = New System.Windows.Forms.Label()
        Me.numeric_t = New System.Windows.Forms.NumericUpDown()
        Me.numeric_b = New System.Windows.Forms.NumericUpDown()
        Me.numeric_a = New System.Windows.Forms.NumericUpDown()
        Me.label_t = New System.Windows.Forms.Label()
        Me.label_b = New System.Windows.Forms.Label()
        Me.label_a = New System.Windows.Forms.Label()
        Me.label_title = New System.Windows.Forms.Label()
        Me.GroupBox_stiffeners_number = New System.Windows.Forms.GroupBox()
        Me.numeric_short = New System.Windows.Forms.NumericUpDown()
        Me.numeric_long = New System.Windows.Forms.NumericUpDown()
        Me.label_short = New System.Windows.Forms.Label()
        Me.label_long = New System.Windows.Forms.Label()
        Me.GroupBox_stiffeners = New System.Windows.Forms.GroupBox()
        Me.GroupBox_stiffeners_geometric = New System.Windows.Forms.GroupBox()
        Me.textbox_geo_type = New System.Windows.Forms.TextBox()
        Me.Label_geometric = New System.Windows.Forms.Label()
        Me.GroupBox_stiffeners_data = New System.Windows.Forms.GroupBox()
        Me.Button_data_change = New System.Windows.Forms.Button()
        Me.Label_data_unit = New System.Windows.Forms.Label()
        Me.Button_data_more = New System.Windows.Forms.Button()
        Me.TextBox_b = New System.Windows.Forms.TextBox()
        Me.Label_transverse01 = New System.Windows.Forms.Label()
        Me.TextBox_nb = New System.Windows.Forms.TextBox()
        Me.Label_non_central02 = New System.Windows.Forms.Label()
        Me.Label_central02 = New System.Windows.Forms.Label()
        Me.TextBox_a = New System.Windows.Forms.TextBox()
        Me.Label_longitudinals01 = New System.Windows.Forms.Label()
        Me.Label_non_central01 = New System.Windows.Forms.Label()
        Me.Label_central01 = New System.Windows.Forms.Label()
        Me.TextBox_na = New System.Windows.Forms.TextBox()
        Me.data_units = New System.Windows.Forms.ComboBox()
        Me.groupbox_general = New System.Windows.Forms.GroupBox()
        Me.Label_GPa = New System.Windows.Forms.Label()
        Me.button_BC_select = New System.Windows.Forms.Button()
        Me.combobox_P_units = New System.Windows.Forms.ComboBox()
        Me.textbox_P_input = New System.Windows.Forms.TextBox()
        Me.textbox_ni_input = New System.Windows.Forms.TextBox()
        Me.textbox_E_input = New System.Windows.Forms.TextBox()
        Me.Label_pressure = New System.Windows.Forms.Label()
        Me.label_ni = New System.Windows.Forms.Label()
        Me.Label_E = New System.Windows.Forms.Label()
        Me.numeric_case_input = New System.Windows.Forms.NumericUpDown()
        Me.Label_BC = New System.Windows.Forms.Label()
        Me.RichTextBox_result_for_saving = New System.Windows.Forms.RichTextBox()
        Me.Button_compute = New System.Windows.Forms.Button()
        Me.Textbox_results = New System.Windows.Forms.TextBox()
        Me.label_msg01 = New System.Windows.Forms.Label()
        Me.Button_more_error = New System.Windows.Forms.Button()
        Me.button_results_clear = New System.Windows.Forms.Button()
        Me.ListView_steps = New System.Windows.Forms.ListView()
        Me.ImageList_listview = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Picture_eng_panel1 = New System.Windows.Forms.PictureBox()
        Me.Picture_heb_panel1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox_numeric_stiffeners = New System.Windows.Forms.GroupBox()
        Me.Label_mm_msg = New System.Windows.Forms.Label()
        Me.CheckBox_Inb = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Ib = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Ina = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Ia = New System.Windows.Forms.CheckBox()
        Me.TextBox_Inb_d = New System.Windows.Forms.TextBox()
        Me.TextBox_Ina_d = New System.Windows.Forms.TextBox()
        Me.TextBox_Ia_d = New System.Windows.Forms.TextBox()
        Me.TextBox_Ib_d = New System.Windows.Forms.TextBox()
        Me.Button_save_stiffeners = New System.Windows.Forms.Button()
        Me.TextBox_Inb_b = New System.Windows.Forms.TextBox()
        Me.TextBox_Ina_b = New System.Windows.Forms.TextBox()
        Me.TextBox_Ia_b = New System.Windows.Forms.TextBox()
        Me.TextBox_Ib_b = New System.Windows.Forms.TextBox()
        Me.Label_b_change = New System.Windows.Forms.Label()
        Me.Label_d_change = New System.Windows.Forms.Label()
        Me.Label_longitudinals02 = New System.Windows.Forms.Label()
        Me.Label_transverse02 = New System.Windows.Forms.Label()
        Me.Label_non_central04 = New System.Windows.Forms.Label()
        Me.Label_central04 = New System.Windows.Forms.Label()
        Me.Label_non_central03 = New System.Windows.Forms.Label()
        Me.Label_central03 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox_figures = New System.Windows.Forms.PictureBox()
        Me.NumericUpDown_SD = New System.Windows.Forms.NumericUpDown()
        Me.Picture_eng_panel2 = New System.Windows.Forms.PictureBox()
        Me.Picture_heb_panel2 = New System.Windows.Forms.PictureBox()
        Me.RichTextBox_results = New System.Windows.Forms.RichTextBox()
        Me.Label_SD = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.button_results_save_HTML = New System.Windows.Forms.Button()
        Me.GroupBox_choose_language = New System.Windows.Forms.GroupBox()
        Me.GroupBox_update = New System.Windows.Forms.GroupBox()
        Me.RadioButton_add_replace = New System.Windows.Forms.RadioButton()
        Me.Button_update = New System.Windows.Forms.Button()
        Me.RadioButton_add_after = New System.Windows.Forms.RadioButton()
        Me.RadioButton_other_language = New System.Windows.Forms.RadioButton()
        Me.RadioButton_default_english = New System.Windows.Forms.RadioButton()
        Me.RichTextBox_result_for_saving_HTML = New System.Windows.Forms.RichTextBox()
        Me.Picture_eng_panel3 = New System.Windows.Forms.PictureBox()
        Me.Picture_heb_panel3 = New System.Windows.Forms.PictureBox()
        Me.button_results_save = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox_creation_type = New System.Windows.Forms.GroupBox()
        Me.RadioButton_normal = New System.Windows.Forms.RadioButton()
        Me.RadioButton_fast = New System.Windows.Forms.RadioButton()
        Me.Label_affiliated = New System.Windows.Forms.Label()
        Me.PictureBox02 = New System.Windows.Forms.PictureBox()
        Me.PictureBox01 = New System.Windows.Forms.PictureBox()
        Me.Button_Run_ADINA = New System.Windows.Forms.Button()
        Me.Button_feed_ADINA = New System.Windows.Forms.Button()
        Me.RichTextBox_model_qualify = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox_adina_msg = New System.Windows.Forms.RichTextBox()
        Me.Picture_eng_panel4 = New System.Windows.Forms.PictureBox()
        Me.Picture_heb_panel4 = New System.Windows.Forms.PictureBox()
        Me.Label_Adina = New System.Windows.Forms.Label()
        Me.ImageList_model = New System.Windows.Forms.ImageList(Me.components)
        Me.SplitContainer = New System.Windows.Forms.SplitContainer()
        Me.groupbox_plate_geo.SuspendLayout()
        CType(Me.numeric_t, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numeric_b, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numeric_a, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_stiffeners_number.SuspendLayout()
        CType(Me.numeric_short, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numeric_long, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_stiffeners.SuspendLayout()
        Me.GroupBox_stiffeners_geometric.SuspendLayout()
        Me.GroupBox_stiffeners_data.SuspendLayout()
        Me.groupbox_general.SuspendLayout()
        CType(Me.numeric_case_input, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Picture_eng_panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture_heb_panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_numeric_stiffeners.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox_figures, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_SD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture_eng_panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture_heb_panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox_choose_language.SuspendLayout()
        Me.GroupBox_update.SuspendLayout()
        CType(Me.Picture_eng_panel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture_heb_panel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.GroupBox_creation_type.SuspendLayout()
        CType(Me.PictureBox02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox01, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture_eng_panel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture_heb_panel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer.Panel1.SuspendLayout()
        Me.SplitContainer.Panel2.SuspendLayout()
        Me.SplitContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupbox_plate_geo
        '
        Me.groupbox_plate_geo.Controls.Add(Me.Button_view_parameters)
        Me.groupbox_plate_geo.Controls.Add(Me.label_unit_mm01)
        Me.groupbox_plate_geo.Controls.Add(Me.label_unit_m02)
        Me.groupbox_plate_geo.Controls.Add(Me.label_unit_m01)
        Me.groupbox_plate_geo.Controls.Add(Me.numeric_t)
        Me.groupbox_plate_geo.Controls.Add(Me.numeric_b)
        Me.groupbox_plate_geo.Controls.Add(Me.numeric_a)
        Me.groupbox_plate_geo.Controls.Add(Me.label_t)
        Me.groupbox_plate_geo.Controls.Add(Me.label_b)
        Me.groupbox_plate_geo.Controls.Add(Me.label_a)
        Me.groupbox_plate_geo.Font = New System.Drawing.Font("David", 12.0!)
        Me.groupbox_plate_geo.Location = New System.Drawing.Point(9, 59)
        Me.groupbox_plate_geo.Name = "groupbox_plate_geo"
        Me.groupbox_plate_geo.Size = New System.Drawing.Size(339, 172)
        Me.groupbox_plate_geo.TabIndex = 41
        Me.groupbox_plate_geo.TabStop = False
        Me.groupbox_plate_geo.Text = "Plate Geometry"
        '
        'Button_view_parameters
        '
        Me.Button_view_parameters.Location = New System.Drawing.Point(11, 119)
        Me.Button_view_parameters.Name = "Button_view_parameters"
        Me.Button_view_parameters.Size = New System.Drawing.Size(317, 46)
        Me.Button_view_parameters.TabIndex = 42
        Me.Button_view_parameters.Text = "View model parameters"
        Me.Button_view_parameters.UseVisualStyleBackColor = True
        '
        'label_unit_mm01
        '
        Me.label_unit_mm01.AutoEllipsis = True
        Me.label_unit_mm01.Font = New System.Drawing.Font("David", 10.8!)
        Me.label_unit_mm01.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label_unit_mm01.Location = New System.Drawing.Point(267, 88)
        Me.label_unit_mm01.Name = "label_unit_mm01"
        Me.label_unit_mm01.Size = New System.Drawing.Size(66, 25)
        Me.label_unit_mm01.TabIndex = 41
        Me.label_unit_mm01.Text = "[mm]"
        Me.label_unit_mm01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label_unit_m02
        '
        Me.label_unit_m02.AutoEllipsis = True
        Me.label_unit_m02.Font = New System.Drawing.Font("David", 10.8!)
        Me.label_unit_m02.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label_unit_m02.Location = New System.Drawing.Point(267, 56)
        Me.label_unit_m02.Name = "label_unit_m02"
        Me.label_unit_m02.Size = New System.Drawing.Size(66, 25)
        Me.label_unit_m02.TabIndex = 40
        Me.label_unit_m02.Text = "[m]"
        Me.label_unit_m02.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label_unit_m01
        '
        Me.label_unit_m01.AutoEllipsis = True
        Me.label_unit_m01.Font = New System.Drawing.Font("David", 10.8!)
        Me.label_unit_m01.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label_unit_m01.Location = New System.Drawing.Point(267, 25)
        Me.label_unit_m01.Name = "label_unit_m01"
        Me.label_unit_m01.Size = New System.Drawing.Size(66, 25)
        Me.label_unit_m01.TabIndex = 39
        Me.label_unit_m01.Text = "[m]"
        Me.label_unit_m01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'numeric_t
        '
        Me.numeric_t.DecimalPlaces = 2
        Me.numeric_t.Font = New System.Drawing.Font("David", 10.8!)
        Me.numeric_t.Location = New System.Drawing.Point(190, 88)
        Me.numeric_t.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.numeric_t.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.numeric_t.Name = "numeric_t"
        Me.numeric_t.Size = New System.Drawing.Size(64, 25)
        Me.numeric_t.TabIndex = 11
        Me.numeric_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numeric_t.Value = New Decimal(New Integer() {1, 0, 0, 131072})
        '
        'numeric_b
        '
        Me.numeric_b.DecimalPlaces = 2
        Me.numeric_b.Font = New System.Drawing.Font("David", 10.8!)
        Me.numeric_b.Location = New System.Drawing.Point(190, 56)
        Me.numeric_b.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.numeric_b.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.numeric_b.Name = "numeric_b"
        Me.numeric_b.Size = New System.Drawing.Size(64, 25)
        Me.numeric_b.TabIndex = 9
        Me.numeric_b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numeric_b.Value = New Decimal(New Integer() {1, 0, 0, 131072})
        '
        'numeric_a
        '
        Me.numeric_a.DecimalPlaces = 2
        Me.numeric_a.Font = New System.Drawing.Font("David", 10.8!)
        Me.numeric_a.Location = New System.Drawing.Point(190, 25)
        Me.numeric_a.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.numeric_a.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.numeric_a.Name = "numeric_a"
        Me.numeric_a.Size = New System.Drawing.Size(64, 25)
        Me.numeric_a.TabIndex = 7
        Me.numeric_a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numeric_a.Value = New Decimal(New Integer() {1, 0, 0, 131072})
        '
        'label_t
        '
        Me.label_t.AutoEllipsis = True
        Me.label_t.Font = New System.Drawing.Font("David", 10.8!)
        Me.label_t.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label_t.Location = New System.Drawing.Point(7, 88)
        Me.label_t.Name = "label_t"
        Me.label_t.Size = New System.Drawing.Size(165, 25)
        Me.label_t.TabIndex = 12
        Me.label_t.Text = "Thickness t"
        Me.label_t.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label_b
        '
        Me.label_b.AutoEllipsis = True
        Me.label_b.Font = New System.Drawing.Font("David", 10.8!)
        Me.label_b.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label_b.Location = New System.Drawing.Point(7, 56)
        Me.label_b.Name = "label_b"
        Me.label_b.Size = New System.Drawing.Size(165, 25)
        Me.label_b.TabIndex = 10
        Me.label_b.Text = "רוחב b"
        Me.label_b.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label_a
        '
        Me.label_a.AutoEllipsis = True
        Me.label_a.Font = New System.Drawing.Font("David", 10.8!)
        Me.label_a.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label_a.Location = New System.Drawing.Point(7, 25)
        Me.label_a.Name = "label_a"
        Me.label_a.Size = New System.Drawing.Size(165, 25)
        Me.label_a.TabIndex = 8
        Me.label_a.Text = "אורך a"
        Me.label_a.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label_title
        '
        Me.label_title.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label_title.AutoEllipsis = True
        Me.label_title.Font = New System.Drawing.Font("David", 22.2!, System.Drawing.FontStyle.Underline)
        Me.label_title.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label_title.Location = New System.Drawing.Point(8, 8)
        Me.label_title.Name = "label_title"
        Me.label_title.Size = New System.Drawing.Size(707, 48)
        Me.label_title.TabIndex = 42
        Me.label_title.Text = "Results"
        Me.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox_stiffeners_number
        '
        Me.GroupBox_stiffeners_number.Controls.Add(Me.numeric_short)
        Me.GroupBox_stiffeners_number.Controls.Add(Me.numeric_long)
        Me.GroupBox_stiffeners_number.Controls.Add(Me.label_short)
        Me.GroupBox_stiffeners_number.Controls.Add(Me.label_long)
        Me.GroupBox_stiffeners_number.Font = New System.Drawing.Font("David", 12.0!)
        Me.GroupBox_stiffeners_number.Location = New System.Drawing.Point(136, 19)
        Me.GroupBox_stiffeners_number.Name = "GroupBox_stiffeners_number"
        Me.GroupBox_stiffeners_number.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox_stiffeners_number.Size = New System.Drawing.Size(191, 96)
        Me.GroupBox_stiffeners_number.TabIndex = 43
        Me.GroupBox_stiffeners_number.TabStop = False
        '
        'numeric_short
        '
        Me.numeric_short.Font = New System.Drawing.Font("David", 10.8!)
        Me.numeric_short.Location = New System.Drawing.Point(5, 66)
        Me.numeric_short.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.numeric_short.Name = "numeric_short"
        Me.numeric_short.Size = New System.Drawing.Size(53, 25)
        Me.numeric_short.TabIndex = 9
        Me.numeric_short.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numeric_short.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numeric_long
        '
        Me.numeric_long.Font = New System.Drawing.Font("David", 10.8!)
        Me.numeric_long.Location = New System.Drawing.Point(5, 30)
        Me.numeric_long.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.numeric_long.Name = "numeric_long"
        Me.numeric_long.Size = New System.Drawing.Size(51, 25)
        Me.numeric_long.TabIndex = 7
        Me.numeric_long.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numeric_long.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'label_short
        '
        Me.label_short.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label_short.AutoEllipsis = True
        Me.label_short.Font = New System.Drawing.Font("David", 10.8!)
        Me.label_short.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label_short.Location = New System.Drawing.Point(63, 66)
        Me.label_short.Name = "label_short"
        Me.label_short.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.label_short.Size = New System.Drawing.Size(118, 25)
        Me.label_short.TabIndex = 10
        Me.label_short.Text = "Transverses"
        Me.label_short.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label_long
        '
        Me.label_long.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label_long.AutoEllipsis = True
        Me.label_long.Font = New System.Drawing.Font("David", 10.8!)
        Me.label_long.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label_long.Location = New System.Drawing.Point(63, 30)
        Me.label_long.Name = "label_long"
        Me.label_long.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.label_long.Size = New System.Drawing.Size(118, 25)
        Me.label_long.TabIndex = 8
        Me.label_long.Text = "Longitudinals"
        Me.label_long.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox_stiffeners
        '
        Me.GroupBox_stiffeners.Controls.Add(Me.GroupBox_stiffeners_geometric)
        Me.GroupBox_stiffeners.Controls.Add(Me.GroupBox_stiffeners_number)
        Me.GroupBox_stiffeners.Controls.Add(Me.GroupBox_stiffeners_data)
        Me.GroupBox_stiffeners.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.GroupBox_stiffeners.Location = New System.Drawing.Point(377, 237)
        Me.GroupBox_stiffeners.Name = "GroupBox_stiffeners"
        Me.GroupBox_stiffeners.Size = New System.Drawing.Size(374, 408)
        Me.GroupBox_stiffeners.TabIndex = 44
        Me.GroupBox_stiffeners.TabStop = False
        Me.GroupBox_stiffeners.Text = "Stiffeners"
        '
        'GroupBox_stiffeners_geometric
        '
        Me.GroupBox_stiffeners_geometric.Controls.Add(Me.textbox_geo_type)
        Me.GroupBox_stiffeners_geometric.Controls.Add(Me.Label_geometric)
        Me.GroupBox_stiffeners_geometric.Font = New System.Drawing.Font("David", 13.8!)
        Me.GroupBox_stiffeners_geometric.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox_stiffeners_geometric.Name = "GroupBox_stiffeners_geometric"
        Me.GroupBox_stiffeners_geometric.Size = New System.Drawing.Size(125, 96)
        Me.GroupBox_stiffeners_geometric.TabIndex = 49
        Me.GroupBox_stiffeners_geometric.TabStop = False
        '
        'textbox_geo_type
        '
        Me.textbox_geo_type.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.textbox_geo_type.Location = New System.Drawing.Point(36, 62)
        Me.textbox_geo_type.Name = "textbox_geo_type"
        Me.textbox_geo_type.ReadOnly = True
        Me.textbox_geo_type.Size = New System.Drawing.Size(52, 27)
        Me.textbox_geo_type.TabIndex = 51
        Me.textbox_geo_type.Text = "1"
        Me.textbox_geo_type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_geometric
        '
        Me.Label_geometric.AutoEllipsis = True
        Me.Label_geometric.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_geometric.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_geometric.Location = New System.Drawing.Point(4, 20)
        Me.Label_geometric.Name = "Label_geometric"
        Me.Label_geometric.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label_geometric.Size = New System.Drawing.Size(120, 40)
        Me.Label_geometric.TabIndex = 45
        Me.Label_geometric.Text = "Geometric Configuration"
        Me.Label_geometric.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox_stiffeners_data
        '
        Me.GroupBox_stiffeners_data.Controls.Add(Me.Button_data_change)
        Me.GroupBox_stiffeners_data.Controls.Add(Me.Label_data_unit)
        Me.GroupBox_stiffeners_data.Controls.Add(Me.Button_data_more)
        Me.GroupBox_stiffeners_data.Controls.Add(Me.TextBox_b)
        Me.GroupBox_stiffeners_data.Controls.Add(Me.Label_transverse01)
        Me.GroupBox_stiffeners_data.Controls.Add(Me.TextBox_nb)
        Me.GroupBox_stiffeners_data.Controls.Add(Me.Label_non_central02)
        Me.GroupBox_stiffeners_data.Controls.Add(Me.Label_central02)
        Me.GroupBox_stiffeners_data.Controls.Add(Me.TextBox_a)
        Me.GroupBox_stiffeners_data.Controls.Add(Me.Label_longitudinals01)
        Me.GroupBox_stiffeners_data.Controls.Add(Me.Label_non_central01)
        Me.GroupBox_stiffeners_data.Controls.Add(Me.Label_central01)
        Me.GroupBox_stiffeners_data.Controls.Add(Me.TextBox_na)
        Me.GroupBox_stiffeners_data.Controls.Add(Me.data_units)
        Me.GroupBox_stiffeners_data.Font = New System.Drawing.Font("David", 12.0!)
        Me.GroupBox_stiffeners_data.Location = New System.Drawing.Point(8, 120)
        Me.GroupBox_stiffeners_data.Name = "GroupBox_stiffeners_data"
        Me.GroupBox_stiffeners_data.Size = New System.Drawing.Size(319, 284)
        Me.GroupBox_stiffeners_data.TabIndex = 46
        Me.GroupBox_stiffeners_data.TabStop = False
        Me.GroupBox_stiffeners_data.Text = "Moment of Inertia"
        '
        'Button_data_change
        '
        Me.Button_data_change.AutoEllipsis = True
        Me.Button_data_change.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Button_data_change.Location = New System.Drawing.Point(224, 27)
        Me.Button_data_change.Name = "Button_data_change"
        Me.Button_data_change.Size = New System.Drawing.Size(85, 28)
        Me.Button_data_change.TabIndex = 56
        Me.Button_data_change.Text = "שינוי"
        '
        'Label_data_unit
        '
        Me.Label_data_unit.AutoEllipsis = True
        Me.Label_data_unit.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_data_unit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_data_unit.Location = New System.Drawing.Point(12, 30)
        Me.Label_data_unit.Name = "Label_data_unit"
        Me.Label_data_unit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_data_unit.Size = New System.Drawing.Size(110, 25)
        Me.Label_data_unit.TabIndex = 55
        Me.Label_data_unit.Text = "יחידות:"
        Me.Label_data_unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button_data_more
        '
        Me.Button_data_more.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Button_data_more.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_data_more.Location = New System.Drawing.Point(96, 246)
        Me.Button_data_more.Name = "Button_data_more"
        Me.Button_data_more.Size = New System.Drawing.Size(104, 32)
        Me.Button_data_more.TabIndex = 19
        Me.Button_data_more.Text = "More Data"
        '
        'TextBox_b
        '
        Me.TextBox_b.Font = New System.Drawing.Font("David", 10.8!)
        Me.TextBox_b.Location = New System.Drawing.Point(202, 180)
        Me.TextBox_b.Name = "TextBox_b"
        Me.TextBox_b.ReadOnly = True
        Me.TextBox_b.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox_b.Size = New System.Drawing.Size(104, 25)
        Me.TextBox_b.TabIndex = 18
        Me.TextBox_b.Text = "0"
        Me.TextBox_b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_transverse01
        '
        Me.Label_transverse01.AutoEllipsis = True
        Me.Label_transverse01.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Underline)
        Me.Label_transverse01.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_transverse01.Location = New System.Drawing.Point(8, 152)
        Me.Label_transverse01.Name = "Label_transverse01"
        Me.Label_transverse01.Size = New System.Drawing.Size(301, 21)
        Me.Label_transverse01.TabIndex = 10
        Me.Label_transverse01.Text = "רוחביים"
        Me.Label_transverse01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_nb
        '
        Me.TextBox_nb.Font = New System.Drawing.Font("David", 10.8!)
        Me.TextBox_nb.Location = New System.Drawing.Point(202, 210)
        Me.TextBox_nb.Name = "TextBox_nb"
        Me.TextBox_nb.ReadOnly = True
        Me.TextBox_nb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox_nb.Size = New System.Drawing.Size(104, 25)
        Me.TextBox_nb.TabIndex = 17
        Me.TextBox_nb.Text = "0"
        Me.TextBox_nb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_non_central02
        '
        Me.Label_non_central02.AutoEllipsis = True
        Me.Label_non_central02.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_non_central02.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_non_central02.Location = New System.Drawing.Point(9, 210)
        Me.Label_non_central02.Name = "Label_non_central02"
        Me.Label_non_central02.Size = New System.Drawing.Size(187, 25)
        Me.Label_non_central02.TabIndex = 15
        Me.Label_non_central02.Text = "לא מרכזיים"
        Me.Label_non_central02.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_central02
        '
        Me.Label_central02.AutoEllipsis = True
        Me.Label_central02.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_central02.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_central02.Location = New System.Drawing.Point(9, 180)
        Me.Label_central02.Name = "Label_central02"
        Me.Label_central02.Size = New System.Drawing.Size(187, 25)
        Me.Label_central02.TabIndex = 14
        Me.Label_central02.Text = "מרכזי"
        Me.Label_central02.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_a
        '
        Me.TextBox_a.Font = New System.Drawing.Font("David", 10.8!)
        Me.TextBox_a.Location = New System.Drawing.Point(202, 90)
        Me.TextBox_a.Name = "TextBox_a"
        Me.TextBox_a.ReadOnly = True
        Me.TextBox_a.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox_a.Size = New System.Drawing.Size(108, 25)
        Me.TextBox_a.TabIndex = 16
        Me.TextBox_a.Text = "0"
        Me.TextBox_a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_longitudinals01
        '
        Me.Label_longitudinals01.AutoEllipsis = True
        Me.Label_longitudinals01.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Underline)
        Me.Label_longitudinals01.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_longitudinals01.Location = New System.Drawing.Point(8, 64)
        Me.Label_longitudinals01.Name = "Label_longitudinals01"
        Me.Label_longitudinals01.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_longitudinals01.Size = New System.Drawing.Size(301, 21)
        Me.Label_longitudinals01.TabIndex = 8
        Me.Label_longitudinals01.Text = "Longitudinals"
        Me.Label_longitudinals01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_non_central01
        '
        Me.Label_non_central01.AutoEllipsis = True
        Me.Label_non_central01.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_non_central01.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_non_central01.Location = New System.Drawing.Point(9, 120)
        Me.Label_non_central01.Name = "Label_non_central01"
        Me.Label_non_central01.Size = New System.Drawing.Size(187, 25)
        Me.Label_non_central01.TabIndex = 13
        Me.Label_non_central01.Text = "לא מרכזיים"
        Me.Label_non_central01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_central01
        '
        Me.Label_central01.AutoEllipsis = True
        Me.Label_central01.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_central01.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_central01.Location = New System.Drawing.Point(9, 90)
        Me.Label_central01.Name = "Label_central01"
        Me.Label_central01.Size = New System.Drawing.Size(187, 25)
        Me.Label_central01.TabIndex = 12
        Me.Label_central01.Text = "מרכזי"
        Me.Label_central01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_na
        '
        Me.TextBox_na.Font = New System.Drawing.Font("David", 10.8!)
        Me.TextBox_na.Location = New System.Drawing.Point(202, 120)
        Me.TextBox_na.Name = "TextBox_na"
        Me.TextBox_na.ReadOnly = True
        Me.TextBox_na.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox_na.Size = New System.Drawing.Size(108, 25)
        Me.TextBox_na.TabIndex = 11
        Me.TextBox_na.Text = "0"
        Me.TextBox_na.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'data_units
        '
        Me.data_units.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.data_units.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.data_units.Font = New System.Drawing.Font("David", 10.8!)
        Me.data_units.ItemHeight = 17
        Me.data_units.Items.AddRange(New Object() {"[m^4]", "[cm^4]", "[mm^4]"})
        Me.data_units.Location = New System.Drawing.Point(116, 30)
        Me.data_units.Name = "data_units"
        Me.data_units.Size = New System.Drawing.Size(84, 25)
        Me.data_units.TabIndex = 54
        '
        'groupbox_general
        '
        Me.groupbox_general.Controls.Add(Me.Label_GPa)
        Me.groupbox_general.Controls.Add(Me.button_BC_select)
        Me.groupbox_general.Controls.Add(Me.combobox_P_units)
        Me.groupbox_general.Controls.Add(Me.textbox_P_input)
        Me.groupbox_general.Controls.Add(Me.textbox_ni_input)
        Me.groupbox_general.Controls.Add(Me.textbox_E_input)
        Me.groupbox_general.Controls.Add(Me.Label_pressure)
        Me.groupbox_general.Controls.Add(Me.label_ni)
        Me.groupbox_general.Controls.Add(Me.Label_E)
        Me.groupbox_general.Controls.Add(Me.numeric_case_input)
        Me.groupbox_general.Controls.Add(Me.Label_BC)
        Me.groupbox_general.Font = New System.Drawing.Font("David", 12.0!)
        Me.groupbox_general.Location = New System.Drawing.Point(377, 59)
        Me.groupbox_general.Name = "groupbox_general"
        Me.groupbox_general.Size = New System.Drawing.Size(376, 172)
        Me.groupbox_general.TabIndex = 45
        Me.groupbox_general.TabStop = False
        Me.groupbox_general.Text = "General Properties"
        '
        'Label_GPa
        '
        Me.Label_GPa.AutoEllipsis = True
        Me.Label_GPa.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_GPa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_GPa.Location = New System.Drawing.Point(318, 80)
        Me.Label_GPa.Name = "Label_GPa"
        Me.Label_GPa.Size = New System.Drawing.Size(52, 25)
        Me.Label_GPa.TabIndex = 54
        Me.Label_GPa.Text = "[GPa]"
        Me.Label_GPa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'button_BC_select
        '
        Me.button_BC_select.AutoEllipsis = True
        Me.button_BC_select.Font = New System.Drawing.Font("David", 10.8!)
        Me.button_BC_select.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.button_BC_select.Location = New System.Drawing.Point(293, 138)
        Me.button_BC_select.Name = "button_BC_select"
        Me.button_BC_select.Size = New System.Drawing.Size(81, 28)
        Me.button_BC_select.TabIndex = 53
        Me.button_BC_select.Text = "change"
        '
        'combobox_P_units
        '
        Me.combobox_P_units.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_P_units.Font = New System.Drawing.Font("David", 10.8!)
        Me.combobox_P_units.ItemHeight = 17
        Me.combobox_P_units.Items.AddRange(New Object() {"Pa", "Kpa", "Mpa"})
        Me.combobox_P_units.Location = New System.Drawing.Point(289, 30)
        Me.combobox_P_units.Name = "combobox_P_units"
        Me.combobox_P_units.Size = New System.Drawing.Size(81, 25)
        Me.combobox_P_units.TabIndex = 52
        '
        'textbox_P_input
        '
        Me.textbox_P_input.Font = New System.Drawing.Font("David", 10.8!)
        Me.textbox_P_input.Location = New System.Drawing.Point(214, 30)
        Me.textbox_P_input.Name = "textbox_P_input"
        Me.textbox_P_input.Size = New System.Drawing.Size(52, 25)
        Me.textbox_P_input.TabIndex = 51
        Me.textbox_P_input.Text = "0"
        Me.textbox_P_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textbox_ni_input
        '
        Me.textbox_ni_input.Font = New System.Drawing.Font("David", 10.8!)
        Me.textbox_ni_input.Location = New System.Drawing.Point(214, 110)
        Me.textbox_ni_input.Name = "textbox_ni_input"
        Me.textbox_ni_input.Size = New System.Drawing.Size(52, 25)
        Me.textbox_ni_input.TabIndex = 50
        Me.textbox_ni_input.Text = "0"
        Me.textbox_ni_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textbox_E_input
        '
        Me.textbox_E_input.Font = New System.Drawing.Font("David", 10.8!)
        Me.textbox_E_input.Location = New System.Drawing.Point(214, 80)
        Me.textbox_E_input.Name = "textbox_E_input"
        Me.textbox_E_input.Size = New System.Drawing.Size(52, 25)
        Me.textbox_E_input.TabIndex = 49
        Me.textbox_E_input.Text = "0"
        Me.textbox_E_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_pressure
        '
        Me.Label_pressure.AutoEllipsis = True
        Me.Label_pressure.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_pressure.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_pressure.Location = New System.Drawing.Point(13, 24)
        Me.Label_pressure.Name = "Label_pressure"
        Me.Label_pressure.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_pressure.Size = New System.Drawing.Size(180, 44)
        Me.Label_pressure.TabIndex = 48
        Me.Label_pressure.Text = "Uniform pressure acting on plate"
        Me.Label_pressure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label_ni
        '
        Me.label_ni.AutoEllipsis = True
        Me.label_ni.Font = New System.Drawing.Font("David", 10.8!)
        Me.label_ni.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label_ni.Location = New System.Drawing.Point(13, 109)
        Me.label_ni.Name = "label_ni"
        Me.label_ni.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.label_ni.Size = New System.Drawing.Size(183, 25)
        Me.label_ni.TabIndex = 47
        Me.label_ni.Text = "Poisson's Ratio"
        Me.label_ni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_E
        '
        Me.Label_E.AutoEllipsis = True
        Me.Label_E.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_E.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_E.Location = New System.Drawing.Point(13, 79)
        Me.Label_E.Name = "Label_E"
        Me.Label_E.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_E.Size = New System.Drawing.Size(183, 25)
        Me.Label_E.TabIndex = 46
        Me.Label_E.Text = "Modulus of Elasticity"
        Me.Label_E.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'numeric_case_input
        '
        Me.numeric_case_input.Font = New System.Drawing.Font("David", 10.8!)
        Me.numeric_case_input.Location = New System.Drawing.Point(214, 140)
        Me.numeric_case_input.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.numeric_case_input.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numeric_case_input.Name = "numeric_case_input"
        Me.numeric_case_input.Size = New System.Drawing.Size(52, 25)
        Me.numeric_case_input.TabIndex = 45
        Me.numeric_case_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numeric_case_input.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label_BC
        '
        Me.Label_BC.AutoEllipsis = True
        Me.Label_BC.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_BC.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_BC.Location = New System.Drawing.Point(12, 140)
        Me.Label_BC.Name = "Label_BC"
        Me.Label_BC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_BC.Size = New System.Drawing.Size(180, 25)
        Me.Label_BC.TabIndex = 44
        Me.Label_BC.Text = "Boundary condition"
        Me.Label_BC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RichTextBox_result_for_saving
        '
        Me.RichTextBox_result_for_saving.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox_result_for_saving.BackColor = System.Drawing.Color.White
        Me.RichTextBox_result_for_saving.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.RichTextBox_result_for_saving.Location = New System.Drawing.Point(20, 295)
        Me.RichTextBox_result_for_saving.Name = "RichTextBox_result_for_saving"
        Me.RichTextBox_result_for_saving.ReadOnly = True
        Me.RichTextBox_result_for_saving.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RichTextBox_result_for_saving.Size = New System.Drawing.Size(720, 224)
        Me.RichTextBox_result_for_saving.TabIndex = 46
        Me.RichTextBox_result_for_saving.Text = ""
        Me.RichTextBox_result_for_saving.WordWrap = False
        '
        'Button_compute
        '
        Me.Button_compute.AutoEllipsis = True
        Me.Button_compute.Font = New System.Drawing.Font("David", 11.8!)
        Me.Button_compute.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_compute.Location = New System.Drawing.Point(21, 11)
        Me.Button_compute.Name = "Button_compute"
        Me.Button_compute.Size = New System.Drawing.Size(182, 45)
        Me.Button_compute.TabIndex = 47
        Me.Button_compute.Text = "Run calculation"
        '
        'Textbox_results
        '
        Me.Textbox_results.Font = New System.Drawing.Font("David", 28.2!)
        Me.Textbox_results.ForeColor = System.Drawing.Color.Gray
        Me.Textbox_results.Location = New System.Drawing.Point(460, 12)
        Me.Textbox_results.Name = "Textbox_results"
        Me.Textbox_results.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Textbox_results.Size = New System.Drawing.Size(244, 54)
        Me.Textbox_results.TabIndex = 54
        Me.Textbox_results.Text = "0.00 [mm]"
        Me.Textbox_results.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label_msg01
        '
        Me.label_msg01.AutoEllipsis = True
        Me.label_msg01.Font = New System.Drawing.Font("David", 11.8!)
        Me.label_msg01.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label_msg01.Location = New System.Drawing.Point(209, 9)
        Me.label_msg01.Name = "label_msg01"
        Me.label_msg01.Size = New System.Drawing.Size(241, 57)
        Me.label_msg01.TabIndex = 55
        Me.label_msg01.Text = "Maximum deflection at center of plate"
        Me.label_msg01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button_more_error
        '
        Me.Button_more_error.AutoEllipsis = True
        Me.Button_more_error.Font = New System.Drawing.Font("David", 10.8!)
        Me.Button_more_error.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_more_error.Location = New System.Drawing.Point(21, 64)
        Me.Button_more_error.Name = "Button_more_error"
        Me.Button_more_error.Size = New System.Drawing.Size(182, 45)
        Me.Button_more_error.TabIndex = 57
        Me.Button_more_error.Text = "הצגת האנליזות שבוצעו"
        Me.Button_more_error.Visible = False
        '
        'button_results_clear
        '
        Me.button_results_clear.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.button_results_clear.Font = New System.Drawing.Font("David", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.button_results_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_results_clear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.button_results_clear.Location = New System.Drawing.Point(203, 527)
        Me.button_results_clear.Name = "button_results_clear"
        Me.button_results_clear.Size = New System.Drawing.Size(100, 48)
        Me.button_results_clear.TabIndex = 58
        Me.button_results_clear.Text = "Clear"
        '
        'ListView_steps
        '
        Me.ListView_steps.AutoArrange = False
        Me.ListView_steps.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView_steps.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.ListView_steps.HideSelection = False
        ListViewItem5.Checked = True
        ListViewItem5.StateImageIndex = 1
        ListViewItem6.Checked = True
        ListViewItem6.StateImageIndex = 1
        ListViewItem7.Checked = True
        ListViewItem7.StateImageIndex = 1
        ListViewItem8.Checked = True
        ListViewItem8.StateImageIndex = 5
        Me.ListView_steps.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8})
        Me.ListView_steps.LargeImageList = Me.ImageList_listview
        Me.ListView_steps.Location = New System.Drawing.Point(0, 0)
        Me.ListView_steps.Name = "ListView_steps"
        Me.ListView_steps.Size = New System.Drawing.Size(159, 686)
        Me.ListView_steps.SmallImageList = Me.ImageList_listview
        Me.ListView_steps.TabIndex = 59
        Me.ListView_steps.UseCompatibleStateImageBehavior = False
        '
        'ImageList_listview
        '
        Me.ImageList_listview.ImageStream = CType(resources.GetObject("ImageList_listview.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_listview.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_listview.Images.SetKeyName(0, "")
        Me.ImageList_listview.Images.SetKeyName(1, "")
        Me.ImageList_listview.Images.SetKeyName(2, "")
        Me.ImageList_listview.Images.SetKeyName(3, "")
        Me.ImageList_listview.Images.SetKeyName(4, "")
        Me.ImageList_listview.Images.SetKeyName(5, "")
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.Picture_eng_panel1)
        Me.Panel1.Controls.Add(Me.Picture_heb_panel1)
        Me.Panel1.Controls.Add(Me.GroupBox_numeric_stiffeners)
        Me.Panel1.Controls.Add(Me.GroupBox_stiffeners)
        Me.Panel1.Controls.Add(Me.label_title)
        Me.Panel1.Controls.Add(Me.groupbox_general)
        Me.Panel1.Controls.Add(Me.groupbox_plate_geo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(763, 686)
        Me.Panel1.TabIndex = 60
        '
        'Picture_eng_panel1
        '
        Me.Picture_eng_panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Picture_eng_panel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Picture_eng_panel1.Image = Global.SPE.My.Resources.Resources.flag_english01
        Me.Picture_eng_panel1.Location = New System.Drawing.Point(721, 32)
        Me.Picture_eng_panel1.Name = "Picture_eng_panel1"
        Me.Picture_eng_panel1.Size = New System.Drawing.Size(32, 16)
        Me.Picture_eng_panel1.TabIndex = 48
        Me.Picture_eng_panel1.TabStop = False
        '
        'Picture_heb_panel1
        '
        Me.Picture_heb_panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Picture_heb_panel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Picture_heb_panel1.Image = Global.SPE.My.Resources.Resources.flag_hebrew01
        Me.Picture_heb_panel1.Location = New System.Drawing.Point(721, 8)
        Me.Picture_heb_panel1.Name = "Picture_heb_panel1"
        Me.Picture_heb_panel1.Size = New System.Drawing.Size(32, 20)
        Me.Picture_heb_panel1.TabIndex = 47
        Me.Picture_heb_panel1.TabStop = False
        '
        'GroupBox_numeric_stiffeners
        '
        Me.GroupBox_numeric_stiffeners.Controls.Add(Me.Label_mm_msg)
        Me.GroupBox_numeric_stiffeners.Controls.Add(Me.CheckBox_Inb)
        Me.GroupBox_numeric_stiffeners.Controls.Add(Me.CheckBox_Ib)
        Me.GroupBox_numeric_stiffeners.Controls.Add(Me.CheckBox_Ina)
        Me.GroupBox_numeric_stiffeners.Controls.Add(Me.CheckBox_Ia)
        Me.GroupBox_numeric_stiffeners.Controls.Add(Me.TextBox_Inb_d)
        Me.GroupBox_numeric_stiffeners.Controls.Add(Me.TextBox_Ina_d)
        Me.GroupBox_numeric_stiffeners.Controls.Add(Me.TextBox_Ia_d)
        Me.GroupBox_numeric_stiffeners.Controls.Add(Me.TextBox_Ib_d)
        Me.GroupBox_numeric_stiffeners.Controls.Add(Me.Button_save_stiffeners)
        Me.GroupBox_numeric_stiffeners.Controls.Add(Me.TextBox_Inb_b)
        Me.GroupBox_numeric_stiffeners.Controls.Add(Me.TextBox_Ina_b)
        Me.GroupBox_numeric_stiffeners.Controls.Add(Me.TextBox_Ia_b)
        Me.GroupBox_numeric_stiffeners.Controls.Add(Me.TextBox_Ib_b)
        Me.GroupBox_numeric_stiffeners.Controls.Add(Me.Label_b_change)
        Me.GroupBox_numeric_stiffeners.Controls.Add(Me.Label_d_change)
        Me.GroupBox_numeric_stiffeners.Controls.Add(Me.Label_longitudinals02)
        Me.GroupBox_numeric_stiffeners.Controls.Add(Me.Label_transverse02)
        Me.GroupBox_numeric_stiffeners.Controls.Add(Me.Label_non_central04)
        Me.GroupBox_numeric_stiffeners.Controls.Add(Me.Label_central04)
        Me.GroupBox_numeric_stiffeners.Controls.Add(Me.Label_non_central03)
        Me.GroupBox_numeric_stiffeners.Controls.Add(Me.Label_central03)
        Me.GroupBox_numeric_stiffeners.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.GroupBox_numeric_stiffeners.Location = New System.Drawing.Point(9, 237)
        Me.GroupBox_numeric_stiffeners.Name = "GroupBox_numeric_stiffeners"
        Me.GroupBox_numeric_stiffeners.Size = New System.Drawing.Size(339, 408)
        Me.GroupBox_numeric_stiffeners.TabIndex = 46
        Me.GroupBox_numeric_stiffeners.TabStop = False
        Me.GroupBox_numeric_stiffeners.Text = "Blade Stiffeners - Data Change"
        Me.GroupBox_numeric_stiffeners.Visible = False
        '
        'Label_mm_msg
        '
        Me.Label_mm_msg.AutoEllipsis = True
        Me.Label_mm_msg.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_mm_msg.ForeColor = System.Drawing.Color.Navy
        Me.Label_mm_msg.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_mm_msg.Location = New System.Drawing.Point(12, 325)
        Me.Label_mm_msg.Name = "Label_mm_msg"
        Me.Label_mm_msg.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label_mm_msg.Size = New System.Drawing.Size(314, 28)
        Me.Label_mm_msg.TabIndex = 82
        Me.Label_mm_msg.Text = "כל הערכים הינם במילימטרים"
        Me.Label_mm_msg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CheckBox_Inb
        '
        Me.CheckBox_Inb.AutoEllipsis = True
        Me.CheckBox_Inb.Checked = True
        Me.CheckBox_Inb.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_Inb.Font = New System.Drawing.Font("David", 10.8!)
        Me.CheckBox_Inb.Location = New System.Drawing.Point(12, 119)
        Me.CheckBox_Inb.Name = "CheckBox_Inb"
        Me.CheckBox_Inb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBox_Inb.Size = New System.Drawing.Size(314, 24)
        Me.CheckBox_Inb.TabIndex = 4
        Me.CheckBox_Inb.Text = "Non-Central Transverse Stiffeners"
        '
        'CheckBox_Ib
        '
        Me.CheckBox_Ib.AutoEllipsis = True
        Me.CheckBox_Ib.Checked = True
        Me.CheckBox_Ib.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_Ib.Font = New System.Drawing.Font("David", 10.8!)
        Me.CheckBox_Ib.Location = New System.Drawing.Point(12, 88)
        Me.CheckBox_Ib.Name = "CheckBox_Ib"
        Me.CheckBox_Ib.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBox_Ib.Size = New System.Drawing.Size(314, 24)
        Me.CheckBox_Ib.TabIndex = 3
        Me.CheckBox_Ib.Text = "Central Transverse Stiffener"
        '
        'CheckBox_Ina
        '
        Me.CheckBox_Ina.AutoEllipsis = True
        Me.CheckBox_Ina.Checked = True
        Me.CheckBox_Ina.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_Ina.Font = New System.Drawing.Font("David", 10.8!)
        Me.CheckBox_Ina.Location = New System.Drawing.Point(12, 60)
        Me.CheckBox_Ina.Name = "CheckBox_Ina"
        Me.CheckBox_Ina.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBox_Ina.Size = New System.Drawing.Size(314, 24)
        Me.CheckBox_Ina.TabIndex = 2
        Me.CheckBox_Ina.Text = "Non-Central Longitudinal Stiffeners"
        '
        'CheckBox_Ia
        '
        Me.CheckBox_Ia.AutoEllipsis = True
        Me.CheckBox_Ia.Checked = True
        Me.CheckBox_Ia.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_Ia.Font = New System.Drawing.Font("David", 10.8!)
        Me.CheckBox_Ia.Location = New System.Drawing.Point(12, 28)
        Me.CheckBox_Ia.Name = "CheckBox_Ia"
        Me.CheckBox_Ia.Size = New System.Drawing.Size(314, 24)
        Me.CheckBox_Ia.TabIndex = 1
        Me.CheckBox_Ia.Text = "Central Longitudinal Stiffener"
        '
        'TextBox_Inb_d
        '
        Me.TextBox_Inb_d.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox_Inb_d.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TextBox_Inb_d.Location = New System.Drawing.Point(177, 292)
        Me.TextBox_Inb_d.Name = "TextBox_Inb_d"
        Me.TextBox_Inb_d.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox_Inb_d.Size = New System.Drawing.Size(68, 25)
        Me.TextBox_Inb_d.TabIndex = 12
        Me.TextBox_Inb_d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_Ina_d
        '
        Me.TextBox_Ina_d.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox_Ina_d.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TextBox_Ina_d.Location = New System.Drawing.Point(177, 200)
        Me.TextBox_Ina_d.Name = "TextBox_Ina_d"
        Me.TextBox_Ina_d.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox_Ina_d.Size = New System.Drawing.Size(68, 25)
        Me.TextBox_Ina_d.TabIndex = 8
        Me.TextBox_Ina_d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_Ia_d
        '
        Me.TextBox_Ia_d.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox_Ia_d.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TextBox_Ia_d.Location = New System.Drawing.Point(177, 172)
        Me.TextBox_Ia_d.Name = "TextBox_Ia_d"
        Me.TextBox_Ia_d.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox_Ia_d.Size = New System.Drawing.Size(68, 25)
        Me.TextBox_Ia_d.TabIndex = 6
        Me.TextBox_Ia_d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_Ib_d
        '
        Me.TextBox_Ib_d.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox_Ib_d.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TextBox_Ib_d.Location = New System.Drawing.Point(177, 264)
        Me.TextBox_Ib_d.Name = "TextBox_Ib_d"
        Me.TextBox_Ib_d.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox_Ib_d.Size = New System.Drawing.Size(68, 25)
        Me.TextBox_Ib_d.TabIndex = 10
        Me.TextBox_Ib_d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button_save_stiffeners
        '
        Me.Button_save_stiffeners.Image = CType(resources.GetObject("Button_save_stiffeners.Image"), System.Drawing.Image)
        Me.Button_save_stiffeners.Location = New System.Drawing.Point(127, 358)
        Me.Button_save_stiffeners.Name = "Button_save_stiffeners"
        Me.Button_save_stiffeners.Size = New System.Drawing.Size(64, 36)
        Me.Button_save_stiffeners.TabIndex = 13
        '
        'TextBox_Inb_b
        '
        Me.TextBox_Inb_b.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox_Inb_b.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TextBox_Inb_b.Location = New System.Drawing.Point(260, 292)
        Me.TextBox_Inb_b.Name = "TextBox_Inb_b"
        Me.TextBox_Inb_b.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox_Inb_b.Size = New System.Drawing.Size(68, 25)
        Me.TextBox_Inb_b.TabIndex = 11
        Me.TextBox_Inb_b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_Ina_b
        '
        Me.TextBox_Ina_b.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox_Ina_b.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TextBox_Ina_b.Location = New System.Drawing.Point(260, 200)
        Me.TextBox_Ina_b.Name = "TextBox_Ina_b"
        Me.TextBox_Ina_b.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox_Ina_b.Size = New System.Drawing.Size(68, 25)
        Me.TextBox_Ina_b.TabIndex = 7
        Me.TextBox_Ina_b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_Ia_b
        '
        Me.TextBox_Ia_b.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox_Ia_b.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TextBox_Ia_b.Location = New System.Drawing.Point(260, 172)
        Me.TextBox_Ia_b.Name = "TextBox_Ia_b"
        Me.TextBox_Ia_b.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox_Ia_b.Size = New System.Drawing.Size(68, 25)
        Me.TextBox_Ia_b.TabIndex = 5
        Me.TextBox_Ia_b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_Ib_b
        '
        Me.TextBox_Ib_b.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox_Ib_b.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TextBox_Ib_b.Location = New System.Drawing.Point(260, 264)
        Me.TextBox_Ib_b.Name = "TextBox_Ib_b"
        Me.TextBox_Ib_b.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox_Ib_b.Size = New System.Drawing.Size(68, 25)
        Me.TextBox_Ib_b.TabIndex = 9
        Me.TextBox_Ib_b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_b_change
        '
        Me.Label_b_change.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_b_change.AutoEllipsis = True
        Me.Label_b_change.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_b_change.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_b_change.Location = New System.Drawing.Point(247, 146)
        Me.Label_b_change.Name = "Label_b_change"
        Me.Label_b_change.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_b_change.Size = New System.Drawing.Size(93, 25)
        Me.Label_b_change.TabIndex = 80
        Me.Label_b_change.Text = "Thickness"
        Me.Label_b_change.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_d_change
        '
        Me.Label_d_change.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_d_change.AutoEllipsis = True
        Me.Label_d_change.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_d_change.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_d_change.Location = New System.Drawing.Point(173, 146)
        Me.Label_d_change.Name = "Label_d_change"
        Me.Label_d_change.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_d_change.Size = New System.Drawing.Size(69, 25)
        Me.Label_d_change.TabIndex = 81
        Me.Label_d_change.Text = "Height"
        Me.Label_d_change.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_longitudinals02
        '
        Me.Label_longitudinals02.AutoEllipsis = True
        Me.Label_longitudinals02.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_longitudinals02.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_longitudinals02.Location = New System.Drawing.Point(22, 146)
        Me.Label_longitudinals02.Name = "Label_longitudinals02"
        Me.Label_longitudinals02.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_longitudinals02.Size = New System.Drawing.Size(139, 25)
        Me.Label_longitudinals02.TabIndex = 27
        Me.Label_longitudinals02.Text = "Longitudinals"
        Me.Label_longitudinals02.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_transverse02
        '
        Me.Label_transverse02.AutoEllipsis = True
        Me.Label_transverse02.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_transverse02.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_transverse02.Location = New System.Drawing.Point(22, 233)
        Me.Label_transverse02.Name = "Label_transverse02"
        Me.Label_transverse02.Size = New System.Drawing.Size(140, 25)
        Me.Label_transverse02.TabIndex = 28
        Me.Label_transverse02.Text = "קצרים"
        Me.Label_transverse02.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_non_central04
        '
        Me.Label_non_central04.AutoEllipsis = True
        Me.Label_non_central04.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_non_central04.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_non_central04.Location = New System.Drawing.Point(22, 291)
        Me.Label_non_central04.Name = "Label_non_central04"
        Me.Label_non_central04.Size = New System.Drawing.Size(144, 25)
        Me.Label_non_central04.TabIndex = 32
        Me.Label_non_central04.Text = "משניים"
        Me.Label_non_central04.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_central04
        '
        Me.Label_central04.AutoEllipsis = True
        Me.Label_central04.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_central04.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_central04.Location = New System.Drawing.Point(22, 263)
        Me.Label_central04.Name = "Label_central04"
        Me.Label_central04.Size = New System.Drawing.Size(144, 25)
        Me.Label_central04.TabIndex = 31
        Me.Label_central04.Text = "מרכזי"
        Me.Label_central04.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_non_central03
        '
        Me.Label_non_central03.AutoEllipsis = True
        Me.Label_non_central03.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_non_central03.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_non_central03.Location = New System.Drawing.Point(22, 200)
        Me.Label_non_central03.Name = "Label_non_central03"
        Me.Label_non_central03.Size = New System.Drawing.Size(144, 25)
        Me.Label_non_central03.TabIndex = 30
        Me.Label_non_central03.Text = "משניים"
        Me.Label_non_central03.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_central03
        '
        Me.Label_central03.AutoEllipsis = True
        Me.Label_central03.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_central03.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_central03.Location = New System.Drawing.Point(22, 172)
        Me.Label_central03.Name = "Label_central03"
        Me.Label_central03.Size = New System.Drawing.Size(144, 25)
        Me.Label_central03.TabIndex = 29
        Me.Label_central03.Text = "מרכזי"
        Me.Label_central03.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.PictureBox_figures)
        Me.Panel2.Controls.Add(Me.NumericUpDown_SD)
        Me.Panel2.Controls.Add(Me.Picture_eng_panel2)
        Me.Panel2.Controls.Add(Me.Picture_heb_panel2)
        Me.Panel2.Controls.Add(Me.RichTextBox_results)
        Me.Panel2.Controls.Add(Me.Textbox_results)
        Me.Panel2.Controls.Add(Me.Button_more_error)
        Me.Panel2.Controls.Add(Me.Button_compute)
        Me.Panel2.Controls.Add(Me.label_msg01)
        Me.Panel2.Controls.Add(Me.Label_SD)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(763, 686)
        Me.Panel2.TabIndex = 62
        '
        'PictureBox_figures
        '
        Me.PictureBox_figures.Location = New System.Drawing.Point(18, 212)
        Me.PictureBox_figures.Name = "PictureBox_figures"
        Me.PictureBox_figures.Size = New System.Drawing.Size(685, 448)
        Me.PictureBox_figures.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_figures.TabIndex = 64
        Me.PictureBox_figures.TabStop = False
        '
        'NumericUpDown_SD
        '
        Me.NumericUpDown_SD.AutoSize = True
        Me.NumericUpDown_SD.Location = New System.Drawing.Point(656, 76)
        Me.NumericUpDown_SD.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.NumericUpDown_SD.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_SD.Name = "NumericUpDown_SD"
        Me.NumericUpDown_SD.Size = New System.Drawing.Size(48, 22)
        Me.NumericUpDown_SD.TabIndex = 62
        Me.NumericUpDown_SD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown_SD.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Picture_eng_panel2
        '
        Me.Picture_eng_panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Picture_eng_panel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Picture_eng_panel2.Image = Global.SPE.My.Resources.Resources.flag_english01
        Me.Picture_eng_panel2.Location = New System.Drawing.Point(721, 40)
        Me.Picture_eng_panel2.Name = "Picture_eng_panel2"
        Me.Picture_eng_panel2.Size = New System.Drawing.Size(32, 16)
        Me.Picture_eng_panel2.TabIndex = 61
        Me.Picture_eng_panel2.TabStop = False
        '
        'Picture_heb_panel2
        '
        Me.Picture_heb_panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Picture_heb_panel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Picture_heb_panel2.Image = Global.SPE.My.Resources.Resources.flag_hebrew01
        Me.Picture_heb_panel2.Location = New System.Drawing.Point(721, 16)
        Me.Picture_heb_panel2.Name = "Picture_heb_panel2"
        Me.Picture_heb_panel2.Size = New System.Drawing.Size(32, 20)
        Me.Picture_heb_panel2.TabIndex = 60
        Me.Picture_heb_panel2.TabStop = False
        '
        'RichTextBox_results
        '
        Me.RichTextBox_results.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox_results.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RichTextBox_results.ForeColor = System.Drawing.Color.Black
        Me.RichTextBox_results.Location = New System.Drawing.Point(18, 115)
        Me.RichTextBox_results.Name = "RichTextBox_results"
        Me.RichTextBox_results.ReadOnly = True
        Me.RichTextBox_results.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RichTextBox_results.Size = New System.Drawing.Size(686, 91)
        Me.RichTextBox_results.TabIndex = 58
        Me.RichTextBox_results.Text = "According to the FEA analyses that were performed, for unstiffened plates, all th" &
    "e relative errors between the analytic estimations and the FEA results are less " &
    "than 10 percents."
        Me.RichTextBox_results.Visible = False
        '
        'Label_SD
        '
        Me.Label_SD.AutoEllipsis = True
        Me.Label_SD.Font = New System.Drawing.Font("David", 11.8!)
        Me.Label_SD.Location = New System.Drawing.Point(207, 76)
        Me.Label_SD.Name = "Label_SD"
        Me.Label_SD.Size = New System.Drawing.Size(436, 22)
        Me.Label_SD.TabIndex = 63
        Me.Label_SD.Text = "Number of Significant digits:"
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.Controls.Add(Me.RichTextBox_result_for_saving)
        Me.Panel3.Controls.Add(Me.button_results_save_HTML)
        Me.Panel3.Controls.Add(Me.GroupBox_choose_language)
        Me.Panel3.Controls.Add(Me.Picture_eng_panel3)
        Me.Panel3.Controls.Add(Me.Picture_heb_panel3)
        Me.Panel3.Controls.Add(Me.button_results_clear)
        Me.Panel3.Controls.Add(Me.button_results_save)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(763, 686)
        Me.Panel3.TabIndex = 63
        '
        'button_results_save_HTML
        '
        Me.button_results_save_HTML.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.button_results_save_HTML.Font = New System.Drawing.Font("David", 13.8!)
        Me.button_results_save_HTML.Location = New System.Drawing.Point(203, 584)
        Me.button_results_save_HTML.Name = "button_results_save_HTML"
        Me.button_results_save_HTML.Size = New System.Drawing.Size(305, 51)
        Me.button_results_save_HTML.TabIndex = 67
        Me.button_results_save_HTML.Text = "Generate HTML Report"
        Me.button_results_save_HTML.UseVisualStyleBackColor = True
        Me.button_results_save_HTML.Visible = False
        '
        'GroupBox_choose_language
        '
        Me.GroupBox_choose_language.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_choose_language.Controls.Add(Me.GroupBox_update)
        Me.GroupBox_choose_language.Controls.Add(Me.RadioButton_other_language)
        Me.GroupBox_choose_language.Controls.Add(Me.RadioButton_default_english)
        Me.GroupBox_choose_language.Controls.Add(Me.RichTextBox_result_for_saving_HTML)
        Me.GroupBox_choose_language.Location = New System.Drawing.Point(20, 26)
        Me.GroupBox_choose_language.Name = "GroupBox_choose_language"
        Me.GroupBox_choose_language.Size = New System.Drawing.Size(695, 246)
        Me.GroupBox_choose_language.TabIndex = 66
        Me.GroupBox_choose_language.TabStop = False
        '
        'GroupBox_update
        '
        Me.GroupBox_update.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_update.Controls.Add(Me.RadioButton_add_replace)
        Me.GroupBox_update.Controls.Add(Me.Button_update)
        Me.GroupBox_update.Controls.Add(Me.RadioButton_add_after)
        Me.GroupBox_update.Location = New System.Drawing.Point(16, 85)
        Me.GroupBox_update.Name = "GroupBox_update"
        Me.GroupBox_update.Size = New System.Drawing.Size(668, 155)
        Me.GroupBox_update.TabIndex = 70
        Me.GroupBox_update.TabStop = False
        Me.GroupBox_update.Text = "Update of text"
        '
        'RadioButton_add_replace
        '
        Me.RadioButton_add_replace.AutoEllipsis = True
        Me.RadioButton_add_replace.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RadioButton_add_replace.Location = New System.Drawing.Point(11, 66)
        Me.RadioButton_add_replace.Name = "RadioButton_add_replace"
        Me.RadioButton_add_replace.Size = New System.Drawing.Size(538, 31)
        Me.RadioButton_add_replace.TabIndex = 70
        Me.RadioButton_add_replace.Text = "Clear the textbox of all text and add the new text"
        Me.RadioButton_add_replace.UseVisualStyleBackColor = True
        '
        'Button_update
        '
        Me.Button_update.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_update.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Button_update.Location = New System.Drawing.Point(279, 103)
        Me.Button_update.Name = "Button_update"
        Me.Button_update.Size = New System.Drawing.Size(113, 46)
        Me.Button_update.TabIndex = 67
        Me.Button_update.Text = "Update"
        Me.Button_update.UseVisualStyleBackColor = True
        '
        'RadioButton_add_after
        '
        Me.RadioButton_add_after.AutoEllipsis = True
        Me.RadioButton_add_after.Checked = True
        Me.RadioButton_add_after.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RadioButton_add_after.Location = New System.Drawing.Point(11, 30)
        Me.RadioButton_add_after.Name = "RadioButton_add_after"
        Me.RadioButton_add_after.Size = New System.Drawing.Size(538, 27)
        Me.RadioButton_add_after.TabIndex = 69
        Me.RadioButton_add_after.TabStop = True
        Me.RadioButton_add_after.Text = "Add the new text after the text already in the textbox"
        Me.RadioButton_add_after.UseVisualStyleBackColor = True
        '
        'RadioButton_other_language
        '
        Me.RadioButton_other_language.AutoEllipsis = True
        Me.RadioButton_other_language.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RadioButton_other_language.Location = New System.Drawing.Point(16, 51)
        Me.RadioButton_other_language.Name = "RadioButton_other_language"
        Me.RadioButton_other_language.Size = New System.Drawing.Size(566, 31)
        Me.RadioButton_other_language.TabIndex = 68
        Me.RadioButton_other_language.Text = "Use current language"
        Me.RadioButton_other_language.UseVisualStyleBackColor = True
        '
        'RadioButton_default_english
        '
        Me.RadioButton_default_english.AutoEllipsis = True
        Me.RadioButton_default_english.Checked = True
        Me.RadioButton_default_english.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RadioButton_default_english.Location = New System.Drawing.Point(16, 21)
        Me.RadioButton_default_english.Name = "RadioButton_default_english"
        Me.RadioButton_default_english.Size = New System.Drawing.Size(566, 27)
        Me.RadioButton_default_english.TabIndex = 67
        Me.RadioButton_default_english.TabStop = True
        Me.RadioButton_default_english.Text = "Use the default English language for displaying calculations"
        Me.RadioButton_default_english.UseVisualStyleBackColor = True
        '
        'RichTextBox_result_for_saving_HTML
        '
        Me.RichTextBox_result_for_saving_HTML.Location = New System.Drawing.Point(252, 109)
        Me.RichTextBox_result_for_saving_HTML.Name = "RichTextBox_result_for_saving_HTML"
        Me.RichTextBox_result_for_saving_HTML.Size = New System.Drawing.Size(70, 44)
        Me.RichTextBox_result_for_saving_HTML.TabIndex = 68
        Me.RichTextBox_result_for_saving_HTML.Text = ""
        Me.RichTextBox_result_for_saving_HTML.Visible = False
        '
        'Picture_eng_panel3
        '
        Me.Picture_eng_panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Picture_eng_panel3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Picture_eng_panel3.Image = Global.SPE.My.Resources.Resources.flag_english01
        Me.Picture_eng_panel3.Location = New System.Drawing.Point(721, 32)
        Me.Picture_eng_panel3.Name = "Picture_eng_panel3"
        Me.Picture_eng_panel3.Size = New System.Drawing.Size(32, 16)
        Me.Picture_eng_panel3.TabIndex = 63
        Me.Picture_eng_panel3.TabStop = False
        '
        'Picture_heb_panel3
        '
        Me.Picture_heb_panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Picture_heb_panel3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Picture_heb_panel3.Image = Global.SPE.My.Resources.Resources.flag_hebrew01
        Me.Picture_heb_panel3.Location = New System.Drawing.Point(721, 8)
        Me.Picture_heb_panel3.Name = "Picture_heb_panel3"
        Me.Picture_heb_panel3.Size = New System.Drawing.Size(32, 20)
        Me.Picture_heb_panel3.TabIndex = 62
        Me.Picture_heb_panel3.TabStop = False
        '
        'button_results_save
        '
        Me.button_results_save.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.button_results_save.Font = New System.Drawing.Font("David", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.button_results_save.Image = CType(resources.GetObject("button_results_save.Image"), System.Drawing.Image)
        Me.button_results_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_results_save.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.button_results_save.Location = New System.Drawing.Point(315, 527)
        Me.button_results_save.Name = "button_results_save"
        Me.button_results_save.Size = New System.Drawing.Size(193, 48)
        Me.button_results_save.TabIndex = 49
        Me.button_results_save.Text = "Save Output"
        Me.button_results_save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.GroupBox_creation_type)
        Me.Panel4.Controls.Add(Me.Label_affiliated)
        Me.Panel4.Controls.Add(Me.PictureBox02)
        Me.Panel4.Controls.Add(Me.PictureBox01)
        Me.Panel4.Controls.Add(Me.Button_Run_ADINA)
        Me.Panel4.Controls.Add(Me.Button_feed_ADINA)
        Me.Panel4.Controls.Add(Me.RichTextBox_model_qualify)
        Me.Panel4.Controls.Add(Me.RichTextBox_adina_msg)
        Me.Panel4.Controls.Add(Me.Picture_eng_panel4)
        Me.Panel4.Controls.Add(Me.Picture_heb_panel4)
        Me.Panel4.Controls.Add(Me.Label_Adina)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(763, 686)
        Me.Panel4.TabIndex = 64
        '
        'GroupBox_creation_type
        '
        Me.GroupBox_creation_type.Controls.Add(Me.RadioButton_normal)
        Me.GroupBox_creation_type.Controls.Add(Me.RadioButton_fast)
        Me.GroupBox_creation_type.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.GroupBox_creation_type.Location = New System.Drawing.Point(21, 438)
        Me.GroupBox_creation_type.Name = "GroupBox_creation_type"
        Me.GroupBox_creation_type.Size = New System.Drawing.Size(712, 96)
        Me.GroupBox_creation_type.TabIndex = 58
        Me.GroupBox_creation_type.TabStop = False
        Me.GroupBox_creation_type.Text = "Creation Mode"
        '
        'RadioButton_normal
        '
        Me.RadioButton_normal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButton_normal.AutoEllipsis = True
        Me.RadioButton_normal.Location = New System.Drawing.Point(4, 21)
        Me.RadioButton_normal.Name = "RadioButton_normal"
        Me.RadioButton_normal.Size = New System.Drawing.Size(673, 30)
        Me.RadioButton_normal.TabIndex = 1
        Me.RadioButton_normal.Text = "Normal ADINA session creation (Full loading of ADINA GUI)"
        Me.RadioButton_normal.UseVisualStyleBackColor = True
        '
        'RadioButton_fast
        '
        Me.RadioButton_fast.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButton_fast.AutoEllipsis = True
        Me.RadioButton_fast.Checked = True
        Me.RadioButton_fast.Location = New System.Drawing.Point(4, 55)
        Me.RadioButton_fast.Name = "RadioButton_fast"
        Me.RadioButton_fast.Size = New System.Drawing.Size(673, 29)
        Me.RadioButton_fast.TabIndex = 0
        Me.RadioButton_fast.TabStop = True
        Me.RadioButton_fast.Text = "Fast ADINA session creation (Auto save dialog box & closing of ADINA GUI)"
        Me.RadioButton_fast.UseMnemonic = False
        Me.RadioButton_fast.UseVisualStyleBackColor = True
        '
        'Label_affiliated
        '
        Me.Label_affiliated.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label_affiliated.Font = New System.Drawing.Font("David", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_affiliated.ForeColor = System.Drawing.Color.Black
        Me.Label_affiliated.Location = New System.Drawing.Point(0, 641)
        Me.Label_affiliated.Name = "Label_affiliated"
        Me.Label_affiliated.Size = New System.Drawing.Size(763, 45)
        Me.Label_affiliated.TabIndex = 57
        Me.Label_affiliated.Text = """ADINA Generator"" is in no way affiliated with ADINA R & D ,Inc. All ADINA tradem" &
    "arks and copyrights, except ""ADINA Generator"", are the property of their respect" &
    "ive holders."
        Me.Label_affiliated.UseMnemonic = False
        '
        'PictureBox02
        '
        Me.PictureBox02.Image = CType(resources.GetObject("PictureBox02.Image"), System.Drawing.Image)
        Me.PictureBox02.Location = New System.Drawing.Point(574, 356)
        Me.PictureBox02.Name = "PictureBox02"
        Me.PictureBox02.Size = New System.Drawing.Size(157, 55)
        Me.PictureBox02.TabIndex = 56
        Me.PictureBox02.TabStop = False
        Me.PictureBox02.Visible = False
        '
        'PictureBox01
        '
        Me.PictureBox01.Image = CType(resources.GetObject("PictureBox01.Image"), System.Drawing.Image)
        Me.PictureBox01.Location = New System.Drawing.Point(20, 356)
        Me.PictureBox01.Name = "PictureBox01"
        Me.PictureBox01.Size = New System.Drawing.Size(157, 55)
        Me.PictureBox01.TabIndex = 55
        Me.PictureBox01.TabStop = False
        Me.PictureBox01.Visible = False
        '
        'Button_Run_ADINA
        '
        Me.Button_Run_ADINA.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Button_Run_ADINA.Location = New System.Drawing.Point(378, 336)
        Me.Button_Run_ADINA.Name = "Button_Run_ADINA"
        Me.Button_Run_ADINA.Size = New System.Drawing.Size(180, 88)
        Me.Button_Run_ADINA.TabIndex = 54
        Me.Button_Run_ADINA.Text = "Run ADINA Generator"
        Me.Button_Run_ADINA.Visible = False
        '
        'Button_feed_ADINA
        '
        Me.Button_feed_ADINA.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Button_feed_ADINA.Location = New System.Drawing.Point(184, 336)
        Me.Button_feed_ADINA.Name = "Button_feed_ADINA"
        Me.Button_feed_ADINA.Size = New System.Drawing.Size(180, 88)
        Me.Button_feed_ADINA.TabIndex = 53
        Me.Button_feed_ADINA.Text = "Feed the current model to ADINA Generator"
        Me.Button_feed_ADINA.Visible = False
        '
        'RichTextBox_model_qualify
        '
        Me.RichTextBox_model_qualify.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox_model_qualify.BackColor = System.Drawing.Color.WhiteSmoke
        Me.RichTextBox_model_qualify.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox_model_qualify.BulletIndent = 1
        Me.RichTextBox_model_qualify.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RichTextBox_model_qualify.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RichTextBox_model_qualify.ForeColor = System.Drawing.Color.Blue
        Me.RichTextBox_model_qualify.Location = New System.Drawing.Point(20, 212)
        Me.RichTextBox_model_qualify.Name = "RichTextBox_model_qualify"
        Me.RichTextBox_model_qualify.ReadOnly = True
        Me.RichTextBox_model_qualify.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RichTextBox_model_qualify.ShowSelectionMargin = True
        Me.RichTextBox_model_qualify.Size = New System.Drawing.Size(681, 107)
        Me.RichTextBox_model_qualify.TabIndex = 52
        Me.RichTextBox_model_qualify.Text = resources.GetString("RichTextBox_model_qualify.Text")
        Me.RichTextBox_model_qualify.Visible = False
        '
        'RichTextBox_adina_msg
        '
        Me.RichTextBox_adina_msg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox_adina_msg.BackColor = System.Drawing.Color.WhiteSmoke
        Me.RichTextBox_adina_msg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox_adina_msg.BulletIndent = 1
        Me.RichTextBox_adina_msg.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RichTextBox_adina_msg.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RichTextBox_adina_msg.ForeColor = System.Drawing.Color.Navy
        Me.RichTextBox_adina_msg.Location = New System.Drawing.Point(20, 84)
        Me.RichTextBox_adina_msg.Name = "RichTextBox_adina_msg"
        Me.RichTextBox_adina_msg.ReadOnly = True
        Me.RichTextBox_adina_msg.ShowSelectionMargin = True
        Me.RichTextBox_adina_msg.Size = New System.Drawing.Size(683, 112)
        Me.RichTextBox_adina_msg.TabIndex = 51
        Me.RichTextBox_adina_msg.Text = "ההגבלות הגאומטריות עבור ADINA Generator הן כדלקמן:" & Global.Microsoft.VisualBasic.ChrW(10) & "•  כל החיזוקים חייבים להיות בע" &
    "לי אותו גובה (עובי יכול להיות שונה)." & Global.Microsoft.VisualBasic.ChrW(10) & "•  לפחות חיזוק אחד חייב להיות בכל ציר."
        '
        'Picture_eng_panel4
        '
        Me.Picture_eng_panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Picture_eng_panel4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Picture_eng_panel4.Image = Global.SPE.My.Resources.Resources.flag_english01
        Me.Picture_eng_panel4.Location = New System.Drawing.Point(721, 32)
        Me.Picture_eng_panel4.Name = "Picture_eng_panel4"
        Me.Picture_eng_panel4.Size = New System.Drawing.Size(32, 16)
        Me.Picture_eng_panel4.TabIndex = 50
        Me.Picture_eng_panel4.TabStop = False
        '
        'Picture_heb_panel4
        '
        Me.Picture_heb_panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Picture_heb_panel4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Picture_heb_panel4.Image = Global.SPE.My.Resources.Resources.flag_hebrew01
        Me.Picture_heb_panel4.Location = New System.Drawing.Point(721, 8)
        Me.Picture_heb_panel4.Name = "Picture_heb_panel4"
        Me.Picture_heb_panel4.Size = New System.Drawing.Size(32, 20)
        Me.Picture_heb_panel4.TabIndex = 49
        Me.Picture_heb_panel4.TabStop = False
        '
        'Label_Adina
        '
        Me.Label_Adina.AutoEllipsis = True
        Me.Label_Adina.Font = New System.Drawing.Font("David", 22.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_Adina.Location = New System.Drawing.Point(16, 20)
        Me.Label_Adina.Name = "Label_Adina"
        Me.Label_Adina.Size = New System.Drawing.Size(724, 52)
        Me.Label_Adina.TabIndex = 0
        Me.Label_Adina.Text = "ADINA Finite Element Model Creation"
        Me.Label_Adina.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ImageList_model
        '
        Me.ImageList_model.ImageStream = CType(resources.GetObject("ImageList_model.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_model.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_model.Images.SetKeyName(0, "")
        Me.ImageList_model.Images.SetKeyName(1, "")
        Me.ImageList_model.Images.SetKeyName(2, "")
        Me.ImageList_model.Images.SetKeyName(3, "")
        '
        'SplitContainer
        '
        Me.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer.Name = "SplitContainer"
        '
        'SplitContainer.Panel1
        '
        Me.SplitContainer.Panel1.Controls.Add(Me.ListView_steps)
        Me.SplitContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        'SplitContainer.Panel2
        '
        Me.SplitContainer.Panel2.Controls.Add(Me.Panel4)
        Me.SplitContainer.Panel2.Controls.Add(Me.Panel3)
        Me.SplitContainer.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitContainer.Size = New System.Drawing.Size(926, 686)
        Me.SplitContainer.SplitterDistance = 159
        Me.SplitContainer.TabIndex = 65
        '
        'GUI_Data_and_Results
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(926, 686)
        Me.Controls.Add(Me.SplitContainer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(859, 694)
        Me.Name = "GUI_Data_and_Results"
        Me.Text = "סיכום נתונים וביצוע חישוב לפי מודל הפלטה האורתוטרופית (מבוסס על מאמר של A.H. SCHA" &
    "DE)"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.groupbox_plate_geo.ResumeLayout(False)
        CType(Me.numeric_t, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numeric_b, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numeric_a, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_stiffeners_number.ResumeLayout(False)
        CType(Me.numeric_short, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numeric_long, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_stiffeners.ResumeLayout(False)
        Me.GroupBox_stiffeners_geometric.ResumeLayout(False)
        Me.GroupBox_stiffeners_geometric.PerformLayout()
        Me.GroupBox_stiffeners_data.ResumeLayout(False)
        Me.GroupBox_stiffeners_data.PerformLayout()
        Me.groupbox_general.ResumeLayout(False)
        Me.groupbox_general.PerformLayout()
        CType(Me.numeric_case_input, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.Picture_eng_panel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture_heb_panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_numeric_stiffeners.ResumeLayout(False)
        Me.GroupBox_numeric_stiffeners.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox_figures, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_SD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture_eng_panel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture_heb_panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox_choose_language.ResumeLayout(False)
        Me.GroupBox_update.ResumeLayout(False)
        CType(Me.Picture_eng_panel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture_heb_panel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox_creation_type.ResumeLayout(False)
        CType(Me.PictureBox02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox01, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture_eng_panel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture_heb_panel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer.Panel1.ResumeLayout(False)
        Me.SplitContainer.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim GUI_ADINA As New Adina_Generator.GUI_ADINA_main
    Dim OK_even_numbers As Boolean = False
    'Dim general_function As New general_functions
    Dim current_data As String = "moment"
    Dim GUI_FEA_results As New GUI_FEA_results
    Dim result_deflection As Single = 0
    Dim result_deflection_SD As Single = 0
    Dim BC_select As New GUI_BC_select
    Dim toolTip_result As New ToolTip
    Dim color_old As Color = Color.Gray
    Dim continue_process As Boolean = False
    '********* OK sections ************
    Private Sub hide_panels()
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
    End Sub
    Sub load_data()
        If general_settings.general_variables.current_model = "Orthotropic Plate model" Then
            numeric_a.Value = models_calculations.Orthotropic_model.model_variables.a
            numeric_b.Value = models_calculations.Orthotropic_model.model_variables.b
            numeric_t.Value = models_calculations.Orthotropic_model.model_variables.t * 1000
            textbox_P_input.Text = models_calculations.Orthotropic_model.model_variables.P
            textbox_E_input.Text = models_calculations.Orthotropic_model.model_variables.E
            textbox_ni_input.Text = models_calculations.Orthotropic_model.model_variables.ni
            numeric_case_input.Text = models_calculations.Orthotropic_model.model_variables.C
            numeric_long.Text = models_calculations.Orthotropic_model.model_variables.Na
            numeric_short.Text = models_calculations.Orthotropic_model.model_variables.Nb
            textbox_geo_type.Text = models_calculations.Orthotropic_model.model_variables.geo_type
            textbox_geo_type.Visible = True
            'CHECKING NA
            If (numeric_long.Value = 1) Or (numeric_long.Value = 0) Then
                numeric_long.Enabled = False
            Else
                numeric_long.Enabled = True
                'remove this ***
                'numeric_long.Minimum = 3
            End If
            'CHECKING NB
            If (numeric_short.Value = 1) Or (numeric_short.Value = 0) Then
                numeric_short.Enabled = False
            Else
                numeric_short.Enabled = True
                'remove this ***
                'numeric_short.Minimum = 3
            End If
        ElseIf general_settings.general_variables.current_model = "Grillage model" Then
            numeric_short.Minimum = 1
            numeric_long.Minimum = 1
            textbox_geo_type.Visible = False
            numeric_a.Value = models_calculations.Grillage_model.model_variables.a
            numeric_b.Value = models_calculations.Grillage_model.model_variables.b
            numeric_t.Value = models_calculations.Grillage_model.model_variables.t * 1000
            textbox_P_input.Text = models_calculations.Grillage_model.model_variables.P
            textbox_E_input.Text = models_calculations.Grillage_model.model_variables.E
            textbox_ni_input.Text = models_calculations.Grillage_model.model_variables.ni
            numeric_case_input.Text = models_calculations.Grillage_model.model_variables.BC
            numeric_long.Value = models_calculations.Grillage_model.model_variables.s
            numeric_short.Value = models_calculations.Grillage_model.model_variables.r
            textbox_geo_type.Text = "N/A"
            'textbox_geo_type.Visible = False
        End If
    End Sub
    Private Sub GUI_set_show_data_stiffeners(ByVal current As String)
        ' ************* Orthotropic plate model ***************
        If general_settings.general_variables.current_model = "Orthotropic Plate model" Then
            If current = "moment" Then
                GroupBox_stiffeners_data.Text = language_settings.results_panel1_GroupBox_stiffeners_data_moment
                If data_units.Text = language_settings.unit_meter4 Then
                    TextBox_a.Text = models_calculations.Orthotropic_model.model_variables.Ia_stiffener
                    TextBox_na.Text = models_calculations.Orthotropic_model.model_variables.Ina_stiffeners
                    TextBox_b.Text = models_calculations.Orthotropic_model.model_variables.Ib_stiffener
                    TextBox_nb.Text = models_calculations.Orthotropic_model.model_variables.Inb_stiffeners
                ElseIf data_units.Text = language_settings.unit_centimeter4 Then
                    TextBox_a.Text = Math.Round(models_calculations.Orthotropic_model.model_variables.Ia_stiffener * 10 ^ 8, 3)
                    TextBox_na.Text = Math.Round(models_calculations.Orthotropic_model.model_variables.Ina_stiffeners * 10 ^ 8, 3)
                    TextBox_b.Text = Math.Round(models_calculations.Orthotropic_model.model_variables.Ib_stiffener * 10 ^ 8, 3)
                    TextBox_nb.Text = Math.Round(models_calculations.Orthotropic_model.model_variables.Inb_stiffeners * 10 ^ 8, 3)
                ElseIf data_units.Text = language_settings.unit_millimeter4 Then
                    TextBox_a.Text = Math.Round(models_calculations.Orthotropic_model.model_variables.Ia_stiffener * 10 ^ 12, 3)
                    TextBox_na.Text = Math.Round(models_calculations.Orthotropic_model.model_variables.Ina_stiffeners * 10 ^ 12, 3)
                    TextBox_b.Text = Math.Round(models_calculations.Orthotropic_model.model_variables.Ib_stiffener * 10 ^ 12, 3)
                    TextBox_nb.Text = Math.Round(models_calculations.Orthotropic_model.model_variables.Inb_stiffeners * 10 ^ 12, 3)
                Else
                    TextBox_a.Text = "N/A"
                    TextBox_b.Text = "N/A"
                    TextBox_nb.Text = "N/A"
                    TextBox_na.Text = "N/A"
                End If
            ElseIf current = "area" Then
                GroupBox_stiffeners_data.Text = language_settings.results_panel1_GroupBox_stiffeners_data_area
                If data_units.Text = language_settings.unit_meter2 Then
                    TextBox_a.Text = models_calculations.Orthotropic_model.model_variables.Aa_stiffener
                    TextBox_na.Text = models_calculations.Orthotropic_model.model_variables.Ana_stiffeners
                    TextBox_b.Text = models_calculations.Orthotropic_model.model_variables.Ab_stiffener
                    TextBox_nb.Text = models_calculations.Orthotropic_model.model_variables.Anb_stiffeners
                ElseIf data_units.Text = language_settings.unit_centimeter2 Then
                    TextBox_a.Text = Math.Round(models_calculations.Orthotropic_model.model_variables.Aa_stiffener * 10 ^ 4, 3)
                    TextBox_na.Text = Math.Round(models_calculations.Orthotropic_model.model_variables.Ana_stiffeners * 10 ^ 4, 3)
                    TextBox_b.Text = Math.Round(models_calculations.Orthotropic_model.model_variables.Ab_stiffener * 10 ^ 4, 3)
                    TextBox_nb.Text = Math.Round(models_calculations.Orthotropic_model.model_variables.Anb_stiffeners * 10 ^ 4, 3)
                ElseIf data_units.Text = language_settings.unit_millimeter2 Then
                    TextBox_a.Text = Math.Round(models_calculations.Orthotropic_model.model_variables.Aa_stiffener * 10 ^ 6, 3)
                    TextBox_na.Text = Math.Round(models_calculations.Orthotropic_model.model_variables.Ana_stiffeners * 10 ^ 6, 3)
                    TextBox_b.Text = Math.Round(models_calculations.Orthotropic_model.model_variables.Ab_stiffener * 10 ^ 6, 3)
                    TextBox_nb.Text = Math.Round(models_calculations.Orthotropic_model.model_variables.Anb_stiffeners * 10 ^ 6, 3)
                Else
                    TextBox_a.Text = "N/A"
                    TextBox_b.Text = "N/A"
                    TextBox_nb.Text = "N/A"
                    TextBox_na.Text = "N/A"
                End If
            ElseIf current = "center" Then
                GroupBox_stiffeners_data.Text = language_settings.results_panel1_GroupBox_stiffeners_data_center
                If data_units.Text = language_settings.unit_meter Then
                    TextBox_a.Text = models_calculations.Orthotropic_model.model_variables.Ya_stiffener
                    TextBox_na.Text = models_calculations.Orthotropic_model.model_variables.Yna_stiffeners
                    TextBox_b.Text = models_calculations.Orthotropic_model.model_variables.Yb_stiffener
                    TextBox_nb.Text = models_calculations.Orthotropic_model.model_variables.Ynb_stiffeners
                ElseIf data_units.Text = language_settings.unit_centimeter Then
                    TextBox_a.Text = Math.Round(models_calculations.Orthotropic_model.model_variables.Ya_stiffener * 10 ^ 2, 3)
                    TextBox_na.Text = Math.Round(models_calculations.Orthotropic_model.model_variables.Yna_stiffeners * 10 ^ 2, 3)
                    TextBox_b.Text = Math.Round(models_calculations.Orthotropic_model.model_variables.Yb_stiffener * 10 ^ 2, 3)
                    TextBox_nb.Text = Math.Round(models_calculations.Orthotropic_model.model_variables.Ynb_stiffeners * 10 ^ 2, 3)
                ElseIf data_units.Text = language_settings.unit_millimeter Then
                    TextBox_a.Text = Math.Round(models_calculations.Orthotropic_model.model_variables.Ya_stiffener * 10 ^ 3, 3)
                    TextBox_na.Text = Math.Round(models_calculations.Orthotropic_model.model_variables.Yna_stiffeners * 10 ^ 3, 3)
                    TextBox_b.Text = Math.Round(models_calculations.Orthotropic_model.model_variables.Yb_stiffener * 10 ^ 3, 3)
                    TextBox_nb.Text = Math.Round(models_calculations.Orthotropic_model.model_variables.Ynb_stiffeners * 10 ^ 3, 3)
                Else
                    TextBox_a.Text = "N/A"
                    TextBox_b.Text = "N/A"
                    TextBox_nb.Text = "N/A"
                    TextBox_na.Text = "N/A"
                End If
            Else
                TextBox_a.Text = "N/A"
                TextBox_b.Text = "N/A"
                TextBox_nb.Text = "N/A"
                TextBox_na.Text = "N/A"
            End If
            ' ************* GRILLAGE  model ***************
        ElseIf general_settings.general_variables.current_model = "Grillage model" Then
            If current = "moment" Then
                GroupBox_stiffeners_data.Text = language_settings.results_panel1_GroupBox_stiffeners_data_moment
                If data_units.Text = language_settings.unit_meter4 Then
                    TextBox_a.Text = models_calculations.Grillage_model.model_variables.Ir_stiffeners
                    TextBox_na.Text = models_calculations.Grillage_model.model_variables.Ir_stiffeners
                    TextBox_b.Text = models_calculations.Grillage_model.model_variables.Is_stiffeners
                    TextBox_nb.Text = models_calculations.Grillage_model.model_variables.Is_stiffeners
                ElseIf data_units.Text = language_settings.unit_centimeter4 Then
                    TextBox_a.Text = Math.Round(models_calculations.Grillage_model.model_variables.Ir_stiffeners * 10 ^ 8, 3)
                    TextBox_na.Text = Math.Round(models_calculations.Grillage_model.model_variables.Ir_stiffeners * 10 ^ 8, 3)
                    TextBox_b.Text = Math.Round(models_calculations.Grillage_model.model_variables.Is_stiffeners * 10 ^ 8, 3)
                    TextBox_nb.Text = Math.Round(models_calculations.Grillage_model.model_variables.Is_stiffeners * 10 ^ 8, 3)
                ElseIf data_units.Text = language_settings.unit_millimeter4 Then
                    TextBox_a.Text = Math.Round(models_calculations.Grillage_model.model_variables.Ir_stiffeners * 10 ^ 12, 3)
                    TextBox_na.Text = Math.Round(models_calculations.Grillage_model.model_variables.Ir_stiffeners * 10 ^ 12, 3)
                    TextBox_b.Text = Math.Round(models_calculations.Grillage_model.model_variables.Is_stiffeners * 10 ^ 12, 3)
                    TextBox_nb.Text = Math.Round(models_calculations.Grillage_model.model_variables.Is_stiffeners * 10 ^ 12, 3)
                Else
                    TextBox_a.Text = "N/A"
                    TextBox_b.Text = "N/A"
                    TextBox_nb.Text = "N/A"
                    TextBox_na.Text = "N/A"
                End If
            ElseIf current = "area" Then
                GroupBox_stiffeners_data.Text = language_settings.results_panel1_GroupBox_stiffeners_data_area
                If data_units.Text = language_settings.unit_meter2 Then
                    TextBox_a.Text = models_calculations.Grillage_model.model_variables.Ar_stiffeners
                    TextBox_na.Text = models_calculations.Grillage_model.model_variables.Ar_stiffeners
                    TextBox_b.Text = models_calculations.Grillage_model.model_variables.As_stiffeners
                    TextBox_nb.Text = models_calculations.Grillage_model.model_variables.As_stiffeners
                ElseIf data_units.Text = language_settings.unit_centimeter2 Then
                    TextBox_a.Text = Math.Round(models_calculations.Grillage_model.model_variables.Ar_stiffeners * 10 ^ 4, 3)
                    TextBox_na.Text = Math.Round(models_calculations.Grillage_model.model_variables.Ar_stiffeners * 10 ^ 4, 3)
                    TextBox_b.Text = Math.Round(models_calculations.Grillage_model.model_variables.As_stiffeners * 10 ^ 4, 3)
                    TextBox_nb.Text = Math.Round(models_calculations.Grillage_model.model_variables.As_stiffeners * 10 ^ 4, 3)
                ElseIf data_units.Text = language_settings.unit_millimeter2 Then
                    TextBox_a.Text = Math.Round(models_calculations.Grillage_model.model_variables.Ar_stiffeners * 10 ^ 6, 3)
                    TextBox_na.Text = Math.Round(models_calculations.Grillage_model.model_variables.Ar_stiffeners * 10 ^ 6, 3)
                    TextBox_b.Text = Math.Round(models_calculations.Grillage_model.model_variables.As_stiffeners * 10 ^ 6, 3)
                    TextBox_nb.Text = Math.Round(models_calculations.Grillage_model.model_variables.As_stiffeners * 10 ^ 6, 3)
                Else
                    TextBox_a.Text = "N/A"
                    TextBox_b.Text = "N/A"
                    TextBox_nb.Text = "N/A"
                    TextBox_na.Text = "N/A"
                End If
            ElseIf current = "center" Then
                GroupBox_stiffeners_data.Text = language_settings.results_panel1_GroupBox_stiffeners_data_center
                If data_units.Text = language_settings.unit_meter Then
                    TextBox_a.Text = models_calculations.Grillage_model.model_variables.Yr_stiffeners
                    TextBox_na.Text = models_calculations.Grillage_model.model_variables.Yr_stiffeners
                    TextBox_b.Text = models_calculations.Grillage_model.model_variables.Ys_stiffeners
                    TextBox_nb.Text = models_calculations.Grillage_model.model_variables.Ys_stiffeners
                ElseIf data_units.Text = language_settings.unit_centimeter Then
                    TextBox_a.Text = Math.Round(models_calculations.Grillage_model.model_variables.Yr_stiffeners * 10 ^ 2, 3)
                    TextBox_na.Text = Math.Round(models_calculations.Grillage_model.model_variables.Yr_stiffeners * 10 ^ 2, 3)
                    TextBox_b.Text = Math.Round(models_calculations.Grillage_model.model_variables.Ys_stiffeners * 10 ^ 2, 3)
                    TextBox_nb.Text = Math.Round(models_calculations.Grillage_model.model_variables.Ys_stiffeners * 10 ^ 2, 3)
                ElseIf data_units.Text = language_settings.unit_millimeter Then
                    TextBox_a.Text = Math.Round(models_calculations.Grillage_model.model_variables.Yr_stiffeners * 10 ^ 3, 3)
                    TextBox_na.Text = Math.Round(models_calculations.Grillage_model.model_variables.Yr_stiffeners * 10 ^ 3, 3)
                    TextBox_b.Text = Math.Round(models_calculations.Grillage_model.model_variables.Ys_stiffeners * 10 ^ 3, 3)
                    TextBox_nb.Text = Math.Round(models_calculations.Grillage_model.model_variables.Ys_stiffeners * 10 ^ 3, 3)
                Else
                    TextBox_a.Text = "N/A"
                    TextBox_b.Text = "N/A"
                    TextBox_nb.Text = "N/A"
                    TextBox_na.Text = "N/A"
                End If
            Else
                TextBox_a.Text = "N/A"
                TextBox_b.Text = "N/A"
                TextBox_nb.Text = "N/A"
                TextBox_na.Text = "N/A"
            End If
        End If
    End Sub
    Private Sub GUI_set_data_only_stiffeners(ByVal current As String)
        data_units.Items.Clear()
        If current = "moment" Then
            data_units.Items.Insert(0, language_settings.unit_millimeter4)
            data_units.Items.Insert(1, language_settings.unit_centimeter4)
            data_units.Items.Insert(2, language_settings.unit_meter4)
            data_units.Text = data_units.Items(2)
        ElseIf current = "area" Then
            data_units.Items.Insert(0, language_settings.unit_millimeter2)
            data_units.Items.Insert(1, language_settings.unit_centimeter2)
            data_units.Items.Insert(2, language_settings.unit_meter2)
            data_units.Text = data_units.Items(2)
        ElseIf current = "center" Then
            data_units.Items.Insert(0, language_settings.unit_millimeter)
            data_units.Items.Insert(1, language_settings.unit_centimeter)
            data_units.Items.Insert(2, language_settings.unit_meter)
            data_units.Text = data_units.Items(2)
        End If
        If language_settings.language_RTL_layout = True Then
            data_units.RightToLeft = Windows.Forms.RightToLeft.Yes
        Else
            data_units.RightToLeft = Windows.Forms.RightToLeft.No
        End If
        GUI_set_show_data_stiffeners(current)
    End Sub
    Private Sub Button_save_stiffeners_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_save_stiffeners.Click
        Dim data_ok As Boolean = True
        If (general_functions.check_data(TextBox_Ia_b.Text) = True) And (general_functions.check_data(TextBox_Ia_d.Text) = True) Then
            If (TextBox_Ia_b.Text.Length > 30) Or (TextBox_Ia_d.Text.Length > 30) Then
                general_settings.messages.read_msg(5)
                general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                data_ok = False
            End If
        Else
            general_settings.messages.read_msg(21)
            general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
            data_ok = False
        End If

        If (general_functions.check_data(TextBox_Ina_b.Text) = True) And (general_functions.check_data(TextBox_Ina_d.Text) = True) Then
            If (TextBox_Ina_b.Text.Length > 30) Or (TextBox_Ina_d.Text.Length > 30) Then
                general_settings.messages.read_msg(5)
                general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                data_ok = False
            End If
        Else
            general_settings.messages.read_msg(22)
            general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
            data_ok = False
        End If

        If (general_functions.check_data(TextBox_Ib_b.Text) = True) And (general_functions.check_data(TextBox_Ib_d.Text) = True) Then
            If (TextBox_Ib_b.Text.Length > 30) Or (TextBox_Ib_d.Text.Length > 30) Then
                general_settings.messages.read_msg(5)
                general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                data_ok = False
            End If
        Else
            general_settings.messages.read_msg(23)
            general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
            data_ok = False
        End If

        If (general_functions.check_data(TextBox_Inb_b.Text) = True) And (general_functions.check_data(TextBox_Inb_d.Text) = True) Then
            If (TextBox_Inb_b.Text.Length > 30) Or (TextBox_Inb_d.Text.Length > 30) Then
                general_settings.messages.read_msg(5)
                general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                data_ok = False
            End If
        Else
            general_settings.messages.read_msg(24)
            general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
            data_ok = False
        End If

        If data_ok = True Then
            '********* setting data ***************************
            '///////////ORTHOTROPIC PLATE MODEL \\\\\\\\\\\\\\\\\
            If general_settings.general_variables.current_model = "Orthotropic Plate model" Then
                If CheckBox_Ia.Checked = True Then
                    models_calculations.Orthotropic_model.model_variables.Ia_stiffener = CSng(models_calculations.general_functions.moment_of_inertia(TextBox_Ia_b.Text, TextBox_Ia_d.Text, 0, 0, "|"))
                    models_calculations.Orthotropic_model.model_variables.Aa_stiffener = CSng(models_calculations.general_functions.Area(TextBox_Ia_b.Text, TextBox_Ia_d.Text, 0, 0, "|"))
                    models_calculations.Orthotropic_model.model_variables.Ya_stiffener = CSng(models_calculations.general_functions.centroid(TextBox_Ia_b.Text, TextBox_Ia_d.Text, 0, 0, "|"))
                End If

                If CheckBox_Ina.Checked = True Then
                    models_calculations.Orthotropic_model.model_variables.Ina_stiffeners = CSng(models_calculations.general_functions.moment_of_inertia(TextBox_Ina_b.Text, TextBox_Ina_d.Text, 0, 0, "|"))
                    models_calculations.Orthotropic_model.model_variables.Ana_stiffeners = CSng(models_calculations.general_functions.Area(TextBox_Ina_b.Text, TextBox_Ina_d.Text, 0, 0, "|"))
                    models_calculations.Orthotropic_model.model_variables.Yna_stiffeners = CSng(models_calculations.general_functions.centroid(TextBox_Ina_b.Text, TextBox_Ina_d.Text, 0, 0, "|"))
                End If

                If CheckBox_Ib.Checked = True Then
                    models_calculations.Orthotropic_model.model_variables.Ib_stiffener = CSng(models_calculations.general_functions.moment_of_inertia(TextBox_Ib_b.Text, TextBox_Ib_d.Text, 0, 0, "|"))
                    models_calculations.Orthotropic_model.model_variables.Ab_stiffener = CSng(models_calculations.general_functions.Area(TextBox_Ib_b.Text, TextBox_Ib_d.Text, 0, 0, "|"))
                    models_calculations.Orthotropic_model.model_variables.Yb_stiffener = CSng(models_calculations.general_functions.centroid(TextBox_Ib_b.Text, TextBox_Ib_d.Text, 0, 0, "|"))
                End If

                If CheckBox_Inb.Checked = True Then
                    models_calculations.Orthotropic_model.model_variables.Inb_stiffeners = CSng(models_calculations.general_functions.moment_of_inertia(TextBox_Inb_b.Text, TextBox_Inb_d.Text, 0, 0, "|"))
                    models_calculations.Orthotropic_model.model_variables.Anb_stiffeners = CSng(models_calculations.general_functions.Area(TextBox_Inb_b.Text, TextBox_Inb_d.Text, 0, 0, "|"))
                    models_calculations.Orthotropic_model.model_variables.Ynb_stiffeners = CSng(models_calculations.general_functions.centroid(TextBox_Inb_b.Text, TextBox_Inb_d.Text, 0, 0, "|"))
                End If
                '///////////Grillage MODEL \\\\\\\\\\\\\\\\\
            ElseIf general_settings.general_variables.current_model = "Grillage model" Then
                If CheckBox_Ia.Checked = True Then
                    models_calculations.Grillage_model.model_variables.Ir_stiffeners = CSng(models_calculations.general_functions.moment_of_inertia(TextBox_Ia_b.Text, TextBox_Ia_d.Text, 0, 0, "|"))
                    models_calculations.Grillage_model.model_variables.Ar_stiffeners = CSng(models_calculations.general_functions.Area(TextBox_Ia_b.Text, TextBox_Ia_d.Text, 0, 0, "|"))
                    models_calculations.Grillage_model.model_variables.Yr_stiffeners = CSng(models_calculations.general_functions.centroid(TextBox_Ia_b.Text, TextBox_Ia_d.Text, 0, 0, "|"))
                End If

                If CheckBox_Ina.Checked = True Then
                    models_calculations.Grillage_model.model_variables.Ir_stiffeners = CSng(models_calculations.general_functions.moment_of_inertia(TextBox_Ina_b.Text, TextBox_Ina_d.Text, 0, 0, "|"))
                    models_calculations.Grillage_model.model_variables.Ar_stiffeners = CSng(models_calculations.general_functions.Area(TextBox_Ina_b.Text, TextBox_Ina_d.Text, 0, 0, "|"))
                    models_calculations.Grillage_model.model_variables.Yr_stiffeners = CSng(models_calculations.general_functions.centroid(TextBox_Ina_b.Text, TextBox_Ina_d.Text, 0, 0, "|"))
                End If

                If CheckBox_Ib.Checked = True Then
                    models_calculations.Grillage_model.model_variables.Is_stiffeners = CSng(models_calculations.general_functions.moment_of_inertia(TextBox_Ib_b.Text, TextBox_Ib_d.Text, 0, 0, "|"))
                    models_calculations.Grillage_model.model_variables.As_stiffeners = CSng(models_calculations.general_functions.Area(TextBox_Ib_b.Text, TextBox_Ib_d.Text, 0, 0, "|"))
                    models_calculations.Grillage_model.model_variables.Ys_stiffeners = CSng(models_calculations.general_functions.centroid(TextBox_Ib_b.Text, TextBox_Ib_d.Text, 0, 0, "|"))
                End If

                If CheckBox_Inb.Checked = True Then
                    models_calculations.Grillage_model.model_variables.Is_stiffeners = CSng(models_calculations.general_functions.moment_of_inertia(TextBox_Inb_b.Text, TextBox_Inb_d.Text, 0, 0, "|"))
                    models_calculations.Grillage_model.model_variables.As_stiffeners = CSng(models_calculations.general_functions.Area(TextBox_Inb_b.Text, TextBox_Inb_d.Text, 0, 0, "|"))
                    models_calculations.Grillage_model.model_variables.Ys_stiffeners = CSng(models_calculations.general_functions.centroid(TextBox_Inb_b.Text, TextBox_Inb_d.Text, 0, 0, "|"))
                End If
            End If
            GUI_set_show_data_stiffeners(current_data)
            ADINA_check()
            general_settings.messages.read_msg(25)
            general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
        Else
            general_settings.messages.read_msg(26)
            general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
            data_ok = False
        End If
    End Sub
    Private Sub Button_BC_change(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_BC_select.Click
        If BC_select.IsDisposed = True Then
            BC_select = New GUI_BC_select
        End If
        BC_select.ShowDialog()
    End Sub
    Private Sub Button_show_change_data_box(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_data_change.Click
        GroupBox_numeric_stiffeners.Visible = True
    End Sub
    Private Sub Form_Loading(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GUI_set(language_settings.language_current_file)
        general_settings.controls_Library.numeric_case = Me.numeric_case_input
        load_data()
        Panel1.Dock = DockStyle.Fill
        Panel1.Visible = True
    End Sub
    Private Sub Combobox_data_units_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles data_units.SelectedIndexChanged
        'set_GUI_data_only_stiffeners(current_data)
        GUI_set_show_data_stiffeners(current_data)
    End Sub
    Private Sub Combobox_P_units_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combobox_P_units.SelectedIndexChanged
        Textbox_results.ForeColor = color_old
        RichTextBox_results.ForeColor = color_old
    End Sub
    Private Sub numeric_case_input_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numeric_case_input.ValueChanged
        Textbox_results.ForeColor = color_old
        RichTextBox_results.ForeColor = color_old
    End Sub
    Private Sub numeric_updown_b_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numeric_b.ValueChanged
        Textbox_results.ForeColor = color_old
        RichTextBox_results.ForeColor = color_old
        If general_settings.general_variables.current_model = "orthotropic plate model" Then
            If numeric_b.Value > numeric_a.Value Then
                numeric_a.Value = numeric_b.Value
            End If
        ElseIf general_settings.general_variables.current_model = "grillage model" Then
            If numeric_a.Value > numeric_b.Value Then
                numeric_a.Value = numeric_b.Value
            End If
        End If
    End Sub
    Private Sub numeric_updown_a_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numeric_a.ValueChanged
        Textbox_results.ForeColor = color_old
        RichTextBox_results.ForeColor = color_old
        If general_settings.general_variables.current_model = "orthotropic plate model" Then
            If numeric_b.Value > numeric_a.Value Then
                numeric_b.Value = numeric_a.Value
            End If
        ElseIf general_settings.general_variables.current_model = "grillage model" Then
            If numeric_a.Value > numeric_b.Value Then
                numeric_b.Value = numeric_a.Value
            End If
        End If
    End Sub
    Private Sub numericValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numeric_long.ValueChanged, numeric_short.ValueChanged
        Textbox_results.ForeColor = color_old
        RichTextBox_results.ForeColor = color_old
        If general_settings.general_variables.current_model = "Orthotropic Plate model" Then
            If textbox_geo_type.Text <> "" Then
                Select Case CInt(textbox_geo_type.Text)
                    Case 1
                        'nothing do to
                    Case 2, 3
                        If (numeric_short.Value Mod 2) = 0 Then
                            Panel2.Enabled = False
                            Panel3.Enabled = False
                            Panel4.Enabled = False
                        Else
                            Panel2.Enabled = True
                            Panel3.Enabled = True
                            Panel4.Enabled = True
                        End If
                    Case 4
                        If (numeric_short.Value Mod 2) = 0 Or (numeric_long.Value Mod 2) = 0 Or (numeric_short.Value < 3) Or (numeric_long.Value < 3) Then
                            'remove this (**
                            'Panel2.Enabled = False
                            'Panel3.Enabled = False
                            'Panel4.Enabled = False
                        Else
                            Panel2.Enabled = True
                            Panel3.Enabled = True
                            Panel4.Enabled = True
                        End If
                End Select
            End If
        ElseIf general_settings.general_variables.current_model = "Grillage model" Then
            If numeric_long.Value > numeric_short.Value Then
                numeric_short.Value = numeric_long.Value
            End If
        End If
    End Sub
    Private Sub Textbox_P_input_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textbox_P_input.TextChanged, textbox_E_input.TextChanged, textbox_ni_input.TextChanged
        Textbox_results.ForeColor = color_old
        RichTextBox_results.ForeColor = color_old
    End Sub
    Private Sub Button_result_save_text(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_results_save.Click
        ' Create a SaveFileDialog to request a path and file name to save to.
        Dim saveFile1 As New SaveFileDialog

        ' Initialize the SaveFileDialog to specify the TXT extension for the file.
        saveFile1.DefaultExt = "*.txt"
        saveFile1.Filter = "Text Files|*.txt"

        ' Determine if the user selected a file name from the saveFileDialog.
        If (saveFile1.ShowDialog() = System.Windows.Forms.DialogResult.OK) _
            And (saveFile1.FileName.Length) > 0 Then

            ' Save the contents of the RichTextBox into the file.
            RichTextBox_result_for_saving.SaveFile(saveFile1.FileName, _
                RichTextBoxStreamType.PlainText)
        End If
    End Sub
    Private Sub Button_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_update.Click
        Text_feed()
    End Sub
    Private Sub Text_feed()
        '*********TEXT FOR SAVING************'
        If RadioButton_add_after.Checked = True Then
            'no need to clear text
        ElseIf RadioButton_add_replace.Checked = True Then
            RichTextBox_result_for_saving.Clear()
        End If
        If RadioButton_default_english.Checked = True Then
            text_feed_default_english()
        Else
            text_feed_current_language()
        End If
        '***********TEXT ERRORS *********
        If general_settings.general_variables.current_model = "Orthotropic Plate model" Then
            If models_calculations.Orthotropic_model.model_variables.geo_type = 4 Then
                If models_calculations.Orthotropic_model.model_variables.C = 1 Then
                    RichTextBox_results.Text = language_settings.results_panel2_error_msg_case_04a
                ElseIf models_calculations.Orthotropic_model.model_variables.C = 2 Then
                    RichTextBox_results.Text = language_settings.results_panel2_error_msg_case_04b
                ElseIf models_calculations.Orthotropic_model.model_variables.C = 3 Then
                    RichTextBox_results.Text = language_settings.results_panel2_error_msg_case_04c
                ElseIf models_calculations.Orthotropic_model.model_variables.C = 4 Then
                    RichTextBox_results.Text = language_settings.results_panel2_error_msg_case_04d
                End If
            ElseIf models_calculations.Orthotropic_model.model_variables.geo_type = 3 Then
                RichTextBox_results.Text = language_settings.results_panel2_error_msg_case_03
            ElseIf models_calculations.Orthotropic_model.model_variables.geo_type = 2 Then
                RichTextBox_results.Text = language_settings.results_panel2_error_msg_case_02
            ElseIf models_calculations.Orthotropic_model.model_variables.geo_type = 1 Then
                RichTextBox_results.Text = language_settings.results_panel2_error_msg_case_01
            End If
        ElseIf general_settings.general_variables.current_model = "Grillage model" Then
            RichTextBox_results.Text = language_settings.results_panel2_error_msg_grillage_BC
        End If
        figures_show()
    End Sub
    Private Sub GUI_set(ByVal new_lang As String)
        language_settings.read_language(new_lang)
        If general_settings.general_variables.current_model = "Orthotropic Plate model" Then
            Me.Text = language_settings.results_text_Orthotropic
        ElseIf general_settings.general_variables.current_model = "Grillage model" Then
            Me.Text = language_settings.results_text_Grillage
        End If
        '**************** TOOLTIP *******************
        toolTip_result.AutoPopDelay = 5000
        toolTip_result.InitialDelay = 100
        toolTip_result.ReshowDelay = 500
        toolTip_result.ShowAlways = True
        toolTip_result.IsBalloon = True
        toolTip_result.UseAnimation = True
        toolTip_result.UseFading = True
        toolTip_result.SetToolTip(Button_more_error, language_settings.results_panel2_Button_more_error_tooltip)
        '****************END TOOLTIP ****************
        '**************** LISTVIEW ******************
        ListView_steps.Items(0).Text = language_settings.results_listview0
        ListView_steps.Items(1).Text = language_settings.results_listview1
        ListView_steps.Items(2).Text = language_settings.results_listview2
        ListView_steps.Items(3).Text = language_settings.results_listview3
        '************ END LISTVIEW *******************
        '**************PANEL01 - text*****************
        combobox_P_units.Items.Clear()
        combobox_P_units.Items.Insert(0, language_settings.unit_Pa)
        combobox_P_units.Items.Insert(1, language_settings.unit_KPa)
        combobox_P_units.Items.Insert(2, language_settings.unit_MPa)
        combobox_P_units.Text = combobox_P_units.Items(0)
        Button_view_parameters.Text = language_settings.results_Button_view_parameters
        Button_view_parameters.RightToLeft = language_settings.language_RTL
        label_t.Text = language_settings.thickness_t
        Label_data_unit.Text = language_settings.results_panel1_label_data_unit
        label_unit_m01.Text = language_settings.unit_meter
        label_unit_m02.Text = language_settings.unit_meter
        label_unit_mm01.Text = language_settings.unit_millimeter
        label_title.Text = language_settings.results_panel1_summary
        groupbox_plate_geo.Text = language_settings.results_panel1_groupbox_plate
        groupbox_general.Text = language_settings.results_panel1_groupbox_general
        button_BC_select.Text = language_settings.results_panel1_button_BC_select
        GroupBox_stiffeners.Text = language_settings.results_panel1_GroupBox_stiffeners
        Label_geometric.Text = language_settings.results_panel1_Label_geometric
        GroupBox_numeric_stiffeners.Text = language_settings.results_panel1_GroupBox_numeric_stiffeners
        Button_data_change.Text = language_settings.results_panel1_Button_data_change
        Label_longitudinals01.Text = language_settings.results_panel1_label_longitudinals
        Label_longitudinals02.Text = language_settings.results_panel1_label_longitudinals
        Label_transverse01.Text = language_settings.results_panel1_label_transverses
        Label_transverse02.Text = language_settings.results_panel1_label_transverses
        Label_central01.Text = language_settings.results_panel1_label_central
        Label_central02.Text = language_settings.results_panel1_label_central
        Label_central03.Text = language_settings.results_panel1_label_central
        Label_central04.Text = language_settings.results_panel1_label_central
        Label_non_central01.Text = language_settings.results_panel1_label_noncentral
        Label_non_central02.Text = language_settings.results_panel1_label_noncentral
        Label_non_central03.Text = language_settings.results_panel1_label_noncentral
        Label_non_central04.Text = language_settings.results_panel1_label_noncentral
        CheckBox_Ia.Text = language_settings.results_panel1_CheckBox_Ia
        CheckBox_Ib.Text = language_settings.results_panel1_CheckBox_Ib
        CheckBox_Ina.Text = language_settings.results_panel1_CheckBox_Ina
        CheckBox_Inb.Text = language_settings.results_panel1_CheckBox_Inb
        Label_b_change.Text = language_settings.results_panel1_Label_b_change
        Label_d_change.Text = language_settings.results_panel1_Label_d_change
        Label_mm_msg.Text = language_settings.results_panel1_Label_mm_msg
        Button_data_more.Text = language_settings.results_panel1_Button_data_more
        '*********FROM INPUT GUI ******************
        '==========================================
        Label_pressure.Text = language_settings.input_panel4_Label_pressure
        Label_E.Text = language_settings.input_panel4_Label_modulus
        label_ni.Text = language_settings.input_panel4_label_ni
        Label_BC.Text = language_settings.input_panel4_label_BC_title
        Label_GPa.Text = language_settings.unit_GPa
        '**************PANEL2 *****************
        Button_compute.Text = language_settings.results_panel2_Button_compute
        Button_more_error.Text = language_settings.results_panel2_Button_more_error
        label_msg01.Text = language_settings.results_panel2_label_msg01
        Label_SD.Text = language_settings.results_panel2_Label_SD
        '**************PANEL3 *****************
        RadioButton_default_english.Text = language_settings.results_panel3_RadioButton_default_english
        RadioButton_other_language.Text = language_settings.results_panel3_RadioButton_other_language
        RadioButton_add_after.Text = language_settings.results_panel3_RadioButton_add_after
        RadioButton_add_replace.Text = language_settings.results_panel3_RadioButton_add_replace
        GroupBox_choose_language.Text = language_settings.results_panel3_GroupBox_choose_language
        GroupBox_update.Text = language_settings.results_panel3_GroupBox_update
        Button_update.Text = language_settings.results_panel3_Button_update
        button_results_clear.Text = language_settings.results_panel3_button_results_clear
        button_results_save.Text = language_settings.results_panel3_button_results_save

        '**************PANEL4 *****************
        Label_Adina.Text = language_settings.results_panel4_Label_Adina
        RichTextBox_adina_msg.Text = language_settings.results_panel4_RichTextBox_adina_msg01 + Chr(13) + language_settings.results_panel4_RichTextBox_adina_msg02 + Chr(13) + language_settings.results_panel4_RichTextBox_adina_msg03 + Chr(13) + language_settings.results_panel4_RichTextBox_adina_msg04
        Button_Run_ADINA.Text = language_settings.results_panel4_Button_Run_ADINA
        Button_feed_ADINA.Text = language_settings.results_panel4_Button_feed_ADINA
        GroupBox_creation_type.Text = language_settings.results_panel4_groupbox_creation_type
        GroupBox_creation_type.RightToLeft = language_settings.language_RTL
        RadioButton_normal.Text = language_settings.results_panel4_radiobutton_normal
        RadioButton_normal.RightToLeft = language_settings.language_RTL
        RadioButton_fast.Text = language_settings.results_panel4_radiobutton_fast
        RadioButton_fast.RightToLeft = language_settings.language_RTL
        '**************layouts*****************
        Me.RightToLeftLayout = language_settings.language_RTL_layout
        Me.RightToLeft = language_settings.language_RTL
        label_title.RightToLeft = language_settings.language_RTL
        groupbox_plate_geo.RightToLeft = language_settings.language_RTL
        label_a.RightToLeft = language_settings.language_RTL
        label_b.RightToLeft = language_settings.language_RTL
        label_t.RightToLeft = language_settings.language_RTL
        label_unit_m01.RightToLeft = language_settings.language_RTL
        label_unit_m02.RightToLeft = language_settings.language_RTL
        label_unit_mm01.RightToLeft = language_settings.language_RTL
        groupbox_general.RightToLeft = language_settings.language_RTL
        Label_pressure.RightToLeft = language_settings.language_RTL
        Label_E.RightToLeft = language_settings.language_RTL
        label_ni.RightToLeft = language_settings.language_RTL
        Label_BC.RightToLeft = language_settings.language_RTL
        Label_GPa.RightToLeft = language_settings.language_RTL
        button_BC_select.RightToLeft = language_settings.language_RTL
        GroupBox_stiffeners.RightToLeft = language_settings.language_RTL
        GroupBox_stiffeners_number.RightToLeft = language_settings.language_RTL
        Label_geometric.RightToLeft = language_settings.language_RTL
        label_long.RightToLeft = language_settings.language_RTL
        label_short.RightToLeft = language_settings.language_RTL
        numeric_long.RightToLeft = language_settings.language_RTL
        numeric_short.RightToLeft = language_settings.language_RTL
        GroupBox_stiffeners_data.RightToLeft = language_settings.language_RTL
        GroupBox_numeric_stiffeners.RightToLeft = language_settings.language_RTL
        Label_data_unit.RightToLeft = language_settings.language_RTL
        Label_longitudinals01.RightToLeft = language_settings.language_RTL
        Label_longitudinals02.RightToLeft = language_settings.language_RTL
        Label_transverse01.RightToLeft = language_settings.language_RTL
        Label_transverse02.RightToLeft = language_settings.language_RTL
        Label_central01.RightToLeft = language_settings.language_RTL
        Label_central02.RightToLeft = language_settings.language_RTL
        Label_central03.RightToLeft = language_settings.language_RTL
        Label_central04.RightToLeft = language_settings.language_RTL
        Label_non_central01.RightToLeft = language_settings.language_RTL
        Label_non_central02.RightToLeft = language_settings.language_RTL
        Label_non_central03.RightToLeft = language_settings.language_RTL
        Label_non_central04.RightToLeft = language_settings.language_RTL
        CheckBox_Ia.RightToLeft = language_settings.language_RTL
        CheckBox_Ina.RightToLeft = language_settings.language_RTL
        CheckBox_Ib.RightToLeft = language_settings.language_RTL
        CheckBox_Inb.RightToLeft = language_settings.language_RTL
        Label_b_change.RightToLeft = language_settings.language_RTL
        Label_d_change.RightToLeft = language_settings.language_RTL
        Label_mm_msg.RightToLeft = language_settings.language_RTL
        Button_data_more.RightToLeft = language_settings.language_RTL
        Button_data_change.RightToLeft = language_settings.language_RTL
        '**************PANEL2 *****************
        Button_compute.RightToLeft = language_settings.language_RTL
        Button_more_error.RightToLeft = language_settings.language_RTL
        label_msg01.RightToLeft = language_settings.language_RTL
        Textbox_results.RightToLeft = language_settings.language_RTL
        RichTextBox_results.RightToLeft = language_settings.language_RTL
        '**************PANEL3 *****************
        RadioButton_default_english.RightToLeft = language_settings.language_RTL
        RadioButton_other_language.RightToLeft = language_settings.language_RTL
        RadioButton_add_after.RightToLeft = language_settings.language_RTL
        RadioButton_add_replace.RightToLeft = language_settings.language_RTL
        GroupBox_choose_language.RightToLeft = language_settings.language_RTL
        GroupBox_update.RightToLeft = language_settings.language_RTL
        Button_update.RightToLeft = language_settings.language_RTL
        button_results_clear.RightToLeft = language_settings.language_RTL
        button_results_save.RightToLeft = language_settings.language_RTL
        If RadioButton_default_english.Checked = True Then
            RichTextBox_result_for_saving.RightToLeft = Windows.Forms.RightToLeft.No
        Else
            RichTextBox_result_for_saving.RightToLeft = language_settings.language_RTL
        End If
        '**************PANEL4 *****************
        Button_feed_ADINA.RightToLeft = language_settings.language_RTL
        Button_Run_ADINA.RightToLeft = language_settings.language_RTL
        RichTextBox_model_qualify.RightToLeft = language_settings.language_RTL
        RichTextBox_adina_msg.RightToLeft = language_settings.language_RTL
        Label_Adina.RightToLeft = language_settings.language_RTL
        Textbox_results.RightToLeft = language_settings.language_RTL
        Label_SD.RightToLeft = language_settings.language_RTL
        If general_settings.general_variables.current_model = "Orthotropic Plate model" Then
            label_a.Text = language_settings.length_a
            label_b.Text = language_settings.breadth_b
            label_long.Text = language_settings.results_panel1_label_Na
            label_short.Text = language_settings.results_panel1_label_Nb
            GroupBox_stiffeners_number.Text = language_settings.results_panel1_groupbox_stiffeners_number
            GroupBox_stiffeners_geometric.Visible = True
            GroupBox_stiffeners_number.Size = New Size(191, 96)
        ElseIf general_settings.general_variables.current_model = "Grillage model" Then
            label_a.Text = language_settings.length_r_beams
            label_b.Text = language_settings.length_s_beams
            label_short.Text = language_settings.results_panel1_label_r
            label_long.Text = language_settings.results_panel1_label_s
            GroupBox_stiffeners_number.Text = language_settings.results_Grillage_requirement1
            GroupBox_stiffeners_geometric.Visible = False
            GroupBox_stiffeners_number.Size = New Size(321, 96)
            GroupBox_stiffeners_number.Location = New Point(6, GroupBox_stiffeners_number.Location.Y)
            If language_settings.language_RTL_layout = False Then
                numeric_long.Location = New Point(261, numeric_long.Location.Y)
                numeric_short.Location = New Point(261, numeric_short.Location.Y)
            Else
                numeric_long.Location = New Point(5, numeric_long.Location.Y)
                numeric_short.Location = New Point(5, numeric_short.Location.Y)
            End If
        End If
        ADINA_check()
        GUI_set_data_only_stiffeners(current_data)
    End Sub
    Function set_data() As Boolean
        continue_process = True
        If Me.Visible = True Then
            If general_settings.general_variables.current_model = "Orthotropic Plate model" Then
                'checking correctness of data
                '*********************************************************
                If general_functions.check_data(numeric_a.Value) = True Then
                    models_calculations.Orthotropic_model.model_variables.a = numeric_a.Value
                Else
                    general_settings.messages.read_msg(1)
                    general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                    continue_process = False
                End If
                '*********************************************************
                If general_functions.check_data(numeric_b.Value) = True Then
                    models_calculations.Orthotropic_model.model_variables.b = numeric_b.Value
                Else
                    general_settings.messages.read_msg(2)
                    general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                    continue_process = False
                End If
                '*********************************************************
                If CSng(numeric_b.Text) > CSng(numeric_a.Text) Then
                    general_settings.messages.read_msg(4)
                    general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                    If general_settings.messages.msg_res = MsgBoxResult.Yes Then
                        Dim temp As Single = numeric_a.Text
                        models_calculations.Orthotropic_model.model_variables.a = numeric_b.Text
                        models_calculations.Orthotropic_model.model_variables.b = temp
                    Else
                        continue_process = False
                    End If
                End If
                '*********************************************************
                If general_functions.check_data(numeric_t.Value) = True Then
                    models_calculations.Orthotropic_model.model_variables.t = numeric_t.Value / 1000
                Else
                    general_settings.messages.read_msg(3)
                    general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                    continue_process = False
                End If
                '*********************************************************
                If combobox_P_units.Text = language_settings.unit_Pa Then
                    If general_functions.check_data(textbox_P_input.Text) = True Then
                        models_calculations.Orthotropic_model.model_variables.P = textbox_P_input.Text
                    Else
                        general_settings.messages.read_msg(15)
                        general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                        continue_process = False
                    End If
                ElseIf combobox_P_units.Text = language_settings.unit_KPa Then
                    If general_functions.check_data(textbox_P_input.Text) = True Then
                        models_calculations.Orthotropic_model.model_variables.P = textbox_P_input.Text * 10 ^ 3
                    Else
                        general_settings.messages.read_msg(15)
                        general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                        continue_process = False
                    End If
                ElseIf combobox_P_units.Text = language_settings.unit_MPa Then
                    If general_functions.check_data(textbox_P_input.Text) = True Then
                        models_calculations.Orthotropic_model.model_variables.P = textbox_P_input.Text * 10 ^ 6
                    Else
                        general_settings.messages.read_msg(15)
                        general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                        continue_process = False
                    End If
                Else
                    general_settings.messages.read_msg(14)
                    general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                    continue_process = False
                End If
                '*********************************************************
                If general_functions.check_data(textbox_E_input.Text) = True Then
                    models_calculations.Orthotropic_model.model_variables.E = textbox_E_input.Text * 10 ^ 9
                Else
                    general_settings.messages.read_msg(16)
                    general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                    continue_process = False
                End If
                '*********************************************************
                If general_functions.check_data(textbox_ni_input.Text) = True Then
                    models_calculations.Orthotropic_model.model_variables.ni = textbox_ni_input.Text
                Else
                    general_settings.messages.read_msg(17)
                    general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                    continue_process = False
                End If
                '*********************************************************
                'Setting the data
                If (numeric_case_input.Value = 1) Or (numeric_case_input.Value = 2) Or (numeric_case_input.Value = 3) Or (numeric_case_input.Value = 4) Then
                    models_calculations.Orthotropic_model.model_variables.C = numeric_case_input.Value
                Else
                    general_settings.messages.read_msg(18)
                    general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                    continue_process = False
                End If
                '*********************************************************
                Select Case textbox_geo_type.Text
                    Case 1
                        'no need
                    Case 2
                        '*********************************************************
                        If general_functions.check_data(numeric_short.Value) = True Then
                            If (numeric_short.Value Mod 2) = 0 AndAlso (OK_even_numbers = False) Then
                                general_settings.messages.read_msg(19)
                                general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                                If general_settings.messages.msg_res = MsgBoxResult.Yes Then
                                    models_calculations.Orthotropic_model.model_variables.Nb = numeric_short.Value
                                    OK_even_numbers = True
                                Else
                                    continue_process = False
                                End If
                            Else
                                models_calculations.Orthotropic_model.model_variables.Nb = numeric_short.Value
                            End If
                        Else
                            general_settings.messages.read_msg(20)
                            general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                            continue_process = False
                        End If
                        '*********************************************************
                    Case 3
                        '*********************************************************
                        If general_functions.check_data(numeric_short.Value) = True Then
                            If (numeric_short.Value Mod 2) = 0 AndAlso (OK_even_numbers = False) Then
                                general_settings.messages.read_msg(19)
                                general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                                If general_settings.messages.msg_res = MsgBoxResult.Yes Then
                                    models_calculations.Orthotropic_model.model_variables.Nb = numeric_short.Value
                                    OK_even_numbers = True
                                Else
                                    continue_process = False
                                End If
                            Else
                                models_calculations.Orthotropic_model.model_variables.Nb = numeric_short.Value
                            End If
                        Else
                            general_settings.messages.read_msg(20)
                            general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                            continue_process = False
                        End If

                        models_calculations.Orthotropic_model.model_variables.Na = numeric_long.Value

                        '*********************************************************
                    Case 4
                        If general_functions.check_data(numeric_long.Value) = True Then
                            If (numeric_long.Value Mod 2) = 0 AndAlso (OK_even_numbers = False) Then
                                general_settings.messages.read_msg(19)
                                general_settings.messages.msg_style = MsgBoxStyle.YesNo
                                general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                                If general_settings.messages.msg_res = MsgBoxResult.Yes Then
                                    models_calculations.Orthotropic_model.model_variables.Na = numeric_long.Value
                                    OK_even_numbers = True
                                Else
                                    continue_process = False
                                End If
                            Else
                                models_calculations.Orthotropic_model.model_variables.Na = numeric_long.Value
                            End If
                        Else
                            general_settings.messages.read_msg(20)
                            general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                            continue_process = False
                        End If
                        '*********************************************************
                        If general_functions.check_data(numeric_short.Value) = True Then
                            If (numeric_short.Value Mod 2) = 0 AndAlso (OK_even_numbers = False) Then
                                general_settings.messages.read_msg(19)
                                general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                                If general_settings.messages.msg_res = MsgBoxResult.Yes Then
                                    models_calculations.Orthotropic_model.model_variables.Nb = numeric_short.Value
                                    OK_even_numbers = True
                                Else
                                    continue_process = False
                                End If
                            Else
                                models_calculations.Orthotropic_model.model_variables.Nb = numeric_short.Value
                            End If
                        Else
                            general_settings.messages.read_msg(20)
                            general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                            continue_process = False
                        End If
                        '*********************************************************
                End Select
                '///////////////// GRILLAGE MODEL /////////////////////
            ElseIf general_settings.general_variables.current_model = "Grillage model" Then
                If general_functions.check_data(numeric_b.Value) = True Then
                    models_calculations.Grillage_model.model_variables.b = numeric_b.Value
                Else
                    general_settings.messages.read_msg(1)
                    general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                    continue_process = False
                End If
                '*********************************************************
                If general_functions.check_data(numeric_a.Value) = True Then
                    models_calculations.Grillage_model.model_variables.a = numeric_a.Value
                Else
                    general_settings.messages.read_msg(2)
                    general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                    continue_process = False
                End If
                '*********************************************************
                ' TO BE COMPLETE LATER if needed
                'need to check if b>a is required
                'If CSng(numeric_b.Text) > CSng(numeric_a.Text) Then
                '    general_settings.messages.read_msg(4)
                '    general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                '    If general_settings.messages.msg_res = MsgBoxResult.Yes Then
                '        Dim temp As Single = numeric_a.Text
                '        models_calculations.Orthotropic_model.model_variables.a = numeric_b.Text
                '        models_calculations.Orthotropic_model.model_variables.b = temp
                '    Else
                '        continue_process = False
                '    End If
                'End If
                '*********************************************************
                If general_functions.check_data(numeric_t.Value) = True Then
                    models_calculations.Grillage_model.model_variables.t = numeric_t.Value / 1000
                Else
                    general_settings.messages.read_msg(3)
                    general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                    continue_process = False
                End If
                '*********************************************************
                If combobox_P_units.Text = language_settings.unit_Pa Then
                    If general_functions.check_data(textbox_P_input.Text) = True Then
                        models_calculations.Grillage_model.model_variables.P = textbox_P_input.Text
                    Else
                        general_settings.messages.read_msg(15)
                        general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                        continue_process = False
                    End If
                ElseIf combobox_P_units.Text = language_settings.unit_KPa Then
                    If general_functions.check_data(textbox_P_input.Text) = True Then
                        models_calculations.Grillage_model.model_variables.P = textbox_P_input.Text * 10 ^ 3
                    Else
                        general_settings.messages.read_msg(15)
                        general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                        continue_process = False
                    End If
                ElseIf combobox_P_units.Text = language_settings.unit_MPa Then
                    If general_functions.check_data(textbox_P_input.Text) = True Then
                        models_calculations.Grillage_model.model_variables.P = textbox_P_input.Text * 10 ^ 6
                    Else
                        general_settings.messages.read_msg(15)
                        general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                        continue_process = False
                    End If
                Else
                    general_settings.messages.read_msg(14)
                    general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                    continue_process = False
                End If
                '*********************************************************
                If general_functions.check_data(textbox_E_input.Text) = True Then
                    models_calculations.Grillage_model.model_variables.E = textbox_E_input.Text * 10 ^ 9
                Else
                    general_settings.messages.read_msg(16)
                    general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                    continue_process = False
                End If
                '*********************************************************
                If general_functions.check_data(textbox_ni_input.Text) = True Then
                    models_calculations.Grillage_model.model_variables.ni = textbox_ni_input.Text
                Else
                    general_settings.messages.read_msg(17)
                    general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                    continue_process = False
                End If
                '*********************************************************
                'Setting the data
                If (numeric_case_input.Value = 1) Or (numeric_case_input.Value = 2) Or (numeric_case_input.Value = 3) Or (numeric_case_input.Value = 4) Then
                    models_calculations.Grillage_model.model_variables.BC = numeric_case_input.Value
                Else
                    general_settings.messages.read_msg(18)
                    general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                    continue_process = False
                End If
                '*********************************************************
                If general_functions.check_data(numeric_short.Value) = True Then
                    If (numeric_long.Value Mod 2) = 0 Then
                        'remove this ***
                        models_calculations.Grillage_model.model_variables.r = numeric_short.Value
                        'and this ':
                        'general_settings.messages.read_msg(19)
                        ' general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                        'continue_process = False
                    Else
                        models_calculations.Grillage_model.model_variables.r = numeric_short.Value
                    End If
                Else
                    general_settings.messages.read_msg(20)
                    general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                    continue_process = False
                End If
                '*********************************************************
                If general_functions.check_data(numeric_long.Value) = True Then
                    If (numeric_short.Value Mod 2) = 0 AndAlso (OK_even_numbers = False) Then
                        'remove this ***
                        models_calculations.Grillage_model.model_variables.s = numeric_long.Value
                        'and this ':
                        'general_settings.messages.read_msg(19)
                        'general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                        'continue_process = False
                    Else
                        models_calculations.Grillage_model.model_variables.s = numeric_long.Value
                    End If
                Else
                    general_settings.messages.read_msg(20)
                    general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                    continue_process = False
                End If
                '*********************************************************
            End If
        End If
    End Function
    Function ADINA_check() As Boolean
        Dim OK_ADINA As Boolean = False
        'checking model geometric parameters
        ' TO BE COMPLETE LATER
        'grillage should be allowed
        If Me.Visible = True Then
            If general_settings.general_variables.current_model = "orthotropic plate model" Then
                If ((models_calculations.Orthotropic_model.model_variables.Ya_stiffener = models_calculations.Orthotropic_model.model_variables.Yna_stiffeners) AndAlso (models_calculations.Orthotropic_model.model_variables.Ya_stiffener = models_calculations.Orthotropic_model.model_variables.Yb_stiffener) AndAlso (models_calculations.Orthotropic_model.model_variables.Ya_stiffener = models_calculations.Orthotropic_model.model_variables.Ynb_stiffeners) And models_calculations.Orthotropic_model.model_variables.geo_type = 4) Or ((models_calculations.Orthotropic_model.model_variables.Ya_stiffener = models_calculations.Orthotropic_model.model_variables.Yb_stiffener) AndAlso (models_calculations.Orthotropic_model.model_variables.Ya_stiffener = models_calculations.Orthotropic_model.model_variables.Ynb_stiffeners) And models_calculations.Orthotropic_model.model_variables.geo_type = 3) Then
                    OK_ADINA = True
                Else
                    OK_ADINA = False
                End If
            ElseIf general_settings.general_variables.current_model = "grillage model" Then
                If (models_calculations.Grillage_model.model_variables.Yr_stiffeners = models_calculations.Grillage_model.model_variables.Ys_stiffeners) Then
                    OK_ADINA = True
                Else
                    OK_ADINA = False
                End If
            End If
            If OK_ADINA = False Then
                Button_feed_ADINA.Enabled = False
                PictureBox01.Image = ImageList_model.Images(1)
                PictureBox02.Image = ImageList_model.Images(1)
                RichTextBox_model_qualify.Text = language_settings.results_panel4_RichTextBox_model_qualify_not_ok_01 + Chr(13) + language_settings.results_panel4_RichTextBox_model_qualify_not_ok_02 + Chr(13) + language_settings.results_panel4_RichTextBox_model_qualify_not_ok_03 + Chr(13) + language_settings.results_panel4_RichTextBox_model_qualify_not_ok_04
                RichTextBox_model_qualify.ForeColor = Color.Red
            Else
                Button_feed_ADINA.Enabled = True
                PictureBox01.Image = ImageList_model.Images(0)
                PictureBox02.Image = ImageList_model.Images(0)
                RichTextBox_model_qualify.Text = language_settings.results_panel4_RichTextBox_model_qualify_ok_01 + Chr(13) + language_settings.results_panel4_RichTextBox_model_qualify_ok_02 + Chr(13) + language_settings.results_panel4_RichTextBox_model_qualify_ok_03 + Chr(13) + language_settings.results_panel4_RichTextBox_model_qualify_ok_04
                RichTextBox_model_qualify.ForeColor = Color.Blue
            End If
            If (result_deflection_SD <> 0) Then
                RichTextBox_model_qualify.Visible = True
                PictureBox01.Visible = True
                PictureBox02.Visible = True
                Button_feed_ADINA.Visible = True
                Button_Run_ADINA.Visible = True
            Else
                RichTextBox_model_qualify.Visible = False
                PictureBox01.Visible = False
                PictureBox02.Visible = False
                Button_feed_ADINA.Visible = False
                Button_Run_ADINA.Visible = False
            End If
            Return OK_ADINA
        End If
    End Function
    '********* END OK sections ************
    Private Sub figures_show()
        If general_settings.general_variables.current_model = "Orthotropic Plate model" Then
            If models_calculations.Orthotropic_model.model_variables.geo_type = 4 Then
                If models_calculations.Orthotropic_model.model_variables.C = 1 Then
                    PictureBox_figures.Image = My.Resources.both_models_BC1
                ElseIf models_calculations.Orthotropic_model.model_variables.C = 2 Then
                    PictureBox_figures.Image = My.Resources.both_models_BC2
                ElseIf models_calculations.Orthotropic_model.model_variables.C = 3 Then
                    PictureBox_figures.Image = My.Resources.both_models_BC3
                ElseIf models_calculations.Orthotropic_model.model_variables.C = 4 Then
                    PictureBox_figures.Image = My.Resources.both_models_BC4
                End If
            End If
        ElseIf general_settings.general_variables.current_model = "Grillage model" Then
            If models_calculations.Grillage_model.model_variables.BC = 1 Then
                PictureBox_figures.Image = My.Resources.both_models_BC1
            ElseIf models_calculations.Grillage_model.model_variables.BC = 2 Then
                PictureBox_figures.Image = My.Resources.both_models_BC2
            ElseIf models_calculations.Grillage_model.model_variables.BC = 3 Then
                PictureBox_figures.Image = My.Resources.both_models_BC3
            ElseIf models_calculations.Grillage_model.model_variables.BC = 4 Then
                PictureBox_figures.Image = My.Resources.both_models_BC4
            End If
        End If
        PictureBox_figures.Visible = True
    End Sub
    Private Sub Button_data_more_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_data_more.Click
        If current_data = "moment" Then
            current_data = "area"
            GUI_set_data_only_stiffeners(current_data)
        ElseIf current_data = "area" Then
            current_data = "center"
            GUI_set_data_only_stiffeners(current_data)
        ElseIf current_data = "center" Then
            current_data = "moment"
            GUI_set_data_only_stiffeners(current_data)
        End If
    End Sub
    Private Sub Button_ADINA_Run(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Run_ADINA.Click
        If GUI_ADINA.IsDisposed = True Then
            GUI_ADINA = New Adina_Generator.GUI_ADINA_main
        End If
        GUI_ADINA.model_ok = False
        GUI_ADINA.Label_status.Visible = True
        GUI_ADINA.Show()
    End Sub
    Private Sub Button_ADINA_feed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_feed_ADINA.Click
        If GUI_ADINA.IsDisposed = True Then
            GUI_ADINA = New Adina_Generator.GUI_ADINA_main
        End If
        If general_settings.general_variables.current_model = "Orthotropic Plate model" Then
            GUI_ADINA.model_ok = True
            GUI_ADINA.Label_status.Visible = True
            GUI_ADINA.numeric_a.Value = models_calculations.Orthotropic_model.model_variables.a
            GUI_ADINA.numeric_a.Text = models_calculations.Orthotropic_model.model_variables.a
            GUI_ADINA.numeric_b.Value = models_calculations.Orthotropic_model.model_variables.b
            GUI_ADINA.numeric_b.Text = models_calculations.Orthotropic_model.model_variables.b
            GUI_ADINA.numeric_t.Value = models_calculations.Orthotropic_model.model_variables.t * 1000
            GUI_ADINA.numeric_t.Text = models_calculations.Orthotropic_model.model_variables.t * 1000
            GUI_ADINA.textbox_P_input.Text = models_calculations.Orthotropic_model.model_variables.P
            GUI_ADINA.textbox_E_input.Text = models_calculations.Orthotropic_model.model_variables.E / 10 ^ 9
            GUI_ADINA.textbox_ni_input.Text = models_calculations.Orthotropic_model.model_variables.ni
            GUI_ADINA.numeric_case_input.Value = models_calculations.Orthotropic_model.model_variables.C
            GUI_ADINA.numeric_case_input.Text = models_calculations.Orthotropic_model.model_variables.C
            GUI_ADINA.numeric_na.Value = models_calculations.Orthotropic_model.model_variables.Na
            GUI_ADINA.numeric_na.Text = models_calculations.Orthotropic_model.model_variables.Na
            GUI_ADINA.numeric_nb.Value = models_calculations.Orthotropic_model.model_variables.Nb
            GUI_ADINA.numeric_nb.Text = models_calculations.Orthotropic_model.model_variables.Nb
            GUI_ADINA.Textbox_H_general.Text = (models_calculations.Orthotropic_model.model_variables.Ya_stiffener * 2) * 1000
            If models_calculations.Orthotropic_model.model_variables.geo_type = 4 Then
                GUI_ADINA.Textbox_Ta.Text = (models_calculations.Orthotropic_model.model_variables.Aa_stiffener / (models_calculations.Orthotropic_model.model_variables.Ya_stiffener * 2)) * 1000
                GUI_ADINA.Textbox_Tna.Text = (models_calculations.Orthotropic_model.model_variables.Ana_stiffeners / (models_calculations.Orthotropic_model.model_variables.Yna_stiffeners * 2)) * 1000
                GUI_ADINA.Textbox_Tna.Enabled = True
                GUI_ADINA.Textbox_Tb.Text = (models_calculations.Orthotropic_model.model_variables.Ab_stiffener / (models_calculations.Orthotropic_model.model_variables.Yb_stiffener * 2)) * 1000
                GUI_ADINA.Textbox_Tnb.Text = (models_calculations.Orthotropic_model.model_variables.Anb_stiffeners / (models_calculations.Orthotropic_model.model_variables.Ynb_stiffeners * 2)) * 1000
            ElseIf models_calculations.Orthotropic_model.model_variables.geo_type = 3 Then
                GUI_ADINA.Textbox_Ta.Text = (models_calculations.Orthotropic_model.model_variables.Aa_stiffener / (models_calculations.Orthotropic_model.model_variables.Ya_stiffener * 2)) * 1000
                GUI_ADINA.Textbox_Tna.Text = (models_calculations.Orthotropic_model.model_variables.Aa_stiffener / (models_calculations.Orthotropic_model.model_variables.Ya_stiffener * 2)) * 1000
                GUI_ADINA.Textbox_Tna.Enabled = False
                GUI_ADINA.Textbox_Tb.Text = (models_calculations.Orthotropic_model.model_variables.Ab_stiffener / (models_calculations.Orthotropic_model.model_variables.Yb_stiffener * 2)) * 1000
                GUI_ADINA.Textbox_Tnb.Text = (models_calculations.Orthotropic_model.model_variables.Anb_stiffeners / (models_calculations.Orthotropic_model.model_variables.Ynb_stiffeners * 2)) * 1000
            End If
        ElseIf general_settings.general_variables.current_model = "Grillage model" Then

            GUI_ADINA.model_ok = True
            GUI_ADINA.Label_status.Visible = True
            GUI_ADINA.numeric_a.Value = models_calculations.Grillage_model.model_variables.a
            GUI_ADINA.numeric_a.Text = models_calculations.Grillage_model.model_variables.b
            GUI_ADINA.numeric_b.Value = models_calculations.Grillage_model.model_variables.a
            GUI_ADINA.numeric_b.Text = models_calculations.Grillage_model.model_variables.a
            GUI_ADINA.numeric_t.Value = models_calculations.Grillage_model.model_variables.t * 1000
            GUI_ADINA.numeric_t.Text = models_calculations.Grillage_model.model_variables.t * 1000
            GUI_ADINA.textbox_P_input.Text = models_calculations.Grillage_model.model_variables.P
            GUI_ADINA.textbox_E_input.Text = models_calculations.Grillage_model.model_variables.E / 10 ^ 9
            GUI_ADINA.textbox_ni_input.Text = models_calculations.Grillage_model.model_variables.ni
            GUI_ADINA.numeric_case_input.Value = models_calculations.Grillage_model.model_variables.BC
            GUI_ADINA.numeric_case_input.Text = models_calculations.Grillage_model.model_variables.BC
            GUI_ADINA.numeric_na.Value = models_calculations.Grillage_model.model_variables.s
            GUI_ADINA.numeric_na.Text = models_calculations.Grillage_model.model_variables.s
            GUI_ADINA.numeric_nb.Value = models_calculations.Grillage_model.model_variables.r
            GUI_ADINA.numeric_nb.Text = models_calculations.Grillage_model.model_variables.r
            GUI_ADINA.Textbox_H_general.Text = (models_calculations.Grillage_model.model_variables.Yr_stiffeners * 2) * 1000
            GUI_ADINA.Textbox_Tna.Enabled = True
            GUI_ADINA.Textbox_Ta.Text = (models_calculations.Grillage_model.model_variables.As_stiffeners / (models_calculations.Grillage_model.model_variables.Ys_stiffeners * 2)) * 1000
            GUI_ADINA.Textbox_Tna.Text = (models_calculations.Grillage_model.model_variables.As_stiffeners / (models_calculations.Grillage_model.model_variables.Ys_stiffeners * 2)) * 1000
            GUI_ADINA.Textbox_Tb.Text = (models_calculations.Grillage_model.model_variables.Ar_stiffeners / (models_calculations.Grillage_model.model_variables.Yr_stiffeners * 2)) * 1000
            GUI_ADINA.Textbox_Tnb.Text = (models_calculations.Grillage_model.model_variables.Ar_stiffeners / (models_calculations.Grillage_model.model_variables.Yr_stiffeners * 2)) * 1000
        End If
        GUI_ADINA.Show()
        If RadioButton_fast.Checked Then
            'GUI_ADINA.Size = New Size(0, 0)
            GUI_ADINA.hide_panels()
            GUI_ADINA.Panel_create_model.Dock = DockStyle.Fill
            GUI_ADINA.Panel_create_model.Visible = True
            GUI_ADINA.Button_gen_Click(sender, e)
            GUI_ADINA.RichTextBox_macro.Update()
            GUI_ADINA.Button_save_macro_Click(sender, e)
            GUI_ADINA.Dispose()
        End If
    End Sub
    Private Sub text_feed_current_language()
        Dim text_results As String = ""
        If general_settings.general_variables.current_model = "Orthotropic Plate model" Then
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
        ElseIf general_settings.general_variables.current_model = "Grillage model" Then
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
        Else
            ' TO BE COMPLETE LATER
            ' TO BE COMPLETE LATER
            ' TO BE COMPLETE LATER
            ' TO BE COMPLETE LATER
            ' TO BE COMPLETE LATER
            ' TO BE COMPLETE LATER
            ' TO BE COMPLETE LATER
            ' TO BE COMPLETE LATER
        End If
        RichTextBox_result_for_saving.RightToLeft = language_settings.language_RTL
        RichTextBox_result_for_saving.Text += text_results
    End Sub
    Private Sub text_feed_default_english_HTML()
        Dim text_results As String = "<html><head><title>Stiffened Plate Evaluator 1.8.3 Analysis Report</title>" & vbCr & _
                       "<meta http-equiv=""Content-Type"" content=""text/html; charset=unicode"">" & vbCr & _
           "<style type=""text/css"">" & vbCr & _
           "BODY {" & vbCr & _
           "SCROLLBAR-FACE-COLOR: #dddddd; FONT-SIZE: 10px; SCROLLBAR-HIGHLIGHT-COLOR: #dddddd; SCROLLBAR-SHADOW-COLOR: #555555; COLOR: #000000; SCROLLBAR-3DLIGHT-COLOR: #555555; SCROLLBAR-ARROW-COLOR: #555555; SCROLLBAR-TRACK-COLOR: #ffffff; FONT-FAMILY: Verdana; SCROLLBAR-DARKSHADOW-COLOR: #cccccc" & vbCr & _
           "}" & vbCr & _
           ".Footerbar {" & vbCr & _
           "BORDER-TOP: 1px none #7f8893;" & vbCr & _
           "FONT-SIZE: 10px;" & vbCr & _
           "BACKGROUND: #CCCCCC;" & vbCr & _
           "MARGIN-BOTTOM: 5px;" & vbCr & _
           "COLOR: #000000;" & vbCr & _
           "BORDER-BOTTOM: 1px none black;" & vbCr & _
           "FONT-FAMILY: Verdana, Arial, Helvetica, sans-serif;" & vbCr & _
           "padding: 3px;" & vbCr & _
           "}" & vbCr & _
           ".Menubar {" & vbCr & _
           "BORDER-TOP: #7f8893 1px solid; FONT-SIZE: 10px; BACKGROUND: #8492ad; COLOR: white; BORDER-BOTTOM: black 1px solid; FONT-FAMILY: Verdana, Arial, Helvetica, sans-serif" & vbCr & _
           "}" & vbCr & _
           ".TopBar1 {" & vbCr & _
           "BORDER-TOP: #7f8893 1px solid; PADDING-LEFT: 5px; FONT-SIZE: 16px; BACKGROUND: #8492ad; COLOR: white; BORDER-BOTTOM: black 1px solid; FONT-FAMILY: Verdana, Arial, Helvetica, sans-serif" & vbCr & _
           "}" & vbCr & _
           ".csSmall {" & vbCr & _
           "FONT-SIZE: 10px; COLOR: #ffffff; FONT-FAMILY: Verdana, Arial, Helvetica, sans-serif" & vbCr & _
           "}" & vbCr & _
           ".TitleB {" & vbCr & _
           "BORDER-RIGHT: #cccccc 1px solid; BORDER-TOP: #cccccc 1px solid; FONT-WEIGHT: bold; FONT-SIZE: 16px; BORDER-LEFT: #cccccc 1px solid; COLOR: #000000; BORDER-BOTTOM: #cccccc 1px solid; FONT-FAMILY: Verdana, Arial, Helvetica, sans-serif" & vbCr & _
           "}" & vbCr & _
           ".Sep {" & vbCr & _
           "BORDER-TOP: #cccccc 1px solid; FONT-SIZE: 6px; COLOR: #999999; FONT-FAMILY: Arial, Helvetica, sans-serif; BORDER-RIGHT-STYLE: none; BORDER-LEFT-STYLE: none; BORDER-BOTTOM-STYLE: none" & vbCr & _
           "}" & vbCr & _
           "TD {" & vbCr & _
           "FONT-SIZE: 12px; COLOR: #000000; FONT-FAMILY: Verdana, Arial, Helvetica, sans-serif" & vbCr & _
           "}" & vbCr & _
           "</style>" & vbCr & _
           "<script language=""JavaScript"" type=""text/JavaScript"">" & vbCr & _
           "<!--" & vbCr & _
           "function MM_reloadPage(init) {  //reloads the window if Nav4 resized" & vbCr & _
           "if (init==true) with (navigator) {if ((appName==""Netscape"")&&(parseInt(appVersion)==4)) {" & vbCr & _
           "document.MM_pgW=innerWidth; document.MM_pgH=innerHeight; onresize=MM_reloadPage; }}" & vbCr & _
           "else if (innerWidth!=document.MM_pgW || innerHeight!=document.MM_pgH) location.reload();" & vbCr & _
           "}" & vbCr & _
           "MM_reloadPage(true);" & vbCr & _
           "//-->" & vbCr & _
           "</script>" & vbCr & _
           "<style type=""text/css"">" & vbCr & _
           ".TopBarBlack {" & vbCr & _
           "BORDER-TOP: #7f8893 1px solid; PADDING-LEFT: 5px; FONT-SIZE: 16px; BACKGROUND: #003366; COLOR: white; BORDER-BOTTOM: black 1px solid; FONT-FAMILY: Verdana, Arial, Helvetica, sans-serif" & vbCr & _
           "}" & vbCr & _
           ".TopBarBlack A:link {" & vbCr & _
           "COLOR: white; TEXT-DECORATION: underline" & vbCr & _
           "}" & vbCr & _
           ".TopBarBlack A:visited {" & vbCr & _
           "COLOR: white; TEXT-DECORATION: underline" & vbCr & _
           "}" & vbCr & _
           ".TopBarBlack A:active {" & vbCr & _
           "COLOR: white; TEXT-DECORATION: underline" & vbCr & _
           "}" & vbCr & _
           ".TopBarBlack A:hover {" & vbCr & _
           "COLOR: #e39127; TEXT-DECORATION: underline" & vbCr & _
           "}" & vbCr & _
           ".Link1 A:link {" & vbCr & _
           "COLOR: black; TEXT-DECORATION: underline" & vbCr & _
           "}" & vbCr & _
           ".Link1 A:visited {" & vbCr & _
           "COLOR: black; TEXT-DECORATION: underline" & vbCr & _
           "}" & vbCr & _
           ".Link1 A:active {" & vbCr & _
           "COLOR: black; TEXT-DECORATION: underline" & vbCr & _
           "}" & vbCr & _
           ".Link1 A:hover {" & vbCr & _
           "COLOR: #e39127; TEXT-DECORATION: underline" & vbCr & _
           "}" & vbCr & _
           ".Link2 A:link {" & vbCr & _
           "COLOR: white; TEXT-DECORATION: underline" & vbCr & _
           "}" & vbCr & _
           ".Link2 A:visited {" & vbCr & _
           "COLOR: white; TEXT-DECORATION: underline" & vbCr & _
           "}" & vbCr & _
           ".Link2 A:active {" & vbCr & _
           "COLOR: white; TEXT-DECORATION: underline" & vbCr & _
           "}" & vbCr & _
           ".Link2 A:hover {" & vbCr & _
           "COLOR: #e39127; TEXT-DECORATION: underline" & vbCr & _
           "}" & vbCr & _
           "TABLE.INNER {" & vbCr & _
           "background-color:#405F8B;" & vbCr & _
           "color:white;" & vbCr & _
           "padding:0pt;" & vbCr & _
           "font-size:9pt;" & vbCr & _
           "width:100%;" & vbCr & _
           "border: 0pt solid CCCCCC;" & vbCr & _
           "}" & vbCr & _
           "INPUT.STATE  {" & vbCr & _
           "cursor:hand;" & vbCr & _
           "width:14pt;" & vbCr & _
           "height:13pt;" & vbCr & _
           "margin-left: 2pt;" & vbCr & _
           "margin-right: 4pt;" & vbCr & _
           "margin-bottom:1pt;" & vbCr & _
           "line-height:normal;" & vbCr & _
           "font-weight:bold;" & vbCr & _
           "font-size:12pt;" & vbCr & _
           "font-family:Courier;" & vbCr & _
           "vertical-align: top;" & vbCr & _
           "}" & vbCr & _
           "INPUT.SUBSTATE  {" & vbCr & _
           "cursor:hand;" & vbCr & _
           "width:11pt;" & vbCr & _
           "height:11pt;" & vbCr & _
           "margin-left: 1pt;" & vbCr & _
           "margin-right: 1pt;" & vbCr & _
           "margin-bottom:2pt;" & vbCr & _
           "line-height:normal;" & vbCr & _
           "font-weight:normal;" & vbCr & _
           "font-size:6pt;" & vbCr & _
           "font-family:Courier;" & vbCr & _
           "vertical-align: top" & vbCr & _
           "}" & vbCr & _
           "TD.EXPANDED    { padding-right:10px ; padding-top:10pt; padding-left:5pt; border-style:solid; border-width:1pt; background-color:white; color:black; display:visible; width:100% }" & vbCr & _
           "TD.COLLAPSED   { padding-right:10px ; padding-top:10pt; padding-left:5pt; border-style:solid; border-width:1pt; background-color:white; color:black; display:none; width:100% }" & vbCr & _
           "TH.INNER       { font-size:10pt; color:#FFFFFF; background-color:#003366; text-indent:2px; font-weight:bold; text-align:left; padding:0pt;  width:100% }" & vbCr & _
           "div.EXPANDED  { display:visible;margin-left:10px }" & vbCr & _
           "div.COLLAPSED { display:none;margin-left:20px }" & vbCr & _
           "</style>" & vbCr & _
           "<script language=""JavaScript""><!--" & vbCr & _
           "function ShowRow(srcElement,ElementID)" & vbCr & _
           "{" & vbCr & _
           "var srcValue=srcElement.value;" & vbCr & _
           "if (srcValue=='-')" & vbCr & _
           "{" & vbCr & _
           "srcElement.value = '+';" & vbCr & _
           "document.getElementById(ElementID).className=""COLLAPSED"";" & vbCr & _
           "}" & vbCr & _
           "else" & vbCr & _
           "{" & vbCr & _
           "srcElement.value = '-';" & vbCr & _
           "document.getElementById(ElementID).className=""EXPANDED"";" & vbCr & _
           "} " & vbCr & _
           "}" & vbCr & _
           "function expandCollapseAll(strNewClass)" & vbCr & _
           "{" & vbCr & _
           "theForm =  document.form1;" & vbCr & _
           "document.getElementById('JobInfo').className=strNewClass;" & vbCr & _
           "document.getElementById('BackupInfo').className=strNewClass;" & vbCr & _
           "document.getElementById('BckpSmryInfo').className=strNewClass;	" & vbCr & _
           "document.getElementById('DataIntgrtyTst').className=strNewClass;" & vbCr & _
           "if (strNewClass=='EXPANDED')" & vbCr & _
           "{" & vbCr & _
           "theForm.btnJobInfo.value='-';" & vbCr & _
           "theForm.btnBackupInfo.value='-';" & vbCr & _
           "theForm.btnBckpSmryInfo.value='-';" & vbCr & _
           "theForm.btnDataIntgrtyTst.value='-';" & vbCr & _
           "}" & vbCr & _
           "else" & vbCr & _
           "{" & vbCr & _
           "theForm.btnJobInfo.value='+';" & vbCr & _
           "theForm.btnBackupInfo.value='+';" & vbCr & _
           "theForm.btnBckpSmryInfo.value='+';" & vbCr & _
           "theForm.btnDataIntgrtyTst.value='+';" & vbCr & _
           "}" & vbCr & _
           "}" & vbCr & _
           "--></script>" & vbCr & _
           "<meta content=""MSHTML 6.00.2800.1106"" name=""SPE GENERATOR""></head><body leftmargin=""5"" topmargin=""5"" marginheight=""5"" marginwidth=""5"">" & vbCr & _
           "<form name=""form1"">" & vbCr & _
           "<table border=""0"" cellpadding=""0"" cellspacing=""0"" height=""368"" width=""100%"">" & vbCr & _
           "<tbody>" & vbCr & _
           "<tr>" & vbCr & _
           "<td class=""TopBarBlack"" height=""38""><strong>Stiffened Plate Evaluator 1.8.2 - Analysis Report</strong><span class=""csSmall""><br>" & vbCr & _
           "<a target=""_new"" href=""http://spe.tekcities.com/"">http://spe.tekcities.com/</a></span></td></tr>" & vbCr & _
           "<tr>" & vbCr & _
           "<tr>" & vbCr & _
           "<td height=""70"" valign=""top"">" & vbCr & _
           "&nbsp;" & vbCr & _
           "<table class=""INNER"" border=""0"" width=""100%"">" & vbCr & _
           "<tbody><tr>" & vbCr & _
           "<th class=""INNER"">" & vbCr & _
           "<p dir=""ltr"">" & vbCr & _
           "<input name=""btnJobInfo"" class=""STATE"" onclick=""ShowRow(this,'JobInfo');"" value=""-"" type=""button"">" & vbCr & _
           "General Information</th>" & vbCr & _
           "</tr>" & vbCr & _
           "<tr>" & vbCr & _
           "<td class=""EXPANDED"" id=""JobInfo"" height=""44""><b>Model Used:</b>"

        If general_settings.general_variables.current_model = "Orthotropic Plate model" Then
            text_results += " Orthotropic Plate model <br><b>" & vbCr & _
            "Analysis Type:</b> Maximum Deflection (Due To Uniform Pressure)<br><b>" & vbCr & _
            "Analysis Time:</b> " & DateTime.Now.ToString & "<br><b>Number of Times This Model has been used:</b>" & general_settings.general_variables.orthotropic_count_results & "<br><br><!--$JobInfo$--></td>" & vbCr & _
            "</tr>" & vbCr & _
            "</tbody></table></td>" & vbCr & _
            "</tr>" & vbCr & _
            "<tr>" & vbCr & _
            "<td height=""18"">&nbsp;</td>" & vbCr & _
            "</tr>" & vbCr & _
            "<tr>" & vbCr & _
            "<td height=""85"" valign=""top"">" & vbCr & _
            "<table class=""INNER"" border=""0"" width=""100%"">" & vbCr & _
            "<tbody><tr>" & vbCr & _
            "<th class=""INNER"">" & vbCr & _
            "<p dir=""ltr"">" & vbCr & _
            "<input name=""btnBackupInfo"" class=""STATE"" onclick=""ShowRow(this,'BackupInfo');"" value=""-"" type=""button"">" & vbCr & _
            "<strong>Input DATA</strong></th>" & vbCr & _
            "</tr>" & vbCr & _
            "<tr>" & vbCr & _
            "<td class=""EXPANDED"" id=""BackupInfo"" height=""58""><b>Geometric configuration: </b>"
        Else
            text_results += " Grillage model <br><b>" & vbCr & _
            "Analysis Type:</b> Maximum Deflection (Due To Uniform Pressure)<br><b>" & vbCr & _
            "Analysis Time:</b> " & DateTime.Now.ToString & "<br><b>Number of Times This Model has been used:</b>" & general_settings.general_variables.Grillage_count_results & "<br><br><!--$JobInfo$--></td>" & vbCr & _
            "</tr>" & vbCr & _
            "</tbody></table></td>" & vbCr & _
            "</tr>" & vbCr & _
            "<tr>" & vbCr & _
            "<td height=""18"">&nbsp;</td>" & vbCr & _
            "</tr>" & vbCr & _
            "<tr>" & vbCr & _
            "<td height=""85"" valign=""top"">" & vbCr & _
            "<table class=""INNER"" border=""0"" width=""100%"">" & vbCr & _
            "<tbody><tr>" & vbCr & _
            "<th class=""INNER"">" & vbCr & _
            "<p dir=""ltr"">" & vbCr & _
            "<input name=""btnBackupInfo"" class=""STATE"" onclick=""ShowRow(this,'BackupInfo');"" value=""-"" type=""button"">" & vbCr & _
            "<strong>Input DATA</strong></th>" & vbCr & _
            "</tr>" & vbCr & _
            "<tr>" & vbCr & _
            "<td class=""EXPANDED"" id=""BackupInfo"" height=""58""><b>Geometric configuration: </b>"
        End If

            'If general_settings.general_variables.current_model = "Orthotropic Plate model" Then
            '    text_results = My.Application.Info.Title & " " & DateTime.Now.ToString + Chr(13) + "====================================================================================" + Chr(13) + "*********** RESULTS OBTAINED USING THE ORTHOTROPIC PLATE MODEL ****************" + vbCr + _
            '    "Input data:" + Chr(13) + Chr(13) + "Geometric configuration: "
            '    If models_calculations.Orthotropic_model.model_variables.geo_type = 1 Then
            '        text_results += "Plate without stiffeners"
            '    ElseIf models_calculations.Orthotropic_model.model_variables.geo_type = 2 Then
            '        text_results += "Plate with transverse stiffeners only"
            '    ElseIf models_calculations.Orthotropic_model.model_variables.geo_type = 3 Then
            '        text_results += "Plate with transverse stiffeners and central longitudinal stiffener"
            '    ElseIf models_calculations.Orthotropic_model.model_variables.geo_type = 4 Then
            '        text_results += "Plate with longitudinal and transverse stiffeners"
            '    Else
            '        text_results += "No geometric configuration could be detected." + Chr(13) + "Either the model hasn't been used yet or the model parameters have been re-initialized/cleared."
            '    End If
            '    text_results += Chr(13) + Chr(13) + "Plate data:" + Chr(13) + _
            '    vbTab + "Length (a): " + CStr(models_calculations.Orthotropic_model.model_variables.a) + " [m]" + Chr(13) + _
            '    vbTab + "Width (b): " + CStr(models_calculations.Orthotropic_model.model_variables.b) + " [m]" + Chr(13) + _
            '    vbTab + "Thickness (t): " + CStr(models_calculations.Orthotropic_model.model_variables.t * 1000) + " [mm]" + Chr(13) + _
            '    Chr(13) + "Boundary conditions, Load and Material properties: " + Chr(13) + _
            '    vbTab + "Uniform pressure: " + CStr(models_calculations.Orthotropic_model.model_variables.P) + " [Pa]" + Chr(13) + _
            '    vbTab + "Young's modulus: " + CStr(models_calculations.Orthotropic_model.model_variables.E / 10 ^ 9) + " [GPa]" + Chr(13) + _
            '    vbTab + "Poisson’s ratio: " + CStr(models_calculations.Orthotropic_model.model_variables.ni) + Chr(13)
            '    If models_calculations.Orthotropic_model.model_variables.C = 1 Then
            '        text_results += vbTab + "Boundary conditions: All edges are Simply Supported" + Chr(13)
            '    ElseIf models_calculations.Orthotropic_model.model_variables.C = 2 Then
            '        text_results += vbTab + "Boundary conditions: Both short edges are fixed and both long edges are simply supported." + Chr(13)
            '    ElseIf models_calculations.Orthotropic_model.model_variables.C = 3 Then
            '        text_results += vbTab + "Boundary conditions: Both long edges are fixed and both short edges are simply supported." + Chr(13)
            '    ElseIf models_calculations.Orthotropic_model.model_variables.C = 4 Then
            '        text_results += vbTab + "Boundary conditions: All four edges are fixed/clamped (All six degrees of freedom are fixed at the edges)." + Chr(13)
            '    End If

            '    '*******STIFFENERS *****
            '    text_results += Chr(13) + "Stiffeners:" + Chr(13) + _
            '    vbTab + "Number of longitudinal stiffeners (Na): " + CStr(models_calculations.Orthotropic_model.model_variables.Na) + Chr(13) + _
            '    vbTab + "Number of transverse stiffeners (Nb): " + CStr(models_calculations.Orthotropic_model.model_variables.Nb) + Chr(13) + Chr(13) + _
            '    "Stiffeners' properties:" & vbCr & _
            '    vbTab & "longitudinal stiffeners" & vbCr & _
            '    vbTab & vbTab & "Central stiffener:" & vbCr & _
            '    vbTab & vbTab & vbTab & "Moment of inertia: " & CStr(models_calculations.Orthotropic_model.model_variables.Ia_stiffener) & " [" & "m^4" & "]" & vbCr & _
            '    vbTab & vbTab & vbTab & "Area of cross section: " & CStr(models_calculations.Orthotropic_model.model_variables.Aa_stiffener) & " [" & "m²" & "]" & vbCr & _
            '    vbTab & vbTab & vbTab & "Centroid of cross section: " + CStr(models_calculations.Orthotropic_model.model_variables.Ya_stiffener) & " [" & "m" & "]" & vbCr & vbCr & _
            '    vbTab & vbTab & "Non-Central stiffeners:" & Chr(13) & _
            '    vbTab & vbTab & vbTab & "Moment of inertia: " & CStr(models_calculations.Orthotropic_model.model_variables.Ina_stiffeners) & " [" & "m^4" & "]" & vbCr & _
            '    vbTab & vbTab & vbTab & "Area of cross section: " & CStr(models_calculations.Orthotropic_model.model_variables.Ana_stiffeners) & " [" & "m²" & "]" & vbCr & _
            '    vbTab & vbTab & vbTab & "Centroid of cross section: " + CStr(models_calculations.Orthotropic_model.model_variables.Yna_stiffeners) & " [" & "m" & "]" & vbCr & vbCr & _
            '    vbTab & "Transverse stiffeners" + Chr(13) + _
            '    vbTab & vbTab & "Central stiffener:" + Chr(13) + _
            '    vbTab & vbTab & vbTab & "Moment of inertia: " & CStr(models_calculations.Orthotropic_model.model_variables.Ib_stiffener) & " [" & "m^4" & "]" & vbCr & _
            '    vbTab & vbTab & vbTab & "Area of cross section: " & CStr(models_calculations.Orthotropic_model.model_variables.Ab_stiffener) & " [" & "m²" & "]" & vbCr & _
            '    vbTab & vbTab & vbTab & "Centroid of cross section: " + CStr(models_calculations.Orthotropic_model.model_variables.Yb_stiffener) & " [" & "m" & "]" & vbCr & vbCr & _
            '    vbTab & vbTab & "Non-Central stiffeners:" & Chr(13) & _
            '    vbTab & vbTab & vbTab & "Moment of inertia: " & CStr(models_calculations.Orthotropic_model.model_variables.Inb_stiffeners) & " [" & "m^4" & "]" & vbCr & _
            '    vbTab & vbTab & vbTab & "Area of cross section: " & CStr(models_calculations.Orthotropic_model.model_variables.Anb_stiffeners) & " [" & "m²" & "]" & vbCr & _
            '    vbTab & vbTab & vbTab & "Centroid of cross section: " + CStr(models_calculations.Orthotropic_model.model_variables.Ynb_stiffeners) & " [" & "m" & "]" & vbCr & vbCr & _
            '    "====================================================================================" + Chr(13) + _
            '    "Orthotropic Model's Intermediates Calculations:" + Chr(13) + _
            '    "Sa: " + CStr(models_calculations.Orthotropic_model.model_variables.Sa) + " [m]" + Chr(13) + _
            '    "Sb: " + CStr(models_calculations.Orthotropic_model.model_variables.Sb) + " [m]" + Chr(13) + _
            '    "Lambda (a): " + CStr(models_calculations.Orthotropic_model.model_variables.lamda_a) + " [m]" + Chr(13) + _
            '    "Lambda (b): " + CStr(models_calculations.Orthotropic_model.model_variables.lamda_b) + " [m]" + Chr(13) + _
            '    "moment of inertia of plate only (longer edge - Ipa): " + CStr(models_calculations.Orthotropic_model.model_variables.Ipa) + " [m^4]" + Chr(13) + _
            '    "moment of inertia of plate only (shorter edge - Ipb): " + CStr(models_calculations.Orthotropic_model.model_variables.Ipb) + " [m^4]" + Chr(13) + _
            '    "moment of inertia of section (non-central longitudinal stiffeners - Ina): " + CStr(models_calculations.Orthotropic_model.model_variables.Ina) + " [m^4]" + Chr(13) + _
            '    "moment of inertia of section (non-central transverse stiffeners - Inb): " + CStr(models_calculations.Orthotropic_model.model_variables.Inb) + " [m^4]" + Chr(13) + _
            '    "moment of inertia of section (central longitudinal stiffener - Ia): " + CStr(models_calculations.Orthotropic_model.model_variables.Ia) + " [m^4]" + Chr(13) + _
            '    "moment of inertia of section (central transverse stiffener - Ib): " + CStr(models_calculations.Orthotropic_model.model_variables.Ib) + " [m^4]" + Chr(13) + _
            '    "moment of inertia (estimated stiffening of longer edge of plate - ia): " + CStr(models_calculations.Orthotropic_model.model_variables.Ia_small) + " [m^4]" + Chr(13) + _
            '    "moment of inertia (estimated stiffening of shorter edge of plate - ib): " + CStr(models_calculations.Orthotropic_model.model_variables.Ib_small) + " [m^4]" + Chr(13) + _
            '    "Ro: " + CStr(models_calculations.Orthotropic_model.model_variables.ro) + " [-]" + Chr(13) + _
            '    "Eta: " + CStr(models_calculations.Orthotropic_model.model_variables.eta) + " [-]" + Chr(13) + _
            '    "K value (linear estimation used): " + CStr(models_calculations.Orthotropic_model.model_variables.K) + " [-]" + Chr(13) + _
            '    "Maximum deflection: " + CStr(Math.Round(models_calculations.Orthotropic_model.model_variables.Result * 1000, 2)) + " [mm]" + Chr(13)
            'ElseIf general_settings.general_variables.current_model = "Grillage model" Then
            '    text_results = My.Application.Info.Title & " " & DateTime.Now.ToString + Chr(13) + "====================================================================================" + Chr(13) + "*********** RESULTS OBTAINED USING THE GRILLAGE MODEL  **************************" & vbCr & _
            '    "Input data:" & Chr(13) + Chr(13) + "Plate data:" + Chr(13) + _
            '    vbTab + "Length (a): " + CStr(models_calculations.Grillage_model.model_variables.a) + " [m]" + Chr(13) + _
            '    vbTab + "Width (b): " + CStr(models_calculations.Grillage_model.model_variables.b) + " [m]" + Chr(13) + _
            '    vbTab + "Thickness (t): " + CStr(models_calculations.Grillage_model.model_variables.t * 1000) + " [mm]" + Chr(13) + _
            '    Chr(13) + "Boundary conditions, Load and Material properties: " + Chr(13) + _
            '    vbTab + "Uniform pressure: " + CStr(models_calculations.Grillage_model.model_variables.P) + " [Pa]" + Chr(13) + _
            '    vbTab + "Young's modulus: " + CStr(models_calculations.Grillage_model.model_variables.E / 10 ^ 9) + " [GPa]" + Chr(13) + _
            '    vbTab + "Poisson’s ratio: " + CStr(models_calculations.Grillage_model.model_variables.ni) + Chr(13)
            '    If models_calculations.Grillage_model.model_variables.BC = 1 Then
            '        text_results += vbTab + "Boundary conditions: All edges are Simply Supported" + Chr(13)
            '    ElseIf models_calculations.Grillage_model.model_variables.BC = 2 Then
            '        text_results += vbTab + "Boundary conditions: Both short edges are fixed and both long edges are simply supported." + Chr(13)
            '    ElseIf models_calculations.Grillage_model.model_variables.BC = 3 Then
            '        text_results += vbTab + "Boundary conditions: Both long edges are fixed and both short edges are simply supported." + Chr(13)
            '    ElseIf models_calculations.Grillage_model.model_variables.BC = 4 Then
            '        text_results += vbTab + "Boundary conditions: All four edges are fixed/clamped (All six degrees of freedom are fixed at the edges)." + Chr(13)
            '    End If
            '    '*******STIFFENERS *****
            '    text_results += Chr(13) + "Stiffeners:" + Chr(13) + _
            '    vbTab + "Number of longitudinal stiffeners (s beams): " + CStr(models_calculations.Grillage_model.model_variables.s) + Chr(13) + _
            '    vbTab + "Number of transverse stiffeners (r beams): " + CStr(models_calculations.Grillage_model.model_variables.r) + Chr(13) + Chr(13) + _
            '    "Stiffeners' properties:" & vbCr & _
            '    vbTab & "longitudinal stiffeners" & vbCr & _
            '    vbTab & vbTab & "Moment of inertia: " & CStr(models_calculations.Grillage_model.model_variables.Is_stiffeners) & " [" & "m^4" & "]" & vbCr & _
            '    vbTab & vbTab & "Area of cross section: " & CStr(models_calculations.Grillage_model.model_variables.As_stiffeners) & " [" & "m²" & "]" & vbCr & _
            '    vbTab & vbTab & "Centroid of cross section: " + CStr(models_calculations.Grillage_model.model_variables.Ys_stiffeners) & " [" & "m" & "]" & vbCr & vbCr & _
            '    vbTab & "Transverse stiffeners" + Chr(13) + _
            '    vbTab & vbTab & "Moment of inertia: " & CStr(models_calculations.Grillage_model.model_variables.Ir_stiffeners) & " [" & "m^4" & "]" & vbCr & _
            '    vbTab & vbTab & "Area of cross section: " & CStr(models_calculations.Grillage_model.model_variables.Ar_stiffeners) & " [" & "m²" & "]" & vbCr & _
            '    vbTab & vbTab & "Centroid of cross section: " + CStr(models_calculations.Grillage_model.model_variables.Yr_stiffeners) & " [" & "m" & "]" & vbCr & vbCr & _
            '    "====================================================================================" + Chr(13) + _
            '    "Grillage Model's Intermediates Calculations:" + Chr(13) + _
            '    "c (spacing of s beams): " + CStr(models_calculations.Grillage_model.model_variables.c) + " [m]" + Chr(13) + _
            '    "d (spacing of r beams): " + CStr(models_calculations.Grillage_model.model_variables.d) + " [m]" + Chr(13) + _
            '    "Lambda: " + CStr(models_calculations.Grillage_model.model_variables.lamda) + " [m]" + Chr(13) + _
            '    "Mu: " + CStr(models_calculations.Grillage_model.model_variables.mu) + " [m]" + Chr(13) + _
            '    "moment of inertia of section (r beams - Ir): " + CStr(models_calculations.Grillage_model.model_variables.I_s) + " [m^4]" + Chr(13) + _
            '    "moment of inertia of section (r beams - Is): " + CStr(models_calculations.Grillage_model.model_variables.I_s) + " [m^4]" + Chr(13) + _
            '    "Chart's value: " + CStr(models_calculations.Grillage_model.model_variables.Chart_value) + "" + Chr(13) + _
            '    "Maximum deflection: " + CStr(Math.Round(models_calculations.Grillage_model.model_variables.Result * 1000, 2)) + " [mm]" + Chr(13)
            'Else
            '    ' TO BE COMPLETE LATER
            '    ' TO BE COMPLETE LATER
            '    ' TO BE COMPLETE LATER
            '    ' TO BE COMPLETE LATER
            '    ' TO BE COMPLETE LATER
            '    ' TO BE COMPLETE LATER
            'End If
            RichTextBox_result_for_saving_HTML.RightToLeft = Windows.Forms.RightToLeft.No
            RichTextBox_result_for_saving_HTML.Text = text_results
    End Sub
    Private Sub text_feed_default_english()
        Dim text_results As String = ""
        If general_settings.general_variables.current_model = "Orthotropic Plate model" Then
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
        ElseIf general_settings.general_variables.current_model = "Grillage model" Then
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
            "moment of inertia of section (r beams - Ir): " + CStr(models_calculations.Grillage_model.model_variables.I_r) + " [m^4]" + Chr(13) + _
            "moment of inertia of section (r beams - Is): " + CStr(models_calculations.Grillage_model.model_variables.I_s) + " [m^4]" + Chr(13) + _
            "Chart's value: " + CStr(models_calculations.Grillage_model.model_variables.Chart_value) + "" + Chr(13) + _
            "Maximum deflection: " + CStr(Math.Round(models_calculations.Grillage_model.model_variables.Result * 1000, 2)) + " [mm]" + Chr(13)
        Else
            ' TO BE COMPLETE LATER
            ' TO BE COMPLETE LATER
            ' TO BE COMPLETE LATER
            ' TO BE COMPLETE LATER
            ' TO BE COMPLETE LATER
            ' TO BE COMPLETE LATER
        End If
        RichTextBox_result_for_saving.RightToLeft = Windows.Forms.RightToLeft.No
        RichTextBox_result_for_saving.Text += text_results
    End Sub
    Private Sub Button_run_calculations(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_compute.Click
        Textbox_results.ForeColor = Color.Green
        RichTextBox_results.ForeColor = Color.Chartreuse
        set_data()
        If continue_process = True Then
            If general_settings.general_variables.current_model = "Orthotropic Plate model" Then
                general_settings.general_variables.orthotropic_count_results += 1
                models_calculations.Orthotropic_model.model_functions.main_function(models_calculations.Orthotropic_model.model_variables.a, models_calculations.Orthotropic_model.model_variables.b, models_calculations.Orthotropic_model.model_variables.t, models_calculations.Orthotropic_model.model_variables.Na, models_calculations.Orthotropic_model.model_variables.Nb, models_calculations.Orthotropic_model.model_variables.Ina_stiffeners, models_calculations.Orthotropic_model.model_variables.Inb_stiffeners, models_calculations.Orthotropic_model.model_variables.Ia_stiffener, models_calculations.Orthotropic_model.model_variables.Ib_stiffener, models_calculations.Orthotropic_model.model_variables.Ana_stiffeners, models_calculations.Orthotropic_model.model_variables.Anb_stiffeners, models_calculations.Orthotropic_model.model_variables.Aa_stiffener, models_calculations.Orthotropic_model.model_variables.Ab_stiffener, models_calculations.Orthotropic_model.model_variables.Yna_stiffeners, models_calculations.Orthotropic_model.model_variables.Ynb_stiffeners, models_calculations.Orthotropic_model.model_variables.Ya_stiffener, models_calculations.Orthotropic_model.model_variables.Yb_stiffener, models_calculations.Orthotropic_model.model_variables.C, models_calculations.Orthotropic_model.model_variables.geo_type, models_calculations.Orthotropic_model.model_variables.E, models_calculations.Orthotropic_model.model_variables.ni, models_calculations.Orthotropic_model.model_variables.P)
                result_deflection = models_calculations.Orthotropic_model.model_variables.Result
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Stiffened Plates Evaluator", "orthotropic count results", general_settings.general_variables.orthotropic_count_results)
            ElseIf general_settings.general_variables.current_model = "Grillage model" Then
                general_settings.general_variables.Grillage_count_results += 1
                models_calculations.Grillage_model.model_functions.main_function(models_calculations.Grillage_model.model_variables.a, models_calculations.Grillage_model.model_variables.b, models_calculations.Grillage_model.model_variables.t, models_calculations.Grillage_model.model_variables.r, models_calculations.Grillage_model.model_variables.s, models_calculations.Grillage_model.model_variables.Ir_stiffeners, models_calculations.Grillage_model.model_variables.Is_stiffeners, models_calculations.Grillage_model.model_variables.Ar_stiffeners, models_calculations.Grillage_model.model_variables.As_stiffeners, models_calculations.Grillage_model.model_variables.Yr_stiffeners, models_calculations.Grillage_model.model_variables.Ys_stiffeners, models_calculations.Grillage_model.model_variables.BC, models_calculations.Grillage_model.model_variables.E, models_calculations.Grillage_model.model_variables.ni, models_calculations.Grillage_model.model_variables.P)
                result_deflection = models_calculations.Grillage_model.model_variables.Result
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Stiffened Plates Evaluator", "grillage count results", general_settings.general_variables.Grillage_count_results)
            End If
            RichTextBox_results.Visible = True
            result_deflection_SD = Math.Round(result_deflection * 1000, CInt(NumericUpDown_SD.Value))
            Textbox_results.Text = CStr(result_deflection_SD) + " " + language_settings.unit_millimeter
            My.Computer.Clipboard.SetText(CStr(result_deflection_SD))
            ADINA_check()
            'Button_more_error.Visible = True
            Label_SD.Visible = True
            NumericUpDown_SD.Visible = True
            Text_feed()
        End If
    End Sub
    Private Sub clear_result_text_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_results_clear.Click
        RichTextBox_result_for_saving.Clear()
    End Sub
    Private Sub change_panel(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView_steps.SelectedIndexChanged
        If Not (ListView_steps.FocusedItem Is Nothing) Then
            hide_panels()
            If ListView_steps.FocusedItem.Text = language_settings.results_listview0 Then
                Panel1.Dock = DockStyle.Fill
                Panel1.Visible = True
            ElseIf ListView_steps.FocusedItem.Text = language_settings.results_listview1 Then
                Panel2.Dock = DockStyle.Fill
                Panel2.Visible = True
            ElseIf ListView_steps.FocusedItem.Text = language_settings.results_listview2 Then
                Panel3.Dock = DockStyle.Fill
                Panel3.Visible = True
            ElseIf ListView_steps.FocusedItem.Text = language_settings.results_listview3 Then
                Panel4.Dock = DockStyle.Fill
                Panel4.Visible = True
            End If
        End If
    End Sub
    Private Sub status_form_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        hide_panels()
        GUI_set(language_settings.language_current_file)
    End Sub
    Private Sub Picture_eng_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Picture_eng_panel1.Click, Picture_eng_panel2.Click, Picture_eng_panel3.Click, Picture_eng_panel4.Click
        If File.Exists("default_eng.ini") = True Then
            GUI_set("default_eng.ini")
        Else
            ' TO BE COMPLETE LATER
            ' TO BE COMPLETE LATER
            ' TO BE COMPLETE LATER
            ' TO BE COMPLETE LATER
            ' TO BE COMPLETE LATER
            ' TO BE COMPLETE LATER
        End If
        general_settings.save_settings_to_registry()
    End Sub
    Private Sub Picture_heb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Picture_heb_panel1.Click, Picture_heb_panel2.Click, Picture_heb_panel3.Click, Picture_heb_panel4.Click
        GUI_set("default_heb.ini")
        general_settings.save_settings_to_registry()
    End Sub
    Private Sub more_error_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_more_error.Click
        If GUI_FEA_results.IsDisposed = True Then
            GUI_FEA_results = New GUI_FEA_results
        End If
        If general_settings.general_variables.current_model = "orthotropic plate model" Then
            general_settings.controls_Library.FEA_result_from_status = GUI_FEA_results
            general_settings.controls_Library.FEA_result_from_status_case01 = GUI_FEA_results.case01
            general_settings.controls_Library.FEA_result_from_status_case02 = GUI_FEA_results.case02
            general_settings.controls_Library.FEA_result_from_status_case03 = GUI_FEA_results.case03
            general_settings.controls_Library.FEA_result_from_status_case04 = GUI_FEA_results.case04
            general_settings.controls_Library.FEA_result_from_status.Show()
            If textbox_geo_type.Text = 4 Then
                general_settings.controls_Library.FEA_result_from_status_case04.Checked = True
            ElseIf textbox_geo_type.Text = 3 Then
                general_settings.controls_Library.FEA_result_from_status_case03.Checked = True
            ElseIf textbox_geo_type.Text = 2 Then
                general_settings.controls_Library.FEA_result_from_status_case02.Checked = True
            ElseIf textbox_geo_type.Text = 1 Then
                general_settings.controls_Library.FEA_result_from_status_case01.Checked = True
            End If
        ElseIf general_settings.general_variables.current_model = "grillage model" Then
            general_settings.controls_Library.FEA_result_from_status = GUI_FEA_results
            general_settings.controls_Library.FEA_result_from_status_case01 = GUI_FEA_results.case01
            general_settings.controls_Library.FEA_result_from_status_case02 = GUI_FEA_results.case02
            general_settings.controls_Library.FEA_result_from_status_case03 = GUI_FEA_results.case03
            general_settings.controls_Library.FEA_result_from_status_case04 = GUI_FEA_results.case04
            general_settings.controls_Library.FEA_result_from_status.Show()
        Else
        End If
    End Sub
    Private Sub NumericUpDown_SD_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown_SD.ValueChanged
        If continue_process = True Then
            result_deflection_SD = Math.Round(result_deflection * 1000, CInt(NumericUpDown_SD.Value))
            Textbox_results.Text = CStr(result_deflection_SD) + " " + language_settings.unit_millimeter
            Textbox_results.RightToLeft = language_settings.language_RTL
        End If
    End Sub
    Private Sub TextBox_Ia_b_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_Ia_b.TextChanged
        If general_settings.general_variables.current_model = "Grillage model" Then
            TextBox_Ina_b.Text = TextBox_Ia_b.Text
        End If
    End Sub
    Private Sub TextBox_Ina_b_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_Ina_b.TextChanged
        If general_settings.general_variables.current_model = "Grillage model" Then
            TextBox_Ia_b.Text = TextBox_Ina_b.Text
        End If
    End Sub
    Private Sub TextBox_Ia_d_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_Ia_d.TextChanged
        If general_settings.general_variables.current_model = "Grillage model" Then
            TextBox_Ina_d.Text = TextBox_Ia_d.Text
        End If
    End Sub
    Private Sub TextBox_Ina_d_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_Ina_d.TextChanged
        If general_settings.general_variables.current_model = "Grillage model" Then
            TextBox_Ia_d.Text = TextBox_Ina_d.Text
        End If
    End Sub
    Private Sub TextBox_Ib_d_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_Ib_d.TextChanged
        If general_settings.general_variables.current_model = "Grillage model" Then
            TextBox_Inb_d.Text = TextBox_Ib_d.Text
        End If
    End Sub
    Private Sub TextBox_Inb_d_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_Inb_d.TextChanged
        If general_settings.general_variables.current_model = "Grillage model" Then
            TextBox_Ib_d.Text = TextBox_Inb_d.Text
        End If
    End Sub
    Private Sub TextBox_Ib_b_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_Ib_b.TextChanged
        If general_settings.general_variables.current_model = "Grillage model" Then
            TextBox_Inb_b.Text = TextBox_Ib_b.Text
        End If
    End Sub
    Private Sub TextBox_Inb_b_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_Inb_b.TextChanged
        If general_settings.general_variables.current_model = "Grillage model" Then
            TextBox_Ib_b.Text = TextBox_Inb_b.Text
        End If
    End Sub

    Private Sub Button_view_parameters_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_view_parameters.Click
        ' TO BE COMPLETE LATER
        Dim model_parameters As New GUI_model_parameters
        model_parameters.RightToLeftLayout = language_settings.language_RTL_layout
        model_parameters.RightToLeft = language_settings.language_RTL
        model_parameters.Tag = general_settings.general_variables.current_model
        model_parameters.ShowDialog()
    End Sub

    Private Sub button_results_save_HTML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_results_save_HTML.Click
        RichTextBox_result_for_saving.Show()
        text_feed_default_english_HTML()
        RichTextBox_result_for_saving.SaveFile("test.html", RichTextBoxStreamType.UnicodePlainText)
        RichTextBox_result_for_saving.Hide()

    End Sub
End Class
