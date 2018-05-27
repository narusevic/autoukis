using System;
using System.Windows.Forms;

namespace Autoukis
{
    public partial class LandingForm : Form
    {
        public LandingForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        void btn_Notifications_Click(object sender, EventArgs e)
        {
            var notificationsForm = new NotificationsForm();
            notificationsForm.Show();

            Hide();
        }

        void btn_Feeding_Click(object sender, EventArgs e)
        {
            var feedingForm = new FeedingForm();
            feedingForm.Show();

            Hide();
        }

        void btn_ViewMap_Click(object sender, EventArgs e)
        {
            var mapForm = new MapForm();
            mapForm.Show();

            Hide();
        }
    }
}
