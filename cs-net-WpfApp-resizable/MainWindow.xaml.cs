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
//using static System.Windows.UIElement;

namespace cs_net_WpfApp_resizable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            //access any key press at any time.
            EventManager.RegisterClassHandler(typeof(Window), Keyboard.KeyDownEvent, new KeyEventHandler(KeyUpDelegateMethod), true);

            //EventManager.RegisterClassHandler(typeof(Window), Mouse.MouseWheelEvent, new MouseWheelHandler(), true);

            //EventManager.RegisterClassHandler(typeof(Window), Mouse.MouseWheelEvent, new MouseWheelHandler(MainWindow_MouseWheel), true);

            MouseWheel += MainWindow_MouseWheel;


            InitializeComponent();
        }

        private static void KeyUpDelegateMethod(object sender, KeyEventArgs e)
        {

            System.Console.WriteLine(e.Key);


            var isCtrl = Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl);

            //if (isCtrl) System.Console.WriteLine("isCtrl");

        }

        private static void MainWindow_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            //MouseWheelEventArgs
            System.Console.WriteLine(e.Delta);
            //Accumulate some value
            //someValue += e.Delta;

        }
    }
}