using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kJobs_Client_Side
{
    class kUtils
    {
        string THE_SERVER = "127.0.0.1";
        byte[] buffer = new byte[1024];

        public struct _Admin
        {
            public bool LoggedIn;

        }

        public _Admin Admin;

        public kUtils()
        {
            Admin = new _Admin();

        }

        #region Login
        public void Login(string name)
        {
            try
            {
                this.SendData("join:" + name);
                Admin.LoggedIn = true;
            }
            catch (Exception)
            {
                Admin.LoggedIn = false;
                MessageBox.Show("Connection to: " + this.THE_SERVER + " could not be established");
            }

            try
            {
                new Thread(this.packet_getAlive).Start();
            }
            catch
            {
                /* already started, if this occures, it means the user spammed the login button*/
            }


        }

        #endregion

        #region SendData
        public void SendData(string messageToSend)
        {

            TcpClient client = new TcpClient(this.THE_SERVER, 9999);

            int byteCount = Encoding.ASCII.GetByteCount(messageToSend + 1);
            byte[] sendData = Encoding.ASCII.GetBytes(messageToSend);

            NetworkStream stream = client.GetStream();
            stream.Write(sendData, 0, sendData.Length);

            StreamReader sr = new StreamReader(stream);
            string response = sr.ReadLine();
            Console.WriteLine(response);

            stream.Close();
            client.Close();



        }
        #endregion

        #region Recivedata
        public void RecieveData()
        {
            TcpListener listener = new TcpListener(System.Net.IPAddress.Any, 6942);
            listener.Start();

            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                NetworkStream stream = client.GetStream();
                StreamReader sr = new StreamReader(client.GetStream());
                StreamWriter sw = new StreamWriter(client.GetStream());
                try
                {

                    byte[] buffer = new byte[1024];
                    stream.Read(buffer, 0, buffer.Length);
                    int recv = 0;
                    foreach (byte b in buffer)
                    {
                        if (b != 0)
                        {
                            recv++;
                        }
                    }
                    string request = Encoding.UTF8.GetString(buffer, 0, recv);


                    if(request.Contains("Overtime"))
                    {
                        MessageBox.Show("Changes have no been applied, you are not allowed to work overtime");
                    }
                    if(request == "noAdminOfTheDay")
                    {
                        MessageBox.Show("You are not the assigned Admin to solve tickets today");
                    }

                    sw.Flush();
                }
                catch (Exception e)
                {
                }
            }
        }

        #endregion

        
        public void packet_getAlive() { try { this.RecieveData(); } catch { } }

    }
}
