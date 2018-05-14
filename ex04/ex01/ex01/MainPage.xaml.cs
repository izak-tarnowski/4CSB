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
            const double RATE = 5D;
            double fee;
            int hours;
            try
            {
                hours = int.Parse(box.Text);
            }
            catch(Exception)
            {
                var dia = new MessageDialog("Error, enter integer values.");
                await dia.ShowAsync();
                return;
            }

            if(hours < 0 || hours > 24)
            {
                var di = new MessageDialog("Error, enter hours between 1 and 24.");
                await di.ShowAsync();
                return;
            }

            fee = RATE * hours;
            var dig = new MessageDialog("Your PARKING FEE is " + fee.ToString("C"));
            await dig.ShowAsync();

        }
    }
}
