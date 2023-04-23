﻿Imports System.IO
Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient

Module ExportReports

    Public currentDate As DateTime = DateTime.Now
    Public strpassword = "mdbanares"
    Dim currentDirectory As String = System.IO.Directory.GetCurrentDirectory()
    Dim parentDirectory1 As String = System.IO.Directory.GetParent(currentDirectory).ToString()
    Dim parentDirectory2 As String = System.IO.Directory.GetParent(parentDirectory1).ToString()
    Dim parentDirectory3 As String = System.IO.Directory.GetParent(parentDirectory2).ToString()

    Public templatePath As String = parentDirectory3 & "\ReportsXLS\Template\"
    Public reportFiles As String = parentDirectory3 & "\ReportsXLS\"

    'Public templatePath As String = "..\..\..\ReportsXLS\Template\"
    'Public reportFiles As String = "..\..\..\ReportsXLS\"

    Public Sub ImportToExcel(ByVal mydg As DataGridView, ByVal templatefilename As String)
        Dim xlsApp As Excel.Application = Nothing
        Dim xlsWB As Excel.Workbook = Nothing
        Dim xlsSheet As Excel.Worksheet = Nothing

        Try
            xlsApp = New Excel.Application
            xlsApp.Visible = False
            xlsWB = xlsApp.Workbooks.Open(templatePath & templatefilename)

            'first worksheet in excel file
            xlsSheet = xlsWB.Worksheets(1)
            Dim x, y As Integer
            For x = 0 To mydg.RowCount - 1
                For y = 0 To mydg.ColumnCount - 1
                    'B5 (row 5, column b)
                    xlsSheet.Cells(x + 5, y + 1) = mydg.Rows(x).Cells(y).Value
                Next
            Next
            'Border style
            xlsSheet.Range(convertToLetters(1) & 5, convertToLetters(mydg.ColumnCount) & x + 4).Borders.LineStyle = Excel.XlLineStyle.xlContinuous

            'templatefilename = templatefilename.Replace(".xlsx", "")
            'templatefilename = templatefilename.Replace(".xls", "")
            templatefilename = Path.ChangeExtension(templatefilename, Nothing)
            Dim myfilename As String = templatefilename & " " & DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") & ".xlsx"
            'MsgBox(myfilename)
            MessageBox.Show(templatePath, "File created successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            xlsSheet.Protect(strpassword)
            'Page layout view
            xlsApp.ActiveWindow.View = Excel.XlWindowView.xlPageLayoutView
            xlsApp.ActiveWindow.DisplayGridlines = False
            xlsWB.SaveAs(reportFiles & myfilename)
            xlsApp.Quit()
        Catch ex As Exception
            MessageBox.Show("Error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            releaseObject(xlsApp)
            releaseObject(xlsWB)
            releaseObject(xlsSheet)
        End Try
        'System.Diagnostics.Process.Start("excel.exe", """" & reportFiles & myfilename & """")
    End Sub

    Public Function convertToLetters(ByVal columnNumber As Integer) As String
        Dim columnName As String = ""
        While columnNumber > 0
            Dim remainder As Integer = (columnNumber - 1) Mod 26
            columnName = Chr(65 + remainder) & columnName
            columnNumber = (columnNumber - remainder) \ 26
        End While
        Return columnName
    End Function

    'Public Function convertToLetters(ByVal number As Integer) As String
    'number -= 1
    'Dim result As String = String.Empty

    'If (26 > number) Then
    'result = Chr(number + 65)
    'Else
    'Dim column As Integer

    'Do
    'column = number Mod 26
    'number = (number \ 26) - 1
    'result = Chr(column + 65) + result
    'Loop Until (number < 0)
    'End If

    'Return result

    'End Function

    Public Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Module

