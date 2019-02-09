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

namespace RDBrute {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void connectbtn_Click(object sender, EventArgs e) {
            RDPClient rdp = new RDPClient();

            string username = usernamebox.Text;
            string password = passwordbox.Text;
            string server = serverbox.Text;
            int threads = Convert.ToInt32(threadBox.Value);

            //if (usernamebox.Text == null)
            //{
            //    MessageBo
            //}

            rdp.newclient(Form1.ActiveForm, username, password, server, threads);
            Console.WriteLine(rdp);

        }
    }
}
