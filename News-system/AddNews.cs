using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace News_System {
    public partial class AddNews : Form {

        private AddNewsMain _addNewsMain;
        private MainWindow _mainWindow = new();

        public AddNews(AddNewsMain addNewsMain) {
            _addNewsMain = addNewsMain;

            InitializeComponent();
            LoadAuthor();
        }

        private void LoadAuthor() {
            if (CurrentUser.IsLoggedIn()) {
                tb_author.Text = CurrentUser.GetUsername();
                tb_author.ReadOnly = true;
            }
            else { }
        }

        private void btn_save_Click(object sender, EventArgs e) {
            AddNewsMain addNewsMain = new AddNewsMain();

            // Извлекаем значения из полей формы
            string title = tb_title.Text;
            string description = tb_description.Text;
            string author = tb_author.Text;
            DateTime selectedDate = dtp_date.Value;

            if (addNewsMain.CheckNewsExists(title)) {
                MessageBox.Show("Новость с таким заголовком уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isAdded = addNewsMain.AddNews(title, description, author, selectedDate);

            if (isAdded) {
                MessageBox.Show("Новость успешно добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _mainWindow.Show();
                Hide();
            }
            else {
                MessageBox.Show("Ошибка добавления новости.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e) {
            _mainWindow.Show();
            this.Hide();
        }
    }
}
