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


        /*********************************************************************************************************************************
        * 倒車直線
        **********************************************************************************************************************************/
        private void Btn_Send(object sender, EventArgs e)
        {
            sendBacktracking(); //轉成倒車模式

            InitializeComponent();

            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.72.152"), 9930); //可自行定義廣播區域跟Port(TEST 網路 醫療)

            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("172.20.10.4"), 9930); //可自行定義廣播區域跟Port (我手機)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域
            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小
            char[] sendtest = new char[1024];

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            String AAA = "Mr;1,0,2.61,0.73,-1.41,diff,0,0.5,ivam_3F;2,3,3.32,-4.49,-1.41,diff,0,0.5,ivam_3F,2;E"; //back line
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            pushdata = Encoding.UTF8.GetBytes(AAA); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的 
        }

        /*********************************************************************************************************************************
        * 前進直線
        **********************************************************************************************************************************/
        private void Btn_Send2(object sender, EventArgs e)
        {
            sendFronttracking(); //轉成前進模式

            InitializeComponent();

            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.72.152"), 9930); //可自行定義廣播區域跟Port(TEST 網路 醫療)

            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("172.20.10.4"), 9930); //可自行定義廣播區域跟Port (我手機)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域
            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小
            char[] sendtest = new char[1024];

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            String AAA = "Mr;1,0,3.32,-4.49,-1.41,diff,0,0.5,ivam_3F;2,3,2.61,0.73,-1.41,diff,0,0.5,ivam_3F,2;E"; //front line
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            pushdata = Encoding.UTF8.GetBytes(AAA); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的 
        }

        /*********************************************************************************************************************************
        * 倒車S
        **********************************************************************************************************************************/
        private void Btn_Send3(object sender, EventArgs e)
        {
            sendBacktracking(); //轉成倒車模式

            InitializeComponent();

            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.72.152"), 9930); //可自行定義廣播區域跟Port(TEST 網路 醫療)

            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("172.20.10.4"), 9930); //可自行定義廣播區域跟Port (我手機)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域
            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小
            char[] sendtest = new char[1024];

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            String AAA = "Mr;1,0,2.11,0.57,1.655,diff,1,0.5,ivam_3F;2,1,3.8,-0.48,1.74,diff,0,0.5,ivam_3F;3,1,2.27,-2.0,1.08,diff,1,0.5,ivam_3F;4,1,1.18,-2.9,1.74,diff,0,0.5,ivam_3F;5,3,2.25556,-4.49588,1.66535,diff,0,0.5,ivam_3F,2;E"; //S
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            pushdata = Encoding.UTF8.GetBytes(AAA); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的
        }

        /*********************************************************************************************************************************
        * 前進S
        **********************************************************************************************************************************/
        private void Btn_Send4(object sender, EventArgs e)
        {
            sendFronttracking(); //轉成前進模式

            InitializeComponent();

            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.72.152"), 9930); //可自行定義廣播區域跟Port(TEST 網路 醫療)

            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("172.20.10.4"), 9930); //可自行定義廣播區域跟Port (我手機)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域
            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小
            char[] sendtest = new char[1024];

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            String AAA = "Mr;1,0,2.25556,-4.49588,1.66535,diff,1,0.5,ivam_3F;2,1,1.18,-2.9,1.74,diff,0,0.5,ivam_3F;3,1,2.27,-2.0,1.08,diff,1,0.5,ivam_3F;4,1,3.8,-0.48,1.74,diff,0,0.5,ivam_3F;5,3,2.11,0.57,1.655,diff,0,0.5,ivam_3F,2;E"; //S
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            pushdata = Encoding.UTF8.GetBytes(AAA); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的 
        }

        /*********************************************************************************************************************************
        * 倒車O
        **********************************************************************************************************************************/
        private void Btn_Send5(object sender, EventArgs e)
        {
            sendBacktracking(); //轉成倒車模式

            InitializeComponent();

            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.72.152"), 9930); //可自行定義廣播區域跟Port(TEST 網路 醫療)

            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("172.20.10.4"), 9930); //可自行定義廣播區域跟Port (我手機)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域
            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小
            char[] sendtest = new char[1024];

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            String AAA = "Mr;1,0,-0.17,-0.44,0.10,diff,1,0.5,ivam_3F;2,1,3.61,0.35,1.68,diff,0,0.5,ivam_3F;3,1,3.77,-0.85,-1.46,diff,1,0.5,ivam_3F;4,1,4.01,-3.44,1.68,diff,1,0.5,ivam_3F;5,1,1.31,-3.73,0.12,diff,0,0.5,ivam_3F;6,3,0.72,-0.358,-1.45,diff,0,0.5,ivam_3F,2;E"; //o turn
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            pushdata = Encoding.UTF8.GetBytes(AAA); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的 
        }

        /*********************************************************************************************************************************
        * 前進O
        **********************************************************************************************************************************/
        private void Btn_Send6(object sender, EventArgs e)
        {
            sendFronttracking(); //轉成前進模式

            InitializeComponent();

            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.72.152"), 9930); //可自行定義廣播區域跟Port(TEST 網路 醫療)

            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("172.20.10.4"), 9930); //可自行定義廣播區域跟Port (我手機)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域
            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小
            char[] sendtest = new char[1024];

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            String AAA = "Mr;1,0,-0.17,-0.44,0.10,diff,1,0.5,ivam_3F;2,1,3.61,0.35,1.68,diff,0,0.5,ivam_3F;3,1,3.77,-0.85,-1.46,diff,1,0.5,ivam_3F;4,1,4.01,-3.44,1.68,diff,1,0.5,ivam_3F;5,1,1.31,-3.73,0.12,diff,0,0.5,ivam_3F;6,3,0.72,-0.358,-1.45,diff,0,0.5,ivam_3F,2;E"; //o turn
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            pushdata = Encoding.UTF8.GetBytes(AAA); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的 
        }

        /*********************************************************************************************************************************
        * 倒車原點
        **********************************************************************************************************************************/
        private void Btn_Send7(object sender, EventArgs e)
        {
            sendBacktracking(); //轉成倒車模式

            InitializeComponent();

            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.72.152"), 9930); //可自行定義廣播區域跟Port(TEST 網路 醫療)

            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("172.20.10.4"), 9930); //可自行定義廣播區域跟Port (我手機)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域
            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小
            char[] sendtest = new char[1024];

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            String AAA = "Mr;1,0,2.46556,-4.44588,1.66535,diff,1,0.5,ivam_3F;2,1,0.29,-0.07,-2.98,diff,0,0.5,ivam_3F;3,3,-0.99,0.16,-3.02,diff,0,0.5,ivam_3F,2;E"; //back home
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            pushdata = Encoding.UTF8.GetBytes(AAA); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的
        }

        /*********************************************************************************************************************************
        * 前進原點
        **********************************************************************************************************************************/
        private void Btn_Send8(object sender, EventArgs e)
        {
            sendFronttracking();  //轉成前進模式

            InitializeComponent();

            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.72.152"), 9930); //可自行定義廣播區域跟Port(TEST 網路 醫療)

            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("172.20.10.4"), 9930); //可自行定義廣播區域跟Port (我手機)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域
            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小
            char[] sendtest = new char[1024];

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            String AAA = "Mr;1,0,2.46556,-4.44588,1.66535,diff,1,0.5,ivam_3F;2,1,-0.09,0.49,2.02,diff,0,0.5,ivam_3F;3,3,-1.75,-0.28,-3.03,diff,0,0.5,ivam_3F,2;E"; //back home
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            pushdata = Encoding.UTF8.GetBytes(AAA); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的 
        }

        /*********************************************************************************************************************************
        * 後退導航
        **********************************************************************************************************************************/
        private void Button36_Click(object sender, EventArgs e)
        {
            sendBacktracking(); //轉成倒車模式
        }

        /*********************************************************************************************************************************
        * 前進導航
        **********************************************************************************************************************************/
        private void Button9_Click(object sender, EventArgs e)
        {
            sendFronttracking(); //轉成前進模式
        }

        /*********************************************************************************************************************************
        * 倒車封包
        **********************************************************************************************************************************/
        private void sendBacktracking()
        {
            InitializeComponent();
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.72.152"), 9930); //可自行定義廣播區域跟Port (NUC)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域


            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小

            String QQQ = "F;10;E";

            //pushdata = Encoding.UTF8.GetBytes("sendMessage"); //把要送出的資料轉成byte型態
            pushdata = Encoding.UTF8.GetBytes(QQQ); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的
        }

        /*********************************************************************************************************************************
        * 前進封包
        **********************************************************************************************************************************/
        private void sendFronttracking()
        {
            InitializeComponent();
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.72.152"), 9930); //可自行定義廣播區域跟Port (NUC)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域


            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小

            String QQQ = "F;11;E";

            //pushdata = Encoding.UTF8.GetBytes("sendMessage"); //把要送出的資料轉成byte型態
            pushdata = Encoding.UTF8.GetBytes(QQQ); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }
    }
}
