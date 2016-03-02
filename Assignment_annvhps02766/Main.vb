Public Class Main

    Private Sub btnThemKhachHang_Click(sender As Object, e As EventArgs) Handles btnThemKhachHang.Click
        frmKhachHang.Show()
    End Sub

    Private Sub btnThemSanPham_Click(sender As Object, e As EventArgs) Handles btnThemSanPham.Click
        frmSanPham.Show()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnLoaiSanPham_Click(sender As Object, e As EventArgs) Handles btnLoaiSanPham.Click
        frmLoaiSP.Show()
    End Sub
End Class