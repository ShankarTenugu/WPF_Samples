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
    /// Interaction logic for DataTemplateWindow.xaml
    /// </summary>
    public partial class DataTemplateWindow : Window
    {
        Person dataperson = new Person { Name = "Krithikesh", Age = 1 };
        List<Person> people = new List<Person>()
        {
            new Person { Name = "Krithikesh", Age = 1 },
            new Person { Name = "Shankar", Age = 36 },
            new Person { Name = "Rajasree", Age = 31 }
        };
        public DataTemplateWindow()
        {
            InitializeComponent();
            this.DataContext = people;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(e.Source.ToString());
        }
    }
}
