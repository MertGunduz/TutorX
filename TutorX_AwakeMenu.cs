using System;
using System.Threading;
using System.Windows.Forms;

namespace TutorX
{
    public partial class TutorX_AwakeMenu : Form
    {
        // Timer Data
        int estimatedTime = 0;

        public TutorX_AwakeMenu()
        {
            InitializeComponent();
        }

        private void AwakeTimer_Tick(object sender, EventArgs e)
        {
            // Increases Estimatedtime By 1 Every Tick
            if (estimatedTime != 100)
            {
                estimatedTime++;
            }
            else
            {
                // Stops Timer
                AwakeTimer.Stop();

                // Form Object Created & Main Menu Showed
                TutorX_AddDataMenu tutorX_AddDataMenu = new TutorX_AddDataMenu();
                this.Hide();
                tutorX_AddDataMenu.Show();
            }
        }
    }
}
