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
    public partial class CustomerDashboard : Form
    {
        NavigationControl navigationControl;
        NavigationButtons navigationButtons;

        Color btndDefaultColor = Color.FromArgb(61, 52, 70);
        Color btndSelectedColor = Color.FromArgb(80, 68, 92);
        public CustomerDashboard()
        {
            InitializeComponent();
            InitializeNavigationButton();
            InitializeNavigationControl();
        }
        private void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>()
            { new RentalModule()};

            navigationControl = new NavigationControl(userControls, dashboardPanel);
            navigationControl.Display(0);
        }
        private void InitializeNavigationButton()
        {
            List<Button> buttons = new List<Button>()
            { rentalBtn };

            navigationButtons = new NavigationButtons(buttons, btndDefaultColor, btndSelectedColor);
            navigationButtons.Highlight(rentalBtn);
        }
        private void rentalBtn_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);
            navigationButtons.Highlight(rentalBtn);
        }
    }
}
