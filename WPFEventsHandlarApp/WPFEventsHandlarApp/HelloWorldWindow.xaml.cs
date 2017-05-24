using System.Windows;

namespace WPFEventsHandlarApp
{
    /// <summary>
    /// Interaction logic for HelloWorldWindow.xaml
    /// </summary>
    public partial class HelloWorldWindow : Window
    {


        public HelloWorldWindow()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            string name = nameTextBox.Text;
            displayLabel.Content = "Hello World " + name + " !";
            anotherLabel.Content = "Hello World " + name + " !";
        }
    }
}
