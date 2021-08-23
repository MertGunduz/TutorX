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
    public partial class TutorX_AddLectureMenu : Form
    {
        // OleDbConnection
        OleDbConnection oleDbConnection = new OleDbConnection(Database.databaseClass);

        public TutorX_AddLectureMenu()
        {
            InitializeComponent();
        }
        private void TutorX_AddLectureMenu_Load(object sender, EventArgs e)
        {
            // Student Reader
            oleDbConnection.Open();
            OleDbCommand readStudentCommand = new OleDbCommand("Select Student_Name, Student_Surname From Students_Table", oleDbConnection);
            OleDbDataReader studentReader = readStudentCommand.ExecuteReader();

            while (studentReader.Read())
            {
                Student_ComboBox.Items.Add(studentReader[0].ToString() + " " + studentReader[1].ToString());
            }

            studentReader.Close();
            oleDbConnection.Close();

            // Lesson Reader
            oleDbConnection.Open();
            OleDbCommand readLessonCommand = new OleDbCommand("Select Lesson_Name From Lessons_Table", oleDbConnection);
            OleDbDataReader lessonReader = readLessonCommand.ExecuteReader();

            while (lessonReader.Read())
            {
                Lesson_ComboBox.Items.Add(lessonReader[0].ToString());
            }

            lessonReader.Close();
            oleDbConnection.Close();

            // Teacher Reader
            oleDbConnection.Open();
            OleDbCommand readTeachersCommand = new OleDbCommand("Select Teacher_Name, Teacher_Surname From Teachers_Table", oleDbConnection);
            OleDbDataReader teacherReader = readTeachersCommand.ExecuteReader();

            while (teacherReader.Read())
            {
                Teacher_ComboBox.Items.Add(teacherReader[0].ToString());
            }

            teacherReader.Close();
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

        private void AddStudent_Button_Click(object sender, EventArgs e)
        {
            oleDbConnection.Open();
            OleDbCommand addLectureCommand = new OleDbCommand("Insert Into Lectures_Table (Lecture_Student, Lecture_Teacher, Lecture_Lesson, Lecture_Date) Values (@p1, @p2, @p3, @p4)", oleDbConnection);
            addLectureCommand.Parameters.AddWithValue("@p1", Student_ComboBox.Text);
            addLectureCommand.Parameters.AddWithValue("@p2", Teacher_ComboBox.Text);
            addLectureCommand.Parameters.AddWithValue("@p3", Lesson_ComboBox.Text);
            addLectureCommand.Parameters.AddWithValue("@p4", Date_TextBox.Text);
            addLectureCommand.ExecuteNonQuery();
            oleDbConnection.Close();
        }
    }
}
