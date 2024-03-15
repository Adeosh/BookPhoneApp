using BookPhoneApp.Core.Data;
using BookPhoneApp.Core.Samples;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace BookPhoneApp
{
    public partial class btnEdit : Form
    {
        public btnEdit()
        {
            InitializeComponent();
            EllipseWindow();
        }

        #region Ellipse
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void EllipseWindow()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        #endregion

        #region Options

        long PersonId;
        Int64 RowId;

        private void lblCloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblCloseButton_MouseEnter(object sender, EventArgs e)
        {
            lblCloseButton.ForeColor = Color.FromArgb(193, 101, 117);
        }

        private void lblCloseButton_MouseLeave(object sender, EventArgs e)
        {
            lblCloseButton.ForeColor = Color.FromArgb(172, 189, 207);
        }

        private void lblHideButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblHideButton_MouseEnter(object sender, EventArgs e)
        {
            lblHideButton.ForeColor = Color.FromArgb(193, 101, 117);
        }

        private void lblHideButton_MouseLeave(object sender, EventArgs e)
        {
            lblHideButton.ForeColor = Color.FromArgb(172, 189, 207);
        }

        private void lblBackButton_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void lblBackButton_MouseEnter(object sender, EventArgs e)
        {
            lblBackButton.ForeColor = Color.FromArgb(193, 101, 117);
        }

        private void lblBackButton_MouseLeave(object sender, EventArgs e)
        {
            lblBackButton.ForeColor = Color.FromArgb(172, 189, 207);
        }

        Point lastPoint;
        private void Edit_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Edit_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            if (tbSearch.Text == "Поиск...")
            {
                tbSearch.Text = "";
                tbSearch.ForeColor = Color.FromArgb(172, 189, 207);
            }
        }

        private void tbSearch_Leave(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                tbSearch.Text = "";
                tbSearch.ForeColor = Color.FromArgb(172, 189, 207);
            }
        }
        #endregion

        #region ToolTips
        private ToolTip toolTip = new ToolTip();
        private TxtSample txtSample = new TxtSample();

        private void lblTxt_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Show(txtSample.Text, lblTxt, 40, 20);

            string toolTipText = toolTip.GetToolTip(lblTxt);
            Clipboard.SetText(toolTipText);
        }

        private void lblTxt_MouseLeave(object sender, EventArgs e)
        {
            toolTip.Hide(lblTxt);
        }

        private void lblSql_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Show(txtSample.SQL, lblSql, 40, 20);

            string toolTipText = toolTip.GetToolTip(lblSql);
            Clipboard.SetText(toolTipText);
        }

        private void lblSql_MouseLeave(object sender, EventArgs e)
        {
            toolTip.Hide(lblSql);
        }
        #endregion

        private void bInsert_Click(object sender, EventArgs e)
        {
            DateTime selectDate = dtBirth.Value.Date;

            BookPhoneDB db = new BookPhoneDB();
            db.OpenConnection();

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = db.GetConnection();

                try
                {
                    cmd.CommandText =
                        """
                        BEGIN TRANSACTION;
                        INSERT INTO Persons (FirstName, MiddleName, LastName) VALUES (@FirstName, @MiddleName, @LastName);
                        DECLARE @PersonId BIGINT;
                        SET @PersonId = SCOPE_IDENTITY();
                        INSERT INTO Phone (PhoneNumber, PersonId) VALUES (@PhoneNumber, @PersonId);
                        INSERT INTO Address (AddressOf, PersonId) VALUES (@AddressOf, @PersonId);
                        INSERT INTO BirthDate (BirthDate, PersonId) VALUES (@BirthDate, @PersonId);
                        COMMIT TRANSACTION;
                        """;

                    cmd.Parameters.AddWithValue("@FirstName", tbFirstName.Text);
                    cmd.Parameters.AddWithValue("@MiddleName", tbMiddleName.Text);
                    cmd.Parameters.AddWithValue("@LastName", tbLastName.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", tbPhone.Text);
                    cmd.Parameters.AddWithValue("@AddressOf", tbAddress.Text);
                    cmd.Parameters.AddWithValue("@BirthDate", selectDate);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Контакт создан!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Контакт не создан!" + ex.Message);
                }
            }

            db.CloseConnection();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DateTime selectDate = dtBirth.Value.Date;

            BookPhoneDB db = new BookPhoneDB();
            db.OpenConnection();

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = db.GetConnection();

                try
                {
                    cmd.CommandText =
                     """
                    BEGIN TRANSACTION;
                    DECLARE @PersonId BIGINT;
                    UPDATE Persons
                    SET
                    @PersonId = SCOPE_IDENTITY(),
                    FirstName = @FirstName,
                    MiddleName = @MiddleName,
                    LastName = @LastName
                    WHERE Id = @ExistingId;
                    UPDATE Phone
                    SET PhoneNumber = @PhoneNumber
                    WHERE PersonId = @ExistingId;
                    UPDATE Address
                    SET AddressOf = @AddressOf
                    WHERE PersonId = @ExistingId;
                    UPDATE BirthDate
                    SET BirthDate = @BirthDate
                    WHERE PersonId = @ExistingId;
                    COMMIT TRANSACTION;
                    """;

                    cmd.Parameters.Add("@ExistingId", SqlDbType.BigInt).Value = long.Parse(RowId.ToString());
                    cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = tbFirstName.Text;
                    cmd.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = tbMiddleName.Text;
                    cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = tbLastName.Text;
                    cmd.Parameters.Add("@PhoneNumber", SqlDbType.VarChar).Value = tbPhone.Text;
                    cmd.Parameters.Add("@AddressOf", SqlDbType.VarChar).Value = tbAddress.Text;
                    cmd.Parameters.Add("@BirthDate", SqlDbType.Date).Value = selectDate;

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Контакт обновлён!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Контакт не обновлён!" + ex.Message);
                }
            }

            db.CloseConnection();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Контакт будет удалён. Подтвердить?", "Confirmation Dialog",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    BookPhoneDB db = new BookPhoneDB();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Persons " +
                        "WHERE Id = " + RowId + "", db.GetConnection());
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet set = new DataSet();
                    adapter.Fill(set);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Контакт не удалён!" + ex.Message);
            }
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            BookPhoneDB db = new BookPhoneDB();
            db.OpenConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db.GetConnection();
            cmd.CommandText =
                """
                SELECT p.Id, p.FirstName, p.MiddleName, p.LastName,
                       ph.PhoneNumber,
                       a.AddressOf,
                       b.BirthDate
                FROM Persons p
                LEFT JOIN Phone ph ON p.Id = ph.PersonId
                LEFT JOIN Address a ON p.Id = a.PersonId  
                LEFT JOIN BirthDate b ON p.Id = b.PersonId;
                """;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgEdit.DataSource = dt;

            dtBirth.Format = DateTimePickerFormat.Custom;
        }

        private void dgEdit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgEdit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                PersonId = long.Parse(dgEdit.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgEdit.Rows[e.RowIndex];
                RowId = Int64.Parse(row.Cells[0].Value.ToString());
                tbFirstName.Text = row.Cells[1].Value.ToString();
                tbMiddleName.Text = row.Cells[2].Value.ToString();
                tbLastName.Text = row.Cells[3].Value.ToString();
                tbPhone.Text = row.Cells[4].Value.ToString();
                tbAddress.Text = row.Cells[5].Value.ToString();
                dtBirth.Text = row.Cells[6].Value.ToString();
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            (dgEdit.DataSource as DataTable).DefaultView.RowFilter =
                $"FirstName LIKE '%{tbSearch.Text}%' " +
                $"OR MiddleName LIKE '%{tbSearch.Text}%' " +
                $"OR LastName LIKE '%{tbSearch.Text}%' " +
                $"OR PhoneNumber LIKE '%{tbSearch.Text}%' " +
                $"OR AddressOf LIKE '%{tbSearch.Text}%' " +
                $"OR Convert(BirthDate, 'System.String') LIKE '%{tbSearch.Text}%'";
        }

        private void dgEdit_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgEdit.Columns[0].HeaderText = "~";
            dgEdit.Columns[1].HeaderText = "Имя";
            dgEdit.Columns[2].HeaderText = "Отчество";
            dgEdit.Columns[3].HeaderText = "Фамилия";
            dgEdit.Columns[4].HeaderText = "Номер телефона";
            dgEdit.Columns[5].HeaderText = "Адрес";
            dgEdit.Columns[6].HeaderText = "Дата рождения";
        }

        private void bFromTxt_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogFromTxt = new OpenFileDialog();

            openFileDialogFromTxt.Filter = "Text Files|*.txt";
            openFileDialogFromTxt.Title = "Выберите файл для выполнения SQL команд";

            if (openFileDialogFromTxt.ShowDialog() == DialogResult.OK)
            {
                string file = File.ReadAllText(openFileDialogFromTxt.FileName);

                using (SqlConnection connection = new SqlConnection(
                    ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(file, connection))
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private void bFromSQL_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "SQL Files|*.sql";
            openFileDialog.Title = "Выберите SQL файл для выполнения SQL команд";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = File.ReadAllText(openFileDialog.FileName);

                using (SqlConnection connection = new SqlConnection(
                ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(file, connection))
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tbFirstName.Clear();
            tbMiddleName.Clear();
            tbLastName.Clear();
            tbPhone.Clear();
            tbAddress.Clear();
        }
    }
}
