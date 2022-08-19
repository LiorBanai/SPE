Public Class GUI_about
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
    Friend WithEvents copy As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label_version As System.Windows.Forms.Label
    Friend WithEvents Label_msg01 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel_mail As System.Windows.Forms.LinkLabel
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_about As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_contact As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_Additional As System.Windows.Forms.TabPage
    Friend WithEvents Label_lior As System.Windows.Forms.Label
    Friend WithEvents LinkLabel_mail1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label_omri As System.Windows.Forms.Label
    Friend WithEvents LinkLabel_mail2 As System.Windows.Forms.LinkLabel
    Friend WithEvents RichTextBox_additional As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox_paypal As System.Windows.Forms.PictureBox
    Friend WithEvents LinkLabelGithub As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button_disclaimer As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI_about))
        Me.Label_msg01 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.copy = New System.Windows.Forms.Label()
        Me.LinkLabel_mail = New System.Windows.Forms.LinkLabel()
        Me.Label_version = New System.Windows.Forms.Label()
        Me.Button_disclaimer = New System.Windows.Forms.Button()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPage_about = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage_contact = New System.Windows.Forms.TabPage()
        Me.PictureBox_paypal = New System.Windows.Forms.PictureBox()
        Me.LinkLabel_mail2 = New System.Windows.Forms.LinkLabel()
        Me.Label_omri = New System.Windows.Forms.Label()
        Me.Label_lior = New System.Windows.Forms.Label()
        Me.LinkLabel_mail1 = New System.Windows.Forms.LinkLabel()
        Me.TabPage_Additional = New System.Windows.Forms.TabPage()
        Me.RichTextBox_additional = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabelGithub = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl.SuspendLayout()
        Me.TabPage_about.SuspendLayout()
        Me.TabPage_contact.SuspendLayout()
        CType(Me.PictureBox_paypal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_Additional.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_msg01
        '
        Me.Label_msg01.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_msg01.AutoEllipsis = True
        Me.Label_msg01.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label_msg01.Location = New System.Drawing.Point(105, 4)
        Me.Label_msg01.Name = "Label_msg01"
        Me.Label_msg01.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_msg01.Size = New System.Drawing.Size(718, 264)
        Me.Label_msg01.TabIndex = 0
        Me.Label_msg01.Text = resources.GetString("Label_msg01.Text")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SPE.My.Resources.Resources.SPE01_small
        Me.PictureBox1.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(91, 91)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'copy
        '
        Me.copy.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.copy.Location = New System.Drawing.Point(0, 429)
        Me.copy.Name = "copy"
        Me.copy.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.copy.Size = New System.Drawing.Size(839, 22)
        Me.copy.TabIndex = 2
        Me.copy.Text = "All Rights Reserved 2005 - 2007 (updated 2022)"
        Me.copy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel_mail
        '
        Me.LinkLabel_mail.AutoEllipsis = True
        Me.LinkLabel_mail.AutoSize = True
        Me.LinkLabel_mail.Location = New System.Drawing.Point(305, 179)
        Me.LinkLabel_mail.Name = "LinkLabel_mail"
        Me.LinkLabel_mail.Size = New System.Drawing.Size(155, 20)
        Me.LinkLabel_mail.TabIndex = 3
        Me.LinkLabel_mail.TabStop = True
        Me.LinkLabel_mail.Text = "liorbanai@yahoo.com"
        '
        'Label_version
        '
        Me.Label_version.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label_version.Location = New System.Drawing.Point(0, 405)
        Me.Label_version.Name = "Label_version"
        Me.Label_version.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_version.Size = New System.Drawing.Size(839, 24)
        Me.Label_version.TabIndex = 4
        Me.Label_version.Text = "VERSION"
        Me.Label_version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button_disclaimer
        '
        Me.Button_disclaimer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button_disclaimer.AutoEllipsis = True
        Me.Button_disclaimer.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.Button_disclaimer.Location = New System.Drawing.Point(24, 281)
        Me.Button_disclaimer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button_disclaimer.Name = "Button_disclaimer"
        Me.Button_disclaimer.Size = New System.Drawing.Size(160, 64)
        Me.Button_disclaimer.TabIndex = 6
        Me.Button_disclaimer.Text = "DISCLAIMER OF WARRANTIES and LIMIT OF LIABILITY"
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPage_about)
        Me.TabControl.Controls.Add(Me.TabPage_contact)
        Me.TabControl.Controls.Add(Me.TabPage_Additional)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(839, 405)
        Me.TabControl.TabIndex = 8
        '
        'TabPage_about
        '
        Me.TabPage_about.Controls.Add(Me.PictureBox1)
        Me.TabPage_about.Controls.Add(Me.Button1)
        Me.TabPage_about.Controls.Add(Me.Button_disclaimer)
        Me.TabPage_about.Controls.Add(Me.Label_msg01)
        Me.TabPage_about.Location = New System.Drawing.Point(4, 29)
        Me.TabPage_about.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage_about.Name = "TabPage_about"
        Me.TabPage_about.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage_about.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabPage_about.Size = New System.Drawing.Size(831, 372)
        Me.TabPage_about.TabIndex = 0
        Me.TabPage_about.Text = "About - Orthotropic Plate Model"
        Me.TabPage_about.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(658, 281)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 64)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "View Program Citation (Hebrew)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabPage_contact
        '
        Me.TabPage_contact.Controls.Add(Me.LinkLabelGithub)
        Me.TabPage_contact.Controls.Add(Me.Label1)
        Me.TabPage_contact.Controls.Add(Me.PictureBox_paypal)
        Me.TabPage_contact.Controls.Add(Me.LinkLabel_mail2)
        Me.TabPage_contact.Controls.Add(Me.Label_omri)
        Me.TabPage_contact.Controls.Add(Me.Label_lior)
        Me.TabPage_contact.Controls.Add(Me.LinkLabel_mail1)
        Me.TabPage_contact.Location = New System.Drawing.Point(4, 29)
        Me.TabPage_contact.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage_contact.Name = "TabPage_contact"
        Me.TabPage_contact.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage_contact.Size = New System.Drawing.Size(831, 372)
        Me.TabPage_contact.TabIndex = 1
        Me.TabPage_contact.Text = "Contact Information"
        Me.TabPage_contact.UseVisualStyleBackColor = True
        '
        'PictureBox_paypal
        '
        Me.PictureBox_paypal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox_paypal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_paypal.Image = CType(resources.GetObject("PictureBox_paypal.Image"), System.Drawing.Image)
        Me.PictureBox_paypal.Location = New System.Drawing.Point(761, 333)
        Me.PictureBox_paypal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox_paypal.Name = "PictureBox_paypal"
        Me.PictureBox_paypal.Size = New System.Drawing.Size(62, 31)
        Me.PictureBox_paypal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox_paypal.TabIndex = 12
        Me.PictureBox_paypal.TabStop = False
        '
        'LinkLabel_mail2
        '
        Me.LinkLabel_mail2.AutoEllipsis = True
        Me.LinkLabel_mail2.Location = New System.Drawing.Point(101, 145)
        Me.LinkLabel_mail2.Name = "LinkLabel_mail2"
        Me.LinkLabel_mail2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LinkLabel_mail2.Size = New System.Drawing.Size(255, 31)
        Me.LinkLabel_mail2.TabIndex = 11
        Me.LinkLabel_mail2.TabStop = True
        Me.LinkLabel_mail2.Text = "omrip@alum.mit.edu"
        Me.LinkLabel_mail2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_omri
        '
        Me.Label_omri.AutoEllipsis = True
        Me.Label_omri.Location = New System.Drawing.Point(35, 109)
        Me.Label_omri.Name = "Label_omri"
        Me.Label_omri.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_omri.Size = New System.Drawing.Size(490, 36)
        Me.Label_omri.TabIndex = 10
        Me.Label_omri.Text = "Omri Pedatzur:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label_lior
        '
        Me.Label_lior.AutoEllipsis = True
        Me.Label_lior.Location = New System.Drawing.Point(35, 25)
        Me.Label_lior.Name = "Label_lior"
        Me.Label_lior.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_lior.Size = New System.Drawing.Size(490, 28)
        Me.Label_lior.TabIndex = 8
        Me.Label_lior.Text = "Lior Banai:"
        '
        'LinkLabel_mail1
        '
        Me.LinkLabel_mail1.AutoEllipsis = True
        Me.LinkLabel_mail1.Location = New System.Drawing.Point(101, 53)
        Me.LinkLabel_mail1.Name = "LinkLabel_mail1"
        Me.LinkLabel_mail1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LinkLabel_mail1.Size = New System.Drawing.Size(255, 31)
        Me.LinkLabel_mail1.TabIndex = 9
        Me.LinkLabel_mail1.TabStop = True
        Me.LinkLabel_mail1.Text = "lior_banai@eng-alum.tau.ac.il"
        Me.LinkLabel_mail1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage_Additional
        '
        Me.TabPage_Additional.Controls.Add(Me.RichTextBox_additional)
        Me.TabPage_Additional.Location = New System.Drawing.Point(4, 29)
        Me.TabPage_Additional.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage_Additional.Name = "TabPage_Additional"
        Me.TabPage_Additional.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage_Additional.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabPage_Additional.Size = New System.Drawing.Size(831, 372)
        Me.TabPage_Additional.TabIndex = 2
        Me.TabPage_Additional.Text = "Additional Information"
        Me.TabPage_Additional.UseVisualStyleBackColor = True
        '
        'RichTextBox_additional
        '
        Me.RichTextBox_additional.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox_additional.Location = New System.Drawing.Point(3, 4)
        Me.RichTextBox_additional.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RichTextBox_additional.Name = "RichTextBox_additional"
        Me.RichTextBox_additional.ReadOnly = True
        Me.RichTextBox_additional.Size = New System.Drawing.Size(825, 364)
        Me.RichTextBox_additional.TabIndex = 10
        Me.RichTextBox_additional.Text = resources.GetString("RichTextBox_additional.Text")
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.Location = New System.Drawing.Point(35, 206)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(490, 36)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Github Repository:"
        '
        'LinkLabelGithub
        '
        Me.LinkLabelGithub.AutoEllipsis = True
        Me.LinkLabelGithub.Location = New System.Drawing.Point(101, 260)
        Me.LinkLabelGithub.Name = "LinkLabelGithub"
        Me.LinkLabelGithub.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LinkLabelGithub.Size = New System.Drawing.Size(255, 31)
        Me.LinkLabelGithub.TabIndex = 14
        Me.LinkLabelGithub.TabStop = True
        Me.LinkLabelGithub.Text = "https://github.com/LiorBanai/SPE"
        Me.LinkLabelGithub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GUI_about
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 451)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.Label_version)
        Me.Controls.Add(Me.LinkLabel_mail)
        Me.Controls.Add(Me.copy)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GUI_about"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl.ResumeLayout(False)
        Me.TabPage_about.ResumeLayout(False)
        Me.TabPage_contact.ResumeLayout(False)
        Me.TabPage_contact.PerformLayout()
        CType(Me.PictureBox_paypal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_Additional.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private Sub GUI_set()
        Me.RightToLeftLayout = language_settings.language_RTL_layout
        Me.RightToLeft = language_settings.language_RTL
        TabControl.RightToLeftLayout = language_settings.language_RTL_layout
        TabControl.RightToLeft = language_settings.language_RTL
        Label_msg01.RightToLeft = language_settings.language_RTL
        RichTextBox_additional.RightToLeft = Windows.Forms.RightToLeft.No
        Label_lior.RightToLeft = Windows.Forms.RightToLeft.No
        LinkLabel_mail1.RightToLeft = Windows.Forms.RightToLeft.No
        LinkLabel_mail2.RightToLeft = Windows.Forms.RightToLeft.No
        Label_omri.RightToLeft = Windows.Forms.RightToLeft.No
        If language_settings.language_RTL_layout = True Then
            Label_msg01.Text = "תוכנה זו נכתבה במסגרת פרויקט הגמר לקבלת תואר ראשון בהנדסת מכונות (B.Sc) מאוניברסיטת תל אביב ע""י ליאור בנאי בהנחיתו של רס""ן עמרי פדהצור מחיל הים."
            Me.Text = "אודות"
            TabPage_about.Text = "אודות - מודל הפלטה האורתוטרופית"
        Else
            Label_msg01.Text = "This program was written as part of 4th year graduate project in partial fulfillment of the requirements for the degree of B.Sc. in Mechanical Engineering from Tel Aviv University under the advisory of LCDR Omri Pedatzur of the Israeli Navy."
            Me.Text = "About"
            TabPage_about.Text = "About - Orthotropic Plate Model"
        End If
    End Sub
    Private Sub Button_disclaimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_disclaimer.Click
        Dim msg_style As MsgBoxStyle = MsgBoxStyle.Information + MsgBoxStyle.OkOnly
        Dim msg_title As String = "DISCLAIMER OF WARRANTIES & LIMIT OF LIABILITY"
        Dim msg_text As String = "WARRANTIES & LIMIT OF LIABILITY" & vbCr & vbCr & "THERE IS NO WARRANTY FOR THE PROGRAM, TO THE EXTENT PERMITTED BY APPLICABLE LAW. EXCEPT WHEN OTHERWISE STATED IN WRITING THE COPYRIGHT HOLDERS AND/OR OTHER PARTIES PROVIDE THE PROGRAM ""AS IS"" WITHOUT WARRANTY OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE. THE ENTIRE RISK AS TO THE QUALITY AND PERFORMANCE OF THE PROGRAM IS WITH YOU. SHOULD THE PROGRAM PROVE DEFECTIVE, YOU ASSUME THE COST OF ALL NECESSARY SERVICING, REPAIR OR CORRECTION." & Chr(13) & Chr(13) & "IN NO EVENT UNLESS REQUIRED BY APPLICABLE LAW OR AGREED TO IN WRITING WILL ANY COPYRIGHT HOLDER, OR ANY OTHER PARTY WHO MAY MODIFY AND/OR REDISTRIBUTE THE PROGRAM AS PERMITTED ABOVE, BE LIABLE TO YOU FOR DAMAGES, INCLUDING ANY GENERAL, SPECIAL, INCIDENTAL OR CONSEQUENTIAL DAMAGES ARISING OUT OF THE USE OR INABILITY TO USE THE PROGRAM (INCLUDING BUT NOT LIMITED TO LOSS OF DATA OR DATA BEING RENDERED INACCURATE OR LOSSES SUSTAINED BY YOU OR THIRD PARTIES OR A FAILURE OF THE PROGRAM TO OPERATE WITH ANY OTHER PROGRAMS), EVEN IF SUCH HOLDER OR OTHER PARTY HAS BEEN ADVISED OF THE POSSIBILITY OF SUCH DAMAGES."
        MsgBox(msg_text, msg_style, msg_title)
    End Sub
    Private Sub LinkLabel_mail1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_mail1.LinkClicked
        Try
            LinkLabel_mail1.LinkVisited = True
            System.Diagnostics.Process.Start("mailto:" & LinkLabel_mail1.Text)
        Catch ex As Exception
            MessageBox.Show("Unable to open link that was clicked.")
        End Try
    End Sub
    Private Sub LinkLabel_mail2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_mail2.LinkClicked
        Try
            LinkLabel_mail2.LinkVisited = True
            System.Diagnostics.Process.Start("mailto:" + LinkLabel_mail2.Text)
        Catch ex As Exception
            MessageBox.Show("Unable to open link that was clicked.")
        End Try
    End Sub
    Private Sub PictureBox_rpoints_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            System.Diagnostics.Process.Start("http://www.rpoints.com/?ruid=100416")
        Catch ex As Exception
            MessageBox.Show("Unable to open link that was clicked.")
        End Try
    End Sub
    Private Sub PictureBox_quickrewards_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            System.Diagnostics.Process.Start("http://tinyurl.com/pexel")
        Catch ex As Exception
            MessageBox.Show("Unable to open link that was clicked.")
        End Try
    End Sub
    Private Sub Button_citation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If GUI_citation.IsDisposed = True Then
            GUI_citation = New GUI_citation
        End If
        GUI_citation.Show()
    End Sub


    Private Sub GUI_about_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'GUI_set()
        Label_version.Text = System.String.Format("Version {0}.{1}.{2}", My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.MinorRevision)
    End Sub

    Private Sub PictureBox_paypal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox_paypal.Click
        Try
            System.Diagnostics.Process.Start("https://www.paypal.com/donate/?business=MCP57TBRAAVXA&no_recurring=0&item_name=Support+Open+source+Projects+%28Analogy+Log+Viewer%2C+HDF5-CSHARP%2C+etc%29&currency_code=USD")
        Catch ex As Exception
            MessageBox.Show("Unable to open link that was clicked.")
        End Try
    End Sub

    Private Sub LinkLabelGithub_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelGithub.LinkClicked
        Try
            System.Diagnostics.Process.Start("https://github.com/LiorBanai/SPE")
        Catch ex As Exception
            MessageBox.Show("Unable to open link that was clicked.")
        End Try
    End Sub
End Class
