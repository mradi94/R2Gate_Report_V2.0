using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R2Gate_Report_v2._0
{
    class RowToothExcel
    {
        private String name;
        private double height;
        private int excelIndex;
        public RowToothExcel(String name,double height)
        {
            this.name = name;
            this.height = height;           
            this.excelIndex = ExcelReport.nextExcelRowIndex ;
            setHeightRow(excelIndex, height);
        }
        
        private static void setHeightRow(int rowIndex, double newRowHeight)
        {
            String cell = "B" + rowIndex;
            ExcelReport.xlWorkSheet.get_Range(cell).RowHeight = newRowHeight;
        }
        public int getRowExcelIndex()
        {
            return this.excelIndex;
        }
        public double getRowExcelHeight()
        {
            return this.height;
        }
        public String getRowExcelName()
        {
            return this.name;
        }

 
    }
}
