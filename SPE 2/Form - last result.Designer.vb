<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GUI_last_result
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI_last_result))
        Me.RichTextBox_last_result = New System.Windows.Forms.RichTextBox
        Me.Button_update = New System.Windows.Forms.Button
        Me.button_results_save = New System.Windows.Forms.Button
        Me.GroupBox_choose_language = New System.Windows.Forms.GroupBox
        Me.RadioButton_other_language = New System.Windows.Forms.RadioButton
        Me.RadioButton_default_english = New System.Windows.Forms.RadioButton
        Me.Picture_eng = New System.Windows.Forms.PictureBox
        Me.Picture_heb = New System.Windows.Forms.PictureBox
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.TSSLabel_count = New System.Windows.Forms.ToolStripStatusLabel
        Me.GroupBox_choose_language.SuspendLayout()
        CType(Me.Picture_eng, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture_heb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox_last_result
        '
        Me.RichTextBox_last_result.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox_last_result.BackColor = System.Drawing.Color.White
        Me.RichTextBox_last_result.Location = New System.Drawing.Point(12, 95)
        Me.RichTextBox_last_result.Name = "RichTextBox_last_result"
        Me.RichTextBox_last_result.ReadOnly = True
        Me.RichTextBox_last_result.Size = New System.Drawing.Size(637, 266)
        Me.RichTextBox_last_result.TabIndex = 0
        Me.RichTextBox_last_result.Text = ""
        '
        'Button_update
        '
        Me.Button_update.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button_update.AutoEllipsis = True
        Me.Button_update.Location = New System.Drawing.Point(185, 367)
        Me.Button_update.Name = "Button_update"
        Me.Button_update.Size = New System.Drawing.Size(117, 40)
        Me.Button_update.TabIndex = 1
        Me.Button_update.Text = "Update"
        Me.Button_update.UseVisualStyleBackColor = True
        '
        'button_results_save
        '
        Me.button_results_save.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.button_results_save.AutoEllipsis = True
        Me.button_results_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.button_results_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_results_save.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.button_results_save.Location = New System.Drawing.Point(327, 367)
        Me.button_results_save.Name = "button_results_save"
        Me.button_results_save.Size = New System.Drawing.Size(117, 40)
        Me.button_results_save.TabIndex = 50
        Me.button_results_save.Text = "Save Output"
        '
        'GroupBox_choose_language
        '
        Me.GroupBox_choose_language.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_choose_language.Controls.Add(Me.RadioButton_other_language)
        Me.GroupBox_choose_language.Controls.Add(Me.RadioButton_default_english)
        Me.GroupBox_choose_language.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox_choose_language.Name = "GroupBox_choose_language"
        Me.GroupBox_choose_language.Size = New System.Drawing.Size(590, 77)
        Me.GroupBox_choose_language.TabIndex = 67
        Me.GroupBox_choose_language.TabStop = False
        '
        'RadioButton_other_language
        '
        Me.RadioButton_other_language.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButton_other_language.AutoEllipsis = True
        Me.RadioButton_other_language.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RadioButton_other_language.Location = New System.Drawing.Point(16, 42)
        Me.RadioButton_other_language.Name = "RadioButton_other_language"
        Me.RadioButton_other_language.Size = New System.Drawing.Size(562, 31)
        Me.RadioButton_other_language.TabIndex = 68
        Me.RadioButton_other_language.Text = "Use current language"
        Me.RadioButton_other_language.UseVisualStyleBackColor = True
        '
        'RadioButton_default_english
        '
        Me.RadioButton_default_english.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButton_default_english.AutoEllipsis = True
        Me.RadioButton_default_english.Checked = True
        Me.RadioButton_default_english.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RadioButton_default_english.Location = New System.Drawing.Point(16, 13)
        Me.RadioButton_default_english.Name = "RadioButton_default_english"
        Me.RadioButton_default_english.Size = New System.Drawing.Size(562, 27)
        Me.RadioButton_default_english.TabIndex = 67
        Me.RadioButton_default_english.TabStop = True
        Me.RadioButton_default_english.Text = "Use the default English language for displaying calculations"
        Me.RadioButton_default_english.UseVisualStyleBackColor = True
        '
        'Picture_eng
        '
        Me.Picture_eng.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Picture_eng.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Picture_eng.Image = CType(resources.GetObject("Picture_eng.Image"), System.Drawing.Image)
        Me.Picture_eng.Location = New System.Drawing.Point(617, 38)
        Me.Picture_eng.Name = "Picture_eng"
        Me.Picture_eng.Size = New System.Drawing.Size(32, 16)
        Me.Picture_eng.TabIndex = 69
        Me.Picture_eng.TabStop = False
        '
        'Picture_heb
        '
        Me.Picture_heb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Picture_heb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Picture_heb.Image = CType(resources.GetObject("Picture_heb.Image"), System.Drawing.Image)
        Me.Picture_heb.Location = New System.Drawing.Point(617, 12)
        Me.Picture_heb.Name = "Picture_heb"
        Me.Picture_heb.Size = New System.Drawing.Size(32, 20)
        Me.Picture_heb.TabIndex = 68
        Me.Picture_heb.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSSLabel_count})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 424)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(661, 23)
        Me.StatusStrip1.TabIndex = 70
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TSSLabel_count
        '
        Me.TSSLabel_count.Name = "TSSLabel_count"
        Me.TSSLabel_count.Size = New System.Drawing.Size(146, 18)
        Me.TSSLabel_count.Text = "ToolStripStatusLabel1"
        '
        'GUI_last_result
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 447)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Picture_eng)
        Me.Controls.Add(Me.Picture_heb)
        Me.Controls.Add(Me.GroupBox_choose_language)
        Me.Controls.Add(Me.button_results_save)
        Me.Controls.Add(Me.Button_update)
        Me.Controls.Add(Me.RichTextBox_last_result)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(628, 487)
        Me.Name = "GUI_last_result"
        Me.Text = "Orthotropic Plate model: Last Results"
        Me.GroupBox_choose_language.ResumeLayout(False)
        CType(Me.Picture_eng, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture_heb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox_last_result As System.Windows.Forms.RichTextBox
    Friend WithEvents Button_update As System.Windows.Forms.Button
    Friend WithEvents button_results_save As System.Windows.Forms.Button
    Friend WithEvents GroupBox_choose_language As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton_other_language As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_default_english As System.Windows.Forms.RadioButton
    Friend WithEvents Picture_eng As System.Windows.Forms.PictureBox
    Friend WithEvents Picture_heb As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents TSSLabel_count As System.Windows.Forms.ToolStripStatusLabel
End Class
