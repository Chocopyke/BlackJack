using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Linq.Expressions;
using System.Threading;

namespace BlackJack
{
    public partial class LoginForm : Form
    {
        Socket logform;
        Thread listen;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);

            return stream.ToArray();
        }
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }

        void Connect()
        {
            IPEndPoint ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8888);
            logform = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            logform.Connect(ip);

            string tmp = "99:" + accBox.Text.Trim() + pasBox.Text.Trim();
            logform.Send(Serialize(tmp));

            string sermes = "";

            try
            {
                byte[] data = new byte[1024 * 5000];
                logform.Receive(data);

                sermes = Deserialize(data).ToString();
            }
            catch { }

            if (sermes == "true")
            {
                Multi_Client client = new Multi_Client();
                client.Show();
                logform.Close();
                this.Hide();
            }
            else MessageBox.Show("Dang nhap sai! Vui long nhap lai!");
        }
    }
}
