using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AppWindows
{
    public partial class frmServer : Form
    {
        private const int BUFFER_SIZE = 1024;
        private const int PORT_NUMBER = 9999;
        static ASCIIEncoding encoding = new ASCIIEncoding();

        Socket server, client = null;
        IPEndPoint ipe;
        public frmServer()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            ipe = new IPEndPoint(IPAddress.Any, PORT_NUMBER);

            server.Bind(ipe);
            server.Listen(10);

            appendText("Waiting for a connection...", rTbWindow.Text.Length, Color.Red);

            Thread thread = new Thread(new ThreadStart(receive));
            thread.Start();

            btnStart.Enabled = false;

        }
        public void receive()
        {
            client = server.Accept();
            if (client != null)
            {
                appendText("\nClient has been accepted!", rTbWindow.Text.Length, Color.Red);
            }
            string text = "";
            while (true)
            {
                byte[] data = new byte[BUFFER_SIZE];
                client.Receive(data);

                text = Encoding.Unicode.GetString(data);

                if (text.Trim().Length > 0)
                {
                    appendText("\nClient : " + text, rTbWindow.Text.Length, Color.Violet);
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

        public void send(string text)
        {
            client.Send(Encoding.Unicode.GetBytes(text));
            appendText("\nServer: " + text, rTbWindow.Text.Length, Color.Black);
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (client == null)
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
