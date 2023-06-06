namespace KetNoi_SQL_SERVER
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtNameServer = new System.Windows.Forms.TextBox();
			this.txtNameDatabase = new System.Windows.Forms.TextBox();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.txtPassWord = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.grbSQLServer = new System.Windows.Forms.GroupBox();
			this.rdoWindows = new System.Windows.Forms.RadioButton();
			this.rdoSQLServer = new System.Windows.Forms.RadioButton();
			this.btnConnect = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.grbSQLServer.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(152, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(345, 38);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kết Nối Cơ Sở Dữ Liệu";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên server";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 82);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(110, 20);
			this.label3.TabIndex = 1;
			this.label3.Text = "Tên database";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(4, 19);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 20);
			this.label4.TabIndex = 1;
			this.label4.Text = "Tài khoản";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(4, 67);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(77, 20);
			this.label5.TabIndex = 1;
			this.label5.Text = "Mật khẩu";
			// 
			// txtNameServer
			// 
			this.txtNameServer.Location = new System.Drawing.Point(135, 24);
			this.txtNameServer.Name = "txtNameServer";
			this.txtNameServer.Size = new System.Drawing.Size(475, 27);
			this.txtNameServer.TabIndex = 2;
			// 
			// txtNameDatabase
			// 
			this.txtNameDatabase.Location = new System.Drawing.Point(135, 79);
			this.txtNameDatabase.Name = "txtNameDatabase";
			this.txtNameDatabase.Size = new System.Drawing.Size(475, 27);
			this.txtNameDatabase.TabIndex = 2;
			// 
			// txtUser
			// 
			this.txtUser.Location = new System.Drawing.Point(136, 16);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(475, 27);
			this.txtUser.TabIndex = 2;
			// 
			// txtPassWord
			// 
			this.txtPassWord.Location = new System.Drawing.Point(136, 64);
			this.txtPassWord.Name = "txtPassWord";
			this.txtPassWord.PasswordChar = '*';
			this.txtPassWord.Size = new System.Drawing.Size(475, 27);
			this.txtPassWord.TabIndex = 2;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtNameDatabase);
			this.groupBox1.Controls.Add(this.txtNameServer);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(23, 60);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(622, 120);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			// 
			// grbSQLServer
			// 
			this.grbSQLServer.Controls.Add(this.txtPassWord);
			this.grbSQLServer.Controls.Add(this.txtUser);
			this.grbSQLServer.Controls.Add(this.label5);
			this.grbSQLServer.Controls.Add(this.label4);
			this.grbSQLServer.Location = new System.Drawing.Point(23, 252);
			this.grbSQLServer.Name = "grbSQLServer";
			this.grbSQLServer.Size = new System.Drawing.Size(621, 117);
			this.grbSQLServer.TabIndex = 4;
			this.grbSQLServer.TabStop = false;
			this.grbSQLServer.Visible = false;
			// 
			// rdoWindows
			// 
			this.rdoWindows.AutoSize = true;
			this.rdoWindows.Checked = true;
			this.rdoWindows.Location = new System.Drawing.Point(144, 186);
			this.rdoWindows.Name = "rdoWindows";
			this.rdoWindows.Size = new System.Drawing.Size(225, 24);
			this.rdoWindows.TabIndex = 5;
			this.rdoWindows.TabStop = true;
			this.rdoWindows.Text = "Chứng thực bằng windows";
			this.rdoWindows.UseVisualStyleBackColor = true;
			this.rdoWindows.CheckedChanged += new System.EventHandler(this.rdoWindows_CheckedChanged);
			// 
			// rdoSQLServer
			// 
			this.rdoSQLServer.AutoSize = true;
			this.rdoSQLServer.Location = new System.Drawing.Point(144, 216);
			this.rdoSQLServer.Name = "rdoSQLServer";
			this.rdoSQLServer.Size = new System.Drawing.Size(249, 24);
			this.rdoSQLServer.TabIndex = 6;
			this.rdoSQLServer.Text = "Chứng thực bằng SQL Server";
			this.rdoSQLServer.UseVisualStyleBackColor = true;
			this.rdoSQLServer.CheckedChanged += new System.EventHandler(this.rdoWindows_CheckedChanged);
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(80, 400);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(194, 35);
			this.btnConnect.TabIndex = 7;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(371, 400);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(194, 35);
			this.btnCancel.TabIndex = 7;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGreen;
			this.ClientSize = new System.Drawing.Size(667, 451);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.rdoSQLServer);
			this.Controls.Add(this.rdoWindows);
			this.Controls.Add(this.grbSQLServer);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.Red;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Connection";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.grbSQLServer.ResumeLayout(false);
			this.grbSQLServer.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNameServer;
        private System.Windows.Forms.TextBox txtNameDatabase;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grbSQLServer;
        private System.Windows.Forms.RadioButton rdoWindows;
        private System.Windows.Forms.RadioButton rdoSQLServer;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnCancel;
    }
}

