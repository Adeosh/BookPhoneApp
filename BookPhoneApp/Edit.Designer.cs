namespace BookPhoneApp
{
    partial class btnEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            tbFirstName = new TextBox();
            dtBirth = new DateTimePicker();
            lblFirstName = new Label();
            lblMiddleName = new Label();
            tbLastName = new TextBox();
            lblLastName = new Label();
            tbMiddleName = new TextBox();
            lblPhone = new Label();
            tbPhone = new TextBox();
            lblAddress = new Label();
            tbAddress = new TextBox();
            lblDate = new Label();
            bInsert = new Button();
            btnUpdate = new Button();
            bFromTxt = new Button();
            btnRefresh = new Button();
            lblHideButton = new Label();
            lblCloseButton = new Label();
            lblBackButton = new Label();
            dgEdit = new DataGridView();
            pSearch = new Panel();
            tbSearch = new TextBox();
            lblEdit = new Label();
            bFromSQL = new Button();
            lblTxt = new Label();
            lblSql = new Label();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgEdit).BeginInit();
            SuspendLayout();
            // 
            // tbFirstName
            // 
            tbFirstName.BackColor = Color.FromArgb(45, 62, 81);
            tbFirstName.BorderStyle = BorderStyle.FixedSingle;
            tbFirstName.ForeColor = Color.FromArgb(172, 189, 207);
            tbFirstName.Location = new Point(143, 420);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(291, 23);
            tbFirstName.TabIndex = 1;
            // 
            // dtBirth
            // 
            dtBirth.Location = new Point(143, 670);
            dtBirth.Name = "dtBirth";
            dtBirth.Size = new Size(291, 23);
            dtBirth.TabIndex = 2;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFirstName.ForeColor = Color.FromArgb(172, 189, 207);
            lblFirstName.Location = new Point(4, 420);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(44, 21);
            lblFirstName.TabIndex = 3;
            lblFirstName.Text = "Имя";
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMiddleName.ForeColor = Color.FromArgb(172, 189, 207);
            lblMiddleName.Location = new Point(4, 470);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(82, 21);
            lblMiddleName.TabIndex = 5;
            lblMiddleName.Text = "Отчество";
            // 
            // tbLastName
            // 
            tbLastName.BackColor = Color.FromArgb(45, 62, 81);
            tbLastName.BorderStyle = BorderStyle.FixedSingle;
            tbLastName.ForeColor = Color.FromArgb(172, 189, 207);
            tbLastName.Location = new Point(143, 520);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(291, 23);
            tbLastName.TabIndex = 4;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblLastName.ForeColor = Color.FromArgb(172, 189, 207);
            lblLastName.Location = new Point(4, 520);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(83, 21);
            lblLastName.TabIndex = 7;
            lblLastName.Text = "Фамилия";
            // 
            // tbMiddleName
            // 
            tbMiddleName.BackColor = Color.FromArgb(45, 62, 81);
            tbMiddleName.BorderStyle = BorderStyle.FixedSingle;
            tbMiddleName.ForeColor = Color.FromArgb(172, 189, 207);
            tbMiddleName.Location = new Point(143, 470);
            tbMiddleName.Name = "tbMiddleName";
            tbMiddleName.Size = new Size(291, 23);
            tbMiddleName.TabIndex = 6;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPhone.ForeColor = Color.FromArgb(172, 189, 207);
            lblPhone.Location = new Point(4, 570);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(111, 21);
            lblPhone.TabIndex = 9;
            lblPhone.Text = "№ Телефона";
            // 
            // tbPhone
            // 
            tbPhone.BackColor = Color.FromArgb(45, 62, 81);
            tbPhone.BorderStyle = BorderStyle.FixedSingle;
            tbPhone.ForeColor = Color.FromArgb(172, 189, 207);
            tbPhone.Location = new Point(143, 570);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(291, 23);
            tbPhone.TabIndex = 8;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAddress.ForeColor = Color.FromArgb(172, 189, 207);
            lblAddress.Location = new Point(4, 620);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(59, 21);
            lblAddress.TabIndex = 11;
            lblAddress.Text = "Адрес";
            // 
            // tbAddress
            // 
            tbAddress.BackColor = Color.FromArgb(45, 62, 81);
            tbAddress.BorderStyle = BorderStyle.FixedSingle;
            tbAddress.ForeColor = Color.FromArgb(172, 189, 207);
            tbAddress.Location = new Point(143, 620);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(291, 23);
            tbAddress.TabIndex = 10;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDate.ForeColor = Color.FromArgb(172, 189, 207);
            lblDate.Location = new Point(4, 670);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(133, 21);
            lblDate.TabIndex = 12;
            lblDate.Text = "Дата рождения";
            // 
            // bInsert
            // 
            bInsert.BackColor = Color.FromArgb(28, 46, 60);
            bInsert.FlatStyle = FlatStyle.Flat;
            bInsert.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            bInsert.ForeColor = Color.FromArgb(172, 189, 207);
            bInsert.Location = new Point(470, 420);
            bInsert.Name = "bInsert";
            bInsert.Size = new Size(154, 40);
            bInsert.TabIndex = 13;
            bInsert.Text = "Добавить";
            bInsert.UseVisualStyleBackColor = false;
            bInsert.Click += bInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(28, 46, 60);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnUpdate.ForeColor = Color.FromArgb(172, 189, 207);
            btnUpdate.Location = new Point(470, 500);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(154, 40);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Обновить";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // bFromTxt
            // 
            bFromTxt.BackColor = Color.FromArgb(28, 46, 60);
            bFromTxt.FlatStyle = FlatStyle.Flat;
            bFromTxt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            bFromTxt.ForeColor = Color.FromArgb(172, 189, 207);
            bFromTxt.Location = new Point(646, 353);
            bFromTxt.Name = "bFromTxt";
            bFromTxt.Size = new Size(500, 40);
            bFromTxt.TabIndex = 15;
            bFromTxt.Text = "Вставить .txt";
            bFromTxt.UseVisualStyleBackColor = false;
            bFromTxt.Click += bFromTxt_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(28, 46, 60);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnRefresh.ForeColor = Color.FromArgb(172, 189, 207);
            btnRefresh.Location = new Point(470, 650);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(154, 40);
            btnRefresh.TabIndex = 16;
            btnRefresh.Text = "Очистить";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblHideButton
            // 
            lblHideButton.AutoSize = true;
            lblHideButton.Cursor = Cursors.Hand;
            lblHideButton.Font = new Font("Ink Free", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHideButton.ForeColor = Color.FromArgb(172, 189, 207);
            lblHideButton.Location = new Point(1205, 9);
            lblHideButton.Name = "lblHideButton";
            lblHideButton.Size = new Size(29, 34);
            lblHideButton.TabIndex = 17;
            lblHideButton.Text = "_";
            lblHideButton.Click += lblHideButton_Click;
            lblHideButton.MouseEnter += lblHideButton_MouseEnter;
            lblHideButton.MouseLeave += lblHideButton_MouseLeave;
            // 
            // lblCloseButton
            // 
            lblCloseButton.AutoSize = true;
            lblCloseButton.Cursor = Cursors.Hand;
            lblCloseButton.Font = new Font("Ink Free", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCloseButton.ForeColor = Color.FromArgb(172, 189, 207);
            lblCloseButton.Location = new Point(1240, 10);
            lblCloseButton.Name = "lblCloseButton";
            lblCloseButton.Size = new Size(26, 34);
            lblCloseButton.TabIndex = 18;
            lblCloseButton.Text = "X";
            lblCloseButton.Click += lblCloseButton_Click;
            lblCloseButton.MouseEnter += lblCloseButton_MouseEnter;
            lblCloseButton.MouseLeave += lblCloseButton_MouseLeave;
            // 
            // lblBackButton
            // 
            lblBackButton.AutoSize = true;
            lblBackButton.Cursor = Cursors.Hand;
            lblBackButton.Font = new Font("Ink Free", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBackButton.ForeColor = Color.FromArgb(172, 189, 207);
            lblBackButton.Location = new Point(1156, 9);
            lblBackButton.Name = "lblBackButton";
            lblBackButton.Size = new Size(43, 34);
            lblBackButton.TabIndex = 19;
            lblBackButton.Text = "<<";
            lblBackButton.Click += lblBackButton_Click;
            lblBackButton.MouseEnter += lblBackButton_MouseEnter;
            lblBackButton.MouseLeave += lblBackButton_MouseLeave;
            // 
            // dgEdit
            // 
            dgEdit.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(28, 46, 60);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(172, 189, 207);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(193, 101, 117);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(28, 46, 60);
            dgEdit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgEdit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgEdit.BackgroundColor = Color.FromArgb(45, 62, 81);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(28, 46, 60);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(172, 189, 207);
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(28, 46, 60);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgEdit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgEdit.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(28, 46, 60);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(172, 189, 207);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(193, 101, 117);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(28, 46, 60);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgEdit.DefaultCellStyle = dataGridViewCellStyle3;
            dgEdit.EnableHeadersVisualStyles = false;
            dgEdit.GridColor = SystemColors.Window;
            dgEdit.Location = new Point(12, 52);
            dgEdit.Name = "dgEdit";
            dgEdit.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(28, 46, 60);
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(172, 189, 207);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(193, 101, 117);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(28, 46, 60);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgEdit.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(28, 46, 60);
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(172, 189, 207);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(193, 101, 117);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(28, 46, 60);
            dgEdit.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgEdit.Size = new Size(1250, 280);
            dgEdit.TabIndex = 20;
            dgEdit.CellClick += dgEdit_CellClick;
            dgEdit.DataBindingComplete += dgEdit_DataBindingComplete;
            // 
            // pSearch
            // 
            pSearch.BackColor = Color.FromArgb(172, 189, 207);
            pSearch.Location = new Point(12, 390);
            pSearch.Name = "pSearch";
            pSearch.Size = new Size(612, 3);
            pSearch.TabIndex = 22;
            // 
            // tbSearch
            // 
            tbSearch.BackColor = Color.FromArgb(28, 46, 60);
            tbSearch.BorderStyle = BorderStyle.None;
            tbSearch.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            tbSearch.ForeColor = Color.FromArgb(172, 189, 207);
            tbSearch.Location = new Point(12, 353);
            tbSearch.Multiline = true;
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(612, 40);
            tbSearch.TabIndex = 21;
            tbSearch.Text = "Поиск...";
            tbSearch.TextChanged += tbSearch_TextChanged;
            tbSearch.Enter += tbSearch_Enter;
            tbSearch.Leave += tbSearch_Leave;
            // 
            // lblEdit
            // 
            lblEdit.FlatStyle = FlatStyle.Popup;
            lblEdit.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            lblEdit.ForeColor = Color.FromArgb(172, 189, 207);
            lblEdit.Location = new Point(570, 4);
            lblEdit.Name = "lblEdit";
            lblEdit.Size = new Size(154, 35);
            lblEdit.TabIndex = 23;
            lblEdit.Text = "Редактор";
            lblEdit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bFromSQL
            // 
            bFromSQL.BackColor = Color.FromArgb(28, 46, 60);
            bFromSQL.FlatStyle = FlatStyle.Flat;
            bFromSQL.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            bFromSQL.ForeColor = Color.FromArgb(172, 189, 207);
            bFromSQL.Location = new Point(646, 420);
            bFromSQL.Name = "bFromSQL";
            bFromSQL.Size = new Size(500, 40);
            bFromSQL.TabIndex = 24;
            bFromSQL.Text = "Вставить .sql";
            bFromSQL.UseVisualStyleBackColor = false;
            bFromSQL.Click += bFromSQL_Click;
            // 
            // lblTxt
            // 
            lblTxt.AutoSize = true;
            lblTxt.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTxt.ForeColor = Color.FromArgb(172, 189, 207);
            lblTxt.Location = new Point(1199, 346);
            lblTxt.Name = "lblTxt";
            lblTxt.Size = new Size(35, 47);
            lblTxt.TabIndex = 25;
            lblTxt.Text = "?";
            lblTxt.MouseEnter += lblTxt_MouseEnter;
            lblTxt.MouseLeave += lblTxt_MouseLeave;
            // 
            // lblSql
            // 
            lblSql.AutoSize = true;
            lblSql.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblSql.ForeColor = Color.FromArgb(172, 189, 207);
            lblSql.Location = new Point(1199, 413);
            lblSql.Name = "lblSql";
            lblSql.Size = new Size(35, 47);
            lblSql.TabIndex = 26;
            lblSql.Text = "?";
            lblSql.MouseEnter += lblSql_MouseEnter;
            lblSql.MouseLeave += lblSql_MouseLeave;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(28, 46, 60);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnDelete.ForeColor = Color.FromArgb(172, 189, 207);
            btnDelete.Location = new Point(470, 580);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(154, 40);
            btnDelete.TabIndex = 27;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 62, 81);
            ClientSize = new Size(1280, 720);
            Controls.Add(btnDelete);
            Controls.Add(lblSql);
            Controls.Add(lblTxt);
            Controls.Add(bFromSQL);
            Controls.Add(lblEdit);
            Controls.Add(pSearch);
            Controls.Add(tbSearch);
            Controls.Add(dgEdit);
            Controls.Add(lblBackButton);
            Controls.Add(lblHideButton);
            Controls.Add(lblCloseButton);
            Controls.Add(btnRefresh);
            Controls.Add(bFromTxt);
            Controls.Add(btnUpdate);
            Controls.Add(bInsert);
            Controls.Add(lblDate);
            Controls.Add(lblAddress);
            Controls.Add(tbAddress);
            Controls.Add(lblPhone);
            Controls.Add(tbPhone);
            Controls.Add(lblLastName);
            Controls.Add(tbMiddleName);
            Controls.Add(lblMiddleName);
            Controls.Add(tbLastName);
            Controls.Add(lblFirstName);
            Controls.Add(dtBirth);
            Controls.Add(tbFirstName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "btnEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit";
            Load += Edit_Load;
            MouseDown += Edit_MouseDown;
            MouseMove += Edit_MouseMove;
            ((System.ComponentModel.ISupportInitialize)dgEdit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbFirstName;
        private DateTimePicker dtBirth;
        private Label lblFirstName;
        private Label lblMiddleName;
        private TextBox tbLastName;
        private Label lblLastName;
        private TextBox tbMiddleName;
        private Label lblPhone;
        private TextBox tbPhone;
        private Label lblAddress;
        private TextBox tbAddress;
        private Label lblDate;
        private Button bInsert;
        private Button btnUpdate;
        private Button bFromTxt;
        private Button btnRefresh;
        private Label lblHideButton;
        private Label lblCloseButton;
        private Label lblBackButton;
        private DataGridView dgEdit;
        private Panel pSearch;
        private TextBox tbSearch;
        private Label lblEdit;
        private Button bFromSQL;
        private Label lblTxt;
        private Label lblSql;
        private Button btnDelete;
    }
}