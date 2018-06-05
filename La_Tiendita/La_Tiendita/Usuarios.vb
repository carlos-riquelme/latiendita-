Public Class Usuarios

    Private Structure pageDetails
        Dim columns As Integer
        Dim rows As Integer
        Dim startCol As Integer
        Dim startRow As Integer
    End Structure

    Private pages As Dictionary(Of Integer, pageDetails)

    Dim maxPagesWide As Integer
    Dim maxPagesTall As Integer

    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LatienditaDataSet.users' Puede moverla o quitarla según sea necesario.
        Me.UsersTableAdapter.Fill(Me.LatienditaDataSet.users)
        Me.CenterToScreen()
        For r As Integer = 1 To 100
            Dim y As Integer = r
            Dim fmt As String = "R{0}C{1}"
            UsersDataGridView.Rows.Add()
            UsersDataGridView.Rows(r - 1).SetValues(Enumerable.Range(1, 10).Select(Function(x) String.Format(fmt, y, x)).ToArray)
            UsersDataGridView.Rows(r - 1).HeaderCell.Value = r.ToString

        Next
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

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles preview.Click
        Dim ppd As New PrintPreviewDialog
        ppd.Document = PrintDocument1
        ppd.WindowState = FormWindowState.Maximized
        ppd.ShowDialog()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        UsersTableAdapter.Fill(LatienditaDataSet.users)
    End Sub

    Private Sub ImprimirToolStripButton_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripButton.Click
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
        ''this removes the printed page margins 
        PrintDocument1.OriginAtMargins = True
        PrintDocument1.DefaultPageSettings.Margins = New Drawing.Printing.Margins(0, 0, 0, 0)

        pages = New Dictionary(Of Integer, pageDetails)

        Dim maxWidth As Integer = CInt(PrintDocument1.DefaultPageSettings.PrintableArea.Width) - 40
        Dim maxHeight As Integer = CInt(PrintDocument1.DefaultPageSettings.PrintableArea.Height) - 40 + Label1.Height

        Dim pageCounter As Integer = 0
        pages.Add(pageCounter, New pageDetails)

        Dim columnCounter As Integer = 0

        Dim columnSum As Integer = UsersDataGridView.RowHeadersWidth

        For c As Integer = 0 To UsersDataGridView.Columns.Count - 1
            If columnSum + UsersDataGridView.Columns(c).Width < maxWidth Then
                columnSum += UsersDataGridView.Columns(c).Width
                columnCounter += 1
            Else
                pages(pageCounter) = New pageDetails With {.columns = columnCounter, .rows = 0, .startCol = pages(pageCounter).startCol}
                columnSum = UsersDataGridView.RowHeadersWidth + UsersDataGridView.Columns(c).Width
                columnCounter = 1
                pageCounter += 1
                pages.Add(pageCounter, New pageDetails With {.startCol = c})
            End If
            If c = UsersDataGridView.Columns.Count - 1 Then
                If pages(pageCounter).columns = 0 Then
                    pages(pageCounter) = New pageDetails With {.columns = columnCounter, .rows = 0, .startCol = pages(pageCounter).startCol}
                End If
            End If
        Next

        maxPagesWide = pages.Keys.Max + 1

        pageCounter = 0

        Dim rowCounter As Integer = 0

        Dim rowSum As Integer = UsersDataGridView.ColumnHeadersHeight

        For r As Integer = 0 To UsersDataGridView.Rows.Count - 2
            If rowSum + UsersDataGridView.Rows(r).Height < maxHeight Then
                rowSum += UsersDataGridView.Rows(r).Height
                rowCounter += 1
            Else
                pages(pageCounter) = New pageDetails With {.columns = pages(pageCounter).columns, .rows = rowCounter, .startCol = pages(pageCounter).startCol, .startRow = pages(pageCounter).startRow}
                For x As Integer = 1 To maxPagesWide - 1
                    pages(pageCounter + x) = New pageDetails With {.columns = pages(pageCounter + x).columns, .rows = rowCounter, .startCol = pages(pageCounter + x).startCol, .startRow = pages(pageCounter).startRow}
                Next

                pageCounter += maxPagesWide
                For x As Integer = 0 To maxPagesWide - 1
                    pages.Add(pageCounter + x, New pageDetails With {.columns = pages(x).columns, .rows = 0, .startCol = pages(x).startCol, .startRow = r})
                Next

                rowSum = UsersDataGridView.ColumnHeadersHeight + UsersDataGridView.Rows(r).Height
                rowCounter = 1
            End If
            If r = UsersDataGridView.Rows.Count - 2 Then
                For x As Integer = 0 To maxPagesWide - 1
                    If pages(pageCounter + x).rows = 0 Then
                        pages(pageCounter + x) = New pageDetails With {.columns = pages(pageCounter + x).columns, .rows = rowCounter, .startCol = pages(pageCounter + x).startCol, .startRow = pages(pageCounter + x).startRow}
                    End If
                Next
            End If
        Next

        maxPagesTall = pages.Count \ maxPagesWide

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim rect As New Rectangle(20, 20, CInt(PrintDocument1.DefaultPageSettings.PrintableArea.Width), Label1.Height)
        Dim sf As New StringFormat
        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center

        'e.Graphics.DrawString(Label1.Text, Label1.Font, Brushes.Black, rect, sf)

        sf.Alignment = StringAlignment.Near

        Dim startX As Integer = 50
        Dim startY As Integer = rect.Bottom

        Static startPage As Integer = 0

        For p As Integer = startPage To pages.Count - 1
            Dim cell As New Rectangle(startX, startY, UsersDataGridView.RowHeadersWidth, UsersDataGridView.ColumnHeadersHeight)
            e.Graphics.FillRectangle(New SolidBrush(SystemColors.ControlLight), cell)
            e.Graphics.DrawRectangle(Pens.Black, cell)

            startY += UsersDataGridView.ColumnHeadersHeight

            For r As Integer = pages(p).startRow To pages(p).startRow + pages(p).rows - 1
                cell = New Rectangle(startX, startY, UsersDataGridView.RowHeadersWidth, UsersDataGridView.Rows(r).Height)
                e.Graphics.FillRectangle(New SolidBrush(SystemColors.ControlLight), cell)
                e.Graphics.DrawRectangle(Pens.Black, cell)
                'e.Graphics.DrawString(ProductosDataGridView.Rows(r).HeaderCell.Value.ToString, ProductosDataGridView.Font, Brushes.Black, cell, sf)
                startY += UsersDataGridView.Rows(r).Height
            Next

            startX += cell.Width
            startY = rect.Bottom

            For c As Integer = pages(p).startCol To pages(p).startCol + pages(p).columns - 1
                cell = New Rectangle(startX, startY, UsersDataGridView.Columns(c).Width, UsersDataGridView.ColumnHeadersHeight)
                e.Graphics.FillRectangle(New SolidBrush(SystemColors.ControlLight), cell)
                e.Graphics.DrawRectangle(Pens.Black, cell)
                e.Graphics.DrawString(UsersDataGridView.Columns(c).HeaderCell.Value.ToString, UsersDataGridView.Font, Brushes.Black, cell, sf)
                startX += UsersDataGridView.Columns(c).Width
            Next

            startY = rect.Bottom + UsersDataGridView.ColumnHeadersHeight

            For r As Integer = pages(p).startRow To pages(p).startRow + pages(p).rows - 1
                startX = 50 + UsersDataGridView.RowHeadersWidth
                For c As Integer = pages(p).startCol To pages(p).startCol + pages(p).columns - 1
                    cell = New Rectangle(startX, startY, UsersDataGridView.Columns(c).Width, UsersDataGridView.Rows(r).Height)
                    e.Graphics.DrawRectangle(Pens.Black, cell)
                    e.Graphics.DrawString(UsersDataGridView(c, r).Value.ToString, UsersDataGridView.Font, Brushes.Black, cell, sf)
                    startX += UsersDataGridView.Columns(c).Width
                Next
                startY += UsersDataGridView.Rows(r).Height
            Next

            If p <> pages.Count - 1 Then
                startPage = p + 1
                e.HasMorePages = True
                Return
            Else
                startPage = 0
            End If

        Next

    End Sub

    Private Sub buscar_Click(sender As Object, e As EventArgs) Handles buscar.Click
        busca_user.Show()
    End Sub
End Class