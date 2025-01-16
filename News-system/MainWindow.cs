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

                // ��������� ������ � ��������� �������
                var newsDetails = _newsMain.GetNewsDetails(selectedTitle);

                if (!string.IsNullOrEmpty(newsDetails.Title)) {
                    lbl_title.Text = newsDetails.Title;
                    tb_content.Text = newsDetails.Description;
                    lbl_votes.Text = newsDetails.Votes;
                    lbl_author.Text = newsDetails.Author;
                    lbl_date.Text = newsDetails.Date;
                }
                else {
                    MessageBox.Show("������� �� �������!", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateVotesLabel(int newsId) {
            // ��������� �������� ���������� ������� ��� ��������� �������
            int currentVotes = _newsMain.GetVotes(newsId);
            lbl_votes.Text = currentVotes.ToString(); // ���������� ������ lbl_votes
        }

        private void btn_voteup_Click(object sender, EventArgs e) {
            if (lb_news.SelectedItem == null) {
                MessageBox.Show("�������� ������� ��� �����������!", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ��������� ID ��������� �������
            int selectedNewsId = _newsMain.GetSelectedNewsId(lb_news.SelectedItem.ToString());

            if (selectedNewsId == 0) {
                MessageBox.Show("�� ������� ���������� ID �������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ����������� �����
            bool isVoteIncreased = _newsMain.IncreaseVote(selectedNewsId);

            if (isVoteIncreased) {
                MessageBox.Show("��� ����� ��������!", "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // ��������� lbl_votes
                UpdateVotesLabel(selectedNewsId);
            }
            else {
                MessageBox.Show("�� ������� ��������� �����. ���������� ��� ���.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
