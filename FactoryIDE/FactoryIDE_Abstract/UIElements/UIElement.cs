using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryIDE_Abstract.UIElements {

    public abstract class UIElement {

        public string Content { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Top { get; set; }
        public int Left { get; set; }

        public abstract string Render();
    }
}
