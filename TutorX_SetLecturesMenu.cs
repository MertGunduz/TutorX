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
    public partial class TutorX_SetLecturesMenu : Form
    {
        OleDbConnection oleDbConnection = new OleDbConnection(Database.databaseClass);

        public TutorX_SetLecturesMenu()
        {
            InitializeComponent();
        }

        private void TutorX_SetLecturesMenu_Load(object sender, EventArgs e)
        {
            oleDbConnection.Open();
            OleDbCommand readLectureDataCommand = new OleDbCommand("Select * From Lectures_Table", oleDbConnection);

            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
            oleDbDataAdapter.SelectCommand = readLectureDataCommand;

            DataTable dataTable = new DataTable();
            oleDbDataAdapter.Fill(dataTable);

            Lecture_DataGridView.DataSource = dataTable;
            oleDbConnection.Close();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
