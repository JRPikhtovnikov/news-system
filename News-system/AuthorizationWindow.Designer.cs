namespace News_System {
    partial class AuthorizationWindow {
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
            labelUsername = new Label();
            tb_username = new TextBox();
            labelPassword = new Label();
            tb_password = new TextBox();
            btn_login = new Button();
            btn_register = new Button();
            SuspendLayout();
            // 
            // labelUsername
            // 
            labelUsername.Anchor = AnchorStyles.None;
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(17, 89);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(109, 15);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "Имя пользователя";
            // 
            // tb_username
            // 
            tb_username.Anchor = AnchorStyles.None;
            tb_username.Location = new Point(17, 109);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(240, 23);
            tb_username.TabIndex = 1;
            // 
            // labelPassword
            // 
            labelPassword.Anchor = AnchorStyles.None;
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(17, 149);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(49, 15);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Пароль";
            // 
            // tb_password
            // 
            tb_password.Anchor = AnchorStyles.None;
            tb_password.Location = new Point(17, 169);
            tb_password.Name = "tb_password";
            tb_password.PasswordChar = '●';
            tb_password.Size = new Size(240, 23);
            tb_password.TabIndex = 3;
            // 
            // btn_login
            // 
            btn_login.Anchor = AnchorStyles.None;
            btn_login.Location = new Point(17, 219);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(115, 30);
            btn_login.TabIndex = 4;
            btn_login.Text = "Войти";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // btn_register
            // 
            btn_register.Anchor = AnchorStyles.None;
            btn_register.Location = new Point(142, 219);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(115, 30);
            btn_register.TabIndex = 5;
            btn_register.Text = "Регистрация";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // AuthorizationWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 301);
            Controls.Add(btn_register);
            Controls.Add(btn_login);
            Controls.Add(tb_password);
            Controls.Add(labelPassword);
            Controls.Add(tb_username);
            Controls.Add(labelUsername);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AuthorizationWindow";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_register;
    }
}