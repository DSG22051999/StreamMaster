Imports System.Net

Public Class Stream_Master_Player
    ' Lista completa dei canali da mantenere in memoria per la ricerca
    Private allChannels As New List(Of ListItem)
    Private placeholderText As String = "Cerca canale..." ' Testo del placeholder
    Private isPlaceholderActive As Boolean = True
    Private Sub Stream_Master_Player_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Imposta il placeholder quando il form viene caricato
        SetPlaceholder()
    End Sub

    ' Evento che si attiva quando la ComboBox ottiene il focus (cliccata o selezionata)
    Private Sub cmbSearch_GotFocus(sender As Object, e As EventArgs) Handles cmbSearch.GotFocus
        ' Rimuovi il placeholder quando si ottiene il focus
        If isPlaceholderActive Then
            cmbSearch.Text = ""
            cmbSearch.ForeColor = Color.Black
            isPlaceholderActive = False
        End If
    End Sub

    ' Evento che si attiva quando la ComboBox perde il focus
    Private Sub cmbSearch_LostFocus(sender As Object, e As EventArgs) Handles cmbSearch.LostFocus
        ' Reimposta il placeholder se il campo è vuoto
        If String.IsNullOrWhiteSpace(cmbSearch.Text) Then
            SetPlaceholder()
        End If
    End Sub

    ' Funzione per impostare il placeholder
    Private Sub SetPlaceholder()
        cmbSearch.Text = placeholderText
        cmbSearch.ForeColor = Color.Gray
        isPlaceholderActive = True
    End Sub


    Private Sub btn_start_click(sender As Object, e As EventArgs) Handles btnstart.Click
        Try
            Dim url As String = txtURL.Text

            ' Verifica se l'URL non è vuoto
            If Not String.IsNullOrEmpty(url) Then
                ' Pulisce la ListBox e ComboBox esistente
                lstChannels.Items.Clear()
                cmbSearch.Items.Clear()
                allChannels.Clear() ' Pulisce la lista completa dei canali

                ' Carica la playlist M3U
                Dim client As New WebClient()
                Dim m3uContent As String = client.DownloadString(url)

                ' Verifica se il contenuto è stato caricato correttamente
                If String.IsNullOrEmpty(m3uContent) Then
                    MessageBox.Show("Il contenuto della playlist M3U è vuoto.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                ' Analizza il contenuto M3U e aggiungi i canali alla ListBox e alla lista completa
                Dim lines As String() = m3uContent.Split(New String() {Environment.NewLine}, StringSplitOptions.None)
                Dim channelUrl As String = ""

                For Each line As String In lines
                    line = line.Trim()
                    If line.StartsWith("#EXTINF") Then
                        ' Estrae il nome del canale
                        Dim channelName As String = line.Substring(line.IndexOf(",") + 1).Trim()
                        Dim newChannel As New ListItem(channelUrl, channelName)

                        ' Aggiunge il canale alla lista completa e alla ComboBox per la ricerca
                        allChannels.Add(newChannel)
                        lstChannels.Items.Add(newChannel)
                    ElseIf Not line.StartsWith("#") AndAlso Not String.IsNullOrWhiteSpace(line) Then
                        ' Aggiorna l'URL del canale
                        channelUrl = line
                        ' Associa l'URL del canale all'ultimo elemento aggiunto
                        If allChannels.Count > 0 Then
                            Dim lastItem As ListItem = allChannels(allChannels.Count - 1)
                            lastItem.Url = channelUrl
                        End If
                    End If
                Next
            Else
                MessageBox.Show("Per favore inserisci un URL M3U valido.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Si è verificato un errore: " & ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lstChannels_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstChannels.SelectedIndexChanged
        Try
            Dim selectedItem As ListItem = CType(lstChannels.SelectedItem, ListItem)
            If selectedItem IsNot Nothing Then
                ' Imposta l'URL del canale selezionato nel controllo Windows Media Player
                AxWindowsMediaPlayer1.URL = selectedItem.Url
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Else
                MessageBox.Show("Seleziona un canale dalla lista.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Si è verificato un errore: " & ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbSearch_TextChanged(sender As Object, e As EventArgs) Handles cmbSearch.TextChanged
        If Not isPlaceholderActive Then
            ' Esegui la logica di ricerca solo se il placeholder non è attivo
            Dim searchQuery As String = cmbSearch.Text.ToLower()
            lstChannels.Items.Clear() ' Pulisce la ListBox per aggiornare i risultati

            ' Filtra i canali che corrispondono alla ricerca e li aggiunge alla ListBox
            For Each item As ListItem In allChannels
                If item.Name.ToLower().Contains(searchQuery) Then
                    lstChannels.Items.Add(item)
                End If
            Next
        End If
    End Sub
    Private Sub btninformazioni(sender As Object, e As EventArgs) Handles InfomazioniSuToolStripMenuItem.Click
        informazionisu.Show()
        Me.Hide()
    End Sub

    ' Classe per memorizzare il canale e l'URL
    Private Class ListItem
        Public Property Url As String
        Public Property Name As String

        Public Sub New(url As String, name As String)
            Me.Url = url
            Me.Name = name
        End Sub

        Public Overrides Function ToString() As String
            Return Name
        End Function
    End Class
End Class
