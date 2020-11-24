using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R2Gate_Report_v2._0
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ExcelReport excel  =  new ExcelReport();
            //ToothSelectionExcel tooth1 = new ToothSelectionExcel();
            //ToothSelectionExcel tooth2 = new ToothSelectionExcel();
            //ToothSelectionExcel tooth3 = new ToothSelectionExcel();

           // ExcelReport.addToothSelection(tooth1);
            //ExcelReport.addToothSelection(tooth2);
            //ExcelReport.addToothSelection(tooth3);

//            ExcelReport.saveExcelFile(@"C:\Users\Adi\Desktop\Export");
         
        }
    }
}
