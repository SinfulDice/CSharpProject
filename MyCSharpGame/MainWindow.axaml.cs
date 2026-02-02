using Avalonia.Controls;
using MyCSharpGame.Windows;
using MyCSharpGame.Windows.Character;

namespace MyCSharpGame;

public partial class MainWindow : Window
{
    public static int SettingsCounter = 0;
    public MenuWindow MenuWindow = new MenuWindow();
    public SettingsWindow SettingsWindow = new SettingsWindow();
    public PlayWindow PlayWindow = new PlayWindow();
    public static Character Player;
    public MainWindow()
    {
        InitializeComponent();
        ShowMenuWindow();
        Player = new Character();
    }

    public void ShowMenuWindow()
    {
        MainPanel.Children.Clear();
        MainPanel.Children.Add(MenuWindow);
    }
    public void ShowSettingsWindow()
    {
        MainPanel.Children.Clear();
        MainPanel.Children.Add(SettingsWindow);
    }

    public void ShowPlayWindow()
    {
        MainPanel.Children.Clear();
        MainPanel.Children.Add(PlayWindow);
    }
}