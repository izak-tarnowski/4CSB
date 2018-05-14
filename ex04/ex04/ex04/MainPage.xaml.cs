using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Diagnostics;
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

        private async void button_Click(object s, RoutedEventArgs a)
        {
            MessageDialog d;

            if(findBox.Text == "")
            {
                d = new MessageDialog("Invalid arguments. The 'find' box must have filled in.");
                await d.ShowAsync();
                return;
            }

            if(inputBox.Text.IndexOf(findBox.Text) == -1)
            {
                d = new MessageDialog("Invalid arguments. The word '" + findBox.Text + "' was not found in the text.");
                await d.ShowAsync();
                return;
            }

            inputBox.Text = inputBox.Text.Replace(findBox.Text, replaceBox.Text);

            d = new MessageDialog("Replaced word '" + findBox.Text + "' with '" + replaceBox.Text + "' succesfully.");
            await d.ShowAsync();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            inputBox.Text = "Universal Windows Platform Foundation (UWP) provides developers with a programming model for building Windows 10 applications across all Windows device types using one app package.";
        }
    }
}
