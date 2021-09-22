Module Fonctions
    Public Sub modifierLHumeurDuBoss(ByVal sentimentDuBoss As String)
        'Ici il s'agit soit faire sourire le Boss, soit le faire se facher.
        'Dans la condition1 , si le Boss sourit alors on le fait se facher 
        'Dans la condition2 , si le boss est facher alors on le fait sourire

        point1Bouche = Form1.boucheSourirePts1.Location
        point2Bouche = Form1.boucheSourirePts2.Location
        point3Bouche = Form1.boucheSourirePts3.Location
        point4Bouche = Form1.boucheSourirePts4.Location
        point5Bouche = Form1.boucheSourirePts5.Location
        point6Bouche = Form1.boucheSourirePts6.Location

        If (sentimentDuBoss = "facher") Then
            'Condition1
            point1Bouche.Y += 7
            point2Bouche.Y -= 5
            point3Bouche.Y -= 12
            point4Bouche.Y -= 12
            point5Bouche.Y -= 4
            point6Bouche.Y += 7

            Form1.SourcilGauchePts1.Show()
            Form1.SourcilGauchePts2.Show()
            Form1.SourcilGauchePts3.Show()
            Form1.SourcilDroitPts1.Show()
            Form1.SourcilDroitPts2.Show()
            Form1.SourcilDroitPts3.Show()

            Form1.teteBossMechant.BackColor = Color.Red

        End If

        If (sentimentDuBoss = "sourire") Then
            'Condition2
            point1Bouche.Y -= 7
            point2Bouche.Y += 5
            point3Bouche.Y += 12
            point4Bouche.Y += 12
            point5Bouche.Y += 4
            point6Bouche.Y -= 7

            Form1.SourcilGauchePts1.Hide()
            Form1.SourcilGauchePts2.Hide()
            Form1.SourcilGauchePts3.Hide()
            Form1.SourcilDroitPts1.Hide()
            Form1.SourcilDroitPts2.Hide()
            Form1.SourcilDroitPts3.Hide()

            Form1.teteBossMechant.BackColor = Color.Green
        End If

        Form1.boucheSourirePts1.Location = point1Bouche
        Form1.boucheSourirePts2.Location = point2Bouche
        Form1.boucheSourirePts3.Location = point3Bouche
        Form1.boucheSourirePts4.Location = point4Bouche
        Form1.boucheSourirePts5.Location = point5Bouche
        Form1.boucheSourirePts6.Location = point6Bouche

    End Sub
    Public Sub declencherLaRiposteDuBossAvecSesBalles()
        numDeLaBalleQuiAeteTirer = 0
        activerLaballe1 = False
        activerLaballe2 = False
        activerLaballe3 = False
        activerLaballe4 = False
        activerLaballe5 = False
        activerLaballe6 = False
        activerLaballe7 = False
        activerLaballe8 = False
        activerLaballe9 = False

        Form1.timerDeDeplacementDeLaBalle1.Start()
        Form1.TimerDeDeplacemnentDeLaBalle2.Start()
        Form1.TimerDeDeplacemnentDeLaBalle3.Start()
        Form1.TimerDeDeplacemnentDeLaBalle4.Start()
        Form1.TimerDeDeplacemnentDeLaBalle5.Start()
        Form1.TimerDeDeplacemnentDeLaBalle6.Start()
        Form1.TimerDeDeplacemnentDeLaBalle7.Start()
        Form1.TimerDeDeplacemnentDeLaBalle8.Start()
        Form1.TimerDeDeplacemnentDeLaBalle9.Start()
        'TimerDeDplacementDeLaBalise.Start()
        Form1.Timer_Pour_CadencerLeTirDeBalles.Start()
    End Sub
    Public Sub calculDeLaPositionDuPanzerAvantLeTir()
        'Ici il est question de determiner la position du panzer avant ou après le tir du boss.
        If (positionDuPanzerAvantLeLargageDuBoss >= 100) And demarrerLeCalculDeLaPosDuPanzerAventLeTir Then
            If (positionDeLaTeteDuBoss.X < positionDuPanzerAvantLeLargageDuBoss) Then
                positionDuLargageDesBallesDuBoss = positionDuPanzerAvantLeLargageDuBoss - 50
            End If
            If (positionDeLaTeteDuBoss.X > positionDuPanzerAvantLeLargageDuBoss) Then
                positionDuLargageDesBallesDuBoss = positionDuPanzerAvantLeLargageDuBoss + 30
            End If
            demarrerLeCalculDeLaPosDuPanzerAventLeTir = False
        End If

        If (positionDeLaTeteDuBoss.X >= positionDuLargageDesBallesDuBoss) And autoriserLeTirDuBoss Then
            declencherLaRiposteDuBossAvecSesBalles()
            autoriserLeTirDuBoss = False
        End If
    End Sub
    Public Sub tirerLesBallesDuBoss(ByVal laBalle As Label, ByVal timerDeLaBalle As Timer, Optional ByVal arreterDeTirer As Boolean = True)
        'Ici il est question de deplacer la balle du Boss , la balle doit depasser la hauteur de la fenetre.
        'La balle apres le tir va retourner à la position de la balise en attente d'un nouveau tire.
        'Lorsque la balle aura depasser la hauteur de la fenetre alors , elle retournera à la position de la balise.
        'Dans la Condition1 il est question de depalacer(tirer) la balle , tant que celle ci n' pas encore depasser la hauteur de la fenetre. 
        'Explication1 Cette instruction nous permet de connaitre la position du panzer pendant qu'on effectue un tir de balle du Boss.
        'Explication2 Cette instrution va nous permettre de compter les degats à infliger au Panzer à chaque fois qu'une balle va atteindre sa position.
        If (arreterDeTirer) Then
            If (laBalle.Location.Y <= Form1.Height) Then 'Form1.frontiereDuBossEtDuHerosEtDesBalles(2)) Then
                'Condition1
                positionDeLaBalle = laBalle.Location
                positionDeLaBalle.Y += distanceParcourueParlesBallesPanzer
                compterLesDegatsInfligerAuPanzer(positionDeLaBalle) 'Explication2
                laBalle.Location = positionDeLaBalle
                positionDuPanzerAvantLeLargageDuBoss = Form1.corpsDuPanzer.Location.X 'Explication1
            ElseIf (laBalle.Location.Y > Form1.Height) Then 'Form1.frontiereDuBossEtDuHerosEtDesBalles(2)) Then
                laBalle.Location = Form1.copieDeLaBalise.Location
                arreterDeTirer = False
                timerDeLaBalle.Stop()
                numDeLaBalleQuiAeteTirer += 1
            End If
        End If
    End Sub
    Public Function choisirLaBalleQuiVaEtreTirer(ByVal numeroDeLaBalleDuPanzer As Integer) As Label
        Dim balleATirer As Label = Nothing

        Select Case numeroDeLaBalleDuPanzer
            Case 1
                balleATirer = Form1.balle1DuPanzer
            Case 2
                balleATirer = Form1.balle2DuPanzer
            Case 3
                balleATirer = Form1.balle3DuPanzer
            Case 4
                balleATirer = Form1.balle4DuPanzer
            Case 5
                balleATirer = Form1.balle5DuPanzer
            Case 6
                balleATirer = Form1.balle6DuPanzer
            Case 7
                balleATirer = Form1.balle7DuPanzer
            Case 8
                balleATirer = Form1.balle8DuPanzer
            Case 9
                balleATirer = Form1.balle9DuPanzer
        End Select

        Return balleATirer

    End Function
    Public Sub tirerLesBallesDuPanzer(ByVal numeroDeLaBalleDuPanzer As Integer)
        'Le principe de cette fonction c'est de tirer les balles à partir du numero de balle recuperer.
        'Le numero de balle est recuperer à chaque fois qu'on appuie sur la touche desugner pour tirer une balle.
        'Et le timer chargé du deplacement des balles lui il est toujours activé dans l'attente du deplacement d'une balle.
        'Jusqu'à la limite à ne pas depasser par ces balles(cette limite c'est l'axe des ordonnées , ça doit pas depasser 0)
        'Dans la partie II il est question de desactiver ou de repositionner la balle du panzer qui a déjà depasser la limite.

        If (idBalle1Panzer = 1 Or activerLaballe1DuPanzer = True) Then
            positionDeLaBalleDuPanzer = Form1.balle1DuPanzer.Location
            positionDeLaBalleDuPanzer.Y -= distanceParcourueParlesBallesPanzer
            compterLesDegatsInfligerAuBoss(positionDeLaBalleDuPanzer)
            idBalle1Panzer = -1
            If (positionDeLaBalleDuPanzer.Y > -10) Then
                activerLaballe1DuPanzer = True
                Form1.balle1DuPanzer.Location = positionDeLaBalleDuPanzer
            ElseIf (positionDeLaBalleDuPanzer.Y <= -10)
                activerLaballe1DuPanzer = False 'PARTIE II
                Form1.balle1DuPanzer.Location = Form1.baliseDesBallesDuPanzer.Location
            End If
        End If
        If (idBalle2Panzer = 2 Or activerLaballe2DuPanzer = True) Then
            positionDeLaBalle2DuPanzer = Form1.balle2DuPanzer.Location
            positionDeLaBalle2DuPanzer.Y -= distanceParcourueParlesBallesPanzer
            compterLesDegatsInfligerAuBoss(positionDeLaBalle2DuPanzer)
            idBalle2Panzer = -1
            If (positionDeLaBalle2DuPanzer.Y > -10) Then
                activerLaballe2DuPanzer = True
                Form1.balle2DuPanzer.Location = positionDeLaBalle2DuPanzer
            ElseIf (positionDeLaBalle2DuPanzer.Y <= -10)
                activerLaballe2DuPanzer = False 'PARTIE II
                Form1.balle2DuPanzer.Location = Form1.baliseDesBallesDuPanzer.Location
            End If
        End If
        If (idBalle3Panzer = 3 Or activerLaballe3DuPanzer = True) Then
            positionDeLaBalle3DuPanzer = Form1.balle3DuPanzer.Location
            positionDeLaBalle3DuPanzer.Y -= distanceParcourueParlesBallesPanzer
            compterLesDegatsInfligerAuBoss(positionDeLaBalle3DuPanzer)
            Form1.ballesDuPanzer.Text = "position de Balle3 : " & positionDeLaBalle3DuPanzer.Y
            idBalle3Panzer = -1
            If (positionDeLaBalle3DuPanzer.Y > -10) Then
                activerLaballe3DuPanzer = True
                Form1.balle3DuPanzer.Location = positionDeLaBalle3DuPanzer
            ElseIf (positionDeLaBalle3DuPanzer.Y <= -10)
                activerLaballe3DuPanzer = False 'PARTIE II
                Form1.balle3DuPanzer.Location = Form1.baliseDesBallesDuPanzer.Location
            End If
        End If
        If (idBalle4Panzer = 4 Or activerLaballe4DuPanzer = True) Then
            positionDeLaBalle4DuPanzer = Form1.balle4DuPanzer.Location
            positionDeLaBalle4DuPanzer.Y -= distanceParcourueParlesBallesPanzer
            compterLesDegatsInfligerAuBoss(positionDeLaBalle4DuPanzer)
            idBalle4Panzer = -1
            If (positionDeLaBalle4DuPanzer.Y > -10) Then
                activerLaballe4DuPanzer = True
                Form1.balle4DuPanzer.Location = positionDeLaBalle4DuPanzer
            ElseIf (positionDeLaBalle4DuPanzer.Y <= -10)
                activerLaballe4DuPanzer = False
                Form1.balle4DuPanzer.Location = Form1.baliseDesBallesDuPanzer.Location
            End If
        End If
        If (idBalle5Panzer = 5 Or activerLaballe5DuPanzer = True) Then
            positionDeLaBalle5DuPanzer = Form1.balle5DuPanzer.Location
            positionDeLaBalle5DuPanzer.Y -= distanceParcourueParlesBallesPanzer
            compterLesDegatsInfligerAuBoss(positionDeLaBalle5DuPanzer)
            idBalle5Panzer = -1
            If (positionDeLaBalle5DuPanzer.Y > -10) Then
                activerLaballe5DuPanzer = True
                Form1.balle5DuPanzer.Location = positionDeLaBalle5DuPanzer
            ElseIf (positionDeLaBalle5DuPanzer.Y <= -10)
                activerLaballe5DuPanzer = False
                Form1.balle5DuPanzer.Location = Form1.baliseDesBallesDuPanzer.Location
            End If
        End If
        If (idBalle6Panzer = 6 Or activerLaballe6DuPanzer = True) Then
            positionDeLaBalle6DuPanzer = Form1.balle6DuPanzer.Location
            positionDeLaBalle6DuPanzer.Y -= distanceParcourueParlesBallesPanzer
            compterLesDegatsInfligerAuBoss(positionDeLaBalle6DuPanzer)
            idBalle6Panzer = -1
            If (positionDeLaBalle6DuPanzer.Y > -10) Then
                activerLaballe6DuPanzer = True
                Form1.balle6DuPanzer.Location = positionDeLaBalle6DuPanzer
            ElseIf (positionDeLaBalle6DuPanzer.Y <= -10)
                activerLaballe6DuPanzer = False
                Form1.balle6DuPanzer.Location = Form1.baliseDesBallesDuPanzer.Location
            End If
        End If
        If (idBalle7Panzer = 7 Or activerLaballe7DuPanzer = True) Then
            positionDeLaBalle7DuPanzer = Form1.balle7DuPanzer.Location
            positionDeLaBalle7DuPanzer.Y -= distanceParcourueParlesBallesPanzer
            compterLesDegatsInfligerAuBoss(positionDeLaBalle7DuPanzer)
            idBalle7Panzer = -1
            If (positionDeLaBalle7DuPanzer.Y > -10) Then
                activerLaballe7DuPanzer = True
                Form1.balle7DuPanzer.Location = positionDeLaBalle7DuPanzer
            ElseIf (positionDeLaBalle7DuPanzer.Y <= -10)
                activerLaballe7DuPanzer = False
                Form1.balle7DuPanzer.Location = Form1.baliseDesBallesDuPanzer.Location
            End If
        End If

        If (idBalle8Panzer = 8 Or activerLaballe8DuPanzer = True) Then
            positionDeLaBalle8DuPanzer = Form1.balle8DuPanzer.Location
            positionDeLaBalle8DuPanzer.Y -= distanceParcourueParlesBallesPanzer
            compterLesDegatsInfligerAuBoss(positionDeLaBalle8DuPanzer)
            idBalle8Panzer = -1
            If (positionDeLaBalle8DuPanzer.Y > -10) Then
                activerLaballe8DuPanzer = True
                Form1.balle8DuPanzer.Location = positionDeLaBalle8DuPanzer
            ElseIf (positionDeLaBalle8DuPanzer.Y <= -10)
                activerLaballe8DuPanzer = False
                Form1.balle8DuPanzer.Location = Form1.baliseDesBallesDuPanzer.Location
            End If
        End If

        If (idBalle9Panzer = 9 Or activerLaballe9DuPanzer = True) Then
            positionDeLaBalle9DuPanzer = Form1.balle9DuPanzer.Location
            positionDeLaBalle9DuPanzer.Y -= distanceParcourueParlesBallesPanzer
            compterLesDegatsInfligerAuBoss(positionDeLaBalle9DuPanzer)
            idBalle9Panzer = -1
            If (positionDeLaBalle9DuPanzer.Y > -10) Then
                activerLaballe9DuPanzer = True
                Form1.balle9DuPanzer.Location = positionDeLaBalle9DuPanzer
            ElseIf (positionDeLaBalle9DuPanzer.Y <= -10)
                activerLaballe9DuPanzer = False
                numeroDeLaBalleDuPanzerQuiDoitEtreTirer = 0
                Form1.balle9DuPanzer.Location = Form1.baliseDesBallesDuPanzer.Location
            End If
        End If

    End Sub
    Public Sub deplacerLesBallesAvecLaBaliseVersLaDroite()
        'Ici il est question de faire avencer les balles avec la balise lorsque celle ci doivent avancer avec la balise.
        'La valeur 10 qu'on ajoute ou qu'on retire sur la position de la balle , c'est pour combler un retard.
        'En effet quand on dit a la balle de prendre la position de la balise et que directement après la balise augmente sa position
        'alors on aura une balle qui va prendre une ancienne position ,apres cette prise de position , alors la balise va en prendre une nouvelle
        'Ce qui aura pour effet de creer unretard entre la prise de position de la balle et la prise de position de la balise.
        'Car la balise donne toujours une ancienne position à la balle , et en prend une nouvelle immediatement après.
        'Donc on va ajouter ou retirer 10 pour prevoir le retard et ainsi afficher la balle à la meme position que la balise.


        If (deplacerLaballe1AvecLaBalise Or numDeLaBalleQuiAeteTirer = 1) Then
            pos = Form1.copieDeLaBalise.Location
            pos.X += 10
            Form1.Balle1Copie.Location = pos
            deplacerLaballe1AvecLaBalise = True
        End If
        If (deplacerLaballe2AvecLaBalise Or numDeLaBalleQuiAeteTirer = 2) Then
            pos = Form1.copieDeLaBalise.Location
            pos.X += 10
            Form1.Balle2Copie.Location = pos
            deplacerLaballe2AvecLaBalise = True
        End If
        If (deplacerLaballe3AvecLaBalise Or numDeLaBalleQuiAeteTirer = 3) Then
            pos = Form1.copieDeLaBalise.Location
            pos.X += 10
            Form1.Balle3Copie.Location = pos
            deplacerLaballe3AvecLaBalise = True
        End If
        If (deplacerLaballe4AvecLaBalise Or numDeLaBalleQuiAeteTirer = 4) Then
            pos = Form1.copieDeLaBalise.Location
            pos.X += 10
            Form1.Balle4Copie.Location = pos
            deplacerLaballe4AvecLaBalise = True
        End If
        If (deplacerLaballe5AvecLaBalise Or numDeLaBalleQuiAeteTirer = 5) Then
            pos = Form1.copieDeLaBalise.Location
            pos.X += 10
            Form1.Balle5Copie.Location = pos
            deplacerLaballe5AvecLaBalise = True
        End If
        If (deplacerLaballe6AvecLaBalise Or numDeLaBalleQuiAeteTirer = 6) Then
            pos = Form1.copieDeLaBalise.Location
            pos.X += 10
            Form1.Balle6Copie.Location = pos
            deplacerLaballe6AvecLaBalise = True
        End If
        If (deplacerLaballe7AvecLaBalise Or numDeLaBalleQuiAeteTirer = 7) Then
            pos = Form1.copieDeLaBalise.Location
            pos.X += 10
            Form1.Balle7Copie.Location = pos
            deplacerLaballe7AvecLaBalise = True
        End If
        If (deplacerLaballe8AvecLaBalise Or numDeLaBalleQuiAeteTirer = 8) Then
            pos = Form1.copieDeLaBalise.Location
            pos.X += 10
            Form1.Balle8Copie.Location = pos
            deplacerLaballe8AvecLaBalise = True
        End If
        If (deplacerLaballe9AvecLaBalise Or numDeLaBalleQuiAeteTirer = 9) Then
            pos = Form1.copieDeLaBalise.Location
            pos.X += 10
            Form1.Balle9Copie.Location = pos
            deplacerLaballe9AvecLaBalise = True
        End If



    End Sub
    Public Sub deplacerLesBallesAvecLaBaliseVersLaGauche()
        'Memme chose que ce qui a ete decrit juste en haut.

        If (deplacerLaballe1AvecLaBalise Or numDeLaBalleQuiAeteTirer = 1) Then
            pos = Form1.copieDeLaBalise.Location
            pos.X -= 10
            Form1.Balle1Copie.Location = pos
            deplacerLaballe1AvecLaBalise = True
        End If
        If (deplacerLaballe2AvecLaBalise Or numDeLaBalleQuiAeteTirer = 2) Then
            pos = Form1.copieDeLaBalise.Location
            pos.X -= 10
            Form1.Balle2Copie.Location = pos
            deplacerLaballe2AvecLaBalise = True
        End If
        If (deplacerLaballe3AvecLaBalise Or numDeLaBalleQuiAeteTirer = 3) Then
            pos = Form1.copieDeLaBalise.Location
            pos.X -= 10
            Form1.Balle3Copie.Location = pos
            deplacerLaballe3AvecLaBalise = True
        End If
        If (deplacerLaballe4AvecLaBalise Or numDeLaBalleQuiAeteTirer = 4) Then
            pos = Form1.copieDeLaBalise.Location
            pos.X -= 10
            Form1.Balle4Copie.Location = pos
            deplacerLaballe4AvecLaBalise = True
        End If
        If (deplacerLaballe5AvecLaBalise Or numDeLaBalleQuiAeteTirer = 5) Then
            pos = Form1.copieDeLaBalise.Location
            pos.X -= 10
            Form1.Balle5Copie.Location = pos
            deplacerLaballe5AvecLaBalise = True
        End If
        If (deplacerLaballe6AvecLaBalise Or numDeLaBalleQuiAeteTirer = 6) Then
            pos = Form1.copieDeLaBalise.Location
            pos.X -= 10
            Form1.Balle6Copie.Location = pos
            deplacerLaballe6AvecLaBalise = True
        End If
        If (deplacerLaballe7AvecLaBalise Or numDeLaBalleQuiAeteTirer = 7) Then
            pos = Form1.copieDeLaBalise.Location
            pos.X -= 10
            Form1.Balle7Copie.Location = pos
            deplacerLaballe7AvecLaBalise = True
        End If
        If (deplacerLaballe8AvecLaBalise Or numDeLaBalleQuiAeteTirer = 8) Then
            pos = Form1.copieDeLaBalise.Location
            pos.X -= 10
            Form1.Balle8Copie.Location = pos
            deplacerLaballe8AvecLaBalise = True
        End If
        If (deplacerLaballe9AvecLaBalise Or numDeLaBalleQuiAeteTirer = 9) Then
            pos = Form1.copieDeLaBalise.Location
            pos.X -= 10
            Form1.Balle9Copie.Location = pos
            deplacerLaballe9AvecLaBalise = True
        End If
    End Sub
    Public Sub deplacerLesBallesDuPanzerAvecBaliseVersLaDroite()
        If (activerLaballe1DuPanzer = False) Then
            positionDeLaBalleDuPanzer = Form1.baliseDesBallesDuPanzer.Location
            positionDeLaBalleDuPanzer.X += nbreDePasDeDeplacementDuPanzer
            Form1.balle1DuPanzer.Location = positionDeLaBalleDuPanzer
        End If
        If (activerLaballe2DuPanzer = False) Then
            positionDeLaBalle2DuPanzer = Form1.baliseDesBallesDuPanzer.Location
            positionDeLaBalle2DuPanzer.X += nbreDePasDeDeplacementDuPanzer
            Form1.balle2DuPanzer.Location = positionDeLaBalle2DuPanzer
        End If
        If (activerLaballe3DuPanzer = False) Then
            positionDeLaBalle3DuPanzer = Form1.baliseDesBallesDuPanzer.Location
            positionDeLaBalle3DuPanzer.X += nbreDePasDeDeplacementDuPanzer
            Form1.balle3DuPanzer.Location = positionDeLaBalle3DuPanzer
        End If
        If (activerLaballe3DuPanzer = False) Then
            positionDeLaBalle3DuPanzer = Form1.baliseDesBallesDuPanzer.Location
            positionDeLaBalle3DuPanzer.X += nbreDePasDeDeplacementDuPanzer
            Form1.balle3DuPanzer.Location = positionDeLaBalle3DuPanzer
        End If
        If (activerLaballe4DuPanzer = False) Then
            positionDeLaBalle4DuPanzer = Form1.baliseDesBallesDuPanzer.Location
            positionDeLaBalle4DuPanzer.X += nbreDePasDeDeplacementDuPanzer
            Form1.balle4DuPanzer.Location = positionDeLaBalle4DuPanzer
        End If
        If (activerLaballe5DuPanzer = False) Then
            positionDeLaBalle5DuPanzer = Form1.baliseDesBallesDuPanzer.Location
            positionDeLaBalle5DuPanzer.X += nbreDePasDeDeplacementDuPanzer
            Form1.balle5DuPanzer.Location = positionDeLaBalle5DuPanzer
        End If
        If (activerLaballe6DuPanzer = False) Then
            positionDeLaBalle6DuPanzer = Form1.baliseDesBallesDuPanzer.Location
            positionDeLaBalle6DuPanzer.X += nbreDePasDeDeplacementDuPanzer
            Form1.balle6DuPanzer.Location = positionDeLaBalle6DuPanzer
        End If
        If (activerLaballe7DuPanzer = False) Then
            positionDeLaBalle7DuPanzer = Form1.baliseDesBallesDuPanzer.Location
            positionDeLaBalle7DuPanzer.X += nbreDePasDeDeplacementDuPanzer
            Form1.balle7DuPanzer.Location = positionDeLaBalle7DuPanzer
        End If
        If (activerLaballe8DuPanzer = False) Then
            positionDeLaBalle8DuPanzer = Form1.baliseDesBallesDuPanzer.Location
            positionDeLaBalle8DuPanzer.X += nbreDePasDeDeplacementDuPanzer
            Form1.balle8DuPanzer.Location = positionDeLaBalle8DuPanzer
        End If
        If (activerLaballe9DuPanzer = False) Then
            positionDeLaBalle9DuPanzer = Form1.baliseDesBallesDuPanzer.Location
            positionDeLaBalle9DuPanzer.X += nbreDePasDeDeplacementDuPanzer
            Form1.balle9DuPanzer.Location = positionDeLaBalle9DuPanzer
        End If
    End Sub
    Public Sub deplacerLesBallesDuPanzerAvecBaliseVersLaGauche()
        If (activerLaballe1DuPanzer = False) Then
            positionDeLaBalleDuPanzer = Form1.baliseDesBallesDuPanzer.Location
            positionDeLaBalleDuPanzer.X -= nbreDePasDeDeplacementDuPanzer
            Form1.balle1DuPanzer.Location = positionDeLaBalleDuPanzer
        End If
        If (activerLaballe2DuPanzer = False) Then
            positionDeLaBalle2DuPanzer = Form1.baliseDesBallesDuPanzer.Location
            positionDeLaBalle2DuPanzer.X -= nbreDePasDeDeplacementDuPanzer
            Form1.balle2DuPanzer.Location = positionDeLaBalle2DuPanzer
        End If
        If (activerLaballe3DuPanzer = False) Then
            positionDeLaBalle3DuPanzer = Form1.baliseDesBallesDuPanzer.Location
            positionDeLaBalle3DuPanzer.X -= nbreDePasDeDeplacementDuPanzer
            Form1.balle3DuPanzer.Location = positionDeLaBalle3DuPanzer
        End If
        If (activerLaballe3DuPanzer = False) Then
            positionDeLaBalle3DuPanzer = Form1.baliseDesBallesDuPanzer.Location
            positionDeLaBalle3DuPanzer.X -= nbreDePasDeDeplacementDuPanzer
            Form1.balle3DuPanzer.Location = positionDeLaBalle3DuPanzer
        End If
        If (activerLaballe4DuPanzer = False) Then
            positionDeLaBalle4DuPanzer = Form1.baliseDesBallesDuPanzer.Location
            positionDeLaBalle4DuPanzer.X -= nbreDePasDeDeplacementDuPanzer
            Form1.balle4DuPanzer.Location = positionDeLaBalle4DuPanzer
        End If
        If (activerLaballe5DuPanzer = False) Then
            positionDeLaBalle5DuPanzer = Form1.baliseDesBallesDuPanzer.Location
            positionDeLaBalle5DuPanzer.X -= nbreDePasDeDeplacementDuPanzer
            Form1.balle5DuPanzer.Location = positionDeLaBalle5DuPanzer
        End If
        If (activerLaballe6DuPanzer = False) Then
            positionDeLaBalle6DuPanzer = Form1.baliseDesBallesDuPanzer.Location
            positionDeLaBalle6DuPanzer.X -= nbreDePasDeDeplacementDuPanzer
            Form1.balle6DuPanzer.Location = positionDeLaBalle6DuPanzer
        End If
        If (activerLaballe7DuPanzer = False) Then
            positionDeLaBalle7DuPanzer = Form1.baliseDesBallesDuPanzer.Location
            positionDeLaBalle7DuPanzer.X -= nbreDePasDeDeplacementDuPanzer
            Form1.balle7DuPanzer.Location = positionDeLaBalle7DuPanzer
        End If
        If (activerLaballe8DuPanzer = False) Then
            positionDeLaBalle8DuPanzer = Form1.baliseDesBallesDuPanzer.Location
            positionDeLaBalle8DuPanzer.X -= nbreDePasDeDeplacementDuPanzer
            Form1.balle8DuPanzer.Location = positionDeLaBalle8DuPanzer
        End If
        If (activerLaballe9DuPanzer = False) Then
            positionDeLaBalle9DuPanzer = Form1.baliseDesBallesDuPanzer.Location
            positionDeLaBalle9DuPanzer.X -= nbreDePasDeDeplacementDuPanzer
            Form1.balle9DuPanzer.Location = positionDeLaBalle9DuPanzer
        End If
    End Sub
    Public Sub compterLesDegatsInfligerAuPanzer(ByVal positionDeLABalleALimpact As Point)
        'Ici on va verifier si la balle tirer par le boss a atteint sa cible.
        'Ca consiste à verifier si la balle est situé entre l'abscisse du corps du panzer et la limite droite du corpsDuPanzer d'abord
        'Puis de verifier si cette balle à traverser l'ordonnée du corpsDuPanzer
        'Dans la condition1 on va changer la couleur de sa barre vie ,si sa valeur devient plus petite que 50 ou egale à 50
        'Explication1 on a Hide() les labelqui permettent d'afficher cette valeur, si tu la show alors tu pourras enlever le commentaire dessus.
        'Explication2 ici il est question qu'à chaque fois que le boss va toucher le panzer alors on va augmenter son score.
        'Explication3 ici il est question de compter le nombre de victoires du Boss.
        If (positionDeLABalleALimpact.X >= Form1.corpsDuPanzer.Location.X And positionDeLABalleALimpact.X <= Form1.limiteDroiteDuPanzer.Location.X) Then

            If (positionDeLABalleALimpact.Y >= Form1.Height) Then
                'degatInfligerAuPanzer += nbreDeDegatAInfliger'Explication1
                If (Form1.barreDeVieDuPanzer.Value > 0 And onContinue) Then
                    Form1.bossChangeCouleursScore.Start()
                    scoreDuBoss += 20 'Explication2
                    Form1.scoreDuBoss.Text = "Boss Score: +" & scoreDuBoss 'Explication2
                    Form1.barreDeVieDuPanzer.Value -= 20
                ElseIf (Form1.barreDeVieDuPanzer.Value = 0)
                    If (activerLeDecompteDesVictoires) Then
                        victoireDuBoss += 1 'Explication3
                        Scores_Et_Victoires.les_Victoires_Du_Boss.Text = victoireDuBoss
                        activerLeDecompteDesVictoires = False
                        lesScoresEtLesNiveaux.Show()
                    End If
                    onContinue = False
                    Form1.Timer_DuTempsQuiPasse.Stop()
                        'C'est ici qu'on utilise lE scoreEtlEsNiveaux
                    End If

                If (Form1.barreDeVieDuPanzer.Value <= (Form1.barreDeVieDuPanzer.Maximum / 2)) Then
                    'Condition1
                    Form1.barreDeVieDuPanzer.ForeColor = Color.Red
                End If
                'Form1.compteurDeDegats.Text = "Degats sur Panzer :" & degatInfligerAuPanzer'Explication1

            End If
        End If
    End Sub
    Public Sub tempsQuiSecouleEntreLesTirsDuBoss()
        'Ici on a plusieurs types de salves de tirs effectuée par le Boss et chacune des salves va être executée l'une après l'autre.
        'IL FAUT GERER L'ESPACE ENTRE LES BALLES.
        If (numeroDeSalveDeTir = 1) Then
            Select Case (tempsApresLequelUneBalleEstTirer)
                Case 2
                    activerLaballe1 = True
                    deplacerLaballe1AvecLaBalise = False
                Case 8
                    activerLaballe2 = True
                    deplacerLaballe2AvecLaBalise = False
                Case 16
                    activerLaballe3 = True
                    deplacerLaballe3AvecLaBalise = False
                Case 24
                    activerLaballe4 = True
                    deplacerLaballe4AvecLaBalise = False
                Case 32
                    activerLaballe5 = True
                    deplacerLaballe5AvecLaBalise = False
                Case 40
                    activerLaballe6 = True
                    deplacerLaballe6AvecLaBalise = False
                Case 45
                    activerLaballe7 = True
                    deplacerLaballe7AvecLaBalise = False
                Case 52
                    activerLaballe8 = True
                    deplacerLaballe8AvecLaBalise = False
                Case 60
                    activerLaballe9 = True
                    deplacerLaballe9AvecLaBalise = False
            End Select
        ElseIf (numeroDeSalveDeTir = 2)
            Select Case (tempsApresLequelUneBalleEstTirer)
                Case 2
                    activerLaballe1 = True
                    deplacerLaballe1AvecLaBalise = False
                Case 6
                    activerLaballe2 = True
                    deplacerLaballe2AvecLaBalise = False
                Case 10
                    activerLaballe3 = True
                    deplacerLaballe3AvecLaBalise = False
                Case 14
                    activerLaballe4 = True
                    deplacerLaballe4AvecLaBalise = False
                Case 18
                    activerLaballe5 = True
                    deplacerLaballe5AvecLaBalise = False
                Case 22
                    activerLaballe6 = True
                    deplacerLaballe6AvecLaBalise = False
                Case 26
                    activerLaballe7 = True
                    deplacerLaballe7AvecLaBalise = False
                Case 30
                    activerLaballe8 = True
                    deplacerLaballe8AvecLaBalise = False
                Case 34
                    activerLaballe9 = True
                    deplacerLaballe9AvecLaBalise = False
            End Select
        ElseIf (numeroDeSalveDeTir = 3)
            Select Case (tempsApresLequelUneBalleEstTirer)
                Case 2
                    activerLaballe1 = True
                    deplacerLaballe1AvecLaBalise = False
                Case 4
                    activerLaballe2 = True
                    deplacerLaballe2AvecLaBalise = False
                Case 6
                    activerLaballe3 = True
                    deplacerLaballe3AvecLaBalise = False
                Case 8
                    activerLaballe4 = True
                    deplacerLaballe4AvecLaBalise = False
                Case 10
                    activerLaballe5 = True
                    deplacerLaballe5AvecLaBalise = False
                Case 12
                    activerLaballe6 = True
                    deplacerLaballe6AvecLaBalise = False
                Case 16
                    activerLaballe7 = True
                    deplacerLaballe7AvecLaBalise = False
                Case 18
                    activerLaballe8 = True
                    deplacerLaballe8AvecLaBalise = False
                Case 20
                    activerLaballe9 = True
                    deplacerLaballe9AvecLaBalise = False
            End Select
        ElseIf (numeroDeSalveDeTir = 4)
            Select Case (tempsApresLequelUneBalleEstTirer)
                Case 2
                    activerLaballe1 = True
                    deplacerLaballe1AvecLaBalise = False
                Case 12
                    activerLaballe2 = True
                    deplacerLaballe2AvecLaBalise = False
                Case 22
                    activerLaballe3 = True
                    deplacerLaballe3AvecLaBalise = False
                Case 30
                    activerLaballe4 = True
                    deplacerLaballe4AvecLaBalise = False
                Case 35
                    activerLaballe5 = True
                    deplacerLaballe5AvecLaBalise = False
                Case 38
                    activerLaballe6 = True
                    deplacerLaballe6AvecLaBalise = False
                Case 60
                    activerLaballe7 = True
                    deplacerLaballe7AvecLaBalise = False
                Case 70
                    activerLaballe8 = True
                    deplacerLaballe8AvecLaBalise = False
                Case 80
                    activerLaballe9 = True
                    deplacerLaballe9AvecLaBalise = False
            End Select
        ElseIf (numeroDeSalveDeTir = 5)
            Select Case (tempsApresLequelUneBalleEstTirer)
                Case 1
                    activerLaballe1 = True
                    deplacerLaballe1AvecLaBalise = False
                Case 9
                    activerLaballe2 = True
                    deplacerLaballe2AvecLaBalise = False
                Case 18
                    activerLaballe3 = True
                    deplacerLaballe3AvecLaBalise = False
                Case 27
                    activerLaballe4 = True
                    deplacerLaballe4AvecLaBalise = False
                Case 35
                    activerLaballe5 = True
                    deplacerLaballe5AvecLaBalise = False
                Case 42
                    activerLaballe6 = True
                    deplacerLaballe6AvecLaBalise = False
                Case 51
                    activerLaballe7 = True
                    deplacerLaballe7AvecLaBalise = False
                Case 60
                    activerLaballe8 = True
                    deplacerLaballe8AvecLaBalise = False
                Case 69
                    activerLaballe9 = True
                    deplacerLaballe9AvecLaBalise = False
            End Select
        End If
    End Sub
    Public Sub compterLesDegatsInfligerAuBoss(ByVal positionDeLABalleALimpact As Point)
        'Ici on va verifier si la balle tirer par le panzer a atteint sa cible.
        'Ca consiste à verifier si la balle est situé entre l'abscisse du corps du boss et la limite droite de la teteDuBossMechant d'abord
        'Puis de verifier si cette balle à traverser l'ordonnée de la teteDuBossMechant
        'Dans la condition2 on va verifier  si les points de vie du Boss ont atteint 50 ou sont inferieure à 50.
        'Si c'est st le cas alors on change la couleur de la barre de vie en rouge, et son humeur a changer ,il va se mettre en colère.
        'Dans la condition1  on va verifier si les points de degats infliger au boss sont supérieure ou égale à 100.
        'Si c'est le cas on va faire en sorte que l'humeur du boss change il va se mettre en colère. 
        'Explication3 onContinue  c'sst la variable qui nous permet de savoir si l'une des barres de vie est terminée.
        If (positionDeLABalleALimpact.X >= Form1.teteBossMechant.Location.X And positionDeLABalleALimpact.X <= Form1.limiteDroiteDuBoss.Location.X) Then

            If (positionDeLABalleALimpact.Y < 0) Then
                'degatInfligerAuBoss += nbreDeDegatAInfliger

                If (Form1.barreDeVieDuBoss.Value > 0 And onContinue) Then
                    Form1.panzerChangeCouleursScore.Start()
                    scoreDuPanzer += 20 'Explication2
                    Form1.scoreDuPanzer.Text = "Mon Score: +" & scoreDuPanzer 'Explication2
                    Form1.barreDeVieDuBoss.Value -= nbreDeDegatAInfliger
                ElseIf (Form1.barreDeVieDuBoss.Value = 0)

                    If (activerLeDecompteDesVictoires) Then
                        victoireDuPanzer += 1 'Explication3
                        Scores_Et_Victoires.les_Victoires_Du_Panzer.Text = victoireDuPanzer
                        lesScoresEtLesNiveaux.Show()
                        activerLeDecompteDesVictoires = False
                    End If

                    onContinue = False
                    Form1.Timer_DuTempsQuiPasse.Stop()
                    'C'est ici qu'on utilise lE scoreEtlEsNiveaux
                End If

                If (Form1.barreDeVieDuBoss.Value <= (Form1.barreDeVieDuBoss.Maximum / 2)) Then
                    'Condition2
                    Form1.barreDeVieDuBoss.ForeColor = Color.Red
                    If (sentimentDuBoss = "sourire") Then
                        modifierLHumeurDuBoss("facher")
                        sentimentDuBoss = "facher"
                    End If
                End If

                'Form1.compteurDeDegatsDuBoss.Text = "Degats sur Boss :" & degatInfligerAuBoss
                'If (degatInfligerAuBoss >= 100) Then
                '    'Condition1
                '    If (sentimentDuBoss = "sourire") Then
                '        modifierLHumeurDuBoss("facher")
                '        sentimentDuBoss = "facher"
                '    End If
                'End If
            End If
        End If
    End Sub
    Public Function onContinueLeJeu() As Boolean
        If (Form1.CadrantDuTempsQuiSecoule.Text = "0") Or Form1.barreDeVieDuBoss.Value = 0 Or Form1.barreDeVieDuPanzer.Value = 0 Then
            onContinue = False 'on decide ou pas de continuer le jeu.
        End If
        Return onContinue
    End Function
End Module
