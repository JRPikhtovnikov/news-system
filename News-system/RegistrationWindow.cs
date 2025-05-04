using News_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace News_System {
    public partial class RegistrationWindow : Form {

        private static readonly FileDataUsers _fileDataUsers = new FileDataUsers();
        private static AuthorizationMain _authorizationMain = new AuthorizationMain(_fileDataUsers);
        private static RegistrationMain _registrationMain = new RegistrationMain(_fileDataUsers);
        private AuthorizationWindow _authorizationWindow = new AuthorizationWindow(_authorizationMain);
        private string _username = "";
        private string _password = "";
        private string _confirmPassword = "";

        public RegistrationWindow(RegistrationMain registration) {
            _registrationMain = registration;
            InitializeComponent();
        }

        public bool ValidatePlaceHolders() {

            _username = tb_username.Text.Trim();
            _password = tb_password.Text.Trim();
            _confirmPassword = tb_confirm_password.Text.Trim();

            if (string.IsNullOrEmpty(_username) || string.IsNullOrEmpty(_password)) {
                MessageBox.Show("Все поля обязательны для заполнения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!string.Equals(_password, _confirmPassword)) {
                MessageBox.Show("Пароли не совпадают.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (_fileDataUsers.UserExists(_username)) {
                MessageBox.Show("Имя пользователя уже занято.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btn_register_Click(object sender, EventArgs e) {

            if (ValidatePlaceHolders()) {
                if (_registrationMain.RegisterUser(_username, _password, _confirmPassword)) {
                    MessageBox.Show("Регистрация успешна!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _authorizationWindow.Show();
                    _fileDataUsers.LoadUsersFromFile();
                    Close();
                }
                else {
                    MessageBox.Show("Ошибка регистрации!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e) {
            Close();
            _authorizationWindow.Show();
        }
    }
}
