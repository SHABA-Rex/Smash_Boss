<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Scores_Et_Victoires
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Scores_Et_Victoires))
        Me.les_Victoires_Du_Panzer = New System.Windows.Forms.Label()
        Me.les_Victoires_Du_Boss = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Boutton_Retour = New System.Windows.Forms.Label()
        Me.Score_Du_Panzer = New System.Windows.Forms.Label()
        Me.Score_Du_Boss = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'les_Victoires_Du_Panzer
        '
        Me.les_Victoires_Du_Panzer.BackColor = System.Drawing.Color.Lime
        Me.les_Victoires_Du_Panzer.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.les_Victoires_Du_Panzer.Location = New System.Drawing.Point(6, 27)
        Me.les_Victoires_Du_Panzer.Name = "les_Victoires_Du_Panzer"
        Me.les_Victoires_Du_Panzer.Size = New System.Drawing.Size(174, 168)
        Me.les_Victoires_Du_Panzer.TabIndex = 1
        Me.les_Victoires_Du_Panzer.Text = "0"
        Me.les_Victoires_Du_Panzer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'les_Victoires_Du_Boss
        '
        Me.les_Victoires_Du_Boss.BackColor = System.Drawing.Color.Lime
        Me.les_Victoires_Du_Boss.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.les_Victoires_Du_Boss.Location = New System.Drawing.Point(183, 27)
        Me.les_Victoires_Du_Boss.Name = "les_Victoires_Du_Boss"
        Me.les_Victoires_Du_Boss.Size = New System.Drawing.Size(174, 168)
        Me.les_Victoires_Du_Boss.TabIndex = 2
        Me.les_Victoires_Du_Boss.Text = "0"
        Me.les_Victoires_Du_Boss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Lime
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(5, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 51)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Mon Score :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Green
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(5, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(174, 24)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Mes victoires"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Green
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(183, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(174, 24)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Victoires du Boss"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Boutton_Retour
        '
        Me.Boutton_Retour.BackColor = System.Drawing.Color.Yellow
        Me.Boutton_Retour.Image = CType(resources.GetObject("Boutton_Retour.Image"), System.Drawing.Image)
        Me.Boutton_Retour.Location = New System.Drawing.Point(-2, 3)
        Me.Boutton_Retour.Name = "Boutton_Retour"
        Me.Boutton_Retour.Size = New System.Drawing.Size(32, 21)
        Me.Boutton_Retour.TabIndex = 7
        '
        'Score_Du_Panzer
        '
        Me.Score_Du_Panzer.BackColor = System.Drawing.Color.Lime
        Me.Score_Du_Panzer.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Score_Du_Panzer.ForeColor = System.Drawing.Color.Red
        Me.Score_Du_Panzer.Location = New System.Drawing.Point(101, 202)
        Me.Score_Du_Panzer.Name = "Score_Du_Panzer"
        Me.Score_Du_Panzer.Size = New System.Drawing.Size(78, 51)
        Me.Score_Du_Panzer.TabIndex = 8
        Me.Score_Du_Panzer.Text = "0"
        Me.Score_Du_Panzer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Score_Du_Boss
        '
        Me.Score_Du_Boss.BackColor = System.Drawing.Color.Lime
        Me.Score_Du_Boss.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Score_Du_Boss.ForeColor = System.Drawing.Color.Red
        Me.Score_Du_Boss.Location = New System.Drawing.Point(278, 202)
        Me.Score_Du_Boss.Name = "Score_Du_Boss"
        Me.Score_Du_Boss.Size = New System.Drawing.Size(78, 51)
        Me.Score_Du_Boss.TabIndex = 10
        Me.Score_Du_Boss.Text = "0"
        Me.Score_Du_Boss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Lime
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(182, 202)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 51)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Score du Boss :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Scores_Et_Victoires
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(362, 261)
        Me.Controls.Add(Me.Score_Du_Boss)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Score_Du_Panzer)
        Me.Controls.Add(Me.Boutton_Retour)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.les_Victoires_Du_Boss)
        Me.Controls.Add(Me.les_Victoires_Du_Panzer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Scores_Et_Victoires"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mon_Score"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents les_Victoires_Du_Panzer As Label
    Friend WithEvents les_Victoires_Du_Boss As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Boutton_Retour As Label
    Friend WithEvents Score_Du_Panzer As Label
    Friend WithEvents Score_Du_Boss As Label
    Friend WithEvents Label9 As Label
End Class
