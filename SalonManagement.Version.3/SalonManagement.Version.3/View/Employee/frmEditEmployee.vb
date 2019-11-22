Public Class frmEditEmployee
    Public employee As Employee

    Private post As New Position
    Private emp As New Employee

    Private msg As String = ""
    Dim gender As String = "Male"



    Private Sub frmEditEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        post.LoadPositionToCBO(cboPosition)

        With employee
            txtLName.Text = .EmployeeLN
            txtFName.Text = .EmployeeFN
            txtMName.Text = .EmployeeMN
            dtpDob.Value = .EmployeeBirthDate
            If .EmployeeGender = "Male" Then
                rdbMale.Checked = True
            ElseIf .EmployeeGender = "Female" Then
                rdbFemale.Checked = True
            End If
            txtCN.Text = .EmployeeCN
            txtPasscode.Text = .EmployeePasscode

            PictureImage.BackgroundImage = .Base64ToImage(.EmployeePicture)

            cboPosition.Text = .EmployeePosition

        End With
    End Sub

    ''---------Uploading Picture---------
    Public Function ConvertToBytes(img As PictureBox) As Byte()
        Try
            Dim msPic As New IO.MemoryStream
            img.BackgroundImage.Save(msPic, System.Drawing.Imaging.ImageFormat.Bmp)
            Dim Mybyte() As Byte = msPic.GetBuffer
            msPic.Close()
            Return Mybyte
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Private Function ResizeImage(ByVal PhotoFile As Image) As Image
        Return New Bitmap(PhotoFile, New Size(PictureImage.Width, PictureImage.Height))
    End Function
    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Try
            Dim ofd As New OpenFileDialog
            ofd.Title = "Choose a photo"
            ofd.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            ofd.Filter = "Picture Files(*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            ofd.FilterIndex = 2
            ofd.RestoreDirectory = False

            If ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                If ofd.CheckFileExists = False Or ofd.CheckPathExists = False Then
                    MessageBox.Show("The File Does Not Exist.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = DialogResult.OK
                    Me.Close()

                Else
                    Dim PhotoFile As New IO.FileInfo(ofd.FileName)
                    If PhotoFile.Length <= 3500000 Then
                        Dim EmployeePhoto As New Bitmap(ofd.FileName)
                        PictureImage.BackgroundImageLayout = ImageLayout.Stretch
                        PictureImage.BackgroundImage = ResizeImage(EmployeePhoto)
                    Else
                        MessageBox.Show("File Size Too Large", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    ''---------Validation---------
    Private Function ValidateRequired() As Boolean
        If IsTextBoxEmpty(txtLName, txtFName, txtCN, txtPasscode) = True Or PictureImage.BackgroundImage Is PictureNoImage.BackgroundImage = True Then
            msg = "Picture And Fields with asterisk symbol are required."
            Return False
        Else
            msg = ""
            Return True
        End If
    End Function
    Private Function ValidateAge() As Boolean
        If employee.GetCurrentAge(dtpDob.Value.Date, FrmMain.dtServer.Date) < 18 Then
            msg = "You are less than 18 years old"
            Return True
        Else
            msg = ""
            Return False
        End If
    End Function
    Private Function PasscodeLimit() As Boolean
        If txtPasscode.MaxLength <= 8 Then
            msg = "Passcode must be 8 characters or more"
            Return True
        Else
            msg = ""
            Return False
        End If
    End Function


    Private Sub doEdit()
        If ValidateRequired() = True Then
            If ValidateAge() = False Then
                If PasscodeLimit() = True Then
                    With employee
                        .EmployeeFN = txtFName.Text.Trim
                        .EmployeeLN = txtLName.Text.Trim
                        .EmployeeMN = txtMName.Text.Trim

                        .EmployeeBirthDate = dtpDob.Value.Date
                        .EmployeeGender = gender

                        .EmployeeCN = txtCN.Text.Trim
                        .EmployeePosition = cboPosition.Text.Trim
                        .EmployeePasscode = txtPasscode.Text.Trim

                        .EmployeePicture = .ConvertImageTo64(PictureImage.BackgroundImage)
                        .EmployeeStatus = 0

                        If .EditEmployee() = True Then
                            Dim ok As New OKMessage
                            ok = New OKMessage
                            ok.lblMsg.Text = "Employee has been update."
                            ok.ShowDialog()
                            Me.Close()

                        Else
                            Dim err As ErrorMessage
                            err = New ErrorMessage
                            err.lblMsg.Text = "Failed to update Employee."
                            err.ShowDialog()
                        End If
                    End With
                End If
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        doEdit()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtLName_TextChanged(sender As Object, e As EventArgs) Handles txtLName.TextChanged
        AllowedOnly(LetterOnly, txtLName)
        txtLName.MaxLength = 20
    End Sub

    Private Sub txtFName_TextChanged(sender As Object, e As EventArgs) Handles txtFName.TextChanged
        AllowedOnly(LetterOnly, txtFName)
        txtFName.MaxLength = 20
    End Sub

    Private Sub txtMName_TextChanged(sender As Object, e As EventArgs) Handles txtMName.TextChanged
        AllowedOnly(LetterWDot, txtMName)
        txtMName.MaxLength = 20
    End Sub

    Private Sub txtCN_TextChanged(sender As Object, e As EventArgs) Handles txtCN.TextChanged
        ContactNo(txtCN)
        PhoneFormat(txtCN)
        txtCN.MaxLength = 13
        AllowedOnly(NumberWDash, txtCN)
    End Sub

    Private Sub txtPasscode_TextChanged(sender As Object, e As EventArgs) Handles txtPasscode.TextChanged
        AllowedOnly(ForUserPass, txtPasscode)
        txtPasscode.MaxLength = 30
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim obj As New frmSearchEmployee
        obj.ShowDialog()
    End Sub

    Private Sub dtpDob_ValueChanged(sender As Object, e As EventArgs) Handles dtpDob.ValueChanged
        txtAge.Text = emp.GetCurrentAge(dtpDob.Value, FrmMain.dtServer)
    End Sub

    Private Sub cboPosition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPosition.SelectedIndexChanged
        With post
            .LoadPositionCboTextBox(cboPosition, txtStandardPay, txtOT, txtBasicPays)
        End With
    End Sub

    Private Sub PictureShowPasword_Click(sender As Object, e As EventArgs) Handles PictureShowPasword.Click
        If txtPasscode.UseSystemPasswordChar = True Then
            txtPasscode.UseSystemPasswordChar = False
        Else
            txtPasscode.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

End Class