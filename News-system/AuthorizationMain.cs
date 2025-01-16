using System;
using MySql.Data.MySqlClient;
using News_System;

namespace News_System {
    public class AuthorizationMain {
        private static DataBase _dataBase = new DataBase("localhost", "3306", "NewsSystem", "root", "root");
        private static string? _connectionString = _dataBase?.GetConnectionString(); // Проверяем на null
        private RegistrationMain _registrationMain = new RegistrationMain();

        /// <summary>
        /// Проверяет данные пользователя в базе данных и возвращает true, если они корректны.
        /// </summary>
        public bool ValidateLogin(string username, string password) {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) {
                throw new ArgumentException("Имя пользователя и пароль не могут быть пустыми.");
            }

            if (string.IsNullOrEmpty(_connectionString)) {
                throw new InvalidOperationException("Строка подключения не инициализирована.");
            }

            try {
                using (var connection = new MySqlConnection(_connectionString)) {
                    connection.Open();

                    // Запрос для проверки логина и пароля
                    string query = "SELECT PasswordHash FROM Users WHERE Username = @Username;";
                    using (var command = new MySqlCommand(query, connection)) {
                        command.Parameters.AddWithValue("@Username", username);

                        var result = command.ExecuteScalar();

                        if (result != null && result is string storedPasswordHash) {
                            // Сравниваем хэш введённого пароля с хэшем из базы данных
                            return VerifyPassword(password, storedPasswordHash);
                        }
                        else {
                            // Пользователь не найден
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex) {
                Console.WriteLine($"Ошибка при проверке логина: {ex.Message}");
                throw;
            }
        }

        public void RemindUser(string username) {
            CurrentUser.Login(username);
        }

        /// <summary>
        /// Генерация хэша пароля для сравнения.
        /// </summary>
        private bool VerifyPassword(string inputPassword, string storedHash) {
            if (_registrationMain == null) {
                throw new InvalidOperationException("RegistrationMain не инициализирован.");
            }

            // Здесь используется метод для сравнения хэшей.
            string inputHash = _registrationMain.GeneratePasswordHash(inputPassword);
            return inputHash == storedHash;
        }
    }
}
