<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnThemKhachHang = New System.Windows.Forms.Button()
        Me.btnThemSanPham = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnLoaiSanPham = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(28, 287)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(504, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "annvhps02766 - INF205 - Assignment"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(537, 243)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'btnThemKhachHang
        '
        Me.btnThemKhachHang.Location = New System.Drawing.Point(12, 4)
        Me.btnThemKhachHang.Name = "btnThemKhachHang"
        Me.btnThemKhachHang.Size = New System.Drawing.Size(127, 31)
        Me.btnThemKhachHang.TabIndex = 5
        Me.btnThemKhachHang.Text = "Thêm Khách Hàng"
        Me.btnThemKhachHang.UseVisualStyleBackColor = True
        '
        'btnThemSanPham
        '
        Me.btnThemSanPham.Location = New System.Drawing.Point(145, 4)
        Me.btnThemSanPham.Name = "btnThemSanPham"
        Me.btnThemSanPham.Size = New System.Drawing.Size(117, 31)
        Me.btnThemSanPham.TabIndex = 6
        Me.btnThemSanPham.Text = "Thêm Sản Phẩm"
        Me.btnThemSanPham.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(379, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(96, 31)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnLoaiSanPham
        '
        Me.btnLoaiSanPham.Location = New System.Drawing.Point(268, 4)
        Me.btnLoaiSanPham.Name = "btnLoaiSanPham"
        Me.btnLoaiSanPham.Size = New System.Drawing.Size(105, 31)
        Me.btnLoaiSanPham.TabIndex = 8
        Me.btnLoaiSanPham.Text = "Loại Sản Phẩm"
        Me.btnLoaiSanPham.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 327)
        Me.Controls.Add(Me.btnLoaiSanPham)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnThemSanPham)
        Me.Controls.Add(Me.btnThemKhachHang)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Main"
        Me.Text = "Main"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnThemKhachHang As System.Windows.Forms.Button
    Friend WithEvents btnThemSanPham As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnLoaiSanPham As System.Windows.Forms.Button
End Class
