using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryIDE_Abstract.UIElements;

namespace FactoryIDE.UIElements
{
    public class UIHTMLButton : UIButton
    {
        public override string Render()
        {
            return "<button>Content</button>";
        }
    }
}
