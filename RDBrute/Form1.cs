using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxMSTSCLib;
using System.IO;

namespace RDBrute {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void connectbtn_Click(object sender, EventArgs e) {
            RDPClient rdp = new RDPClient();

            //string username = usernamebox.Text;
            //string password = passwordbox.Text;
            //string server = serverbox.Text;
            //int threads = Convert.ToInt32(threadBox.Value);

            //if (usernamebox.Text == null)
            //{
            //    MessageBo
            //}

            if ((usernamebox.Text == null) || (passwordbox.Text == null) || serverbox.Text == null)
            {
                MessageBox.Show("Please ensure you pick a username, password and server list.");
            }
            else
            {
                string[] usernames = File.ReadAllLines(usernamebox.Text);
                string[] passwords = File.ReadAllLines(passwordbox.Text);
                string[] servers = File.ReadAllLines(serverbox.Text);
                int threads = Convert.ToInt32(threadBox.Value);

                rdp.newclient(Form1.ActiveForm, usernames, passwords, servers, threads);
            }

        }

        private void browseusernamebutton_Click(object sender, EventArgs e)
        {
            if(OpenUserNameFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string userFileName = OpenUserNameFile.FileName;
                usernamebox.Text = userFileName;
            }
        }

        private void browsepasswordbutton_Click(object sender, EventArgs e)
        {
            if (OpenPasswordFile.ShowDialog() == DialogResult.OK)
            {
                string passwordFileName = OpenPasswordFile.FileName;
                passwordbox.Text = passwordFileName;
            }
        }

        private void browseserverbutton_Click(object sender, EventArgs e)
        {
            if (OpenServerFile.ShowDialog() == DialogResult.OK)
            {
                string serverFileName = OpenServerFile.FileName;
                serverbox.Text = serverFileName;
            }
        }
    }
}
