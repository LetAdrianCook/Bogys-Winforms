using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bogys_Winforms.Services
{
    public class NavigationButtons
    {
        private List<Button> buttons; 
        private Color defaultColor; 
        private Color selectedColor; 

        public NavigationButtons(List<Button> buttons, Color defaultColor, Color selectedColor)
        {
            this.buttons = buttons;
            this.defaultColor = defaultColor;
            this.selectedColor = selectedColor;
        }
        public void Highlight(Button selectedButton)
        {
            foreach (Button button in buttons)
            {
                if (button == selectedButton)
                {
                    button.BackColor = selectedColor;
                    button.ForeColor = Color.White; 
                }
                else
                {
                    button.BackColor = defaultColor; 
                    button.ForeColor = Color.FromArgb(255, 228, 186); 
                }
            }
        }
    }
}