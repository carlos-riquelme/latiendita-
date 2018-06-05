Imports System.Data.SqlClient

Public Class busca_prod

    Dim connection As New SqlConnection("Data Source=ANC-CRIQUELME;Initial Catalog=latiendita;Integrated Security=True")

    Private Sub busca_prod_load(sender As Object, e As EventArgs) Handles MyBase.Load

        FilterData("")

    End Sub

    Public Sub FilterData(valueToSearch As String)
        'SELECT * From Users WHERE CONCAT(fname, lname, age) like '%F%'
        Dim searchQuery As String = "SELECT * From productos WHERE CONCAT(idproducto, nombre, descripcion, idinventario) like '%" & TextBox1.text & "%'"

        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table

    End Sub

    Private Sub BTN_FILTER_Click(sender As Object, e As EventArgs) Handles Button1.Click

        FilterData(TextBox1.Text)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        FilterData(TextBox1.Text)

    End Sub
End Class