<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GUI_grillage_model
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Plate Geometry")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stiffeners' Properties")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Physical Properties")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Preprocessing", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3})
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Summary")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Result")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Processing", New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode6})
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Export Results ")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ADINA model Generator")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Postprocessing", New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode9})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI_grillage_model))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TreeView_steps = New System.Windows.Forms.TreeView()
        Me.ImageList_icons = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox_plate = New System.Windows.Forms.GroupBox()
        Me.Label_comment02 = New System.Windows.Forms.Label()
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
        Me.GroupBox_stiffeners = New System.Windows.Forms.GroupBox()
        Me.GroupBox_stiffeners_mark = New System.Windows.Forms.GroupBox()
        Me.PictureBox_S = New System.Windows.Forms.PictureBox()
        Me.PictureBox_R = New System.Windows.Forms.PictureBox()
        Me.CheckBox_short = New System.Windows.Forms.CheckBox()
        Me.CheckBox_long = New System.Windows.Forms.CheckBox()
        Me.GroupBox_stiffeners_number = New System.Windows.Forms.GroupBox()
        Me.Label_comment01 = New System.Windows.Forms.Label()
        Me.numeric_R = New System.Windows.Forms.NumericUpDown()
        Me.Label_stiffeners_short = New System.Windows.Forms.Label()
        Me.numeric_S = New System.Windows.Forms.NumericUpDown()
        Me.Label_stiffeners_long = New System.Windows.Forms.Label()
        Me.GroupBox_stiffeners_data = New System.Windows.Forms.GroupBox()
        Me.GroupBox_input_selection = New System.Windows.Forms.GroupBox()
        Me.Radiobutton_select_geometric = New System.Windows.Forms.RadioButton()
        Me.Radiobutton_select_numeric = New System.Windows.Forms.RadioButton()
        Me.Radiobutton_select_DB = New System.Windows.Forms.RadioButton()
        Me.Groupbox_geometric_input = New System.Windows.Forms.GroupBox()
        Me.Button_Geo_selected = New System.Windows.Forms.Button()
        Me.TextBox_Geo_result = New System.Windows.Forms.TextBox()
        Me.Label_Geo_result = New System.Windows.Forms.Label()
        Me.Combobox_geo_select = New System.Windows.Forms.ComboBox()
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
        Me.PictureBox_Geo_L = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Geo_T = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Geo_I = New System.Windows.Forms.PictureBox()
        Me.GroupBox_numeric_input = New System.Windows.Forms.GroupBox()
        Me.ComboBox_num_center_units = New System.Windows.Forms.ComboBox()
        Me.ComboBox_num_area_units = New System.Windows.Forms.ComboBox()
        Me.ComboBox_num_moment_units = New System.Windows.Forms.ComboBox()
        Me.Label_num_area = New System.Windows.Forms.Label()
        Me.TextBox_num_area = New System.Windows.Forms.TextBox()
        Me.Label_num_center = New System.Windows.Forms.Label()
        Me.TextBox_num_center = New System.Windows.Forms.TextBox()
        Me.Label_num_moment = New System.Windows.Forms.Label()
        Me.TextBox_num_moment = New System.Windows.Forms.TextBox()
        Me.Button_num_selected = New System.Windows.Forms.Button()
        Me.PictureBox_numeric = New System.Windows.Forms.PictureBox()
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
        Me.GroupBox_BC = New System.Windows.Forms.GroupBox()
        Me.label_GPa = New System.Windows.Forms.Label()
        Me.ComboBox_P_units = New System.Windows.Forms.ComboBox()
        Me.Button_case04 = New System.Windows.Forms.Button()
        Me.TextBox_P_input = New System.Windows.Forms.TextBox()
        Me.Button_case01 = New System.Windows.Forms.Button()
        Me.TextBox_ni_input = New System.Windows.Forms.TextBox()
        Me.Button_case02 = New System.Windows.Forms.Button()
        Me.Button_case03 = New System.Windows.Forms.Button()
        Me.TextBox_E_input = New System.Windows.Forms.TextBox()
        Me.Label_pressure = New System.Windows.Forms.Label()
        Me.label_ni = New System.Windows.Forms.Label()
        Me.Label_modulus = New System.Windows.Forms.Label()
        Me.numeric_BC_input = New System.Windows.Forms.NumericUpDown()
        Me.Label_BC = New System.Windows.Forms.Label()
        Me.GroupBox_stiffeners_whole = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.GroupBox_results = New System.Windows.Forms.GroupBox()
        Me.GroupBox_results_deflection = New System.Windows.Forms.GroupBox()
        Me.Label_SD_deflection = New System.Windows.Forms.Label()
        Me.RichTextBox_results_deflection = New System.Windows.Forms.RichTextBox()
        Me.NumericUpDown_SD_deflection = New System.Windows.Forms.NumericUpDown()
        Me.Textbox_results_Deflection = New System.Windows.Forms.TextBox()
        Me.Button_compute = New System.Windows.Forms.Button()
        Me.GroupBox_results_BM = New System.Windows.Forms.GroupBox()
        Me.RichTextBox_results_BM = New System.Windows.Forms.RichTextBox()
        Me.Label_SD_BM = New System.Windows.Forms.Label()
        Me.NumericUpDown_SD_BM = New System.Windows.Forms.NumericUpDown()
        Me.Textbox_results_BM = New System.Windows.Forms.TextBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.GroupBox_summary = New System.Windows.Forms.GroupBox()
        Me.groupbox_plate_geo = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.numeric_t = New System.Windows.Forms.NumericUpDown()
        Me.numeric_b = New System.Windows.Forms.NumericUpDown()
        Me.numeric_a = New System.Windows.Forms.NumericUpDown()
        Me.label_t = New System.Windows.Forms.Label()
        Me.label_a = New System.Windows.Forms.Label()
        Me.label_b = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox_Ar_stiffeners = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox_Yr_stiffeners = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox_Ir_stiffeners = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox_As_stiffeners = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox_Ys_stiffeners = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox_Is_stiffeners = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.numeric_s_sum = New System.Windows.Forms.NumericUpDown()
        Me.numeric_r_sum = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.groupbox_general = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.button_BC_select = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox_P = New System.Windows.Forms.TextBox()
        Me.TextBox_ni = New System.Windows.Forms.TextBox()
        Me.TextBox_E = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label_E = New System.Windows.Forms.Label()
        Me.numeric_case_input = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.GroupBox_export = New System.Windows.Forms.GroupBox()
        Me.RichTextBox_result_for_saving = New System.Windows.Forms.RichTextBox()
        Me.button_results_save_HTML = New System.Windows.Forms.Button()
        Me.GroupBox_choose_language = New System.Windows.Forms.GroupBox()
        Me.GroupBox_update = New System.Windows.Forms.GroupBox()
        Me.RadioButton_add_replace = New System.Windows.Forms.RadioButton()
        Me.Button_update = New System.Windows.Forms.Button()
        Me.RadioButton_add_after = New System.Windows.Forms.RadioButton()
        Me.RadioButton_other_language = New System.Windows.Forms.RadioButton()
        Me.RadioButton_default_english = New System.Windows.Forms.RadioButton()
        Me.RichTextBox_result_for_saving_HTML = New System.Windows.Forms.RichTextBox()
        Me.button_results_clear = New System.Windows.Forms.Button()
        Me.button_results_save = New System.Windows.Forms.Button()
        Me.GroupBox_ADINA = New System.Windows.Forms.GroupBox()
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
        Me.Label_Adina = New System.Windows.Forms.Label()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel_right = New System.Windows.Forms.Panel()
        Me.GroupBox_plate.SuspendLayout()
        CType(Me.numeric_plate_t, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numeric_plate_short, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numeric_plate_long, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_plate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_stiffeners.SuspendLayout()
        Me.GroupBox_stiffeners_mark.SuspendLayout()
        CType(Me.PictureBox_S, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_R, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_stiffeners_number.SuspendLayout()
        CType(Me.numeric_R, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numeric_S, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_stiffeners_data.SuspendLayout()
        Me.GroupBox_input_selection.SuspendLayout()
        Me.Groupbox_geometric_input.SuspendLayout()
        CType(Me.PictureBox_Geo_blade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_geo_input.SuspendLayout()
        CType(Me.PictureBox_Geo_L, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Geo_T, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Geo_I, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_numeric_input.SuspendLayout()
        CType(Me.PictureBox_numeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox_DB_input.SuspendLayout()
        CType(Me.PictureBox_DB_pic02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_DB_pic01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox_DB_sub.SuspendLayout()
        Me.GroupBox_BC.SuspendLayout()
        CType(Me.numeric_BC_input, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_stiffeners_whole.SuspendLayout()
        Me.GroupBox_results.SuspendLayout()
        Me.GroupBox_results_deflection.SuspendLayout()
        CType(Me.NumericUpDown_SD_deflection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_results_BM.SuspendLayout()
        CType(Me.NumericUpDown_SD_BM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_summary.SuspendLayout()
        Me.groupbox_plate_geo.SuspendLayout()
        CType(Me.numeric_t, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numeric_b, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numeric_a, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numeric_s_sum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numeric_r_sum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupbox_general.SuspendLayout()
        CType(Me.numeric_case_input, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_export.SuspendLayout()
        Me.GroupBox_choose_language.SuspendLayout()
        Me.GroupBox_update.SuspendLayout()
        Me.GroupBox_ADINA.SuspendLayout()
        Me.GroupBox_creation_type.SuspendLayout()
        CType(Me.PictureBox02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel_right.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1028, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TreeView_steps
        '
        Me.TreeView_steps.Dock = System.Windows.Forms.DockStyle.Left
        Me.TreeView_steps.ImageIndex = 0
        Me.TreeView_steps.ImageList = Me.ImageList_icons
        Me.TreeView_steps.Indent = 25
        Me.TreeView_steps.Location = New System.Drawing.Point(0, 24)
        Me.TreeView_steps.Name = "TreeView_steps"
        TreeNode1.ImageKey = "icon_x.gif"
        TreeNode1.Name = "Node0"
        TreeNode1.SelectedImageKey = "icon_x.gif"
        TreeNode1.Text = "Plate Geometry"
        TreeNode2.ImageKey = "icon_x.gif"
        TreeNode2.Name = "Node1"
        TreeNode2.SelectedImageKey = "icon_x.gif"
        TreeNode2.Text = "Stiffeners' Properties"
        TreeNode3.ImageKey = "icon_x.gif"
        TreeNode3.Name = "Node2"
        TreeNode3.SelectedImageKey = "icon_x.gif"
        TreeNode3.Text = "Physical Properties"
        TreeNode4.ImageKey = "icon_x.gif"
        TreeNode4.Name = "Node0"
        TreeNode4.SelectedImageKey = "icon_x.gif"
        TreeNode4.Text = "Preprocessing"
        TreeNode5.ImageKey = "icon_unknown.gif"
        TreeNode5.Name = "Node3"
        TreeNode5.SelectedImageKey = "icon_unknown.gif"
        TreeNode5.Text = "Summary"
        TreeNode6.ImageKey = "icon_unknown.gif"
        TreeNode6.Name = "Node7"
        TreeNode6.SelectedImageKey = "icon_unknown.gif"
        TreeNode6.Text = "Result"
        TreeNode7.ImageKey = "icon_unknown.gif"
        TreeNode7.Name = "Node1"
        TreeNode7.SelectedImageKey = "icon_unknown.gif"
        TreeNode7.Text = "Processing"
        TreeNode8.ImageKey = "icon_unknown.gif"
        TreeNode8.Name = "Node4"
        TreeNode8.SelectedImageKey = "icon_unknown.gif"
        TreeNode8.Text = "Export Results "
        TreeNode9.ImageKey = "icon_unknown.gif"
        TreeNode9.Name = "Node5"
        TreeNode9.SelectedImageKey = "icon_unknown.gif"
        TreeNode9.Text = "ADINA model Generator"
        TreeNode10.ImageKey = "icon_unknown.gif"
        TreeNode10.Name = "Node2"
        TreeNode10.SelectedImageKey = "icon_unknown.gif"
        TreeNode10.Text = "Postprocessing"
        Me.TreeView_steps.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode7, TreeNode10})
        Me.TreeView_steps.SelectedImageIndex = 0
        Me.TreeView_steps.Size = New System.Drawing.Size(216, 690)
        Me.TreeView_steps.TabIndex = 1
        '
        'ImageList_icons
        '
        Me.ImageList_icons.ImageStream = CType(resources.GetObject("ImageList_icons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_icons.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_icons.Images.SetKeyName(0, "icon_x.gif")
        Me.ImageList_icons.Images.SetKeyName(1, "icon_check.gif")
        Me.ImageList_icons.Images.SetKeyName(2, "icon_unknown.gif")
        '
        'GroupBox_plate
        '
        Me.GroupBox_plate.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox_plate.Controls.Add(Me.Label_comment02)
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
        Me.GroupBox_plate.Font = New System.Drawing.Font("David", 13.8!)
        Me.GroupBox_plate.Location = New System.Drawing.Point(18, 72)
        Me.GroupBox_plate.Name = "GroupBox_plate"
        Me.GroupBox_plate.Size = New System.Drawing.Size(745, 204)
        Me.GroupBox_plate.TabIndex = 41
        Me.GroupBox_plate.TabStop = False
        Me.GroupBox_plate.Text = "Plate's Geometry's Parameters"
        '
        'Label_comment02
        '
        Me.Label_comment02.AutoEllipsis = True
        Me.Label_comment02.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_comment02.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_comment02.Location = New System.Drawing.Point(280, 40)
        Me.Label_comment02.Name = "Label_comment02"
        Me.Label_comment02.Size = New System.Drawing.Size(203, 25)
        Me.Label_comment02.TabIndex = 45
        Me.Label_comment02.Text = "Length b ≥ Breadth a"
        Me.Label_comment02.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_long
        '
        Me.Label_long.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_long.AutoEllipsis = True
        Me.Label_long.BackColor = System.Drawing.Color.White
        Me.Label_long.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_long.Location = New System.Drawing.Point(640, 106)
        Me.Label_long.Name = "Label_long"
        Me.Label_long.Size = New System.Drawing.Size(51, 19)
        Me.Label_long.TabIndex = 44
        Me.Label_long.Text = "b"
        Me.Label_long.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_short
        '
        Me.Label_short.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_short.AutoEllipsis = True
        Me.Label_short.BackColor = System.Drawing.Color.White
        Me.Label_short.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_short.Location = New System.Drawing.Point(596, 38)
        Me.Label_short.Name = "Label_short"
        Me.Label_short.Size = New System.Drawing.Size(113, 27)
        Me.Label_short.TabIndex = 43
        Me.Label_short.Text = "a"
        Me.Label_short.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label_thickness
        '
        Me.Label_thickness.AutoEllipsis = True
        Me.Label_thickness.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_thickness.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_thickness.Location = New System.Drawing.Point(8, 137)
        Me.Label_thickness.Name = "Label_thickness"
        Me.Label_thickness.Size = New System.Drawing.Size(100, 25)
        Me.Label_thickness.TabIndex = 12
        Me.Label_thickness.Text = "Thickness t"
        Me.Label_thickness.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'numeric_plate_t
        '
        Me.numeric_plate_t.DecimalPlaces = 4
        Me.numeric_plate_t.Font = New System.Drawing.Font("David", 10.8!)
        Me.numeric_plate_t.Location = New System.Drawing.Point(112, 137)
        Me.numeric_plate_t.Name = "numeric_plate_t"
        Me.numeric_plate_t.Size = New System.Drawing.Size(81, 25)
        Me.numeric_plate_t.TabIndex = 11
        Me.numeric_plate_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_breadth
        '
        Me.Label_breadth.AutoEllipsis = True
        Me.Label_breadth.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_breadth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_breadth.Location = New System.Drawing.Point(9, 86)
        Me.Label_breadth.Name = "Label_breadth"
        Me.Label_breadth.Size = New System.Drawing.Size(100, 25)
        Me.Label_breadth.TabIndex = 10
        Me.Label_breadth.Text = "Breadth a"
        Me.Label_breadth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'numeric_plate_short
        '
        Me.numeric_plate_short.DecimalPlaces = 4
        Me.numeric_plate_short.Font = New System.Drawing.Font("David", 10.8!)
        Me.numeric_plate_short.Location = New System.Drawing.Point(113, 86)
        Me.numeric_plate_short.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numeric_plate_short.Name = "numeric_plate_short"
        Me.numeric_plate_short.Size = New System.Drawing.Size(81, 25)
        Me.numeric_plate_short.TabIndex = 9
        Me.numeric_plate_short.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_length
        '
        Me.Label_length.AutoEllipsis = True
        Me.Label_length.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_length.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_length.Location = New System.Drawing.Point(9, 40)
        Me.Label_length.Name = "Label_length"
        Me.Label_length.Size = New System.Drawing.Size(100, 25)
        Me.Label_length.TabIndex = 8
        Me.Label_length.Text = "Length b"
        Me.Label_length.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'numeric_plate_long
        '
        Me.numeric_plate_long.DecimalPlaces = 4
        Me.numeric_plate_long.Font = New System.Drawing.Font("David", 10.8!)
        Me.numeric_plate_long.Location = New System.Drawing.Point(113, 40)
        Me.numeric_plate_long.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numeric_plate_long.Name = "numeric_plate_long"
        Me.numeric_plate_long.Size = New System.Drawing.Size(81, 25)
        Me.numeric_plate_long.TabIndex = 7
        Me.numeric_plate_long.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox_plate
        '
        Me.PictureBox_plate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox_plate.Image = Global.SPE.My.Resources.Resources.plate_empty_text
        Me.PictureBox_plate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox_plate.Location = New System.Drawing.Point(511, 29)
        Me.PictureBox_plate.Name = "PictureBox_plate"
        Me.PictureBox_plate.Size = New System.Drawing.Size(206, 144)
        Me.PictureBox_plate.TabIndex = 42
        Me.PictureBox_plate.TabStop = False
        '
        'Label_unit_mm01
        '
        Me.Label_unit_mm01.AutoEllipsis = True
        Me.Label_unit_mm01.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_unit_mm01.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_unit_mm01.Location = New System.Drawing.Point(208, 137)
        Me.Label_unit_mm01.Name = "Label_unit_mm01"
        Me.Label_unit_mm01.Size = New System.Drawing.Size(69, 25)
        Me.Label_unit_mm01.TabIndex = 41
        Me.Label_unit_mm01.Text = "[mm]"
        Me.Label_unit_mm01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_unit_m02
        '
        Me.Label_unit_m02.AutoEllipsis = True
        Me.Label_unit_m02.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_unit_m02.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_unit_m02.Location = New System.Drawing.Point(209, 86)
        Me.Label_unit_m02.Name = "Label_unit_m02"
        Me.Label_unit_m02.Size = New System.Drawing.Size(66, 25)
        Me.Label_unit_m02.TabIndex = 40
        Me.Label_unit_m02.Text = "[m]"
        Me.Label_unit_m02.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_unit_m01
        '
        Me.Label_unit_m01.AutoEllipsis = True
        Me.Label_unit_m01.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_unit_m01.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_unit_m01.Location = New System.Drawing.Point(209, 40)
        Me.Label_unit_m01.Name = "Label_unit_m01"
        Me.Label_unit_m01.Size = New System.Drawing.Size(66, 25)
        Me.Label_unit_m01.TabIndex = 39
        Me.Label_unit_m01.Text = "[m]"
        Me.Label_unit_m01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox_stiffeners
        '
        Me.GroupBox_stiffeners.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox_stiffeners.Controls.Add(Me.GroupBox_stiffeners_mark)
        Me.GroupBox_stiffeners.Controls.Add(Me.GroupBox_stiffeners_number)
        Me.GroupBox_stiffeners.Font = New System.Drawing.Font("David", 13.8!)
        Me.GroupBox_stiffeners.Location = New System.Drawing.Point(6, 16)
        Me.GroupBox_stiffeners.Name = "GroupBox_stiffeners"
        Me.GroupBox_stiffeners.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox_stiffeners.Size = New System.Drawing.Size(722, 150)
        Me.GroupBox_stiffeners.TabIndex = 41
        Me.GroupBox_stiffeners.TabStop = False
        Me.GroupBox_stiffeners.Text = "Selection of Stiffeners"
        '
        'GroupBox_stiffeners_mark
        '
        Me.GroupBox_stiffeners_mark.Controls.Add(Me.PictureBox_S)
        Me.GroupBox_stiffeners_mark.Controls.Add(Me.PictureBox_R)
        Me.GroupBox_stiffeners_mark.Controls.Add(Me.CheckBox_short)
        Me.GroupBox_stiffeners_mark.Controls.Add(Me.CheckBox_long)
        Me.GroupBox_stiffeners_mark.Location = New System.Drawing.Point(385, 25)
        Me.GroupBox_stiffeners_mark.Name = "GroupBox_stiffeners_mark"
        Me.GroupBox_stiffeners_mark.Size = New System.Drawing.Size(318, 112)
        Me.GroupBox_stiffeners_mark.TabIndex = 52
        Me.GroupBox_stiffeners_mark.TabStop = False
        Me.GroupBox_stiffeners_mark.Tag = ""
        Me.GroupBox_stiffeners_mark.Text = "Type of Stiffeners Selection"
        '
        'PictureBox_S
        '
        Me.PictureBox_S.Image = Global.SPE.My.Resources.Resources.icon_x
        Me.PictureBox_S.Location = New System.Drawing.Point(276, 35)
        Me.PictureBox_S.Name = "PictureBox_S"
        Me.PictureBox_S.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox_S.TabIndex = 6
        Me.PictureBox_S.TabStop = False
        '
        'PictureBox_R
        '
        Me.PictureBox_R.Image = Global.SPE.My.Resources.Resources.icon_x
        Me.PictureBox_R.Location = New System.Drawing.Point(276, 71)
        Me.PictureBox_R.Name = "PictureBox_R"
        Me.PictureBox_R.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox_R.TabIndex = 5
        Me.PictureBox_R.TabStop = False
        '
        'CheckBox_short
        '
        Me.CheckBox_short.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox_short.AutoEllipsis = True
        Me.CheckBox_short.Font = New System.Drawing.Font("David", 10.8!)
        Me.CheckBox_short.Location = New System.Drawing.Point(7, 71)
        Me.CheckBox_short.Name = "CheckBox_short"
        Me.CheckBox_short.Size = New System.Drawing.Size(259, 30)
        Me.CheckBox_short.TabIndex = 1
        Me.CheckBox_short.Text = "Transverse Stiffeners"
        '
        'CheckBox_long
        '
        Me.CheckBox_long.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox_long.AutoEllipsis = True
        Me.CheckBox_long.Font = New System.Drawing.Font("David", 10.8!)
        Me.CheckBox_long.Location = New System.Drawing.Point(7, 35)
        Me.CheckBox_long.Name = "CheckBox_long"
        Me.CheckBox_long.Size = New System.Drawing.Size(259, 30)
        Me.CheckBox_long.TabIndex = 0
        Me.CheckBox_long.Text = "Longitudinal Stiffeners"
        '
        'GroupBox_stiffeners_number
        '
        Me.GroupBox_stiffeners_number.Controls.Add(Me.Label_comment01)
        Me.GroupBox_stiffeners_number.Controls.Add(Me.numeric_R)
        Me.GroupBox_stiffeners_number.Controls.Add(Me.Label_stiffeners_short)
        Me.GroupBox_stiffeners_number.Controls.Add(Me.numeric_S)
        Me.GroupBox_stiffeners_number.Controls.Add(Me.Label_stiffeners_long)
        Me.GroupBox_stiffeners_number.Font = New System.Drawing.Font("David", 13.8!)
        Me.GroupBox_stiffeners_number.Location = New System.Drawing.Point(20, 25)
        Me.GroupBox_stiffeners_number.Name = "GroupBox_stiffeners_number"
        Me.GroupBox_stiffeners_number.Size = New System.Drawing.Size(358, 112)
        Me.GroupBox_stiffeners_number.TabIndex = 51
        Me.GroupBox_stiffeners_number.TabStop = False
        Me.GroupBox_stiffeners_number.Text = "Number of Stiffeners"
        '
        'Label_comment01
        '
        Me.Label_comment01.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_comment01.AutoEllipsis = True
        Me.Label_comment01.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_comment01.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_comment01.Location = New System.Drawing.Point(8, 81)
        Me.Label_comment01.Name = "Label_comment01"
        Me.Label_comment01.Size = New System.Drawing.Size(342, 25)
        Me.Label_comment01.TabIndex = 59
        Me.Label_comment01.Text = "R ≥ S"
        Me.Label_comment01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'numeric_R
        '
        Me.numeric_R.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numeric_R.Font = New System.Drawing.Font("David", 10.8!)
        Me.numeric_R.Location = New System.Drawing.Point(287, 54)
        Me.numeric_R.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numeric_R.Name = "numeric_R"
        Me.numeric_R.Size = New System.Drawing.Size(64, 25)
        Me.numeric_R.TabIndex = 58
        Me.numeric_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numeric_R.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'Label_stiffeners_short
        '
        Me.Label_stiffeners_short.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_stiffeners_short.AutoEllipsis = True
        Me.Label_stiffeners_short.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_stiffeners_short.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_stiffeners_short.Location = New System.Drawing.Point(8, 54)
        Me.Label_stiffeners_short.Name = "Label_stiffeners_short"
        Me.Label_stiffeners_short.Size = New System.Drawing.Size(272, 25)
        Me.Label_stiffeners_short.TabIndex = 57
        Me.Label_stiffeners_short.Text = "Transverse Stiffeners (R beams)"
        Me.Label_stiffeners_short.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'numeric_S
        '
        Me.numeric_S.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numeric_S.Font = New System.Drawing.Font("David", 10.8!)
        Me.numeric_S.Location = New System.Drawing.Point(287, 24)
        Me.numeric_S.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numeric_S.Name = "numeric_S"
        Me.numeric_S.Size = New System.Drawing.Size(63, 25)
        Me.numeric_S.TabIndex = 56
        Me.numeric_S.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numeric_S.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label_stiffeners_long
        '
        Me.Label_stiffeners_long.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_stiffeners_long.AutoEllipsis = True
        Me.Label_stiffeners_long.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_stiffeners_long.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_stiffeners_long.Location = New System.Drawing.Point(8, 24)
        Me.Label_stiffeners_long.Name = "Label_stiffeners_long"
        Me.Label_stiffeners_long.Size = New System.Drawing.Size(272, 25)
        Me.Label_stiffeners_long.TabIndex = 55
        Me.Label_stiffeners_long.Text = "Longitudinal Stiffeners (S beams)"
        Me.Label_stiffeners_long.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox_stiffeners_data
        '
        Me.GroupBox_stiffeners_data.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox_stiffeners_data.Controls.Add(Me.GroupBox_input_selection)
        Me.GroupBox_stiffeners_data.Controls.Add(Me.Groupbox_geometric_input)
        Me.GroupBox_stiffeners_data.Controls.Add(Me.GroupBox_numeric_input)
        Me.GroupBox_stiffeners_data.Controls.Add(Me.groupBox_DB_input)
        Me.GroupBox_stiffeners_data.Font = New System.Drawing.Font("David", 13.8!)
        Me.GroupBox_stiffeners_data.Location = New System.Drawing.Point(6, 172)
        Me.GroupBox_stiffeners_data.Name = "GroupBox_stiffeners_data"
        Me.GroupBox_stiffeners_data.Size = New System.Drawing.Size(722, 430)
        Me.GroupBox_stiffeners_data.TabIndex = 48
        Me.GroupBox_stiffeners_data.TabStop = False
        Me.GroupBox_stiffeners_data.Text = "Stiffeners' Properties"
        '
        'GroupBox_input_selection
        '
        Me.GroupBox_input_selection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_input_selection.Controls.Add(Me.Radiobutton_select_geometric)
        Me.GroupBox_input_selection.Controls.Add(Me.Radiobutton_select_numeric)
        Me.GroupBox_input_selection.Controls.Add(Me.Radiobutton_select_DB)
        Me.GroupBox_input_selection.Font = New System.Drawing.Font("David", 12.0!)
        Me.GroupBox_input_selection.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox_input_selection.Name = "GroupBox_input_selection"
        Me.GroupBox_input_selection.Size = New System.Drawing.Size(691, 135)
        Me.GroupBox_input_selection.TabIndex = 44
        Me.GroupBox_input_selection.TabStop = False
        Me.GroupBox_input_selection.Text = "Method of Inputs"
        '
        'Radiobutton_select_geometric
        '
        Me.Radiobutton_select_geometric.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Radiobutton_select_geometric.AutoEllipsis = True
        Me.Radiobutton_select_geometric.Checked = True
        Me.Radiobutton_select_geometric.Font = New System.Drawing.Font("David", 10.8!)
        Me.Radiobutton_select_geometric.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Radiobutton_select_geometric.Location = New System.Drawing.Point(6, 23)
        Me.Radiobutton_select_geometric.Name = "Radiobutton_select_geometric"
        Me.Radiobutton_select_geometric.Size = New System.Drawing.Size(665, 32)
        Me.Radiobutton_select_geometric.TabIndex = 2
        Me.Radiobutton_select_geometric.TabStop = True
        Me.Radiobutton_select_geometric.Text = "Geometric Input (simple cross sections)"
        '
        'Radiobutton_select_numeric
        '
        Me.Radiobutton_select_numeric.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Radiobutton_select_numeric.AutoEllipsis = True
        Me.Radiobutton_select_numeric.Font = New System.Drawing.Font("David", 10.8!)
        Me.Radiobutton_select_numeric.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Radiobutton_select_numeric.Location = New System.Drawing.Point(6, 51)
        Me.Radiobutton_select_numeric.Name = "Radiobutton_select_numeric"
        Me.Radiobutton_select_numeric.Size = New System.Drawing.Size(665, 32)
        Me.Radiobutton_select_numeric.TabIndex = 1
        Me.Radiobutton_select_numeric.Text = "Numerical Input"
        '
        'Radiobutton_select_DB
        '
        Me.Radiobutton_select_DB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Radiobutton_select_DB.AutoEllipsis = True
        Me.Radiobutton_select_DB.Font = New System.Drawing.Font("David", 10.8!)
        Me.Radiobutton_select_DB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Radiobutton_select_DB.Location = New System.Drawing.Point(6, 83)
        Me.Radiobutton_select_DB.Name = "Radiobutton_select_DB"
        Me.Radiobutton_select_DB.Size = New System.Drawing.Size(665, 33)
        Me.Radiobutton_select_DB.TabIndex = 0
        Me.Radiobutton_select_DB.Text = "Database Selection"
        '
        'Groupbox_geometric_input
        '
        Me.Groupbox_geometric_input.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Groupbox_geometric_input.Controls.Add(Me.Button_Geo_selected)
        Me.Groupbox_geometric_input.Controls.Add(Me.TextBox_Geo_result)
        Me.Groupbox_geometric_input.Controls.Add(Me.Label_Geo_result)
        Me.Groupbox_geometric_input.Controls.Add(Me.Combobox_geo_select)
        Me.Groupbox_geometric_input.Controls.Add(Me.PictureBox_Geo_blade)
        Me.Groupbox_geometric_input.Controls.Add(Me.Label_Geo_type_select)
        Me.Groupbox_geometric_input.Controls.Add(Me.GroupBox_geo_input)
        Me.Groupbox_geometric_input.Controls.Add(Me.PictureBox_Geo_L)
        Me.Groupbox_geometric_input.Controls.Add(Me.PictureBox_Geo_T)
        Me.Groupbox_geometric_input.Controls.Add(Me.PictureBox_Geo_I)
        Me.Groupbox_geometric_input.Font = New System.Drawing.Font("David", 12.0!)
        Me.Groupbox_geometric_input.Location = New System.Drawing.Point(12, 169)
        Me.Groupbox_geometric_input.Name = "Groupbox_geometric_input"
        Me.Groupbox_geometric_input.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Groupbox_geometric_input.Size = New System.Drawing.Size(697, 255)
        Me.Groupbox_geometric_input.TabIndex = 46
        Me.Groupbox_geometric_input.TabStop = False
        '
        'Button_Geo_selected
        '
        Me.Button_Geo_selected.AutoEllipsis = True
        Me.Button_Geo_selected.Font = New System.Drawing.Font("David", 10.8!)
        Me.Button_Geo_selected.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_Geo_selected.Location = New System.Drawing.Point(179, 213)
        Me.Button_Geo_selected.Name = "Button_Geo_selected"
        Me.Button_Geo_selected.Size = New System.Drawing.Size(85, 31)
        Me.Button_Geo_selected.TabIndex = 24
        Me.Button_Geo_selected.Text = "OK"
        '
        'TextBox_Geo_result
        '
        Me.TextBox_Geo_result.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Geo_result.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox_Geo_result.Location = New System.Drawing.Point(431, 214)
        Me.TextBox_Geo_result.Name = "TextBox_Geo_result"
        Me.TextBox_Geo_result.ReadOnly = True
        Me.TextBox_Geo_result.Size = New System.Drawing.Size(240, 27)
        Me.TextBox_Geo_result.TabIndex = 17
        Me.TextBox_Geo_result.Text = "N/A"
        Me.TextBox_Geo_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_Geo_result
        '
        Me.Label_Geo_result.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Geo_result.AutoEllipsis = True
        Me.Label_Geo_result.Location = New System.Drawing.Point(390, 173)
        Me.Label_Geo_result.Name = "Label_Geo_result"
        Me.Label_Geo_result.Size = New System.Drawing.Size(299, 33)
        Me.Label_Geo_result.TabIndex = 18
        Me.Label_Geo_result.Text = "Current Moment of Inertia [cm^4]"
        Me.Label_Geo_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Combobox_geo_select
        '
        Me.Combobox_geo_select.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Combobox_geo_select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combobox_geo_select.Font = New System.Drawing.Font("David", 10.8!)
        Me.Combobox_geo_select.ItemHeight = 17
        Me.Combobox_geo_select.Items.AddRange(New Object() {"Blade Stiffener (|)", "L Stiffener", "T Stiffener", "I Stiffener"})
        Me.Combobox_geo_select.Location = New System.Drawing.Point(213, 21)
        Me.Combobox_geo_select.Name = "Combobox_geo_select"
        Me.Combobox_geo_select.Size = New System.Drawing.Size(212, 25)
        Me.Combobox_geo_select.TabIndex = 19
        '
        'PictureBox_Geo_blade
        '
        Me.PictureBox_Geo_blade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox_Geo_blade.Image = CType(resources.GetObject("PictureBox_Geo_blade.Image"), System.Drawing.Image)
        Me.PictureBox_Geo_blade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox_Geo_blade.Location = New System.Drawing.Point(450, 17)
        Me.PictureBox_Geo_blade.Name = "PictureBox_Geo_blade"
        Me.PictureBox_Geo_blade.Size = New System.Drawing.Size(212, 151)
        Me.PictureBox_Geo_blade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Geo_blade.TabIndex = 8
        Me.PictureBox_Geo_blade.TabStop = False
        '
        'Label_Geo_type_select
        '
        Me.Label_Geo_type_select.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Geo_type_select.AutoEllipsis = True
        Me.Label_Geo_type_select.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_Geo_type_select.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_Geo_type_select.Location = New System.Drawing.Point(8, 23)
        Me.Label_Geo_type_select.Name = "Label_Geo_type_select"
        Me.Label_Geo_type_select.Size = New System.Drawing.Size(199, 19)
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
        Me.GroupBox_geo_input.Font = New System.Drawing.Font("David", 10.8!)
        Me.GroupBox_geo_input.Location = New System.Drawing.Point(12, 62)
        Me.GroupBox_geo_input.Name = "GroupBox_geo_input"
        Me.GroupBox_geo_input.Size = New System.Drawing.Size(362, 142)
        Me.GroupBox_geo_input.TabIndex = 14
        Me.GroupBox_geo_input.TabStop = False
        Me.GroupBox_geo_input.Text = "Stiffener"
        '
        'MaskedTextBox_geo_w
        '
        Me.MaskedTextBox_geo_w.Location = New System.Drawing.Point(167, 110)
        Me.MaskedTextBox_geo_w.Name = "MaskedTextBox_geo_w"
        Me.MaskedTextBox_geo_w.Size = New System.Drawing.Size(88, 25)
        Me.MaskedTextBox_geo_w.TabIndex = 23
        Me.MaskedTextBox_geo_w.Visible = False
        '
        'MaskedTextBox_geo_t
        '
        Me.MaskedTextBox_geo_t.Location = New System.Drawing.Point(167, 80)
        Me.MaskedTextBox_geo_t.Name = "MaskedTextBox_geo_t"
        Me.MaskedTextBox_geo_t.Size = New System.Drawing.Size(88, 25)
        Me.MaskedTextBox_geo_t.TabIndex = 22
        Me.MaskedTextBox_geo_t.Visible = False
        '
        'MaskedTextBox_geo_d
        '
        Me.MaskedTextBox_geo_d.Location = New System.Drawing.Point(167, 50)
        Me.MaskedTextBox_geo_d.Name = "MaskedTextBox_geo_d"
        Me.MaskedTextBox_geo_d.Size = New System.Drawing.Size(88, 25)
        Me.MaskedTextBox_geo_d.TabIndex = 21
        Me.MaskedTextBox_geo_d.Text = "80"
        '
        'MaskedTextBox_geo_b
        '
        Me.MaskedTextBox_geo_b.Location = New System.Drawing.Point(167, 20)
        Me.MaskedTextBox_geo_b.Name = "MaskedTextBox_geo_b"
        Me.MaskedTextBox_geo_b.Size = New System.Drawing.Size(88, 25)
        Me.MaskedTextBox_geo_b.TabIndex = 20
        Me.MaskedTextBox_geo_b.Text = "8"
        '
        'Label_unit_mm05
        '
        Me.Label_unit_mm05.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_unit_mm05.AutoEllipsis = True
        Me.Label_unit_mm05.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_unit_mm05.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_unit_mm05.Location = New System.Drawing.Point(286, 110)
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
        Me.Label_geo_w.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_geo_w.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_geo_w.Location = New System.Drawing.Point(3, 110)
        Me.Label_geo_w.Name = "Label_geo_w"
        Me.Label_geo_w.Size = New System.Drawing.Size(150, 23)
        Me.Label_geo_w.TabIndex = 18
        Me.Label_geo_w.Text = "Thickness w"
        Me.Label_geo_w.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_geo_w.Visible = False
        '
        'Label_unit_mm04
        '
        Me.Label_unit_mm04.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_unit_mm04.AutoEllipsis = True
        Me.Label_unit_mm04.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_unit_mm04.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_unit_mm04.Location = New System.Drawing.Point(286, 80)
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
        Me.Label_geo_t.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_geo_t.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_geo_t.Location = New System.Drawing.Point(3, 80)
        Me.Label_geo_t.Name = "Label_geo_t"
        Me.Label_geo_t.Size = New System.Drawing.Size(150, 23)
        Me.Label_geo_t.TabIndex = 12
        Me.Label_geo_t.Text = "Thickness t"
        Me.Label_geo_t.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_geo_t.Visible = False
        '
        'Label_unit_mm03
        '
        Me.Label_unit_mm03.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_unit_mm03.AutoEllipsis = True
        Me.Label_unit_mm03.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_unit_mm03.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_unit_mm03.Location = New System.Drawing.Point(286, 50)
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
        Me.Label_unit_mm02.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_unit_mm02.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_unit_mm02.Location = New System.Drawing.Point(286, 20)
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
        Me.Label_geo_d.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_geo_d.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_geo_d.Location = New System.Drawing.Point(3, 50)
        Me.Label_geo_d.Name = "Label_geo_d"
        Me.Label_geo_d.Size = New System.Drawing.Size(150, 23)
        Me.Label_geo_d.TabIndex = 8
        Me.Label_geo_d.Text = "Height d"
        Me.Label_geo_d.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_geo_b
        '
        Me.Label_geo_b.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_geo_b.AutoEllipsis = True
        Me.Label_geo_b.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_geo_b.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_geo_b.Location = New System.Drawing.Point(3, 20)
        Me.Label_geo_b.Name = "Label_geo_b"
        Me.Label_geo_b.Size = New System.Drawing.Size(150, 23)
        Me.Label_geo_b.TabIndex = 6
        Me.Label_geo_b.Text = "Length b"
        Me.Label_geo_b.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox_Geo_L
        '
        Me.PictureBox_Geo_L.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox_Geo_L.Image = CType(resources.GetObject("PictureBox_Geo_L.Image"), System.Drawing.Image)
        Me.PictureBox_Geo_L.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox_Geo_L.Location = New System.Drawing.Point(450, 17)
        Me.PictureBox_Geo_L.Name = "PictureBox_Geo_L"
        Me.PictureBox_Geo_L.Size = New System.Drawing.Size(212, 151)
        Me.PictureBox_Geo_L.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Geo_L.TabIndex = 12
        Me.PictureBox_Geo_L.TabStop = False
        Me.PictureBox_Geo_L.Visible = False
        '
        'PictureBox_Geo_T
        '
        Me.PictureBox_Geo_T.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox_Geo_T.Image = CType(resources.GetObject("PictureBox_Geo_T.Image"), System.Drawing.Image)
        Me.PictureBox_Geo_T.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox_Geo_T.Location = New System.Drawing.Point(450, 17)
        Me.PictureBox_Geo_T.Name = "PictureBox_Geo_T"
        Me.PictureBox_Geo_T.Size = New System.Drawing.Size(212, 151)
        Me.PictureBox_Geo_T.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Geo_T.TabIndex = 15
        Me.PictureBox_Geo_T.TabStop = False
        Me.PictureBox_Geo_T.Visible = False
        '
        'PictureBox_Geo_I
        '
        Me.PictureBox_Geo_I.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox_Geo_I.Image = CType(resources.GetObject("PictureBox_Geo_I.Image"), System.Drawing.Image)
        Me.PictureBox_Geo_I.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox_Geo_I.Location = New System.Drawing.Point(450, 17)
        Me.PictureBox_Geo_I.Name = "PictureBox_Geo_I"
        Me.PictureBox_Geo_I.Size = New System.Drawing.Size(212, 151)
        Me.PictureBox_Geo_I.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Geo_I.TabIndex = 16
        Me.PictureBox_Geo_I.TabStop = False
        Me.PictureBox_Geo_I.Visible = False
        '
        'GroupBox_numeric_input
        '
        Me.GroupBox_numeric_input.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_numeric_input.Controls.Add(Me.ComboBox_num_center_units)
        Me.GroupBox_numeric_input.Controls.Add(Me.ComboBox_num_area_units)
        Me.GroupBox_numeric_input.Controls.Add(Me.ComboBox_num_moment_units)
        Me.GroupBox_numeric_input.Controls.Add(Me.Label_num_area)
        Me.GroupBox_numeric_input.Controls.Add(Me.TextBox_num_area)
        Me.GroupBox_numeric_input.Controls.Add(Me.Label_num_center)
        Me.GroupBox_numeric_input.Controls.Add(Me.TextBox_num_center)
        Me.GroupBox_numeric_input.Controls.Add(Me.Label_num_moment)
        Me.GroupBox_numeric_input.Controls.Add(Me.TextBox_num_moment)
        Me.GroupBox_numeric_input.Controls.Add(Me.Button_num_selected)
        Me.GroupBox_numeric_input.Controls.Add(Me.PictureBox_numeric)
        Me.GroupBox_numeric_input.Font = New System.Drawing.Font("David", 12.0!)
        Me.GroupBox_numeric_input.Location = New System.Drawing.Point(12, 169)
        Me.GroupBox_numeric_input.Name = "GroupBox_numeric_input"
        Me.GroupBox_numeric_input.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox_numeric_input.Size = New System.Drawing.Size(697, 255)
        Me.GroupBox_numeric_input.TabIndex = 45
        Me.GroupBox_numeric_input.TabStop = False
        Me.GroupBox_numeric_input.Visible = False
        '
        'ComboBox_num_center_units
        '
        Me.ComboBox_num_center_units.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_num_center_units.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_num_center_units.Font = New System.Drawing.Font("David", 10.8!)
        Me.ComboBox_num_center_units.ItemHeight = 17
        Me.ComboBox_num_center_units.Items.AddRange(New Object() {"mm", "cm", "m"})
        Me.ComboBox_num_center_units.Location = New System.Drawing.Point(391, 135)
        Me.ComboBox_num_center_units.Name = "ComboBox_num_center_units"
        Me.ComboBox_num_center_units.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ComboBox_num_center_units.Size = New System.Drawing.Size(84, 25)
        Me.ComboBox_num_center_units.TabIndex = 55
        '
        'ComboBox_num_area_units
        '
        Me.ComboBox_num_area_units.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_num_area_units.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_num_area_units.Font = New System.Drawing.Font("David", 10.8!)
        Me.ComboBox_num_area_units.ItemHeight = 17
        Me.ComboBox_num_area_units.Items.AddRange(New Object() {"mm^2", "cm^2", "m^2"})
        Me.ComboBox_num_area_units.Location = New System.Drawing.Point(391, 80)
        Me.ComboBox_num_area_units.Name = "ComboBox_num_area_units"
        Me.ComboBox_num_area_units.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ComboBox_num_area_units.Size = New System.Drawing.Size(84, 25)
        Me.ComboBox_num_area_units.TabIndex = 54
        '
        'ComboBox_num_moment_units
        '
        Me.ComboBox_num_moment_units.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_num_moment_units.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_num_moment_units.Font = New System.Drawing.Font("David", 10.8!)
        Me.ComboBox_num_moment_units.ItemHeight = 17
        Me.ComboBox_num_moment_units.Items.AddRange(New Object() {"mm^4", "cm^4", "m^4"})
        Me.ComboBox_num_moment_units.Location = New System.Drawing.Point(391, 30)
        Me.ComboBox_num_moment_units.Name = "ComboBox_num_moment_units"
        Me.ComboBox_num_moment_units.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ComboBox_num_moment_units.Size = New System.Drawing.Size(84, 25)
        Me.ComboBox_num_moment_units.TabIndex = 53
        '
        'Label_num_area
        '
        Me.Label_num_area.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_num_area.AutoEllipsis = True
        Me.Label_num_area.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_num_area.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_num_area.Location = New System.Drawing.Point(10, 80)
        Me.Label_num_area.Name = "Label_num_area"
        Me.Label_num_area.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_num_area.Size = New System.Drawing.Size(267, 25)
        Me.Label_num_area.TabIndex = 10
        Me.Label_num_area.Text = "Area of cross section"
        Me.Label_num_area.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_num_area
        '
        Me.TextBox_num_area.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_num_area.Font = New System.Drawing.Font("David", 10.8!)
        Me.TextBox_num_area.Location = New System.Drawing.Point(289, 80)
        Me.TextBox_num_area.Name = "TextBox_num_area"
        Me.TextBox_num_area.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox_num_area.Size = New System.Drawing.Size(88, 25)
        Me.TextBox_num_area.TabIndex = 6
        Me.TextBox_num_area.Text = "0"
        Me.TextBox_num_area.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_num_center
        '
        Me.Label_num_center.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_num_center.AutoEllipsis = True
        Me.Label_num_center.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_num_center.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_num_center.Location = New System.Drawing.Point(10, 116)
        Me.Label_num_center.Name = "Label_num_center"
        Me.Label_num_center.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_num_center.Size = New System.Drawing.Size(267, 57)
        Me.Label_num_center.TabIndex = 7
        Me.Label_num_center.Text = "Center of area with respect to base of stiffener"
        Me.Label_num_center.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_num_center
        '
        Me.TextBox_num_center.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_num_center.Font = New System.Drawing.Font("David", 10.8!)
        Me.TextBox_num_center.Location = New System.Drawing.Point(289, 135)
        Me.TextBox_num_center.Name = "TextBox_num_center"
        Me.TextBox_num_center.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox_num_center.Size = New System.Drawing.Size(88, 25)
        Me.TextBox_num_center.TabIndex = 9
        Me.TextBox_num_center.Text = "0"
        Me.TextBox_num_center.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_num_moment
        '
        Me.Label_num_moment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_num_moment.AutoEllipsis = True
        Me.Label_num_moment.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_num_moment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_num_moment.Location = New System.Drawing.Point(10, 30)
        Me.Label_num_moment.Name = "Label_num_moment"
        Me.Label_num_moment.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_num_moment.Size = New System.Drawing.Size(267, 25)
        Me.Label_num_moment.TabIndex = 5
        Me.Label_num_moment.Text = "Moment of Inertia"
        Me.Label_num_moment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_num_moment
        '
        Me.TextBox_num_moment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_num_moment.Font = New System.Drawing.Font("David", 10.8!)
        Me.TextBox_num_moment.Location = New System.Drawing.Point(289, 30)
        Me.TextBox_num_moment.Name = "TextBox_num_moment"
        Me.TextBox_num_moment.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox_num_moment.Size = New System.Drawing.Size(88, 25)
        Me.TextBox_num_moment.TabIndex = 4
        Me.TextBox_num_moment.Text = "0"
        Me.TextBox_num_moment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button_num_selected
        '
        Me.Button_num_selected.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_num_selected.AutoEllipsis = True
        Me.Button_num_selected.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Button_num_selected.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_num_selected.Location = New System.Drawing.Point(192, 200)
        Me.Button_num_selected.Name = "Button_num_selected"
        Me.Button_num_selected.Size = New System.Drawing.Size(79, 31)
        Me.Button_num_selected.TabIndex = 3
        Me.Button_num_selected.Text = "OK"
        '
        'PictureBox_numeric
        '
        Me.PictureBox_numeric.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox_numeric.Image = CType(resources.GetObject("PictureBox_numeric.Image"), System.Drawing.Image)
        Me.PictureBox_numeric.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox_numeric.Location = New System.Drawing.Point(481, 25)
        Me.PictureBox_numeric.Name = "PictureBox_numeric"
        Me.PictureBox_numeric.Size = New System.Drawing.Size(208, 216)
        Me.PictureBox_numeric.TabIndex = 8
        Me.PictureBox_numeric.TabStop = False
        '
        'groupBox_DB_input
        '
        Me.groupBox_DB_input.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBox_DB_input.Controls.Add(Me.PictureBox_DB_pic02)
        Me.groupBox_DB_input.Controls.Add(Me.Button_DB_selected)
        Me.groupBox_DB_input.Controls.Add(Me.PictureBox_DB_pic01)
        Me.groupBox_DB_input.Controls.Add(Me.groupBox_DB_sub)
        Me.groupBox_DB_input.Font = New System.Drawing.Font("David", 12.0!)
        Me.groupBox_DB_input.Location = New System.Drawing.Point(12, 169)
        Me.groupBox_DB_input.Name = "groupBox_DB_input"
        Me.groupBox_DB_input.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.groupBox_DB_input.Size = New System.Drawing.Size(697, 255)
        Me.groupBox_DB_input.TabIndex = 47
        Me.groupBox_DB_input.TabStop = False
        Me.groupBox_DB_input.Text = "Selection from database of known standards"
        Me.groupBox_DB_input.Visible = False
        '
        'PictureBox_DB_pic02
        '
        Me.PictureBox_DB_pic02.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox_DB_pic02.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_DB_pic02.Image = CType(resources.GetObject("PictureBox_DB_pic02.Image"), System.Drawing.Image)
        Me.PictureBox_DB_pic02.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox_DB_pic02.Location = New System.Drawing.Point(567, 142)
        Me.PictureBox_DB_pic02.Name = "PictureBox_DB_pic02"
        Me.PictureBox_DB_pic02.Size = New System.Drawing.Size(120, 88)
        Me.PictureBox_DB_pic02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_DB_pic02.TabIndex = 4
        Me.PictureBox_DB_pic02.TabStop = False
        '
        'Button_DB_selected
        '
        Me.Button_DB_selected.AutoEllipsis = True
        Me.Button_DB_selected.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Button_DB_selected.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_DB_selected.Location = New System.Drawing.Point(216, 208)
        Me.Button_DB_selected.Name = "Button_DB_selected"
        Me.Button_DB_selected.Size = New System.Drawing.Size(109, 33)
        Me.Button_DB_selected.TabIndex = 3
        Me.Button_DB_selected.Text = "OK"
        '
        'PictureBox_DB_pic01
        '
        Me.PictureBox_DB_pic01.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox_DB_pic01.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_DB_pic01.Image = CType(resources.GetObject("PictureBox_DB_pic01.Image"), System.Drawing.Image)
        Me.PictureBox_DB_pic01.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox_DB_pic01.Location = New System.Drawing.Point(567, 39)
        Me.PictureBox_DB_pic01.Name = "PictureBox_DB_pic01"
        Me.PictureBox_DB_pic01.Size = New System.Drawing.Size(120, 88)
        Me.PictureBox_DB_pic01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_DB_pic01.TabIndex = 0
        Me.PictureBox_DB_pic01.TabStop = False
        '
        'groupBox_DB_sub
        '
        Me.groupBox_DB_sub.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.groupBox_DB_sub.Location = New System.Drawing.Point(14, 32)
        Me.groupBox_DB_sub.Name = "groupBox_DB_sub"
        Me.groupBox_DB_sub.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.groupBox_DB_sub.Size = New System.Drawing.Size(547, 169)
        Me.groupBox_DB_sub.TabIndex = 2
        Me.groupBox_DB_sub.TabStop = False
        Me.groupBox_DB_sub.Text = "Properties of selected stiffener"
        '
        'Label_DB_center_unit
        '
        Me.Label_DB_center_unit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_DB_center_unit.AutoEllipsis = True
        Me.Label_DB_center_unit.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_DB_center_unit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_DB_center_unit.Location = New System.Drawing.Point(460, 125)
        Me.Label_DB_center_unit.Name = "Label_DB_center_unit"
        Me.Label_DB_center_unit.Size = New System.Drawing.Size(75, 27)
        Me.Label_DB_center_unit.TabIndex = 12
        Me.Label_DB_center_unit.Text = "[cm]"
        Me.Label_DB_center_unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button_DB_select03
        '
        Me.Button_DB_select03.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_DB_select03.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_DB_select03.Location = New System.Drawing.Point(422, 125)
        Me.Button_DB_select03.Name = "Button_DB_select03"
        Me.Button_DB_select03.Size = New System.Drawing.Size(32, 27)
        Me.Button_DB_select03.TabIndex = 11
        Me.Button_DB_select03.Text = "..."
        '
        'Label_DB_area_unit
        '
        Me.Label_DB_area_unit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_DB_area_unit.AutoEllipsis = True
        Me.Label_DB_area_unit.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_DB_area_unit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_DB_area_unit.Location = New System.Drawing.Point(460, 78)
        Me.Label_DB_area_unit.Name = "Label_DB_area_unit"
        Me.Label_DB_area_unit.Size = New System.Drawing.Size(75, 27)
        Me.Label_DB_area_unit.TabIndex = 10
        Me.Label_DB_area_unit.Text = "[cm^2]"
        Me.Label_DB_area_unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button_DB_select02
        '
        Me.Button_DB_select02.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_DB_select02.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_DB_select02.Location = New System.Drawing.Point(422, 78)
        Me.Button_DB_select02.Name = "Button_DB_select02"
        Me.Button_DB_select02.Size = New System.Drawing.Size(32, 27)
        Me.Button_DB_select02.TabIndex = 9
        Me.Button_DB_select02.Text = "..."
        '
        'Label_DB_moment_unit
        '
        Me.Label_DB_moment_unit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_DB_moment_unit.AutoEllipsis = True
        Me.Label_DB_moment_unit.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_DB_moment_unit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_DB_moment_unit.Location = New System.Drawing.Point(460, 30)
        Me.Label_DB_moment_unit.Name = "Label_DB_moment_unit"
        Me.Label_DB_moment_unit.Size = New System.Drawing.Size(75, 27)
        Me.Label_DB_moment_unit.TabIndex = 8
        Me.Label_DB_moment_unit.Text = "[cm^4]"
        Me.Label_DB_moment_unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button_DB_select01
        '
        Me.Button_DB_select01.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_DB_select01.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_DB_select01.Location = New System.Drawing.Point(422, 30)
        Me.Button_DB_select01.Name = "Button_DB_select01"
        Me.Button_DB_select01.Size = New System.Drawing.Size(32, 27)
        Me.Button_DB_select01.TabIndex = 7
        Me.Button_DB_select01.Text = "..."
        '
        'Label_DB_center
        '
        Me.Label_DB_center.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_DB_center.AutoEllipsis = True
        Me.Label_DB_center.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_DB_center.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_DB_center.Location = New System.Drawing.Point(12, 126)
        Me.Label_DB_center.Name = "Label_DB_center"
        Me.Label_DB_center.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_DB_center.Size = New System.Drawing.Size(278, 27)
        Me.Label_DB_center.TabIndex = 6
        Me.Label_DB_center.Text = "Center of Area"
        Me.Label_DB_center.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_db_center
        '
        Me.TextBox_db_center.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_db_center.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBox_db_center.Location = New System.Drawing.Point(297, 125)
        Me.TextBox_db_center.Name = "TextBox_db_center"
        Me.TextBox_db_center.ReadOnly = True
        Me.TextBox_db_center.Size = New System.Drawing.Size(119, 27)
        Me.TextBox_db_center.TabIndex = 5
        '
        'Label_DB_area
        '
        Me.Label_DB_area.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_DB_area.AutoEllipsis = True
        Me.Label_DB_area.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_DB_area.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_DB_area.Location = New System.Drawing.Point(9, 68)
        Me.Label_DB_area.Name = "Label_DB_area"
        Me.Label_DB_area.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_DB_area.Size = New System.Drawing.Size(281, 44)
        Me.Label_DB_area.TabIndex = 4
        Me.Label_DB_area.Text = "Area of cross section"
        Me.Label_DB_area.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_db_area
        '
        Me.TextBox_db_area.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_db_area.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBox_db_area.Location = New System.Drawing.Point(297, 77)
        Me.TextBox_db_area.Name = "TextBox_db_area"
        Me.TextBox_db_area.ReadOnly = True
        Me.TextBox_db_area.Size = New System.Drawing.Size(119, 27)
        Me.TextBox_db_area.TabIndex = 3
        '
        'Label_DB_moment
        '
        Me.Label_DB_moment.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_DB_moment.AutoEllipsis = True
        Me.Label_DB_moment.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_DB_moment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_DB_moment.Location = New System.Drawing.Point(9, 25)
        Me.Label_DB_moment.Name = "Label_DB_moment"
        Me.Label_DB_moment.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_DB_moment.Size = New System.Drawing.Size(281, 38)
        Me.Label_DB_moment.TabIndex = 2
        Me.Label_DB_moment.Text = "Moment of Inertia"
        Me.Label_DB_moment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_db_moment
        '
        Me.TextBox_db_moment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_db_moment.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBox_db_moment.Location = New System.Drawing.Point(297, 30)
        Me.TextBox_db_moment.Name = "TextBox_db_moment"
        Me.TextBox_db_moment.ReadOnly = True
        Me.TextBox_db_moment.Size = New System.Drawing.Size(119, 27)
        Me.TextBox_db_moment.TabIndex = 1
        '
        'GroupBox_BC
        '
        Me.GroupBox_BC.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox_BC.Controls.Add(Me.label_GPa)
        Me.GroupBox_BC.Controls.Add(Me.ComboBox_P_units)
        Me.GroupBox_BC.Controls.Add(Me.Button_case04)
        Me.GroupBox_BC.Controls.Add(Me.TextBox_P_input)
        Me.GroupBox_BC.Controls.Add(Me.Button_case01)
        Me.GroupBox_BC.Controls.Add(Me.TextBox_ni_input)
        Me.GroupBox_BC.Controls.Add(Me.Button_case02)
        Me.GroupBox_BC.Controls.Add(Me.Button_case03)
        Me.GroupBox_BC.Controls.Add(Me.TextBox_E_input)
        Me.GroupBox_BC.Controls.Add(Me.Label_pressure)
        Me.GroupBox_BC.Controls.Add(Me.label_ni)
        Me.GroupBox_BC.Controls.Add(Me.Label_modulus)
        Me.GroupBox_BC.Controls.Add(Me.numeric_BC_input)
        Me.GroupBox_BC.Controls.Add(Me.Label_BC)
        Me.GroupBox_BC.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.GroupBox_BC.Location = New System.Drawing.Point(18, 1044)
        Me.GroupBox_BC.Name = "GroupBox_BC"
        Me.GroupBox_BC.Size = New System.Drawing.Size(745, 422)
        Me.GroupBox_BC.TabIndex = 56
        Me.GroupBox_BC.TabStop = False
        Me.GroupBox_BC.Text = "Pressure, Material Properties and BC"
        '
        'label_GPa
        '
        Me.label_GPa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label_GPa.AutoEllipsis = True
        Me.label_GPa.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_GPa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label_GPa.Location = New System.Drawing.Point(663, 60)
        Me.label_GPa.Name = "label_GPa"
        Me.label_GPa.Size = New System.Drawing.Size(60, 25)
        Me.label_GPa.TabIndex = 56
        Me.label_GPa.Text = "[GPa]"
        Me.label_GPa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox_P_units
        '
        Me.ComboBox_P_units.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_P_units.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_P_units.Font = New System.Drawing.Font("David", 10.8!)
        Me.ComboBox_P_units.ItemHeight = 17
        Me.ComboBox_P_units.Items.AddRange(New Object() {"Pa", "Kpa", "Mpa"})
        Me.ComboBox_P_units.Location = New System.Drawing.Point(663, 26)
        Me.ComboBox_P_units.Name = "ComboBox_P_units"
        Me.ComboBox_P_units.Size = New System.Drawing.Size(64, 25)
        Me.ComboBox_P_units.TabIndex = 52
        '
        'Button_case04
        '
        Me.Button_case04.Image = CType(resources.GetObject("Button_case04.Image"), System.Drawing.Image)
        Me.Button_case04.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_case04.Location = New System.Drawing.Point(249, 298)
        Me.Button_case04.Name = "Button_case04"
        Me.Button_case04.Size = New System.Drawing.Size(214, 120)
        Me.Button_case04.TabIndex = 55
        Me.Button_case04.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TextBox_P_input
        '
        Me.TextBox_P_input.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_P_input.Font = New System.Drawing.Font("David", 10.8!)
        Me.TextBox_P_input.Location = New System.Drawing.Point(605, 26)
        Me.TextBox_P_input.Name = "TextBox_P_input"
        Me.TextBox_P_input.Size = New System.Drawing.Size(52, 25)
        Me.TextBox_P_input.TabIndex = 51
        Me.TextBox_P_input.Text = "1000"
        '
        'Button_case01
        '
        Me.Button_case01.Font = New System.Drawing.Font("David", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Button_case01.Image = CType(resources.GetObject("Button_case01.Image"), System.Drawing.Image)
        Me.Button_case01.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_case01.Location = New System.Drawing.Point(12, 162)
        Me.Button_case01.Name = "Button_case01"
        Me.Button_case01.Size = New System.Drawing.Size(214, 120)
        Me.Button_case01.TabIndex = 52
        Me.Button_case01.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TextBox_ni_input
        '
        Me.TextBox_ni_input.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_ni_input.Font = New System.Drawing.Font("David", 10.8!)
        Me.TextBox_ni_input.Location = New System.Drawing.Point(605, 93)
        Me.TextBox_ni_input.Name = "TextBox_ni_input"
        Me.TextBox_ni_input.Size = New System.Drawing.Size(52, 25)
        Me.TextBox_ni_input.TabIndex = 50
        Me.TextBox_ni_input.Text = "0.3"
        '
        'Button_case02
        '
        Me.Button_case02.Image = CType(resources.GetObject("Button_case02.Image"), System.Drawing.Image)
        Me.Button_case02.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_case02.Location = New System.Drawing.Point(249, 162)
        Me.Button_case02.Name = "Button_case02"
        Me.Button_case02.Size = New System.Drawing.Size(214, 120)
        Me.Button_case02.TabIndex = 53
        Me.Button_case02.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button_case03
        '
        Me.Button_case03.Image = CType(resources.GetObject("Button_case03.Image"), System.Drawing.Image)
        Me.Button_case03.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_case03.Location = New System.Drawing.Point(480, 162)
        Me.Button_case03.Name = "Button_case03"
        Me.Button_case03.Size = New System.Drawing.Size(214, 120)
        Me.Button_case03.TabIndex = 54
        Me.Button_case03.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TextBox_E_input
        '
        Me.TextBox_E_input.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_E_input.Font = New System.Drawing.Font("David", 10.8!)
        Me.TextBox_E_input.Location = New System.Drawing.Point(605, 60)
        Me.TextBox_E_input.Name = "TextBox_E_input"
        Me.TextBox_E_input.Size = New System.Drawing.Size(52, 25)
        Me.TextBox_E_input.TabIndex = 49
        Me.TextBox_E_input.Text = "200"
        '
        'Label_pressure
        '
        Me.Label_pressure.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_pressure.AutoEllipsis = True
        Me.Label_pressure.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_pressure.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_pressure.Location = New System.Drawing.Point(6, 26)
        Me.Label_pressure.Name = "Label_pressure"
        Me.Label_pressure.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_pressure.Size = New System.Drawing.Size(582, 25)
        Me.Label_pressure.TabIndex = 48
        Me.Label_pressure.Text = "Uniform Pressure acting on plate"
        Me.Label_pressure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label_ni
        '
        Me.label_ni.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label_ni.AutoEllipsis = True
        Me.label_ni.Font = New System.Drawing.Font("David", 10.8!)
        Me.label_ni.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label_ni.Location = New System.Drawing.Point(8, 93)
        Me.label_ni.Name = "label_ni"
        Me.label_ni.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.label_ni.Size = New System.Drawing.Size(582, 25)
        Me.label_ni.TabIndex = 47
        Me.label_ni.Text = "Poisson's Ratio"
        Me.label_ni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_modulus
        '
        Me.Label_modulus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_modulus.AutoEllipsis = True
        Me.Label_modulus.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_modulus.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_modulus.Location = New System.Drawing.Point(6, 60)
        Me.Label_modulus.Name = "Label_modulus"
        Me.Label_modulus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_modulus.Size = New System.Drawing.Size(582, 25)
        Me.Label_modulus.TabIndex = 46
        Me.Label_modulus.Text = "Modulus of Elasticity (E)"
        Me.Label_modulus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'numeric_BC_input
        '
        Me.numeric_BC_input.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numeric_BC_input.Font = New System.Drawing.Font("David", 10.8!)
        Me.numeric_BC_input.Location = New System.Drawing.Point(605, 126)
        Me.numeric_BC_input.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.numeric_BC_input.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numeric_BC_input.Name = "numeric_BC_input"
        Me.numeric_BC_input.Size = New System.Drawing.Size(52, 25)
        Me.numeric_BC_input.TabIndex = 45
        Me.numeric_BC_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numeric_BC_input.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label_BC
        '
        Me.Label_BC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_BC.AutoEllipsis = True
        Me.Label_BC.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_BC.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_BC.Location = New System.Drawing.Point(8, 126)
        Me.Label_BC.Name = "Label_BC"
        Me.Label_BC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_BC.Size = New System.Drawing.Size(582, 25)
        Me.Label_BC.TabIndex = 44
        Me.Label_BC.Text = "Boundary Condition"
        Me.Label_BC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox_stiffeners_whole
        '
        Me.GroupBox_stiffeners_whole.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox_stiffeners_whole.Controls.Add(Me.GroupBox_stiffeners)
        Me.GroupBox_stiffeners_whole.Controls.Add(Me.GroupBox_stiffeners_data)
        Me.GroupBox_stiffeners_whole.Location = New System.Drawing.Point(18, 356)
        Me.GroupBox_stiffeners_whole.Name = "GroupBox_stiffeners_whole"
        Me.GroupBox_stiffeners_whole.Size = New System.Drawing.Size(745, 620)
        Me.GroupBox_stiffeners_whole.TabIndex = 61
        Me.GroupBox_stiffeners_whole.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox1.AutoEllipsis = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Gold
        Me.CheckBox1.Font = New System.Drawing.Font("David", 13.8!)
        Me.CheckBox1.Location = New System.Drawing.Point(18, 16)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(745, 50)
        Me.CheckBox1.TabIndex = 62
        Me.CheckBox1.Text = "Plate/Panel Properties"
        Me.CheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'CheckBox2
        '
        Me.CheckBox2.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox2.AutoEllipsis = True
        Me.CheckBox2.BackColor = System.Drawing.Color.Gold
        Me.CheckBox2.Font = New System.Drawing.Font("David", 13.8!)
        Me.CheckBox2.Location = New System.Drawing.Point(18, 282)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(745, 50)
        Me.CheckBox2.TabIndex = 63
        Me.CheckBox2.Text = "Stiffeners Properties"
        Me.CheckBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'CheckBox3
        '
        Me.CheckBox3.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox3.AutoEllipsis = True
        Me.CheckBox3.BackColor = System.Drawing.Color.Gold
        Me.CheckBox3.Font = New System.Drawing.Font("David", 13.8!)
        Me.CheckBox3.Location = New System.Drawing.Point(18, 982)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(745, 50)
        Me.CheckBox3.TabIndex = 64
        Me.CheckBox3.Text = "Physical Properties"
        Me.CheckBox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox3.UseVisualStyleBackColor = False
        '
        'GroupBox_results
        '
        Me.GroupBox_results.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox_results.Controls.Add(Me.GroupBox_results_deflection)
        Me.GroupBox_results.Controls.Add(Me.Button_compute)
        Me.GroupBox_results.Controls.Add(Me.GroupBox_results_BM)
        Me.GroupBox_results.Font = New System.Drawing.Font("David", 11.8!)
        Me.GroupBox_results.Location = New System.Drawing.Point(18, 2185)
        Me.GroupBox_results.Name = "GroupBox_results"
        Me.GroupBox_results.Size = New System.Drawing.Size(745, 346)
        Me.GroupBox_results.TabIndex = 69
        Me.GroupBox_results.TabStop = False
        '
        'GroupBox_results_deflection
        '
        Me.GroupBox_results_deflection.Controls.Add(Me.Label_SD_deflection)
        Me.GroupBox_results_deflection.Controls.Add(Me.RichTextBox_results_deflection)
        Me.GroupBox_results_deflection.Controls.Add(Me.NumericUpDown_SD_deflection)
        Me.GroupBox_results_deflection.Controls.Add(Me.Textbox_results_Deflection)
        Me.GroupBox_results_deflection.Font = New System.Drawing.Font("David", 11.8!)
        Me.GroupBox_results_deflection.Location = New System.Drawing.Point(13, 71)
        Me.GroupBox_results_deflection.Name = "GroupBox_results_deflection"
        Me.GroupBox_results_deflection.Size = New System.Drawing.Size(720, 274)
        Me.GroupBox_results_deflection.TabIndex = 71
        Me.GroupBox_results_deflection.TabStop = False
        Me.GroupBox_results_deflection.Text = "Maximum deflection at center of plate"
        '
        'Label_SD_deflection
        '
        Me.Label_SD_deflection.AutoEllipsis = True
        Me.Label_SD_deflection.Font = New System.Drawing.Font("David", 11.8!)
        Me.Label_SD_deflection.Location = New System.Drawing.Point(13, 36)
        Me.Label_SD_deflection.Name = "Label_SD_deflection"
        Me.Label_SD_deflection.Size = New System.Drawing.Size(256, 27)
        Me.Label_SD_deflection.TabIndex = 70
        Me.Label_SD_deflection.Text = "Number of Significant digits:"
        Me.Label_SD_deflection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RichTextBox_results_deflection
        '
        Me.RichTextBox_results_deflection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox_results_deflection.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RichTextBox_results_deflection.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RichTextBox_results_deflection.ForeColor = System.Drawing.Color.Chartreuse
        Me.RichTextBox_results_deflection.Location = New System.Drawing.Point(6, 100)
        Me.RichTextBox_results_deflection.Name = "RichTextBox_results_deflection"
        Me.RichTextBox_results_deflection.ReadOnly = True
        Me.RichTextBox_results_deflection.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RichTextBox_results_deflection.Size = New System.Drawing.Size(698, 165)
        Me.RichTextBox_results_deflection.TabIndex = 68
        Me.RichTextBox_results_deflection.Text = "According to the FEA analyses that were performed, for unstiffened plates, all th" &
    "e relative errors between the analytic estimations and the FEA results are less " &
    "than 10 percents."
        Me.RichTextBox_results_deflection.Visible = False
        '
        'NumericUpDown_SD_deflection
        '
        Me.NumericUpDown_SD_deflection.Location = New System.Drawing.Point(271, 36)
        Me.NumericUpDown_SD_deflection.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.NumericUpDown_SD_deflection.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_SD_deflection.Name = "NumericUpDown_SD_deflection"
        Me.NumericUpDown_SD_deflection.Size = New System.Drawing.Size(48, 27)
        Me.NumericUpDown_SD_deflection.TabIndex = 69
        Me.NumericUpDown_SD_deflection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown_SD_deflection.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Textbox_results_Deflection
        '
        Me.Textbox_results_Deflection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Textbox_results_Deflection.Font = New System.Drawing.Font("David", 28.2!)
        Me.Textbox_results_Deflection.ForeColor = System.Drawing.Color.Gray
        Me.Textbox_results_Deflection.Location = New System.Drawing.Point(328, 25)
        Me.Textbox_results_Deflection.Name = "Textbox_results_Deflection"
        Me.Textbox_results_Deflection.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Textbox_results_Deflection.Size = New System.Drawing.Size(376, 54)
        Me.Textbox_results_Deflection.TabIndex = 65
        Me.Textbox_results_Deflection.Text = "0.00 [mm]"
        Me.Textbox_results_Deflection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button_compute
        '
        Me.Button_compute.AutoEllipsis = True
        Me.Button_compute.Font = New System.Drawing.Font("David", 11.8!)
        Me.Button_compute.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_compute.Location = New System.Drawing.Point(301, 20)
        Me.Button_compute.Name = "Button_compute"
        Me.Button_compute.Size = New System.Drawing.Size(182, 45)
        Me.Button_compute.TabIndex = 64
        Me.Button_compute.Text = "Run calculation"
        '
        'GroupBox_results_BM
        '
        Me.GroupBox_results_BM.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_results_BM.Controls.Add(Me.RichTextBox_results_BM)
        Me.GroupBox_results_BM.Controls.Add(Me.Label_SD_BM)
        Me.GroupBox_results_BM.Controls.Add(Me.NumericUpDown_SD_BM)
        Me.GroupBox_results_BM.Controls.Add(Me.Textbox_results_BM)
        Me.GroupBox_results_BM.Font = New System.Drawing.Font("David", 11.8!)
        Me.GroupBox_results_BM.Location = New System.Drawing.Point(14, 352)
        Me.GroupBox_results_BM.Name = "GroupBox_results_BM"
        Me.GroupBox_results_BM.Size = New System.Drawing.Size(719, 277)
        Me.GroupBox_results_BM.TabIndex = 72
        Me.GroupBox_results_BM.TabStop = False
        Me.GroupBox_results_BM.Text = "Maximum bending moment"
        Me.GroupBox_results_BM.Visible = False
        '
        'RichTextBox_results_BM
        '
        Me.RichTextBox_results_BM.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox_results_BM.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RichTextBox_results_BM.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RichTextBox_results_BM.ForeColor = System.Drawing.Color.Chartreuse
        Me.RichTextBox_results_BM.Location = New System.Drawing.Point(6, 100)
        Me.RichTextBox_results_BM.Name = "RichTextBox_results_BM"
        Me.RichTextBox_results_BM.ReadOnly = True
        Me.RichTextBox_results_BM.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RichTextBox_results_BM.Size = New System.Drawing.Size(698, 165)
        Me.RichTextBox_results_BM.TabIndex = 71
        Me.RichTextBox_results_BM.Text = "According to the FEA analyses that were performed, for unstiffened plates, all th" &
    "e relative errors between the analytic estimations and the FEA results are less " &
    "than 10 percents."
        Me.RichTextBox_results_BM.Visible = False
        '
        'Label_SD_BM
        '
        Me.Label_SD_BM.AutoEllipsis = True
        Me.Label_SD_BM.Font = New System.Drawing.Font("David", 11.8!)
        Me.Label_SD_BM.Location = New System.Drawing.Point(13, 36)
        Me.Label_SD_BM.Name = "Label_SD_BM"
        Me.Label_SD_BM.Size = New System.Drawing.Size(256, 27)
        Me.Label_SD_BM.TabIndex = 70
        Me.Label_SD_BM.Text = "Number of Significant digits:"
        Me.Label_SD_BM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumericUpDown_SD_BM
        '
        Me.NumericUpDown_SD_BM.Location = New System.Drawing.Point(270, 36)
        Me.NumericUpDown_SD_BM.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.NumericUpDown_SD_BM.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_SD_BM.Name = "NumericUpDown_SD_BM"
        Me.NumericUpDown_SD_BM.Size = New System.Drawing.Size(48, 27)
        Me.NumericUpDown_SD_BM.TabIndex = 69
        Me.NumericUpDown_SD_BM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown_SD_BM.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Textbox_results_BM
        '
        Me.Textbox_results_BM.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Textbox_results_BM.Font = New System.Drawing.Font("David", 28.2!)
        Me.Textbox_results_BM.ForeColor = System.Drawing.Color.Gray
        Me.Textbox_results_BM.Location = New System.Drawing.Point(328, 25)
        Me.Textbox_results_BM.Name = "Textbox_results_BM"
        Me.Textbox_results_BM.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Textbox_results_BM.Size = New System.Drawing.Size(376, 54)
        Me.Textbox_results_BM.TabIndex = 65
        Me.Textbox_results_BM.Text = "0.00 [MPa]"
        Me.Textbox_results_BM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CheckBox5
        '
        Me.CheckBox5.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox5.AutoEllipsis = True
        Me.CheckBox5.BackColor = System.Drawing.Color.Gold
        Me.CheckBox5.Font = New System.Drawing.Font("David", 13.8!)
        Me.CheckBox5.Location = New System.Drawing.Point(18, 2124)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(745, 50)
        Me.CheckBox5.TabIndex = 68
        Me.CheckBox5.Text = "Results"
        Me.CheckBox5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox5.UseVisualStyleBackColor = False
        '
        'GroupBox_summary
        '
        Me.GroupBox_summary.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox_summary.Controls.Add(Me.groupbox_plate_geo)
        Me.GroupBox_summary.Controls.Add(Me.GroupBox1)
        Me.GroupBox_summary.Controls.Add(Me.groupbox_general)
        Me.GroupBox_summary.Font = New System.Drawing.Font("David", 12.0!)
        Me.GroupBox_summary.Location = New System.Drawing.Point(18, 1552)
        Me.GroupBox_summary.Name = "GroupBox_summary"
        Me.GroupBox_summary.Size = New System.Drawing.Size(745, 549)
        Me.GroupBox_summary.TabIndex = 67
        Me.GroupBox_summary.TabStop = False
        Me.GroupBox_summary.Text = "Summary of Data"
        '
        'groupbox_plate_geo
        '
        Me.groupbox_plate_geo.Controls.Add(Me.Label5)
        Me.groupbox_plate_geo.Controls.Add(Me.Label6)
        Me.groupbox_plate_geo.Controls.Add(Me.Label7)
        Me.groupbox_plate_geo.Controls.Add(Me.numeric_t)
        Me.groupbox_plate_geo.Controls.Add(Me.numeric_b)
        Me.groupbox_plate_geo.Controls.Add(Me.numeric_a)
        Me.groupbox_plate_geo.Controls.Add(Me.label_t)
        Me.groupbox_plate_geo.Controls.Add(Me.label_a)
        Me.groupbox_plate_geo.Controls.Add(Me.label_b)
        Me.groupbox_plate_geo.Font = New System.Drawing.Font("David", 12.0!)
        Me.groupbox_plate_geo.Location = New System.Drawing.Point(13, 26)
        Me.groupbox_plate_geo.Name = "groupbox_plate_geo"
        Me.groupbox_plate_geo.Size = New System.Drawing.Size(339, 172)
        Me.groupbox_plate_geo.TabIndex = 64
        Me.groupbox_plate_geo.TabStop = False
        Me.groupbox_plate_geo.Text = "Plate Geometry"
        '
        'Label5
        '
        Me.Label5.AutoEllipsis = True
        Me.Label5.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(267, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 25)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "[mm]"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoEllipsis = True
        Me.Label6.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(267, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 25)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "[m]"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoEllipsis = True
        Me.Label7.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(267, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 25)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "[m]"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'numeric_t
        '
        Me.numeric_t.DecimalPlaces = 2
        Me.numeric_t.Font = New System.Drawing.Font("David", 10.8!)
        Me.numeric_t.Location = New System.Drawing.Point(190, 88)
        Me.numeric_t.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.numeric_t.Name = "numeric_t"
        Me.numeric_t.ReadOnly = True
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
        Me.numeric_b.Name = "numeric_b"
        Me.numeric_b.ReadOnly = True
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
        Me.numeric_a.Name = "numeric_a"
        Me.numeric_a.ReadOnly = True
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
        'label_a
        '
        Me.label_a.AutoEllipsis = True
        Me.label_a.Font = New System.Drawing.Font("David", 10.8!)
        Me.label_a.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label_a.Location = New System.Drawing.Point(7, 56)
        Me.label_a.Name = "label_a"
        Me.label_a.Size = New System.Drawing.Size(165, 25)
        Me.label_a.TabIndex = 10
        Me.label_a.Text = "Breadth b"
        Me.label_a.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label_b
        '
        Me.label_b.AutoEllipsis = True
        Me.label_b.Font = New System.Drawing.Font("David", 10.8!)
        Me.label_b.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label_b.Location = New System.Drawing.Point(7, 25)
        Me.label_b.Name = "label_b"
        Me.label_b.Size = New System.Drawing.Size(165, 25)
        Me.label_b.TabIndex = 8
        Me.label_b.Text = "Length a"
        Me.label_b.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox_Ar_stiffeners)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.TextBox_Yr_stiffeners)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.TextBox_Ir_stiffeners)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.TextBox_As_stiffeners)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TextBox_Ys_stiffeners)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TextBox_Is_stiffeners)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.numeric_s_sum)
        Me.GroupBox1.Controls.Add(Me.numeric_r_sum)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 209)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(726, 324)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Stiffeners"
        '
        'TextBox_Ar_stiffeners
        '
        Me.TextBox_Ar_stiffeners.Font = New System.Drawing.Font("David", 10.8!)
        Me.TextBox_Ar_stiffeners.Location = New System.Drawing.Point(361, 240)
        Me.TextBox_Ar_stiffeners.Name = "TextBox_Ar_stiffeners"
        Me.TextBox_Ar_stiffeners.ReadOnly = True
        Me.TextBox_Ar_stiffeners.Size = New System.Drawing.Size(278, 25)
        Me.TextBox_Ar_stiffeners.TabIndex = 61
        Me.TextBox_Ar_stiffeners.Text = "0"
        Me.TextBox_Ar_stiffeners.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoEllipsis = True
        Me.Label13.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(47, 240)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(308, 25)
        Me.Label13.TabIndex = 60
        Me.Label13.Text = "Cross-section Area"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_Yr_stiffeners
        '
        Me.TextBox_Yr_stiffeners.Font = New System.Drawing.Font("David", 10.8!)
        Me.TextBox_Yr_stiffeners.Location = New System.Drawing.Point(361, 209)
        Me.TextBox_Yr_stiffeners.Name = "TextBox_Yr_stiffeners"
        Me.TextBox_Yr_stiffeners.ReadOnly = True
        Me.TextBox_Yr_stiffeners.Size = New System.Drawing.Size(278, 25)
        Me.TextBox_Yr_stiffeners.TabIndex = 59
        Me.TextBox_Yr_stiffeners.Text = "0"
        Me.TextBox_Yr_stiffeners.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoEllipsis = True
        Me.Label14.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(47, 209)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(308, 25)
        Me.Label14.TabIndex = 58
        Me.Label14.Text = "Centroid"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_Ir_stiffeners
        '
        Me.TextBox_Ir_stiffeners.Font = New System.Drawing.Font("David", 10.8!)
        Me.TextBox_Ir_stiffeners.Location = New System.Drawing.Point(361, 178)
        Me.TextBox_Ir_stiffeners.Name = "TextBox_Ir_stiffeners"
        Me.TextBox_Ir_stiffeners.ReadOnly = True
        Me.TextBox_Ir_stiffeners.Size = New System.Drawing.Size(278, 25)
        Me.TextBox_Ir_stiffeners.TabIndex = 57
        Me.TextBox_Ir_stiffeners.Text = "0"
        Me.TextBox_Ir_stiffeners.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoEllipsis = True
        Me.Label15.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(47, 178)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(308, 25)
        Me.Label15.TabIndex = 56
        Me.Label15.Text = "Moment of Inertia:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_As_stiffeners
        '
        Me.TextBox_As_stiffeners.Font = New System.Drawing.Font("David", 10.8!)
        Me.TextBox_As_stiffeners.Location = New System.Drawing.Point(360, 109)
        Me.TextBox_As_stiffeners.Name = "TextBox_As_stiffeners"
        Me.TextBox_As_stiffeners.ReadOnly = True
        Me.TextBox_As_stiffeners.Size = New System.Drawing.Size(278, 25)
        Me.TextBox_As_stiffeners.TabIndex = 55
        Me.TextBox_As_stiffeners.Text = "0"
        Me.TextBox_As_stiffeners.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoEllipsis = True
        Me.Label12.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(46, 109)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(308, 25)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "Cross-section Area"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_Ys_stiffeners
        '
        Me.TextBox_Ys_stiffeners.Font = New System.Drawing.Font("David", 10.8!)
        Me.TextBox_Ys_stiffeners.Location = New System.Drawing.Point(360, 78)
        Me.TextBox_Ys_stiffeners.Name = "TextBox_Ys_stiffeners"
        Me.TextBox_Ys_stiffeners.ReadOnly = True
        Me.TextBox_Ys_stiffeners.Size = New System.Drawing.Size(278, 25)
        Me.TextBox_Ys_stiffeners.TabIndex = 53
        Me.TextBox_Ys_stiffeners.Text = "0"
        Me.TextBox_Ys_stiffeners.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoEllipsis = True
        Me.Label11.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(46, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(308, 25)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "Centroid"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_Is_stiffeners
        '
        Me.TextBox_Is_stiffeners.Font = New System.Drawing.Font("David", 10.8!)
        Me.TextBox_Is_stiffeners.Location = New System.Drawing.Point(360, 47)
        Me.TextBox_Is_stiffeners.Name = "TextBox_Is_stiffeners"
        Me.TextBox_Is_stiffeners.ReadOnly = True
        Me.TextBox_Is_stiffeners.Size = New System.Drawing.Size(278, 25)
        Me.TextBox_Is_stiffeners.TabIndex = 51
        Me.TextBox_Is_stiffeners.Text = "0"
        Me.TextBox_Is_stiffeners.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoEllipsis = True
        Me.Label10.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(46, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(308, 25)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Moment of Inertia:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'numeric_s_sum
        '
        Me.numeric_s_sum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numeric_s_sum.Font = New System.Drawing.Font("David", 10.8!)
        Me.numeric_s_sum.Location = New System.Drawing.Point(572, 16)
        Me.numeric_s_sum.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.numeric_s_sum.Name = "numeric_s_sum"
        Me.numeric_s_sum.ReadOnly = True
        Me.numeric_s_sum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numeric_s_sum.Size = New System.Drawing.Size(66, 25)
        Me.numeric_s_sum.TabIndex = 9
        Me.numeric_s_sum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numeric_s_sum.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numeric_r_sum
        '
        Me.numeric_r_sum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numeric_r_sum.Font = New System.Drawing.Font("David", 10.8!)
        Me.numeric_r_sum.Location = New System.Drawing.Point(572, 144)
        Me.numeric_r_sum.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.numeric_r_sum.Name = "numeric_r_sum"
        Me.numeric_r_sum.ReadOnly = True
        Me.numeric_r_sum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numeric_r_sum.Size = New System.Drawing.Size(66, 25)
        Me.numeric_r_sum.TabIndex = 7
        Me.numeric_r_sum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numeric_r_sum.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoEllipsis = True
        Me.Label8.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(11, 144)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(549, 25)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Transverses"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoEllipsis = True
        Me.Label9.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(11, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(549, 25)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Longitudinals"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'groupbox_general
        '
        Me.groupbox_general.Controls.Add(Me.Label1)
        Me.groupbox_general.Controls.Add(Me.button_BC_select)
        Me.groupbox_general.Controls.Add(Me.ComboBox1)
        Me.groupbox_general.Controls.Add(Me.TextBox_P)
        Me.groupbox_general.Controls.Add(Me.TextBox_ni)
        Me.groupbox_general.Controls.Add(Me.TextBox_E)
        Me.groupbox_general.Controls.Add(Me.Label2)
        Me.groupbox_general.Controls.Add(Me.Label3)
        Me.groupbox_general.Controls.Add(Me.Label_E)
        Me.groupbox_general.Controls.Add(Me.numeric_case_input)
        Me.groupbox_general.Controls.Add(Me.Label4)
        Me.groupbox_general.Font = New System.Drawing.Font("David", 12.0!)
        Me.groupbox_general.Location = New System.Drawing.Point(361, 26)
        Me.groupbox_general.Name = "groupbox_general"
        Me.groupbox_general.Size = New System.Drawing.Size(378, 172)
        Me.groupbox_general.TabIndex = 65
        Me.groupbox_general.TabStop = False
        Me.groupbox_general.Text = "General Properties"
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(39, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(52, 25)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "[GPa]"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'button_BC_select
        '
        Me.button_BC_select.AutoEllipsis = True
        Me.button_BC_select.Enabled = False
        Me.button_BC_select.Font = New System.Drawing.Font("David", 10.8!)
        Me.button_BC_select.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.button_BC_select.Location = New System.Drawing.Point(6, 138)
        Me.button_BC_select.Name = "button_BC_select"
        Me.button_BC_select.Size = New System.Drawing.Size(81, 28)
        Me.button_BC_select.TabIndex = 53
        Me.button_BC_select.Text = "change"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.Font = New System.Drawing.Font("David", 10.8!)
        Me.ComboBox1.ItemHeight = 17
        Me.ComboBox1.Items.AddRange(New Object() {"Pa", "Kpa", "Mpa"})
        Me.ComboBox1.Location = New System.Drawing.Point(6, 30)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(81, 25)
        Me.ComboBox1.TabIndex = 52
        '
        'TextBox_P
        '
        Me.TextBox_P.Font = New System.Drawing.Font("David", 10.8!)
        Me.TextBox_P.Location = New System.Drawing.Point(96, 30)
        Me.TextBox_P.Name = "TextBox_P"
        Me.TextBox_P.ReadOnly = True
        Me.TextBox_P.Size = New System.Drawing.Size(52, 25)
        Me.TextBox_P.TabIndex = 51
        Me.TextBox_P.Text = "0"
        Me.TextBox_P.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_ni
        '
        Me.TextBox_ni.Font = New System.Drawing.Font("David", 10.8!)
        Me.TextBox_ni.Location = New System.Drawing.Point(96, 110)
        Me.TextBox_ni.Name = "TextBox_ni"
        Me.TextBox_ni.ReadOnly = True
        Me.TextBox_ni.Size = New System.Drawing.Size(52, 25)
        Me.TextBox_ni.TabIndex = 50
        Me.TextBox_ni.Text = "0"
        Me.TextBox_ni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_E
        '
        Me.TextBox_E.Font = New System.Drawing.Font("David", 10.8!)
        Me.TextBox_E.Location = New System.Drawing.Point(96, 80)
        Me.TextBox_E.Name = "TextBox_E"
        Me.TextBox_E.ReadOnly = True
        Me.TextBox_E.Size = New System.Drawing.Size(52, 25)
        Me.TextBox_E.TabIndex = 49
        Me.TextBox_E.Text = "0"
        Me.TextBox_E.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoEllipsis = True
        Me.Label2.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(149, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(180, 44)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Uniform pressure acting on plate"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoEllipsis = True
        Me.Label3.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(149, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(183, 25)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Poisson's Ratio"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_E
        '
        Me.Label_E.AutoEllipsis = True
        Me.Label_E.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_E.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_E.Location = New System.Drawing.Point(149, 80)
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
        Me.numeric_case_input.Location = New System.Drawing.Point(96, 140)
        Me.numeric_case_input.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.numeric_case_input.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numeric_case_input.Name = "numeric_case_input"
        Me.numeric_case_input.ReadOnly = True
        Me.numeric_case_input.Size = New System.Drawing.Size(52, 25)
        Me.numeric_case_input.TabIndex = 45
        Me.numeric_case_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numeric_case_input.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoEllipsis = True
        Me.Label4.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(149, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(180, 25)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Boundary condition"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CheckBox4
        '
        Me.CheckBox4.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox4.AutoEllipsis = True
        Me.CheckBox4.BackColor = System.Drawing.Color.Gold
        Me.CheckBox4.Font = New System.Drawing.Font("David", 13.8!)
        Me.CheckBox4.Location = New System.Drawing.Point(18, 1493)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(745, 50)
        Me.CheckBox4.TabIndex = 63
        Me.CheckBox4.Text = "Summary of Data"
        Me.CheckBox4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox4.UseVisualStyleBackColor = False
        '
        'GroupBox_export
        '
        Me.GroupBox_export.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox_export.Controls.Add(Me.RichTextBox_result_for_saving)
        Me.GroupBox_export.Controls.Add(Me.button_results_save_HTML)
        Me.GroupBox_export.Controls.Add(Me.GroupBox_choose_language)
        Me.GroupBox_export.Controls.Add(Me.button_results_clear)
        Me.GroupBox_export.Controls.Add(Me.button_results_save)
        Me.GroupBox_export.Location = New System.Drawing.Point(18, 3010)
        Me.GroupBox_export.Name = "GroupBox_export"
        Me.GroupBox_export.Size = New System.Drawing.Size(745, 641)
        Me.GroupBox_export.TabIndex = 67
        Me.GroupBox_export.TabStop = False
        '
        'RichTextBox_result_for_saving
        '
        Me.RichTextBox_result_for_saving.BackColor = System.Drawing.Color.White
        Me.RichTextBox_result_for_saving.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.RichTextBox_result_for_saving.Location = New System.Drawing.Point(18, 294)
        Me.RichTextBox_result_for_saving.Name = "RichTextBox_result_for_saving"
        Me.RichTextBox_result_for_saving.ReadOnly = True
        Me.RichTextBox_result_for_saving.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RichTextBox_result_for_saving.Size = New System.Drawing.Size(604, 224)
        Me.RichTextBox_result_for_saving.TabIndex = 68
        Me.RichTextBox_result_for_saving.Text = ""
        Me.RichTextBox_result_for_saving.WordWrap = False
        '
        'button_results_save_HTML
        '
        Me.button_results_save_HTML.Font = New System.Drawing.Font("David", 13.8!)
        Me.button_results_save_HTML.Location = New System.Drawing.Point(201, 583)
        Me.button_results_save_HTML.Name = "button_results_save_HTML"
        Me.button_results_save_HTML.Size = New System.Drawing.Size(305, 51)
        Me.button_results_save_HTML.TabIndex = 72
        Me.button_results_save_HTML.Text = "Generate HTML Report"
        Me.button_results_save_HTML.UseVisualStyleBackColor = True
        Me.button_results_save_HTML.Visible = False
        '
        'GroupBox_choose_language
        '
        Me.GroupBox_choose_language.Controls.Add(Me.GroupBox_update)
        Me.GroupBox_choose_language.Controls.Add(Me.RadioButton_other_language)
        Me.GroupBox_choose_language.Controls.Add(Me.RadioButton_default_english)
        Me.GroupBox_choose_language.Controls.Add(Me.RichTextBox_result_for_saving_HTML)
        Me.GroupBox_choose_language.Location = New System.Drawing.Point(18, 23)
        Me.GroupBox_choose_language.Name = "GroupBox_choose_language"
        Me.GroupBox_choose_language.Size = New System.Drawing.Size(604, 246)
        Me.GroupBox_choose_language.TabIndex = 71
        Me.GroupBox_choose_language.TabStop = False
        '
        'GroupBox_update
        '
        Me.GroupBox_update.Controls.Add(Me.RadioButton_add_replace)
        Me.GroupBox_update.Controls.Add(Me.Button_update)
        Me.GroupBox_update.Controls.Add(Me.RadioButton_add_after)
        Me.GroupBox_update.Location = New System.Drawing.Point(16, 85)
        Me.GroupBox_update.Name = "GroupBox_update"
        Me.GroupBox_update.Size = New System.Drawing.Size(566, 155)
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
        Me.Button_update.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Button_update.Location = New System.Drawing.Point(215, 103)
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
        Me.RadioButton_default_english.Text = "Use the default English language for displaying Intermediate calculations"
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
        'button_results_clear
        '
        Me.button_results_clear.Font = New System.Drawing.Font("David", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.button_results_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_results_clear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.button_results_clear.Location = New System.Drawing.Point(201, 526)
        Me.button_results_clear.Name = "button_results_clear"
        Me.button_results_clear.Size = New System.Drawing.Size(100, 48)
        Me.button_results_clear.TabIndex = 70
        Me.button_results_clear.Text = "Clear"
        '
        'button_results_save
        '
        Me.button_results_save.Font = New System.Drawing.Font("David", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.button_results_save.Image = CType(resources.GetObject("button_results_save.Image"), System.Drawing.Image)
        Me.button_results_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_results_save.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.button_results_save.Location = New System.Drawing.Point(313, 526)
        Me.button_results_save.Name = "button_results_save"
        Me.button_results_save.Size = New System.Drawing.Size(193, 48)
        Me.button_results_save.TabIndex = 69
        Me.button_results_save.Text = "Save Output"
        Me.button_results_save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox_ADINA
        '
        Me.GroupBox_ADINA.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox_ADINA.Controls.Add(Me.GroupBox_creation_type)
        Me.GroupBox_ADINA.Controls.Add(Me.Label_affiliated)
        Me.GroupBox_ADINA.Controls.Add(Me.PictureBox02)
        Me.GroupBox_ADINA.Controls.Add(Me.PictureBox01)
        Me.GroupBox_ADINA.Controls.Add(Me.Button_Run_ADINA)
        Me.GroupBox_ADINA.Controls.Add(Me.Button_feed_ADINA)
        Me.GroupBox_ADINA.Controls.Add(Me.RichTextBox_model_qualify)
        Me.GroupBox_ADINA.Controls.Add(Me.RichTextBox_adina_msg)
        Me.GroupBox_ADINA.Controls.Add(Me.Label_Adina)
        Me.GroupBox_ADINA.Location = New System.Drawing.Point(18, 3736)
        Me.GroupBox_ADINA.Name = "GroupBox_ADINA"
        Me.GroupBox_ADINA.Size = New System.Drawing.Size(745, 621)
        Me.GroupBox_ADINA.TabIndex = 66
        Me.GroupBox_ADINA.TabStop = False
        '
        'GroupBox_creation_type
        '
        Me.GroupBox_creation_type.Controls.Add(Me.RadioButton_normal)
        Me.GroupBox_creation_type.Controls.Add(Me.RadioButton_fast)
        Me.GroupBox_creation_type.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.GroupBox_creation_type.Location = New System.Drawing.Point(26, 441)
        Me.GroupBox_creation_type.Name = "GroupBox_creation_type"
        Me.GroupBox_creation_type.Size = New System.Drawing.Size(712, 96)
        Me.GroupBox_creation_type.TabIndex = 67
        Me.GroupBox_creation_type.TabStop = False
        Me.GroupBox_creation_type.Text = "ADD THIS TO LANG FILES"
        '
        'RadioButton_normal
        '
        Me.RadioButton_normal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButton_normal.AutoEllipsis = True
        Me.RadioButton_normal.Location = New System.Drawing.Point(4, 21)
        Me.RadioButton_normal.Name = "RadioButton_normal"
        Me.RadioButton_normal.Size = New System.Drawing.Size(693, 30)
        Me.RadioButton_normal.TabIndex = 1
        Me.RadioButton_normal.Text = "Normal ADINA session creation (Full loading of ADINA generator GUI)"
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
        Me.RadioButton_fast.Size = New System.Drawing.Size(698, 29)
        Me.RadioButton_fast.TabIndex = 0
        Me.RadioButton_fast.TabStop = True
        Me.RadioButton_fast.Text = "Fast ADINA session creation (Auto save dialog box & closing of ADINA generator GU" &
    "I)"
        Me.RadioButton_fast.UseMnemonic = False
        Me.RadioButton_fast.UseVisualStyleBackColor = True
        '
        'Label_affiliated
        '
        Me.Label_affiliated.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label_affiliated.Font = New System.Drawing.Font("David", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_affiliated.ForeColor = System.Drawing.Color.Black
        Me.Label_affiliated.Location = New System.Drawing.Point(3, 573)
        Me.Label_affiliated.Name = "Label_affiliated"
        Me.Label_affiliated.Size = New System.Drawing.Size(739, 45)
        Me.Label_affiliated.TabIndex = 66
        Me.Label_affiliated.Text = """ADINA Generator"" is in no way affiliated with ADINA R & D ,Inc. All ADINA tradem" &
    "arks and copyrights, except ""ADINA Generator"", are the property of their respect" &
    "ive holders."
        Me.Label_affiliated.UseMnemonic = False
        '
        'PictureBox02
        '
        Me.PictureBox02.Image = CType(resources.GetObject("PictureBox02.Image"), System.Drawing.Image)
        Me.PictureBox02.Location = New System.Drawing.Point(579, 362)
        Me.PictureBox02.Name = "PictureBox02"
        Me.PictureBox02.Size = New System.Drawing.Size(157, 55)
        Me.PictureBox02.TabIndex = 65
        Me.PictureBox02.TabStop = False
        Me.PictureBox02.Visible = False
        '
        'PictureBox01
        '
        Me.PictureBox01.Image = CType(resources.GetObject("PictureBox01.Image"), System.Drawing.Image)
        Me.PictureBox01.Location = New System.Drawing.Point(25, 362)
        Me.PictureBox01.Name = "PictureBox01"
        Me.PictureBox01.Size = New System.Drawing.Size(157, 55)
        Me.PictureBox01.TabIndex = 64
        Me.PictureBox01.TabStop = False
        Me.PictureBox01.Visible = False
        '
        'Button_Run_ADINA
        '
        Me.Button_Run_ADINA.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Button_Run_ADINA.Location = New System.Drawing.Point(383, 342)
        Me.Button_Run_ADINA.Name = "Button_Run_ADINA"
        Me.Button_Run_ADINA.Size = New System.Drawing.Size(180, 88)
        Me.Button_Run_ADINA.TabIndex = 63
        Me.Button_Run_ADINA.Text = "Run ADINA Generator"
        Me.Button_Run_ADINA.Visible = False
        '
        'Button_feed_ADINA
        '
        Me.Button_feed_ADINA.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Button_feed_ADINA.Location = New System.Drawing.Point(189, 342)
        Me.Button_feed_ADINA.Name = "Button_feed_ADINA"
        Me.Button_feed_ADINA.Size = New System.Drawing.Size(180, 88)
        Me.Button_feed_ADINA.TabIndex = 62
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
        Me.RichTextBox_model_qualify.Location = New System.Drawing.Point(25, 218)
        Me.RichTextBox_model_qualify.Name = "RichTextBox_model_qualify"
        Me.RichTextBox_model_qualify.ReadOnly = True
        Me.RichTextBox_model_qualify.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RichTextBox_model_qualify.ShowSelectionMargin = True
        Me.RichTextBox_model_qualify.Size = New System.Drawing.Size(681, 107)
        Me.RichTextBox_model_qualify.TabIndex = 61
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
        Me.RichTextBox_adina_msg.Location = New System.Drawing.Point(25, 90)
        Me.RichTextBox_adina_msg.Name = "RichTextBox_adina_msg"
        Me.RichTextBox_adina_msg.ReadOnly = True
        Me.RichTextBox_adina_msg.ShowSelectionMargin = True
        Me.RichTextBox_adina_msg.Size = New System.Drawing.Size(683, 112)
        Me.RichTextBox_adina_msg.TabIndex = 60
        Me.RichTextBox_adina_msg.Text = "ההגבלות הגאומטריות עבור ADINA Generator הן כדלקמן:" & Global.Microsoft.VisualBasic.ChrW(10) & "•  כל החיזוקים חייבים להיות בע" &
    "לי אותו גובה (עובי יכול להיות שונה)." & Global.Microsoft.VisualBasic.ChrW(10) & "•  לפחות חיזוק אחד חייב להיות בכל ציר."
        '
        'Label_Adina
        '
        Me.Label_Adina.AutoEllipsis = True
        Me.Label_Adina.Font = New System.Drawing.Font("David", 22.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_Adina.Location = New System.Drawing.Point(21, 26)
        Me.Label_Adina.Name = "Label_Adina"
        Me.Label_Adina.Size = New System.Drawing.Size(724, 52)
        Me.Label_Adina.TabIndex = 59
        Me.Label_Adina.Text = "ADINA Finite Element Model Creation"
        Me.Label_Adina.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CheckBox7
        '
        Me.CheckBox7.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox7.AutoEllipsis = True
        Me.CheckBox7.BackColor = System.Drawing.Color.Gold
        Me.CheckBox7.Font = New System.Drawing.Font("David", 13.8!)
        Me.CheckBox7.Location = New System.Drawing.Point(18, 3676)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(745, 50)
        Me.CheckBox7.TabIndex = 65
        Me.CheckBox7.Text = "ADINA Model generator"
        Me.CheckBox7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox7.UseVisualStyleBackColor = False
        '
        'CheckBox6
        '
        Me.CheckBox6.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox6.AutoEllipsis = True
        Me.CheckBox6.BackColor = System.Drawing.Color.Gold
        Me.CheckBox6.Font = New System.Drawing.Font("David", 13.8!)
        Me.CheckBox6.Location = New System.Drawing.Point(18, 2947)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(745, 50)
        Me.CheckBox6.TabIndex = 64
        Me.CheckBox6.Text = "Exporting results"
        Me.CheckBox6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox6.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 714)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1028, 26)
        Me.StatusStrip1.TabIndex = 67
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(249, 20)
        Me.ToolStripStatusLabel1.Text = "Preprocessing step is not completed"
        '
        'Panel_right
        '
        Me.Panel_right.AutoScroll = True
        Me.Panel_right.Controls.Add(Me.CheckBox1)
        Me.Panel_right.Controls.Add(Me.GroupBox_export)
        Me.Panel_right.Controls.Add(Me.GroupBox_plate)
        Me.Panel_right.Controls.Add(Me.GroupBox_results)
        Me.Panel_right.Controls.Add(Me.CheckBox2)
        Me.Panel_right.Controls.Add(Me.GroupBox_ADINA)
        Me.Panel_right.Controls.Add(Me.GroupBox_stiffeners_whole)
        Me.Panel_right.Controls.Add(Me.CheckBox5)
        Me.Panel_right.Controls.Add(Me.CheckBox4)
        Me.Panel_right.Controls.Add(Me.CheckBox7)
        Me.Panel_right.Controls.Add(Me.CheckBox3)
        Me.Panel_right.Controls.Add(Me.GroupBox_BC)
        Me.Panel_right.Controls.Add(Me.GroupBox_summary)
        Me.Panel_right.Controls.Add(Me.CheckBox6)
        Me.Panel_right.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_right.Location = New System.Drawing.Point(216, 24)
        Me.Panel_right.Name = "Panel_right"
        Me.Panel_right.Size = New System.Drawing.Size(812, 690)
        Me.Panel_right.TabIndex = 70
        Me.Panel_right.Visible = False
        '
        'GUI_grillage_model
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1028, 740)
        Me.Controls.Add(Me.Panel_right)
        Me.Controls.Add(Me.TreeView_steps)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "GUI_grillage_model"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "The Grillage Model  for Maximum Deflection & Bending Moment"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox_plate.ResumeLayout(False)
        CType(Me.numeric_plate_t, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numeric_plate_short, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numeric_plate_long, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_plate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_stiffeners.ResumeLayout(False)
        Me.GroupBox_stiffeners_mark.ResumeLayout(False)
        CType(Me.PictureBox_S, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_R, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_stiffeners_number.ResumeLayout(False)
        CType(Me.numeric_R, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numeric_S, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_stiffeners_data.ResumeLayout(False)
        Me.GroupBox_input_selection.ResumeLayout(False)
        Me.Groupbox_geometric_input.ResumeLayout(False)
        Me.Groupbox_geometric_input.PerformLayout()
        CType(Me.PictureBox_Geo_blade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_geo_input.ResumeLayout(False)
        Me.GroupBox_geo_input.PerformLayout()
        CType(Me.PictureBox_Geo_L, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Geo_T, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Geo_I, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_numeric_input.ResumeLayout(False)
        Me.GroupBox_numeric_input.PerformLayout()
        CType(Me.PictureBox_numeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox_DB_input.ResumeLayout(False)
        CType(Me.PictureBox_DB_pic02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_DB_pic01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox_DB_sub.ResumeLayout(False)
        Me.groupBox_DB_sub.PerformLayout()
        Me.GroupBox_BC.ResumeLayout(False)
        Me.GroupBox_BC.PerformLayout()
        CType(Me.numeric_BC_input, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_stiffeners_whole.ResumeLayout(False)
        Me.GroupBox_results.ResumeLayout(False)
        Me.GroupBox_results_deflection.ResumeLayout(False)
        Me.GroupBox_results_deflection.PerformLayout()
        CType(Me.NumericUpDown_SD_deflection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_results_BM.ResumeLayout(False)
        Me.GroupBox_results_BM.PerformLayout()
        CType(Me.NumericUpDown_SD_BM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_summary.ResumeLayout(False)
        Me.groupbox_plate_geo.ResumeLayout(False)
        CType(Me.numeric_t, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numeric_b, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numeric_a, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numeric_s_sum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numeric_r_sum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupbox_general.ResumeLayout(False)
        Me.groupbox_general.PerformLayout()
        CType(Me.numeric_case_input, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_export.ResumeLayout(False)
        Me.GroupBox_choose_language.ResumeLayout(False)
        Me.GroupBox_update.ResumeLayout(False)
        Me.GroupBox_ADINA.ResumeLayout(False)
        Me.GroupBox_creation_type.ResumeLayout(False)
        CType(Me.PictureBox02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel_right.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TreeView_steps As System.Windows.Forms.TreeView
    Friend WithEvents GroupBox_plate As System.Windows.Forms.GroupBox
    Friend WithEvents Label_long As System.Windows.Forms.Label
    Friend WithEvents Label_short As System.Windows.Forms.Label
    Friend WithEvents Label_thickness As System.Windows.Forms.Label
    Friend WithEvents numeric_plate_t As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label_breadth As System.Windows.Forms.Label
    Friend WithEvents numeric_plate_short As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label_length As System.Windows.Forms.Label
    Friend WithEvents numeric_plate_long As System.Windows.Forms.NumericUpDown
    Friend WithEvents PictureBox_plate As System.Windows.Forms.PictureBox
    Friend WithEvents Label_unit_mm01 As System.Windows.Forms.Label
    Friend WithEvents Label_unit_m02 As System.Windows.Forms.Label
    Friend WithEvents Label_unit_m01 As System.Windows.Forms.Label
    Friend WithEvents GroupBox_stiffeners As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox_stiffeners_mark As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox_S As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_R As System.Windows.Forms.PictureBox
    Friend WithEvents CheckBox_short As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_long As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox_stiffeners_number As System.Windows.Forms.GroupBox
    Friend WithEvents numeric_R As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label_stiffeners_short As System.Windows.Forms.Label
    Friend WithEvents numeric_S As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label_stiffeners_long As System.Windows.Forms.Label
    Friend WithEvents GroupBox_stiffeners_data As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox_input_selection As System.Windows.Forms.GroupBox
    Friend WithEvents Radiobutton_select_geometric As System.Windows.Forms.RadioButton
    Friend WithEvents Radiobutton_select_numeric As System.Windows.Forms.RadioButton
    Friend WithEvents Radiobutton_select_DB As System.Windows.Forms.RadioButton
    Friend WithEvents Groupbox_geometric_input As System.Windows.Forms.GroupBox
    Friend WithEvents Button_Geo_selected As System.Windows.Forms.Button
    Friend WithEvents TextBox_Geo_result As System.Windows.Forms.TextBox
    Friend WithEvents Label_Geo_result As System.Windows.Forms.Label
    Friend WithEvents Combobox_geo_select As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox_Geo_L As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_Geo_T As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_Geo_I As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_Geo_blade As System.Windows.Forms.PictureBox
    Friend WithEvents Label_Geo_type_select As System.Windows.Forms.Label
    Friend WithEvents GroupBox_geo_input As System.Windows.Forms.GroupBox
    Friend WithEvents MaskedTextBox_geo_w As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox_geo_t As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox_geo_d As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox_geo_b As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label_unit_mm05 As System.Windows.Forms.Label
    Friend WithEvents Label_geo_w As System.Windows.Forms.Label
    Friend WithEvents Label_unit_mm04 As System.Windows.Forms.Label
    Friend WithEvents Label_geo_t As System.Windows.Forms.Label
    Friend WithEvents Label_unit_mm03 As System.Windows.Forms.Label
    Friend WithEvents Label_unit_mm02 As System.Windows.Forms.Label
    Friend WithEvents Label_geo_d As System.Windows.Forms.Label
    Friend WithEvents Label_geo_b As System.Windows.Forms.Label
    Friend WithEvents groupBox_DB_input As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox_DB_pic02 As System.Windows.Forms.PictureBox
    Friend WithEvents Button_DB_selected As System.Windows.Forms.Button
    Friend WithEvents PictureBox_DB_pic01 As System.Windows.Forms.PictureBox
    Friend WithEvents groupBox_DB_sub As System.Windows.Forms.GroupBox
    Friend WithEvents Label_DB_center_unit As System.Windows.Forms.Label
    Friend WithEvents Button_DB_select03 As System.Windows.Forms.Button
    Friend WithEvents Label_DB_area_unit As System.Windows.Forms.Label
    Friend WithEvents Button_DB_select02 As System.Windows.Forms.Button
    Friend WithEvents Label_DB_moment_unit As System.Windows.Forms.Label
    Friend WithEvents Button_DB_select01 As System.Windows.Forms.Button
    Friend WithEvents Label_DB_center As System.Windows.Forms.Label
    Friend WithEvents TextBox_db_center As System.Windows.Forms.TextBox
    Friend WithEvents Label_DB_area As System.Windows.Forms.Label
    Friend WithEvents TextBox_db_area As System.Windows.Forms.TextBox
    Friend WithEvents Label_DB_moment As System.Windows.Forms.Label
    Friend WithEvents TextBox_db_moment As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox_numeric_input As System.Windows.Forms.GroupBox
    Protected WithEvents ComboBox_num_center_units As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_num_area_units As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_num_moment_units As System.Windows.Forms.ComboBox
    Friend WithEvents Label_num_area As System.Windows.Forms.Label
    Friend WithEvents TextBox_num_area As System.Windows.Forms.TextBox
    Friend WithEvents Label_num_center As System.Windows.Forms.Label
    Friend WithEvents TextBox_num_center As System.Windows.Forms.TextBox
    Friend WithEvents Label_num_moment As System.Windows.Forms.Label
    Friend WithEvents TextBox_num_moment As System.Windows.Forms.TextBox
    Friend WithEvents Button_num_selected As System.Windows.Forms.Button
    Friend WithEvents PictureBox_numeric As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox_BC As System.Windows.Forms.GroupBox
    Friend WithEvents label_GPa As System.Windows.Forms.Label
    Friend WithEvents ComboBox_P_units As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox_P_input As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_ni_input As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_E_input As System.Windows.Forms.TextBox
    Friend WithEvents Label_pressure As System.Windows.Forms.Label
    Friend WithEvents label_ni As System.Windows.Forms.Label
    Friend WithEvents Label_modulus As System.Windows.Forms.Label
    Friend WithEvents numeric_BC_input As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label_BC As System.Windows.Forms.Label
    Friend WithEvents Button_case04 As System.Windows.Forms.Button
    Friend WithEvents Button_case01 As System.Windows.Forms.Button
    Friend WithEvents Button_case02 As System.Windows.Forms.Button
    Friend WithEvents Button_case03 As System.Windows.Forms.Button
    Friend WithEvents GroupBox_stiffeners_whole As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents ImageList_icons As System.Windows.Forms.ImageList
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents groupbox_general As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents button_BC_select As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox_P As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_ni As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_E As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label_E As System.Windows.Forms.Label
    Friend WithEvents numeric_case_input As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents groupbox_plate_geo As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents numeric_t As System.Windows.Forms.NumericUpDown
    Friend WithEvents numeric_b As System.Windows.Forms.NumericUpDown
    Friend WithEvents numeric_a As System.Windows.Forms.NumericUpDown
    Friend WithEvents label_t As System.Windows.Forms.Label
    Friend WithEvents label_a As System.Windows.Forms.Label
    Friend WithEvents label_b As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox_summary As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox_Is_stiffeners As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents numeric_s_sum As System.Windows.Forms.NumericUpDown
    Friend WithEvents numeric_r_sum As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Ar_stiffeners As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Yr_stiffeners As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Ir_stiffeners As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TextBox_As_stiffeners As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Ys_stiffeners As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox_results As System.Windows.Forms.GroupBox
    Friend WithEvents NumericUpDown_SD_deflection As System.Windows.Forms.NumericUpDown
    Friend WithEvents RichTextBox_results_deflection As System.Windows.Forms.RichTextBox
    Friend WithEvents Textbox_results_Deflection As System.Windows.Forms.TextBox
    Friend WithEvents Button_compute As System.Windows.Forms.Button
    Friend WithEvents Label_SD_deflection As System.Windows.Forms.Label
    Friend WithEvents GroupBox_results_deflection As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox_results_BM As System.Windows.Forms.GroupBox
    Friend WithEvents Label_SD_BM As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown_SD_BM As System.Windows.Forms.NumericUpDown
    Friend WithEvents Textbox_results_BM As System.Windows.Forms.TextBox
    Friend WithEvents RichTextBox_results_BM As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox_ADINA As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox_creation_type As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton_normal As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_fast As System.Windows.Forms.RadioButton
    Friend WithEvents Label_affiliated As System.Windows.Forms.Label
    Friend WithEvents PictureBox02 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox01 As System.Windows.Forms.PictureBox
    Friend WithEvents Button_Run_ADINA As System.Windows.Forms.Button
    Friend WithEvents Button_feed_ADINA As System.Windows.Forms.Button
    Friend WithEvents RichTextBox_model_qualify As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox_adina_msg As System.Windows.Forms.RichTextBox
    Friend WithEvents Label_Adina As System.Windows.Forms.Label
    Friend WithEvents GroupBox_export As System.Windows.Forms.GroupBox
    Friend WithEvents RichTextBox_result_for_saving As System.Windows.Forms.RichTextBox
    Friend WithEvents button_results_save_HTML As System.Windows.Forms.Button
    Friend WithEvents GroupBox_choose_language As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox_update As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton_add_replace As System.Windows.Forms.RadioButton
    Friend WithEvents Button_update As System.Windows.Forms.Button
    Friend WithEvents RadioButton_add_after As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_other_language As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_default_english As System.Windows.Forms.RadioButton
    Friend WithEvents RichTextBox_result_for_saving_HTML As System.Windows.Forms.RichTextBox
    Friend WithEvents button_results_clear As System.Windows.Forms.Button
    Friend WithEvents button_results_save As System.Windows.Forms.Button
    Friend WithEvents Label_comment01 As System.Windows.Forms.Label
    Friend WithEvents Panel_right As System.Windows.Forms.Panel
    Friend WithEvents Label_comment02 As System.Windows.Forms.Label
End Class
