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
    public partial class GuideForm3 : Form
    {
        public GuideForm3()
        {
            InitializeComponent();
        }

        private void pinToothNumberBox_TextChanged(object sender, EventArgs e)
        {
            PacientData.currentTooth.pinToothNumber = pinToothNumberBox.Text;
        }

        private void pinSizeDLBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PacientData.currentTooth.pinSizeDL = pinSizeDLBox.Text;
        }
        public void updateAllFields()
        {
            pinToothNumberBox.Text = PacientData.currentTooth.pinToothNumber;
            pinSizeDLBox.Text = PacientData.currentTooth.pinSizeDL;
        }
    }
}
