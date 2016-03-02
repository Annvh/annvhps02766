Public Class frmLoaiSP
    Private Sub FillLoaiSP()
        Dim Sql As String =
            <sql>
                SELECT * FROM LoaiSanPham_PS02766
            </sql>
        Connect(Sql, "LoaiSanPham_PS02766")
        bsLoaiSanPham.DataSource = ds.Tables("LoaiSanPham_PS02766")
        dgvLoaiSanPham.DataSource = bsLoaiSanPham
        bsLoaiSanPham.ResetBindings(False)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim Sql As String =
            <sql>
                insert into LoaiSanPham_PS02766(MaLoaiSP, TenLoaiSP)
                values ('{0}', '{1}')
            </sql>

        Sql = String.Format(Sql, txtMaLoaiSP.Text, txtTenLoaiSP)

        ExecuteNonQuery(Sql)

        FillLoaiSP()
    End Sub

    Private Sub dgvLoaiSanPham_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLoaiSanPham.CellContentClick
        Try
            Dim RowView As DataRowView = bsLoaiSanPham.Current
            Dim Row As DataRow = RowView.Row

            txtMaLoaiSP.Text = Row("MaLoaiSP")
            txtTenLoaiSP.Text = Row("TenLoaiSP")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        FillLoaiSP()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim Sql As String =
            <sql>
                DELETE FROM LoaiSanPham_PS02766
                WHERE        (LoaiSanPham_PS02766.MaLoaiSP = '{0}')
            </sql>
        Sql = String.Format(Sql, txtMaLoaiSP.Text)

        ExecuteNonQuery(Sql)

        FillLoaiSP()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim Sql As String =
           <sql>
                UPDATE      LoaiSanPham_PS02766
                SET         TenLoaiSP = N'{1}'
                WHERE        (MaLoaiSP = '{0}')
            </sql>

        Sql = String.Format(Sql, txtMaLoaiSP.Text, txtTenLoaiSP.Text)

        ExecuteNonQuery(Sql)

        FillLoaiSP()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtMaLoaiSP.Clear()
        txtTenLoaiSP.Clear()
    End Sub

    Private Sub frmLoaiSP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class