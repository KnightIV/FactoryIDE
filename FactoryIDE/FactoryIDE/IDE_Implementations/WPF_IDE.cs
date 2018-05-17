using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryIDE.FactoryImplementations;
using FactoryIDE_Abstract.IDE;
using FactoryIDE_Abstract.Factories;
using System.Windows.Controls;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using FactoryIDE_Abstract.UIElements;
using System.IO;
using System.Reflection;
using System.Windows;

namespace FactoryIDE.IDE_Implementations
{

    public class WPF_IDE : IDE
    {

        public override void Compile(string fileName)
        {
            string cSharpCode = "";
            int i = 0;
            foreach (FactoryIDE_Abstract.UIElements.UIElement item in Elements)
            {
                cSharpCode += $"var i{i} = {item.Render()}; \n" +
                    $"canvas.Children.Add(i{i}); \n" +
                    $"Canvas.SetTop(i{i},{item.Top}); \n" +
                    $"Canvas.SetLeft(i{i},{item.Left}); \n";

            }

            string template = File.ReadAllText(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Files/WPFTemplate.txt"));
            cSharpCode = template.Replace("%s", cSharpCode);

            string[] references = { "PresentationCore", "PresentationFramework", "WindowBase" };
            CSharpCodeProvider codeProvider = new CSharpCodeProvider();
            // ICodeCompiler codeCompiler = codeProvider.CreateCompiler();

            CompilerParameters compilerParameters = new CompilerParameters();
            compilerParameters.GenerateExecutable = true;
            compilerParameters.OutputAssembly = fileName + ".exe";
            //compilerParameters.ReferencedAssemblies.AddRange();

            compilerParameters.ReferencedAssemblies.Add(@"C:\Program Files\Reference Assemblies\Microsoft\Framework\v3.0\PresentationCore.dll");

            compilerParameters.ReferencedAssemblies.Add(@"C:\Program Files\Reference Assemblies\Microsoft\Framework\v3.0\PresentationFramework.dll");

            compilerParameters.ReferencedAssemblies.Add(@"C:\Program Files\Reference Assemblies\Microsoft\Framework\v3.0\WindowsBase.dll");
            compilerParameters.ReferencedAssemblies.Add("System.dll");

            CompilerResults compilerResults = codeProvider.CompileAssemblyFromSource(compilerParameters, cSharpCode);
            if (compilerResults.Errors.HasErrors)
            {
                foreach (CompilerError e in compilerResults.Errors)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        } 

        public override IUIElementFactory CreateFactory()
        {
            return new WPFElementFactory();
        }
    }
}
