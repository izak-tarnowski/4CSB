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

    public sealed partial class MainPage : Page
    {

        private string[] cities = new string[] { "Dehli", "Los Angeles", "Mexico City", "Mumbai", "New York City", "Osaka", "Sao Paulo", "Seoul", "Shanghai", "Tokyo" };
        private int[] pops = new int[] { 22, 18, 22, 22, 22, 17, 21, 23, 18, 34 };

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void BurgerButton_Click(object s, RoutedEventArgs a)
        {
            NewSplitView.IsPaneOpen = !NewSplitView.IsPaneOpen;
        }

        private void Population_Click(object s, RoutedEventArgs a)
        {
            string output = "";
            for (int i = 0; i < pops.Length; i++)
            {
                output = "\n" + output + pops[i];
            }

            outputTextBlock.Text = "Output population array elements:" + output;
        }

        private void Sum_Click(object s, RoutedEventArgs a)
        {
            int total = 0;
            for (int i = 0; i < pops.Length; i++)
            {
                total += pops[i];
            }

            outputTextBlock.Text = "Total of all populations:" + total;
        }

        private void Average_Click(object s, RoutedEventArgs a)
        {
            double ave = 0D;
            int total = 0;

            for (int i = 0; i < pops.Length; i++)
            {
                total += pops[i];
            }

            ave = (double)total / pops.Length;

            outputTextBlock.Text = "Average population of array elements:\n" + ave.ToString("N");
        }

        private void Highest_Click(object s, RoutedEventArgs a)
        {
            int hi = pops[0];
            for (int i = 0; i < pops.Length; i++)
            {
                if (pops[i] > hi)
                {
                    hi = pops[i];
                }
            }

            outputTextBlock.Text = "Highest population:\n" + hi;
        }

        private void Lowest_Click(object s, RoutedEventArgs a)
        {
            int lo = pops[0];
            for (int i = 0; i < pops.Length; i++)
            {
                if (pops[i] < lo)
                {
                    lo = pops[i];
                }
            }

            outputTextBlock.Text = "Lowest population:\n" + lo;
        }

        private void CityArray_Click(object s, RoutedEventArgs a)
        {
            string output = "";
            for (int i = 0; i < cities.Length; i++)
            {
                output += cities[i] + '\n';
            }

            outputTextBlock.Text = "Output city array elements:\n" + output;
        }

        private async void SearchCity_Click(object s, RoutedEventArgs a)
        {
            if (CitySearchBox.Text == "")
            {
                await new MessageDialog("Please enter search criteria.").ShowAsync();
                return;
            }
            bool found = false;
            int count = 0;

            string sea = CitySearchBox.Text.ToLower();
            while (!found && count < cities.Length)
            {
                if (sea == cities[count].ToLower())
                {
                    found = true;
                }
                else
                {
                    count++;
                }
            }

            if (found)
            {
                outputTextBlock.Text = "Search found city: " + sea + " with a population of: " + pops[count];
            }
            else
            {
                await new MessageDialog("City was not found!").ShowAsync();
                return;
            }
        }

        private async void InsertCity_Click(object s, RoutedEventArgs a)
        {
            if (CityInsertBox.Text == "")
            {
                await new MessageDialog("Please enter city to insert.").ShowAsync();
                return;
            }

            bool found = false;
            int count = 0;

            string sea = CityInsertBox.Text.ToLower();

            while (!found && count < cities.Length)
            {
                if (sea == cities[count].ToLower())
                {
                    found = true;
                }
                else
                {
                    count++;
                }
            }

            if (!found)
            {
                Array.Resize(ref cities, cities.Length + 1);
                cities[cities.Length - 1] = sea;
                CityArray_Click(s, a);
                await new MessageDialog("Updated city array. Now with " + cities.Length + " entries.").ShowAsync();
            }
            else
            {
                await new MessageDialog("City already exists.").ShowAsync();
                return;
            }

        }

        private async void DeleteCity_Click(object s, RoutedEventArgs a)
        {
            if (CityDeleteBox.Text == "")
            {
                await new MessageDialog("Please enter city to delete.").ShowAsync();
                return;
            }

            int count = 0;
            bool found = false;

            string sea = CityDeleteBox.Text.ToLower();

            while (!found && count < cities.Length)
            {
                if (sea == cities[count].ToLower())
                {
                    found = true;
                }
                else
                {
                    count++;
                }
            }

            if (found)
            {
                for (int i = count; i < cities.Length - 1; i++)
                {
                    cities[i] = cities[i + 1];
                }
                Array.Resize(ref cities, cities.Length - 1);
                CityArray_Click(s, a);
                await new MessageDialog("Updated city array. Now with " + cities.Length + " entries.").ShowAsync();
            }
            else
            {
                await new MessageDialog(sea + " was not found.").ShowAsync();
            }
        }


    }
}
