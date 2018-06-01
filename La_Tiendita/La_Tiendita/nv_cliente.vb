Imports System.Data
Imports System.Data.SqlClient

Public Class nv_cliente
    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox1.Select()

    End Sub

    Private Sub nv_cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        TextBox1.Select()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Me.Close()
    End Sub

    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        'las variables
        'Dim con As New SqlClient.SqlConnection
        'Dim da As New SqlClient.SqlDataAdapter
        'Dim comandosql As SqlCommand
        'Dim ds As New DataSet
        'Dim sqlquery As String



        Try
        If Len(Trim(TextBox1.Text)) = 0 Then
                MessageBox.Show("Ingrese un nombre", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
                TextBox1.Focus()
            End If
            If Len(Trim(TextBox2.Text)) = 0 Then
                MessageBox.Show("Ingrese un apellido", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
                TextBox2.Focus()
            End If
            If Len(Trim(TextBox3.Text)) = 0 Then
                MessageBox.Show("Ingrese un apellido", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
                TextBox3.Focus()
            End If
            If Len(Trim(TextBox4.Text)) = 0 Then
                MessageBox.Show("Ingrese un apellido", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
                TextBox4.Focus()
            End If
            If Len(Trim(TextBox5.Text)) = 0 Then
                MessageBox.Show("Ingrese un apellido", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
                TextBox5.Focus()
            End If

            Dim sqlconexion As New System.Data.SqlClient.SqlConnection("Data Source=ANC-CRIQUELME;Initial Catalog=latiendita;Integrated Security=True")
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "INSERT INTO clientes (nombre,app,apm,direccion,comuna) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "')"
            cmd.Connection = sqlconexion

            sqlconexion.Open()
            cmd.ExecuteNonQuery()
            sqlconexion.Close()


            MessageBox.Show("Cliente registrado exitosamente")
            Clientes.ClientesDataGridView.Refresh()
            Me.Close()



            'con.Open()
            'sqlquery =
            'da = New SqlClient.SqlDataAdapter(sqlquery, con)

            'da.Fill(ds, "users")
            'If ds.Tables("users").Rows.Count <> 0 Then
            '    Dim name As String
            '    Dim user_type As String
            '    user_type = ds.Tables("users").Rows(0).Item(3)
            '    name = ds.Tables("users").Rows(0).Item(1)
            '    If user_type = "1" Then
            '        MsgBox("Bienvenido " & name & " has iniciado sesión como Administrador")
            '        inicio_admin.Show()
            '        'Me.Hide()
            '    Else
            '        MsgBox("Ha iniciado sesión como Gestor de Clientes. Bienvenido " & name & ".")
            '        Clientes.Show()
            '        'Me.Hide()
            '    End If
            'Else
            '    MessageBox.Show("Su combinación de nombre de usuario y contraseña son inválidas", "Accesso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End If
            'con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción generada", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class