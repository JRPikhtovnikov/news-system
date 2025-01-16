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


namespace News_System {
    public partial class RegistrationWindow : Form {

        private static AuthorizationMain _authorizationMain = new AuthorizationMain();
        private static RegistrationMain _registrationMain = new RegistrationMain();
        private AuthorizationWindow _authorizationWindow = new AuthorizationWindow(_authorizationMain);
        private string _username = "";
        private string _password = "";
        private string _confirmPassword = "";

        public RegistrationWindow(RegistrationMain registration) {
            _registrationMain = registration;
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e) {

            // Получение данных из текстовых полей
            _username = tb_username.Text.Trim();
            _password = tb_password.Text.Trim();
            _confirmPassword = tb_confirm_password.Text.Trim();

            // Вызов функции регистрации
            if (_registrationMain.RegisterUser(_username, _password, _confirmPassword)) {
                MessageBox.Show("Регистрация успешна!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _authorizationWindow.ShowDialog();
                this.Close(); // Закрыть окно регистрации
            }
            else {
                MessageBox.Show("Ошибка регистрации. Проверьте введённые данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e) {
            this.Close();
            _authorizationWindow.ShowDialog();
        }
    }
}
