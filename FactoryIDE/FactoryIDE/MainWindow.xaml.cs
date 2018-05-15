using FactoryIDE_Abstract.IDE;
using System;
using System.Collections.Generic;
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
using FactoryIDE.IDE_Implementations;

namespace FactoryIDE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void SelectionButton_Click(object sender, RoutedEventArgs e)
        {
            //NavigationService nav = NavigationService.GetNavigationService(this);

            string menu = LanguageDropDownMenu.Text;
            if (menu == "WPF")
            {
                nav.Navigate(new IDEPage(new WPF_IDE()));
            }
            else if (menu == "HTML")
            {
                nav.Navigate(new IDEPage(new HTML_IDE()));
            }
        }
    }
}
