using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ex03
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

        private void WebView_LoadCompleted(object sender, NavigationEventArgs e)
        {
            textBlock.Text = "Website successfully loaded!";
        }

        private void googleButton_Click(object sender, RoutedEventArgs e)
        {
            urlTextBox.Text = "https://www.google.com.au/";
            browserView.Source = new Uri(urlTextBox.Text);
        }

        private void tafeButton_Click(object sender, RoutedEventArgs e)
        {
            urlTextBox.Text = "https://portal.tafesa.edu.au/";
            browserView.Source = new Uri(urlTextBox.Text);
        }

        private void yahooButton_Click(object sender, RoutedEventArgs e)
        {
            urlTextBox.Text = "https://au.yahoo.com/";
            browserView.Source = new Uri(urlTextBox.Text);
        }

        private void ownButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Uri.TryCreate(urlTextBox.Text, UriKind.RelativeOrAbsolute, out Uri uri)) 
            {
                browserView.Source = uri;
            }
            else
            {
                textBlock.Text = "That URL is invalid. Please try again!";
            }
        }
    }
}
