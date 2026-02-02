using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using MyCSharpGame.Windows.Character;

namespace MyCSharpGame.Windows;

public partial class RaceWindow : UserControl
{
    private readonly PlayWindow _playWindow;
    CharacterRace humanRace = new CharacterRace("Human", 155, 185, 80, 900, [1,1,1,1,1,1], 
        "Humans are fealthy creatures who ramps on Earth.");
    CharacterRace elfRace = new CharacterRace("Elf", 150, 180, 750, 900, [0,2,0,0,0,0], 
        "Elf are beautiful creatures who reigns on Earth.");
    CharacterRace dwarvenRace = new CharacterRace("Dwarf", 120, 150, 350, 750, [0,0,2,0,0,0], 
        "Dwarf are creatures who lives under us, who loves Rocks.");
    CharacterRace dragonbornRace = new CharacterRace("Dragonborn", 180, 240, 80, 900, [2,0,0,0,0,1], 
        "Dragonborn are dragon I suppose, I don't know much about them.");
    CharacterRace tieflingRace = new CharacterRace("Tiefling", 155, 185, 90, 900, [0,0,0,1,0,2], 
        "Tiefling are charismatic like Raphael");
    public RaceWindow(PlayWindow playWindow)
    {
        InitializeComponent();
        _playWindow = playWindow;
        InfosHumanRace.Text = humanRace.infos;
        InfosElfRace.Text = elfRace.infos;
        InfosDwarvenRace.Text = dwarvenRace.infos;
        InfosDragonbornRace.Text = dragonbornRace.infos;
        InfosTieflingRace.Text = tieflingRace.infos;
    }

    public void NextWindow(string _Race, float _Speed)
    {
        var characterSheet = _playWindow.CharacterSheetWindow;
        characterSheet.ChangeRace(_Race);
        characterSheet.ChangeSpeed(_Speed);
        _playWindow.ShowClassWindow();
    }

    private void HumanRace_OnClick(object? sender, RoutedEventArgs e)
    {
        string _race = humanRace.label;
        MainWindow.Player.characterRace = humanRace;
        float _speed = MainWindow.Player.toMeters(humanRace.speed);
        NextWindow(_race, _speed);
    }

    private void ElfRace_OnClick(object? sender, RoutedEventArgs e)
    {
        string _race = elfRace.label;
        MainWindow.Player.characterRace = elfRace;
        float _speed = MainWindow.Player.toMeters(elfRace.speed);
        NextWindow(_race, _speed);
    }

    private void DwarvenRace_OnClick(object? sender, RoutedEventArgs e)
    {
        string _race = dwarvenRace.label;
        MainWindow.Player.characterRace = dwarvenRace;
        float _speed = MainWindow.Player.toMeters(dwarvenRace.speed);
        NextWindow(_race, _speed);
    }

    private void Dragonborn_OnClick(object? sender, RoutedEventArgs e)
    {
        string _race = dragonbornRace.label;
        MainWindow.Player.characterRace = dragonbornRace;
        float _speed = MainWindow.Player.toMeters(dragonbornRace.speed);
        NextWindow(_race, _speed);
    }

    private void TieflingRace_OnClick(object? sender, RoutedEventArgs e)
    {
        string _race = tieflingRace.label;
        MainWindow.Player.characterRace = tieflingRace;
        float _speed = MainWindow.Player.toMeters(tieflingRace.speed);
        NextWindow(_race, _speed);
    }
}