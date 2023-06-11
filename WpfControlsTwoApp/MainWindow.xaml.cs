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

namespace WpfControlsTwoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button b)
            {
                string? txt = b.Content.ToString();
                switch (txt)
                {
                    case "To Home":
                        sw.ScrollToHome();
                        break;
                    case "To End":
                        sw.ScrollToEnd();
                        break;
                    case "Line Up":
                        sw.LineUp();
                        break;
                    case "Line Down":
                        sw.LineDown();
                        break;
                }
            }
        }  
    }
}
