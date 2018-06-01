Public Class Productos
    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub VolverAPantallaPrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverAPantallaPrincipalToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs)
        nv_producto.Show()
    End Sub

    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LatienditaDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.LatienditaDataSet.productos)
        Me.CenterToScreen()
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) 
        Try
            Me.ProductosTableAdapter.FillBy(Me.LatienditaDataSet.productos)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class