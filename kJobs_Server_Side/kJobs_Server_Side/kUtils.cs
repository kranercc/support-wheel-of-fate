using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kJobs_Server_Side
{
    class kUtils
    {

        public int DAY_OF_SUPPORT_AMMOUNT_IN_SECONDS = 8*(60*60);

        public struct Client
        {
            public string name;
            
            public string addr;

            public bool isConnected;

            public int timeAlive;



            /* handle business rules */

            public bool WorkedYesterday;
            public int Complete_Days_Of_Support;

            public bool canWorkToday()
            {
                if(WorkedYesterday == false) { return true; }
                else { return false; }
            }

            public bool Completed_One_Whole_Day_Of_Support()
            {
                /* if(requestTimeAliveFromDatabase + this.timeAlive >= this.DAY_OF_SUPPORT_AMMOUNT_IN_SECONDS)
                { 
                    Get_Last_Login_Date();
                    if GetLastLoginDate - (int)time.today.getmonth > 2 {return false}
                    else {return true;}
                } */

                /* return false by default */
                return false;
                
            }


            public string Get_Last_Login_Date()
            {
                /* request from database the last made connection to the server, then use split(':') or a 
                 separator char and organize in day month year and check currentMonth - Today.Month 
                and if n > 2 then return false in complete_one_whole_day_of_support*/

                return "";
            }

            
            public void Send_timeAlive_IntoDataBase()
            {
                /* for storage reasons send timeAlive in total into the database */
                if (this.isConnected == false)
                {
                    if(this.timeAlive != 0)
                    {
                        /* send into data base this.timeAlive */
                    }
                }
            }

            /* getters and setters */
            
            public void setName(string name) { this.name = name; }
            public void setAddr(string addy) { this.addr = addy; }
            public void setIsConnected(bool value) { this.isConnected = value; }
            public void setTimeAlive(int value) { this.timeAlive = value; }

            public string getName() { return this.name; }
            public string getAddr() { return this.addr; }
            public bool getisConnected() { return this.isConnected; }
            public int getTimeAlive() { return this.timeAlive; }

        }

        public Client[] clients;

        public Client[] AdminsOfTheDay;

        public int clientsOnline = 0;



        public kUtils()
        {
            this.clients = new Client[10];
            /* asta daca vrei sa ia 10 administrator dintr-o lista intreaga de persoane
             * daca nu, nu se initializeaza si programul ia random persone din lista de persoane
             * ACTIVE la momentu de fata pe server */
            this.clients[0].name = "krane";
            this.clients[1].name = "mario";
            this.clients[2].name = "ady";
            this.clients[3].name = "andrei";
            this.clients[4].name = "mircea";
            this.clients[5].name = "Marian";
            this.clients[6].name = "Geroge";
            this.clients[7].name = "grigore";
            this.clients[8].name = "adrian";
            this.clients[9].name = "mirel";

            this.AdminsOfTheDay = this.get_2RandomAdmins();

            this.Is_Week_Day();

            Thread t_checkAlive = new Thread(this.CheckAlive);
            t_checkAlive.Start();

            new Thread(this.Copy_and_Update_Since_NoPOINTERS).Start();

        }

        #region ContinuousUpdateAdmins
        public void Copy_and_Update_Since_NoPOINTERS()
        {
            while (true)
            {
                for (int i = 0; i < this.clients.Length; i++)
                {
                    for (int a = 0; a < this.AdminsOfTheDay.Length; a++)
                    {
                        if (this.clients[i].name == this.AdminsOfTheDay[a].name)
                        {
                            this.AdminsOfTheDay[a] = this.clients[i];
                        }
                    }
                }
            }

        }
        #endregion

        #region CheckForOvertime
        public bool clientIsOvertime(Client c)
        {
            if (c.timeAlive > this.DAY_OF_SUPPORT_AMMOUNT_IN_SECONDS / 2) { return true; }

            return false;
        }
        #endregion

        #region CheckAlive
        public void CheckAlive()
        {
            while (true)
            {
                Thread.Sleep(5000);

                for (int i = 0; i < this.clients.Length; i++)
                {
                    if(this.clients[i].name != null && this.clients[i].addr != null)
                    {

                        try
                        {
                            this.packet_sendAlive(this.clients[i].addr);
                            /* checkul se afla aici ca useru sa primeasca notificare IN TIMP ce lucreaza, iar checkul pentru Update e in request recivevedeedede */
                            if(this.clientIsOvertime(this.clients[i]))
                            {
                                this.SendData(this.clients[i].addr, "Overtime");
                            }
                            else
                            {
                                this.clients[i].timeAlive = this.clients[i].timeAlive + 5;
                            }

                        }
                        catch (Exception)
                        {

                            this.clients[i].isConnected = false;

                            //send time to database to sync data
//                            this.clients[i].Send_timeAlive_IntoDataBase();
                        }

                        
                    }
                }

            }
        }

        #endregion

        #region allConnectedadmins
        public int get_AllConnectedAdmins()
        {
            int toreturn = 0;
            foreach (var c in this.clients)
            {
                if (c.isConnected == true && c.name != null) { toreturn++; }
            }

            
            return toreturn;
        }

        #endregion

        #region Recivedata
        public void RecieveData()
        {
            TcpListener listener = new TcpListener(System.Net.IPAddress.Any, 9999);
            listener.Start();
            
            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                NetworkStream stream = client.GetStream();
                StreamReader sr = new StreamReader(client.GetStream());
                StreamWriter sw = new StreamWriter(client.GetStream());
                string addr = client.Client.RemoteEndPoint.ToString().Split(':')[0];
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

                    #region JoinMessage
                    if (request.Contains("join"))
                    {
                        string clientName = request.Substring(request.IndexOf(":") + 1);

                        for (int i = 0; i < this.clients.Length; i++)
                        {
                            /*if client not exists*/
                            if (this.clients[i].name == clientName)
                            {
                                if (this.clients[i].addr == null)
                                {

                                    this.clients[i].isConnected = true;
                                    this.clients[i].addr = addr;

                                }
                                else
                                {
                                    if (this.clients[i].isConnected == false)
                                    {
                                        this.clients[i].isConnected = true;
                                        this.clients[i].addr = addr; //intri de pe alt ip -> renew
                                    }

                                }
                            }
                        }

                        
                    }
                    #endregion

                    #region UpdateData
                    /* de preferat ar fi sa lucrez cu acelasi loop sau sa nu am mai multe if checkuri si sa folosesc un switch pentru viteza dar nu stiu switch pe .contains() care are output true sau false si decat sa-l fac case true case fals si sa am in ele ifuri mai bine fac asa */
                    if(request.Contains("update"))
                    {
                        bool isAdmin = false;

                        /*check if admin */
                        for (int i = 0; i < this.AdminsOfTheDay.Length; i++)
                        {
                            /* FIIND IN LOCAL HOST TRIGGERUL NU O SA MEARGA NICIODATA DAR WAN MERGE */
                            if(this.AdminsOfTheDay[i].addr == addr)
                            {
                                /* check overtime */
                                if(!this.clientIsOvertime(this.AdminsOfTheDay[i]))
                                {
                                    /* update some database i guess */
                                    
                                }
                                else
                                {
                                    this.SendData(this.AdminsOfTheDay[i].addr, "Overtime");
                                }

                                isAdmin = true;
                                
                            }

                        }

                        if(isAdmin == false) { this.SendData(addr, "noAdminOfTheDay"); }
                        
                    }


                    #endregion



                    sw.WriteLine("Message: " + request + " Recieved");
                    sw.Flush();
                }
                catch (Exception e)
                {

                    Debug.WriteLine(e.ToString());
                    Console.WriteLine("Something went wrong.");
                    sw.WriteLine(e.ToString());
                }
            }
        }

        #endregion

        #region SendData

        public void SendData(string client_addr, string messageToSend)
        {
            TcpClient client = new TcpClient(client_addr, 6942);

            int byteCount = Encoding.ASCII.GetByteCount(messageToSend + 1);
            byte[] sendData = Encoding.ASCII.GetBytes(messageToSend);

            NetworkStream stream = client.GetStream();
            stream.Write(sendData, 0, sendData.Length);

            stream.Close();
            client.Close();
        }

        #endregion

        #region Get_2_random_Admins
        public Client[] get_2RandomAdmins()
        {
            Client[] clients = new Client[2];


            /* request database results, see if there is an ALREADY assigned admin for today, in that case don't get a new random admin else do the following */

            Random rnd = new Random();
            for (int i = 0; i < 2; i++)
            {
                int rndClient = rnd.Next(0, this.clients.Length-1);
                clients[i] = this.clients[rndClient];

            }

            return clients;
        }

        #endregion

        #region IsWeekDay
        /* you can argue this could be in a different class but i like to think this is a random utility function*/
        public bool Is_Week_Day()
        {
            int day = (int)DateTime.Now.DayOfWeek;

            if(day < 6) { return true; }
            //return false;
            return true; //RETURN TRUE REGARDLESS OF DAY SINCE THIS CODE WILL NOT BE USED IRL
        }


        #endregion

        public void packet_sendAlive(string addr) { this.SendData(addr, "rudy"); }
    }
}
