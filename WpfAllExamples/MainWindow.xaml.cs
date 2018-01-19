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

namespace WpfAllExamples
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person person = new Person { Age = 23, Name = "Shankar" };
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = person; //
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Person Name is \t" + person.Name + "\n Person Age is \t" +person.Age.ToString());
        }
    }

    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
}
