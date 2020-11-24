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
    public partial class GuideForm2 : Form
    {
        public GuideForm2()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void muaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PacientData.currentTooth.hasMUA = muaCheckBox.Checked;
            if (muaCheckBox.Checked)
            {
                dimensionMM.Enabled   = true;
                radioButton0.Enabled  = true;
                radioButton17.Enabled = true;
                radioButton29.Enabled = true;
                radioButton0.Checked = true;
            }
            else
            {
              
                dimensionMM.Enabled = false;
                radioButton0.Checked  = false;
                radioButton17.Checked = false;
                radioButton29.Checked = false;
                radioButton0.Enabled  = false;
                radioButton17.Enabled = false;
                radioButton29.Enabled = false;
            }
        }

        private void sizeDLBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PacientData.currentTooth.sizeDL1 = sizeDLBox1.Text;
        }

        private void sizeDLBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            PacientData.currentTooth.sizeDL2 = sizeDLBox2.Text;
        }

        private void BoneDensityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PacientData.currentTooth.boneDensity = BoneDensityBox.Text;
        }

        private void gbrBox_TextChanged(object sender, EventArgs e)
        {
            PacientData.currentTooth.gbr = gbrBox.Text;
        }

        private void boneProfilerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PacientData.currentTooth.hasBoneProfiler = boneProfilerCheckBox.Checked;
        }

        private void narrowCrestDrillmuaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PacientData.currentTooth.hasNarrowCrestDrill = narrowCrestDrillmuaCheckBox.Checked;
        }

        private void anchorStentmuaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PacientData.currentTooth.hasAnchorStent = anchorStentmuaCheckBox.Checked;
        }

        private void radioButton0_CheckedChanged(object sender, EventArgs e)
        {
            PacientData.currentTooth.hasMUA0 = radioButton0.Checked;
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            PacientData.currentTooth.hasMUA17 = radioButton17.Checked;
        }

        private void radioButton29_CheckedChanged(object sender, EventArgs e)
        {
            PacientData.currentTooth.hasMUA29 = radioButton29.Checked;
        }

        private void dimensionMM_TextChanged(object sender, EventArgs e)
        {
            PacientData.currentTooth.dimensionMM = dimensionMM.Text;
        }

        private void GuideForm2_Load(object sender, EventArgs e)
        {

        }
        public void updateAllFields()
        {
            sizeDLBox1.Text = PacientData.currentTooth.sizeDL1;
            sizeDLBox2.Text = PacientData.currentTooth.sizeDL2;
            BoneDensityBox.Text = PacientData.currentTooth.boneDensity;
            gbrBox.Text = PacientData.currentTooth.gbr;
            boneProfilerCheckBox.Checked = PacientData.currentTooth.hasBoneProfiler;
            narrowCrestDrillmuaCheckBox.Checked = PacientData.currentTooth.hasNarrowCrestDrill;
            anchorStentmuaCheckBox.Checked = PacientData.currentTooth.hasAnchorStent;
            muaCheckBox.Checked = PacientData.currentTooth.hasMUA;
            radioButton0.Checked = PacientData.currentTooth.hasMUA0;
            radioButton17.Checked = PacientData.currentTooth.hasMUA17;
            radioButton29.Checked = PacientData.currentTooth.hasMUA29;
            dimensionMM.Text = PacientData.currentTooth.dimensionMM;
        }

    }
}
