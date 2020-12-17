using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientForm
{
    public partial class Form1 : Form
    {
        Socket client;
        bool connection = false;
        public Form1()
        {
            InitializeComponent();
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            imgConnesso.Image = Properties.Resources.NonConnesso;
            ControlloConnessione();
        }

        private void btnConnetti_Click(object sender, EventArgs e)
        {
            IPAddress ipaddr = null;
            int nPort = 0;
            bool errori = false;

            if (!IPAddress.TryParse(txtIp.Text, out ipaddr))
            {
                MessageBox.Show("Ip vuoto o non valido", "Errore");
                errori = true;
            }
            if (!int.TryParse(txtPorta.Text, out nPort))
            {
                //porta o è vuota o è non valida
                MessageBox.Show("La porta è vuota o non valida", "Errore");
                errori = true;
            }
            if (nPort < 0 || nPort > 65535)
            {
                MessageBox.Show("La porta deve essere compresa fra 0 e 65535");
                errori = true;
            }

            if (!errori)
            {
                try
                {
                    client.Connect(ipaddr, nPort);
                    connection = true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Errore");
                    if(client!=null)
                    {
                        if (client.Connected)
                            client.Shutdown(SocketShutdown.Both);
                        client.Close();
                        client.Dispose();
                    }
                }
            }

            ControlloConnessione();
        }

        private void btnInvia_Click(object sender, EventArgs e)
        {
            byte[] sendbuff = new byte[128];
            byte[] recvbuff = new byte[128];
            int nReceivedBytes = 0;
            string mes = txtMsg.Text;

            try
            {
                sendbuff = Encoding.ASCII.GetBytes(mes);
                client.Send(sendbuff);

                if (mes.ToUpper() == "QUIT")
                {
                    if (client.Connected)
                        client.Shutdown(SocketShutdown.Both);
                    client.Close();
                    client.Dispose();
                    connection = false;
                    ControlloConnessione();
                    return;
                }

                nReceivedBytes = client.Receive(recvbuff);
                string receivedString = Encoding.ASCII.GetString(recvbuff, 0, nReceivedBytes);
                lstMsgs.Items.Add("S: " + receivedString);
                Array.Clear(sendbuff, 0, sendbuff.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore");
                if (client != null)
                {
                    if (client.Connected)
                        client.Shutdown(SocketShutdown.Both);
                    client.Close();
                    client.Dispose();
                }
            }
        }
        private void ControlloConnessione()
        {
            if (connection)
            {
                lblConnessione.Text = "Connesso";
                btnInvia.Enabled = true;
                txtMsg.Enabled = true;
                imgConnesso.Image = Properties.Resources.Connesso;
            }
            else
            {
                lblConnessione.Text = "Non Connesso";
                btnInvia.Enabled = false;
                txtMsg.Enabled = false;
                imgConnesso.Image = Properties.Resources.NonConnesso;
            }
        }
    }
}
