using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R2Gate_Report_v2._0
{
    class PinSelectionExcel :  ToothSelectionExcel
    {

        public PinSelectionExcel() :base()
        {
            
        }
        public override void initialToothTable()
        {
            this.addRowTooth("noName", 15);
            this.addRowTooth("noName", 15);
            this.addRowTooth("noName", 15);
            this.addRowTooth("noName", 15);
            this.addRowTooth("noName", 15);
            this.addRowTooth("noName", 15);
            this.addRowTooth("noName", 15);
            this.addRowTooth("noName", 15);
            this.addRowTooth("noName", 15);
            this.addRowTooth("noName", 15);
            this.addRowTooth("noName", 15);
            ExcelReport.pasteAnchorPin(this.startIndex, this.startIndex + this.rowsNumber - 1);
        }

    }
}
