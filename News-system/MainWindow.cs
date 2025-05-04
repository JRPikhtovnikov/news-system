using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace News_System {
    public partial class MainWindow : Form {
        private readonly NewsMain _newsMain;
        private static CurrentUser _currentUser = new CurrentUser();
        private static readonly FileDataNews _fileDataNews = new FileDataNews();
        private NewsEditor _editor = new NewsEditor(_fileDataNews, _currentUser);
        private NewsFilters _newsFilters;

        public MainWindow() {
            InitializeComponent();
            _fileDataNews.LoadNewsFromFile();
            _newsMain = new NewsMain(_fileDataNews);
            _newsFilters = new NewsFilters(_fileDataNews);
            _newsMain.LoadNewsTitles(lb_news);
        }

        private void lb_news_SelectedIndexChanged(object sender, EventArgs e) {
            if (lb_news.SelectedItem != null) {
                string selectedTitle = lb_news.SelectedItem.ToString();

                var newsDetails = _newsMain.GetNewsDetails(selectedTitle);

                if (!string.IsNullOrEmpty(newsDetails.Title)) {
                    lbl_title.Text = newsDetails.Title;
                    tb_content.Text = newsDetails.Description;
                    lbl_votes.Text = newsDetails.Votes;
                    lbl_author.Text = newsDetails.Author;
                    lbl_date.Text = newsDetails.Date;
                }
                else {
                    MessageBox.Show("Новость не найдена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateVotesLabel(string newsTitle) {
            int currentVotes = _newsMain.GetVotes(newsTitle);
            lbl_votes.Text = currentVotes.ToString();
        }

        private void btn_voteup_Click(object sender, EventArgs e) {
            if (lb_news.SelectedItem == null) {
                MessageBox.Show("Выберите новость для голосования!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedTitle = lb_news.SelectedItem.ToString();

            bool isVoteIncreased = _newsMain.IncreaseVote(selectedTitle);

            if (isVoteIncreased) {
                MessageBox.Show("Ваш голос засчитан!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                UpdateVotesLabel(selectedTitle);
            }
            else {
                MessageBox.Show("Не удалось засчитать голос. Попробуйте еще раз.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_add_news_Click(object sender, EventArgs e) {
            NewsRegistry addNewsMain = new NewsRegistry(_fileDataNews);
            AddNewsWindow addNews = new AddNewsWindow(addNewsMain);

            addNews.ShowDialog();
        }

        private void btn_refresh_Click(object sender, EventArgs e) {
            _fileDataNews.LoadNewsFromFile();
            _newsMain.LoadNewsTitles(lb_news);
        }

        private void btn_edit_Click(object sender, EventArgs e) {
            if (lb_news.SelectedItem == null) {
                MessageBox.Show("Выберите новость для редактирования!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedTitle = lb_news.SelectedItem.ToString();

            var newsDetails = _newsMain.GetNewsDetails(selectedTitle);

            if (!string.IsNullOrEmpty(newsDetails.Title)) {
                if (newsDetails.Author == _currentUser.GetUsername()) {
                    var editorWindow = new EditorWindow(_editor, selectedTitle);
                    editorWindow.ShowDialog();
                }
                else {
                    MessageBox.Show("Вы не можете редактировать эту новость, так как она не принадлежит вам!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show("Новость не найдена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_filter_Click(object sender, EventArgs e) {
            FilterWindow filterForm = new FilterWindow(_newsFilters, _newsMain, this);
            filterForm.ShowDialog();
        }

        public void SetAuthorNewsCount() {
            lbl_author_count.Text = $"Новостей автора: {lb_news.Items.Count}";
        }


        public void UpdateNewsList(List<News> filteredNews) {
            lb_news.Items.Clear();
            foreach (var news in filteredNews) {
                lb_news.Items.Add(news.GetTitle());
            }
        }

        private void btn_top_news_Click(object sender, EventArgs e) {
            _newsMain.LoadTopNews(lb_news);
        }
    }
}
