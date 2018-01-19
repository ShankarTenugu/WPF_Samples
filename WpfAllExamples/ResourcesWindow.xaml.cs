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
using System.Windows.Shapes;

namespace WpfAllExamples
{
    /// <summary>
    /// Interaction logic for ResourcesWindow.xaml
    /// </summary>
    public partial class ResourcesWindow : Window
    {
        public ResourcesWindow()
        {
            InitializeComponent();
        }

        private void changeResourceButton_Click(object sender, RoutedEventArgs e)
        {
            var brush = (SolidColorBrush)TryFindResource("solidBrush");
            brush.Color = System.Windows.Media.Colors.Black;
        }
    }
}
