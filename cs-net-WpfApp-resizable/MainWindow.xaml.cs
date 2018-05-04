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
        public MainWindow()
        {
            MouseWheel += MouseWheelDelegate;
            InitializeComponent();
        }

        private static void MouseWheelDelegate(object sender, MouseWheelEventArgs e)
        {

            var isCtrl = Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl);
            var printCtrl = (isCtrl) ? " + isCtrl" : "";

            System.Console.WriteLine(e.Delta + printCtrl);
            //Accumulate some value
            //someValue += e.Delta;

        }
    }
}