﻿Imports System.Data.SqlClient

Public Class busca_cliente

    Dim connection As New SqlConnection("Data Source=<<NOMBRESERVIDORSQLSERVER>>;Initial Catalog=latiendita;Integrated Security=True")

    Private Sub busca_cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LatienditaDataSet.clientes' Puede moverla o quitarla según sea necesario.
        'Me.ClientesTableAdapter.Fill(Me.LatienditaDataSet.clientes)
        FilterData("")

    End Sub

    Public Sub FilterData(valueToSearch As String)
        'SELECT * From Users WHERE CONCAT(fname, lname, age) like '%F%'
        Dim searchQuery As String = "SELECT * From clientes WHERE CONCAT(idclientes, nombre, app, apm, direccion, comuna, correo) like '%" & TextBox1.Text & "%'"

        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table

    End Sub

    Private Sub BTN_FILTER_Click(sender As Object, e As EventArgs)

        FilterData(TextBox1.Text)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        FilterData(TextBox1.Text)

    End Sub

End Class