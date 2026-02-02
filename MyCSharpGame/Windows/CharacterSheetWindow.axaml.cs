using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace MyCSharpGame.Windows;

public partial class CharacterSheetWindow : UserControl
{
    public CharacterSheetWindow()
    {
        InitializeComponent();
    }

    private void SaveQuitButton_OnClick(object? sender, RoutedEventArgs e)
    {
        
    }

    private void SettingButton_OnClick(object? sender, RoutedEventArgs e)
    {
        MainWindow.SettingsCounter = 2;
        var mainWindow = TopLevel.GetTopLevel(this) as MainWindow;
        mainWindow?.ShowSettingsWindow();
    }

    public void ChangeName(string input)
    {
        Name.Text = $"Name : {input}";
    }
    public void ChangeRace(string input)
    {
        Race.Text = $"Race : {input}";
    }
    public void ChangeSpeed(float input)
    {
        Speed.Text = $"Speed : {input}m";
    }
    public void ChangeClass(string input)
    {
        Class.Text = $"Class : {input}";
    }
    public void ChangeHeight(float input)
    {
        Height.Text = $"Height : {input}m";
    }
    public void ChangeWeight(int input)
    {
        Weight.Text = $"Weight : {input}kg";
    }
    public void ChangeAge(int input)
    {
        Age.Text = $"Age : {input}yo";
    }
}