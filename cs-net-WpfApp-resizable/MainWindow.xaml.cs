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
        public delegate void Delegate(string message);

        public MainWindow()
        {
            // Instantiate the delegate.
            Delegate handler = DelegateMethod;

            // Call the delegate.
            handler("Hello World");

            //TBD: whatever the practical difference is between next two RegisterClassHandler invocation types:

            //1
            //EventManager.RegisterClassHandler(typeof(System.Windows.Controls.Control), System.Windows.Controls.Control.KeyDownEvent, handler);

            //2
            EventManager.RegisterClassHandler(typeof(Window), Keyboard.KeyUpEvent, new KeyEventHandler(keyUp), true);




            InitializeComponent();
        }

        // Create a method for a delegate.
        public static void DelegateMethod(string message)
        {
            System.Console.WriteLine(message);
        }

        private void keyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.OemComma)
                MessageBox.Show("YAY!!!");
        }


    }
}
