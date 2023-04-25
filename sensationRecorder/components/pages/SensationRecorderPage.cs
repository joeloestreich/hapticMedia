using Google.Apis.YouTube.v3.Data;
using OWOGame;
using hapticMedia.genericComponents.pageDefinition;
using hapticMedia.videoViewer.components.pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hapticMedia.videoViewer.data;
using SharpPcap;
using SharpPcap.LibPcap;
using System.Threading;
using PacketDotNet;
using ConnectionState = OWOGame.ConnectionState;
using Google.Apis.Util;
using hapticMedia.sensationRecorder.data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using hapticMedia.applicationFrame.Service;
using Newtonsoft.Json;

namespace hapticMedia.sensationRecorder.components.pages {
    public partial class SensationRecorderPage : UserControlPage {
        public SensationRecorderPage() {
            InitializeComponent();
        }

        public static string FolderName = "capture";

        List<CaptureData> CaptureContent;

        LibPcapLiveDevice NetworkDevice = null;
        bool DoCapture = false;
        long CaptureStart;



        public override void Init() {
            base.Init();

            // TODO: Check Stuff
            // - Library is functional (npcap installed / potentially admin privilages)
            // LibPcapLiveDeviceList dList = LibPcapLiveDeviceList.Instance
            // - Connected to OWO
            // ConnectionState cs = OWO.ConnectionState;

            LibPcapLiveDeviceList dList = LibPcapLiveDeviceList.Instance;
            foreach (LibPcapLiveDevice device in dList) {
                // Is Loopback check always correct? Other means to identify?
                if (device.Loopback) {
                    if (NetworkDevice == null) {
                        NetworkDevice = device;
                    } else {
                        // Multiple Loopbacks possible?
                    }
                }
            }
        }

        private void btnStartCapture_Click(object sender, EventArgs e) {
            if (DoCapture) {
                return;
            }
            CaptureContent = new List<CaptureData>();
            DoCapture = true;
            bgwCapture.RunWorkerAsync();
        }

        private void btnStopCapture_Click(object sender, EventArgs e) {
            DoCapture = false;

            if (CaptureContent.Count != 0) {
                // Save
                string captureString = JsonConvert.SerializeObject(CaptureContent);

                DateTime dateTime = new DateTime(1970, 1, 1).AddMilliseconds(CaptureStart);
                string fileName = "SensationCapture_" + dateTime;
                fileName = fileName.Replace(" ", "-");
                fileName = fileName.Replace(".", "-");
                fileName = fileName.Replace(":", "-");
                fileName += ".txt";

                HapticMediaFileService.SaveFile(captureString, FolderName, fileName);
            }

        }

        private void bgwCapture_DoWork(object sender, DoWorkEventArgs e) {
            using (NetworkDevice) {
                CaptureStart = DateTimeOffset.Now.ToUnixTimeMilliseconds();
                NetworkDevice.Open();
                // Berkeley Packet Filter
                NetworkDevice.Filter = "udp";
                NetworkDevice.OnPacketArrival += Device_OnPacketArrival;
                NetworkDevice.StartCapture();
                while (DoCapture) {
                    Thread.Sleep(50);
                }
            }
        }

        private void Device_OnPacketArrival(object sender, PacketCapture e) {
            var packet = Packet.ParsePacket(e.GetPacket().LinkLayerType, e.GetPacket().Data);
            packet.GetType();
            UdpPacket udp = packet.Extract<UdpPacket>();
            if (udp?.ParentPacket is IPv4Packet && udp?.PayloadData?.Length != null) {
                string enc = Encoding.UTF8.GetString(udp.PayloadData, 0, udp.PayloadData.Length);
                Console.WriteLine("CAPTURE => " + enc);
                if ("192.168.178.26".Equals(((IPv4Packet)udp.ParentPacket).DestinationAddress.ToString())) {
                    long timestamp = Convert.ToInt64((e.Header.Timeval.Seconds * 1000) + (e.Header.Timeval.MicroSeconds / 1000)) - CaptureStart;
                    CaptureData cap = new CaptureData(timestamp, enc);
                    this.bgwCapture.ReportProgress(0, cap);
                }
            }
        }

        private void bgwCapture_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            CaptureData cap = (CaptureData) e.UserState;
            Label lbl = new Label();
            lbl.Text = cap.TimeStamp + " - " + cap.Capture;
            lbl.Width = 1000;
            flowLayoutPanel1.Controls.Add(lbl);

            CaptureContent.Add(cap);
        }



        private void button1_Click(object sender, EventArgs e) {
            // newOWO/1/100,5,90,200,300,0|0%100&100,5,90,200,300,0|0%100/eof
            // Sensation parse1 = (Sensation)"100,5,90,200,300,0|0%100&100,5,90,200,300,0|0%100"; (Fail: Add "," before "|")
            Sensation parse1 = (Sensation)"100,5,90,200,300,0,|0%100&100,5,90,200,300,0,|0%100";

            // 8000*SENSATION*100,1,100,0,0,0,|0%50
            Sensation parse2 = (Sensation)"100,1,100,0,0,0,|0%50";


            MicroSensation ball = SensationsFactory.Create(100, 0.1f, 100, 0, 0, 0);
            Sensation softBall = ball.WithMuscles(Muscle.Pectoral_R.WithIntensity(50));

            OWO.Send(softBall);
        }
    }
}
