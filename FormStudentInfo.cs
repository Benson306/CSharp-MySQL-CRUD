namespace CSharp_MySQL_CRUD
{
    public partial class FormStudentInfo : Form
    {
        public FormStudentInfo()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormStudent form = new FormStudent();
            form.ShowDialog();
        }
    }
}