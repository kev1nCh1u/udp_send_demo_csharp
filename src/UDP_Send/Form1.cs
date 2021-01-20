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

            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.72.152"), 9930); //可自行定義廣播區域跟Port(TEST 網路 醫療)

            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("172.20.10.4"), 9930); //可自行定義廣播區域跟Port (我手機)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域
            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小
            char[] sendtest = new char[1024];

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            String AAA = "Mr;1,0,2.11,0.57,1.655,diff,0,0.5,ivam_3F;2,3,2.46556,-4.44588,1.66535,diff,0,0.5,ivam_3F,2;E";
            //String AAA = "Mr;1,0,2.46556,-4.44588,1.66535,diff,0,0.5,ivam_3F;2,3,2.11,0.57,1.655,diff,0,0.5,ivam_3F,2;E";

            //String AAA = "Mr;1,0,2.11,0.57,1.655,diff,1,0.5,ivam_3F;2,1,3.8,-0.48,1.74,diff,0,0.5,ivam_3F;3,1,2.27,-2.0,1.08,diff,1,0.5,ivam_3F;4,1,1.18,-2.9,1.74,diff,0,0.5,ivam_3F;5,3,2.25556,-4.49588,1.66535,diff,0,0.5,ivam_3F,2;E";
            //String AAA = "Mr;1,0,2.46556,-4.44588,1.66535,diff,1,0.5,ivam_3F;2,1,2.33,-2.36,1.62,diff,0,0.5,ivam_3F;3,3,-0.95,-0.27,-3.05,diff,0,0.5,ivam_3F,2;E";
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            pushdata = Encoding.UTF8.GetBytes(AAA); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的 
        }

        private void Btn_Send2(object sender, EventArgs e)
        {

            InitializeComponent();

            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.72.152"), 9930); //可自行定義廣播區域跟Port(TEST 網路 醫療)

            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("172.20.10.4"), 9930); //可自行定義廣播區域跟Port (我手機)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域
            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小
            char[] sendtest = new char[1024];

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // String AAA = "Mr;1,0,2.11,0.57,1.655,diff,0,0.5,ivam_3F;2,3,2.46556,-4.44588,1.66535,diff,0,0.5,ivam_3F,2;E";
            String AAA = "Mr;1,0,2.46556,-4.44588,1.66535,diff,0,0.5,ivam_3F;2,3,2.11,0.57,1.655,diff,0,0.5,ivam_3F,2;E";

            //String AAA = "Mr;1,0,2.11,0.57,1.655,diff,1,0.5,ivam_3F;2,1,3.8,-0.48,1.74,diff,0,0.5,ivam_3F;3,1,2.27,-2.0,1.08,diff,1,0.5,ivam_3F;4,1,1.18,-2.9,1.74,diff,0,0.5,ivam_3F;5,3,2.25556,-4.49588,1.66535,diff,0,0.5,ivam_3F,2;E";
            //String AAA = "Mr;1,0,2.46556,-4.44588,1.66535,diff,1,0.5,ivam_3F;2,1,2.33,-2.36,1.62,diff,0,0.5,ivam_3F;3,3,-0.95,-0.27,-3.05,diff,0,0.5,ivam_3F,2;E";
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            pushdata = Encoding.UTF8.GetBytes(AAA); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的 
        }

        private void Btn_Send3(object sender, EventArgs e)
        {

            InitializeComponent();

            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.72.152"), 9930); //可自行定義廣播區域跟Port(TEST 網路 醫療)

            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("172.20.10.4"), 9930); //可自行定義廣播區域跟Port (我手機)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域
            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小
            char[] sendtest = new char[1024];

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // String AAA = "Mr;1,0,2.11,0.57,1.655,diff,0,0.5,ivam_3F;2,3,2.46556,-4.44588,1.66535,diff,0,0.5,ivam_3F,2;E";
            //String AAA = "Mr;1,0,2.46556,-4.44588,1.66535,diff,0,0.5,ivam_3F;2,3,2.11,0.57,1.655,diff,0,0.5,ivam_3F,2;E";

            String AAA = "Mr;1,0,2.11,0.57,1.655,diff,1,0.5,ivam_3F;2,1,3.8,-0.48,1.74,diff,0,0.5,ivam_3F;3,1,2.27,-2.0,1.08,diff,1,0.5,ivam_3F;4,1,1.18,-2.9,1.74,diff,0,0.5,ivam_3F;5,3,2.25556,-4.49588,1.66535,diff,0,0.5,ivam_3F,2;E";
            //String AAA = "Mr;1,0,2.46556,-4.44588,1.66535,diff,1,0.5,ivam_3F;2,1,2.33,-2.36,1.62,diff,0,0.5,ivam_3F;3,3,-0.95,-0.27,-3.05,diff,0,0.5,ivam_3F,2;E";
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            pushdata = Encoding.UTF8.GetBytes(AAA); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的 
        }

        private void Btn_Send4(object sender, EventArgs e)
        {

            InitializeComponent();

            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.72.152"), 9930); //可自行定義廣播區域跟Port(TEST 網路 醫療)

            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("172.20.10.4"), 9930); //可自行定義廣播區域跟Port (我手機)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域
            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小
            char[] sendtest = new char[1024];

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // String AAA = "Mr;1,0,2.11,0.57,1.655,diff,0,0.5,ivam_3F;2,3,2.46556,-4.44588,1.66535,diff,0,0.5,ivam_3F,2;E";
            //String AAA = "Mr;1,0,2.46556,-4.44588,1.66535,diff,0,0.5,ivam_3F;2,3,2.11,0.57,1.655,diff,0,0.5,ivam_3F,2;E";

            //String AAA = "Mr;1,0,2.11,0.57,1.655,diff,1,0.5,ivam_3F;2,1,3.8,-0.48,1.74,diff,0,0.5,ivam_3F;3,1,2.27,-2.0,1.08,diff,1,0.5,ivam_3F;4,1,1.18,-2.9,1.74,diff,0,0.5,ivam_3F;5,3,2.25556,-4.49588,1.66535,diff,0,0.5,ivam_3F,2;E";
            String AAA = "Mr;1,0,2.46556,-4.44588,1.66535,diff,1,0.5,ivam_3F;2,1,2.33,-2.36,1.62,diff,0,0.5,ivam_3F;3,3,-0.95,-0.27,-3.05,diff,0,0.5,ivam_3F,2;E";
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            pushdata = Encoding.UTF8.GetBytes(AAA); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的 
        }

        private void Btn_Send5(object sender, EventArgs e)
        {

            InitializeComponent();

            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.72.152"), 9930); //可自行定義廣播區域跟Port(TEST 網路 醫療)

            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("172.20.10.4"), 9930); //可自行定義廣播區域跟Port (我手機)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域
            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小
            char[] sendtest = new char[1024];

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            String AAA = "Mr;1,0,2.11,0.57,1.655,diff,0,0.5,ivam_3F;2,3,2.46556,-4.44588,1.66535,diff,0,0.5,ivam_3F,2;E";
            //String AAA = "Mr;1,0,2.46556,-4.44588,1.66535,diff,0,0.5,ivam_3F;2,3,2.11,0.57,1.655,diff,0,0.5,ivam_3F,2;E";

            //String AAA = "Mr;1,0,2.11,0.57,1.655,diff,1,0.5,ivam_3F;2,1,3.8,-0.48,1.74,diff,0,0.5,ivam_3F;3,1,2.27,-2.0,1.08,diff,1,0.5,ivam_3F;4,1,1.18,-2.9,1.74,diff,0,0.5,ivam_3F;5,3,2.25556,-4.49588,1.66535,diff,0,0.5,ivam_3F,2;E";
            //String AAA = "Mr;1,0,2.46556,-4.44588,1.66535,diff,1,0.5,ivam_3F;2,1,2.33,-2.36,1.62,diff,0,0.5,ivam_3F;3,3,-0.95,-0.27,-3.05,diff,0,0.5,ivam_3F,2;E";
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            pushdata = Encoding.UTF8.GetBytes(AAA); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的 
        }

        private void Btn_Send6(object sender, EventArgs e)
        {

            InitializeComponent();

            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.72.152"), 9930); //可自行定義廣播區域跟Port(TEST 網路 醫療)

            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("172.20.10.4"), 9930); //可自行定義廣播區域跟Port (我手機)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域
            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小
            char[] sendtest = new char[1024];

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            String AAA = "Mr;1,0,2.11,0.57,1.655,diff,0,0.5,ivam_3F;2,3,2.46556,-4.44588,1.66535,diff,0,0.5,ivam_3F,2;E";
            //String AAA = "Mr;1,0,2.46556,-4.44588,1.66535,diff,0,0.5,ivam_3F;2,3,2.11,0.57,1.655,diff,0,0.5,ivam_3F,2;E";

            //String AAA = "Mr;1,0,2.11,0.57,1.655,diff,1,0.5,ivam_3F;2,1,3.8,-0.48,1.74,diff,0,0.5,ivam_3F;3,1,2.27,-2.0,1.08,diff,1,0.5,ivam_3F;4,1,1.18,-2.9,1.74,diff,0,0.5,ivam_3F;5,3,2.25556,-4.49588,1.66535,diff,0,0.5,ivam_3F,2;E";
            //String AAA = "Mr;1,0,2.46556,-4.44588,1.66535,diff,1,0.5,ivam_3F;2,1,2.33,-2.36,1.62,diff,0,0.5,ivam_3F;3,3,-0.95,-0.27,-3.05,diff,0,0.5,ivam_3F,2;E";
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            pushdata = Encoding.UTF8.GetBytes(AAA); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的 
        }

        private void Btn_Send7(object sender, EventArgs e)
        {

            InitializeComponent();

            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.72.152"), 9930); //可自行定義廣播區域跟Port(TEST 網路 醫療)

            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("172.20.10.4"), 9930); //可自行定義廣播區域跟Port (我手機)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域
            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小
            char[] sendtest = new char[1024];

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            String AAA = "Mr;1,0,2.11,0.57,1.655,diff,0,0.5,ivam_3F;2,3,2.46556,-4.44588,1.66535,diff,0,0.5,ivam_3F,2;E";
            //String AAA = "Mr;1,0,2.46556,-4.44588,1.66535,diff,0,0.5,ivam_3F;2,3,2.11,0.57,1.655,diff,0,0.5,ivam_3F,2;E";

            //String AAA = "Mr;1,0,2.11,0.57,1.655,diff,1,0.5,ivam_3F;2,1,3.8,-0.48,1.74,diff,0,0.5,ivam_3F;3,1,2.27,-2.0,1.08,diff,1,0.5,ivam_3F;4,1,1.18,-2.9,1.74,diff,0,0.5,ivam_3F;5,3,2.25556,-4.49588,1.66535,diff,0,0.5,ivam_3F,2;E";
            //String AAA = "Mr;1,0,2.46556,-4.44588,1.66535,diff,1,0.5,ivam_3F;2,1,2.33,-2.36,1.62,diff,0,0.5,ivam_3F;3,3,-0.95,-0.27,-3.05,diff,0,0.5,ivam_3F,2;E";
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            pushdata = Encoding.UTF8.GetBytes(AAA); //把要送出的資料轉成byte型態
            Server.SendTo(pushdata, remoteIP); //送出的資料跟目的 
        }

        private void Btn_Send8(object sender, EventArgs e)
        {

            InitializeComponent();

            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("192.168.72.152"), 9930); //可自行定義廣播區域跟Port(TEST 網路 醫療)

            //IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("172.20.10.4"), 9930); //可自行定義廣播區域跟Port (我手機)
            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域
            Server.EnableBroadcast = true;
            Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            byte[] pushdata = new byte[1024]; //定義要送出的封包大小
            char[] sendtest = new char[1024];

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            String AAA = "Mr;1,0,2.11,0.57,1.655,diff,0,0.5,ivam_3F;2,3,2.46556,-4.44588,1.66535,diff,0,0.5,ivam_3F,2;E";
            //String AAA = "Mr;1,0,2.46556,-4.44588,1.66535,diff,0,0.5,ivam_3F;2,3,2.11,0.57,1.655,diff,0,0.5,ivam_3F,2;E";

            //String AAA = "Mr;1,0,2.11,0.57,1.655,diff,1,0.5,ivam_3F;2,1,3.8,-0.48,1.74,diff,0,0.5,ivam_3F;3,1,2.27,-2.0,1.08,diff,1,0.5,ivam_3F;4,1,1.18,-2.9,1.74,diff,0,0.5,ivam_3F;5,3,2.25556,-4.49588,1.66535,diff,0,0.5,ivam_3F,2;E";
            //String AAA = "Mr;1,0,2.46556,-4.44588,1.66535,diff,1,0.5,ivam_3F;2,1,2.33,-2.36,1.62,diff,0,0.5,ivam_3F;3,3,-0.95,-0.27,-3.05,diff,0,0.5,ivam_3F,2;E";
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            pushdata = Encoding.UTF8.GetBytes(AAA); //把要送出的資料轉成byte型態
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
