<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSanPham
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.dgvSanPham = New System.Windows.Forms.DataGridView()
        Me.txtMaLoaiSanPham = New System.Windows.Forms.TextBox()
        Me.txtTenSanPham = New System.Windows.Forms.TextBox()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.txtMaSanPham = New System.Windows.Forms.TextBox()
        Me.lblDonGia = New System.Windows.Forms.Label()
        Me.lblTenSanPham = New System.Windows.Forms.Label()
        Me.lblDiaChi = New System.Windows.Forms.Label()
        Me.lblMaSP = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.bsSanPham = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.dgvSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(93, 7)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(75, 30)
        Me.btnCapNhat.TabIndex = 31
        Me.btnCapNhat.Text = "Load"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'dgvSanPham
        '
        Me.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSanPham.Location = New System.Drawing.Point(12, 163)
        Me.dgvSanPham.Name = "dgvSanPham"
        Me.dgvSanPham.Size = New System.Drawing.Size(406, 218)
        Me.dgvSanPham.TabIndex = 30
        '
        'txtMaLoaiSanPham
        '
        Me.txtMaLoaiSanPham.Location = New System.Drawing.Point(110, 82)
        Me.txtMaLoaiSanPham.Name = "txtMaLoaiSanPham"
        Me.txtMaLoaiSanPham.Size = New System.Drawing.Size(221, 20)
        Me.txtMaLoaiSanPham.TabIndex = 28
        '
        'txtTenSanPham
        '
        Me.txtTenSanPham.Location = New System.Drawing.Point(110, 111)
        Me.txtTenSanPham.Name = "txtTenSanPham"
        Me.txtTenSanPham.Size = New System.Drawing.Size(221, 20)
        Me.txtTenSanPham.TabIndex = 27
        '
        'txtDonGia
        '
        Me.txtDonGia.Location = New System.Drawing.Point(110, 137)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(221, 20)
        Me.txtDonGia.TabIndex = 26
        '
        'txtMaSanPham
        '
        Me.txtMaSanPham.Location = New System.Drawing.Point(110, 52)
        Me.txtMaSanPham.Name = "txtMaSanPham"
        Me.txtMaSanPham.Size = New System.Drawing.Size(221, 20)
        Me.txtMaSanPham.TabIndex = 25
        '
        'lblDonGia
        '
        Me.lblDonGia.AutoSize = True
        Me.lblDonGia.Location = New System.Drawing.Point(12, 140)
        Me.lblDonGia.Name = "lblDonGia"
        Me.lblDonGia.Size = New System.Drawing.Size(46, 13)
        Me.lblDonGia.TabIndex = 24
        Me.lblDonGia.Text = "Đơn Giá"
        '
        'lblTenSanPham
        '
        Me.lblTenSanPham.AutoSize = True
        Me.lblTenSanPham.Location = New System.Drawing.Point(12, 114)
        Me.lblTenSanPham.Name = "lblTenSanPham"
        Me.lblTenSanPham.Size = New System.Drawing.Size(78, 13)
        Me.lblTenSanPham.TabIndex = 23
        Me.lblTenSanPham.Text = "Tên Sản Phẩm"
        '
        'lblDiaChi
        '
        Me.lblDiaChi.AutoSize = True
        Me.lblDiaChi.Location = New System.Drawing.Point(12, 85)
        Me.lblDiaChi.Name = "lblDiaChi"
        Me.lblDiaChi.Size = New System.Drawing.Size(97, 13)
        Me.lblDiaChi.TabIndex = 22
        Me.lblDiaChi.Text = "Mã Loại Sản Phẩm"
        '
        'lblMaSP
        '
        Me.lblMaSP.AutoSize = True
        Me.lblMaSP.Location = New System.Drawing.Point(12, 55)
        Me.lblMaSP.Name = "lblMaSP"
        Me.lblMaSP.Size = New System.Drawing.Size(74, 13)
        Me.lblMaSP.TabIndex = 20
        Me.lblMaSP.Text = "Mã Sản Phẩm"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(337, 6)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 31)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(256, 6)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 31)
        Me.btnXoa.TabIndex = 18
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(174, 6)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 31)
        Me.btnSua.TabIndex = 17
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(12, 8)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 30)
        Me.btnThem.TabIndex = 16
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(337, 61)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 66)
        Me.btnClear.TabIndex = 51
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 393)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.dgvSanPham)
        Me.Controls.Add(Me.txtMaLoaiSanPham)
        Me.Controls.Add(Me.txtTenSanPham)
        Me.Controls.Add(Me.txtDonGia)
        Me.Controls.Add(Me.txtMaSanPham)
        Me.Controls.Add(Me.lblDonGia)
        Me.Controls.Add(Me.lblTenSanPham)
        Me.Controls.Add(Me.lblDiaChi)
        Me.Controls.Add(Me.lblMaSP)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Name = "frmSanPham"
        Me.Text = "Sản Phẩm"
        CType(Me.dgvSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCapNhat As System.Windows.Forms.Button
    Friend WithEvents dgvSanPham As System.Windows.Forms.DataGridView
    Friend WithEvents txtMaLoaiSanPham As System.Windows.Forms.TextBox
    Friend WithEvents txtTenSanPham As System.Windows.Forms.TextBox
    Friend WithEvents txtDonGia As System.Windows.Forms.TextBox
    Friend WithEvents txtMaSanPham As System.Windows.Forms.TextBox
    Friend WithEvents lblDonGia As System.Windows.Forms.Label
    Friend WithEvents lblTenSanPham As System.Windows.Forms.Label
    Friend WithEvents lblDiaChi As System.Windows.Forms.Label
    Friend WithEvents lblMaSP As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents bsSanPham As System.Windows.Forms.BindingSource
    Friend WithEvents btnClear As System.Windows.Forms.Button
End Class
