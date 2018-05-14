using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using System.Diagnostics;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Temperature
{

    public sealed partial class MainPage : Page
    {
        string s = "";

        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void Convert_Click(object o, RoutedEventArgs e)
        {
            try
            {
                Convert(double.Parse(box.Text));
            }
            catch (Exception)
            {
                await new MessageDialog("Error!\nPlease enter a numeric value.").ShowAsync();
                return;
            }

            this.Frame.Navigate(typeof(ConversionPage), s);
        }

        private double Convert(double temp)
        {
            double conv = 0D;

            if (ctof.IsChecked == true)
            {
                conv = (temp * 1.8) + 32;
                s = ("You converted from Celcius to Fahrenheit.\nConverted " + temp + "C to " + conv.ToString("N1") + "F.");
            }
            else if (ftoc.IsChecked == true)
            {
                conv = (temp - 32) * 5 / 9;
                s = ("You converted from Fahrenheit to Celcius.\nConverted " + temp + "F to " + conv.ToString("N1") + "C.");
            }

            return conv;
        }

    }
}
