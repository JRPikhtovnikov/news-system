using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace News_System {
    public class News {
        private string _title;
        private DateTime _date;
        private string _author;
        private string _description;
        private int _votes;

        public News(string title, DateTime date, string author, string description) {
            _title = title;
            _date = date;
            _author = author;
            _description = description;
            _votes = 0;
        }

        // Методы доступа
        public string GetTitle() => _title;
        public void SetTitle(string title) {
            if (string.IsNullOrWhiteSpace(title)) throw new ArgumentException("Заголовок не может быть пустым.");
            _title = title;
        }

        public DateTime GetDate() => _date;

        public string GetAuthor() => _author;

        public string GetDescription() => _description;
        public void SetDescription(string description) {
            if (string.IsNullOrWhiteSpace(description)) throw new ArgumentException("Описание не может быть пустым.");
            _description = description;
        }

        public int GetVotes() => _votes;

        public void Upvote() {
            _votes++;
        }

        public static News FromString(string data) {
            var parts = data.Split('|');

            return new News(
                parts[0], 
                DateTime.Parse(parts[1]),
                parts[2], 
                parts[3] 
            ) {
                _votes = int.Parse(parts[4])
            };
        }

        public string ToDataString() {
            return $"{_title}|{_date:yyyy-MM-dd}|{_author}|{_description}|{_votes}";
        }
    }

}

