Public Class Usuarios
    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        ver_usuario.Show()
    End Sub
End Class