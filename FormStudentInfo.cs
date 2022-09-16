namespace CSharp_MySQL_CRUD
{
    public partial class FormStudentInfo : Form
    {
        public FormStudentInfo()
        {
            InitializeComponent();
        }
        public void Display()
        {
            DbStudent.DisplayAndSearchStudents("SELECT id, name, reg, class, section FROM students_table",dataGridView);
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            FormStudent form = new FormStudent(this);
            form.ShowDialog();
        }

        private void FormStudentInfo_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DbStudent.DisplayAndSearchStudents("SELECT id, name, reg, class, section FROM students_table WHERE name LIKE '%"+ txtSearch.Text +"%'", dataGridView);
        }
    }
}