<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GUI_first_run
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI_first_run))
        Me.RichTextBox_welcome = New System.Windows.Forms.RichTextBox
        Me.Button_next = New System.Windows.Forms.Button
        Me.CheckBox_accept = New System.Windows.Forms.CheckBox
        Me.RichTextBox_disclaimer = New System.Windows.Forms.RichTextBox
        Me.SuspendLayout()
        '
        'RichTextBox_welcome
        '
        Me.RichTextBox_welcome.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox_welcome.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RichTextBox_welcome.Font = New System.Drawing.Font("David", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RichTextBox_welcome.Location = New System.Drawing.Point(12, 12)
        Me.RichTextBox_welcome.Name = "RichTextBox_welcome"
        Me.RichTextBox_welcome.Size = New System.Drawing.Size(672, 89)
        Me.RichTextBox_welcome.TabIndex = 0
        Me.RichTextBox_welcome.Text = "This program implements the Orthotropic plate model and the Grillage model for qu" & _
            "ick estimation of the maximum deflection of stiffened plates/panels due to unifo" & _
            "rm pressure acting on the plate/panel."
        '
        'Button_next
        '
        Me.Button_next.Location = New System.Drawing.Point(311, 371)
        Me.Button_next.Name = "Button_next"
        Me.Button_next.Size = New System.Drawing.Size(67, 38)
        Me.Button_next.TabIndex = 2
        Me.Button_next.Text = "OK"
        Me.Button_next.UseVisualStyleBackColor = True
        '
        'CheckBox_accept
        '
        Me.CheckBox_accept.AutoEllipsis = True
        Me.CheckBox_accept.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox_accept.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.CheckBox_accept.ForeColor = System.Drawing.Color.Lime
        Me.CheckBox_accept.Location = New System.Drawing.Point(12, 337)
        Me.CheckBox_accept.Name = "CheckBox_accept"
        Me.CheckBox_accept.Size = New System.Drawing.Size(662, 28)
        Me.CheckBox_accept.TabIndex = 3
        Me.CheckBox_accept.Text = "I agree with the DISCLAIMER OF WARRANTIES and LIMIT OF LIABILITY"
        Me.CheckBox_accept.UseVisualStyleBackColor = False
        '
        'RichTextBox_disclaimer
        '
        Me.RichTextBox_disclaimer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox_disclaimer.Location = New System.Drawing.Point(12, 107)
        Me.RichTextBox_disclaimer.Name = "RichTextBox_disclaimer"
        Me.RichTextBox_disclaimer.Size = New System.Drawing.Size(672, 224)
        Me.RichTextBox_disclaimer.TabIndex = 4
        Me.RichTextBox_disclaimer.Text = resources.GetString("RichTextBox_disclaimer.Text")
        '
        'GUI_first_run
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SPE.My.Resources.Resources.saar_in_sunset
        Me.ClientSize = New System.Drawing.Size(696, 431)
        Me.Controls.Add(Me.RichTextBox_disclaimer)
        Me.Controls.Add(Me.CheckBox_accept)
        Me.Controls.Add(Me.Button_next)
        Me.Controls.Add(Me.RichTextBox_welcome)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GUI_first_run"
        Me.Text = "Welcome to Stiffened Plates Evaluator"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RichTextBox_welcome As System.Windows.Forms.RichTextBox
    Friend WithEvents Button_next As System.Windows.Forms.Button
    Friend WithEvents CheckBox_accept As System.Windows.Forms.CheckBox
    Friend WithEvents RichTextBox_disclaimer As System.Windows.Forms.RichTextBox
End Class
