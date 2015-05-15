Imports System.IO
Imports iTextSharp.text.pdf
Imports System.Text.RegularExpressions

Public Class Form1
    Dim age As Integer

#Region "Validation"
    Private Sub tb_name_Leave(sender As Object, e As EventArgs) Handles tb_name.Leave
        If Not Regex.Match(tb_name.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success Or tb_name.Text = "" Then
            MsgBox("Please enter only alphabetic characters.", vbOKOnly Or vbCritical, "Incorrect name")
            tb_name.Focus()
            tb_name.SelectAll()
        End If
    End Sub

    Private Sub tb_playerID_Leave(sender As Object, e As EventArgs) Handles tb_playerID.Leave
        If Strings.Len(tb_playerID.Text) <> 7 Then
            MsgBox("Incorrect Player ID entered." & vbNewLine & "Please correct your Player ID.", vbOKOnly Or vbCritical, "Incorrect Player ID")
            tb_playerID.Focus()
            tb_playerID.SelectAll()
        End If
    End Sub

    Private Sub dtp_dateOfBirth_Leave(sender As Object, e As EventArgs) Handles dtp_dateOfBirth.Leave
        age = Date.Today.Year - dtp_dateOfBirth.Value.Year
        If age < 5 Then
            MsgBox("Please check your date of birth.", vbOKOnly Or vbCritical, "Incorrect player age")
        End If
    End Sub
#End Region
End Class
