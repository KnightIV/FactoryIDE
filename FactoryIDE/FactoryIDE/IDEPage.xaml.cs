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

using FactoryIDE_Abstract.IDE;

namespace FactoryIDE {

    /// <summary>
    /// Interaction logic for IDEPage.xaml
    /// </summary>
    public partial class IDEPage : Page {

        private IDE ide;
        private ObservableCollection<string> listBox = new ObservableCollection<string>();

        public IDEPage(IDE ide) {
            InitializeComponent();
            ComponentListBox.ItemsSource = listBox;
            this.ide = ide;
        }

        private void AddComponent_Click(object sender, RoutedEventArgs e) {
            string selectedComponent = ComponentSelector.Text;
            bool added = true;

            string content = ContentTextBox.Text;
            int width, height, left, top;

            // Some rudimentary error checking
            if (!int.TryParse(WidthTextBox.Text, out width) || !int.TryParse(HeightTextBox.Text, out height) || !int.TryParse(LeftTextBox.Text, out left) || !int.TryParse(TopTextBox.Text, out top)) {
                MessageBox.Show("Make sure all of your values were typed correctly.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            } else {
                try {
                    switch (selectedComponent) {
                        case "Button":
                            ide.AddButton(content, height, width, top, left);
                            break;

                        case "Label":
                            ide.AddLabel(content, height, width, top, left);
                            break;

                        case "Rectangle":
                            ide.AddRectangle(content, height, width, top, left);
                            break;

                        case "Text Box":
                            ide.AddTextBox(content, height, width, top, left);
                            break;

                        default:
                            MessageBox.Show("Please select a component to add first.", "Error", MessageBoxButton.OK,
                                MessageBoxImage.Error);
                            break;
                    }
                } catch (NotImplementedException) {
                    MessageBox.Show("This component is not supported in this language!", "Error", MessageBoxButton.OK,
                        MessageBoxImage.Error);
                    added = false;
                }

                if (added) {
                    listBox.Add(ide.Elements.Last().ToString());

                    ContentTextBox.Text = String.Empty;
                    WidthTextBox.Text = String.Empty;
                    HeightTextBox.Text = String.Empty;
                    LeftTextBox.Text = String.Empty;
                    TopTextBox.Text = String.Empty;
                }
            }
        }

        private void Compile_Click(object sender, RoutedEventArgs e) {
            throw new NotImplementedException();
        }
    }
}
