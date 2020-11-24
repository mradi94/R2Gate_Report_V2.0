using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Management;

namespace R2Gate_Report_v2._0
{
    public partial class AccesToApplicationForm : Form
    {
        public AccesToApplicationForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            this.Visible = false;
            pacientDataForm = new PacientDataForm();
            this.InitializeUniqueIDs();
        }
        private void InitializeUniqueIDs()
        {

            StreamReader codeReader = new StreamReader("R2Gate Report v2.0.ini");
            codeFromFile = codeReader.ReadLine();
            codeReader.Close();

            uniqueIDs.Add (codeFromFile);
           
        }
        private String codeFromFile ="";
        private String yourProcessorID = "";
        private HashSet<String> uniqueIDs = new HashSet<string>();
        private static PacientDataForm pacientDataForm;
        private static bool isNetworkAvailable()
        {
            return isNetworkAvailable(0);
        }
        private static bool isNetworkAvailable(long minimumSpeed)
        {
            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                return false;

            foreach (System.Net.NetworkInformation.NetworkInterface ni in System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces())
            {
                // discard because of standard reasons
                if ((ni.OperationalStatus != System.Net.NetworkInformation.OperationalStatus.Up) ||
                    (ni.NetworkInterfaceType == System.Net.NetworkInformation.NetworkInterfaceType.Loopback) ||
                    (ni.NetworkInterfaceType == System.Net.NetworkInformation.NetworkInterfaceType.Tunnel))
                    continue;

                // this allow to filter modems, serial, etc.
                // I use 10000000 as a minimum speed for most cases
                if (ni.Speed < minimumSpeed)
                    continue;

                // discard virtual cards (virtual box, virtual pc, etc.)
                if ((ni.Description.IndexOf("virtual", StringComparison.OrdinalIgnoreCase) >= 0) ||
                    (ni.Name.IndexOf("virtual", StringComparison.OrdinalIgnoreCase) >= 0))
                    continue;

                // discard "Microsoft Loopback Adapter", it will not show as NetworkInterfaceType.Loopback but as Ethernet Card.
                if (ni.Description.Equals("Microsoft Loopback Adapter", StringComparison.OrdinalIgnoreCase))
                    continue;

                return true;
            }
            return false;
        }
 
       private String getProcessorID()
        {
            ManagementObjectCollection mbsList = null;
            ManagementObjectSearcher mbs = new ManagementObjectSearcher("Select * From Win32_processor");
            mbsList = mbs.Get();
            string id = "";
            foreach (ManagementObject mo in mbsList)
            {
                id = mo["ProcessorID"].ToString();
            }
            return id;
        }
        private Boolean checkYourComputerLicence()
        {
            String processorId = getProcessorID();
            if (processorId.Equals("BFEBFBFF000906EA") &&
                             (Environment.UserName.Equals("ADRIAN") || Environment.UserName.Equals("PuntoLab"))
               )
            {
                return true;
            }

            return false;
        }
       
        private static DateTime getNetworkTime()
        {
            //default Windows time server
            const string ntpServer = "time.windows.com";

            // NTP message size - 16 bytes of the digest (RFC 2030)
            var ntpData = new byte[48];

            //Setting the Leap Indicator, Version Number and Mode values
            ntpData[0] = 0x1B; //LI = 0 (no warning), VN = 3 (IPv4 only), Mode = 3 (Client Mode)

            var addresses = Dns.GetHostEntry(ntpServer).AddressList;

            //The UDP port number assigned to NTP is 123
            var ipEndPoint = new IPEndPoint(addresses[0], 123);
            //NTP uses UDP

            using (var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp))
            {
                socket.Connect(ipEndPoint);

                //Stops code hang if NTP is blocked
                socket.ReceiveTimeout = 3000;

                socket.Send(ntpData);
                socket.Receive(ntpData);
                socket.Close();
            }

            //Offset to get to the "Transmit Timestamp" field (time at which the reply 
            //departed the server for the client, in 64-bit timestamp format."
            const byte serverReplyTime = 40;

            //Get the seconds part
            ulong intPart = BitConverter.ToUInt32(ntpData, serverReplyTime);

            //Get the seconds fraction
            ulong fractPart = BitConverter.ToUInt32(ntpData, serverReplyTime + 4);

            //Convert From big-endian to little-endian
            intPart = swapEndianness(intPart);
            fractPart = swapEndianness(fractPart);

            var milliseconds = (intPart * 1000) + ((fractPart * 1000) / 0x100000000L);

            //**UTC** time
            var networkDateTime = (new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)).AddMilliseconds((long)milliseconds);

            return networkDateTime.ToLocalTime();
        }
        private static uint swapEndianness(ulong x)
        {
            return (uint)(((x & 0x000000ff) << 24) +
                           ((x & 0x0000ff00) << 8) +
                           ((x & 0x00ff0000) >> 8) +
                           ((x & 0xff000000) >> 24));
        }
        
        private void AccesToApplicationForm_Load(object sender, EventArgs e)
        {

            //if (!isNetworkAvailable())
            //{
            //    MessageBox.Show("Check your internet connection");
            //    Application.Exit();
            //    return;
            //}

            //DateTime today = getNetworkTime();
            //DateTime beginLicence = new DateTime(2018, 9, 1);
            //DateTime endOfLicence = new DateTime(2019, 8, 7);

            //if (today < beginLicence || today > endOfLicence)
            //{
            //    MessageBox.Show("The license has expired!");
            //    Application.Exit();
            //    return;
            //}

            //if (!checkYourComputerLicence())
            //{
            //    MessageBox.Show("The license is not available on this PC!");
            //    Application.Exit();
            //    return;
            //}    
            
            pacientDataForm.Show();

        }
        
    }
}
