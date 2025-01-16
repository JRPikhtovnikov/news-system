using MySql.Data.MySqlClient;

namespace News_System {
    public class AddNewsMain {
        private static readonly DataBase _dataBase = new DataBase("localhost", "3306", "NewsSystem", "root", "root");
        private readonly MySqlConnection _connection = new MySqlConnection(_dataBase.GetConnectionString());

        /// <summary>
        /// Добавляет новость в базу данных.
        /// </summary>
        public bool AddNews(string title, string description, string author, DateTime date) {
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(author)) {
                MessageBox.Show("Все поля обязательны для заполнения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (CheckNewsExists(title)) {
                MessageBox.Show("Новость с таким заголовком уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try {
                using (_connection) {
                    _connection.Open();

                    string insertQuery = "INSERT INTO news (title, description, author, publish_date) VALUES (@Title, @Description, @Author, @PublishDate);";
                    using (var command = new MySqlCommand(insertQuery, _connection)) {
                        command.Parameters.AddWithValue("@Title", title);
                        command.Parameters.AddWithValue("@Description", description);
                        command.Parameters.AddWithValue("@Author", author);
                        command.Parameters.AddWithValue("@PublishDate", date);

                        int rowsInserted = command.ExecuteNonQuery();
                        return rowsInserted > 0; // Возвращает True, если новость успешно добавлена
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Ошибка при добавлении новости: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Проверяет, существует ли новость с данным заголовком.
        /// </summary>
        public bool CheckNewsExists(string title) {
            try {
                using (_connection) {
                    _connection.Open();

                    string checkQuery = "SELECT COUNT(*) FROM news WHERE title = @Title;";
                    using (var command = new MySqlCommand(checkQuery, _connection)) {
                        command.Parameters.AddWithValue("@Title", title);

                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count > 0; // Возвращает True, если новость с таким заголовком уже существует
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Ошибка проверки новости: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
