Namespace My

    ' The following events are availble for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication

        Private Sub MyApplication_UnhandledException(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
            Dim msg_style As MsgBoxStyle = MsgBoxStyle.Critical
            Dim msg_text As String = "The following message has been copied to the clipboard" & vbCr & vbCr & "Please report this back to the developer." & vbCr & _
            vbCr & "****************************" & vbCr & "The exception message is:" & vbCr & e.Exception.Message & _
            vbCr & "The exception StackTrace is:" & vbCr & e.Exception.StackTrace & _
            vbCr & "****************************" & vbCr & e.Exception.ToString

            MessageBox.Show("The following message has been copied to the clipboard" & vbCr & vbCr & "Please report this back to the developer." & vbCr & _
            vbCr & "****************************" & vbCr & "The exception message is:" & vbCr & e.Exception.Message & _
            vbCr & "The exception StackTrace is:" & vbCr & e.Exception.StackTrace & _
            vbCr & "****************************" & vbCr & e.Exception.ToString, "Exception Occured")

            My.Computer.Clipboard.SetText("The following message has been copied to the clipboard" & vbCr & "Please report this back to the developer." & _
            vbCr & "The exception message is:" & vbCr & e.Exception.Message & _
            vbCr & "The exception StackTrace is:" & vbCr & e.Exception.StackTrace & _
            vbCr & "****************************" & vbCr & e.Exception.ToString)
            e.ExitApplication = False
        End Sub
    End Class

End Namespace

