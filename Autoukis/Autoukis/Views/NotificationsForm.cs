using System;
using System.Windows.Forms;

namespace Autoukis
{
    public partial class NotificationsForm : Form
    {
        public NotificationsForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        void btn_Back_Click(object sender, EventArgs e)
        {
            var landingForm = new LandingForm();
            landingForm.Show();

            Hide();
        }
    }
}
