<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class busca_cliente
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdclientesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApmDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComunaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LatienditaDataSet = New La_Tiendita.latienditaDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ClientesTableAdapter = New La_Tiendita.latienditaDataSetTableAdapters.clientesTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LatienditaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdclientesDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.AppDataGridViewTextBoxColumn, Me.ApmDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.ComunaDataGridViewTextBoxColumn, Me.CorreoDataGridViewTextBoxColumn, Me.CreadoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ClientesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 59)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(850, 271)
        Me.DataGridView1.TabIndex = 0
        '
        'IdclientesDataGridViewTextBoxColumn
        '
        Me.IdclientesDataGridViewTextBoxColumn.DataPropertyName = "idclientes"
        Me.IdclientesDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdclientesDataGridViewTextBoxColumn.Name = "IdclientesDataGridViewTextBoxColumn"
        Me.IdclientesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombres"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'AppDataGridViewTextBoxColumn
        '
        Me.AppDataGridViewTextBoxColumn.DataPropertyName = "app"
        Me.AppDataGridViewTextBoxColumn.HeaderText = "Apellido Paterno"
        Me.AppDataGridViewTextBoxColumn.Name = "AppDataGridViewTextBoxColumn"
        '
        'ApmDataGridViewTextBoxColumn
        '
        Me.ApmDataGridViewTextBoxColumn.DataPropertyName = "apm"
        Me.ApmDataGridViewTextBoxColumn.HeaderText = "Apellido Materno"
        Me.ApmDataGridViewTextBoxColumn.Name = "ApmDataGridViewTextBoxColumn"
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Dirección"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        '
        'ComunaDataGridViewTextBoxColumn
        '
        Me.ComunaDataGridViewTextBoxColumn.DataPropertyName = "comuna"
        Me.ComunaDataGridViewTextBoxColumn.HeaderText = "Comuna"
        Me.ComunaDataGridViewTextBoxColumn.Name = "ComunaDataGridViewTextBoxColumn"
        '
        'CorreoDataGridViewTextBoxColumn
        '
        Me.CorreoDataGridViewTextBoxColumn.DataPropertyName = "correo"
        Me.CorreoDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.CorreoDataGridViewTextBoxColumn.Name = "CorreoDataGridViewTextBoxColumn"
        '
        'CreadoDataGridViewTextBoxColumn
        '
        Me.CreadoDataGridViewTextBoxColumn.DataPropertyName = "creado"
        Me.CreadoDataGridViewTextBoxColumn.HeaderText = "Fecha Creación"
        Me.CreadoDataGridViewTextBoxColumn.Name = "CreadoDataGridViewTextBoxColumn"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.LatienditaDataSet
        '
        'LatienditaDataSet
        '
        Me.LatienditaDataSet.DataSetName = "latienditaDataSet"
        Me.LatienditaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Ingrese texto a buscar"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(232, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(209, 20)
        Me.TextBox1.TabIndex = 4
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'busca_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 342)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "busca_cliente"
        Me.Text = "Buscador de Clientes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LatienditaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LatienditaDataSet As latienditaDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As latienditaDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents IdclientesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AppDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApmDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ComunaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
