namespace News_System {
    partial class EditorWindow {
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

        #region Код, автоматически созданный конструктором формы

        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorWindow));
            txt_title = new TextBox();
            txt_description = new TextBox();
            lbl_author = new Label();
            lbl_date = new Label();
            btn_save = new Button();
            btn_cancel = new Button();
            lbl_title = new Label();
            lbl_description = new Label();
            SuspendLayout();
            // 
            // txt_title
            // 
            txt_title.Location = new Point(12, 29);
            txt_title.Name = "txt_title";
            txt_title.Size = new Size(350, 23);
            txt_title.TabIndex = 0;
            // 
            // txt_description
            // 
            txt_description.Location = new Point(12, 79);
            txt_description.Multiline = true;
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(350, 150);
            txt_description.TabIndex = 1;
            // 
            // lbl_author
            // 
            lbl_author.AutoSize = true;
            lbl_author.Location = new Point(12, 243);
            lbl_author.Name = "lbl_author";
            lbl_author.Size = new Size(46, 15);
            lbl_author.TabIndex = 2;
            lbl_author.Text = "Автор: ";
            // 
            // lbl_date
            // 
            lbl_date.AutoSize = true;
            lbl_date.Location = new Point(12, 266);
            lbl_date.Name = "lbl_date";
            lbl_date.Size = new Size(38, 15);
            lbl_date.TabIndex = 3;
            lbl_date.Text = "Дата: ";
            // 
            // btn_save
            // 
            btn_save.Location = new Point(12, 292);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(75, 23);
            btn_save.TabIndex = 4;
            btn_save.Text = "Сохранить";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(93, 292);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(75, 23);
            btn_cancel.TabIndex = 5;
            btn_cancel.Text = "Отменить";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Location = new Point(12, 13);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(68, 15);
            lbl_title.TabIndex = 6;
            lbl_title.Text = "Заголовок:";
            // 
            // lbl_description
            // 
            lbl_description.AutoSize = true;
            lbl_description.Location = new Point(12, 63);
            lbl_description.Name = "lbl_description";
            lbl_description.Size = new Size(65, 15);
            lbl_description.TabIndex = 7;
            lbl_description.Text = "Описание:";
            // 
            // EditorWindow
            // 
            ClientSize = new Size(374, 327);
            Controls.Add(lbl_description);
            Controls.Add(lbl_title);
            Controls.Add(btn_cancel);
            Controls.Add(btn_save);
            Controls.Add(lbl_date);
            Controls.Add(lbl_author);
            Controls.Add(txt_description);
            Controls.Add(txt_title);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditorWindow";
            Text = "Редактировать новость";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label lbl_author;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_description;
    }
}