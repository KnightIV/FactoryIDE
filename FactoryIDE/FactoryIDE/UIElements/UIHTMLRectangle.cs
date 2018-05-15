using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryIDE_Abstract.UIElements;

namespace FactoryIDE.UIElements
{
    public class UIHTMLRectangle : UIRectangle
    {
        public override string Render()
        {
            return "<div border:solid thick black>Content</div>";
        }
    }
}
