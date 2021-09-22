<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Choisir_Le_Niveau
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Choisir_Le_Niveau))
        Me.boutton_Retour = New System.Windows.Forms.Label()
        Me.niveau_Difficile = New Guna.UI.WinForms.GunaButton()
        Me.niveau_Normal = New Guna.UI.WinForms.GunaButton()
        Me.niveau_Intermediaire = New Guna.UI.WinForms.GunaButton()
        Me.SuspendLayout()
        '
        'boutton_Retour
        '
        Me.boutton_Retour.BackColor = System.Drawing.Color.Yellow
        Me.boutton_Retour.Image = CType(resources.GetObject("boutton_Retour.Image"), System.Drawing.Image)
        Me.boutton_Retour.Location = New System.Drawing.Point(-5, 1)
        Me.boutton_Retour.Name = "boutton_Retour"
        Me.boutton_Retour.Size = New System.Drawing.Size(32, 21)
        Me.boutton_Retour.TabIndex = 8
        '
        'niveau_Difficile
        '
        Me.niveau_Difficile.AnimationHoverSpeed = 0.07!
        Me.niveau_Difficile.AnimationSpeed = 0.03!
        Me.niveau_Difficile.BaseColor = System.Drawing.Color.Lime
        Me.niveau_Difficile.BorderColor = System.Drawing.Color.Black
        Me.niveau_Difficile.DialogResult = System.Windows.Forms.DialogResult.None
        Me.niveau_Difficile.FocusedColor = System.Drawing.Color.Empty
        Me.niveau_Difficile.Font = New System.Drawing.Font("Segoe UI Symbol", 20.25!)
        Me.niveau_Difficile.ForeColor = System.Drawing.Color.White
        Me.niveau_Difficile.Image = Nothing
        Me.niveau_Difficile.ImageSize = New System.Drawing.Size(20, 20)
        Me.niveau_Difficile.Location = New System.Drawing.Point(21, 147)
        Me.niveau_Difficile.Name = "niveau_Difficile"
        Me.niveau_Difficile.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.niveau_Difficile.OnHoverBorderColor = System.Drawing.Color.Black
        Me.niveau_Difficile.OnHoverForeColor = System.Drawing.Color.White
        Me.niveau_Difficile.OnHoverImage = Nothing
        Me.niveau_Difficile.OnPressedColor = System.Drawing.Color.Black
        Me.niveau_Difficile.Size = New System.Drawing.Size(218, 55)
        Me.niveau_Difficile.TabIndex = 11
        Me.niveau_Difficile.Text = "Difficile"
        Me.niveau_Difficile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'niveau_Normal
        '
        Me.niveau_Normal.AnimationHoverSpeed = 0.07!
        Me.niveau_Normal.AnimationSpeed = 0.03!
        Me.niveau_Normal.BaseColor = System.Drawing.Color.Lime
        Me.niveau_Normal.BorderColor = System.Drawing.Color.Black
        Me.niveau_Normal.DialogResult = System.Windows.Forms.DialogResult.None
        Me.niveau_Normal.FocusedColor = System.Drawing.Color.Empty
        Me.niveau_Normal.Font = New System.Drawing.Font("Segoe UI Symbol", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.niveau_Normal.ForeColor = System.Drawing.Color.White
        Me.niveau_Normal.Image = Nothing
        Me.niveau_Normal.ImageSize = New System.Drawing.Size(20, 20)
        Me.niveau_Normal.Location = New System.Drawing.Point(21, 25)
        Me.niveau_Normal.Name = "niveau_Normal"
        Me.niveau_Normal.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.niveau_Normal.OnHoverBorderColor = System.Drawing.Color.Black
        Me.niveau_Normal.OnHoverForeColor = System.Drawing.Color.White
        Me.niveau_Normal.OnHoverImage = Nothing
        Me.niveau_Normal.OnPressedColor = System.Drawing.Color.Black
        Me.niveau_Normal.Size = New System.Drawing.Size(218, 55)
        Me.niveau_Normal.TabIndex = 12
        Me.niveau_Normal.Text = "Normal"
        Me.niveau_Normal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'niveau_Intermediaire
        '
        Me.niveau_Intermediaire.AnimationHoverSpeed = 0.07!
        Me.niveau_Intermediaire.AnimationSpeed = 0.03!
        Me.niveau_Intermediaire.BaseColor = System.Drawing.Color.Lime
        Me.niveau_Intermediaire.BorderColor = System.Drawing.Color.Black
        Me.niveau_Intermediaire.DialogResult = System.Windows.Forms.DialogResult.None
        Me.niveau_Intermediaire.FocusedColor = System.Drawing.Color.Empty
        Me.niveau_Intermediaire.Font = New System.Drawing.Font("Segoe UI Symbol", 20.25!)
        Me.niveau_Intermediaire.ForeColor = System.Drawing.Color.White
        Me.niveau_Intermediaire.Image = Nothing
        Me.niveau_Intermediaire.ImageSize = New System.Drawing.Size(20, 20)
        Me.niveau_Intermediaire.Location = New System.Drawing.Point(21, 86)
        Me.niveau_Intermediaire.Name = "niveau_Intermediaire"
        Me.niveau_Intermediaire.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.niveau_Intermediaire.OnHoverBorderColor = System.Drawing.Color.Black
        Me.niveau_Intermediaire.OnHoverForeColor = System.Drawing.Color.White
        Me.niveau_Intermediaire.OnHoverImage = Nothing
        Me.niveau_Intermediaire.OnPressedColor = System.Drawing.Color.Black
        Me.niveau_Intermediaire.Size = New System.Drawing.Size(218, 55)
        Me.niveau_Intermediaire.TabIndex = 13
        Me.niveau_Intermediaire.Text = "Intermédiaire"
        Me.niveau_Intermediaire.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Choisir_Le_Niveau
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(260, 219)
        Me.Controls.Add(Me.niveau_Intermediaire)
        Me.Controls.Add(Me.niveau_Normal)
        Me.Controls.Add(Me.niveau_Difficile)
        Me.Controls.Add(Me.boutton_Retour)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Choisir_Le_Niveau"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choisir_Le_Niveau"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents boutton_Retour As Label
    Friend WithEvents niveau_Difficile As Guna.UI.WinForms.GunaButton
    Friend WithEvents niveau_Normal As Guna.UI.WinForms.GunaButton
    Friend WithEvents niveau_Intermediaire As Guna.UI.WinForms.GunaButton
End Class
