Imports System.IO
Imports System.Threading
Imports SPE
Namespace Adina_Generator
    Public Class GUI_ADINA_main
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
        Friend WithEvents label_Nb As System.Windows.Forms.Label
        Friend WithEvents label_Na As System.Windows.Forms.Label
        Friend WithEvents numeric_input_moment_units As System.Windows.Forms.ComboBox
        Friend WithEvents RichTextBox_macro As System.Windows.Forms.RichTextBox
        Friend WithEvents Button_gen As System.Windows.Forms.Button
        Friend WithEvents Button_save_macro As System.Windows.Forms.Button
        Friend WithEvents ProgressBar_sub As System.Windows.Forms.ProgressBar
        Friend WithEvents ProgressBar_total As System.Windows.Forms.ProgressBar
        Friend WithEvents Label_total_progress As System.Windows.Forms.Label
        Friend WithEvents Label_current_progress As System.Windows.Forms.Label
        Friend WithEvents CheckBox_macro As System.Windows.Forms.CheckBox
        Friend WithEvents Panel_create_model As System.Windows.Forms.Panel
        Friend WithEvents Panel_model_geometry As System.Windows.Forms.Panel 'System.Windows.Forms.Panel
        Friend WithEvents Panel_mesh_properties As System.Windows.Forms.Panel 'System.Windows.Forms.Panel
        Friend WithEvents Label21 As System.Windows.Forms.Label
        Friend WithEvents Label23 As System.Windows.Forms.Label
        Friend WithEvents Label24 As System.Windows.Forms.Label
        Friend WithEvents Label25 As System.Windows.Forms.Label
        Friend WithEvents Label30 As System.Windows.Forms.Label
        Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
        Friend WithEvents Label31 As System.Windows.Forms.Label
        Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
        Friend WithEvents Label32 As System.Windows.Forms.Label
        Friend WithEvents Label33 As System.Windows.Forms.Label
        Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
        Friend WithEvents Label26 As System.Windows.Forms.Label
        Friend WithEvents Label27 As System.Windows.Forms.Label
        Friend WithEvents CheckBox_CBIAS1 As System.Windows.Forms.CheckBox
        Friend WithEvents CheckBox_CBIAS2 As System.Windows.Forms.CheckBox
        Friend WithEvents Button_set_data As System.Windows.Forms.Button
        Friend WithEvents GroupBox_CBIAS As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox_density As System.Windows.Forms.GroupBox
        Friend WithEvents ComboBox_progress As System.Windows.Forms.ComboBox
        Friend WithEvents GroupBox_div As System.Windows.Forms.GroupBox
        Friend WithEvents TextBox_div_v As System.Windows.Forms.TextBox
        Friend WithEvents TextBox_div_u As System.Windows.Forms.TextBox
        Friend WithEvents GroupBox_ratio As System.Windows.Forms.GroupBox
        Friend WithEvents TextBox_ratio_v As System.Windows.Forms.TextBox
        Friend WithEvents TextBox_ratio_u As System.Windows.Forms.TextBox
        Friend WithEvents ComboBox_method As System.Windows.Forms.ComboBox
        Friend WithEvents TextBox_edge_length As System.Windows.Forms.TextBox
        Friend WithEvents ComboBox_type As System.Windows.Forms.ComboBox
        Friend WithEvents GroupBox_mesh_algo As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox_mesh_type As System.Windows.Forms.GroupBox
        Friend WithEvents RadioButton_mesh_type02 As System.Windows.Forms.RadioButton
        Friend WithEvents RadioButton_mesh_type01 As System.Windows.Forms.RadioButton
        Friend WithEvents Label_shape As System.Windows.Forms.Label
        Friend WithEvents ListView_steps As System.Windows.Forms.ListView
        Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
        Friend WithEvents ComboBox_nodes As System.Windows.Forms.ComboBox
        Friend WithEvents RadioButton_free02 As System.Windows.Forms.RadioButton
        Friend WithEvents RadioButton_free01 As System.Windows.Forms.RadioButton
        Friend WithEvents RadioButton_mid02 As System.Windows.Forms.RadioButton
        Friend WithEvents RadioButton_mid01 As System.Windows.Forms.RadioButton
        Friend WithEvents ComboBox_pattern As System.Windows.Forms.ComboBox
        Friend WithEvents CheckBox_flip As System.Windows.Forms.CheckBox
        Friend WithEvents ComboBox_shape_all As System.Windows.Forms.ComboBox
        Friend WithEvents ComboBox_shape_tri As System.Windows.Forms.ComboBox
        Friend WithEvents ComboBox_shape_qua As System.Windows.Forms.ComboBox
        Friend WithEvents ComboBox_shape_quaonly As System.Windows.Forms.ComboBox
        Friend WithEvents GroupBox_generation As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox_process As System.Windows.Forms.GroupBox
        Friend WithEvents CheckBox_gen_geo As System.Windows.Forms.CheckBox
        Friend WithEvents CheckBox_gen_BC As System.Windows.Forms.CheckBox
        Friend WithEvents CheckBox_gen_load As System.Windows.Forms.CheckBox
        Friend WithEvents CheckBox_gen_mesh As System.Windows.Forms.CheckBox
        Friend WithEvents CheckBox_degenenrate As System.Windows.Forms.CheckBox
        Friend WithEvents Panel_start As System.Windows.Forms.Panel ' System.Windows.Forms.Panel
        Friend WithEvents RichTextBox_welcome As System.Windows.Forms.RichTextBox
        Friend WithEvents Label_affiliated As System.Windows.Forms.Label
        Friend WithEvents Label_disclaimer As System.Windows.Forms.Label
        Friend WithEvents GroupBox_statistics As System.Windows.Forms.GroupBox
        Friend WithEvents Label_time_start As System.Windows.Forms.Label
        Friend WithEvents Label_time_end As System.Windows.Forms.Label
        Friend WithEvents Label_time_interval As System.Windows.Forms.Label
        Friend WithEvents GroupBox_generate As System.Windows.Forms.GroupBox
        Friend WithEvents Button_time As System.Windows.Forms.Button
        Friend WithEvents GroupBox_video As System.Windows.Forms.GroupBox
        Friend WithEvents PictureBox_video01 As System.Windows.Forms.PictureBox
        Friend WithEvents RichTextBox_video As System.Windows.Forms.RichTextBox
        Friend WithEvents Label_status As System.Windows.Forms.Label
        Friend WithEvents groupbox_General As System.Windows.Forms.GroupBox
        Friend WithEvents Label_GPa As System.Windows.Forms.Label
        Friend WithEvents combobox_P_units As System.Windows.Forms.ComboBox
        Friend WithEvents Label_pressure As System.Windows.Forms.Label
        Friend WithEvents label_ni As System.Windows.Forms.Label
        Friend WithEvents Label_E As System.Windows.Forms.Label
        Friend WithEvents Label_BC As System.Windows.Forms.Label
        Friend WithEvents groupbox_plate_geo As System.Windows.Forms.GroupBox
        Friend WithEvents label_unit_mm01 As System.Windows.Forms.Label
        Friend WithEvents label_unit_m02 As System.Windows.Forms.Label
        Friend WithEvents label_unit_m01 As System.Windows.Forms.Label
        Friend WithEvents label_t As System.Windows.Forms.Label
        Friend WithEvents numeric_t As System.Windows.Forms.NumericUpDown
        Friend WithEvents label_b As System.Windows.Forms.Label
        Friend WithEvents numeric_b As System.Windows.Forms.NumericUpDown
        Friend WithEvents label_a As System.Windows.Forms.Label
        Friend WithEvents numeric_a As System.Windows.Forms.NumericUpDown
        Friend WithEvents numeric_case_input As System.Windows.Forms.NumericUpDown
        Friend WithEvents textbox_P_input As System.Windows.Forms.TextBox
        Friend WithEvents textbox_ni_input As System.Windows.Forms.TextBox
        Friend WithEvents textbox_E_input As System.Windows.Forms.TextBox
        Friend WithEvents Picture_eng_panel1 As System.Windows.Forms.PictureBox
        Friend WithEvents Picture_heb_panel1 As System.Windows.Forms.PictureBox
        Friend WithEvents Picture_eng_panel0 As System.Windows.Forms.PictureBox
        Friend WithEvents Picture_heb_panel0 As System.Windows.Forms.PictureBox
        Friend WithEvents Picture_eng_panel2 As System.Windows.Forms.PictureBox
        Friend WithEvents Picture_heb_panel2 As System.Windows.Forms.PictureBox
        Friend WithEvents Picture_eng_panel3 As System.Windows.Forms.PictureBox
        Friend WithEvents Picture_heb_panel3 As System.Windows.Forms.PictureBox
        Friend WithEvents GroupBox_stiffeners As System.Windows.Forms.GroupBox
        Friend WithEvents numeric_nb As System.Windows.Forms.NumericUpDown
        Friend WithEvents numeric_na As System.Windows.Forms.NumericUpDown
        Friend WithEvents GroupBox_stiffeners_Data As System.Windows.Forms.GroupBox
        Friend WithEvents Label_H As System.Windows.Forms.Label
        Friend WithEvents Label_thickness As System.Windows.Forms.Label
        Friend WithEvents Label_longitudinals As System.Windows.Forms.Label
        Friend WithEvents Label_central01 As System.Windows.Forms.Label
        Friend WithEvents Label_non_central01 As System.Windows.Forms.Label
        Friend WithEvents Label_non_central02 As System.Windows.Forms.Label
        Friend WithEvents Label_central02 As System.Windows.Forms.Label
        Friend WithEvents Label_transverses As System.Windows.Forms.Label
        Friend WithEvents label_unit_mm06 As System.Windows.Forms.Label
        Friend WithEvents label_unit_mm05 As System.Windows.Forms.Label
        Friend WithEvents label_unit_mm04 As System.Windows.Forms.Label
        Friend WithEvents label_unit_mm03 As System.Windows.Forms.Label
        Friend WithEvents Textbox_Tnb As System.Windows.Forms.TextBox
        Friend WithEvents Textbox_Tna As System.Windows.Forms.TextBox
        Friend WithEvents Textbox_Ta As System.Windows.Forms.TextBox
        Friend WithEvents Textbox_Tb As System.Windows.Forms.TextBox
        Friend WithEvents label_unit_mm02 As System.Windows.Forms.Label
        Friend WithEvents Textbox_H_general As System.Windows.Forms.TextBox
        Friend WithEvents Textbox_Ib As System.Windows.Forms.TextBox
        Friend WithEvents Textbox_Inb As System.Windows.Forms.TextBox
        Friend WithEvents Textbox_Ia As System.Windows.Forms.TextBox
        Friend WithEvents Textbox_Ina As System.Windows.Forms.TextBox
        Friend WithEvents Label_data_transverses As System.Windows.Forms.Label
        Friend WithEvents Label_non_central04 As System.Windows.Forms.Label
        Friend WithEvents Label_central04 As System.Windows.Forms.Label
        Friend WithEvents Label_data_longitudinals As System.Windows.Forms.Label
        Friend WithEvents Label_non_central03 As System.Windows.Forms.Label
        Friend WithEvents Label_central03 As System.Windows.Forms.Label
        Friend WithEvents Label_units As System.Windows.Forms.Label
        Friend WithEvents SplitContainer As System.Windows.Forms.SplitContainer
        Friend WithEvents PictureBox_info As System.Windows.Forms.PictureBox
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI_ADINA_main))
            Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("שלב ראשון - גיאומטרית המודל", 2)
            Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("שלב שני - הגדרות רישות", 1)
            Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("שלב שלישי- יצירת המודל", 0)
            Me.GroupBox_stiffeners = New System.Windows.Forms.GroupBox()
            Me.label_unit_mm06 = New System.Windows.Forms.Label()
            Me.label_unit_mm05 = New System.Windows.Forms.Label()
            Me.label_unit_mm04 = New System.Windows.Forms.Label()
            Me.label_unit_mm03 = New System.Windows.Forms.Label()
            Me.label_unit_mm02 = New System.Windows.Forms.Label()
            Me.numeric_nb = New System.Windows.Forms.NumericUpDown()
            Me.numeric_na = New System.Windows.Forms.NumericUpDown()
            Me.Textbox_H_general = New System.Windows.Forms.TextBox()
            Me.Textbox_Tnb = New System.Windows.Forms.TextBox()
            Me.Label_transverses = New System.Windows.Forms.Label()
            Me.Label_H = New System.Windows.Forms.Label()
            Me.Textbox_Tna = New System.Windows.Forms.TextBox()
            Me.Textbox_Ta = New System.Windows.Forms.TextBox()
            Me.Label_thickness = New System.Windows.Forms.Label()
            Me.Label_non_central02 = New System.Windows.Forms.Label()
            Me.Label_central02 = New System.Windows.Forms.Label()
            Me.Label_longitudinals = New System.Windows.Forms.Label()
            Me.Label_non_central01 = New System.Windows.Forms.Label()
            Me.Label_central01 = New System.Windows.Forms.Label()
            Me.Textbox_Tb = New System.Windows.Forms.TextBox()
            Me.label_Nb = New System.Windows.Forms.Label()
            Me.label_Na = New System.Windows.Forms.Label()
            Me.GroupBox_stiffeners_Data = New System.Windows.Forms.GroupBox()
            Me.Label_data_transverses = New System.Windows.Forms.Label()
            Me.Label_data_longitudinals = New System.Windows.Forms.Label()
            Me.numeric_input_moment_units = New System.Windows.Forms.ComboBox()
            Me.Textbox_Ib = New System.Windows.Forms.TextBox()
            Me.Textbox_Inb = New System.Windows.Forms.TextBox()
            Me.Textbox_Ia = New System.Windows.Forms.TextBox()
            Me.Textbox_Ina = New System.Windows.Forms.TextBox()
            Me.Label_non_central04 = New System.Windows.Forms.Label()
            Me.Label_central04 = New System.Windows.Forms.Label()
            Me.Label_non_central03 = New System.Windows.Forms.Label()
            Me.Label_central03 = New System.Windows.Forms.Label()
            Me.Label_units = New System.Windows.Forms.Label()
            Me.RichTextBox_macro = New System.Windows.Forms.RichTextBox()
            Me.Button_gen = New System.Windows.Forms.Button()
            Me.Button_save_macro = New System.Windows.Forms.Button()
            Me.ProgressBar_sub = New System.Windows.Forms.ProgressBar()
            Me.ProgressBar_total = New System.Windows.Forms.ProgressBar()
            Me.Label_total_progress = New System.Windows.Forms.Label()
            Me.Label_current_progress = New System.Windows.Forms.Label()
            Me.CheckBox_macro = New System.Windows.Forms.CheckBox()
            Me.Panel_model_geometry = New System.Windows.Forms.Panel()
            Me.Picture_eng_panel1 = New System.Windows.Forms.PictureBox()
            Me.Picture_heb_panel1 = New System.Windows.Forms.PictureBox()
            Me.groupbox_plate_geo = New System.Windows.Forms.GroupBox()
            Me.label_t = New System.Windows.Forms.Label()
            Me.numeric_t = New System.Windows.Forms.NumericUpDown()
            Me.label_b = New System.Windows.Forms.Label()
            Me.numeric_b = New System.Windows.Forms.NumericUpDown()
            Me.label_a = New System.Windows.Forms.Label()
            Me.numeric_a = New System.Windows.Forms.NumericUpDown()
            Me.label_unit_mm01 = New System.Windows.Forms.Label()
            Me.label_unit_m02 = New System.Windows.Forms.Label()
            Me.label_unit_m01 = New System.Windows.Forms.Label()
            Me.groupbox_General = New System.Windows.Forms.GroupBox()
            Me.PictureBox_info = New System.Windows.Forms.PictureBox()
            Me.Label_GPa = New System.Windows.Forms.Label()
            Me.combobox_P_units = New System.Windows.Forms.ComboBox()
            Me.textbox_P_input = New System.Windows.Forms.TextBox()
            Me.textbox_ni_input = New System.Windows.Forms.TextBox()
            Me.textbox_E_input = New System.Windows.Forms.TextBox()
            Me.Label_pressure = New System.Windows.Forms.Label()
            Me.label_ni = New System.Windows.Forms.Label()
            Me.Label_E = New System.Windows.Forms.Label()
            Me.numeric_case_input = New System.Windows.Forms.NumericUpDown()
            Me.Label_BC = New System.Windows.Forms.Label()
            Me.Panel_create_model = New System.Windows.Forms.Panel()
            Me.Picture_eng_panel3 = New System.Windows.Forms.PictureBox()
            Me.Picture_heb_panel3 = New System.Windows.Forms.PictureBox()
            Me.GroupBox_generate = New System.Windows.Forms.GroupBox()
            Me.GroupBox_statistics = New System.Windows.Forms.GroupBox()
            Me.Button_time = New System.Windows.Forms.Button()
            Me.Label_time_interval = New System.Windows.Forms.Label()
            Me.Label_time_end = New System.Windows.Forms.Label()
            Me.Label_time_start = New System.Windows.Forms.Label()
            Me.GroupBox_process = New System.Windows.Forms.GroupBox()
            Me.GroupBox_generation = New System.Windows.Forms.GroupBox()
            Me.CheckBox_gen_mesh = New System.Windows.Forms.CheckBox()
            Me.CheckBox_gen_load = New System.Windows.Forms.CheckBox()
            Me.CheckBox_gen_BC = New System.Windows.Forms.CheckBox()
            Me.CheckBox_gen_geo = New System.Windows.Forms.CheckBox()
            Me.GroupBox_video = New System.Windows.Forms.GroupBox()
            Me.RichTextBox_video = New System.Windows.Forms.RichTextBox()
            Me.PictureBox_video01 = New System.Windows.Forms.PictureBox()
            Me.Panel_mesh_properties = New System.Windows.Forms.Panel()
            Me.Picture_eng_panel2 = New System.Windows.Forms.PictureBox()
            Me.Picture_heb_panel2 = New System.Windows.Forms.PictureBox()
            Me.GroupBox7 = New System.Windows.Forms.GroupBox()
            Me.CheckBox_degenenrate = New System.Windows.Forms.CheckBox()
            Me.CheckBox_flip = New System.Windows.Forms.CheckBox()
            Me.Label_shape = New System.Windows.Forms.Label()
            Me.ComboBox_shape_all = New System.Windows.Forms.ComboBox()
            Me.GroupBox11 = New System.Windows.Forms.GroupBox()
            Me.RadioButton_mid02 = New System.Windows.Forms.RadioButton()
            Me.RadioButton_mid01 = New System.Windows.Forms.RadioButton()
            Me.GroupBox10 = New System.Windows.Forms.GroupBox()
            Me.ComboBox_pattern = New System.Windows.Forms.ComboBox()
            Me.Label33 = New System.Windows.Forms.Label()
            Me.ComboBox_nodes = New System.Windows.Forms.ComboBox()
            Me.Label32 = New System.Windows.Forms.Label()
            Me.GroupBox_mesh_algo = New System.Windows.Forms.GroupBox()
            Me.RadioButton_free02 = New System.Windows.Forms.RadioButton()
            Me.RadioButton_free01 = New System.Windows.Forms.RadioButton()
            Me.GroupBox_mesh_type = New System.Windows.Forms.GroupBox()
            Me.RadioButton_mesh_type02 = New System.Windows.Forms.RadioButton()
            Me.RadioButton_mesh_type01 = New System.Windows.Forms.RadioButton()
            Me.Label31 = New System.Windows.Forms.Label()
            Me.ComboBox_type = New System.Windows.Forms.ComboBox()
            Me.ComboBox_shape_quaonly = New System.Windows.Forms.ComboBox()
            Me.ComboBox_shape_qua = New System.Windows.Forms.ComboBox()
            Me.ComboBox_shape_tri = New System.Windows.Forms.ComboBox()
            Me.GroupBox_density = New System.Windows.Forms.GroupBox()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.GroupBox_CBIAS = New System.Windows.Forms.GroupBox()
            Me.CheckBox_CBIAS1 = New System.Windows.Forms.CheckBox()
            Me.CheckBox_CBIAS2 = New System.Windows.Forms.CheckBox()
            Me.GroupBox_ratio = New System.Windows.Forms.GroupBox()
            Me.TextBox_ratio_v = New System.Windows.Forms.TextBox()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.TextBox_ratio_u = New System.Windows.Forms.TextBox()
            Me.Label27 = New System.Windows.Forms.Label()
            Me.GroupBox_div = New System.Windows.Forms.GroupBox()
            Me.TextBox_div_v = New System.Windows.Forms.TextBox()
            Me.Label25 = New System.Windows.Forms.Label()
            Me.TextBox_div_u = New System.Windows.Forms.TextBox()
            Me.Label24 = New System.Windows.Forms.Label()
            Me.Label23 = New System.Windows.Forms.Label()
            Me.ComboBox_progress = New System.Windows.Forms.ComboBox()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.TextBox_edge_length = New System.Windows.Forms.TextBox()
            Me.ComboBox_method = New System.Windows.Forms.ComboBox()
            Me.Button_set_data = New System.Windows.Forms.Button()
            Me.ListView_steps = New System.Windows.Forms.ListView()
            Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.Panel_start = New System.Windows.Forms.Panel()
            Me.Picture_eng_panel0 = New System.Windows.Forms.PictureBox()
            Me.Picture_heb_panel0 = New System.Windows.Forms.PictureBox()
            Me.Label_status = New System.Windows.Forms.Label()
            Me.Label_disclaimer = New System.Windows.Forms.Label()
            Me.Label_affiliated = New System.Windows.Forms.Label()
            Me.RichTextBox_welcome = New System.Windows.Forms.RichTextBox()
            Me.SplitContainer = New System.Windows.Forms.SplitContainer()
            Me.GroupBox_stiffeners.SuspendLayout()
            CType(Me.numeric_nb, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numeric_na, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox_stiffeners_Data.SuspendLayout()
            Me.Panel_model_geometry.SuspendLayout()
            CType(Me.Picture_eng_panel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Picture_heb_panel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupbox_plate_geo.SuspendLayout()
            CType(Me.numeric_t, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numeric_b, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numeric_a, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupbox_General.SuspendLayout()
            CType(Me.PictureBox_info, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numeric_case_input, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel_create_model.SuspendLayout()
            CType(Me.Picture_eng_panel3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Picture_heb_panel3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox_generate.SuspendLayout()
            Me.GroupBox_statistics.SuspendLayout()
            Me.GroupBox_process.SuspendLayout()
            Me.GroupBox_generation.SuspendLayout()
            Me.GroupBox_video.SuspendLayout()
            CType(Me.PictureBox_video01, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel_mesh_properties.SuspendLayout()
            CType(Me.Picture_eng_panel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Picture_heb_panel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox7.SuspendLayout()
            Me.GroupBox11.SuspendLayout()
            Me.GroupBox10.SuspendLayout()
            Me.GroupBox_mesh_algo.SuspendLayout()
            Me.GroupBox_mesh_type.SuspendLayout()
            Me.GroupBox_density.SuspendLayout()
            Me.GroupBox_CBIAS.SuspendLayout()
            Me.GroupBox_ratio.SuspendLayout()
            Me.GroupBox_div.SuspendLayout()
            Me.Panel_start.SuspendLayout()
            CType(Me.Picture_eng_panel0, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Picture_heb_panel0, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitContainer.Panel1.SuspendLayout()
            Me.SplitContainer.Panel2.SuspendLayout()
            Me.SplitContainer.SuspendLayout()
            Me.SuspendLayout()
            '
            'GroupBox_stiffeners
            '
            Me.GroupBox_stiffeners.Controls.Add(Me.label_unit_mm06)
            Me.GroupBox_stiffeners.Controls.Add(Me.label_unit_mm05)
            Me.GroupBox_stiffeners.Controls.Add(Me.label_unit_mm04)
            Me.GroupBox_stiffeners.Controls.Add(Me.label_unit_mm03)
            Me.GroupBox_stiffeners.Controls.Add(Me.label_unit_mm02)
            Me.GroupBox_stiffeners.Controls.Add(Me.numeric_nb)
            Me.GroupBox_stiffeners.Controls.Add(Me.numeric_na)
            Me.GroupBox_stiffeners.Controls.Add(Me.Textbox_H_general)
            Me.GroupBox_stiffeners.Controls.Add(Me.Textbox_Tnb)
            Me.GroupBox_stiffeners.Controls.Add(Me.Label_transverses)
            Me.GroupBox_stiffeners.Controls.Add(Me.Label_H)
            Me.GroupBox_stiffeners.Controls.Add(Me.Textbox_Tna)
            Me.GroupBox_stiffeners.Controls.Add(Me.Textbox_Ta)
            Me.GroupBox_stiffeners.Controls.Add(Me.Label_thickness)
            Me.GroupBox_stiffeners.Controls.Add(Me.Label_non_central02)
            Me.GroupBox_stiffeners.Controls.Add(Me.Label_central02)
            Me.GroupBox_stiffeners.Controls.Add(Me.Label_longitudinals)
            Me.GroupBox_stiffeners.Controls.Add(Me.Label_non_central01)
            Me.GroupBox_stiffeners.Controls.Add(Me.Label_central01)
            Me.GroupBox_stiffeners.Controls.Add(Me.Textbox_Tb)
            Me.GroupBox_stiffeners.Controls.Add(Me.label_Nb)
            Me.GroupBox_stiffeners.Controls.Add(Me.label_Na)
            Me.GroupBox_stiffeners.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
            Me.GroupBox_stiffeners.Location = New System.Drawing.Point(8, 216)
            Me.GroupBox_stiffeners.Name = "GroupBox_stiffeners"
            Me.GroupBox_stiffeners.Size = New System.Drawing.Size(328, 404)
            Me.GroupBox_stiffeners.TabIndex = 43
            Me.GroupBox_stiffeners.TabStop = False
            Me.GroupBox_stiffeners.Text = "Stiffeners' Parameters"
            '
            'label_unit_mm06
            '
            Me.label_unit_mm06.AutoEllipsis = True
            Me.label_unit_mm06.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
            Me.label_unit_mm06.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.label_unit_mm06.Location = New System.Drawing.Point(10, 344)
            Me.label_unit_mm06.Name = "label_unit_mm06"
            Me.label_unit_mm06.Size = New System.Drawing.Size(85, 25)
            Me.label_unit_mm06.TabIndex = 68
            Me.label_unit_mm06.Text = "[mm]"
            Me.label_unit_mm06.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'label_unit_mm05
            '
            Me.label_unit_mm05.AutoEllipsis = True
            Me.label_unit_mm05.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
            Me.label_unit_mm05.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.label_unit_mm05.Location = New System.Drawing.Point(10, 312)
            Me.label_unit_mm05.Name = "label_unit_mm05"
            Me.label_unit_mm05.Size = New System.Drawing.Size(85, 25)
            Me.label_unit_mm05.TabIndex = 67
            Me.label_unit_mm05.Text = "[mm]"
            Me.label_unit_mm05.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'label_unit_mm04
            '
            Me.label_unit_mm04.AutoEllipsis = True
            Me.label_unit_mm04.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
            Me.label_unit_mm04.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.label_unit_mm04.Location = New System.Drawing.Point(10, 248)
            Me.label_unit_mm04.Name = "label_unit_mm04"
            Me.label_unit_mm04.Size = New System.Drawing.Size(85, 25)
            Me.label_unit_mm04.TabIndex = 66
            Me.label_unit_mm04.Text = "[mm]"
            Me.label_unit_mm04.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'label_unit_mm03
            '
            Me.label_unit_mm03.AutoEllipsis = True
            Me.label_unit_mm03.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
            Me.label_unit_mm03.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.label_unit_mm03.Location = New System.Drawing.Point(10, 212)
            Me.label_unit_mm03.Name = "label_unit_mm03"
            Me.label_unit_mm03.Size = New System.Drawing.Size(85, 25)
            Me.label_unit_mm03.TabIndex = 65
            Me.label_unit_mm03.Text = "[mm]"
            Me.label_unit_mm03.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'label_unit_mm02
            '
            Me.label_unit_mm02.AutoEllipsis = True
            Me.label_unit_mm02.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
            Me.label_unit_mm02.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.label_unit_mm02.Location = New System.Drawing.Point(9, 104)
            Me.label_unit_mm02.Name = "label_unit_mm02"
            Me.label_unit_mm02.Size = New System.Drawing.Size(72, 25)
            Me.label_unit_mm02.TabIndex = 64
            Me.label_unit_mm02.Text = "[mm]"
            Me.label_unit_mm02.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'numeric_nb
            '
            Me.numeric_nb.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
            Me.numeric_nb.Location = New System.Drawing.Point(8, 68)
            Me.numeric_nb.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.numeric_nb.Name = "numeric_nb"
            Me.numeric_nb.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.numeric_nb.Size = New System.Drawing.Size(64, 25)
            Me.numeric_nb.TabIndex = 9
            Me.numeric_nb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.numeric_nb.Value = New Decimal(New Integer() {5, 0, 0, 0})
            '
            'numeric_na
            '
            Me.numeric_na.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
            Me.numeric_na.Location = New System.Drawing.Point(8, 32)
            Me.numeric_na.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.numeric_na.Name = "numeric_na"
            Me.numeric_na.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.numeric_na.Size = New System.Drawing.Size(64, 25)
            Me.numeric_na.TabIndex = 7
            Me.numeric_na.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.numeric_na.Value = New Decimal(New Integer() {3, 0, 0, 0})
            '
            'Textbox_H_general
            '
            Me.Textbox_H_general.Font = New System.Drawing.Font("David", 10.8!)
            Me.Textbox_H_general.Location = New System.Drawing.Point(83, 104)
            Me.Textbox_H_general.Name = "Textbox_H_general"
            Me.Textbox_H_general.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Textbox_H_general.Size = New System.Drawing.Size(48, 25)
            Me.Textbox_H_general.TabIndex = 61
            Me.Textbox_H_general.Text = "80"
            Me.Textbox_H_general.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Textbox_Tnb
            '
            Me.Textbox_Tnb.BackColor = System.Drawing.SystemColors.Window
            Me.Textbox_Tnb.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
            Me.Textbox_Tnb.Location = New System.Drawing.Point(107, 344)
            Me.Textbox_Tnb.Name = "Textbox_Tnb"
            Me.Textbox_Tnb.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Textbox_Tnb.Size = New System.Drawing.Size(68, 25)
            Me.Textbox_Tnb.TabIndex = 22
            Me.Textbox_Tnb.Text = "8"
            Me.Textbox_Tnb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label_transverses
            '
            Me.Label_transverses.AutoEllipsis = True
            Me.Label_transverses.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
            Me.Label_transverses.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_transverses.Location = New System.Drawing.Point(12, 284)
            Me.Label_transverses.Name = "Label_transverses"
            Me.Label_transverses.Size = New System.Drawing.Size(309, 21)
            Me.Label_transverses.TabIndex = 28
            Me.Label_transverses.Text = "Transverses:"
            Me.Label_transverses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label_H
            '
            Me.Label_H.AutoEllipsis = True
            Me.Label_H.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
            Me.Label_H.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_H.Location = New System.Drawing.Point(137, 104)
            Me.Label_H.Name = "Label_H"
            Me.Label_H.Size = New System.Drawing.Size(180, 25)
            Me.Label_H.TabIndex = 60
            Me.Label_H.Text = "Stiffeners' Height:"
            Me.Label_H.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Textbox_Tna
            '
            Me.Textbox_Tna.BackColor = System.Drawing.SystemColors.Window
            Me.Textbox_Tna.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
            Me.Textbox_Tna.Location = New System.Drawing.Point(107, 248)
            Me.Textbox_Tna.Name = "Textbox_Tna"
            Me.Textbox_Tna.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Textbox_Tna.Size = New System.Drawing.Size(68, 25)
            Me.Textbox_Tna.TabIndex = 20
            Me.Textbox_Tna.Text = "8"
            Me.Textbox_Tna.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Textbox_Ta
            '
            Me.Textbox_Ta.BackColor = System.Drawing.SystemColors.Window
            Me.Textbox_Ta.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
            Me.Textbox_Ta.Location = New System.Drawing.Point(107, 212)
            Me.Textbox_Ta.Name = "Textbox_Ta"
            Me.Textbox_Ta.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Textbox_Ta.Size = New System.Drawing.Size(68, 25)
            Me.Textbox_Ta.TabIndex = 19
            Me.Textbox_Ta.Text = "8"
            Me.Textbox_Ta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label_thickness
            '
            Me.Label_thickness.AutoEllipsis = True
            Me.Label_thickness.Font = New System.Drawing.Font("David", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(177, Byte))
            Me.Label_thickness.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_thickness.Location = New System.Drawing.Point(8, 145)
            Me.Label_thickness.Name = "Label_thickness"
            Me.Label_thickness.Size = New System.Drawing.Size(313, 28)
            Me.Label_thickness.TabIndex = 63
            Me.Label_thickness.Text = "Stiffeners' Thicknesses:"
            Me.Label_thickness.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label_non_central02
            '
            Me.Label_non_central02.AutoEllipsis = True
            Me.Label_non_central02.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
            Me.Label_non_central02.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_non_central02.Location = New System.Drawing.Point(183, 344)
            Me.Label_non_central02.Name = "Label_non_central02"
            Me.Label_non_central02.Size = New System.Drawing.Size(134, 25)
            Me.Label_non_central02.TabIndex = 32
            Me.Label_non_central02.Text = "Non-Central"
            Me.Label_non_central02.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label_central02
            '
            Me.Label_central02.AutoEllipsis = True
            Me.Label_central02.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
            Me.Label_central02.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_central02.Location = New System.Drawing.Point(183, 312)
            Me.Label_central02.Name = "Label_central02"
            Me.Label_central02.Size = New System.Drawing.Size(134, 25)
            Me.Label_central02.TabIndex = 31
            Me.Label_central02.Text = "Central"
            Me.Label_central02.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label_longitudinals
            '
            Me.Label_longitudinals.AutoEllipsis = True
            Me.Label_longitudinals.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
            Me.Label_longitudinals.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_longitudinals.Location = New System.Drawing.Point(12, 180)
            Me.Label_longitudinals.Name = "Label_longitudinals"
            Me.Label_longitudinals.Size = New System.Drawing.Size(309, 21)
            Me.Label_longitudinals.TabIndex = 27
            Me.Label_longitudinals.Text = "Longitudinals:"
            Me.Label_longitudinals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label_non_central01
            '
            Me.Label_non_central01.AutoEllipsis = True
            Me.Label_non_central01.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
            Me.Label_non_central01.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_non_central01.Location = New System.Drawing.Point(183, 248)
            Me.Label_non_central01.Name = "Label_non_central01"
            Me.Label_non_central01.Size = New System.Drawing.Size(134, 25)
            Me.Label_non_central01.TabIndex = 30
            Me.Label_non_central01.Text = "Non-Central"
            Me.Label_non_central01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label_central01
            '
            Me.Label_central01.AutoEllipsis = True
            Me.Label_central01.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
            Me.Label_central01.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_central01.Location = New System.Drawing.Point(183, 212)
            Me.Label_central01.Name = "Label_central01"
            Me.Label_central01.Size = New System.Drawing.Size(134, 25)
            Me.Label_central01.TabIndex = 29
            Me.Label_central01.Text = "Central"
            Me.Label_central01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Textbox_Tb
            '
            Me.Textbox_Tb.BackColor = System.Drawing.SystemColors.Window
            Me.Textbox_Tb.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
            Me.Textbox_Tb.Location = New System.Drawing.Point(107, 312)
            Me.Textbox_Tb.Name = "Textbox_Tb"
            Me.Textbox_Tb.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Textbox_Tb.Size = New System.Drawing.Size(68, 25)
            Me.Textbox_Tb.TabIndex = 21
            Me.Textbox_Tb.Text = "8"
            Me.Textbox_Tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'label_Nb
            '
            Me.label_Nb.AutoEllipsis = True
            Me.label_Nb.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
            Me.label_Nb.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.label_Nb.Location = New System.Drawing.Point(77, 68)
            Me.label_Nb.Name = "label_Nb"
            Me.label_Nb.Size = New System.Drawing.Size(224, 25)
            Me.label_Nb.TabIndex = 10
            Me.label_Nb.Text = "Transverses:"
            Me.label_Nb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'label_Na
            '
            Me.label_Na.AutoEllipsis = True
            Me.label_Na.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
            Me.label_Na.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.label_Na.Location = New System.Drawing.Point(77, 32)
            Me.label_Na.Name = "label_Na"
            Me.label_Na.Size = New System.Drawing.Size(224, 25)
            Me.label_Na.TabIndex = 8
            Me.label_Na.Text = "Longitudinals:"
            Me.label_Na.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'GroupBox_stiffeners_Data
            '
            Me.GroupBox_stiffeners_Data.Controls.Add(Me.Label_data_transverses)
            Me.GroupBox_stiffeners_Data.Controls.Add(Me.Label_data_longitudinals)
            Me.GroupBox_stiffeners_Data.Controls.Add(Me.numeric_input_moment_units)
            Me.GroupBox_stiffeners_Data.Controls.Add(Me.Textbox_Ib)
            Me.GroupBox_stiffeners_Data.Controls.Add(Me.Textbox_Inb)
            Me.GroupBox_stiffeners_Data.Controls.Add(Me.Textbox_Ia)
            Me.GroupBox_stiffeners_Data.Controls.Add(Me.Textbox_Ina)
            Me.GroupBox_stiffeners_Data.Controls.Add(Me.Label_non_central04)
            Me.GroupBox_stiffeners_Data.Controls.Add(Me.Label_central04)
            Me.GroupBox_stiffeners_Data.Controls.Add(Me.Label_non_central03)
            Me.GroupBox_stiffeners_Data.Controls.Add(Me.Label_central03)
            Me.GroupBox_stiffeners_Data.Controls.Add(Me.Label_units)
            Me.GroupBox_stiffeners_Data.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
            Me.GroupBox_stiffeners_Data.Location = New System.Drawing.Point(344, 216)
            Me.GroupBox_stiffeners_Data.Name = "GroupBox_stiffeners_Data"
            Me.GroupBox_stiffeners_Data.Size = New System.Drawing.Size(304, 288)
            Me.GroupBox_stiffeners_Data.TabIndex = 46
            Me.GroupBox_stiffeners_Data.TabStop = False
            Me.GroupBox_stiffeners_Data.Text = "Moment of Inertia"
            '
            'Label_data_transverses
            '
            Me.Label_data_transverses.AutoEllipsis = True
            Me.Label_data_transverses.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
            Me.Label_data_transverses.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_data_transverses.Location = New System.Drawing.Point(12, 168)
            Me.Label_data_transverses.Name = "Label_data_transverses"
            Me.Label_data_transverses.Size = New System.Drawing.Size(278, 21)
            Me.Label_data_transverses.TabIndex = 57
            Me.Label_data_transverses.Text = "Transverses:"
            Me.Label_data_transverses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label_data_longitudinals
            '
            Me.Label_data_longitudinals.AutoEllipsis = True
            Me.Label_data_longitudinals.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
            Me.Label_data_longitudinals.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_data_longitudinals.Location = New System.Drawing.Point(8, 64)
            Me.Label_data_longitudinals.Name = "Label_data_longitudinals"
            Me.Label_data_longitudinals.Size = New System.Drawing.Size(282, 21)
            Me.Label_data_longitudinals.TabIndex = 56
            Me.Label_data_longitudinals.Text = "Longitudinals:"
            Me.Label_data_longitudinals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'numeric_input_moment_units
            '
            Me.numeric_input_moment_units.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.numeric_input_moment_units.Font = New System.Drawing.Font("David", 10.8!)
            Me.numeric_input_moment_units.ItemHeight = 17
            Me.numeric_input_moment_units.Items.AddRange(New Object() {"m^4", "cm^4", "mm^4"})
            Me.numeric_input_moment_units.Location = New System.Drawing.Point(12, 30)
            Me.numeric_input_moment_units.Name = "numeric_input_moment_units"
            Me.numeric_input_moment_units.Size = New System.Drawing.Size(76, 25)
            Me.numeric_input_moment_units.TabIndex = 54
            '
            'Textbox_Ib
            '
            Me.Textbox_Ib.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
            Me.Textbox_Ib.Location = New System.Drawing.Point(12, 196)
            Me.Textbox_Ib.Name = "Textbox_Ib"
            Me.Textbox_Ib.ReadOnly = True
            Me.Textbox_Ib.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Textbox_Ib.Size = New System.Drawing.Size(104, 25)
            Me.Textbox_Ib.TabIndex = 18
            Me.Textbox_Ib.Text = "0"
            Me.Textbox_Ib.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Textbox_Inb
            '
            Me.Textbox_Inb.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
            Me.Textbox_Inb.Location = New System.Drawing.Point(12, 228)
            Me.Textbox_Inb.Name = "Textbox_Inb"
            Me.Textbox_Inb.ReadOnly = True
            Me.Textbox_Inb.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Textbox_Inb.Size = New System.Drawing.Size(104, 25)
            Me.Textbox_Inb.TabIndex = 17
            Me.Textbox_Inb.Text = "0"
            Me.Textbox_Inb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Textbox_Ia
            '
            Me.Textbox_Ia.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
            Me.Textbox_Ia.Location = New System.Drawing.Point(12, 96)
            Me.Textbox_Ia.Name = "Textbox_Ia"
            Me.Textbox_Ia.ReadOnly = True
            Me.Textbox_Ia.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Textbox_Ia.Size = New System.Drawing.Size(108, 25)
            Me.Textbox_Ia.TabIndex = 16
            Me.Textbox_Ia.Text = "0"
            Me.Textbox_Ia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Textbox_Ina
            '
            Me.Textbox_Ina.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
            Me.Textbox_Ina.Location = New System.Drawing.Point(12, 132)
            Me.Textbox_Ina.Name = "Textbox_Ina"
            Me.Textbox_Ina.ReadOnly = True
            Me.Textbox_Ina.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.Textbox_Ina.Size = New System.Drawing.Size(108, 25)
            Me.Textbox_Ina.TabIndex = 11
            Me.Textbox_Ina.Text = "0"
            Me.Textbox_Ina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label_non_central04
            '
            Me.Label_non_central04.AutoEllipsis = True
            Me.Label_non_central04.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
            Me.Label_non_central04.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_non_central04.Location = New System.Drawing.Point(126, 228)
            Me.Label_non_central04.Name = "Label_non_central04"
            Me.Label_non_central04.Size = New System.Drawing.Size(164, 25)
            Me.Label_non_central04.TabIndex = 61
            Me.Label_non_central04.Text = "Non-Central"
            Me.Label_non_central04.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label_central04
            '
            Me.Label_central04.AutoEllipsis = True
            Me.Label_central04.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
            Me.Label_central04.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_central04.Location = New System.Drawing.Point(126, 196)
            Me.Label_central04.Name = "Label_central04"
            Me.Label_central04.Size = New System.Drawing.Size(164, 25)
            Me.Label_central04.TabIndex = 60
            Me.Label_central04.Text = "Central"
            Me.Label_central04.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label_non_central03
            '
            Me.Label_non_central03.AutoEllipsis = True
            Me.Label_non_central03.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
            Me.Label_non_central03.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_non_central03.Location = New System.Drawing.Point(126, 132)
            Me.Label_non_central03.Name = "Label_non_central03"
            Me.Label_non_central03.Size = New System.Drawing.Size(164, 25)
            Me.Label_non_central03.TabIndex = 59
            Me.Label_non_central03.Text = "Non-Central"
            Me.Label_non_central03.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label_central03
            '
            Me.Label_central03.AutoEllipsis = True
            Me.Label_central03.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
            Me.Label_central03.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_central03.Location = New System.Drawing.Point(126, 96)
            Me.Label_central03.Name = "Label_central03"
            Me.Label_central03.Size = New System.Drawing.Size(164, 25)
            Me.Label_central03.TabIndex = 58
            Me.Label_central03.Text = "Central"
            Me.Label_central03.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label_units
            '
            Me.Label_units.AutoEllipsis = True
            Me.Label_units.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
            Me.Label_units.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_units.Location = New System.Drawing.Point(90, 30)
            Me.Label_units.Name = "Label_units"
            Me.Label_units.Size = New System.Drawing.Size(206, 25)
            Me.Label_units.TabIndex = 55
            Me.Label_units.Text = "Units:"
            Me.Label_units.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'RichTextBox_macro
            '
            Me.RichTextBox_macro.Location = New System.Drawing.Point(20, 267)
            Me.RichTextBox_macro.Name = "RichTextBox_macro"
            Me.RichTextBox_macro.Size = New System.Drawing.Size(776, 289)
            Me.RichTextBox_macro.TabIndex = 48
            Me.RichTextBox_macro.Text = ""
            Me.RichTextBox_macro.Visible = False
            '
            'Button_gen
            '
            Me.Button_gen.AutoEllipsis = True
            Me.Button_gen.Location = New System.Drawing.Point(19, 16)
            Me.Button_gen.Name = "Button_gen"
            Me.Button_gen.Size = New System.Drawing.Size(137, 32)
            Me.Button_gen.TabIndex = 49
            Me.Button_gen.Text = "generate"
            '
            'Button_save_macro
            '
            Me.Button_save_macro.AutoEllipsis = True
            Me.Button_save_macro.Location = New System.Drawing.Point(336, 560)
            Me.Button_save_macro.Name = "Button_save_macro"
            Me.Button_save_macro.Size = New System.Drawing.Size(120, 40)
            Me.Button_save_macro.TabIndex = 50
            Me.Button_save_macro.Text = "Save Macro"
            Me.Button_save_macro.Visible = False
            '
            'ProgressBar_sub
            '
            Me.ProgressBar_sub.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ProgressBar_sub.Location = New System.Drawing.Point(9, 55)
            Me.ProgressBar_sub.Name = "ProgressBar_sub"
            Me.ProgressBar_sub.Size = New System.Drawing.Size(372, 16)
            Me.ProgressBar_sub.TabIndex = 51
            '
            'ProgressBar_total
            '
            Me.ProgressBar_total.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ProgressBar_total.Location = New System.Drawing.Point(9, 107)
            Me.ProgressBar_total.Name = "ProgressBar_total"
            Me.ProgressBar_total.Size = New System.Drawing.Size(372, 16)
            Me.ProgressBar_total.TabIndex = 52
            '
            'Label_total_progress
            '
            Me.Label_total_progress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label_total_progress.AutoEllipsis = True
            Me.Label_total_progress.Location = New System.Drawing.Point(9, 84)
            Me.Label_total_progress.Name = "Label_total_progress"
            Me.Label_total_progress.Size = New System.Drawing.Size(372, 20)
            Me.Label_total_progress.TabIndex = 53
            Me.Label_total_progress.Text = "Total Progress:"
            '
            'Label_current_progress
            '
            Me.Label_current_progress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label_current_progress.AutoEllipsis = True
            Me.Label_current_progress.Location = New System.Drawing.Point(9, 31)
            Me.Label_current_progress.Name = "Label_current_progress"
            Me.Label_current_progress.Size = New System.Drawing.Size(372, 20)
            Me.Label_current_progress.TabIndex = 54
            Me.Label_current_progress.Text = "Generation nodes,surfaces,meshing,setting properties"
            '
            'CheckBox_macro
            '
            Me.CheckBox_macro.AutoEllipsis = True
            Me.CheckBox_macro.Enabled = False
            Me.CheckBox_macro.Location = New System.Drawing.Point(23, 56)
            Me.CheckBox_macro.Name = "CheckBox_macro"
            Me.CheckBox_macro.Size = New System.Drawing.Size(275, 20)
            Me.CheckBox_macro.TabIndex = 55
            Me.CheckBox_macro.Text = "Show generated ADINA code"
            '
            'Panel_model_geometry
            '
            Me.Panel_model_geometry.AutoScroll = True
            Me.Panel_model_geometry.Controls.Add(Me.Picture_eng_panel1)
            Me.Panel_model_geometry.Controls.Add(Me.Picture_heb_panel1)
            Me.Panel_model_geometry.Controls.Add(Me.groupbox_plate_geo)
            Me.Panel_model_geometry.Controls.Add(Me.groupbox_General)
            Me.Panel_model_geometry.Controls.Add(Me.GroupBox_stiffeners)
            Me.Panel_model_geometry.Controls.Add(Me.GroupBox_stiffeners_Data)
            Me.Panel_model_geometry.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel_model_geometry.Location = New System.Drawing.Point(0, 0)
            Me.Panel_model_geometry.Name = "Panel_model_geometry"
            Me.Panel_model_geometry.Size = New System.Drawing.Size(907, 740)
            Me.Panel_model_geometry.TabIndex = 58
            '
            'Picture_eng_panel1
            '
            Me.Picture_eng_panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Picture_eng_panel1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Picture_eng_panel1.Image = Global.SPE.My.Resources.Resources.flag_english01
            Me.Picture_eng_panel1.Location = New System.Drawing.Point(865, 32)
            Me.Picture_eng_panel1.Name = "Picture_eng_panel1"
            Me.Picture_eng_panel1.Size = New System.Drawing.Size(32, 16)
            Me.Picture_eng_panel1.TabIndex = 50
            Me.Picture_eng_panel1.TabStop = False
            '
            'Picture_heb_panel1
            '
            Me.Picture_heb_panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Picture_heb_panel1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Picture_heb_panel1.Image = Global.SPE.My.Resources.Resources.flag_hebrew01
            Me.Picture_heb_panel1.Location = New System.Drawing.Point(865, 8)
            Me.Picture_heb_panel1.Name = "Picture_heb_panel1"
            Me.Picture_heb_panel1.Size = New System.Drawing.Size(32, 20)
            Me.Picture_heb_panel1.TabIndex = 49
            Me.Picture_heb_panel1.TabStop = False
            '
            'groupbox_plate_geo
            '
            Me.groupbox_plate_geo.Controls.Add(Me.label_t)
            Me.groupbox_plate_geo.Controls.Add(Me.numeric_t)
            Me.groupbox_plate_geo.Controls.Add(Me.label_b)
            Me.groupbox_plate_geo.Controls.Add(Me.numeric_b)
            Me.groupbox_plate_geo.Controls.Add(Me.label_a)
            Me.groupbox_plate_geo.Controls.Add(Me.numeric_a)
            Me.groupbox_plate_geo.Controls.Add(Me.label_unit_mm01)
            Me.groupbox_plate_geo.Controls.Add(Me.label_unit_m02)
            Me.groupbox_plate_geo.Controls.Add(Me.label_unit_m01)
            Me.groupbox_plate_geo.Font = New System.Drawing.Font("David", 12.0!)
            Me.groupbox_plate_geo.Location = New System.Drawing.Point(8, 24)
            Me.groupbox_plate_geo.Name = "groupbox_plate_geo"
            Me.groupbox_plate_geo.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.groupbox_plate_geo.Size = New System.Drawing.Size(328, 172)
            Me.groupbox_plate_geo.TabIndex = 48
            Me.groupbox_plate_geo.TabStop = False
            Me.groupbox_plate_geo.Text = "Plate Geometry"
            '
            'label_t
            '
            Me.label_t.AutoEllipsis = True
            Me.label_t.Font = New System.Drawing.Font("David", 10.8!)
            Me.label_t.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.label_t.Location = New System.Drawing.Point(182, 118)
            Me.label_t.Name = "label_t"
            Me.label_t.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.label_t.Size = New System.Drawing.Size(134, 25)
            Me.label_t.TabIndex = 12
            Me.label_t.Text = "Thickness t"
            Me.label_t.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'numeric_t
            '
            Me.numeric_t.DecimalPlaces = 2
            Me.numeric_t.Font = New System.Drawing.Font("David", 10.8!)
            Me.numeric_t.Location = New System.Drawing.Point(104, 118)
            Me.numeric_t.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
            Me.numeric_t.Name = "numeric_t"
            Me.numeric_t.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.numeric_t.Size = New System.Drawing.Size(64, 25)
            Me.numeric_t.TabIndex = 11
            Me.numeric_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.numeric_t.Value = New Decimal(New Integer() {100, 0, 0, 131072})
            '
            'label_b
            '
            Me.label_b.AutoEllipsis = True
            Me.label_b.Font = New System.Drawing.Font("David", 10.8!)
            Me.label_b.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.label_b.Location = New System.Drawing.Point(182, 80)
            Me.label_b.Name = "label_b"
            Me.label_b.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.label_b.Size = New System.Drawing.Size(134, 25)
            Me.label_b.TabIndex = 10
            Me.label_b.Text = "Breadth b"
            Me.label_b.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'numeric_b
            '
            Me.numeric_b.DecimalPlaces = 2
            Me.numeric_b.Font = New System.Drawing.Font("David", 10.8!)
            Me.numeric_b.Location = New System.Drawing.Point(104, 80)
            Me.numeric_b.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
            Me.numeric_b.Name = "numeric_b"
            Me.numeric_b.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.numeric_b.Size = New System.Drawing.Size(64, 25)
            Me.numeric_b.TabIndex = 9
            Me.numeric_b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.numeric_b.Value = New Decimal(New Integer() {3, 0, 0, 0})
            '
            'label_a
            '
            Me.label_a.AutoEllipsis = True
            Me.label_a.Font = New System.Drawing.Font("David", 10.8!)
            Me.label_a.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.label_a.Location = New System.Drawing.Point(182, 36)
            Me.label_a.Name = "label_a"
            Me.label_a.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.label_a.Size = New System.Drawing.Size(134, 25)
            Me.label_a.TabIndex = 8
            Me.label_a.Text = "Length a"
            Me.label_a.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'numeric_a
            '
            Me.numeric_a.DecimalPlaces = 2
            Me.numeric_a.Font = New System.Drawing.Font("David", 10.8!)
            Me.numeric_a.Location = New System.Drawing.Point(104, 36)
            Me.numeric_a.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
            Me.numeric_a.Name = "numeric_a"
            Me.numeric_a.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.numeric_a.Size = New System.Drawing.Size(64, 25)
            Me.numeric_a.TabIndex = 7
            Me.numeric_a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.numeric_a.Value = New Decimal(New Integer() {6, 0, 0, 0})
            '
            'label_unit_mm01
            '
            Me.label_unit_mm01.AutoEllipsis = True
            Me.label_unit_mm01.Font = New System.Drawing.Font("David", 10.8!)
            Me.label_unit_mm01.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.label_unit_mm01.Location = New System.Drawing.Point(10, 118)
            Me.label_unit_mm01.Name = "label_unit_mm01"
            Me.label_unit_mm01.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.label_unit_mm01.Size = New System.Drawing.Size(81, 25)
            Me.label_unit_mm01.TabIndex = 41
            Me.label_unit_mm01.Text = "[mm]"
            Me.label_unit_mm01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'label_unit_m02
            '
            Me.label_unit_m02.AutoEllipsis = True
            Me.label_unit_m02.Font = New System.Drawing.Font("David", 10.8!)
            Me.label_unit_m02.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.label_unit_m02.Location = New System.Drawing.Point(10, 80)
            Me.label_unit_m02.Name = "label_unit_m02"
            Me.label_unit_m02.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.label_unit_m02.Size = New System.Drawing.Size(81, 25)
            Me.label_unit_m02.TabIndex = 40
            Me.label_unit_m02.Text = "[m]"
            Me.label_unit_m02.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'label_unit_m01
            '
            Me.label_unit_m01.AutoEllipsis = True
            Me.label_unit_m01.Font = New System.Drawing.Font("David", 10.8!)
            Me.label_unit_m01.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.label_unit_m01.Location = New System.Drawing.Point(10, 36)
            Me.label_unit_m01.Name = "label_unit_m01"
            Me.label_unit_m01.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.label_unit_m01.Size = New System.Drawing.Size(81, 25)
            Me.label_unit_m01.TabIndex = 39
            Me.label_unit_m01.Text = "[m]"
            Me.label_unit_m01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'groupbox_General
            '
            Me.groupbox_General.Controls.Add(Me.PictureBox_info)
            Me.groupbox_General.Controls.Add(Me.Label_GPa)
            Me.groupbox_General.Controls.Add(Me.combobox_P_units)
            Me.groupbox_General.Controls.Add(Me.textbox_P_input)
            Me.groupbox_General.Controls.Add(Me.textbox_ni_input)
            Me.groupbox_General.Controls.Add(Me.textbox_E_input)
            Me.groupbox_General.Controls.Add(Me.Label_pressure)
            Me.groupbox_General.Controls.Add(Me.label_ni)
            Me.groupbox_General.Controls.Add(Me.Label_E)
            Me.groupbox_General.Controls.Add(Me.numeric_case_input)
            Me.groupbox_General.Controls.Add(Me.Label_BC)
            Me.groupbox_General.Font = New System.Drawing.Font("David", 12.0!)
            Me.groupbox_General.Location = New System.Drawing.Point(344, 24)
            Me.groupbox_General.Name = "groupbox_General"
            Me.groupbox_General.Size = New System.Drawing.Size(304, 172)
            Me.groupbox_General.TabIndex = 47
            Me.groupbox_General.TabStop = False
            Me.groupbox_General.Text = "General Properties"
            '
            'PictureBox_info
            '
            Me.PictureBox_info.Image = CType(resources.GetObject("PictureBox_info.Image"), System.Drawing.Image)
            Me.PictureBox_info.Location = New System.Drawing.Point(12, 140)
            Me.PictureBox_info.Name = "PictureBox_info"
            Me.PictureBox_info.Size = New System.Drawing.Size(28, 24)
            Me.PictureBox_info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox_info.TabIndex = 55
            Me.PictureBox_info.TabStop = False
            Me.PictureBox_info.Visible = False
            '
            'Label_GPa
            '
            Me.Label_GPa.AutoEllipsis = True
            Me.Label_GPa.Font = New System.Drawing.Font("David", 10.8!)
            Me.Label_GPa.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_GPa.Location = New System.Drawing.Point(12, 80)
            Me.Label_GPa.Name = "Label_GPa"
            Me.Label_GPa.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.Label_GPa.Size = New System.Drawing.Size(52, 25)
            Me.Label_GPa.TabIndex = 54
            Me.Label_GPa.Text = "[GPa]"
            Me.Label_GPa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'combobox_P_units
            '
            Me.combobox_P_units.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.combobox_P_units.Font = New System.Drawing.Font("David", 10.8!)
            Me.combobox_P_units.ItemHeight = 17
            Me.combobox_P_units.Items.AddRange(New Object() {"Pa", "Kpa", "Mpa"})
            Me.combobox_P_units.Location = New System.Drawing.Point(6, 40)
            Me.combobox_P_units.Name = "combobox_P_units"
            Me.combobox_P_units.Size = New System.Drawing.Size(64, 25)
            Me.combobox_P_units.TabIndex = 52
            '
            'textbox_P_input
            '
            Me.textbox_P_input.Font = New System.Drawing.Font("David", 10.8!)
            Me.textbox_P_input.Location = New System.Drawing.Point(76, 40)
            Me.textbox_P_input.Name = "textbox_P_input"
            Me.textbox_P_input.Size = New System.Drawing.Size(52, 25)
            Me.textbox_P_input.TabIndex = 51
            Me.textbox_P_input.Text = "1000"
            Me.textbox_P_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'textbox_ni_input
            '
            Me.textbox_ni_input.Font = New System.Drawing.Font("David", 10.8!)
            Me.textbox_ni_input.Location = New System.Drawing.Point(76, 110)
            Me.textbox_ni_input.Name = "textbox_ni_input"
            Me.textbox_ni_input.Size = New System.Drawing.Size(52, 25)
            Me.textbox_ni_input.TabIndex = 50
            Me.textbox_ni_input.Text = "0.3"
            Me.textbox_ni_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'textbox_E_input
            '
            Me.textbox_E_input.Font = New System.Drawing.Font("David", 10.8!)
            Me.textbox_E_input.Location = New System.Drawing.Point(76, 80)
            Me.textbox_E_input.Name = "textbox_E_input"
            Me.textbox_E_input.Size = New System.Drawing.Size(52, 25)
            Me.textbox_E_input.TabIndex = 49
            Me.textbox_E_input.Text = "207"
            Me.textbox_E_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label_pressure
            '
            Me.Label_pressure.AutoEllipsis = True
            Me.Label_pressure.Font = New System.Drawing.Font("David", 10.8!)
            Me.Label_pressure.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_pressure.Location = New System.Drawing.Point(134, 30)
            Me.Label_pressure.Name = "Label_pressure"
            Me.Label_pressure.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label_pressure.Size = New System.Drawing.Size(164, 44)
            Me.Label_pressure.TabIndex = 48
            Me.Label_pressure.Text = "Uniform pressure acting on plate"
            Me.Label_pressure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'label_ni
            '
            Me.label_ni.AutoEllipsis = True
            Me.label_ni.Font = New System.Drawing.Font("David", 10.8!)
            Me.label_ni.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.label_ni.Location = New System.Drawing.Point(134, 110)
            Me.label_ni.Name = "label_ni"
            Me.label_ni.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.label_ni.Size = New System.Drawing.Size(168, 25)
            Me.label_ni.TabIndex = 47
            Me.label_ni.Text = "Poisson's Ratio"
            Me.label_ni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label_E
            '
            Me.Label_E.AutoEllipsis = True
            Me.Label_E.Font = New System.Drawing.Font("David", 10.8!)
            Me.Label_E.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_E.Location = New System.Drawing.Point(134, 80)
            Me.Label_E.Name = "Label_E"
            Me.Label_E.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label_E.Size = New System.Drawing.Size(168, 25)
            Me.Label_E.TabIndex = 46
            Me.Label_E.Text = "Modulus of Elasticity"
            Me.Label_E.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'numeric_case_input
            '
            Me.numeric_case_input.Font = New System.Drawing.Font("David", 10.8!)
            Me.numeric_case_input.Location = New System.Drawing.Point(76, 140)
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
            Me.Label_BC.Location = New System.Drawing.Point(134, 140)
            Me.Label_BC.Name = "Label_BC"
            Me.Label_BC.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label_BC.Size = New System.Drawing.Size(168, 25)
            Me.Label_BC.TabIndex = 44
            Me.Label_BC.Text = "Boundary condition"
            Me.Label_BC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Panel_create_model
            '
            Me.Panel_create_model.AutoScroll = True
            Me.Panel_create_model.Controls.Add(Me.Picture_eng_panel3)
            Me.Panel_create_model.Controls.Add(Me.Picture_heb_panel3)
            Me.Panel_create_model.Controls.Add(Me.GroupBox_generate)
            Me.Panel_create_model.Controls.Add(Me.GroupBox_statistics)
            Me.Panel_create_model.Controls.Add(Me.GroupBox_process)
            Me.Panel_create_model.Controls.Add(Me.GroupBox_generation)
            Me.Panel_create_model.Controls.Add(Me.RichTextBox_macro)
            Me.Panel_create_model.Controls.Add(Me.Button_save_macro)
            Me.Panel_create_model.Controls.Add(Me.GroupBox_video)
            Me.Panel_create_model.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel_create_model.Location = New System.Drawing.Point(0, 0)
            Me.Panel_create_model.Name = "Panel_create_model"
            Me.Panel_create_model.Size = New System.Drawing.Size(907, 740)
            Me.Panel_create_model.TabIndex = 61
            '
            'Picture_eng_panel3
            '
            Me.Picture_eng_panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Picture_eng_panel3.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Picture_eng_panel3.Image = Global.SPE.My.Resources.Resources.flag_english01
            Me.Picture_eng_panel3.Location = New System.Drawing.Point(1731, 32)
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
            Me.Picture_heb_panel3.Location = New System.Drawing.Point(1731, 8)
            Me.Picture_heb_panel3.Name = "Picture_heb_panel3"
            Me.Picture_heb_panel3.Size = New System.Drawing.Size(32, 20)
            Me.Picture_heb_panel3.TabIndex = 62
            Me.Picture_heb_panel3.TabStop = False
            '
            'GroupBox_generate
            '
            Me.GroupBox_generate.Controls.Add(Me.CheckBox_macro)
            Me.GroupBox_generate.Controls.Add(Me.Button_gen)
            Me.GroupBox_generate.Location = New System.Drawing.Point(20, 176)
            Me.GroupBox_generate.Name = "GroupBox_generate"
            Me.GroupBox_generate.Size = New System.Drawing.Size(304, 88)
            Me.GroupBox_generate.TabIndex = 59
            Me.GroupBox_generate.TabStop = False
            '
            'GroupBox_statistics
            '
            Me.GroupBox_statistics.Controls.Add(Me.Button_time)
            Me.GroupBox_statistics.Controls.Add(Me.Label_time_interval)
            Me.GroupBox_statistics.Controls.Add(Me.Label_time_end)
            Me.GroupBox_statistics.Controls.Add(Me.Label_time_start)
            Me.GroupBox_statistics.Location = New System.Drawing.Point(341, 176)
            Me.GroupBox_statistics.Name = "GroupBox_statistics"
            Me.GroupBox_statistics.Size = New System.Drawing.Size(399, 88)
            Me.GroupBox_statistics.TabIndex = 58
            Me.GroupBox_statistics.TabStop = False
            Me.GroupBox_statistics.Text = "Statistics"
            '
            'Button_time
            '
            Me.Button_time.AutoEllipsis = True
            Me.Button_time.Location = New System.Drawing.Point(300, 28)
            Me.Button_time.Name = "Button_time"
            Me.Button_time.Size = New System.Drawing.Size(72, 36)
            Me.Button_time.TabIndex = 3
            Me.Button_time.Text = "Explain"
            '
            'Label_time_interval
            '
            Me.Label_time_interval.AutoEllipsis = True
            Me.Label_time_interval.Location = New System.Drawing.Point(20, 60)
            Me.Label_time_interval.Name = "Label_time_interval"
            Me.Label_time_interval.Size = New System.Drawing.Size(260, 18)
            Me.Label_time_interval.TabIndex = 2
            Me.Label_time_interval.Text = "Process time: 0000 [Milliseconds]"
            '
            'Label_time_end
            '
            Me.Label_time_end.AutoEllipsis = True
            Me.Label_time_end.Location = New System.Drawing.Point(20, 40)
            Me.Label_time_end.Name = "Label_time_end"
            Me.Label_time_end.Size = New System.Drawing.Size(260, 18)
            Me.Label_time_end.TabIndex = 1
            Me.Label_time_end.Text = "End time: N/A"
            '
            'Label_time_start
            '
            Me.Label_time_start.AutoEllipsis = True
            Me.Label_time_start.Location = New System.Drawing.Point(20, 20)
            Me.Label_time_start.Name = "Label_time_start"
            Me.Label_time_start.Size = New System.Drawing.Size(260, 17)
            Me.Label_time_start.TabIndex = 0
            Me.Label_time_start.Text = "Start time:  N/A"
            '
            'GroupBox_process
            '
            Me.GroupBox_process.Controls.Add(Me.Label_current_progress)
            Me.GroupBox_process.Controls.Add(Me.Label_total_progress)
            Me.GroupBox_process.Controls.Add(Me.ProgressBar_total)
            Me.GroupBox_process.Controls.Add(Me.ProgressBar_sub)
            Me.GroupBox_process.Location = New System.Drawing.Point(340, 19)
            Me.GroupBox_process.Name = "GroupBox_process"
            Me.GroupBox_process.Size = New System.Drawing.Size(400, 152)
            Me.GroupBox_process.TabIndex = 57
            Me.GroupBox_process.TabStop = False
            Me.GroupBox_process.Text = "Process"
            '
            'GroupBox_generation
            '
            Me.GroupBox_generation.Controls.Add(Me.CheckBox_gen_mesh)
            Me.GroupBox_generation.Controls.Add(Me.CheckBox_gen_load)
            Me.GroupBox_generation.Controls.Add(Me.CheckBox_gen_BC)
            Me.GroupBox_generation.Controls.Add(Me.CheckBox_gen_geo)
            Me.GroupBox_generation.Location = New System.Drawing.Point(20, 19)
            Me.GroupBox_generation.Name = "GroupBox_generation"
            Me.GroupBox_generation.Size = New System.Drawing.Size(304, 152)
            Me.GroupBox_generation.TabIndex = 56
            Me.GroupBox_generation.TabStop = False
            Me.GroupBox_generation.Text = "Model creation"
            '
            'CheckBox_gen_mesh
            '
            Me.CheckBox_gen_mesh.AutoEllipsis = True
            Me.CheckBox_gen_mesh.Checked = True
            Me.CheckBox_gen_mesh.CheckState = System.Windows.Forms.CheckState.Checked
            Me.CheckBox_gen_mesh.Location = New System.Drawing.Point(13, 125)
            Me.CheckBox_gen_mesh.Name = "CheckBox_gen_mesh"
            Me.CheckBox_gen_mesh.Size = New System.Drawing.Size(264, 20)
            Me.CheckBox_gen_mesh.TabIndex = 3
            Me.CheckBox_gen_mesh.Text = "Mesh generating"
            '
            'CheckBox_gen_load
            '
            Me.CheckBox_gen_load.AutoEllipsis = True
            Me.CheckBox_gen_load.Checked = True
            Me.CheckBox_gen_load.CheckState = System.Windows.Forms.CheckState.Checked
            Me.CheckBox_gen_load.Location = New System.Drawing.Point(13, 99)
            Me.CheckBox_gen_load.Name = "CheckBox_gen_load"
            Me.CheckBox_gen_load.Size = New System.Drawing.Size(264, 20)
            Me.CheckBox_gen_load.TabIndex = 2
            Me.CheckBox_gen_load.Text = "Load (Uniform Lateral pressure)"
            '
            'CheckBox_gen_BC
            '
            Me.CheckBox_gen_BC.AutoEllipsis = True
            Me.CheckBox_gen_BC.Checked = True
            Me.CheckBox_gen_BC.CheckState = System.Windows.Forms.CheckState.Checked
            Me.CheckBox_gen_BC.Location = New System.Drawing.Point(13, 71)
            Me.CheckBox_gen_BC.Name = "CheckBox_gen_BC"
            Me.CheckBox_gen_BC.Size = New System.Drawing.Size(264, 20)
            Me.CheckBox_gen_BC.TabIndex = 1
            Me.CheckBox_gen_BC.Text = "Boundary conditions"
            '
            'CheckBox_gen_geo
            '
            Me.CheckBox_gen_geo.AutoEllipsis = True
            Me.CheckBox_gen_geo.Checked = True
            Me.CheckBox_gen_geo.CheckState = System.Windows.Forms.CheckState.Checked
            Me.CheckBox_gen_geo.Location = New System.Drawing.Point(13, 18)
            Me.CheckBox_gen_geo.Name = "CheckBox_gen_geo"
            Me.CheckBox_gen_geo.Size = New System.Drawing.Size(285, 54)
            Me.CheckBox_gen_geo.TabIndex = 0
            Me.CheckBox_gen_geo.Text = "Model only (Geometry, thicknesses and Material properties)"
            '
            'GroupBox_video
            '
            Me.GroupBox_video.Controls.Add(Me.RichTextBox_video)
            Me.GroupBox_video.Controls.Add(Me.PictureBox_video01)
            Me.GroupBox_video.Location = New System.Drawing.Point(20, 267)
            Me.GroupBox_video.Name = "GroupBox_video"
            Me.GroupBox_video.Size = New System.Drawing.Size(776, 289)
            Me.GroupBox_video.TabIndex = 61
            Me.GroupBox_video.TabStop = False
            '
            'RichTextBox_video
            '
            Me.RichTextBox_video.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.RichTextBox_video.AutoWordSelection = True
            Me.RichTextBox_video.BackColor = System.Drawing.Color.WhiteSmoke
            Me.RichTextBox_video.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.RichTextBox_video.BulletIndent = 1
            Me.RichTextBox_video.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
            Me.RichTextBox_video.ForeColor = System.Drawing.Color.Navy
            Me.RichTextBox_video.Location = New System.Drawing.Point(324, 24)
            Me.RichTextBox_video.Name = "RichTextBox_video"
            Me.RichTextBox_video.ReadOnly = True
            Me.RichTextBox_video.ShowSelectionMargin = True
            Me.RichTextBox_video.Size = New System.Drawing.Size(444, 248)
            Me.RichTextBox_video.TabIndex = 2
            Me.RichTextBox_video.Text = resources.GetString("RichTextBox_video.Text")
            '
            'PictureBox_video01
            '
            Me.PictureBox_video01.Cursor = System.Windows.Forms.Cursors.Hand
            Me.PictureBox_video01.Image = CType(resources.GetObject("PictureBox_video01.Image"), System.Drawing.Image)
            Me.PictureBox_video01.Location = New System.Drawing.Point(8, 51)
            Me.PictureBox_video01.Name = "PictureBox_video01"
            Me.PictureBox_video01.Size = New System.Drawing.Size(336, 192)
            Me.PictureBox_video01.TabIndex = 0
            Me.PictureBox_video01.TabStop = False
            '
            'Panel_mesh_properties
            '
            Me.Panel_mesh_properties.AutoScroll = True
            Me.Panel_mesh_properties.Controls.Add(Me.Picture_eng_panel2)
            Me.Panel_mesh_properties.Controls.Add(Me.Picture_heb_panel2)
            Me.Panel_mesh_properties.Controls.Add(Me.GroupBox7)
            Me.Panel_mesh_properties.Controls.Add(Me.GroupBox_density)
            Me.Panel_mesh_properties.Controls.Add(Me.Button_set_data)
            Me.Panel_mesh_properties.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel_mesh_properties.Location = New System.Drawing.Point(0, 0)
            Me.Panel_mesh_properties.Name = "Panel_mesh_properties"
            Me.Panel_mesh_properties.Size = New System.Drawing.Size(907, 740)
            Me.Panel_mesh_properties.TabIndex = 62
            '
            'Picture_eng_panel2
            '
            Me.Picture_eng_panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Picture_eng_panel2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Picture_eng_panel2.Image = Global.SPE.My.Resources.Resources.flag_english01
            Me.Picture_eng_panel2.Location = New System.Drawing.Point(1041, 32)
            Me.Picture_eng_panel2.Name = "Picture_eng_panel2"
            Me.Picture_eng_panel2.Size = New System.Drawing.Size(32, 16)
            Me.Picture_eng_panel2.TabIndex = 65
            Me.Picture_eng_panel2.TabStop = False
            '
            'Picture_heb_panel2
            '
            Me.Picture_heb_panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Picture_heb_panel2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Picture_heb_panel2.Image = Global.SPE.My.Resources.Resources.flag_hebrew01
            Me.Picture_heb_panel2.Location = New System.Drawing.Point(1041, 8)
            Me.Picture_heb_panel2.Name = "Picture_heb_panel2"
            Me.Picture_heb_panel2.Size = New System.Drawing.Size(32, 20)
            Me.Picture_heb_panel2.TabIndex = 64
            Me.Picture_heb_panel2.TabStop = False
            '
            'GroupBox7
            '
            Me.GroupBox7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.GroupBox7.Controls.Add(Me.CheckBox_degenenrate)
            Me.GroupBox7.Controls.Add(Me.CheckBox_flip)
            Me.GroupBox7.Controls.Add(Me.Label_shape)
            Me.GroupBox7.Controls.Add(Me.ComboBox_shape_all)
            Me.GroupBox7.Controls.Add(Me.GroupBox11)
            Me.GroupBox7.Controls.Add(Me.GroupBox10)
            Me.GroupBox7.Controls.Add(Me.GroupBox_mesh_algo)
            Me.GroupBox7.Controls.Add(Me.GroupBox_mesh_type)
            Me.GroupBox7.Controls.Add(Me.Label31)
            Me.GroupBox7.Controls.Add(Me.ComboBox_type)
            Me.GroupBox7.Controls.Add(Me.ComboBox_shape_quaonly)
            Me.GroupBox7.Controls.Add(Me.ComboBox_shape_qua)
            Me.GroupBox7.Controls.Add(Me.ComboBox_shape_tri)
            Me.GroupBox7.Location = New System.Drawing.Point(12, 264)
            Me.GroupBox7.Name = "GroupBox7"
            Me.GroupBox7.Size = New System.Drawing.Size(878, 336)
            Me.GroupBox7.TabIndex = 1
            Me.GroupBox7.TabStop = False
            Me.GroupBox7.Text = "Mesh Properties"
            '
            'CheckBox_degenenrate
            '
            Me.CheckBox_degenenrate.Location = New System.Drawing.Point(21, 304)
            Me.CheckBox_degenenrate.Name = "CheckBox_degenenrate"
            Me.CheckBox_degenenrate.Size = New System.Drawing.Size(292, 20)
            Me.CheckBox_degenenrate.TabIndex = 20
            Me.CheckBox_degenenrate.Text = "Triangular Surfaces Treated as Degenerate"
            '
            'CheckBox_flip
            '
            Me.CheckBox_flip.Location = New System.Drawing.Point(413, 268)
            Me.CheckBox_flip.Name = "CheckBox_flip"
            Me.CheckBox_flip.Size = New System.Drawing.Size(160, 20)
            Me.CheckBox_flip.TabIndex = 18
            Me.CheckBox_flip.Text = "Flip Shell Normal"
            '
            'Label_shape
            '
            Me.Label_shape.Location = New System.Drawing.Point(18, 263)
            Me.Label_shape.Name = "Label_shape"
            Me.Label_shape.Size = New System.Drawing.Size(222, 28)
            Me.Label_shape.TabIndex = 16
            Me.Label_shape.Text = "Preferred Cell Shape:"
            '
            'ComboBox_shape_all
            '
            Me.ComboBox_shape_all.ItemHeight = 20
            Me.ComboBox_shape_all.Items.AddRange(New Object() {"Automatic", "Triangular", "Quadrilateral"})
            Me.ComboBox_shape_all.Location = New System.Drawing.Point(244, 264)
            Me.ComboBox_shape_all.Name = "ComboBox_shape_all"
            Me.ComboBox_shape_all.Size = New System.Drawing.Size(140, 28)
            Me.ComboBox_shape_all.TabIndex = 15
            Me.ComboBox_shape_all.Text = "Automatic"
            '
            'GroupBox11
            '
            Me.GroupBox11.Controls.Add(Me.RadioButton_mid02)
            Me.GroupBox11.Controls.Add(Me.RadioButton_mid01)
            Me.GroupBox11.Location = New System.Drawing.Point(340, 160)
            Me.GroupBox11.Name = "GroupBox11"
            Me.GroupBox11.Size = New System.Drawing.Size(236, 92)
            Me.GroupBox11.TabIndex = 14
            Me.GroupBox11.TabStop = False
            Me.GroupBox11.Text = "Mid-Side Nodes On"
            '
            'RadioButton_mid02
            '
            Me.RadioButton_mid02.Location = New System.Drawing.Point(12, 52)
            Me.RadioButton_mid02.Name = "RadioButton_mid02"
            Me.RadioButton_mid02.Size = New System.Drawing.Size(128, 28)
            Me.RadioButton_mid02.TabIndex = 1
            Me.RadioButton_mid02.Text = "Straight Line"
            '
            'RadioButton_mid01
            '
            Me.RadioButton_mid01.Checked = True
            Me.RadioButton_mid01.Location = New System.Drawing.Point(12, 24)
            Me.RadioButton_mid01.Name = "RadioButton_mid01"
            Me.RadioButton_mid01.Size = New System.Drawing.Size(128, 28)
            Me.RadioButton_mid01.TabIndex = 0
            Me.RadioButton_mid01.TabStop = True
            Me.RadioButton_mid01.Text = "Curved Geometry"
            '
            'GroupBox10
            '
            Me.GroupBox10.Controls.Add(Me.ComboBox_pattern)
            Me.GroupBox10.Controls.Add(Me.Label33)
            Me.GroupBox10.Controls.Add(Me.ComboBox_nodes)
            Me.GroupBox10.Controls.Add(Me.Label32)
            Me.GroupBox10.Location = New System.Drawing.Point(20, 160)
            Me.GroupBox10.Name = "GroupBox10"
            Me.GroupBox10.Size = New System.Drawing.Size(296, 92)
            Me.GroupBox10.TabIndex = 13
            Me.GroupBox10.TabStop = False
            Me.GroupBox10.Text = "Nodal Specification"
            '
            'ComboBox_pattern
            '
            Me.ComboBox_pattern.Items.AddRange(New Object() {"Automatic"})
            Me.ComboBox_pattern.Location = New System.Drawing.Point(184, 52)
            Me.ComboBox_pattern.Name = "ComboBox_pattern"
            Me.ComboBox_pattern.Size = New System.Drawing.Size(92, 28)
            Me.ComboBox_pattern.TabIndex = 14
            Me.ComboBox_pattern.Text = "Automatic"
            '
            'Label33
            '
            Me.Label33.Location = New System.Drawing.Point(15, 56)
            Me.Label33.Name = "Label33"
            Me.Label33.Size = New System.Drawing.Size(74, 24)
            Me.Label33.TabIndex = 13
            Me.Label33.Text = "Pattern:"
            '
            'ComboBox_nodes
            '
            Me.ComboBox_nodes.Items.AddRange(New Object() {"4", "8", "9", "16"})
            Me.ComboBox_nodes.Location = New System.Drawing.Point(184, 24)
            Me.ComboBox_nodes.Name = "ComboBox_nodes"
            Me.ComboBox_nodes.Size = New System.Drawing.Size(92, 28)
            Me.ComboBox_nodes.TabIndex = 12
            Me.ComboBox_nodes.Text = "9"
            '
            'Label32
            '
            Me.Label32.Location = New System.Drawing.Point(12, 24)
            Me.Label32.Name = "Label32"
            Me.Label32.Size = New System.Drawing.Size(140, 28)
            Me.Label32.TabIndex = 11
            Me.Label32.Text = "Nodes per Element:"
            '
            'GroupBox_mesh_algo
            '
            Me.GroupBox_mesh_algo.Controls.Add(Me.RadioButton_free02)
            Me.GroupBox_mesh_algo.Controls.Add(Me.RadioButton_free01)
            Me.GroupBox_mesh_algo.Enabled = False
            Me.GroupBox_mesh_algo.Location = New System.Drawing.Point(304, 55)
            Me.GroupBox_mesh_algo.Name = "GroupBox_mesh_algo"
            Me.GroupBox_mesh_algo.Size = New System.Drawing.Size(273, 92)
            Me.GroupBox_mesh_algo.TabIndex = 12
            Me.GroupBox_mesh_algo.TabStop = False
            Me.GroupBox_mesh_algo.Text = "Free Mesh Algorithm"
            '
            'RadioButton_free02
            '
            Me.RadioButton_free02.Location = New System.Drawing.Point(17, 52)
            Me.RadioButton_free02.Name = "RadioButton_free02"
            Me.RadioButton_free02.Size = New System.Drawing.Size(128, 28)
            Me.RadioButton_free02.TabIndex = 1
            Me.RadioButton_free02.Text = "Delaunay"
            '
            'RadioButton_free01
            '
            Me.RadioButton_free01.Checked = True
            Me.RadioButton_free01.Location = New System.Drawing.Point(17, 24)
            Me.RadioButton_free01.Name = "RadioButton_free01"
            Me.RadioButton_free01.Size = New System.Drawing.Size(128, 28)
            Me.RadioButton_free01.TabIndex = 0
            Me.RadioButton_free01.TabStop = True
            Me.RadioButton_free01.Text = "Advancing Front"
            '
            'GroupBox_mesh_type
            '
            Me.GroupBox_mesh_type.Controls.Add(Me.RadioButton_mesh_type02)
            Me.GroupBox_mesh_type.Controls.Add(Me.RadioButton_mesh_type01)
            Me.GroupBox_mesh_type.Location = New System.Drawing.Point(16, 55)
            Me.GroupBox_mesh_type.Name = "GroupBox_mesh_type"
            Me.GroupBox_mesh_type.Size = New System.Drawing.Size(208, 92)
            Me.GroupBox_mesh_type.TabIndex = 11
            Me.GroupBox_mesh_type.TabStop = False
            Me.GroupBox_mesh_type.Text = "Mesh generation type"
            '
            'RadioButton_mesh_type02
            '
            Me.RadioButton_mesh_type02.Location = New System.Drawing.Point(12, 52)
            Me.RadioButton_mesh_type02.Name = "RadioButton_mesh_type02"
            Me.RadioButton_mesh_type02.Size = New System.Drawing.Size(128, 28)
            Me.RadioButton_mesh_type02.TabIndex = 1
            Me.RadioButton_mesh_type02.Text = "Free-Form"
            '
            'RadioButton_mesh_type01
            '
            Me.RadioButton_mesh_type01.Checked = True
            Me.RadioButton_mesh_type01.Location = New System.Drawing.Point(12, 24)
            Me.RadioButton_mesh_type01.Name = "RadioButton_mesh_type01"
            Me.RadioButton_mesh_type01.Size = New System.Drawing.Size(128, 28)
            Me.RadioButton_mesh_type01.TabIndex = 0
            Me.RadioButton_mesh_type01.TabStop = True
            Me.RadioButton_mesh_type01.Text = "Rule-Based"
            '
            'Label31
            '
            Me.Label31.Location = New System.Drawing.Point(4, 24)
            Me.Label31.Name = "Label31"
            Me.Label31.Size = New System.Drawing.Size(68, 28)
            Me.Label31.TabIndex = 10
            Me.Label31.Text = "Type:"
            '
            'ComboBox_type
            '
            Me.ComboBox_type.Enabled = False
            Me.ComboBox_type.Items.AddRange(New Object() {"2-D solid", "Shell", "Plate", "2-D Fluid", "3-D Fluid Interface", "General"})
            Me.ComboBox_type.Location = New System.Drawing.Point(77, 24)
            Me.ComboBox_type.Name = "ComboBox_type"
            Me.ComboBox_type.Size = New System.Drawing.Size(168, 28)
            Me.ComboBox_type.TabIndex = 9
            Me.ComboBox_type.Text = "Shell"
            '
            'ComboBox_shape_quaonly
            '
            Me.ComboBox_shape_quaonly.ItemHeight = 20
            Me.ComboBox_shape_quaonly.Items.AddRange(New Object() {"Quad Only"})
            Me.ComboBox_shape_quaonly.Location = New System.Drawing.Point(244, 264)
            Me.ComboBox_shape_quaonly.Name = "ComboBox_shape_quaonly"
            Me.ComboBox_shape_quaonly.Size = New System.Drawing.Size(140, 28)
            Me.ComboBox_shape_quaonly.TabIndex = 23
            Me.ComboBox_shape_quaonly.Text = "Quad Only"
            '
            'ComboBox_shape_qua
            '
            Me.ComboBox_shape_qua.ItemHeight = 20
            Me.ComboBox_shape_qua.Items.AddRange(New Object() {"Quadrilateral"})
            Me.ComboBox_shape_qua.Location = New System.Drawing.Point(244, 264)
            Me.ComboBox_shape_qua.Name = "ComboBox_shape_qua"
            Me.ComboBox_shape_qua.Size = New System.Drawing.Size(140, 28)
            Me.ComboBox_shape_qua.TabIndex = 22
            Me.ComboBox_shape_qua.Text = "Quadrilateral"
            '
            'ComboBox_shape_tri
            '
            Me.ComboBox_shape_tri.ItemHeight = 20
            Me.ComboBox_shape_tri.Items.AddRange(New Object() {"Triangular"})
            Me.ComboBox_shape_tri.Location = New System.Drawing.Point(244, 264)
            Me.ComboBox_shape_tri.Name = "ComboBox_shape_tri"
            Me.ComboBox_shape_tri.Size = New System.Drawing.Size(140, 28)
            Me.ComboBox_shape_tri.TabIndex = 21
            Me.ComboBox_shape_tri.Text = "Triangular"
            '
            'GroupBox_density
            '
            Me.GroupBox_density.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.GroupBox_density.Controls.Add(Me.Label30)
            Me.GroupBox_density.Controls.Add(Me.GroupBox_CBIAS)
            Me.GroupBox_density.Controls.Add(Me.GroupBox_ratio)
            Me.GroupBox_density.Controls.Add(Me.GroupBox_div)
            Me.GroupBox_density.Controls.Add(Me.Label23)
            Me.GroupBox_density.Controls.Add(Me.ComboBox_progress)
            Me.GroupBox_density.Controls.Add(Me.Label21)
            Me.GroupBox_density.Controls.Add(Me.TextBox_edge_length)
            Me.GroupBox_density.Controls.Add(Me.ComboBox_method)
            Me.GroupBox_density.Location = New System.Drawing.Point(12, 8)
            Me.GroupBox_density.Name = "GroupBox_density"
            Me.GroupBox_density.Size = New System.Drawing.Size(878, 248)
            Me.GroupBox_density.TabIndex = 0
            Me.GroupBox_density.TabStop = False
            Me.GroupBox_density.Text = "Mesh density"
            '
            'Label30
            '
            Me.Label30.Location = New System.Drawing.Point(12, 28)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(152, 20)
            Me.Label30.TabIndex = 8
            Me.Label30.Text = "Method:"
            '
            'GroupBox_CBIAS
            '
            Me.GroupBox_CBIAS.Controls.Add(Me.CheckBox_CBIAS1)
            Me.GroupBox_CBIAS.Controls.Add(Me.CheckBox_CBIAS2)
            Me.GroupBox_CBIAS.Location = New System.Drawing.Point(16, 182)
            Me.GroupBox_CBIAS.Name = "GroupBox_CBIAS"
            Me.GroupBox_CBIAS.Size = New System.Drawing.Size(260, 52)
            Me.GroupBox_CBIAS.TabIndex = 7
            Me.GroupBox_CBIAS.TabStop = False
            Me.GroupBox_CBIAS.Text = "Use Central Biasing for"
            '
            'CheckBox_CBIAS1
            '
            Me.CheckBox_CBIAS1.Location = New System.Drawing.Point(8, 20)
            Me.CheckBox_CBIAS1.Name = "CheckBox_CBIAS1"
            Me.CheckBox_CBIAS1.Size = New System.Drawing.Size(116, 24)
            Me.CheckBox_CBIAS1.TabIndex = 11
            Me.CheckBox_CBIAS1.Text = "u Direction"
            '
            'CheckBox_CBIAS2
            '
            Me.CheckBox_CBIAS2.Location = New System.Drawing.Point(137, 17)
            Me.CheckBox_CBIAS2.Name = "CheckBox_CBIAS2"
            Me.CheckBox_CBIAS2.Size = New System.Drawing.Size(96, 25)
            Me.CheckBox_CBIAS2.TabIndex = 10
            Me.CheckBox_CBIAS2.Text = "v Direction"
            '
            'GroupBox_ratio
            '
            Me.GroupBox_ratio.Controls.Add(Me.TextBox_ratio_v)
            Me.GroupBox_ratio.Controls.Add(Me.Label26)
            Me.GroupBox_ratio.Controls.Add(Me.TextBox_ratio_u)
            Me.GroupBox_ratio.Controls.Add(Me.Label27)
            Me.GroupBox_ratio.Location = New System.Drawing.Point(356, 101)
            Me.GroupBox_ratio.Name = "GroupBox_ratio"
            Me.GroupBox_ratio.Size = New System.Drawing.Size(260, 68)
            Me.GroupBox_ratio.TabIndex = 6
            Me.GroupBox_ratio.TabStop = False
            Me.GroupBox_ratio.Text = "Length Ratio of Element Edges"
            '
            'TextBox_ratio_v
            '
            Me.TextBox_ratio_v.Location = New System.Drawing.Point(188, 24)
            Me.TextBox_ratio_v.Name = "TextBox_ratio_v"
            Me.TextBox_ratio_v.Size = New System.Drawing.Size(56, 27)
            Me.TextBox_ratio_v.TabIndex = 12
            Me.TextBox_ratio_v.Text = "1"
            Me.TextBox_ratio_v.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label26
            '
            Me.Label26.Location = New System.Drawing.Point(140, 24)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(36, 28)
            Me.Label26.TabIndex = 11
            Me.Label26.Text = "v:"
            Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'TextBox_ratio_u
            '
            Me.TextBox_ratio_u.Location = New System.Drawing.Point(54, 24)
            Me.TextBox_ratio_u.Name = "TextBox_ratio_u"
            Me.TextBox_ratio_u.Size = New System.Drawing.Size(56, 27)
            Me.TextBox_ratio_u.TabIndex = 10
            Me.TextBox_ratio_u.Text = "1"
            Me.TextBox_ratio_u.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label27
            '
            Me.Label27.Location = New System.Drawing.Point(8, 24)
            Me.Label27.Name = "Label27"
            Me.Label27.Size = New System.Drawing.Size(36, 28)
            Me.Label27.TabIndex = 9
            Me.Label27.Text = "u:"
            Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'GroupBox_div
            '
            Me.GroupBox_div.Controls.Add(Me.TextBox_div_v)
            Me.GroupBox_div.Controls.Add(Me.Label25)
            Me.GroupBox_div.Controls.Add(Me.TextBox_div_u)
            Me.GroupBox_div.Controls.Add(Me.Label24)
            Me.GroupBox_div.Location = New System.Drawing.Point(16, 103)
            Me.GroupBox_div.Name = "GroupBox_div"
            Me.GroupBox_div.Size = New System.Drawing.Size(257, 68)
            Me.GroupBox_div.TabIndex = 5
            Me.GroupBox_div.TabStop = False
            Me.GroupBox_div.Text = "Number of subdivisions"
            '
            'TextBox_div_v
            '
            Me.TextBox_div_v.Location = New System.Drawing.Point(188, 24)
            Me.TextBox_div_v.Name = "TextBox_div_v"
            Me.TextBox_div_v.Size = New System.Drawing.Size(56, 27)
            Me.TextBox_div_v.TabIndex = 8
            Me.TextBox_div_v.Text = "10"
            Me.TextBox_div_v.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label25
            '
            Me.Label25.Location = New System.Drawing.Point(140, 24)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(36, 28)
            Me.Label25.TabIndex = 7
            Me.Label25.Text = "v:"
            Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'TextBox_div_u
            '
            Me.TextBox_div_u.Location = New System.Drawing.Point(54, 24)
            Me.TextBox_div_u.Name = "TextBox_div_u"
            Me.TextBox_div_u.Size = New System.Drawing.Size(56, 27)
            Me.TextBox_div_u.TabIndex = 6
            Me.TextBox_div_u.Text = "10"
            Me.TextBox_div_u.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label24
            '
            Me.Label24.Location = New System.Drawing.Point(8, 24)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(36, 28)
            Me.Label24.TabIndex = 5
            Me.Label24.Text = "u:"
            Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label23
            '
            Me.Label23.Location = New System.Drawing.Point(12, 61)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(236, 20)
            Me.Label23.TabIndex = 4
            Me.Label23.Text = "Progression of Element Edge Lengths:"
            '
            'ComboBox_progress
            '
            Me.ComboBox_progress.Items.AddRange(New Object() {"Arithmetic", "Geometric"})
            Me.ComboBox_progress.Location = New System.Drawing.Point(266, 61)
            Me.ComboBox_progress.Name = "ComboBox_progress"
            Me.ComboBox_progress.Size = New System.Drawing.Size(100, 28)
            Me.ComboBox_progress.TabIndex = 3
            Me.ComboBox_progress.Text = "Geometric"
            '
            'Label21
            '
            Me.Label21.Enabled = False
            Me.Label21.Location = New System.Drawing.Point(372, 24)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(155, 60)
            Me.Label21.TabIndex = 2
            Me.Label21.Text = "Maximum Element Edge Length:"
            '
            'TextBox_edge_length
            '
            Me.TextBox_edge_length.Enabled = False
            Me.TextBox_edge_length.Location = New System.Drawing.Point(540, 27)
            Me.TextBox_edge_length.Name = "TextBox_edge_length"
            Me.TextBox_edge_length.Size = New System.Drawing.Size(80, 27)
            Me.TextBox_edge_length.TabIndex = 1
            Me.TextBox_edge_length.Text = "0"
            '
            'ComboBox_method
            '
            Me.ComboBox_method.Items.AddRange(New Object() {"Use End-Point Sizes", "Use Length", "Use Number of Divisions"})
            Me.ComboBox_method.Location = New System.Drawing.Point(168, 24)
            Me.ComboBox_method.Name = "ComboBox_method"
            Me.ComboBox_method.Size = New System.Drawing.Size(200, 28)
            Me.ComboBox_method.TabIndex = 0
            Me.ComboBox_method.Text = "Use Number of Divisions"
            '
            'Button_set_data
            '
            Me.Button_set_data.Location = New System.Drawing.Point(13, 606)
            Me.Button_set_data.Name = "Button_set_data"
            Me.Button_set_data.Size = New System.Drawing.Size(76, 28)
            Me.Button_set_data.TabIndex = 63
            Me.Button_set_data.Text = "Button1"
            Me.Button_set_data.Visible = False
            '
            'ListView_steps
            '
            Me.ListView_steps.AutoArrange = False
            Me.ListView_steps.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ListView_steps.HideSelection = False
            ListViewItem1.StateImageIndex = 0
            ListViewItem2.StateImageIndex = 0
            ListViewItem3.StateImageIndex = 0
            Me.ListView_steps.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3})
            Me.ListView_steps.LargeImageList = Me.ImageList1
            Me.ListView_steps.Location = New System.Drawing.Point(0, 0)
            Me.ListView_steps.MultiSelect = False
            Me.ListView_steps.Name = "ListView_steps"
            Me.ListView_steps.Size = New System.Drawing.Size(195, 740)
            Me.ListView_steps.TabIndex = 64
            Me.ListView_steps.UseCompatibleStateImageBehavior = False
            '
            'ImageList1
            '
            Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.ImageList1.Images.SetKeyName(0, "")
            Me.ImageList1.Images.SetKeyName(1, "")
            Me.ImageList1.Images.SetKeyName(2, "")
            Me.ImageList1.Images.SetKeyName(3, "")
            '
            'Panel_start
            '
            Me.Panel_start.AutoScroll = True
            Me.Panel_start.Controls.Add(Me.Picture_eng_panel0)
            Me.Panel_start.Controls.Add(Me.Picture_heb_panel0)
            Me.Panel_start.Controls.Add(Me.Label_status)
            Me.Panel_start.Controls.Add(Me.Label_disclaimer)
            Me.Panel_start.Controls.Add(Me.Label_affiliated)
            Me.Panel_start.Controls.Add(Me.RichTextBox_welcome)
            Me.Panel_start.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel_start.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
            Me.Panel_start.ForeColor = System.Drawing.Color.Red
            Me.Panel_start.Location = New System.Drawing.Point(0, 0)
            Me.Panel_start.Name = "Panel_start"
            Me.Panel_start.Size = New System.Drawing.Size(907, 740)
            Me.Panel_start.TabIndex = 67
            '
            'Picture_eng_panel0
            '
            Me.Picture_eng_panel0.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Picture_eng_panel0.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Picture_eng_panel0.Image = CType(resources.GetObject("Picture_eng_panel0.Image"), System.Drawing.Image)
            Me.Picture_eng_panel0.Location = New System.Drawing.Point(865, 32)
            Me.Picture_eng_panel0.Name = "Picture_eng_panel0"
            Me.Picture_eng_panel0.Size = New System.Drawing.Size(32, 16)
            Me.Picture_eng_panel0.TabIndex = 52
            Me.Picture_eng_panel0.TabStop = False
            '
            'Picture_heb_panel0
            '
            Me.Picture_heb_panel0.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Picture_heb_panel0.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Picture_heb_panel0.Image = Global.SPE.My.Resources.Resources.flag_hebrew01
            Me.Picture_heb_panel0.Location = New System.Drawing.Point(865, 8)
            Me.Picture_heb_panel0.Name = "Picture_heb_panel0"
            Me.Picture_heb_panel0.Size = New System.Drawing.Size(32, 20)
            Me.Picture_heb_panel0.TabIndex = 51
            Me.Picture_heb_panel0.TabStop = False
            '
            'Label_status
            '
            Me.Label_status.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label_status.Font = New System.Drawing.Font("Segoe UI", 12.0!)
            Me.Label_status.ForeColor = System.Drawing.Color.Black
            Me.Label_status.Location = New System.Drawing.Point(18, 417)
            Me.Label_status.Name = "Label_status"
            Me.Label_status.Size = New System.Drawing.Size(870, 72)
            Me.Label_status.TabIndex = 4
            Me.Label_status.Text = "No model has been entered to ADINA Generator. To create new model select ""First S" &
    "tep -  Model's Geometry"" from the list on the left."
            '
            'Label_disclaimer
            '
            Me.Label_disclaimer.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Label_disclaimer.Font = New System.Drawing.Font("Segoe UI", 12.0!)
            Me.Label_disclaimer.Location = New System.Drawing.Point(0, 616)
            Me.Label_disclaimer.Name = "Label_disclaimer"
            Me.Label_disclaimer.Size = New System.Drawing.Size(907, 64)
            Me.Label_disclaimer.TabIndex = 3
            Me.Label_disclaimer.Text = "Disclaimer: This module is in testing stages. As so, there are no warranties of a" &
    "ny kind. The user should use his own discretion with regard to the results obtai" &
    "ned with this code."
            '
            'Label_affiliated
            '
            Me.Label_affiliated.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Label_affiliated.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.Label_affiliated.ForeColor = System.Drawing.Color.Black
            Me.Label_affiliated.Location = New System.Drawing.Point(0, 680)
            Me.Label_affiliated.Name = "Label_affiliated"
            Me.Label_affiliated.Size = New System.Drawing.Size(907, 60)
            Me.Label_affiliated.TabIndex = 0
            Me.Label_affiliated.Text = """ADINA Generator"" is in no way affiliated with ADINA R & D ,Inc. All ADINA tradem" &
    "arks and copyrights, except ""ADINA Generator"", are the property of their respect" &
    "ive holders."
            Me.Label_affiliated.UseMnemonic = False
            '
            'RichTextBox_welcome
            '
            Me.RichTextBox_welcome.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.RichTextBox_welcome.AutoWordSelection = True
            Me.RichTextBox_welcome.BackColor = System.Drawing.Color.WhiteSmoke
            Me.RichTextBox_welcome.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.RichTextBox_welcome.BulletIndent = 1
            Me.RichTextBox_welcome.Font = New System.Drawing.Font("Segoe UI", 12.0!)
            Me.RichTextBox_welcome.ForeColor = System.Drawing.Color.Navy
            Me.RichTextBox_welcome.Location = New System.Drawing.Point(16, 10)
            Me.RichTextBox_welcome.Name = "RichTextBox_welcome"
            Me.RichTextBox_welcome.ReadOnly = True
            Me.RichTextBox_welcome.ShowSelectionMargin = True
            Me.RichTextBox_welcome.Size = New System.Drawing.Size(843, 389)
            Me.RichTextBox_welcome.TabIndex = 1
            Me.RichTextBox_welcome.Text = resources.GetString("RichTextBox_welcome.Text")
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
            '
            'SplitContainer.Panel2
            '
            Me.SplitContainer.Panel2.Controls.Add(Me.Panel_start)
            Me.SplitContainer.Panel2.Controls.Add(Me.Panel_create_model)
            Me.SplitContainer.Panel2.Controls.Add(Me.Panel_model_geometry)
            Me.SplitContainer.Panel2.Controls.Add(Me.Panel_mesh_properties)
            Me.SplitContainer.Size = New System.Drawing.Size(1106, 740)
            Me.SplitContainer.SplitterDistance = 195
            Me.SplitContainer.TabIndex = 68
            '
            'GUI_ADINA_main
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(7, 20)
            Me.ClientSize = New System.Drawing.Size(1106, 740)
            Me.Controls.Add(Me.SplitContainer)
            Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "GUI_ADINA_main"
            Me.Text = "ADINA Generator: Create FE Model for ADINA 8.1"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.GroupBox_stiffeners.ResumeLayout(False)
            Me.GroupBox_stiffeners.PerformLayout()
            CType(Me.numeric_nb, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numeric_na, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox_stiffeners_Data.ResumeLayout(False)
            Me.GroupBox_stiffeners_Data.PerformLayout()
            Me.Panel_model_geometry.ResumeLayout(False)
            CType(Me.Picture_eng_panel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Picture_heb_panel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupbox_plate_geo.ResumeLayout(False)
            CType(Me.numeric_t, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numeric_b, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numeric_a, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupbox_General.ResumeLayout(False)
            Me.groupbox_General.PerformLayout()
            CType(Me.PictureBox_info, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numeric_case_input, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel_create_model.ResumeLayout(False)
            CType(Me.Picture_eng_panel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Picture_heb_panel3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox_generate.ResumeLayout(False)
            Me.GroupBox_statistics.ResumeLayout(False)
            Me.GroupBox_process.ResumeLayout(False)
            Me.GroupBox_generation.ResumeLayout(False)
            Me.GroupBox_video.ResumeLayout(False)
            CType(Me.PictureBox_video01, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel_mesh_properties.ResumeLayout(False)
            CType(Me.Picture_eng_panel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Picture_heb_panel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox7.ResumeLayout(False)
            Me.GroupBox11.ResumeLayout(False)
            Me.GroupBox10.ResumeLayout(False)
            Me.GroupBox_mesh_algo.ResumeLayout(False)
            Me.GroupBox_mesh_type.ResumeLayout(False)
            Me.GroupBox_density.ResumeLayout(False)
            Me.GroupBox_density.PerformLayout()
            Me.GroupBox_CBIAS.ResumeLayout(False)
            Me.GroupBox_ratio.ResumeLayout(False)
            Me.GroupBox_ratio.PerformLayout()
            Me.GroupBox_div.ResumeLayout(False)
            Me.GroupBox_div.PerformLayout()
            Me.Panel_start.ResumeLayout(False)
            CType(Me.Picture_eng_panel0, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Picture_heb_panel0, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitContainer.Panel1.ResumeLayout(False)
            Me.SplitContainer.Panel2.ResumeLayout(False)
            CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitContainer.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Public model_ok As Boolean = False
        Public mesh_continue As Boolean = True
        Public a, b, Na, Nb, ta, tna, tb, tnb, t, P, Young_modulus, ni, H As Single
        Public C As Byte
        Public jump_x, jump_z, new_value As Single
        Public i, j, count_points, total_points, loc_x, loc_y, loc_z As Single
        Public i_str As String = ""
        Public counts_of_total As Single = 0
        Public new_count As Single = 0
        Public total_points_sub As Single = 0
        Public p1, p2, count_surface As Single
        Public string_holder As String
        Public msgbox_msg As String
        Public msgbox_title As String
        Public msgbox_style As MsgBoxStyle
        Public proceed As Boolean = False
        Public toolTip_info As New ToolTip
        '************* Elements & material properties ***************
        Dim DISPLACE As String = "DEFAULT"
        Dim RINT As String = "DEFAULT"
        Dim SINT As String = "DEFAULT"
        Dim TINT As String = "2"
        Dim RESULTS As String = "STRESSES"
        Dim STRESSRE As String = "GLOBAL"
        Dim PRINTVEC As String = "0"
        Dim NLAYERS As String = "1"
        Dim INITIALS As String = "NONE"
        Dim FAILURE As String = "0"
        Dim SECTION As String = "0"
        Dim CMASS As String = "DEFAULT"
        Dim STRAINS As String = "DEFAULT"
        Dim RUPTURE As String = "ADINA"
        Dim TIMEOFF As String = "0.00000000000000"
        Dim OPTION_STR As String = "NONE"
        Dim DESCRIPT As String = "'NONE'"
        '************* end Elements & material properties ***************
        '************* mesh density properties ***************
        Dim mode, PROGRESS, EXTEND, CBIAS1, CBIAS2 As String
        Dim NDIV1, NDIV2, RATIO1, RATIO2 As Single
        Dim LENGTH_SIZE As Single
        '************* end mesh density properties ***************
        '************* mesh generation properties ***************
        Dim NODES, NCEDGE, NCVERTEX, NCTOLERA As Single
        Dim SUBSTRUC, GROUP As Byte
        Dim PATTERN, FLIP, METHOD, MIDNODES, NCOINCID, PREFSHAP, MESHING, COLLAPSE, SMOOTHIN, DEGENERA As String
        '************* end mesh generation properties ***************
        Public Function GUI_set(ByVal new_lang As String) As Boolean
            language_settings.read_language(new_lang)
            Me.SuspendLayout()
            Me.Text = language_settings.ADINA_text
            Me.RightToLeft = language_settings.language_RTL
            Me.RightToLeftLayout = language_settings.language_RTL_layout
            '****************listview***********************
            ListView_steps.Items(0).Text = language_settings.ADINA_lists_step1
            ListView_steps.Items(1).Text = language_settings.ADINA_lists_step2
            ListView_steps.Items(2).Text = language_settings.ADINA_lists_step3
            ListView_steps.RightToLeftLayout = language_settings.language_RTL_layout
            ListView_steps.RightToLeft = language_settings.language_RTL
            RichTextBox_welcome.RightToLeft = language_settings.language_RTL
            Label_affiliated.RightToLeft = Windows.Forms.RightToLeft.No
            Label_disclaimer.RightToLeft = Windows.Forms.RightToLeft.No
            '************panel0 - welcome gui **************
            RichTextBox_welcome.Text = language_settings.ADINA_RichTextBox_welcome01 + Chr(13) + Chr(13) + _
            language_settings.ADINA_RichTextBox_welcome02 + Chr(13) + Chr(13) + language_settings.ADINA_RichTextBox_welcome03 + Chr(13) + _
            language_settings.ADINA_RichTextBox_welcome04 + Chr(13) + language_settings.ADINA_RichTextBox_welcome05 + Chr(13) + _
            language_settings.ADINA_RichTextBox_welcome06 + Chr(13) + language_settings.ADINA_RichTextBox_welcome07 + Chr(13) + language_settings.ADINA_RichTextBox_welcome08
            If model_ok = True Then
                Label_status.Text = language_settings.ADINA_label_status_OK
            Else
                Label_status.Text = language_settings.ADINA_label_status_not_OK
            End If
            '************panel1 - geometry ****************
            combobox_P_units.Items.Clear()
            combobox_P_units.Items.Insert(0, language_settings.unit_Pa)
            combobox_P_units.Items.Insert(1, language_settings.unit_KPa)
            combobox_P_units.Items.Insert(2, language_settings.unit_MPa)
            combobox_P_units.Text = combobox_P_units.Items(0)
            numeric_input_moment_units.Items.Clear()
            numeric_input_moment_units.Items.Insert(0, language_settings.unit_millimeter4)
            numeric_input_moment_units.Items.Insert(1, language_settings.unit_centimeter4)
            numeric_input_moment_units.Items.Insert(2, language_settings.unit_meter4)
            numeric_input_moment_units.Text = numeric_input_moment_units.Items(2)
            label_a.Text = language_settings.length_a
            label_b.Text = language_settings.breadth_b
            label_t.Text = language_settings.thickness_t
            Label_pressure.Text = language_settings.input_panel4_Label_pressure
            Label_E.Text = language_settings.input_panel4_Label_modulus
            label_ni.Text = language_settings.input_panel4_label_ni
            Label_BC.Text = language_settings.input_panel4_label_BC_title
            Label_GPa.Text = language_settings.unit_GPa
            GroupBox_stiffeners_Data.Text = language_settings.results_panel1_GroupBox_stiffeners_data_moment
            Label_units.Text = language_settings.results_panel1_label_data_unit
            label_unit_m01.Text = language_settings.unit_meter
            label_unit_m02.Text = language_settings.unit_meter
            label_unit_mm01.Text = language_settings.unit_millimeter
            label_unit_mm02.Text = language_settings.unit_millimeter
            label_unit_mm03.Text = language_settings.unit_millimeter
            label_unit_mm04.Text = language_settings.unit_millimeter
            label_unit_mm05.Text = language_settings.unit_millimeter
            label_unit_mm06.Text = language_settings.unit_millimeter
            groupbox_plate_geo.Text = language_settings.results_panel1_groupbox_plate
            groupbox_General.Text = language_settings.results_panel1_groupbox_general
            GroupBox_stiffeners.Text = language_settings.results_panel1_GroupBox_stiffeners
            label_Na.Text = language_settings.results_panel1_label_Na
            label_Nb.Text = language_settings.results_panel1_label_Nb
            Label_H.Text = language_settings.ADINA_Label_H
            Label_thickness.Text = language_settings.ADINA_Label_thickness
            Label_longitudinals.Text = language_settings.results_panel1_label_longitudinals
            Label_data_longitudinals.Text = language_settings.results_panel1_label_longitudinals
            Label_transverses.Text = language_settings.results_panel1_label_transverses
            Label_data_transverses.Text = language_settings.results_panel1_label_transverses
            Label_central01.Text = language_settings.results_panel1_label_central
            Label_central02.Text = language_settings.results_panel1_label_central
            Label_central03.Text = language_settings.results_panel1_label_central
            Label_central04.Text = language_settings.results_panel1_label_central
            Label_non_central01.Text = language_settings.results_panel1_label_noncentral
            Label_non_central02.Text = language_settings.results_panel1_label_noncentral
            Label_non_central03.Text = language_settings.results_panel1_label_noncentral
            Label_non_central04.Text = language_settings.results_panel1_label_noncentral
            numeric_input_moment_units.RightToLeft = language_settings.language_RTL
            label_a.RightToLeft = language_settings.language_RTL
            label_b.RightToLeft = language_settings.language_RTL
            label_t.RightToLeft = language_settings.language_RTL
            Label_pressure.RightToLeft = language_settings.language_RTL
            Label_E.RightToLeft = language_settings.language_RTL
            label_ni.RightToLeft = language_settings.language_RTL
            Label_BC.RightToLeft = language_settings.language_RTL
            Label_GPa.RightToLeft = language_settings.language_RTL
            GroupBox_stiffeners_Data.RightToLeft = language_settings.language_RTL
            Label_units.RightToLeft = language_settings.language_RTL
            label_unit_m01.RightToLeft = language_settings.language_RTL
            label_unit_m02.RightToLeft = language_settings.language_RTL
            label_unit_mm01.RightToLeft = language_settings.language_RTL
            label_unit_mm02.RightToLeft = language_settings.language_RTL
            label_unit_mm03.RightToLeft = language_settings.language_RTL
            label_unit_mm04.RightToLeft = language_settings.language_RTL
            label_unit_mm05.RightToLeft = language_settings.language_RTL
            label_unit_mm06.RightToLeft = language_settings.language_RTL
            groupbox_plate_geo.RightToLeft = language_settings.language_RTL
            groupbox_General.RightToLeft = language_settings.language_RTL
            GroupBox_stiffeners.RightToLeft = language_settings.language_RTL
            label_Na.RightToLeft = language_settings.language_RTL
            label_Nb.RightToLeft = language_settings.language_RTL
            Label_H.RightToLeft = language_settings.language_RTL
            Label_thickness.RightToLeft = language_settings.language_RTL
            Label_longitudinals.RightToLeft = language_settings.language_RTL
            Label_data_longitudinals.RightToLeft = language_settings.language_RTL
            Label_transverses.RightToLeft = language_settings.language_RTL
            Label_data_transverses.RightToLeft = language_settings.language_RTL
            Label_central01.RightToLeft = language_settings.language_RTL
            Label_central02.RightToLeft = language_settings.language_RTL
            Label_central03.RightToLeft = language_settings.language_RTL
            Label_central04.RightToLeft = language_settings.language_RTL
            Label_non_central01.RightToLeft = language_settings.language_RTL
            Label_non_central02.RightToLeft = language_settings.language_RTL
            Label_non_central03.RightToLeft = language_settings.language_RTL
            Label_non_central04.RightToLeft = language_settings.language_RTL
            '************panel3 ****************
            Panel_create_model.RightToLeft = Windows.Forms.RightToLeft.No 'language_settings.language_RTL
            RichTextBox_video.RightToLeft = language_settings.language_RTL
            RichTextBox_video.Text = language_settings.ADINA_RichTextBox_video01 + Chr(13) + _
            language_settings.ADINA_RichTextBox_video02 + Chr(13) + language_settings.ADINA_RichTextBox_video03 + Chr(13) + _
            language_settings.ADINA_RichTextBox_video04 + Chr(13) + language_settings.ADINA_RichTextBox_video05 + Chr(13) + _
            language_settings.ADINA_RichTextBox_video06 + Chr(13) + language_settings.ADINA_RichTextBox_video07 + Chr(13) + Chr(13) + _
            language_settings.ADINA_RichTextBox_video09
            '********* layouts *****************
            If language_settings.language_RTL_layout = True Then
                '*********PANEL1 **********************
                Picture_heb_panel1.Location = New Point(10, 8)
                Picture_eng_panel1.Location = New Point(10, 32)
                groupbox_plate_geo.Location = New Point(Panel_model_geometry.Width - 10 - groupbox_plate_geo.Width, 24)
                groupbox_General.Location = New Point(Panel_model_geometry.Width - 20 - groupbox_plate_geo.Width - groupbox_General.Width, 24)
                GroupBox_stiffeners.Location = New Point(Panel_model_geometry.Width - 10 - GroupBox_stiffeners.Width, 216)
                GroupBox_stiffeners_Data.Location = New Point(Panel_model_geometry.Width - 20 - GroupBox_stiffeners.Width - GroupBox_stiffeners_Data.Width, 216)
                label_a.Location = New Point(182, 36)
                label_b.Location = New Point(182, 80)
                label_t.Location = New Point(182, 118)
                numeric_a.Location = New Point(104, 36)
                numeric_b.Location = New Point(104, 80)
                numeric_t.Location = New Point(104, 118)
                label_unit_m01.Location = New Point(10, 36)
                label_unit_m02.Location = New Point(10, 80)
                label_unit_mm01.Location = New Point(10, 118)
                Label_pressure.Location = New Point(134, 30)
                textbox_P_input.Location = New Point(76, 40)
                combobox_P_units.Location = New Point(6, 40)
                Label_E.Location = New Point(134, 80)
                textbox_E_input.Location = New Point(76, 80)
                Label_GPa.Location = New Point(12, 80)
                label_ni.Location = New Point(134, 110)
                textbox_ni_input.Location = New Point(76, 110)
                Label_BC.Location = New Point(134, 140)
                numeric_case_input.Location = New Point(76, 140)
                label_Na.Location = New Point(77, 32)
                numeric_na.Location = New Point(8, 32)
                label_Nb.Location = New Point(77, 68)
                numeric_nb.Location = New Point(8, 68)
                Label_H.Location = New Point(137, 104)
                Textbox_H_general.Location = New Point(83, 104)
                label_unit_mm02.Location = New Point(9, 104)
                Label_central01.Location = New Point(183, 212)
                Textbox_Ta.Location = New Point(107, 212)
                label_unit_mm03.Location = New Point(10, 212)
                Label_non_central01.Location = New Point(183, 248)
                Textbox_Tna.Location = New Point(107, 248)
                label_unit_mm04.Location = New Point(10, 248)
                Label_central02.Location = New Point(183, 312)
                Textbox_Tb.Location = New Point(107, 312)
                label_unit_mm05.Location = New Point(10, 312)
                Label_non_central02.Location = New Point(183, 344)
                Textbox_Tnb.Location = New Point(107, 344)
                label_unit_mm06.Location = New Point(10, 344)
                Label_units.Location = New Point(90, 30)
                numeric_input_moment_units.Location = New Point(12, 30)
                Label_central03.Location = New Point(126, 96)
                Textbox_Ia.Location = New Point(12, 96)
                Label_non_central03.Location = New Point(126, 132)
                Textbox_Ina.Location = New Point(12, 132)
                Label_central04.Location = New Point(126, 196)
                Textbox_Ib.Location = New Point(12, 196)
                Label_non_central04.Location = New Point(126, 228)
                Textbox_Inb.Location = New Point(12, 228)
                '***************PANEL2 **********************
            Else
                '***************PANEL1 **********************
                Picture_heb_panel1.Location = New Point(Panel_model_geometry.Width - Picture_heb_panel1.Width - 10, 8)
                Picture_eng_panel1.Location = New Point(Panel_model_geometry.Width - Picture_heb_panel1.Width - 10, 32)
                groupbox_plate_geo.Location = New Point(8, 24)
                groupbox_General.Location = New Point(344, 24)
                GroupBox_stiffeners.Location = New Point(8, 216)
                GroupBox_stiffeners_Data.Location = New Point(344, 216)
                label_a.Location = New Point(10, 36)
                label_b.Location = New Point(10, 80)
                label_t.Location = New Point(10, 118)
                numeric_a.Location = New Point(159, 36)
                numeric_b.Location = New Point(159, 80)
                numeric_t.Location = New Point(159, 118)
                label_unit_m01.Location = New Point(229, 36)
                label_unit_m02.Location = New Point(229, 80)
                label_unit_mm01.Location = New Point(229, 118)
                Label_pressure.Location = New Point(12, 30)
                textbox_P_input.Location = New Point(178, 40)
                combobox_P_units.Location = New Point(234, 40)
                Label_E.Location = New Point(8, 80)
                textbox_E_input.Location = New Point(178, 80)
                Label_GPa.Location = New Point(238, 80)
                label_ni.Location = New Point(8, 110)
                textbox_ni_input.Location = New Point(178, 110)
                Label_BC.Location = New Point(8, 140)
                numeric_case_input.Location = New Point(178, 140)
                label_Na.Location = New Point(4, 32)
                numeric_na.Location = New Point(236, 32)
                label_Nb.Location = New Point(4, 68)
                numeric_nb.Location = New Point(236, 68)
                Label_H.Location = New Point(4, 104)
                Textbox_H_general.Location = New Point(192, 104)
                label_unit_mm02.Location = New Point(248, 104)
                Label_central01.Location = New Point(8, 212)
                Textbox_Ta.Location = New Point(148, 212)
                label_unit_mm03.Location = New Point(228, 212)
                Label_non_central01.Location = New Point(8, 248)
                Textbox_Tna.Location = New Point(148, 248)
                label_unit_mm04.Location = New Point(228, 248)
                Label_central02.Location = New Point(8, 312)
                Textbox_Tb.Location = New Point(148, 312)
                label_unit_mm05.Location = New Point(228, 312)
                Label_non_central02.Location = New Point(8, 344)
                Textbox_Tnb.Location = New Point(148, 344)
                label_unit_mm06.Location = New Point(228, 344)
                Label_units.Location = New Point(8, 30)
                numeric_input_moment_units.Location = New Point(220, 30)
                Label_central03.Location = New Point(12, 96)
                Textbox_Ia.Location = New Point(188, 96)
                Label_non_central03.Location = New Point(12, 132)
                Textbox_Ina.Location = New Point(188, 132)
                Label_central04.Location = New Point(12, 196)
                Textbox_Ib.Location = New Point(188, 196)
                Label_non_central04.Location = New Point(12, 228)
                Textbox_Inb.Location = New Point(188, 228)
                '***************PANEL2 **********************
            End If
            Me.ResumeLayout()
        End Function
        Function BC_info() As Boolean
            toolTip_info.RemoveAll()
            Dim msg00, msg01, msg02, msg03, msg04 As String
            If general_settings.controls_Library.current_lang = "english" Then
                msg00 = "Incorrect number selected for BC case"
                msg01 = "All four edges are Simply Supported which" + Chr(13) + "allows rotational degrees of freedom only"
                msg02 = "The short edges are fixed/clamped which eliminates all DOF," + Chr(13) + "long edges are Simply Supported which allows rotational degrees of freedom only"
                msg03 = "The long edges are fixed/clamped which eliminates all DOF," + Chr(13) + "short edges are Simply Supported which allows rotational degrees of freedom only"
                msg04 = "All four edges are fixed/clamped which eliminates all DOF"
            Else
                msg00 = "מספר שגוי נבחר עבור סוג תנאי שפה"
                msg01 = "כל ארבעת קצוות הפלטה נתמכות ע""י " + Chr(13) + "תמיכות Simply Supported המאפשרות" + Chr(13) + " דרגות חופש סיבוביות בלבד"
                msg02 = "הקצוות הקצרים של הפלטה מקובעים, " + Chr(13) + "הקצוות הארוכים בעלי תמיכות " + Chr(13) + "Simply Supported המאפשרות " + Chr(13) + "דרגות חופש סיבוביות בלבד"
                msg03 = "הקצוות הארוכים של הפלטה מקובעים, " + Chr(13) + "הקצוות הקצרים בעלי תמיכות " + Chr(13) + "Simply Supported המאפשרות " + Chr(13) + "דרגות חופש סיבוביות בלבד"
                msg04 = "כל ארבעת קצוות הפלטה מקובעים ללא אפשרות תזוזה או סיבוב"
            End If
            ' Set up the delays for the ToolTip.
            toolTip_info.AutoPopDelay = 5000
            toolTip_info.InitialDelay = 100
            toolTip_info.ReshowDelay = 0
            ' Force the ToolTip text to be displayed whether or not the form is active.
            toolTip_info.ShowAlways = True
            ' Set up the ToolTip text for the Button and Checkbox.
            If Me.numeric_case_input.Value = 1 Then
                toolTip_info.SetToolTip(Me.PictureBox_info, msg01)
            ElseIf Me.numeric_case_input.Value = 2 Then
                toolTip_info.SetToolTip(Me.PictureBox_info, msg02)
            ElseIf Me.numeric_case_input.Value = 3 Then
                toolTip_info.SetToolTip(Me.PictureBox_info, msg03)
            ElseIf Me.numeric_case_input.Value = 4 Then
                toolTip_info.SetToolTip(Me.PictureBox_info, msg04)
            Else

            End If
        End Function
        Function hide_panels() As Boolean
            Panel_model_geometry.Visible = False
            Panel_start.Visible = False
            Panel_create_model.Visible = False
            Panel_mesh_properties.Visible = False
        End Function
        Function check_data(ByVal number As String) As Boolean
            If (IsNumeric(number) = True) AndAlso (number > 0) Then
                check_data = True
            Else
                check_data = False
            End If
        End Function
        Function msg_texts(ByVal msg_index As Byte) As String
            Select Case msg_index
                Case "1"
                    msg_texts = "The entered data must be numeric values greater than zero"
                Case "2"
            End Select
            Return True
        End Function
        Function moment(ByVal t As Single, ByVal h As Single) As Single
            moment = t * h ^ 3 / 12
        End Function
        Public Sub Button_gen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_gen.Click
            '************************DENSITY SECTION **********************
            mesh_continue = True
            If ComboBox_method.Text = "Use Number of Divisions" Then
                mode = "DIVISIONS"
            ElseIf ComboBox_method.Text = "Use End-Point Sizes" Then
                mode = "POINTWISE"
            ElseIf ComboBox_method.Text = "Use Length" Then
                mode = "LENGTH"
            Else
                mesh_continue = False
            End If
            '************** DIVISONS METHODD: SETTING BIAS *******************
            If CheckBox_CBIAS1.Checked = True Then
                CBIAS1 = "YES"
            Else
                CBIAS1 = "NO"
            End If
            If CheckBox_CBIAS2.Checked = True Then
                CBIAS2 = "YES"
            Else
                CBIAS2 = "NO"
            End If
            '************** DIVISONS METHODD: END SETTING BIAS *******************
            '************** DIVISONS and ENDPOINT METHODDS: SETTING Progress *******************
            If ComboBox_progress.SelectedItem = "Geometric" Then
                PROGRESS = "GEOMETRIC"
            ElseIf ComboBox_progress.SelectedItem = "Arithmetic" Then
                PROGRESS = "ARITHMETIC"
            Else
                mesh_continue = False
            End If
            '************** DIVISONS METHODD: END SETTING Progress *******************
            '************** DIVISONS METHODD: SETTING DIVISIONS *******************
            If (check_data(TextBox_div_u.Text) = True) And (check_data(TextBox_div_v.Text) = True) Then
                NDIV1 = TextBox_div_u.Text
                NDIV2 = TextBox_div_v.Text
            Else
                mesh_continue = False
            End If
            '************** DIVISONS METHODD: END SETTING DIVISIONS *******************
            '************** DIVISONS METHODD: SETTING RATIO *******************
            If (check_data(TextBox_ratio_u.Text) = True) And (check_data(TextBox_ratio_v.Text) = True) Then
                RATIO1 = TextBox_ratio_u.Text
                RATIO2 = TextBox_ratio_v.Text
            Else
                mesh_continue = False
            End If
            '************** DIVISONS METHODD: END SETTING RATIO *******************
            '************** LENGTH AND ENDPOINT METHODDS:  SETTING Length *******************
            If (TextBox_edge_length.Enabled = True) Then
                If (check_data(TextBox_edge_length.Text) = True) Then
                    LENGTH_SIZE = TextBox_edge_length.Text
                Else
                    mesh_continue = False
                End If
            End If
            '**************END DENSITY ******************
            '**************START MESH ******************
            '**************CONTROL 01 : NODES COUNT ******************
            If (ComboBox_nodes.Text = "4") Or (ComboBox_nodes.Text = "8") Or (ComboBox_nodes.Text = "9") Or (ComboBox_nodes.Text = "16") Then
                NODES = ComboBox_nodes.Text
            Else
                mesh_continue = False
            End If
            '**************CONTROL 02+03+04 : MESH TYPE AND FREE MESH BOX and shape******************
            If RadioButton_mesh_type01.Checked = True Then
                MESHING = "MAPPED"
                METHOD = "ADVFRONT"
                If (ComboBox_shape_all.Text = "Automatic") Then
                    PREFSHAP = "AUTOMATIC"
                ElseIf (ComboBox_shape_all.Text = "Triangular") Then
                    PREFSHAP = "TRIANGULAR"
                ElseIf (ComboBox_shape_all.Text = "Quadrilateral") Then
                    PREFSHAP = "QUADRILATERAL"
                Else
                    mesh_continue = False
                End If
            ElseIf RadioButton_mesh_type02.Checked = True Then
                MESHING = "FREE-FORM"
                If ComboBox_shape_quaonly.Visible = True Then
                    PREFSHAP = "QUAD-DIRECT"
                ElseIf ComboBox_shape_qua.Visible = True Then
                    PREFSHAP = "QUADRILATERAL"
                ElseIf ComboBox_shape_tri.Visible = True Then
                    PREFSHAP = "TRIANGULAR"
                End If
                If RadioButton_free01.Checked = True Then
                    METHOD = "ADVFRONT"
                ElseIf RadioButton_free02.Checked = True Then
                    METHOD = "DELAUNAY"
                Else
                    mesh_continue = False
                End If
            Else
                mesh_continue = False
            End If
            '**************CONTROL 05 : Flip normal ******************
            If CheckBox_flip.Checked = True Then
                FLIP = "YES"
            Else
                FLIP = "NO"
            End If
            '**************CONTROL 06 : MIDSIDE ******************
            If RadioButton_mid01.Checked = True Then
                MIDNODES = "CURVED"
            Else
                MIDNODES = "STRAIGHT"
            End If
            '**************CONTROL 07 : DEGENERATED ******************
            If CheckBox_degenenrate.Checked = True Then
                DEGENERA = "YES"
            Else
                DEGENERA = "NO"
            End If
            '******************* END MESH SECTION ********************
            '******************* Geometry SECTION ********************
            proceed = True
            If (check_data(numeric_a.Value) = True) AndAlso (check_data(numeric_b.Value) = True) AndAlso (check_data(numeric_t.Value) = True) AndAlso (check_data(textbox_P_input.Text) = True) AndAlso (check_data(textbox_E_input.Text) = True) AndAlso (check_data(textbox_ni_input.Text) = True) Then
                Young_modulus = textbox_E_input.Text * 10 ^ 9
                a = numeric_a.Value
                b = numeric_b.Value
                t = numeric_t.Value
                ni = textbox_ni_input.Text
                If (numeric_case_input.Value = 1) Or (numeric_case_input.Value = 2) Or (numeric_case_input.Value = 3) Or (numeric_case_input.Value = 4) Then
                    C = numeric_case_input.Value
                Else
                    C = 0
                    proceed = False
                End If
                If combobox_P_units.Text = language_settings.unit_Pa Then
                    P = textbox_P_input.Text
                ElseIf combobox_P_units.Text = language_settings.unit_KPa Then
                    P = textbox_P_input.Text * 10 ^ 3
                ElseIf combobox_P_units.Text = language_settings.unit_MPa Then
                    P = textbox_P_input.Text * 10 ^ 6
                Else
                    P = 0
                    proceed = False
                End If
                string_holder = ""
                CheckBox_macro.Enabled = False
                CheckBox_macro.Checked = False
                RichTextBox_macro.Visible = False
                Button_save_macro.Visible = False
            Else
                msgbox_style = MsgBoxStyle.Exclamation
                msgbox_title = "Incorrect Data (Physical Properties)"
                msgbox_msg = CStr(msg_texts("1"))
                MsgBox(msgbox_msg, msgbox_style, msgbox_title)
                proceed = False
            End If

            msgbox_title = "Incorrect Data (Stiffeners Properties)"
            msgbox_msg = CStr(msg_texts("1"))
            msgbox_style = MsgBoxStyle.Exclamation
            If (check_data(Textbox_H_general.Text) = False) Or (check_data(Textbox_Ta.Text) = False) Or (check_data(Textbox_Tna.Text) = False) Or (check_data(Textbox_Tb.Text) = False) Or (check_data(Textbox_Tnb.Text) = False) Then
                MsgBox(msgbox_msg, msgbox_style, msgbox_title)
                proceed = False
            Else
                H = Textbox_H_general.Text
                ta = Textbox_Ta.Text
                tna = Textbox_Tna.Text
                tb = Textbox_Tb.Text
                tnb = Textbox_Tnb.Text
                Na = numeric_na.Value
                Nb = numeric_nb.Value
            End If
            '******************* END Geometry SECTION ********************
            If proceed = True AndAlso (mesh_continue = True) Then
                generator(a, b, Na, Nb, t)
            Else
                Dim msg As String = ""
                Dim title As String
                Dim style As MsgBoxStyle
                Dim response As MsgBoxResult
                'if lang
                If proceed = False Then
                    msg = "Unable to perform macro generation." + Chr(13) + "The model settings are invalid/Incorrect." + Chr(13) + "Please check the model properties"
                End If
                If mesh_continue = False Then
                    msg += "Unable to perform macro generation." + Chr(13) + "The meshing properties are invalid/Incorrect." + Chr(13) + "Please check the meshing properties"
                End If
                style = MsgBoxStyle.Critical
                title = "Incorrect setttings detected"   ' Define title.
                response = MsgBox(msg, style, title)
            End If
        End Sub
        Public Sub Button_save_macro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_save_macro.Click
            ' Create a SaveFileDialog to request a path and file name to save to.
            CheckBox_macro.Checked = True
            RichTextBox_macro.Visible = True
            Dim saveFile1 As New SaveFileDialog
            ' Initialize the SaveFileDialog to specify the TXT extension for the file.
            saveFile1.DefaultExt = "*.ses"
            saveFile1.Filter = "ADINA-AUI Session Files|*.ses"
            ' Determine if the user selected a file name from the saveFileDialog.
            If (saveFile1.ShowDialog() = System.Windows.Forms.DialogResult.OK) _
                And (saveFile1.FileName.Length) > 0 Then
                ' Save the contents of the RichTextBox into the file.
                RichTextBox_macro.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText)
            End If

        End Sub
        Private Sub CheckBox_macro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox_macro.CheckedChanged
            If CheckBox_macro.Checked = True Then
                RichTextBox_macro.Visible = True
                Button_save_macro.Visible = True
                GroupBox_video.Visible = False
            Else
                RichTextBox_macro.Visible = False
                Button_save_macro.Visible = False
                GroupBox_video.Visible = True
            End If
        End Sub
        Private Sub GUI_ADINA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            GUI_set(language_settings.language_current_file)
        End Sub
        Private Sub ADINA_main_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
            hide_panels()
            GUI_set(language_settings.language_current_file)
            Panel_start.Dock = DockStyle.Fill
            Panel_start.Visible = True
        End Sub
        Private Sub ComboBox_method_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_method.SelectedIndexChanged
            If ComboBox_method.SelectedItem = "Use Number of Divisions" Then
                GroupBox_div.Enabled = True
                GroupBox_ratio.Enabled = True
                GroupBox_CBIAS.Enabled = True
                TextBox_edge_length.Enabled = False
                ComboBox_progress.Enabled = True
            ElseIf ComboBox_method.SelectedItem = "Use End-Point Sizes" Then
                GroupBox_div.Enabled = False
                GroupBox_ratio.Enabled = False
                GroupBox_CBIAS.Enabled = False
                TextBox_edge_length.Enabled = True
                ComboBox_progress.Enabled = True
            Else
                GroupBox_div.Enabled = False
                GroupBox_ratio.Enabled = False
                GroupBox_CBIAS.Enabled = False
                TextBox_edge_length.Enabled = True
                ComboBox_progress.Enabled = False
            End If
        End Sub
        Private Sub RadioButton_mesh_type01_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_mesh_type01.CheckedChanged, RadioButton_mesh_type02.CheckedChanged, RadioButton_free01.CheckedChanged, RadioButton_free02.CheckedChanged, ComboBox_nodes.SelectedIndexChanged
            If RadioButton_mesh_type01.Checked = True Then 'RULED BASED
                GroupBox_mesh_algo.Enabled = False
                Label_shape.Text = "Preferred Cell Shape:"
                ComboBox_shape_quaonly.Visible = False
                ComboBox_shape_all.Visible = True
                ComboBox_shape_tri.Visible = False
                ComboBox_shape_qua.Visible = False
                ComboBox_shape_quaonly.Visible = False
            ElseIf RadioButton_mesh_type02.Checked = True Then
                GroupBox_mesh_algo.Enabled = True
                Label_shape.Text = "Preferred Element Shape:"
                If RadioButton_free01.Checked = True Then
                    If (ComboBox_nodes.Text = 4) Or (ComboBox_nodes.Text = 9) Or (ComboBox_nodes.Text = 16) Then
                        ComboBox_shape_all.Visible = False
                        ComboBox_shape_tri.Visible = True
                        ComboBox_shape_qua.Visible = False
                        ComboBox_shape_quaonly.Visible = False
                    ElseIf ComboBox_nodes.Text = 8 Then
                        ComboBox_shape_all.Visible = False
                        ComboBox_shape_tri.Visible = False
                        ComboBox_shape_qua.Visible = True
                        ComboBox_shape_quaonly.Visible = False
                    Else
                        mesh_continue = False
                    End If
                Else
                    If (ComboBox_nodes.Text = 4) Or (ComboBox_nodes.Text = 9) Or (ComboBox_nodes.Text = 16) Then
                        ComboBox_shape_all.Visible = False
                        ComboBox_shape_tri.Visible = True
                        ComboBox_shape_qua.Visible = False
                        ComboBox_shape_quaonly.Visible = False
                    ElseIf ComboBox_nodes.Text = 8 Then
                        ComboBox_shape_all.Visible = False
                        ComboBox_shape_tri.Visible = False
                        ComboBox_shape_qua.Visible = False
                        ComboBox_shape_quaonly.Visible = True
                    Else
                        mesh_continue = False
                    End If
                End If
            End If
        End Sub
        Private Sub ListView_steps_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView_steps.SelectedIndexChanged
            If Not (ListView_steps.FocusedItem Is Nothing) Then
                hide_panels()
                If ListView_steps.FocusedItem.Text = language_settings.ADINA_lists_step1 Then
                    Panel_model_geometry.Dock = DockStyle.Fill
                    Panel_model_geometry.Visible = True
                ElseIf ListView_steps.FocusedItem.Text = language_settings.ADINA_lists_step2 Then
                    Panel_mesh_properties.Dock = DockStyle.Fill
                    Panel_mesh_properties.Visible = True
                ElseIf ListView_steps.FocusedItem.Text = language_settings.ADINA_lists_step3 Then
                    Panel_create_model.Dock = DockStyle.Fill
                    Panel_create_model.Visible = True
                End If
            Else
            End If
        End Sub
        Private Sub ListView_steps_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView_steps.SizeChanged
            'ImageList1.ImageSize = New Size(ListView_steps.Width, ListView_steps.Width)
        End Sub
        Private Sub CheckBox_gen_geo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox_gen_geo.CheckedChanged
            If CheckBox_gen_geo.Checked = False Then
                Dim msg As String
                Dim title As String
                Dim style As MsgBoxStyle
                Dim response As MsgBoxResult
                'if lang
                msg = "The geometric model generating is essential for creation of the ADINA file." + Chr(13) + "It can't be unchecked"
                style = MsgBoxStyle.Critical
                title = "Unable to proceed"   ' Define title.
                response = MsgBox(msg, style, title)
            End If
            CheckBox_gen_geo.Checked = True
        End Sub
        Private Sub CheckBox_gen_mesh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox_gen_mesh.Click
            If (CheckBox_gen_mesh.Checked = True) And ((CheckBox_gen_load.Checked = False) Or (CheckBox_gen_BC.Checked = False)) Then
                Dim msg As String
                Dim title As String
                Dim style As MsgBoxStyle
                Dim response As MsgBoxResult
                'if lang
                msg = "It is highly recommended to check the BC" + Chr(13) + "and Load options when selecting mesh generation" + Chr(13) + Chr(13) + "Do you want to checked them?"
                style = MsgBoxStyle.YesNo + MsgBoxStyle.Information
                title = "Creation Warning"   ' Define title.
                response = MsgBox(msg, style, title)
                If response = MsgBoxResult.Yes Then
                    CheckBox_gen_load.Checked = True
                    CheckBox_gen_BC.Checked = True
                End If
            End If
        End Sub
        Private Sub CheckBox_gen_mesh_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CheckBox_gen_mesh.KeyPress
            If (CheckBox_gen_mesh.Checked = True) And ((CheckBox_gen_load.Checked = False) Or (CheckBox_gen_BC.Checked = False)) Then
                Dim msg As String
                Dim title As String
                Dim style As MsgBoxStyle
                Dim response As MsgBoxResult
                'if lang
                msg = "It is highly recommended to check the BC" + Chr(13) + "and Load options when selecting mesh generation" + Chr(13) + Chr(13) + "Do you want to checked them?"
                style = MsgBoxStyle.YesNo + MsgBoxStyle.Information
                title = "Creation Warning"   ' Define title.
                response = MsgBox(msg, style, title)
                If response = MsgBoxResult.Yes Then
                    CheckBox_gen_load.Checked = True
                    CheckBox_gen_BC.Checked = True
                End If
            End If
        End Sub
        Private Sub Button_time_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_time.Click
            Dim msg As String
            Dim title As String
            Dim style As MsgBoxStyle
            Dim response As MsgBoxResult
            msg = "Start time: The date and time when the building process began (The string is computer dependent)." + Chr(13) + Chr(13) + _
            "End Time: The date and time when the building process ended (The string is computer dependent)." + Chr(13) + Chr(13) + _
            "Process Time: The building time in milliseconds it took to generate the file. The Process time is " + "not the CPU time devoted to the process but rather the user time. Only if the process uses 100% " + "of the CPU capabilities then the CPU time and the User time are the same."
            style = MsgBoxStyle.Information
            title = "Times explanation"
            response = MsgBox(msg, style, title)
        End Sub
        Private Sub PictureBox_video01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox_video01.Click
            If File.Exists("videos/example1.wmv") = True Then
                System.Diagnostics.Process.Start("videos/example1.wmv")
            Else
                Dim msg As String
                Dim title As String
                Dim style As MsgBoxStyle
                Dim response As MsgBoxResult
                msg = "the file example1.wmv in the videos directory is missing" + Chr(13) + _
                "Unable to open it"
                style = MsgBoxStyle.Information
                title = "File is missing"
                response = MsgBox(msg, style, title)
            End If
        End Sub
        Private Sub Textbox_H_general_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, numeric_input_moment_units.SelectedIndexChanged, Textbox_Tnb.TextChanged, Textbox_Tna.TextChanged, Textbox_Ta.TextChanged, Textbox_Tb.TextChanged, Textbox_H_general.TextChanged
            If IsNumeric(Textbox_H_general.Text) = True Then
                If numeric_input_moment_units.Text = language_settings.unit_millimeter4 Then
                    If IsNumeric(Textbox_Ta.Text) = True Then
                        Textbox_Ia.Text = moment(Textbox_Ta.Text, Textbox_H_general.Text)
                    Else
                        Textbox_Ia.Text = "N/A"
                    End If
                    If IsNumeric(Textbox_Tna.Text) = True Then
                        Textbox_Ina.Text = moment(Textbox_Tna.Text, Textbox_H_general.Text)
                    Else
                        Textbox_Ina.Text = "N/A"
                    End If
                    If IsNumeric(Textbox_Tnb.Text) = True Then
                        Textbox_Inb.Text = moment(Textbox_Tnb.Text, Textbox_H_general.Text)
                    Else
                        Textbox_Inb.Text = "N/A"
                    End If
                    If IsNumeric(Textbox_Tb.Text) = True Then
                        Textbox_Ib.Text = moment(Textbox_Tb.Text, Textbox_H_general.Text)
                    Else
                        Textbox_Ib.Text = "N/A"
                    End If
                ElseIf numeric_input_moment_units.Text = language_settings.unit_centimeter4 Then
                    If IsNumeric(Textbox_Ta.Text) = True Then
                        Textbox_Ia.Text = moment(Textbox_Ta.Text / 10, Textbox_H_general.Text / 10)
                    Else
                        Textbox_Ia.Text = "N/A"
                    End If

                    If IsNumeric(Textbox_Tna.Text) = True Then
                        Textbox_Ina.Text = moment(Textbox_Tna.Text / 10, Textbox_H_general.Text / 10)
                    Else
                        Textbox_Ina.Text = "N/A"
                    End If

                    If IsNumeric(Textbox_Tnb.Text) = True Then
                        Textbox_Inb.Text = moment(Textbox_Tnb.Text / 10, Textbox_H_general.Text / 10)
                    Else
                        Textbox_Inb.Text = "N/A"
                    End If

                    If IsNumeric(Textbox_Tb.Text) = True Then
                        Textbox_Ib.Text = moment(Textbox_Tb.Text / 10, Textbox_H_general.Text / 10)
                    Else
                        Textbox_Ib.Text = "N/A"
                    End If
                ElseIf numeric_input_moment_units.Text = language_settings.unit_meter4 Then
                    If IsNumeric(Textbox_Ta.Text) = True Then
                        Textbox_Ia.Text = moment(Textbox_Ta.Text / 1000, Textbox_H_general.Text / 1000)
                    Else
                        Textbox_Ia.Text = "N/A"
                    End If

                    If IsNumeric(Textbox_Tna.Text) = True Then
                        Textbox_Ina.Text = moment(Textbox_Tna.Text / 1000, Textbox_H_general.Text / 1000)
                    Else
                        Textbox_Ina.Text = "N/A"
                    End If

                    If IsNumeric(Textbox_Tnb.Text) = True Then
                        Textbox_Inb.Text = moment(Textbox_Tnb.Text / 1000, Textbox_H_general.Text / 1000)
                    Else
                        Textbox_Inb.Text = "N/A"
                    End If

                    If IsNumeric(Textbox_Tb.Text) = True Then
                        Textbox_Ib.Text = moment(Textbox_Tb.Text / 1000, Textbox_H_general.Text / 1000)
                    Else
                        Textbox_Ib.Text = "N/A"
                    End If
                Else
                    Textbox_Ia.Text = "N/A"
                    Textbox_Ib.Text = "N/A"
                    Textbox_Ina.Text = "N/A"
                    Textbox_Inb.Text = "N/A"
                End If
            Else
                Textbox_Ia.Text = "N/A"
                Textbox_Ib.Text = "N/A"
                Textbox_Ina.Text = "N/A"
                Textbox_Inb.Text = "N/A"
            End If
        End Sub
        Private Sub Picture_eng_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Picture_eng_panel0.Click, Picture_eng_panel1.Click, Picture_eng_panel2.Click, Picture_eng_panel3.Click
            If File.Exists("default_eng.ini") = True Then
                GUI_set("default_eng.ini")
                language_settings.language_current_file = "default_eng.ini"
            Else
                'message to follow
            End If
            general_settings.save_settings_to_registry()
        End Sub
        Private Sub Picture_heb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Picture_heb_panel0.Click, Picture_heb_panel1.Click, Picture_heb_panel2.Click, Picture_heb_panel3.Click
            GUI_set("default_heb.ini")
            language_settings.language_current_file = "default_heb.ini"
            general_settings.save_settings_to_registry()
        End Sub
        Private Sub Label_time_interval_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label_time_interval.Click
            '    Dim msg_style As MsgBoxStyle
            '    Dim msg_title As String
            '    Dim msg_text As String
            '    msg_style = MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading
            '    msg_title = "Time Breakdown"
            '    msg_text = "Building Time:" + Chr(13) + "In Milliseconds:"
            '    MsgBox(msg_text, msg_style, msg_title)
        End Sub
        Private Sub numeric_case_input_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numeric_case_input.ValueChanged
            BC_info()
        End Sub
        Private Sub numeric_case_input_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles numeric_case_input.KeyPress
            BC_info()
        End Sub
        Private Sub numeric_case_input_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles numeric_case_input.Enter
            BC_info()
        End Sub
        '************MODEL CREATION **********************
        Function points_generator(ByVal a As Single, ByVal b As Single, ByVal H As Single, ByVal Na As Byte, ByVal Nb As Byte) As Boolean
            '****************POINTS********************
            '*************Plate points*****************
            Label_current_progress.Text = "Generating nodes of model (Plate)"
            Label_current_progress.Update()
            counts_of_total = 1
            count_points = 1
            loc_x = 0
            loc_z = 0
            loc_y = 0
            total_points_sub = (Na + 2) * (Nb + 2)
            For i = 1 To Nb + 2
                For j = 1 To Na + 2
                    string_holder += Chr(13) + CStr(count_points) + " " + CStr(loc_x) + " " + CStr(loc_y) + " " + CStr(loc_z)
                    '********PROGRESS BAR *********************
                    ProgressBar_sub.Value = count_points / total_points_sub * 100
                    ProgressBar_total.Value = counts_of_total / total_points * 100
                    count_points += 1
                    counts_of_total += 1
                    loc_y += b / (Na + 1)
                Next
                loc_x += a / (Nb + 1)
                loc_y = 0
            Next
            ProgressBar_sub.Value = 0
            '*************stiffeners tops edges points*****************
            loc_x = 0
            loc_y = b / (Na + 1)
            loc_z = H / 1000
            For j = 1 To Na
                string_holder += Chr(13) + CStr(count_points) + " " + CStr(loc_x) + " " + CStr(loc_y) + " " + CStr(loc_z)
                count_points += 1
                loc_y += b / (Na + 1)
            Next

            '*************stiffeners tops non edge points*****************
            Label_current_progress.Text = "Generating nodes of model (Stiffeners)"
            Label_current_progress.Update()
            loc_y = 0
            loc_x = a / (Nb + 1)
            loc_z = H / 1000
            total_points_sub = Nb * (Na + 2)
            For i = 1 To Nb
                For j = 1 To Na + 2
                    string_holder += Chr(13) + CStr(count_points) + " " + CStr(loc_x) + " " + CStr(loc_y) + " " + CStr(loc_z)
                    '********PROGRESS BAR *********************
                    new_count += 1
                    ProgressBar_sub.Value = new_count / total_points_sub * 100
                    counts_of_total += 1
                    ProgressBar_total.Value = counts_of_total / total_points * 100
                    count_points += 1
                    loc_y += b / (Na + 1)
                Next
                loc_x += a / (Nb + 1)
                loc_y = 0
            Next

            '*************stiffeners tops edges points*****************
            loc_x = a
            loc_y = b / (Na + 1)
            loc_z = H / 1000
            For j = 1 To Na
                string_holder += Chr(13) + CStr(count_points) + " " + CStr(loc_x) + " " + CStr(loc_y) + " " + CStr(loc_z)
                count_points += 1
                loc_y += b / (Na + 1)
            Next
            string_holder += Chr(13) + "*" + Chr(13)
            '****************END POINTS*********************
        End Function
        Function plate_surfaces_generator(ByVal a As Single, ByVal b As Single, ByVal Na As Byte, ByVal Nb As Byte) As Boolean
            '****************PLATE SURFACES GENERATING *********************
            Label_current_progress.Text = "Generating surfaces of model (Plate)"
            Label_current_progress.Update()
            jump_x = Na + 2
            count_surface = 1
            p1 = count_surface
            p2 = count_surface + jump_x + 1
            total_points_sub = (Nb + 1) * (Na + 1)
            new_count = 0
            ProgressBar_sub.Value = 0
            For i = 1 To (Nb + 1)
                For j = 1 To Na + 1
                    string_holder += "SURFACE VERTEX NAME=" + CStr(count_surface) + " P1=" + CStr(p1) + " P2=" + CStr(p1 + 1) + " P3=" + CStr(p2) + " P4=" + CStr(p2 - 1) + Chr(13)
                    '********PROGRESS BAR *********************
                    new_count += 1
                    ProgressBar_sub.Value = new_count / total_points_sub * 100
                    counts_of_total += 1
                    ProgressBar_total.Value = counts_of_total / total_points * 100
                    count_surface += 1
                    p1 += 1
                    p2 += 1
                Next
                p1 += 1
                p2 += 1
            Next
        End Function
        Function long_axis_surfaces_generator(ByVal a As Single, ByVal b As Single, ByVal Na As Byte, ByVal Nb As Byte) As Boolean
            Label_current_progress.Text = "Generating surfaces of model (Stiffeners)"
            Label_current_progress.Update()
            p1 = 2
            p2 = (Na + 2) * (Nb + 2) + 1
            For j = 1 To Na
                string_holder += "SURFACE VERTEX NAME=" + CStr(count_surface) + " P1=" + CStr(p1) + " P2=" + CStr(p2) + " P3=" + CStr(p2 + Na + 1) + " P4=" + CStr(p1 + Na + 2) + Chr(13)
                count_surface += 1
                p1 += 1
                p2 += 1
            Next
            '****************NON EDGES STIFFENERS SURFACES GENERATING *********************
            p1 = 2 + Na + 2
            p2 = (Na + 2) * (Nb + 2) + Na + 2
            total_points_sub = Na * (Nb - 1)
            new_count = 0
            For i = 1 To (Nb - 1)
                For j = 1 To Na
                    string_holder += "SURFACE VERTEX NAME=" + CStr(count_surface) + " P1=" + CStr(p1) + " P2=" + CStr(p2) + " P3=" + CStr(p2 + Na + 2) + " P4=" + CStr(p1 + Na + 2) + Chr(13)
                    '********PROGRESS BAR *********************
                    new_count += 1
                    ProgressBar_sub.Value = new_count / total_points_sub * 100
                    counts_of_total += 1
                    ProgressBar_total.Value = counts_of_total / total_points * 100
                    count_surface += 1
                    p1 += 1
                    p2 += 1
                Next
                p1 += 2
                p2 += 2
            Next
            '****************EDGES STIFFENERS SURFACES GENERATING *********************
            Label_current_progress.Text = "Generating surfaces of model (Stiffeners)"
            Label_current_progress.Update()
            p1 = (Na + 2) * (Nb + 2) - 2 * (Na + 2) + 2
            p2 = (Na + 2) * (Nb + 2) + 2 * Nb + Na * (Nb + 2) - Na - (Na + 2) + 2
            For j = 1 To Na
                string_holder += "SURFACE VERTEX NAME=" + CStr(count_surface) + " P1=" + CStr(p1) + " P2=" + CStr(p2) + " P3=" + CStr(p2 + Na + 1) + " P4=" + CStr(p1 + Na + 2) + Chr(13)
                count_surface += 1
                p1 += 1
                p2 += 1
            Next
        End Function
        Function short_axis_surfaces_generator(ByVal a As Single, ByVal b As Single, ByVal Na As Byte, ByVal Nb As Byte) As Boolean
            Label_current_progress.Text = "Generating surfaces of model (Stiffeners)"
            Label_current_progress.Update()
            p1 = Na + 3
            p2 = (Na + 2) * (Nb + 2) + Na + 1
            total_points_sub = Nb * (Na + 1)
            new_count = 1
            For j = 1 To Nb
                For i = 1 To Na + 1
                    string_holder += "SURFACE VERTEX NAME=" + CStr(count_surface) + " P1=" + CStr(p1) + " P2=" + CStr(p2) + " P3=" + CStr(p2 + 1) + " P4=" + CStr(p1 + 1) + Chr(13)
                    ''********PROGRESS BAR *********************
                    ProgressBar_sub.Value = new_count / total_points_sub * 100
                    ProgressBar_total.Value = counts_of_total / total_points * 100
                    new_count += 1
                    counts_of_total += 1
                    count_surface += 1
                    p1 += 1
                    p2 += 1
                Next
                p1 += 1
                p2 += 1
            Next
        End Function
        Function surfaces_thicknesses(ByVal t As Single, ByVal ta As Single, ByVal tna As Single, ByVal tb As Single, ByVal tnb As Single, ByVal Na As Single, ByVal Nb As Single) As Boolean
            Label_current_progress.Text = "Applying surface thicknesses"
            Label_current_progress.Update()
            Dim plate_surfaces As Single = (Na + 1) * (Nb + 1)
            Dim new_count_sub As Single = 1
            Dim location As Single = 0
            Dim mid_a, mid_b, thickness As Single
            mid_a = Na \ 2 + 1
            mid_b = Nb \ 2 + 1
            count_surface -= 1
            string_holder += Chr(13) + "*" + Chr(13) + "SFTHICKNESS" + Chr(13) + "@CLEAR" + Chr(13)
            For j = 1 To plate_surfaces
                string_holder += CStr(j) + " " + CStr(t) + " 0.00000000000000 0.00000000000000," + Chr(13) + "     0.00000000000000 0.00000000000000" + Chr(13)
                ''********PROGRESS BAR *********************
                ProgressBar_sub.Value = new_count_sub / count_surface * 100
                ProgressBar_total.Value = counts_of_total / total_points * 100
                new_count_sub += 1
                counts_of_total += 1
            Next
            Dim end_point As Single = (plate_surfaces + Na * (Nb + 1))

            '********** long stiffeners ********************8
            Dim current_center As Single = mid_a
            For j = plate_surfaces + 1 To end_point
                If (j - plate_surfaces) = current_center Then
                    thickness = ta
                    current_center += Na
                Else
                    thickness = tna
                End If

                string_holder += CStr(j) + " " + CStr(thickness) + " 0.00000000000000 0.00000000000000," + Chr(13) + "     0.00000000000000 0.00000000000000" + Chr(13)
                ''********PROGRESS BAR *********************
                ProgressBar_sub.Value = new_count_sub / count_surface * 100
                ProgressBar_total.Value = counts_of_total / total_points * 100
                new_count_sub += 1
                counts_of_total += 1
            Next

            '***** short stiffeners ***************
            Dim start_point As Single = end_point
            end_point = (start_point + Nb * (Na + 1))
            For j = start_point + 1 To end_point
                Select Case CInt(j)
                    Case start_point + 1 + (Na + 1) * (mid_b - 1) To start_point + 1 + (Na + 1) * (mid_b) - 1
                        thickness = tb
                    Case Else
                        thickness = tnb
                End Select
                string_holder += CStr(j) + " " + CStr(thickness) + " 0.00000000000000 0.00000000000000," + Chr(13) + "     0.00000000000000 0.00000000000000" + Chr(13)
                ''********PROGRESS BAR *********************
                ProgressBar_sub.Value = new_count_sub / count_surface * 100
                ProgressBar_total.Value = counts_of_total / total_points * 100
                new_count_sub += 1
                counts_of_total += 1
            Next
        End Function
        Function loads(ByVal Na As Byte, ByVal Nb As Byte, ByVal P As Single) As Boolean
            Label_current_progress.Text = "Applying loads"
            Label_current_progress.Update()
            Dim end_point As Single = (Na + 1) * (Nb + 1)
            string_holder += Chr(13) + "*" + Chr(13) + "LOAD PRESSURE NAME=1 MAGNITUD=" + CStr(P) + " BETA=0.00000000000000," + Chr(13) + "LINE = 0" + Chr(13) + "*" + Chr(13) + "APPLY-LOAD BODY=0" + Chr(13) + "@CLEAR" + Chr(13)
            For j = 1 To end_point
                string_holder += CStr(j) + "  'PRESSURE' 1  'SURFACE' " + CStr(j) + " 0 1 0.00000000000000 0 -1 0 0 0  'NO'," + Chr(13) + "     0.00000000000000 0.00000000000000 1 0" + Chr(13)
                ''********PROGRESS BAR *********************
                ProgressBar_sub.Value = j / end_point * 100
                ProgressBar_total.Value = counts_of_total / total_points * 100
                counts_of_total += 1
            Next
        End Function
        Function BC(ByVal C As Byte, ByVal Na As Single, ByVal Nb As Single) As Boolean
            Label_current_progress.Text = "Applying boundary conditions"
            Label_current_progress.Update()
            '**************** Setting the BC names and parameters****************
            string_holder += Chr(13) + _
            "*" + Chr(13) + _
            "FIXITY NAME=SIMPLY_SUPPORTED" + Chr(13) + _
            "@CLEAR" + Chr(13) + _
            " 'X-TRANSLATION'" + Chr(13) + _
            " 'Y-TRANSLATION'" + Chr(13) + _
            " 'Z-TRANSLATION'" + Chr(13) + _
            " 'OVALIZATION'" + Chr(13) + _
            " 'FLUID-POTENTIAL'" + Chr(13) + _
            " 'PORE-FLUID-PRESSURE'" + Chr(13) + "@" + Chr(13) + _
            "*" + Chr(13) + _
            "FIXITY NAME=FIXED" + Chr(13) + _
            "@CLEAR" + Chr(13) + _
            " 'X-TRANSLATION'" + Chr(13) + _
            " 'Y-TRANSLATION'" + Chr(13) + _
            " 'Z-TRANSLATION'" + Chr(13) + _
            " 'X-ROTATION'" + Chr(13) + _
            " 'Y-ROTATION'" + Chr(13) + _
            " 'Z-ROTATION'" + Chr(13) + _
            " 'OVALIZATION'" + Chr(13) + _
            " 'FLUID-POTENTIAL'" + Chr(13) + _
            " 'PORE-FLUID-PRESSURE'" + Chr(13) + _
            "@" + Chr(13) + "*"
            string_holder += Chr(13) + "FIXBOUNDARY LINES FIXITY=SIMPLY_SUPPORTED" + Chr(13) + "@CLEAR" + Chr(13)
            '**************** end Setting the BC names and parameters****************
            Dim BC_str_long As String = ""
            Dim BC_str_short As String = ""
            If C = 1 Then
                BC_str_long = "SIMPLY_SUPPORTED"
                BC_str_short = "SIMPLY_SUPPORTED"
            ElseIf C = 2 Then
                BC_str_long = "SIMPLY_SUPPORTED"
                BC_str_short = "FIXED"
            ElseIf C = 3 Then
                BC_str_long = "FIXED"
                BC_str_short = "SIMPLY_SUPPORTED"
            ElseIf C = 4 Then
                string_holder += Chr(13) + "FIXBOUNDARY LINES FIXITY=FIXED" + Chr(13) + "@CLEAR" + Chr(13)
                BC_str_long = "FIXED"
                BC_str_short = "FIXED"
            End If

            '********** Setting left short edge ****************
            string_holder += "1  '" + BC_str_short + "'" + Chr(13)
            string_holder += "5  '" + BC_str_short + "'" + Chr(13)
            Dim int As Integer = 8
            For i = 1 To Na - 1
                string_holder += CStr(int) + "  '" + BC_str_short + "'" + Chr(13)
                int += 3
            Next
            '********** Setting right short edge ****************
            int = 4 + Na * 3 + (Nb - 1) * 3 + 2 * Na * (Nb - 1) + 2
            string_holder += CStr(int) + "  '" + BC_str_short + "'" + Chr(13)
            int += 3
            string_holder += CStr(int) + "  '" + BC_str_short + "'" + Chr(13)
            int += 2
            For i = 1 To Na - 1
                string_holder += CStr(int) + "  '" + BC_str_short + "'" + Chr(13)
                int += 2
            Next
            '********** Setting long  edges ****************
            int = 4
            string_holder += CStr(int) + "  '" + BC_str_long + "'" + Chr(13)
            int += 3 * Na - 1
            string_holder += CStr(int) + "  '" + BC_str_long + "'" + Chr(13)
            int += 4
            For i = 1 To Nb
                string_holder += CStr(int) + "  '" + BC_str_long + "'" + Chr(13)
                int += 2 * Na - 1
                string_holder += CStr(int) + "  '" + BC_str_long + "'" + Chr(13)
                int += 4
            Next

            '********** Setting stiffeners BC ****************
            int += 2 - 4 - 3
            Dim r_int As Integer
            r_int = int + 3 * Na + 2 * Na * (Nb - 1) + 3 + 1 - 2
            If C = 2 Then
                For i = 1 To Na
                    int += 3
                    r_int += 2
                    string_holder += CStr(int) + "  '" + BC_str_short + "'" + Chr(13)
                    string_holder += CStr(r_int) + "  '" + BC_str_short + "'" + Chr(13)
                Next
            ElseIf C = 3 Then
                int = r_int + 2 * Na + 1
                For i = 1 To Nb
                    string_holder += CStr(int) + "  '" + BC_str_long + "'" + Chr(13)
                    int += Na + 2
                    string_holder += CStr(int) + "  '" + BC_str_long + "'" + Chr(13)
                    int += 1
                Next
            ElseIf C = 4 Then
                Dim n_int As Integer
                n_int = r_int + 2 * Na + 1

                For i = 1 To Na 'short edges'
                    int += 3
                    r_int += 2
                    string_holder += CStr(int) + "  '" + BC_str_short + "'" + Chr(13)
                    string_holder += CStr(r_int) + "  '" + BC_str_short + "'" + Chr(13)
                Next
                For i = 1 To Nb
                    string_holder += CStr(n_int) + "  '" + BC_str_long + "'" + Chr(13)
                    n_int += Na + 2
                    string_holder += CStr(n_int) + "  '" + BC_str_long + "'" + Chr(13)
                    n_int += 1
                Next
            End If
        End Function
        Function material_elementsgroup(ByVal modulus As Single, ByVal ni As Single) As Boolean

            '*********************Setting material *******************
            string_holder += Chr(13) + "*" + Chr(13) + "MATERIAL ELASTIC NAME=1 E=" + CStr(modulus) + " NU=" + CStr(ni) + "," + Chr(13) + _
            "DENSITY=0.00000000000000 ALPHA=0.00000000000000 MDESCRIP='NONE'" + Chr(13) + "*"
            '*********************end Setting material *******************
            string_holder += Chr(13) + "*" + Chr(13) + "EGROUP SHELL NAME=1 DISPLACE=" + DISPLACE + " MATERIAL=1 RINT=" + RINT + "," + Chr(13) + _
     "     SINT=" + SINT + " TINT=" + TINT + " RESULTS=" + RESULTS + " STRESSRE=" + STRESSRE + " PRINTVEC=" + PRINTVEC + "," + _
     "     NLAYERS=" + NLAYERS + " INITIALS=" + INITIALS + " FAILURE=" + FAILURE + " SECTION=" + SECTION + " CMASS=" + CMASS + "," + Chr(13) + _
     "     STRAINS=" + STRAINS + " RUPTURE=" + RUPTURE + " TIME-OFF=" + TIMEOFF + "," + Chr(13) + _
     "     OPTION=" + OPTION_STR + " DESCRIPT=" + DESCRIPT + Chr(13) + "****"

            '*********************Setting elementsgroup *******************
        End Function
        Function mesh_generator(ByVal na As Single, ByVal nb As Single) As Boolean
            Label_current_progress.Text = "Meshing the model (phase 1/2)"
            Label_current_progress.Update()
            Dim total_surfaces As Single = (na + 1) * (nb + 1) + (nb + 1) * na + nb * (na + 1)
            '************Setting mesh density *****************
            EXTEND = "NONE"
            If mode = "DIVISIONS" Then
                string_holder += Chr(13) + "SUBDIVIDE SURFACE NAME=1 MODE=" + mode + " NDIV1=" + CStr(NDIV1) + " NDIV2=" + CStr(NDIV2) + "," + Chr(13) + _
                "RATIO1=" + CStr(RATIO1) + " RATIO2=" + CStr(RATIO2) + "," + Chr(13) + _
                "PROGRESS=" + PROGRESS + " EXTEND=" + EXTEND + " CBIAS1=" + CBIAS1 + " CBIAS2=" + CBIAS2 + Chr(13) + "@CLEAR" + Chr(13)
            ElseIf mode = "LENGTH" Then
                string_holder += Chr(13) + "SUBDIVIDE SURFACE NAME=1 MODE=" + mode + " SIZE=" + CStr(LENGTH_SIZE) + Chr(13) + "@CLEAR" + Chr(13)
            ElseIf mode = "POINTWISE" Then 'mode=endpoint - POINTWISE
                string_holder += Chr(13) + "SUBDIVIDE SURFACE NAME=1 MODE=" + mode + " SIZE=" + CStr(LENGTH_SIZE) + "," + _
                "     PROGRESS=" + PROGRESS + Chr(13) + "@CLEAR" + Chr(13)
            Else
                MsgBox("ERROR")
                Exit Function
            End If
            For i = 1 To total_surfaces
                string_holder += CStr(i) + Chr(13)
                ProgressBar_sub.Value = (i / total_surfaces * 100)
                ProgressBar_total.Value = counts_of_total / total_points * 100
                counts_of_total += 1
            Next
            string_holder += "@" + Chr(13) + "*" + Chr(13) + "REGENERATE" + Chr(13)
            '************end Setting mesh density *****************

            '************ mesh creation *****************
            'NODES = 9
            'METHOD = "ADVFRONT"
            'MESHING = "MAPPED"
            'PREFSHAP = "AUTOMATIC"
            'FLIP = "NO"
            'MIDNODES = "CURVED"
            'DEGENERA = "NO"
            PATTERN = "AUTOMATIC"
            NCOINCID = "BOUNDARIES"
            NCEDGE = 1234
            NCVERTEX = 1234
            NCTOLERA = 0.00001
            SUBSTRUC = 0
            GROUP = 1
            SMOOTHIN = "NO"
            COLLAPSE = "NO"

            string_holder += "GSURFACE NODES=" + CStr(NODES) + " PATTERN=" + PATTERN + " NCOINCID=" + NCOINCID + " NCEDGE=" + CStr(NCEDGE) + "," + Chr(13) + _
            "NCVERTEX=" + CStr(NCVERTEX) + " NCTOLERA=" + CStr(NCTOLERA) + " SUBSTRUC=" + CStr(SUBSTRUC) + " GROUP=" + CStr(GROUP) + "," + Chr(13) + _
            "PREFSHAP=" + PREFSHAP + " MESHING=" + MESHING + " SMOOTHIN=" + SMOOTHIN + " DEGENERA=" + DEGENERA + "," + Chr(13) + _
            "COLLAPSE=" + COLLAPSE + " MIDNODES=" + MIDNODES + " METHOD=" + METHOD + " FLIP=" + FLIP + Chr(13) + "@CLEAR" + Chr(13)
            Label_current_progress.Text = "Meshing the model (phase 2/2)"
            Label_current_progress.Update()
            For i = 1 To total_surfaces
                string_holder += CStr(i) + Chr(13)
                ProgressBar_sub.Value = (i / total_surfaces * 100)
                ProgressBar_total.Value = counts_of_total / total_points * 100
                counts_of_total += 1
            Next
            string_holder += "@" + Chr(13) + "*" + Chr(13) + "REGENERATE"
            '************end mesh creation*****************
        End Function
        Function generator(ByVal a As Single, ByVal b As Single, ByVal Na As Byte, ByVal Nb As Byte, ByVal t As Single) As Boolean
            string_holder = Chr(13) + "*" + Chr(13) + "* Session file: Created for ADINA AUI version 8.1.0 By Lior Banai, " + CStr(Date.Now) + Chr(13) + _
            "**** Stiffened Plate Evaluator: ADINA generator *** " + Chr(13) + "*" + Chr(13) + "HEADING STRING='Stiffened_Plate_Evaluator_ADINA_generator'" + Chr(13) + "COORDINATES POINT SYSTEM=0" + Chr(13) + "@CLEAR"
            '   total_points = (Na + 2) * (Nb + 2) + Nb * (Na + 2) + (Nb + 1) * (Na + 1) + Na * (Nb - 1) + Nb * (Na + 1) + Na + Na * (Nb - 1) + Na + Nb * (Na + 1) + (Na + 1) * (Nb + 1) * 2
            '************MODEL GENERATION *****************
            new_count = 0
            ProgressBar_total.Value = 0
            ProgressBar_sub.Value = 0
            Dim s_date As Date = Date.Now
            Label_time_start.Text = "Start time: " + CStr(s_date)
            If (CheckBox_gen_mesh.Checked = False) And (CheckBox_gen_load.Checked = False) And (CheckBox_gen_BC.Checked = False) Then
                total_points = (Na + 2) * (Nb + 2) + Nb * (Na + 2) + (Nb + 1) * (Na + 1) + Na * (Nb - 1) + Nb * (Na + 1) + (Na + 1) * (Nb + 1) + Na * (Nb + 1) + Nb * (Na + 1)
                '               PLATE_PT_GENEATOR   INSIDE_STF_GEN   SURFACE_PLATE_GEN     surfgen_lg_stf surfgen_sh_stf   !!!!!surface_thickn  long_stf_thic + short_stf_thic
                '************ MODEL GENERATION ***********************
                points_generator(a, b, H, Na, Nb)
                plate_surfaces_generator(a, b, Na, Nb)
                long_axis_surfaces_generator(a, b, Na, Nb)
                short_axis_surfaces_generator(a, b, Na, Nb)
                surfaces_thicknesses(t / 1000, ta / 1000, tna / 1000, tb / 1000, tnb / 1000, Na, Nb)
                '************ MODEL GENERATION ***********************
            ElseIf (CheckBox_gen_mesh.Checked = False) And (CheckBox_gen_load.Checked = False) And (CheckBox_gen_BC.Checked = True) Then
                total_points = (Na + 2) * (Nb + 2) + Nb * (Na + 2) + (Nb + 1) * (Na + 1) + Na * (Nb - 1) + Nb * (Na + 1) + (Na + 1) * (Nb + 1) + Na * (Nb + 1) + Nb * (Na + 1) + (Na + 1) * (Nb + 1) + (Nb + 1) * Na + Nb * (Na + 1)
                '               PLATE_PT_GENEATOR   INSIDE_STF_GEN   SURFACE_PLATE_GEN     surfgen_lg_stf surfgen_sh_stf   !!!!!surface_thickn  long_stf_thic + short_stf_thic
                '************ MODEL GENERATION ***********************
                points_generator(a, b, H, Na, Nb)
                plate_surfaces_generator(a, b, Na, Nb)
                long_axis_surfaces_generator(a, b, Na, Nb)
                short_axis_surfaces_generator(a, b, Na, Nb)
                surfaces_thicknesses(t / 1000, ta / 1000, tna / 1000, tb / 1000, tnb / 1000, Na, Nb)
                '************ MODEL GENERATION ***********************
                '************ BC GENERATION    ***********************
                BC(C, Na, Nb)
            ElseIf (CheckBox_gen_mesh.Checked = False) And (CheckBox_gen_load.Checked = True) And (CheckBox_gen_BC.Checked = False) Then
                total_points = (Na + 2) * (Nb + 2) + Nb * (Na + 2) + (Nb + 1) * (Na + 1) + Na * (Nb - 1) + Nb * (Na + 1) + (Na + 1) * (Nb + 1) + Na * (Nb + 1) + Nb * (Na + 1) + (Na + 1) * (Nb + 1)
                '               PLATE_PT_GENEATOR   INSIDE_STF_GEN   SURFACE_PLATE_GEN     surfgen_lg_stf surfgen_sh_stf   !!!!!surface_thickn  long_stf_thic + short_stf_thic    loads generation
                '************ MODEL GENERATION ***********************
                points_generator(a, b, H, Na, Nb)
                plate_surfaces_generator(a, b, Na, Nb)
                long_axis_surfaces_generator(a, b, Na, Nb)
                short_axis_surfaces_generator(a, b, Na, Nb)
                surfaces_thicknesses(t / 1000, ta / 1000, tna / 1000, tb / 1000, tnb / 1000, Na, Nb)
                '************ MODEL GENERATION ***********************
                '************ LOADS GENERATION    ***********************
                loads(Na, Nb, P)
            ElseIf (CheckBox_gen_mesh.Checked = False) And (CheckBox_gen_load.Checked = True) And (CheckBox_gen_BC.Checked = True) Then
                total_points = (Na + 2) * (Nb + 2) + Nb * (Na + 2) + (Nb + 1) * (Na + 1) + Na * (Nb - 1) + Nb * (Na + 1) + (Na + 1) * (Nb + 1) + Na * (Nb + 1) + Nb * (Na + 1) + (Na + 1) * (Nb + 1)
                '               PLATE_PT_GENEATOR   INSIDE_STF_GEN   SURFACE_PLATE_GEN     surfgen_lg_stf surfgen_sh_stf   !!!!!surface_thickn  long_stf_thic + short_stf_thic    loads generation
                '************ MODEL GENERATION ***********************
                points_generator(a, b, H, Na, Nb)
                plate_surfaces_generator(a, b, Na, Nb)
                long_axis_surfaces_generator(a, b, Na, Nb)
                short_axis_surfaces_generator(a, b, Na, Nb)
                surfaces_thicknesses(t / 1000, ta / 1000, tna / 1000, tb / 1000, tnb / 1000, Na, Nb)
                material_elementsgroup(Young_modulus, ni)
                '************ MODEL GENERATION ***********************
                '************ LOADS & BC GENERATION    ***********************
                BC(C, Na, Nb)
                loads(Na, Nb, P)
            ElseIf (CheckBox_gen_mesh.Checked = True) And (CheckBox_gen_load.Checked = False) And (CheckBox_gen_BC.Checked = False) Then
                total_points = (Na + 2) * (Nb + 2) + Nb * (Na + 2) + (Nb + 1) * (Na + 1) + Na * (Nb - 1) + Nb * (Na + 1) + (Na + 1) * (Nb + 1) + Na * (Nb + 1) + Nb * (Na + 1) + (Na + 1) * (Nb + 1) + (Nb + 1) * Na + Nb * (Na + 1) + (Na + 1) * (Nb + 1) + (Nb + 1) * Na + Nb * (Na + 1)
                '               PLATE_PT_GENEATOR   INSIDE_STF_GEN   SURFACE_PLATE_GEN     surfgen_lg_stf surfgen_sh_stf   !!!!!surface_thickn  long_stf_thic + short_stf_thic
                '************ MODEL GENERATION ***********************
                points_generator(a, b, H, Na, Nb)
                plate_surfaces_generator(a, b, Na, Nb)
                long_axis_surfaces_generator(a, b, Na, Nb)
                short_axis_surfaces_generator(a, b, Na, Nb)
                surfaces_thicknesses(t / 1000, ta / 1000, tna / 1000, tb / 1000, tnb / 1000, Na, Nb)
                material_elementsgroup(Young_modulus, ni)
                material_elementsgroup(Young_modulus, ni)
                '************ MODEL GENERATION ***********************
                '************ MESH GENERATION    ***********************
                mesh_generator(Na, Nb)
            ElseIf (CheckBox_gen_mesh.Checked = True) And (CheckBox_gen_load.Checked = False) And (CheckBox_gen_BC.Checked = True) Then
                total_points = (Na + 2) * (Nb + 2) + Nb * (Na + 2) + (Nb + 1) * (Na + 1) + Na * (Nb - 1) + Nb * (Na + 1) + (Na + 1) * (Nb + 1) + Na * (Nb + 1) + Nb * (Na + 1) + (Na + 1) * (Nb + 1) + (Nb + 1) * Na + Nb * (Na + 1) + (Na + 1) * (Nb + 1) + (Nb + 1) * Na + Nb * (Na + 1)
                '               PLATE_PT_GENEATOR   INSIDE_STF_GEN   SURFACE_PLATE_GEN     surfgen_lg_stf surfgen_sh_stf   !!!!!surface_thickn  long_stf_thic + short_stf_thic
                '************ MODEL GENERATION ***********************
                points_generator(a, b, H, Na, Nb)
                plate_surfaces_generator(a, b, Na, Nb)
                long_axis_surfaces_generator(a, b, Na, Nb)
                short_axis_surfaces_generator(a, b, Na, Nb)
                surfaces_thicknesses(t / 1000, ta / 1000, tna / 1000, tb / 1000, tnb / 1000, Na, Nb)
                material_elementsgroup(Young_modulus, ni)
                material_elementsgroup(Young_modulus, ni)
                '************ MODEL GENERATION ***********************
                '************ BC GENERATION    ***********************
                BC(C, Na, Nb)
                '************ MESH GENERATION    ***********************
                mesh_generator(Na, Nb)
            ElseIf (CheckBox_gen_mesh.Checked = True) And (CheckBox_gen_load.Checked = True) And (CheckBox_gen_BC.Checked = False) Then
                total_points = (Na + 2) * (Nb + 2) + Nb * (Na + 2) + (Nb + 1) * (Na + 1) + Na * (Nb - 1) + Nb * (Na + 1) + (Na + 1) * (Nb + 1) + Na * (Nb + 1) + Nb * (Na + 1) + (Na + 1) * (Nb + 1) + (Na + 1) * (Nb + 1) + (Nb + 1) * Na + Nb * (Na + 1) + (Na + 1) * (Nb + 1) + (Nb + 1) * Na + Nb * (Na + 1)
                '               PLATE_PT_GENEATOR   INSIDE_STF_GEN   SURFACE_PLATE_GEN     surfgen_lg_stf surfgen_sh_stf   !!!!!surface_thickn  long_stf_thic + short_stf_thic   load generation
                '************ MODEL GENERATION ***********************
                points_generator(a, b, H, Na, Nb)
                plate_surfaces_generator(a, b, Na, Nb)
                long_axis_surfaces_generator(a, b, Na, Nb)
                short_axis_surfaces_generator(a, b, Na, Nb)
                surfaces_thicknesses(t / 1000, ta / 1000, tna / 1000, tb / 1000, tnb / 1000, Na, Nb)
                material_elementsgroup(Young_modulus, ni)
                material_elementsgroup(Young_modulus, ni)
                '************ MODEL GENERATION ***********************
                '************ LOADS GENERATION    ***********************
                loads(Na, Nb, P)
                '************ MESH GENERATION    ***********************
                mesh_generator(Na, Nb)
            ElseIf (CheckBox_gen_mesh.Checked = True) And (CheckBox_gen_load.Checked = True) And (CheckBox_gen_BC.Checked = True) Then
                total_points = (Na + 2) * (Nb + 2) + Nb * (Na + 2) + (Nb + 1) * (Na + 1) + Na * (Nb - 1) + Nb * (Na + 1) + Na + Na * (Nb - 1) + Na + Nb * (Na + 1) + (Na + 1) * (Nb + 1) * 2 + (Na + 1) * (Nb + 1) + (Nb + 1) * Na + Nb * (Na + 1) + (Na + 1) * (Nb + 1) + (Nb + 1) * Na + Nb * (Na + 1)
                points_generator(a, b, H, Na, Nb)
                plate_surfaces_generator(a, b, Na, Nb)
                long_axis_surfaces_generator(a, b, Na, Nb)
                short_axis_surfaces_generator(a, b, Na, Nb)
                surfaces_thicknesses(t / 1000, ta / 1000, tna / 1000, tb / 1000, tnb / 1000, Na, Nb)
                loads(Na, Nb, P)
                material_elementsgroup(Young_modulus, ni)
                BC(C, Na, Nb)
                mesh_generator(Na, Nb)
            Else
                MsgBox("ERROR")
            End If
            '**************************GENERATE ISO VIEW*****************************
            string_holder += Chr(13) + "*" + Chr(13) + _
                            "MESHPLOT NAME=DEFAULT MESHSTYL=DEFAULT ZONENAME=WHOLE_MODEL," + Chr(13) + _
                            "     RESPONSE=DEFAULT MODELDEP=DEFAULT VIEW=DEFAULT MESHWIND=DEFAULT," + Chr(13) + _
                            "     PLOTAREA=DEFAULT SUBFRAME=DEFAULT ELDEPICT=DEFAULT," + Chr(13) + _
                            "     NODEDEPI=DEFAULT BOUNDEPI=ALL GPDEPICT=DEFAULT GLDEPICT=DEFAULT," + Chr(13) + _
                            "     GSDEPICT=DEFAULT GVDEPICT=DEFAULT MESHREND=DEFAULT," + Chr(13) + _
                            "     MESHANNO=DEFAULT FRONDEPI=DEFAULT CONDEPIC=DEFAULT," + Chr(13) + _
                            "     VSDEPICI=DEFAULT CRACKDEP=DEFAULT RESULTCO=DEFAULT," + Chr(13) + _
                            "     CUTSURFA=DEFAULT" + Chr(13) + _
                            "****" + Chr(13) + "*" + Chr(13)
            Label_current_progress.Text = "Completing Process... Stand by"
            Label_current_progress.Update()
            RichTextBox_macro.Text = string_holder
            CheckBox_macro.Enabled = True
            CheckBox_macro.Checked = True
            RichTextBox_macro.Visible = True
            Label_current_progress.Text = "Process completed"
            Label_current_progress.Update()
            Button_save_macro.Visible = True
            GroupBox_video.Visible = False
            Dim f_date As Date = Date.Now
            Label_time_end.Text = "End time: " + CStr(f_date)
            Dim interval As TimeSpan = f_date.Subtract(s_date)
            Label_time_interval.Text = "Process time: " + CStr(interval.TotalMilliseconds) + " [Milliseconds]"
        End Function
        '************END MODEL CREATION **********************
    End Class
End Namespace
