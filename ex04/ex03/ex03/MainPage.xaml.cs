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

namespace ex03
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private string s = "";

        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void button_Click(object o, RoutedEventArgs a)
        {
            try
            {
                calcPostage(double.Parse(box.Text));
            }
            catch(FormatException)
            {
                var di = new MessageDialog("Invalid argument. Please use numeric values for weight.");
                await di.ShowAsync();
            }

            this.Frame.Navigate(typeof(Final), s);
            /*
            var d = new MessageDialog(weight + "kg to be shipped through " + type + " will cost " + cost.ToString("C"));
            await d.ShowAsync();*/
        }

        private double calcPostage(double weight)
        {
            double mul = 0D;
            string type = "";
            if (regBut.IsChecked == true)
            {
                mul = 2.5D;
                type = "Regular Post";
            }
            else if (expBut.IsChecked == true)
            {
                mul = 5D;
                type = "Express Post";
            }
            else if (couBut.IsChecked == true)
            {
                mul = 7.5D;
                type = "Courier";
            }
            s = weight + "kg to be shipped via " + type + " will cost " + (mul * weight).ToString("C") + ".";

            return mul * weight;
        }
    }
}
