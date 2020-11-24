using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R2Gate_Report_v2._0
{
    public partial class PacientDataForm : Form
    {
        public PacientDataForm()
        {
            InitializeComponent();
            pacientData = new PacientData();
            allPatientImages = new AllPatientImages();
            guideForm = new GuideForm();
            drawRectangle = new DrawRectangle();
            
            
            excelReport = new ExcelReport();
        }

        private PacientData pacientData;
        private static AllPatientImages allPatientImages;
        public static GuideForm guideForm;
        private static DrawRectangle drawRectangle;
        private static ExcelReport excelReport;
        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void PacientDataForm_Load(object sender, EventArgs e)
        {
            writeComboBoxItemsFromTextFileLocation(operatorComboBox, @"Operators History\Operators.ini");
            writeComboBoxItemsFromTextFileLocation(designerComboBox, @"Operators History\Designers.ini");
        }
        #region Move-Formular
        private int TogMove;
        private int MValX;
        private int MValY;
        private void PacientDataForm_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void PacientDataForm_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void PacientDataForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }

        }
        #endregion

        private void okButton_Click(object sender, EventArgs e)
        {
            if(puttyComboBox.Text == "Yes")
            {
                PacientData.hasPutty = true;
            }
            if (kitOptionBox.Text == "Narrow")
            {
                PacientData.hasNarrow = true;
            }
            else if (kitOptionBox.Text == "Regular + Wide")
            {
                PacientData.hasRegularWide = true;
            }

            PacientData.orderNo     = this.orderNoTextBox.Text;
            PacientData.patient     = this.patientTextBox.Text;
            PacientData.clinic      = this.clinicTextBox.Text;
            PacientData.dentist     = this.dentistTextBox.Text;
            PacientData.opSite      = this.opSiteTextBox.Text;
            PacientData.opDate      = this.opDateTextBox.Text;
            PacientData.opOption    = this.opOptionComboBox.Text;
            PacientData.putty       = this.puttyComboBox.Text;
            PacientData.txOption    = this.txOptionComboBox.Text;   
            PacientData.anchor      = this.anchorComboBox.Text;
            PacientData.r2Stent1    = this.r2StentBox1.Text;
            PacientData.r2Stent2    = this.r2StentBox2.Text;
            PacientData.r2Stent3    = this.r2StentBox3.Text;
            PacientData.custom1     = this.customBox1.Text;
            PacientData.custom2     = this.customBox2.Text;
            PacientData.custom3     = this.customBox3.Text;
            PacientData.temp1       = this.tempBox1.Text;
            PacientData.temp2       = this.tempBox2.Text;
            PacientData.temp3       = this.tempBox3.Text;
            PacientData.salesRep    = this.salesRepTextBox.Text;
            PacientData.operatorPC  = this.operatorComboBox.Text ;
            PacientData.designerPC  = this.designerComboBox.Text;

            
            drawRectangle.Show(); 
            guideForm.Show();
            this.Close();
        }
        private void writeComboBoxItemsFromTextFileLocation(ComboBox comboBox, String textFileLocation)
        {
            String line = "";
            using (StreamReader operators = new StreamReader(textFileLocation))
            {
                while (line != null)
                {
                    line = operators.ReadLine();
                    if (line != null)
                    {
                        comboBox.Items.Add(line);
                    }
                }
                operators.Close();
            }
        }

        private void removeOperatorButton_Click(object sender, EventArgs e)
        {
            removePcOperator(operatorComboBox, @"Operators History\Operators.ini");
        }

        private void removeDesignerButton_Click(object sender, EventArgs e)
        {
            removePcOperator(designerComboBox, @"Operators History\Designers.ini");
        }

        private void addOperatorButton_Click(object sender, EventArgs e)
        {
            addPcOperator(operatorComboBox, @"Operators History\Operators.ini");
        }

      
        private void addDesignerButton_Click(object sender, EventArgs e)
        {
            addPcOperator(designerComboBox, @"Operators History\Designers.ini");
        }
        
        private void removePcOperator(ComboBox comboBox, String textFileLocation)
        {
            var lines = File.ReadAllLines(textFileLocation);
            File.WriteAllLines(textFileLocation, lines.Take(lines.Length - 1).ToArray());

            int noOfLines = operatorComboBox.Items.Count;
            if (noOfLines > 0)
            {
                comboBox.Items.RemoveAt(noOfLines - 1);
            }
        }
        private void addPcOperator(ComboBox comboBox, String operatorPcName)
        {
            if (comboBox.Text.Trim() == "")
            {
                return;
            }
            comboBox.Items.Add(comboBox.Text);
            using (StreamWriter operatori = new StreamWriter(operatorPcName, true))
            {

                operatori.WriteLine(comboBox.Text);
            }
            comboBox.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void orderNoLabel_Click(object sender, EventArgs e)
        {

        }


    }
}
