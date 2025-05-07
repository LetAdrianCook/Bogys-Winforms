using Bogys_Winforms.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogys_Winforms.Services
{
    internal class NavigationControl
    {
        List<UserControl> userControlList = new List<UserControl>();
        Panel panel;
        StringsVariables strTxt = new StringsVariables();

        public NavigationControl(List<UserControl> userControlList, Panel panel) {
        
            this.userControlList = userControlList;
            this.panel = panel;
            AddUserControls();
        }

        private void AddUserControls()
        {
            for (int i = 0; i < userControlList.Count(); i++)
            {
                userControlList[i].Dock = DockStyle.Fill;
                panel.Controls.Add(userControlList[i]);
            }
        }
        public void Display(int index)
        {
            if (index < userControlList.Count)
            {
                var control = userControlList[index];
                var method = control.GetType().GetMethod(strTxt.refreshtab);
                if (method != null)
                {
                    method.Invoke(control, null);
                }
                control.BringToFront();
            }
        }

    }
}
