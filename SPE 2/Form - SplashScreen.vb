Public NotInheritable Class GUI_SplashScreen

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).

    Dim time_set As Byte = 2
    Dim first_run As Boolean = False
    Dim GUI_Launcher As New GUI_Launcher
    Dim first_run_gui As New GUI_first_run
   
    Private Sub GUI_SplashScreen_load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Set up the dialog text at runtime according to the application's assembly information.  'TODO: Customize the application's assembly information in the "Application" pane of the project properties dialog (under the "Project" menu) Application title
        'Format the version information using the text set into the Version control at design time as the
        '  formatting string.  This allows for effective localization if desired.
        '  Build and revision information could be included by using the following code and changing the 
        '  Version control's designtime text to "Version {0}.{1:00}.{2}.{3}" or something similar.  See
        '  String.Format() in Help for more information.
        Dim format_str As String = "Version {0}.{1}.{2}"
        Label_version.Text = System.String.Format(format_str, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.MinorRevision)

        'Copyright info
        'Copyright.Text = My.Application.Info.Copyright
        If ((My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Stiffened Plates Evaluator", "First run", Nothing) Is Nothing)) Or Not (My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Stiffened Plates Evaluator", "First run", Nothing) = "false") Then
            first_run = True
        Else
            first_run = False
        End If
    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        Timer.Interval = 1000
        If Timer.Tag = time_set Then
            Label_time.Text = "Loading in " & CStr(time_set - Timer.Tag) & " seconds"
            If Not first_run Then
                GUI_Launcher.Show()
                Me.Close()
            Else
                first_run_gui.Show()
                Me.Close()
            End If
        Else
            Label_time.Text = "Loading in " & CStr(time_set - Timer.Tag) & " seconds"
            Timer.Tag += 1
        End If
    End Sub

    Private Sub MainLayoutPanel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MainLayoutPanel.Click
        Timer.Enabled = False
        If first_run = False Then
            GUI_Launcher.Show()
            Me.Close()
        Else
            first_run_gui.Show()
            Me.Close()
        End If
    End Sub
End Class
