using FactoryIDE_Abstract.IDE;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
using FactoryIDE_Abstract.UIElements;

namespace FactoryIDE
{
    /// <summary>
    /// Interaction logic for IDEPage.xaml
    /// </summary>
    public partial class IDEPage : Page
    {
        public string selectedComponent;
        public IDE PageContent{ get; set; }

        ObservableCollection<FactoryIDE_Abstract.UIElements.UIElement> listBox = new ObservableCollection<FactoryIDE_Abstract.UIElements.UIElement>();
        public IDEPage(IDE pageContent)
        {
            InitializeComponent();
            DataContext = this;
            PageContent = pageContent;


           
        }

        private void AddComponent_Click(object sender, RoutedEventArgs e)
        {
            string componentSelector = ComponentSelector.Text;
            MessageBox.Show(componentSelector);
           
        }

        private void Compile_Click(object sender, RoutedEventArgs e)
        {

        }

      

      
    }
}
