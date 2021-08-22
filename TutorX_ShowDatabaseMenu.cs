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
using TutorX.Properties;

namespace TutorX
{
    public partial class TutorX_ShowDatabaseMenu : Form
    {
        // OleDbConnection 
        OleDbConnection oleDbConnection = new OleDbConnection(Database.databaseClass);

        public TutorX_ShowDatabaseMenu()
        {
            InitializeComponent();
        }

        private void Minimize_Button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Dynamic_DataGridView_MouseEnter(object sender, EventArgs e)
        {
            if (TutorX_AddDataMenu.showDatabase == TutorX_AddDataMenu.ShowDatabase.Student)
            {
                Specifier_Label.Image = Resources.students_database;

                oleDbConnection.Open();
                OleDbCommand readStudentDatabaseCommand = new OleDbCommand("Select * From Students_Table", oleDbConnection);
               
                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
                oleDbDataAdapter.SelectCommand = readStudentDatabaseCommand;

                DataTable dataTable = new DataTable();
                oleDbDataAdapter.Fill(dataTable);

                oleDbConnection.Close();

                Dynamic_DataGridView.DataSource = dataTable;
            }
            else if (TutorX_AddDataMenu.showDatabase == TutorX_AddDataMenu.ShowDatabase.Lesson)
            {
                Specifier_Label.Image = Resources.lessons_database;

                oleDbConnection.Open();
                OleDbCommand readLessonsDatabaseCommand = new OleDbCommand("Select * From Lessons_Table", oleDbConnection);

                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
                oleDbDataAdapter.SelectCommand = readLessonsDatabaseCommand;

                DataTable dataTable = new DataTable();
                oleDbDataAdapter.Fill(dataTable);

                oleDbConnection.Close();

                Dynamic_DataGridView.DataSource = dataTable;
            }
            else if (TutorX_AddDataMenu.showDatabase == TutorX_AddDataMenu.ShowDatabase.Teacher)
            {
                Specifier_Label.Image = Resources.teachers_database;

                oleDbConnection.Open();
                OleDbCommand readTeachersDatabaseCommand = new OleDbCommand("Select * From Teachers_Table", oleDbConnection);

                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
                oleDbDataAdapter.SelectCommand = readTeachersDatabaseCommand;

                DataTable dataTable = new DataTable();
                oleDbDataAdapter.Fill(dataTable);

                oleDbConnection.Close();

                Dynamic_DataGridView.DataSource = dataTable;
            }
        }
    }
}
