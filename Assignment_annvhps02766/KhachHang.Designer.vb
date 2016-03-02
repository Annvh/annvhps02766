<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKhachHang
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
        Me.bsKhachHang = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.dgvKhachHang = New System.Windows.Forms.DataGridView()
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtSoDienThoai = New System.Windows.Forms.TextBox()
        Me.txtNgaySinh = New System.Windows.Forms.TextBox()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.lblNgaySinh = New System.Windows.Forms.Label()
        Me.lblSoDienThoai = New System.Windows.Forms.Label()
        Me.lblDiaChi = New System.Windows.Forms.Label()
        Me.lblHoTen = New System.Windows.Forms.Label()
        Me.lblMa = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.bsKhachHang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvKhachHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(93, 11)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(75, 30)
        Me.btnCapNhat.TabIndex = 49
        Me.btnCapNhat.Text = "Load"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'dgvKhachHang
        '
        Me.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKhachHang.Location = New System.Drawing.Point(12, 195)
        Me.dgvKhachHang.Name = "dgvKhachHang"
        Me.dgvKhachHang.Size = New System.Drawing.Size(522, 169)
        Me.dgvKhachHang.TabIndex = 48
        '
        'txtHoTen
        '
        Me.txtHoTen.Location = New System.Drawing.Point(110, 82)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(221, 20)
        Me.txtHoTen.TabIndex = 47
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(110, 108)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(221, 20)
        Me.txtDiaChi.TabIndex = 46
        '
        'txtSoDienThoai
        '
        Me.txtSoDienThoai.Location = New System.Drawing.Point(110, 134)
        Me.txtSoDienThoai.Name = "txtSoDienThoai"
        Me.txtSoDienThoai.Size = New System.Drawing.Size(221, 20)
        Me.txtSoDienThoai.TabIndex = 45
        '
        'txtNgaySinh
        '
        Me.txtNgaySinh.Location = New System.Drawing.Point(110, 160)
        Me.txtNgaySinh.Name = "txtNgaySinh"
        Me.txtNgaySinh.Size = New System.Drawing.Size(221, 20)
        Me.txtNgaySinh.TabIndex = 44
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(110, 56)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(221, 20)
        Me.txtMaKH.TabIndex = 43
        '
        'lblNgaySinh
        '
        Me.lblNgaySinh.AutoSize = True
        Me.lblNgaySinh.Location = New System.Drawing.Point(12, 163)
        Me.lblNgaySinh.Name = "lblNgaySinh"
        Me.lblNgaySinh.Size = New System.Drawing.Size(56, 13)
        Me.lblNgaySinh.TabIndex = 42
        Me.lblNgaySinh.Text = "Ngày Sinh"
        '
        'lblSoDienThoai
        '
        Me.lblSoDienThoai.AutoSize = True
        Me.lblSoDienThoai.Location = New System.Drawing.Point(12, 137)
        Me.lblSoDienThoai.Name = "lblSoDienThoai"
        Me.lblSoDienThoai.Size = New System.Drawing.Size(75, 13)
        Me.lblSoDienThoai.TabIndex = 41
        Me.lblSoDienThoai.Text = "Số Điện Thoại"
        '
        'lblDiaChi
        '
        Me.lblDiaChi.AutoSize = True
        Me.lblDiaChi.Location = New System.Drawing.Point(12, 111)
        Me.lblDiaChi.Name = "lblDiaChi"
        Me.lblDiaChi.Size = New System.Drawing.Size(41, 13)
        Me.lblDiaChi.TabIndex = 40
        Me.lblDiaChi.Text = "Địa Chỉ"
        '
        'lblHoTen
        '
        Me.lblHoTen.AutoSize = True
        Me.lblHoTen.Location = New System.Drawing.Point(12, 85)
        Me.lblHoTen.Name = "lblHoTen"
        Me.lblHoTen.Size = New System.Drawing.Size(39, 13)
        Me.lblHoTen.TabIndex = 39
        Me.lblHoTen.Text = "Họ tên"
        '
        'lblMa
        '
        Me.lblMa.AutoSize = True
        Me.lblMa.Location = New System.Drawing.Point(12, 59)
        Me.lblMa.Name = "lblMa"
        Me.lblMa.Size = New System.Drawing.Size(85, 13)
        Me.lblMa.TabIndex = 38
        Me.lblMa.Text = "Mã Khách Hàng"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(337, 10)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 31)
        Me.btnExit.TabIndex = 37
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(256, 10)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 31)
        Me.btnXoa.TabIndex = 36
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(174, 10)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 31)
        Me.btnSua.TabIndex = 35
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(12, 12)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 30)
        Me.btnThem.TabIndex = 34
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(337, 75)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 66)
        Me.btnClear.TabIndex = 50
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 371)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.dgvKhachHang)
        Me.Controls.Add(Me.txtHoTen)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.txtSoDienThoai)
        Me.Controls.Add(Me.txtNgaySinh)
        Me.Controls.Add(Me.txtMaKH)
        Me.Controls.Add(Me.lblNgaySinh)
        Me.Controls.Add(Me.lblSoDienThoai)
        Me.Controls.Add(Me.lblDiaChi)
        Me.Controls.Add(Me.lblHoTen)
        Me.Controls.Add(Me.lblMa)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Name = "frmKhachHang"
        Me.Text = "Khách Hàng"
        CType(Me.bsKhachHang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvKhachHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bsKhachHang As System.Windows.Forms.BindingSource
    Friend WithEvents btnCapNhat As System.Windows.Forms.Button
    Friend WithEvents dgvKhachHang As System.Windows.Forms.DataGridView
    Friend WithEvents txtHoTen As System.Windows.Forms.TextBox
    Friend WithEvents txtDiaChi As System.Windows.Forms.TextBox
    Friend WithEvents txtSoDienThoai As System.Windows.Forms.TextBox
    Friend WithEvents txtNgaySinh As System.Windows.Forms.TextBox
    Friend WithEvents txtMaKH As System.Windows.Forms.TextBox
    Friend WithEvents lblNgaySinh As System.Windows.Forms.Label
    Friend WithEvents lblSoDienThoai As System.Windows.Forms.Label
    Friend WithEvents lblDiaChi As System.Windows.Forms.Label
    Friend WithEvents lblHoTen As System.Windows.Forms.Label
    Friend WithEvents lblMa As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
End Class
