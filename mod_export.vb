Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf



Module mod_export
    Dim pdffile As String


    Sub SavePDFDialog()
        frmViewRecords.labelStatus.Text = frmViewRecords.labelStatus.Text + " exporting"

        Dim folderPath As String = "C:\PDFs\"
        If Not Directory.Exists(folderPath) Then
            Directory.CreateDirectory(folderPath)
        End If

        frmViewRecords.SaveFileDialog1.Filter = "PDF Files (*.pdf*)|*.pdf"
        frmViewRecords.SaveFileDialog1.InitialDirectory = "C:\PDFs\"

        If frmViewRecords.SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            pdffile = frmViewRecords.SaveFileDialog1.FileName.ToString
            '' ExportDataToPDFTable()
            exportPDF()

<<<<<<< HEAD
            frmViewRecords.labelStatus.Text = frmViewRecords.labelStatus.Text + "PDF file : " + pdffile + " created Successfully!"
            MsgBox("PDF file : " + pdffile + " created Successfully!")
        Else
            MsgBox("Enter Filename to create PDF", "PropertyXplorer")
=======
            frmViewRecords.labelStatus.Text = frmViewRecords.labelStatus.Text + " PDF Created! "
            MsgBox("PDF Created Successfully")
        Else
            MsgBox("Enter Filename to create PDF")
>>>>>>> f54819e443c85e5ff52398d5c81defd02cc2ea52

        End If
    End Sub


    Sub exportPDF()
        frmViewRecords.labelStatus.Text = "STATUS : "

        ''pdffile = "export_" & pdffile.ToString


        '' DataGridView1.DataSource = PopulateDataGridViewResto()
        'Creating iTextSharp Table from the DataTable data
        Dim pdfTable As New PdfPTable(frmViewRecords.DataGridView1.ColumnCount)
        pdfTable.DefaultCell.Padding = 3
        pdfTable.WidthPercentage = 100
        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT
        pdfTable.DefaultCell.BorderWidth = 1


        ''Label2.Text = "Adding header row"

        'Adding Header row
        For Each column As DataGridViewColumn In frmViewRecords.DataGridView1.Columns
            Dim cell As New PdfPCell(New Phrase(column.HeaderText))
            '' cell.BackgroundColor = New iTextSharp.text.Color(240, 240, 240)
            pdfTable.AddCell(cell)
        Next

        ''Label2.Text = "Adding data row"

        'Adding DataRow
        For Each row As DataGridViewRow In frmViewRecords.DataGridView1.Rows
            For Each cell As DataGridViewCell In row.Cells
                If row.IsNewRow Then Continue For

                pdfTable.AddCell(cell.Value.ToString())
            Next
        Next

        ''Label2.Text = "Exporting pdf"

        'Exporting to PDF
        Using stream As New FileStream(pdffile, FileMode.Create)
            Dim pdfDoc As New Document(PageSize.A2, 10.0F, 10.0F, 10.0F, 0.0F)
            PdfWriter.GetInstance(pdfDoc, stream)
            pdfDoc.Open()
            pdfDoc.Add(pdfTable)
            pdfDoc.Close()
            stream.Close()
        End Using



    End Sub







End Module
