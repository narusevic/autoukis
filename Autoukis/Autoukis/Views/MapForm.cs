using DotNetBrowser;
using DotNetBrowser.WinForms;
using System;
using System.Windows.Forms;

namespace Autoukis
{
    public partial class MapForm : Form
    {
        BrowserView browserView;

        public MapForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();

            browserView = new WinFormsBrowserView();
            pnl_Map.Controls.Add((Control)browserView.GetComponent());
            browserView.Browser.LoadURL("http://maps.google.com");
        }

        void btn_OK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Problema", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        void btn_Back_Click(object sender, EventArgs e)
        {
            var landingForm = new LandingForm();
            landingForm.Show();

            Hide();
        }
    }
}
