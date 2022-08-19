Imports System.ComponentModel
Imports System.Drawing.Drawing2D

<System.ComponentModel.DefaultPropertyAttribute("Content"), _
System.ComponentModel.DesignTimeVisible(False)> _
Public Class PopupNotifierForm
    Inherits System.Windows.Forms.Form

    Sub New(ByVal Parent As PopupNotifier)
        pnParent = Parent
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        Me.SetStyle(ControlStyles.ResizeRedraw, True)
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'PopupNotifierForm
        '
        Me.ClientSize = New System.Drawing.Size(392, 66)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PopupNotifierForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Private bMouseOnClose As Boolean = False
    Private bMouseOnLink As Boolean = False
    Private bMouseOnOptions As Boolean = False
    Private iHeightOfTitle As Integer

    Public Event LinkClick()

    Public Event CloseClick()



#Region "Properties"

    Private pnParent As PopupNotifier
    Shadows Property Parent() As PopupNotifier
        Get
            Return pnParent
        End Get
        Set(ByVal value As PopupNotifier)
            pnParent = value
        End Set
    End Property

#End Region

#Region "Functions & Private properties"
    Private Function AddValueMax255(ByVal Input As Integer, ByVal Add As Integer) As Integer
        If Input + Add < 256 Then
            Return Input + Add
        Else
            Return 255
        End If
    End Function

    Private Function DedValueMin0(ByVal Input As Integer, ByVal Ded As Integer) As Integer
        If Input - Ded > 0 Then
            Return Input - Ded
        Else
            Return 0
        End If
    End Function

    Private Function GetDarkerColor(ByVal Color As Color) As Color
        Dim clNew As Color
        clNew = Drawing.Color.FromArgb(255, DedValueMin0(CInt(Color.R), Parent.GradientPower), DedValueMin0(CInt(Color.G), Parent.GradientPower), DedValueMin0(CInt(Color.B), Parent.GradientPower))
        Return clNew
    End Function

    Private Function GetLighterColor(ByVal Color As Color) As Color
        Dim clNew As Color
        clNew = Drawing.Color.FromArgb(255, AddValueMax255(CInt(Color.R), Parent.GradientPower), AddValueMax255(CInt(Color.G), Parent.GradientPower), AddValueMax255(CInt(Color.B), Parent.GradientPower))
        Return clNew
    End Function

    Private Function GetLighterTransparentColor(ByVal Color As Color) As Color
        Dim clNew As Color
        clNew = Drawing.Color.FromArgb(0, AddValueMax255(CInt(Color.R), Parent.GradientPower), AddValueMax255(CInt(Color.G), Parent.GradientPower), AddValueMax255(CInt(Color.B), Parent.GradientPower))
        Return clNew
    End Function

    Private ReadOnly Property RectText() As RectangleF
        Get
            If Not Parent.Image Is Nothing Then
                Return New RectangleF(Parent.ImagePosition.X + Parent.ImageSize.Width + Parent.TextPadding.Left, Parent.TextPadding.Top + Parent.TextPadding.Top + iHeightOfTitle + Parent.HeaderHeight, Me.Width - Parent.ImageSize.Width - Parent.ImagePosition.X - 16 - 5 - Parent.TextPadding.Left - Parent.TextPadding.Right, Me.Height - Parent.HeaderHeight - Parent.TextPadding.Top - Parent.TextPadding.Top - Parent.TextPadding.Bottom - iHeightOfTitle - 1)
            Else
                Return New RectangleF(Parent.TextPadding.Left, Parent.TextPadding.Top + Parent.TextPadding.Top + iHeightOfTitle + Parent.HeaderHeight, Me.Width - 16 - 5 - Parent.TextPadding.Left - Parent.TextPadding.Right, Me.Height - Parent.HeaderHeight - Parent.TextPadding.Top - Parent.TextPadding.Top - Parent.TextPadding.Bottom - iHeightOfTitle - 1)
            End If
        End Get
    End Property

    Private ReadOnly Property RectClose() As Rectangle
        Get
            Return New Rectangle(Me.Width - 5 - 16, 12, 16, 16)
        End Get
    End Property

    Private ReadOnly Property RectOptions() As Rectangle
        Get
            Return New Rectangle(Me.Width - 5 - 16, 12 + 16 + 5, 16, 16)
        End Get
    End Property

#End Region

#Region "Events"

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If Parent.CloseButton Then
            If RectClose.Contains(e.X, e.Y) Then
                bMouseOnClose = True
            Else
                bMouseOnClose = False
            End If
        End If
        If Parent.OptionsButton Then
            If RectOptions.Contains(e.X, e.Y) Then
                bMouseOnOptions = True
            Else
                bMouseOnOptions = False
            End If
        End If
        If RectText.Contains(e.X, e.Y) Then
            bMouseOnLink = True
        Else
            bMouseOnLink = False
        End If
        Invalidate()
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        If RectClose.Contains(e.X, e.Y) Then
            RaiseEvent CloseClick()
        End If
        If RectText.Contains(e.X, e.Y) Then
            RaiseEvent LinkClick()
        End If
        If RectOptions.Contains(e.X, e.Y) Then
            If Not Parent.OptionsMenu Is Nothing Then
                Parent.OptionsMenu.Show(Me, New Point(RectOptions.Right - Parent.OptionsMenu.Width, RectOptions.Bottom))
                Parent.bShouldRemainVisible = True
            End If
        End If
    End Sub

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim rcBody As New Rectangle(0, 0, Me.Width, Me.Height)
        Dim rcHeader As New Rectangle(0, 0, Me.Width, Parent.HeaderHeight)
        Dim rcForm As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim brBody As New LinearGradientBrush(rcBody, Parent.BodyColor, GetLighterColor(Parent.BodyColor), LinearGradientMode.Vertical)

        Dim brHeader As New LinearGradientBrush(rcHeader, Parent.HeaderColor, GetDarkerColor(Parent.HeaderColor), LinearGradientMode.Vertical)
        With e.Graphics
            .FillRectangle(brBody, rcBody)
            .FillRectangle(brHeader, rcHeader)
            .DrawRectangle(New Pen(Parent.BorderColor), rcForm)
            If Parent.ShowGrip Then .DrawImage(Global.My.Resources.grip, CInt((Me.Width - Global.My.Resources.grip.Width) / 2), CInt((Parent.HeaderHeight - 3) / 2))
            If Parent.CloseButton Then
                If bMouseOnClose Then
                    .FillRectangle(New SolidBrush(Parent.ButtonHoverColor), RectClose)
                    .DrawRectangle(New Pen(Parent.ButtonBorderColor), RectClose)
                End If
                .DrawLine(New Pen(Parent.ContentColor, 2), RectClose.Left + 4, RectClose.Top + 4, RectClose.Right - 4, RectClose.Bottom - 4)
                .DrawLine(New Pen(Parent.ContentColor, 2), RectClose.Left + 4, RectClose.Bottom - 4, RectClose.Right - 4, RectClose.Top + 4)
            End If
            If Parent.OptionsButton Then
                If bMouseOnOptions Then
                    .FillRectangle(New SolidBrush(Parent.ButtonHoverColor), RectOptions)
                    .DrawRectangle(New Pen(Parent.ButtonBorderColor), RectOptions)
                End If
                .FillPolygon(New SolidBrush(ForeColor), New Point() {New Point(RectOptions.Left + 4, RectOptions.Top + 6), New Point(RectOptions.Left + 12, RectOptions.Top + 6), New Point(RectOptions.Left + 8, RectOptions.Top + 4 + 6)})
            End If
            If Not Parent.Image Is Nothing Then
                .DrawImage(Parent.Image, Parent.ImagePosition.X, Parent.ImagePosition.Y, Parent.ImageSize.Width, Parent.ImageSize.Height)
            End If
            iHeightOfTitle = .MeasureString("A", Parent.TitleFont).Height
            Dim iTitleOrigin As Integer
            If Not Parent.Image Is Nothing Then
                iTitleOrigin = Parent.ImagePosition.X + Parent.ImageSize.Width + Parent.TextPadding.Left
            Else
                iTitleOrigin = Parent.TextPadding.Left
            End If
            If bMouseOnLink Then
                Me.Cursor = Cursors.Hand
                .DrawString(Parent.ContentText, Parent.ContentFont, New SolidBrush(Parent.LinkHoverColor), RectText)
            Else
                Me.Cursor = Cursors.Default
                .DrawString(Parent.ContentText, Parent.ContentFont, New SolidBrush(Parent.ContentColor), RectText)
            End If
            .DrawString(Parent.TitleText, Parent.TitleFont, New SolidBrush(Parent.TitleColor), iTitleOrigin, Parent.TextPadding.Top + Parent.HeaderHeight)

        End With
    End Sub
#End Region

End Class
