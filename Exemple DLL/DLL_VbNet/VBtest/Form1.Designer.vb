<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.btnCrypt = New System.Windows.Forms.Button()
        Me.btnUnCrypt = New System.Windows.Forms.Button()
        Me.txtResult = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'txtText
        '
        Me.txtText.Location = New System.Drawing.Point(113, 151)
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(224, 20)
        Me.txtText.TabIndex = 0
        '
        'btnCrypt
        '
        Me.btnCrypt.Location = New System.Drawing.Point(113, 177)
        Me.btnCrypt.Name = "btnCrypt"
        Me.btnCrypt.Size = New System.Drawing.Size(91, 35)
        Me.btnCrypt.TabIndex = 1
        Me.btnCrypt.Text = "Crypt"
        Me.btnCrypt.UseVisualStyleBackColor = True
        '
        'btnUnCrypt
        '
        Me.btnUnCrypt.Location = New System.Drawing.Point(246, 177)
        Me.btnUnCrypt.Name = "btnUnCrypt"
        Me.btnUnCrypt.Size = New System.Drawing.Size(91, 35)
        Me.btnUnCrypt.TabIndex = 2
        Me.btnUnCrypt.Text = "Decrypte"
        Me.btnUnCrypt.UseVisualStyleBackColor = True
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(113, 228)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(224, 107)
        Me.txtResult.TabIndex = 3
        Me.txtResult.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.btnUnCrypt)
        Me.Controls.Add(Me.btnCrypt)
        Me.Controls.Add(Me.txtText)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtText As TextBox
    Friend WithEvents btnCrypt As Button
    Friend WithEvents btnUnCrypt As Button
    Friend WithEvents txtResult As RichTextBox
End Class
