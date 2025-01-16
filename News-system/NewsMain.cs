using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace News_System {
    public class NewsMain {
        private static readonly DataBase _dataBase = new DataBase("localhost", "3306", "NewsSystem", "root", "root");
        private static readonly string? _connectionString = _dataBase.GetConnectionString();

        /// <summary>
        /// Загружает заголовки новостей в ListBox.
        /// </summary>
        public void LoadNewsTitles(ListBox lb_news) {
            lb_news.Items.Clear();
            var newsTitles = GetAllNewsTitles();

            foreach (var title in newsTitles) {
                lb_news.Items.Add(title);
            }
        }

        /// <summary>
        /// Получает все заголовки новостей из базы данных.
        /// </summary>
        public List<string> GetAllNewsTitles() {
            var newsTitles = new List<string>();

            try {
                using (var connection = new MySqlConnection(_connectionString)) {
                    connection.Open();

                    string query = "SELECT Title FROM News;";
                    using (var command = new MySqlCommand(query, connection)) {
                        using (var reader = command.ExecuteReader()) {
                            while (reader.Read()) {
                                newsTitles.Add(reader.GetString("Title"));
                            }
                        }
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Ошибка при загрузке новостей: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return newsTitles;
        }

        /// <summary>
        /// Получает подробности новости по её заголовку.
        /// </summary>
        public (string Title, string Description, string Votes, string Author, string Date) GetNewsDetails(string title) {
            try {
                using (var connection = new MySqlConnection(_connectionString)) {
                    connection.Open();

                    string query = "SELECT Title, Description, Votes, Author, Publish_date FROM News WHERE Title = @Title;";
                    using (var command = new MySqlCommand(query, connection)) {
                        command.Parameters.AddWithValue("@Title", title);

                        using (var reader = command.ExecuteReader()) {
                            if (reader.Read()) {
                                return (reader.GetString("Title"), reader.GetString("Description"), 
                                    reader.GetString("Votes"), reader.GetString("Author"), reader.GetString("Publish_date").Substring(0, 10));
                            }
                        }
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Ошибка при загрузке подробностей новости: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return (string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }

        /// <summary>
        /// Увеличивает количество голосов для указанной новости.
        /// </summary>
        /// <param name="newsId">Идентификатор новости.</param>
        /// <returns>True, если голос был успешно увеличен, иначе False.</returns>
        public bool IncreaseVote(int newsId) {
            try {
                using (var connection = new MySqlConnection(_connectionString)) {
                    connection.Open();

                    string query = "UPDATE News SET Votes = Votes + 1 WHERE news_id = @news_id;";
                    using (var command = new MySqlCommand(query, connection)) {
                        command.Parameters.AddWithValue("@news_id", newsId);

                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"Rows Affected: {rowsAffected}"); // Диагностика
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex) {
                Console.WriteLine($"Ошибка при увеличении голосов: {ex.Message}");
                return false;
            }
        }


        /// <summary>
        /// Получает текущее количество голосов для указанной новости.
        /// </summary>
        /// <param name="newsId">Идентификатор новости.</param>
        /// <returns>Количество голосов.</returns>
        public int GetVotes(int newsId) {
            try {
                using (var connection = new MySqlConnection(_connectionString)) {
                    connection.Open();

                    // Получение текущего количества голосов
                    string query = "SELECT Votes FROM News WHERE news_id = @news_id;";
                    using (var command = new MySqlCommand(query, connection)) {
                        command.Parameters.AddWithValue("@news_id", newsId);

                        var result = command.ExecuteScalar();
                        return result != null ? Convert.ToInt32(result) : 0;
                    }
                }
            }
            catch (Exception ex) {
                Console.WriteLine($"Ошибка при получении голосов: {ex.Message}");
                return 0;
            }
        }

        /// <summary>
        /// Получает ID новости по её заголовку из базы данных.
        /// </summary>
        public int GetSelectedNewsId(string title) {
            try {
                using (var connection = new MySqlConnection(new DataBase("localhost", "3306", "NewsSystem", "root", "root").GetConnectionString())) {
                    connection.Open();

                    string query = "SELECT news_id FROM News WHERE Title = @Title;";
                    using (var command = new MySqlCommand(query, connection)) {
                        command.Parameters.AddWithValue("@Title", title);

                        var result = command.ExecuteScalar();
                        Console.WriteLine($"Title: {title}, news_id: {result}"); // Диагностика
                        return result != null ? Convert.ToInt32(result) : 0;
                    }
                }
            }
            catch (Exception ex) {
                Console.WriteLine($"Ошибка при получении ID новости: {ex.Message}");
                return 0;
            }
        }
    }
}
