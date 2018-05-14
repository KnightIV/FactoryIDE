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

namespace FactoryIDE
{
    /// <summary>
    /// Interaction logic for IDEPage.xaml
    /// </summary>
    public partial class IDEPage : Page
    {
        public IDE pageContent{ get; set; }
        public IDEPage(IDE PageContent)
        {
            InitializeComponent();
            pageContent = PageContent;
        }


    }
}
