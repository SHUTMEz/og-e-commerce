<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Home))
        PictureBox1 = New PictureBox()
        btnEnter = New Button()
        Label1 = New Label()
        Button1 = New Button()
        PrintDialog1 = New PrintDialog()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logo_dark
        PictureBox1.Location = New Point(400, 58)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(200, 200)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' btnEnter
        ' 
        btnEnter.BackColor = Color.FromArgb(CByte(42), CByte(106), CByte(179))
        btnEnter.FlatAppearance.BorderSize = 0
        btnEnter.FlatStyle = FlatStyle.Flat
        btnEnter.Font = New Font("Mitr", 25F, FontStyle.Regular, GraphicsUnit.Point)
        btnEnter.ForeColor = Color.White
        btnEnter.ImageAlign = ContentAlignment.MiddleLeft
        btnEnter.Location = New Point(350, 282)
        btnEnter.Name = "btnEnter"
        btnEnter.Size = New Size(300, 90)
        btnEnter.TabIndex = 1
        btnEnter.Text = "เข้าสู่ร้านค้า"
        btnEnter.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(380, 530)
        Label1.Name = "Label1"
        Label1.Size = New Size(239, 22)
        Label1.TabIndex = 2
        Label1.Text = "Power by ♥ Phaiwan Nacharoen"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(55))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Mitr", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(375, 392)
        Button1.Name = "Button1"
        Button1.Size = New Size(250, 70)
        Button1.TabIndex = 3
        Button1.Text = "จัดการสต็อกสินค้า"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(984, 561)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(btnEnter)
        Controls.Add(PictureBox1)
        Font = New Font("Mitr", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 5, 3, 5)
        Name = "Home"
        StartPosition = FormStartPosition.CenterScreen
        Text = "IT - Marketplace"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PrintDialog1 As PrintDialog
End Class
