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
        Me.LBnombre = New System.Windows.Forms.Label()
        Me.GPClientes = New System.Windows.Forms.GroupBox()
        Me.LBnit = New System.Windows.Forms.Label()
        Me.LBDias = New System.Windows.Forms.Label()
        Me.LBimpuesto = New System.Windows.Forms.Label()
        Me.TBnombre = New System.Windows.Forms.TextBox()
        Me.TBnit = New System.Windows.Forms.TextBox()
        Me.TBdias = New System.Windows.Forms.TextBox()
        Me.TBimouesto = New System.Windows.Forms.TextBox()
        Me.GPHabitacion = New System.Windows.Forms.GroupBox()
        Me.GPpago = New System.Windows.Forms.GroupBox()
        Me.DTresultados = New System.Windows.Forms.DataGridView()
        Me.CBhabitacion = New System.Windows.Forms.ComboBox()
        Me.CBpago = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TSlimpiar = New System.Windows.Forms.ToolStripLabel()
        Me.TSeliminar = New System.Windows.Forms.ToolStripLabel()
        Me.TSconsultar = New System.Windows.Forms.ToolStripLabel()
        Me.TSmostrar = New System.Windows.Forms.ToolStripLabel()
        Me.TScalculo = New System.Windows.Forms.ToolStripLabel()
        Me.GPconsulta = New System.Windows.Forms.GroupBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGNIT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGdias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGImpuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGHabitacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGParcial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGdescuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GPClientes.SuspendLayout()
        Me.GPHabitacion.SuspendLayout()
        Me.GPpago.SuspendLayout()
        CType(Me.DTresultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.GPconsulta.SuspendLayout()
        Me.SuspendLayout()
        '
        'LBnombre
        '
        Me.LBnombre.AutoSize = True
        Me.LBnombre.Location = New System.Drawing.Point(30, 39)
        Me.LBnombre.Name = "LBnombre"
        Me.LBnombre.Size = New System.Drawing.Size(177, 20)
        Me.LBnombre.TabIndex = 0
        Me.LBnombre.Text = "Nombre del Huesped"
        '
        'GPClientes
        '
        Me.GPClientes.Controls.Add(Me.TBimouesto)
        Me.GPClientes.Controls.Add(Me.TBdias)
        Me.GPClientes.Controls.Add(Me.TBnit)
        Me.GPClientes.Controls.Add(Me.TBnombre)
        Me.GPClientes.Controls.Add(Me.LBimpuesto)
        Me.GPClientes.Controls.Add(Me.LBDias)
        Me.GPClientes.Controls.Add(Me.LBnit)
        Me.GPClientes.Controls.Add(Me.LBnombre)
        Me.GPClientes.Location = New System.Drawing.Point(12, 51)
        Me.GPClientes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GPClientes.Name = "GPClientes"
        Me.GPClientes.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GPClientes.Size = New System.Drawing.Size(393, 167)
        Me.GPClientes.TabIndex = 1
        Me.GPClientes.TabStop = False
        Me.GPClientes.Text = "DATOS DEL CLIENTE"
        '
        'LBnit
        '
        Me.LBnit.AutoSize = True
        Me.LBnit.Location = New System.Drawing.Point(170, 74)
        Me.LBnit.Name = "LBnit"
        Me.LBnit.Size = New System.Drawing.Size(37, 20)
        Me.LBnit.TabIndex = 1
        Me.LBnit.Text = "NIT"
        '
        'LBDias
        '
        Me.LBDias.AutoSize = True
        Me.LBDias.Location = New System.Drawing.Point(45, 101)
        Me.LBDias.Name = "LBDias"
        Me.LBDias.Size = New System.Drawing.Size(162, 20)
        Me.LBDias.TabIndex = 2
        Me.LBDias.Text = "Dias a Hospedarse"
        '
        'LBimpuesto
        '
        Me.LBimpuesto.AutoSize = True
        Me.LBimpuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBimpuesto.Location = New System.Drawing.Point(123, 137)
        Me.LBimpuesto.Name = "LBimpuesto"
        Me.LBimpuesto.Size = New System.Drawing.Size(84, 20)
        Me.LBimpuesto.TabIndex = 3
        Me.LBimpuesto.Text = "Impuesto"
        '
        'TBnombre
        '
        Me.TBnombre.Location = New System.Drawing.Point(213, 36)
        Me.TBnombre.Name = "TBnombre"
        Me.TBnombre.Size = New System.Drawing.Size(174, 26)
        Me.TBnombre.TabIndex = 4
        '
        'TBnit
        '
        Me.TBnit.Location = New System.Drawing.Point(213, 68)
        Me.TBnit.Name = "TBnit"
        Me.TBnit.Size = New System.Drawing.Size(174, 26)
        Me.TBnit.TabIndex = 5
        '
        'TBdias
        '
        Me.TBdias.Location = New System.Drawing.Point(213, 101)
        Me.TBdias.Name = "TBdias"
        Me.TBdias.Size = New System.Drawing.Size(174, 26)
        Me.TBdias.TabIndex = 6
        '
        'TBimouesto
        '
        Me.TBimouesto.Location = New System.Drawing.Point(213, 134)
        Me.TBimouesto.Name = "TBimouesto"
        Me.TBimouesto.Size = New System.Drawing.Size(174, 26)
        Me.TBimouesto.TabIndex = 7
        '
        'GPHabitacion
        '
        Me.GPHabitacion.Controls.Add(Me.CBhabitacion)
        Me.GPHabitacion.Location = New System.Drawing.Point(427, 36)
        Me.GPHabitacion.Name = "GPHabitacion"
        Me.GPHabitacion.Size = New System.Drawing.Size(155, 94)
        Me.GPHabitacion.TabIndex = 2
        Me.GPHabitacion.TabStop = False
        Me.GPHabitacion.Text = "TIPO DE HABITACION"
        '
        'GPpago
        '
        Me.GPpago.Controls.Add(Me.CBpago)
        Me.GPpago.Location = New System.Drawing.Point(427, 146)
        Me.GPpago.Name = "GPpago"
        Me.GPpago.Size = New System.Drawing.Size(155, 72)
        Me.GPpago.TabIndex = 3
        Me.GPpago.TabStop = False
        Me.GPpago.Text = "TIPO DE PAGO"
        '
        'DTresultados
        '
        Me.DTresultados.BackgroundColor = System.Drawing.Color.OliveDrab
        Me.DTresultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTresultados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGNombre, Me.DGNIT, Me.DGdias, Me.DGImpuesto, Me.DGHabitacion, Me.DGPago, Me.DGParcial, Me.DGdescuento, Me.DGTotal})
        Me.DTresultados.Location = New System.Drawing.Point(-2, 240)
        Me.DTresultados.Name = "DTresultados"
        Me.DTresultados.Size = New System.Drawing.Size(947, 286)
        Me.DTresultados.TabIndex = 4
        '
        'CBhabitacion
        '
        Me.CBhabitacion.FormattingEnabled = True
        Me.CBhabitacion.Items.AddRange(New Object() {"Sencilla", "Doble", "Cabaña"})
        Me.CBhabitacion.Location = New System.Drawing.Point(19, 55)
        Me.CBhabitacion.Name = "CBhabitacion"
        Me.CBhabitacion.Size = New System.Drawing.Size(121, 28)
        Me.CBhabitacion.TabIndex = 0
        '
        'CBpago
        '
        Me.CBpago.FormattingEnabled = True
        Me.CBpago.Items.AddRange(New Object() {"Efectivo", "Tarjeta Credito/Debito", "Transferencia", "Deposito"})
        Me.CBpago.Location = New System.Drawing.Point(26, 30)
        Me.CBpago.Name = "CBpago"
        Me.CBpago.Size = New System.Drawing.Size(114, 28)
        Me.CBpago.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TScalculo, Me.TSmostrar, Me.TSconsultar, Me.TSeliminar, Me.TSlimpiar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(967, 25)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TSlimpiar
        '
        Me.TSlimpiar.Name = "TSlimpiar"
        Me.TSlimpiar.Size = New System.Drawing.Size(97, 22)
        Me.TSlimpiar.Text = "Limpiar  Vectores"
        '
        'TSeliminar
        '
        Me.TSeliminar.Name = "TSeliminar"
        Me.TSeliminar.Size = New System.Drawing.Size(50, 22)
        Me.TSeliminar.Text = "Eliminar"
        '
        'TSconsultar
        '
        Me.TSconsultar.Name = "TSconsultar"
        Me.TSconsultar.Size = New System.Drawing.Size(58, 22)
        Me.TSconsultar.Text = "Consultar"
        '
        'TSmostrar
        '
        Me.TSmostrar.Name = "TSmostrar"
        Me.TSmostrar.Size = New System.Drawing.Size(48, 22)
        Me.TSmostrar.Text = "Mostrar"
        '
        'TScalculo
        '
        Me.TScalculo.Name = "TScalculo"
        Me.TScalculo.Size = New System.Drawing.Size(47, 22)
        Me.TScalculo.Text = "Calculo"
        '
        'GPconsulta
        '
        Me.GPconsulta.Controls.Add(Me.TextBox5)
        Me.GPconsulta.Controls.Add(Me.Label1)
        Me.GPconsulta.Location = New System.Drawing.Point(727, 51)
        Me.GPconsulta.Name = "GPconsulta"
        Me.GPconsulta.Size = New System.Drawing.Size(218, 158)
        Me.GPconsulta.TabIndex = 6
        Me.GPconsulta.TabStop = False
        Me.GPconsulta.Text = "Consulta"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(88, 51)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(114, 26)
        Me.TextBox5.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "NIT"
        '
        'DGNombre
        '
        Me.DGNombre.HeaderText = "Huesped"
        Me.DGNombre.Name = "DGNombre"
        '
        'DGNIT
        '
        Me.DGNIT.HeaderText = "NIT"
        Me.DGNIT.Name = "DGNIT"
        '
        'DGdias
        '
        Me.DGdias.HeaderText = "Dias a Hospedarse"
        Me.DGdias.Name = "DGdias"
        '
        'DGImpuesto
        '
        Me.DGImpuesto.HeaderText = "Impuesto"
        Me.DGImpuesto.Name = "DGImpuesto"
        '
        'DGHabitacion
        '
        Me.DGHabitacion.HeaderText = "Tipo de Habitacion"
        Me.DGHabitacion.Name = "DGHabitacion"
        '
        'DGPago
        '
        Me.DGPago.HeaderText = "Tipo de Pago"
        Me.DGPago.Name = "DGPago"
        '
        'DGParcial
        '
        Me.DGParcial.HeaderText = "Pago Parcial"
        Me.DGParcial.Name = "DGParcial"
        '
        'DGdescuento
        '
        Me.DGdescuento.HeaderText = "Descuento/Recargo"
        Me.DGdescuento.Name = "DGdescuento"
        '
        'DGTotal
        '
        Me.DGTotal.HeaderText = "Total"
        Me.DGTotal.Name = "DGTotal"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OliveDrab
        Me.ClientSize = New System.Drawing.Size(967, 538)
        Me.Controls.Add(Me.GPconsulta)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DTresultados)
        Me.Controls.Add(Me.GPpago)
        Me.Controls.Add(Me.GPHabitacion)
        Me.Controls.Add(Me.GPClientes)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "HOTEL PLAYA DORADA S.A."
        Me.GPClientes.ResumeLayout(False)
        Me.GPClientes.PerformLayout()
        Me.GPHabitacion.ResumeLayout(False)
        Me.GPpago.ResumeLayout(False)
        CType(Me.DTresultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GPconsulta.ResumeLayout(False)
        Me.GPconsulta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBnombre As Label
    Friend WithEvents GPClientes As GroupBox
    Friend WithEvents TBimouesto As TextBox
    Friend WithEvents TBdias As TextBox
    Friend WithEvents TBnit As TextBox
    Friend WithEvents TBnombre As TextBox
    Friend WithEvents LBimpuesto As Label
    Friend WithEvents LBDias As Label
    Friend WithEvents LBnit As Label
    Friend WithEvents GPHabitacion As GroupBox
    Friend WithEvents GPpago As GroupBox
    Friend WithEvents DTresultados As DataGridView
    Friend WithEvents CBhabitacion As ComboBox
    Friend WithEvents CBpago As ComboBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TScalculo As ToolStripLabel
    Friend WithEvents TSmostrar As ToolStripLabel
    Friend WithEvents TSconsultar As ToolStripLabel
    Friend WithEvents TSeliminar As ToolStripLabel
    Friend WithEvents TSlimpiar As ToolStripLabel
    Friend WithEvents GPconsulta As GroupBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DGNombre As DataGridViewTextBoxColumn
    Friend WithEvents DGNIT As DataGridViewTextBoxColumn
    Friend WithEvents DGdias As DataGridViewTextBoxColumn
    Friend WithEvents DGImpuesto As DataGridViewTextBoxColumn
    Friend WithEvents DGHabitacion As DataGridViewTextBoxColumn
    Friend WithEvents DGPago As DataGridViewTextBoxColumn
    Friend WithEvents DGParcial As DataGridViewTextBoxColumn
    Friend WithEvents DGdescuento As DataGridViewTextBoxColumn
    Friend WithEvents DGTotal As DataGridViewTextBoxColumn
End Class
