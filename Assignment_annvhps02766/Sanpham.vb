Public Class frmSanPham
    Private Sub FillSP()
        Dim Sql As String =
            <sql>
                SELECT * FROM SANPHAM_PS02766
            </sql>
        Connect(Sql, "SANPHAM_PS02766")
        bsSanPham.DataSource = ds.Tables("SANPHAM_PS02766")
        dgvSanPham.DataSource = bsSanPham
        bsSanPham.ResetBindings(False)
    End Sub
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim Sql As String =
           <sql>
                insert into SanPham_PS02766(MaSP, MaLoaiSP, TenSP, DonGia)
                values ('{0}', '{1}', N'{2}', '{3}')
            </sql>

        Sql = String.Format(Sql, txtMaSanPham.Text, txtMaLoaiSanPham.Text, txtTenSanPham.Text, txtDonGia.Text)

        ExecuteNonQuery(Sql)

        FillSP()
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        FillSP()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub dgvSanPham_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSanPham.CellContentClick
        Try
            Dim RowView As DataRowView = bsSanPham.Current
            Dim Row As DataRow = RowView.Row

            txtMaSanPham.Text = Row("MASP")
            txtMaLoaiSanPham.Text = Row("MaLoaiSP")
            txtTenSanPham.Text = Row("TENSP")
            txtDonGia.Text = Row("DONGIA")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim Sql As String =
           <sql>
                UPDATE      SanPham_PS02766
                SET         MaLoaiSP ='{1}', TenSP =N'{2}', DonGia ='{3}'
                WHERE        (MaSP = '{0}')
            </sql>

        Sql = String.Format(Sql, txtMaSanPham.Text, txtMaLoaiSanPham.Text, txtTenSanPham.Text, txtDonGia.Text)

        ExecuteNonQuery(Sql)

        FillSP()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim Sql As String =
            <sql>
                DELETE FROM SanPham_PS02766
                WHERE        (SanPham_PS02766.MaSP = '{0}')
            </sql>
        Sql = String.Format(Sql, txtMaSanPham.Text)

        ExecuteNonQuery(Sql)

        FillSP()
    End Sub

    Private Sub txtTenSanPham_TextChanged(sender As Object, e As EventArgs) Handles txtTenSanPham.TextChanged

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDonGia.Clear()
        txtMaLoaiSanPham.Clear()
        txtMaSanPham.Clear()
        txtTenSanPham.Clear()
    End Sub

    Private Sub txtSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
