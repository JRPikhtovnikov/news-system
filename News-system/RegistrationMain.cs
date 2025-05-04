using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace News_System {
    public class RegistrationMain {
        private readonly FileDataUsers _fileDataUsers;

        public RegistrationMain(FileDataUsers fileDataProvider) {
            _fileDataUsers = fileDataProvider ?? throw new ArgumentNullException(nameof(fileDataProvider));
        }

        /// <summary>
        /// Регистрирует нового пользователя с использованием FileDataProvider.
        /// </summary>
        /// <param name="username">Имя пользователя.</param>
        /// <param name="password">Пароль пользователя.</param>
        /// <param name="confirmPassword">Подтверждение пароля.</param>
        /// <returns>True, если регистрация успешна, иначе False.</returns>
        public bool RegisterUser(string username, string password, string confirmPassword) {
            string passwordHash = GeneratePasswordHash(password);

            try {
                _fileDataUsers.AddUser(username, passwordHash);
                return true;
            }
            catch (Exception) {
                return false;
            }
        }

        /// <summary>
        /// Генерация хэша пароля.
        /// </summary>
        /// <param name="password">Пароль пользователя.</param>
        /// <returns>Хэш пароля.</returns>
        public string GeneratePasswordHash(string password) {
            using (var sha256 = SHA256.Create()) {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }
    }
}
