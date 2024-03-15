namespace BookPhoneApp
{
    partial class Main
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            dgMain = new DataGridView();
            bEdit = new Button();
            tbSearch = new TextBox();
            lblCloseButton = new Label();
            lblHideButton = new Label();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgMain).BeginInit();
            SuspendLayout();
            // 
            // dgMain
            // 
            dataGridViewCellStyle6.BackColor = Color.FromArgb(28, 46, 60);
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(172, 189, 207);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(193, 101, 117);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(28, 46, 60);
            dgMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgMain.BackgroundColor = Color.FromArgb(45, 62, 81);
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(28, 46, 60);
            dataGridViewCellStyle7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(172, 189, 207);
            dataGridViewCellStyle7.SelectionBackColor = Color.White;
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(28, 46, 60);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgMain.ColumnHeadersHeight = 40;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(28, 46, 60);
            dataGridViewCellStyle8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(172, 189, 207);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(193, 101, 117);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(28, 46, 60);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgMain.DefaultCellStyle = dataGridViewCellStyle8;
            dgMain.EnableHeadersVisualStyles = false;
            dgMain.GridColor = SystemColors.Window;
            dgMain.Location = new Point(12, 127);
            dgMain.Name = "dgMain";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(28, 46, 60);
            dataGridViewCellStyle9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(172, 189, 207);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(193, 101, 117);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(28, 46, 60);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(28, 46, 60);
            dataGridViewCellStyle10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(172, 189, 207);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(193, 101, 117);
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(28, 46, 60);
            dgMain.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgMain.Size = new Size(1256, 580);
            dgMain.TabIndex = 0;
            dgMain.DataBindingComplete += dgMain_DataBindingComplete;
            // 
            // bEdit
            // 
            bEdit.BackColor = Color.FromArgb(28, 46, 60);
            bEdit.FlatStyle = FlatStyle.Flat;
            bEdit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            bEdit.ForeColor = Color.FromArgb(172, 189, 207);
            bEdit.Location = new Point(1114, 67);
            bEdit.Name = "bEdit";
            bEdit.Size = new Size(154, 40);
            bEdit.TabIndex = 1;
            bEdit.Text = "Редактор";
            bEdit.UseVisualStyleBackColor = false;
            bEdit.Click += bEdit_Click;
            // 
            // tbSearch
            // 
            tbSearch.BackColor = Color.FromArgb(28, 46, 60);
            tbSearch.BorderStyle = BorderStyle.None;
            tbSearch.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            tbSearch.ForeColor = Color.FromArgb(172, 189, 207);
            tbSearch.Location = new Point(12, 67);
            tbSearch.Multiline = true;
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(1096, 40);
            tbSearch.TabIndex = 2;
            tbSearch.Text = "Поиск...";
            tbSearch.TextChanged += tbSearch_TextChanged;
            tbSearch.Enter += tbSearch_Enter;
            tbSearch.Leave += tbSearch_Leave;
            // 
            // lblCloseButton
            // 
            lblCloseButton.AutoSize = true;
            lblCloseButton.Cursor = Cursors.Hand;
            lblCloseButton.Font = new Font("Ink Free", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCloseButton.ForeColor = Color.FromArgb(172, 189, 207);
            lblCloseButton.Location = new Point(1242, 9);
            lblCloseButton.Name = "lblCloseButton";
            lblCloseButton.Size = new Size(26, 34);
            lblCloseButton.TabIndex = 4;
            lblCloseButton.Text = "X";
            lblCloseButton.Click += lblCloseButton_Click;
            lblCloseButton.MouseEnter += lblCloseButton_MouseEnter;
            lblCloseButton.MouseLeave += lblCloseButton_MouseLeave;
            // 
            // lblHideButton
            // 
            lblHideButton.AutoSize = true;
            lblHideButton.Cursor = Cursors.Hand;
            lblHideButton.Font = new Font("Ink Free", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHideButton.ForeColor = Color.FromArgb(172, 189, 207);
            lblHideButton.Location = new Point(1207, 8);
            lblHideButton.Name = "lblHideButton";
            lblHideButton.Size = new Size(29, 34);
            lblHideButton.TabIndex = 3;
            lblHideButton.Text = "_";
            lblHideButton.Click += lblHideButton_Click;
            lblHideButton.MouseEnter += lblHideButton_MouseEnter;
            lblHideButton.MouseLeave += lblHideButton_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(172, 189, 207);
            panel1.Location = new Point(12, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(1096, 3);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(172, 189, 207);
            label1.Location = new Point(480, 2);
            label1.Name = "label1";
            label1.Size = new Size(340, 35);
            label1.TabIndex = 6;
            label1.Text = "Телефонный справочник";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 62, 81);
            ClientSize = new Size(1280, 720);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(lblHideButton);
            Controls.Add(lblCloseButton);
            Controls.Add(tbSearch);
            Controls.Add(bEdit);
            Controls.Add(dgMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "1";
            Text = "Main";
            Load += Main_Load;
            MouseDown += Main_MouseDown;
            MouseMove += Main_MouseMove;
            ((System.ComponentModel.ISupportInitialize)dgMain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgMain;
        private Button bEdit;
        private TextBox tbSearch;
        private Label lblCloseButton;
        private Label lblHideButton;
        private Panel panel1;
        private Label label1;
    }
}