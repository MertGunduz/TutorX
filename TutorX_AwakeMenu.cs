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
            if (estimatedTime != 100)
            {
                estimatedTime++;
            }
            else
            {
                AwakeTimer.Stop();

                // Main Menu
            }
        }
    }
}
