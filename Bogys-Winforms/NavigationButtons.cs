using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bogys_Winforms
{
    public class NavigationButtons
    {
        private List<Button> buttons; // List of buttons
        private Color defaultColor; // Default color for buttons
        private Color selectedColor; // Color for the selected button

        public NavigationButtons(List<Button> buttons, Color defaultColor, Color selectedColor)
        {
            this.buttons = buttons;
            this.defaultColor = defaultColor;
            this.selectedColor = selectedColor;
        }

        /// <summary>
        /// Highlights the selected button and resets the others to default color.
        /// </summary>
        /// <param name="selectedButton">The button to highlight.</param>
        public void Highlight(Button selectedButton)
        {
            foreach (Button button in buttons)
            {
                if (button == selectedButton)
                {
                    button.BackColor = selectedColor; // Set the selected button's color
                    button.ForeColor = Color.White; // Optional: Change text color for better visibility
                }
                else
                {
                    button.BackColor = defaultColor; // Reset the other buttons' color
                    button.ForeColor = Color.FromArgb(255, 228, 186); // Optional: Reset text color to default
                }
            }
        }
    }
}