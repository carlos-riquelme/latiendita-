Imports System.Data.SqlClient 'importa la librería para la base de datos

Public Class Login
    'las variables
    Dim con As New SqlClient.SqlConnection
    Dim da As New SqlClient.SqlDataAdapter
    Dim ds As New DataSet
    Dim sqlquery As String

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=<<NOMBRESERVIDORSQLSERVER>>;Initial Catalog=latiendita;Integrated Security=True"
        CenterToScreen()
        Me.Show()
        TextBox1.Select()
    End Sub

    Private Sub entrar_Click(sender As Object, e As EventArgs) Handles entrar.Click
        Try
            'verifica si los cuadros de texto están vacíos

            If Len(Trim(TextBox1.Text)) = 0 Then
                MessageBox.Show("Ingrese el nombre de usuario", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
                TextBox1.Focus()
            End If
            If Len(Trim(TextBox2.Text)) = 0 Then
                MessageBox.Show("Ingrese la contraseña", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
                TextBox2.Focus()
            End If

            'executing SQL Query for retrieving the username and password from the database table

            con.Open()
            sqlquery = "SELECT * FROM users WHERE nombre='" & TextBox1.Text & "' and password='" & TextBox2.Text & "' "
            da = New SqlClient.SqlDataAdapter(sqlquery, con)
            da.Fill(ds, "users")
            If ds.Tables("users").Rows.Count <> 0 Then
                Dim name As String
                Dim user_type As String
                user_type = ds.Tables("users").Rows(0).Item(3)
                name = ds.Tables("users").Rows(0).Item(1)
                If user_type = "1" Then
                    MsgBox("Bienvenido " & name & " has iniciado sesión como Administrador")
                    inicio_admin.Show()
                    'Me.Hide()
                Else
                    MsgBox("Ha iniciado sesión como Gestor de Clientes. Bienvenido " & name & ".")
                    Clientes.Show()
                    'Me.Hide()
                End If
            Else
                MessageBox.Show("Su combinación de nombre de usuario y contraseña son inválidas", "Accesso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            con.Close()

            TextBox1.Clear()    'limpia los cuadros de texto
            TextBox2.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción generada", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class