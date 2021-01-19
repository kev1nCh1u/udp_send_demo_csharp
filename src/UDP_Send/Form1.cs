using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace UDP_Send
{
    public partial class Form1 : Form
    {
        public char[] data = new char[100];
        public Form1()
        {
            InitializeComponent();
        }



        private void Btn_Send(object sender, EventArgs e)
        {

            InitializeComponent();
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.50.192"),9930); //可自行定義廣播區域跟Port (外面)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.50.211"),9930); //可自行定義廣播區域跟Port (外面)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.50.148"),9930); //可自行定義廣播區域跟Port (外面)

            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.197"), 9930); //可自行定義廣播區域跟Port (IVAM)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.149"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.50.192"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.0.255"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.122"), 9930); //可自行定義廣播區域跟Port (明榮網醫療)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.122"), 9930); //可自行定義廣播區域跟Port(TEST 網路 醫療)
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.72.152"), 9930); //可自行定義廣播區域跟Port(TEST 網路 醫療)

            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("172.20.10.4"), 9930); //可自行定義廣播區域跟Port (我手機)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域
            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小
            char[] sendtest = new char[1024];


            //String AAA = "M;0,0,2455,2050,3,diff,2;1,1,2489,2050,3,diff,1;3,3,2493,2006,930,diff,0,1000;E";
            //String AAA = "Mp;0,0,2087,2053,3,diff,2,1.0;1,1,2316,2046,3,diff,1,0.1;3,3,2329,1997,930,diff,0,0.1,2;E";
            //String AAA = "Mr;0,0,22.15,5,0.00523599,diff,2;1,1,22.15,6,0.00523599,diff,1;3,3,23.75,6,1.62316,diff,0,1000;E";


            //String AAA = "Mp;3,0,2042,2048,-1.7,omni,0;0,3,2096,2048,-1.7,omni,0,2;E";

            //pushdata = Encoding.UTF8.GetBytes("sendMessage"); //把要送出的資料轉成byte型態
            //pushdata = Encoding.UTF8.GetBytes(QQQ); //把要送出的資料轉成byte型態
            //Server.SendTo(pushdata, remoteIP); //送出的資料跟目的

            //String AAA = "Mp;0,0,2309,2060,-7,diff,0,0.0;1,2,2405,2062,13,diff,2,0.5;2,1,2442,2062,4,diff,0,0.0;3,1,2448,2005,877,diff,0,0.0;4,3,2450,1952,905,diff,0,0.0,2;E";

            //測試直走(原本)
            //String AAA = "Mp;1,0,2330,2200,900,diff,0,0.5;2,2,2325,1950,900,diff,0,0.5;E";
            //String AAA = "Mr;1,0,0.277,1.230,0.0277,diff,0,0.5;2,3,3.861,1.272,-0.029,diff,0,0.5,5;E";//單剁倫直線
            //String AAA = "Mr;1,0,-0.08,0.098,0.068,diff,0,0.5,ivam_1F;2,14,4.032,0.632,0.116,diff,0,0.5,ivam_1F,5;E";//t字直線
            //String AAA = "Mr;1,0,-1.3304,-2.901,1.630,diff,1,0.5;2,1,-1.203,-0.489,1.603,diff,0,0.5;3,3,1.979,-0.186,0.0155,diff,0,0.5,5;E";//t字直線
            //String AAA = "Mr;1,0,-1.3304,-2.901,1.630,diff,1,0.5;2,1,-1.203,-0.489,1.603,diff,0,0.5;3,3,1.979,-0.186,0.0155,diff,0,0.5,5;E";//t字直線
            //String AAA = "Mr;1,0,-1.3304,-2.901,1.630,diff,1,0.5;2,1,-1.203,-0.489,1.603,diff,0,0.5;3,3,1.979,-0.186,0.0155,diff,0,0.5,5;E";//t字直線
            //cartographer
            //String AAA = "Mr;1,0,2.804,0.7612,0.014,diff,0,0.5,factory0;2,3,5.804,0.89074,0.072,diff,0,0.5,factory0,1;E";//單剁倫直線
            //String AAA = "Mr;1,0,5.804,0.89074,0.072,diff,0,0.5,factory0;2,3,2.804,0.7612,0.014,diff,0,0.5,factory0,1;E";//單剁倫直線後退
            //String AAA = "Mr;1,0,2.98,0.726,0.057,diff,1,0.5,factory0;2,1,4.627,0.778,-0.009,diff,0,0.5,factory0;3,3,5.316,-1.258,-1.50,diff,0,0.5,factory0,5;E";//轉彎
            //String AAA = "Mr;1,0,5.316,-1.258,-1.50,diff,1,0.5,factory0;2,1,4.627,0.778,-0.009,diff,0,0.5,factory0;3,3,2.98,0.726,0.057,diff,0,0.5,factory0,5;E";//後退轉彎
            //String AAA = "Mr;1,0,-0.144826,0.012,-0.0108151,diff,0,0.5,mymap2;2,1,5.1901,-0.445292,0.0048,diff,0,0.5,mymap2;3,1,24.7907,0.414613,0.03211,diff,0,0.5,mymap2;4,1,46.6649,0.332849,0.00203,diff,0,0.5,mymap2;5,1,68.9414,0.420427,0.01629,diff,0,0.5,mymap2;6,1,87.5388,-0.2149,-0.006,diff,0,0.5,mymap2;7,3,98.1313,-1.58196,-0.0659235,diff,0,0.5,mymap2,2;E";//單剁倫長直線
            //String AAA = "Mr;1,0,-3.22124,-0.5206,-0.0022,diff,0,0.5,mymap;2,1,13.1975,-0.493916,-0.0156271,diff,1,0.5,mymap;3,1,17.3851,-0.293355,0.596017,diff,0,0.5,mymap;4,1,17.6825,2.87445,1.60423,diff,1,0.5,mymap;5,1,17.9051,5.4552,1.03343,diff,0,0.5,mymap;6,3,21.4285,5.72716,0.0316,diff,0,0.5,mymap,2;E";//單剁倫地下室
            //bolin mi
            //String AAA = "Mr;1,0,-5.86,-0.60,1.62,omni,0,0.5;2,14,5.76,0.76,1.43,omni,0,0.5;E";//單剁倫直線y+
            //String AAA = "Mr;1,0,5.65,1.98,-1.51,omni,0,0.5;2,14,5.77,0.83,-1.68,omni,0,0.5;E";//單剁倫直線y-
            //String AAA = "Mr;1,0,5.7,7.13,1.598,omni,0,0.5;2,14,5.58,3.62,1.66,omni,0,0.5,3;E";//單剁倫直線x+
            //String AAA = "Mr;1,0,6.86,0.89,-3.0,omni,0,0.5;2,14,5.82,0.76,3-2.94,omni,0,0.5,3;E";//單剁倫直線x-
            int count = 0;
            
            //String AAA = "Mr;1,0,2.89,-5.32,-1.47186,diff,0,0.5,ivam_1F;2,3,2.13,-1.84,-1.52,diff,0,0.5,ivam_1F,2;E";//測試omni_2
            //String AAA = "Mr;1,0,3.02,-3.92,-1.46,diff,0,0.5,ivam_1F;2,15,2.745,-1.956,-1.199,diff,0,0.5,ivam_1F,1;3,3,-1.59,0.491165,-0.1042,diff,0,0.5,ivam_1F,1;4,3,-0.59,0.491165,-0.1042,diff,0,0.5,ivam_1F,2;E";//測試omni_2
            //String AAA = "Mr;1,0,2.57,-3.18,-1.52,diff,0,0.5,ivam_1F;2,3,2.89,-5.32,-1.47186,diff,0,0.5,ivam_1F,2;E";//測試omni_2

            //String AAA = "Mr;1,0,1.68822,0.432922,1.71258,diff,0,0.5,ivam_3F;2,3,2.46556,-4.44588,1.66535,diff,0,0.5,ivam_3F,2;E";
            //String AAA = "Mp;0,0,2495,2051,900,diff,1,1.0;1,1,2550,2051,900,diff,0,0.5;2,2,2550,2114,888,diff,0,0.5;E";
            //測試轉彎
            //String AAA = "Mp;0,0,2257,2050,900,diff,1,1.0;1,1,2323,2048,900,diff,0,0.5;2,2,2325,1950,900,diff,0,0.5;E";

            //String AAA = "Mp;6,0,2400,1918,0,diff,1,0.5;5,1,2329,1927,0,diff,1,0.5;4,2,2327,2010,2700,diff,1,0.5;3,1,2312,2047,0,diff,1,0.5;8,2,2324,2126,2700,diff,0,0.5;E";


            //測試直走B1
            //String AAA = "Mp;1,0,2550,2114,888,diff,0,0.5;2,2,2550,1984,888,diff,0,0.5;E";
            //String AAA = "Mp;1,0,2285,2050,20,diff,0,0.5;2,2,2445,2046,20,diff,0,0.5;E";
            //測試轉彎B1
            //String AAA = "Mp;0,0,2495,2051,900,diff,1,1.0;1,1,2550,2051,900,diff,0,0.5;2,2,2550,2114,888,diff,0,0.5;E";
            //String AAA = "Mr;5,0,-0.298546,-0.1203033,0.0828308,diff,1,0.5; 4,1,1.48059,-0.1298325,3.10016,diff,1,0.5; 6,1,1.35283,1.78837,1.59481,diff,0,0.5; 7,1,1.37777,2.7171,-1.57,diff,0,0.5; 8,1,1.40759,5.51805,1.57,diff,0,0.5; 9,2,1.35604,6.28347,1.57637,diff,0,0.5; 10,7,1.37017,7.90223,-1.57,omni,0,0.5; 11,1,2.59215,7.93435,-1.57,omni,0,0.5; 12,7,3.7,7.98438,-1.57,diff,0,0.5; 1,2,3.85,4,-1.54431,diff,0,0.5;E";

            //測試直走中華汽車實驗場域
            //String AAA = "Mr;1,0,11.1650,-0.3382,-0.033,diff,1,0.5;2,1,17.52,0.087,0.92,diff,0,0.5;3,3,17.78,2.772,1.57,diff,0,0.5,5;E";
            //測試轉彎
            //String AAA = "Mp;0,0,2082,2204,887,diff,1,1.0;1,1,2086,2078,900,diff,0,0.5;2,3,2036,2052,-1796,diff,0,0.5,1;E";
            //測試極限避障
            //String AAA = "Mr;1,0,3.85,4,-1.54431,diff,1,0.5;2,1,4.01345,-0.1,-1.56415,diff,1,0.5;3,1,3.03585,-0.09511719,3.11463,diff,1,0.5;4,1,1.48059,-0.0298325,3.10016,diff,1,0.5;6,1,1.35283,1.78837,1.59481,diff,0,0.5;7,9,1.37777,2.7171,-1.57,diff,0,0.5,5;E";


            //隊的
            //String AAA = "Mr;22,0,-4.80035,2.7421,1.55253,omni,0,0.5;21,1,-4.71364,5.73025,1.53359,omni,0,0.5;14,7,-4.65228,7.68863,1.53725,diff,0,0.5;20,2,-3.33048,7.74044,1.51842,diff,0,0.5;19,1,-1.89249,7.79111,1.51545,diff,0,0.5;13,2,-0.05,7.86924,0.049065,diff,1,0.5;10,1,1.37017,7.95223,-1.57,diff,1,0.5;9,1,1.35604,6.28347,1.57637,diff,0,0.5;8,1,1.40759,5.51805,1.57,diff,0,0.5;7,9,1.37777,2.7171,-1.57,diff,0,0.5,5;E";
            //錯誤
            //String AAA =  "Mr;22,0,-4.80035,2.7421,1.55253,omni,0,0.5;21,1,-4.71364,5.73025,1.53359,omni,0,0.5;14,7,-4.65228,7.68863,1.53725,diff,0,0.5;20,2,-3.33048,7.74044,1.51842,diff,0,0.5;19,1,-1.89249,7.79111,1.51545,diff,1,0.5;13,2,-0.05,7.86924,0.049065,diff,1,0.5;10,1,1.37017,7.95223,-1.57,diff,1,0.5;9,1,1.35604,6.28347,1.57637,diff,0,0.5;8,1,1.40759,5.51805,1.57,diff,0,0.5;7,9,1.37777,2.7171,-1.57,diff,0,0.5,5;E";

            //測試封包 前後2是否為交管
            //String AAA = "Mp;0,0,0,0,0,diff,0,0;1,1,0,0,0,diff,0,0;2,1,0,0,0,diff,0,0;3,3,0,0,0,diff,0,0,0;4,1,0,0,0,diff,0,0;5,2,0,0,0,diff,0,0;E";

            //測試後退
            //String AAA = "Mr;22,0,-4.80035,2.7421,-1.55253,omni,0,0.5;21,1,-4.71364,5.73025,-1.53359,omni,0,0.5;14,7,-4.65228,7.68863,-1.53725,diff,0,0.5;E";
            
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            String AAA = "Mr;1,0,2.11,0.57,1.655,diff,0,0.5,ivam_3F;2,3,2.46556,-4.44588,1.66535,diff,0,0.5,ivam_3F,2;E";
            //String AAA = "Mr;1,0,2.46556,-4.44588,1.66535,diff,0,0.5,ivam_3F;2,3,2.11,0.57,1.655,diff,0,0.5,ivam_3F,2;E";

            //String AAA = "Mr;1,0,2.11,0.57,1.655,diff,1,0.5,ivam_3F;2,1,3.8,-0.48,1.74,diff,0,0.5,ivam_3F;3,1,2.27,-2.0,1.08,diff,1,0.5,ivam_3F;4,1,1.18,-2.9,1.74,diff,0,0.5,ivam_3F;5,3,2.25556,-4.49588,1.66535,diff,0,0.5,ivam_3F,2;E";
            //String AAA = "Mr;1,0,2.46556,-4.44588,1.66535,diff,1,0.5,ivam_3F;2,1,2.33,-2.36,1.62,diff,0,0.5,ivam_3F;3,3,-0.95,-0.27,-3.05,diff,0,0.5,ivam_3F,2;E";
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            pushdata = Encoding.UTF8.GetBytes(AAA); //把要送出的資料轉成byte型態
            //while (true)
            //{
            //    count++;
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的
            //    if (count == 10) break;
            //}
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.50.148"),9930); //可自行定義廣播區域跟Port (外面)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.197"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.0.7"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("172.20.10.4"), 9930); //可自行定義廣播區域跟Port (我手機)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.50.194"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.50.148"), 9930); //可自行定義廣播區域跟Port (NUC)
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.0.2"), 9930); //可自行定義廣播區域跟Port (TEST 網路 醫療)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域


            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小
           

            String QQQ = "T;3,1;E";
            //String QQQ = "C;1;E";
      
            //pushdata = Encoding.UTF8.GetBytes("sendMessage"); //把要送出的資料轉成byte型態
            pushdata = Encoding.UTF8.GetBytes(QQQ); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的


        }

        private void button3_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.50.194"), 9930); //可自行定義廣播區域跟Port (NUC)
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.50.153"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.148"), 9930); //可自行定義廣播區域跟Port (外面)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.197"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.0.7"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("172.20.10.4"), 9930); //可自行定義廣播區域跟Port (我手機)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域


            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小


            //String QQQ = "T;1,1;E";
            String QQQ = "C;1;E";

            //pushdata = Encoding.UTF8.GetBytes("sendMessage"); //把要送出的資料轉成byte型態
            pushdata = Encoding.UTF8.GetBytes(QQQ); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.149"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.50.194"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.50.148"),9930); //可自行定義廣播區域跟Port (外面)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.197"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.0.7"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.68"), 9930); //可自行定義廣播區域跟Port (我手機)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域


            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小


            //String QQQ = "T;1,1;E";
            //String QQQ = "C;1;E";
            String QQQ = "P;AGV2,11,0,1.3,0.9,0.44,0.64,-1,0.075,22.5,0.1,1,0.5,1,0.2,0.3,0.5,0.0,1.0,2,120;E";

            //pushdata = Encoding.UTF8.GetBytes("sendMessage"); //把要送出的資料轉成byte型態
            pushdata = Encoding.UTF8.GetBytes(QQQ); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.50.194"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.43.177"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.109"), 9930); //可自行定義廣播區域跟Port (外面)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.197"), 9930); //可自行定義廣播區域跟Port (NUC)
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.72.152"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("172.20.10.4"), 9930); //可自行定義廣播區域跟Port (我手機)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.50.211"), 9930); //可自行定義廣播區域跟Port(TEST 網路 醫療)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域


            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小


            //String QQQ = "T;1,1;E";
            String QQQ = "Sm;0;E";

            //pushdata = Encoding.UTF8.GetBytes("sendMessage"); //把要送出的資料轉成byte型態
            pushdata = Encoding.UTF8.GetBytes(QQQ); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.50.194"), 9930); //可自行定義廣播區域跟Port (NUC)
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.72.152"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.109"), 9930); //可自行定義廣播區域跟Port (外面)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.197"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.0.2"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.0.2"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.0.2"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("172.20.10.4"), 9930); //可自行定義廣播區域跟Port (我手機)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域


            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小


            //String QQQ = "T;1,1;E";
            String QQQ = "Sm;1,ivam_5F;E";

            //pushdata = Encoding.UTF8.GetBytes("sendMessage"); //把要送出的資料轉成byte型態
            pushdata = Encoding.UTF8.GetBytes(QQQ); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的
        }

        private void button7_Click(object sender, EventArgs e)
        {
            InitializeComponent();

            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.50.192"), 9930); //可自行定義廣播區域跟Port (外面)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.197"), 9930); //可自行定義廣播區域跟Port (IVAM)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.50.194"), 9930); //可自行定義廣播區域跟Port (外面)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.0.255"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.122"), 9930); //可自行定義廣播區域跟Port (明榮網醫療)
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.122"), 9930); //可自行定義廣播區域跟Port(TEST網醫療)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.197"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.0.7"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("172.20.10.4"), 9930); //可自行定義廣播區域跟Port (我手機)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域
            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小
            char[] sendtest = new char[1024];



            //String AAA = "M;3,0,-0.909477,0.118225,0.063229,diff;0,5,-4.475,0.1,0.0215,diff,2;E";

            //測試直走
            //String AAA = "Mp;2,0,2325,1950,900,diff,0,0.5;1,2,2330,2140,900,diff,0,0.5;E";

            //測試直走B1
            //String AAA = "Mp;1,0,2550,1984,888,diff,0,0.5,ivam_B1F;2,2,2550,2114,888,diff,0,0.5,ivam_B1F;E";
            String AAA = "Mr;1,0,-0.216,-0.093,0.062,diff,1,0.5,mymap1;2,1,1.96,0.32,0.0.7869,diff,0,0.5,mymap1;3,3,1.976,3.8834,1.67,diff,0,0.5,mymap1,1;E";//轉彎
            //String AAA = "Mp;2,0,2452,2046,20,diff,0,0.5;1,2,2350,2050,20,diff,0,0.5;E";

            //測試直走中華汽車實驗場域
            //String AAA = "Mp;2,0,2086,2078,900,diff,0,0.5;1,2,2082,2204,887,diff,0,0.5;E";


            pushdata = Encoding.UTF8.GetBytes(AAA); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的
        }

        private void button8_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.50.194"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.43.177"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.109"), 9930); //可自行定義廣播區域跟Port (外面)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.197"), 9930); //可自行定義廣播區域跟Port (NUC)
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.43.177"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("172.20.10.4"), 9930); //可自行定義廣播區域跟Port (我手機)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域


            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小


            //String QQQ = "T;1,1;E";
            String QQQ = "Sm;3;E";

            //pushdata = Encoding.UTF8.GetBytes("sendMessage"); //把要送出的資料轉成byte型態
            pushdata = Encoding.UTF8.GetBytes(QQQ); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的
        }

        private void button9_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.149"), 9930); //可自行定義廣播區域跟Port (NUC)
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.50.149"), 9930); //可自行定義廣播區域跟Port (NUC)

            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域


            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小


            //String QQQ = "T;1,1;E";
            String QQQ = "I;check;E";

            //pushdata = Encoding.UTF8.GetBytes("sendMessage"); //把要送出的資料轉成byte型態
            pushdata = Encoding.UTF8.GetBytes(QQQ); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的
        }

        private void button10_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.149"), 9930); //可自行定義廣播區域跟Port (NUC)

            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域


            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小


            //String QQQ = "T;1,1;E";
            String QQQ = "Rp;0,1,123,123,123;E";

            //pushdata = Encoding.UTF8.GetBytes("sendMessage"); //把要送出的資料轉成byte型態
            pushdata = Encoding.UTF8.GetBytes(QQQ); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的
        }

        private void button11_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.0.2"), 9930); //可自行定義廣播區域跟Port (NUC)

            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域


            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小

            String QQQ = "St;1;E";

            //pushdata = Encoding.UTF8.GetBytes("sendMessage"); //把要送出的資料轉成byte型態
            pushdata = Encoding.UTF8.GetBytes(QQQ); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的
        }

        private void button12_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.0.2"), 9930); //可自行定義廣播區域跟Port (NUC)

            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域


            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小

            String QQQ = "St;2;E";

            //pushdata = Encoding.UTF8.GetBytes("sendMessage"); //把要送出的資料轉成byte型態
            pushdata = Encoding.UTF8.GetBytes(QQQ); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的
        }

        private void button13_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.0.2"), 9930); //可自行定義廣播區域跟Port (NUC)

            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域


            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小

            String QQQ = "St;3;E";

            //pushdata = Encoding.UTF8.GetBytes("sendMessage"); //把要送出的資料轉成byte型態
            pushdata = Encoding.UTF8.GetBytes(QQQ); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的

        }

        private void button14_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.50.194"), 9930); //可自行定義廣播區域跟Port (NUC)
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.149"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.109"), 9930); //可自行定義廣播區域跟Port (外面)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.197"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.0.2"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("172.20.10.4"), 9930); //可自行定義廣播區域跟Port (我手機)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域


            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小


            //String QQQ = "T;1,1;E";
            String QQQ = "Sm;2;E";

            //pushdata = Encoding.UTF8.GetBytes("sendMessage"); //把要送出的資料轉成byte型態
            pushdata = Encoding.UTF8.GetBytes(QQQ); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的
        }

        private void button15_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.50.194"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.43.177"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.149"), 9930); //可自行定義廣播區域跟Port (筆電)
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.122"), 9930); //可自行定義廣播區域跟Port (明榮網醫療)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.109"), 9930); //可自行定義廣播區域跟Port (外面)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.197"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.0.2"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("172.20.10.4"), 9930); //可自行定義廣播區域跟Port (我手機)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域


            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小


            //String QQQ = "T;1,1;E";
            String QQQ = "Sm;0;E";

            //pushdata = Encoding.UTF8.GetBytes("sendMessage"); //把要送出的資料轉成byte型態
            pushdata = Encoding.UTF8.GetBytes(QQQ); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的
        }



        private void button17_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.50.194"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.43.177"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.122"), 9930); //可自行定義廣播區域跟Port (明榮網醫療)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.109"), 9930); //可自行定義廣播區域跟Port (外面)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.197"), 9930); //可自行定義廣播區域跟Port (NUC)
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.43.177"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.0.2"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.0.2"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("172.20.10.4"), 9930); //可自行定義廣播區域跟Port (我手機)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域


            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小


            //String QQQ = "T;1,1;E";
            String QQQ = "Sm;1,trash_map;E";

            //pushdata = Encoding.UTF8.GetBytes("sendMessage"); //把要送出的資料轉成byte型態
            pushdata = Encoding.UTF8.GetBytes(QQQ); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的
        }

        private void button16_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.50.194"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.43.177"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.149"), 9930); //可自行定義廣播區域跟Port (筆電)
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.122"), 9930); //可自行定義廣播區域跟Port (明榮網醫療)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.109"), 9930); //可自行定義廣播區域跟Port (外面)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.197"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.0.2"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("172.20.10.4"), 9930); //可自行定義廣播區域跟Port (我手機)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域


            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小


            //String QQQ = "T;1,1;E";
            String QQQ = "Sm;2,trash;E";

            //pushdata = Encoding.UTF8.GetBytes("sendMessage"); //把要送出的資料轉成byte型態
            pushdata = Encoding.UTF8.GetBytes(QQQ); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的
        }

        private void button18_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.149"), 9930); //可自行定義廣播區域跟Port (NUC)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域


            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小

            String QQQ = "{\"Doubletest\":1.3456,\"companyID\":15.7,\"AGVID\":12,\"AGVname\":\"genius\",\"arrayint\":[1,2,3,4,5]}";

            //pushdata = Encoding.UTF8.GetBytes("sendMessage"); //把要送出的資料轉成byte型態
            pushdata = Encoding.UTF8.GetBytes(QQQ); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的
        }

        private void button19_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.122"), 9930); //可自行定義廣播區域跟Port (明榮網醫療)
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.0.2"), 9930); //可自行定義廣播區域跟Port (TEST網醫療)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域


            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小


            //String QQQ = "T;1,1;E";
            String QQQ = "Sm;2,ivam_B1F;E";

            //pushdata = Encoding.UTF8.GetBytes("sendMessage"); //把要送出的資料轉成byte型態
            pushdata = Encoding.UTF8.GetBytes(QQQ); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的
        }

        private void button20_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.122"), 9930); //可自行定義廣播區域跟Port (明榮網醫療)
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.0.2"), 9930); //可自行定義廣播區域跟Port (TEST網醫療)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域


            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小


            //String QQQ = "T;1,1;E";
            String QQQ = "Sm;2,ivam_B1F_1;E";

            //pushdata = Encoding.UTF8.GetBytes("sendMessage"); //把要送出的資料轉成byte型態
            pushdata = Encoding.UTF8.GetBytes(QQQ); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的
        }

        private void button21_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.122"), 9930); //可自行定義廣播區域跟Port (明榮網醫療)
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.0.2"), 9930); //可自行定義廣播區域跟Port (TEST網醫療)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域


            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小


            //String QQQ = "T;1,1;E";
            String QQQ = "Sm;2,ivam_B1F_2;E";

            //pushdata = Encoding.UTF8.GetBytes("sendMessage"); //把要送出的資料轉成byte型態
            pushdata = Encoding.UTF8.GetBytes(QQQ); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的
        }

        private void button22_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.122"), 9930); //可自行定義廣播區域跟Port (明榮網醫療)
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.0.2"), 9930); //可自行定義廣播區域跟Port (TEST網醫療)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域


            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小


            //String QQQ = "T;1,1;E";
            String QQQ = "Sm;2,ivam_B1F_3;E";

            //pushdata = Encoding.UTF8.GetBytes("sendMessage"); //把要送出的資料轉成byte型態
            pushdata = Encoding.UTF8.GetBytes(QQQ); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的
        }

        private void button23_Click(object sender, EventArgs e)
        {
            InitializeComponent();

            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.122"), 9930); //可自行定義廣播區域跟Port (明榮網醫療)
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.0.2"), 9930); //可自行定義廣播區域跟Port (TEST網醫療)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域


            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小


            //String QQQ = "T;1,1;E";
            String QQQ = "Sm;2,ivam_B1F_4;E";

            //pushdata = Encoding.UTF8.GetBytes("sendMessage"); //把要送出的資料轉成byte型態
            pushdata = Encoding.UTF8.GetBytes(QQQ); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的
        }

        private void button24_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.50.148"),9930); //可自行定義廣播區域跟Port (外面)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.197"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.0.7"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("172.20.10.4"), 9930); //可自行定義廣播區域跟Port (我手機)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.50.194"), 9930); //可自行定義廣播區域跟Port (NUC)
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.50.148"), 9930); //可自行定義廣播區域跟Port (NUC)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域


            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小


            String QQQ = "T;3,3,0.8;E";
            //String QQQ = "C;1;E";

            //pushdata = Encoding.UTF8.GetBytes("sendMessage"); //把要送出的資料轉成byte型態
            pushdata = Encoding.UTF8.GetBytes(QQQ); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的
        }

        private void button25_Click(object sender, EventArgs e)
        {

            InitializeComponent();

            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.122"), 9930); //可自行定義廣播區域跟Port (明榮網醫療)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.50.211"), 9930); //可自行定義廣播區域跟Port(TEST 網路 醫療)
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.0.2"), 9930); //可自行定義廣播區域跟Port (TEST 網路 醫療)

            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("172.20.10.4"), 9930); //可自行定義廣播區域跟Port (我手機)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域
            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小
            char[] sendtest = new char[1024];



            //測試直走B1
            //String AAA = "Mp;1,0,2550,2114,888,diff,0,0.5;2,2,2550,1984,888,diff,0,0.5;E";
            //String AAA = "Mp;1,0,2285,2050,20,diff,0,0.5;2,2,2445,2046,20,diff,0,0.5;E";
            //測試轉彎B1
            //String AAA = "Mp;0,0,2495,2051,900,diff,1,1.0,ivam_B1F;1,1,2550,2051,900,diff,0,0.5,ivam_B1F;2,2,2550,2114,2688,diff,0,0.5,ivam_B1F;E";
            //String AAA = "Mr;5,0,-0.298546,-0.1203033,0.0828308,diff,1,0.5; 4,1,1.48059,-0.1298325,3.10016,diff,1,0.5; 6,1,1.35283,1.78837,1.59481,diff,0,0.5; 7,1,1.37777,2.7171,-1.57,diff,0,0.5; 8,1,1.40759,5.51805,1.57,diff,0,0.5; 9,2,1.35604,6.28347,1.57637,diff,0,0.5; 10,7,1.37017,7.90223,-1.57,omni,0,0.5; 11,1,2.59215,7.93435,-1.57,omni,0,0.5; 12,7,3.7,7.98438,-1.57,diff,0,0.5; 1,2,3.85,4,-1.54431,diff,0,0.5;E";

            //測試轉彎B1取數據
            String AAA = "Mp;0,0,2495,2051,900,diff,1,1.0,ivam_B1F;1,1,2550,2051,900,diff,0,0.5,ivam_B1F;2,1,2550,1991,898,diff,1,0.5,ivam_B1F;3,1,2548,1930,945,diff,0,0.5,ivam_B1F;4,2,2685,1924,5.31,diff,0,0.5,ivam_B1F;E";
            //String AAA = "Mp;0,0,2495,2051,900,diff,1,1.0,ivam_B1F;1,1,2550,2051,900,diff,0,0.5,ivam_B1F;2,2,2550,1991,898,diff,1,0.5,ivam_B1F;E";



            //測試B1_test
            //電梯入內功能
            //String AAA = "Mp;0,0,47,-6,95,diff,0,0.5,ivam_B1F_test1;1,11,70,-9,64,diff,0,0.5,ivam_B1F_test1;2,12,98,-12,64,diff,0,0.5,ivam_B1F_test1;3,12,2,-2.3,0,diff,0,0.5,ivam_B1F_test2;4,3,29,-3.44,0,diff,0,0.5,ivam_B1F_test2,1;E";
            //純切換功能
            //String AAA = "Mp;0,0,47,-6,95,diff,0,0.5,ivam_B1F_test1;1,1,70,-9,64,diff,0,0.5,ivam_B1F_test1;2,13,98,-12,64,diff,0,0.5,ivam_B1F_test1;3,12,2,-2.3,0,diff,0,0.5,ivam_B1F_test2;4,3,29,-3.44,0,diff,0,0.5,ivam_B1F_test2,1;E";






            pushdata = Encoding.UTF8.GetBytes(AAA); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的
        }

        private void button26_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.122"), 9930); //可自行定義廣播區域跟Port (明榮網醫療)
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.0.2"), 9930); //可自行定義廣播區域跟Port (TEST網醫療)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域


            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小


            //String QQQ = "T;1,1;E";
            String QQQ = "Sm;2,ivam_B1F_test1;E";

            //pushdata = Encoding.UTF8.GetBytes("sendMessage"); //把要送出的資料轉成byte型態
            pushdata = Encoding.UTF8.GetBytes(QQQ); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的
        }

        private void button27_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.122"), 9930); //可自行定義廣播區域跟Port (明榮網醫療)
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.0.2"), 9930); //可自行定義廣播區域跟Port (TEST網醫療)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域


            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小


            //String QQQ = "T;1,1;E";
            String QQQ = "Sm;2,ivam_B1F_test2;E";

            //pushdata = Encoding.UTF8.GetBytes("sendMessage"); //把要送出的資料轉成byte型態
            pushdata = Encoding.UTF8.GetBytes(QQQ); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的
        }

        private void qrcode_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.50.194"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.43.177"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.109"), 9930); //可自行定義廣播區域跟Port (外面)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.197"), 9930); //可自行定義廣播區域跟Port (NUC)
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.50.153"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("172.20.10.4"), 9930); //可自行定義廣播區域跟Port (我手機)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.50.211"), 9930); //可自行定義廣播區域跟Port(TEST 網路 醫療)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域


            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小


            //String QQQ = "T;1,1;E";
            String QQQ = "Qr;1;E";

            //pushdata = Encoding.UTF8.GetBytes("sendMessage"); //把要送出的資料轉成byte型態
            pushdata = Encoding.UTF8.GetBytes(QQQ); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的
        }

        private void qrcode_exit_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.50.194"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.43.177"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.109"), 9930); //可自行定義廣播區域跟Port (外面)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.197"), 9930); //可自行定義廣播區域跟Port (NUC)
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.50.152"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("172.20.10.4"), 9930); //可自行定義廣播區域跟Port (我手機)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.50.211"), 9930); //可自行定義廣播區域跟Port(TEST 網路 醫療)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域


            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小


            //String QQQ = "T;1,1;E";
            String QQQ = "Qr;2;E";

            //pushdata = Encoding.UTF8.GetBytes("sendMessage"); //把要送出的資料轉成byte型態
            pushdata = Encoding.UTF8.GetBytes(QQQ); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的
        }

        private void Button30_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.50.194"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.43.177"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.109"), 9930); //可自行定義廣播區域跟Port (外面)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.197"), 9930); //可自行定義廣播區域跟Port (NUC)
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.72.109"), 9930); //可自行定義廣播區域跟Port (NUC)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("172.20.10.4"), 9930); //可自行定義廣播區域跟Port (我手機)
            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.50.211"), 9930); //可自行定義廣播區域跟Port(TEST 網路 醫療)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域


            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小


            //String QQQ = "T;1,1;E";
            String QQQ = "Sm;5;E";

            //pushdata = Encoding.UTF8.GetBytes("sendMessage"); //把要送出的資料轉成byte型態
            pushdata = Encoding.UTF8.GetBytes(QQQ); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的
        }

        private void Button31_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.15"), 9930); //可自行定義廣播區域跟Port (NUC)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域


            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小


            //String QQQ = "T;1,1;E";
            //String QQQ = "Sm;2,factory1;E";//cartographer
            String QQQ = "Sm;2,ivam_5F;E";//hector_slam

            //pushdata = Encoding.UTF8.GetBytes("sendMessage"); //把要送出的資料轉成byte型態
            pushdata = Encoding.UTF8.GetBytes(QQQ); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的
        }

        private void change_floor_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.72.152"), 9930); //可自行定義廣播區域跟Port (NUC)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域


            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小


            //String QQQ = "T;1,1;E";
            //String QQQ = "Sm;2;E";

            //cartographer
            //String QQQ = "Mr;" +
            //         "0,0,-1.37,-0.182,0.098,diff,0,0.5,ivam_3F;" +
            //         "1,13,0.3,0.021,0.117,diff,0,0.5,ivam_3F;" +
            //         "2,13,-0.247,0.097,-0.087,diff,1,0.5,ivam_5F;" +//1.319
            //         "3,1,1.043,0.147,-0.04,diff,0,0.5,ivam_5F;" +
            //         "4,3,1.76,1.88,1.38,diff,0,0.5,ivam_5F," +
            //         "5;E";
            //boling
            String QQQ = "Mr;" +
                     "0,0,0.618896,0.04968,-0.0555704,diff,0,0.5,ivam_5F;" +
                     "1,13,0.938148,-0.405746,-0.211771,diff,0,0.5,ivam_5F;" +
                     "2,13,0.519852,0.0206451,-0.057999,diff,0,0.5,ivam_3F;" +//1.319
                     "3,3,1.91673,-0.134689,-0.0623019,diff,0,0.5,ivam_3F;" +
                     "5;E";

            //pushdata = Encoding.UTF8.GetBytes("sendMessage"); //把要送出的資料轉成byte型態
            pushdata = Encoding.UTF8.GetBytes(QQQ); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的
        }

        private void comfirm_floor_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.15"), 9930); //可自行定義廣播區域跟Port (NUC)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域


            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小


            //String QQQ = "T;1,1;E";
            String QQQ = "F;100;E";

            //pushdata = Encoding.UTF8.GetBytes("sendMessage"); //把要送出的資料轉成byte型態
            pushdata = Encoding.UTF8.GetBytes(QQQ); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的
        }

        private void virtual_el_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.72.109"), 9930); //可自行定義廣播區域跟Port (NUC)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域


            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小


            //String QQQ = "T;1,1;E";
            String QQQ = "F;100;E";

            //pushdata = Encoding.UTF8.GetBytes("sendMessage"); //把要送出的資料轉成byte型態
            pushdata = Encoding.UTF8.GetBytes(QQQ); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的
        }

        private void change_floor2_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.1.15"), 9930); //可自行定義廣播區域跟Port (NUC)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域


            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小


            //String QQQ = "T;1,1;E";
            //String QQQ = "Sm;2;E";
            //cartographer
            //String QQQ = "Mr;" +
            //         "0,0,-1.37,-0.182,0.098,diff,0,0.5,ivam_3F;" +
            //         "1,13,0.3,0.021,0.117,diff,0,0.5,ivam_3F;" +
            //         "2,13,-0.247,0.097,-0.087,diff,1,0.5,ivam_5F;" +//1.319
            //         "3,1,1.043,0.147,-0.04,diff,0,0.5,ivam_5F;" +
            //         "4,3,1.76,1.88,1.38,diff,0,0.5,ivam_5F," +
            //         "5;E";
            //boling
            String QQQ = "Mr;" +
                     "0,0,-1.37,-0.182,0.098,diff,0,0.5,ivam_8F;" +
                     "1,13,0.3,0.021,0.117,diff,0,0.5,ivam_8F;" +
                     "2,13,-0.247,0.097,-0.087,diff,1,0.5,ivam_1F;" +//1.319
                     "3,1,1.043,0.147,-0.04,diff,0,0.5,ivam_1F;" +
                     "4,3,1.76,1.88,1.38,diff,0,0.5,ivam_1F," +
                     "5;E";

            //pushdata = Encoding.UTF8.GetBytes("sendMessage"); //把要送出的資料轉成byte型態
            pushdata = Encoding.UTF8.GetBytes(QQQ); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的
        }

        private void Button36_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.72.152"), 9930); //可自行定義廣播區域跟Port (NUC)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域


            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小


            //String QQQ = "T;1,1;E";
            String QQQ = "F;10;E";

            //pushdata = Encoding.UTF8.GetBytes("sendMessage"); //把要送出的資料轉成byte型態
            pushdata = Encoding.UTF8.GetBytes(QQQ); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的
        }
    }
}
