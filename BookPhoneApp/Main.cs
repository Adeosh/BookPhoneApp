using BookPhoneApp.Core.Data;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace BookPhoneApp
{
    public partial class Main : Form
    {
        public Main()
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
        private void bEdit_Click(object sender, EventArgs e)
        {
            btnEdit edit = new btnEdit();
            edit.Show();
            this.Hide();
        }

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

        private void dgMain_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgMain.Columns["Id"].Visible = false;
            dgMain.Columns[1].HeaderText = "Имя";
            dgMain.Columns[2].HeaderText = "Отчество";
            dgMain.Columns[3].HeaderText = "Фамилия";
            dgMain.Columns[4].HeaderText = "Номер телефона";
            dgMain.Columns[5].HeaderText = "Адрес";
            dgMain.Columns[6].HeaderText = "Дата рождения";
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

        Point lastPoint;
        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        #endregion   

        private void Main_Load(object sender, EventArgs e)
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
            DataSet set = new DataSet();
            adapter.Fill(set);
            dgMain.DataSource = set.Tables[0];
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            (dgMain.DataSource as DataTable).DefaultView.RowFilter =
                $"FirstName LIKE '%{tbSearch.Text}%' " +
                $"OR MiddleName LIKE '%{tbSearch.Text}%' " +
                $"OR LastName LIKE '%{tbSearch.Text}%' " +
                $"OR PhoneNumber LIKE '%{tbSearch.Text}%' " +
                $"OR AddressOf LIKE '%{tbSearch.Text}%' " +
                $"OR Convert(BirthDate, 'System.String') LIKE '%{tbSearch.Text}%'";
        }
    }
}
