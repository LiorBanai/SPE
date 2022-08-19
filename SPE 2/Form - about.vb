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
    Friend WithEvents pic As System.Windows.Forms.GroupBox
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
    Friend WithEvents TabPage_email As System.Windows.Forms.TabPage
    Friend WithEvents email_contact1 As System.Windows.Forms.LinkLabel
    Friend WithEvents email_contact2 As System.Windows.Forms.LinkLabel
    Friend WithEvents email_contact4 As System.Windows.Forms.LinkLabel
    Friend WithEvents email_contact3 As System.Windows.Forms.LinkLabel
    Friend WithEvents email_contact5 As System.Windows.Forms.LinkLabel
    Friend WithEvents email_contact6 As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox_paypal As System.Windows.Forms.PictureBox
    Friend WithEvents Button_disclaimer As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI_about))
        Me.Label_msg01 = New System.Windows.Forms.Label
        Me.pic = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.copy = New System.Windows.Forms.Label
        Me.LinkLabel_mail = New System.Windows.Forms.LinkLabel
        Me.Label_version = New System.Windows.Forms.Label
        Me.Button_disclaimer = New System.Windows.Forms.Button
        Me.TabControl = New System.Windows.Forms.TabControl
        Me.TabPage_about = New System.Windows.Forms.TabPage
        Me.Button1 = New System.Windows.Forms.Button
        Me.TabPage_contact = New System.Windows.Forms.TabPage
        Me.PictureBox_paypal = New System.Windows.Forms.PictureBox
        Me.LinkLabel_mail2 = New System.Windows.Forms.LinkLabel
        Me.Label_omri = New System.Windows.Forms.Label
        Me.Label_lior = New System.Windows.Forms.Label
        Me.LinkLabel_mail1 = New System.Windows.Forms.LinkLabel
        Me.TabPage_Additional = New System.Windows.Forms.TabPage
        Me.RichTextBox_additional = New System.Windows.Forms.RichTextBox
        Me.TabPage_email = New System.Windows.Forms.TabPage
        Me.email_contact5 = New System.Windows.Forms.LinkLabel
        Me.email_contact6 = New System.Windows.Forms.LinkLabel
        Me.email_contact4 = New System.Windows.Forms.LinkLabel
        Me.email_contact3 = New System.Windows.Forms.LinkLabel
        Me.email_contact2 = New System.Windows.Forms.LinkLabel
        Me.email_contact1 = New System.Windows.Forms.LinkLabel
        Me.pic.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl.SuspendLayout()
        Me.TabPage_about.SuspendLayout()
        Me.TabPage_contact.SuspendLayout()
        CType(Me.PictureBox_paypal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_Additional.SuspendLayout()
        Me.TabPage_email.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_msg01
        '
        Me.Label_msg01.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_msg01.AutoEllipsis = True
        Me.Label_msg01.Font = New System.Drawing.Font("David", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_msg01.Location = New System.Drawing.Point(204, 13)
        Me.Label_msg01.Name = "Label_msg01"
        Me.Label_msg01.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_msg01.Size = New System.Drawing.Size(371, 202)
        Me.Label_msg01.TabIndex = 0
        Me.Label_msg01.Text = resources.GetString("Label_msg01.Text")
        '
        'pic
        '
        Me.pic.Controls.Add(Me.PictureBox1)
        Me.pic.Location = New System.Drawing.Point(24, 13)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(125, 152)
        Me.pic.TabIndex = 1
        Me.pic.TabStop = False
        Me.pic.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(7, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 137)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'copy
        '
        Me.copy.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.copy.Location = New System.Drawing.Point(0, 343)
        Me.copy.Name = "copy"
        Me.copy.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.copy.Size = New System.Drawing.Size(598, 18)
        Me.copy.TabIndex = 2
        Me.copy.Text = "All Rights Reserved 2005 - 2007"
        Me.copy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel_mail
        '
        Me.LinkLabel_mail.AutoEllipsis = True
        Me.LinkLabel_mail.AutoSize = True
        Me.LinkLabel_mail.Location = New System.Drawing.Point(305, 143)
        Me.LinkLabel_mail.Name = "LinkLabel_mail"
        Me.LinkLabel_mail.Size = New System.Drawing.Size(145, 17)
        Me.LinkLabel_mail.TabIndex = 3
        Me.LinkLabel_mail.TabStop = True
        Me.LinkLabel_mail.Text = "liorbanai@yahoo.com"
        '
        'Label_version
        '
        Me.Label_version.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label_version.Location = New System.Drawing.Point(0, 324)
        Me.Label_version.Name = "Label_version"
        Me.Label_version.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_version.Size = New System.Drawing.Size(598, 19)
        Me.Label_version.TabIndex = 4
        Me.Label_version.Text = "VERSION"
        Me.Label_version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button_disclaimer
        '
        Me.Button_disclaimer.AutoEllipsis = True
        Me.Button_disclaimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.Button_disclaimer.Location = New System.Drawing.Point(24, 218)
        Me.Button_disclaimer.Name = "Button_disclaimer"
        Me.Button_disclaimer.Size = New System.Drawing.Size(160, 51)
        Me.Button_disclaimer.TabIndex = 6
        Me.Button_disclaimer.Text = "DISCLAIMER OF WARRANTIES and LIMIT OF LIABILITY"
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPage_about)
        Me.TabControl.Controls.Add(Me.TabPage_contact)
        Me.TabControl.Controls.Add(Me.TabPage_Additional)
        Me.TabControl.Controls.Add(Me.TabPage_email)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(598, 324)
        Me.TabControl.TabIndex = 8
        '
        'TabPage_about
        '
        Me.TabPage_about.Controls.Add(Me.Button1)
        Me.TabPage_about.Controls.Add(Me.pic)
        Me.TabPage_about.Controls.Add(Me.Button_disclaimer)
        Me.TabPage_about.Controls.Add(Me.Label_msg01)
        Me.TabPage_about.Location = New System.Drawing.Point(4, 25)
        Me.TabPage_about.Name = "TabPage_about"
        Me.TabPage_about.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_about.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabPage_about.Size = New System.Drawing.Size(636, 295)
        Me.TabPage_about.TabIndex = 0
        Me.TabPage_about.Text = "About - Orthotropic Plate Model"
        Me.TabPage_about.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(398, 218)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 51)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "View Program Citation (Hebrew)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabPage_contact
        '
        Me.TabPage_contact.Controls.Add(Me.PictureBox_paypal)
        Me.TabPage_contact.Controls.Add(Me.LinkLabel_mail2)
        Me.TabPage_contact.Controls.Add(Me.Label_omri)
        Me.TabPage_contact.Controls.Add(Me.Label_lior)
        Me.TabPage_contact.Controls.Add(Me.LinkLabel_mail1)
        Me.TabPage_contact.Location = New System.Drawing.Point(4, 25)
        Me.TabPage_contact.Name = "TabPage_contact"
        Me.TabPage_contact.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_contact.Size = New System.Drawing.Size(636, 295)
        Me.TabPage_contact.TabIndex = 1
        Me.TabPage_contact.Text = "Contact Information"
        Me.TabPage_contact.UseVisualStyleBackColor = True
        '
        'PictureBox_paypal
        '
        Me.PictureBox_paypal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_paypal.Image = CType(resources.GetObject("PictureBox_paypal.Image"), System.Drawing.Image)
        Me.PictureBox_paypal.Location = New System.Drawing.Point(520, 258)
        Me.PictureBox_paypal.Name = "PictureBox_paypal"
        Me.PictureBox_paypal.Size = New System.Drawing.Size(62, 31)
        Me.PictureBox_paypal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox_paypal.TabIndex = 12
        Me.PictureBox_paypal.TabStop = False
        '
        'LinkLabel_mail2
        '
        Me.LinkLabel_mail2.AutoEllipsis = True
        Me.LinkLabel_mail2.Location = New System.Drawing.Point(101, 97)
        Me.LinkLabel_mail2.Name = "LinkLabel_mail2"
        Me.LinkLabel_mail2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LinkLabel_mail2.Size = New System.Drawing.Size(255, 25)
        Me.LinkLabel_mail2.TabIndex = 11
        Me.LinkLabel_mail2.TabStop = True
        Me.LinkLabel_mail2.Text = "omrip@alum.mit.edu"
        Me.LinkLabel_mail2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_omri
        '
        Me.Label_omri.AutoEllipsis = True
        Me.Label_omri.Location = New System.Drawing.Point(35, 79)
        Me.Label_omri.Name = "Label_omri"
        Me.Label_omri.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_omri.Size = New System.Drawing.Size(490, 29)
        Me.Label_omri.TabIndex = 10
        Me.Label_omri.Text = "Omri Pedatzur:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label_lior
        '
        Me.Label_lior.AutoEllipsis = True
        Me.Label_lior.Location = New System.Drawing.Point(35, 20)
        Me.Label_lior.Name = "Label_lior"
        Me.Label_lior.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_lior.Size = New System.Drawing.Size(490, 22)
        Me.Label_lior.TabIndex = 8
        Me.Label_lior.Text = "Lior Banai:"
        '
        'LinkLabel_mail1
        '
        Me.LinkLabel_mail1.AutoEllipsis = True
        Me.LinkLabel_mail1.Location = New System.Drawing.Point(101, 42)
        Me.LinkLabel_mail1.Name = "LinkLabel_mail1"
        Me.LinkLabel_mail1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LinkLabel_mail1.Size = New System.Drawing.Size(255, 25)
        Me.LinkLabel_mail1.TabIndex = 9
        Me.LinkLabel_mail1.TabStop = True
        Me.LinkLabel_mail1.Text = "lior_banai@eng-alum.tau.ac.il"
        Me.LinkLabel_mail1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage_Additional
        '
        Me.TabPage_Additional.Controls.Add(Me.RichTextBox_additional)
        Me.TabPage_Additional.Location = New System.Drawing.Point(4, 25)
        Me.TabPage_Additional.Name = "TabPage_Additional"
        Me.TabPage_Additional.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Additional.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabPage_Additional.Size = New System.Drawing.Size(590, 295)
        Me.TabPage_Additional.TabIndex = 2
        Me.TabPage_Additional.Text = "Additional Information"
        Me.TabPage_Additional.UseVisualStyleBackColor = True
        '
        'RichTextBox_additional
        '
        Me.RichTextBox_additional.Location = New System.Drawing.Point(3, 6)
        Me.RichTextBox_additional.Name = "RichTextBox_additional"
        Me.RichTextBox_additional.ReadOnly = True
        Me.RichTextBox_additional.Size = New System.Drawing.Size(566, 180)
        Me.RichTextBox_additional.TabIndex = 10
        Me.RichTextBox_additional.Text = resources.GetString("RichTextBox_additional.Text")
        '
        'TabPage_email
        '
        Me.TabPage_email.Controls.Add(Me.email_contact5)
        Me.TabPage_email.Controls.Add(Me.email_contact6)
        Me.TabPage_email.Controls.Add(Me.email_contact4)
        Me.TabPage_email.Controls.Add(Me.email_contact3)
        Me.TabPage_email.Controls.Add(Me.email_contact2)
        Me.TabPage_email.Controls.Add(Me.email_contact1)
        Me.TabPage_email.Location = New System.Drawing.Point(4, 25)
        Me.TabPage_email.Name = "TabPage_email"
        Me.TabPage_email.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_email.Size = New System.Drawing.Size(590, 295)
        Me.TabPage_email.TabIndex = 3
        Me.TabPage_email.Text = "Email contacts"
        Me.TabPage_email.UseVisualStyleBackColor = True
        '
        'email_contact5
        '
        Me.email_contact5.AutoEllipsis = True
        Me.email_contact5.Location = New System.Drawing.Point(8, 200)
        Me.email_contact5.Name = "email_contact5"
        Me.email_contact5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.email_contact5.Size = New System.Drawing.Size(316, 26)
        Me.email_contact5.TabIndex = 5
        Me.email_contact5.TabStop = True
        Me.email_contact5.Text = "Special Requests"
        Me.email_contact5.UseMnemonic = False
        '
        'email_contact6
        '
        Me.email_contact6.AutoEllipsis = True
        Me.email_contact6.Location = New System.Drawing.Point(330, 200)
        Me.email_contact6.Name = "email_contact6"
        Me.email_contact6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.email_contact6.Size = New System.Drawing.Size(241, 26)
        Me.email_contact6.TabIndex = 4
        Me.email_contact6.TabStop = True
        Me.email_contact6.Text = "Non SPE Issue"
        '
        'email_contact4
        '
        Me.email_contact4.AutoEllipsis = True
        Me.email_contact4.Location = New System.Drawing.Point(8, 109)
        Me.email_contact4.Name = "email_contact4"
        Me.email_contact4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.email_contact4.Size = New System.Drawing.Size(316, 26)
        Me.email_contact4.TabIndex = 3
        Me.email_contact4.TabStop = True
        Me.email_contact4.Text = "Languages Related: new/modified files"
        Me.email_contact4.UseMnemonic = False
        '
        'email_contact3
        '
        Me.email_contact3.AutoEllipsis = True
        Me.email_contact3.Location = New System.Drawing.Point(330, 109)
        Me.email_contact3.Name = "email_contact3"
        Me.email_contact3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.email_contact3.Size = New System.Drawing.Size(241, 26)
        Me.email_contact3.TabIndex = 2
        Me.email_contact3.TabStop = True
        Me.email_contact3.Text = "General SPE issues"
        '
        'email_contact2
        '
        Me.email_contact2.AutoEllipsis = True
        Me.email_contact2.Location = New System.Drawing.Point(330, 23)
        Me.email_contact2.Name = "email_contact2"
        Me.email_contact2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.email_contact2.Size = New System.Drawing.Size(238, 26)
        Me.email_contact2.TabIndex = 1
        Me.email_contact2.TabStop = True
        Me.email_contact2.Text = "Suggestions and Improvments"
        Me.email_contact2.UseMnemonic = False
        '
        'email_contact1
        '
        Me.email_contact1.AutoEllipsis = True
        Me.email_contact1.Location = New System.Drawing.Point(8, 23)
        Me.email_contact1.Name = "email_contact1"
        Me.email_contact1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.email_contact1.Size = New System.Drawing.Size(316, 26)
        Me.email_contact1.TabIndex = 0
        Me.email_contact1.TabStop = True
        Me.email_contact1.Text = "Bugs reports, errors and/or technical stuffs"
        '
        'GUI_about
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 361)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.Label_version)
        Me.Controls.Add(Me.LinkLabel_mail)
        Me.Controls.Add(Me.copy)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GUI_about"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        Me.pic.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl.ResumeLayout(False)
        Me.TabPage_about.ResumeLayout(False)
        Me.TabPage_contact.ResumeLayout(False)
        Me.TabPage_contact.PerformLayout()
        CType(Me.PictureBox_paypal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_Additional.ResumeLayout(False)
        Me.TabPage_email.ResumeLayout(False)
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
    Private Sub email_contacts_Clicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles email_contact1.LinkClicked, email_contact2.LinkClicked, email_contact3.LinkClicked, email_contact4.LinkClicked, email_contact5.LinkClicked
        Try
            System.Diagnostics.Process.Start("mailto:SPE.support@gmail.com?subject=" & sender.Text)
        Catch ex As Exception
            MessageBox.Show("Unable to open the link that was clicked.")
        End Try
    End Sub
    Private Sub email_contact6_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles email_contact6.LinkClicked
        Try
            System.Diagnostics.Process.Start("mailto:lior_banai@eng-alum.tau.ac.il")
        Catch ex As Exception
            MessageBox.Show("Unable to open the link that was clicked.")
        End Try
    End Sub
    Private Sub PictureBox_quickreward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            System.Diagnostics.Process.Start("http://quickrewardsnetwork.com/?r=!F94VXV35D5MM0")
        Catch ex As Exception
            MessageBox.Show("Unable to open the link that was clicked.")
        End Try
    End Sub

    Private Sub GUI_about_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'GUI_set()
        Label_version.Text = System.String.Format("Version {0}.{1}.{2}", My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.MinorRevision)
    End Sub

    Private Sub PictureBox_cashbag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            System.Diagnostics.Process.Start("http://www.cashbag.co.uk/register.php?user_id=52279")
        Catch ex As Exception
            MessageBox.Show("Unable to open the link that was clicked.")
        End Try
    End Sub

    Private Sub PictureBox_adbrite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            System.Diagnostics.Process.Start("http://www.adbrite.com/mb/landing_both.php?spid=24222&afb=120x60-1-blue")
        Catch ex As Exception
            MessageBox.Show("Unable to open the link that was clicked.")
        End Try
    End Sub

    Private Sub PictureBox_bidvertiser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            System.Diagnostics.Process.Start("http://www.bidvertiser.com/bdv/bidvertiser/bdv_ref.dbm?Ref_Option=pub&Ref_PID=38608")
        Catch ex As Exception
            MessageBox.Show("Unable to open the link that was clicked.")
        End Try
    End Sub

    Private Sub PictureBox_paypal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox_paypal.Click
        Try
            System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_xclick&business=lior_banai%40eng%2dalum%2etau%2eac%2eil&item_name=Deflection%20Evaluator%20Support&no_shipping=0&no_note=1&tax=0&currency_code=USD&bn=PP%2dDonationsBF&charset=UTF%2d8")
        Catch ex As Exception
            MessageBox.Show("Unable to open link that was clicked.")
        End Try
    End Sub
End Class
