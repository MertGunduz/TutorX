using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace TutorX
{
    public partial class TutorX_AddDataMenu : Form
    {
        // Datbase Connection
        OleDbConnection oleDbConnection = new OleDbConnection(Database.databaseClass);

        // Picked Menu
        public enum ShowDatabase
        {
            Student,
            Lesson,
            Teacher
        }

        public static ShowDatabase showDatabase;

        // Form Object
        TutorX_ShowDatabaseMenu tutorX_ShowDatabaseMenu = new TutorX_ShowDatabaseMenu();

        public TutorX_AddDataMenu()
        {
            InitializeComponent();
        }


        private void ShowStudentDatabase_Button_Click(object sender, EventArgs e)
        {
            showDatabase = ShowDatabase.Student;
            tutorX_ShowDatabaseMenu.Show();
        }

        private void ShowLessonDatabase_Button_Click(object sender, EventArgs e)
        {
            showDatabase = ShowDatabase.Lesson;
            tutorX_ShowDatabaseMenu.Show();
        }

        private void ShowTeacherDatabase_Button_Click(object sender, EventArgs e)
        {
            showDatabase = ShowDatabase.Teacher;
            tutorX_ShowDatabaseMenu.Show();
        }

        private void AddStudent_Button_Click(object sender, EventArgs e)
        {
            oleDbConnection.Open();
            OleDbCommand addStudentCommand = new OleDbCommand("Insert Into Students_Table (Student_Name, Student_Surname, Student_Birth) Values (@p1, @p2, @p3)", oleDbConnection);
            addStudentCommand.Parameters.AddWithValue("@p1", StudentName_TextBox.Text);
            addStudentCommand.Parameters.AddWithValue("@p2", StudentSurname_TextBox.Text);
            addStudentCommand.Parameters.AddWithValue("@p3", StudentBirth_TextBox.Text);
            addStudentCommand.ExecuteNonQuery();
            oleDbConnection.Close();
        }

        private void AddLesson_Button_Click(object sender, EventArgs e)
        {
            oleDbConnection.Open();
            OleDbCommand readLessonCommand = new OleDbCommand("Select Lesson_Name From Lessons_Table Where Lesson_Name = @p1", oleDbConnection);
            readLessonCommand.Parameters.AddWithValue("@p1", LessonName_TextBox.Text);
            OleDbDataReader readLessonReader = readLessonCommand.ExecuteReader();

            if (readLessonReader.Read())
            {
                MessageBox.Show("This Lesson Exists in Database!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            readLessonReader.Close();
            oleDbConnection.Close();

            oleDbConnection.Open();
            OleDbCommand addLessonCommand = new OleDbCommand("Insert Into Lessons_Table (Lesson_Name) Values (@p1)", oleDbConnection);
            addLessonCommand.Parameters.AddWithValue("@p1", LessonName_TextBox.Text);
            addLessonCommand.ExecuteNonQuery();
            oleDbConnection.Close();
        }

        private void AddTeacher_Button_Click(object sender, EventArgs e)
        {
            oleDbConnection.Open();
            OleDbCommand addTeacherCommand = new OleDbCommand("Insert Into Teachers_Table (Teacher_Name, Teacher_Surname, Teacher_Birth, Teacher_Field) Values (@p1, @p2, @p3, @p4)", oleDbConnection);
            addTeacherCommand.Parameters.AddWithValue("@p1", TeacherName_TextBox.Text);
            addTeacherCommand.Parameters.AddWithValue("@p2", TeacherSurname_TextBox.Text);
            addTeacherCommand.Parameters.AddWithValue("@p3", TeacherBirth_TextBox.Text);
            addTeacherCommand.Parameters.AddWithValue("@p4", TeacherField_TextBox.Text);
            addTeacherCommand.ExecuteNonQuery();
            oleDbConnection.Close();
        }

        private void Minimize_Button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void StudentName_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (StudentName_TextBox.Text == "  Student Name:")
            {
                StudentName_TextBox.Clear();
            }
        }

        private void StudentSurname_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (StudentSurname_TextBox.Text == "  Student Surname:")
            {
                StudentSurname_TextBox.Clear();
            }
        }

        private void StudentBirth_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (StudentBirth_TextBox.Text == "  Student Birth:")
            {
                StudentBirth_TextBox.Clear();
            }
        }

        private void LessonName_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (LessonName_TextBox.Text == "  Lesson Name:")
            {
                LessonName_TextBox.Clear();
            }
        }

        private void TeacherName_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (TeacherName_TextBox.Text == "  Teacher Name:")
            {
                TeacherName_TextBox.Clear();
            }
        }

        private void TeacherSurname_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (TeacherSurname_TextBox.Text == "  Teacher Surname:")
            {
                TeacherSurname_TextBox.Clear();
            }
        }

        private void TeacherBirth_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (TeacherBirth_TextBox.Text == "  Teacher Birth:")
            {
                TeacherBirth_TextBox.Clear();
            }
        }

        private void TeacherField_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (TeacherField_TextBox.Text == "  Teacher Field:")
            {
                TeacherField_TextBox.Clear();
            }
        }
    }
}
