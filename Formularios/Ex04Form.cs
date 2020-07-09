using POOP2.Classes.Ex04;
using System;
using System.Windows.Forms;

namespace POOP2.Formularios
{
    public partial class Ex04Form : Form
    {
        private Professor _professor;
        public Ex04Form()
        {
            _professor = new Professor();
            InitializeComponent();
        }

        private void btnEditProfessor_Click(Object sender, EventArgs e)
        {
            _professor.Name = txtProfessorName.Text;
            _professor.GradeName = txtGradeName.Text;
            MessageBox.Show("Professor editado com sucesso!");
        }

        private void btnPrintProfessor_Click(Object sender, EventArgs e)
        {
            _professor.Print();
        }

        private void btnAddStudent_Click(Object sender, EventArgs e)
        {
            _professor.Students.Add(new Student(txtStudentName.Text, _professor));
            UpdateStudentsListView();
            MessageBox.Show("Aluno adicionado com sucesso!");
        }

        private void UpdateStudentsListView()
        {
            listViewStudents.Items.Clear();
            _professor.Students.ForEach(s => listViewStudents.Items.Add(s));
        }

        private void btnMakeTest_Click(Object sender, EventArgs e)
        {
            if(listViewStudents.SelectedItem == null)
            {
                MessageBox.Show("Selecione um aluno antes de aplicar a prova!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Student student = (Student)listViewStudents.SelectedItem;
            student.MakeTest();
            MessageBox.Show($"Prova feita com sucesso!\nNota do aluno: {student.Grade}");
        }

        private void btnPrintSelectedStudent_Click(Object sender, EventArgs e)
        {
            if (listViewStudents.SelectedItem == null)
            {
                MessageBox.Show("Selecione um aluno antes imprimir!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Student student = (Student)listViewStudents.SelectedItem;
            student.Print();
        }

    }
}
