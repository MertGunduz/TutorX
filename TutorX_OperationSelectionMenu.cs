using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
