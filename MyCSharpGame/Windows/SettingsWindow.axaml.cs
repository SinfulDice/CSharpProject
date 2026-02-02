using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace MyCSharpGame.Windows;

public partial class SettingsWindow : UserControl
{
    
    public SettingsWindow()
    {
        InitializeComponent();
    }

    private void BackButton_OnClick(object? sender, RoutedEventArgs e)
    {
        var mainWindow = TopLevel.GetTopLevel(this) as MainWindow;
        
        if (MainWindow.SettingsCounter == 1)
        {
            mainWindow?.ShowMenuWindow();
        }
        else if (MainWindow.SettingsCounter == 2)
        {
            mainWindow?.ShowPlayWindow();
        }
    }
}