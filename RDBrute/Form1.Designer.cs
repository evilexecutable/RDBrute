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
            ((System.ComponentModel.ISupportInitialize)(this.threadBox)).BeginInit();
            this.SuspendLayout();
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Location = new System.Drawing.Point(12, 9);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(55, 13);
            this.usernamelabel.TabIndex = 0;
            this.usernamelabel.Text = "Username";
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Location = new System.Drawing.Point(14, 47);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(53, 13);
            this.passwordlabel.TabIndex = 1;
            this.passwordlabel.Text = "Password";
            // 
            // serverlabel
            // 
            this.serverlabel.AutoSize = true;
            this.serverlabel.Location = new System.Drawing.Point(14, 87);
            this.serverlabel.Name = "serverlabel";
            this.serverlabel.Size = new System.Drawing.Size(38, 13);
            this.serverlabel.TabIndex = 2;
            this.serverlabel.Text = "Server";
            // 
            // usernamebox
            // 
            this.usernamebox.Location = new System.Drawing.Point(124, 9);
            this.usernamebox.Name = "usernamebox";
            this.usernamebox.Size = new System.Drawing.Size(147, 20);
            this.usernamebox.TabIndex = 3;
            // 
            // passwordbox
            // 
            this.passwordbox.Location = new System.Drawing.Point(124, 44);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.Size = new System.Drawing.Size(147, 20);
            this.passwordbox.TabIndex = 4;
            // 
            // serverbox
            // 
            this.serverbox.Location = new System.Drawing.Point(124, 80);
            this.serverbox.Name = "serverbox";
            this.serverbox.Size = new System.Drawing.Size(147, 20);
            this.serverbox.TabIndex = 5;
            // 
            // connectbtn
            // 
            this.connectbtn.Location = new System.Drawing.Point(124, 234);
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
            this.threadslbl.Location = new System.Drawing.Point(14, 126);
            this.threadslbl.Name = "threadslbl";
            this.threadslbl.Size = new System.Drawing.Size(46, 13);
            this.threadslbl.TabIndex = 7;
            this.threadslbl.Text = "Threads";
            // 
            // threadBox
            // 
            this.threadBox.Location = new System.Drawing.Point(124, 119);
            this.threadBox.Name = "threadBox";
            this.threadBox.Size = new System.Drawing.Size(147, 20);
            this.threadBox.TabIndex = 9;
            this.threadBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 272);
            this.Controls.Add(this.threadBox);
            this.Controls.Add(this.threadslbl);
            this.Controls.Add(this.connectbtn);
            this.Controls.Add(this.serverbox);
            this.Controls.Add(this.passwordbox);
            this.Controls.Add(this.usernamebox);
            this.Controls.Add(this.serverlabel);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.usernamelabel);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

