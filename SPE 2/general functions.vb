Public Class general_functions
    '******* POPUP Definitions *********
    Public Shared Function check_data(ByVal number As String) As Boolean
        If (IsNumeric(number) = True) AndAlso (number > 0) Then
            check_data = True
        Else
            check_data = False
        End If
        Return check_data
    End Function
    ' If the TextBox doesn’t contain an integer between min_value and max_value,
    ' display an error message, set focus to the TextBox, and return False.
    ' Otherwise return True and return the integer through the ByRef
    ' parameter result.
    Private Function IsValidInteger(ByRef result As Integer, _
    ByVal txt As TextBox, ByVal field_name As String, _
    Optional ByVal min_value As Integer = Integer.MinValue, _
    Optional ByVal max_value As Integer = Integer.MaxValue) As Boolean
        ' Check for blank entry.
        Dim num_items_txt As String = txt.Text
        If num_items_txt.Length < 1 Then
            MessageBox.Show("Please enter " & field_name & ".")
            txt.Focus()
            Return False
        End If
        ' See if it’s numeric.
        If Not IsNumeric(num_items_txt) Then
            MessageBox.Show(field_name & " must be a number.")
            txt.Select(0, num_items_txt.Length)
            txt.Focus()
            Return False
        End If
        ' Assign the value.
        Try
            result = Integer.Parse(txt.Text)
        Catch ex As Exception
            MessageBox.Show("Error in " & field_name & "." & _
            vbCrLf & ex.Message)
            txt.Select(0, num_items_txt.Length)
            txt.Focus()
            Return False
        End Try
        ' Check that the value is between min_value and max_value.
        If result < min_value Or result > max_value Then
            MessageBox.Show(field_name & " must be between " & _
            min_value.ToString & " and " & max_value.ToString & ".")
            txt.Select(0, num_items_txt.Length)
            txt.Focus()
            Return False
        End If
        ' The value is okay.
        Return True
    End Function
End Class

