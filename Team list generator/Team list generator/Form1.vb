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

    Private Sub btn_createForm_Click(sender As Object, e As EventArgs) Handles btn_createForm.Click
        If tb_name.Text = "" OrElse tb_playerID.Text = "" OrElse dtp_dateOfBirth.Value.Date = Date.Today Then
            MsgBox("Form input not complete." & vbNewLine & "Please fill in the needed text boxes.", vbOKOnly Or vbCritical, "Incomplete form entry")
            Exit Sub
        End If

        Dim svd_saveFile As New SaveFileDialog
        With svd_saveFile
            .Title = "Save completed form"
            .DefaultExt = ".pdf"
            .Filter = "PDF files|*.pdf|All files|*.*"
        End With

        svd_saveFile.ShowDialog()

        If svd_saveFile.FileName = "" Then
            Exit Sub
        End If

        Dim pdfTemplate = My.Resources._2014_VG_XY_Team_List___Editable_Form
        Dim newFile As String = svd_saveFile.FileName

        Dim pdfReader As New PdfReader(pdfTemplate)
        Dim pdfStamper As New PdfStamper(pdfReader, New FileStream(newFile, FileMode.Create))
        Dim pdfFormFields As AcroFields = pdfStamper.AcroFields

        pdfFormFields.SetField("Name", tb_name.Text)
        pdfFormFields.SetField("Player ID", tb_playerID.Text)
        pdfFormFields.SetField("Event Name", tb_eventName.Text)
        pdfFormFields.SetField("Age Division", If(age <= 11, "Junior", If(age <= 15, "Senior", "Master")))
        pdfFormFields.SetField("DOB", dtp_dateOfBirth.Value.Date)

        pdfStamper.FormFlattening = False

        pdfStamper.Close()
    End Sub
End Class
