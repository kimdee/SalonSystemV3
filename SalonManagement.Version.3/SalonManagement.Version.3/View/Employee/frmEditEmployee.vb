Public Class frmEditEmployee
    Public employee As Employee

    Private position As New Position
    Private emp As New Employee

    Private msg As String = ""
    Dim gender As String = "Male"



    Private Sub frmEditEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            position.LoadPositionToCBO(cboPosition)
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

                cboPosition.SelectedIndex = cboPosition.FindString(.EmployeePosition)

                txtCN.Text = .EmployeeCN
                txtPasscode.Text = .EmployeePasscode

                PictureImage.BackgroundImage = .Base64ToImage(.EmployeePicture)
            End With
        Catch ex As Exception

        End Try
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
        If IsTextBoxEmpty(txtLName, txtFName, txtCN, txtPasscode) = True Then
            msg = "Fields with asterisk symbol are required."
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If ValidateRequired() = True Then
                '    If ValidateAge() = False Then
                With employee
                    .EmployeeLN = txtLName.Text
                    .EmployeeFN = txtFName.Text
                    .EmployeeMN = txtMName.Text

                    .EmployeeBirthDate = dtpDob.Value.ToString("d")

                    If rdbMale.Checked = True Then
                        .EmployeeGender = "Male"
                    ElseIf rdbFemale.Checked = True Then
                        .EmployeeGender = "Female"
                    End If


                    .EmployeeCN = txtCN.Text
                    .EmployeePosition = cboPosition.Text
                    .EmployeePasscode = txtPasscode.Text

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
                '    End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub picboxAddPosition_Click(sender As Object, e As EventArgs) Handles picboxAddPosition.Click
        Dim obj As New frmAddPosition
        If obj.ShowDialog = DialogResult.OK Then
            position.LoadPositionToCBO(cboPosition)
        End If
    End Sub

    Private Sub txtLName_TextChanged(sender As Object, e As EventArgs) Handles txtLName.TextChanged
        AllowedOnly(LetterOnly, txtLName)
        txtLName.MaxLength = 15
        SentenceCase(txtLName)
    End Sub

    Private Sub txtFName_TextChanged(sender As Object, e As EventArgs) Handles txtFName.TextChanged
        AllowedOnly(LetterOnly, txtFName)
        txtFName.MaxLength = 15
        SentenceCase(txtFName)
    End Sub

    Private Sub txtMName_TextChanged(sender As Object, e As EventArgs) Handles txtMName.TextChanged
        AllowedOnly(LetterWDot, txtMName)
        txtMName.MaxLength = 15
        SentenceCase(txtMName)
    End Sub

    Private Sub txtCN_TextChanged(sender As Object, e As EventArgs) Handles txtCN.TextChanged
        ContactNo(txtCN)
        PhoneFormat(txtCN)
        txtCN.MaxLength = 13
        AllowedOnly(NumberWDash, txtCN)
    End Sub

    Private Sub txtPasscode_TextChanged(sender As Object, e As EventArgs) Handles txtPasscode.TextChanged
        AllowedOnly(ForUserPass, txtPasscode)
        txtPasscode.MaxLength = 6
    End Sub

    Private Sub PictureShowPasword_Click(sender As Object, e As EventArgs) Handles PictureShowPasword.Click
        If txtPasscode.UseSystemPasswordChar = True Then
            PictureNotShowPassword.Show()
            PictureShowPasword.Hide()
            txtPasscode.UseSystemPasswordChar = False
        Else
            txtPasscode.UseSystemPasswordChar = True
            PictureShowPasword.Show()
            PictureNotShowPassword.Hide()
        End If
    End Sub

    Private Sub PictureNotShowPassword_Click(sender As Object, e As EventArgs) Handles PictureNotShowPassword.Click
        If txtPasscode.UseSystemPasswordChar = True Then
            PictureNotShowPassword.Show()
            PictureShowPasword.Hide()
            txtPasscode.UseSystemPasswordChar = False
        Else
            txtPasscode.UseSystemPasswordChar = True
            PictureShowPasword.Show()
            PictureNotShowPassword.Hide()
        End If
    End Sub

    Private Sub cboPosition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPosition.SelectedIndexChanged
        With position
            .LoadPositionCboTextBox(cboPosition, txtStandardPay, txtOT, txtBasicPays)
        End With
    End Sub

    Private Sub rdbMale_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMale.CheckedChanged
        If rdbMale.Checked = True Then
            gender = "Male"
        End If
    End Sub

    Private Sub rdbFemale_CheckedChanged(sender As Object, e As EventArgs) Handles rdbFemale.CheckedChanged
        If rdbFemale.Checked = True Then
            gender = "Female"
        End If
    End Sub

    Private Sub dtpDob_ValueChanged(sender As Object, e As EventArgs) Handles dtpDob.ValueChanged
        txtAge.Text = emp.GetCurrentAge(dtpDob.Value, FrmMain.dtServer)
        dtpDob.MinDate = Date.Now.AddYears(-71)
        dtpDob.MaxDate = Date.Now.ToString
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

End Class