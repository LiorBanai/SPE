Imports System.ComponentModel

<DefaultEvent("Click")> _
Public Class PopupNotifier
    Inherits Component

    Event Click()
    Event Close()


    Private WithEvents fPopup As New PopupNotifierForm(Me)
    Private WithEvents tmAnimation As New Timer
    Public WithEvents tmWait As New Timer

    Private bAppearing As Boolean = True
    Public bShouldRemainVisible As Boolean = False

#Region "Properties"

    Private clHeader As Color = SystemColors.ControlDark
    <Category("Header"), _
    DefaultValue(GetType(Color), "ControlDark")> _
    Property HeaderColor() As Color
        Get
            Return clHeader
        End Get
        Set(ByVal value As Color)
            clHeader = value

        End Set
    End Property

    Private clBody As Color = SystemColors.Control
    <Category("Appearance"), _
    DefaultValue(GetType(Color), "Control")> _
    Property BodyColor() As Color
        Get
            Return clBody
        End Get
        Set(ByVal value As Color)
            clBody = value

        End Set
    End Property

    Private clTitle As Color = Color.Gray
    <Category("Title"), _
    DefaultValue(GetType(Color), "Gray")> _
    Property TitleColor() As Color
        Get
            Return clTitle
        End Get
        Set(ByVal value As Color)
            clTitle = value

        End Set
    End Property

    Private clBase As Color = SystemColors.ControlText
    <Category("Content"), _
    DefaultValue(GetType(Color), "ControlText")> _
    Property ContentColor() As Color
        Get
            Return clBase
        End Get
        Set(ByVal value As Color)
            clBase = value

        End Set
    End Property

    Private clBorder As Color = SystemColors.WindowFrame
    <Category("Appearance"), _
    DefaultValue(GetType(Color), "WindowFrame")> _
    Property BorderColor() As Color
        Get
            Return clBorder
        End Get
        Set(ByVal value As Color)
            clBorder = value

        End Set
    End Property

    Private clCloseBorder As Color = SystemColors.WindowFrame
    <Category("Buttons"), _
    DefaultValue(GetType(Color), "WindowFrame")> _
    Property ButtonBorderColor() As Color
        Get
            Return clCloseBorder
        End Get
        Set(ByVal value As Color)
            clCloseBorder = value

        End Set
    End Property

    Private clCloseHover As Color = SystemColors.Highlight
    <Category("Buttons"), _
    DefaultValue(GetType(Color), "Highlight")> _
    Property ButtonHoverColor() As Color
        Get
            Return clCloseHover
        End Get
        Set(ByVal value As Color)
            clCloseHover = value

        End Set
    End Property

    Private clLinkHover As Color = SystemColors.HotTrack
    <Category("Appearance"), _
    DefaultValue(GetType(Color), "HotTrack")> _
    Property LinkHoverColor() As Color
        Get
            Return clLinkHover
        End Get
        Set(ByVal value As Color)
            clLinkHover = value

        End Set
    End Property

    Private iDiffGradient As Integer = 50
    <Category("Appearance"), _
    DefaultValue(50)> _
    Property GradientPower() As Integer
        Get
            Return iDiffGradient
        End Get
        Set(ByVal value As Integer)
            iDiffGradient = value

        End Set
    End Property

    Private ftBase As Font = SystemFonts.DialogFont
    <Category("Content")> _
    Property ContentFont() As Font
        Get
            Return ftBase
        End Get
        Set(ByVal value As Font)
            ftBase = value
        End Set
    End Property

    Private ftTitle As Font = SystemFonts.CaptionFont
    <Category("Title")> _
    Property TitleFont() As Font
        Get
            Return ftTitle
        End Get
        Set(ByVal value As Font)
            ftTitle = value

        End Set
    End Property

    Private ptImagePosition As Point = New Point(12, 21)
    <Category("Image")> _
    Property ImagePosition() As Point
        Get
            Return ptImagePosition
        End Get
        Set(ByVal value As Point)
            ptImagePosition = value

        End Set
    End Property

    Private szImageSize As Size = New Size(0, 0)
    <Category("Image")> _
    Property ImageSize() As Size
        Get
            If szImageSize.Width = 0 Then
                If Not Image Is Nothing Then
                    Return Image.Size
                Else
                    Return New Size(32, 32)
                End If
            Else
                Return szImageSize
            End If
        End Get
        Set(ByVal value As Size)
            szImageSize = value

        End Set
    End Property

    Private imImage As Image = Nothing
    <Category("Image")> _
    Property Image() As Image
        Get
            Return imImage
        End Get
        Set(ByVal value As Image)
            imImage = value

        End Set
    End Property

    Private bShowGrip As Boolean = True
    <Category("Header"), _
    DefaultValue(True)> _
    Property ShowGrip() As Boolean
        Get
            Return bShowGrip
        End Get
        Set(ByVal value As Boolean)
            bShowGrip = value

        End Set
    End Property

    Private sText As String
    <Category("Content")> _
    Property ContentText() As String
        Get
            Return sText
        End Get
        Set(ByVal value As String)
            sText = value

        End Set
    End Property

    Private sTitle As String
    <Category("Title")> _
    Property TitleText() As String
        Get
            Return sTitle
        End Get
        Set(ByVal value As String)
            sTitle = value

        End Set
    End Property

    Private pdTextPadding As Padding = New Padding(0)
    <Category("Appearance")> _
    Property TextPadding() As Padding
        Get
            Return pdTextPadding
        End Get
        Set(ByVal value As Padding)
            pdTextPadding = value

        End Set
    End Property

    Private iHeaderHeight As Integer = 9
    <Category("Header"), _
    DefaultValue(9)> _
    Property HeaderHeight() As Integer
        Get
            Return iHeaderHeight
        End Get
        Set(ByVal value As Integer)
            iHeaderHeight = value

        End Set
    End Property

    Private bCloseButtonVisible As Boolean = True
    <Category("Buttons"), _
    DefaultValue(True)> _
    Property CloseButton() As Boolean
        Get
            Return bCloseButtonVisible
        End Get
        Set(ByVal value As Boolean)
            bCloseButtonVisible = value

        End Set
    End Property

    Private bOptionsButtonVisible As Boolean = False
    <Category("Buttons"), _
    DefaultValue(False)> _
    Property OptionsButton() As Boolean
        Get
            Return bOptionsButtonVisible
        End Get
        Set(ByVal value As Boolean)
            bOptionsButtonVisible = value

        End Set
    End Property

    Private WithEvents ctContextMenu As ContextMenuStrip = Nothing
    <Category("Behavior")> _
    Property OptionsMenu() As ContextMenuStrip
        Get
            Return ctContextMenu
        End Get
        Set(ByVal value As ContextMenuStrip)
            ctContextMenu = value
        End Set
    End Property

    Private iShowDelay As Integer = 3000
    <Category("Behavior"), _
    DefaultValue(3000)> _
    Property ShowDelay() As Integer
        Get
            Return iShowDelay
        End Get
        Set(ByVal value As Integer)
            iShowDelay = value
        End Set
    End Property

    Private szSize As Size = New Size(400, 100)
    <Category("Appearance")> _
    Property Size() As Size
        Get
            Return szSize
        End Get
        Set(ByVal value As Size)
            szSize = value
        End Set
    End Property

#End Region

    Sub New()
        With fPopup
            .TopMost = True
            .FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            .StartPosition = System.Windows.Forms.FormStartPosition.Manual
            .FormBorderStyle = Windows.Forms.FormBorderStyle.None
        End With
        tmAnimation.Interval = 1
    End Sub

    Sub Popup()
        tmWait.Interval = ShowDelay
        fPopup.Size = Size
        fPopup.Opacity = 0
        fPopup.Location = New Point(Screen.PrimaryScreen.WorkingArea.Right - fPopup.Size.Width - 1, Screen.PrimaryScreen.WorkingArea.Bottom)
        fPopup.Show()
        fPopup.ShowInTaskbar = False
        tmAnimation.Start()
    End Sub

    Private bMouseIsOn As Boolean = False

    Private Sub fPopup_CloseClick() Handles fPopup.CloseClick
        RaiseEvent Close()
    End Sub

    Private Sub fPopup_LinkClick() Handles fPopup.LinkClick
        RaiseEvent Click()
    End Sub

    Private Function GetOpacityBasedOnPosition() As Double
        Dim iCentPourcent As Integer = fPopup.Height
        Dim iCurrentlyShown As Integer = Screen.PrimaryScreen.WorkingArea.Height - fPopup.Top
        Dim dPourcentOpacity As Double = iCentPourcent / 100 * iCurrentlyShown
        Return (dPourcentOpacity / 100) - 0.05
    End Function

    Private iMaxPosition As Integer
    Private dMaxOpacity As Double

    Private Sub tmAnimation_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmAnimation.Tick
        If bAppearing Then
            fPopup.Top -= 2
            fPopup.Opacity = GetOpacityBasedOnPosition()
            If fPopup.Top + fPopup.Height < Screen.PrimaryScreen.WorkingArea.Bottom Then
                tmAnimation.Stop()
                bAppearing = False
                iMaxPosition = fPopup.Top
                dMaxOpacity = fPopup.Opacity
                tmWait.Start()
            End If
        Else
            If bMouseIsOn Then
                fPopup.Top = iMaxPosition
                fPopup.Opacity = dMaxOpacity
                tmAnimation.Stop()
                tmWait.Start()
            Else
                fPopup.Top += 2
                fPopup.Opacity = GetOpacityBasedOnPosition()
                If fPopup.Top > Screen.PrimaryScreen.WorkingArea.Bottom Then
                    tmAnimation.Stop()
                    fPopup.Hide()
                    bAppearing = True
                End If
            End If
        End If
    End Sub

    Private Sub tmWait_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmWait.Tick
        tmWait.Stop()
        tmAnimation.Start()
    End Sub

    Private Sub fPopup_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles fPopup.MouseEnter
        bMouseIsOn = True
    End Sub

    Private Sub fPopup_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles fPopup.MouseLeave
        If Not bShouldRemainVisible Then
            bMouseIsOn = False
        End If
    End Sub

    Private Sub ctContextMenu_Closed(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripDropDownClosedEventArgs) Handles ctContextMenu.Closed
        bShouldRemainVisible = False
        bMouseIsOn = False
        tmAnimation.Start()
    End Sub

    Private Sub PopupNotifier_Close() Handles Me.Close
        fPopup.Hide()
    End Sub
    Private Sub PopupNotifier_click() Handles Me.Click
        Select Case Me.ContentText
            Case " "

        End Select
    End Sub
End Class
