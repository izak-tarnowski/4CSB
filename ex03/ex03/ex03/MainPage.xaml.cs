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
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void calcButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                row1sum1Box.Text = "" + (double.Parse(row1num1Box.Text) + double.Parse(row1num2Box.Text));
                row2sum2Box.Text = "" + (double.Parse(row2num1Box.Text) + double.Parse(row2num2Box.Text));
                row3sum1Box.Text = "" + (double.Parse(row1num1Box.Text) + double.Parse(row2num1Box.Text));
                row3sum2Box.Text = "" + (double.Parse(row1num2Box.Text) + double.Parse(row2num2Box.Text));
                row3sum3Box.Text = "" + (double.Parse(row1sum1Box.Text) + double.Parse(row2sum2Box.Text));
            }
            catch(Exception)
            {
                var dia = new MessageDialog("Invalid argument. Ensure all values are numeric.");
                await dia.ShowAsync();
            }
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            row1num1Box.Text = "";
            row1num2Box.Text = "";
            row1sum1Box.Text = "";
            row2num1Box.Text = "";
            row2num2Box.Text = "";
            row2sum2Box.Text = "";
            row3sum1Box.Text = "";
            row3sum2Box.Text = "";
            row3sum3Box.Text = "";
        }
    }
}
