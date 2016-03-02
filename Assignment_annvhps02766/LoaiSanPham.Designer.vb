<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoaiSP
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
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.dgvLoaiSanPham = New System.Windows.Forms.DataGridView()
        Me.txtTenLoaiSP = New System.Windows.Forms.TextBox()
        Me.txtMaLoaiSP = New System.Windows.Forms.TextBox()
        Me.lblTenLoaiSP = New System.Windows.Forms.Label()
        Me.lblLoaiSanPham = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.bsLoaiSanPham = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvLoaiSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLoaiSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(334, 56)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 66)
        Me.btnClear.TabIndex = 67
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(90, 5)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(75, 30)
        Me.btnCapNhat.TabIndex = 66
        Me.btnCapNhat.Text = "Load"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'dgvLoaiSanPham
        '
        Me.dgvLoaiSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLoaiSanPham.Location = New System.Drawing.Point(9, 128)
        Me.dgvLoaiSanPham.Name = "dgvLoaiSanPham"
        Me.dgvLoaiSanPham.Size = New System.Drawing.Size(522, 169)
        Me.dgvLoaiSanPham.TabIndex = 65
        '
        'txtTenLoaiSP
        '
        Me.txtTenLoaiSP.Location = New System.Drawing.Point(107, 80)
        Me.txtTenLoaiSP.Name = "txtTenLoaiSP"
        Me.txtTenLoaiSP.Size = New System.Drawing.Size(221, 20)
        Me.txtTenLoaiSP.TabIndex = 63
        '
        'txtMaLoaiSP
        '
        Me.txtMaLoaiSP.Location = New System.Drawing.Point(107, 50)
        Me.txtMaLoaiSP.Name = "txtMaLoaiSP"
        Me.txtMaLoaiSP.Size = New System.Drawing.Size(221, 20)
        Me.txtMaLoaiSP.TabIndex = 60
        '
        'lblTenLoaiSP
        '
        Me.lblTenLoaiSP.AutoSize = True
        Me.lblTenLoaiSP.Location = New System.Drawing.Point(9, 83)
        Me.lblTenLoaiSP.Name = "lblTenLoaiSP"
        Me.lblTenLoaiSP.Size = New System.Drawing.Size(101, 13)
        Me.lblTenLoaiSP.TabIndex = 57
        Me.lblTenLoaiSP.Text = "Tên Loại Sản Phẩm"
        '
        'lblLoaiSanPham
        '
        Me.lblLoaiSanPham.AutoSize = True
        Me.lblLoaiSanPham.Location = New System.Drawing.Point(9, 53)
        Me.lblLoaiSanPham.Name = "lblLoaiSanPham"
        Me.lblLoaiSanPham.Size = New System.Drawing.Size(97, 13)
        Me.lblLoaiSanPham.TabIndex = 55
        Me.lblLoaiSanPham.Text = "Mã Loại Sản Phẩm"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(334, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 31)
        Me.btnExit.TabIndex = 54
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(253, 4)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 31)
        Me.btnXoa.TabIndex = 53
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(171, 4)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 31)
        Me.btnSua.TabIndex = 52
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(9, 6)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 30)
        Me.btnThem.TabIndex = 51
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'frmLoaiSP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 309)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.dgvLoaiSanPham)
        Me.Controls.Add(Me.txtTenLoaiSP)
        Me.Controls.Add(Me.txtMaLoaiSP)
        Me.Controls.Add(Me.lblTenLoaiSP)
        Me.Controls.Add(Me.lblLoaiSanPham)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Name = "frmLoaiSP"
        Me.Text = "Loại Sản Phẩm"
        CType(Me.dgvLoaiSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLoaiSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCapNhat As System.Windows.Forms.Button
    Friend WithEvents dgvLoaiSanPham As System.Windows.Forms.DataGridView
    Friend WithEvents txtTenLoaiSP As System.Windows.Forms.TextBox
    Friend WithEvents txtMaLoaiSP As System.Windows.Forms.TextBox
    Friend WithEvents lblTenLoaiSP As System.Windows.Forms.Label
    Friend WithEvents lblLoaiSanPham As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents bsLoaiSanPham As System.Windows.Forms.BindingSource
End Class
