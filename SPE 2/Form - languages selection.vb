Imports System
Imports System.IO
Public Class GUI_languages_selection
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
    Friend WithEvents Button_finish As System.Windows.Forms.Button
    Friend WithEvents Label_lang_ver As System.Windows.Forms.Label
    Friend WithEvents Label_lang_menuname As System.Windows.Forms.Label
    Friend WithEvents Label_lang_RTL As System.Windows.Forms.Label
    Friend WithEvents Label_lang_info As System.Windows.Forms.Label
    Friend WithEvents Label_available As System.Windows.Forms.Label
    Public WithEvents ListBox_files As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox_lang2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label_lang_comment3 As System.Windows.Forms.Label
    Friend WithEvents Label_lang_comment2 As System.Windows.Forms.Label
    Friend WithEvents Label_lang_comment4 As System.Windows.Forms.Label
    Friend WithEvents Label_lang_comment1 As System.Windows.Forms.Label
    Friend WithEvents ImageList_model As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox_lang_check As System.Windows.Forms.GroupBox
    Friend WithEvents Label_counter_of_lines As System.Windows.Forms.Label
    Friend WithEvents Label_missing As System.Windows.Forms.Label
    Friend WithEvents Label_status As System.Windows.Forms.Label
    Friend WithEvents GroupBox_lang1 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI_languages_selection))
        Me.Button_finish = New System.Windows.Forms.Button
        Me.GroupBox_lang1 = New System.Windows.Forms.GroupBox
        Me.Label_lang_ver = New System.Windows.Forms.Label
        Me.Label_lang_menuname = New System.Windows.Forms.Label
        Me.Label_lang_RTL = New System.Windows.Forms.Label
        Me.Label_lang_info = New System.Windows.Forms.Label
        Me.Label_available = New System.Windows.Forms.Label
        Me.ListBox_files = New System.Windows.Forms.ListBox
        Me.GroupBox_lang2 = New System.Windows.Forms.GroupBox
        Me.Label_lang_comment3 = New System.Windows.Forms.Label
        Me.Label_lang_comment2 = New System.Windows.Forms.Label
        Me.Label_lang_comment4 = New System.Windows.Forms.Label
        Me.Label_lang_comment1 = New System.Windows.Forms.Label
        Me.ImageList_model = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox_lang_check = New System.Windows.Forms.GroupBox
        Me.Label_status = New System.Windows.Forms.Label
        Me.Label_missing = New System.Windows.Forms.Label
        Me.Label_counter_of_lines = New System.Windows.Forms.Label
        Me.GroupBox_lang1.SuspendLayout()
        Me.GroupBox_lang2.SuspendLayout()
        Me.GroupBox_lang_check.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_finish
        '
        Me.Button_finish.Location = New System.Drawing.Point(361, 327)
        Me.Button_finish.MinimumSize = New System.Drawing.Size(100, 36)
        Me.Button_finish.Name = "Button_finish"
        Me.Button_finish.Size = New System.Drawing.Size(100, 36)
        Me.Button_finish.TabIndex = 4
        Me.Button_finish.Text = "OK"
        '
        'GroupBox_lang1
        '
        Me.GroupBox_lang1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox_lang1.Controls.Add(Me.Label_lang_ver)
        Me.GroupBox_lang1.Controls.Add(Me.Label_lang_menuname)
        Me.GroupBox_lang1.Controls.Add(Me.Label_lang_RTL)
        Me.GroupBox_lang1.Controls.Add(Me.Label_lang_info)
        Me.GroupBox_lang1.Location = New System.Drawing.Point(238, 4)
        Me.GroupBox_lang1.Name = "GroupBox_lang1"
        Me.GroupBox_lang1.Size = New System.Drawing.Size(277, 128)
        Me.GroupBox_lang1.TabIndex = 9
        Me.GroupBox_lang1.TabStop = False
        Me.GroupBox_lang1.Text = "Language Info"
        '
        'Label_lang_ver
        '
        Me.Label_lang_ver.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_lang_ver.AutoEllipsis = True
        Me.Label_lang_ver.BackColor = System.Drawing.Color.Yellow
        Me.Label_lang_ver.Location = New System.Drawing.Point(6, 75)
        Me.Label_lang_ver.Name = "Label_lang_ver"
        Me.Label_lang_ver.Size = New System.Drawing.Size(265, 17)
        Me.Label_lang_ver.TabIndex = 7
        Me.Label_lang_ver.Text = "Language version: N/A"
        '
        'Label_lang_menuname
        '
        Me.Label_lang_menuname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_lang_menuname.AutoEllipsis = True
        Me.Label_lang_menuname.BackColor = System.Drawing.Color.Yellow
        Me.Label_lang_menuname.Location = New System.Drawing.Point(6, 49)
        Me.Label_lang_menuname.Name = "Label_lang_menuname"
        Me.Label_lang_menuname.Size = New System.Drawing.Size(265, 17)
        Me.Label_lang_menuname.TabIndex = 6
        Me.Label_lang_menuname.Text = "main menu name: N/A"
        '
        'Label_lang_RTL
        '
        Me.Label_lang_RTL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_lang_RTL.AutoEllipsis = True
        Me.Label_lang_RTL.BackColor = System.Drawing.Color.Yellow
        Me.Label_lang_RTL.Location = New System.Drawing.Point(6, 99)
        Me.Label_lang_RTL.Name = "Label_lang_RTL"
        Me.Label_lang_RTL.Size = New System.Drawing.Size(265, 17)
        Me.Label_lang_RTL.TabIndex = 5
        Me.Label_lang_RTL.Text = "Right to left: N/A"
        '
        'Label_lang_info
        '
        Me.Label_lang_info.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_lang_info.AutoEllipsis = True
        Me.Label_lang_info.BackColor = System.Drawing.Color.Yellow
        Me.Label_lang_info.Location = New System.Drawing.Point(6, 24)
        Me.Label_lang_info.Name = "Label_lang_info"
        Me.Label_lang_info.Size = New System.Drawing.Size(265, 17)
        Me.Label_lang_info.TabIndex = 4
        Me.Label_lang_info.Text = "Name: N/A"
        '
        'Label_available
        '
        Me.Label_available.AutoEllipsis = True
        Me.Label_available.Font = New System.Drawing.Font("David Transparent", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_available.Location = New System.Drawing.Point(12, 4)
        Me.Label_available.Name = "Label_available"
        Me.Label_available.Size = New System.Drawing.Size(205, 25)
        Me.Label_available.TabIndex = 11
        Me.Label_available.Text = "availables languages:"
        '
        'ListBox_files
        '
        Me.ListBox_files.FormattingEnabled = True
        Me.ListBox_files.ItemHeight = 16
        Me.ListBox_files.Location = New System.Drawing.Point(12, 32)
        Me.ListBox_files.Name = "ListBox_files"
        Me.ListBox_files.Size = New System.Drawing.Size(205, 100)
        Me.ListBox_files.TabIndex = 10
        '
        'GroupBox_lang2
        '
        Me.GroupBox_lang2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox_lang2.Controls.Add(Me.Label_lang_comment3)
        Me.GroupBox_lang2.Controls.Add(Me.Label_lang_comment2)
        Me.GroupBox_lang2.Controls.Add(Me.Label_lang_comment4)
        Me.GroupBox_lang2.Controls.Add(Me.Label_lang_comment1)
        Me.GroupBox_lang2.Location = New System.Drawing.Point(521, 4)
        Me.GroupBox_lang2.Name = "GroupBox_lang2"
        Me.GroupBox_lang2.Size = New System.Drawing.Size(277, 128)
        Me.GroupBox_lang2.TabIndex = 13
        Me.GroupBox_lang2.TabStop = False
        Me.GroupBox_lang2.Text = "Additional Info"
        '
        'Label_lang_comment3
        '
        Me.Label_lang_comment3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_lang_comment3.AutoEllipsis = True
        Me.Label_lang_comment3.BackColor = System.Drawing.Color.Yellow
        Me.Label_lang_comment3.Location = New System.Drawing.Point(6, 75)
        Me.Label_lang_comment3.Name = "Label_lang_comment3"
        Me.Label_lang_comment3.Size = New System.Drawing.Size(265, 17)
        Me.Label_lang_comment3.TabIndex = 7
        Me.Label_lang_comment3.Text = "comment3"
        '
        'Label_lang_comment2
        '
        Me.Label_lang_comment2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_lang_comment2.AutoEllipsis = True
        Me.Label_lang_comment2.BackColor = System.Drawing.Color.Yellow
        Me.Label_lang_comment2.Location = New System.Drawing.Point(6, 49)
        Me.Label_lang_comment2.Name = "Label_lang_comment2"
        Me.Label_lang_comment2.Size = New System.Drawing.Size(265, 17)
        Me.Label_lang_comment2.TabIndex = 6
        Me.Label_lang_comment2.Text = "comment2"
        '
        'Label_lang_comment4
        '
        Me.Label_lang_comment4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_lang_comment4.AutoEllipsis = True
        Me.Label_lang_comment4.BackColor = System.Drawing.Color.Yellow
        Me.Label_lang_comment4.Location = New System.Drawing.Point(6, 99)
        Me.Label_lang_comment4.Name = "Label_lang_comment4"
        Me.Label_lang_comment4.Size = New System.Drawing.Size(265, 17)
        Me.Label_lang_comment4.TabIndex = 5
        Me.Label_lang_comment4.Text = "comment4"
        '
        'Label_lang_comment1
        '
        Me.Label_lang_comment1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_lang_comment1.AutoEllipsis = True
        Me.Label_lang_comment1.BackColor = System.Drawing.Color.Yellow
        Me.Label_lang_comment1.Location = New System.Drawing.Point(6, 24)
        Me.Label_lang_comment1.Name = "Label_lang_comment1"
        Me.Label_lang_comment1.Size = New System.Drawing.Size(265, 17)
        Me.Label_lang_comment1.TabIndex = 4
        Me.Label_lang_comment1.Text = "comment1"
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
        'GroupBox_lang_check
        '
        Me.GroupBox_lang_check.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox_lang_check.Controls.Add(Me.Label_status)
        Me.GroupBox_lang_check.Controls.Add(Me.Label_missing)
        Me.GroupBox_lang_check.Controls.Add(Me.Label_counter_of_lines)
        Me.GroupBox_lang_check.Location = New System.Drawing.Point(16, 165)
        Me.GroupBox_lang_check.Name = "GroupBox_lang_check"
        Me.GroupBox_lang_check.Size = New System.Drawing.Size(782, 147)
        Me.GroupBox_lang_check.TabIndex = 14
        Me.GroupBox_lang_check.TabStop = False
        Me.GroupBox_lang_check.Text = "File Status"
        '
        'Label_status
        '
        Me.Label_status.AutoEllipsis = True
        Me.Label_status.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_status.Location = New System.Drawing.Point(6, 72)
        Me.Label_status.Name = "Label_status"
        Me.Label_status.Size = New System.Drawing.Size(770, 55)
        Me.Label_status.TabIndex = 2
        Me.Label_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_missing
        '
        Me.Label_missing.AutoEllipsis = True
        Me.Label_missing.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_missing.Location = New System.Drawing.Point(6, 44)
        Me.Label_missing.Name = "Label_missing"
        Me.Label_missing.Size = New System.Drawing.Size(770, 24)
        Me.Label_missing.TabIndex = 1
        Me.Label_missing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_counter_of_lines
        '
        Me.Label_counter_of_lines.AutoEllipsis = True
        Me.Label_counter_of_lines.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_counter_of_lines.Location = New System.Drawing.Point(6, 18)
        Me.Label_counter_of_lines.Name = "Label_counter_of_lines"
        Me.Label_counter_of_lines.Size = New System.Drawing.Size(770, 24)
        Me.Label_counter_of_lines.TabIndex = 0
        Me.Label_counter_of_lines.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GUI_languages_selection
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(822, 375)
        Me.Controls.Add(Me.GroupBox_lang_check)
        Me.Controls.Add(Me.GroupBox_lang2)
        Me.Controls.Add(Me.Label_available)
        Me.Controls.Add(Me.ListBox_files)
        Me.Controls.Add(Me.GroupBox_lang1)
        Me.Controls.Add(Me.Button_finish)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GUI_languages_selection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Languages Selection"
        Me.GroupBox_lang1.ResumeLayout(False)
        Me.GroupBox_lang2.ResumeLayout(False)
        Me.GroupBox_lang_check.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim counter As Integer
    Dim missing As Integer
    Dim total_lines As UShort = 545
    Private Sub Button_finish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_finish.Click
        '*****************end saving language***************************
        '*****************Loading launcher***************************
        'general_settings.controls_Library.luncher_form.Visible = True
        If Not ListBox_files.SelectedItem = Nothing Then
            language_settings.language_current_file = ListBox_files.SelectedItem
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Stiffened Plates Evaluator", "Current file", language_settings.language_current_file)
            If Not (general_settings.controls_Library.GUI_Launcher Is Nothing) Then
                general_settings.controls_Library.GUI_Launcher.Activate()
            Else
                Dim GUI_Launcher As New GUI_Launcher
                GUI_Launcher.Show()
            End If
            Me.Close()
        Else
        End If
    End Sub
    Private Sub form_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        '*****************end saving language***************************
        '*****************Loading launcher***************************
        'general_settings.controls_Library.luncher_form.Visible = True
    End Sub
    Private Sub form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If File.Exists("default_eng.ini") = False Then
            File.WriteAllText("default_eng.ini", My.Resources.default_eng)
        End If
        If File.Exists("default_heb.ini") = False Then
            File.WriteAllText("default_heb.ini", My.Resources.default_heb)
        End If

        Dim di As New DirectoryInfo(Environment.CurrentDirectory)
        Dim fi As FileInfo() = di.GetFiles()
        Dim fiTemp As FileInfo
        For Each fiTemp In fi
            If fiTemp.Extension = ".ini" And Not (fiTemp.Name = "config.ini") Then
                ListBox_files.Items.Add(fiTemp.Name)
            End If
        Next fiTemp
    End Sub
    Function read_language(ByVal f As String) As String
        Dim found As Integer = 0
        Dim current_line As String = ""
        Dim current_key As String = ""
        Dim current_line_number As UShort = 1
        Using sr As StreamReader = New StreamReader(f, System.Text.Encoding.Default)
            'current_line = language_settings.read_line_from_file(sr, 1)
            current_line = sr.ReadLine()
            While Not (current_line Is Nothing) 'there is text
                found = current_line.IndexOf("=")
                If (found > 0) Then
                    current_key = current_line.Substring(0, found).Trim() 'name
                    Select Case current_key
                        Case "name"
                            Label_lang_info.Text = "Name: " & (current_line.Substring((found + 1)).Trim())
                        Case "ver"
                            Label_lang_ver.Text = "Language version: " & (current_line.Substring((found + 1)).Trim())
                        Case "menuname"
                            Label_lang_menuname.Text = "main menu name: " & (current_line.Substring((found + 1)).Trim())
                        Case "RTL"
                            Label_lang_RTL.Text = "Right to left: " & (current_line.Substring((found + 1)).Trim())
                            If current_line.Substring((found + 1)).Trim() = "true" Or current_line.Substring((found + 1)).Trim() = "True" Then
                                GroupBox_lang1.RightToLeft = Windows.Forms.RightToLeft.Yes
                                GroupBox_lang2.RightToLeft = Windows.Forms.RightToLeft.Yes
                                Me.RightToLeftLayout = True
                                Me.RightToLeft = Windows.Forms.RightToLeft.No
                            Else
                                GroupBox_lang1.RightToLeft = Windows.Forms.RightToLeft.No
                                GroupBox_lang2.RightToLeft = Windows.Forms.RightToLeft.No
                                Me.RightToLeftLayout = False
                                Me.RightToLeft = Windows.Forms.RightToLeft.No
                            End If
                            GroupBox_lang1.RightToLeft = Windows.Forms.RightToLeft.No
                        Case "comment1"
                            Label_lang_comment1.Text = "" & (current_line.Substring((found + 1)).Trim())
                        Case "comment2"
                            Label_lang_comment2.Text = "" & (current_line.Substring((found + 1)).Trim())
                        Case "comment3"
                            Label_lang_comment3.Text = "" & (current_line.Substring((found + 1)).Trim())
                        Case "comment4"
                            Label_lang_comment4.Text = "" & (current_line.Substring((found + 1)).Trim())
                    End Select
                End If
                'current_line = language_settings.read_line_from_file(sr, 1)
                current_line = sr.ReadLine()
                current_line_number += 1
            End While
            sr.Close()
        End Using
    End Function
    Private Sub ListBox_files_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox_files.SelectedIndexChanged
        Label_lang_info.Text = "Name: N/A"
        Label_lang_menuname.Text = "main menu name: N/A"
        Label_lang_RTL.Text = "Right to left: N/A"
        Label_lang_ver.Text = "Language version: N/A"
        Label_lang_comment1.Text = "comment1"
        Label_lang_comment2.Text = "comment2"
        Label_lang_comment3.Text = "comment3"
        Label_lang_comment4.Text = "comment4"
        counter = language_settings.check_file(ListBox_files.SelectedItem)
        missing = total_lines - counter
        Label_counter_of_lines.Text = "The number of lines detected are: " + CStr(counter)
        Label_missing.Text = "The number of Missing lines are: " + CStr(missing)
        If missing = 0 Then
            Label_status.Text = "The selected file seems to be OK"
            read_language(ListBox_files.SelectedItem)
            Label_status.ForeColor = Color.Chartreuse
            Label_status.BackColor = Color.Black
            Button_finish.Enabled = True
        ElseIf missing < 0 Then
            Label_status.Text = "The selected file appears to have extra lines (probably repeating lines). Use of this file may be OK."
            read_language(ListBox_files.SelectedItem)
            Label_status.ForeColor = Color.Blue
            Label_status.BackColor = Color.Black
            Button_finish.Enabled = True
        Else
            Label_status.Text = "The selected file appears to be missing " + CStr(missing) + " lines. The file should not be used"
            Label_status.ForeColor = Color.Red
            Label_status.BackColor = Color.Black
            'Button_finish.Enabled = False

        End If
    End Sub
End Class
