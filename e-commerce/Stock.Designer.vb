<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stock
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Stock))
        lblName = New Label()
        lblEmail = New Label()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        btnExit = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.BackColor = Color.White
        lblName.Font = New Font("Mitr", 10F, FontStyle.Regular, GraphicsUnit.Point)
        lblName.Location = New Point(65, 8)
        lblName.Name = "lblName"
        lblName.Size = New Size(65, 22)
        lblName.TabIndex = 0
        lblName.Text = "Loading"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.BackColor = Color.White
        lblEmail.Font = New Font("Mitr", 10F, FontStyle.Regular, GraphicsUnit.Point)
        lblEmail.Location = New Point(65, 30)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(65, 22)
        lblEmail.TabIndex = 1
        lblEmail.Text = "Loading"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(btnExit)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(lblEmail)
        Panel1.Controls.Add(lblName)
        Panel1.Location = New Point(-6, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1000, 65)
        Panel1.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(18, 11)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(41, 41)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(55))
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Mitr", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnExit.ForeColor = Color.White
        btnExit.Location = New Point(867, 8)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(111, 41)
        btnExit.TabIndex = 4
        btnExit.Text = "HOME"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' Stock
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(984, 561)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Stock"
        StartPosition = FormStartPosition.CenterScreen
        Text = "IT - Marketplace"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnExit As Button
End Class
