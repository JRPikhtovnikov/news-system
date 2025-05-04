namespace News_System {
    public class NewsMain {
        private readonly FileDataNews _fileDataNews;

        public NewsMain(FileDataNews fileDataProvider) {
            _fileDataNews = fileDataProvider ?? throw new ArgumentNullException(nameof(fileDataProvider));
        }

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
        /// Получает все заголовки новостей.
        /// </summary>
        public List<string> GetAllNewsTitles() {
            var news = _fileDataNews.GetNews();
            var newsTitles = new List<string>();

            foreach (var item in news) {
                newsTitles.Add(item.GetTitle());  // Используем GetTitle для получения заголовка
            }
            return newsTitles;
        }
        /// <summary>
        /// Получает подробности новости по её заголовку.
        /// </summary>
        public (string Title, string Description, string Votes, string Author, string Date) GetNewsDetails(string title) {

            var news = _fileDataNews.GetNews();
            var selectedNews = news.FirstOrDefault(n => n.GetTitle() == title);

            if (selectedNews != null) {
                return (
                    selectedNews.GetTitle(),
                    selectedNews.GetDescription(),
                    selectedNews.GetVotes().ToString(),
                    selectedNews.GetAuthor(),
                    selectedNews.GetDate().ToString("yyyy-MM-dd")
                );
            }
            
            return (string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }

        /// <summary>
        /// Увеличивает количество голосов для указанной новости.
        /// </summary>
        public bool IncreaseVote(string title) {
            try {
                var newsList = _fileDataNews.GetNews();
                var selectedNews = newsList.FirstOrDefault(n => n.GetTitle().Equals(title, StringComparison.OrdinalIgnoreCase));

                selectedNews.Upvote();
                _fileDataNews.SaveNews(newsList);
                return true;
            }
            catch (Exception) {   
            }

            return false;
        }
        /// <summary>
        /// Выыод список лучших новостей
        /// </summary>
        /// <param name="lb_news"></param>
        public void LoadTopNews(ListBox lb_news) {
            try {
                var newsList = _fileDataNews.GetNews();

                var topNews = newsList.OrderByDescending(n => n.GetVotes()).Take(7).ToList();

                lb_news.Items.Clear();

                foreach (var news in topNews) {
                    lb_news.Items.Add(news.GetTitle());
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Ошибка при загрузке лучших новостей: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Получает текущее количество голосов для указанной новости.
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public int GetVotes(string title) {
            var newsList = _fileDataNews.GetNews();
            var selectedNews = newsList.FirstOrDefault(n => n.GetTitle().Equals(title, StringComparison.OrdinalIgnoreCase));

            return selectedNews != null ? selectedNews.GetVotes() : 0;
        }

    }
}
