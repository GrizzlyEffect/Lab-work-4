using laba3;
using System.ComponentModel;
using System.DirectoryServices.ActiveDirectory;

namespace lab4

{
    public partial class fMain : Form
    {

        private BindingList<Person> dataSource;

        public fMain()
        {
            InitializeComponent();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            Person data = new Person();

            fPerson fd = new fPerson(data);
            if (fd.ShowDialog() == DialogResult.OK)
            {
                dataSource.Add(data);
            }

        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            if (gvPerson.CurrentRow != null)
            {
                Person data = (Person)gvPerson.CurrentRow.DataBoundItem;

                fPerson fd = new fPerson(data);
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    gvPerson.Refresh();
                }
            }
            
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            if (gvPerson.CurrentRow != null)
            {
                if (MessageBox.Show("Видалити поточний запис?", "Видалення запису",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    Person data = (Person)gvPerson.CurrentRow.DataBoundItem;
                    dataSource.Remove(data);
                }
            }
        }

        private void btnCLEAR_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Очистити таблицю?\n\nВсі дані будуть втрачені", "Очищення даних",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                dataSource.Clear();
            }

        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }

        }

        private void FORMMAIN_Load(object sender, EventArgs e)
        {
            gvPerson.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn column;

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "FirstName";
            column.Name = "Ім'я";
            gvPerson.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "LastName";
            column.Name = "Прізвище";
            gvPerson.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Gender";
            column.Name = "Стать";
            gvPerson.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Age";
            column.Name = "Вік";
            gvPerson.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Height";
            column.Name = "Зріст";
            gvPerson.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Weight";
            column.Name = "Вага";
            gvPerson.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "HasAuto";
            column.Name = "Наявність авто";
            gvPerson.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "HasBike";
            column.Name = "Наявність велосипеду";
            gvPerson.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "BMI";
            column.Name = "ІМТ";
            gvPerson.Columns.Add(column);

            dataSource = new BindingList<Person>();

            dataSource.Add(new Person("Влад", "Саяпін", "Чоловіча", 20, 1.8, 72, true, false, 22.2));

            gvPerson.DataSource = dataSource;

            gvPerson.AutoResizeColumns();

            EventArgs args = new EventArgs();
            OnResize(args);

        }
    }
}
