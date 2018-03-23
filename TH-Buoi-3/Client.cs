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

namespace TH_Buoi_3
{
    public partial class Client : Form
    {
        IPEndPoint ipe;
        Socket TH_Buoi_3;
        EndPoint Remote;
        public Client()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtboxSelection.Enabled = false;
            txtboxResult.Enabled = false;
            TH_Buoi_3 = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint ipep = new IPEndPoint(IPAddress.Loopback, 1234);
            Remote = (EndPoint)ipep;
        }

        private void btnKeo_Click(object sender, EventArgs e)
        {
            txtboxSelection.Text = "Kéo";
            byte[] send = Encoding.ASCII.GetBytes("0");
            TH_Buoi_3.SendTo(send, Remote);
            byte[] receive = new byte[20];
            txtboxResult.Text = Encoding.ASCII.GetString(receive);
            TH_Buoi_3.ReceiveFrom(send, ref Remote);
            txtboxResult.Text = Encoding.UTF8.GetString(receive);
        }

        private void btnBua_Click(object sender, EventArgs e)
        {
            txtboxSelection.Text = "Búa";
            byte[] send = Encoding.ASCII.GetBytes("0");
            TH_Buoi_3.SendTo(send, Remote);
            byte[] receive = new byte[20];
            txtboxResult.Text = Encoding.ASCII.GetString(receive);
            TH_Buoi_3.ReceiveFrom(send, ref Remote);
            txtboxResult.Text = Encoding.UTF8.GetString(receive);
        }

        private void btnBao_Click(object sender, EventArgs e)
        {
            txtboxSelection.Text = "Bao";
            byte[] send = Encoding.ASCII.GetBytes("0");
            TH_Buoi_3.SendTo(send, Remote);
            byte[] receive = new byte[20];
            txtboxResult.Text = Encoding.ASCII.GetString(receive);
            TH_Buoi_3.ReceiveFrom(send, ref Remote);
            txtboxResult.Text = Encoding.UTF8.GetString(receive);
        }
    }
}
