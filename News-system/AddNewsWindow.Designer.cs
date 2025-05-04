namespace News_System {
    partial class AddNewsWindow {
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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewsWindow));
            labelTitle = new Label();
            tb_title = new TextBox();
            labelAuthor = new Label();
            tb_author = new TextBox();
            labelDate = new Label();
            dtp_date = new DateTimePicker();
            labelDescription = new Label();
            tb_description = new TextBox();
            btn_save = new Button();
            btn_cancel = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(12, 15);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(65, 15);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Заголовок";
            // 
            // tb_title
            // 
            tb_title.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tb_title.Location = new Point(100, 12);
            tb_title.Name = "tb_title";
            tb_title.Size = new Size(400, 23);
            tb_title.TabIndex = 1;
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Location = new Point(12, 50);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(40, 15);
            labelAuthor.TabIndex = 2;
            labelAuthor.Text = "Автор";
            // 
            // tb_author
            // 
            tb_author.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tb_author.Location = new Point(100, 47);
            tb_author.Name = "tb_author";
            tb_author.Size = new Size(400, 23);
            tb_author.TabIndex = 3;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(12, 85);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(32, 15);
            labelDate.TabIndex = 4;
            labelDate.Text = "Дата";
            // 
            // dtp_date
            // 
            dtp_date.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtp_date.Location = new Point(100, 81);
            dtp_date.Name = "dtp_date";
            dtp_date.Size = new Size(400, 23);
            dtp_date.TabIndex = 5;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(12, 120);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(62, 15);
            labelDescription.TabIndex = 6;
            labelDescription.Text = "Описание";
            // 
            // tb_description
            // 
            tb_description.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_description.Location = new Point(100, 117);
            tb_description.Multiline = true;
            tb_description.Name = "tb_description";
            tb_description.ScrollBars = ScrollBars.Vertical;
            tb_description.Size = new Size(400, 150);
            tb_description.TabIndex = 7;
            // 
            // btn_save
            // 
            btn_save.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_save.Location = new Point(325, 280);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(85, 30);
            btn_save.TabIndex = 8;
            btn_save.Text = "Сохранить";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cancel.Location = new Point(415, 280);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(85, 30);
            btn_cancel.TabIndex = 9;
            btn_cancel.Text = "Отмена";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // AddNewsWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 330);
            Controls.Add(btn_cancel);
            Controls.Add(btn_save);
            Controls.Add(tb_description);
            Controls.Add(labelDescription);
            Controls.Add(dtp_date);
            Controls.Add(labelDate);
            Controls.Add(tb_author);
            Controls.Add(labelAuthor);
            Controls.Add(tb_title);
            Controls.Add(labelTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddNewsWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление новости";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.TextBox tb_author;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
    }
}