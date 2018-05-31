<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inicio_admin
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministradorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Vendedores = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem, Me.AdministradorToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(270, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AdministradorToolStripMenuItem
        '
        Me.AdministradorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarUsuariosToolStripMenuItem})
        Me.AdministradorToolStripMenuItem.Name = "AdministradorToolStripMenuItem"
        Me.AdministradorToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.AdministradorToolStripMenuItem.Text = "Administrador"
        '
        'RegistrarUsuariosToolStripMenuItem
        '
        Me.RegistrarUsuariosToolStripMenuItem.Name = "RegistrarUsuariosToolStripMenuItem"
        Me.RegistrarUsuariosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RegistrarUsuariosToolStripMenuItem.Text = "Registrar Usuarios"
        '
        'Button7
        '
        Me.Button7.Enabled = False
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(6, 333)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(239, 44)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Conductores"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Vendedores
        '
        Me.Vendedores.Enabled = False
        Me.Vendedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vendedores.Location = New System.Drawing.Point(6, 283)
        Me.Vendedores.Name = "Vendedores"
        Me.Vendedores.Size = New System.Drawing.Size(239, 44)
        Me.Vendedores.TabIndex = 5
        Me.Vendedores.Text = "Vendedores"
        Me.Vendedores.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(6, 233)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(239, 44)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Sucursales"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(6, 183)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(239, 44)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Compras"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(6, 134)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(239, 44)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Ventas"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(6, 84)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(239, 44)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Productos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(6, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(239, 44)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Clientes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.Vendedores)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(251, 411)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Controles"
        '
        'inicio_admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "inicio_admin"
        Me.Text = "Inicio - Administrador"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministradorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button7 As Button
    Friend WithEvents Vendedores As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
