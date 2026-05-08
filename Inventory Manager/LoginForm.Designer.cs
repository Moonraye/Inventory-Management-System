namespace Inventory_Manager
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
            emailLabel = new Label();
            passwordLabel = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 14F);
            emailLabel.ForeColor = Color.White;
            emailLabel.Location = new Point(304, 172);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(58, 25);
            emailLabel.TabIndex = 0;
            emailLabel.Text = "Email";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 14F);
            passwordLabel.ForeColor = Color.White;
            passwordLabel.Location = new Point(509, 172);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(91, 25);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 14F);
            txtEmail.Location = new Point(226, 199);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(216, 32);
            txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14F);
            txtPassword.Location = new Point(456, 199);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(208, 32);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(174, 153, 117);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 14F);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(271, 248);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(144, 38);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.FlatAppearance.BorderColor = Color.FromArgb(174, 153, 117);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 14F);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(484, 248);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(144, 38);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 22, 22);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(passwordLabel);
            panel1.Controls.Add(emailLabel);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(btnRegister);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 484);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 350);
            panel2.Name = "panel2";
            panel2.Size = new Size(884, 134);
            panel2.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(385, 135);
            label1.Name = "label1";
            label1.Size = new Size(135, 37);
            label1.TabIndex = 6;
            label1.Text = "Welcome!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(367, 10);
            label2.Name = "label2";
            label2.Size = new Size(165, 15);
            label2.TabIndex = 0;
            label2.Text = "Password may be 8 characters";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 484);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(900, 523);
            MinimumSize = new Size(900, 523);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Label emailLabel;
        public Label passwordLabel;
        public TextBox txtEmail;
        public TextBox txtPassword;
        public Button btnLogin;
        public Button btnRegister;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
    }
}