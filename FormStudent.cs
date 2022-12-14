using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_MySQL_CRUD
{
    public partial class FormStudent : Form
    {
        private readonly FormStudentInfo _parent;
        public string id, name, reg, section, @class;
        public FormStudent(FormStudentInfo parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public void UpdateInfo()
        {
            lbltext.Text = "Update Student Details";
            btnSave.Text = "update";
            txtName.Text = name;
            txtClass.Text = @class;
            txtReg.Text = reg;
            txtSection.Text = section;
        }
        public void saveInfo()
        {
            lbltext.Text = "Add Student";
            btnSave.Text = "Save";
        }
        public void clear()
        {
            txtName.Text = txtClass.Text = txtReg.Text = txtSection.Text = String.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtName.Text.Trim().Length < 3)
            {
                MessageBox.Show("Student Name is too short");
                return;
            }
            if (txtReg.Text.Trim().Length < 1)
            {
                MessageBox.Show("Student reg is too short");
                return;
            }
            if (txtClass.Text.Trim().Length == 0)
            {
                MessageBox.Show("Student class is too short");
                return;
            }
            if (txtSection.Text.Trim().Length < 3)
            {
                MessageBox.Show("Student Section is too short");
                return;
            }
            if (btnSave.Text == "Save")
            {
                Student std = new Student(txtName.Text.Trim(), txtReg.Text.Trim(), txtClass.Text.Trim(), txtSection.Text.Trim());
                DbStudent.addStudent(std);
                clear();
            }
            if (btnSave.Text == "update")
            {
                Student std = new Student(txtName.Text.Trim(), txtReg.Text.Trim(), txtClass.Text.Trim(), txtSection.Text.Trim());
                DbStudent.updateStudent(std, id);
                clear();
            }

            _parent.Display();
        }
    }
}
