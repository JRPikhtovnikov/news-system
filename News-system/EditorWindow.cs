using System;
using System.Windows.Forms;

namespace News_System {
    public partial class EditorWindow : Form {
        private readonly NewsEditor _newsEditor;
        private readonly string _currentNewsTitle;

        public EditorWindow(NewsEditor newsEditor, string newsTitle) {
            _newsEditor = newsEditor ?? throw new ArgumentNullException(nameof(newsEditor));
            _currentNewsTitle = newsTitle;
            InitializeComponent();
            LoadNewsDetails(newsTitle);
        }

        private void LoadNewsDetails(string newsTitle) {
            var newsDetails = _newsEditor.GetNewsDetails(newsTitle);

            if (!string.IsNullOrEmpty(newsDetails.Title)) {
                txt_title.Text = newsDetails.Title;
                txt_description.Text = newsDetails.Description;
                lbl_author.Text = $"Автор: {newsDetails.Author}";
                lbl_date.Text = $"Дата: {newsDetails.Date}";
            }
            else {
                MessageBox.Show("Новость не найдена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_save_Click(object sender, EventArgs e) {
            string newTitle = txt_title.Text;
            string newDescription = txt_description.Text;

            bool success = _newsEditor.EditNews(_currentNewsTitle, newTitle, newDescription);

            if (success) {
                MessageBox.Show("Новость успешно обновлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else {
                MessageBox.Show("Не удалось обновить новость. Попробуйте снова.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
