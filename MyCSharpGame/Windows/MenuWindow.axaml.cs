using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace MyCSharpGame.Windows;

public partial class MenuWindow : UserControl
{
    public MenuWindow()
    {
        InitializeComponent();
    }

    private void PlayButton_OnClick(object? sender, RoutedEventArgs e)
    {
        var mainWindow = TopLevel.GetTopLevel(this) as MainWindow;
        mainWindow?.ShowPlayWindow();
    }

    private void SettingsButton_OnClick(object? sender, RoutedEventArgs e)
    {
        MainWindow.SettingsCounter = 1;
        var mainWindow = TopLevel.GetTopLevel(this) as MainWindow;
        mainWindow?.ShowSettingsWindow();
    }
}