using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FactoryIDE_Abstract.Factories;
using FactoryIDE_Abstract.UIElements;

namespace FactoryIDE_Abstract.IDE {

    public abstract class IDE {

        public List<UIElement> Elements { get; set; }
        public abstract UIElementFactory ElementFactory { get; protected set; }

        protected IDE() {
            Elements = new List<UIElement>();
        }

        public void AddButton(string content, int height, int width, int top, int left) => Elements.Add(ElementFactory.CreateUIButton(content, height, width, top, left));

        public void AddLabel(string content, int height, int width, int top, int left) => Elements.Add(ElementFactory.CreateUILabel(content, height, width, top, left));

        public void AddTextBox(string content, int height, int width, int top, int left) => Elements.Add(ElementFactory.CreateUITextBox(content, height, width, top, left));

        public void AddRectangle(string content, int height, int width, int top, int left) => Elements.Add(ElementFactory.CreateUIRectangle(content, height, width, top, left));

        public abstract void Compile(string fileName);
    }
}