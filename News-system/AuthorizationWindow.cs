using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using News_System;

namespace News_System {
    public partial class AuthorizationWindow : Form {
        private AuthorizationMain _authorization;
        private RegistrationMain _registration;

        public AuthorizationWindow(AuthorizationMain authorization) {

            _authorization = authorization;
            _registration = new RegistrationMain(); // Инициализируем объект RegistrationMain
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e) {
            // Проверка ввода логина и пароля
            if (string.IsNullOrEmpty(tb_username.Text) || string.IsNullOrEmpty(tb_password.Text)) {
                MessageBox.Show("Введите имя пользователя и пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка данных авторизации
            if (_authorization.ValidateLogin(tb_username.Text, tb_password.Text)) {
                MessageBox.Show("Вход выполнен успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _authorization.RemindUser(tb_username.Text);
                // Открытие главного окна
                var mainWindow = new MainWindow();
                mainWindow.Show();
                Hide();
            }
            else {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_register_Click(object sender, EventArgs e) {
            // Открыть окно регистрации
            var registrationWindow = new RegistrationWindow(_registration);
            registrationWindow.Show();
            Hide();
        }
    }
}
