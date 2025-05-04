namespace News_System {
    partial class RegistrationWindow {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationWindow));
            labelUsername = new Label();
            tb_username = new TextBox();
            labelPassword = new Label();
            tb_password = new TextBox();
            labelConfirmPassword = new Label();
            tb_confirm_password = new TextBox();
            btn_register = new Button();
            btn_cancel = new Button();
            SuspendLayout();
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(12, 20);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(109, 15);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "Имя пользователя";
            // 
            // tb_username
            // 
            tb_username.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tb_username.Location = new Point(140, 17);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(128, 23);
            tb_username.TabIndex = 1;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(12, 60);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(49, 15);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Пароль";
            // 
            // tb_password
            // 
            tb_password.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tb_password.Location = new Point(140, 57);
            tb_password.Name = "tb_password";
            tb_password.PasswordChar = '*';
            tb_password.Size = new Size(128, 23);
            tb_password.TabIndex = 3;
            // 
            // labelConfirmPassword
            // 
            labelConfirmPassword.AutoSize = true;
            labelConfirmPassword.Location = new Point(12, 100);
            labelConfirmPassword.Name = "labelConfirmPassword";
            labelConfirmPassword.Size = new Size(120, 15);
            labelConfirmPassword.TabIndex = 4;
            labelConfirmPassword.Text = "Подтвердите пароль";
            // 
            // tb_confirm_password
            // 
            tb_confirm_password.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tb_confirm_password.Location = new Point(140, 97);
            tb_confirm_password.Name = "tb_confirm_password";
            tb_confirm_password.PasswordChar = '*';
            tb_confirm_password.Size = new Size(128, 23);
            tb_confirm_password.TabIndex = 5;
            // 
            // btn_register
            // 
            btn_register.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_register.Location = new Point(81, 138);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(96, 30);
            btn_register.TabIndex = 6;
            btn_register.Text = "Регистрация";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cancel.Location = new Point(192, 138);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(75, 30);
            btn_cancel.TabIndex = 7;
            btn_cancel.Text = "Отмена";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // RegistrationWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 190);
            Controls.Add(btn_cancel);
            Controls.Add(btn_register);
            Controls.Add(tb_confirm_password);
            Controls.Add(labelConfirmPassword);
            Controls.Add(tb_password);
            Controls.Add(labelPassword);
            Controls.Add(tb_username);
            Controls.Add(labelUsername);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegistrationWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.TextBox tb_confirm_password;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_cancel;
    }
}