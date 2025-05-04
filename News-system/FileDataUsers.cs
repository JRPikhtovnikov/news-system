using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace News_System {
    public class FileDataUsers {
        private readonly string _usersFilePath = "../../../users.txt";
        private List<string[]> _users;

        /// <summary>
        /// Конструктор, который загружает пользователей из файла при создании объекта.
        /// </summary>
        public FileDataUsers() {
            _users = new List<string[]>();
            LoadUsersFromFile();
        }

        public void LoadUsersFromFile() {
            if (File.Exists(_usersFilePath)) {
                foreach (var line in File.ReadAllLines(_usersFilePath)) {
                    if (!string.IsNullOrWhiteSpace(line)) {
                        _users.Add(line.Split('|'));
                    }
                }
            }
        }
        /// <summary>
        /// Сохраняет данные в файл пользователей.
        /// </summary>
        public void SaveUsers() {
            using (var writer = new StreamWriter(_usersFilePath, false)) {
                foreach (var user in _users) {
                    writer.WriteLine(string.Join('|', user));
                }
            }
        }

        /// <summary>
        /// Проверяет существование пользователя по имени.
        /// </summary>
        public bool UserExists(string username) {
            return _users.Any(user => user[0].Equals(username, StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Добавляет нового пользователя в список и сохраняет изменения в файл.
        /// </summary>
        public void AddUser(string username, string passwordHash) {
            if (string.IsNullOrWhiteSpace(username)) throw new ArgumentException("Имя пользователя не может быть пустым.", nameof(username));
            if (string.IsNullOrWhiteSpace(passwordHash)) throw new ArgumentException("Хэш пароля не может быть пустым.", nameof(passwordHash));

            if (UserExists(username)) {
                throw new InvalidOperationException($"Пользователь с именем \"{username}\" уже существует.");
            }

            _users.Add(new string[] { username, passwordHash });
            SaveUsers();
        }

        /// <summary>
        /// Получает пользователя по имени.
        /// </summary>
        public string[] GetUserByUsername(string username) {
            if (string.IsNullOrWhiteSpace(username)) return null;

            return _users.FirstOrDefault(user => user[0].Equals(username, StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Проверяет соответствие хэша пароля пользователя.
        /// </summary>
        public bool VerifyPassword(string username, string inputPasswordHash) {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(inputPasswordHash)) return false;

            var user = GetUserByUsername(username);
            if (user != null) {
                return user[1] == inputPasswordHash;
            }
            return false;
        }

        /// <summary>
        /// Получает хэш пароля пользователя по имени.
        /// </summary>
        public string GetUserPasswordHash(string username) {
            if (string.IsNullOrWhiteSpace(username)) return null;

            var user = GetUserByUsername(username);
            return user != null ? user[1] : null;
        }
    }
}
