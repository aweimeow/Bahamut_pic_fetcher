<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.lblc_account = New System.Windows.Forms.Label
        Me.TB_account = New System.Windows.Forms.TextBox
        Me.TB_password = New System.Windows.Forms.TextBox
        Me.lblc_password = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TB_check = New System.Windows.Forms.TextBox
        Me.lblc_check = New System.Windows.Forms.Label
        Me.Btn_login = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblc_account
        '
        Me.lblc_account.AutoSize = True
        Me.lblc_account.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblc_account.Location = New System.Drawing.Point(12, 21)
        Me.lblc_account.Name = "lblc_account"
        Me.lblc_account.Size = New System.Drawing.Size(86, 31)
        Me.lblc_account.TabIndex = 0
        Me.lblc_account.Text = "帳號："
        '
        'TB_account
        '
        Me.TB_account.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold)
        Me.TB_account.Location = New System.Drawing.Point(104, 18)
        Me.TB_account.Name = "TB_account"
        Me.TB_account.Size = New System.Drawing.Size(197, 39)
        Me.TB_account.TabIndex = 1
        '
        'TB_password
        '
        Me.TB_password.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold)
        Me.TB_password.Location = New System.Drawing.Point(104, 67)
        Me.TB_password.Name = "TB_password"
        Me.TB_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_password.Size = New System.Drawing.Size(197, 39)
        Me.TB_password.TabIndex = 3
        '
        'lblc_password
        '
        Me.lblc_password.AutoSize = True
        Me.lblc_password.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblc_password.Location = New System.Drawing.Point(12, 70)
        Me.lblc_password.Name = "lblc_password"
        Me.lblc_password.Size = New System.Drawing.Size(86, 31)
        Me.lblc_password.TabIndex = 2
        Me.lblc_password.Text = "密碼："
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(68, 120)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 80)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'TB_check
        '
        Me.TB_check.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold)
        Me.TB_check.Location = New System.Drawing.Point(102, 216)
        Me.TB_check.Name = "TB_check"
        Me.TB_check.Size = New System.Drawing.Size(197, 39)
        Me.TB_check.TabIndex = 6
        '
        'lblc_check
        '
        Me.lblc_check.AutoSize = True
        Me.lblc_check.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblc_check.Location = New System.Drawing.Point(14, 224)
        Me.lblc_check.Name = "lblc_check"
        Me.lblc_check.Size = New System.Drawing.Size(86, 24)
        Me.lblc_check.TabIndex = 5
        Me.lblc_check.Text = "驗證碼："
        '
        'Btn_login
        '
        Me.Btn_login.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_login.Location = New System.Drawing.Point(12, 262)
        Me.Btn_login.Name = "Btn_login"
        Me.Btn_login.Size = New System.Drawing.Size(289, 62)
        Me.Btn_login.TabIndex = 7
        Me.Btn_login.Text = "登入"
        Me.Btn_login.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 335)
        Me.Controls.Add(Me.Btn_login)
        Me.Controls.Add(Me.TB_check)
        Me.Controls.Add(Me.lblc_check)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TB_password)
        Me.Controls.Add(Me.lblc_password)
        Me.Controls.Add(Me.TB_account)
        Me.Controls.Add(Me.lblc_account)
        Me.Name = "Form1"
        Me.Text = "巴哈姆特場外圖片抓取器"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblc_account As System.Windows.Forms.Label
    Friend WithEvents TB_account As System.Windows.Forms.TextBox
    Friend WithEvents TB_password As System.Windows.Forms.TextBox
    Friend WithEvents lblc_password As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TB_check As System.Windows.Forms.TextBox
    Friend WithEvents lblc_check As System.Windows.Forms.Label
    Friend WithEvents Btn_login As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
