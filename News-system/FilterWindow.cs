using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace News_System {
    public partial class FilterWindow : Form {
        private readonly NewsFilters _newsFilters;
        private readonly NewsMain _newsMain;        
        private readonly MainWindow _mainWindow;

        public FilterWindow(NewsFilters newsFilters, NewsMain newsMain, MainWindow mainWindow) {
            InitializeComponent();
            _newsFilters = newsFilters;
            _newsMain = newsMain;
            _mainWindow = mainWindow;
        }

        private void btn_search_Click(object sender, EventArgs e) {
            string titleFilter = tb_search_title.Text;
            string descriptionFilter = tb_search_description.Text;
            string authorFilter = tb_search_author.Text;
            DateTime dateFrom = dtp_since_date.Value;
            DateTime dateTo = dtp_for_date.Value;

            var filteredNews = _newsFilters.FilterNews(titleFilter, descriptionFilter, authorFilter, dateFrom, dateTo);

            _mainWindow.UpdateNewsList(filteredNews);

            if(!string.IsNullOrWhiteSpace(authorFilter)) {
                //var autor_news_count = _newsFilters.GetAuthorNewsCount(tb_search_author.Text);
                _mainWindow.SetAuthorNewsCount();
            }

            Close();
        }

        private void btn_reset_Click(object sender, EventArgs e) {
            Close();
        }

    }
}
