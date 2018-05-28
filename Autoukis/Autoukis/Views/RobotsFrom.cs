using System;
using System.Drawing;
using System.Windows.Forms;

namespace Autoukis
{
    public partial class RobotsFrom : Form
    {
        public RobotsFrom()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        void btn_Robot1_Click(object sender, EventArgs e)
        {
            btn_Robot1.BackColor = Color.Green;
            btn_Robot2.BackColor = Color.Gray;
            btn_Robot3.BackColor = Color.Gray;
            btn_Robot4.BackColor = Color.Gray;
        }

        void btn_Robot2_Click(object sender, EventArgs e)
        {
            btn_Robot1.BackColor = Color.Gray;
            btn_Robot2.BackColor = Color.Green;
            btn_Robot3.BackColor = Color.Gray;
            btn_Robot4.BackColor = Color.Gray;
        }

        void btn_Robot3_Click(object sender, EventArgs e)
        {
            btn_Robot1.BackColor = Color.Gray;
            btn_Robot2.BackColor = Color.Gray;
            btn_Robot3.BackColor = Color.Green;
            btn_Robot4.BackColor = Color.Gray;
        }

        void btn_Robot4_Click(object sender, EventArgs e)
        {
            btn_Robot1.BackColor = Color.Gray;
            btn_Robot2.BackColor = Color.Gray;
            btn_Robot3.BackColor = Color.Gray;
            btn_Robot4.BackColor = Color.Green;
        }

        void btn_Back_Click(object sender, EventArgs e)
        {
            var landingForm = new LandingForm();
            landingForm.Show();

            Hide();
        }
    }
}
