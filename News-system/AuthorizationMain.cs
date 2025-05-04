namespace News_System {
    public class AuthorizationMain {
        private readonly FileDataUsers _fileDataUsers;
        private readonly RegistrationMain _registrationMain;

        public AuthorizationMain(FileDataUsers fileDataProvider) {
            _fileDataUsers = fileDataProvider ?? throw new ArgumentNullException(nameof(fileDataProvider));
            _registrationMain = new RegistrationMain(_fileDataUsers);
        }

        /// <summary>
        /// Проверяет данные пользователя с использованием FileDataProvider.
        /// </summary>
        public bool Validate(string username, string password) {
            try {
                var storedPasswordHash = _fileDataUsers.GetUserPasswordHash(username);

                if (storedPasswordHash != null) {
                    string inputPasswordHash = _registrationMain.GeneratePasswordHash(password);
                    return _fileDataUsers.VerifyPassword(username, inputPasswordHash);
                }
                return false;
            }
            catch (Exception) {
                return false;
            }
        }
        /// <summary>
        /// Сохраняет имя пользователя в текущей сессии.
        /// </summary>
        public void RemindUser(string username) {
            CurrentUser.Login(username);
        }
    }
}
