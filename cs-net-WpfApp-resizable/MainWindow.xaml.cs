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

namespace cs_net_WpfApp_resizable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public delegate void Del(string message);

        public MainWindow()
        {
            // Instantiate the delegate.
            Del handler = DelegateMethod;

            // Call the delegate.
            handler("Hello World");

            EventManager.RegisterClassHandler(typeof(System.Windows.Controls.Control), System.Windows.Controls.Control.KeyDownEvent, handler);

            InitializeComponent();
        }

        // Create a method for a delegate.
        public static void DelegateMethod(string message)
        {
            System.Console.WriteLine(message);
        }

    }
}
