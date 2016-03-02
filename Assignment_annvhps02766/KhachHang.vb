Public Class frmKhachHang
    Private Sub FillKH()
        Dim Sql As String =
            <sql>
                SELECT * FROM KHACHHANG_PS02766
            </sql>
        Connect(Sql, "KHACHHANG_PS02766")
        bsKhachHang.DataSource = ds.Tables("KHACHHANG_PS02766")
        dgvKhachHang.DataSource = bsKhachHang
        bsKhachHang.ResetBindings(False)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim Sql As String =
            <sql>
                insert into KhachHang_PS02766(MaKH, HoTen, DiaChi, SoDienThoai, NgaySinh)
                values ('{0}', N'{1}', N'{2}', N'{3}', '{4}')
            </sql>

        Sql = String.Format(Sql, txtMaKH.Text, txtHoTen.Text, txtDiaChi.Text, txtSoDienThoai.Text, txtNgaySinh.Text)

        ExecuteNonQuery(Sql)

        FillKH()
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKhachHang.CellContentClick
        Try
            Dim RowView As DataRowView = bsKhachHang.Current
            Dim Row As DataRow = RowView.Row

            txtMaKH.Text = Row("MAKH")
            txtHoTen.Text = Row("HOTEN")
            txtDiaChi.Text = Row("DIACHI")
            txtSoDienThoai.Text = Row("SODIENTHOAI")
            txtNgaySinh.Text = Row("NGAYSINH")
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        FillKH()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim Sql As String =
            <sql>
                DELETE FROM KhachHang_PS02766
                WHERE        (KhachHang_PS02766.MaKH = '{0}')
            </sql>
        Sql = String.Format(Sql, txtMaKH.Text)

        ExecuteNonQuery(Sql)

        FillKH()
    End Sub



    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim Sql As String =
           <sql>
                UPDATE      KhachHang_PS02766
                SET         HoTen =N'{1}', DiaChi =N'{2}', SoDienThoai =N'{3}', NgaySinh ='{4}'
                WHERE        (MaKH = '{0}')
            </sql>

        Sql = String.Format(Sql, txtMaKH.Text, txtHoTen.Text, txtDiaChi.Text, txtSoDienThoai.Text, txtNgaySinh.Text)

        ExecuteNonQuery(Sql)

        FillKH()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtMaKH.Clear()
        txtDiaChi.Clear()
        txtHoTen.Clear()
        txtNgaySinh.Clear()
        txtSoDienThoai.Clear()
    End Sub

    Private Sub frmKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
