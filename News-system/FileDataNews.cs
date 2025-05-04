using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace News_System {
    public class FileDataNews {
        private string _newsFilePath = "../../../news.txt";
        private List<News> _newsList = new List<News>();

        /// <summary>
        /// Загружает данные из файла новостей.
        /// </summary>
        public void LoadNewsFromFile() {
            if (File.Exists(_newsFilePath)) {
                var lines = File.ReadAllLines(_newsFilePath);
                foreach (var line in lines) {
                    _newsList.Add(News.FromString(line));
                }
            }
        }
        /// <summary>
        /// Возвращает все новости.
        /// </summary>
        public List<News> GetNews() {
            return _newsList;
        }
        /// <summary>
        /// Сохраняет данные в файл новостей.
        /// </summary>
        public void SaveNews(List<News> newsList) {
            var data = newsList.Select(news => news.ToDataString()).ToList();
            File.WriteAllLines(_newsFilePath, data);
        }
        /// <summary>
        /// Добавляет новую новость в файл.
        /// </summary>
        public void AddNews(News news) {
            var data = news.ToDataString();
            File.AppendAllText(_newsFilePath, data + Environment.NewLine);
        }
    }
}
