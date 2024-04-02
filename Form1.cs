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

namespace mc_protocol_test1
{
    public partial class Form1 : Form
    {
        TcpClient Client;
        NetworkStream stream;
        bool PLCConnected;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PLCConnected = false;
            btn_Connect.Text = "Connect";
            btn_Tx.Enabled = false;
            txt_TxCommand.Text = "500000FF03FF000020001014010000M*00010000022347AB96";

        }


        private void txt_Port_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (!PLCConnected)
                {
                    Client = new TcpClient();
                    //  Client.Connect(txt_IP.ToString(), Int32.Parse(txt_Port.ToString()));
                    Client.Connect(txt_IP.Text, int.Parse(txt_Port.Text));
                    //Client.Connect("192.168.3.250", 5000);
                    stream = Client.GetStream();

                    PLCConnected = true;
                    btn_Connect.Text = "Disconnect";
                    btn_Tx.Enabled = true;

                    MessageBox.Show("Success.");
                    //IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 11004);
                    //Client.Connect(ipEndPoint);
                }else
                {
                    timer1.Enabled = false;
                    Client.Close();


                    PLCConnected = false;
                    btn_Connect.Text = "Connect";
                    btn_Tx.Enabled = false;
                }
            }
            catch (ArgumentNullException a)
            {
                Console.WriteLine("ArgumentNullException:{0}", a);
            }
            catch (SocketException ex)
            {
                Console.WriteLine("SocketException:{0}", ex);
            }
            //catch (Exception ex)
            //{
            //     MessageBox.Show("Error.");
            // }


        }

        private void btn_Tx_Click(object sender, EventArgs e)
        {

            byte[] btData = System.Text.Encoding.ASCII.GetBytes(txt_TxCommand.Text);
            try
            {
                
                stream.Write(btData, 0, btData.Length); // Write data to server.
                Console.WriteLine(btData.Length);
                timer1.Enabled=true;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Write Exception:{0}", ex);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (stream.DataAvailable)
            {
               // timer1.Enabled = false;
                byte[] InBuff = new byte[1024];
                stream.Read(InBuff, 0, InBuff.Length);
                txt_RxMessage.Text = System.Text.Encoding.Default.GetString(InBuff);
               // Client.GetStream().Read(InBuff, 0, InBuff.Length)
                //RxResponse = System.Text.Encoding.Default.GetString(InBuff)

            }
            //else
              //  Console.WriteLine("!");

        }

        private void btn_MessageCLR_Click(object sender, EventArgs e)
        {
            txt_RxMessage.Text = "";
        }
    }
}
