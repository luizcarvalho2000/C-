<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExercicioInicial_01_08112023
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
        Me.btnMenssagem = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMenssagem
        '
        Me.btnMenssagem.Location = New System.Drawing.Point(0, 0)
        Me.btnMenssagem.Name = "btnMenssagem"
        Me.btnMenssagem.Size = New System.Drawing.Size(75, 23)
        Me.btnMenssagem.TabIndex = 0
        Me.btnMenssagem.Text = "Mensagem"
        Me.btnMenssagem.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 540)
        Me.Controls.Add(Me.btnMenssagem)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnMenssagem As System.Windows.Forms.Button

End Class
