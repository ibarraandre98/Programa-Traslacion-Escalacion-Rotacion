<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.panelDibujo = New System.Windows.Forms.PictureBox()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.rbTraslacion = New System.Windows.Forms.RadioButton()
        Me.rbEscalamiento = New System.Windows.Forms.RadioButton()
        Me.rbRotacion = New System.Windows.Forms.RadioButton()
        Me.rbNormal = New System.Windows.Forms.RadioButton()
        Me.OPF = New System.Windows.Forms.OpenFileDialog()
        CType(Me.panelDibujo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelDibujo
        '
        Me.panelDibujo.BackColor = System.Drawing.Color.White
        Me.panelDibujo.Location = New System.Drawing.Point(0, 0)
        Me.panelDibujo.Name = "panelDibujo"
        Me.panelDibujo.Size = New System.Drawing.Size(903, 419)
        Me.panelDibujo.TabIndex = 0
        Me.panelDibujo.TabStop = False
        '
        'btnCargar
        '
        Me.btnCargar.Location = New System.Drawing.Point(559, 441)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(75, 23)
        Me.btnCargar.TabIndex = 1
        Me.btnCargar.Text = "Cargar"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'rbTraslacion
        '
        Me.rbTraslacion.AutoSize = True
        Me.rbTraslacion.Location = New System.Drawing.Point(191, 441)
        Me.rbTraslacion.Name = "rbTraslacion"
        Me.rbTraslacion.Size = New System.Drawing.Size(74, 17)
        Me.rbTraslacion.TabIndex = 2
        Me.rbTraslacion.Text = "Traslación"
        Me.rbTraslacion.UseVisualStyleBackColor = True
        '
        'rbEscalamiento
        '
        Me.rbEscalamiento.AutoSize = True
        Me.rbEscalamiento.Location = New System.Drawing.Point(281, 441)
        Me.rbEscalamiento.Name = "rbEscalamiento"
        Me.rbEscalamiento.Size = New System.Drawing.Size(88, 17)
        Me.rbEscalamiento.TabIndex = 3
        Me.rbEscalamiento.Text = "Escalamiento"
        Me.rbEscalamiento.UseVisualStyleBackColor = True
        '
        'rbRotacion
        '
        Me.rbRotacion.AutoSize = True
        Me.rbRotacion.Location = New System.Drawing.Point(390, 441)
        Me.rbRotacion.Name = "rbRotacion"
        Me.rbRotacion.Size = New System.Drawing.Size(68, 17)
        Me.rbRotacion.TabIndex = 4
        Me.rbRotacion.Text = "Rotación"
        Me.rbRotacion.UseVisualStyleBackColor = True
        '
        'rbNormal
        '
        Me.rbNormal.AutoSize = True
        Me.rbNormal.Checked = True
        Me.rbNormal.Location = New System.Drawing.Point(473, 441)
        Me.rbNormal.Name = "rbNormal"
        Me.rbNormal.Size = New System.Drawing.Size(58, 17)
        Me.rbNormal.TabIndex = 5
        Me.rbNormal.TabStop = True
        Me.rbNormal.Text = "Normal"
        Me.rbNormal.UseVisualStyleBackColor = True
        '
        'OPF
        '
        Me.OPF.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(901, 476)
        Me.Controls.Add(Me.rbNormal)
        Me.Controls.Add(Me.rbRotacion)
        Me.Controls.Add(Me.rbEscalamiento)
        Me.Controls.Add(Me.rbTraslacion)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.panelDibujo)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProgramaTER"
        CType(Me.panelDibujo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panelDibujo As PictureBox
    Friend WithEvents btnCargar As Button
    Friend WithEvents rbTraslacion As RadioButton
    Friend WithEvents rbEscalamiento As RadioButton
    Friend WithEvents rbRotacion As RadioButton
    Friend WithEvents rbNormal As RadioButton
    Friend WithEvents OPF As OpenFileDialog
End Class
