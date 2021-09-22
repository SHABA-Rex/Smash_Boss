Public Class Form1
    ' """"""""""""""""""""""""""""
    '   IMPORTANT ON A CACHER TOUS LES BOUTTONS 1,2,3,4 avec les properties visible=False
    '   Mis les autres ont ete hiden dans le load de la fenetre
    '   Si tu veux augmenter la dificulté du jeu va dans choisirLeNiveau ,  Dans Fonctions, Dans Variables pour modifier certaines variables. 
    '   Augmente surtout la virtesse des timers de la teteDuBoss , Le TimerDeCadenceDesTirs, Modifie le nombre de salve de tirs , Modifie le type de salve de tirs.
    '   En changeant la procedure tempsQuiSecouleEntreLesTirsDuBoss.Voila C'est Fini.
    '""""""""""""""""""""""""""""""


    Public frontiereDuBossEtDuHerosEtDesBalles() As Integer = {0, (Me.Width - 100)}
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If (sentimentDuBoss = "sourire") Then
            modifierLHumeurDuBoss("facher")
            sentimentDuBoss = "facher"
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If (sentimentDuBoss = "facher") Then
            modifierLHumeurDuBoss("sourire")
            sentimentDuBoss = "sourire"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        compteurDeDegats.Hide()
        compteurDeDegatsDuBoss.Hide()

        balle1DuPanzer.Location = baliseDesBallesDuPanzer.Location
        balle2DuPanzer.Location = baliseDesBallesDuPanzer.Location
        balle3DuPanzer.Location = baliseDesBallesDuPanzer.Location
        balle4DuPanzer.Location = baliseDesBallesDuPanzer.Location
        balle5DuPanzer.Location = baliseDesBallesDuPanzer.Location
        balle6DuPanzer.Location = baliseDesBallesDuPanzer.Location
        balle7DuPanzer.Location = baliseDesBallesDuPanzer.Location
        balle8DuPanzer.Location = baliseDesBallesDuPanzer.Location
        balle9DuPanzer.Location = baliseDesBallesDuPanzer.Location

        Balle1Copie.Location = copieDeLaBalise.Location
        Balle2Copie.Location = copieDeLaBalise.Location
        Balle3Copie.Location = copieDeLaBalise.Location
        Balle4Copie.Location = copieDeLaBalise.Location
        Balle5Copie.Location = copieDeLaBalise.Location
        Balle6Copie.Location = copieDeLaBalise.Location
        Balle7Copie.Location = copieDeLaBalise.Location
        Balle8Copie.Location = copieDeLaBalise.Location
        Balle9Copie.Location = copieDeLaBalise.Location

        deplacerLaballe1AvecLaBalise = True
        deplacerLaballe2AvecLaBalise = True
        deplacerLaballe3AvecLaBalise = True
        deplacerLaballe4AvecLaBalise = True
        deplacerLaballe5AvecLaBalise = True
        deplacerLaballe6AvecLaBalise = True
        deplacerLaballe7AvecLaBalise = True
        deplacerLaballe8AvecLaBalise = True
        deplacerLaballe9AvecLaBalise = True

        activerLaballe1DuPanzer = False
        activerLaballe2DuPanzer = False
        activerLaballe3DuPanzer = False
        activerLaballe4DuPanzer = False
        activerLaballe5DuPanzer = False
        activerLaballe6DuPanzer = False
        activerLaballe6DuPanzer = False
        activerLaballe7DuPanzer = False
        activerLaballe8DuPanzer = False
        activerLaballe9DuPanzer = False

        SourcilGauchePts1.Hide()
        SourcilGauchePts2.Hide()
        SourcilGauchePts3.Hide()
        SourcilDroitPts1.Hide()
        SourcilDroitPts2.Hide()
        SourcilDroitPts3.Hide()

        positionDeLoeil1 = oeil1.Location
        positionDeLoeil2 = oeil2.Location
        positionDuSourcilDroitePts1 = SourcilDroitPts1.Location
        positionDuSourcilDroitePts2 = SourcilDroitPts2.Location
        positionDuSourcilDroitePts3 = SourcilDroitPts3.Location
        positionDuSourcilGauchePts1 = SourcilGauchePts1.Location
        positionDuSourcilGauchePts2 = SourcilGauchePts2.Location
        positionDuSourcilGauchePts3 = SourcilGauchePts3.Location
        point1Bouche = boucheSourirePts1.Location
        point2Bouche = boucheSourirePts2.Location
        point3Bouche = boucheSourirePts3.Location
        point4Bouche = boucheSourirePts4.Location
        point5Bouche = boucheSourirePts5.Location
        point6Bouche = boucheSourirePts6.Location
        positionDeLaTeteDuBoss = teteBossMechant.Location
        positionDuPanzerAvantLeLargageDuBoss = corpsDuPanzer.Location.X

        balle1DuPanzer.Text = ""
        balle2DuPanzer.Text = ""
        balle3DuPanzer.Text = ""
        balle4DuPanzer.Text = ""
        balle5DuPanzer.Text = ""
        balle6DuPanzer.Text = ""
        balle7DuPanzer.Text = ""
        balle8DuPanzer.Text = ""
        balle9DuPanzer.Text = ""

        Label24.Hide()
        'lesScoresEtLesNiveaux.Show()
        Timer_DuTempsQuiPasse.Start()
        Timer_De_Deplacement_Du_Boss.Start()
        limiteDroiteDuPanzer.Hide()
        limiteDroiteDuBoss.Hide()
        LesBallesDuBoss.Hide()
        RemplaçantDuBoss.Hide()
        ballesDuPanzer.Hide()
        degatInfligerAuPanzer = 0
        baliseDesBallesDuPanzer.BackColor = Color.Green

    End Sub

    'Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click
    '    Timer_De_Deplacement_Du_Boss.Start()
    'End Sub
    Private Sub Timer_De_Deplacement_Du_Boss_Tick(sender As Object, e As EventArgs) Handles Timer_De_Deplacement_Du_Boss.Tick
        'Ici il est question de faire bouger le Boss soit vers la gauche, soit vers la droite
        'Dans la condition1 on fait en sorte que le boss aille vers la droite jusqu'à atteindre la frontiere droite.
        'Dans la condition2 on fait en sorte que le boss aille vers la gauche jusqu'à atteindre la frontiere gauche.
        'Dans la condtion3 , on verifie si le boss a dejà depasser la frontiere droite , si c'est le cas alors on change sa direction pour la gauche
        'Dans la condition4, on verifie si le boss a déjà depasser la frontiere gauche , si c'est le cas alors on change sa direction pour la droite
        If (Me.ResizeRedraw) Then
            frontiereDuBossEtDuHerosEtDesBalles(1) = Me.Width - 100
        End If
        If (onContinue) Then
            If (teteBossMechant.Location.X < frontiereDuBossEtDuHerosEtDesBalles(1)) And directionPriseParLaTeteDuBoss = "directionDroite" Then
                'Condition1
                positionDeLoeil1.X += 10
                positionDeLoeil2.X += 10
                positionDeLabalise.X += 10
                positionDuSourcilGauchePts1.X += 10
                positionDuSourcilGauchePts2.X += 10
                positionDuSourcilGauchePts3.X += 10
                positionDuSourcilDroitePts1.X += 10
                positionDuSourcilDroitePts2.X += 10
                positionDuSourcilDroitePts3.X += 10
                positionDeLaLimiteDroiteDuBoss.X += 10
                point1Bouche.X += 10
                point2Bouche.X += 10
                point3Bouche.X += 10
                point4Bouche.X += 10
                point5Bouche.X += 10
                point6Bouche.X += 10
                positionDeLaTeteDuBoss.X += 10
                deplacerLesBallesAvecLaBaliseVersLaDroite()
            ElseIf (teteBossMechant.Location.X > frontiereDuBossEtDuHerosEtDesBalles(0)) And directionPriseParLaTeteDuBoss = "directionGauche" Then
                'Condition2
                positionDeLoeil1.X -= 10
                positionDeLoeil2.X -= 10
                positionDeLabalise.X -= 10
                positionDuSourcilGauchePts1.X -= 10
                positionDuSourcilGauchePts2.X -= 10
                positionDuSourcilGauchePts3.X -= 10
                positionDuSourcilDroitePts1.X -= 10
                positionDuSourcilDroitePts2.X -= 10
                positionDuSourcilDroitePts3.X -= 10
                positionDeLaLimiteDroiteDuBoss.X -= 10
                point1Bouche.X -= 10
                point2Bouche.X -= 10
                point3Bouche.X -= 10
                point4Bouche.X -= 10
                point5Bouche.X -= 10
                point6Bouche.X -= 10
                positionDeLaTeteDuBoss.X -= 10
                deplacerLesBallesAvecLaBaliseVersLaGauche()
            End If

            If (teteBossMechant.Location.X >= frontiereDuBossEtDuHerosEtDesBalles(1)) And directionPriseParLaTeteDuBoss = "directionDroite" Then
                'Condition3
                directionPriseParLaTeteDuBoss = "directionGauche"
            ElseIf (teteBossMechant.Location.X <= frontiereDuBossEtDuHerosEtDesBalles(0)) And directionPriseParLaTeteDuBoss = "directionGauche" Then
                'Condition4
                directionPriseParLaTeteDuBoss = "directionDroite"
            End If

            'Condition5
            calculDeLaPositionDuPanzerAvantLeTir()

            oeil1.Location = positionDeLoeil1
            oeil2.Location = positionDeLoeil2
            copieDeLaBalise.Location = positionDeLabalise 'Le nez du Boss
            SourcilDroitPts1.Location = positionDuSourcilDroitePts1
            SourcilDroitPts2.Location = positionDuSourcilDroitePts2
            SourcilDroitPts3.Location = positionDuSourcilDroitePts3
            SourcilGauchePts1.Location = positionDuSourcilGauchePts1
            SourcilGauchePts2.Location = positionDuSourcilGauchePts2
            SourcilGauchePts3.Location = positionDuSourcilGauchePts3
            boucheSourirePts1.Location = point1Bouche
            boucheSourirePts2.Location = point2Bouche
            boucheSourirePts3.Location = point3Bouche
            boucheSourirePts4.Location = point4Bouche
            boucheSourirePts5.Location = point5Bouche
            boucheSourirePts6.Location = point6Bouche
            teteBossMechant.Location = positionDeLaTeteDuBoss
            limiteDroiteDuBoss.Location = positionDeLaLimiteDroiteDuBoss
        End If
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        frontiereDuBossEtDuHerosEtDesBalles(1) = Me.Width - 100
    End Sub


    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click

        'numDeLaBalleQuiAeteTirer = 0
        'activerLaballe1 = False
        'activerLaballe2 = False
        'activerLaballe3 = False
        'activerLaballe4 = False
        'activerLaballe5 = False
        'activerLaballe6 = False
        'activerLaballe7 = False
        'activerLaballe8 = False
        'activerLaballe9 = False

        'timerDeDeplacementDeLaBalle1.Start()
        'TimerDeDeplacemnentDeLaBalle2.Start()
        'TimerDeDeplacemnentDeLaBalle3.Start()
        'TimerDeDeplacemnentDeLaBalle4.Start()
        'TimerDeDeplacemnentDeLaBalle5.Start()
        'TimerDeDeplacemnentDeLaBalle6.Start()
        'TimerDeDeplacemnentDeLaBalle7.Start()
        'TimerDeDeplacemnentDeLaBalle8.Start()
        'TimerDeDeplacemnentDeLaBalle9.Start()
        ''TimerDeDplacementDeLaBalise.Start()
        'Timer_Pour_CadencerLeTirDeBalles.Start()
        declencherLaRiposteDuBossAvecSesBalles()
    End Sub

    Private Sub timerDeDeplacementDeLaBalle1_Tick(sender As Object, e As EventArgs) Handles timerDeDeplacementDeLaBalle1.Tick
        If (activerLaballe1) Then
            tirerLesBallesDuBoss(Balle1Copie, timerDeDeplacementDeLaBalle1)
        End If
    End Sub

    Private Sub TimerDeDeplacemnentDeLaBalle2_Tick(sender As Object, e As EventArgs) Handles TimerDeDeplacemnentDeLaBalle2.Tick
        If (activerLaballe2) Then
            tirerLesBallesDuBoss(Balle2Copie, TimerDeDeplacemnentDeLaBalle2)
        End If
    End Sub

    Private Sub TimerDeDeplacemnentDeLaBalle3_Tick(sender As Object, e As EventArgs) Handles TimerDeDeplacemnentDeLaBalle3.Tick
        If (activerLaballe3) Then
            tirerLesBallesDuBoss(Balle3Copie, TimerDeDeplacemnentDeLaBalle3)
        End If
    End Sub
    Private Sub TimerDeDeplacemnentDeLaBalle4_Tick(sender As Object, e As EventArgs) Handles TimerDeDeplacemnentDeLaBalle4.Tick
        If (activerLaballe4) Then
            tirerLesBallesDuBoss(Balle4Copie, TimerDeDeplacemnentDeLaBalle4)
        End If
    End Sub

    Private Sub TimerDeDeplacemnentDeLaBalle5_Tick(sender As Object, e As EventArgs) Handles TimerDeDeplacemnentDeLaBalle5.Tick
        If (activerLaballe5) Then
            tirerLesBallesDuBoss(Balle5Copie, TimerDeDeplacemnentDeLaBalle5)
        End If
    End Sub

    Private Sub TimerDeDeplacemnentDeLaBalle6_Tick(sender As Object, e As EventArgs) Handles TimerDeDeplacemnentDeLaBalle6.Tick
        If (activerLaballe6) Then
            tirerLesBallesDuBoss(Balle6Copie, TimerDeDeplacemnentDeLaBalle6)
        End If
    End Sub

    Private Sub TimerDeDeplacemnentDeLaBalle7_Tick(sender As Object, e As EventArgs) Handles TimerDeDeplacemnentDeLaBalle7.Tick
        If (activerLaballe7) Then
            tirerLesBallesDuBoss(Balle7Copie, TimerDeDeplacemnentDeLaBalle7)
        End If
    End Sub

    Private Sub TimerDeDeplacemnentDeLaBalle8_Tick(sender As Object, e As EventArgs) Handles TimerDeDeplacemnentDeLaBalle8.Tick
        If (activerLaballe8) Then
            tirerLesBallesDuBoss(Balle8Copie, TimerDeDeplacemnentDeLaBalle8)
        End If
    End Sub

    Private Sub TimerDeDeplacemnentDeLaBalle9_Tick(sender As Object, e As EventArgs) Handles TimerDeDeplacemnentDeLaBalle9.Tick
        If (activerLaballe9) Then
            tirerLesBallesDuBoss(Balle9Copie, TimerDeDeplacemnentDeLaBalle9)
        End If
    End Sub

    'Private Sub TimerDeDplacementDeLaBalise_Tick(sender As Object, e As EventArgs) Handles TimerDeDplacementDeLaBalise.Tick

    '    positionDeLabalise.X += 3
    '    copieDeLaBalise.Location = positionDeLabalise


    '    If (deplacerLaballe1AvecLaBalise Or numDeLaBalleQuiAeteTirer = 1) Then
    '        Balle1Copie.Location = copieDeLaBalise.Location
    '        deplacerLaballe1AvecLaBalise = True
    '    End If
    '    If (deplacerLaballe2AvecLaBalise Or numDeLaBalleQuiAeteTirer = 2) Then
    '        Balle2Copie.Location = copieDeLaBalise.Location
    '        deplacerLaballe2AvecLaBalise = True
    '    End If
    '    If (deplacerLaballe3AvecLaBalise Or numDeLaBalleQuiAeteTirer = 3) Then
    '        Balle3Copie.Location = copieDeLaBalise.Location
    '        deplacerLaballe3AvecLaBalise = True
    '    End If
    '    If (deplacerLaballe4AvecLaBalise Or numDeLaBalleQuiAeteTirer = 4) Then
    '        Balle4Copie.Location = copieDeLaBalise.Location
    '        deplacerLaballe4AvecLaBalise = True
    '    End If
    '    If (deplacerLaballe5AvecLaBalise Or numDeLaBalleQuiAeteTirer = 5) Then
    '        Balle5Copie.Location = copieDeLaBalise.Location
    '        deplacerLaballe5AvecLaBalise = True
    '    End If
    '    If (deplacerLaballe6AvecLaBalise Or numDeLaBalleQuiAeteTirer = 6) Then
    '        Balle6Copie.Location = copieDeLaBalise.Location
    '        deplacerLaballe6AvecLaBalise = True
    '    End If
    '    If (deplacerLaballe7AvecLaBalise Or numDeLaBalleQuiAeteTirer = 7) Then
    '        Balle7Copie.Location = copieDeLaBalise.Location
    '        deplacerLaballe7AvecLaBalise = True
    '    End If
    '    If (deplacerLaballe8AvecLaBalise Or numDeLaBalleQuiAeteTirer = 8) Then
    '        Balle8Copie.Location = copieDeLaBalise.Location
    '        deplacerLaballe8AvecLaBalise = True
    '    End If
    '    If (deplacerLaballe9AvecLaBalise Or numDeLaBalleQuiAeteTirer = 9) Then
    '        Balle9Copie.Location = copieDeLaBalise.Location
    '        deplacerLaballe9AvecLaBalise = True
    '    End If



    'End Sub

    Private Sub Timer_Pour_CadencerLeTirDeBalles_Tick(sender As Object, e As EventArgs) Handles Timer_Pour_CadencerLeTirDeBalles.Tick
        'La seul utilité de ce timer c'est de compter.
        'Et en fonction du nombre surLequel il se trouve on va activer les timer de certaines balles. 
        'activerLaCadenceDesTirs
        'On a numeroter les types de tirs du boss ils vont se succeder les uns après les Autres.

        Label26.Text = tempsApresLequelUneBalleEstTirer & " num : " & numDeLaBalleQuiAeteTirer
        tempsApresLequelUneBalleEstTirer += 1
        tempsQuiSecouleEntreLesTirsDuBoss()
        'Select Case (tempsApresLequelUneBalleEstTirer)
        '    Case 2
        '        activerLaballe1 = True
        '        deplacerLaballe1AvecLaBalise = False
        '    Case 8
        '        activerLaballe2 = True
        '        deplacerLaballe2AvecLaBalise = False
        '    Case 16
        '        activerLaballe3 = True
        '        deplacerLaballe3AvecLaBalise = False
        '    Case 24
        '        activerLaballe4 = True
        '        deplacerLaballe4AvecLaBalise = False
        '    Case 32
        '        activerLaballe5 = True
        '        deplacerLaballe5AvecLaBalise = False
        '    Case 40
        '        activerLaballe6 = True
        '        deplacerLaballe6AvecLaBalise = False
        '    Case 45
        '        activerLaballe7 = True
        '        deplacerLaballe7AvecLaBalise = False
        '    Case 52
        '        activerLaballe8 = True
        '        deplacerLaballe8AvecLaBalise = False
        '    Case 60
        '        activerLaballe9 = True
        '        deplacerLaballe9AvecLaBalise = False
        'End Select

        If (numDeLaBalleQuiAeteTirer = 9) Then
            demarrerLeCalculDeLaPosDuPanzerAventLeTir = True
            autoriserLeTirDuBoss = True
            recupererPosDuPanzer = True
            Timer_Pour_CadencerLeTirDeBalles.Stop()
            tempsApresLequelUneBalleEstTirer = 0
            If (numeroDeSalveDeTir < nbreDeSalveLimite) Then
                'Condition3
                numeroDeSalveDeTir += 1
            ElseIf (numeroDeSalveDeTir = nbreDeSalveLimite) Then
                numeroDeSalveDeTir = 1
            End If
        End If

    End Sub

    Private Sub Form1_KeyDown(sender As Object, evenement As KeyEventArgs) Handles Me.KeyDown

        'If (recupererPosDuPanzer) Then
        '    positionDuPanzerAvantLeLargageDuBoss = positionDuCorpsDuPanzer.X
        '    recupererPosDuPanzer = False
        'End If
        'Dans les conditions1 et conditions2  il question de determiner la position du panzer lorsque l'une des touches directionnelles est appuyée.
        If (corpsDuPanzer.Location.X > frontiereDuBossEtDuHerosEtDesBalles(0)) Or directionPriseParLePanzer = "directionGauche" Then
            If (evenement.KeyCode = Keys.Left) Then
                supporDuCanonDuPanzer.X -= nbreDePasDeDeplacementDuPanzer
                positionDuCanonDuPanzer.X -= nbreDePasDeDeplacementDuPanzer
                positionDuCorpsDuPanzer.X -= nbreDePasDeDeplacementDuPanzer
                positionDeLaBaliseDesBallesDuPanzer.X -= nbreDePasDeDeplacementDuPanzer
                positionDeLalimiteDroiteDuPanzer.X -= nbreDePasDeDeplacementDuPanzer
                deplacerLesBallesDuPanzerAvecBaliseVersLaGauche()
                'Apres etre allé sur la Gauche on ne peut aller que sur la droite
                directionPriseParLePanzer = "directionDroite"
                If (recupererPosDuPanzer) Then
                    'Condition1
                    positionDuPanzerAvantLeLargageDuBoss = corpsDuPanzer.Location.X
                    recupererPosDuPanzer = False
                End If
            End If
        End If

        If (corpsDuPanzer.Location.X < frontiereDuBossEtDuHerosEtDesBalles(1) + 18) Or directionPriseParLePanzer = "directionDroite" Then
            If (evenement.KeyCode = Keys.Right) Then
                supporDuCanonDuPanzer.X += nbreDePasDeDeplacementDuPanzer
                positionDuCanonDuPanzer.X += nbreDePasDeDeplacementDuPanzer
                positionDuCorpsDuPanzer.X += nbreDePasDeDeplacementDuPanzer
                positionDeLaBaliseDesBallesDuPanzer.X += nbreDePasDeDeplacementDuPanzer
                positionDeLalimiteDroiteDuPanzer.X += nbreDePasDeDeplacementDuPanzer
                deplacerLesBallesDuPanzerAvecBaliseVersLaDroite()
                'Apres etre allé sur la droite ,on ne peut aller que sur la gauche
                directionPriseParLePanzer = "directionGauche"
                If (recupererPosDuPanzer) Then
                    'Condition2
                    positionDuPanzerAvantLeLargageDuBoss = corpsDuPanzer.Location.X
                    recupererPosDuPanzer = False
                End If
            End If
        End If

        If (evenement.KeyCode = Keys.NumPad0) Then
            numeroDeLaBalleDuPanzerQuiDoitEtreTirer += 1
            idBalle1Panzer = numeroDeLaBalleDuPanzerQuiDoitEtreTirer
            idBalle2Panzer = numeroDeLaBalleDuPanzerQuiDoitEtreTirer
            idBalle3Panzer = numeroDeLaBalleDuPanzerQuiDoitEtreTirer
            idBalle4Panzer = numeroDeLaBalleDuPanzerQuiDoitEtreTirer
            idBalle5Panzer = numeroDeLaBalleDuPanzerQuiDoitEtreTirer
            idBalle6Panzer = numeroDeLaBalleDuPanzerQuiDoitEtreTirer
            idBalle7Panzer = numeroDeLaBalleDuPanzerQuiDoitEtreTirer
            idBalle8Panzer = numeroDeLaBalleDuPanzerQuiDoitEtreTirer
            idBalle9Panzer = numeroDeLaBalleDuPanzerQuiDoitEtreTirer
            Timer_DeplacementDesBallesDuPanzer.Start()
        End If

        coteGaucheCanonDuPanzer.Location = supporDuCanonDuPanzer
        canonDuPanzer.Location = positionDuCanonDuPanzer
        corpsDuPanzer.Location = positionDuCorpsDuPanzer
        baliseDesBallesDuPanzer.Location = positionDeLaBaliseDesBallesDuPanzer
        limiteDroiteDuPanzer.Location = positionDeLalimiteDroiteDuPanzer
    End Sub

    Private Sub Timer_DeplacementDesBallesDuPanzer_Tick(sender As Object, e As EventArgs) Handles Timer_DeplacementDesBallesDuPanzer.Tick
        tirerLesBallesDuPanzer(numeroDeLaBalleDuPanzerQuiDoitEtreTirer)
    End Sub

    Private Sub Form1_KeyUp(sender As Object, evenement As KeyEventArgs) Handles Me.KeyUp
        'Ici on recupere la position du panzer lorsque l'ennnemi relâche l'une des touches directionnelles
        'Dans les conditions1 et conditions2  il question de determiner la position du panzer lorsque l'une des touches directionnelles est relâchée.

        If (evenement.KeyCode = Keys.Left) Then
            If (recupererPosDuPanzer) Then
                positionDuPanzerAvantLeLargageDuBoss = corpsDuPanzer.Location.X
                recupererPosDuPanzer = False
            End If
        End If


        If (evenement.KeyCode = Keys.Right) Then
            If (recupererPosDuPanzer) Then
                positionDuPanzerAvantLeLargageDuBoss = corpsDuPanzer.Location.X
                recupererPosDuPanzer = False
            End If
        End If

    End Sub

    Private Sub Timer_DuTempsQuiPasse_Tick(sender As Object, e As EventArgs) Handles Timer_DuTempsQuiPasse.Tick

        If (tempsQuiSecoule > 0) Then
            tempsQuiSecoule -= 1
            CadrantDuTempsQuiSecoule.Text = tempsQuiSecoule
        End If
        If (tempsQuiSecoule = 0) Then
            onContinue = False

            Scores_Et_Victoires.Score_Du_Boss.Text = Variables.scoreDuBoss
            Scores_Et_Victoires.Score_Du_Panzer.Text = Variables.scoreDuPanzer

            If (barreDeVieDuBoss.Value > barreDeVieDuPanzer.Value) Then
                victoireDuBoss += 1
                Scores_Et_Victoires.les_Victoires_Du_Boss.Text = victoireDuBoss
            End If

            If (barreDeVieDuBoss.Value < barreDeVieDuPanzer.Value) Then
                victoireDuPanzer += 1
                Scores_Et_Victoires.les_Victoires_Du_Panzer.Text = victoireDuPanzer
            End If

            'If (sentimentDuBoss = "facher") Then
            '    modifierLHumeurDuBoss("sourire")
            '    sentimentDuBoss = "sourire"
            'End If

            Timer_DuTempsQuiPasse.Stop()
            lesScoresEtLesNiveaux.Show()
        End If

    End Sub

    Private Sub bossChangeCouleursScore_Tick(sender As Object, e As EventArgs) Handles bossChangeCouleursScore.Tick
        scoreDuBoss.BackColor = Color.Orange
        onChangeDeCouleurBoss += 1

        If (onChangeDeCouleurBoss = 2) Then
            onChangeDeCouleurBoss = 0
            scoreDuBoss.BackColor = Color.Lime
            bossChangeCouleursScore.Stop()
        End If

    End Sub

    Private Sub panzerChangeCouleursScore_Tick(sender As Object, e As EventArgs) Handles panzerChangeCouleursScore.Tick
        scoreDuPanzer.BackColor = Color.Orange
        onChangeDeCouleurPanzer += 1

        If (onChangeDeCouleurPanzer = 2) Then
            onChangeDeCouleurPanzer = 0
            scoreDuPanzer.BackColor = Color.Lime
            panzerChangeCouleursScore.Stop()
        End If
    End Sub

    Private Sub Form1_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        lesScoresEtLesNiveaux.Dispose()
    End Sub
End Class
