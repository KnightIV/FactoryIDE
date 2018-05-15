using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryIDE_Abstract.Factories;
using FactoryIDE_Abstract.UIElements;
using FactoryIDE.UIElements;

namespace FactoryIDE.FactoryImplementations {

    public class HTMLElementFactory : IUIElementFactory {

        public UIButton CreateUIButton(string content, int height, int width, int top, int left) {
            return new UIHTMLButton()
            {
                Content = content,
                Height = height,
                Width = width,
                Top = top,
                Left = left

            };
        }

        public UILabel CreateUILabel(string content, int height, int width, int top, int left) {
            return new UIHTMLLabel()
            {
                Content = content,
                Height = height,
                Width = width,
                Top = top,
                Left = left

            };
        }

        public UITextBox CreateUITextBox(string content, int height, int width, int top, int left) {
            return new UIHTMLTextBox()
            {
                Content = content,
                Height = height,
                Width = width,
                Top = top,
                Left = left

            };
        }

        public UIRectangle CreateUIRectangle(string content, int height, int width, int top, int left) {
            return new UIHTMLRectangle()
            {
                Content = content,
                Height = height,
                Width = width,
                Top = top,
                Left = left

            };
        }
    }
}
