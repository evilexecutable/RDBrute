using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RDBrute;
using AxMSTSCLib;
using System.Windows.Forms;
using MSTSCLib;
using System.Threading;

namespace RDBrute {
    class RDPClient {
        //public TaskCompletionSource<bool> TheResult = new TaskCompletionSource<bool>();

        public async Task newclient(Form f, string[] username, string[] password, string[] server) {

            //List<Task<string>> tasks = new List<Task<string>>();
            //foreach (string thisserver in server) {
            //    foreach (string thispassword in password) {
            //        foreach (string thisusername in username) {
            //            Console.WriteLine(thisusername + thispassword + thisserver);
            //            Task<string> task = SpawnClient(f, thisusername, thispassword, thisserver);
            //            tasks.Add(task);
            //            Console.WriteLine(tasks);
            //        }
            //    }
            //}
            //var allResults = await Task.WhenAll(tasks);

            //int maxServers = server.Count();
            //int maxPassword = password.Count();
            //int maxUsername = username.Count();
            //int currentUsername = 

            //for (int maxServers = 1; maxServers < server.Count(); maxServers++) {

            //}

            //for(int serverNumber = 1; serverNumber < server.Count(); serverNumber++) {
            //    for (int passwordNumber = 1; passwordNumber < password.Count(); passwordNumber++) {
            //        for (int usernameNumber = 1; serverNumber < username.Count(); usernameNumber++) {

            //            string nextserver = server[serverNumber];
            //            string nextpassword = password[passwordNumber];
            //            string nextusername = username[usernameNumber];

            //            Console.WriteLine(server[serverNumber]);

            //            Task<string> Task = SpawnClient(f, nextusername, nextpassword, nextserver);



            //        }
            //    }
            //}

        }

        public async Task<string> SpawnClient(Form f, string nextusername, string nextpassword, string nextserver) {
            

            AxMsRdpClient9NotSafeForScripting rdpClient = new AxMsRdpClient9NotSafeForScripting();
            f.Controls.Add(rdpClient);
            rdpClient.Size = new System.Drawing.Size(1, 1);
            rdpClient.CreateControl();
            rdpClient.OnConnected += Rdp_OnConnected;
            rdpClient.OnLoginComplete += Rdp_OnLoginComplete;
            rdpClient.OnLogonError += new AxMSTSCLib.IMsTscAxEvents_OnLogonErrorEventHandler(Rdp_OnLogonError);
            rdpClient.UserName = nextusername;
            rdpClient.Server = nextserver;
            ((MSTSCLib.IMsRdpClientAdvancedSettings)rdpClient.AdvancedSettings).ClearTextPassword = nextpassword;
            ((MSTSCLib.IMsRdpClientAdvancedSettings8)rdpClient.AdvancedSettings8).EnableCredSspSupport = true;
            var stuff = rdpClient.GetOcx() as IMsRdpClientNonScriptable7;
            stuff.PromptForCredentials = false;
            //stuff.PromptForCredsOnClient = false;

            rdpClient.Connect();
            
            //TheResult.Delay(5000);

            return "";
            //Console.WriteLine(nextserver + " done");
          
        }

        public void getResult(string result) {
            //public static string result;
        
        }

        public void Rdp_OnConnected(object sender, EventArgs e) {
            MessageBox.Show("Connected");
            //getResult("connected");            
        }

        public void Rdp_OnLoginComplete(object sender, EventArgs e) {
            MessageBox.Show("Logged in");
            //getResult("success");
        }

        public void Rdp_OnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e) {
            MessageBox.Show("Error");
            //getResult("error");
        }

    }
}
