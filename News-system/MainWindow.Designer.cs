
namespace News_System {
    partial class MainWindow {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            lb_news = new ListBox();
            lbl_title = new Label();
            tb_content = new TextBox();
            btn_voteup = new Button();
            btn_add_news = new Button();
            label2 = new Label();
            label3 = new Label();
            lbl_votes = new Label();
            lbl_author = new Label();
            label5 = new Label();
            lbl_date = new Label();
            label6 = new Label();
            btn_refresh = new Button();
            btn_edit = new Button();
            label4 = new Label();
            btn_filter = new Button();
            btn_top_news = new Button();
            tt_edit = new ToolTip(components);
            tt_vote = new ToolTip(components);
            tt_refresh = new ToolTip(components);
            tt_filters = new ToolTip(components);
            tt_top = new ToolTip(components);
            lbl_author_count = new Label();
            SuspendLayout();
            // 
            // lb_news
            // 
            lb_news.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lb_news.BackColor = SystemColors.Control;
            lb_news.BorderStyle = BorderStyle.FixedSingle;
            lb_news.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lb_news.FormattingEnabled = true;
            lb_news.ItemHeight = 17;
            lb_news.Location = new Point(12, 46);
            lb_news.Name = "lb_news";
            lb_news.Size = new Size(225, 291);
            lb_news.TabIndex = 0;
            lb_news.SelectedIndexChanged += lb_news_SelectedIndexChanged;
            // 
            // lbl_title
            // 
            lbl_title.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbl_title.Location = new Point(243, 12);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(110, 25);
            lbl_title.TabIndex = 1;
            lbl_title.Text = "Заголовок";
            // 
            // tb_content
            // 
            tb_content.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_content.BorderStyle = BorderStyle.FixedSingle;
            tb_content.Location = new Point(243, 46);
            tb_content.Multiline = true;
            tb_content.Name = "tb_content";
            tb_content.ReadOnly = true;
            tb_content.ScrollBars = ScrollBars.Vertical;
            tb_content.Size = new Size(350, 264);
            tb_content.TabIndex = 2;
            // 
            // btn_voteup
            // 
            btn_voteup.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_voteup.Location = new Point(397, 353);
            btn_voteup.Name = "btn_voteup";
            btn_voteup.Size = new Size(37, 30);
            btn_voteup.TabIndex = 3;
            btn_voteup.Text = "👍";
            tt_vote.SetToolTip(btn_voteup, "Нажмите, чтобы проголосовать за новость");
            btn_voteup.UseVisualStyleBackColor = true;
            btn_voteup.Click += btn_voteup_Click;
            // 
            // btn_add_news
            // 
            btn_add_news.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_add_news.Location = new Point(87, 355);
            btn_add_news.Name = "btn_add_news";
            btn_add_news.Size = new Size(148, 33);
            btn_add_news.TabIndex = 5;
            btn_add_news.Text = "Добавить новость";
            btn_add_news.Click += btn_add_news_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(241, 358);
            label2.Name = "label2";
            label2.Size = new Size(144, 21);
            label2.TabIndex = 6;
            label2.Text = "Оценить новость";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(485, 320);
            label3.Name = "label3";
            label3.Size = new Size(59, 17);
            label3.TabIndex = 7;
            label3.Text = "Оценок:";
            // 
            // lbl_votes
            // 
            lbl_votes.AutoSize = true;
            lbl_votes.Font = new Font("Segoe UI Semilight", 9.75F);
            lbl_votes.Location = new Point(545, 320);
            lbl_votes.Name = "lbl_votes";
            lbl_votes.Size = new Size(0, 17);
            lbl_votes.TabIndex = 8;
            // 
            // lbl_author
            // 
            lbl_author.AutoSize = true;
            lbl_author.Font = new Font("Segoe UI Semilight", 9.75F);
            lbl_author.Location = new Point(295, 320);
            lbl_author.Name = "lbl_author";
            lbl_author.Size = new Size(0, 17);
            lbl_author.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(243, 320);
            label5.Name = "label5";
            label5.Size = new Size(49, 17);
            label5.TabIndex = 9;
            label5.Text = "Автор:";
            // 
            // lbl_date
            // 
            lbl_date.AutoSize = true;
            lbl_date.Font = new Font("Segoe UI Semilight", 9.75F);
            lbl_date.Location = new Point(402, 320);
            lbl_date.Name = "lbl_date";
            lbl_date.Size = new Size(0, 17);
            lbl_date.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(359, 320);
            label6.Name = "label6";
            label6.Size = new Size(40, 17);
            label6.TabIndex = 11;
            label6.Text = "Дата:";
            // 
            // btn_refresh
            // 
            btn_refresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_refresh.Image = (Image)resources.GetObject("btn_refresh.Image");
            btn_refresh.Location = new Point(12, 355);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(32, 33);
            btn_refresh.TabIndex = 13;
            tt_refresh.SetToolTip(btn_refresh, "Нажмите, чтобы обновить список новостей");
            btn_refresh.Click += btn_refresh_Click;
            // 
            // btn_edit
            // 
            btn_edit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_edit.Image = (Image)resources.GetObject("btn_edit.Image");
            btn_edit.Location = new Point(50, 355);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(32, 33);
            btn_edit.TabIndex = 14;
            tt_edit.SetToolTip(btn_edit, "Нажмите, чтобы редактировать новость");
            btn_edit.Click += btn_edit_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(12, 12);
            label4.Name = "label4";
            label4.Size = new Size(172, 25);
            label4.TabIndex = 15;
            label4.Text = "Список новостей";
            // 
            // btn_filter
            // 
            btn_filter.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_filter.Image = (Image)resources.GetObject("btn_filter.Image");
            btn_filter.Location = new Point(189, 16);
            btn_filter.Name = "btn_filter";
            btn_filter.Size = new Size(23, 23);
            btn_filter.TabIndex = 16;
            tt_filters.SetToolTip(btn_filter, "Нажмите, чтобы отфильтровать новости");
            btn_filter.Click += btn_filter_Click;
            // 
            // btn_top_news
            // 
            btn_top_news.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_top_news.Image = (Image)resources.GetObject("btn_top_news.Image");
            btn_top_news.Location = new Point(214, 17);
            btn_top_news.Name = "btn_top_news";
            btn_top_news.Size = new Size(23, 23);
            btn_top_news.TabIndex = 17;
            tt_top.SetToolTip(btn_top_news, "Нажмите, чтобы посмотреть лучшие новости");
            btn_top_news.Click += btn_top_news_Click;
            // 
            // lbl_author_count
            // 
            lbl_author_count.AutoSize = true;
            lbl_author_count.Location = new Point(432, 21);
            lbl_author_count.Name = "lbl_author_count";
            lbl_author_count.Size = new Size(0, 15);
            lbl_author_count.TabIndex = 18;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 400);
            Controls.Add(lbl_author_count);
            Controls.Add(btn_top_news);
            Controls.Add(btn_filter);
            Controls.Add(label4);
            Controls.Add(btn_edit);
            Controls.Add(btn_refresh);
            Controls.Add(lbl_date);
            Controls.Add(label6);
            Controls.Add(lbl_author);
            Controls.Add(label5);
            Controls.Add(lbl_votes);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_add_news);
            Controls.Add(btn_voteup);
            Controls.Add(tb_content);
            Controls.Add(lbl_title);
            Controls.Add(lb_news);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главное окно";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private System.Windows.Forms.ListBox lb_news;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox tb_content;
        private System.Windows.Forms.Button btn_voteup;
        private Label label1;
        private Label label2;
        private Button btn_add_news;
        private Label label3;
        private Label lbl_votes;
        private Label lbl_author;
        private Label label5;
        private Label lbl_date;
        private Label label6;
        private Button btn_refresh;
        private Button btn_edit;
        private Label label4;
        private Button btn_filter;
        private Button btn_top_news;
        private ToolTip tt_edit;
        private ToolTip tt_vote;
        private ToolTip tt_refresh;
        private ToolTip tt_filters;
        private ToolTip tt_top;
        private Label lbl_author_count;
    }
}
