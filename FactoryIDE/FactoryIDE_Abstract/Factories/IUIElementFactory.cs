using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FactoryIDE_Abstract.UIElements;

namespace FactoryIDE_Abstract.Factories {

    public interface IUIElementFactory {

        UIButton CreateUIButton(string content, int height, int width, int top, int left);
        UILabel CreateUILabel(string content, int height, int width, int top, int left);
        UITextBox CreateUITextBox(string content, int height, int width, int top, int left);
        UIRectangle CreateUIRectangle(string content, int height, int width, int top, int left);
    }
}
