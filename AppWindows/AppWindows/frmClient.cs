using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWindows
{
    public partial class frmClient : Form
    {
        private const int BUFFER_SIZE = 1024;
        private const int PORT_NUMBER = 9999;

        static ASCIIEncoding encoding = new ASCIIEncoding();

        Socket client;
        IPEndPoint iep;
        public frmClient()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            iep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), PORT_NUMBER);

            client.Connect(iep);
            send(client.LocalEndPoint + " connected!!!");
            Thread thread = new Thread(new ThreadStart(receive));
            thread.Start();

            btnConnect.Enabled = false;
        }

        public void receive()
        {
            string text = "";
            while (true)
            {
                byte[] data = new byte[BUFFER_SIZE];
                client.Receive(data);

                text = Encoding.Unicode.GetString(data);

                if (text.Trim().Length > 0)
                {
                    appendText("\nServer: " + text, rTbWindow.Text.Length, Color.Violet);
                }
            }

        }

        public void appendText(string text, int indexStartSelection, Color _color)
        {
            rTbWindow.SelectionStart = indexStartSelection;
            rTbWindow.SelectionColor = _color;
            rTbWindow.AppendText(text);
            rTbWindow.ScrollToCaret();
            rTbWindow.DeselectAll();
        }

        public void send(String text)
        {
            client.Send(Encoding.Unicode.GetBytes(text));
            appendText("\nClient: " + text, rTbWindow.Text.Length, Color.Black);
           // rTbWindow.AppendText("\nClient: " + text);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (btnConnect.Enabled == true)
            {
                MessageBox.Show("Please start server and connect client");
                return;
            }

            send(rTbChat.Text.ToString());
            rTbChat.Clear();
            rTbChat.Focus();
        }
    }
}
