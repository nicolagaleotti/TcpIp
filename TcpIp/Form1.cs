using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcpIp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SimpleTcpServer server;
        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += DataReceived;
        }

        private void DataReceived(object sender, SimpleTCP.Message e)
        {
            statustxt.Invoke((MethodInvoker)delegate ()
            {
                statustxt.Text += e.MessageString;
                e.ReplyLine(string.Format("Said", e.MessageString));
            });
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void srtbtn_Click(object sender, EventArgs e)
        {
            statustxt.Text += "il server ha iniziato a comunicare";
            IPAddress ip = IPAddress.Parse(txtHost.Text);
        }

        private void stopbtn_Click(object sender, EventArgs e)
        {
            if(server.IsStarted)
            {
                server.Stop();
                statustxt.Text = "Server stopped";
            }
        }
    }
}
