using System;
using MySql.Data.MySqlClient;
using static System.Console;

namespace News_System {
    public class RegistrationMain {

        private static readonly DataBase _dataBase = new DataBase("localhost", "3306", "NewsSystem", "root", "root");
        private readonly MySqlConnection _connection = new MySqlConnection(_connectionString);
        private static readonly string? _connectionString = _dataBase.GetConnectionString();
        private string _passwordHash = "";

        /// <summary>
        /// Регистрирует нового пользователя в базе данных.
        /// </summary>
        /// <param name="username">Имя пользователя.</param>
        /// <param name="passwordHash">Хэш пароля.</param>
        /// <param name="email">Email пользователя.</param>
        /// <returns>True, если регистрация успешна, иначе False.</returns>
        public bool RegisterUser(string username, string password, string confirmPassword) {
            // Проверка обязательных полей
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) {
                MessageBox.Show("Все поля обязательны для заполнения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!string.Equals(password, confirmPassword)) {
                MessageBox.Show("Пароли не совпадают.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            _passwordHash = GeneratePasswordHash(password);

            try {
                using (_connection) {
                    _connection.Open();

                    // Проверка существования пользователя с таким именем
                    CheckExist(username);

                    // Добавление нового пользователя
                    string insertQuery = "INSERT INTO Users (Username, PasswordHash) VALUES (@Username, @PasswordHash);";
                    using (var insertCommand = new MySqlCommand(insertQuery, _connection)) {
                        insertCommand.Parameters.AddWithValue("@Username", username);
                        insertCommand.Parameters.AddWithValue("@PasswordHash", _passwordHash);

                        int rowsInserted = insertCommand.ExecuteNonQuery();
                        return rowsInserted > 0;
                    }
                }
            }
            catch (Exception) {
                return false;
            }
        }
        /// <summary>
        /// Проверка логина на существование.
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        private bool CheckExist(string username) {
            string checkUserQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username;";
            using (var checkCommand = new MySqlCommand(checkUserQuery, _connection)) {
                checkCommand.Parameters.AddWithValue("@Username", username);

                int count = Convert.ToInt32(checkCommand.ExecuteScalar());
                if (count > 0) {
                    MessageBox.Show("Имя пользователя уже занято.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; // Пользователь уже существует
                }
            }
            return true;
        }

        /// <summary>
        /// Генерация хэша пароля.
        /// </summary>
        /// <param name="password">Пароль пользователя.</param>
        /// <returns>Хэш пароля.</returns>
        public string GeneratePasswordHash(string password) {
            using (var sha256 = System.Security.Cryptography.SHA256.Create()) {
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }
    }
}
