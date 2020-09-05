Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click


        If (dgvSale.Rows.Count > 0) Then

            For i = 0 To dgvSale.Rows.Count - 1

                If (dgvSale.Rows(i).Cells("barcode").Value = txtBarcode.Text) Then

                    dgvSale.Rows(i).Cells("amount").Value += CInt(txtAmount.Text)
                    dgvSale.Rows(i).Cells("total").Value = (CInt(dgvSale.Rows(i).Cells("amount").Value) * CInt(dgvSale.Rows(i).Cells("price").Value)).ToString("#,##0")

                    Exit Sub
                End If


            Next

        End If


        dgvSale.Rows.Add(txtBarcode.Text, txtProductName.Text, txtPrice.Text, txtAmount.Text, txtTotal.Text)

    End Sub

    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged
        Try
            If txtAmount.Text <> "" And txtPrice.Text <> "" Then

                Dim total As Integer = CInt(txtAmount.Text) * CInt(txtPrice.Text)
                txtTotal.Text = total.ToString("#,##0")

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
