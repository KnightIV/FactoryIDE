using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryIDE_Abstract.Factories;
using FactoryIDE_Abstract.UIElements;

namespace FactoryIDE.FactoryImplementations {

    public class WPFElementFactory : IUIElementFactory {

        public UIButton CreateUIButton(string content, int height, int width, int top, int left) {
            throw new NotImplementedException();
        }

        public UILabel CreateUILabel(string content, int height, int width, int top, int left) {
            throw new NotImplementedException();
        }

        public UITextBox CreateUITextBox(string content, int height, int width, int top, int left) {
            throw new NotImplementedException();
        }

        public UIRectangle CreateUIRectangle(string content, int height, int width, int top, int left) {
            throw new NotImplementedException();
        }
    }
}
