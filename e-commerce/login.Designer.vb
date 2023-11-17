<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(login))
        logoImg = New PictureBox()
        txtEmail = New TextBox()
        lblUsername = New Label()
        lblPassword = New Label()
        txtPassword = New TextBox()
        btnLogin = New Button()
        Label1 = New Label()
        btnHome = New Button()
        CType(logoImg, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' logoImg
        ' 
        logoImg.Image = My.Resources.Resources.logo_dark
        logoImg.Location = New Point(450, 69)
        logoImg.Name = "logoImg"
        logoImg.Size = New Size(100, 100)
        logoImg.SizeMode = PictureBoxSizeMode.StretchImage
        logoImg.TabIndex = 1
        logoImg.TabStop = False
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Mitr", 16F, FontStyle.Regular, GraphicsUnit.Point)
        txtEmail.Location = New Point(375, 214)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(250, 41)
        txtEmail.TabIndex = 2
        txtEmail.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Mitr", 13F, FontStyle.Regular, GraphicsUnit.Point)
        lblUsername.Location = New Point(471, 182)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(58, 29)
        lblUsername.TabIndex = 3
        lblUsername.Text = "Email"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Mitr", 13F, FontStyle.Regular, GraphicsUnit.Point)
        lblPassword.Location = New Point(450, 273)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(93, 29)
        lblPassword.TabIndex = 5
        lblPassword.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Mitr", 16F, FontStyle.Regular, GraphicsUnit.Point)
        txtPassword.Location = New Point(375, 305)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(250, 41)
        txtPassword.TabIndex = 4
        txtPassword.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(42), CByte(106), CByte(179))
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Mitr", 13F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(375, 382)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(250, 41)
        btnLogin.TabIndex = 6
        btnLogin.Text = "เข้าสู่ระบบ"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Mitr", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(380, 530)
        Label1.Name = "Label1"
        Label1.Size = New Size(239, 22)
        Label1.TabIndex = 7
        Label1.Text = "Power by ♥ Phaiwan Nacharoen"
        ' 
        ' btnHome
        ' 
        btnHome.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(55))
        btnHome.FlatAppearance.BorderSize = 0
        btnHome.FlatStyle = FlatStyle.Flat
        btnHome.Font = New Font("Mitr", 13F, FontStyle.Regular, GraphicsUnit.Point)
        btnHome.ForeColor = Color.White
        btnHome.Location = New Point(375, 429)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(250, 41)
        btnHome.TabIndex = 8
        btnHome.Text = "กลับหน้าหลัก"
        btnHome.UseVisualStyleBackColor = False
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(984, 561)
        Controls.Add(btnHome)
        Controls.Add(Label1)
        Controls.Add(btnLogin)
        Controls.Add(lblPassword)
        Controls.Add(txtPassword)
        Controls.Add(lblUsername)
        Controls.Add(txtEmail)
        Controls.Add(logoImg)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "IT - Marketplace"
        CType(logoImg, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents logoImg As PictureBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnHome As Button
End Class
