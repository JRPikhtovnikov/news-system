using System;
using System.Windows.Forms;

namespace News_System {
    public partial class AuthorizationWindow : Form {
        private readonly AuthorizationMain _authorization;
        private readonly RegistrationMain _registration;
        private static readonly FileDataUsers _fileDataUsers = new FileDataUsers();

        public AuthorizationWindow(AuthorizationMain authorization) {
            InitializeComponent();
            _authorization = authorization;
            _registration = new RegistrationMain(_fileDataUsers);
        }

        private void btn_login_Click(object sender, EventArgs e) {
            string username = tb_username.Text;
            string password = tb_password.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) {
                MessageBox.Show("Введите имя пользователя и пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try {
                if (_authorization.Validate(username, password)) {
                    MessageBox.Show("Вход выполнен успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _authorization.RemindUser(username);

                    var mainWindow = new MainWindow();
                    mainWindow.Show();
                    Hide();
                }
                else {
                    MessageBox.Show("Неверный логин или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Ошибка при авторизации: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_register_Click(object sender, EventArgs e) {
            var registrationWindow = new RegistrationWindow(_registration);
            registrationWindow.Show();
            Hide();
        }
    }
}
