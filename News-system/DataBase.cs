using System;
using System.Data;
using MySql.Data.MySqlClient;
using static System.Console;

namespace News_System {
    public class DataBase {
        // Поля
        private MySqlConnection _connection;
        private string _connectionString;

        // Конструктор
        public DataBase(string server, string port, string database, string username, string password) {
            _connectionString = $"server={server};port={port};database={database};username={username};password={password};";
            _connection = new MySqlConnection(_connectionString);
        }

        // Свойство: Статус подключения
        public bool IsConnected {
            get { return _connection.State == ConnectionState.Open; }
        }

        // Метод: Открытие соединения
        public void OpenConnection() {
            try {
                if (_connection.State == ConnectionState.Closed) {
                    _connection.Open();
                    WriteLine("Соединение с базой данных успешно установлено.");
                }
            }
            catch (Exception ex) {
                WriteLine($"Ошибка подключения к базе данных: {ex.Message}");
                throw;
            }
        }

        // Метод: Закрытие соединения
        public void CloseConnection() {
            try {
                if (_connection.State == ConnectionState.Open) {
                    _connection.Close();
                    WriteLine("Соединение с базой данных закрыто.");
                }
            }
            catch (Exception ex) {
                WriteLine($"Ошибка закрытия соединения: {ex.Message}");
                throw;
            }
        }

        // Метод: Выполнение SQL-команды без возвращаемого значения (INSERT, UPDATE, DELETE)
        public int ExecuteNonQuery(string query, params MySqlParameter[] parameters) {
            try {
                using (var command = new MySqlCommand(query, _connection)) {
                    if (parameters != null) {
                        command.Parameters.AddRange(parameters);
                    }
                    return command.ExecuteNonQuery();
                }
            }
            catch (Exception ex) {
                WriteLine($"Ошибка выполнения команды: {ex.Message}");
                throw;
            }
        }

        // Метод: Выполнение SQL-команды с возвращением одного значения (например, COUNT, MAX)
        public object ExecuteScalar(string query, params MySqlParameter[] parameters) {
            try {
                using (var command = new MySqlCommand(query, _connection)) {
                    if (parameters != null) {
                        command.Parameters.AddRange(parameters);
                    }
                    return command.ExecuteScalar();
                }
            }
            catch (Exception ex) {
                WriteLine($"Ошибка выполнения команды: {ex.Message}");
                throw;
            }
        }

        // Метод: Выполнение SQL-команды с возвращением результата (SELECT)
        public DataTable ExecuteQuery(string query, params MySqlParameter[] parameters) {
            try {
                using (var command = new MySqlCommand(query, _connection)) {
                    if (parameters != null) {
                        command.Parameters.AddRange(parameters);
                    }

                    using (var adapter = new MySqlDataAdapter(command)) {
                        var dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
            catch (Exception ex) {
                WriteLine($"Ошибка выполнения запроса: {ex.Message}");
                throw;
            }
        }

        public string GetConnectionString() { 
            return _connectionString;
        }
    }
}
