using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryIDE_Abstract.UIElements {

    public abstract class UIButton : UIElement {

        public override string ToString()
        {
            return "Button(text, width, height)";
        }
    }
}
