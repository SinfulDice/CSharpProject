using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using MyCSharpGame.Windows.Character;

namespace MyCSharpGame.Windows;

public partial class ClassWindow : UserControl
{
    private readonly PlayWindow _playWindow;
    CharacterClass barbarianClass = new CharacterClass("Barbarian", "1d12", "They love alcool, probably.", "Rage", "Enrage for 10 turns. Each time you hit, deal twice your damage, each time you get hit, receive twice the damage.");
    CharacterClass bardClass = new CharacterClass("Bard", "1d8", "They love children, I think.", "Singing makes raining ?", "Roll a dice, if it's even, boost yourself and your ally with 1d6 next time you hit an opponent, and if it's odd, make it rain baby.");
    CharacterClass clericClass = new CharacterClass("Cleric", "1d8", "They love children, for sure.", "Heal", "Heal yourself or your ally for 3d6.");
    CharacterClass druidClass = new CharacterClass("Druid", "1d8", "They love animals, probably.", "Pet", "You can summon one of your tamed pet.");
    CharacterClass fighterClass = new CharacterClass("Fighter", "1d10", "They love to punch people.", "1000 cut", "That's a metaphor, but you cut  3 times your opponent, so 3 times your damage.");
    CharacterClass monkClass = new CharacterClass("Monk", "1d8", "They love yoga, or I don't know how they are so flexible.", "Hit combo", "Hit 4 times your enemy with your fist.");
    CharacterClass rogueClass = new CharacterClass("Rogue", "1d8", "They love to rob you, not your heart.", "Sneak attack", "An attack that deals twice the damage from behind.");
    CharacterClass wizardClass = new CharacterClass("Wizard", "1d6", "They love to fuck themselves, intellectually, of course.", "FireBall", "Self explicit, 8d6 damage in a zone.");
    CharacterClass artificerClass = new CharacterClass("Artificer", "1d8", "They love their wrench, I don't want to know what they do with it.", "Infuse", "Infuse your weapon with a potion.");
    
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
    public void NextWindow(string _class, string _skill, string _infos, string _hitDice)
    {
        var characterSheet = _playWindow.CharacterSheetWindow;
        characterSheet.ChangeClass(_class);
        characterSheet.ChangeSkills(_skill, _infos);
        characterSheet.ChangeMaxHitPoint(_hitDice);
        _playWindow.ShowHeightWeightAgeWindow();
    }
    private void BarbarianClass_OnClick(object? sender, RoutedEventArgs e)
    {
        string _class = BarbarianClass.Content.ToString();
        string _skill = barbarianClass.skillN1;
        string _infos = barbarianClass.infosSkillN1;
        string _hitDice = barbarianClass.hitDice.Replace("1d", "");
        NextWindow(_class, _skill, _infos, _hitDice);
    }
    
    private void BardClass_OnClick(object? sender, RoutedEventArgs e)
    {
        string _class = BardClass.Content.ToString();
        string _skill = bardClass.skillN1;
        string _infos = bardClass.infosSkillN1;
        string _hitDice = bardClass.hitDice.Replace("1d", "");
        NextWindow(_class, _skill, _infos, _hitDice);
    }

    private void ClericClass_OnClick(object? sender, RoutedEventArgs e)
    {
        string _class = ClericClass.Content.ToString();
        string _skill = clericClass.skillN1;
        string _infos = clericClass.infosSkillN1;
        string _hitDice = clericClass.hitDice.Replace("1d", "");
        NextWindow(_class, _skill, _infos, _hitDice);
    }

    private void DruidClass_OnClick(object? sender, RoutedEventArgs e)
    {
        string _class = DruidClass.Content.ToString();
        string _skill = druidClass.skillN1;
        string _infos = druidClass.infosSkillN1;
        string _hitDice = druidClass.hitDice.Replace("1d", "");
        NextWindow(_class, _skill, _infos, _hitDice);
    }

    private void Fighter_OnClick(object? sender, RoutedEventArgs e)
    {
        string _class = Fighter.Content.ToString();
        string _skill = fighterClass.skillN1;
        string _infos = fighterClass.infosSkillN1;
        string _hitDice = fighterClass.hitDice.Replace("1d", "");
        NextWindow(_class, _skill, _infos, _hitDice);
    }

    private void MonkClass_OnClick(object? sender, RoutedEventArgs e)
    {
        string _class = MonkClass.Content.ToString();
        string _skill = monkClass.skillN1;
        string _infos = monkClass.infosSkillN1;
        string _hitDice = monkClass.hitDice.Replace("1d", "");
        NextWindow(_class, _skill, _infos, _hitDice);
    }

    private void RogueClass_OnClick(object? sender, RoutedEventArgs e)
    {
        string _class = RogueClass.Content.ToString();
        string _skill = rogueClass.skillN1;
        string _infos = rogueClass.infosSkillN1;
        string _hitDice = rogueClass.hitDice.Replace("1d", "");
        NextWindow(_class, _skill, _infos, _hitDice);
    }

    private void WizardClass_OnClick(object? sender, RoutedEventArgs e)
    {
        string _class = WizardClass.Content.ToString();
        string _skill = wizardClass.skillN1;
        string _infos = wizardClass.infosSkillN1;
        string _hitDice = wizardClass.hitDice.Replace("1d", "");
        NextWindow(_class, _skill, _infos, _hitDice);
    }

    private void Artificer_OnClick(object? sender, RoutedEventArgs e)
    {
        string _class = Artificer.Content.ToString();
        string _skill = artificerClass.skillN1;
        string _infos = artificerClass.infosSkillN1;
        string _hitDice = artificerClass.hitDice.Replace("1d", "");
        NextWindow(_class, _skill, _infos, _hitDice);
    }
}