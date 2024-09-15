<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stream_Master_Player
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stream_Master_Player))
        MenuStrip1 = New MenuStrip()
        AiutoToolStripMenuItem = New ToolStripMenuItem()
        GuidaToolStripMenuItem = New ToolStripMenuItem()
        InfomazioniSuToolStripMenuItem = New ToolStripMenuItem()
        txtURL = New TextBox()
        btnstart = New Button()
        AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        lstChannels = New ListBox()
        Label1 = New Label()
        cmbSearch = New ComboBox()
        MenuStrip1.SuspendLayout()
        CType(AxWindowsMediaPlayer1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {AiutoToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(818, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' AiutoToolStripMenuItem
        ' 
        AiutoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {GuidaToolStripMenuItem, InfomazioniSuToolStripMenuItem})
        AiutoToolStripMenuItem.Name = "AiutoToolStripMenuItem"
        AiutoToolStripMenuItem.Size = New Size(48, 20)
        AiutoToolStripMenuItem.Text = "Aiuto"
        ' 
        ' GuidaToolStripMenuItem
        ' 
        GuidaToolStripMenuItem.Name = "GuidaToolStripMenuItem"
        GuidaToolStripMenuItem.Size = New Size(180, 22)
        GuidaToolStripMenuItem.Text = "Guida"
        ' 
        ' InfomazioniSuToolStripMenuItem
        ' 
        InfomazioniSuToolStripMenuItem.Name = "InfomazioniSuToolStripMenuItem"
        InfomazioniSuToolStripMenuItem.Size = New Size(180, 22)
        InfomazioniSuToolStripMenuItem.Text = "Infomazioni Su"
        ' 
        ' txtURL
        ' 
        txtURL.Location = New Point(53, 27)
        txtURL.Name = "txtURL"
        txtURL.Size = New Size(638, 23)
        txtURL.TabIndex = 1
        ' 
        ' btnstart
        ' 
        btnstart.Location = New Point(697, 27)
        btnstart.Name = "btnstart"
        btnstart.Size = New Size(109, 23)
        btnstart.TabIndex = 2
        btnstart.Text = "Carica M3U"
        btnstart.UseVisualStyleBackColor = True
        ' 
        ' AxWindowsMediaPlayer1
        ' 
        AxWindowsMediaPlayer1.Enabled = True
        AxWindowsMediaPlayer1.Location = New Point(195, 56)
        AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), AxHost.State)
        AxWindowsMediaPlayer1.Size = New Size(611, 378)
        AxWindowsMediaPlayer1.TabIndex = 3
        ' 
        ' lstChannels
        ' 
        lstChannels.FormattingEnabled = True
        lstChannels.ItemHeight = 15
        lstChannels.Location = New Point(12, 85)
        lstChannels.Name = "lstChannels"
        lstChannels.Size = New Size(177, 349)
        lstChannels.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(32, 15)
        Label1.TabIndex = 5
        Label1.Text = "M3U"
        ' 
        ' cmbSearch
        ' 
        cmbSearch.FormattingEnabled = True
        cmbSearch.Location = New Point(12, 56)
        cmbSearch.Name = "cmbSearch"
        cmbSearch.Size = New Size(177, 23)
        cmbSearch.TabIndex = 6
        cmbSearch.Text = "Cerca per Canale"
        ' 
        ' Stream_Master_Player
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(818, 450)
        Controls.Add(cmbSearch)
        Controls.Add(Label1)
        Controls.Add(lstChannels)
        Controls.Add(AxWindowsMediaPlayer1)
        Controls.Add(btnstart)
        Controls.Add(txtURL)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MainMenuStrip = MenuStrip1
        Name = "Stream_Master_Player"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Stream_Master_Player"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(AxWindowsMediaPlayer1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AiutoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InfomazioniSuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtURL As TextBox
    Friend WithEvents btnstart As Button
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents lstChannels As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbSearch As ComboBox
End Class
