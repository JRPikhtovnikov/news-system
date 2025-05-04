using System;
using System.Collections.Generic;
using System.Linq;

namespace News_System {
    public class NewsFilters {
        private readonly FileDataNews _fileDataNews;

        public NewsFilters(FileDataNews fileDataProvider) {
            _fileDataNews = fileDataProvider;
        }

        public List<News> FilterNews(string titleFilter, string descriptionFilter, string authorFilter, DateTime dateFrom, DateTime dateTo) {
            var filteredNews = _fileDataNews.GetNews();

            if (!string.IsNullOrWhiteSpace(titleFilter)) {
                filteredNews = filteredNews.Where(news => news.GetTitle().Contains(titleFilter, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            if (!string.IsNullOrWhiteSpace(descriptionFilter)) {
                filteredNews = filteredNews.Where(news => news.GetDescription().Contains(descriptionFilter, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            if (!string.IsNullOrWhiteSpace(authorFilter)) {
                filteredNews = filteredNews.Where(news => news.GetAuthor().Contains(authorFilter, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            if (dateFrom != DateTime.MinValue && dateTo != DateTime.MinValue) {
                filteredNews = filteredNews.Where(news =>
                    news.GetDate() >= dateFrom && news.GetDate() <= dateTo).ToList();
            }

            return filteredNews;
        }

        public int GetAuthorNewsCount(string author) {
            var allNews = _fileDataNews.GetNews();
            return allNews.Count(news => news.GetAuthor().Equals(author));
        }
    }
}
