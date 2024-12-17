using System;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace GetStartedApp.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void ButtonClicked(object source, RoutedEventArgs args)
    {
        //Debug.WriteLine($"Click! Celsius={celsius.Text}");
        //Console.WriteLine($"Click! Celsius={celsius.Text}");
        if (Double.TryParse(celsius.Text, out double celsiusValue))
        {
            double fahrenheitValue = celsiusValue * (9d / 5d) + 32;
            fahrenheit.Text = fahrenheitValue.ToString("0.0");
        }
        else
        {
            celsius.Text = "0";
            fahrenheit.Text = "0";
        }
    }
}