﻿using System;
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

namespace Sum
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

        private async void goButton_Click(object sender, RoutedEventArgs e)
        {
            int a, b, sum= 0;

            try
            {
                a = int.Parse(num1Box.Text);
                b = int.Parse(num2Box.Text);
                sum = a + b;
                sumBox.Text = "" + sum;
            }
            catch (FormatException)
            {
                var dia = new MessageDialog("Invalid arguments. Please enter a number, not words.");
                await dia.ShowAsync();
            }

        }
    }
}