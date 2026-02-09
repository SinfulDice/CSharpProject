using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using MyCSharpGame.Windows.Character;

namespace MyCSharpGame.Windows;

public partial class ClassWindow : UserControl
{
    private readonly PlayWindow _playWindow;
    CharacterClass barbarianClass = new CharacterClass("Barbarian", "1d12", "They love alcool, probably.");
    CharacterClass bardClass = new CharacterClass("Bard", "1d8", "They love children, I think.");
    CharacterClass clericClass = new CharacterClass("Cleric", "1d8", "They love children, for sure.");
    CharacterClass druidClass = new CharacterClass("Druid", "1d8", "They love animals, probably.");
    CharacterClass fighterClass = new CharacterClass("Fighter", "1d10", "They love to punch people.");
    CharacterClass monkClass = new CharacterClass("Monk", "1d8", "They love yoga, or I don't know how they are so flexible.");
    CharacterClass rogueClass = new CharacterClass("Rogue", "1d8", "They love to rob you, not your heart.");
    CharacterClass wizardClass = new CharacterClass("Wizard", "1d6", "They love to fuck themselves, intellectually, of course.");
    CharacterClass artificerClass = new CharacterClass("Artificer", "1d8", "They love their wrench, I don't want to know what they do with it.");
    
    public ClassWindow(PlayWindow playWindow)
    {
        InitializeComponent();
        _playWindow = playWindow;
        BarbarianTextBlock.Text = barbarianClass.infos;
        BardTextBlock.Text = bardClass.infos;
        ClericTextBlock.Text = clericClass.infos;
        DruidTextBlock.Text = druidClass.infos;
        FighterTextBlock.Text = fighterClass.infos;
        MonkTextBlock.Text = monkClass.infos;
        RogueTextBlock.Text = rogueClass.infos;
        WizardTextBlock.Text = wizardClass.infos;
        ArtificerTextBlock.Text = artificerClass.infos;
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