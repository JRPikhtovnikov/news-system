namespace News_System {
    public partial class MainWindow : Form {
        private readonly NewsMain _newsMain;

        public MainWindow() {
            InitializeComponent();
            _newsMain = new NewsMain();
            _newsMain.LoadNewsTitles(lb_news);
        }

        private void lb_news_SelectedIndexChanged(object sender, EventArgs e) {
            if (lb_news.SelectedItem != null) {
                string selectedTitle = lb_news.SelectedItem.ToString();

                // Получение данных о выбранной новости
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

        private void UpdateVotesLabel(int newsId) {
            // Получение текущего количества голосов для указанной новости
            int currentVotes = _newsMain.GetVotes(newsId);
            lbl_votes.Text = currentVotes.ToString(); // Обновление текста lbl_votes
        }

        private void btn_voteup_Click(object sender, EventArgs e) {
            if (lb_news.SelectedItem == null) {
                MessageBox.Show("Выберите новость для голосования!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Получение ID выбранной новости
            int selectedNewsId = _newsMain.GetSelectedNewsId(lb_news.SelectedItem.ToString());

            if (selectedNewsId == 0) {
                MessageBox.Show("Не удалось определить ID новости.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Увеличиваем голос
            bool isVoteIncreased = _newsMain.IncreaseVote(selectedNewsId);

            if (isVoteIncreased) {
                MessageBox.Show("Ваш голос засчитан!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Обновляем lbl_votes
                UpdateVotesLabel(selectedNewsId);
            }
            else {
                MessageBox.Show("Не удалось засчитать голос. Попробуйте еще раз.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_add_news_Click(object sender, EventArgs e) {
            AddNewsMain addNewsMain = new AddNewsMain();
            AddNews addNews = new AddNews(addNewsMain);

            addNews.Show();
            Close();
        }
    }
}
