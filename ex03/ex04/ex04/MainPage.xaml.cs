using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ex04
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void secondClicked_Checked(object sender, RoutedEventArgs e)
        {
            if(secondClicked.IsChecked == true)
            {
                button2.Background = new SolidColorBrush(Colors.Coral);
            }
        }

        private void secondClicked_Unchecked(object s, RoutedEventArgs e)
        {
            if(secondClicked.IsChecked == false)
            {
                button2.Background = new SolidColorBrush(Colors.White);
            }
        }

        private void firstCheck_Unchecked(object s, RoutedEventArgs e)
        {
            if(firstCheck.IsChecked == false)
            {
                button.Background = new SolidColorBrush(Colors.White);
            }
        }

        private void firstCheck_Checked(object sender, RoutedEventArgs e)
        {
            if(firstCheck.IsChecked == true)
            {
                button.Background = new SolidColorBrush(Colors.Coral);
            }
            if(firstCheck.IsChecked == false)
            {
                button.Background = new SolidColorBrush(Colors.White);
            }
        }
    }
}
