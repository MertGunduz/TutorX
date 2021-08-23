using System;
using System.Windows.Forms;

namespace TutorX
{
    public partial class TutorX_OperationSelectionMenu : Form
    {
        public TutorX_OperationSelectionMenu()
        {
            InitializeComponent();
        }

        private void AddDatas_Button_Click(object sender, EventArgs e)
        {
            TutorX_AddDataMenu tutorX_AddDataMenu = new TutorX_AddDataMenu();
            this.Hide();
            tutorX_AddDataMenu.Show();
        }

        private void CreateLectures_Button_Click(object sender, EventArgs e)
        {
            TutorX_SetLecturesMenu tutorX_SetLecturesMenu = new TutorX_SetLecturesMenu();
            this.Hide();
            tutorX_SetLecturesMenu.Show();
        }
    }
}
