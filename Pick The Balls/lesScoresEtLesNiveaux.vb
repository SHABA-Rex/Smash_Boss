Public Class lesScoresEtLesNiveaux
    Private Sub Boutton_Des_Scores_Click(sender As Object, e As EventArgs) Handles Boutton_Des_Scores.Click
        Me.Dispose()
        Scores_Et_Victoires.Show()
    End Sub

    Private Sub Boutton_Des_Niveaux_Click(sender As Object, e As EventArgs) Handles Boutton_Des_Niveaux.Click
        Me.Dispose()
        Choisir_Le_Niveau.Show()
    End Sub

    Private Sub Boutton_Pour_Jouer_Click(sender As Object, e As EventArgs) Handles Boutton_Pour_Jouer.Click
        activerLeDecompteDesVictoires = True
        onContinue = True
        Form1.barreDeVieDuBoss.Value = Form1.barreDeVieDuBoss.Maximum
        Form1.barreDeVieDuPanzer.Value = Form1.barreDeVieDuPanzer.Maximum
        tempsQuiSecoule = tempsChoisis
        Form1.barreDeVieDuPanzer.ForeColor = Color.Lime
        Form1.barreDeVieDuBoss.ForeColor = Color.Lime
        Form1.Timer_DuTempsQuiPasse.Start()

        If (sentimentDuBoss = "facher") Then
            modifierLHumeurDuBoss("sourire")
            sentimentDuBoss = "sourire"
        End If

        Me.Hide()
    End Sub

    'Private Sub lesScoresEtLesNiveaux_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Scores_Et_Victoires.les_Victoires_Du_Panzer.Text = victoireDuPanzer
    '    Scores_Et_Victoires.les_Victoires_Du_Boss.Text = victoireDuBoss
    '    Scores_Et_Victoires.Score_Du_Boss.Text = scoreDuBoss
    '    Scores_Et_Victoires.Score_Du_Panzer.Text = scoreDuPanzer
    'End Sub
    Private Sub lesScoresEtLesNiveaux_Show(sender As Object, e As EventArgs) Handles MyBase.Shown
        Scores_Et_Victoires.Score_Du_Boss.Text = scoreDuBoss
        Scores_Et_Victoires.Score_Du_Panzer.Text = scoreDuPanzer
    End Sub
End Class