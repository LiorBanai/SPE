<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GUI_model_parameters
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI_model_parameters))
        Me.Label_model = New System.Windows.Forms.Label
        Me.ComboBox_current_model = New System.Windows.Forms.ComboBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.RTB_comments = New System.Windows.Forms.RichTextBox
        Me.GroupBox_model = New System.Windows.Forms.GroupBox
        Me.Label_short = New System.Windows.Forms.Label
        Me.Label_long = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_model.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_model
        '
        Me.Label_model.AutoEllipsis = True
        Me.Label_model.Location = New System.Drawing.Point(12, 7)
        Me.Label_model.Name = "Label_model"
        Me.Label_model.Size = New System.Drawing.Size(299, 23)
        Me.Label_model.TabIndex = 0
        Me.Label_model.Text = "Model:"
        '
        'ComboBox_current_model
        '
        Me.ComboBox_current_model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_current_model.FormattingEnabled = True
        Me.ComboBox_current_model.Items.AddRange(New Object() {"Orthotropic Plate", "Grillage"})
        Me.ComboBox_current_model.Location = New System.Drawing.Point(364, 6)
        Me.ComboBox_current_model.Name = "ComboBox_current_model"
        Me.ComboBox_current_model.Size = New System.Drawing.Size(282, 24)
        Me.ComboBox_current_model.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(310, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(314, 400)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'RTB_comments
        '
        Me.RTB_comments.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RTB_comments.Location = New System.Drawing.Point(6, 24)
        Me.RTB_comments.Name = "RTB_comments"
        Me.RTB_comments.Size = New System.Drawing.Size(298, 388)
        Me.RTB_comments.TabIndex = 3
        Me.RTB_comments.Text = "1" & Global.Microsoft.VisualBasic.ChrW(10) & "2" & Global.Microsoft.VisualBasic.ChrW(10) & "3" & Global.Microsoft.VisualBasic.ChrW(10) & "3" & Global.Microsoft.VisualBasic.ChrW(10) & "4" & Global.Microsoft.VisualBasic.ChrW(10) & "5" & Global.Microsoft.VisualBasic.ChrW(10) & "6" & Global.Microsoft.VisualBasic.ChrW(10) & "7" & Global.Microsoft.VisualBasic.ChrW(10) & "8" & Global.Microsoft.VisualBasic.ChrW(10) & "9" & Global.Microsoft.VisualBasic.ChrW(10) & "10" & Global.Microsoft.VisualBasic.ChrW(10) & "11" & Global.Microsoft.VisualBasic.ChrW(10) & "12" & Global.Microsoft.VisualBasic.ChrW(10) & "13" & Global.Microsoft.VisualBasic.ChrW(10) & "14" & Global.Microsoft.VisualBasic.ChrW(10) & "15" & Global.Microsoft.VisualBasic.ChrW(10) & "16" & Global.Microsoft.VisualBasic.ChrW(10) & "17"
        '
        'GroupBox_model
        '
        Me.GroupBox_model.Controls.Add(Me.Label_short)
        Me.GroupBox_model.Controls.Add(Me.Label_long)
        Me.GroupBox_model.Controls.Add(Me.RTB_comments)
        Me.GroupBox_model.Controls.Add(Me.PictureBox1)
        Me.GroupBox_model.Location = New System.Drawing.Point(15, 35)
        Me.GroupBox_model.Name = "GroupBox_model"
        Me.GroupBox_model.Size = New System.Drawing.Size(639, 427)
        Me.GroupBox_model.TabIndex = 4
        Me.GroupBox_model.TabStop = False
        '
        'Label_short
        '
        Me.Label_short.AutoEllipsis = True
        Me.Label_short.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_short.Location = New System.Drawing.Point(448, 391)
        Me.Label_short.Name = "Label_short"
        Me.Label_short.Size = New System.Drawing.Size(27, 29)
        Me.Label_short.TabIndex = 6
        Me.Label_short.Text = "a"
        Me.Label_short.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_long
        '
        Me.Label_long.AutoEllipsis = True
        Me.Label_long.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_long.Location = New System.Drawing.Point(584, 204)
        Me.Label_long.Name = "Label_long"
        Me.Label_long.Size = New System.Drawing.Size(27, 31)
        Me.Label_long.TabIndex = 5
        Me.Label_long.Text = "b"
        Me.Label_long.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GUI_model_parameters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 519)
        Me.Controls.Add(Me.GroupBox_model)
        Me.Controls.Add(Me.ComboBox_current_model)
        Me.Controls.Add(Me.Label_model)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(674, 559)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(674, 559)
        Me.Name = "GUI_model_parameters"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Model Parameters"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_model.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label_model As System.Windows.Forms.Label
    Friend WithEvents ComboBox_current_model As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents RTB_comments As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox_model As System.Windows.Forms.GroupBox
    Friend WithEvents Label_short As System.Windows.Forms.Label
    Friend WithEvents Label_long As System.Windows.Forms.Label
End Class
