using System;
using System.Windows.Forms;

namespace News_System {
    public partial class AddNewsWindow : Form {
        private readonly FileDataNews _fileDataNews;
        private NewsRegistry _addNewsMain;
        private MainWindow _mainWindow;
        private CurrentUser _currentUser;

        public AddNewsWindow(NewsRegistry addNewsMain) {
            _addNewsMain = addNewsMain;
            _fileDataNews = new FileDataNews();
            _mainWindow = new MainWindow();
            _currentUser = new CurrentUser();
            InitializeComponent();
            LoadAuthor();
        }

        private void LoadAuthor() {
            if (CurrentUser.IsLoggedIn()) {
                tb_author.Text = _currentUser.GetUsername();
                tb_author.ReadOnly = true;
            }
            else {
                tb_author.Clear();
                tb_author.ReadOnly = false;
            }
        }

        private void btn_save_Click(object sender, EventArgs e) {
            string title = tb_title.Text;
            string description = tb_description.Text;
            string author = tb_author.Text;
            DateTime selectedDate = dtp_date.Value;

            bool isAdded = _addNewsMain.AddNews(title, description, author, selectedDate);

            if (isAdded) {
                MessageBox.Show("Новость успешно добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else {
                MessageBox.Show("Ошибка при добалении новости, проверьте заполненность полей, а так же заголовок. " +
                    "Возможно, новость с таким заголовком уже существует",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_cancel_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
