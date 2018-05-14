using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ex02
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

        public async void rectButton_Click(object o, RoutedEventArgs e)
        {
            try
            {
                rectShape.Width = double.Parse(widthBox.Text);
                rectShape.Height = double.Parse(heightBox.Text);
            }
            catch(Exception)
            {
                var dia = new MessageDialog("Invalid arguments. Please ensure you are entering numeric values, not text values.");
                await dia.ShowAsync();
            }
        }

        public async void ellButton_Click(object o, RoutedEventArgs e)
        {
            try
            {
                ellShape.Width = double.Parse(widthBox.Text);
                ellShape.Height = double.Parse(heightBox.Text);
            }
            catch(Exception)
            {
                var dia = new MessageDialog("Invalid arguments. Please ensure you are entering numeric values, not text values.");
                await dia.ShowAsync();
            }
        }

    }
}
