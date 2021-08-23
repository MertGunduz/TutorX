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
        public TutorX_AddLectureMenu()
        {
            InitializeComponent();
        }
        private void TutorX_AddLectureMenu_Load(object sender, EventArgs e)
        {

        }

        private void Minimize_Button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
