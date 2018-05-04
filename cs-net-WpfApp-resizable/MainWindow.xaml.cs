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

            EventManager.RegisterClassHandler(typeof(Window), Keyboard.KeyUpEvent, new KeyEventHandler(MyStrangeMethod), true);
            



            InitializeComponent();
        }

        // Create a method for .... i'm uncertain if it's valid to call this part the delegate... but I'll go with Yes, it is, since it's semantically executing later.
        public static void MyStrangeMethod(object sender, KeyEventArgs e)
        {
            //System.Console.WriteLine(message);
            if (e.Key == Key.OemComma)
                MessageBox.Show("YAY!!!");

        }

        private void keyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.OemComma)
                MessageBox.Show("YAY!!!");
        }


    }
}
