Module Variables
    'Utilite de la longue declaration , quand une seul balle est tirer alors il faut qu'on specifie que apres le tir la balle ne doit pas se tirer encore seul.
    'Alors on cree l'Id pour que si seulement un seul tire est effectué alors , la balle va occupé la meme position que la balise ,après que le tire ait ete effectué.  .
    Public point1Bouche As Point
    Public point2Bouche As Point
    Public point3Bouche As Point
    Public point4Bouche As Point
    Public point5Bouche As Point
    Public point6Bouche As Point
    Public positionDeLaBalle As Point
    Public vitesseDeLaTeteDuBoss As Integer 'C'est en realite l'intervalle qu'on va mettre dans son timer.
    Public numeroDeLaBalleDuPanzerQuiDoitEtreTirer As Integer = 0
    Public numDeLaBalleQuiAeteTirer As Integer = 0
    Public nbreDePasDeDeplacementDuPanzer As Integer = 10 'Facile =12 ,Intermediaire=8, Difficile=4 
    'Cette longue declaration a une utilite specifique.
    Public idBalle1Panzer, idBalle2Panzer, idBalle3Panzer, idBalle4Panzer, idBalle5Panzer, idBalle6Panzer, idBalle7Panzer, idBalle8Panzer, idBalle9Panzer As Integer
    Public positionDuPanzerAvantLeLargageDuBoss, positionDuLargageDesBallesDuBoss, degatInfligerAuPanzer, degatInfligerAuBoss As Integer
    Public tempsApresLequelUneBalleEstTirer As Integer = 0 'En secondes
    Public temps As DateTime = DateTime.Now
    Public nbreDeDegatAInfliger As Integer = 10 'Ici on a le nombre de degat à infliger lorsque l'une des cibles est touchée
    Public cadenceDeTirDesBalles As Integer = temps.Second
    Public scoreDuBoss As Integer = 0
    Public scoreDuPanzer As Integer = 0
    Public onChangeDeCouleurBoss As Integer = 0
    Public onChangeDeCouleurPanzer As Integer = 0
    Public nbreDeSalveLimite = 5 'Ne peut depasser 5 puisqu'il n'y en a que 5.'REGRADE ICI <<<<<<<<<<<<<<
    Public numeroDeSalveDeTir As Integer = 1
    Public pasEntreBallesBoss As Integer = 8
    Public victoireDuBoss As Integer = 0
    Public victoireDuPanzer As Integer = 0
    Public activerLeDecompteDesVictoires As Boolean = True
    Public onContinue As Boolean = True 'Ici on decide si on va continuer le jeu.
    Public tempsChoisis As Integer = 600
    Public tempsQuiSecoule As Integer = tempsChoisis '*********TEMPS QUI S'ECOULE
    Public activerLaballe1, activerLaballe2, activerLaballe3, activerLaballe4, activerLaballe5, activerLaballe6, activerLaballe7, activerLaballe8, activerLaballe9
    Public activerLaballe1DuPanzer, activerLaballe2DuPanzer, activerLaballe3DuPanzer, activerLaballe4DuPanzer, activerLaballe5DuPanzer, activerLaballe6DuPanzer, activerLaballe7DuPanzer, activerLaballe8DuPanzer, activerLaballe9DuPanzer
    Public deplacerLaballe1AvecLaBalise, deplacerLaballe2AvecLaBalise, deplacerLaballe3AvecLaBalise, deplacerLaballe4AvecLaBalise, deplacerLaballe5AvecLaBalise, deplacerLaballe6AvecLaBalise, deplacerLaballe7AvecLaBalise, deplacerLaballe8AvecLaBalise, deplacerLaballe9AvecLaBalise
    Public demarrerLeCalculDeLaPosDuPanzerAventLeTir As Boolean = True
    Public recupererPosDuPanzer As Boolean = True
    Public autoriserLeTirDuBoss As Boolean = True
    Public positionDeLaLimiteDroiteDuBoss As Point = Form1.limiteDroiteDuBoss.Location
    Public positionDeLalimiteDroiteDuPanzer As Point = Form1.limiteDroiteDuPanzer.Location
    Public positionDeLoeil1 As Point = Form1.oeil1.Location
    Public positionDeLoeil2 As Point = Form1.oeil2.Location
    Public positionDeLabalise As Point = Form1.copieDeLaBalise.Location
    Public positionDuCanonDuPanzer As Point = Form1.canonDuPanzer.Location
    Public positionDuCorpsDuPanzer As Point = Form1.corpsDuPanzer.Location
    Public supporDuCanonDuPanzer As Point = Form1.coteGaucheCanonDuPanzer.Location
    Public pos, positionDeLaBalleDuPanzer, positionDeLaBalle2DuPanzer, positionDeLaBalle3DuPanzer, positionDeLaBalle4DuPanzer, positionDeLaBalle5DuPanzer, positionDeLaBalle6DuPanzer, positionDeLaBalle7DuPanzer, positionDeLaBalle8DuPanzer, positionDeLaBalle9DuPanzer As Point
    Public distanceParcourueParlesBallesPanzer As Integer = 10
    Public positionDeLaBaliseDesBallesDuPanzer As Point = Form1.baliseDesBallesDuPanzer.Location
    Public positionDuSourcilGauchePts1 As Point = Form1.SourcilGauchePts1.Location
    Public positionDuSourcilGauchePts2 As Point = Form1.SourcilGauchePts2.Location
    Public positionDuSourcilGauchePts3 As Point = Form1.SourcilGauchePts3.Location
    Public positionDuSourcilDroitePts1 As Point = Form1.SourcilDroitPts1.Location
    Public positionDuSourcilDroitePts2 As Point = Form1.SourcilDroitPts2.Location
    Public positionDuSourcilDroitePts3 As Point = Form1.SourcilDroitPts3.Location
    Public positionDeLaTeteDuBoss As Point
    Public sentimentDuBoss As String = "sourire"
    Public directionPriseParLaTeteDuBoss As String = "directionDroite"
    Public directionPriseParLePanzer As String = "directionDroite"
    Public leBossSourit() As Point = {}
    Public leBossSeFache() As Integer = {}
End Module
