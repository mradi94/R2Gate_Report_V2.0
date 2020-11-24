using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace R2Gate_Report_v2._0
{
    class PasteAllToExcel
    {
        private const double maximHeight = 510;
        private List<int> excelRowBreak;

        private int currentExcelBreakIndex;
        private double currentHeightSum;


        private int teethNumber;
        private int pinNumber, pinGroups;
        private List<List<Image>> images;
        private ToothDetails[] toothDetails;
        private void pasteTeeth()
        {



            for (int i = 1; i <= teethNumber; i++)
            {
                ToothSelectionExcel table = new ToothSelectionExcel();
                #region hasBoneProfiler, hasNarrowCrestDrill etc. table.addRowTooth("Name",15.25)
                if (toothDetails[i].hasBoneProfiler)
                {
                    table.addRowTooth("Bone Profiler", 15);
                }
                if (toothDetails[i].hasNarrowCrestDrill)
                {
                    table.addRowTooth("Narrow Crest Drill", 15);
                }
                if (toothDetails[i].hasAnchorStent)
                {
                    table.addRowTooth("Anchor Stent", 15);
                }
                if (toothDetails[i].hasMUA)
                {
                    table.addRowTooth("MUA", 15, i);
                }
                #endregion
                table.addRowTooth("Blank", 18);


                currentHeightSum += table.getTotalHeight();
                if (currentHeightSum > maximHeight)
                {
                    excelRowBreak.Add(currentExcelBreakIndex);
                    currentHeightSum = table.getTotalHeight();
                }
                currentExcelBreakIndex = table.getEndIndex();

                ExcelReport.teethSelectionsExcel.Add(table);
            }

            for (int i = 0; i < ExcelReport.teethSelectionsExcel.Count(); i++)
            {
                ToothDetails details = toothDetails[i + 1];
                int startIndex = ExcelReport.teethSelectionsExcel[i].getStartIndex();
                #region //tooth details[rows,columns]
                ExcelReport.xlWorkSheet.Cells[startIndex + 1, 2] = details.toothNotation;
                ExcelReport.xlWorkSheet.Cells[startIndex + 3, 2] = details.implantSystem;
                ExcelReport.xlWorkSheet.Cells[startIndex + 5, 4] = details.sizeDL1;
                ExcelReport.xlWorkSheet.Cells[startIndex + 5, 5] = details.sizeDL2;
                ExcelReport.xlWorkSheet.Cells[startIndex + 8, 4] = details.boneDensity;
                ExcelReport.xlWorkSheet.Cells[startIndex + 9, 4] = details.gbr;
                List<Image> groupImages = this.images[i + 1];
                #endregion
                //toothImages
                pasteImageInCell(groupImages[0], startIndex + 1, 6);
                pasteImageInCell(groupImages[1], startIndex + 1, 10);
                pasteImageInCell(groupImages[2], startIndex + 1, 14);

            }
        }

        public PasteAllToExcel()
        {
            if (!PacientData.hasPins)
            {
                teethNumber = PacientData.getToothEntitiesNumber() - 1;
            }
            else
            {
                teethNumber = PacientData.getToothEntitiesNumber();
            }
            currentExcelBreakIndex = 0;
            currentHeightSum = 0;
            pinNumber = PacientData.getPinNumber()-1;
            pinGroups = (pinNumber + 2) / 3;
            images = AllPatientImages.getAllImages();
            toothDetails = PacientData.toothDetails;
            excelRowBreak = new List<int>();
            pasteInitialData();
            pasteTeeth();
            if (PacientData.hasPins)
            {
                pastePins();
            }
            pasteAllPhotos();
            addBreaksToExcel();
        }
     
        private void pastePins()
        {

            for (int i = teethNumber + 1; i < teethNumber + 1 + pinNumber; i = i + 3)
            {
                ToothSelectionExcel table = new PinSelectionExcel();
                table.addRowTooth("Blank", 18);

                currentHeightSum += table.getTotalHeight();
                if (currentHeightSum > maximHeight)
                {
                    excelRowBreak.Add(currentExcelBreakIndex);
                    currentHeightSum = 0;
                }
                currentExcelBreakIndex = table.getEndIndex();

                ExcelReport.addToothSelection(table);
            }

            for (int i = 1; i <=(pinNumber+2)/3; i = i + 1)
            {
                
                int startIndex = ExcelReport.teethSelectionsExcel[teethNumber+i-1].getStartIndex();
                
                ToothDetails details = toothDetails[teethNumber+ 3*(i-1) + 1];
                ExcelReport.xlWorkSheet.Cells[startIndex + 9, 8] = details.pinToothNumber;
                ExcelReport.xlWorkSheet.Cells[startIndex + 10, 8] = details.pinSizeDL;
                
                details = toothDetails[teethNumber + 3 * (i - 1) + 2];
                ExcelReport.xlWorkSheet.Cells[startIndex + 9, 12] = details.pinToothNumber;
                ExcelReport.xlWorkSheet.Cells[startIndex + 10, 12] = details.pinSizeDL;

                details = toothDetails[teethNumber + 3 * (i - 1) + 3];
                ExcelReport.xlWorkSheet.Cells[startIndex + 9, 16] = details.pinToothNumber;
                ExcelReport.xlWorkSheet.Cells[startIndex + 10, 16] = details.pinSizeDL;

                try
                {
                    pasteImageInCell(images[teethNumber + 3 * (i - 1) + 1][0], startIndex + 1, 6);
                }
                catch (System.ArgumentOutOfRangeException e)
                {

                }
                try
                {
                    pasteImageInCell(images[teethNumber + 3 * (i - 1) + 2][0], startIndex + 1, 10);
                }
                catch (System.ArgumentOutOfRangeException e)
                {

                }
                try
                {
                    pasteImageInCell(images[teethNumber + 3 * (i - 1) + 3][0], startIndex + 1, 14);
                }
                catch (System.ArgumentOutOfRangeException e)
                {

                }
            }
            
        }
        private void pasteInitialData()
        {
            ExcelReport.xlWorkSheet.Cells[4, 3]     = PacientData.orderNo;
            ExcelReport.xlWorkSheet.Cells[5, 3]     = PacientData.patient;
            ExcelReport.xlWorkSheet.Cells[6, 3]     = PacientData.clinic;
            ExcelReport.xlWorkSheet.Cells[7, 3]     = PacientData.dentist;
            ExcelReport.xlWorkSheet.Cells[4, 7]     = PacientData.opSite;
            ExcelReport.xlWorkSheet.Cells[5, 7]     = PacientData.opDate;
            ExcelReport.xlWorkSheet.Cells[6, 7]     = PacientData.opOption;
            ExcelReport.xlWorkSheet.Cells[7, 7]     = PacientData.putty;
            ExcelReport.xlWorkSheet.Cells[6, 10]    = PacientData.txOption;
            ExcelReport.xlWorkSheet.Cells[7, 10]    = PacientData.anchor;
            ExcelReport.xlWorkSheet.Cells[6, 3]     = PacientData.clinic;
            ExcelReport.xlWorkSheet.Cells[5, 14]    = PacientData.r2Stent1;
            ExcelReport.xlWorkSheet.Cells[5, 16]    = PacientData.r2Stent2;
            ExcelReport.xlWorkSheet.Cells[5, 17]    = PacientData.r2Stent3;
            ExcelReport.xlWorkSheet.Cells[6, 14]    = PacientData.custom1;
            ExcelReport.xlWorkSheet.Cells[6, 16]    = PacientData.custom2;
            ExcelReport.xlWorkSheet.Cells[6, 17]    = PacientData.custom3;
            ExcelReport.xlWorkSheet.Cells[7, 14]    = PacientData.temp1;
            ExcelReport.xlWorkSheet.Cells[7, 16]    = PacientData.temp2;
            ExcelReport.xlWorkSheet.Cells[7, 17]    = PacientData.temp3;
            ExcelReport.xlWorkSheet.Cells[8, 14]    =  PacientData.salesRep;
            ExcelReport.xlWorkSheet.Cells[9, 14]    = PacientData.operatorPC;
            ExcelReport.xlWorkSheet.Cells[10, 14]   = PacientData.designerPC;

            pasteImageInCell(images[0][0],14,2);
            pasteImageInCell(images[0][1],14,10);


        }
        private void addBreaksToExcel()
        {

         
            ExcelReport.xlWorkSheet.Rows[27].PageBreak = true;
            for (int i = 0; i < excelRowBreak.Count(); i++)
            {
                ExcelReport.xlWorkSheet.Rows[excelRowBreak[i]].PageBreak = true;
                Console.Write(excelRowBreak[i] + " ");
            }
        }

        private void pastePhotoToExcel(String imageLocation)
        {
            imageLocation = getPathLocation() + @"\" + imageLocation;
            Image img = Image.FromFile(imageLocation);
            int row = ExcelReport.nextExcelRowIndex;
            int column = 2;
            float excelHeight = 3F * img.Height / 4F; ;
            ExcelReport.xlWorkSheet.get_Range("B" + row.ToString()).RowHeight = excelHeight / 2;
            ExcelReport.xlWorkSheet.get_Range("B" + (row+1).ToString()).RowHeight = excelHeight - excelHeight / 2 +10;

            pasteImageInCell(img, row, column);
            excelRowBreak.Add(row);
            ExcelReport.nextExcelRowIndex+=2;

        }
        private void pasteAllPhotos()
        {
            pastePhotoToExcel(@"P0.jpg");
            if (PacientData.hasPutty)
            {
                pastePhotoToExcel(@"P1.jpg");
            }

            if (PacientData.hasNarrow)
            {
                pastePhotoToExcel(@"P2.jpg");
            }
            if (PacientData.hasRegularWide)
            {
                pastePhotoToExcel(@"P3.jpg");
            }
            if (PacientData.hasBoneProfiler)
            {
                pastePhotoToExcel(@"P4.jpg");
            }
            if (PacientData.hasNarrowCrestDrill)
            {
                pastePhotoToExcel(@"P5.1.jpg");
                pastePhotoToExcel(@"P5.2.jpg");
            }
            if (PacientData.hasAnchorStent)
            {
                pastePhotoToExcel(@"P6.1.jpg");
                pastePhotoToExcel(@"P6.2.jpg"); ;
            }
            if (PacientData.hasMUA00)
            {
                //pastePhotoToExcel(@"P7.jpg");
            }

            if (PacientData.hasMUA17)
            {
                //pastePhotoToExcel(@"P8.jpg");
            }

            if (PacientData.hasMUA26)
            {
                //pastePhotoToExcel(@"P9.jpg");
            }

        }


        public void pasteImageInCell(Image img,int cellRow, int cellColumn)
        {
            float width  = (3f / 4f) * (float)img.Width;
            float height = (3f / 4f) * (float)img.Height;
            Microsoft.Office.Interop.Excel.Range oRange = (Microsoft.Office.Interop.Excel.Range)ExcelReport.xlWorkSheet.Cells[cellRow, cellColumn];
            float left = (float)((double)oRange.Left);
            float top = (float)((double)oRange.Top);
            String imageLocation = createImageLocation(img);
            ExcelReport.xlWorkSheet.Shapes.AddPicture(imageLocation, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, left, top, width, height);
        }
        private String getPathLocation()
        {
            String path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            path = path.Substring(6);
            return path;
        }      
        public String createImageLocation(Image img)
        {
            String path = getPathLocation();
            path += @"\R2 Gate - Images\images.jpg";
            img.Save(path);
            return path;
        }
   
    }
}
