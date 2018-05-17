using System.IO;

using FactoryIDE_Abstract.Factories;
using FactoryIDE_Abstract.IDE;
using FactoryIDE_Abstract.UIElements;
using FactoryIDE.FactoryImplementations;

namespace FactoryIDE.IDE_Implementations {

    public class HTML_IDE : IDE {

        public override void Compile(string fileName) {
            string html = "<!DOCTYPE html>\n" +
                            "<html>\n" +
                                "<head>\n" +
                                    "<title></title>\n" +
                                "</head>\n" +
                                "<body>";

            foreach (UIElement element in Elements) {
                html += element.Render() + "\n";
            }

            html += "</body>\n</html>";

            File.WriteAllText($"{fileName}.html", html);
        }

        public override IUIElementFactory CreateFactory() {
            return new HTMLElementFactory();
        }
    }
}
