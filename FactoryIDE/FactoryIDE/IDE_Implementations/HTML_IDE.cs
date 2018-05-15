using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryIDE.FactoryImplementations;
using FactoryIDE_Abstract.Factories;
using FactoryIDE_Abstract.IDE;

namespace FactoryIDE.IDE_Implementations {

    public class HTML_IDE : IDE {

        public override void Compile(string fileName) {
            throw new NotImplementedException();
        }

        public override IUIElementFactory CreateFactory() {
            return new HTMLElementFactory();
        }
    }
}
