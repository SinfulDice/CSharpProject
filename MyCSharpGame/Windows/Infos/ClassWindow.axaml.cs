using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using MyCSharpGame.Windows.Character;

namespace MyCSharpGame.Windows;

public partial class ClassWindow : UserControl
{
    private readonly PlayWindow _playWindow;
    private CharacterClass barabarianClass = new CharacterClass("Barbarian", "1d12", "They love alcool, probably.");
    public ClassWindow(PlayWindow playWindow)
    {
        InitializeComponent();
        _playWindow = playWindow;
    }
    public void NextWindow(string _Class)
    {
        var characterSheet = _playWindow.CharacterSheetWindow;
        characterSheet.ChangeClass(_Class);
        _playWindow.ShowHeightWeightAgeWindow();
    }
    private void BarbarianClass_OnClick(object? sender, RoutedEventArgs e)
    {
        string _class = BarbarianClass.Content.ToString();
        NextWindow(_class);
    }
    
    private void BardClass_OnClick(object? sender, RoutedEventArgs e)
    {
        string _class = BardClass.Content.ToString();
        NextWindow(_class);
    }

    private void ClericClass_OnClick(object? sender, RoutedEventArgs e)
    {
        string _class = ClericClass.Content.ToString();
        NextWindow(_class);
    }

    private void DruidClass_OnClick(object? sender, RoutedEventArgs e)
    {
        string _class = DruidClass.Content.ToString();
        NextWindow(_class);
    }

    private void Fighter_OnClick(object? sender, RoutedEventArgs e)
    {
        string _class = Fighter.Content.ToString();
        NextWindow(_class);
    }

    private void MonkClass_OnClick(object? sender, RoutedEventArgs e)
    {
        string _class = MonkClass.Content.ToString();
        NextWindow(_class);
    }

    private void RogueClass_OnClick(object? sender, RoutedEventArgs e)
    {
        string _class = RogueClass.Content.ToString();
        NextWindow(_class);
    }

    private void WizardClass_OnClick(object? sender, RoutedEventArgs e)
    {
        string _class = WizardClass.Content.ToString();
        NextWindow(_class);
    }

    private void Artificer_OnClick(object? sender, RoutedEventArgs e)
    {
        string _class = Artificer.Content.ToString();
        NextWindow(_class);
    }
}