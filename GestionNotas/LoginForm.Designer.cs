namespace GestionNotas
{
    partial class LoginForm
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
            panel1 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            Iniciosesion = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            txtUsername = new System.Windows.Forms.TextBox();
            panel3 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            btnLogin = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(258, 450);
            panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(12, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(198, 239);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Iniciosesion
            // 
            Iniciosesion.AutoSize = true;
            Iniciosesion.BackColor = System.Drawing.Color.LightGray;
            Iniciosesion.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Iniciosesion.ForeColor = System.Drawing.Color.DarkSlateBlue;
            Iniciosesion.Location = new System.Drawing.Point(398, 21);
            Iniciosesion.Name = "Iniciosesion";
            Iniciosesion.Size = new System.Drawing.Size(208, 25);
            Iniciosesion.TabIndex = 11;
            Iniciosesion.Text = "INICIAR SESION";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = System.Drawing.Color.Gainsboro;
            txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            txtPassword.Location = new System.Drawing.Point(369, 210);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(237, 26);
            txtPassword.TabIndex = 9;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = System.Drawing.Color.Gainsboro;
            txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtUsername.ForeColor = System.Drawing.Color.Black;
            txtUsername.Location = new System.Drawing.Point(369, 161);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(272, 27);
            txtUsername.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.DarkSlateBlue;
            panel3.Location = new System.Drawing.Point(361, 235);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(293, 1);
            panel3.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            panel2.Location = new System.Drawing.Point(361, 187);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(293, 1);
            panel2.TabIndex = 15;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(318, 150);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(37, 38);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(318, 198);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(37, 38);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = System.Drawing.Color.DarkSlateBlue;
            btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogin.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnLogin.ForeColor = System.Drawing.Color.Gainsboro;
            btnLogin.Location = new System.Drawing.Point(398, 292);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(214, 39);
            btnLogin.TabIndex = 18;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Gainsboro;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(Iniciosesion);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(panel1);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Iniciosesion;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnLogin;
    }
}