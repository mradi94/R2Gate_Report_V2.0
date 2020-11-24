using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Tools.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace R2Gate_Report_v2._0
{
    class ExcelReport
    {
        
        public static List<ToothSelectionExcel> teethSelectionsExcel ;
        public static int nextExcelRowIndex ; // from row 26 we will start excel tabels.
        
        // Excel file !
        private static String baseExcelLocation ; // -> Location BaseExcelReport
        public static Excel.Application xlApp ;    
        public static Excel.Workbook  xlWorkBook ;
        public static Excel.Worksheet xlWorkSheet ;
        
        public ExcelReport()
        {
            teethSelectionsExcel = new List<ToothSelectionExcel>();
            List<Image> teethImages = new List<Image>();
            nextExcelRowIndex = 27;
            baseExcelLocation = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            baseExcelLocation = baseExcelLocation.Substring(6) + @"\Excel\BaseExcelReport.xlsx";
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(baseExcelLocation);
            xlWorkSheet = xlApp.ActiveSheet as Excel.Worksheet;

        }

        public static void addToothSelection(ToothSelectionExcel newTooth)
        {
            ExcelReport.teethSelectionsExcel.Add(newTooth);
            //ExcelReport.nextExcelRowIndex += newTooth.getRowsNumber();   
        }
       
        public static void pasteInitialExcelTable(int startIndex, int endIndex) // paste initial Excel selection
        {                                                             // Paste when you need
            ExcelReport.xlWorkSheet.get_Range("B389", "Q398").Copy(); // Copy selection from BaseExcel
            String TopLeft, BottomRight;
            TopLeft = "B" + startIndex;
            BottomRight = "Q" + endIndex;
            xlWorkSheet.get_Range(TopLeft, BottomRight).PasteSpecial(Excel.XlPasteType.xlPasteAll
                                            , Excel.XlPasteSpecialOperation.xlPasteSpecialOperationNone, false, false);  
        }

        public static void pasteSpecialRow(String rowType,int startIndex)
        {
            switch (rowType)
            {
                case "Bone Profiler":
                    ExcelReport.xlWorkSheet.get_Range("B382", "Q382").Copy();
                    break;
                case "Narrow Crest Drill":
                    ExcelReport.xlWorkSheet.get_Range("B383", "Q383").Copy();
                    break;
                case "Anchor Stent":
                    ExcelReport.xlWorkSheet.get_Range("B384", "Q384").Copy();
                    break;
                case "MUA":
                    ExcelReport.xlWorkSheet.get_Range("B385", "Q385").Copy();        
                    break;  
                default:
                    return;
            }

            String TopLeft, BottomRight;
            TopLeft = "B" + startIndex;
            BottomRight = "Q" + startIndex;
            Console.WriteLine(TopLeft + " " + BottomRight);
            xlWorkSheet.get_Range(TopLeft, BottomRight).PasteSpecial(Excel.XlPasteType.xlPasteAll
                                            , Excel.XlPasteSpecialOperation.xlPasteSpecialOperationNone, false, false); 
            
        }
        public static void pasteSpecialRow(String rowType, int startIndex, int indexTooth)
        {
            pasteSpecialRow(rowType, startIndex);
            String degreesAndHeight="MUA ";
            if (PacientData.toothDetails[indexTooth].hasMUA0)
            {
                degreesAndHeight += "0°,CH=";
            }
            if (PacientData.toothDetails[indexTooth].hasMUA17)
            {
                degreesAndHeight += "17°,CH=";
            }
            if (PacientData.toothDetails[indexTooth].hasMUA29)
            {
                degreesAndHeight += "29°,CH=";
            }
            degreesAndHeight += PacientData.toothDetails[indexTooth].dimensionMM+"mm";
            ExcelReport.xlWorkSheet.Cells[startIndex, 4] = degreesAndHeight;
        }


        public static void pasteAnchorPin(int startIndex,int endIndex)
        {
            ExcelReport.xlWorkSheet.get_Range("B400", "Q410").Copy(); // Copy selection from BaseExcel
            String TopLeft, BottomRight;
            TopLeft = "B" + startIndex;
            BottomRight = "Q" + endIndex;
            xlWorkSheet.get_Range(TopLeft, BottomRight).PasteSpecial(Excel.XlPasteType.xlPasteAll
                                            , Excel.XlPasteSpecialOperation.xlPasteSpecialOperationNone, false, false);
        }
        
        
        
        public static void saveExcelFile(String location) //Save final work in a String Location
        {
            Console.WriteLine("excel:" + location);
            xlWorkBook.SaveAs(location, Excel.XlFileFormat.xlWorkbookDefault);
            
        }


        public static void savePdfFile(String location)
        {
            //location = location.Substring(0, location.Length - 5);
            String pdfLocation = location + ".pdf";
            Excel.Range excelRange = xlWorkSheet.Range["B1", "Q"+ (nextExcelRowIndex + 1)];


            excelRange.ExportAsFixedFormat(Excel.XlFixedFormatType.xlTypePDF, pdfLocation);

           


            xlWorkBook.Close();
            xlApp.Quit();
        }

        private bool ExportWorkbookToPdf(string workbookPath, string outputPath)
        {
            // If either required string is null or empty, stop and bail out
            if (string.IsNullOrEmpty(workbookPath) || string.IsNullOrEmpty(outputPath))
            {
                return false;
            }

            // Create COM Objects
            Microsoft.Office.Interop.Excel.Application excelApplication;
            Microsoft.Office.Interop.Excel.Workbook excelWorkbook;

            // Create new instance of Excel
            excelApplication = new Microsoft.Office.Interop.Excel.Application();

            // Make the process invisible to the user
            excelApplication.ScreenUpdating = false;

            // Make the process silent
            excelApplication.DisplayAlerts = false;

            // Open the workbook that you wish to export to PDF
            excelWorkbook = excelApplication.Workbooks.Open(workbookPath);

            // If the workbook failed to open, stop, clean up, and bail out
            if (excelWorkbook == null)
            {
                excelApplication.Quit();

                excelApplication = null;
                excelWorkbook = null;

                return false;
            }

            var exportSuccessful = true;
            try
            {

                //Call Excel's native export function (valid in Office 2007 and Office 2010, AFAIK)
                //excelWorkbook.ExportAsFixedFormat(Microsoft.Office.Interop.Excel.XlFixedFormatType.xlTypePDF, outputPath);
                Excel.Worksheet excelWorksheet = excelApplication.ActiveSheet as Excel.Worksheet;
                Excel.Range excelRange = excelWorksheet.Range["B1", "Q139"];
                excelRange.ExportAsFixedFormat(Excel.XlFixedFormatType.xlTypePDF, outputPath);

            }
            catch (System.Exception ex)
            {
            
                // Mark the export as failed for the return value...
                exportSuccessful = false;

                // Do something with any exceptions here, if you wish...
                // MessageBox.Show...        
            }
            finally
            {
                // Close the workbook, quit the Excel, and clean up regardless of the results...
                excelWorkbook.Close();
                excelApplication.Quit();

                excelApplication = null;
                excelWorkbook = null;
            }

            // You can use the following method to automatically open the PDF after export if you wish
            // Make sure that the file actually exists first...
            if (System.IO.File.Exists(outputPath))
            {
                System.Diagnostics.Process.Start(outputPath);
            }

            return exportSuccessful;
        }

        public static void openPdfFile(String location)
        {

            location += ".pdf";
            System.Diagnostics.Process.Start(location);

        }


    }
}
