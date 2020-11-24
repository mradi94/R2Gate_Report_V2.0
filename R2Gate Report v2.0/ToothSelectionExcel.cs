using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R2Gate_Report_v2._0
{
    class ToothSelectionExcel
    {
        private List<RowToothExcel> rows;
        protected int rowsNumber;
        protected int startIndex;
        protected int endIndex;
        private double totalHeight;
        //Getter:
        public int getRowsNumber()
        {
            return rowsNumber;
        }
        public double getTotalHeight()
        {
            return totalHeight;
        }
        //Constructor:
        public ToothSelectionExcel()
        {
            this.totalHeight = 0;
            this.startIndex = ExcelReport.nextExcelRowIndex;
            this.endIndex = this.startIndex; 

            this.rowsNumber = 0 ;
            this.rows = new List<RowToothExcel>();
            // Initial values:
            this.initialToothTable();

        }
        public int getStartIndex()
        {
            return startIndex;
        }
        public int getEndIndex()
        {
            return endIndex;
        }

        public virtual void initialToothTable()
        {
            
                this.addRowTooth("TitleLabel", 15);
                this.addRowTooth("ToothNumber", 26.25);
                this.addRowTooth("ImplantSystemLabel", 15);
                this.addRowTooth("ImplantSystemType1", 15);
                this.addRowTooth("ImplantSystemType2", 15);
                this.addRowTooth("SIZE(DXL)", 15);
                this.addRowTooth("WTD/BEVEL", 15);
                this.addRowTooth("Core/APD", 15);
                this.addRowTooth("BoneDensity", 15);
                this.addRowTooth("GBR", 15);
                ExcelReport.pasteInitialExcelTable(startIndex, startIndex + rowsNumber - 1);     
        }
        
        public void addRowTooth(String name, double height)
        {
            this.rows.Add(new RowToothExcel(name, height));
            ExcelReport.pasteSpecialRow(name, startIndex + rowsNumber);
            endIndex = ++ExcelReport.nextExcelRowIndex;
            ++rowsNumber;
            totalHeight += height;
        }
        public void addRowTooth(String name, double height,int indexTooth)
        {
            this.rows.Add(new RowToothExcel(name, height));
            ExcelReport.pasteSpecialRow(name, startIndex + rowsNumber, indexTooth);
            ExcelReport.nextExcelRowIndex++;
            ++rowsNumber;
            totalHeight += height;
        }


    }
}
