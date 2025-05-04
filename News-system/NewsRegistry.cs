namespace News_System {
    public class NewsRegistry {
        private readonly FileDataNews _fileDataNews;

        public NewsRegistry(FileDataNews fileDataProvider) {
            _fileDataNews = fileDataProvider;
        }

        /// <summary>
        /// Добавляет новость в файл.
        /// </summary>
        public bool AddNews(string title, string description, string author, DateTime date) {
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(author)) {
                return false;
            }

            if (CheckNewsExists(title)) { return false; }

            try {
                News newNews = new News(title, date, author, description);
                _fileDataNews.AddNews(newNews);
                return true;
            }
            catch (Exception) { return false; }
        }

        /// <summary>
        /// Проверяет, существует ли новость с данным заголовком.
        /// </summary>
        public bool CheckNewsExists(string title) {
            try {
                var news = _fileDataNews.GetNews();
                return news.Any(item => item.GetTitle().Equals(title, StringComparison.OrdinalIgnoreCase));
            }
            catch (Exception) {
                return false;
            }
        }
    }
}
