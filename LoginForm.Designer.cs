using System;
using System.Windows.Forms;

namespace GestionNotas
{
    partial class LoginForm : Form

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureUser = new PictureBox();
            btnLogin = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            picturePass = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            Iniciosesion = new Label();
            minimizarimg = new PictureBox();
            Cerrarimg = new PictureBox();
            minimaxiimg = new PictureBox();
            linkLabel1 = new LinkLabel();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picturePass).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minimizarimg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Cerrarimg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minimaxiimg).BeginInit();
            SuspendLayout();
            // 
            // pictureUser
            // 
            pictureUser.Image = (System.Drawing.Image)resources.GetObject("pictureUser.Image");
            pictureUser.Location = new System.Drawing.Point(374, 123);
            pictureUser.Margin = new Padding(5, 6, 5, 6);
            pictureUser.Name = "pictureUser";
            pictureUser.Size = new System.Drawing.Size(45, 45);
            pictureUser.SizeMode = PictureBoxSizeMode.Zoom;
            pictureUser.TabIndex = 0;
            pictureUser.TabStop = false;
            pictureUser.Click += pictureBox1_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = System.Drawing.Color.SlateBlue;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnLogin.Location = new System.Drawing.Point(415, 282);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(221, 32);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Log In\r\n";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.UseWaitCursor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = System.Drawing.Color.Gainsboro;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Cursor = Cursors.IBeam;
            txtUsername.ForeColor = System.Drawing.Color.Black;
            txtUsername.Location = new System.Drawing.Point(427, 141);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(237, 27);
            txtUsername.TabIndex = 0;
            txtUsername.TextChanged += txtUsername_TextChanged;
            txtUsername.MouseEnter += txtUsername_MouseEnter;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = System.Drawing.Color.Gainsboro;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            txtPassword.Location = new System.Drawing.Point(425, 192);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(211, 26);
            txtPassword.TabIndex = 1;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // picturePass
            // 
            picturePass.BackgroundImageLayout = ImageLayout.None;
            picturePass.Image = (System.Drawing.Image)resources.GetObject("picturePass.Image");
            picturePass.Location = new System.Drawing.Point(374, 180);
            picturePass.Name = "picturePass";
            picturePass.Size = new System.Drawing.Size(45, 45);
            picturePass.SizeMode = PictureBoxSizeMode.Zoom;
            picturePass.TabIndex = 5;
            picturePass.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(258, 450);
            panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(12, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(198, 239);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Iniciosesion
            // 
            Iniciosesion.AutoSize = true;
            Iniciosesion.BackColor = System.Drawing.Color.LightGray;
            Iniciosesion.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Iniciosesion.ForeColor = System.Drawing.Color.DarkSlateBlue;
            Iniciosesion.Location = new System.Drawing.Point(410, 9);
            Iniciosesion.Name = "Iniciosesion";
            Iniciosesion.Size = new System.Drawing.Size(208, 25);
            Iniciosesion.TabIndex = 7;
            Iniciosesion.Text = "INICIAR SESION";
            // 
            // minimizarimg
            // 
            minimizarimg.Image = (System.Drawing.Image)resources.GetObject("minimizarimg.Image");
            minimizarimg.Location = new System.Drawing.Point(729, 0);
            minimizarimg.Name = "minimizarimg";
            minimizarimg.Size = new System.Drawing.Size(20, 20);
            minimizarimg.SizeMode = PictureBoxSizeMode.Zoom;
            minimizarimg.TabIndex = 9;
            minimizarimg.TabStop = false;
            minimizarimg.Click += minimizarimg_Click;
            // 
            // Cerrarimg
            // 
            Cerrarimg.Image = (System.Drawing.Image)resources.GetObject("Cerrarimg.Image");
            Cerrarimg.Location = new System.Drawing.Point(781, 0);
            Cerrarimg.Name = "Cerrarimg";
            Cerrarimg.Size = new System.Drawing.Size(20, 20);
            Cerrarimg.SizeMode = PictureBoxSizeMode.Zoom;
            Cerrarimg.TabIndex = 10;
            Cerrarimg.TabStop = false;
            Cerrarimg.Click += Cerrarimg_Click;
            // 
            // minimaxiimg
            // 
            minimaxiimg.Image = (System.Drawing.Image)resources.GetObject("minimaxiimg.Image");
            minimaxiimg.Location = new System.Drawing.Point(755, 0);
            minimaxiimg.Name = "minimaxiimg";
            minimaxiimg.Size = new System.Drawing.Size(20, 20);
            minimaxiimg.SizeMode = PictureBoxSizeMode.Zoom;
            minimaxiimg.TabIndex = 11;
            minimaxiimg.TabStop = false;
            minimaxiimg.Click += minimaxiimg_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new System.Drawing.Point(400, 331);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(246, 24);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "¿Has olvidado tu contraseña?";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            panel2.Location = new System.Drawing.Point(374, 167);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(293, 1);
            panel2.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.DarkSlateBlue;
            panel3.Location = new System.Drawing.Point(374, 224);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(293, 1);
            panel3.TabIndex = 14;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Gainsboro;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(linkLabel1);
            Controls.Add(minimaxiimg);
            Controls.Add(Cerrarimg);
            Controls.Add(minimizarimg);
            Controls.Add(Iniciosesion);
            Controls.Add(panel1);
            Controls.Add(picturePass);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnLogin);
            Controls.Add(pictureUser);
            Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            ForeColor = System.Drawing.Color.CadetBlue;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 6, 5, 6);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)picturePass).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)minimizarimg).EndInit();
            ((System.ComponentModel.ISupportInitialize)Cerrarimg).EndInit();
            ((System.ComponentModel.ISupportInitialize)minimaxiimg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox picturePass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Iniciosesion;
        private System.Windows.Forms.PictureBox minimizarimg;
        private System.Windows.Forms.PictureBox Cerrarimg;
        private System.Windows.Forms.PictureBox minimaxiimg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}