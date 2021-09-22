Public Class Choisir_Le_Niveau
    Private Sub boutton_Retour_Click(sender As Object, e As EventArgs) Handles boutton_Retour.Click
        Me.Hide()
        lesScoresEtLesNiveaux.Show()
    End Sub

    Private Sub niveau_Normal_Click(sender As Object, e As EventArgs) Handles niveau_Normal.Click
        tempsChoisis = 1800
        nbreDeSalveLimite = 1
        Form1.Timer_De_Deplacement_Du_Boss.Interval = 25
    End Sub

    Private Sub niveau_Intermediaire_Click(sender As Object, e As EventArgs) Handles niveau_Intermediaire.Click
        tempsChoisis = 900
        nbreDeSalveLimite = 3
        Form1.Timer_De_Deplacement_Du_Boss.Interval = 12
    End Sub

    Private Sub niveau_Difficile_Click(sender As Object, e As EventArgs) Handles niveau_Difficile.Click
        tempsChoisis = 600
        nbreDeSalveLimite = 5
        Form1.Timer_De_Deplacement_Du_Boss.Interval = 8
    End Sub
End Class