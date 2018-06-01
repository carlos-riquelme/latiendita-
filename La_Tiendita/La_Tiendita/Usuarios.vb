Public Class Usuarios
    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LatienditaDataSet.users' Puede moverla o quitarla según sea necesario.
        Me.UsersTableAdapter.Fill(Me.LatienditaDataSet.users)
        Me.CenterToScreen()
    End Sub

    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.UsersTableAdapter.FillBy(Me.LatienditaDataSet.users)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        For Each row As DataGridViewRow In UsersDataGridView.SelectedRows
            UsersDataGridView.Rows.Remove(row)
        Next
    End Sub

    Private Sub GuardarToolStripButton_Click(sender As Object, e As EventArgs) Handles GuardarToolStripButton.Click
        Try
            Me.Validate()
            Me.UsersBindingSource.EndEdit()
            UsersTableAdapter.Update(LatienditaDataSet.users)
            MsgBox("Actualización Exitosa")
        Catch ex As Exception
            MsgBox("Se produjo un error y no sabemos cuál es. Mala suerte.")
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        UsersTableAdapter.Fill(LatienditaDataSet.users)
    End Sub
End Class