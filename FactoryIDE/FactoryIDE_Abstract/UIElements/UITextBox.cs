using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryIDE_Abstract.UIElements {

    public abstract class UITextBox : UIElement {

        public override string ToString()
        {
            return "TextBox(text, width, height)";
        }
    }
}
