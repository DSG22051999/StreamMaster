<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        btnenter = New Button()
        Label2 = New Label()
        btnexit = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(147, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(494, 18)
        Label1.TabIndex = 0
        Label1.Text = "Benvenuto in StreamMaster! La tua porta di accesso al mondo IPTV"
        ' 
        ' btnenter
        ' 
        btnenter.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnenter.Location = New Point(278, 159)
        btnenter.Name = "btnenter"
        btnenter.Size = New Size(114, 28)
        btnenter.TabIndex = 1
        btnenter.Text = "Avvia"
        btnenter.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(7, 123)
        Label2.Name = "Label2"
        Label2.Size = New Size(786, 34)
        Label2.TabIndex = 2
        Label2.Text = resources.GetString("Label2.Text")
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnexit
        ' 
        btnexit.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnexit.Location = New Point(398, 159)
        btnexit.Name = "btnexit"
        btnexit.Size = New Size(114, 28)
        btnexit.TabIndex = 3
        btnexit.Text = "Esci"
        btnexit.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(225, 30)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(342, 90)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 199)
        Controls.Add(PictureBox1)
        Controls.Add(btnexit)
        Controls.Add(Label2)
        Controls.Add(btnenter)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnenter As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnexit As Button
    Friend WithEvents PictureBox1 As PictureBox

End Class
