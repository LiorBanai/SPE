Imports system
Imports System.IO
Imports System.Security

Public Class GUI_Launcher
    Inherits System.Windows.Forms.Form


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'general_settings.load_settings_from_registry()
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
    Friend WithEvents picture_TAU As System.Windows.Forms.PictureBox
    Friend WithEvents picture_navy_sign As System.Windows.Forms.PictureBox
    Friend WithEvents button_about As System.Windows.Forms.Button
    Friend WithEvents button_input As System.Windows.Forms.Button
    Friend WithEvents button_database As System.Windows.Forms.Button
    Friend WithEvents button_FEA_results As System.Windows.Forms.Button
    Friend WithEvents Button_model_orthotropic As System.Windows.Forms.Button
    Friend WithEvents menu_images As System.Windows.Forms.ImageList
    Friend WithEvents Picture_heb As System.Windows.Forms.PictureBox
    Friend WithEvents Picture_eng As System.Windows.Forms.PictureBox
    Friend WithEvents picture_navy_HQ_patch As System.Windows.Forms.PictureBox
    Friend WithEvents Button_ADINA As System.Windows.Forms.Button
    Friend WithEvents Button_switch As System.Windows.Forms.Button
    Friend WithEvents RichTextBox_messages As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox_model As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox_pdf_req As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_pdf_get As System.Windows.Forms.PictureBox
    Friend WithEvents Label_PDF As System.Windows.Forms.Label
    Friend WithEvents Button_read_project As System.Windows.Forms.Button
    Friend WithEvents Button_read_journal As System.Windows.Forms.Button
    Friend WithEvents RichTextBox_read_msg As System.Windows.Forms.RichTextBox
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents TSM_file As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSM_exit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSM_Base_Functions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSM_input As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSM_DB As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSM_FEA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSM_Addons As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSM_ADINA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSM_Model As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSM_Orthotropic As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSM_Orthotropic_last As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSM_Grillage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSM_Language As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSM_hebrew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSM_english As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSM_Remember_lang As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSM_separator02 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TSM_current_info As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSM_User_made As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSM_Help As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSM_Version_History As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSM_separator01 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TSM_About As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button_model_grillage As System.Windows.Forms.Button
    Friend WithEvents GroupBox_current_model As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox_current_model As System.Windows.Forms.ComboBox
    Friend WithEvents TSM_combo_prompt As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents Label_fast_results As System.Windows.Forms.Label
    Friend WithEvents GroupBox_fast_results As System.Windows.Forms.GroupBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TSM_Grillage_last As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSM_grillage_summary As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label_DOI As System.Windows.Forms.Label
    Friend WithEvents Button_DOI As System.Windows.Forms.Button
    Friend WithEvents GroupBox_new As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox_new As System.Windows.Forms.PictureBox
    Friend WithEvents RichTextBox_new As System.Windows.Forms.RichTextBox
    Friend WithEvents PictureBox_SAOS As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tsGithub As ToolStripStatusLabel
    Friend WithEvents tsKoFi As ToolStripStatusLabel
    Friend WithEvents tsPayPal As ToolStripStatusLabel
    Friend WithEvents PictureBox_MT As PictureBox
    Friend WithEvents TSM_Orthotropic_summary As System.Windows.Forms.ToolStripMenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI_Launcher))
        Me.button_input = New System.Windows.Forms.Button()
        Me.button_database = New System.Windows.Forms.Button()
        Me.button_FEA_results = New System.Windows.Forms.Button()
        Me.picture_TAU = New System.Windows.Forms.PictureBox()
        Me.picture_navy_sign = New System.Windows.Forms.PictureBox()
        Me.picture_navy_HQ_patch = New System.Windows.Forms.PictureBox()
        Me.Button_model_orthotropic = New System.Windows.Forms.Button()
        Me.button_about = New System.Windows.Forms.Button()
        Me.menu_images = New System.Windows.Forms.ImageList(Me.components)
        Me.Picture_heb = New System.Windows.Forms.PictureBox()
        Me.Picture_eng = New System.Windows.Forms.PictureBox()
        Me.Button_ADINA = New System.Windows.Forms.Button()
        Me.Button_switch = New System.Windows.Forms.Button()
        Me.RichTextBox_messages = New System.Windows.Forms.RichTextBox()
        Me.GroupBox_model = New System.Windows.Forms.GroupBox()
        Me.Button_DOI = New System.Windows.Forms.Button()
        Me.Label_DOI = New System.Windows.Forms.Label()
        Me.PictureBox_pdf_get = New System.Windows.Forms.PictureBox()
        Me.RichTextBox_read_msg = New System.Windows.Forms.RichTextBox()
        Me.Button_read_journal = New System.Windows.Forms.Button()
        Me.Button_read_project = New System.Windows.Forms.Button()
        Me.Label_PDF = New System.Windows.Forms.Label()
        Me.PictureBox_pdf_req = New System.Windows.Forms.PictureBox()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.TSM_file = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_Base_Functions = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_input = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_DB = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_FEA = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_Addons = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_ADINA = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_Model = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_Orthotropic = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_Orthotropic_last = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_Orthotropic_summary = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_Grillage = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_Grillage_last = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_grillage_summary = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_Language = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_hebrew = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_english = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_User_made = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_separator02 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSM_Remember_lang = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_current_info = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_Help = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_Version_History = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_separator01 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSM_About = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_combo_prompt = New System.Windows.Forms.ToolStripComboBox()
        Me.Button_model_grillage = New System.Windows.Forms.Button()
        Me.GroupBox_current_model = New System.Windows.Forms.GroupBox()
        Me.ComboBox_current_model = New System.Windows.Forms.ComboBox()
        Me.Label_fast_results = New System.Windows.Forms.Label()
        Me.GroupBox_fast_results = New System.Windows.Forms.GroupBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox_new = New System.Windows.Forms.GroupBox()
        Me.PictureBox_MT = New System.Windows.Forms.PictureBox()
        Me.RichTextBox_new = New System.Windows.Forms.RichTextBox()
        Me.PictureBox_new = New System.Windows.Forms.PictureBox()
        Me.PictureBox_SAOS = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsGithub = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsKoFi = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsPayPal = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.picture_TAU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picture_navy_sign, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picture_navy_HQ_patch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture_heb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture_eng, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_model.SuspendLayout()
        CType(Me.PictureBox_pdf_get, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_pdf_req, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.GroupBox_current_model.SuspendLayout()
        Me.GroupBox_fast_results.SuspendLayout()
        Me.GroupBox_new.SuspendLayout()
        CType(Me.PictureBox_MT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_new, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_SAOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'button_input
        '
        Me.button_input.Image = CType(resources.GetObject("button_input.Image"), System.Drawing.Image)
        Me.button_input.Location = New System.Drawing.Point(3, 38)
        Me.button_input.Name = "button_input"
        Me.button_input.Size = New System.Drawing.Size(90, 90)
        Me.button_input.TabIndex = 0
        '
        'button_database
        '
        Me.button_database.Image = CType(resources.GetObject("button_database.Image"), System.Drawing.Image)
        Me.button_database.Location = New System.Drawing.Point(4, 234)
        Me.button_database.Name = "button_database"
        Me.button_database.Size = New System.Drawing.Size(90, 90)
        Me.button_database.TabIndex = 1
        '
        'button_FEA_results
        '
        Me.button_FEA_results.Image = Global.SPE.My.Resources.Resources.Bar_graph
        Me.button_FEA_results.Location = New System.Drawing.Point(111, 381)
        Me.button_FEA_results.Name = "button_FEA_results"
        Me.button_FEA_results.Size = New System.Drawing.Size(90, 90)
        Me.button_FEA_results.TabIndex = 2
        Me.button_FEA_results.Visible = False
        '
        'picture_TAU
        '
        Me.picture_TAU.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picture_TAU.BackColor = System.Drawing.Color.Transparent
        Me.picture_TAU.Image = CType(resources.GetObject("picture_TAU.Image"), System.Drawing.Image)
        Me.picture_TAU.Location = New System.Drawing.Point(0, 666)
        Me.picture_TAU.Name = "picture_TAU"
        Me.picture_TAU.Size = New System.Drawing.Size(362, 52)
        Me.picture_TAU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picture_TAU.TabIndex = 7
        Me.picture_TAU.TabStop = False
        '
        'picture_navy_sign
        '
        Me.picture_navy_sign.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picture_navy_sign.Image = CType(resources.GetObject("picture_navy_sign.Image"), System.Drawing.Image)
        Me.picture_navy_sign.Location = New System.Drawing.Point(1013, 120)
        Me.picture_navy_sign.Name = "picture_navy_sign"
        Me.picture_navy_sign.Size = New System.Drawing.Size(135, 128)
        Me.picture_navy_sign.TabIndex = 8
        Me.picture_navy_sign.TabStop = False
        Me.picture_navy_sign.Visible = False
        '
        'picture_navy_HQ_patch
        '
        Me.picture_navy_HQ_patch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picture_navy_HQ_patch.Image = CType(resources.GetObject("picture_navy_HQ_patch.Image"), System.Drawing.Image)
        Me.picture_navy_HQ_patch.Location = New System.Drawing.Point(976, 254)
        Me.picture_navy_HQ_patch.Name = "picture_navy_HQ_patch"
        Me.picture_navy_HQ_patch.Size = New System.Drawing.Size(172, 183)
        Me.picture_navy_HQ_patch.TabIndex = 9
        Me.picture_navy_HQ_patch.TabStop = False
        Me.picture_navy_HQ_patch.Visible = False
        '
        'Button_model_orthotropic
        '
        Me.Button_model_orthotropic.Image = CType(resources.GetObject("Button_model_orthotropic.Image"), System.Drawing.Image)
        Me.Button_model_orthotropic.Location = New System.Drawing.Point(111, 484)
        Me.Button_model_orthotropic.Name = "Button_model_orthotropic"
        Me.Button_model_orthotropic.Size = New System.Drawing.Size(90, 90)
        Me.Button_model_orthotropic.TabIndex = 11
        Me.Button_model_orthotropic.Visible = False
        '
        'button_about
        '
        Me.button_about.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.button_about.Image = CType(resources.GetObject("button_about.Image"), System.Drawing.Image)
        Me.button_about.Location = New System.Drawing.Point(3, 428)
        Me.button_about.Name = "button_about"
        Me.button_about.Size = New System.Drawing.Size(90, 90)
        Me.button_about.TabIndex = 3
        Me.button_about.Text = "About"
        Me.button_about.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'menu_images
        '
        Me.menu_images.ImageStream = CType(resources.GetObject("menu_images.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.menu_images.TransparentColor = System.Drawing.Color.Transparent
        Me.menu_images.Images.SetKeyName(0, "")
        Me.menu_images.Images.SetKeyName(1, "")
        Me.menu_images.Images.SetKeyName(2, "")
        '
        'Picture_heb
        '
        Me.Picture_heb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Picture_heb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Picture_heb.Image = Global.SPE.My.Resources.Resources.flag_hebrew01
        Me.Picture_heb.Location = New System.Drawing.Point(1121, 42)
        Me.Picture_heb.Name = "Picture_heb"
        Me.Picture_heb.Size = New System.Drawing.Size(32, 20)
        Me.Picture_heb.TabIndex = 19
        Me.Picture_heb.TabStop = False
        '
        'Picture_eng
        '
        Me.Picture_eng.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Picture_eng.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Picture_eng.Image = Global.SPE.My.Resources.Resources.flag_english01
        Me.Picture_eng.Location = New System.Drawing.Point(1121, 66)
        Me.Picture_eng.Name = "Picture_eng"
        Me.Picture_eng.Size = New System.Drawing.Size(32, 16)
        Me.Picture_eng.TabIndex = 20
        Me.Picture_eng.TabStop = False
        '
        'Button_ADINA
        '
        Me.Button_ADINA.Image = CType(resources.GetObject("Button_ADINA.Image"), System.Drawing.Image)
        Me.Button_ADINA.Location = New System.Drawing.Point(3, 332)
        Me.Button_ADINA.Name = "Button_ADINA"
        Me.Button_ADINA.Size = New System.Drawing.Size(90, 90)
        Me.Button_ADINA.TabIndex = 24
        '
        'Button_switch
        '
        Me.Button_switch.Font = New System.Drawing.Font("David", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Button_switch.Image = CType(resources.GetObject("Button_switch.Image"), System.Drawing.Image)
        Me.Button_switch.Location = New System.Drawing.Point(10, 534)
        Me.Button_switch.Name = "Button_switch"
        Me.Button_switch.Size = New System.Drawing.Size(68, 40)
        Me.Button_switch.TabIndex = 25
        Me.Button_switch.Visible = False
        '
        'RichTextBox_messages
        '
        Me.RichTextBox_messages.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox_messages.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox_messages.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox_messages.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RichTextBox_messages.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.RichTextBox_messages.Location = New System.Drawing.Point(100, 46)
        Me.RichTextBox_messages.Name = "RichTextBox_messages"
        Me.RichTextBox_messages.ReadOnly = True
        Me.RichTextBox_messages.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RichTextBox_messages.Size = New System.Drawing.Size(872, 304)
        Me.RichTextBox_messages.TabIndex = 26
        Me.RichTextBox_messages.Text = ""
        Me.RichTextBox_messages.Visible = False
        '
        'GroupBox_model
        '
        Me.GroupBox_model.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_model.Controls.Add(Me.Button_DOI)
        Me.GroupBox_model.Controls.Add(Me.Label_DOI)
        Me.GroupBox_model.Controls.Add(Me.PictureBox_pdf_get)
        Me.GroupBox_model.Controls.Add(Me.RichTextBox_read_msg)
        Me.GroupBox_model.Controls.Add(Me.Button_read_journal)
        Me.GroupBox_model.Controls.Add(Me.Button_read_project)
        Me.GroupBox_model.Controls.Add(Me.Label_PDF)
        Me.GroupBox_model.Controls.Add(Me.PictureBox_pdf_req)
        Me.GroupBox_model.Location = New System.Drawing.Point(100, 39)
        Me.GroupBox_model.Name = "GroupBox_model"
        Me.GroupBox_model.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox_model.Size = New System.Drawing.Size(872, 304)
        Me.GroupBox_model.TabIndex = 27
        Me.GroupBox_model.TabStop = False
        Me.GroupBox_model.Visible = False
        '
        'Button_DOI
        '
        Me.Button_DOI.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_DOI.Image = Global.SPE.My.Resources.Resources.m_map
        Me.Button_DOI.Location = New System.Drawing.Point(772, 126)
        Me.Button_DOI.Name = "Button_DOI"
        Me.Button_DOI.Size = New System.Drawing.Size(42, 33)
        Me.Button_DOI.TabIndex = 29
        Me.Button_DOI.UseVisualStyleBackColor = True
        '
        'Label_DOI
        '
        Me.Label_DOI.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_DOI.AutoEllipsis = True
        Me.Label_DOI.Font = New System.Drawing.Font("David", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_DOI.Location = New System.Drawing.Point(586, 126)
        Me.Label_DOI.Name = "Label_DOI"
        Me.Label_DOI.Size = New System.Drawing.Size(180, 33)
        Me.Label_DOI.TabIndex = 28
        Me.Label_DOI.Text = "DOI: 10.1533/saos.2005.0135"
        Me.Label_DOI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox_pdf_get
        '
        Me.PictureBox_pdf_get.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox_pdf_get.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_pdf_get.Image = CType(resources.GetObject("PictureBox_pdf_get.Image"), System.Drawing.Image)
        Me.PictureBox_pdf_get.Location = New System.Drawing.Point(772, 264)
        Me.PictureBox_pdf_get.Name = "PictureBox_pdf_get"
        Me.PictureBox_pdf_get.Size = New System.Drawing.Size(92, 32)
        Me.PictureBox_pdf_get.TabIndex = 1
        Me.PictureBox_pdf_get.TabStop = False
        '
        'RichTextBox_read_msg
        '
        Me.RichTextBox_read_msg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox_read_msg.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox_read_msg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox_read_msg.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RichTextBox_read_msg.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.RichTextBox_read_msg.Location = New System.Drawing.Point(4, 20)
        Me.RichTextBox_read_msg.Name = "RichTextBox_read_msg"
        Me.RichTextBox_read_msg.ReadOnly = True
        Me.RichTextBox_read_msg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RichTextBox_read_msg.Size = New System.Drawing.Size(860, 108)
        Me.RichTextBox_read_msg.TabIndex = 27
        Me.RichTextBox_read_msg.Text = "In this section the user can read about the Orthotropic plate model. The left but" &
    "ton opens the fourth year project file while the right opens an english summary " &
    "of the entire project."
        '
        'Button_read_journal
        '
        Me.Button_read_journal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_read_journal.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Button_read_journal.Image = CType(resources.GetObject("Button_read_journal.Image"), System.Drawing.Image)
        Me.Button_read_journal.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_read_journal.Location = New System.Drawing.Point(635, 161)
        Me.Button_read_journal.Name = "Button_read_journal"
        Me.Button_read_journal.Size = New System.Drawing.Size(124, 96)
        Me.Button_read_journal.TabIndex = 4
        Me.Button_read_journal.Text = "SAOS Paper"
        Me.Button_read_journal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button_read_project
        '
        Me.Button_read_project.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Button_read_project.Image = CType(resources.GetObject("Button_read_project.Image"), System.Drawing.Image)
        Me.Button_read_project.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_read_project.Location = New System.Drawing.Point(71, 161)
        Me.Button_read_project.Name = "Button_read_project"
        Me.Button_read_project.Size = New System.Drawing.Size(124, 96)
        Me.Button_read_project.TabIndex = 3
        Me.Button_read_project.Text = "TAU Project"
        Me.Button_read_project.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label_PDF
        '
        Me.Label_PDF.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_PDF.AutoEllipsis = True
        Me.Label_PDF.Font = New System.Drawing.Font("David", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_PDF.Location = New System.Drawing.Point(34, 264)
        Me.Label_PDF.Name = "Label_PDF"
        Me.Label_PDF.Size = New System.Drawing.Size(732, 39)
        Me.Label_PDF.TabIndex = 2
        Me.Label_PDF.Text = "PDF reader is required in order to view the files"
        Me.Label_PDF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox_pdf_req
        '
        Me.PictureBox_pdf_req.Image = CType(resources.GetObject("PictureBox_pdf_req.Image"), System.Drawing.Image)
        Me.PictureBox_pdf_req.Location = New System.Drawing.Point(11, 269)
        Me.PictureBox_pdf_req.Name = "PictureBox_pdf_req"
        Me.PictureBox_pdf_req.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox_pdf_req.TabIndex = 0
        Me.PictureBox_pdf_req.TabStop = False
        '
        'MenuStrip
        '
        Me.MenuStrip.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSM_file, Me.TSM_Base_Functions, Me.TSM_Addons, Me.TSM_Model, Me.TSM_Language, Me.TSM_Help, Me.TSM_combo_prompt})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuStrip.Size = New System.Drawing.Size(1159, 32)
        Me.MenuStrip.TabIndex = 28
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'TSM_file
        '
        Me.TSM_file.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSM_exit})
        Me.TSM_file.Name = "TSM_file"
        Me.TSM_file.Size = New System.Drawing.Size(49, 28)
        Me.TSM_file.Text = "File"
        '
        'TSM_exit
        '
        Me.TSM_exit.Image = Global.SPE.My.Resources.Resources.menu_exit
        Me.TSM_exit.Name = "TSM_exit"
        Me.TSM_exit.Size = New System.Drawing.Size(121, 28)
        Me.TSM_exit.Text = "Exit"
        '
        'TSM_Base_Functions
        '
        Me.TSM_Base_Functions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSM_input, Me.TSM_DB, Me.TSM_FEA})
        Me.TSM_Base_Functions.Name = "TSM_Base_Functions"
        Me.TSM_Base_Functions.Size = New System.Drawing.Size(137, 28)
        Me.TSM_Base_Functions.Text = "Base Functions"
        '
        'TSM_input
        '
        Me.TSM_input.Name = "TSM_input"
        Me.TSM_input.Size = New System.Drawing.Size(372, 28)
        Me.TSM_input.Text = "Maximum Deflection Analysis"
        '
        'TSM_DB
        '
        Me.TSM_DB.Name = "TSM_DB"
        Me.TSM_DB.Size = New System.Drawing.Size(372, 28)
        Me.TSM_DB.Text = "Stiffeners Database"
        '
        'TSM_FEA
        '
        Me.TSM_FEA.Name = "TSM_FEA"
        Me.TSM_FEA.Size = New System.Drawing.Size(372, 28)
        Me.TSM_FEA.Text = "FEA results of performed simulations"
        Me.TSM_FEA.Visible = False
        '
        'TSM_Addons
        '
        Me.TSM_Addons.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSM_ADINA})
        Me.TSM_Addons.Name = "TSM_Addons"
        Me.TSM_Addons.Size = New System.Drawing.Size(89, 28)
        Me.TSM_Addons.Text = "Add-ons"
        '
        'TSM_ADINA
        '
        Me.TSM_ADINA.Image = Global.SPE.My.Resources.Resources.menu_adina
        Me.TSM_ADINA.Name = "TSM_ADINA"
        Me.TSM_ADINA.Size = New System.Drawing.Size(220, 28)
        Me.TSM_ADINA.Text = "Adina Generator"
        '
        'TSM_Model
        '
        Me.TSM_Model.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSM_Orthotropic, Me.TSM_Grillage})
        Me.TSM_Model.Name = "TSM_Model"
        Me.TSM_Model.Size = New System.Drawing.Size(146, 28)
        Me.TSM_Model.Text = "Model Selection"
        '
        'TSM_Orthotropic
        '
        Me.TSM_Orthotropic.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSM_Orthotropic_last, Me.TSM_Orthotropic_summary})
        Me.TSM_Orthotropic.Name = "TSM_Orthotropic"
        Me.TSM_Orthotropic.Size = New System.Drawing.Size(269, 28)
        Me.TSM_Orthotropic.Text = "Ortotropic Plate model"
        '
        'TSM_Orthotropic_last
        '
        Me.TSM_Orthotropic_last.Name = "TSM_Orthotropic_last"
        Me.TSM_Orthotropic_last.Size = New System.Drawing.Size(262, 28)
        Me.TSM_Orthotropic_last.Text = "View Last Results"
        '
        'TSM_Orthotropic_summary
        '
        Me.TSM_Orthotropic_summary.Name = "TSM_Orthotropic_summary"
        Me.TSM_Orthotropic_summary.Size = New System.Drawing.Size(262, 28)
        Me.TSM_Orthotropic_summary.Text = "Read Model Summary"
        Me.TSM_Orthotropic_summary.Visible = False
        '
        'TSM_Grillage
        '
        Me.TSM_Grillage.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSM_Grillage_last, Me.TSM_grillage_summary})
        Me.TSM_Grillage.Name = "TSM_Grillage"
        Me.TSM_Grillage.Size = New System.Drawing.Size(269, 28)
        Me.TSM_Grillage.Text = "Grillage model"
        '
        'TSM_Grillage_last
        '
        Me.TSM_Grillage_last.Name = "TSM_Grillage_last"
        Me.TSM_Grillage_last.Size = New System.Drawing.Size(262, 28)
        Me.TSM_Grillage_last.Text = "View Last Results"
        '
        'TSM_grillage_summary
        '
        Me.TSM_grillage_summary.Enabled = False
        Me.TSM_grillage_summary.Name = "TSM_grillage_summary"
        Me.TSM_grillage_summary.Size = New System.Drawing.Size(262, 28)
        Me.TSM_grillage_summary.Text = "Read Model Summary"
        Me.TSM_grillage_summary.Visible = False
        '
        'TSM_Language
        '
        Me.TSM_Language.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSM_hebrew, Me.TSM_english, Me.TSM_User_made, Me.TSM_separator02, Me.TSM_Remember_lang, Me.TSM_current_info})
        Me.TSM_Language.Name = "TSM_Language"
        Me.TSM_Language.Size = New System.Drawing.Size(99, 28)
        Me.TSM_Language.Text = "Language"
        '
        'TSM_hebrew
        '
        Me.TSM_hebrew.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TSM_hebrew.Image = Global.SPE.My.Resources.Resources.menu_hebrew
        Me.TSM_hebrew.Name = "TSM_hebrew"
        Me.TSM_hebrew.Size = New System.Drawing.Size(347, 28)
        Me.TSM_hebrew.Text = "עברית"
        '
        'TSM_english
        '
        Me.TSM_english.Image = Global.SPE.My.Resources.Resources.menu_english
        Me.TSM_english.Name = "TSM_english"
        Me.TSM_english.Size = New System.Drawing.Size(347, 28)
        Me.TSM_english.Text = "English"
        '
        'TSM_User_made
        '
        Me.TSM_User_made.Image = Global.SPE.My.Resources.Resources.question_mark
        Me.TSM_User_made.Name = "TSM_User_made"
        Me.TSM_User_made.Size = New System.Drawing.Size(347, 28)
        Me.TSM_User_made.Text = "User-made languages"
        '
        'TSM_separator02
        '
        Me.TSM_separator02.Name = "TSM_separator02"
        Me.TSM_separator02.Size = New System.Drawing.Size(344, 6)
        '
        'TSM_Remember_lang
        '
        Me.TSM_Remember_lang.Checked = True
        Me.TSM_Remember_lang.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TSM_Remember_lang.Name = "TSM_Remember_lang"
        Me.TSM_Remember_lang.Size = New System.Drawing.Size(347, 28)
        Me.TSM_Remember_lang.Text = "Remember language on next run"
        '
        'TSM_current_info
        '
        Me.TSM_current_info.Image = Global.SPE.My.Resources.Resources.menu_information01
        Me.TSM_current_info.Name = "TSM_current_info"
        Me.TSM_current_info.Size = New System.Drawing.Size(347, 28)
        Me.TSM_current_info.Text = "Current language information"
        '
        'TSM_Help
        '
        Me.TSM_Help.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSM_Version_History, Me.TSM_separator01, Me.TSM_About})
        Me.TSM_Help.Name = "TSM_Help"
        Me.TSM_Help.Size = New System.Drawing.Size(59, 28)
        Me.TSM_Help.Text = "Help"
        '
        'TSM_Version_History
        '
        Me.TSM_Version_History.Name = "TSM_Version_History"
        Me.TSM_Version_History.Size = New System.Drawing.Size(206, 28)
        Me.TSM_Version_History.Text = "Version history"
        '
        'TSM_separator01
        '
        Me.TSM_separator01.Name = "TSM_separator01"
        Me.TSM_separator01.Size = New System.Drawing.Size(203, 6)
        '
        'TSM_About
        '
        Me.TSM_About.Name = "TSM_About"
        Me.TSM_About.Size = New System.Drawing.Size(206, 28)
        Me.TSM_About.Text = "about"
        '
        'TSM_combo_prompt
        '
        Me.TSM_combo_prompt.Enabled = False
        Me.TSM_combo_prompt.Items.AddRange(New Object() {"gm_blade(1,2,10,3,1,1000,200,1,5,50)", "gm_blade(breadth,length,thickness,r,s,P,E,BC,w,h)", "?"})
        Me.TSM_combo_prompt.Name = "TSM_combo_prompt"
        Me.TSM_combo_prompt.Size = New System.Drawing.Size(270, 28)
        Me.TSM_combo_prompt.Text = "Currently disabled "
        Me.TSM_combo_prompt.Visible = False
        '
        'Button_model_grillage
        '
        Me.Button_model_grillage.Image = CType(resources.GetObject("Button_model_grillage.Image"), System.Drawing.Image)
        Me.Button_model_grillage.Location = New System.Drawing.Point(3, 136)
        Me.Button_model_grillage.Name = "Button_model_grillage"
        Me.Button_model_grillage.Size = New System.Drawing.Size(90, 90)
        Me.Button_model_grillage.TabIndex = 29
        '
        'GroupBox_current_model
        '
        Me.GroupBox_current_model.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_current_model.Controls.Add(Me.ComboBox_current_model)
        Me.GroupBox_current_model.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.GroupBox_current_model.Location = New System.Drawing.Point(4, 581)
        Me.GroupBox_current_model.Name = "GroupBox_current_model"
        Me.GroupBox_current_model.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox_current_model.Size = New System.Drawing.Size(444, 79)
        Me.GroupBox_current_model.TabIndex = 31
        Me.GroupBox_current_model.TabStop = False
        Me.GroupBox_current_model.Text = "Current model"
        '
        'ComboBox_current_model
        '
        Me.ComboBox_current_model.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_current_model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_current_model.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.ComboBox_current_model.FormattingEnabled = True
        Me.ComboBox_current_model.Location = New System.Drawing.Point(6, 35)
        Me.ComboBox_current_model.Name = "ComboBox_current_model"
        Me.ComboBox_current_model.Size = New System.Drawing.Size(426, 33)
        Me.ComboBox_current_model.TabIndex = 32
        '
        'Label_fast_results
        '
        Me.Label_fast_results.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_fast_results.AutoEllipsis = True
        Me.Label_fast_results.Location = New System.Drawing.Point(6, 26)
        Me.Label_fast_results.Name = "Label_fast_results"
        Me.Label_fast_results.Size = New System.Drawing.Size(670, 25)
        Me.Label_fast_results.TabIndex = 0
        '
        'GroupBox_fast_results
        '
        Me.GroupBox_fast_results.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_fast_results.Controls.Add(Me.Label_fast_results)
        Me.GroupBox_fast_results.Font = New System.Drawing.Font("David", 12.0!)
        Me.GroupBox_fast_results.Location = New System.Drawing.Point(6, 162)
        Me.GroupBox_fast_results.Name = "GroupBox_fast_results"
        Me.GroupBox_fast_results.Size = New System.Drawing.Size(682, 65)
        Me.GroupBox_fast_results.TabIndex = 35
        Me.GroupBox_fast_results.TabStop = False
        Me.GroupBox_fast_results.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'GroupBox_new
        '
        Me.GroupBox_new.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_new.Controls.Add(Me.PictureBox_MT)
        Me.GroupBox_new.Controls.Add(Me.RichTextBox_new)
        Me.GroupBox_new.Controls.Add(Me.PictureBox_new)
        Me.GroupBox_new.Controls.Add(Me.PictureBox_SAOS)
        Me.GroupBox_new.Controls.Add(Me.GroupBox_fast_results)
        Me.GroupBox_new.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_new.Location = New System.Drawing.Point(454, 484)
        Me.GroupBox_new.Name = "GroupBox_new"
        Me.GroupBox_new.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox_new.Size = New System.Drawing.Size(694, 233)
        Me.GroupBox_new.TabIndex = 36
        Me.GroupBox_new.TabStop = False
        Me.GroupBox_new.Text = "What's New"
        '
        'PictureBox_MT
        '
        Me.PictureBox_MT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox_MT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_MT.Image = Global.SPE.My.Resources.Resources.SNAME
        Me.PictureBox_MT.Location = New System.Drawing.Point(544, 12)
        Me.PictureBox_MT.Name = "PictureBox_MT"
        Me.PictureBox_MT.Size = New System.Drawing.Size(144, 144)
        Me.PictureBox_MT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox_MT.TabIndex = 39
        Me.PictureBox_MT.TabStop = False
        '
        'RichTextBox_new
        '
        Me.RichTextBox_new.BackColor = System.Drawing.Color.Cyan
        Me.RichTextBox_new.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RichTextBox_new.Location = New System.Drawing.Point(45, 28)
        Me.RichTextBox_new.Name = "RichTextBox_new"
        Me.RichTextBox_new.ReadOnly = True
        Me.RichTextBox_new.Size = New System.Drawing.Size(380, 128)
        Me.RichTextBox_new.TabIndex = 1
        Me.RichTextBox_new.Text = "Welcome to the new and improved Stiffened Plates Evaluator." & Global.Microsoft.VisualBasic.ChrW(10) & "This program was crea" &
    "ted in 2005." & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox_new
        '
        Me.PictureBox_new.Image = Global.SPE.My.Resources.Resources.Exclamation_bulb
        Me.PictureBox_new.Location = New System.Drawing.Point(6, 28)
        Me.PictureBox_new.Name = "PictureBox_new"
        Me.PictureBox_new.Size = New System.Drawing.Size(25, 35)
        Me.PictureBox_new.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox_new.TabIndex = 38
        Me.PictureBox_new.TabStop = False
        '
        'PictureBox_SAOS
        '
        Me.PictureBox_SAOS.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox_SAOS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_SAOS.Image = Global.SPE.My.Resources.Resources.SAOS_cover
        Me.PictureBox_SAOS.Location = New System.Drawing.Point(431, 28)
        Me.PictureBox_SAOS.Name = "PictureBox_SAOS"
        Me.PictureBox_SAOS.Size = New System.Drawing.Size(95, 125)
        Me.PictureBox_SAOS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox_SAOS.TabIndex = 37
        Me.PictureBox_SAOS.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsGithub, Me.tsKoFi, Me.tsPayPal})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 717)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1159, 29)
        Me.StatusStrip1.TabIndex = 37
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsGithub
        '
        Me.tsGithub.Image = Global.SPE.My.Resources.Resources.github16x16
        Me.tsGithub.Name = "tsGithub"
        Me.tsGithub.Size = New System.Drawing.Size(84, 23)
        Me.tsGithub.Text = "GitHub"
        '
        'tsKoFi
        '
        Me.tsKoFi.Image = Global.SPE.My.Resources.Resources.ko_fi_logo_blue_16x16
        Me.tsKoFi.Name = "tsKoFi"
        Me.tsKoFi.Size = New System.Drawing.Size(62, 23)
        Me.tsKoFi.Text = "KoFi"
        '
        'tsPayPal
        '
        Me.tsPayPal.Image = Global.SPE.My.Resources.Resources.paypal16
        Me.tsPayPal.Name = "tsPayPal"
        Me.tsPayPal.Size = New System.Drawing.Size(78, 23)
        Me.tsPayPal.Text = "PayPal"
        '
        'GUI_Launcher
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 18)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1159, 754)
        Me.Controls.Add(Me.GroupBox_new)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox_current_model)
        Me.Controls.Add(Me.Button_switch)
        Me.Controls.Add(Me.Picture_eng)
        Me.Controls.Add(Me.Picture_heb)
        Me.Controls.Add(Me.picture_TAU)
        Me.Controls.Add(Me.picture_navy_HQ_patch)
        Me.Controls.Add(Me.picture_navy_sign)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.RichTextBox_messages)
        Me.Controls.Add(Me.button_about)
        Me.Controls.Add(Me.Button_ADINA)
        Me.Controls.Add(Me.Button_model_orthotropic)
        Me.Controls.Add(Me.Button_model_grillage)
        Me.Controls.Add(Me.button_FEA_results)
        Me.Controls.Add(Me.button_input)
        Me.Controls.Add(Me.button_database)
        Me.Controls.Add(Me.GroupBox_model)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.MinimumSize = New System.Drawing.Size(965, 698)
        Me.Name = "GUI_Launcher"
        Me.Padding = New System.Windows.Forms.Padding(0, 0, 0, 8)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deflection Evaluator: Evaluate Maximum Deflection at Center of stiffened Plates/P" &
    "anels Due To Uniform Load"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picture_TAU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picture_navy_sign, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picture_navy_HQ_patch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture_heb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture_eng, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_model.ResumeLayout(False)
        CType(Me.PictureBox_pdf_get, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_pdf_req, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.GroupBox_current_model.ResumeLayout(False)
        Me.GroupBox_fast_results.ResumeLayout(False)
        Me.GroupBox_new.ResumeLayout(False)
        Me.GroupBox_new.PerformLayout()
        CType(Me.PictureBox_MT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_new, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_SAOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    'Dim Adina_form As adina_main
    Dim msgs() As String = {"",
                           ""}
    Dim local_language As String = ""
    Dim key As Microsoft.Win32.RegistryKey
    Dim GUI_input As New GUI_Input_Parameters
    Dim GUI_ADINA_Main As New Adina_Generator.GUI_ADINA_main
    Dim about As New GUI_about
    Dim history As New GUI_History
    Dim gui_FEA_results As New GUI_FEA_results
    Dim database As New GUI_Database
    Dim languages_selection As New GUI_languages_selection
    Dim last_result As New GUI_last_result
    '*********END ADDONS ***************
    Dim toolTip_buttons As New ToolTip
    Dim toolTip_pictures As New ToolTip
    Dim current_msg As Byte
    Function show_messages(ByVal num As Byte) As Boolean
        RichTextBox_messages.RightToLeft = language_settings.language_RTL
        RichTextBox_read_msg.RightToLeft = language_settings.language_RTL
        Select Case num
            Case 0
                GroupBox_model.Visible = False
                RichTextBox_messages.Visible = False
            Case 1
                GroupBox_model.Visible = False
                RichTextBox_messages.Visible = True
                RichTextBox_messages.Text = language_settings.launcher_msg1a + vbNewLine + language_settings.launcher_msg1b + vbNewLine + language_settings.launcher_msg1c + vbNewLine + language_settings.launcher_msg1d + vbNewLine + language_settings.launcher_msg1e + vbNewLine + language_settings.launcher_msg1f
            Case 2
                GroupBox_model.Visible = False
                RichTextBox_messages.Visible = True
                RichTextBox_messages.Text = language_settings.launcher_msg2a + vbNewLine + language_settings.launcher_msg2b + vbNewLine + language_settings.launcher_msg2c + vbNewLine + language_settings.launcher_msg2d + vbNewLine + language_settings.launcher_msg2e
            Case 3
                GroupBox_model.Visible = False
                RichTextBox_messages.Visible = True
                RichTextBox_messages.Text = language_settings.launcher_msg3a + vbNewLine + language_settings.launcher_msg3b + vbNewLine + language_settings.launcher_msg3c + vbNewLine + language_settings.launcher_msg3d + vbNewLine + language_settings.launcher_msg3e
            Case 4
                GroupBox_model.Visible = False
                RichTextBox_messages.Visible = True
                RichTextBox_messages.Text = language_settings.launcher_msg4a + vbNewLine + language_settings.launcher_msg4b + vbNewLine + language_settings.launcher_msg4c + vbNewLine + language_settings.launcher_msg4d + vbNewLine + language_settings.launcher_msg4e
            Case 5
                GroupBox_model.Visible = True
                RichTextBox_messages.Visible = False
                RichTextBox_read_msg.Text = language_settings.launcher_msg5a + vbNewLine + language_settings.launcher_msg5b + vbNewLine + language_settings.launcher_msg5c + vbNewLine + language_settings.launcher_msg5d + vbNewLine + language_settings.launcher_msg5e
        End Select
        Return True
    End Function
    Public Function GUI_set(ByVal new_lang As String) As Boolean
        If Me.Visible Then
            Me.SuspendLayout()
            language_settings.read_language(new_lang)
            show_messages(current_msg)
            Dim tooltip1 As String = language_settings.launcher_tt1a + vbNewLine + language_settings.launcher_tt1b + vbNewLine + language_settings.launcher_tt1c
            Dim tooltip2 As String = language_settings.launcher_tt2a + vbNewLine + language_settings.launcher_tt2b + vbNewLine + language_settings.launcher_tt2c
            Dim tooltip3 As String = language_settings.launcher_tt3a + vbNewLine + language_settings.launcher_tt3b + vbNewLine + language_settings.launcher_tt3c
            Dim tooltip4 As String = language_settings.launcher_tt4a + vbNewLine + language_settings.launcher_tt4b + vbNewLine + language_settings.launcher_tt4c
            toolTip_buttons.RemoveAll()
            toolTip_pictures.RemoveAll()
            toolTip_pictures.AutoPopDelay = 5000
            toolTip_pictures.InitialDelay = 100
            toolTip_pictures.ReshowDelay = 0
            toolTip_pictures.ShowAlways = True
            toolTip_buttons.AutoPopDelay = 5000
            toolTip_buttons.InitialDelay = 100
            toolTip_buttons.ReshowDelay = 0
            toolTip_buttons.ShowAlways = True
            toolTip_buttons.IsBalloon = True
            toolTip_buttons.UseAnimation = True
            toolTip_buttons.UseFading = True
            toolTip_pictures.SetToolTip(Me.PictureBox_pdf_get, "http://www.adobe.com/products/acrobat/readstep2.html")
            toolTip_buttons.SetToolTip(Me.button_input, tooltip1)
            toolTip_buttons.SetToolTip(Me.button_database, tooltip2)
            toolTip_buttons.SetToolTip(Me.button_FEA_results, tooltip3)
            toolTip_buttons.SetToolTip(Me.Button_ADINA, tooltip4)
            toolTip_buttons.SetToolTip(Me.Button_model_grillage, "The new GUI for the Grillage model")
            Me.RightToLeftLayout = language_settings.language_RTL_layout
            Me.RightToLeft = language_settings.language_RTL
            Me.Text = language_settings.launcher_text
            MenuStrip.RightToLeft = language_settings.language_RTL 'language_settings.language_RTL
            TSM_file.Text = language_settings.launcher_menu_file
            TSM_exit.Text = language_settings.launcher_menu_exit
            TSM_Base_Functions.Text = language_settings.launcher_menu_base_functions
            TSM_input.Text = language_settings.launcher_menu_input
            TSM_DB.Text = language_settings.launcher_menu_DB
            TSM_FEA.Text = language_settings.launcher_menu_FEA
            TSM_Addons.Text = language_settings.launcher_Menu_addons
            TSM_ADINA.Text = language_settings.launcher_Menu_adina
            TSM_Language.Text = language_settings.launcher_menu_language
            TSM_hebrew.Text = language_settings.launcher_menu_hebrew
            TSM_english.Text = language_settings.launcher_menu_english
            TSM_Remember_lang.Text = language_settings.launcher_menu_remember_lang
            TSM_current_info.Text = language_settings.launcher_menu_current_info
            TSM_User_made.Text = language_settings.launcher_Menu_user_made
            TSM_Help.Text = language_settings.launcher_menu_help
            TSM_Version_History.Text = language_settings.launcher_menu_history
            TSM_Model.Text = language_settings.launcher_Menu_model
            TSM_Orthotropic.Text = language_settings.launcher_Menu_ortho
            TSM_Orthotropic_summary.Text = language_settings.launcher_Menu_ortho_summary
            TSM_Orthotropic_last.Text = language_settings.launcher_Menu_ortho_last
            TSM_Grillage.Text = language_settings.launcher_Menu_grillage
            TSM_Grillage_last.Text = language_settings.launcher_Menu_grillage_last
            TSM_grillage_summary.Text = language_settings.launcher_Menu_grillage_summary
            TSM_About.Text = language_settings.launcher_menu_about
            button_about.Text = language_settings.launcher_button1
            Button_read_project.Text = language_settings.launcher_button2
            Button_read_journal.Text = language_settings.launcher_button3
            Label_PDF.Text = language_settings.launcher_Label_PDF
            Label_PDF.RightToLeft = language_settings.language_RTL
            ComboBox_current_model.Items.Clear()
            ComboBox_current_model.Items.Insert(0, language_settings.model_orthotropic)
            ComboBox_current_model.Items.Insert(1, language_settings.model_grillage)
            ComboBox_current_model.RightToLeft = language_settings.language_RTL
            GroupBox_current_model.RightToLeft = language_settings.language_RTL
            GroupBox_current_model.Text = language_settings.launcher_current_model + " " + general_settings.general_variables.current_model
            If general_settings.general_variables.current_model = "orthotropic plate model" Then
                GroupBox_current_model.Text = language_settings.launcher_current_model + " " + language_settings.model_orthotropic
            ElseIf general_settings.general_variables.current_model = "grillage model" Then
                GroupBox_current_model.Text = language_settings.launcher_current_model + " " + language_settings.model_grillage
            Else
                GroupBox_current_model.Text = "Erroneous results"
            End If
            TSM_combo_prompt.RightToLeft = Windows.Forms.RightToLeft.No
            GroupBox_new.RightToLeft = Windows.Forms.RightToLeft.No
            RichTextBox_new.RightToLeft = Windows.Forms.RightToLeft.No
            'RichTextBox_new.Text = "Welcome to the new and improved Stiffened Plates Evaluator"
            Me.ResumeLayout()
        End If
    End Function
    Private Sub GUI_Launcher_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If (local_language <> language_settings.language_current_file) AndAlso local_language <> "" Then
            GUI_set(language_settings.language_current_file)
            local_language = language_settings.language_current_file
        End If
    End Sub
    Private Sub GUI_Launcher_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        general_settings.save_settings_to_registry()
        While My.Application.OpenForms.Count > 1
            My.Application.OpenForms.Item(1).Close()
        End While
    End Sub
    Private Sub GUI_Launcher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'popup_initiator(My.Application.Info.Title.ToString, "Welcome to " & My.Application.Info.Title.ToString & "!")
    End Sub
    Private Sub GUI_Launcher_first_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        general_settings.load_settings_from_registry()
        local_language = language_settings.language_current_file
        general_settings.controls_Library.luncher_form = Me
        TSM_Remember_lang.Checked = language_settings.language_remember
        GUI_set(language_settings.language_current_file)
    End Sub
    Private Sub button_about_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_about.Click, TSM_About.Click
        If about.IsDisposed Then
            about = New GUI_about
        End If
        about.ShowDialog(Me)
    End Sub
    Private Sub input_button_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_input.MouseHover
        current_msg = 1
        show_messages(current_msg)
    End Sub
    Private Sub moment_of_inertia_button_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_database.MouseHover
        current_msg = 2
        show_messages(current_msg)
    End Sub
    Private Sub FEA_button_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_FEA_results.MouseHover
        current_msg = 3
        show_messages(current_msg)
    End Sub
    Private Sub FEA_button_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles button_FEA_results.MouseMove
        current_msg = 3
        show_messages(current_msg)
    End Sub
    Private Sub moment_of_inertia_button_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles button_database.MouseMove
        current_msg = 2
        show_messages(current_msg)

    End Sub
    Private Sub input_button_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles button_input.MouseMove
        current_msg = 1
        show_messages(current_msg)
    End Sub

    Private Sub Button_ADINA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_ADINA.Click
        If GUI_ADINA_Main.IsDisposed = True Then
            GUI_ADINA_Main = New Adina_Generator.GUI_ADINA_main
        End If
        GUI_ADINA_Main.model_ok = False
        GUI_ADINA_Main.Label_status.Visible = False
        GUI_ADINA_Main.Show()
    End Sub
    Private Sub Button_switch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_switch.Click
        If Me.Visible Then
            If button_input.Visible = True Then
                button_input.Visible = False
            Else
                button_input.Visible = True
            End If
            If button_database.Visible = True Then
                button_database.Visible = False
            Else
                button_database.Visible = True
            End If
            If button_FEA_results.Visible = True Then
                button_FEA_results.Visible = False
            Else
                button_FEA_results.Visible = True
            End If
            If button_about.Visible = True Then
                button_about.Visible = False
            Else
                button_about.Visible = True
            End If
            If Button_ADINA.Visible = True Then
                Button_ADINA.Visible = False
            Else
                Button_ADINA.Visible = True
            End If
            If Button_model_orthotropic.Visible = True Then
                Button_model_orthotropic.Visible = False
            Else
                Button_model_orthotropic.Visible = True
            End If
            If Button_model_grillage.Visible = True Then
                Button_model_grillage.Visible = False
            Else
                Button_model_grillage.Visible = True
            End If

        End If
    End Sub
    Private Sub Button_ADINA_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_ADINA.MouseHover
        current_msg = 4
        show_messages(current_msg)
    End Sub
    Private Sub Button_ADINA_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button_ADINA.MouseMove
        current_msg = 4
        show_messages(current_msg)
    End Sub
    Private Sub PictureBox_pdf_get_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox_pdf_get.Click
        System.Diagnostics.Process.Start("http://www.adobe.com/products/acrobat/readstep2.html")
    End Sub
    Private Sub Button_model_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_model_orthotropic.Click
        current_msg = 5
        show_messages(current_msg)
    End Sub
    Private Sub Button_model_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_model_orthotropic.MouseHover
        current_msg = 5
        show_messages(current_msg)
    End Sub
    Private Sub Button_model_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button_model_orthotropic.MouseMove
        current_msg = 5
        show_messages(current_msg)
    End Sub
    Private Sub Button_read_project_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_read_project.Click
        Dim msg As String = ""
        Dim title As String = ""
        Dim style As MsgBoxStyle
        Dim response As MsgBoxResult
        ' TO BE COMPLETE LATER
        If general_settings.controls_Library.current_lang = "hebrew" Then
            msg = "לידעתך, התמונות מסך של התוכנה בקובץ הפרויקט הינם של גירסה קודמת יותר"
            style = MsgBoxStyle.Information + MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading
        Else
            msg = "Please be advised that the screen captures of the program are outdated in the project file"
            style = MsgBoxStyle.Information + MsgBoxStyle.OkOnly
        End If
        MsgBox(msg, style, title)

        If File.Exists("papers/project.pdf") = True Then
            System.Diagnostics.Process.Start("papers/project.pdf")
        Else
            If general_settings.controls_Library.current_lang = "hebrew" Then
                msg = "לא ניתן לפתוח את הקובץ project.pdf" + Chr(13) + "נא לבדוק שהקובץ קיים בתיקיית papers ושהוא בעל השם project.pdf"
                style = MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading
                title = "הקובץ לא נמצא"
            Else
                msg = "Unable to open the file project.pdf" + Chr(13) + "Please check that the file exist in the papers folder and that it is named project.pdf"
                style = MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly
                title = "The file is missing"
            End If
            response = MsgBox(msg, style, title)
        End If
    End Sub
    Private Sub Button_read_journal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_read_journal.Click
        Dim msg As String = ""
        Dim title As String = ""
        Dim style As MsgBoxStyle
        Dim response As MsgBoxResult
        ' TO BE COMPLETE LATER
        If general_settings.controls_Library.current_lang = "hebrew" Then
            msg = "לידעתך, התמונות מסך של התוכנה בקובץ המאמר הינם של גירסה קודמת יותר"
            style = MsgBoxStyle.Information + MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading
        Else
            msg = "Please be advised that the screen captures of the program are outdated in the paper file"
            style = MsgBoxStyle.Information + MsgBoxStyle.OkOnly
        End If
        MsgBox(msg, style, title)

        If File.Exists("papers/SAOS paper.pdf") = True Then
            System.Diagnostics.Process.Start("papers/SAOS paper.pdf")
        Else
            If general_settings.controls_Library.current_lang = "hebrew" Then
                msg = "לא ניתן לפתוח את הקובץ paper.pdf" + Chr(13) + "נא לבדוק שהקובץ קיים בתיקיית papers ושהוא בעל השם paper.pdf"
                style = MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading
                title = "הקובץ לא נמצא"
            Else
                msg = "Unable to open the file paper.pdf" + Chr(13) + "Please check that the file exist in the papers folder and that it is named paper.pdf"
                style = MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly
                title = "The file is missing"
            End If
            response = MsgBox(msg, style, title)
        End If
    End Sub
    Private Sub TSM_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSM_exit.Click
        Me.Close()
    End Sub
    Private Sub TSM_input_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSM_input.Click, button_input.Click
        If GUI_input.IsDisposed = True Then
            GUI_input = New GUI_Input_Parameters
        End If
        GUI_input.Show()
    End Sub
    Private Sub TSM_DB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSM_DB.Click, button_database.Click
        If database.IsDisposed = True Then
            database = New GUI_Database
        End If
        database.Show()
    End Sub
    Private Sub TSM_FEA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSM_FEA.Click, button_FEA_results.Click
        If gui_FEA_results.IsDisposed = True Then
            gui_FEA_results = New GUI_FEA_results
        End If
        gui_FEA_results.Show()
    End Sub
    Private Sub TSM_ADINA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSM_ADINA.Click
        If GUI_ADINA_Main.IsDisposed = True Then
            GUI_ADINA_Main = New Adina_Generator.GUI_ADINA_main
        End If
        GUI_ADINA_Main.model_ok = False
        GUI_ADINA_Main.Label_status.Visible = False
        GUI_ADINA_Main.Show()
    End Sub
    Private Sub TSM_Ortotropic_last_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSM_Orthotropic_last.Click
        If last_result.IsDisposed = True Then
            last_result = New GUI_last_result
        End If
        last_result.Tag = "orthotropic plate model"
        last_result.Show()
        last_result.GUI_last_result_Load(sender, e)
        last_result.Focus()
    End Sub
    Private Sub TSM_Grillage_last_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSM_Grillage_last.Click
        If last_result.IsDisposed = True Then
            last_result = New GUI_last_result
        End If
        last_result.Tag = "grillage model"
        last_result.Show()
        last_result.GUI_last_result_Load(sender, e)
        last_result.Focus()
    End Sub
    Private Sub TSM_ortho_summary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSM_Orthotropic_summary.Click
        Dim msg As String = ""
        Dim title As String = ""
        Dim style As MsgBoxStyle
        Dim response As MsgBoxResult
        If general_settings.controls_Library.current_lang = "hebrew" Then
            msg = "לידעתך, התמונות מסך של התוכנה בקובץ המאמר הינם של גירסה קודמת יותר"
            style = MsgBoxStyle.Information + MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading
        Else
            msg = "Please be advised that the screen captures of the program are outdated in the paper file"
            style = MsgBoxStyle.Information + MsgBoxStyle.OkOnly
        End If
        MsgBox(msg, style, title)

        If File.Exists("papers/SAOS paper.pdf") = True Then
            System.Diagnostics.Process.Start("papers/SAOS paper.pdf")
        Else
            If general_settings.controls_Library.current_lang = "hebrew" Then
                msg = "לא ניתן לפתוח את הקובץ paper.pdf" + Chr(13) + "נא לבדוק שהקובץ קיים בתיקיית papers ושהוא בעל השם paper.pdf"
                style = MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading
                title = "הקובץ לא נמצא"
            Else
                msg = "Unable to open the file paper.pdf" + Chr(13) + "Please check that the file exist in the papers folder and that it is named paper.pdf"
                style = MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly
                title = "The file is missing"
            End If
            response = MsgBox(msg, style, title)
        End If
    End Sub
    Private Sub TSM_hebrew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSM_hebrew.Click, Picture_heb.Click
        TSM_hebrew.Enabled = True
        GUI_set("default_heb.ini")
        language_settings.language_current_file = "default_heb.ini"
        local_language = "default_heb.ini"
        language_settings.language_remember = TSM_Remember_lang.Checked
        general_settings.save_settings_to_registry()
    End Sub
    Private Sub TSM_english_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSM_english.Click, Picture_eng.Click
        If File.Exists("default_eng.ini") = True Then
            TSM_english.Enabled = True
            GUI_set("default_eng.ini")
            language_settings.language_current_file = "default_eng.ini"
            local_language = "default_eng.ini"
        Else
            TSM_english.Enabled = False
            'message to follow
        End If
        language_settings.language_remember = TSM_Remember_lang.Checked
        general_settings.save_settings_to_registry()
    End Sub
    Private Sub TSM_Remember_lang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSM_Remember_lang.Click
        If TSM_Remember_lang.Checked = True Then
            TSM_Remember_lang.Checked = False
        Else
            TSM_Remember_lang.Checked = True
        End If
        language_settings.language_remember = TSM_Remember_lang.Checked
        general_settings.save_settings_to_registry()
    End Sub
    Private Sub TSM_current_info_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSM_current_info.Click
        general_settings.messages.read_msg(27)
        general_settings.messages.msg_res = MsgBox(general_settings.messages.msg_text, general_settings.messages.msg_style, general_settings.messages.msg_title)
    End Sub
    Private Sub TSM_User_made_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSM_User_made.Click
        If languages_selection.IsDisposed Then
            languages_selection = New GUI_languages_selection
        End If
        languages_selection.Show()
        general_settings.controls_Library.GUI_Launcher = Me
    End Sub
    Private Sub TSM_Version_History_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSM_Version_History.Click
        If history.IsDisposed Then
            history = New GUI_History
        End If
        history.ShowDialog()
    End Sub
    Private Sub Button_DOI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_DOI.Click
        System.Diagnostics.Process.Start("http://dx.doi.org/10.1533/saos.2005.0135")
    End Sub
    Private Sub ComboBox_current_model_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_current_model.SelectedIndexChanged
        If ComboBox_current_model.Text = language_settings.model_orthotropic Then
            general_settings.general_variables.current_model = "orthotropic plate model"
            GroupBox_current_model.Text = language_settings.launcher_current_model + " " + language_settings.model_orthotropic
        ElseIf ComboBox_current_model.Text = language_settings.model_grillage Then
            general_settings.general_variables.current_model = "grillage model"
            GroupBox_current_model.Text = language_settings.launcher_current_model + " " + language_settings.model_grillage
        End If
    End Sub
    Private Function TSM_combo_prompt_check_input(ByVal text As String) As Single
        Dim found As Integer = 0
        Dim count As Byte = 0
        Dim pos1, pos2 As Byte
        Dim cmd As String = ""
        Dim temp As String = ""
        Dim parameters As String = ""
        Dim array_par(10) As String
        Dim a As Single = 0 ' length of R stiffeners
        Dim b As Single = 0 ' length of S stiffeners
        Dim t As Single = 0 ' Thickness of plate/panel
        Dim r As Single = 0 ' number of R stiffeners
        Dim s As Single = 0 ' number of S stiffeners
        Dim P As Single = 0
        Dim BC As Byte = 0 ' type of boundary condition
        Dim E As Double = 0
        Dim h As Double = 0
        Dim w As Double = 0
        Dim I_stiffeners As Single = 0
        Dim A_stiffeners As Single = 0
        Dim Y_stiffeners As Single = 0

        found = text.IndexOf("(")
        If found > 0 Then
            cmd = text.Substring(0, found).Trim()
            parameters = text.Substring(found + 1).Trim()
            temp = parameters
            If cmd = "gm_blade" Then
                For count = 1 To 9
                    pos1 = temp.IndexOf(",")
                    array_par(count) = temp.Substring(0, pos1).Trim
                    pos2 = pos1 + 1 + temp.Substring(pos1 + 1).Trim().IndexOf(",")
                    If pos2 > 2 Then
                        array_par(count + 1) = temp.Substring(pos1 + 1, pos2 - pos1 - 1).Trim()
                        temp = temp.Substring(pos2 + 1).Trim
                    Else
                        array_par(count + 1) = temp.Substring(pos1 + 1, temp.IndexOf(")") - pos1 - 1).Trim()
                    End If
                    count += 1
                Next count
                Try
                    a = CSng(array_par(1))
                    b = CSng(array_par(2))
                    t = CSng(array_par(3)) / 1000
                    r = CSng(array_par(4))
                    s = CSng(array_par(5))
                    P = CSng(array_par(6))
                    E = CSng(array_par(7)) * 10 ^ 9
                    BC = CSng(array_par(8))
                    w = CSng(array_par(9))
                    h = CSng(array_par(10))
                Catch ex As Exception
                    MessageBox.Show("Not a number", "Error")
                End Try
                A_stiffeners = h * w
                Y_stiffeners = h / 2
                If general_functions.check_data(h) = True And general_functions.check_data(w) = True Then
                    I_stiffeners = models_calculations.general_functions.moment_of_inertia(w, h, 0, 0, "|")
                End If
                A_stiffeners = A_stiffeners * 10 ^ -6
                Y_stiffeners = Y_stiffeners * 10 ^ -3
                Return (models_calculations.Grillage_model.model_functions.main_function(a, b, t, r, s, I_stiffeners, I_stiffeners, A_stiffeners, A_stiffeners, Y_stiffeners, Y_stiffeners, BC, E, 0.3, P) * 1000)
            Else
            End If
        ElseIf cmd = "" Then
            If text = "?" Then
                'Dim str As String = "The format is as follow: " + Chr(13) + Chr(13) + ""
                'MessageBox.Show(str)
            End If
        End If
    End Function
    Private Sub TSM_combo_prompt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TSM_combo_prompt.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Label_fast_results.Text = CStr(TSM_combo_prompt_check_input(TSM_combo_prompt.Text)) & " [mm]"
            GroupBox_fast_results.Show()
            My.Computer.Clipboard.SetText(Math.Round(CDbl(Label_fast_results.Text.Substring(0, Label_fast_results.Text.Length - 4)), 4))
        End If
    End Sub
    'Private Sub popup_initiator(ByVal str_title As String, ByVal str_text As String)
    '    'PopupNotifier1.Dispose()
    '    'models_calculations.Orthotropic_model()
    '    Dim PN1 As New PopupNotifier
    '    'Dim ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    '    'Dim ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    '    'Dim ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    '    PN1.BodyColor = System.Drawing.Color.Gray 'System.Drawing.Color.FromArgb(CInt(Int((255 * Rnd()) + 1)), CInt(Int((255 * Rnd()) + 1)), CInt(Int((255 * Rnd()) + 1)), CInt(Int((255 * Rnd()) + 1)))
    '    PN1.BorderColor = System.Drawing.Color.Navy
    '    PN1.ButtonHoverColor = System.Drawing.Color.Orange
    '    PN1.ContentColor = System.Drawing.Color.White
    '    PN1.ContentFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    '    Dim st As String = "Welcome to the new and improved" & vbCr & "Stiffened Plates Evaluator" '"Welcome to Stiffened Plates Evaluator 1.8" & vbCrLf & "(formerly Deflection Evaluator)"
    '    PN1.ContentText = st
    '    PN1.HeaderColor = System.Drawing.Color.Navy
    '    PN1.Image = CType(My.Resources.SPE01_small, System.Drawing.Image)
    '    PN1.ImagePosition = New System.Drawing.Point(12, 21)
    '    PN1.ImageSize = New System.Drawing.Size(48, 48)
    '    PN1.LinkHoverColor = System.Drawing.Color.Black
    '    'PN1.OptionsMenu = ContextMenuStrip1
    '    PN1.Size = New System.Drawing.Size(400, 100)
    '    PN1.TextPadding = New System.Windows.Forms.Padding(5)
    '    PN1.TitleColor = System.Drawing.Color.White
    '    PN1.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    '    PN1.TitleText = str_title & " " & System.String.Format("{0}.{1}", My.Application.Info.Version.Major, My.Application.Info.Version.Minor)
    '    PN1.tmWait.Interval = 5000
    '    'PN1.Popup()
    'End Sub



    Private Sub TSM_combo_prompt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSM_combo_prompt.Click

    End Sub


    Private Sub PictureBox_SAOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox_SAOS.Click
        Try
            System.Diagnostics.Process.Start("http://dx.doi.org/10.1533/saos.2005.0135")
        Catch ex As Exception
            MessageBox.Show("Unable to open the link that was clicked.")
        End Try
    End Sub

    Private Sub Button_model_grillage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_model_grillage.Click
        Dim grillage As New GUI_grillage_model
        grillage.Show()
    End Sub

    Private Sub Button_model_grillage_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_model_grillage.MouseHover
        RichTextBox_messages.Text = "This is the new GUI for the Grillage model ONLY." & vbCr & vbCr & "The GUI is currently incomplete but is usable"
        RichTextBox_messages.RightToLeft = Windows.Forms.RightToLeft.No
    End Sub

    Private Sub Button_model_grillage_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button_model_grillage.MouseMove
        RichTextBox_messages.Text = "This is the new GUI for the Grillage model ONLY." & vbCr & vbCr & "The GUI is currently incomplete but is usable"
        RichTextBox_messages.RightToLeft = Windows.Forms.RightToLeft.No
    End Sub

    Private Sub tsPayPal_Click(sender As Object, e As EventArgs) Handles tsPayPal.Click
        Try
            System.Diagnostics.Process.Start("https://www.paypal.com/donate/?business=MCP57TBRAAVXA&no_recurring=0&item_name=Support+Open+source+Projects+%28Analogy+Log+Viewer%2C+HDF5-CSHARP%2C+etc%29&currency_code=USD")
        Catch ex As Exception
            MessageBox.Show("Unable to open link that was clicked.")
        End Try
    End Sub

    Private Sub tsKoFi_Click(sender As Object, e As EventArgs) Handles tsKoFi.Click
        Try
            System.Diagnostics.Process.Start("https://ko-fi.com/liorbanai")
        Catch ex As Exception
            MessageBox.Show("Unable to open link that was clicked.")
        End Try
    End Sub

    Private Sub tsGithub_Click(sender As Object, e As EventArgs) Handles tsGithub.Click
        Try
            System.Diagnostics.Process.Start("https://github.com/LiorBanai/SPE")
        Catch ex As Exception
            MessageBox.Show("Unable to open link that was clicked.")
        End Try
    End Sub

    Private Sub PictureBox_MT_Click(sender As Object, e As EventArgs) Handles PictureBox_MT.Click
        Try
            System.Diagnostics.Process.Start("https://doi.org/10.5957/mt1.2007.44.4.212")
        Catch ex As Exception
            MessageBox.Show("Unable to open link that was clicked.")
        End Try
    End Sub
End Class



