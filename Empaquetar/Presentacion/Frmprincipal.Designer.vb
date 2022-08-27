<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmprincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmprincipal))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.dgproductos = New System.Windows.Forms.DataGridView()
        Me.Codarticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ventasdetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empaquetado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tiempo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Num_factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.devoluciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.anulado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nota = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Nota_pantalla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LblEjecutar = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cbPantallas = New System.Windows.Forms.ComboBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lhistorial = New System.Windows.Forms.ListBox()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.dgproductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'dgproductos
        '
        Me.dgproductos.AllowUserToAddRows = False
        Me.dgproductos.AllowUserToDeleteRows = False
        Me.dgproductos.AllowUserToResizeColumns = False
        Me.dgproductos.AllowUserToResizeRows = False
        Me.dgproductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgproductos.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgproductos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgproductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgproductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgproductos.ColumnHeadersHeight = 40
        Me.dgproductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codarticulo, Me.Descripcion, Me.Cantidad, Me.ventasdetalle, Me.empaquetado, Me.Tiempo, Me.marca, Me.id_factura, Me.Num_factura, Me.devoluciones, Me.anulado, Me.Nota, Me.Nota_pantalla})
        Me.dgproductos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgproductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgproductos.GridColor = System.Drawing.SystemColors.HotTrack
        Me.dgproductos.Location = New System.Drawing.Point(0, 77)
        Me.dgproductos.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.dgproductos.Name = "dgproductos"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgproductos.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgproductos.RowHeadersWidth = 20
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dgproductos.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgproductos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Transparent
        Me.dgproductos.RowTemplate.Height = 40
        Me.dgproductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgproductos.Size = New System.Drawing.Size(1284, 554)
        Me.dgproductos.TabIndex = 0
        '
        'Codarticulo
        '
        Me.Codarticulo.DataPropertyName = "codarticulo"
        Me.Codarticulo.HeaderText = "Codigo"
        Me.Codarticulo.Name = "Codarticulo"
        Me.Codarticulo.ReadOnly = True
        Me.Codarticulo.Width = 110
        '
        'Descripcion
        '
        Me.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Descripcion.DataPropertyName = "descripcion"
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.DataPropertyName = "cantidad"
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 134
        '
        'ventasdetalle
        '
        Me.ventasdetalle.DataPropertyName = "id_venta_detalle"
        Me.ventasdetalle.HeaderText = "ventasdetalle"
        Me.ventasdetalle.Name = "ventasdetalle"
        Me.ventasdetalle.ReadOnly = True
        Me.ventasdetalle.Visible = False
        Me.ventasdetalle.Width = 185
        '
        'empaquetado
        '
        Me.empaquetado.DataPropertyName = "empaquetado"
        Me.empaquetado.HeaderText = "empaquetado"
        Me.empaquetado.Name = "empaquetado"
        Me.empaquetado.ReadOnly = True
        Me.empaquetado.Visible = False
        Me.empaquetado.Width = 185
        '
        'Tiempo
        '
        Me.Tiempo.DataPropertyName = "minutos"
        Me.Tiempo.HeaderText = "Minutos"
        Me.Tiempo.Name = "Tiempo"
        Me.Tiempo.ReadOnly = True
        Me.Tiempo.Visible = False
        Me.Tiempo.Width = 121
        '
        'marca
        '
        Me.marca.DataPropertyName = "codmarca"
        Me.marca.HeaderText = "marca"
        Me.marca.Name = "marca"
        Me.marca.Visible = False
        Me.marca.Width = 105
        '
        'id_factura
        '
        Me.id_factura.DataPropertyName = "id_factura"
        Me.id_factura.HeaderText = "id_factura"
        Me.id_factura.Name = "id_factura"
        Me.id_factura.Visible = False
        Me.id_factura.Width = 150
        '
        'Num_factura
        '
        Me.Num_factura.DataPropertyName = "Num_factura"
        Me.Num_factura.HeaderText = "Num_factura"
        Me.Num_factura.Name = "Num_factura"
        Me.Num_factura.Visible = False
        Me.Num_factura.Width = 178
        '
        'devoluciones
        '
        Me.devoluciones.DataPropertyName = "devoluciones"
        Me.devoluciones.HeaderText = "devoluciones"
        Me.devoluciones.Name = "devoluciones"
        Me.devoluciones.Visible = False
        Me.devoluciones.Width = 177
        '
        'anulado
        '
        Me.anulado.DataPropertyName = "anulado"
        Me.anulado.HeaderText = "anulado"
        Me.anulado.Name = "anulado"
        Me.anulado.Visible = False
        Me.anulado.Width = 123
        '
        'Nota
        '
        Me.Nota.HeaderText = "Nota"
        Me.Nota.Image = Global.Empaquetar.My.Resources.Resources.no_note
        Me.Nota.Name = "Nota"
        Me.Nota.Width = 70
        '
        'Nota_pantalla
        '
        Me.Nota_pantalla.DataPropertyName = "nota_pantalla"
        Me.Nota_pantalla.HeaderText = "nota_pantalla"
        Me.Nota_pantalla.Name = "Nota_pantalla"
        Me.Nota_pantalla.Visible = False
        Me.Nota_pantalla.Width = 189
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.RoyalBlue
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LblEjecutar, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 723)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1284, 26)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LblEjecutar
        '
        Me.LblEjecutar.Name = "LblEjecutar"
        Me.LblEjecutar.Size = New System.Drawing.Size(19, 21)
        Me.LblEjecutar.Text = "0"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(101, 21)
        Me.ToolStripStatusLabel1.Text = "V.19Jun2020"
        Me.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.Orange
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(75, 21)
        Me.ToolStripStatusLabel2.Text = "Entregar"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.Red
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(63, 21)
        Me.ToolStripStatusLabel3.Text = "Recibir"
        '
        'cbPantallas
        '
        Me.cbPantallas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPantallas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbPantallas.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPantallas.FormattingEnabled = True
        Me.cbPantallas.Location = New System.Drawing.Point(73, 24)
        Me.cbPantallas.Name = "cbPantallas"
        Me.cbPantallas.Size = New System.Drawing.Size(263, 32)
        Me.cbPantallas.TabIndex = 3
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "1432845616_0000_Refresh.png")
        Me.ImageList1.Images.SetKeyName(1, "1432845597_box-packing-peanut.png")
        Me.ImageList1.Images.SetKeyName(2, "1432849775_window-view.png")
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.cbPantallas)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1284, 77)
        Me.Panel1.TabIndex = 6
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.ImageKey = "1432845597_box-packing-peanut.png"
        Me.Button4.ImageList = Me.ImageList2
        Me.Button4.Location = New System.Drawing.Point(544, 24)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(260, 36)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Empaquetar/Recibir"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "1432845616_0000_Refresh.png")
        Me.ImageList2.Images.SetKeyName(1, "1432845597_box-packing-peanut.png")
        Me.ImageList2.Images.SetKeyName(2, "1432849775_window-view.png")
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.ImageKey = "1432845616_0000_Refresh.png"
        Me.Button3.ImageList = Me.ImageList2
        Me.Button3.Location = New System.Drawing.Point(342, 24)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(196, 36)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Actualizar (f5)"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'lhistorial
        '
        Me.lhistorial.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lhistorial.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lhistorial.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lhistorial.ForeColor = System.Drawing.Color.Blue
        Me.lhistorial.FormattingEnabled = True
        Me.lhistorial.ItemHeight = 22
        Me.lhistorial.Location = New System.Drawing.Point(0, 631)
        Me.lhistorial.Name = "lhistorial"
        Me.lhistorial.ScrollAlwaysVisible = True
        Me.lhistorial.Size = New System.Drawing.Size(1284, 92)
        Me.lhistorial.TabIndex = 7
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "nota"
        Me.DataGridViewImageColumn1.Image = Global.Empaquetar.My.Resources.Resources.nota
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 68
        '
        'Frmprincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 749)
        Me.Controls.Add(Me.dgproductos)
        Me.Controls.Add(Me.lhistorial)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "Frmprincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "::: SISTEMA DE RECIBIDO Y EMPAQUETADO DE PRODUCTOS :::"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgproductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents dgproductos As System.Windows.Forms.DataGridView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents LblEjecutar As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents cbPantallas As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents lhistorial As System.Windows.Forms.ListBox
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Codarticulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ventasdetalle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents empaquetado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tiempo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_factura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Num_factura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents devoluciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents anulado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nota As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Nota_pantalla As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList

End Class
