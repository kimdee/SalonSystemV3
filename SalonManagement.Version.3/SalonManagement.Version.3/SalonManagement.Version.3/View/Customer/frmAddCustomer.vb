Public Class frmAddCustomer
    Public customer As Customer

    Public edit As Boolean = False
    Private Sub frmAddCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If edit Then
            With customer
                txtName.Text = .CustomerName
                If .CustomerSex = "Male" Then
                    rdbMale.Checked = True
                Else
                    rdbFemale.Checked = True
                End If
                txtCN.Text = .CustomerCN
                .AddCustomer()
            End With
        End If
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtName.Text = "Customer" Then
            MessageBox.Show("Symbol * means required.", "Message",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            With customer
                .CustomerName = txtName.Text
                .CustomerCN = txtCN.Text
                If rdbMale.Checked = True Then
                    .CustomerSex = "Male"
                Else
                    .CustomerSex = "Female"
                End If
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
            End With
        End If

    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        AllowedOnly(LetterOnly, txtName)
        ToUpperOnly(LetterOnly, txtName)
        txtName.MaxLength = 15
    End Sub

    Private Sub txtCN_TextChanged(sender As Object, e As EventArgs) Handles txtCN.TextChanged
        ContactNo(txtCN)
        AllowedOnly(NumberWDash, txtCN)
        txtCN.MaxLength = 13
    End Sub

    Private Sub txtName_GotFocus(sender As Object, e As EventArgs) Handles txtName.GotFocus
        If txtName.Text = "Customer" Then
            txtName.Text = ""
            txtName.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtName_LostFocus(sender As Object, e As EventArgs) Handles txtName.LostFocus
        If txtName.Text = "" Then
            txtName.Text = "Customer"
            txtName.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub txtCN_GotFocus(sender As Object, e As EventArgs) Handles txtCN.GotFocus
        If txtCN.Text = txtCN.Text Then
            txtCN.Text = ""
            txtCN.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtCN_LostFocus(sender As Object, e As EventArgs) Handles txtCN.LostFocus
        If txtCN.Text = "" Then
            txtCN.Text = "0000-000-0000"
            txtCN.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class