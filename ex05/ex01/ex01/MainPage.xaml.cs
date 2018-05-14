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

namespace ex01
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

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog d;
            try
            {
                commBox.Text = "" + calcComm(double.Parse(salesBox.Text)).ToString("C");
            }
            catch(FormatException)
            {
                d = new MessageDialog("Invalid argument. Please use numeric values for sales ammount.");
                await d.ShowAsync();
                return;
            }
        }

        private double calcComm(double amt)
        {
            double comm = 0D;
            if (amt <= 999)
            {
                commBox.Text = "" + comm;
            }
            else if (amt <= 1999)
            {
                comm = amt * .15;
                commBox.Text = "" + comm.ToString("C");
            }
            else
            {
                comm = amt * .2;
                commBox.Text = "" + comm.ToString("C");
            }

            return comm;
        }

    }
}
