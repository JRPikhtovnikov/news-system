namespace News_System {
    partial class FilterWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterWindow));
            labelTitle = new Label();
            tb_search_title = new TextBox();
            labelDescription = new Label();
            tb_search_description = new TextBox();
            labelAuthor = new Label();
            tb_search_author = new TextBox();
            labelDateFrom = new Label();
            dtp_since_date = new DateTimePicker();
            labelDateTo = new Label();
            dtp_for_date = new DateTimePicker();
            btn_search = new Button();
            btn_reset = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(12, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(120, 15);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Поиск по заголовку:";
            // 
            // tb_search_title
            // 
            tb_search_title.Location = new Point(143, 20);
            tb_search_title.Name = "tb_search_title";
            tb_search_title.Size = new Size(177, 23);
            tb_search_title.TabIndex = 1;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(12, 60);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(122, 15);
            labelDescription.TabIndex = 2;
            labelDescription.Text = "Поиск по описанию:";
            // 
            // tb_search_description
            // 
            tb_search_description.Location = new Point(143, 60);
            tb_search_description.Name = "tb_search_description";
            tb_search_description.Size = new Size(177, 23);
            tb_search_description.TabIndex = 3;
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Location = new Point(12, 100);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(102, 15);
            labelAuthor.TabIndex = 4;
            labelAuthor.Text = "Поиск по автору:";
            // 
            // tb_search_author
            // 
            tb_search_author.Location = new Point(143, 100);
            tb_search_author.Name = "tb_search_author";
            tb_search_author.Size = new Size(177, 23);
            tb_search_author.TabIndex = 5;
            // 
            // labelDateFrom
            // 
            labelDateFrom.AutoSize = true;
            labelDateFrom.Location = new Point(12, 140);
            labelDateFrom.Name = "labelDateFrom";
            labelDateFrom.Size = new Size(44, 15);
            labelDateFrom.TabIndex = 6;
            labelDateFrom.Text = "Дата с:";
            // 
            // dtp_since_date
            // 
            dtp_since_date.Format = DateTimePickerFormat.Short;
            dtp_since_date.Location = new Point(143, 140);
            dtp_since_date.Name = "dtp_since_date";
            dtp_since_date.Size = new Size(177, 23);
            dtp_since_date.TabIndex = 7;
            dtp_since_date.Value = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            // 
            // labelDateTo
            // 
            labelDateTo.AutoSize = true;
            labelDateTo.Location = new Point(12, 180);
            labelDateTo.Name = "labelDateTo";
            labelDateTo.Size = new Size(52, 15);
            labelDateTo.TabIndex = 8;
            labelDateTo.Text = "Дата по:";
            // 
            // dtp_for_date
            // 
            dtp_for_date.Format = DateTimePickerFormat.Short;
            dtp_for_date.Location = new Point(143, 180);
            dtp_for_date.Name = "dtp_for_date";
            dtp_for_date.Size = new Size(177, 23);
            dtp_for_date.TabIndex = 9;
            dtp_for_date.Value = new DateTime(2025, 1, 30, 0, 0, 0, 0);
            // 
            // btn_search
            // 
            btn_search.Location = new Point(160, 226);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(75, 23);
            btn_search.TabIndex = 10;
            btn_search.Text = "Поиск";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // btn_reset
            // 
            btn_reset.Location = new Point(245, 226);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(75, 23);
            btn_reset.TabIndex = 11;
            btn_reset.Text = "Отмена";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // FilterWindow
            // 
            ClientSize = new Size(331, 260);
            Controls.Add(btn_reset);
            Controls.Add(btn_search);
            Controls.Add(dtp_for_date);
            Controls.Add(labelDateTo);
            Controls.Add(dtp_since_date);
            Controls.Add(labelDateFrom);
            Controls.Add(tb_search_author);
            Controls.Add(labelAuthor);
            Controls.Add(tb_search_description);
            Controls.Add(labelDescription);
            Controls.Add(tb_search_title);
            Controls.Add(labelTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FilterWindow";
            Text = "Фильтр новостей";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox tb_search_title;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox tb_search_description;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.TextBox tb_search_author;
        private System.Windows.Forms.Label labelDateFrom;
        private System.Windows.Forms.DateTimePicker dtp_since_date;
        private System.Windows.Forms.Label labelDateTo;
        private System.Windows.Forms.DateTimePicker dtp_for_date;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_reset;
    }
}