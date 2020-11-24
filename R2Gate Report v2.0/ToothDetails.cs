using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R2Gate_Report_v2._0
{
    class ToothDetails
    {
        public String toothNotation;
        public String implantSystem;
        public String sizeDL1;
        public String sizeDL2;
        public String boneDensity;
        public String gbr;
        
        public Boolean hasBoneProfiler;
        public Boolean hasNarrowCrestDrill;
        public Boolean hasAnchorStent;
        public Boolean hasMUA;
        public Boolean hasMUA0;
        public Boolean hasMUA17;
        public Boolean hasMUA29;
        public String dimensionMM;

        public String pinToothNumber;
        public String pinSizeDL;
        public ToothDetails()
        {
            toothNotation = "None";
            implantSystem = "Undecided";
            sizeDL1 = "-";
            sizeDL2 = "-";
            boneDensity = "None";
            gbr ="";
           
            hasBoneProfiler = false;
            hasNarrowCrestDrill = false;
            hasAnchorStent = false;
            hasMUA = false;
            hasMUA0 = false;
            hasMUA17 = false;
            hasMUA29 = false;
            dimensionMM = "0";
           
            pinToothNumber = "";
            pinSizeDL = "-";
        }
    }
}
