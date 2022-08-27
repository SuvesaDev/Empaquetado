<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpaquetar
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbventadetalle = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbetiqueta = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbcantidad = New System.Windows.Forms.TextBox()
        Me.lbminutos = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Empaquetar:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(107, 123)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cantidad:"
        '
        'lbventadetalle
        '
        Me.lbventadetalle.AutoSize = True
        Me.lbventadetalle.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbventadetalle.Location = New System.Drawing.Point(54, 237)
        Me.lbventadetalle.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbventadetalle.Name = "lbventadetalle"
        Me.lbventadetalle.Size = New System.Drawing.Size(177, 29)
        Me.lbventadetalle.TabIndex = 6
        Me.lbventadetalle.Text = "lbventadetalle"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(2, 179)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 47)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lbetiqueta
        '
        Me.lbetiqueta.BackColor = System.Drawing.SystemColors.InfoText
        Me.lbetiqueta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbetiqueta.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbetiqueta.ForeColor = System.Drawing.Color.White
        Me.lbetiqueta.Location = New System.Drawing.Point(10, 32)
        Me.lbetiqueta.Multiline = True
        Me.lbetiqueta.Name = "lbetiqueta"
        Me.lbetiqueta.ReadOnly = True
        Me.lbetiqueta.Size = New System.Drawing.Size(302, 57)
        Me.lbetiqueta.TabIndex = 9
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(208, 178)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 48)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbcantidad)
        Me.Panel1.Controls.Add(Me.lbetiqueta)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(331, 174)
        Me.Panel1.TabIndex = 10
        '
        'lbcantidad
        '
        Me.lbcantidad.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbcantidad.ForeColor = System.Drawing.Color.Red
        Me.lbcantidad.Location = New System.Drawing.Point(212, 102)
        Me.lbcantidad.Name = "lbcantidad"
        Me.lbcantidad.ReadOnly = True
        Me.lbcantidad.Size = New System.Drawing.Size(100, 45)
        Me.lbcantidad.TabIndex = 10
        Me.lbcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbminutos
        '
        Me.lbminutos.AutoSize = True
        Me.lbminutos.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbminutos.Location = New System.Drawing.Point(54, 266)
        Me.lbminutos.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbminutos.Name = "lbminutos"
        Me.lbminutos.Size = New System.Drawing.Size(88, 29)
        Me.lbminutos.TabIndex = 11
        Me.lbminutos.Text = "Label3"
        '
        'frmEmpaquetar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(335, 227)
        Me.Controls.Add(Me.lbminutos)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbventadetalle)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEmpaquetar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Producto"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbventadetalle As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbetiqueta As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbcantidad As System.Windows.Forms.TextBox
    Friend WithEvents lbminutos As System.Windows.Forms.Label
End Class
