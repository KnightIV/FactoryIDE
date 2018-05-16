using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using FactoryIDE_Abstract.IDE;

namespace FactoryIDE {

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        
        private Dictionary<string, ConstructorInfo> ideConstructors;

        public MainWindow() {
            InitializeComponent();

            ideConstructors = new Dictionary<string, ConstructorInfo>();
            InitializeDropDown();
        }

        private void InitializeDropDown() {
            // This dynamically gets all of the IDE implementation classes through the following conditions:
            /*
             * 1. The type is a class
             * 2. The type is in the namespace "FactoryIDE.IDE_Implementations"
             * 3. The type inherits from the "IDE" class
             */
            List<Type> classes = Assembly.GetExecutingAssembly().GetTypes()
                                                                .Where(t => t.IsClass && t.Namespace == "FactoryIDE.IDE_Implementations" && t.IsSubclassOf(typeof(IDE)))
                                                                .ToList();
            foreach (Type t in classes) {
                // The name is derived from the convention we currently have going on of "Platform"_IDE for class names
                string name = t.Name.Split('_')[0];

                // This gets the parameterless constructor of the IDE 
                ConstructorInfo classConstructor = t.GetConstructor(Type.EmptyTypes);
                ideConstructors.Add(name, classConstructor);
            }

            // This sets the dropdown list to all the names that the program found
            LanguageDropDownMenu.ItemsSource = ideConstructors.Keys;
        }

        private void SelectionButton_Click(object sender, RoutedEventArgs e) {
            string menu = LanguageDropDownMenu.Text;

            // This actually calls the constructor stored in the dictionary and casts it to the most abstract type (IDE)
            IDE ide = (IDE) ideConstructors[menu].Invoke(null);
            nav.Navigate(new IDEPage(ide));
        }
    }
}
