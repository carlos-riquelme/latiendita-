Public Class Productos
    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub VolverAPantallaPrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverAPantallaPrincipalToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        nv_producto.Show()
    End Sub

    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class