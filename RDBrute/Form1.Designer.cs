namespace RDBrute {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.usernamelabel = new System.Windows.Forms.Label();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.serverlabel = new System.Windows.Forms.Label();
            this.usernamebox = new System.Windows.Forms.TextBox();
            this.passwordbox = new System.Windows.Forms.TextBox();
            this.serverbox = new System.Windows.Forms.TextBox();
            this.connectbtn = new System.Windows.Forms.Button();
            this.threadslbl = new System.Windows.Forms.Label();
            this.threadBox = new System.Windows.Forms.NumericUpDown();
            this.OpenUserNameFile = new System.Windows.Forms.OpenFileDialog();
            this.browseusernamebutton = new System.Windows.Forms.Button();
            this.browsepasswordbutton = new System.Windows.Forms.Button();
            this.OpenPasswordFile = new System.Windows.Forms.OpenFileDialog();
            this.browseserverbutton = new System.Windows.Forms.Button();
            this.OpenServerFile = new System.Windows.Forms.OpenFileDialog();
            this.consolebox = new System.Windows.Forms.TextBox();
            this.ConsoleLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.threadBox)).BeginInit();
            this.SuspendLayout();
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Location = new System.Drawing.Point(63, 12);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(55, 13);
            this.usernamelabel.TabIndex = 0;
            this.usernamelabel.Text = "Username";
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Location = new System.Drawing.Point(65, 47);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(53, 13);
            this.passwordlabel.TabIndex = 1;
            this.passwordlabel.Text = "Password";
            // 
            // serverlabel
            // 
            this.serverlabel.AutoSize = true;
            this.serverlabel.Location = new System.Drawing.Point(80, 83);
            this.serverlabel.Name = "serverlabel";
            this.serverlabel.Size = new System.Drawing.Size(38, 13);
            this.serverlabel.TabIndex = 2;
            this.serverlabel.Text = "Server";
            // 
            // usernamebox
            // 
            this.usernamebox.Location = new System.Drawing.Point(124, 12);
            this.usernamebox.Name = "usernamebox";
            this.usernamebox.ReadOnly = true;
            this.usernamebox.Size = new System.Drawing.Size(276, 20);
            this.usernamebox.TabIndex = 3;
            // 
            // passwordbox
            // 
            this.passwordbox.Location = new System.Drawing.Point(124, 44);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.ReadOnly = true;
            this.passwordbox.Size = new System.Drawing.Size(276, 20);
            this.passwordbox.TabIndex = 4;
            // 
            // serverbox
            // 
            this.serverbox.Location = new System.Drawing.Point(124, 80);
            this.serverbox.Name = "serverbox";
            this.serverbox.ReadOnly = true;
            this.serverbox.Size = new System.Drawing.Size(276, 20);
            this.serverbox.TabIndex = 5;
            // 
            // connectbtn
            // 
            this.connectbtn.Location = new System.Drawing.Point(227, 121);
            this.connectbtn.Name = "connectbtn";
            this.connectbtn.Size = new System.Drawing.Size(75, 23);
            this.connectbtn.TabIndex = 6;
            this.connectbtn.Text = "Connect";
            this.connectbtn.UseVisualStyleBackColor = true;
            this.connectbtn.Click += new System.EventHandler(this.connectbtn_Click);
            // 
            // threadslbl
            // 
            this.threadslbl.AutoSize = true;
            this.threadslbl.Location = new System.Drawing.Point(72, 121);
            this.threadslbl.Name = "threadslbl";
            this.threadslbl.Size = new System.Drawing.Size(46, 13);
            this.threadslbl.TabIndex = 7;
            this.threadslbl.Text = "Threads";
            // 
            // threadBox
            // 
            this.threadBox.Location = new System.Drawing.Point(124, 119);
            this.threadBox.Name = "threadBox";
            this.threadBox.Size = new System.Drawing.Size(51, 20);
            this.threadBox.TabIndex = 9;
            this.threadBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // browseusernamebutton
            // 
            this.browseusernamebutton.Location = new System.Drawing.Point(406, 10);
            this.browseusernamebutton.Name = "browseusernamebutton";
            this.browseusernamebutton.Size = new System.Drawing.Size(75, 23);
            this.browseusernamebutton.TabIndex = 10;
            this.browseusernamebutton.Text = "Browse";
            this.browseusernamebutton.UseVisualStyleBackColor = true;
            this.browseusernamebutton.Click += new System.EventHandler(this.browseusernamebutton_Click);
            // 
            // browsepasswordbutton
            // 
            this.browsepasswordbutton.Location = new System.Drawing.Point(406, 42);
            this.browsepasswordbutton.Name = "browsepasswordbutton";
            this.browsepasswordbutton.Size = new System.Drawing.Size(75, 23);
            this.browsepasswordbutton.TabIndex = 11;
            this.browsepasswordbutton.Text = "Browse";
            this.browsepasswordbutton.UseVisualStyleBackColor = true;
            this.browsepasswordbutton.Click += new System.EventHandler(this.browsepasswordbutton_Click);
            // 
            // browseserverbutton
            // 
            this.browseserverbutton.Location = new System.Drawing.Point(406, 78);
            this.browseserverbutton.Name = "browseserverbutton";
            this.browseserverbutton.Size = new System.Drawing.Size(75, 23);
            this.browseserverbutton.TabIndex = 12;
            this.browseserverbutton.Text = "Browse";
            this.browseserverbutton.UseVisualStyleBackColor = true;
            this.browseserverbutton.Click += new System.EventHandler(this.browseserverbutton_Click);
            // 
            // consolebox
            // 
            this.consolebox.Location = new System.Drawing.Point(18, 201);
            this.consolebox.Multiline = true;
            this.consolebox.Name = "consolebox";
            this.consolebox.ReadOnly = true;
            this.consolebox.Size = new System.Drawing.Size(510, 332);
            this.consolebox.TabIndex = 13;
            // 
            // ConsoleLbl
            // 
            this.ConsoleLbl.AutoSize = true;
            this.ConsoleLbl.Location = new System.Drawing.Point(240, 185);
            this.ConsoleLbl.Name = "ConsoleLbl";
            this.ConsoleLbl.Size = new System.Drawing.Size(45, 13);
            this.ConsoleLbl.TabIndex = 14;
            this.ConsoleLbl.Text = "Console";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 545);
            this.Controls.Add(this.ConsoleLbl);
            this.Controls.Add(this.consolebox);
            this.Controls.Add(this.browseserverbutton);
            this.Controls.Add(this.browsepasswordbutton);
            this.Controls.Add(this.browseusernamebutton);
            this.Controls.Add(this.threadBox);
            this.Controls.Add(this.threadslbl);
            this.Controls.Add(this.connectbtn);
            this.Controls.Add(this.serverbox);
            this.Controls.Add(this.passwordbox);
            this.Controls.Add(this.usernamebox);
            this.Controls.Add(this.serverlabel);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.usernamelabel);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "RDBrute";
            ((System.ComponentModel.ISupportInitialize)(this.threadBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.Label serverlabel;
        private System.Windows.Forms.TextBox usernamebox;
        private System.Windows.Forms.TextBox passwordbox;
        private System.Windows.Forms.TextBox serverbox;
        private System.Windows.Forms.Button connectbtn;
        private System.Windows.Forms.Label threadslbl;
        private System.Windows.Forms.NumericUpDown threadBox;
        private System.Windows.Forms.OpenFileDialog OpenUserNameFile;
        private System.Windows.Forms.Button browseusernamebutton;
        private System.Windows.Forms.Button browsepasswordbutton;
        private System.Windows.Forms.OpenFileDialog OpenPasswordFile;
        private System.Windows.Forms.Button browseserverbutton;
        private System.Windows.Forms.OpenFileDialog OpenServerFile;
        private System.Windows.Forms.TextBox consolebox;
        private System.Windows.Forms.Label ConsoleLbl;
    }
}

