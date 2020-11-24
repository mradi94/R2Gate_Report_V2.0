using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Tools.Excel;
using Microsoft.Office.Core;
using Excel = Microsoft.Office.Interop.Excel;

namespace R2Gate_Report_v2._0
{
    class PacientData
    {
 
        #region Initial Patient-Data Form -> Fields
        public static String orderNo;
        public static String patient;
        public static String clinic;
        public static String dentist;
        public static String opSite;
        public static String opDate;
        public static String opOption;
        public static String putty;
        public static String txOption;
        public static String anchor;
        public static String r2Stent1;
        public static String r2Stent2;
        public static String r2Stent3;
        public static String custom1;
        public static String custom2;
        public static String custom3;
        public static String temp1;
        public static String temp2;
        public static String temp3;
        public static String salesRep;
        public static String operatorPC;
        public static String designerPC;
       
        public static Boolean hasPutty;
        public static Boolean hasNarrow;
        public static Boolean hasRegularWide;
        public static Boolean hasBoneProfiler;
        public static Boolean hasNarrowCrestDrill;
        public static Boolean hasAnchorStent;
        public static Boolean hasMUA00;
        public static Boolean hasMUA17;
        public static Boolean hasMUA26;


        #endregion 
        public static List<List<Image>> images;
        public static Boolean hasPins;
        public static ToothDetails[] toothDetails;
        public static double getRatio()
        {
            if (PacientData.getIndexImage() == 0 || PacientData.getIndexImage() == 1)
            {
                return 1.7660377;
            }
            if (!hasPins)
            {
                if (PacientData.getGroupComponentIndex() == 1)
                {
                    return 1.5705128;
                }
                if (PacientData.getGroupComponentIndex() == 2)
                {
                    return 1.525641;
                }
                if (PacientData.getGroupComponentIndex() == 3)
                {
                    return 1.4807692;
                }
            }
            else
            {
                if (PacientData.getPinNumber() % 3 == 1)
                {
                    return 1.5217391;
                }
                if (PacientData.getPinNumber() % 3 == 2)
                {
                    return 1.4782608;
                }
                if (PacientData.getPinNumber() % 3 == 0)
                {
                    return 1.4347826;
                }
            }

            return -1;
        }
        public static ToothDetails currentTooth;
    
        

        public PacientData()
        {
            #region initialize String Data ()
            orderNo     = "";
            patient     = "";
            clinic      = "";
            dentist     = "";
            opSite      = "";
            opDate      = "";
            opOption    = "";
            putty       = "";
            txOption    = "";
            anchor      = "";
            r2Stent1    = "";
            r2Stent2    = "[Qty]";
            r2Stent3    = "";
            custom1     = "";
            custom2     = "[Qty]";
            custom3     = "";
            temp1       = "";
            temp2       = "[Qty]";
            temp3       = "";
            salesRep    = "";
            operatorPC  = "";
            designerPC  = "";
            
            hasPutty = false;
            hasNarrow = false;
            hasRegularWide = false;
            hasBoneProfiler = false;
            hasNarrowCrestDrill = false;
            hasAnchorStent = false;
            hasMUA00 = false;
            hasMUA17 = false;
            hasMUA26 = false;
             
            #endregion
            images = new List<List<Image>>();
            hasPins = false;
            toothDetails = new ToothDetails[100];
            for (int i = 0; i < toothDetails.Length; i++)
            {
                toothDetails[i] = new ToothDetails();
            }
            currentTooth = new ToothDetails();
        }

        public static int toothEntitiesNumber;
        public static int getToothEntitiesNumber() 
        {
            if (PacientData.hasPins)
            {
                return toothEntitiesNumber;
            }
            toothEntitiesNumber = PacientData.getGroupIndex();
            return toothEntitiesNumber;
        }
        public static int getPinNumber()
        {
            if (!hasPins)
            {
                return -1000;
            }

            return PacientData.getIndexImage() - 1 - 3 * PacientData.getToothEntitiesNumber();
        }
        public static int getIndexImage()
        {
            return AllPatientImages.getIndexImage();
        }
        public static int getGroupIndex()
        {
            return AllPatientImages.getGroupIndex();
        }
        public static int getGroupComponentIndex()
        {
            return AllPatientImages.getGroupComponentIndex();
        }
        public static void setMaximImages(int maximImages)
        {
            AllPatientImages.setGroupMaximImages(maximImages);
        }
        public static void addImage(Image img)
        {
            AllPatientImages.addImage(img);
        }
        public static void removeImage()
        {
            AllPatientImages.removeImage();
        }



        public static void exportAllToExcel()
        {
            exportDataToExcel();
            exportImagesToExcel();
        }
        public static void saveAll(String location)
        {
            ExcelReport.saveExcelFile(location);
        }
        private static void exportDataToExcel()
        {
            ExcelReport.xlWorkSheet.Cells[4, 3] = orderNo;
            ExcelReport.xlWorkSheet.Cells[5, 3] = patient;
            ExcelReport.xlWorkSheet.Cells[6, 3] = clinic;
            ExcelReport.xlWorkSheet.Cells[7, 3] = dentist;
            ExcelReport.xlWorkSheet.Cells[4, 7] = opSite;
            ExcelReport.xlWorkSheet.Cells[5, 7] = opDate;
            ExcelReport.xlWorkSheet.Cells[6, 7] = opOption;
            ExcelReport.xlWorkSheet.Cells[6, 10] = txOption;
            ExcelReport.xlWorkSheet.Cells[7, 7] = putty;
            ExcelReport.xlWorkSheet.Cells[7, 10] = anchor;
            ExcelReport.xlWorkSheet.Cells[5, 14] = r2Stent1;
            ExcelReport.xlWorkSheet.Cells[5, 16] = r2Stent2;
            ExcelReport.xlWorkSheet.Cells[5, 17] = r2Stent3;
            ExcelReport.xlWorkSheet.Cells[6, 14] = custom1;
            ExcelReport.xlWorkSheet.Cells[6, 16] = custom2;
            ExcelReport.xlWorkSheet.Cells[6, 17] = custom3;
            ExcelReport.xlWorkSheet.Cells[7, 14] = temp1;
            ExcelReport.xlWorkSheet.Cells[7, 16] = temp2;
            ExcelReport.xlWorkSheet.Cells[7, 17] = temp3;
            ExcelReport.xlWorkSheet.Cells[8, 14] = salesRep;
            ExcelReport.xlWorkSheet.Cells[9, 14] = operatorPC;
            ExcelReport.xlWorkSheet.Cells[10, 14] = designerPC;
        }
        private static String getLocationImage(Image img)
        {
            img.Save(@"Generated Image\Image.jpg");
            return @"C:\Users\Adi\Documents\Visual Studio 2012\Projects\R2Gate Report v2.0\R2Gate Report v2.0\bin\Debug\Generated Image\Image.jpg";
        }
        private static void exportImagesToExcel()
        {
         //TODO
        
        }
        private static void exportImageToExcel(Image img,int cellRow, int cellColumn)
        {
          
            Excel.Range oRange = (Excel.Range)ExcelReport.xlWorkSheet.Cells[cellRow, cellColumn];
            double width  = 3.0 * img.Width  / 4.0;
            double height = 3.0 * img.Height / 4.0;
            double top  = oRange.Top;
            double left = oRange.Left;
            Console.WriteLine(cellRow+" "+cellColumn+" : "+ top + " " + left);
            ExcelReport.xlWorkSheet.Shapes.AddPicture(getLocationImage(img), Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, (float)left, (float)top, (float)width, (float)height);

            
        }



    }
}
