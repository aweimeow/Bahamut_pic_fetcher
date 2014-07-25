<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.TB_url = New System.Windows.Forms.TextBox
        Me.lblc_url = New System.Windows.Forms.Label
        Me.Btn_fetch = New System.Windows.Forms.Button
        Me.PB_1 = New System.Windows.Forms.PictureBox
        Me.PB_2 = New System.Windows.Forms.PictureBox
        Me.PB_3 = New System.Windows.Forms.PictureBox
        Me.PB_4 = New System.Windows.Forms.PictureBox
        Me.PB_5 = New System.Windows.Forms.PictureBox
        Me.PB_6 = New System.Windows.Forms.PictureBox
        Me.PB_7 = New System.Windows.Forms.PictureBox
        Me.PB_8 = New System.Windows.Forms.PictureBox
        Me.PB_9 = New System.Windows.Forms.PictureBox
        Me.PB_large = New System.Windows.Forms.PictureBox
        Me.Btn_previous = New System.Windows.Forms.Button
        Me.Btn_next = New System.Windows.Forms.Button
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        CType(Me.PB_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_large, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TB_url
        '
        Me.TB_url.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold)
        Me.TB_url.Location = New System.Drawing.Point(104, 6)
        Me.TB_url.Name = "TB_url"
        Me.TB_url.Size = New System.Drawing.Size(287, 39)
        Me.TB_url.TabIndex = 0
        '
        'lblc_url
        '
        Me.lblc_url.AutoSize = True
        Me.lblc_url.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblc_url.Location = New System.Drawing.Point(12, 9)
        Me.lblc_url.Name = "lblc_url"
        Me.lblc_url.Size = New System.Drawing.Size(86, 31)
        Me.lblc_url.TabIndex = 1
        Me.lblc_url.Text = "網址："
        '
        'Btn_fetch
        '
        Me.Btn_fetch.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_fetch.Location = New System.Drawing.Point(397, 4)
        Me.Btn_fetch.Name = "Btn_fetch"
        Me.Btn_fetch.Size = New System.Drawing.Size(83, 40)
        Me.Btn_fetch.TabIndex = 2
        Me.Btn_fetch.Text = "抓取"
        Me.Btn_fetch.UseVisualStyleBackColor = True
        '
        'PB_1
        '
        Me.PB_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PB_1.Location = New System.Drawing.Point(18, 51)
        Me.PB_1.Name = "PB_1"
        Me.PB_1.Size = New System.Drawing.Size(150, 150)
        Me.PB_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB_1.TabIndex = 3
        Me.PB_1.TabStop = False
        '
        'PB_2
        '
        Me.PB_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PB_2.Location = New System.Drawing.Point(174, 51)
        Me.PB_2.Name = "PB_2"
        Me.PB_2.Size = New System.Drawing.Size(150, 150)
        Me.PB_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB_2.TabIndex = 4
        Me.PB_2.TabStop = False
        '
        'PB_3
        '
        Me.PB_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PB_3.Location = New System.Drawing.Point(330, 51)
        Me.PB_3.Name = "PB_3"
        Me.PB_3.Size = New System.Drawing.Size(150, 150)
        Me.PB_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB_3.TabIndex = 5
        Me.PB_3.TabStop = False
        '
        'PB_4
        '
        Me.PB_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PB_4.Location = New System.Drawing.Point(18, 207)
        Me.PB_4.Name = "PB_4"
        Me.PB_4.Size = New System.Drawing.Size(150, 150)
        Me.PB_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB_4.TabIndex = 6
        Me.PB_4.TabStop = False
        '
        'PB_5
        '
        Me.PB_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PB_5.Location = New System.Drawing.Point(174, 207)
        Me.PB_5.Name = "PB_5"
        Me.PB_5.Size = New System.Drawing.Size(150, 150)
        Me.PB_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB_5.TabIndex = 7
        Me.PB_5.TabStop = False
        '
        'PB_6
        '
        Me.PB_6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PB_6.Location = New System.Drawing.Point(330, 207)
        Me.PB_6.Name = "PB_6"
        Me.PB_6.Size = New System.Drawing.Size(150, 150)
        Me.PB_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB_6.TabIndex = 8
        Me.PB_6.TabStop = False
        '
        'PB_7
        '
        Me.PB_7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PB_7.Location = New System.Drawing.Point(18, 363)
        Me.PB_7.Name = "PB_7"
        Me.PB_7.Size = New System.Drawing.Size(150, 150)
        Me.PB_7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB_7.TabIndex = 9
        Me.PB_7.TabStop = False
        '
        'PB_8
        '
        Me.PB_8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PB_8.Location = New System.Drawing.Point(174, 363)
        Me.PB_8.Name = "PB_8"
        Me.PB_8.Size = New System.Drawing.Size(150, 150)
        Me.PB_8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB_8.TabIndex = 10
        Me.PB_8.TabStop = False
        '
        'PB_9
        '
        Me.PB_9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PB_9.Location = New System.Drawing.Point(330, 363)
        Me.PB_9.Name = "PB_9"
        Me.PB_9.Size = New System.Drawing.Size(150, 150)
        Me.PB_9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB_9.TabIndex = 11
        Me.PB_9.TabStop = False
        '
        'PB_large
        '
        Me.PB_large.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PB_large.Location = New System.Drawing.Point(494, 6)
        Me.PB_large.Name = "PB_large"
        Me.PB_large.Size = New System.Drawing.Size(364, 570)
        Me.PB_large.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB_large.TabIndex = 12
        Me.PB_large.TabStop = False
        '
        'Btn_previous
        '
        Me.Btn_previous.Enabled = False
        Me.Btn_previous.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_previous.Location = New System.Drawing.Point(12, 521)
        Me.Btn_previous.Name = "Btn_previous"
        Me.Btn_previous.Size = New System.Drawing.Size(243, 57)
        Me.Btn_previous.TabIndex = 13
        Me.Btn_previous.Text = "＜"
        Me.Btn_previous.UseVisualStyleBackColor = True
        '
        'Btn_next
        '
        Me.Btn_next.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_next.Location = New System.Drawing.Point(261, 521)
        Me.Btn_next.Name = "Btn_next"
        Me.Btn_next.Size = New System.Drawing.Size(219, 57)
        Me.Btn_next.TabIndex = 14
        Me.Btn_next.Text = "＞"
        Me.Btn_next.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 588)
        Me.Controls.Add(Me.Btn_next)
        Me.Controls.Add(Me.Btn_previous)
        Me.Controls.Add(Me.PB_large)
        Me.Controls.Add(Me.PB_9)
        Me.Controls.Add(Me.PB_8)
        Me.Controls.Add(Me.PB_7)
        Me.Controls.Add(Me.PB_6)
        Me.Controls.Add(Me.PB_5)
        Me.Controls.Add(Me.PB_4)
        Me.Controls.Add(Me.PB_3)
        Me.Controls.Add(Me.PB_2)
        Me.Controls.Add(Me.PB_1)
        Me.Controls.Add(Me.Btn_fetch)
        Me.Controls.Add(Me.lblc_url)
        Me.Controls.Add(Me.TB_url)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PB_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_large, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TB_url As System.Windows.Forms.TextBox
    Friend WithEvents lblc_url As System.Windows.Forms.Label
    Friend WithEvents Btn_fetch As System.Windows.Forms.Button
    Friend WithEvents PB_1 As System.Windows.Forms.PictureBox
    Friend WithEvents PB_2 As System.Windows.Forms.PictureBox
    Friend WithEvents PB_3 As System.Windows.Forms.PictureBox
    Friend WithEvents PB_4 As System.Windows.Forms.PictureBox
    Friend WithEvents PB_5 As System.Windows.Forms.PictureBox
    Friend WithEvents PB_6 As System.Windows.Forms.PictureBox
    Friend WithEvents PB_7 As System.Windows.Forms.PictureBox
    Friend WithEvents PB_8 As System.Windows.Forms.PictureBox
    Friend WithEvents PB_9 As System.Windows.Forms.PictureBox
    Friend WithEvents PB_large As System.Windows.Forms.PictureBox
    Friend WithEvents Btn_previous As System.Windows.Forms.Button
    Friend WithEvents Btn_next As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
