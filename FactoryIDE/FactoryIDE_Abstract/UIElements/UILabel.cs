﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryIDE_Abstract.UIElements {

    public abstract class UILabel : UIElement {

        public override string ToString()
        {
            return "Label(text, width, height)";
        }
    }
}
