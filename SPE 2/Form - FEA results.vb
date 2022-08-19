Imports System.IO
Public Class GUI_FEA_results
    Inherits System.Windows.Forms.Form
    Friend WithEvents DataGrid As System.Windows.Forms.DataGridView
    Dim color_front As Color = Color.Chartreuse
    Friend WithEvents DB_DataSet As SPE.DB_DataSet
    Friend WithEvents Source_ALL As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapter_All As SPE.DB_DataSetTableAdapters.AllTableAdapter
    Friend WithEvents Source_Geo01 As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapter_Geo01 As SPE.DB_DataSetTableAdapters.geo01TableAdapter
    Friend WithEvents Source_Geo02 As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapter_Geo02 As SPE.DB_DataSetTableAdapters.geo02TableAdapter
    Friend WithEvents Source_Geo03 As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapter_Geo03 As SPE.DB_DataSetTableAdapters.geo03TableAdapter
    Friend WithEvents Source_Geo04 As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapter_Geo04 As SPE.DB_DataSetTableAdapters.geo04TableAdapter
    Friend WithEvents GroupBox_type As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton_type_values As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_type_figures As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox_arrow02 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_arrow04 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_arrow03 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_arrow01 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox_figures As System.Windows.Forms.GroupBox
    Friend WithEvents Panel_figures As System.Windows.Forms.Panel
    Friend WithEvents GroupBox_geo3 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox_right_arrow2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_left_arrow2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_right_arrow1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_left_arrow1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_figures_geo3 As System.Windows.Forms.PictureBox
    Friend WithEvents RadioButton_geo3_case3_4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_geo3_case1_2 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox_geo_all As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox_geo_all As System.Windows.Forms.PictureBox
    Dim color_back As Color = Color.DeepPink
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
    Friend WithEvents case01 As System.Windows.Forms.RadioButton
    Friend WithEvents case02 As System.Windows.Forms.RadioButton
    Friend WithEvents case04 As System.Windows.Forms.RadioButton
    Friend WithEvents case03 As System.Windows.Forms.RadioButton
    Friend WithEvents Groupbox_datashow As System.Windows.Forms.GroupBox
    Friend WithEvents label_title As System.Windows.Forms.Label
    Friend WithEvents groupbox_geo As System.Windows.Forms.GroupBox
    Friend WithEvents group01 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI_FEA_results))
        Me.groupbox_geo = New System.Windows.Forms.GroupBox
        Me.case01 = New System.Windows.Forms.RadioButton
        Me.case02 = New System.Windows.Forms.RadioButton
        Me.case04 = New System.Windows.Forms.RadioButton
        Me.case03 = New System.Windows.Forms.RadioButton
        Me.group01 = New System.Windows.Forms.GroupBox
        Me.label_title = New System.Windows.Forms.Label
        Me.Groupbox_datashow = New System.Windows.Forms.GroupBox
        Me.DataGrid = New System.Windows.Forms.DataGridView
        Me.DB_DataSet = New SPE.DB_DataSet
        Me.TableAdapter_All = New SPE.DB_DataSetTableAdapters.AllTableAdapter
        Me.Source_Geo01 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapter_Geo01 = New SPE.DB_DataSetTableAdapters.geo01TableAdapter
        Me.Source_Geo02 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapter_Geo02 = New SPE.DB_DataSetTableAdapters.geo02TableAdapter
        Me.Source_Geo03 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapter_Geo03 = New SPE.DB_DataSetTableAdapters.geo03TableAdapter
        Me.Source_Geo04 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapter_Geo04 = New SPE.DB_DataSetTableAdapters.geo04TableAdapter
        Me.GroupBox_type = New System.Windows.Forms.GroupBox
        Me.PictureBox_arrow01 = New System.Windows.Forms.PictureBox
        Me.PictureBox_arrow03 = New System.Windows.Forms.PictureBox
        Me.PictureBox_arrow04 = New System.Windows.Forms.PictureBox
        Me.PictureBox_arrow02 = New System.Windows.Forms.PictureBox
        Me.RadioButton_type_values = New System.Windows.Forms.RadioButton
        Me.RadioButton_type_figures = New System.Windows.Forms.RadioButton
        Me.GroupBox_figures = New System.Windows.Forms.GroupBox
        Me.Panel_figures = New System.Windows.Forms.Panel
        Me.GroupBox_geo3 = New System.Windows.Forms.GroupBox
        Me.PictureBox_right_arrow2 = New System.Windows.Forms.PictureBox
        Me.PictureBox_left_arrow2 = New System.Windows.Forms.PictureBox
        Me.PictureBox_right_arrow1 = New System.Windows.Forms.PictureBox
        Me.PictureBox_left_arrow1 = New System.Windows.Forms.PictureBox
        Me.PictureBox_figures_geo3 = New System.Windows.Forms.PictureBox
        Me.RadioButton_geo3_case3_4 = New System.Windows.Forms.RadioButton
        Me.RadioButton_geo3_case1_2 = New System.Windows.Forms.RadioButton
        Me.GroupBox_geo_all = New System.Windows.Forms.GroupBox
        Me.PictureBox_geo_all = New System.Windows.Forms.PictureBox
        Me.Source_ALL = New System.Windows.Forms.BindingSource(Me.components)
        Me.groupbox_geo.SuspendLayout()
        Me.group01.SuspendLayout()
        Me.Groupbox_datashow.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Source_Geo01, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Source_Geo02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Source_Geo03, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Source_Geo04, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_type.SuspendLayout()
        CType(Me.PictureBox_arrow01, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_arrow03, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_arrow04, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_arrow02, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_figures.SuspendLayout()
        Me.Panel_figures.SuspendLayout()
        Me.GroupBox_geo3.SuspendLayout()
        CType(Me.PictureBox_right_arrow2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_left_arrow2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_right_arrow1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_left_arrow1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_figures_geo3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_geo_all.SuspendLayout()
        CType(Me.PictureBox_geo_all, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Source_ALL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupbox_geo
        '
        Me.groupbox_geo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupbox_geo.Controls.Add(Me.case01)
        Me.groupbox_geo.Controls.Add(Me.case02)
        Me.groupbox_geo.Controls.Add(Me.case04)
        Me.groupbox_geo.Controls.Add(Me.case03)
        Me.groupbox_geo.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.groupbox_geo.Location = New System.Drawing.Point(23, 116)
        Me.groupbox_geo.Name = "groupbox_geo"
        Me.groupbox_geo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.groupbox_geo.Size = New System.Drawing.Size(802, 152)
        Me.groupbox_geo.TabIndex = 33
        Me.groupbox_geo.TabStop = False
        Me.groupbox_geo.Text = "תצורה גאומטרית"
        '
        'case01
        '
        Me.case01.Appearance = System.Windows.Forms.Appearance.Button
        Me.case01.BackColor = System.Drawing.Color.DeepPink
        Me.case01.Image = CType(resources.GetObject("case01.Image"), System.Drawing.Image)
        Me.case01.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.case01.Location = New System.Drawing.Point(599, 27)
        Me.case01.Name = "case01"
        Me.case01.Size = New System.Drawing.Size(180, 115)
        Me.case01.TabIndex = 12
        Me.case01.UseVisualStyleBackColor = False
        '
        'case02
        '
        Me.case02.Appearance = System.Windows.Forms.Appearance.Button
        Me.case02.BackColor = System.Drawing.Color.Chartreuse
        Me.case02.Image = CType(resources.GetObject("case02.Image"), System.Drawing.Image)
        Me.case02.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.case02.Location = New System.Drawing.Point(407, 27)
        Me.case02.Name = "case02"
        Me.case02.Size = New System.Drawing.Size(180, 115)
        Me.case02.TabIndex = 13
        Me.case02.UseVisualStyleBackColor = False
        '
        'case04
        '
        Me.case04.Appearance = System.Windows.Forms.Appearance.Button
        Me.case04.BackColor = System.Drawing.Color.Khaki
        Me.case04.Image = CType(resources.GetObject("case04.Image"), System.Drawing.Image)
        Me.case04.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.case04.Location = New System.Drawing.Point(33, 27)
        Me.case04.Name = "case04"
        Me.case04.Size = New System.Drawing.Size(180, 115)
        Me.case04.TabIndex = 15
        Me.case04.UseVisualStyleBackColor = False
        '
        'case03
        '
        Me.case03.Appearance = System.Windows.Forms.Appearance.Button
        Me.case03.BackColor = System.Drawing.Color.PowderBlue
        Me.case03.Image = CType(resources.GetObject("case03.Image"), System.Drawing.Image)
        Me.case03.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.case03.Location = New System.Drawing.Point(221, 27)
        Me.case03.Name = "case03"
        Me.case03.Size = New System.Drawing.Size(180, 115)
        Me.case03.TabIndex = 14
        Me.case03.UseVisualStyleBackColor = False
        '
        'group01
        '
        Me.group01.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.group01.Controls.Add(Me.label_title)
        Me.group01.Location = New System.Drawing.Point(27, 0)
        Me.group01.Name = "group01"
        Me.group01.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.group01.Size = New System.Drawing.Size(802, 46)
        Me.group01.TabIndex = 28
        Me.group01.TabStop = False
        '
        'label_title
        '
        Me.label_title.Dock = System.Windows.Forms.DockStyle.Fill
        Me.label_title.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_title.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label_title.Location = New System.Drawing.Point(3, 18)
        Me.label_title.Name = "label_title"
        Me.label_title.Size = New System.Drawing.Size(796, 25)
        Me.label_title.TabIndex = 0
        Me.label_title.Text = "במסך זה ניתן לבחון את כל האנליזות שבוצעו על מנת לבדוק את דיוק תוצאות התוכנה ביחס " & _
            "לאנליזות אלמנטים סופיים."
        '
        'Groupbox_datashow
        '
        Me.Groupbox_datashow.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Groupbox_datashow.Controls.Add(Me.DataGrid)
        Me.Groupbox_datashow.Location = New System.Drawing.Point(23, 274)
        Me.Groupbox_datashow.Name = "Groupbox_datashow"
        Me.Groupbox_datashow.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Groupbox_datashow.Size = New System.Drawing.Size(802, 342)
        Me.Groupbox_datashow.TabIndex = 29
        Me.Groupbox_datashow.TabStop = False
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGrid.Location = New System.Drawing.Point(3, 18)
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGrid.RowTemplate.Height = 24
        Me.DataGrid.Size = New System.Drawing.Size(796, 321)
        Me.DataGrid.TabIndex = 1
        '
        'DB_DataSet
        '
        Me.DB_DataSet.DataSetName = "DB_DataSet"
        Me.DB_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapter_All
        '
        Me.TableAdapter_All.ClearBeforeFill = True
        '
        'Source_Geo01
        '
        Me.Source_Geo01.DataMember = "geo01"
        Me.Source_Geo01.DataSource = Me.DB_DataSet
        '
        'TableAdapter_Geo01
        '
        Me.TableAdapter_Geo01.ClearBeforeFill = True
        '
        'Source_Geo02
        '
        Me.Source_Geo02.DataMember = "geo02"
        Me.Source_Geo02.DataSource = Me.DB_DataSet
        '
        'TableAdapter_Geo02
        '
        Me.TableAdapter_Geo02.ClearBeforeFill = True
        '
        'Source_Geo03
        '
        Me.Source_Geo03.DataMember = "geo03"
        Me.Source_Geo03.DataSource = Me.DB_DataSet
        '
        'TableAdapter_Geo03
        '
        Me.TableAdapter_Geo03.ClearBeforeFill = True
        '
        'Source_Geo04
        '
        Me.Source_Geo04.DataMember = "geo04"
        Me.Source_Geo04.DataSource = Me.DB_DataSet
        '
        'TableAdapter_Geo04
        '
        Me.TableAdapter_Geo04.ClearBeforeFill = True
        '
        'GroupBox_type
        '
        Me.GroupBox_type.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_type.Controls.Add(Me.PictureBox_arrow01)
        Me.GroupBox_type.Controls.Add(Me.PictureBox_arrow03)
        Me.GroupBox_type.Controls.Add(Me.PictureBox_arrow04)
        Me.GroupBox_type.Controls.Add(Me.PictureBox_arrow02)
        Me.GroupBox_type.Controls.Add(Me.RadioButton_type_values)
        Me.GroupBox_type.Controls.Add(Me.RadioButton_type_figures)
        Me.GroupBox_type.Font = New System.Drawing.Font("David", 10.8!)
        Me.GroupBox_type.Location = New System.Drawing.Point(27, 54)
        Me.GroupBox_type.Name = "GroupBox_type"
        Me.GroupBox_type.Size = New System.Drawing.Size(799, 56)
        Me.GroupBox_type.TabIndex = 35
        Me.GroupBox_type.TabStop = False
        Me.GroupBox_type.Text = "אופן הצגת תוצאות"
        '
        'PictureBox_arrow01
        '
        Me.PictureBox_arrow01.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox_arrow01.Image = Global.SPE.My.Resources.Resources.arrw01_012
        Me.PictureBox_arrow01.Location = New System.Drawing.Point(650, 21)
        Me.PictureBox_arrow01.Name = "PictureBox_arrow01"
        Me.PictureBox_arrow01.Size = New System.Drawing.Size(31, 26)
        Me.PictureBox_arrow01.TabIndex = 5
        Me.PictureBox_arrow01.TabStop = False
        '
        'PictureBox_arrow03
        '
        Me.PictureBox_arrow03.Image = Global.SPE.My.Resources.Resources.arrw01_012
        Me.PictureBox_arrow03.Location = New System.Drawing.Point(357, 21)
        Me.PictureBox_arrow03.Name = "PictureBox_arrow03"
        Me.PictureBox_arrow03.Size = New System.Drawing.Size(31, 26)
        Me.PictureBox_arrow03.TabIndex = 4
        Me.PictureBox_arrow03.TabStop = False
        Me.PictureBox_arrow03.Visible = False
        '
        'PictureBox_arrow04
        '
        Me.PictureBox_arrow04.Image = Global.SPE.My.Resources.Resources.arrw01_01a
        Me.PictureBox_arrow04.Location = New System.Drawing.Point(95, 21)
        Me.PictureBox_arrow04.Name = "PictureBox_arrow04"
        Me.PictureBox_arrow04.Size = New System.Drawing.Size(31, 26)
        Me.PictureBox_arrow04.TabIndex = 3
        Me.PictureBox_arrow04.TabStop = False
        Me.PictureBox_arrow04.Visible = False
        '
        'PictureBox_arrow02
        '
        Me.PictureBox_arrow02.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox_arrow02.Image = Global.SPE.My.Resources.Resources.arrw01_01a
        Me.PictureBox_arrow02.Location = New System.Drawing.Point(388, 21)
        Me.PictureBox_arrow02.Name = "PictureBox_arrow02"
        Me.PictureBox_arrow02.Size = New System.Drawing.Size(31, 26)
        Me.PictureBox_arrow02.TabIndex = 2
        Me.PictureBox_arrow02.TabStop = False
        '
        'RadioButton_type_values
        '
        Me.RadioButton_type_values.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton_type_values.AutoEllipsis = True
        Me.RadioButton_type_values.Location = New System.Drawing.Point(132, 21)
        Me.RadioButton_type_values.Name = "RadioButton_type_values"
        Me.RadioButton_type_values.Size = New System.Drawing.Size(219, 30)
        Me.RadioButton_type_values.TabIndex = 1
        Me.RadioButton_type_values.Text = "תוצאות מספריות"
        Me.RadioButton_type_values.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton_type_values.UseVisualStyleBackColor = True
        '
        'RadioButton_type_figures
        '
        Me.RadioButton_type_figures.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButton_type_figures.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton_type_figures.AutoEllipsis = True
        Me.RadioButton_type_figures.Checked = True
        Me.RadioButton_type_figures.Location = New System.Drawing.Point(425, 21)
        Me.RadioButton_type_figures.Name = "RadioButton_type_figures"
        Me.RadioButton_type_figures.Size = New System.Drawing.Size(219, 30)
        Me.RadioButton_type_figures.TabIndex = 0
        Me.RadioButton_type_figures.TabStop = True
        Me.RadioButton_type_figures.Text = "תצוגה גרפית"
        Me.RadioButton_type_figures.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton_type_figures.UseVisualStyleBackColor = True
        '
        'GroupBox_figures
        '
        Me.GroupBox_figures.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_figures.Controls.Add(Me.Panel_figures)
        Me.GroupBox_figures.Location = New System.Drawing.Point(23, 274)
        Me.GroupBox_figures.Name = "GroupBox_figures"
        Me.GroupBox_figures.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox_figures.Size = New System.Drawing.Size(802, 342)
        Me.GroupBox_figures.TabIndex = 36
        Me.GroupBox_figures.TabStop = False
        '
        'Panel_figures
        '
        Me.Panel_figures.AutoScroll = True
        Me.Panel_figures.Controls.Add(Me.GroupBox_geo3)
        Me.Panel_figures.Controls.Add(Me.GroupBox_geo_all)
        Me.Panel_figures.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_figures.Location = New System.Drawing.Point(3, 18)
        Me.Panel_figures.Name = "Panel_figures"
        Me.Panel_figures.Size = New System.Drawing.Size(796, 321)
        Me.Panel_figures.TabIndex = 0
        '
        'GroupBox_geo3
        '
        Me.GroupBox_geo3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_geo3.Controls.Add(Me.PictureBox_right_arrow2)
        Me.GroupBox_geo3.Controls.Add(Me.PictureBox_left_arrow2)
        Me.GroupBox_geo3.Controls.Add(Me.PictureBox_right_arrow1)
        Me.GroupBox_geo3.Controls.Add(Me.PictureBox_left_arrow1)
        Me.GroupBox_geo3.Controls.Add(Me.PictureBox_figures_geo3)
        Me.GroupBox_geo3.Controls.Add(Me.RadioButton_geo3_case3_4)
        Me.GroupBox_geo3.Controls.Add(Me.RadioButton_geo3_case1_2)
        Me.GroupBox_geo3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox_geo3.Name = "GroupBox_geo3"
        Me.GroupBox_geo3.Size = New System.Drawing.Size(743, 452)
        Me.GroupBox_geo3.TabIndex = 2
        Me.GroupBox_geo3.TabStop = False
        Me.GroupBox_geo3.Visible = False
        '
        'PictureBox_right_arrow2
        '
        Me.PictureBox_right_arrow2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox_right_arrow2.Image = Global.SPE.My.Resources.Resources.arrw01_04b
        Me.PictureBox_right_arrow2.Location = New System.Drawing.Point(701, 91)
        Me.PictureBox_right_arrow2.Name = "PictureBox_right_arrow2"
        Me.PictureBox_right_arrow2.Size = New System.Drawing.Size(31, 26)
        Me.PictureBox_right_arrow2.TabIndex = 9
        Me.PictureBox_right_arrow2.TabStop = False
        Me.PictureBox_right_arrow2.Visible = False
        '
        'PictureBox_left_arrow2
        '
        Me.PictureBox_left_arrow2.Image = Global.SPE.My.Resources.Resources.arrw01_04a
        Me.PictureBox_left_arrow2.Location = New System.Drawing.Point(2, 91)
        Me.PictureBox_left_arrow2.Name = "PictureBox_left_arrow2"
        Me.PictureBox_left_arrow2.Size = New System.Drawing.Size(31, 26)
        Me.PictureBox_left_arrow2.TabIndex = 8
        Me.PictureBox_left_arrow2.TabStop = False
        Me.PictureBox_left_arrow2.Visible = False
        '
        'PictureBox_right_arrow1
        '
        Me.PictureBox_right_arrow1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox_right_arrow1.Image = Global.SPE.My.Resources.Resources.arrw01_04b
        Me.PictureBox_right_arrow1.Location = New System.Drawing.Point(701, 35)
        Me.PictureBox_right_arrow1.Name = "PictureBox_right_arrow1"
        Me.PictureBox_right_arrow1.Size = New System.Drawing.Size(31, 26)
        Me.PictureBox_right_arrow1.TabIndex = 7
        Me.PictureBox_right_arrow1.TabStop = False
        '
        'PictureBox_left_arrow1
        '
        Me.PictureBox_left_arrow1.Image = Global.SPE.My.Resources.Resources.arrw01_04a
        Me.PictureBox_left_arrow1.Location = New System.Drawing.Point(2, 35)
        Me.PictureBox_left_arrow1.Name = "PictureBox_left_arrow1"
        Me.PictureBox_left_arrow1.Size = New System.Drawing.Size(31, 26)
        Me.PictureBox_left_arrow1.TabIndex = 6
        Me.PictureBox_left_arrow1.TabStop = False
        '
        'PictureBox_figures_geo3
        '
        Me.PictureBox_figures_geo3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox_figures_geo3.Image = Global.SPE.My.Resources.Resources.results_geo3_case_1and2
        Me.PictureBox_figures_geo3.Location = New System.Drawing.Point(6, 140)
        Me.PictureBox_figures_geo3.Name = "PictureBox_figures_geo3"
        Me.PictureBox_figures_geo3.Size = New System.Drawing.Size(731, 309)
        Me.PictureBox_figures_geo3.TabIndex = 3
        Me.PictureBox_figures_geo3.TabStop = False
        '
        'RadioButton_geo3_case3_4
        '
        Me.RadioButton_geo3_case3_4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButton_geo3_case3_4.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton_geo3_case3_4.AutoEllipsis = True
        Me.RadioButton_geo3_case3_4.Location = New System.Drawing.Point(42, 79)
        Me.RadioButton_geo3_case3_4.Name = "RadioButton_geo3_case3_4"
        Me.RadioButton_geo3_case3_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RadioButton_geo3_case3_4.Size = New System.Drawing.Size(652, 52)
        Me.RadioButton_geo3_case3_4.TabIndex = 2
        Me.RadioButton_geo3_case3_4.Text = "BC 3: Short edges are simply supported, long edges are fixed" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BC 4: All edges are" & _
            " fixed"
        Me.RadioButton_geo3_case3_4.UseVisualStyleBackColor = True
        '
        'RadioButton_geo3_case1_2
        '
        Me.RadioButton_geo3_case1_2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButton_geo3_case1_2.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton_geo3_case1_2.AutoEllipsis = True
        Me.RadioButton_geo3_case1_2.Checked = True
        Me.RadioButton_geo3_case1_2.Location = New System.Drawing.Point(42, 21)
        Me.RadioButton_geo3_case1_2.Name = "RadioButton_geo3_case1_2"
        Me.RadioButton_geo3_case1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RadioButton_geo3_case1_2.Size = New System.Drawing.Size(652, 52)
        Me.RadioButton_geo3_case1_2.TabIndex = 1
        Me.RadioButton_geo3_case1_2.TabStop = True
        Me.RadioButton_geo3_case1_2.Text = "BC 1: All edges are simply supported" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BC 2: Long edges are simply supported, shor" & _
            "t edges are fixed"
        Me.RadioButton_geo3_case1_2.UseVisualStyleBackColor = True
        '
        'GroupBox_geo_all
        '
        Me.GroupBox_geo_all.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_geo_all.Controls.Add(Me.PictureBox_geo_all)
        Me.GroupBox_geo_all.Location = New System.Drawing.Point(8, 3)
        Me.GroupBox_geo_all.Name = "GroupBox_geo_all"
        Me.GroupBox_geo_all.Size = New System.Drawing.Size(738, 461)
        Me.GroupBox_geo_all.TabIndex = 11
        Me.GroupBox_geo_all.TabStop = False
        Me.GroupBox_geo_all.Visible = False
        '
        'PictureBox_geo_all
        '
        Me.PictureBox_geo_all.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox_geo_all.Image = Global.SPE.My.Resources.Resources.results_geo4_case_all
        Me.PictureBox_geo_all.Location = New System.Drawing.Point(3, 18)
        Me.PictureBox_geo_all.Name = "PictureBox_geo_all"
        Me.PictureBox_geo_all.Size = New System.Drawing.Size(732, 440)
        Me.PictureBox_geo_all.TabIndex = 3
        Me.PictureBox_geo_all.TabStop = False
        '
        'GUI_FEA_results
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(861, 628)
        Me.Controls.Add(Me.GroupBox_type)
        Me.Controls.Add(Me.groupbox_geo)
        Me.Controls.Add(Me.group01)
        Me.Controls.Add(Me.Groupbox_datashow)
        Me.Controls.Add(Me.GroupBox_figures)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(856, 668)
        Me.Name = "GUI_FEA_results"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "תוצאות אנליזות אלמנטים סופיים שבוצעו עבור בדיקת דיוק התוכנה"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.groupbox_geo.ResumeLayout(False)
        Me.group01.ResumeLayout(False)
        Me.Groupbox_datashow.ResumeLayout(False)
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Source_Geo01, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Source_Geo02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Source_Geo03, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Source_Geo04, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_type.ResumeLayout(False)
        CType(Me.PictureBox_arrow01, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_arrow03, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_arrow04, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_arrow02, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_figures.ResumeLayout(False)
        Me.Panel_figures.ResumeLayout(False)
        Me.GroupBox_geo3.ResumeLayout(False)
        CType(Me.PictureBox_right_arrow2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_left_arrow2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_right_arrow1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_left_arrow1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_figures_geo3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_geo_all.ResumeLayout(False)
        CType(Me.PictureBox_geo_all, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Source_ALL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Sub GUI_set()
        Me.SuspendLayout()
        Me.RightToLeft = language_settings.language_RTL
        Me.RightToLeftLayout = language_settings.language_RTL_layout
        DataGrid.RightToLeft = language_settings.language_RTL
        groupbox_geo.RightToLeft = language_settings.language_RTL
        Groupbox_datashow.RightToLeft = language_settings.language_RTL
        label_title.RightToLeft = language_settings.language_RTL
        'If language_settings.language_RTL_layout = True Then
        '    case01.Anchor = AnchorStyles.Top + AnchorStyles.Right
        '    case02.Anchor = AnchorStyles.Top + AnchorStyles.Right
        '    case03.Anchor = AnchorStyles.Top + AnchorStyles.Right
        '    case04.Anchor = AnchorStyles.Top + AnchorStyles.Right
        'Else
        '    case01.Anchor = AnchorStyles.Top + AnchorStyles.Left
        '    case02.Anchor = AnchorStyles.Top + AnchorStyles.Left
        '    case03.Anchor = AnchorStyles.Top + AnchorStyles.Left
        '    case04.Anchor = AnchorStyles.Top + AnchorStyles.Left
        'End If
        Me.Text = language_settings.FEA_text
        groupbox_geo.Text = language_settings.FEA_groupbox_geo
        label_title.Text = language_settings.FEA_label_title
        GroupBox_type.Text = language_settings.FEA_GroupBox_type
        RadioButton_type_values.Text = language_settings.FEA_RadioButton_type_values
        RadioButton_type_figures.Text = language_settings.FEA_RadioButton_type_figures
        RadioButton_geo3_case1_2.Text = language_settings.FEA_RadioButton_geo3_case1_2a + Chr(13) + language_settings.FEA_RadioButton_geo3_case1_2b
        RadioButton_geo3_case3_4.Text = language_settings.FEA_RadioButton_geo3_case3_4a + Chr(13) + language_settings.FEA_RadioButton_geo3_case3_4b
        GUI_set_datagrid_set()
        Me.ResumeLayout()
    End Sub
    Private Sub GUI_set_datagrid_set()
        If DataGrid.ColumnCount <> 0 Then
            DataGrid.Columns(0).HeaderText = language_settings.FEA_dataview_header01
            DataGrid.Columns(1).HeaderText = language_settings.FEA_dataview_header02
            DataGrid.Columns(2).HeaderText = language_settings.FEA_dataview_header03
            DataGrid.Columns(3).HeaderText = language_settings.FEA_dataview_header04
            DataGrid.Columns(4).HeaderText = language_settings.FEA_dataview_header05
            DataGrid.Columns(5).HeaderText = language_settings.FEA_dataview_header06
            DataGrid.Columns(6).HeaderText = language_settings.FEA_dataview_header07
            DataGrid.Columns(7).HeaderText = language_settings.FEA_dataview_header08
            DataGrid.Columns(8).HeaderText = language_settings.FEA_dataview_header09
            DataGrid.Columns(9).HeaderText = language_settings.FEA_dataview_header10
            DataGrid.Columns(10).HeaderText = language_settings.FEA_dataview_header11
            DataGrid.Columns(11).HeaderText = language_settings.FEA_dataview_header12
            DataGrid.Columns(12).HeaderText = language_settings.FEA_dataview_header13
            DataGrid.Columns(13).HeaderText = language_settings.FEA_dataview_header14
            DataGrid.Columns(14).HeaderText = language_settings.FEA_dataview_header15
            DataGrid.Columns(15).HeaderText = language_settings.FEA_dataview_header16
        End If
    End Sub
    Private Sub case01_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles case01.CheckedChanged
        GroupBox_geo3.Visible = False
        PictureBox_geo_all.Image = My.Resources.results_geo1_case_all
        GroupBox_geo_all.Visible = True
        DataGrid.DataSource = Source_Geo01
        case01.BackColor = color_back
        case02.BackColor = color_back
        case03.BackColor = color_back
        case04.BackColor = color_back
        If case01.Checked = True Then
            case01.BackColor = color_front
        ElseIf case02.Checked = True Then
            case02.BackColor = color_front
        ElseIf case03.Checked = True Then
            case03.BackColor = color_front
        ElseIf case04.Checked = True Then
            case04.BackColor = color_front
        End If
        GUI_set_datagrid_set()
    End Sub
    Private Sub case02_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles case02.CheckedChanged
        GroupBox_geo3.Visible = False
        PictureBox_geo_all.Image = My.Resources.results_geo2_case_all
        GroupBox_geo_all.Visible = True
        DataGrid.DataSource = Source_Geo02
        case01.BackColor = color_back
        case02.BackColor = color_back
        case03.BackColor = color_back
        case04.BackColor = color_back
        If case01.Checked = True Then
            case01.BackColor = color_front
        ElseIf case02.Checked = True Then
            case02.BackColor = color_front
        ElseIf case03.Checked = True Then
            case03.BackColor = color_front
        ElseIf case04.Checked = True Then
            case04.BackColor = color_front
        End If
    End Sub
    Private Sub case03_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles case03.CheckedChanged
        GroupBox_geo3.Visible = True
        GroupBox_geo_all.Visible = False
        DataGrid.DataSource = Source_Geo03
        case01.BackColor = color_back
        case02.BackColor = color_back
        case03.BackColor = color_back
        case04.BackColor = color_back
        If case01.Checked = True Then
            case01.BackColor = color_front
        ElseIf case02.Checked = True Then
            case02.BackColor = color_front
        ElseIf case03.Checked = True Then
            case03.BackColor = color_front
        ElseIf case04.Checked = True Then
            case04.BackColor = color_front
        End If
    End Sub
    Private Sub case04_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles case04.CheckedChanged
        GroupBox_geo3.Visible = False
        PictureBox_geo_all.Image = My.Resources.results_geo4_case_all
        GroupBox_geo_all.Visible = True
        DataGrid.DataSource = Source_Geo04
        case01.BackColor = color_back
        case02.BackColor = color_back
        case03.BackColor = color_back
        case04.BackColor = color_back
        If case01.Checked = True Then
            case01.BackColor = color_front
        ElseIf case02.Checked = True Then
            case02.BackColor = color_front
        ElseIf case03.Checked = True Then
            case03.BackColor = color_front
        ElseIf case04.Checked = True Then
            case04.BackColor = color_front
        End If
    End Sub
    Private Sub FEA_results_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GUI_set()
        If File.Exists("results.mdb") = True Then
            Me.TableAdapter_Geo01.Fill(Me.DB_DataSet.geo01)
            Me.TableAdapter_Geo02.Fill(Me.DB_DataSet.geo02)
            Me.TableAdapter_Geo03.Fill(Me.DB_DataSet.geo03)
            Me.TableAdapter_Geo04.Fill(Me.DB_DataSet.geo04)
            Me.TableAdapter_All.Fill(Me.DB_DataSet.All)
        Else

        End If
        case01.BackColor = color_back
        case02.BackColor = color_back
        case03.BackColor = color_back
        case04.BackColor = color_back
    End Sub
    Sub change_type_of_data()
        If RadioButton_type_figures.Checked = True Then
            GroupBox_figures.Visible = True
            Groupbox_datashow.Visible = False
            PictureBox_arrow01.Visible = True
            PictureBox_arrow02.Visible = True
            PictureBox_arrow03.Visible = False
            PictureBox_arrow04.Visible = False
        Else
            GroupBox_figures.Visible = False
            Groupbox_datashow.Visible = True
            PictureBox_arrow01.Visible = False
            PictureBox_arrow02.Visible = False
            PictureBox_arrow03.Visible = True
            PictureBox_arrow04.Visible = True
        End If
    End Sub
    Sub change_figure_geometric_case_3()
        If RadioButton_geo3_case1_2.Checked = True Then
            PictureBox_figures_geo3.Image = My.Resources.results_geo3_case_1and2
            PictureBox_right_arrow1.Visible = True
            PictureBox_left_arrow1.Visible = True
            PictureBox_right_arrow2.Visible = False
            PictureBox_left_arrow2.Visible = False
        Else
            PictureBox_figures_geo3.Image = My.Resources.results_geo3_case_3and4
            PictureBox_right_arrow1.Visible = False
            PictureBox_left_arrow1.Visible = False
            PictureBox_right_arrow2.Visible = True
            PictureBox_left_arrow2.Visible = True
        End If
    End Sub
    Private Sub RadioButton_type_figures_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_type_figures.CheckedChanged
        change_type_of_data()
    End Sub
    Private Sub RadioButton_type_values_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_type_values.CheckedChanged
        change_type_of_data()
    End Sub
    Private Sub RadioButton_geo3_case1_2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_geo3_case1_2.CheckedChanged
        change_figure_geometric_case_3()
    End Sub
    Private Sub RadioButton_geo3_case3_4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_geo3_case3_4.CheckedChanged
        change_figure_geometric_case_3()
    End Sub
End Class
