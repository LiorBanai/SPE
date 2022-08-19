<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GUI_model_chart_value
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
        Me.label_BC = New System.Windows.Forms.Label
        Me.bc = New System.Windows.Forms.MaskedTextBox
        Me.Label_s = New System.Windows.Forms.Label
        Me.Label_r = New System.Windows.Forms.Label
        Me.s = New System.Windows.Forms.MaskedTextBox
        Me.r = New System.Windows.Forms.MaskedTextBox
        Me.Label_chart_value = New System.Windows.Forms.Label
        Me.mu = New System.Windows.Forms.NumericUpDown
        Me.Label_mu = New System.Windows.Forms.Label
        Me.GroupBox_parameters = New System.Windows.Forms.GroupBox
        Me.GroupBox_reslut = New System.Windows.Forms.GroupBox
        Me.Label_bc_type = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox
        Me.Label6 = New System.Windows.Forms.Label
        CType(Me.mu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_parameters.SuspendLayout()
        Me.GroupBox_reslut.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label_BC
        '
        Me.label_BC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label_BC.AutoEllipsis = True
        Me.label_BC.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.label_BC.Location = New System.Drawing.Point(6, 80)
        Me.label_BC.Name = "label_BC"
        Me.label_BC.Size = New System.Drawing.Size(342, 20)
        Me.label_BC.TabIndex = 15
        Me.label_BC.Text = "Boundary condition"
        '
        'bc
        '
        Me.bc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bc.Location = New System.Drawing.Point(354, 78)
        Me.bc.Name = "bc"
        Me.bc.Size = New System.Drawing.Size(52, 22)
        Me.bc.TabIndex = 14
        Me.bc.Text = "3"
        Me.bc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_s
        '
        Me.Label_s.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_s.AutoEllipsis = True
        Me.Label_s.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_s.Location = New System.Drawing.Point(6, 52)
        Me.Label_s.Name = "Label_s"
        Me.Label_s.Size = New System.Drawing.Size(342, 22)
        Me.Label_s.TabIndex = 13
        Me.Label_s.Text = "s beams"
        '
        'Label_r
        '
        Me.Label_r.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_r.AutoEllipsis = True
        Me.Label_r.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_r.Location = New System.Drawing.Point(6, 20)
        Me.Label_r.Name = "Label_r"
        Me.Label_r.Size = New System.Drawing.Size(342, 22)
        Me.Label_r.TabIndex = 12
        Me.Label_r.Text = "r beams"
        '
        's
        '
        Me.s.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.s.Location = New System.Drawing.Point(354, 48)
        Me.s.Name = "s"
        Me.s.Size = New System.Drawing.Size(52, 22)
        Me.s.TabIndex = 11
        Me.s.Text = "3"
        Me.s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'r
        '
        Me.r.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.r.Location = New System.Drawing.Point(354, 20)
        Me.r.Name = "r"
        Me.r.Size = New System.Drawing.Size(52, 22)
        Me.r.TabIndex = 10
        Me.r.Text = "1"
        Me.r.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_chart_value
        '
        Me.Label_chart_value.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_chart_value.AutoEllipsis = True
        Me.Label_chart_value.Font = New System.Drawing.Font("David", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_chart_value.Location = New System.Drawing.Point(6, 31)
        Me.Label_chart_value.Name = "Label_chart_value"
        Me.Label_chart_value.Size = New System.Drawing.Size(388, 59)
        Me.Label_chart_value.TabIndex = 9
        Me.Label_chart_value.Text = "0.0000000"
        '
        'mu
        '
        Me.mu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mu.DecimalPlaces = 6
        Me.mu.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.mu.Location = New System.Drawing.Point(330, 197)
        Me.mu.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.mu.Minimum = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.mu.Name = "mu"
        Me.mu.Size = New System.Drawing.Size(76, 22)
        Me.mu.TabIndex = 16
        Me.mu.Value = New Decimal(New Integer() {1, 0, 0, 196608})
        '
        'Label_mu
        '
        Me.Label_mu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_mu.AutoEllipsis = True
        Me.Label_mu.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_mu.Location = New System.Drawing.Point(6, 197)
        Me.Label_mu.Name = "Label_mu"
        Me.Label_mu.Size = New System.Drawing.Size(318, 20)
        Me.Label_mu.TabIndex = 17
        Me.Label_mu.Text = "Mu value"
        '
        'GroupBox_parameters
        '
        Me.GroupBox_parameters.Controls.Add(Me.GroupBox_reslut)
        Me.GroupBox_parameters.Controls.Add(Me.Label_bc_type)
        Me.GroupBox_parameters.Controls.Add(Me.Label_mu)
        Me.GroupBox_parameters.Controls.Add(Me.r)
        Me.GroupBox_parameters.Controls.Add(Me.mu)
        Me.GroupBox_parameters.Controls.Add(Me.s)
        Me.GroupBox_parameters.Controls.Add(Me.label_BC)
        Me.GroupBox_parameters.Controls.Add(Me.Label_r)
        Me.GroupBox_parameters.Controls.Add(Me.bc)
        Me.GroupBox_parameters.Controls.Add(Me.Label_s)
        Me.GroupBox_parameters.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox_parameters.Name = "GroupBox_parameters"
        Me.GroupBox_parameters.Size = New System.Drawing.Size(412, 335)
        Me.GroupBox_parameters.TabIndex = 18
        Me.GroupBox_parameters.TabStop = False
        Me.GroupBox_parameters.Text = "Grillage Model"
        '
        'GroupBox_reslut
        '
        Me.GroupBox_reslut.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_reslut.Controls.Add(Me.Label_chart_value)
        Me.GroupBox_reslut.Location = New System.Drawing.Point(6, 226)
        Me.GroupBox_reslut.Name = "GroupBox_reslut"
        Me.GroupBox_reslut.Size = New System.Drawing.Size(400, 100)
        Me.GroupBox_reslut.TabIndex = 19
        Me.GroupBox_reslut.TabStop = False
        Me.GroupBox_reslut.Text = "Chart Value"
        '
        'Label_bc_type
        '
        Me.Label_bc_type.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_bc_type.AutoEllipsis = True
        Me.Label_bc_type.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_bc_type.Location = New System.Drawing.Point(6, 108)
        Me.Label_bc_type.Name = "Label_bc_type"
        Me.Label_bc_type.Size = New System.Drawing.Size(400, 83)
        Me.Label_bc_type.TabIndex = 18
        Me.Label_bc_type.Text = "1: Kr=0 , Ks=0 (All Edges are Simply Supported)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2: Kr=0 , Ks=1 (Long: simply sup" & _
            "ported, long: Fixed) " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3: Kr=1 , Ks=0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4: Kr=1 , Ks=1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox1)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(430, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 335)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Orthotropic Plate Model"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 226)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(292, 100)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chart Value"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoEllipsis = True
        Me.Label1.Font = New System.Drawing.Font("David", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 59)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "0.0000000"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoEllipsis = True
        Me.Label2.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(292, 83)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "1: Kr=0 , Ks=0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2: Kr=0 , Ks=1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3: Kr=1 , Ks=0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4: Kr=1 , Ks=1"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoEllipsis = True
        Me.Label3.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(210, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Mu value"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaskedTextBox1.Location = New System.Drawing.Point(246, 20)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(52, 22)
        Me.MaskedTextBox1.TabIndex = 10
        Me.MaskedTextBox1.Text = "1"
        Me.MaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDown1.DecimalPlaces = 6
        Me.NumericUpDown1.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.NumericUpDown1.Location = New System.Drawing.Point(222, 197)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(76, 22)
        Me.NumericUpDown1.TabIndex = 16
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 196608})
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaskedTextBox2.Location = New System.Drawing.Point(246, 49)
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(52, 22)
        Me.MaskedTextBox2.TabIndex = 11
        Me.MaskedTextBox2.Text = "3"
        Me.MaskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoEllipsis = True
        Me.Label4.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(234, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Boundary condition"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoEllipsis = True
        Me.Label5.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(234, 22)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "r beams"
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaskedTextBox3.Location = New System.Drawing.Point(246, 78)
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(52, 22)
        Me.MaskedTextBox3.TabIndex = 14
        Me.MaskedTextBox3.Text = "3"
        Me.MaskedTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoEllipsis = True
        Me.Label6.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(234, 22)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "s beams"
        '
        'GUI_model_chart_value
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 357)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox_parameters)
        Me.Name = "GUI_model_chart_value"
        Me.Text = "Model Value Extraction"
        CType(Me.mu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_parameters.ResumeLayout(False)
        Me.GroupBox_parameters.PerformLayout()
        Me.GroupBox_reslut.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents label_BC As System.Windows.Forms.Label
    Friend WithEvents bc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label_s As System.Windows.Forms.Label
    Friend WithEvents Label_r As System.Windows.Forms.Label
    Friend WithEvents s As System.Windows.Forms.MaskedTextBox
    Friend WithEvents r As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label_chart_value As System.Windows.Forms.Label
    Friend WithEvents mu As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label_mu As System.Windows.Forms.Label
    Friend WithEvents GroupBox_parameters As System.Windows.Forms.GroupBox
    Friend WithEvents Label_bc_type As System.Windows.Forms.Label
    Friend WithEvents GroupBox_reslut As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents MaskedTextBox2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
