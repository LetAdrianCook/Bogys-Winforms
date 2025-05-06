using Bogys_Winforms.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogys_Winforms.Services
{
    class InputValidator
    {
        StringsVariables strTxt = new StringsVariables();
        public bool ValidateTextBox(TextBox txt, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                MessageBox.Show(fieldName + strTxt.inputValidator, strTxt.validationTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt.Focus();
                return false;
            }
            return true;
        }
    }
}
