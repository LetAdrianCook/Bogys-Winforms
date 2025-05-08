using Bogys_Winforms.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bogys_Winforms.Windows.Admin
{
    public partial class AdminDashboard : Form
    {
        NavigationControl navigationControl;
        NavigationButtons navigationButtons;

        Color btndDefaultColor = Color.FromArgb(61, 52, 70);
        Color btndSelectedColor = Color.FromArgb(80, 68, 92);
        public AdminDashboard()
        {
            InitializeComponent();
            InitializeNavigationButton();
            InitializeNavigationControl();
        }
        private void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>()
            { new CustomerLibrary(), new VideoLibrary(), new VideoList()};

            navigationControl = new NavigationControl(userControls, dashboardPanel);
            navigationControl.Display(0);
        }
        private void InitializeNavigationButton()
        {
            List<Button> buttons = new List<Button>()
            { customerBtn, videoBtn, listBtn};

            navigationButtons = new NavigationButtons(buttons, btndDefaultColor, btndSelectedColor);
            navigationButtons.Highlight(customerBtn);
        }
        private void customerBtn_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);
            navigationButtons.Highlight(customerBtn);
        }
        private void videoBtn_Click(object sender, EventArgs e)
        {
            navigationControl.Display(1);
            navigationButtons.Highlight(videoBtn);
        }
        private void listBtn_Click(object sender, EventArgs e)
        {
            navigationControl.Display(2);
            navigationButtons.Highlight(listBtn);
        }
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            var loginForm = new Login();
            loginForm.Show();
            this.Close();
        }
    }
}
