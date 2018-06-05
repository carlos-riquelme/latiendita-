Public Class Productos

    Private Structure pageDetails
        Dim columns As Integer
        Dim rows As Integer
        Dim startCol As Integer
        Dim startRow As Integer
    End Structure

    Private pages As Dictionary(Of Integer, pageDetails)

    Dim maxPagesWide As Integer
    Dim maxPagesTall As Integer

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
        'TODO: esta línea de código carga datos en la tabla 'LatienditaDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.LatienditaDataSet.productos)
        Me.CenterToScreen()
        ProductosDataGridView.RowHeadersWidth = CInt(ProductosDataGridView.RowHeadersWidth * 1.35)
        For r As Integer = 1 To 100
            Dim y As Integer = r
            Dim fmt As String = "R{0}C{1}"
            ProductosDataGridView.Rows.Add()
            ProductosDataGridView.Rows(r - 1).SetValues(Enumerable.Range(1, 10).Select(Function(x) String.Format(fmt, y, x)).ToArray)
            ProductosDataGridView.Rows(r - 1).HeaderCell.Value = r.ToString

        Next
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.ProductosTableAdapter.FillBy(Me.LatienditaDataSet.productos)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ImprimirToolStripButton_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripButton.Click
        PrintDocument1.Print()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim ppd As New PrintPreviewDialog
        ppd.Document = PrintDocument1
        ppd.WindowState = FormWindowState.Maximized
        ppd.ShowDialog()
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

        Dim columnSum As Integer = ProductosDataGridView.RowHeadersWidth

        For c As Integer = 0 To ProductosDataGridView.Columns.Count - 1
            If columnSum + ProductosDataGridView.Columns(c).Width < maxWidth Then
                columnSum += ProductosDataGridView.Columns(c).Width
                columnCounter += 1
            Else
                pages(pageCounter) = New pageDetails With {.columns = columnCounter, .rows = 0, .startCol = pages(pageCounter).startCol}
                columnSum = ProductosDataGridView.RowHeadersWidth + ProductosDataGridView.Columns(c).Width
                columnCounter = 1
                pageCounter += 1
                pages.Add(pageCounter, New pageDetails With {.startCol = c})
            End If
            If c = ProductosDataGridView.Columns.Count - 1 Then
                If pages(pageCounter).columns = 0 Then
                    pages(pageCounter) = New pageDetails With {.columns = columnCounter, .rows = 0, .startCol = pages(pageCounter).startCol}
                End If
            End If
        Next

        maxPagesWide = pages.Keys.Max + 1

        pageCounter = 0

        Dim rowCounter As Integer = 0

        Dim rowSum As Integer = ProductosDataGridView.ColumnHeadersHeight

        For r As Integer = 0 To ProductosDataGridView.Rows.Count - 2
            If rowSum + ProductosDataGridView.Rows(r).Height < maxHeight Then
                rowSum += ProductosDataGridView.Rows(r).Height
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

                rowSum = ProductosDataGridView.ColumnHeadersHeight + ProductosDataGridView.Rows(r).Height
                rowCounter = 1
            End If
            If r = ProductosDataGridView.Rows.Count - 2 Then
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
            Dim cell As New Rectangle(startX, startY, ProductosDataGridView.RowHeadersWidth, ProductosDataGridView.ColumnHeadersHeight)
            e.Graphics.FillRectangle(New SolidBrush(SystemColors.ControlLight), cell)
            e.Graphics.DrawRectangle(Pens.Black, cell)

            startY += ProductosDataGridView.ColumnHeadersHeight

            For r As Integer = pages(p).startRow To pages(p).startRow + pages(p).rows - 1
                cell = New Rectangle(startX, startY, ProductosDataGridView.RowHeadersWidth, ProductosDataGridView.Rows(r).Height)
                e.Graphics.FillRectangle(New SolidBrush(SystemColors.ControlLight), cell)
                e.Graphics.DrawRectangle(Pens.Black, cell)
                'e.Graphics.DrawString(ProductosDataGridView.Rows(r).HeaderCell.Value.ToString, ProductosDataGridView.Font, Brushes.Black, cell, sf)
                startY += ProductosDataGridView.Rows(r).Height
            Next

            startX += cell.Width
            startY = rect.Bottom

            For c As Integer = pages(p).startCol To pages(p).startCol + pages(p).columns - 1
                cell = New Rectangle(startX, startY, ProductosDataGridView.Columns(c).Width, ProductosDataGridView.ColumnHeadersHeight)
                e.Graphics.FillRectangle(New SolidBrush(SystemColors.ControlLight), cell)
                e.Graphics.DrawRectangle(Pens.Black, cell)
                e.Graphics.DrawString(ProductosDataGridView.Columns(c).HeaderCell.Value.ToString, ProductosDataGridView.Font, Brushes.Black, cell, sf)
                startX += ProductosDataGridView.Columns(c).Width
            Next

            startY = rect.Bottom + ProductosDataGridView.ColumnHeadersHeight

            For r As Integer = pages(p).startRow To pages(p).startRow + pages(p).rows - 1
                startX = 50 + ProductosDataGridView.RowHeadersWidth
                For c As Integer = pages(p).startCol To pages(p).startCol + pages(p).columns - 1
                    cell = New Rectangle(startX, startY, ProductosDataGridView.Columns(c).Width, ProductosDataGridView.Rows(r).Height)
                    e.Graphics.DrawRectangle(Pens.Black, cell)
                    e.Graphics.DrawString(ProductosDataGridView(c, r).Value.ToString, ProductosDataGridView.Font, Brushes.Black, cell, sf)
                    startX += ProductosDataGridView.Columns(c).Width
                Next
                startY += ProductosDataGridView.Rows(r).Height
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

    Private Sub GuardarToolStripButton_Click(sender As Object, e As EventArgs) Handles GuardarToolStripButton.Click
        Try
            Me.Validate()
            Me.ProductosBindingSource.EndEdit()
            ProductosTableAdapter.Update(LatienditaDataSet.productos)
            MsgBox("Actualización Exitosa")
        Catch ex As Exception
            MsgBox("Se produjo un error y no sabemos cuál es. Mala suerte.")
        End Try
    End Sub

    Private Sub actualizar_Click(sender As Object, e As EventArgs) Handles actualizar.Click
        ProductosTableAdapter.Fill(LatienditaDataSet.productos)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        busca_prod.Show()
    End Sub
End Class