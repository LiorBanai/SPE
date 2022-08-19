<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GUI_calculations
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node1")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node2")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node3")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Inputs", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI_calculations))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.TreeView_steps = New System.Windows.Forms.TreeView()
        Me.Panel_plate = New System.Windows.Forms.Panel()
        Me.Button_plate_ok = New System.Windows.Forms.Button()
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
        Me.GroupBox_stiffeners = New System.Windows.Forms.GroupBox()
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
        Me.GroupBox_stiffeners_number = New System.Windows.Forms.GroupBox()
        Me.Button_view_parameters = New System.Windows.Forms.Button()
        Me.numeric_short = New System.Windows.Forms.NumericUpDown()
        Me.Label_stiffeners_short = New System.Windows.Forms.Label()
        Me.numeric_long = New System.Windows.Forms.NumericUpDown()
        Me.Label_stiffeners_long = New System.Windows.Forms.Label()
        Me.GroupBox_stiffeners_data = New System.Windows.Forms.GroupBox()
        Me.GroupBox_moment_select_general = New System.Windows.Forms.GroupBox()
        Me.Radiobutton_select_geometric = New System.Windows.Forms.RadioButton()
        Me.Radiobutton_select_numeric = New System.Windows.Forms.RadioButton()
        Me.Radiobutton_select_DB = New System.Windows.Forms.RadioButton()
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
        Me.Panel_plate.SuspendLayout()
        Me.GroupBox_plate.SuspendLayout()
        CType(Me.numeric_plate_t, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numeric_plate_short, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numeric_plate_long, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_plate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel02.SuspendLayout()
        Me.panel03.SuspendLayout()
        Me.GroupBox_stiffeners.SuspendLayout()
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
        Me.GroupBox_stiffeners_data.SuspendLayout()
        Me.GroupBox_moment_select_general.SuspendLayout()
        Me.Groupbox_geometric_input.SuspendLayout()
        CType(Me.PictureBox_Geo_L, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Geo_T, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Geo_I, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Geo_blade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_geo_input.SuspendLayout()
        Me.groupBox_DB_input.SuspendLayout()
        CType(Me.PictureBox_DB_pic02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_DB_pic01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox_DB_sub.SuspendLayout()
        Me.GroupBox_numeric_input.SuspendLayout()
        CType(Me.PictureBox_numeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1050, 24)
        Me.MenuStrip.TabIndex = 1
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Location = New System.Drawing.Point(0, 718)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1050, 22)
        Me.StatusStrip.TabIndex = 2
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'TreeView_steps
        '
        Me.TreeView_steps.Dock = System.Windows.Forms.DockStyle.Left
        Me.TreeView_steps.Location = New System.Drawing.Point(0, 24)
        Me.TreeView_steps.Name = "TreeView_steps"
        TreeNode1.Checked = True
        TreeNode1.Name = "Node1"
        TreeNode1.Text = "Node1"
        TreeNode2.Name = "Node2"
        TreeNode2.Text = "Node2"
        TreeNode3.Name = "Node3"
        TreeNode3.Text = "Node3"
        TreeNode4.Name = "inputs_root"
        TreeNode4.Text = "Inputs"
        Me.TreeView_steps.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode4})
        Me.TreeView_steps.Size = New System.Drawing.Size(148, 694)
        Me.TreeView_steps.TabIndex = 3
        '
        'Panel_plate
        '
        Me.Panel_plate.AutoScroll = True
        Me.Panel_plate.Controls.Add(Me.Button_plate_ok)
        Me.Panel_plate.Controls.Add(Me.GroupBox_plate)
        Me.Panel_plate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_plate.Location = New System.Drawing.Point(0, 0)
        Me.Panel_plate.Name = "Panel_plate"
        Me.Panel_plate.Size = New System.Drawing.Size(1050, 740)
        Me.Panel_plate.TabIndex = 49
        '
        'Button_plate_ok
        '
        Me.Button_plate_ok.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_plate_ok.Font = New System.Drawing.Font("David", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Button_plate_ok.Image = Global.SPE.My.Resources.Resources.icon_confirmation
        Me.Button_plate_ok.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_plate_ok.Location = New System.Drawing.Point(442, 303)
        Me.Button_plate_ok.Name = "Button_plate_ok"
        Me.Button_plate_ok.Size = New System.Drawing.Size(88, 53)
        Me.Button_plate_ok.TabIndex = 42
        '
        'GroupBox_plate
        '
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
        Me.GroupBox_plate.Location = New System.Drawing.Point(152, 74)
        Me.GroupBox_plate.Name = "GroupBox_plate"
        Me.GroupBox_plate.Size = New System.Drawing.Size(471, 204)
        Me.GroupBox_plate.TabIndex = 40
        Me.GroupBox_plate.TabStop = False
        Me.GroupBox_plate.Text = "Plate's Geometry's Parameters"
        '
        'Label_long
        '
        Me.Label_long.AutoEllipsis = True
        Me.Label_long.BackColor = System.Drawing.Color.White
        Me.Label_long.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_long.Location = New System.Drawing.Point(373, 111)
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
        Me.Label_short.Location = New System.Drawing.Point(329, 43)
        Me.Label_short.Name = "Label_short"
        Me.Label_short.Size = New System.Drawing.Size(113, 27)
        Me.Label_short.TabIndex = 43
        Me.Label_short.Text = "b"
        Me.Label_short.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label_thickness
        '
        Me.Label_thickness.AutoEllipsis = True
        Me.Label_thickness.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_thickness.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_thickness.Location = New System.Drawing.Point(8, 142)
        Me.Label_thickness.Name = "Label_thickness"
        Me.Label_thickness.Size = New System.Drawing.Size(100, 25)
        Me.Label_thickness.TabIndex = 12
        Me.Label_thickness.Text = "Thickness t"
        Me.Label_thickness.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'numeric_plate_t
        '
        Me.numeric_plate_t.DecimalPlaces = 2
        Me.numeric_plate_t.Font = New System.Drawing.Font("David", 10.8!)
        Me.numeric_plate_t.Location = New System.Drawing.Point(112, 142)
        Me.numeric_plate_t.Name = "numeric_plate_t"
        Me.numeric_plate_t.Size = New System.Drawing.Size(64, 25)
        Me.numeric_plate_t.TabIndex = 11
        Me.numeric_plate_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numeric_plate_t.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label_breadth
        '
        Me.Label_breadth.AutoEllipsis = True
        Me.Label_breadth.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_breadth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_breadth.Location = New System.Drawing.Point(8, 94)
        Me.Label_breadth.Name = "Label_breadth"
        Me.Label_breadth.Size = New System.Drawing.Size(100, 25)
        Me.Label_breadth.TabIndex = 10
        Me.Label_breadth.Text = "Breadth b"
        Me.Label_breadth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'numeric_plate_short
        '
        Me.numeric_plate_short.DecimalPlaces = 2
        Me.numeric_plate_short.Font = New System.Drawing.Font("David", 10.8!)
        Me.numeric_plate_short.Location = New System.Drawing.Point(112, 94)
        Me.numeric_plate_short.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numeric_plate_short.Name = "numeric_plate_short"
        Me.numeric_plate_short.Size = New System.Drawing.Size(64, 25)
        Me.numeric_plate_short.TabIndex = 9
        Me.numeric_plate_short.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numeric_plate_short.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label_length
        '
        Me.Label_length.AutoEllipsis = True
        Me.Label_length.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_length.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_length.Location = New System.Drawing.Point(8, 43)
        Me.Label_length.Name = "Label_length"
        Me.Label_length.Size = New System.Drawing.Size(100, 25)
        Me.Label_length.TabIndex = 8
        Me.Label_length.Text = "Length a"
        Me.Label_length.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'numeric_plate_long
        '
        Me.numeric_plate_long.DecimalPlaces = 2
        Me.numeric_plate_long.Font = New System.Drawing.Font("David", 10.8!)
        Me.numeric_plate_long.Location = New System.Drawing.Point(112, 43)
        Me.numeric_plate_long.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numeric_plate_long.Name = "numeric_plate_long"
        Me.numeric_plate_long.Size = New System.Drawing.Size(64, 25)
        Me.numeric_plate_long.TabIndex = 7
        Me.numeric_plate_long.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numeric_plate_long.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'PictureBox_plate
        '
        Me.PictureBox_plate.Image = Global.SPE.My.Resources.Resources.plate_empty_text
        Me.PictureBox_plate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox_plate.Location = New System.Drawing.Point(244, 34)
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
        Me.Label_unit_mm01.Location = New System.Drawing.Point(188, 142)
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
        Me.Label_unit_m02.Location = New System.Drawing.Point(188, 94)
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
        Me.Label_unit_m01.Location = New System.Drawing.Point(188, 43)
        Me.Label_unit_m01.Name = "Label_unit_m01"
        Me.Label_unit_m01.Size = New System.Drawing.Size(66, 25)
        Me.Label_unit_m01.TabIndex = 39
        Me.Label_unit_m01.Text = "[m]"
        Me.Label_unit_m01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.panel02.Location = New System.Drawing.Point(0, 0)
        Me.panel02.Name = "panel02"
        Me.panel02.Size = New System.Drawing.Size(1050, 740)
        Me.panel02.TabIndex = 50
        Me.panel02.Visible = False
        '
        'Button_panel02_back
        '
        Me.Button_panel02_back.AutoEllipsis = True
        Me.Button_panel02_back.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_panel02_back.Location = New System.Drawing.Point(352, 622)
        Me.Button_panel02_back.Name = "Button_panel02_back"
        Me.Button_panel02_back.Size = New System.Drawing.Size(92, 32)
        Me.Button_panel02_back.TabIndex = 8
        Me.Button_panel02_back.Text = "Back"
        '
        'Label_type04
        '
        Me.Label_type04.AutoEllipsis = True
        Me.Label_type04.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_type04.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_type04.Location = New System.Drawing.Point(222, 103)
        Me.Label_type04.Name = "Label_type04"
        Me.Label_type04.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label_type04.Size = New System.Drawing.Size(172, 68)
        Me.Label_type04.TabIndex = 7
        Me.Label_type04.Text = "Longitudinal and Transverse Stiffeners"
        Me.Label_type04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_type03
        '
        Me.Label_type03.AutoEllipsis = True
        Me.Label_type03.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_type03.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_type03.Location = New System.Drawing.Point(218, 226)
        Me.Label_type03.Name = "Label_type03"
        Me.Label_type03.Size = New System.Drawing.Size(183, 68)
        Me.Label_type03.TabIndex = 6
        Me.Label_type03.Text = "Transverse Stiffeners with Central Longitudinal Stiffener"
        Me.Label_type03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_type02
        '
        Me.Label_type02.AutoEllipsis = True
        Me.Label_type02.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_type02.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_type02.Location = New System.Drawing.Point(222, 349)
        Me.Label_type02.Name = "Label_type02"
        Me.Label_type02.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label_type02.Size = New System.Drawing.Size(172, 68)
        Me.Label_type02.TabIndex = 5
        Me.Label_type02.Text = "Transverse Stiffeners Only"
        Me.Label_type02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_type01
        '
        Me.Label_type01.AutoEllipsis = True
        Me.Label_type01.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_type01.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_type01.Location = New System.Drawing.Point(222, 472)
        Me.Label_type01.Name = "Label_type01"
        Me.Label_type01.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label_type01.Size = New System.Drawing.Size(172, 68)
        Me.Label_type01.TabIndex = 4
        Me.Label_type01.Text = "No Stiffeners"
        Me.Label_type01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button_type04
        '
        Me.Button_type04.BackColor = System.Drawing.Color.LightGray
        Me.Button_type04.Image = CType(resources.GetObject("Button_type04.Image"), System.Drawing.Image)
        Me.Button_type04.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_type04.Location = New System.Drawing.Point(30, 79)
        Me.Button_type04.Name = "Button_type04"
        Me.Button_type04.Size = New System.Drawing.Size(172, 117)
        Me.Button_type04.TabIndex = 3
        Me.Button_type04.UseVisualStyleBackColor = False
        '
        'Button_type03
        '
        Me.Button_type03.BackColor = System.Drawing.Color.LightGray
        Me.Button_type03.Image = CType(resources.GetObject("Button_type03.Image"), System.Drawing.Image)
        Me.Button_type03.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_type03.Location = New System.Drawing.Point(30, 202)
        Me.Button_type03.Name = "Button_type03"
        Me.Button_type03.Size = New System.Drawing.Size(172, 117)
        Me.Button_type03.TabIndex = 2
        Me.Button_type03.UseVisualStyleBackColor = False
        '
        'Button_type02
        '
        Me.Button_type02.BackColor = System.Drawing.Color.LightGray
        Me.Button_type02.Image = CType(resources.GetObject("Button_type02.Image"), System.Drawing.Image)
        Me.Button_type02.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_type02.Location = New System.Drawing.Point(30, 325)
        Me.Button_type02.Name = "Button_type02"
        Me.Button_type02.Size = New System.Drawing.Size(172, 117)
        Me.Button_type02.TabIndex = 1
        Me.Button_type02.UseVisualStyleBackColor = False
        '
        'Button_type01
        '
        Me.Button_type01.BackColor = System.Drawing.Color.LightGray
        Me.Button_type01.Image = CType(resources.GetObject("Button_type01.Image"), System.Drawing.Image)
        Me.Button_type01.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_type01.Location = New System.Drawing.Point(30, 448)
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
        Me.panel03.Controls.Add(Me.GroupBox_stiffeners)
        Me.panel03.Controls.Add(Me.GroupBox_stiffeners_data)
        Me.panel03.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel03.Location = New System.Drawing.Point(148, 24)
        Me.panel03.Name = "panel03"
        Me.panel03.Size = New System.Drawing.Size(902, 694)
        Me.panel03.TabIndex = 51
        '
        'GroupBox_stiffeners
        '
        Me.GroupBox_stiffeners.Controls.Add(Me.GroupBox_stiffeners_mark)
        Me.GroupBox_stiffeners.Controls.Add(Me.GroupBox_stiffeners_number)
        Me.GroupBox_stiffeners.Font = New System.Drawing.Font("David", 13.8!)
        Me.GroupBox_stiffeners.Location = New System.Drawing.Point(11, 17)
        Me.GroupBox_stiffeners.Name = "GroupBox_stiffeners"
        Me.GroupBox_stiffeners.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox_stiffeners.Size = New System.Drawing.Size(845, 197)
        Me.GroupBox_stiffeners.TabIndex = 41
        Me.GroupBox_stiffeners.TabStop = False
        Me.GroupBox_stiffeners.Text = "Selection of Stiffeners"
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
        Me.GroupBox_stiffeners_mark.Location = New System.Drawing.Point(410, 25)
        Me.GroupBox_stiffeners_mark.Name = "GroupBox_stiffeners_mark"
        Me.GroupBox_stiffeners_mark.Size = New System.Drawing.Size(421, 159)
        Me.GroupBox_stiffeners_mark.TabIndex = 52
        Me.GroupBox_stiffeners_mark.TabStop = False
        Me.GroupBox_stiffeners_mark.Tag = ""
        Me.GroupBox_stiffeners_mark.Text = "Type of Stiffeners Selection"
        '
        'PictureBox_Inb_info
        '
        Me.PictureBox_Inb_info.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox_Inb_info.Image = CType(resources.GetObject("PictureBox_Inb_info.Image"), System.Drawing.Image)
        Me.PictureBox_Inb_info.Location = New System.Drawing.Point(387, 118)
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
        Me.PictureBox_Ib_info.Location = New System.Drawing.Point(387, 88)
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
        Me.PictureBox_Ina_info.Location = New System.Drawing.Point(387, 58)
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
        Me.PictureBox_Ia_info.Location = New System.Drawing.Point(387, 28)
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
        Me.PictureBox_Inb_checked.Location = New System.Drawing.Point(350, 118)
        Me.PictureBox_Inb_checked.Name = "PictureBox_Inb_checked"
        Me.PictureBox_Inb_checked.Size = New System.Drawing.Size(28, 24)
        Me.PictureBox_Inb_checked.TabIndex = 8
        Me.PictureBox_Inb_checked.TabStop = False
        '
        'PictureBox_Ib_checked
        '
        Me.PictureBox_Ib_checked.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox_Ib_checked.Image = CType(resources.GetObject("PictureBox_Ib_checked.Image"), System.Drawing.Image)
        Me.PictureBox_Ib_checked.Location = New System.Drawing.Point(350, 88)
        Me.PictureBox_Ib_checked.Name = "PictureBox_Ib_checked"
        Me.PictureBox_Ib_checked.Size = New System.Drawing.Size(28, 24)
        Me.PictureBox_Ib_checked.TabIndex = 7
        Me.PictureBox_Ib_checked.TabStop = False
        '
        'PictureBox_Ina_checked
        '
        Me.PictureBox_Ina_checked.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox_Ina_checked.Image = CType(resources.GetObject("PictureBox_Ina_checked.Image"), System.Drawing.Image)
        Me.PictureBox_Ina_checked.Location = New System.Drawing.Point(350, 58)
        Me.PictureBox_Ina_checked.Name = "PictureBox_Ina_checked"
        Me.PictureBox_Ina_checked.Size = New System.Drawing.Size(28, 24)
        Me.PictureBox_Ina_checked.TabIndex = 6
        Me.PictureBox_Ina_checked.TabStop = False
        '
        'PictureBox_Ia_checked
        '
        Me.PictureBox_Ia_checked.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox_Ia_checked.Image = CType(resources.GetObject("PictureBox_Ia_checked.Image"), System.Drawing.Image)
        Me.PictureBox_Ia_checked.Location = New System.Drawing.Point(350, 28)
        Me.PictureBox_Ia_checked.Name = "PictureBox_Ia_checked"
        Me.PictureBox_Ia_checked.Size = New System.Drawing.Size(28, 24)
        Me.PictureBox_Ia_checked.TabIndex = 5
        Me.PictureBox_Ia_checked.TabStop = False
        '
        'CheckBox_Inb
        '
        Me.CheckBox_Inb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox_Inb.AutoEllipsis = True
        Me.CheckBox_Inb.Font = New System.Drawing.Font("David", 10.8!)
        Me.CheckBox_Inb.Location = New System.Drawing.Point(7, 118)
        Me.CheckBox_Inb.Name = "CheckBox_Inb"
        Me.CheckBox_Inb.Size = New System.Drawing.Size(337, 24)
        Me.CheckBox_Inb.TabIndex = 3
        Me.CheckBox_Inb.Text = "Non-Central Transverse Stiffeners"
        '
        'CheckBox_Ib
        '
        Me.CheckBox_Ib.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox_Ib.AutoEllipsis = True
        Me.CheckBox_Ib.Font = New System.Drawing.Font("David", 10.8!)
        Me.CheckBox_Ib.Location = New System.Drawing.Point(7, 88)
        Me.CheckBox_Ib.Name = "CheckBox_Ib"
        Me.CheckBox_Ib.Size = New System.Drawing.Size(337, 24)
        Me.CheckBox_Ib.TabIndex = 2
        Me.CheckBox_Ib.Text = "Central Transverse Stiffeners"
        '
        'CheckBox_Ina
        '
        Me.CheckBox_Ina.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox_Ina.AutoEllipsis = True
        Me.CheckBox_Ina.Font = New System.Drawing.Font("David", 10.8!)
        Me.CheckBox_Ina.Location = New System.Drawing.Point(7, 58)
        Me.CheckBox_Ina.Name = "CheckBox_Ina"
        Me.CheckBox_Ina.Size = New System.Drawing.Size(337, 24)
        Me.CheckBox_Ina.TabIndex = 1
        Me.CheckBox_Ina.Text = "Non-Central Longitudinal Stiffeners"
        '
        'CheckBox_Ia
        '
        Me.CheckBox_Ia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox_Ia.AutoEllipsis = True
        Me.CheckBox_Ia.Font = New System.Drawing.Font("David", 10.8!)
        Me.CheckBox_Ia.Location = New System.Drawing.Point(7, 28)
        Me.CheckBox_Ia.Name = "CheckBox_Ia"
        Me.CheckBox_Ia.Size = New System.Drawing.Size(337, 24)
        Me.CheckBox_Ia.TabIndex = 0
        Me.CheckBox_Ia.Text = "Central Longitudinal Stiffener"
        '
        'GroupBox_stiffeners_number
        '
        Me.GroupBox_stiffeners_number.Controls.Add(Me.Button_view_parameters)
        Me.GroupBox_stiffeners_number.Controls.Add(Me.numeric_short)
        Me.GroupBox_stiffeners_number.Controls.Add(Me.Label_stiffeners_short)
        Me.GroupBox_stiffeners_number.Controls.Add(Me.numeric_long)
        Me.GroupBox_stiffeners_number.Controls.Add(Me.Label_stiffeners_long)
        Me.GroupBox_stiffeners_number.Font = New System.Drawing.Font("David", 13.8!)
        Me.GroupBox_stiffeners_number.Location = New System.Drawing.Point(20, 25)
        Me.GroupBox_stiffeners_number.Name = "GroupBox_stiffeners_number"
        Me.GroupBox_stiffeners_number.Size = New System.Drawing.Size(376, 159)
        Me.GroupBox_stiffeners_number.TabIndex = 51
        Me.GroupBox_stiffeners_number.TabStop = False
        Me.GroupBox_stiffeners_number.Text = "Number of Stiffeners"
        '
        'Button_view_parameters
        '
        Me.Button_view_parameters.Font = New System.Drawing.Font("David", 12.0!)
        Me.Button_view_parameters.Location = New System.Drawing.Point(12, 106)
        Me.Button_view_parameters.Name = "Button_view_parameters"
        Me.Button_view_parameters.Size = New System.Drawing.Size(358, 37)
        Me.Button_view_parameters.TabIndex = 59
        Me.Button_view_parameters.Text = "View model parameters"
        Me.Button_view_parameters.UseVisualStyleBackColor = True
        '
        'numeric_short
        '
        Me.numeric_short.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numeric_short.Font = New System.Drawing.Font("David", 10.8!)
        Me.numeric_short.Location = New System.Drawing.Point(295, 65)
        Me.numeric_short.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numeric_short.Name = "numeric_short"
        Me.numeric_short.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.numeric_short.Size = New System.Drawing.Size(64, 25)
        Me.numeric_short.TabIndex = 58
        Me.numeric_short.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numeric_short.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'Label_stiffeners_short
        '
        Me.Label_stiffeners_short.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_stiffeners_short.AutoEllipsis = True
        Me.Label_stiffeners_short.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_stiffeners_short.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_stiffeners_short.Location = New System.Drawing.Point(8, 65)
        Me.Label_stiffeners_short.Name = "Label_stiffeners_short"
        Me.Label_stiffeners_short.Size = New System.Drawing.Size(281, 25)
        Me.Label_stiffeners_short.TabIndex = 57
        Me.Label_stiffeners_short.Text = "Transverse Stiffeners"
        Me.Label_stiffeners_short.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'numeric_long
        '
        Me.numeric_long.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numeric_long.Font = New System.Drawing.Font("David", 10.8!)
        Me.numeric_long.Location = New System.Drawing.Point(295, 32)
        Me.numeric_long.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numeric_long.Name = "numeric_long"
        Me.numeric_long.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.numeric_long.Size = New System.Drawing.Size(63, 25)
        Me.numeric_long.TabIndex = 56
        Me.numeric_long.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numeric_long.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label_stiffeners_long
        '
        Me.Label_stiffeners_long.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_stiffeners_long.AutoEllipsis = True
        Me.Label_stiffeners_long.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_stiffeners_long.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_stiffeners_long.Location = New System.Drawing.Point(8, 32)
        Me.Label_stiffeners_long.Name = "Label_stiffeners_long"
        Me.Label_stiffeners_long.Size = New System.Drawing.Size(281, 25)
        Me.Label_stiffeners_long.TabIndex = 55
        Me.Label_stiffeners_long.Text = "Longitudinal Stiffeners"
        Me.Label_stiffeners_long.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox_stiffeners_data
        '
        Me.GroupBox_stiffeners_data.Controls.Add(Me.GroupBox_moment_select_general)
        Me.GroupBox_stiffeners_data.Controls.Add(Me.Groupbox_geometric_input)
        Me.GroupBox_stiffeners_data.Controls.Add(Me.groupBox_DB_input)
        Me.GroupBox_stiffeners_data.Controls.Add(Me.GroupBox_numeric_input)
        Me.GroupBox_stiffeners_data.Font = New System.Drawing.Font("David", 13.8!)
        Me.GroupBox_stiffeners_data.Location = New System.Drawing.Point(6, 228)
        Me.GroupBox_stiffeners_data.Name = "GroupBox_stiffeners_data"
        Me.GroupBox_stiffeners_data.Size = New System.Drawing.Size(850, 304)
        Me.GroupBox_stiffeners_data.TabIndex = 48
        Me.GroupBox_stiffeners_data.TabStop = False
        Me.GroupBox_stiffeners_data.Text = "Stiffeners' Properties"
        Me.GroupBox_stiffeners_data.Visible = False
        '
        'GroupBox_moment_select_general
        '
        Me.GroupBox_moment_select_general.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_moment_select_general.Controls.Add(Me.Radiobutton_select_geometric)
        Me.GroupBox_moment_select_general.Controls.Add(Me.Radiobutton_select_numeric)
        Me.GroupBox_moment_select_general.Controls.Add(Me.Radiobutton_select_DB)
        Me.GroupBox_moment_select_general.Font = New System.Drawing.Font("David", 12.0!)
        Me.GroupBox_moment_select_general.Location = New System.Drawing.Point(664, 29)
        Me.GroupBox_moment_select_general.Name = "GroupBox_moment_select_general"
        Me.GroupBox_moment_select_general.Size = New System.Drawing.Size(172, 248)
        Me.GroupBox_moment_select_general.TabIndex = 44
        Me.GroupBox_moment_select_general.TabStop = False
        Me.GroupBox_moment_select_general.Text = "הכנסת מומנטי אינרציה"
        '
        'Radiobutton_select_geometric
        '
        Me.Radiobutton_select_geometric.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Radiobutton_select_geometric.AutoEllipsis = True
        Me.Radiobutton_select_geometric.Checked = True
        Me.Radiobutton_select_geometric.Font = New System.Drawing.Font("David", 10.8!)
        Me.Radiobutton_select_geometric.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Radiobutton_select_geometric.Location = New System.Drawing.Point(6, 162)
        Me.Radiobutton_select_geometric.Name = "Radiobutton_select_geometric"
        Me.Radiobutton_select_geometric.Size = New System.Drawing.Size(160, 78)
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
        Me.Radiobutton_select_numeric.Location = New System.Drawing.Point(6, 86)
        Me.Radiobutton_select_numeric.Name = "Radiobutton_select_numeric"
        Me.Radiobutton_select_numeric.Size = New System.Drawing.Size(160, 69)
        Me.Radiobutton_select_numeric.TabIndex = 1
        Me.Radiobutton_select_numeric.Text = "הכנסת ערך מספרי"
        '
        'Radiobutton_select_DB
        '
        Me.Radiobutton_select_DB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Radiobutton_select_DB.AutoEllipsis = True
        Me.Radiobutton_select_DB.Font = New System.Drawing.Font("David", 10.8!)
        Me.Radiobutton_select_DB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Radiobutton_select_DB.Location = New System.Drawing.Point(6, 18)
        Me.Radiobutton_select_DB.Name = "Radiobutton_select_DB"
        Me.Radiobutton_select_DB.Size = New System.Drawing.Size(160, 55)
        Me.Radiobutton_select_DB.TabIndex = 0
        Me.Radiobutton_select_DB.Text = "בחירה מבסיס נתונים"
        '
        'Groupbox_geometric_input
        '
        Me.Groupbox_geometric_input.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.Groupbox_geometric_input.Font = New System.Drawing.Font("David", 12.0!)
        Me.Groupbox_geometric_input.Location = New System.Drawing.Point(21, 29)
        Me.Groupbox_geometric_input.Name = "Groupbox_geometric_input"
        Me.Groupbox_geometric_input.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Groupbox_geometric_input.Size = New System.Drawing.Size(637, 248)
        Me.Groupbox_geometric_input.TabIndex = 46
        Me.Groupbox_geometric_input.TabStop = False
        '
        'Button_Geo_selected
        '
        Me.Button_Geo_selected.AutoEllipsis = True
        Me.Button_Geo_selected.Font = New System.Drawing.Font("David", 10.8!)
        Me.Button_Geo_selected.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_Geo_selected.Location = New System.Drawing.Point(398, 204)
        Me.Button_Geo_selected.Name = "Button_Geo_selected"
        Me.Button_Geo_selected.Size = New System.Drawing.Size(85, 37)
        Me.Button_Geo_selected.TabIndex = 3
        Me.Button_Geo_selected.Text = "OK"
        '
        'TextBox_Geo_result
        '
        Me.TextBox_Geo_result.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox_Geo_result.Location = New System.Drawing.Point(57, 216)
        Me.TextBox_Geo_result.Name = "TextBox_Geo_result"
        Me.TextBox_Geo_result.ReadOnly = True
        Me.TextBox_Geo_result.Size = New System.Drawing.Size(184, 27)
        Me.TextBox_Geo_result.TabIndex = 17
        Me.TextBox_Geo_result.Text = "N/A"
        Me.TextBox_Geo_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_Geo_result
        '
        Me.Label_Geo_result.AutoEllipsis = True
        Me.Label_Geo_result.Location = New System.Drawing.Point(16, 176)
        Me.Label_Geo_result.Name = "Label_Geo_result"
        Me.Label_Geo_result.Size = New System.Drawing.Size(263, 40)
        Me.Label_Geo_result.TabIndex = 18
        Me.Label_Geo_result.Text = "Current Moment of Inertia [cm^4]"
        '
        'Combobox_geo_select
        '
        Me.Combobox_geo_select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combobox_geo_select.Font = New System.Drawing.Font("David", 10.8!)
        Me.Combobox_geo_select.ItemHeight = 17
        Me.Combobox_geo_select.Items.AddRange(New Object() {"Blade Stiffener (|)", "L Stiffener", "T Stiffener", "I Stiffener"})
        Me.Combobox_geo_select.Location = New System.Drawing.Point(254, 17)
        Me.Combobox_geo_select.Name = "Combobox_geo_select"
        Me.Combobox_geo_select.Size = New System.Drawing.Size(172, 25)
        Me.Combobox_geo_select.TabIndex = 19
        '
        'PictureBox_Geo_L
        '
        Me.PictureBox_Geo_L.Image = CType(resources.GetObject("PictureBox_Geo_L.Image"), System.Drawing.Image)
        Me.PictureBox_Geo_L.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox_Geo_L.Location = New System.Drawing.Point(20, 19)
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
        Me.PictureBox_Geo_T.Location = New System.Drawing.Point(20, 19)
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
        Me.PictureBox_Geo_I.Location = New System.Drawing.Point(20, 19)
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
        Me.PictureBox_Geo_blade.Location = New System.Drawing.Point(20, 19)
        Me.PictureBox_Geo_blade.Name = "PictureBox_Geo_blade"
        Me.PictureBox_Geo_blade.Size = New System.Drawing.Size(212, 151)
        Me.PictureBox_Geo_blade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Geo_blade.TabIndex = 8
        Me.PictureBox_Geo_blade.TabStop = False
        '
        'Label_Geo_type_select
        '
        Me.Label_Geo_type_select.AutoEllipsis = True
        Me.Label_Geo_type_select.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_Geo_type_select.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_Geo_type_select.Location = New System.Drawing.Point(445, 20)
        Me.Label_Geo_type_select.Name = "Label_Geo_type_select"
        Me.Label_Geo_type_select.Size = New System.Drawing.Size(177, 19)
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
        Me.GroupBox_geo_input.Location = New System.Drawing.Point(285, 48)
        Me.GroupBox_geo_input.Name = "GroupBox_geo_input"
        Me.GroupBox_geo_input.Size = New System.Drawing.Size(338, 148)
        Me.GroupBox_geo_input.TabIndex = 14
        Me.GroupBox_geo_input.TabStop = False
        Me.GroupBox_geo_input.Text = "Stiffener"
        '
        'MaskedTextBox_geo_w
        '
        Me.MaskedTextBox_geo_w.Location = New System.Drawing.Point(82, 114)
        Me.MaskedTextBox_geo_w.Name = "MaskedTextBox_geo_w"
        Me.MaskedTextBox_geo_w.Size = New System.Drawing.Size(88, 25)
        Me.MaskedTextBox_geo_w.TabIndex = 23
        Me.MaskedTextBox_geo_w.Visible = False
        '
        'MaskedTextBox_geo_t
        '
        Me.MaskedTextBox_geo_t.Location = New System.Drawing.Point(82, 84)
        Me.MaskedTextBox_geo_t.Name = "MaskedTextBox_geo_t"
        Me.MaskedTextBox_geo_t.Size = New System.Drawing.Size(88, 25)
        Me.MaskedTextBox_geo_t.TabIndex = 22
        Me.MaskedTextBox_geo_t.Visible = False
        '
        'MaskedTextBox_geo_d
        '
        Me.MaskedTextBox_geo_d.Location = New System.Drawing.Point(82, 54)
        Me.MaskedTextBox_geo_d.Name = "MaskedTextBox_geo_d"
        Me.MaskedTextBox_geo_d.Size = New System.Drawing.Size(88, 25)
        Me.MaskedTextBox_geo_d.TabIndex = 21
        Me.MaskedTextBox_geo_d.Text = "80"
        '
        'MaskedTextBox_geo_b
        '
        Me.MaskedTextBox_geo_b.Location = New System.Drawing.Point(82, 24)
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
        Me.Label_unit_mm05.Location = New System.Drawing.Point(7, 114)
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
        Me.Label_geo_w.Location = New System.Drawing.Point(176, 114)
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
        Me.Label_unit_mm04.Location = New System.Drawing.Point(7, 84)
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
        Me.Label_geo_t.Location = New System.Drawing.Point(176, 84)
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
        Me.Label_unit_mm03.Location = New System.Drawing.Point(7, 54)
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
        Me.Label_unit_mm02.Location = New System.Drawing.Point(7, 24)
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
        Me.Label_geo_d.Location = New System.Drawing.Point(176, 54)
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
        Me.Label_geo_b.Location = New System.Drawing.Point(176, 24)
        Me.Label_geo_b.Name = "Label_geo_b"
        Me.Label_geo_b.Size = New System.Drawing.Size(150, 23)
        Me.Label_geo_b.TabIndex = 6
        Me.Label_geo_b.Text = "Length b"
        Me.Label_geo_b.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'groupBox_DB_input
        '
        Me.groupBox_DB_input.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBox_DB_input.Controls.Add(Me.PictureBox_DB_pic02)
        Me.groupBox_DB_input.Controls.Add(Me.Button_DB_selected)
        Me.groupBox_DB_input.Controls.Add(Me.PictureBox_DB_pic01)
        Me.groupBox_DB_input.Controls.Add(Me.groupBox_DB_sub)
        Me.groupBox_DB_input.Font = New System.Drawing.Font("David", 12.0!)
        Me.groupBox_DB_input.Location = New System.Drawing.Point(21, 29)
        Me.groupBox_DB_input.Name = "groupBox_DB_input"
        Me.groupBox_DB_input.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.groupBox_DB_input.Size = New System.Drawing.Size(637, 248)
        Me.groupBox_DB_input.TabIndex = 47
        Me.groupBox_DB_input.TabStop = False
        Me.groupBox_DB_input.Text = "Selection from database of known standards"
        Me.groupBox_DB_input.Visible = False
        '
        'PictureBox_DB_pic02
        '
        Me.PictureBox_DB_pic02.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_DB_pic02.Image = CType(resources.GetObject("PictureBox_DB_pic02.Image"), System.Drawing.Image)
        Me.PictureBox_DB_pic02.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox_DB_pic02.Location = New System.Drawing.Point(8, 132)
        Me.PictureBox_DB_pic02.Name = "PictureBox_DB_pic02"
        Me.PictureBox_DB_pic02.Size = New System.Drawing.Size(120, 88)
        Me.PictureBox_DB_pic02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_DB_pic02.TabIndex = 4
        Me.PictureBox_DB_pic02.TabStop = False
        '
        'Button_DB_selected
        '
        Me.Button_DB_selected.AutoEllipsis = True
        Me.Button_DB_selected.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.Button_DB_selected.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_DB_selected.Location = New System.Drawing.Point(325, 200)
        Me.Button_DB_selected.Name = "Button_DB_selected"
        Me.Button_DB_selected.Size = New System.Drawing.Size(109, 28)
        Me.Button_DB_selected.TabIndex = 3
        Me.Button_DB_selected.Text = "OK"
        '
        'PictureBox_DB_pic01
        '
        Me.PictureBox_DB_pic01.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_DB_pic01.Image = CType(resources.GetObject("PictureBox_DB_pic01.Image"), System.Drawing.Image)
        Me.PictureBox_DB_pic01.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox_DB_pic01.Location = New System.Drawing.Point(8, 36)
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
        Me.groupBox_DB_sub.Location = New System.Drawing.Point(136, 29)
        Me.groupBox_DB_sub.Name = "groupBox_DB_sub"
        Me.groupBox_DB_sub.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.groupBox_DB_sub.Size = New System.Drawing.Size(491, 159)
        Me.groupBox_DB_sub.TabIndex = 2
        Me.groupBox_DB_sub.TabStop = False
        Me.groupBox_DB_sub.Text = "Properties of selected stiffener"
        '
        'Label_DB_center_unit
        '
        Me.Label_DB_center_unit.AutoEllipsis = True
        Me.Label_DB_center_unit.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_DB_center_unit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_DB_center_unit.Location = New System.Drawing.Point(15, 125)
        Me.Label_DB_center_unit.Name = "Label_DB_center_unit"
        Me.Label_DB_center_unit.Size = New System.Drawing.Size(75, 27)
        Me.Label_DB_center_unit.TabIndex = 12
        Me.Label_DB_center_unit.Text = "[cm]"
        Me.Label_DB_center_unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button_DB_select03
        '
        Me.Button_DB_select03.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_DB_select03.Location = New System.Drawing.Point(102, 125)
        Me.Button_DB_select03.Name = "Button_DB_select03"
        Me.Button_DB_select03.Size = New System.Drawing.Size(32, 27)
        Me.Button_DB_select03.TabIndex = 11
        Me.Button_DB_select03.Text = "..."
        '
        'Label_DB_area_unit
        '
        Me.Label_DB_area_unit.AutoEllipsis = True
        Me.Label_DB_area_unit.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_DB_area_unit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_DB_area_unit.Location = New System.Drawing.Point(15, 80)
        Me.Label_DB_area_unit.Name = "Label_DB_area_unit"
        Me.Label_DB_area_unit.Size = New System.Drawing.Size(75, 27)
        Me.Label_DB_area_unit.TabIndex = 10
        Me.Label_DB_area_unit.Text = "[cm^2]"
        Me.Label_DB_area_unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button_DB_select02
        '
        Me.Button_DB_select02.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_DB_select02.Location = New System.Drawing.Point(102, 80)
        Me.Button_DB_select02.Name = "Button_DB_select02"
        Me.Button_DB_select02.Size = New System.Drawing.Size(32, 27)
        Me.Button_DB_select02.TabIndex = 9
        Me.Button_DB_select02.Text = "..."
        '
        'Label_DB_moment_unit
        '
        Me.Label_DB_moment_unit.AutoEllipsis = True
        Me.Label_DB_moment_unit.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_DB_moment_unit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_DB_moment_unit.Location = New System.Drawing.Point(15, 30)
        Me.Label_DB_moment_unit.Name = "Label_DB_moment_unit"
        Me.Label_DB_moment_unit.Size = New System.Drawing.Size(75, 27)
        Me.Label_DB_moment_unit.TabIndex = 8
        Me.Label_DB_moment_unit.Text = "[cm^4]"
        Me.Label_DB_moment_unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button_DB_select01
        '
        Me.Button_DB_select01.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_DB_select01.Location = New System.Drawing.Point(102, 30)
        Me.Button_DB_select01.Name = "Button_DB_select01"
        Me.Button_DB_select01.Size = New System.Drawing.Size(32, 27)
        Me.Button_DB_select01.TabIndex = 7
        Me.Button_DB_select01.Text = "..."
        '
        'Label_DB_center
        '
        Me.Label_DB_center.AutoEllipsis = True
        Me.Label_DB_center.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_DB_center.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_DB_center.Location = New System.Drawing.Point(263, 125)
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
        Me.TextBox_db_center.Location = New System.Drawing.Point(138, 125)
        Me.TextBox_db_center.Name = "TextBox_db_center"
        Me.TextBox_db_center.ReadOnly = True
        Me.TextBox_db_center.Size = New System.Drawing.Size(119, 27)
        Me.TextBox_db_center.TabIndex = 5
        '
        'Label_DB_area
        '
        Me.Label_DB_area.AutoEllipsis = True
        Me.Label_DB_area.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_DB_area.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_DB_area.Location = New System.Drawing.Point(263, 70)
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
        Me.TextBox_db_area.Location = New System.Drawing.Point(138, 80)
        Me.TextBox_db_area.Name = "TextBox_db_area"
        Me.TextBox_db_area.ReadOnly = True
        Me.TextBox_db_area.Size = New System.Drawing.Size(119, 27)
        Me.TextBox_db_area.TabIndex = 3
        '
        'Label_DB_moment
        '
        Me.Label_DB_moment.AutoEllipsis = True
        Me.Label_DB_moment.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_DB_moment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_DB_moment.Location = New System.Drawing.Point(263, 26)
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
        Me.TextBox_db_moment.Location = New System.Drawing.Point(138, 30)
        Me.TextBox_db_moment.Name = "TextBox_db_moment"
        Me.TextBox_db_moment.ReadOnly = True
        Me.TextBox_db_moment.Size = New System.Drawing.Size(119, 27)
        Me.TextBox_db_moment.TabIndex = 1
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
        Me.GroupBox_numeric_input.Location = New System.Drawing.Point(21, 29)
        Me.GroupBox_numeric_input.Name = "GroupBox_numeric_input"
        Me.GroupBox_numeric_input.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox_numeric_input.Size = New System.Drawing.Size(637, 248)
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
        Me.ComboBox_num_center_units.Location = New System.Drawing.Point(229, 135)
        Me.ComboBox_num_center_units.Name = "ComboBox_num_center_units"
        Me.ComboBox_num_center_units.RightToLeft = System.Windows.Forms.RightToLeft.Yes
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
        Me.ComboBox_num_area_units.Location = New System.Drawing.Point(229, 79)
        Me.ComboBox_num_area_units.Name = "ComboBox_num_area_units"
        Me.ComboBox_num_area_units.RightToLeft = System.Windows.Forms.RightToLeft.Yes
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
        Me.ComboBox_num_moment_units.Location = New System.Drawing.Point(229, 36)
        Me.ComboBox_num_moment_units.Name = "ComboBox_num_moment_units"
        Me.ComboBox_num_moment_units.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComboBox_num_moment_units.Size = New System.Drawing.Size(84, 25)
        Me.ComboBox_num_moment_units.TabIndex = 53
        '
        'Label_num_area
        '
        Me.Label_num_area.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_num_area.AutoEllipsis = True
        Me.Label_num_area.Font = New System.Drawing.Font("David", 10.8!)
        Me.Label_num_area.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_num_area.Location = New System.Drawing.Point(412, 79)
        Me.Label_num_area.Name = "Label_num_area"
        Me.Label_num_area.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label_num_area.Size = New System.Drawing.Size(217, 25)
        Me.Label_num_area.TabIndex = 10
        Me.Label_num_area.Text = "Area of cross section"
        Me.Label_num_area.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_num_area
        '
        Me.TextBox_num_area.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_num_area.Font = New System.Drawing.Font("David", 10.8!)
        Me.TextBox_num_area.Location = New System.Drawing.Point(319, 79)
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
        Me.Label_num_center.Location = New System.Drawing.Point(412, 120)
        Me.Label_num_center.Name = "Label_num_center"
        Me.Label_num_center.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label_num_center.Size = New System.Drawing.Size(217, 57)
        Me.Label_num_center.TabIndex = 7
        Me.Label_num_center.Text = "Center of area with respect to base of stiffener"
        Me.Label_num_center.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_num_center
        '
        Me.TextBox_num_center.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_num_center.Font = New System.Drawing.Font("David", 10.8!)
        Me.TextBox_num_center.Location = New System.Drawing.Point(319, 135)
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
        Me.Label_num_moment.Location = New System.Drawing.Point(412, 36)
        Me.Label_num_moment.Name = "Label_num_moment"
        Me.Label_num_moment.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label_num_moment.Size = New System.Drawing.Size(217, 25)
        Me.Label_num_moment.TabIndex = 5
        Me.Label_num_moment.Text = "Moment of Inertia"
        Me.Label_num_moment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_num_moment
        '
        Me.TextBox_num_moment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_num_moment.Font = New System.Drawing.Font("David", 10.8!)
        Me.TextBox_num_moment.Location = New System.Drawing.Point(319, 36)
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
        Me.Button_num_selected.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.Button_num_selected.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button_num_selected.Location = New System.Drawing.Point(397, 200)
        Me.Button_num_selected.Name = "Button_num_selected"
        Me.Button_num_selected.Size = New System.Drawing.Size(68, 28)
        Me.Button_num_selected.TabIndex = 3
        Me.Button_num_selected.Text = "OK"
        '
        'PictureBox_numeric
        '
        Me.PictureBox_numeric.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox_numeric.Image = CType(resources.GetObject("PictureBox_numeric.Image"), System.Drawing.Image)
        Me.PictureBox_numeric.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox_numeric.Location = New System.Drawing.Point(12, 18)
        Me.PictureBox_numeric.Name = "PictureBox_numeric"
        Me.PictureBox_numeric.Size = New System.Drawing.Size(208, 216)
        Me.PictureBox_numeric.TabIndex = 8
        Me.PictureBox_numeric.TabStop = False
        '
        'GUI_calculations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(1050, 740)
        Me.Controls.Add(Me.panel03)
        Me.Controls.Add(Me.TreeView_steps)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.Panel_plate)
        Me.Controls.Add(Me.panel02)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "GUI_calculations"
        Me.Text = "Form___calculations"
        Me.Panel_plate.ResumeLayout(False)
        Me.GroupBox_plate.ResumeLayout(False)
        CType(Me.numeric_plate_t, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numeric_plate_short, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numeric_plate_long, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_plate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel02.ResumeLayout(False)
        Me.panel03.ResumeLayout(False)
        Me.GroupBox_stiffeners.ResumeLayout(False)
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
        Me.GroupBox_stiffeners_data.ResumeLayout(False)
        Me.GroupBox_moment_select_general.ResumeLayout(False)
        Me.Groupbox_geometric_input.ResumeLayout(False)
        Me.Groupbox_geometric_input.PerformLayout()
        CType(Me.PictureBox_Geo_L, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Geo_T, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Geo_I, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Geo_blade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_geo_input.ResumeLayout(False)
        Me.GroupBox_geo_input.PerformLayout()
        Me.groupBox_DB_input.ResumeLayout(False)
        CType(Me.PictureBox_DB_pic02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_DB_pic01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox_DB_sub.ResumeLayout(False)
        Me.groupBox_DB_sub.PerformLayout()
        Me.GroupBox_numeric_input.ResumeLayout(False)
        Me.GroupBox_numeric_input.PerformLayout()
        CType(Me.PictureBox_numeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents TreeView_steps As System.Windows.Forms.TreeView
    Friend WithEvents Panel_plate As System.Windows.Forms.Panel
    Friend WithEvents Button_plate_ok As System.Windows.Forms.Button
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
    Friend WithEvents panel02 As System.Windows.Forms.Panel
    Friend WithEvents Button_panel02_back As System.Windows.Forms.Button
    Friend WithEvents Label_type04 As System.Windows.Forms.Label
    Friend WithEvents Label_type03 As System.Windows.Forms.Label
    Friend WithEvents Label_type02 As System.Windows.Forms.Label
    Friend WithEvents Label_type01 As System.Windows.Forms.Label
    Friend WithEvents Button_type04 As System.Windows.Forms.Button
    Friend WithEvents Button_type03 As System.Windows.Forms.Button
    Friend WithEvents Button_type02 As System.Windows.Forms.Button
    Friend WithEvents Button_type01 As System.Windows.Forms.Button
    Friend WithEvents panel03 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox_stiffeners As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox_stiffeners_mark As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox_Inb_info As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_Ib_info As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_Ina_info As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_Ia_info As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_Inb_checked As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_Ib_checked As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_Ina_checked As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_Ia_checked As System.Windows.Forms.PictureBox
    Friend WithEvents CheckBox_Inb As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_Ib As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_Ina As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_Ia As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox_stiffeners_number As System.Windows.Forms.GroupBox
    Friend WithEvents Button_view_parameters As System.Windows.Forms.Button
    Friend WithEvents numeric_short As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label_stiffeners_short As System.Windows.Forms.Label
    Friend WithEvents numeric_long As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label_stiffeners_long As System.Windows.Forms.Label
    Friend WithEvents GroupBox_stiffeners_data As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox_moment_select_general As System.Windows.Forms.GroupBox
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
End Class
