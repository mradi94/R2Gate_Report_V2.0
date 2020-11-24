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
    public partial class GuideForm : Form
    {

        private Image optionsButtonUp;
        private Image optionsButtonDown;
        private Boolean isDownButton;
        private GuideForm2 gf2;
        private GuideForm3 gf3;
        private SaveFileDialog saveFile;
        private SmallRectangleDialog smallRectangleDialog;
        public GuideForm()
        {
            
            InitializeComponent();
            saveFile = new SaveFileDialog();
            gf2 = new GuideForm2();
            gf3 = new GuideForm3();
            smallRectangleDialog = new SmallRectangleDialog();
            isDownButton = true;
            optionsButtonDown = Image.FromFile(@"In App - Images\DOWN.jpg");
            optionsButtonUp   = Image.FromFile(@"In App - Images\UP.jpg");
            
            PacientData.setMaximImages(2);
            this.updateAllFields();
        }
        




        private void toothNotation_Click(object sender, EventArgs e)
        {

        }
        public void setVisibilityToothEntities(Boolean isVisible)
        {
            if (isVisible)
            {
                this.toothNotationLabel.Visible = true;
                this.toothNotationBox.Visible = true;
                this.implantSystemLabel.Visible = true;
                this.implantSystemBox.Visible = true;
             
            }
            else
            {
                this.toothNotationLabel.Visible = false;
                this.toothNotationBox.Visible = false;
                this.implantSystemLabel.Visible = false;
                this.implantSystemBox.Visible = false;
               
            }
        }

        public void addImage(Image img){
            PacientData.addImage(img);
            this.updateAllFields();
        }

        private void updateAllFields()
        {
            updateMaximImages();
            updateCurrentTooth();

            updateTitle();
            updateSaveButton();
            updatePinButton();
            updateToothAndImplantVisibility();
            updateToothDetails();
            updateEntityGuide();
            updateUndoButton();
            updateShowHideOptions();
        }
        private void updateShowHideOptions()
        {
            if (PacientData.getIndexImage() == 0 || PacientData.getIndexImage() == 1)
            {
                showHideSettings.Visible = false;
            }
            else
            {
                showHideSettings.Visible = true;
            }
        }
        private void updateEntityGuide()
        {
            if (PacientData.getIndexImage() == 0 || PacientData.getIndexImage() == 1 || PacientData.hasPins)
            {
                entityGuide.Text = "";
            }
            else if (PacientData.getGroupComponentIndex() == 1)
            {
                entityGuide.Text = "3D view";
            }
            else if (PacientData.getGroupComponentIndex() == 2)
            {
                entityGuide.Text = "Transsection view";
            }
            else if (PacientData.getGroupComponentIndex() == 3)
            {
                entityGuide.Text = "Digital eye";
            }
            
        }
        private void updateUndoButton()
        {
            if (PacientData.hasPins && PacientData.getPinNumber() == 1)
            {
                this.undo.Enabled = false;
                this.save.Visible = false;
            }
            else
            {
                this.undo.Enabled = true;
            }
        }
        private void updateMaximImages()
        {
            if (PacientData.hasPins)
            {
                PacientData.setMaximImages(1);
                return;
            }
            if (PacientData.getGroupIndex() == 0)
            {
                PacientData.setMaximImages(2);
                return;
            }
            PacientData.setMaximImages(3);
            

        }
        private void updateCurrentTooth()
        {
            PacientData.currentTooth = PacientData.toothDetails[PacientData.getGroupIndex()];
        }
        private void updateTitle()
        {
            if (PacientData.getIndexImage() == 0)
            {
                indexEntityOrTooth.Text = "Over view 1";
                return;
            }
            if (PacientData.getIndexImage() == 1)
            {
                indexEntityOrTooth.Text = "Over view 2";
                return;
            }
            if (!PacientData.hasPins)
            {
                indexEntityOrTooth.Text = "Implant #" + PacientData.getGroupIndex();
                return;
            }
            int diference = 1 + 3 * PacientData.getToothEntitiesNumber();
            indexEntityOrTooth.Text = "Anchor " + PacientData.getPinNumber();


        }
        private void updateSaveButton()
        {
            if (PacientData.hasPins && PacientData.getPinNumber() !=0 )
            {
                this.save.Visible = true;
                return;
            }
            if (PacientData.getIndexImage() < 4)
            {
                this.save.Visible = false;
                return;
            }
            if (PacientData.getGroupComponentIndex() != 1)
            {
                this.save.Visible = false;
                return;
            }
            this.save.Visible = true;
        }
        private void updatePinButton()
        {
            if (PacientData.hasPins || PacientData.getIndexImage() < 4 || PacientData.getGroupComponentIndex() != 1)
            {
                this.pin.Visible = false;
                return;
            }
           
            
            this.pin.Visible = true;
        }
        private void updateToothAndImplantVisibility()
        {
            if (PacientData.getIndexImage() == 0 || PacientData.getIndexImage() == 1 || PacientData.hasPins)
            {
                this.setVisibilityToothEntities(false);
                return;
            }
            this.setVisibilityToothEntities(true);
        }
        private void updateToothDetails()
        {
            toothNotationBox.Text = PacientData.currentTooth.toothNotation;
            implantSystemBox.Text = PacientData.currentTooth.implantSystem;
            gf2.updateAllFields();
            gf3.updateAllFields();
        }





        private void undo_Click(object sender, EventArgs e)
        {
            PacientData.removeImage();
            DrawRectangle.graphics.Clear(Color.White);
            updateAllFields();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            gf2.WindowState = FormWindowState.Minimized;
            gf3.WindowState = FormWindowState.Minimized;
        
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void guideTimer_Tick(object sender, EventArgs e)
        {
            
        }
        private void updatePacientDataDetails()
        {
            for (int i = 0; i < PacientData.toothDetails.Count(); i++)
            {
                if (PacientData.toothDetails[i].hasMUA0)
                {
                    PacientData.hasMUA00 = true;
                }
                if (PacientData.toothDetails[i].hasMUA17)
                {
                    PacientData.hasMUA17 = true;
                }
                if (PacientData.toothDetails[i].hasMUA29)
                {
                    PacientData.hasMUA26 = true;
                }
                if (PacientData.toothDetails[i].hasBoneProfiler)
                {
                    PacientData.hasBoneProfiler = true;
                }
                if (PacientData.toothDetails[i].hasNarrowCrestDrill)
                {
                    PacientData.hasNarrowCrestDrill = true;
                }
                if (PacientData.toothDetails[i].hasAnchorStent)
                {
                    PacientData.hasAnchorStent = true;
                }
            }
        }








        private String getFileNameFromDialog()
        {
            String finalLocation="";
            using (StreamReader lastLocation = new StreamReader(@"Excel\lastLocation.ini"))
            {
                saveFile.InitialDirectory = lastLocation.ReadToEnd();
            }
            saveFile.Title = "R2GATE EXCEL Destination...";
            saveFile.Filter = "Xlsx file|*xlsx";
            if (PacientData.patient.Trim() != "")
            {
                saveFile.FileName = "R2GATE Report " + PacientData.patient;
            }
            else
            {
                saveFile.FileName = "R2GATE Report";
            }
            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                finalLocation = saveFile.FileName;
            }
            else
                return "InvalidExcelName";
            using (StreamWriter lastLocation = new StreamWriter(@"Excel\lastLocation.ini"))
            {
                string aux = finalLocation;

                string fileName = Path.GetFileName(aux);
                int numberLettersFile = fileName.Length + 1;
                int numberLettersFinalLocation = aux.Length - numberLettersFile;
                aux = aux.Substring(0, numberLettersFinalLocation);


                lastLocation.Write(aux);
                lastLocation.Close();
            }


            return finalLocation;
        }


        private void save_Click(object sender, EventArgs e)
        {
            if (PacientData.hasPins)
            {
                PacientData.anchor = "Yes";
            }
            else
            {
                PacientData.anchor = "No";
            }
            updatePacientDataDetails();
            DrawRectangle.graphics.Clear(Color.White);
            this.WindowState = FormWindowState.Minimized;
            gf2.WindowState = FormWindowState.Minimized;
            gf3.WindowState = FormWindowState.Minimized;
           
            String finalLocation = this.getFileNameFromDialog();
            if (finalLocation == "InvalidExcelName")
            {
                return;
            }
            PasteAllToExcel pasteToExcel = new PasteAllToExcel();
            ExcelReport.saveExcelFile(finalLocation);
            ExcelReport.savePdfFile(finalLocation);
            ExcelReport.openPdfFile(finalLocation);
            Application.Exit();

        }

        private void pin_Click(object sender, EventArgs e)
        {
            gf2.Hide();
            showHideSettings.BackgroundImage = optionsButtonDown;
            isDownButton = true;
            DrawRectangle.graphics.Clear(Color.White);
         
            AllPatientImages.setGroupMaximImages(15);
            PacientData.hasPins = true;
            PacientData.toothEntitiesNumber = PacientData.getGroupIndex()-1;
            this.updateAllFields();
        
        }

      

        private void indexEntityOrTooth_Click(object sender, EventArgs e)
        {

        }

        private void GuideForm_Load(object sender, EventArgs e)
        {

        }


        #region Mouse Move Form ()
        private int togMove;
        private int mouseValX;
        private int mouseValY;
        private void GuideForm_MouseUp(object sender, MouseEventArgs e)
        {
            togMove = 0;
        }
        private void GuideForm_MouseDown(object sender, MouseEventArgs e)
        {
            togMove = 1;
            mouseValX = e.X;
            mouseValY = e.Y;
        }
        private void GuideForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (togMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mouseValX, MousePosition.Y - mouseValY);
                gf2.SetDesktopLocation(MousePosition.X - mouseValX , MousePosition.Y - mouseValY +200);
                gf3.SetDesktopLocation(MousePosition.X - mouseValX , MousePosition.Y - mouseValY +200);

            }
        }
        #endregion 

        private void showHideSettings_Click(object sender, EventArgs e)
        {
            
            

            if (isDownButton)
            {
                isDownButton = false;
                showHideSettings.BackgroundImage = optionsButtonUp;
                if (PacientData.hasPins)
                {
                    gf3.Show();
                    gf3.SetDesktopLocation(this.Location.X, this.Location.Y + 200);
                }
                else
                {
                    gf2.Show();
                    gf2.SetDesktopLocation(this.Location.X, this.Location.Y + 200);
                    
                }
            }
            else
            {
                isDownButton = true;
                showHideSettings.BackgroundImage = optionsButtonDown;
                if (PacientData.hasPins)
                {
                    gf3.Hide();
                }
                else
                {
                    gf2.Hide();
                }
            }

        }
        
        private void toothNotationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PacientData.currentTooth.toothNotation = toothNotationBox.Text;

        }
        private void implantSystemBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PacientData.currentTooth.implantSystem = implantSystemBox.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }


     

    }
}
