<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class informazionisu
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(informazionisu))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(290, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(198, 16)
        Label1.TabIndex = 0
        Label1.Text = "Informazioni su StreamMaster" & vbLf
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(62, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(703, 102)
        Label2.TabIndex = 1
        Label2.Text = resources.GetString("Label2.Text")
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(302, 142)
        Label3.Name = "Label3"
        Label3.Size = New Size(175, 16)
        Label3.TabIndex = 2
        Label3.Text = "Caratteristiche principali:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(156, 158)
        Label4.Name = "Label4"
        Label4.Size = New Size(469, 68)
        Label4.TabIndex = 3
        Label4.Text = resources.GetString("Label4.Text")
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(151, 262)
        Label5.Name = "Label5"
        Label5.Size = New Size(488, 34)
        Label5.TabIndex = 4
        Label5.Text = "StreamMaster è la soluzione perfetta per chi desidera un'esperienza IPTV veloce, " & vbCrLf & "efficiente e personalizzata, tutto dal comfort del proprio desktop"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(169, 424)
        Label6.Name = "Label6"
        Label6.Size = New Size(450, 17)
        Label6.TabIndex = 5
        Label6.Text = "Versione: 1.0 - Sviluppatore: DS22051999 - Data di Rilascio: 15/09/2024"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.Location = New Point(12, 6)
        Button1.Name = "Button1"
        Button1.Size = New Size(27, 23)
        Button1.TabIndex = 6
        Button1.Text = "<"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' informazionisu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "informazionisu"
        Text = "informazionisu"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
End Class
