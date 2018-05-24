using System;
using System.Windows.Forms;

namespace Autoukis
{
    public partial class FeedingForm : Form
    {
        public FeedingForm()
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
