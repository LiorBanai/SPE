Imports System
Imports System.IO
Imports System.ComponentModel
Public Class GUI_Input_Parameters
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
    'System.Windows.Forms.Panel
    'System.Windows.Forms.Panel
    'System.Windows.Forms.Panel
    'System.Windows.Forms.Panel
    Friend WithEvents RadioButton_fast As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_full As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox_stiffeners_number As System.Windows.Forms.GroupBox
    Friend WithEvents Label_stiffeners_short As System.Windows.Forms.Label
    Friend WithEvents Label_stiffeners_long As System.Windows.Forms.Label
    Friend WithEvents GroupBox_stiffeners_data As System.Windows.Forms.GroupBox
    Friend WithEvents RichTextBox_fast As System.Windows.Forms.RichTextBox
    Friend WithEvents Button_next_panel01 As System.Windows.Forms.Button
    Friend WithEvents GroupBox_plate As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox_plate As System.Windows.Forms.PictureBox
    Friend WithEvents Label_unit_mm01 As System.Windows.Forms.Label
    Friend WithEvents Label_unit_m02 As System.Windows.Forms.Label
    Friend WithEvents Label_unit_m01 As System.Windows.Forms.Label
    Friend WithEvents Label_type04 As System.Windows.Forms.Label
    Friend WithEvents Label_type03 As System.Windows.Forms.Label
    Friend WithEvents Label_type02 As System.Windows.Forms.Label
    Friend WithEvents Label_type01 As System.Windows.Forms.Label
    Friend WithEvents Button_type04 As System.Windows.Forms.Button
    Friend WithEvents Button_type03 As System.Windows.Forms.Button
    Friend WithEvents Button_type02 As System.Windows.Forms.Button
    Friend WithEvents Button_type01 As System.Windows.Forms.Button

    Friend WithEvents numeric_plate_t As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label_breadth As System.Windows.Forms.Label
    Friend WithEvents numeric_plate_short As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label_length As System.Windows.Forms.Label
    Friend WithEvents numeric_plate_long As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button_status As System.Windows.Forms.Button
    Friend WithEvents button_panel03_next As System.Windows.Forms.Button
    Friend WithEvents button_panel03_back As System.Windows.Forms.Button
    Friend WithEvents GroupBox_stiffeners_mark As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox_Ia As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_Ina As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_Ib As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_Inb As System.Windows.Forms.CheckBox
    Friend WithEvents ImageList_icons As System.Windows.Forms.ImageList
    Friend WithEvents PictureBox_Inb_checked As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_Ib_checked As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_Ina_checked As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_Ia_checked As System.Windows.Forms.PictureBox
    Friend WithEvents numeric_short As System.Windows.Forms.NumericUpDown
    Friend WithEvents numeric_long As System.Windows.Forms.NumericUpDown
    Friend WithEvents PictureBox_Ia_info As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_Ina_info As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_Inb_info As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_Ib_info As System.Windows.Forms.PictureBox
    Friend WithEvents Radiobutton_select_numeric As System.Windows.Forms.RadioButton
    Friend WithEvents Radiobutton_select_DB As System.Windows.Forms.RadioButton
    Friend WithEvents Button_DB_select03 As System.Windows.Forms.Button
    Friend WithEvents Button_DB_select02 As System.Windows.Forms.Button
    Friend WithEvents Button_DB_select01 As System.Windows.Forms.Button
    Friend WithEvents PictureBox_DB_pic02 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_DB_pic01 As System.Windows.Forms.PictureBox
    Friend WithEvents Button_DB_selected As System.Windows.Forms.Button
    Friend WithEvents groupBox_DB_sub As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox_db_area As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_db_moment As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox_moment_select_general As System.Windows.Forms.GroupBox
    Friend WithEvents Radiobutton_select_geometric As System.Windows.Forms.RadioButton
    Friend WithEvents groupBox_DB_input As System.Windows.Forms.GroupBox
    Friend WithEvents Groupbox_geometric_input As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox_geo_input As System.Windows.Forms.GroupBox
    Friend WithEvents Label_unit_mm05 As System.Windows.Forms.Label
    Friend WithEvents Label_geo_w As System.Windows.Forms.Label
    Friend WithEvents Label_unit_mm04 As System.Windows.Forms.Label
    Friend WithEvents Label_geo_t As System.Windows.Forms.Label
    Friend WithEvents Label_unit_mm03 As System.Windows.Forms.Label
    Friend WithEvents Label_unit_mm02 As System.Windows.Forms.Label
    Friend WithEvents Label_geo_d As System.Windows.Forms.Label
    Friend WithEvents Label_geo_b As System.Windows.Forms.Label
    Friend WithEvents Label_Geo_type_select As System.Windows.Forms.Label
    Friend WithEvents Button_Geo_selected As System.Windows.Forms.Button
    Friend WithEvents PictureBox_Geo_blade As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_Geo_L As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_Geo_T As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_Geo_I As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox_Geo_result As System.Windows.Forms.TextBox
    Friend WithEvents Label_Geo_result As System.Windows.Forms.Label
    Friend WithEvents Label_DB_center_unit As System.Windows.Forms.Label
    Friend WithEvents Label_DB_area_unit As System.Windows.Forms.Label
    Friend WithEvents Label_DB_moment_unit As System.Windows.Forms.Label
    Friend WithEvents Label_DB_center As System.Windows.Forms.Label
    Friend WithEvents TextBox_db_center As System.Windows.Forms.TextBox
    Friend WithEvents Label_DB_area As System.Windows.Forms.Label
    Friend WithEvents Label_DB_moment As System.Windows.Forms.Label
    Protected WithEvents ComboBox_num_center_units As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_num_area_units As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_num_moment_units As System.Windows.Forms.ComboBox
    Friend WithEvents Label_num_area As System.Windows.Forms.Label
    Friend WithEvents TextBox_num_area As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox_numeric As System.Windows.Forms.PictureBox
    Friend WithEvents Label_num_center As System.Windows.Forms.Label
    Friend WithEvents TextBox_num_center As System.Windows.Forms.TextBox
    Friend WithEvents Label_num_moment As System.Windows.Forms.Label
    Friend WithEvents TextBox_num_moment As System.Windows.Forms.TextBox
    Friend WithEvents Button_num_selected As System.Windows.Forms.Button
    Friend WithEvents Panel01 As System.Windows.Forms.Panel
    Friend WithEvents panel02 As System.Windows.Forms.Panel
    Friend WithEvents panel04 As System.Windows.Forms.Panel
    Friend WithEvents panel03 As System.Windows.Forms.Panel
    Friend WithEvents Button_panel04_back As System.Windows.Forms.Button
    Friend WithEvents Button_panel04_next As System.Windows.Forms.Button
    Friend WithEvents ComboBox_P_units As System.Windows.Forms.ComboBox
    Friend WithEvents Button_case03 As System.Windows.Forms.Button
    Friend WithEvents Button_case04 As System.Windows.Forms.Button
    Friend WithEvents Button_case02 As System.Windows.Forms.Button
    Friend WithEvents Button_case01 As System.Windows.Forms.Button
    Friend WithEvents TextBox_P_input As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_ni_input As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_E_input As System.Windows.Forms.TextBox
    Friend WithEvents Label_thickness As System.Windows.Forms.Label
    Friend WithEvents Button_panel02_back As System.Windows.Forms.Button
    Friend WithEvents Label_status As System.Windows.Forms.Label
    Friend WithEvents Combobox_geo_select As System.Windows.Forms.ComboBox
    Friend WithEvents Picture_eng As System.Windows.Forms.PictureBox
    Friend WithEvents Picture_heb As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox_BC As System.Windows.Forms.GroupBox
    Friend WithEvents label_type_of_BC As System.Windows.Forms.Label
    Friend WithEvents Label_pressure As System.Windows.Forms.Label
    Friend WithEvents label_ni As System.Windows.Forms.Label
    Friend WithEvents Label_modulus As System.Windows.Forms.Label
    Friend WithEvents numeric_BC_input As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label_BC As System.Windows.Forms.Label
    Friend WithEvents label_BC_title As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox_geo_b As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox_geo_d As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox_geo_w As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox_geo_t As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label_short As System.Windows.Forms.Label
    Friend WithEvents Button_view_parameters As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents PanelTop As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents tpNumericInput As TabPage
    Friend WithEvents tpGeometricInput As TabPage
    Friend WithEvents tpDBInput As TabPage
    Friend WithEvents lblNumericInput As Label
    Friend WithEvents PanelMainTop As Panel
    Friend WithEvents Label_long As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI_Input_Parameters))
        Me.Panel01 = New System.Windows.Forms.Panel()
        Me.RichTextBox_fast = New System.Windows.Forms.RichTextBox()
        Me.RadioButton_full = New System.Windows.Forms.RadioButton()
        Me.Button_next_panel01 = New System.Windows.Forms.Button()
        Me.GroupBox_plate = New System.Windows.Forms.GroupBox()
        Me.Label_long = New System.Windows.Forms.Label()
        Me.Label_short = New System.Windows.Forms.Label()
        Me.Label_thickness = New System.Windows.Forms.Label()
        Me.numeric_plate_t = New System.Windows.Forms.NumericUpDown()
        Me.Label_breadth = New System.Windows.Forms.Label()
        Me.numeric_plate_short = New System.Windows.Forms.NumericUpDown()
        Me.Label_length = New System.Windows.Forms.Label()
        Me.numeric_plate_long = New System.Windows.Forms.NumericUpDown()
        Me.PictureBox_plate = New System.Windows.Forms.PictureBox()
        Me.Label_unit_mm01 = New System.Windows.Forms.Label()
        Me.Label_unit_m02 = New System.Windows.Forms.Label()
        Me.Label_unit_m01 = New System.Windows.Forms.Label()
        Me.RadioButton_fast = New System.Windows.Forms.RadioButton()
        Me.panel02 = New System.Windows.Forms.Panel()
        Me.Button_panel02_back = New System.Windows.Forms.Button()
        Me.Label_type04 = New System.Windows.Forms.Label()
        Me.Label_type03 = New System.Windows.Forms.Label()
        Me.Label_type02 = New System.Windows.Forms.Label()
        Me.Label_type01 = New System.Windows.Forms.Label()
        Me.Button_type04 = New System.Windows.Forms.Button()
        Me.Button_type03 = New System.Windows.Forms.Button()
        Me.Button_type02 = New System.Windows.Forms.Button()
        Me.Button_type01 = New System.Windows.Forms.Button()
        Me.panel03 = New System.Windows.Forms.Panel()
        Me.GroupBox_stiffeners_data = New System.Windows.Forms.GroupBox()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.tpNumericInput = New System.Windows.Forms.TabPage()
        Me.lblNumericInput = New System.Windows.Forms.Label()
        Me.ComboBox_num_center_units = New System.Windows.Forms.ComboBox()
        Me.ComboBox_num_area_units = New System.Windows.Forms.ComboBox()
        Me.Label_num_moment = New System.Windows.Forms.Label()
        Me.ComboBox_num_moment_units = New System.Windows.Forms.ComboBox()
        Me.Button_num_selected = New System.Windows.Forms.Button()
        Me.Label_num_center = New System.Windows.Forms.Label()
        Me.PictureBox_numeric = New System.Windows.Forms.PictureBox()
        Me.TextBox_num_area = New System.Windows.Forms.TextBox()
        Me.Label_num_area = New System.Windows.Forms.Label()
        Me.TextBox_num_center = New System.Windows.Forms.TextBox()
        Me.TextBox_num_moment = New System.Windows.Forms.TextBox()
        Me.tpGeometricInput = New System.Windows.Forms.TabPage()
        Me.Groupbox_geometric_input = New System.Windows.Forms.GroupBox()
        Me.Button_Geo_selected = New System.Windows.Forms.Button()
        Me.TextBox_Geo_result = New System.Windows.Forms.TextBox()
        Me.Label_Geo_result = New System.Windows.Forms.Label()
        Me.Combobox_geo_select = New System.Windows.Forms.ComboBox()
        Me.PictureBox_Geo_L = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Geo_T = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Geo_I = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Geo_blade = New System.Windows.Forms.PictureBox()
        Me.Label_Geo_type_select = New System.Windows.Forms.Label()
        Me.GroupBox_geo_input = New System.Windows.Forms.GroupBox()
        Me.MaskedTextBox_geo_w = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox_geo_t = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox_geo_d = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox_geo_b = New System.Windows.Forms.MaskedTextBox()
        Me.Label_unit_mm05 = New System.Windows.Forms.Label()
        Me.Label_geo_w = New System.Windows.Forms.Label()
        Me.Label_unit_mm04 = New System.Windows.Forms.Label()
        Me.Label_geo_t = New System.Windows.Forms.Label()
        Me.Label_unit_mm03 = New System.Windows.Forms.Label()
        Me.Label_unit_mm02 = New System.Windows.Forms.Label()
        Me.Label_geo_d = New System.Windows.Forms.Label()
        Me.Label_geo_b = New System.Windows.Forms.Label()
        Me.tpDBInput = New System.Windows.Forms.TabPage()
        Me.groupBox_DB_input = New System.Windows.Forms.GroupBox()
        Me.PictureBox_DB_pic02 = New System.Windows.Forms.PictureBox()
        Me.Button_DB_selected = New System.Windows.Forms.Button()
        Me.PictureBox_DB_pic01 = New System.Windows.Forms.PictureBox()
        Me.groupBox_DB_sub = New System.Windows.Forms.GroupBox()
        Me.Label_DB_center_unit = New System.Windows.Forms.Label()
        Me.Button_DB_select03 = New System.Windows.Forms.Button()
        Me.Label_DB_area_unit = New System.Windows.Forms.Label()
        Me.Button_DB_select02 = New System.Windows.Forms.Button()
        Me.Label_DB_moment_unit = New System.Windows.Forms.Label()
        Me.Button_DB_select01 = New System.Windows.Forms.Button()
        Me.Label_DB_center = New System.Windows.Forms.Label()
        Me.TextBox_db_center = New System.Windows.Forms.TextBox()
        Me.Label_DB_area = New System.Windows.Forms.Label()
        Me.TextBox_db_area = New System.Windows.Forms.TextBox()
        Me.Label_DB_moment = New System.Windows.Forms.Label()
        Me.TextBox_db_moment = New System.Windows.Forms.TextBox()
        Me.GroupBox_moment_select_general = New System.Windows.Forms.GroupBox()
        Me.Radiobutton_select_geometric = New System.Windows.Forms.RadioButton()
        Me.Radiobutton_select_numeric = New System.Windows.Forms.RadioButton()
        Me.Radiobutton_select_DB = New System.Windows.Forms.RadioButton()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.button_panel03_next = New System.Windows.Forms.Button()
        Me.button_panel03_back = New System.Windows.Forms.Button()
        Me.GroupBox_stiffeners_mark = New System.Windows.Forms.GroupBox()
        Me.PictureBox_Inb_info = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Ib_info = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Ina_info = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Ia_info = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Inb_checked = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Ib_checked = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Ina_checked = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Ia_checked = New System.Windows.Forms.PictureBox()
        Me.CheckBox_Inb = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Ib = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Ina = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Ia = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox_stiffeners_number = New System.Windows.Forms.GroupBox()
        Me.Button_view_parameters = New System.Windows.Forms.Button()
        Me.numeric_short = New System.Windows.Forms.NumericUpDown()
        Me.Label_stiffeners_short = New System.Windows.Forms.Label()
        Me.numeric_long = New System.Windows.Forms.NumericUpDown()
        Me.Label_stiffeners_long = New System.Windows.Forms.Label()
        Me.panel04 = New System.Windows.Forms.Panel()
        Me.label_BC_title = New System.Windows.Forms.Label()
        Me.Button_panel04_back = New System.Windows.Forms.Button()
        Me.Button_panel04_next = New System.Windows.Forms.Button()
        Me.GroupBox_BC = New System.Windows.Forms.GroupBox()
        Me.label_type_of_BC = New System.Windows.Forms.Label()
        Me.ComboBox_P_units = New System.Windows.Forms.ComboBox()
        Me.TextBox_P_input = New System.Windows.Forms.TextBox()
        Me.TextBox_ni_input = New System.Windows.Forms.TextBox()
        Me.TextBox_E_input = New System.Windows.Forms.TextBox()
        Me.Label_pressure = New System.Windows.Forms.Label()
        Me.label_ni = New System.Windows.Forms.Label()
        Me.Label_modulus = New System.Windows.Forms.Label()
        Me.numeric_BC_input = New System.Windows.Forms.NumericUpDown()
        Me.Label_BC = New System.Windows.Forms.Label()
        Me.Button_case04 = New System.Windows.Forms.Button()
        Me.Button_case01 = New System.Windows.Forms.Button()
        Me.Button_case02 = New System.Windows.Forms.Button()
        Me.Button_case03 = New System.Windows.Forms.Button()
        Me.Picture_eng = New System.Windows.Forms.PictureBox()
        Me.Picture_heb = New System.Windows.Forms.PictureBox()
        Me.Button_status = New System.Windows.Forms.Button()
        Me.Label_status = New System.Windows.Forms.Label()
        Me.ImageList_icons = New System.Windows.Forms.ImageList(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.PanelMainTop = New System.Windows.Forms.Panel()
        Me.Panel01.SuspendLayout()
        Me.GroupBox_plate.SuspendLayout()
        CType(Me.numeric_plate_t, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numeric_plate_short, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numeric_plate_long, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_plate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel02.SuspendLayout()
        Me.panel03.SuspendLayout()
        Me.GroupBox_stiffeners_data.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.tpNumericInput.SuspendLayout()
        CType(Me.PictureBox_numeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpGeometricInput.SuspendLayout()
        Me.Groupbox_geometric_input.SuspendLayout()
        CType(Me.PictureBox_Geo_L, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Geo_T, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Geo_I, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Geo_blade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_geo_input.SuspendLayout()
        Me.tpDBInput.SuspendLayout()
        Me.groupBox_DB_input.SuspendLayout()
        CType(Me.PictureBox_DB_pic02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_DB_pic01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox_DB_sub.SuspendLayout()
        Me.GroupBox_moment_select_general.SuspendLayout()
        Me.PanelTop.SuspendLayout()
        Me.GroupBox_stiffeners_mark.SuspendLayout()
        CType(Me.PictureBox_Inb_info, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Ib_info, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Ina_info, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Ia_info, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Inb_checked, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Ib_checked, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Ina_checked, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Ia_checked, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_stiffeners_number.SuspendLayout()
        CType(Me.numeric_short, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numeric_long, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel04.SuspendLayout()
        Me.GroupBox_BC.SuspendLayout()
        CType(Me.numeric_BC_input, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture_eng, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture_heb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.PanelMainTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel01
        '
        Me.Panel01.AutoScroll = True
        Me.Panel01.Controls.Add(Me.RichTextBox_fast)
        Me.Panel01.Controls.Add(Me.RadioButton_full)
        Me.Panel01.Controls.Add(Me.Button_next_panel01)
        Me.Panel01.Controls.Add(Me.GroupBox_plate)
        Me.Panel01.Controls.Add(Me.RadioButton_fast)
        Me.Panel01.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel01.Location = New System.Drawing.Point(3, 3)
        Me.Panel01.Name = "Panel01"
        Me.Panel01.Size = New System.Drawing.Size(1167, 805)
        Me.Panel01.TabIndex = 47
        '
        'RichTextBox_fast
        '
        Me.RichTextBox_fast.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox_fast.BackColor = System.Drawing.Color.WhiteSmoke
        Me.RichTextBox_fast.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox_fast.BulletIndent = 1
        Me.RichTextBox_fast.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RichTextBox_fast.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RichTextBox_fast.ForeColor = System.Drawing.Color.Navy
        Me.RichTextBox_fast.Location = New System.Drawing.Point(20, 314)
        Me.RichTextBox_fast.Name = "RichTextBox_fast"
        Me.RichTextBox_fast.ReadOnly = True
        Me.RichTextBox_fast.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.RichTextBox_fast.ShowSelectionMargin = True
        Me.RichTextBox_fast.Size = New System.Drawing.Size(1121, 129)
        Me.RichTextBox_fast.TabIndex = 45
        Me.RichTextBox_fast.Text = resources.GetString("RichTextBox_fast.Text")
        '
        'RadioButton_full
        '
        Me.RadioButton_full.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButton_full.Checked = True
        Me.RadioButton_full.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_full.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadioButton_full.Location = New System.Drawing.Point(20, 17)
        Me.RadioButton_full.Name = "RadioButton_full"
        Me.RadioButton_full.Size = New System.Drawing.Size(1121, 32)
        Me.RadioButton_full.TabIndex = 44
        Me.RadioButton_full.TabStop = True
        Me.RadioButton_full.Text = "Full Process"
        '
        'Button_next_panel01
        '
        Me.Button_next_panel01.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_next_panel01.AutoEllipsis = True
        Me.Button_next_panel01.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Button_next_panel01.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_next_panel01.Location = New System.Drawing.Point(502, 454)
        Me.Button_next_panel01.Name = "Button_next_panel01"
        Me.Button_next_panel01.Size = New System.Drawing.Size(88, 44)
        Me.Button_next_panel01.TabIndex = 42
        Me.Button_next_panel01.Text = "OK"
        '
        'GroupBox_plate
        '
        Me.GroupBox_plate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_plate.Controls.Add(Me.Label_long)
        Me.GroupBox_plate.Controls.Add(Me.Label_short)
        Me.GroupBox_plate.Controls.Add(Me.Label_thickness)
        Me.GroupBox_plate.Controls.Add(Me.numeric_plate_t)
        Me.GroupBox_plate.Controls.Add(Me.Label_breadth)
        Me.GroupBox_plate.Controls.Add(Me.numeric_plate_short)
        Me.GroupBox_plate.Controls.Add(Me.Label_length)
        Me.GroupBox_plate.Controls.Add(Me.numeric_plate_long)
        Me.GroupBox_plate.Controls.Add(Me.PictureBox_plate)
        Me.GroupBox_plate.Controls.Add(Me.Label_unit_mm01)
        Me.GroupBox_plate.Controls.Add(Me.Label_unit_m02)
        Me.GroupBox_plate.Controls.Add(Me.Label_unit_m01)
        Me.GroupBox_plate.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_plate.Location = New System.Drawing.Point(20, 68)
        Me.GroupBox_plate.Name = "GroupBox_plate"
        Me.GroupBox_plate.Size = New System.Drawing.Size(1121, 204)
        Me.GroupBox_plate.TabIndex = 40
        Me.GroupBox_plate.TabStop = False
        Me.GroupBox_plate.Text = "Plate's Geometry's Parameters"
        '
        'Label_long
        '
        Me.Label_long.AutoEllipsis = True
        Me.Label_long.BackColor = System.Drawing.Color.White
        Me.Label_long.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_long.Location = New System.Drawing.Point(743, 137)
        Me.Label_long.Name = "Label_long"
        Me.Label_long.Size = New System.Drawing.Size(51, 19)
        Me.Label_long.TabIndex = 44
        Me.Label_long.Text = "a"
        Me.Label_long.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_short
        '
        Me.Label_short.AutoEllipsis = True
        Me.Label_short.BackColor = System.Drawing.Color.White
        Me.Label_short.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_short.Location = New System.Drawing.Point(675, 52)
        Me.Label_short.Name = "Label_short"
        Me.Label_short.Size = New System.Drawing.Size(113, 27)
        Me.Label_short.TabIndex = 43
        Me.Label_short.Text = "b"
        Me.Label_short.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label_thickness
        '
        Me.Label_thickness.AutoEllipsis = True
        Me.Label_thickness.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label_thickness.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_thickness.Location = New System.Drawing.Point(8, 142)
        Me.Label_thickness.Name = "Label_thickness"
        Me.Label_thickness.Size = New System.Drawing.Size(285, 25)
        Me.Label_thickness.TabIndex = 12
        Me.Label_thickness.Text = "Thickness t"
        Me.Label_thickness.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'numeric_plate_t
        '
        Me.numeric_plate_t.DecimalPlaces = 2
        Me.numeric_plate_t.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numeric_plate_t.Location = New System.Drawing.Point(345, 147)
        Me.numeric_plate_t.Name = "numeric_plate_t"
        Me.numeric_plate_t.Size = New System.Drawing.Size(98, 31)
        Me.numeric_plate_t.TabIndex = 11
        Me.numeric_plate_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numeric_plate_t.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label_breadth
        '
        Me.Label_breadth.AutoEllipsis = True
        Me.Label_breadth.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label_breadth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_breadth.Location = New System.Drawing.Point(8, 94)
        Me.Label_breadth.Name = "Label_breadth"
        Me.Label_breadth.Size = New System.Drawing.Size(285, 25)
        Me.Label_breadth.TabIndex = 10
        Me.Label_breadth.Text = "Breadth b"
        Me.Label_breadth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'numeric_plate_short
        '
        Me.numeric_plate_short.DecimalPlaces = 4
        Me.numeric_plate_short.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numeric_plate_short.Location = New System.Drawing.Point(345, 99)
        Me.numeric_plate_short.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numeric_plate_short.Name = "numeric_plate_short"
        Me.numeric_plate_short.Size = New System.Drawing.Size(98, 31)
        Me.numeric_plate_short.TabIndex = 9
        Me.numeric_plate_short.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numeric_plate_short.Value = New Decimal(New Integer() {72, 0, 0, 131072})
        '
        'Label_length
        '
        Me.Label_length.AutoEllipsis = True
        Me.Label_length.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label_length.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_length.Location = New System.Drawing.Point(8, 43)
        Me.Label_length.Name = "Label_length"
        Me.Label_length.Size = New System.Drawing.Size(285, 25)
        Me.Label_length.TabIndex = 8
        Me.Label_length.Text = "Length a"
        Me.Label_length.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'numeric_plate_long
        '
        Me.numeric_plate_long.DecimalPlaces = 4
        Me.numeric_plate_long.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numeric_plate_long.Location = New System.Drawing.Point(345, 48)
        Me.numeric_plate_long.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numeric_plate_long.Name = "numeric_plate_long"
        Me.numeric_plate_long.Size = New System.Drawing.Size(98, 31)
        Me.numeric_plate_long.TabIndex = 7
        Me.numeric_plate_long.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numeric_plate_long.Value = New Decimal(New Integer() {28, 0, 0, 65536})
        '
        'PictureBox_plate
        '
        Me.PictureBox_plate.Image = Global.SPE.My.Resources.Resources.plate_empty_text
        Me.PictureBox_plate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox_plate.Location = New System.Drawing.Point(590, 43)
        Me.PictureBox_plate.Name = "PictureBox_plate"
        Me.PictureBox_plate.Size = New System.Drawing.Size(206, 144)
        Me.PictureBox_plate.TabIndex = 42
        Me.PictureBox_plate.TabStop = False
        '
        'Label_unit_mm01
        '
        Me.Label_unit_mm01.AutoEllipsis = True
        Me.Label_unit_mm01.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_unit_mm01.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_unit_mm01.Location = New System.Drawing.Point(455, 147)
        Me.Label_unit_mm01.Name = "Label_unit_mm01"
        Me.Label_unit_mm01.Size = New System.Drawing.Size(105, 31)
        Me.Label_unit_mm01.TabIndex = 41
        Me.Label_unit_mm01.Text = "[mm]"
        Me.Label_unit_mm01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_unit_m02
        '
        Me.Label_unit_m02.AutoEllipsis = True
        Me.Label_unit_m02.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_unit_m02.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_unit_m02.Location = New System.Drawing.Point(455, 99)
        Me.Label_unit_m02.Name = "Label_unit_m02"
        Me.Label_unit_m02.Size = New System.Drawing.Size(102, 31)
        Me.Label_unit_m02.TabIndex = 40
        Me.Label_unit_m02.Text = "[m]"
        Me.Label_unit_m02.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_unit_m01
        '
        Me.Label_unit_m01.AutoEllipsis = True
        Me.Label_unit_m01.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_unit_m01.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_unit_m01.Location = New System.Drawing.Point(455, 48)
        Me.Label_unit_m01.Name = "Label_unit_m01"
        Me.Label_unit_m01.Size = New System.Drawing.Size(102, 31)
        Me.Label_unit_m01.TabIndex = 39
        Me.Label_unit_m01.Text = "[m]"
        Me.Label_unit_m01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadioButton_fast
        '
        Me.RadioButton_fast.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButton_fast.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_fast.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadioButton_fast.Location = New System.Drawing.Point(20, 278)
        Me.RadioButton_fast.Name = "RadioButton_fast"
        Me.RadioButton_fast.Size = New System.Drawing.Size(1121, 32)
        Me.RadioButton_fast.TabIndex = 43
        Me.RadioButton_fast.Text = "Fast Process"
        '
        'panel02
        '
        Me.panel02.AutoScroll = True
        Me.panel02.Controls.Add(Me.Button_panel02_back)
        Me.panel02.Controls.Add(Me.Label_type04)
        Me.panel02.Controls.Add(Me.Label_type03)
        Me.panel02.Controls.Add(Me.Label_type02)
        Me.panel02.Controls.Add(Me.Label_type01)
        Me.panel02.Controls.Add(Me.Button_type04)
        Me.panel02.Controls.Add(Me.Button_type03)
        Me.panel02.Controls.Add(Me.Button_type02)
        Me.panel02.Controls.Add(Me.Button_type01)
        Me.panel02.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel02.Location = New System.Drawing.Point(3, 3)
        Me.panel02.Name = "panel02"
        Me.panel02.Size = New System.Drawing.Size(1167, 806)
        Me.panel02.TabIndex = 2
        '
        'Button_panel02_back
        '
        Me.Button_panel02_back.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_panel02_back.AutoEllipsis = True
        Me.Button_panel02_back.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Button_panel02_back.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_panel02_back.Location = New System.Drawing.Point(504, 252)
        Me.Button_panel02_back.Name = "Button_panel02_back"
        Me.Button_panel02_back.Size = New System.Drawing.Size(95, 46)
        Me.Button_panel02_back.TabIndex = 8
        Me.Button_panel02_back.Text = "Back"
        '
        'Label_type04
        '
        Me.Label_type04.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label_type04.AutoEllipsis = True
        Me.Label_type04.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_type04.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_type04.Location = New System.Drawing.Point(25, 14)
        Me.Label_type04.Name = "Label_type04"
        Me.Label_type04.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label_type04.Size = New System.Drawing.Size(240, 71)
        Me.Label_type04.TabIndex = 7
        Me.Label_type04.Text = "Longitudinal and Transverse Stiffeners"
        Me.Label_type04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_type03
        '
        Me.Label_type03.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label_type03.AutoEllipsis = True
        Me.Label_type03.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_type03.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_type03.Location = New System.Drawing.Point(294, 14)
        Me.Label_type03.Name = "Label_type03"
        Me.Label_type03.Size = New System.Drawing.Size(248, 71)
        Me.Label_type03.TabIndex = 6
        Me.Label_type03.Text = "Transverse Stiffeners with Central Longitudinal Stiffener"
        Me.Label_type03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_type02
        '
        Me.Label_type02.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label_type02.AutoEllipsis = True
        Me.Label_type02.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_type02.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_type02.Location = New System.Drawing.Point(565, 14)
        Me.Label_type02.Name = "Label_type02"
        Me.Label_type02.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label_type02.Size = New System.Drawing.Size(206, 71)
        Me.Label_type02.TabIndex = 5
        Me.Label_type02.Text = "Transverse Stiffeners Only"
        Me.Label_type02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_type01
        '
        Me.Label_type01.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label_type01.AutoEllipsis = True
        Me.Label_type01.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_type01.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_type01.Location = New System.Drawing.Point(849, 14)
        Me.Label_type01.Name = "Label_type01"
        Me.Label_type01.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label_type01.Size = New System.Drawing.Size(172, 68)
        Me.Label_type01.TabIndex = 4
        Me.Label_type01.Text = "No Stiffeners"
        Me.Label_type01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button_type04
        '
        Me.Button_type04.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_type04.BackColor = System.Drawing.Color.LightGray
        Me.Button_type04.Image = CType(resources.GetObject("Button_type04.Image"), System.Drawing.Image)
        Me.Button_type04.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_type04.Location = New System.Drawing.Point(47, 102)
        Me.Button_type04.Name = "Button_type04"
        Me.Button_type04.Size = New System.Drawing.Size(172, 117)
        Me.Button_type04.TabIndex = 3
        Me.Button_type04.UseVisualStyleBackColor = False
        '
        'Button_type03
        '
        Me.Button_type03.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_type03.BackColor = System.Drawing.Color.LightGray
        Me.Button_type03.Image = CType(resources.GetObject("Button_type03.Image"), System.Drawing.Image)
        Me.Button_type03.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_type03.Location = New System.Drawing.Point(320, 102)
        Me.Button_type03.Name = "Button_type03"
        Me.Button_type03.Size = New System.Drawing.Size(172, 117)
        Me.Button_type03.TabIndex = 2
        Me.Button_type03.UseVisualStyleBackColor = False
        '
        'Button_type02
        '
        Me.Button_type02.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_type02.BackColor = System.Drawing.Color.LightGray
        Me.Button_type02.Image = CType(resources.GetObject("Button_type02.Image"), System.Drawing.Image)
        Me.Button_type02.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_type02.Location = New System.Drawing.Point(582, 102)
        Me.Button_type02.Name = "Button_type02"
        Me.Button_type02.Size = New System.Drawing.Size(172, 117)
        Me.Button_type02.TabIndex = 1
        Me.Button_type02.UseVisualStyleBackColor = False
        '
        'Button_type01
        '
        Me.Button_type01.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_type01.BackColor = System.Drawing.Color.LightGray
        Me.Button_type01.Image = CType(resources.GetObject("Button_type01.Image"), System.Drawing.Image)
        Me.Button_type01.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_type01.Location = New System.Drawing.Point(849, 102)
        Me.Button_type01.Name = "Button_type01"
        Me.Button_type01.Size = New System.Drawing.Size(172, 117)
        Me.Button_type01.TabIndex = 0
        Me.Button_type01.UseVisualStyleBackColor = False
        '
        'panel03
        '
        Me.panel03.AutoScroll = True
        Me.panel03.AutoScrollMargin = New System.Drawing.Size(10, 10)
        Me.panel03.AutoScrollMinSize = New System.Drawing.Size(10, 10)
        Me.panel03.Controls.Add(Me.GroupBox_stiffeners_data)
        Me.panel03.Controls.Add(Me.PanelTop)
        Me.panel03.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel03.Location = New System.Drawing.Point(3, 3)
        Me.panel03.Name = "panel03"
        Me.panel03.Size = New System.Drawing.Size(1167, 806)
        Me.panel03.TabIndex = 44
        '
        'GroupBox_stiffeners_data
        '
        Me.GroupBox_stiffeners_data.Controls.Add(Me.TabControl2)
        Me.GroupBox_stiffeners_data.Controls.Add(Me.GroupBox_moment_select_general)
        Me.GroupBox_stiffeners_data.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox_stiffeners_data.Font = New System.Drawing.Font("Segoe UI", 12.8!)
        Me.GroupBox_stiffeners_data.Location = New System.Drawing.Point(0, 276)
        Me.GroupBox_stiffeners_data.Name = "GroupBox_stiffeners_data"
        Me.GroupBox_stiffeners_data.Size = New System.Drawing.Size(1167, 530)
        Me.GroupBox_stiffeners_data.TabIndex = 48
        Me.GroupBox_stiffeners_data.TabStop = False
        Me.GroupBox_stiffeners_data.Text = "Stiffeners' Properties"
        Me.GroupBox_stiffeners_data.Visible = False
        '
        'TabControl2
        '
        Me.TabControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl2.Controls.Add(Me.tpNumericInput)
        Me.TabControl2.Controls.Add(Me.tpGeometricInput)
        Me.TabControl2.Controls.Add(Me.tpDBInput)
        Me.TabControl2.Font = New System.Drawing.Font("Segoe UI", 7.8!)
        Me.TabControl2.Location = New System.Drawing.Point(252, 41)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(907, 473)
        Me.TabControl2.TabIndex = 48
        '
        'tpNumericInput
        '
        Me.tpNumericInput.Controls.Add(Me.lblNumericInput)
        Me.tpNumericInput.Controls.Add(Me.ComboBox_num_center_units)
        Me.tpNumericInput.Controls.Add(Me.ComboBox_num_area_units)
        Me.tpNumericInput.Controls.Add(Me.Label_num_moment)
        Me.tpNumericInput.Controls.Add(Me.ComboBox_num_moment_units)
        Me.tpNumericInput.Controls.Add(Me.Button_num_selected)
        Me.tpNumericInput.Controls.Add(Me.Label_num_center)
        Me.tpNumericInput.Controls.Add(Me.PictureBox_numeric)
        Me.tpNumericInput.Controls.Add(Me.TextBox_num_area)
        Me.tpNumericInput.Controls.Add(Me.Label_num_area)
        Me.tpNumericInput.Controls.Add(Me.TextBox_num_center)
        Me.tpNumericInput.Controls.Add(Me.TextBox_num_moment)
        Me.tpNumericInput.Location = New System.Drawing.Point(4, 26)
        Me.tpNumericInput.Name = "tpNumericInput"
        Me.tpNumericInput.Padding = New System.Windows.Forms.Padding(3)
        Me.tpNumericInput.Size = New System.Drawing.Size(899, 443)
        Me.tpNumericInput.TabIndex = 0
        Me.tpNumericInput.Text = "numericInput"
        Me.tpNumericInput.UseVisualStyleBackColor = True
        '
        'lblNumericInput
        '
        Me.lblNumericInput.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblNumericInput.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumericInput.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNumericInput.Location = New System.Drawing.Point(3, 3)
        Me.lblNumericInput.Name = "lblNumericInput"
        Me.lblNumericInput.Size = New System.Drawing.Size(893, 46)
        Me.lblNumericInput.TabIndex = 56
        Me.lblNumericInput.Text = "Numeric Input"
        Me.lblNumericInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox_num_center_units
        '
        Me.ComboBox_num_center_units.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_num_center_units.Font = New System.Drawing.Font("David", 10.8!)
        Me.ComboBox_num_center_units.ItemHeight = 17
        Me.ComboBox_num_center_units.Items.AddRange(New Object() {"mm", "cm", "m"})
        Me.ComboBox_num_center_units.Location = New System.Drawing.Point(464, 276)
        Me.ComboBox_num_center_units.Name = "ComboBox_num_center_units"
        Me.ComboBox_num_center_units.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComboBox_num_center_units.Size = New System.Drawing.Size(84, 25)
        Me.ComboBox_num_center_units.TabIndex = 55
        '
        'ComboBox_num_area_units
        '
        Me.ComboBox_num_area_units.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_num_area_units.Font = New System.Drawing.Font("David", 10.8!)
        Me.ComboBox_num_area_units.ItemHeight = 17
        Me.ComboBox_num_area_units.Items.AddRange(New Object() {"mm^2", "cm^2", "m^2"})
        Me.ComboBox_num_area_units.Location = New System.Drawing.Point(464, 191)
        Me.ComboBox_num_area_units.Name = "ComboBox_num_area_units"
        Me.ComboBox_num_area_units.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComboBox_num_area_units.Size = New System.Drawing.Size(84, 25)
        Me.ComboBox_num_area_units.TabIndex = 54
        '
        'Label_num_moment
        '
        Me.Label_num_moment.AutoEllipsis = True
        Me.Label_num_moment.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label_num_moment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_num_moment.Location = New System.Drawing.Point(16, 116)
        Me.Label_num_moment.Name = "Label_num_moment"
        Me.Label_num_moment.Size = New System.Drawing.Size(217, 37)
        Me.Label_num_moment.TabIndex = 5
        Me.Label_num_moment.Text = "Moment of Inertia"
        Me.Label_num_moment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox_num_moment_units
        '
        Me.ComboBox_num_moment_units.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_num_moment_units.Font = New System.Drawing.Font("David", 10.8!)
        Me.ComboBox_num_moment_units.ItemHeight = 17
        Me.ComboBox_num_moment_units.Items.AddRange(New Object() {"mm^4", "cm^4", "m^4"})
        Me.ComboBox_num_moment_units.Location = New System.Drawing.Point(464, 120)
        Me.ComboBox_num_moment_units.Name = "ComboBox_num_moment_units"
        Me.ComboBox_num_moment_units.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComboBox_num_moment_units.Size = New System.Drawing.Size(84, 25)
        Me.ComboBox_num_moment_units.TabIndex = 53
        '
        'Button_num_selected
        '
        Me.Button_num_selected.AutoEllipsis = True
        Me.Button_num_selected.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Button_num_selected.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_num_selected.Location = New System.Drawing.Point(790, 193)
        Me.Button_num_selected.Name = "Button_num_selected"
        Me.Button_num_selected.Size = New System.Drawing.Size(85, 37)
        Me.Button_num_selected.TabIndex = 3
        Me.Button_num_selected.Text = "OK"
        '
        'Label_num_center
        '
        Me.Label_num_center.AutoEllipsis = True
        Me.Label_num_center.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label_num_center.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_num_center.Location = New System.Drawing.Point(16, 262)
        Me.Label_num_center.Name = "Label_num_center"
        Me.Label_num_center.Size = New System.Drawing.Size(301, 68)
        Me.Label_num_center.TabIndex = 7
        Me.Label_num_center.Text = "Center of area with respect to base of stiffener"
        Me.Label_num_center.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox_numeric
        '
        Me.PictureBox_numeric.Image = CType(resources.GetObject("PictureBox_numeric.Image"), System.Drawing.Image)
        Me.PictureBox_numeric.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox_numeric.Location = New System.Drawing.Point(559, 119)
        Me.PictureBox_numeric.Name = "PictureBox_numeric"
        Me.PictureBox_numeric.Size = New System.Drawing.Size(208, 216)
        Me.PictureBox_numeric.TabIndex = 8
        Me.PictureBox_numeric.TabStop = False
        '
        'TextBox_num_area
        '
        Me.TextBox_num_area.Font = New System.Drawing.Font("David", 10.8!)
        Me.TextBox_num_area.Location = New System.Drawing.Point(351, 190)
        Me.TextBox_num_area.Name = "TextBox_num_area"
        Me.TextBox_num_area.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox_num_area.Size = New System.Drawing.Size(88, 25)
        Me.TextBox_num_area.TabIndex = 6
        Me.TextBox_num_area.Text = "0"
        Me.TextBox_num_area.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_num_area
        '
        Me.Label_num_area.AutoEllipsis = True
        Me.Label_num_area.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label_num_area.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_num_area.Location = New System.Drawing.Point(16, 189)
        Me.Label_num_area.Name = "Label_num_area"
        Me.Label_num_area.Size = New System.Drawing.Size(217, 41)
        Me.Label_num_area.TabIndex = 10
        Me.Label_num_area.Text = "Area of cross section"
        Me.Label_num_area.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_num_center
        '
        Me.TextBox_num_center.Font = New System.Drawing.Font("David", 10.8!)
        Me.TextBox_num_center.Location = New System.Drawing.Point(351, 275)
        Me.TextBox_num_center.Name = "TextBox_num_center"
        Me.TextBox_num_center.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox_num_center.Size = New System.Drawing.Size(88, 25)
        Me.TextBox_num_center.TabIndex = 9
        Me.TextBox_num_center.Text = "0"
        Me.TextBox_num_center.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_num_moment
        '
        Me.TextBox_num_moment.Font = New System.Drawing.Font("David", 10.8!)
        Me.TextBox_num_moment.Location = New System.Drawing.Point(351, 119)
        Me.TextBox_num_moment.Name = "TextBox_num_moment"
        Me.TextBox_num_moment.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox_num_moment.Size = New System.Drawing.Size(88, 25)
        Me.TextBox_num_moment.TabIndex = 4
        Me.TextBox_num_moment.Text = "0"
        Me.TextBox_num_moment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tpGeometricInput
        '
        Me.tpGeometricInput.Controls.Add(Me.Groupbox_geometric_input)
        Me.tpGeometricInput.Location = New System.Drawing.Point(4, 26)
        Me.tpGeometricInput.Name = "tpGeometricInput"
        Me.tpGeometricInput.Padding = New System.Windows.Forms.Padding(3)
        Me.tpGeometricInput.Size = New System.Drawing.Size(899, 442)
        Me.tpGeometricInput.TabIndex = 1
        Me.tpGeometricInput.Text = "GeometricInput"
        Me.tpGeometricInput.UseVisualStyleBackColor = True
        '
        'Groupbox_geometric_input
        '
        Me.Groupbox_geometric_input.Controls.Add(Me.Button_Geo_selected)
        Me.Groupbox_geometric_input.Controls.Add(Me.TextBox_Geo_result)
        Me.Groupbox_geometric_input.Controls.Add(Me.Label_Geo_result)
        Me.Groupbox_geometric_input.Controls.Add(Me.Combobox_geo_select)
        Me.Groupbox_geometric_input.Controls.Add(Me.PictureBox_Geo_L)
        Me.Groupbox_geometric_input.Controls.Add(Me.PictureBox_Geo_T)
        Me.Groupbox_geometric_input.Controls.Add(Me.PictureBox_Geo_I)
        Me.Groupbox_geometric_input.Controls.Add(Me.PictureBox_Geo_blade)
        Me.Groupbox_geometric_input.Controls.Add(Me.Label_Geo_type_select)
        Me.Groupbox_geometric_input.Controls.Add(Me.GroupBox_geo_input)
        Me.Groupbox_geometric_input.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Groupbox_geometric_input.Font = New System.Drawing.Font("Segoe UI", 12.8!)
        Me.Groupbox_geometric_input.Location = New System.Drawing.Point(3, 3)
        Me.Groupbox_geometric_input.Name = "Groupbox_geometric_input"
        Me.Groupbox_geometric_input.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Groupbox_geometric_input.Size = New System.Drawing.Size(893, 436)
        Me.Groupbox_geometric_input.TabIndex = 46
        Me.Groupbox_geometric_input.TabStop = False
        '
        'Button_Geo_selected
        '
        Me.Button_Geo_selected.AutoEllipsis = True
        Me.Button_Geo_selected.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Button_Geo_selected.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_Geo_selected.Location = New System.Drawing.Point(790, 193)
        Me.Button_Geo_selected.Name = "Button_Geo_selected"
        Me.Button_Geo_selected.Size = New System.Drawing.Size(85, 37)
        Me.Button_Geo_selected.TabIndex = 3
        Me.Button_Geo_selected.Text = "OK"
        '
        'TextBox_Geo_result
        '
        Me.TextBox_Geo_result.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox_Geo_result.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TextBox_Geo_result.Location = New System.Drawing.Point(445, 327)
        Me.TextBox_Geo_result.Name = "TextBox_Geo_result"
        Me.TextBox_Geo_result.ReadOnly = True
        Me.TextBox_Geo_result.Size = New System.Drawing.Size(184, 30)
        Me.TextBox_Geo_result.TabIndex = 17
        Me.TextBox_Geo_result.Text = "N/A"
        Me.TextBox_Geo_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_Geo_result
        '
        Me.Label_Geo_result.AutoEllipsis = True
        Me.Label_Geo_result.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label_Geo_result.Location = New System.Drawing.Point(6, 332)
        Me.Label_Geo_result.Name = "Label_Geo_result"
        Me.Label_Geo_result.Size = New System.Drawing.Size(393, 31)
        Me.Label_Geo_result.TabIndex = 18
        Me.Label_Geo_result.Text = "Current Moment of Inertia [cm^4]"
        '
        'Combobox_geo_select
        '
        Me.Combobox_geo_select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combobox_geo_select.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combobox_geo_select.ItemHeight = 25
        Me.Combobox_geo_select.Items.AddRange(New Object() {"Blade Stiffener (|)", "L Stiffener", "T Stiffener", "I Stiffener"})
        Me.Combobox_geo_select.Location = New System.Drawing.Point(239, 23)
        Me.Combobox_geo_select.Name = "Combobox_geo_select"
        Me.Combobox_geo_select.Size = New System.Drawing.Size(403, 33)
        Me.Combobox_geo_select.TabIndex = 19
        '
        'PictureBox_Geo_L
        '
        Me.PictureBox_Geo_L.Image = CType(resources.GetObject("PictureBox_Geo_L.Image"), System.Drawing.Image)
        Me.PictureBox_Geo_L.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox_Geo_L.Location = New System.Drawing.Point(430, 81)
        Me.PictureBox_Geo_L.Name = "PictureBox_Geo_L"
        Me.PictureBox_Geo_L.Size = New System.Drawing.Size(212, 151)
        Me.PictureBox_Geo_L.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Geo_L.TabIndex = 12
        Me.PictureBox_Geo_L.TabStop = False
        Me.PictureBox_Geo_L.Visible = False
        '
        'PictureBox_Geo_T
        '
        Me.PictureBox_Geo_T.Image = CType(resources.GetObject("PictureBox_Geo_T.Image"), System.Drawing.Image)
        Me.PictureBox_Geo_T.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox_Geo_T.Location = New System.Drawing.Point(430, 81)
        Me.PictureBox_Geo_T.Name = "PictureBox_Geo_T"
        Me.PictureBox_Geo_T.Size = New System.Drawing.Size(212, 151)
        Me.PictureBox_Geo_T.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Geo_T.TabIndex = 15
        Me.PictureBox_Geo_T.TabStop = False
        Me.PictureBox_Geo_T.Visible = False
        '
        'PictureBox_Geo_I
        '
        Me.PictureBox_Geo_I.Image = CType(resources.GetObject("PictureBox_Geo_I.Image"), System.Drawing.Image)
        Me.PictureBox_Geo_I.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox_Geo_I.Location = New System.Drawing.Point(430, 81)
        Me.PictureBox_Geo_I.Name = "PictureBox_Geo_I"
        Me.PictureBox_Geo_I.Size = New System.Drawing.Size(212, 151)
        Me.PictureBox_Geo_I.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Geo_I.TabIndex = 16
        Me.PictureBox_Geo_I.TabStop = False
        Me.PictureBox_Geo_I.Visible = False
        '
        'PictureBox_Geo_blade
        '
        Me.PictureBox_Geo_blade.Image = CType(resources.GetObject("PictureBox_Geo_blade.Image"), System.Drawing.Image)
        Me.PictureBox_Geo_blade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox_Geo_blade.Location = New System.Drawing.Point(430, 81)
        Me.PictureBox_Geo_blade.Name = "PictureBox_Geo_blade"
        Me.PictureBox_Geo_blade.Size = New System.Drawing.Size(212, 151)
        Me.PictureBox_Geo_blade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Geo_blade.TabIndex = 8
        Me.PictureBox_Geo_blade.TabStop = False
        '
        'Label_Geo_type_select
        '
        Me.Label_Geo_type_select.AutoEllipsis = True
        Me.Label_Geo_type_select.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Geo_type_select.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_Geo_type_select.Location = New System.Drawing.Point(3, 23)
        Me.Label_Geo_type_select.Name = "Label_Geo_type_select"
        Me.Label_Geo_type_select.Size = New System.Drawing.Size(221, 25)
        Me.Label_Geo_type_select.TabIndex = 5
        Me.Label_Geo_type_select.Text = "Type of stiffener/s"
        Me.Label_Geo_type_select.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox_geo_input
        '
        Me.GroupBox_geo_input.Controls.Add(Me.MaskedTextBox_geo_w)
        Me.GroupBox_geo_input.Controls.Add(Me.MaskedTextBox_geo_t)
        Me.GroupBox_geo_input.Controls.Add(Me.MaskedTextBox_geo_d)
        Me.GroupBox_geo_input.Controls.Add(Me.MaskedTextBox_geo_b)
        Me.GroupBox_geo_input.Controls.Add(Me.Label_unit_mm05)
        Me.GroupBox_geo_input.Controls.Add(Me.Label_geo_w)
        Me.GroupBox_geo_input.Controls.Add(Me.Label_unit_mm04)
        Me.GroupBox_geo_input.Controls.Add(Me.Label_geo_t)
        Me.GroupBox_geo_input.Controls.Add(Me.Label_unit_mm03)
        Me.GroupBox_geo_input.Controls.Add(Me.Label_unit_mm02)
        Me.GroupBox_geo_input.Controls.Add(Me.Label_geo_d)
        Me.GroupBox_geo_input.Controls.Add(Me.Label_geo_b)
        Me.GroupBox_geo_input.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.GroupBox_geo_input.Location = New System.Drawing.Point(6, 54)
        Me.GroupBox_geo_input.Name = "GroupBox_geo_input"
        Me.GroupBox_geo_input.Size = New System.Drawing.Size(399, 233)
        Me.GroupBox_geo_input.TabIndex = 14
        Me.GroupBox_geo_input.TabStop = False
        Me.GroupBox_geo_input.Text = "Stiffener"
        '
        'MaskedTextBox_geo_w
        '
        Me.MaskedTextBox_geo_w.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.MaskedTextBox_geo_w.Location = New System.Drawing.Point(154, 185)
        Me.MaskedTextBox_geo_w.Name = "MaskedTextBox_geo_w"
        Me.MaskedTextBox_geo_w.Size = New System.Drawing.Size(88, 31)
        Me.MaskedTextBox_geo_w.TabIndex = 23
        Me.MaskedTextBox_geo_w.Visible = False
        '
        'MaskedTextBox_geo_t
        '
        Me.MaskedTextBox_geo_t.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.MaskedTextBox_geo_t.Location = New System.Drawing.Point(154, 134)
        Me.MaskedTextBox_geo_t.Name = "MaskedTextBox_geo_t"
        Me.MaskedTextBox_geo_t.Size = New System.Drawing.Size(88, 31)
        Me.MaskedTextBox_geo_t.TabIndex = 22
        Me.MaskedTextBox_geo_t.Visible = False
        '
        'MaskedTextBox_geo_d
        '
        Me.MaskedTextBox_geo_d.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.MaskedTextBox_geo_d.Location = New System.Drawing.Point(154, 83)
        Me.MaskedTextBox_geo_d.Name = "MaskedTextBox_geo_d"
        Me.MaskedTextBox_geo_d.Size = New System.Drawing.Size(88, 31)
        Me.MaskedTextBox_geo_d.TabIndex = 21
        Me.MaskedTextBox_geo_d.Text = "80"
        '
        'MaskedTextBox_geo_b
        '
        Me.MaskedTextBox_geo_b.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.MaskedTextBox_geo_b.Location = New System.Drawing.Point(154, 32)
        Me.MaskedTextBox_geo_b.Name = "MaskedTextBox_geo_b"
        Me.MaskedTextBox_geo_b.Size = New System.Drawing.Size(88, 31)
        Me.MaskedTextBox_geo_b.TabIndex = 20
        Me.MaskedTextBox_geo_b.Text = "8"
        '
        'Label_unit_mm05
        '
        Me.Label_unit_mm05.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_unit_mm05.AutoEllipsis = True
        Me.Label_unit_mm05.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label_unit_mm05.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_unit_mm05.Location = New System.Drawing.Point(294, 185)
        Me.Label_unit_mm05.Name = "Label_unit_mm05"
        Me.Label_unit_mm05.Size = New System.Drawing.Size(70, 23)
        Me.Label_unit_mm05.TabIndex = 19
        Me.Label_unit_mm05.Text = "[mm]"
        Me.Label_unit_mm05.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_unit_mm05.Visible = False
        '
        'Label_geo_w
        '
        Me.Label_geo_w.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_geo_w.AutoEllipsis = True
        Me.Label_geo_w.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label_geo_w.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_geo_w.Location = New System.Drawing.Point(5, 177)
        Me.Label_geo_w.Name = "Label_geo_w"
        Me.Label_geo_w.Size = New System.Drawing.Size(143, 47)
        Me.Label_geo_w.TabIndex = 18
        Me.Label_geo_w.Text = "Thickness w"
        Me.Label_geo_w.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_geo_w.Visible = False
        '
        'Label_unit_mm04
        '
        Me.Label_unit_mm04.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_unit_mm04.AutoEllipsis = True
        Me.Label_unit_mm04.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label_unit_mm04.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_unit_mm04.Location = New System.Drawing.Point(294, 142)
        Me.Label_unit_mm04.Name = "Label_unit_mm04"
        Me.Label_unit_mm04.Size = New System.Drawing.Size(70, 23)
        Me.Label_unit_mm04.TabIndex = 13
        Me.Label_unit_mm04.Text = "[mm]"
        Me.Label_unit_mm04.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_unit_mm04.Visible = False
        '
        'Label_geo_t
        '
        Me.Label_geo_t.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_geo_t.AutoEllipsis = True
        Me.Label_geo_t.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label_geo_t.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_geo_t.Location = New System.Drawing.Point(5, 126)
        Me.Label_geo_t.Name = "Label_geo_t"
        Me.Label_geo_t.Size = New System.Drawing.Size(143, 47)
        Me.Label_geo_t.TabIndex = 12
        Me.Label_geo_t.Text = "Thickness t"
        Me.Label_geo_t.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_geo_t.Visible = False
        '
        'Label_unit_mm03
        '
        Me.Label_unit_mm03.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_unit_mm03.AutoEllipsis = True
        Me.Label_unit_mm03.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label_unit_mm03.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_unit_mm03.Location = New System.Drawing.Point(294, 82)
        Me.Label_unit_mm03.Name = "Label_unit_mm03"
        Me.Label_unit_mm03.Size = New System.Drawing.Size(70, 23)
        Me.Label_unit_mm03.TabIndex = 10
        Me.Label_unit_mm03.Text = "[mm]"
        Me.Label_unit_mm03.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_unit_mm02
        '
        Me.Label_unit_mm02.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_unit_mm02.AutoEllipsis = True
        Me.Label_unit_mm02.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label_unit_mm02.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_unit_mm02.Location = New System.Drawing.Point(294, 35)
        Me.Label_unit_mm02.Name = "Label_unit_mm02"
        Me.Label_unit_mm02.Size = New System.Drawing.Size(70, 23)
        Me.Label_unit_mm02.TabIndex = 9
        Me.Label_unit_mm02.Text = "[mm]"
        Me.Label_unit_mm02.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_geo_d
        '
        Me.Label_geo_d.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_geo_d.AutoEllipsis = True
        Me.Label_geo_d.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label_geo_d.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_geo_d.Location = New System.Drawing.Point(5, 75)
        Me.Label_geo_d.Name = "Label_geo_d"
        Me.Label_geo_d.Size = New System.Drawing.Size(143, 47)
        Me.Label_geo_d.TabIndex = 8
        Me.Label_geo_d.Text = "Height d"
        Me.Label_geo_d.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_geo_b
        '
        Me.Label_geo_b.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_geo_b.AutoEllipsis = True
        Me.Label_geo_b.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label_geo_b.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_geo_b.Location = New System.Drawing.Point(5, 24)
        Me.Label_geo_b.Name = "Label_geo_b"
        Me.Label_geo_b.Size = New System.Drawing.Size(143, 47)
        Me.Label_geo_b.TabIndex = 6
        Me.Label_geo_b.Text = "Length b"
        Me.Label_geo_b.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tpDBInput
        '
        Me.tpDBInput.Controls.Add(Me.groupBox_DB_input)
        Me.tpDBInput.Location = New System.Drawing.Point(4, 26)
        Me.tpDBInput.Name = "tpDBInput"
        Me.tpDBInput.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDBInput.Size = New System.Drawing.Size(899, 442)
        Me.tpDBInput.TabIndex = 2
        Me.tpDBInput.Text = "tpInput"
        Me.tpDBInput.UseVisualStyleBackColor = True
        '
        'groupBox_DB_input
        '
        Me.groupBox_DB_input.Controls.Add(Me.PictureBox_DB_pic02)
        Me.groupBox_DB_input.Controls.Add(Me.Button_DB_selected)
        Me.groupBox_DB_input.Controls.Add(Me.PictureBox_DB_pic01)
        Me.groupBox_DB_input.Controls.Add(Me.groupBox_DB_sub)
        Me.groupBox_DB_input.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupBox_DB_input.Font = New System.Drawing.Font("Segoe UI", 12.8!)
        Me.groupBox_DB_input.Location = New System.Drawing.Point(3, 3)
        Me.groupBox_DB_input.Name = "groupBox_DB_input"
        Me.groupBox_DB_input.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.groupBox_DB_input.Size = New System.Drawing.Size(893, 436)
        Me.groupBox_DB_input.TabIndex = 47
        Me.groupBox_DB_input.TabStop = False
        Me.groupBox_DB_input.Text = "Selection from database of known standards"
        '
        'PictureBox_DB_pic02
        '
        Me.PictureBox_DB_pic02.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_DB_pic02.Image = CType(resources.GetObject("PictureBox_DB_pic02.Image"), System.Drawing.Image)
        Me.PictureBox_DB_pic02.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox_DB_pic02.Location = New System.Drawing.Point(18, 205)
        Me.PictureBox_DB_pic02.Name = "PictureBox_DB_pic02"
        Me.PictureBox_DB_pic02.Size = New System.Drawing.Size(120, 88)
        Me.PictureBox_DB_pic02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_DB_pic02.TabIndex = 4
        Me.PictureBox_DB_pic02.TabStop = False
        '
        'Button_DB_selected
        '
        Me.Button_DB_selected.AutoEllipsis = True
        Me.Button_DB_selected.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Button_DB_selected.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_DB_selected.Location = New System.Drawing.Point(790, 193)
        Me.Button_DB_selected.Name = "Button_DB_selected"
        Me.Button_DB_selected.Size = New System.Drawing.Size(85, 37)
        Me.Button_DB_selected.TabIndex = 3
        Me.Button_DB_selected.Text = "OK"
        '
        'PictureBox_DB_pic01
        '
        Me.PictureBox_DB_pic01.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_DB_pic01.Image = CType(resources.GetObject("PictureBox_DB_pic01.Image"), System.Drawing.Image)
        Me.PictureBox_DB_pic01.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox_DB_pic01.Location = New System.Drawing.Point(18, 109)
        Me.PictureBox_DB_pic01.Name = "PictureBox_DB_pic01"
        Me.PictureBox_DB_pic01.Size = New System.Drawing.Size(120, 88)
        Me.PictureBox_DB_pic01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_DB_pic01.TabIndex = 0
        Me.PictureBox_DB_pic01.TabStop = False
        '
        'groupBox_DB_sub
        '
        Me.groupBox_DB_sub.Controls.Add(Me.Label_DB_center_unit)
        Me.groupBox_DB_sub.Controls.Add(Me.Button_DB_select03)
        Me.groupBox_DB_sub.Controls.Add(Me.Label_DB_area_unit)
        Me.groupBox_DB_sub.Controls.Add(Me.Button_DB_select02)
        Me.groupBox_DB_sub.Controls.Add(Me.Label_DB_moment_unit)
        Me.groupBox_DB_sub.Controls.Add(Me.Button_DB_select01)
        Me.groupBox_DB_sub.Controls.Add(Me.Label_DB_center)
        Me.groupBox_DB_sub.Controls.Add(Me.TextBox_db_center)
        Me.groupBox_DB_sub.Controls.Add(Me.Label_DB_area)
        Me.groupBox_DB_sub.Controls.Add(Me.TextBox_db_area)
        Me.groupBox_DB_sub.Controls.Add(Me.Label_DB_moment)
        Me.groupBox_DB_sub.Controls.Add(Me.TextBox_db_moment)
        Me.groupBox_DB_sub.Location = New System.Drawing.Point(155, 88)
        Me.groupBox_DB_sub.Name = "groupBox_DB_sub"
        Me.groupBox_DB_sub.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.groupBox_DB_sub.Size = New System.Drawing.Size(550, 205)
        Me.groupBox_DB_sub.TabIndex = 2
        Me.groupBox_DB_sub.TabStop = False
        Me.groupBox_DB_sub.Text = "Properties of selected stiffener"
        '
        'Label_DB_center_unit
        '
        Me.Label_DB_center_unit.AutoEllipsis = True
        Me.Label_DB_center_unit.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_DB_center_unit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_DB_center_unit.Location = New System.Drawing.Point(452, 150)
        Me.Label_DB_center_unit.Name = "Label_DB_center_unit"
        Me.Label_DB_center_unit.Size = New System.Drawing.Size(75, 27)
        Me.Label_DB_center_unit.TabIndex = 12
        Me.Label_DB_center_unit.Text = "[cm]"
        Me.Label_DB_center_unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button_DB_select03
        '
        Me.Button_DB_select03.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_DB_select03.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_DB_select03.Location = New System.Drawing.Point(250, 144)
        Me.Button_DB_select03.Name = "Button_DB_select03"
        Me.Button_DB_select03.Size = New System.Drawing.Size(42, 30)
        Me.Button_DB_select03.TabIndex = 11
        Me.Button_DB_select03.Text = "..."
        '
        'Label_DB_area_unit
        '
        Me.Label_DB_area_unit.AutoEllipsis = True
        Me.Label_DB_area_unit.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_DB_area_unit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_DB_area_unit.Location = New System.Drawing.Point(452, 96)
        Me.Label_DB_area_unit.Name = "Label_DB_area_unit"
        Me.Label_DB_area_unit.Size = New System.Drawing.Size(75, 27)
        Me.Label_DB_area_unit.TabIndex = 10
        Me.Label_DB_area_unit.Text = "[cm^2]"
        Me.Label_DB_area_unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button_DB_select02
        '
        Me.Button_DB_select02.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_DB_select02.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_DB_select02.Location = New System.Drawing.Point(250, 90)
        Me.Button_DB_select02.Name = "Button_DB_select02"
        Me.Button_DB_select02.Size = New System.Drawing.Size(42, 30)
        Me.Button_DB_select02.TabIndex = 9
        Me.Button_DB_select02.Text = "..."
        '
        'Label_DB_moment_unit
        '
        Me.Label_DB_moment_unit.AutoEllipsis = True
        Me.Label_DB_moment_unit.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_DB_moment_unit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_DB_moment_unit.Location = New System.Drawing.Point(452, 40)
        Me.Label_DB_moment_unit.Name = "Label_DB_moment_unit"
        Me.Label_DB_moment_unit.Size = New System.Drawing.Size(75, 27)
        Me.Label_DB_moment_unit.TabIndex = 8
        Me.Label_DB_moment_unit.Text = "[cm^4]"
        Me.Label_DB_moment_unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button_DB_select01
        '
        Me.Button_DB_select01.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_DB_select01.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_DB_select01.Location = New System.Drawing.Point(250, 34)
        Me.Button_DB_select01.Name = "Button_DB_select01"
        Me.Button_DB_select01.Size = New System.Drawing.Size(42, 30)
        Me.Button_DB_select01.TabIndex = 7
        Me.Button_DB_select01.Text = "..."
        '
        'Label_DB_center
        '
        Me.Label_DB_center.AutoEllipsis = True
        Me.Label_DB_center.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_DB_center.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_DB_center.Location = New System.Drawing.Point(18, 148)
        Me.Label_DB_center.Name = "Label_DB_center"
        Me.Label_DB_center.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_DB_center.Size = New System.Drawing.Size(216, 27)
        Me.Label_DB_center.TabIndex = 6
        Me.Label_DB_center.Text = "Center of Area"
        Me.Label_DB_center.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_db_center
        '
        Me.TextBox_db_center.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBox_db_center.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_db_center.Location = New System.Drawing.Point(296, 144)
        Me.TextBox_db_center.Name = "TextBox_db_center"
        Me.TextBox_db_center.ReadOnly = True
        Me.TextBox_db_center.Size = New System.Drawing.Size(119, 30)
        Me.TextBox_db_center.TabIndex = 5
        '
        'Label_DB_area
        '
        Me.Label_DB_area.AutoEllipsis = True
        Me.Label_DB_area.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_DB_area.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_DB_area.Location = New System.Drawing.Point(18, 84)
        Me.Label_DB_area.Name = "Label_DB_area"
        Me.Label_DB_area.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_DB_area.Size = New System.Drawing.Size(216, 44)
        Me.Label_DB_area.TabIndex = 4
        Me.Label_DB_area.Text = "Area of cross section"
        Me.Label_DB_area.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_db_area
        '
        Me.TextBox_db_area.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBox_db_area.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_db_area.Location = New System.Drawing.Point(296, 90)
        Me.TextBox_db_area.Name = "TextBox_db_area"
        Me.TextBox_db_area.ReadOnly = True
        Me.TextBox_db_area.Size = New System.Drawing.Size(119, 30)
        Me.TextBox_db_area.TabIndex = 3
        '
        'Label_DB_moment
        '
        Me.Label_DB_moment.AutoEllipsis = True
        Me.Label_DB_moment.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_DB_moment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_DB_moment.Location = New System.Drawing.Point(18, 34)
        Me.Label_DB_moment.Name = "Label_DB_moment"
        Me.Label_DB_moment.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_DB_moment.Size = New System.Drawing.Size(216, 38)
        Me.Label_DB_moment.TabIndex = 2
        Me.Label_DB_moment.Text = "Moment of Inertia"
        Me.Label_DB_moment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_db_moment
        '
        Me.TextBox_db_moment.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBox_db_moment.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_db_moment.Location = New System.Drawing.Point(296, 34)
        Me.TextBox_db_moment.Name = "TextBox_db_moment"
        Me.TextBox_db_moment.ReadOnly = True
        Me.TextBox_db_moment.Size = New System.Drawing.Size(119, 30)
        Me.TextBox_db_moment.TabIndex = 1
        '
        'GroupBox_moment_select_general
        '
        Me.GroupBox_moment_select_general.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_moment_select_general.Controls.Add(Me.Radiobutton_select_geometric)
        Me.GroupBox_moment_select_general.Controls.Add(Me.Radiobutton_select_numeric)
        Me.GroupBox_moment_select_general.Controls.Add(Me.Radiobutton_select_DB)
        Me.GroupBox_moment_select_general.Font = New System.Drawing.Font("Segoe UI", 12.8!)
        Me.GroupBox_moment_select_general.Location = New System.Drawing.Point(6, 31)
        Me.GroupBox_moment_select_general.Name = "GroupBox_moment_select_general"
        Me.GroupBox_moment_select_general.Size = New System.Drawing.Size(240, 493)
        Me.GroupBox_moment_select_general.TabIndex = 44
        Me.GroupBox_moment_select_general.TabStop = False
        Me.GroupBox_moment_select_general.Text = "Moment of Inertia method"
        '
        'Radiobutton_select_geometric
        '
        Me.Radiobutton_select_geometric.AutoEllipsis = True
        Me.Radiobutton_select_geometric.Checked = True
        Me.Radiobutton_select_geometric.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radiobutton_select_geometric.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Radiobutton_select_geometric.Location = New System.Drawing.Point(0, 190)
        Me.Radiobutton_select_geometric.Name = "Radiobutton_select_geometric"
        Me.Radiobutton_select_geometric.Size = New System.Drawing.Size(228, 78)
        Me.Radiobutton_select_geometric.TabIndex = 2
        Me.Radiobutton_select_geometric.TabStop = True
        Me.Radiobutton_select_geometric.Text = "Geometric Input (simple cross sections)"
        '
        'Radiobutton_select_numeric
        '
        Me.Radiobutton_select_numeric.AutoEllipsis = True
        Me.Radiobutton_select_numeric.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Radiobutton_select_numeric.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Radiobutton_select_numeric.Location = New System.Drawing.Point(0, 126)
        Me.Radiobutton_select_numeric.Name = "Radiobutton_select_numeric"
        Me.Radiobutton_select_numeric.Size = New System.Drawing.Size(228, 56)
        Me.Radiobutton_select_numeric.TabIndex = 1
        Me.Radiobutton_select_numeric.Text = "Numeric Input"
        '
        'Radiobutton_select_DB
        '
        Me.Radiobutton_select_DB.AutoEllipsis = True
        Me.Radiobutton_select_DB.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Radiobutton_select_DB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Radiobutton_select_DB.Location = New System.Drawing.Point(0, 58)
        Me.Radiobutton_select_DB.Name = "Radiobutton_select_DB"
        Me.Radiobutton_select_DB.Size = New System.Drawing.Size(228, 55)
        Me.Radiobutton_select_DB.TabIndex = 0
        Me.Radiobutton_select_DB.Text = "DB Selection"
        '
        'PanelTop
        '
        Me.PanelTop.Controls.Add(Me.button_panel03_next)
        Me.PanelTop.Controls.Add(Me.button_panel03_back)
        Me.PanelTop.Controls.Add(Me.GroupBox_stiffeners_mark)
        Me.PanelTop.Controls.Add(Me.Label1)
        Me.PanelTop.Controls.Add(Me.GroupBox_stiffeners_number)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(1167, 276)
        Me.PanelTop.TabIndex = 49
        '
        'button_panel03_next
        '
        Me.button_panel03_next.AutoEllipsis = True
        Me.button_panel03_next.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_panel03_next.Image = CType(resources.GetObject("button_panel03_next.Image"), System.Drawing.Image)
        Me.button_panel03_next.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.button_panel03_next.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.button_panel03_next.Location = New System.Drawing.Point(1039, 125)
        Me.button_panel03_next.Name = "button_panel03_next"
        Me.button_panel03_next.Size = New System.Drawing.Size(92, 84)
        Me.button_panel03_next.TabIndex = 42
        Me.button_panel03_next.Text = "Next"
        Me.button_panel03_next.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.button_panel03_next.Visible = False
        '
        'button_panel03_back
        '
        Me.button_panel03_back.AutoEllipsis = True
        Me.button_panel03_back.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_panel03_back.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.button_panel03_back.Location = New System.Drawing.Point(1039, 71)
        Me.button_panel03_back.Name = "button_panel03_back"
        Me.button_panel03_back.Size = New System.Drawing.Size(92, 48)
        Me.button_panel03_back.TabIndex = 43
        Me.button_panel03_back.Text = "Back"
        '
        'GroupBox_stiffeners_mark
        '
        Me.GroupBox_stiffeners_mark.Controls.Add(Me.PictureBox_Inb_info)
        Me.GroupBox_stiffeners_mark.Controls.Add(Me.PictureBox_Ib_info)
        Me.GroupBox_stiffeners_mark.Controls.Add(Me.PictureBox_Ina_info)
        Me.GroupBox_stiffeners_mark.Controls.Add(Me.PictureBox_Ia_info)
        Me.GroupBox_stiffeners_mark.Controls.Add(Me.PictureBox_Inb_checked)
        Me.GroupBox_stiffeners_mark.Controls.Add(Me.PictureBox_Ib_checked)
        Me.GroupBox_stiffeners_mark.Controls.Add(Me.PictureBox_Ina_checked)
        Me.GroupBox_stiffeners_mark.Controls.Add(Me.PictureBox_Ia_checked)
        Me.GroupBox_stiffeners_mark.Controls.Add(Me.CheckBox_Inb)
        Me.GroupBox_stiffeners_mark.Controls.Add(Me.CheckBox_Ib)
        Me.GroupBox_stiffeners_mark.Controls.Add(Me.CheckBox_Ina)
        Me.GroupBox_stiffeners_mark.Controls.Add(Me.CheckBox_Ia)
        Me.GroupBox_stiffeners_mark.Font = New System.Drawing.Font("Segoe UI", 12.8!)
        Me.GroupBox_stiffeners_mark.Location = New System.Drawing.Point(409, 50)
        Me.GroupBox_stiffeners_mark.Name = "GroupBox_stiffeners_mark"
        Me.GroupBox_stiffeners_mark.Size = New System.Drawing.Size(528, 203)
        Me.GroupBox_stiffeners_mark.TabIndex = 52
        Me.GroupBox_stiffeners_mark.TabStop = False
        Me.GroupBox_stiffeners_mark.Tag = ""
        Me.GroupBox_stiffeners_mark.Text = "Type of Stiffeners Selection"
        '
        'PictureBox_Inb_info
        '
        Me.PictureBox_Inb_info.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox_Inb_info.Image = CType(resources.GetObject("PictureBox_Inb_info.Image"), System.Drawing.Image)
        Me.PictureBox_Inb_info.Location = New System.Drawing.Point(459, 145)
        Me.PictureBox_Inb_info.Name = "PictureBox_Inb_info"
        Me.PictureBox_Inb_info.Size = New System.Drawing.Size(28, 24)
        Me.PictureBox_Inb_info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Inb_info.TabIndex = 12
        Me.PictureBox_Inb_info.TabStop = False
        Me.PictureBox_Inb_info.Visible = False
        '
        'PictureBox_Ib_info
        '
        Me.PictureBox_Ib_info.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox_Ib_info.Image = CType(resources.GetObject("PictureBox_Ib_info.Image"), System.Drawing.Image)
        Me.PictureBox_Ib_info.Location = New System.Drawing.Point(459, 109)
        Me.PictureBox_Ib_info.Name = "PictureBox_Ib_info"
        Me.PictureBox_Ib_info.Size = New System.Drawing.Size(28, 24)
        Me.PictureBox_Ib_info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Ib_info.TabIndex = 11
        Me.PictureBox_Ib_info.TabStop = False
        Me.PictureBox_Ib_info.Visible = False
        '
        'PictureBox_Ina_info
        '
        Me.PictureBox_Ina_info.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox_Ina_info.Image = CType(resources.GetObject("PictureBox_Ina_info.Image"), System.Drawing.Image)
        Me.PictureBox_Ina_info.Location = New System.Drawing.Point(459, 69)
        Me.PictureBox_Ina_info.Name = "PictureBox_Ina_info"
        Me.PictureBox_Ina_info.Size = New System.Drawing.Size(28, 24)
        Me.PictureBox_Ina_info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Ina_info.TabIndex = 10
        Me.PictureBox_Ina_info.TabStop = False
        Me.PictureBox_Ina_info.Visible = False
        '
        'PictureBox_Ia_info
        '
        Me.PictureBox_Ia_info.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox_Ia_info.Image = CType(resources.GetObject("PictureBox_Ia_info.Image"), System.Drawing.Image)
        Me.PictureBox_Ia_info.Location = New System.Drawing.Point(459, 28)
        Me.PictureBox_Ia_info.Name = "PictureBox_Ia_info"
        Me.PictureBox_Ia_info.Size = New System.Drawing.Size(28, 24)
        Me.PictureBox_Ia_info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Ia_info.TabIndex = 9
        Me.PictureBox_Ia_info.TabStop = False
        Me.PictureBox_Ia_info.Visible = False
        '
        'PictureBox_Inb_checked
        '
        Me.PictureBox_Inb_checked.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox_Inb_checked.Image = CType(resources.GetObject("PictureBox_Inb_checked.Image"), System.Drawing.Image)
        Me.PictureBox_Inb_checked.Location = New System.Drawing.Point(422, 145)
        Me.PictureBox_Inb_checked.Name = "PictureBox_Inb_checked"
        Me.PictureBox_Inb_checked.Size = New System.Drawing.Size(28, 24)
        Me.PictureBox_Inb_checked.TabIndex = 8
        Me.PictureBox_Inb_checked.TabStop = False
        '
        'PictureBox_Ib_checked
        '
        Me.PictureBox_Ib_checked.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox_Ib_checked.Image = CType(resources.GetObject("PictureBox_Ib_checked.Image"), System.Drawing.Image)
        Me.PictureBox_Ib_checked.Location = New System.Drawing.Point(422, 109)
        Me.PictureBox_Ib_checked.Name = "PictureBox_Ib_checked"
        Me.PictureBox_Ib_checked.Size = New System.Drawing.Size(28, 24)
        Me.PictureBox_Ib_checked.TabIndex = 7
        Me.PictureBox_Ib_checked.TabStop = False
        '
        'PictureBox_Ina_checked
        '
        Me.PictureBox_Ina_checked.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox_Ina_checked.Image = CType(resources.GetObject("PictureBox_Ina_checked.Image"), System.Drawing.Image)
        Me.PictureBox_Ina_checked.Location = New System.Drawing.Point(422, 69)
        Me.PictureBox_Ina_checked.Name = "PictureBox_Ina_checked"
        Me.PictureBox_Ina_checked.Size = New System.Drawing.Size(28, 24)
        Me.PictureBox_Ina_checked.TabIndex = 6
        Me.PictureBox_Ina_checked.TabStop = False
        '
        'PictureBox_Ia_checked
        '
        Me.PictureBox_Ia_checked.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox_Ia_checked.Image = CType(resources.GetObject("PictureBox_Ia_checked.Image"), System.Drawing.Image)
        Me.PictureBox_Ia_checked.Location = New System.Drawing.Point(422, 28)
        Me.PictureBox_Ia_checked.Name = "PictureBox_Ia_checked"
        Me.PictureBox_Ia_checked.Size = New System.Drawing.Size(28, 24)
        Me.PictureBox_Ia_checked.TabIndex = 5
        Me.PictureBox_Ia_checked.TabStop = False
        '
        'CheckBox_Inb
        '
        Me.CheckBox_Inb.AutoEllipsis = True
        Me.CheckBox_Inb.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_Inb.Location = New System.Drawing.Point(7, 145)
        Me.CheckBox_Inb.Name = "CheckBox_Inb"
        Me.CheckBox_Inb.Size = New System.Drawing.Size(438, 24)
        Me.CheckBox_Inb.TabIndex = 3
        Me.CheckBox_Inb.Text = "Non-Central Transverse Stiffeners"
        '
        'CheckBox_Ib
        '
        Me.CheckBox_Ib.AutoEllipsis = True
        Me.CheckBox_Ib.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_Ib.Location = New System.Drawing.Point(7, 109)
        Me.CheckBox_Ib.Name = "CheckBox_Ib"
        Me.CheckBox_Ib.Size = New System.Drawing.Size(438, 24)
        Me.CheckBox_Ib.TabIndex = 2
        Me.CheckBox_Ib.Text = "Central Transverse Stiffeners"
        '
        'CheckBox_Ina
        '
        Me.CheckBox_Ina.AutoEllipsis = True
        Me.CheckBox_Ina.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_Ina.Location = New System.Drawing.Point(7, 69)
        Me.CheckBox_Ina.Name = "CheckBox_Ina"
        Me.CheckBox_Ina.Size = New System.Drawing.Size(438, 24)
        Me.CheckBox_Ina.TabIndex = 1
        Me.CheckBox_Ina.Text = "Non-Central Longitudinal Stiffeners"
        '
        'CheckBox_Ia
        '
        Me.CheckBox_Ia.AutoEllipsis = True
        Me.CheckBox_Ia.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_Ia.Location = New System.Drawing.Point(7, 28)
        Me.CheckBox_Ia.Name = "CheckBox_Ia"
        Me.CheckBox_Ia.Size = New System.Drawing.Size(438, 24)
        Me.CheckBox_Ia.TabIndex = 0
        Me.CheckBox_Ia.Text = "Central Longitudinal Stiffener"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.8!)
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1167, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Stiffeners Selection"
        '
        'GroupBox_stiffeners_number
        '
        Me.GroupBox_stiffeners_number.Controls.Add(Me.Button_view_parameters)
        Me.GroupBox_stiffeners_number.Controls.Add(Me.numeric_short)
        Me.GroupBox_stiffeners_number.Controls.Add(Me.Label_stiffeners_short)
        Me.GroupBox_stiffeners_number.Controls.Add(Me.numeric_long)
        Me.GroupBox_stiffeners_number.Controls.Add(Me.Label_stiffeners_long)
        Me.GroupBox_stiffeners_number.Font = New System.Drawing.Font("Segoe UI", 12.8!)
        Me.GroupBox_stiffeners_number.Location = New System.Drawing.Point(5, 50)
        Me.GroupBox_stiffeners_number.Name = "GroupBox_stiffeners_number"
        Me.GroupBox_stiffeners_number.Size = New System.Drawing.Size(397, 203)
        Me.GroupBox_stiffeners_number.TabIndex = 51
        Me.GroupBox_stiffeners_number.TabStop = False
        Me.GroupBox_stiffeners_number.Text = "Number of Stiffeners"
        '
        'Button_view_parameters
        '
        Me.Button_view_parameters.Font = New System.Drawing.Font("David", 12.0!)
        Me.Button_view_parameters.Location = New System.Drawing.Point(6, 132)
        Me.Button_view_parameters.Name = "Button_view_parameters"
        Me.Button_view_parameters.Size = New System.Drawing.Size(361, 37)
        Me.Button_view_parameters.TabIndex = 59
        Me.Button_view_parameters.Text = "View model parameters"
        Me.Button_view_parameters.UseVisualStyleBackColor = True
        '
        'numeric_short
        '
        Me.numeric_short.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numeric_short.Location = New System.Drawing.Point(272, 70)
        Me.numeric_short.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numeric_short.Name = "numeric_short"
        Me.numeric_short.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.numeric_short.Size = New System.Drawing.Size(96, 31)
        Me.numeric_short.TabIndex = 58
        Me.numeric_short.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numeric_short.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'Label_stiffeners_short
        '
        Me.Label_stiffeners_short.AutoEllipsis = True
        Me.Label_stiffeners_short.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_stiffeners_short.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_stiffeners_short.Location = New System.Drawing.Point(7, 70)
        Me.Label_stiffeners_short.Name = "Label_stiffeners_short"
        Me.Label_stiffeners_short.Size = New System.Drawing.Size(245, 25)
        Me.Label_stiffeners_short.TabIndex = 57
        Me.Label_stiffeners_short.Text = "Transverse Stiffeners"
        Me.Label_stiffeners_short.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'numeric_long
        '
        Me.numeric_long.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numeric_long.Location = New System.Drawing.Point(272, 32)
        Me.numeric_long.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numeric_long.Name = "numeric_long"
        Me.numeric_long.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.numeric_long.Size = New System.Drawing.Size(95, 31)
        Me.numeric_long.TabIndex = 56
        Me.numeric_long.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numeric_long.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label_stiffeners_long
        '
        Me.Label_stiffeners_long.AutoEllipsis = True
        Me.Label_stiffeners_long.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_stiffeners_long.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_stiffeners_long.Location = New System.Drawing.Point(7, 32)
        Me.Label_stiffeners_long.Name = "Label_stiffeners_long"
        Me.Label_stiffeners_long.Size = New System.Drawing.Size(245, 25)
        Me.Label_stiffeners_long.TabIndex = 55
        Me.Label_stiffeners_long.Text = "Longitudinal Stiffeners"
        Me.Label_stiffeners_long.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panel04
        '
        Me.panel04.AutoScroll = True
        Me.panel04.AutoScrollMargin = New System.Drawing.Size(10, 10)
        Me.panel04.AutoScrollMinSize = New System.Drawing.Size(10, 10)
        Me.panel04.Controls.Add(Me.label_BC_title)
        Me.panel04.Controls.Add(Me.Button_panel04_back)
        Me.panel04.Controls.Add(Me.Button_panel04_next)
        Me.panel04.Controls.Add(Me.GroupBox_BC)
        Me.panel04.Controls.Add(Me.Button_case04)
        Me.panel04.Controls.Add(Me.Button_case01)
        Me.panel04.Controls.Add(Me.Button_case02)
        Me.panel04.Controls.Add(Me.Button_case03)
        Me.panel04.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel04.Location = New System.Drawing.Point(3, 3)
        Me.panel04.Name = "panel04"
        Me.panel04.Size = New System.Drawing.Size(1167, 806)
        Me.panel04.TabIndex = 41
        '
        'label_BC_title
        '
        Me.label_BC_title.AutoEllipsis = True
        Me.label_BC_title.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_BC_title.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label_BC_title.Location = New System.Drawing.Point(21, 12)
        Me.label_BC_title.Name = "label_BC_title"
        Me.label_BC_title.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.label_BC_title.Size = New System.Drawing.Size(432, 26)
        Me.label_BC_title.TabIndex = 45
        Me.label_BC_title.Text = "תנאי שפה"
        Me.label_BC_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button_panel04_back
        '
        Me.Button_panel04_back.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_panel04_back.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_panel04_back.Location = New System.Drawing.Point(381, 353)
        Me.Button_panel04_back.Name = "Button_panel04_back"
        Me.Button_panel04_back.Size = New System.Drawing.Size(116, 28)
        Me.Button_panel04_back.TabIndex = 43
        Me.Button_panel04_back.Text = "Back"
        '
        'Button_panel04_next
        '
        Me.Button_panel04_next.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_panel04_next.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_panel04_next.Location = New System.Drawing.Point(503, 353)
        Me.Button_panel04_next.Name = "Button_panel04_next"
        Me.Button_panel04_next.Size = New System.Drawing.Size(116, 28)
        Me.Button_panel04_next.TabIndex = 42
        Me.Button_panel04_next.Text = "Next"
        '
        'GroupBox_BC
        '
        Me.GroupBox_BC.Controls.Add(Me.label_type_of_BC)
        Me.GroupBox_BC.Controls.Add(Me.ComboBox_P_units)
        Me.GroupBox_BC.Controls.Add(Me.TextBox_P_input)
        Me.GroupBox_BC.Controls.Add(Me.TextBox_ni_input)
        Me.GroupBox_BC.Controls.Add(Me.TextBox_E_input)
        Me.GroupBox_BC.Controls.Add(Me.Label_pressure)
        Me.GroupBox_BC.Controls.Add(Me.label_ni)
        Me.GroupBox_BC.Controls.Add(Me.Label_modulus)
        Me.GroupBox_BC.Controls.Add(Me.numeric_BC_input)
        Me.GroupBox_BC.Controls.Add(Me.Label_BC)
        Me.GroupBox_BC.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.GroupBox_BC.Location = New System.Drawing.Point(473, 20)
        Me.GroupBox_BC.Name = "GroupBox_BC"
        Me.GroupBox_BC.Size = New System.Drawing.Size(667, 315)
        Me.GroupBox_BC.TabIndex = 40
        Me.GroupBox_BC.TabStop = False
        Me.GroupBox_BC.Text = "Pressure, Material Properties and BC"
        '
        'label_type_of_BC
        '
        Me.label_type_of_BC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label_type_of_BC.AutoEllipsis = True
        Me.label_type_of_BC.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.label_type_of_BC.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label_type_of_BC.Location = New System.Drawing.Point(16, 218)
        Me.label_type_of_BC.Name = "label_type_of_BC"
        Me.label_type_of_BC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.label_type_of_BC.Size = New System.Drawing.Size(639, 84)
        Me.label_type_of_BC.TabIndex = 54
        Me.label_type_of_BC.Text = "כל תנאי השפה בעלי תמיכות Simply Supported"
        Me.label_type_of_BC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox_P_units
        '
        Me.ComboBox_P_units.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_P_units.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_P_units.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.ComboBox_P_units.ItemHeight = 25
        Me.ComboBox_P_units.Items.AddRange(New Object() {"Pa", "Kpa", "Mpa"})
        Me.ComboBox_P_units.Location = New System.Drawing.Point(591, 29)
        Me.ComboBox_P_units.Name = "ComboBox_P_units"
        Me.ComboBox_P_units.Size = New System.Drawing.Size(64, 33)
        Me.ComboBox_P_units.TabIndex = 52
        '
        'TextBox_P_input
        '
        Me.TextBox_P_input.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_P_input.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.TextBox_P_input.Location = New System.Drawing.Point(388, 32)
        Me.TextBox_P_input.Name = "TextBox_P_input"
        Me.TextBox_P_input.Size = New System.Drawing.Size(87, 31)
        Me.TextBox_P_input.TabIndex = 51
        Me.TextBox_P_input.Text = "1000"
        '
        'TextBox_ni_input
        '
        Me.TextBox_ni_input.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_ni_input.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.TextBox_ni_input.Location = New System.Drawing.Point(388, 122)
        Me.TextBox_ni_input.Name = "TextBox_ni_input"
        Me.TextBox_ni_input.Size = New System.Drawing.Size(87, 31)
        Me.TextBox_ni_input.TabIndex = 50
        Me.TextBox_ni_input.Text = "0.3"
        '
        'TextBox_E_input
        '
        Me.TextBox_E_input.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_E_input.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.TextBox_E_input.Location = New System.Drawing.Point(388, 77)
        Me.TextBox_E_input.Name = "TextBox_E_input"
        Me.TextBox_E_input.Size = New System.Drawing.Size(87, 31)
        Me.TextBox_E_input.TabIndex = 49
        Me.TextBox_E_input.Text = "200"
        '
        'Label_pressure
        '
        Me.Label_pressure.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_pressure.AutoEllipsis = True
        Me.Label_pressure.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label_pressure.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_pressure.Location = New System.Drawing.Point(6, 32)
        Me.Label_pressure.Name = "Label_pressure"
        Me.Label_pressure.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_pressure.Size = New System.Drawing.Size(376, 31)
        Me.Label_pressure.TabIndex = 48
        Me.Label_pressure.Text = "Uniform Pressure acting on plate"
        Me.Label_pressure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label_ni
        '
        Me.label_ni.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label_ni.AutoEllipsis = True
        Me.label_ni.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.label_ni.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label_ni.Location = New System.Drawing.Point(6, 127)
        Me.label_ni.Name = "label_ni"
        Me.label_ni.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.label_ni.Size = New System.Drawing.Size(356, 26)
        Me.label_ni.TabIndex = 47
        Me.label_ni.Text = "Poisson's Ratio"
        Me.label_ni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_modulus
        '
        Me.Label_modulus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_modulus.AutoEllipsis = True
        Me.Label_modulus.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label_modulus.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_modulus.Location = New System.Drawing.Point(6, 77)
        Me.Label_modulus.Name = "Label_modulus"
        Me.Label_modulus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_modulus.Size = New System.Drawing.Size(356, 31)
        Me.Label_modulus.TabIndex = 46
        Me.Label_modulus.Text = "Modulus of Elasticity (E) [GPA]"
        Me.Label_modulus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'numeric_BC_input
        '
        Me.numeric_BC_input.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numeric_BC_input.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.numeric_BC_input.Location = New System.Drawing.Point(388, 166)
        Me.numeric_BC_input.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.numeric_BC_input.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numeric_BC_input.Name = "numeric_BC_input"
        Me.numeric_BC_input.Size = New System.Drawing.Size(52, 31)
        Me.numeric_BC_input.TabIndex = 45
        Me.numeric_BC_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numeric_BC_input.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label_BC
        '
        Me.Label_BC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_BC.AutoEllipsis = True
        Me.Label_BC.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label_BC.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_BC.Location = New System.Drawing.Point(6, 163)
        Me.Label_BC.Name = "Label_BC"
        Me.Label_BC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_BC.Size = New System.Drawing.Size(200, 34)
        Me.Label_BC.TabIndex = 44
        Me.Label_BC.Text = "Boundary Condition"
        Me.Label_BC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button_case04
        '
        Me.Button_case04.Image = CType(resources.GetObject("Button_case04.Image"), System.Drawing.Image)
        Me.Button_case04.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_case04.Location = New System.Drawing.Point(239, 202)
        Me.Button_case04.Name = "Button_case04"
        Me.Button_case04.Size = New System.Drawing.Size(214, 120)
        Me.Button_case04.TabIndex = 3
        Me.Button_case04.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button_case01
        '
        Me.Button_case01.Font = New System.Drawing.Font("David", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Button_case01.Image = CType(resources.GetObject("Button_case01.Image"), System.Drawing.Image)
        Me.Button_case01.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_case01.Location = New System.Drawing.Point(239, 40)
        Me.Button_case01.Name = "Button_case01"
        Me.Button_case01.Size = New System.Drawing.Size(214, 120)
        Me.Button_case01.TabIndex = 0
        Me.Button_case01.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button_case02
        '
        Me.Button_case02.Image = CType(resources.GetObject("Button_case02.Image"), System.Drawing.Image)
        Me.Button_case02.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_case02.Location = New System.Drawing.Point(21, 40)
        Me.Button_case02.Name = "Button_case02"
        Me.Button_case02.Size = New System.Drawing.Size(214, 120)
        Me.Button_case02.TabIndex = 1
        Me.Button_case02.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button_case03
        '
        Me.Button_case03.Image = CType(resources.GetObject("Button_case03.Image"), System.Drawing.Image)
        Me.Button_case03.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_case03.Location = New System.Drawing.Point(21, 202)
        Me.Button_case03.Name = "Button_case03"
        Me.Button_case03.Size = New System.Drawing.Size(214, 120)
        Me.Button_case03.TabIndex = 2
        Me.Button_case03.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Picture_eng
        '
        Me.Picture_eng.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Picture_eng.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Picture_eng.Image = Global.SPE.My.Resources.Resources.flag_english01
        Me.Picture_eng.Location = New System.Drawing.Point(1144, 26)
        Me.Picture_eng.Name = "Picture_eng"
        Me.Picture_eng.Size = New System.Drawing.Size(32, 16)
        Me.Picture_eng.TabIndex = 22
        Me.Picture_eng.TabStop = False
        '
        'Picture_heb
        '
        Me.Picture_heb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Picture_heb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Picture_heb.Image = Global.SPE.My.Resources.Resources.flag_hebrew01
        Me.Picture_heb.Location = New System.Drawing.Point(1144, 3)
        Me.Picture_heb.Name = "Picture_heb"
        Me.Picture_heb.Size = New System.Drawing.Size(32, 20)
        Me.Picture_heb.TabIndex = 21
        Me.Picture_heb.TabStop = False
        '
        'Button_status
        '
        Me.Button_status.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_status.AutoEllipsis = True
        Me.Button_status.Enabled = False
        Me.Button_status.Font = New System.Drawing.Font("David", 10.8!)
        Me.Button_status.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_status.Location = New System.Drawing.Point(1024, 4)
        Me.Button_status.Name = "Button_status"
        Me.Button_status.Size = New System.Drawing.Size(114, 34)
        Me.Button_status.TabIndex = 1
        Me.Button_status.Text = "Data Status"
        Me.Button_status.Visible = False
        '
        'Label_status
        '
        Me.Label_status.AutoEllipsis = True
        Me.Label_status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label_status.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_status.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_status.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_status.Location = New System.Drawing.Point(0, 0)
        Me.Label_status.Name = "Label_status"
        Me.Label_status.Size = New System.Drawing.Size(1181, 44)
        Me.Label_status.TabIndex = 0
        Me.Label_status.Text = "First Step: Process selection & Plate's parameters"
        Me.Label_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_status.UseMnemonic = False
        '
        'ImageList_icons
        '
        Me.ImageList_icons.ImageStream = CType(resources.GetObject("ImageList_icons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_icons.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_icons.Images.SetKeyName(0, "")
        Me.ImageList_icons.Images.SetKeyName(1, "")
        Me.ImageList_icons.Images.SetKeyName(2, "")
        Me.ImageList_icons.Images.SetKeyName(3, "")
        Me.ImageList_icons.Images.SetKeyName(4, "")
        Me.ImageList_icons.Images.SetKeyName(5, "")
        Me.ImageList_icons.Images.SetKeyName(6, "")
        Me.ImageList_icons.Images.SetKeyName(7, "")
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 46)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1181, 841)
        Me.TabControl1.TabIndex = 48
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel01)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1173, 811)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.panel02)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1173, 812)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.panel03)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1173, 812)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.panel04)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1173, 812)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'PanelMainTop
        '
        Me.PanelMainTop.Controls.Add(Me.Button_status)
        Me.PanelMainTop.Controls.Add(Me.Picture_eng)
        Me.PanelMainTop.Controls.Add(Me.Picture_heb)
        Me.PanelMainTop.Controls.Add(Me.Label_status)
        Me.PanelMainTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMainTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelMainTop.Name = "PanelMainTop"
        Me.PanelMainTop.Size = New System.Drawing.Size(1181, 46)
        Me.PanelMainTop.TabIndex = 47
        '
        'GUI_Input_Parameters
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1181, 887)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PanelMainTop)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(507, 572)
        Me.Name = "GUI_Input_Parameters"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Model's Parameters' Input Screen"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel01.ResumeLayout(False)
        Me.GroupBox_plate.ResumeLayout(False)
        CType(Me.numeric_plate_t, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numeric_plate_short, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numeric_plate_long, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_plate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel02.ResumeLayout(False)
        Me.panel03.ResumeLayout(False)
        Me.GroupBox_stiffeners_data.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.tpNumericInput.ResumeLayout(False)
        Me.tpNumericInput.PerformLayout()
        CType(Me.PictureBox_numeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpGeometricInput.ResumeLayout(False)
        Me.Groupbox_geometric_input.ResumeLayout(False)
        Me.Groupbox_geometric_input.PerformLayout()
        CType(Me.PictureBox_Geo_L, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Geo_T, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Geo_I, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Geo_blade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_geo_input.ResumeLayout(False)
        Me.GroupBox_geo_input.PerformLayout()
        Me.tpDBInput.ResumeLayout(False)
        Me.groupBox_DB_input.ResumeLayout(False)
        CType(Me.PictureBox_DB_pic02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_DB_pic01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox_DB_sub.ResumeLayout(False)
        Me.groupBox_DB_sub.PerformLayout()
        Me.GroupBox_moment_select_general.ResumeLayout(False)
        Me.PanelTop.ResumeLayout(False)
        Me.GroupBox_stiffeners_mark.ResumeLayout(False)
        CType(Me.PictureBox_Inb_info, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Ib_info, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Ina_info, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Ia_info, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Inb_checked, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Ib_checked, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Ina_checked, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Ia_checked, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_stiffeners_number.ResumeLayout(False)
        CType(Me.numeric_short, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numeric_long, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel04.ResumeLayout(False)
        Me.GroupBox_BC.ResumeLayout(False)
        Me.GroupBox_BC.PerformLayout()
        CType(Me.numeric_BC_input, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture_eng, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture_heb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.PanelMainTop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim toolTip_stiffeners As New ToolTip
    Dim toolTip_BC As New ToolTip
    Dim DB_form As New GUI_Database 'DATABASE form
    Dim continue_process As Boolean = False
    Dim current_moment As Single = 0
    Dim current_area As Single = 0
    Dim current_center As Single = 0
    '*********** MODEL PARAMETERS ****************
    Dim a As Single = 0
    Dim b As Single = 0
    Dim t As Single = 0
    Dim stiffeners_long As Byte = 0
    Dim stiffeners_short As Byte = 0
    Dim BC_type As Byte = 0
    Dim geo_type As Byte = 0
    Dim Young_Modulus As Single = 0
    Dim ni As Single = 0
    Dim P As Single = 0
    Dim Ina_stiffeners As Single = 0
    Dim Inb_stiffeners As Single = 0
    Dim Ia_stiffener As Single = 0
    Dim Ib_stiffener As Single = 0
    Dim Ana_stiffeners As Single = 0
    Dim Anb_stiffeners As Single = 0
    Dim Aa_stiffener As Single = 0
    Dim Ab_stiffener As Single = 0
    Dim yna_stiffeners As Single = 0
    Dim ya_stiffener As Single = 0
    Dim ynb_stiffeners As Single = 0
    Dim yb_stiffener As Single = 0    '*********** END MODEL PARAMETERS ****************
    '*********** Message PARAMETERS ****************    '*********** end Message PARAMETERS ****************
    Private Sub GUI_Update_steps()
        If general_settings.general_variables.current_model = "orthotropic plate model" Then
            If TabControl1.SelectedIndex = 0 Then
                Label_status.Text = language_settings.input_Label_status_step1_Orthotropic
            ElseIf TabControl1.SelectedIndex = 1 Then
                Label_status.Text = language_settings.input_Label_status_step2_Orthotropic
            ElseIf TabControl1.SelectedIndex = 2 Then
                Label_status.Text = language_settings.input_Label_status_step3_Orthotropic
            ElseIf TabControl1.SelectedIndex = 3 Then
                Label_status.Text = language_settings.input_Label_status_step4_Orthotropic
            Else
                Label_status.Text = "erroneous result"
            End If
        ElseIf general_settings.general_variables.current_model = "grillage model" Then
            If TabControl1.SelectedIndex = 0 Then
                Label_status.Text = language_settings.input_Label_status_step1_Grillage
            ElseIf TabControl1.SelectedIndex = 1 Then
                Label_status.Text = language_settings.input_Label_status_step2_Grillage
            ElseIf TabControl1.SelectedIndex = 2 Then
                Label_status.Text = language_settings.input_Label_status_step3_Grillage
            ElseIf TabControl1.SelectedIndex = 3 Then
                Label_status.Text = language_settings.input_Label_status_step4_Grillage
            Else
                Label_status.Text = "erroneous result"
            End If
        End If
    End Sub
    Private Sub update_label_BC_step()
        If numeric_BC_input.Value = 1 Then
            label_type_of_BC.Text = language_settings.input_panel4_label_type_of_BC01
        ElseIf numeric_BC_input.Value = 2 Then
            label_type_of_BC.Text = language_settings.input_panel4_label_type_of_BC02
        ElseIf numeric_BC_input.Value = 3 Then
            label_type_of_BC.Text = language_settings.input_panel4_label_type_of_BC03
        ElseIf numeric_BC_input.Value = 4 Then
            label_type_of_BC.Text = language_settings.input_panel4_label_type_of_BC04
        End If
    End Sub
    Private Sub GUI_set(ByVal new_lang As String)
        TabControl1.Appearance = TabAppearance.FlatButtons
        TabControl1.ItemSize = New Size(0, 1)
        TabControl1.SizeMode = TabSizeMode.Fixed

        TabControl2.Appearance = TabAppearance.FlatButtons
        TabControl2.ItemSize = New Size(0, 1)
        TabControl2.SizeMode = TabSizeMode.Fixed
        language_settings.read_language(new_lang)
        update_label_BC_step()
        Me.Text = language_settings.input_text
        Me.RightToLeftLayout = language_settings.language_RTL_layout
        Me.RightToLeft = language_settings.language_RTL
        Panel01.RightToLeft = language_settings.language_RTL
        panel02.RightToLeft = language_settings.language_RTL
        panel03.RightToLeft = language_settings.language_RTL
        panel04.RightToLeft = language_settings.language_RTL
        RadioButton_fast.Text = language_settings.input_RadioButton_fast
        RichTextBox_fast.Text = language_settings.input_RichTextBox_fast1 + vbNewLine + language_settings.input_RichTextBox_fast2 + vbNewLine + language_settings.input_RichTextBox_fast3 + vbNewLine + language_settings.input_RichTextBox_fast4
        RadioButton_full.Text = language_settings.input_RadioButton_full
        GroupBox_plate.Text = language_settings.input_GroupBox_plate
        GroupBox_plate.RightToLeft = language_settings.language_RTL
        Label_length.Text = language_settings.length_a
        Label_breadth.Text = language_settings.breadth_b
        Label_thickness.Text = language_settings.thickness_t
        Label_unit_m01.Text = language_settings.unit_meter
        Label_unit_m02.Text = language_settings.unit_meter
        Label_unit_mm01.Text = language_settings.unit_millimeter
        Label_unit_mm02.Text = language_settings.unit_millimeter
        Label_unit_mm03.Text = language_settings.unit_millimeter
        Label_unit_mm04.Text = language_settings.unit_millimeter
        Label_unit_mm05.Text = language_settings.unit_millimeter
        '******top Panel *************
        Button_status.Text = language_settings.input_button_status
        GUI_Update_steps()
        '******end top Panel *************
        '******panel 02 *************
        Label_type01.Text = language_settings.input_panel2_label_type01
        Label_type02.Text = language_settings.input_panel2_label_type02
        Label_type03.Text = language_settings.input_panel2_label_type03
        Label_type04.Text = language_settings.input_panel2_label_type04
        Button_panel02_back.Text = language_settings.input_panel2_button_back
        Label_type01.RightToLeft = language_settings.language_RTL
        Label_type02.RightToLeft = language_settings.language_RTL
        Label_type03.RightToLeft = language_settings.language_RTL
        Label_type04.RightToLeft = language_settings.language_RTL
        '******panel 03 *************
        ' TO BE COMPLETE LATER next 2 lines should be removed from ini file and so
        'Label_warning.Text = language_settings.input_panel3_Label_warning
        'Label_warning.RightToLeft = language_settings.language_RTL
        Button_view_parameters.Text = language_settings.results_Button_view_parameters
        Button_view_parameters.RightToLeft = language_settings.language_RTL
        button_panel03_back.Text = language_settings.input_panel3_button_panel03_back
        button_panel03_next.Text = language_settings.input_panel3_button_panel03_next
        numeric_short.RightToLeft = language_settings.language_RTL
        numeric_long.RightToLeft = language_settings.language_RTL
        PanelTop.RightToLeft = language_settings.language_RTL
        GroupBox_stiffeners_number.RightToLeft = language_settings.language_RTL
        GroupBox_stiffeners_number.Text = language_settings.input_panel3_GroupBox_stiffeners_number
        GroupBox_stiffeners_mark.RightToLeft = language_settings.language_RTL
        GroupBox_stiffeners_mark.Text = language_settings.input_panel3_GroupBox_stiffeners_mark
        CheckBox_Ia.RightToLeft = language_settings.language_RTL
        CheckBox_Ina.RightToLeft = language_settings.language_RTL
        CheckBox_Ib.RightToLeft = language_settings.language_RTL
        CheckBox_Inb.RightToLeft = language_settings.language_RTL
        GroupBox_stiffeners_data.Text = language_settings.input_panel3_GroupBox_stiffeners_data
        GroupBox_stiffeners_data.RightToLeft = language_settings.language_RTL
        GroupBox_moment_select_general.Text = language_settings.input_panel3_GroupBox_moment_select_general
        GroupBox_moment_select_general.RightToLeft = language_settings.language_RTL
        Radiobutton_select_DB.Text = language_settings.input_panel3_Radiobutton_select_DB
        Radiobutton_select_numeric.Text = language_settings.input_panel3_Radiobutton_select_numeric
        Radiobutton_select_geometric.Text = language_settings.input_panel3_Radiobutton_select_geometric
        '        button_select_type_of_input.Text = language_settings.input_panel3_button_select_type_of_input
        Groupbox_geometric_input.Text = language_settings.input_panel3_Groupbox_geometric_input
        Groupbox_geometric_input.RightToLeft = language_settings.language_RTL
        Label_stiffeners_long.RightToLeft = language_settings.language_RTL
        Label_stiffeners_short.RightToLeft = language_settings.language_RTL
        '********** NUMERIC STIFFeNERS FILLER ********
        ComboBox_num_moment_units.Items.Clear()
        ComboBox_num_moment_units.Items.Insert(0, language_settings.unit_millimeter4)
        ComboBox_num_moment_units.Items.Insert(1, language_settings.unit_centimeter4)
        ComboBox_num_moment_units.Items.Insert(2, language_settings.unit_meter4)
        ComboBox_num_moment_units.Text = ComboBox_num_moment_units.Items(0)
        ComboBox_num_area_units.Items.Clear()
        ComboBox_num_area_units.Items.Insert(0, language_settings.unit_millimeter2)
        ComboBox_num_area_units.Items.Insert(1, language_settings.unit_centimeter2)
        ComboBox_num_area_units.Items.Insert(2, language_settings.unit_meter2)
        ComboBox_num_area_units.Text = ComboBox_num_area_units.Items(0)
        ComboBox_num_center_units.Items.Clear()
        ComboBox_num_center_units.Items.Insert(0, language_settings.unit_millimeter)
        ComboBox_num_center_units.Items.Insert(1, language_settings.unit_centimeter)
        ComboBox_num_center_units.Items.Insert(2, language_settings.unit_meter)
        ComboBox_num_center_units.Text = ComboBox_num_center_units.Items(0)
        '********** GEOMETRIC STIFFeNERS FILLER ********
        Combobox_geo_select.Items.Clear()
        Combobox_geo_select.Items.Insert(0, language_settings.name_blade_stiffener)
        Combobox_geo_select.Items.Insert(1, language_settings.name_L_stiffener)
        Combobox_geo_select.Items.Insert(2, language_settings.name_T_stiffener)
        Combobox_geo_select.Items.Insert(3, language_settings.name_I_stiffener)
        Combobox_geo_select.Text = Combobox_geo_select.Items(0)
        Label_Geo_type_select.Text = language_settings.input_panel3_Label_Geo_type_select
        GroupBox_geo_input.Text = language_settings.input_panel3_GroupBox_geo_input
        Label_Geo_result.Text = language_settings.input_panel3_Label_Geo_result
        lblNumericInput.Text = language_settings.input_panel3_GroupBox_numeric_input
        Label_num_moment.Text = language_settings.input_panel3_Label_num_moment
        Label_num_area.Text = language_settings.input_panel3_Label_num_area
        Label_num_center.Text = language_settings.input_panel3_Label_num_center
        Button_num_selected.Text = language_settings.input_panel3_Button_num_selected
        '********** NUMERIC STIFFeNERS FILLER ********
        lblNumericInput.RightToLeft = language_settings.language_RTL
        ComboBox_num_moment_units.RightToLeft = language_settings.language_RTL
        ComboBox_num_area_units.RightToLeft = language_settings.language_RTL
        ComboBox_num_center_units.RightToLeft = language_settings.language_RTL
        Label_num_moment.RightToLeft = language_settings.language_RTL
        Label_num_area.RightToLeft = language_settings.language_RTL
        Label_num_center.RightToLeft = language_settings.language_RTL
        '********** DATABASE STIFFeNERS FILLER ********
        groupBox_DB_input.Text = language_settings.input_panel3_groupBox_DB_input
        groupBox_DB_sub.Text = language_settings.input_panel3_groupBox_DB_sub
        Label_DB_moment.Text = language_settings.input_panel3_Label_DB_moment
        Label_DB_area.Text = language_settings.input_panel3_Label_DB_area
        Label_DB_center.Text = language_settings.input_panel3_Label_DB_center
        Button_DB_selected.Text = language_settings.input_panel3_Button_DB_selected
        Label_DB_moment_unit.Text = language_settings.unit_centimeter4
        Label_DB_area_unit.Text = language_settings.unit_centimeter2
        Label_DB_center_unit.Text = language_settings.unit_centimeter
        groupBox_DB_input.RightToLeft = language_settings.language_RTL
        groupBox_DB_sub.RightToLeft = language_settings.language_RTL
        Label_DB_moment.RightToLeft = language_settings.language_RTL
        Label_DB_area.RightToLeft = language_settings.language_RTL
        Label_DB_center.RightToLeft = language_settings.language_RTL
        Label_DB_moment_unit.RightToLeft = language_settings.language_RTL
        Label_DB_area_unit.RightToLeft = language_settings.language_RTL
        Label_DB_center_unit.RightToLeft = language_settings.language_RTL

        '******panel 04 *************
        ComboBox_P_units.Items.Clear()
        ComboBox_P_units.Items.Insert(0, language_settings.unit_Pa)
        ComboBox_P_units.Items.Insert(1, language_settings.unit_KPa)
        ComboBox_P_units.Items.Insert(2, language_settings.unit_MPa)
        ComboBox_P_units.Text = ComboBox_P_units.Items(0)
        GroupBox_BC.Text = language_settings.input_panel4_GroupBox_BC
        GroupBox_BC.RightToLeft = language_settings.language_RTL
        Label_pressure.Text = language_settings.input_panel4_Label_pressure
        Label_modulus.Text = language_settings.input_panel4_Label_modulus
        label_BC_title.Text = language_settings.input_panel4_label_BC_title
        label_ni.Text = language_settings.input_panel4_label_ni
        Label_BC.Text = language_settings.input_panel4_Label_BC
        Button_panel04_back.Text = language_settings.input_panel4_Button_panel04_back
        Button_panel04_next.Text = language_settings.input_panel4_Button_panel04_next
        Label_pressure.RightToLeft = language_settings.language_RTL
        Label_modulus.RightToLeft = language_settings.language_RTL
        label_ni.RightToLeft = language_settings.language_RTL
        Label_BC.RightToLeft = language_settings.language_RTL
        label_type_of_BC.RightToLeft = language_settings.language_RTL
        Button_panel04_back.RightToLeft = language_settings.language_RTL
        Button_panel04_next.RightToLeft = language_settings.language_RTL

        If general_settings.general_variables.current_model = "orthotropic plate model" Then
            Label_stiffeners_long.Text = language_settings.input_panel3_Label_stiffeners_long_orthotropic
            Label_stiffeners_short.Text = language_settings.input_panel3_Label_stiffeners_short_orthotropic
            CheckBox_Ia.Text = language_settings.input_panel3_CheckBox_Ia_Orthotropic
            CheckBox_Ina.Text = language_settings.input_panel3_CheckBox_Ina_Orthotropic
            CheckBox_Ib.Text = language_settings.input_panel3_CheckBox_Ib_Orthotropic
            CheckBox_Inb.Text = language_settings.input_panel3_CheckBox_Inb_Orthotropic
        ElseIf general_settings.general_variables.current_model = "grillage model" Then
            Label_stiffeners_long.Text = language_settings.input_panel3_Label_stiffeners_long_grillage
            Label_stiffeners_short.Text = language_settings.input_panel3_Label_stiffeners_short_grillage
            CheckBox_Ia.Text = language_settings.input_panel3_CheckBox_r_center_Grillage
            CheckBox_Ina.Text = language_settings.input_panel3_CheckBox_r_noncenter_Grillage
            CheckBox_Ib.Text = language_settings.input_panel3_CheckBox_s_center_Grillage
            CheckBox_Inb.Text = language_settings.input_panel3_CheckBox_s_noncenter_Grillage
        End If

        Label_short.Text = language_settings.breadth_b.Substring(language_settings.breadth_b.Length - 1)
        Label_long.Text = language_settings.length_a.Substring(language_settings.length_a.Length - 1)
    End Sub
    Private Sub GUI_set_locations()
        If Me.Focused Then
            'Button_next_panel01.Location = New Point((Me.Width - Button_next_panel01.Width) / 2, Button_next_panel01.Location.Y)
            ' GroupBox_plate.Location = New Point((Me.Width - GroupBox_plate.Width) / 2, GroupBox_plate.Location.Y)
        End If
    End Sub
    Private Sub GUI_update_stiffeners_Grillage_model(ByVal combo As Object)
        If combo.Name = "CheckBox_Ia" Then
            CheckBox_Ina.Checked = combo.checked
        ElseIf combo.Name = "CheckBox_Ina" Then
            CheckBox_Ia.Checked = combo.checked
        ElseIf combo.Name = "CheckBox_Ib" Then
            CheckBox_Inb.Checked = combo.checked
        ElseIf combo.Name = "CheckBox_Inb" Then
            CheckBox_Ib.Checked = combo.checked
        End If
    End Sub
    Private Sub set_data()
        If CheckBox_Ia.Checked = True Then
            Ia_stiffener = current_moment
            ya_stiffener = current_center
            Aa_stiffener = current_area
        End If
        If CheckBox_Ib.Checked = True Then
            Ib_stiffener = current_moment
            yb_stiffener = current_center
            Ab_stiffener = current_area
        End If
        If CheckBox_Ina.Checked = True Then
            Ina_stiffeners = current_moment
            yna_stiffeners = current_center
            Ana_stiffeners = current_area
        End If
        If CheckBox_Inb.Checked = True Then
            Inb_stiffeners = current_moment
            ynb_stiffeners = current_center
            Anb_stiffeners = current_area
        End If
        gui_update_stiffeners()
    End Sub
    Private Sub gui_update_stiffeners()
        '************ SETTING TEXT *****************
        toolTip_stiffeners.RemoveAll()
        Dim str_Ia As String = ""
        Dim str_Ina As String = ""
        Dim str_Ib As String = ""
        Dim str_Inb As String = ""
        str_Ia = language_settings.input_panel3_tooltip_Ia + " " + Chr(13) + language_settings.msg017 + CStr(Math.Round(Ia_stiffener * 100 ^ 4, 4)) + " " + language_settings.unit_centimeter4 + " " + Chr(13) + language_settings.msg018 + " " + CStr(Math.Round(Aa_stiffener * 100 ^ 2, 4)) + language_settings.unit_centimeter2 + Chr(13) + language_settings.msg019 + " " + CStr(ya_stiffener * 100) + language_settings.unit_centimeter
        str_Ib = language_settings.input_panel3_tooltip_Ib + " " + Chr(13) + language_settings.msg017 + CStr(Math.Round(Ib_stiffener * 100 ^ 4, 4)) + " " + language_settings.unit_centimeter4 + " " + Chr(13) + language_settings.msg018 + " " + CStr(Math.Round(Ab_stiffener * 100 ^ 2, 4)) + language_settings.unit_centimeter2 + Chr(13) + language_settings.msg019 + " " + CStr(yb_stiffener * 100) + language_settings.unit_centimeter
        str_Ina = language_settings.input_panel3_tooltip_Ina + " " + Chr(13) + language_settings.msg017 + CStr(Math.Round(Ina_stiffeners * 100 ^ 4, 4)) + " " + language_settings.unit_centimeter4 + " " + Chr(13) + language_settings.msg018 + " " + CStr(Math.Round(Ana_stiffeners * 100 ^ 2, 4)) + language_settings.unit_centimeter2 + Chr(13) + language_settings.msg019 + " " + CStr(yna_stiffeners * 100) + language_settings.unit_centimeter
        str_Inb = language_settings.input_panel3_tooltip_Inb + " " + Chr(13) + language_settings.msg017 + CStr(Math.Round(Inb_stiffeners * 100 ^ 4, 4)) + " " + language_settings.unit_centimeter4 + " " + Chr(13) + language_settings.msg018 + " " + CStr(Math.Round(Anb_stiffeners * 100 ^ 2, 4)) + language_settings.unit_centimeter2 + Chr(13) + language_settings.msg019 + " " + CStr(ynb_stiffeners * 100) + language_settings.unit_centimeter
        toolTip_stiffeners.AutoPopDelay = 5000
        toolTip_stiffeners.InitialDelay = 100
        toolTip_stiffeners.ReshowDelay = 0
        toolTip_stiffeners.ShowAlways = True
        toolTip_stiffeners.SetToolTip(Me.PictureBox_Ia_info, str_Ia)
        toolTip_stiffeners.SetToolTip(Me.PictureBox_Ib_info, str_Ib)
        toolTip_stiffeners.SetToolTip(Me.PictureBox_Ina_info, str_Ina)
        toolTip_stiffeners.SetToolTip(Me.PictureBox_Inb_info, str_Inb)
        '*************** SETTING IMAGES *******************
        '*********Orthotropic plate model ****************
        If general_settings.general_variables.current_model = "orthotropic plate model" Then
            Select Case geo_type
                Case 1
                Case 2
                    CheckBox_Ia.Checked = False
                    CheckBox_Ia.Enabled = False
                    CheckBox_Ina.Checked = False
                    CheckBox_Ina.Enabled = False
                    CheckBox_Ib.Checked = True
                    CheckBox_Ib.Enabled = False
                    CheckBox_Inb.Checked = True
                    CheckBox_Inb.Enabled = False
                    PictureBox_Ia_checked.Image = ImageList_icons.Images(2)
                    PictureBox_Ia_info.Visible = True
                    Ia_stiffener = 0
                    PictureBox_Ina_checked.Image = ImageList_icons.Images(2)
                    PictureBox_Ina_info.Visible = True
                    Ina_stiffeners = 0
                    If Ib_stiffener > 0 Then
                        PictureBox_Ib_checked.Image = ImageList_icons.Images(2)
                        PictureBox_Ib_info.Visible = True
                    Else
                        PictureBox_Ib_checked.Image = ImageList_icons.Images(4) 'or 0
                        PictureBox_Ib_info.Visible = False
                    End If
                    If Inb_stiffeners > 0 Then
                        PictureBox_Inb_checked.Image = ImageList_icons.Images(2)
                        PictureBox_Inb_info.Visible = True
                    Else
                        PictureBox_Inb_checked.Image = ImageList_icons.Images(4) 'or 0
                        PictureBox_Inb_info.Visible = False
                    End If
                Case 3
                    PictureBox_Ina_checked.Image = ImageList_icons.Images(2)
                    PictureBox_Ina_info.Visible = True
                    Ina_stiffeners = 0
                    If Ia_stiffener > 0 Then
                        PictureBox_Ia_checked.Image = ImageList_icons.Images(2)
                        PictureBox_Ia_info.Visible = True
                    Else
                        PictureBox_Ia_checked.Image = ImageList_icons.Images(4) 'or 0
                        PictureBox_Ia_info.Visible = False
                    End If
                    If Ib_stiffener > 0 Then
                        PictureBox_Ib_checked.Image = ImageList_icons.Images(2)
                        PictureBox_Ib_info.Visible = True
                    Else
                        PictureBox_Ib_checked.Image = ImageList_icons.Images(4) 'or 0
                        PictureBox_Ib_info.Visible = False
                    End If
                    If Inb_stiffeners > 0 Then
                        PictureBox_Inb_checked.Image = ImageList_icons.Images(2)
                        PictureBox_Inb_info.Visible = True
                    Else
                        PictureBox_Inb_checked.Image = ImageList_icons.Images(4) 'or 0
                        PictureBox_Inb_info.Visible = False
                    End If
                Case 4
                    If Ia_stiffener > 0 Then
                        PictureBox_Ia_checked.Image = ImageList_icons.Images(2)
                        PictureBox_Ia_info.Visible = True
                    Else
                        PictureBox_Ia_checked.Image = ImageList_icons.Images(4) 'or 0
                        PictureBox_Ia_info.Visible = False
                    End If
                    If Ina_stiffeners > 0 Then
                        PictureBox_Ina_checked.Image = ImageList_icons.Images(2)
                        PictureBox_Ina_info.Visible = True
                    Else
                        PictureBox_Ina_checked.Image = ImageList_icons.Images(4) 'or 0
                        PictureBox_Ina_info.Visible = False
                    End If
                    If Ib_stiffener > 0 Then
                        PictureBox_Ib_checked.Image = ImageList_icons.Images(2)
                        PictureBox_Ib_info.Visible = True
                    Else
                        PictureBox_Ib_checked.Image = ImageList_icons.Images(4) 'or 0
                        PictureBox_Ib_info.Visible = False
                    End If
                    If Inb_stiffeners > 0 Then
                        PictureBox_Inb_checked.Image = ImageList_icons.Images(2)
                        PictureBox_Inb_info.Visible = True
                    Else
                        PictureBox_Inb_checked.Image = ImageList_icons.Images(4) 'or 0
                        PictureBox_Inb_info.Visible = False
                    End If
            End Select
            '*********Grillage model ****************
        ElseIf general_settings.general_variables.current_model = "grillage model" Then
            If Ia_stiffener > 0 Then
                PictureBox_Ia_checked.Image = ImageList_icons.Images(2)
                PictureBox_Ia_info.Visible = True
            Else
                PictureBox_Ia_checked.Image = ImageList_icons.Images(4) 'or 0
                PictureBox_Ia_info.Visible = False
            End If
            If Ina_stiffeners > 0 Then
                PictureBox_Ina_checked.Image = ImageList_icons.Images(2)
                PictureBox_Ina_info.Visible = True
            Else
                PictureBox_Ina_checked.Image = ImageList_icons.Images(4) 'or 0
                PictureBox_Ina_info.Visible = False
            End If
            If Ib_stiffener > 0 Then
                PictureBox_Ib_checked.Image = ImageList_icons.Images(2)
                PictureBox_Ib_info.Visible = True
            Else
                PictureBox_Ib_checked.Image = ImageList_icons.Images(4) 'or 0
                PictureBox_Ib_info.Visible = False
            End If
            If Inb_stiffeners > 0 Then
                PictureBox_Inb_checked.Image = ImageList_icons.Images(2)
                PictureBox_Inb_info.Visible = True
            Else
                PictureBox_Inb_checked.Image = ImageList_icons.Images(4) 'or 0
                PictureBox_Inb_info.Visible = False
            End If
        End If
        '*************** SHOW DATA INPUT *******************
        If (CheckBox_Ia.Checked = True) Or (CheckBox_Ina.Checked = True) Or (CheckBox_Ib.Checked = True) Or (CheckBox_Inb.Checked = True) Then
            GroupBox_stiffeners_data.Visible = True
        Else
            GroupBox_stiffeners_data.Visible = False
        End If
        '*************** SHOW NEXT BUTTON *******************
        '*********Orthotropic plate model ****************
        If general_settings.general_variables.current_model = "orthotropic plate model" Then
            Select Case geo_type
                Case 4
                    If (Ia_stiffener <> 0) AndAlso (Ib_stiffener <> 0) AndAlso (Ina_stiffeners <> 0) AndAlso (Inb_stiffeners <> 0) Then
                        button_panel03_next.Visible = True
                    Else
                        button_panel03_next.Visible = False
                    End If
                Case 3
                    If (Ia_stiffener <> 0) AndAlso (Ib_stiffener <> 0) AndAlso (Inb_stiffeners <> 0) Then
                        button_panel03_next.Visible = True
                    Else
                        button_panel03_next.Visible = False
                    End If
                Case 2
                    If (Ib_stiffener <> 0) AndAlso (Inb_stiffeners <> 0) Then
                        button_panel03_next.Visible = True
                    Else
                        button_panel03_next.Visible = False
                    End If
            End Select
            '*********Grillage model ****************
        ElseIf general_settings.general_variables.current_model = "grillage model" Then
            If (Ia_stiffener <> 0) AndAlso (Ib_stiffener <> 0) AndAlso (Ina_stiffeners <> 0) AndAlso (Inb_stiffeners <> 0) Then
                button_panel03_next.Visible = True
            Else
                button_panel03_next.Visible = False
            End If
        End If
    End Sub
    Private Sub RadioButton_fast_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_fast.CheckedChanged
        If RadioButton_fast.Checked = True Then
            GroupBox_plate.Enabled = False
        ElseIf RadioButton_full.Checked = True Then
            GroupBox_plate.Enabled = True
        Else
            MsgBox("ERROR 01")
        End If
    End Sub
    Private Sub Button_back_panel02_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_panel02_back.Click
        TabControl1.SelectedIndex = 1
        GUI_Update_steps()
    End Sub
    Private Sub GUI_Input_Parameters_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        GUI_set(language_settings.language_current_file)
        gui_update_stiffeners()
    End Sub
    Private Sub Form_loading(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        GUI_set(language_settings.language_current_file)
        gui_update_stiffeners()
        GUI_set_locations()
        TabControl1.SelectedIndex = 0
    End Sub
    Private Sub Button_next_panel01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_next_panel01.Click
        Dim continue_process As Boolean = True
        If RadioButton_full.Checked = True Then
            '*********** FULL PROCESS **************
            If general_settings.general_variables.current_model = "orthotropic plate model" Then
                If general_functions.check_data(numeric_plate_long.Text) = True Then
                    a = numeric_plate_long.Text
                Else
                    general_settings.messages.read_msg(1)
                    general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                    continue_process = False
                End If
                If general_functions.check_data(numeric_plate_short.Text) = True Then

                    b = numeric_plate_short.Text
                Else
                    general_settings.messages.read_msg(2)
                    general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                    continue_process = False
                End If
                If general_functions.check_data(numeric_plate_t.Text) = True Then
                    t = numeric_plate_t.Text / 1000
                Else
                    general_settings.messages.read_msg(3)
                    general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                    continue_process = False
                End If
                If b > a Then
                    general_settings.messages.read_msg(4)
                    general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                    If general_settings.messages.msg_res = MsgBoxResult.Yes Then
                        Dim temp As Single = a
                        a = b
                        b = temp
                    Else
                        continue_process = False
                    End If
                End If
            ElseIf general_settings.general_variables.current_model = "grillage model" Then
                If general_functions.check_data(numeric_plate_long.Text) = True Then
                    b = numeric_plate_long.Text
                Else
                    general_settings.messages.read_msg(1)
                    general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                    continue_process = False
                End If
                If general_functions.check_data(numeric_plate_short.Text) = True Then
                    a = numeric_plate_short.Text
                Else
                    general_settings.messages.read_msg(2)
                    general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                    continue_process = False
                End If
                If general_functions.check_data(numeric_plate_t.Text) = True Then
                    t = numeric_plate_t.Text / 1000
                Else
                    general_settings.messages.read_msg(3)
                    general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                    continue_process = False
                End If
                If a > b Then
                    general_settings.messages.read_msg(4)
                    general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                    If general_settings.messages.msg_res = MsgBoxResult.Yes Then
                        Dim temp As Single = a
                        a = b
                        b = temp
                    Else
                        continue_process = False
                    End If
                End If
            Else
                ' TO BE COMPLETE LATER
            End If

            If continue_process = True Then
                '************* all ok for full process *****************
                Me.MinimumSize = New Size(0, 0)
                If general_settings.general_variables.current_model = "orthotropic plate model" Then
                    TabControl1.SelectedIndex = 1
                ElseIf general_settings.general_variables.current_model = "grillage model" Then
                    TabControl1.SelectedIndex = 2
                End If
                GUI_Update_steps()
            End If

        ElseIf RadioButton_fast.Checked = True Then
            '********** Fast process *************
            If general_settings.general_variables.current_model = "orthotropic plate model" Then
                'models_calculations.General_variables.last_used_model = "Orthotropic Plate model" removed object
                models_calculations.Orthotropic_model.model_variables.a = 4
                models_calculations.Orthotropic_model.model_variables.b = 4
                models_calculations.Orthotropic_model.model_variables.t = 0.01
                models_calculations.Orthotropic_model.model_variables.P = 1000
                models_calculations.Orthotropic_model.model_variables.E = 200
                models_calculations.Orthotropic_model.model_variables.ni = 0.3
                models_calculations.Orthotropic_model.model_variables.C = 1
                models_calculations.Orthotropic_model.model_variables.Na = 3
                models_calculations.Orthotropic_model.model_variables.Nb = 3
                models_calculations.Orthotropic_model.model_variables.geo_type = 4
                models_calculations.Orthotropic_model.model_variables.Ia_stiffener = 0.0000003413333
                models_calculations.Orthotropic_model.model_variables.Ib_stiffener = 0.0000003413333
                models_calculations.Orthotropic_model.model_variables.Ina_stiffeners = 0.0000003413333
                models_calculations.Orthotropic_model.model_variables.Inb_stiffeners = 0.0000003413333
                models_calculations.Orthotropic_model.model_variables.Ya_stiffener = 0.04
                models_calculations.Orthotropic_model.model_variables.Yb_stiffener = 0.04
                models_calculations.Orthotropic_model.model_variables.Yna_stiffeners = 0.04
                models_calculations.Orthotropic_model.model_variables.Ynb_stiffeners = 0.04
                models_calculations.Orthotropic_model.model_variables.Aa_stiffener = 0.00064
                models_calculations.Orthotropic_model.model_variables.Ab_stiffener = 0.00064
                models_calculations.Orthotropic_model.model_variables.Ana_stiffeners = 0.00064
                models_calculations.Orthotropic_model.model_variables.Anb_stiffeners = 0.00064
            ElseIf general_settings.general_variables.current_model = "grillage model" Then
                'models_calculations.General_variables.last_used_model = "Grillage model" removed code
                models_calculations.Grillage_model.model_variables.a = 4
                models_calculations.Grillage_model.model_variables.b = 4
                models_calculations.Grillage_model.model_variables.t = 0.01
                models_calculations.Grillage_model.model_variables.P = 1000
                models_calculations.Grillage_model.model_variables.E = 200
                models_calculations.Grillage_model.model_variables.ni = 0.3
                models_calculations.Grillage_model.model_variables.BC = 1
                models_calculations.Grillage_model.model_variables.r = 3 'r>=s
                models_calculations.Grillage_model.model_variables.s = 3 'r>=s
                models_calculations.Grillage_model.model_variables.Ir_stiffeners = 0.0000003413333
                models_calculations.Grillage_model.model_variables.Is_stiffeners = 0.0000003413333
                models_calculations.Grillage_model.model_variables.Yr_stiffeners = 0.04
                models_calculations.Grillage_model.model_variables.Ys_stiffeners = 0.04
                models_calculations.Grillage_model.model_variables.Ar_stiffeners = 0.00064
                models_calculations.Grillage_model.model_variables.As_stiffeners = 0.00064
            End If
            Dim data_status As New GUI_Data_and_Results
            data_status.load_data()
            data_status.Show()
            Me.Close()
        Else
            'no model has been selected
        End If
    End Sub
    Private Sub new_input_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged, MyBase.MaximumSizeChanged, MyBase.Resize, MyBase.MinimumSizeChanged, MyBase.Activated
        GUI_set_locations()
    End Sub
    Private Sub numeric_plate_long_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numeric_plate_long.ValueChanged
        If numeric_plate_long.Value < numeric_plate_short.Value Then
            numeric_plate_short.Value = numeric_plate_long.Value
        End If
    End Sub
    Private Sub numeric_plate_short_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numeric_plate_short.ValueChanged
        If numeric_plate_long.Value < numeric_plate_short.Value Then
            numeric_plate_long.Value = numeric_plate_short.Value
        End If
    End Sub
    Private Sub Button_status_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_status.Click
        ' TO BE COMPLETE LATER Need to fix the button to show real values
        If language_settings.language_RTL_layout = True Then
            Dim title As String
            Dim style As MsgBoxStyle = MsgBoxStyle.OkOnly + MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading
            Dim response As MsgBoxResult
            Dim plate_string As String = language_settings.msg031 + CStr(a) + Chr(13) + language_settings.msg032 + CStr(b) + Chr(13) + language_settings.msg033 + CStr(t * 1000) + Chr(13) + Chr(13)
            Dim stf_numbering As String = Chr(13) + Chr(13) + language_settings.msg034 + CStr(stiffeners_long) + Chr(13) + language_settings.msg035 + CStr(stiffeners_short) + Chr(13) + Chr(13)
            Dim stf_string As String = ""
            If geo_type = 0 Then
                stf_string = language_settings.msg036 + Chr(13) + language_settings.msg037
            ElseIf geo_type = 1 Then
                stf_string = language_settings.msg036 + Chr(13) + language_settings.msg038
            ElseIf geo_type = 2 Then
                stf_string = language_settings.msg036 + Chr(13) + language_settings.msg039 + Chr(13) + language_settings.msg042 + CStr(Inb_stiffeners) + Chr(13) + language_settings.msg040 + CStr(Anb_stiffeners) + Chr(13) + language_settings.msg041 + CStr(ynb_stiffeners)
            ElseIf geo_type = 3 Then
                stf_string = language_settings.msg036 + Chr(13) + language_settings.msg043 + Chr(13) + "        " + language_settings.msg042 + CStr(Ia_stiffener) + Chr(13) + "        " + language_settings.msg040 + CStr(Aa_stiffener) + Chr(13) + "        " + language_settings.msg041 + CStr(ya_stiffener) + Chr(13) + _
                language_settings.msg044 + Chr(13) + "    " + language_settings.msg045 + Chr(13) + "        " + language_settings.msg042 + CStr(Ib_stiffener) + Chr(13) + "        " + language_settings.msg040 + CStr(Ab_stiffener) + Chr(13) + "        " + language_settings.msg041 + CStr(yb_stiffener) + Chr(13) + _
                "    " + language_settings.msg046 + Chr(13) + "        " + language_settings.msg042 + CStr(Inb_stiffeners) + Chr(13) + "        " + language_settings.msg040 + CStr(Anb_stiffeners) + Chr(13) + "        " + language_settings.msg041 + CStr(ynb_stiffeners)
            ElseIf geo_type = 4 Then
                stf_string = language_settings.msg036 + Chr(13) + language_settings.msg047 + Chr(13) + "    " + language_settings.msg045 + Chr(13) + "        " + language_settings.msg042 + CStr(Ia_stiffener) + Chr(13) + "        " + language_settings.msg040 + CStr(Aa_stiffener) + Chr(13) + "        " + language_settings.msg041 + CStr(ya_stiffener) + Chr(13) + _
                "    " + language_settings.msg046 + Chr(13) + "        " + language_settings.msg042 + CStr(Ina_stiffeners) + Chr(13) + "        " + language_settings.msg040 + CStr(Ana_stiffeners) + Chr(13) + "        " + language_settings.msg041 + CStr(yna_stiffeners) + Chr(13) + _
                language_settings.msg044 + Chr(13) + "    " + language_settings.msg045 + Chr(13) + "        " + language_settings.msg042 + CStr(Ib_stiffener) + Chr(13) + "        " + language_settings.msg040 + CStr(Ab_stiffener) + Chr(13) + "        " + language_settings.msg041 + CStr(yb_stiffener) + Chr(13) + _
                "    " + language_settings.msg046 + Chr(13) + "        " + language_settings.msg042 + CStr(Inb_stiffeners) + Chr(13) + "        " + language_settings.msg040 + CStr(Anb_stiffeners) + Chr(13) + "        " + language_settings.msg041 + CStr(ynb_stiffeners) + Chr(13)
            End If
            title = language_settings.msg048   ' Define title.
            response = MsgBox(plate_string + stf_string + stf_numbering, style, title)
        ElseIf language_settings.language_RTL_layout = False Then
            Dim title As String
            Dim style As MsgBoxStyle = MsgBoxStyle.OkOnly + MsgBoxStyle.Information
            Dim response As MsgBoxResult
            Dim plate_string As String = language_settings.msg031 + CStr(a) + Chr(13) + language_settings.msg032 + CStr(b) + Chr(13) + language_settings.msg033 + CStr(t * 1000) + Chr(13) + Chr(13)
            Dim stf_numbering As String = Chr(13) + Chr(13) + language_settings.msg034 + CStr(stiffeners_long) + Chr(13) + language_settings.msg035 + CStr(stiffeners_short) + Chr(13) + Chr(13)
            Dim stf_string As String = ""
            If geo_type = 0 Then
                stf_string = language_settings.msg036 + Chr(13) + language_settings.msg037
            ElseIf geo_type = 1 Then
                stf_string = language_settings.msg036 + Chr(13) + language_settings.msg038
            ElseIf geo_type = 2 Then
                stf_string = language_settings.msg036 + Chr(13) + language_settings.msg039 + Chr(13) + language_settings.msg042 + CStr(Inb_stiffeners) + Chr(13) + language_settings.msg040 + CStr(Anb_stiffeners) + Chr(13) + language_settings.msg041 + CStr(ynb_stiffeners)
            ElseIf geo_type = 3 Then
                stf_string = language_settings.msg036 + Chr(13) + language_settings.msg043 + Chr(13) + "        " + language_settings.msg042 + CStr(Ia_stiffener) + Chr(13) + "        " + language_settings.msg040 + CStr(Aa_stiffener) + Chr(13) + "        " + language_settings.msg041 + CStr(ya_stiffener) + Chr(13) + _
                language_settings.msg044 + Chr(13) + "    " + language_settings.msg045 + Chr(13) + "        " + language_settings.msg042 + CStr(Ib_stiffener) + Chr(13) + "        " + language_settings.msg040 + CStr(Ab_stiffener) + Chr(13) + "        " + language_settings.msg041 + CStr(yb_stiffener) + Chr(13) + _
                "    " + language_settings.msg046 + Chr(13) + "        " + language_settings.msg042 + CStr(Inb_stiffeners) + Chr(13) + "        " + language_settings.msg040 + CStr(Anb_stiffeners) + Chr(13) + "        " + language_settings.msg041 + CStr(ynb_stiffeners)
            ElseIf geo_type = 4 Then
                stf_string = language_settings.msg036 + Chr(13) + language_settings.msg047 + Chr(13) + "    " + language_settings.msg045 + Chr(13) + "        " + language_settings.msg042 + CStr(Ia_stiffener) + Chr(13) + "        " + language_settings.msg040 + CStr(Aa_stiffener) + Chr(13) + "        " + language_settings.msg041 + CStr(ya_stiffener) + Chr(13) + _
                "    " + language_settings.msg046 + Chr(13) + "        " + language_settings.msg042 + CStr(Ina_stiffeners) + Chr(13) + "        " + language_settings.msg040 + CStr(Ana_stiffeners) + Chr(13) + "        " + language_settings.msg041 + CStr(yna_stiffeners) + Chr(13) + _
                language_settings.msg044 + Chr(13) + "    " + language_settings.msg045 + Chr(13) + "        " + language_settings.msg042 + CStr(Ib_stiffener) + Chr(13) + "        " + language_settings.msg040 + CStr(Ab_stiffener) + Chr(13) + "        " + language_settings.msg041 + CStr(yb_stiffener) + Chr(13) + _
                "    " + language_settings.msg046 + Chr(13) + "        " + language_settings.msg042 + CStr(Inb_stiffeners) + Chr(13) + "        " + language_settings.msg040 + CStr(Anb_stiffeners) + Chr(13) + "        " + language_settings.msg041 + CStr(ynb_stiffeners) + Chr(13)
            End If
            title = language_settings.msg048
            response = MsgBox(plate_string + stf_string + stf_numbering, style, title)
        Else
            general_settings.messages.msg_text = "Language setting is missing."
            general_settings.messages.msg_title = "Unable to display message"
            general_settings.messages.msg_style = MsgBoxStyle.Critical + MsgBoxStyle.OkOnly
            general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
        End If
    End Sub
    Private Sub Button_type04_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_type04.Click
        If general_settings.general_variables.current_model = "orthotropic plate model" Then
            'remove this ***
            'numeric_long.Minimum = 3
            numeric_long.Enabled = True
            'remove this ***
            'numeric_short.Minimum = 3
            numeric_short.Enabled = True
            '************ Setting types ****************
            CheckBox_Ia.Enabled = True
            CheckBox_Ib.Enabled = True
            CheckBox_Ina.Enabled = True
            CheckBox_Inb.Enabled = True
            GroupBox_stiffeners_data.Visible = False
            '************ show panel ****************
            geo_type = 4
            gui_update_stiffeners()
            CheckBox_Ia.Checked = False
            CheckBox_Ib.Checked = False
            CheckBox_Ina.Checked = False
            CheckBox_Inb.Checked = False
            TabControl1.SelectedIndex = 2
            GUI_Update_steps()
        ElseIf general_settings.general_variables.current_model = "grillage model" Then
            numeric_long.Minimum = 1
            numeric_long.Enabled = True
            numeric_short.Minimum = 1
            numeric_short.Enabled = True
            '************ Setting types ****************
            CheckBox_Ia.Enabled = True
            CheckBox_Ib.Enabled = True
            CheckBox_Ina.Enabled = True
            CheckBox_Inb.Enabled = True
            GroupBox_stiffeners_data.Visible = False
            '************ show panel ****************
            gui_update_stiffeners()
            CheckBox_Ia.Checked = False
            CheckBox_Ib.Checked = False
            CheckBox_Ina.Checked = False
            CheckBox_Inb.Checked = False
            TabControl1.SelectedIndex = 2
            GUI_Update_steps()
        End If
    End Sub
    Private Sub Button_type03_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_type03.Click
        numeric_short.Minimum = 3
        numeric_short.Enabled = True
        numeric_long.Minimum = 1
        numeric_long.Text = 1
        numeric_long.Value = 1
        numeric_long.Enabled = False
        GroupBox_stiffeners_data.Visible = False
        '************ Setting types ****************
        CheckBox_Ia.Enabled = True
        CheckBox_Ib.Enabled = True
        CheckBox_Ina.Enabled = False
        CheckBox_Inb.Enabled = True
        Ina_stiffeners = 0
        Ina_stiffeners = 0
        Ana_stiffeners = 0
        yna_stiffeners = 0
        GroupBox_stiffeners_data.Visible = False
        '************ show panel ****************
        geo_type = 3
        gui_update_stiffeners()
        CheckBox_Ia.Checked = False
        CheckBox_Ib.Checked = False
        CheckBox_Ina.Checked = False
        CheckBox_Inb.Checked = False
        TabControl1.SelectedIndex = 2
        GUI_Update_steps()
    End Sub
    Private Sub Button_type02_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_type02.Click
        '************ Setting numbers ****************
        numeric_long.Minimum = 0
        numeric_long.Text = 0
        numeric_long.Value = 0
        numeric_long.Enabled = False
        numeric_short.Minimum = 1
        numeric_short.Enabled = True
        '************ Setting types ****************
        CheckBox_Ia.Checked = False
        CheckBox_Ia.Enabled = False
        CheckBox_Ina.Checked = False
        CheckBox_Ina.Enabled = False
        CheckBox_Ib.Checked = True
        CheckBox_Ib.Enabled = False
        CheckBox_Inb.Checked = True
        CheckBox_Inb.Enabled = False
        Ia_stiffener = 0
        Aa_stiffener = 0
        ya_stiffener = 0
        Ina_stiffeners = 0
        Ana_stiffeners = 0
        yna_stiffeners = 0
        '************ show panel ****************
        geo_type = 2
        gui_update_stiffeners()
        TabControl1.SelectedIndex = 2
        GUI_Update_steps()
    End Sub
    Private Sub button_panel03_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_panel03_back.Click

        If general_settings.general_variables.current_model = "orthotropic plate model" Then
            TabControl1.SelectedIndex = 1
        ElseIf general_settings.general_variables.current_model = "grillage model" Then
            TabControl1.SelectedIndex = 0
        Else
        End If
        GUI_Update_steps()
    End Sub
    Private Sub Button_type01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_type01.Click
        geo_type = 1
        Ina_stiffeners = 0
        Inb_stiffeners = 0
        Ia_stiffener = 0
        Ib_stiffener = 0
        Ana_stiffeners = 0
        Anb_stiffeners = 0
        Aa_stiffener = 0
        Ab_stiffener = 0
        yna_stiffeners = 0
        ya_stiffener = 0
        ynb_stiffeners = 0
        yb_stiffener = 0
        TabControl1.SelectedIndex = 3
        gui_update_stiffeners()
        GUI_Update_steps()
    End Sub
    Private Sub CheckBox_stiffeneres_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox_Ia.CheckedChanged, CheckBox_Ib.CheckedChanged, CheckBox_Ina.CheckedChanged, CheckBox_Inb.CheckedChanged
        gui_update_stiffeners()
        If general_settings.general_variables.current_model = "grillage model" Then
            GUI_update_stiffeners_Grillage_model(sender)
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
    Private Sub select_type_of_input(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radiobutton_select_geometric.CheckedChanged, Radiobutton_select_DB.CheckedChanged, Radiobutton_select_numeric.CheckedChanged
        If Radiobutton_select_DB.Checked = True Then
            TabControl2.SelectedIndex = 2
        ElseIf Radiobutton_select_numeric.Checked = True Then
            TabControl2.SelectedIndex = 0
        ElseIf Radiobutton_select_geometric.Checked = True Then
            TabControl2.SelectedIndex = 1
        Else
            MsgBox("ERROR: Input method must be selected")
        End If
    End Sub
    Private Sub Button_Geo_selected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Geo_selected.Click
        '********* Blade stiffeners *****************
        If (Combobox_geo_select.Text = language_settings.name_blade_stiffener) Then
            If general_functions.check_data(MaskedTextBox_geo_b.Text) = True And general_functions.check_data(MaskedTextBox_geo_d.Text) = True Then
                current_moment = CSng(models_calculations.general_functions.moment_of_inertia(MaskedTextBox_geo_b.Text, MaskedTextBox_geo_d.Text, 0, 0, "|"))
                current_area = CSng(models_calculations.general_functions.Area(MaskedTextBox_geo_b.Text, MaskedTextBox_geo_d.Text, 0, 0, "|"))
                current_center = CSng(models_calculations.general_functions.centroid(MaskedTextBox_geo_b.Text, MaskedTextBox_geo_d.Text, 0, 0, "|"))
                set_data()
                If geo_type = 4 Then
                    CheckBox_Ia.Checked = False
                    CheckBox_Ib.Checked = False
                    CheckBox_Ina.Checked = False
                    CheckBox_Inb.Checked = False
                    GroupBox_stiffeners_data.Visible = False
                ElseIf geo_type = 3 Then
                    CheckBox_Ia.Checked = False
                    CheckBox_Ib.Checked = False
                    CheckBox_Ina.Checked = False
                    CheckBox_Inb.Checked = False
                    GroupBox_stiffeners_data.Visible = False
                ElseIf geo_type = 2 Then
                    Groupbox_geometric_input.Visible = False
                    groupBox_DB_input.Visible = False
                End If
            Else
                general_settings.messages.read_msg(6)
                general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
            End If
            '********* T stiffeners *****************
        ElseIf (Combobox_geo_select.Text = language_settings.name_T_stiffener) Then
            If general_functions.check_data(MaskedTextBox_geo_b.Text) = True And general_functions.check_data(MaskedTextBox_geo_d.Text) = True And general_functions.check_data(MaskedTextBox_geo_t.Text) = True And general_functions.check_data(MaskedTextBox_geo_w.Text) = True Then
                current_moment = CSng(models_calculations.general_functions.moment_of_inertia(MaskedTextBox_geo_b.Text, MaskedTextBox_geo_d.Text, MaskedTextBox_geo_t.Text, MaskedTextBox_geo_w.Text, "T"))
                current_area = CSng(models_calculations.general_functions.Area(MaskedTextBox_geo_b.Text, MaskedTextBox_geo_d.Text, MaskedTextBox_geo_t.Text, MaskedTextBox_geo_w.Text, "T"))
                current_center = CSng(models_calculations.general_functions.centroid(MaskedTextBox_geo_b.Text, MaskedTextBox_geo_d.Text, MaskedTextBox_geo_t.Text, MaskedTextBox_geo_w.Text, "T"))
                set_data()
                GroupBox_stiffeners_data.Visible = False
                CheckBox_Ia.Checked = False
                CheckBox_Ib.Checked = False
                CheckBox_Ina.Checked = False
                CheckBox_Inb.Checked = False
            Else
                general_settings.messages.read_msg(6)
                general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
            End If
            '********* L stiffeners *****************
        ElseIf (Combobox_geo_select.Text = language_settings.name_L_stiffener) Then
            If general_functions.check_data(MaskedTextBox_geo_b.Text) = True And general_functions.check_data(MaskedTextBox_geo_d.Text) = True And general_functions.check_data(MaskedTextBox_geo_t.Text) = True Then
                current_moment = CSng(models_calculations.general_functions.moment_of_inertia(MaskedTextBox_geo_b.Text, MaskedTextBox_geo_d.Text, MaskedTextBox_geo_t.Text, 0, "L"))
                current_area = CSng(models_calculations.general_functions.Area(MaskedTextBox_geo_b.Text, MaskedTextBox_geo_d.Text, MaskedTextBox_geo_t.Text, 0, "L"))
                current_center = CSng(models_calculations.general_functions.centroid(MaskedTextBox_geo_b.Text, MaskedTextBox_geo_d.Text, MaskedTextBox_geo_t.Text, 0, "L"))
                set_data()
                GroupBox_stiffeners_data.Visible = False
                CheckBox_Ia.Checked = False
                CheckBox_Ib.Checked = False
                CheckBox_Ina.Checked = False
                CheckBox_Inb.Checked = False
            Else
                general_settings.messages.read_msg(6)
                general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
            End If
            '********* L stiffeners *****************
        ElseIf (Combobox_geo_select.Text = language_settings.name_I_stiffener) Then
            If general_functions.check_data(MaskedTextBox_geo_b.Text) = True And general_functions.check_data(MaskedTextBox_geo_d.Text) = True And general_functions.check_data(MaskedTextBox_geo_t.Text) = True And general_functions.check_data(MaskedTextBox_geo_w.Text) = True Then
                current_moment = CSng(models_calculations.general_functions.moment_of_inertia(MaskedTextBox_geo_b.Text, MaskedTextBox_geo_d.Text, MaskedTextBox_geo_t.Text, MaskedTextBox_geo_w.Text, "I"))
                current_area = CSng(models_calculations.general_functions.Area(MaskedTextBox_geo_b.Text, MaskedTextBox_geo_d.Text, MaskedTextBox_geo_t.Text, MaskedTextBox_geo_w.Text, "I"))
                current_center = CSng(models_calculations.general_functions.centroid(MaskedTextBox_geo_b.Text, MaskedTextBox_geo_d.Text, MaskedTextBox_geo_t.Text, MaskedTextBox_geo_w.Text, "I"))
                set_data()
                GroupBox_stiffeners_data.Visible = False
                CheckBox_Ia.Checked = False
                CheckBox_Ib.Checked = False
                CheckBox_Ina.Checked = False
                CheckBox_Inb.Checked = False
            Else
                general_settings.messages.read_msg(6)
                general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
            End If
        End If
    End Sub
    Private Sub Combobox_geo_type_select_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combobox_geo_select.SelectedIndexChanged
        If (Combobox_geo_select.Text = language_settings.name_blade_stiffener) Then
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
            Label_geo_b.Text = language_settings.input_panel3_blade_thickness_b
            Label_geo_d.Text = language_settings.input_panel3_blade_length_d
        ElseIf (Combobox_geo_select.Text = language_settings.name_L_stiffener) Then
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
            Label_geo_b.Text = language_settings.input_panel3_L_length_b
            Label_geo_d.Text = language_settings.input_panel3_L_height_d
            Label_geo_t.Text = language_settings.input_panel3_L_thickness_t
        ElseIf (Combobox_geo_select.Text = language_settings.name_T_stiffener) Then
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
            Label_geo_b.Text = language_settings.input_panel3_T_length_b
            Label_geo_d.Text = language_settings.input_panel3_T_height_d
            Label_geo_t.Text = language_settings.input_panel3_T_thickness_t
            Label_geo_w.Text = language_settings.input_panel3_T_thickness_w
        ElseIf (Combobox_geo_select.Text = language_settings.name_I_stiffener) Then
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
            Label_geo_b.Text = language_settings.input_panel3_I_length_b
            Label_geo_d.Text = language_settings.input_panel3_I_height_d
            Label_geo_t.Text = language_settings.input_panel3_I_thickness_t
            Label_geo_w.Text = language_settings.input_panel3_I_thickness_w
        End If
    End Sub
    Private Sub Button_DB_selected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_DB_selected.Click
        If (general_functions.check_data(TextBox_db_moment.Text) = True) AndAlso (general_functions.check_data(TextBox_db_area.Text) = True) AndAlso (general_functions.check_data(TextBox_db_center.Text) = True) Then
            current_moment = CSng(TextBox_db_moment.Text) / 100 ^ 4
            current_area = CSng(TextBox_db_area.Text) / 100 ^ 2
            current_center = CSng(TextBox_db_center.Text) / 100
            set_data()
            If geo_type = 4 Then
                CheckBox_Ia.Checked = False
                CheckBox_Ib.Checked = False
                CheckBox_Ina.Checked = False
                CheckBox_Inb.Checked = False
                GroupBox_stiffeners_data.Visible = False
            ElseIf geo_type = 3 Then
                CheckBox_Ia.Checked = False
                CheckBox_Ib.Checked = False
                CheckBox_Ina.Checked = False
                CheckBox_Inb.Checked = False
                GroupBox_stiffeners_data.Visible = False
            ElseIf geo_type = 2 Then
                Groupbox_geometric_input.Visible = False
                groupBox_DB_input.Visible = False
            End If
        Else
            general_settings.messages.read_msg(6)
            general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
        End If
    End Sub
    Private Sub Button_num_selected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_num_selected.Click
        continue_process = True
        If (TextBox_num_moment.Text.Length > 30) Or (TextBox_num_area.Text.Length > 30) Or (TextBox_num_center.Text.Length > 30) Then
            general_settings.messages.read_msg(5)
            general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
            continue_process = False
        Else
            If (general_functions.check_data(TextBox_num_moment.Text) = True) AndAlso (general_functions.check_data(TextBox_num_area.Text) = True) AndAlso (general_functions.check_data(TextBox_num_center.Text) = True) Then
                '************ Checking units for moment *******************
                If (ComboBox_num_moment_units.Text = language_settings.unit_centimeter4) Then
                    current_moment = CSng(TextBox_num_moment.Text) / 100 ^ 4
                ElseIf (ComboBox_num_moment_units.Text = language_settings.unit_millimeter4) Then
                    current_moment = CSng(TextBox_num_moment.Text) / 1000 ^ 4
                ElseIf (ComboBox_num_moment_units.Text = language_settings.unit_meter4) Then
                    current_moment = CSng(TextBox_num_moment.Text)
                Else
                    general_settings.messages.read_msg(7)
                    general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                    continue_process = False
                End If
                '************ Checking units for area *******************
                If (ComboBox_num_area_units.Text = language_settings.unit_centimeter2) Then
                    current_area = CSng(TextBox_num_area.Text) / 100 ^ 2
                ElseIf (ComboBox_num_area_units.Text = language_settings.unit_millimeter2) Then
                    current_area = CSng(TextBox_num_area.Text) / 1000 ^ 2
                ElseIf (ComboBox_num_area_units.Text = language_settings.unit_meter2) Then
                    current_area = CSng(TextBox_num_area.Text)
                Else
                    general_settings.messages.read_msg(8) ' incorrect numeric values
                    general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                    continue_process = False
                End If
                '************ Checking units for center *******************
                If (ComboBox_num_center_units.Text = language_settings.unit_centimeter) Then
                    current_center = CSng(TextBox_num_center.Text) / 100
                ElseIf (ComboBox_num_center_units.Text = language_settings.unit_millimeter) Then
                    current_center = CSng(TextBox_num_center.Text) / 1000
                ElseIf (ComboBox_num_center_units.Text = language_settings.unit_meter) Then
                    current_center = CSng(TextBox_num_center.Text)
                Else
                    general_settings.messages.read_msg(9)
                    general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                    continue_process = False
                End If

                If continue_process = True Then
                    set_data()
                    If geo_type = 4 Then
                        CheckBox_Ia.Checked = False
                        CheckBox_Ib.Checked = False
                        CheckBox_Ina.Checked = False
                        CheckBox_Inb.Checked = False
                        GroupBox_stiffeners_data.Visible = False
                    ElseIf geo_type = 3 Then
                        CheckBox_Ia.Checked = False
                        CheckBox_Ib.Checked = False
                        CheckBox_Ina.Checked = False
                        CheckBox_Inb.Checked = False
                        GroupBox_stiffeners_data.Visible = False
                    ElseIf geo_type = 2 Then
                        Groupbox_geometric_input.Visible = False
                        groupBox_DB_input.Visible = False
                    End If
                End If
            Else
                general_settings.messages.read_msg(6)
                general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                If Not ((ComboBox_num_moment_units.Text = language_settings.unit_centimeter4) Or (ComboBox_num_moment_units.Text = language_settings.unit_millimeter4) Or (ComboBox_num_moment_units.Text = language_settings.unit_meter4)) Then
                    general_settings.messages.read_msg(7)
                    general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                End If
                If Not ((ComboBox_num_area_units.Text = language_settings.unit_centimeter2) Or (ComboBox_num_area_units.Text = language_settings.unit_millimeter2) Or (ComboBox_num_area_units.Text = language_settings.unit_meter2)) Then
                    general_settings.messages.read_msg(8)
                    general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                End If
                If Not ((ComboBox_num_center_units.Text = language_settings.unit_centimeter) Or (ComboBox_num_center_units.Text = language_settings.unit_millimeter) Or (ComboBox_num_center_units.Text = language_settings.unit_meter)) Then
                    general_settings.messages.read_msg(9)
                    general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                End If
            End If
        End If
    End Sub
    Private Sub PictureBox_Ia_info_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox_Ia_info.Click
        general_settings.messages.read_msg(10)
        general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
    End Sub
    Private Sub PictureBox_Ina_info_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox_Ina_info.Click
        general_settings.messages.read_msg(12)
        general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
    End Sub
    Private Sub PictureBox_Ib_info_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox_Ib_info.Click
        general_settings.messages.read_msg(11)
        general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
    End Sub
    Private Sub PictureBox_Inb_info_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox_Inb_info.Click
        general_settings.messages.read_msg(13)
        general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
    End Sub
    Private Sub button_panel03_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_panel03_next.Click
        stiffeners_long = numeric_long.Text
        stiffeners_short = numeric_short.Text
        TabControl1.SelectedIndex = 3
        GUI_Update_steps()
    End Sub
    Private Sub Button_panel04_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_panel04_back.Click
        If geo_type = 1 Then
            TabControl1.SelectedIndex = 1
        Else
            gui_update_stiffeners()
            TabControl1.SelectedIndex = 2
        End If
        GUI_Update_steps()
    End Sub
    Private Sub Button_type01_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_type01.MouseHover
        Button_type01.BackColor = Color.Gold
        Button_type03.BackColor = Color.LightGray
        Button_type02.BackColor = Color.LightGray
        Button_type04.BackColor = Color.LightGray
    End Sub
    Private Sub Button_type01_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button_type01.MouseMove
        Button_type01.BackColor = Color.Gold
        Button_type03.BackColor = Color.LightGray
        Button_type02.BackColor = Color.LightGray
        Button_type04.BackColor = Color.LightGray
    End Sub
    Private Sub Button_type02_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button_type02.MouseMove
        Button_type02.BackColor = Color.Gold
        Button_type03.BackColor = Color.LightGray
        Button_type04.BackColor = Color.LightGray
        Button_type01.BackColor = Color.LightGray
    End Sub
    Private Sub Button_type02_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_type02.MouseHover
        Button_type02.BackColor = Color.Gold
        Button_type03.BackColor = Color.LightGray
        Button_type04.BackColor = Color.LightGray
        Button_type01.BackColor = Color.LightGray
    End Sub
    Private Sub Button_type03_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button_type03.MouseMove
        Button_type03.BackColor = Color.Gold
        Button_type04.BackColor = Color.LightGray
        Button_type02.BackColor = Color.LightGray
        Button_type01.BackColor = Color.LightGray
    End Sub
    Private Sub Button_type03_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_type03.MouseHover
        Button_type03.BackColor = Color.Gold
        Button_type04.BackColor = Color.LightGray
        Button_type02.BackColor = Color.LightGray
        Button_type01.BackColor = Color.LightGray
    End Sub
    Private Sub Button_type04_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_type04.MouseHover
        Button_type04.BackColor = Color.Gold
        Button_type03.BackColor = Color.LightGray
        Button_type02.BackColor = Color.LightGray
        Button_type01.BackColor = Color.LightGray
    End Sub
    Private Sub Button_type04_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button_type04.MouseMove
        Button_type04.BackColor = Color.Gold
        Button_type03.BackColor = Color.LightGray
        Button_type02.BackColor = Color.LightGray
        Button_type01.BackColor = Color.LightGray
    End Sub
    Private Sub panel02_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panel02.MouseMove
        Button_type04.BackColor = Color.LightGray
        Button_type03.BackColor = Color.LightGray
        Button_type02.BackColor = Color.LightGray
        Button_type01.BackColor = Color.LightGray
    End Sub
    Private Sub panel02_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles panel02.MouseHover
        Button_type04.BackColor = Color.LightGray
        Button_type03.BackColor = Color.LightGray
        Button_type02.BackColor = Color.LightGray
        Button_type01.BackColor = Color.LightGray
    End Sub
    Private Sub Picture_eng_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Picture_eng.Click
        If File.Exists("default_eng.ini") = True Then
            GUI_set("default_eng.ini")
            gui_update_stiffeners()
            general_settings.controls_Library.luncher_form.Activate()
            Me.Focus()
        Else
            'message to follow
        End If
        general_settings.save_settings_to_registry()
    End Sub
    Private Sub Picture_heb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Picture_heb.Click
        GUI_set("default_heb.ini")
        gui_update_stiffeners()
            general_settings.controls_Library.luncher_form.Activate()
            Me.Focus()

        general_settings.save_settings_to_registry()
    End Sub
    Private Sub Button_case02_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_case02.Click
        numeric_BC_input.Text = 2
        numeric_BC_input.Value = 2
    End Sub
    Private Sub Button_case01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_case01.Click
        numeric_BC_input.Text = 1
        numeric_BC_input.Value = 1

    End Sub
    Private Sub Button_case03_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_case03.Click
        numeric_BC_input.Text = 3
        numeric_BC_input.Value = 3

    End Sub
    Private Sub Button_case04_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_case04.Click
        numeric_BC_input.Text = 4
        numeric_BC_input.Value = 4
    End Sub
    Private Sub numeric_BC_input_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numeric_BC_input.ValueChanged
        update_label_BC_step()
    End Sub
    Private Sub numeric_number_nb_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numeric_short.ValueChanged, numeric_long.ValueChanged
        If general_settings.general_variables.current_model = "orthotropic plate model" Then
            Select Case geo_type
                Case 2, 3
                    If ((numeric_short.Value Mod 2) = 0) Then
                        GroupBox_stiffeners_mark.Enabled = False
                        GroupBox_stiffeners_data.Enabled = False
                        button_panel03_next.Enabled = False
                    Else
                        GroupBox_stiffeners_mark.Enabled = True
                        GroupBox_stiffeners_data.Enabled = True
                        button_panel03_next.Enabled = True
                    End If
                Case 4
                    If ((numeric_short.Value Mod 2) = 0) Or ((numeric_long.Value Mod 2) = 0) Then
                        'remove this ***
                        'GroupBox_stiffeners_mark.Enabled = False
                        'GroupBox_stiffeners_data.Enabled = False
                        'button_panel03_next.Enabled = False
                    Else
                        GroupBox_stiffeners_mark.Enabled = True
                        GroupBox_stiffeners_data.Enabled = True
                        button_panel03_next.Enabled = True
                    End If
            End Select
        ElseIf general_settings.general_variables.current_model = "grillage model" Then
            If ((numeric_short.Value Mod 2) = 0) Or ((numeric_long.Value Mod 2) = 0) Or (numeric_short.Value < numeric_long.Value) Then
                'remove this ***
                ' GroupBox_stiffeners_mark.Enabled = False
                'GroupBox_stiffeners_data.Enabled = False
                'button_panel03_next.Enabled = False
                ' popup_initiator("ERROR", "TEMP")
            Else
                GroupBox_stiffeners_mark.Enabled = True
                GroupBox_stiffeners_data.Enabled = True
                button_panel03_next.Enabled = True
            End If
        End If
    End Sub
    Private Sub update_moment_of_inertia_box(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox_geo_b.TextChanged, MaskedTextBox_geo_d.TextChanged, MaskedTextBox_geo_t.TextChanged, MaskedTextBox_geo_w.TextChanged
        If (Combobox_geo_select.Text = language_settings.name_blade_stiffener) Then
            If (MaskedTextBox_geo_b.Text.Length > 30) Or (MaskedTextBox_geo_d.Text.Length > 30) Then
                general_settings.messages.read_msg(5)
                general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
            Else
                If general_functions.check_data(MaskedTextBox_geo_b.Text) = True And general_functions.check_data(MaskedTextBox_geo_d.Text) = True Then
                    If Math.Round(models_calculations.general_functions.moment_of_inertia(MaskedTextBox_geo_b.Text, MaskedTextBox_geo_d.Text, 0, 0, "|") * 100 ^ 4, 3) = 0 Then
                        TextBox_Geo_result.Text = Math.Round(models_calculations.general_functions.moment_of_inertia(MaskedTextBox_geo_b.Text, MaskedTextBox_geo_d.Text, 0, 0, "|") * 100 ^ 4, 8)
                    Else
                        TextBox_Geo_result.Text = Math.Round(models_calculations.general_functions.moment_of_inertia(MaskedTextBox_geo_b.Text, MaskedTextBox_geo_d.Text, 0, 0, "|") * 100 ^ 4, 3)
                    End If
                Else
                    TextBox_Geo_result.Text = "N/A"
                End If
            End If
        ElseIf (Combobox_geo_select.Text = language_settings.name_T_stiffener) Then
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
        ElseIf (Combobox_geo_select.Text = language_settings.name_L_stiffener) Then
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
        ElseIf (Combobox_geo_select.Text = language_settings.name_I_stiffener) Then
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
    Private Sub Button_finish_process(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_panel04_next.Click
        continue_process = True
        '**********************************************************'
        If general_functions.check_data(TextBox_P_input.Text) = True Then
            If ComboBox_P_units.Text = language_settings.unit_Pa Then
                P = TextBox_P_input.Text
            ElseIf ComboBox_P_units.Text = language_settings.unit_KPa Then
                P = TextBox_P_input.Text * 10 ^ 3
            ElseIf ComboBox_P_units.Text = language_settings.unit_MPa Then
                P = TextBox_P_input.Text * 10 ^ 6
            Else
                general_settings.messages.read_msg(14)
                general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
                continue_process = False
            End If
        Else
            general_settings.messages.read_msg(15)
            general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
            continue_process = False
        End If
        '**********************************************************'
        If general_functions.check_data(TextBox_E_input.Text) = True Then
            Young_Modulus = TextBox_E_input.Text
        Else
            general_settings.messages.read_msg(16)
            general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
            continue_process = False
        End If
        '**********************************************************'
        If general_functions.check_data(TextBox_ni_input.Text) = True Then
            ni = TextBox_ni_input.Text
        Else
            general_settings.messages.read_msg(17)
            general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
            continue_process = False
        End If
        If numeric_BC_input.Text = 1 Or numeric_BC_input.Text = 2 Or numeric_BC_input.Text = 3 Or numeric_BC_input.Text = 4 Then
            BC_type = numeric_BC_input.Text
        Else
            general_settings.messages.read_msg(18)
            general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
            continue_process = False
        End If
        '*****************GOING INTO FINAL STATUS WINDOWS***************
        If continue_process = True Then
            If general_settings.general_variables.current_model = "orthotropic plate model" Then
                'models_calculations.General_variables.last_used_model = current_model
                models_calculations.Orthotropic_model.model_variables.a = a
                models_calculations.Orthotropic_model.model_variables.b = b
                models_calculations.Orthotropic_model.model_variables.t = t
                models_calculations.Orthotropic_model.model_variables.P = P
                models_calculations.Orthotropic_model.model_variables.E = Young_Modulus
                models_calculations.Orthotropic_model.model_variables.ni = ni
                models_calculations.Orthotropic_model.model_variables.C = BC_type
                models_calculations.Orthotropic_model.model_variables.Na = stiffeners_long
                models_calculations.Orthotropic_model.model_variables.Nb = stiffeners_short
                models_calculations.Orthotropic_model.model_variables.geo_type = geo_type
                models_calculations.Orthotropic_model.model_variables.Ia_stiffener = Ia_stiffener
                models_calculations.Orthotropic_model.model_variables.Ib_stiffener = Ib_stiffener
                models_calculations.Orthotropic_model.model_variables.Ina_stiffeners = Ina_stiffeners
                models_calculations.Orthotropic_model.model_variables.Inb_stiffeners = Inb_stiffeners
                models_calculations.Orthotropic_model.model_variables.Ya_stiffener = ya_stiffener
                models_calculations.Orthotropic_model.model_variables.Yb_stiffener = yb_stiffener
                models_calculations.Orthotropic_model.model_variables.Yna_stiffeners = yna_stiffeners
                models_calculations.Orthotropic_model.model_variables.Ynb_stiffeners = ynb_stiffeners
                models_calculations.Orthotropic_model.model_variables.Aa_stiffener = Aa_stiffener
                models_calculations.Orthotropic_model.model_variables.Ab_stiffener = Ab_stiffener
                models_calculations.Orthotropic_model.model_variables.Ana_stiffeners = Ana_stiffeners
                models_calculations.Orthotropic_model.model_variables.Anb_stiffeners = Anb_stiffeners
            ElseIf general_settings.general_variables.current_model = "grillage model" Then
                'models_calculations.General_variables.last_used_model = current_model
                models_calculations.Grillage_model.model_variables.a = a
                models_calculations.Grillage_model.model_variables.b = b
                models_calculations.Grillage_model.model_variables.t = t
                models_calculations.Grillage_model.model_variables.r = stiffeners_short
                models_calculations.Grillage_model.model_variables.s = stiffeners_long
                models_calculations.Grillage_model.model_variables.Ir_stiffeners = Ina_stiffeners
                models_calculations.Grillage_model.model_variables.Is_stiffeners = Inb_stiffeners
                models_calculations.Grillage_model.model_variables.Yr_stiffeners = yna_stiffeners
                models_calculations.Grillage_model.model_variables.Ys_stiffeners = ynb_stiffeners
                models_calculations.Grillage_model.model_variables.Ar_stiffeners = Ana_stiffeners
                models_calculations.Grillage_model.model_variables.As_stiffeners = Anb_stiffeners
                models_calculations.Grillage_model.model_variables.BC = BC_type
                models_calculations.Grillage_model.model_variables.P = P
                models_calculations.Grillage_model.model_variables.E = Young_Modulus
                models_calculations.Grillage_model.model_variables.ni = ni
            Else
                ' TO BE COMPLETE LATER
                general_settings.general_variables.current_model = "Error: no model has been used"
            End If
            Dim data_status As New GUI_Data_and_Results
            data_status.load_data()
            data_status.Show()
            Me.Close()
        End If
    End Sub
    Private Sub Button_back_panel01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GUI_Update_steps()
    End Sub

    Private Sub Button_view_parameters_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_view_parameters.Click
        ' TO BE COMPLETE LATER
        Dim model_parameters As New GUI_model_parameters
        model_parameters.RightToLeftLayout = language_settings.language_RTL_layout
        model_parameters.RightToLeft = language_settings.language_RTL
        model_parameters.Tag = general_settings.general_variables.current_model
        model_parameters.ShowDialog()
    End Sub

    Private Sub MaskedTextBox_geo_b_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MaskedTextBox_geo_b.MaskInputRejected

    End Sub

End Class
