using System;
using System.Diagnostics;
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

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            const double RATE = 0.1;
            double final, gstpart, origcost;
            try
            {
                final = double.Parse(box.Text);
            }
            catch(Exception)
            {
                var d = new MessageDialog("Error. Enter a numeric value");
                await d.ShowAsync();

                return;
            }

            origcost = final / (1 + RATE);
            gstpart = final - origcost;

            Debug.WriteLine("Total cost: " + final);
            Debug.WriteLine("GST Component: " + gstpart);

            var di = new MessageDialog("The GST component is: " + gstpart.ToString("C"));
            await di.ShowAsync();
        }
    }
}
