<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.entrar = New System.Windows.Forms.Button()
        Me.Usuario = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'entrar
        '
        Me.entrar.Location = New System.Drawing.Point(114, 214)
        Me.entrar.Name = "entrar"
        Me.entrar.Size = New System.Drawing.Size(60, 23)
        Me.entrar.TabIndex = 0
        Me.entrar.Text = "Entrar"
        Me.entrar.UseVisualStyleBackColor = True
        '
        'Usuario
        '
        Me.Usuario.AutoSize = True
        Me.Usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usuario.Location = New System.Drawing.Point(110, 51)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(64, 20)
        Me.Usuario.TabIndex = 1
        Me.Usuario.Text = "Usuario"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(73, 74)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(144, 26)
        Me.TextBox1.TabIndex = 2
        '
        'password
        '
        Me.password.AutoSize = True
        Me.password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.Location = New System.Drawing.Point(102, 130)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(92, 20)
        Me.password.TabIndex = 3
        Me.password.Text = "Contraseña"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(73, 153)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(144, 26)
        Me.TextBox2.TabIndex = 4
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Usuario)
        Me.Controls.Add(Me.entrar)
        Me.Name = "Login"
        Me.Text = "Login - La Tiendita"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents entrar As Button
    Friend WithEvents Usuario As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents password As Label
    Friend WithEvents TextBox2 As TextBox
End Class
