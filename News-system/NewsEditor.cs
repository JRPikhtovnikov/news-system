using System;
using System.Linq;
using System.Windows.Forms;

namespace News_System {
    public class NewsEditor {
        private readonly FileDataNews _fileDataNews;
        private readonly CurrentUser _currentUser;

        public NewsEditor(FileDataNews fileDataProvider, CurrentUser currentUser) {
            _fileDataNews = fileDataProvider ?? throw new ArgumentNullException(nameof(fileDataProvider));
            _currentUser = currentUser ?? throw new ArgumentNullException(nameof(currentUser));
        }

        /// <summary>
        /// Редактирует новость, если текущий пользователь является её автором.
        /// </summary>
        public bool EditNews(string title, string newTitle, string newDescription) {
            try {
                var newsList = _fileDataNews.GetNews();
                var selectedNews = newsList.FirstOrDefault(n => n.GetTitle().Equals(title, StringComparison.OrdinalIgnoreCase));

                if (selectedNews != null) {
                    if (selectedNews.GetAuthor() == _currentUser.GetUsername()) {
                        selectedNews.SetTitle(newTitle);
                        selectedNews.SetDescription(newDescription);
                        _fileDataNews.SaveNews(newsList);
                        return true;
                    }
                    else {
                        return false; 
                    }
                }
                return false;
            }
            catch (Exception) {
                return false;
            }
        }

        /// <summary>
        /// Получает подробности новости по заголовку.
        /// </summary>
        public (string Title, string Description, string Author, string Date) GetNewsDetails(string title) {
            try {
                var newsList = _fileDataNews.GetNews();
                var selectedNews = newsList.FirstOrDefault(n => n.GetTitle().Equals(title, StringComparison.OrdinalIgnoreCase));

                if (selectedNews != null) {
                    return (
                        selectedNews.GetTitle(),
                        selectedNews.GetDescription(),
                        selectedNews.GetAuthor(),
                        selectedNews.GetDate().ToString("yyyy-MM-dd")
                    );
                }
                else {
                    return (string.Empty, string.Empty, string.Empty, string.Empty);
                }
            }
            catch (Exception) {
                return (string.Empty, string.Empty, string.Empty, string.Empty);
            }
        }
    }
}
