using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace MyCSharpGame.Windows.Infos;

public partial class HeightWeightAgeWindow : UserControl
{
    private readonly PlayWindow _playWindow;
    public HeightWeightAgeWindow(PlayWindow playWindow)
    {
        InitializeComponent();
        _playWindow = playWindow;
        HeightTextBlock.Text = $"Choose the height of your character, between {MainWindow.Player.toMeters(MainWindow.Player.characterRace.minHeight)}" +
                               $"m and {MainWindow.Player.toMeters(MainWindow.Player.characterRace.maxHeight)}m. This won't affect anything.";
        WeightTextBlock.Text = "Choose the weight of your character, between 50kg and 200kg. This won't affect anything.";
        AgeTextBlock.Text = $"Choose the age of your character, between 1yo and {MainWindow.Player.characterRace.maxAge}yo. This may affect your gameplay.";
        
        HeightUpDown.Minimum = MainWindow.Player.characterRace.minHeight;
        HeightUpDown.Maximum = MainWindow.Player.characterRace.maxHeight;
        HeightUpDown.Value = MainWindow.Player.characterRace.minHeight + 10;
        
        WeightUpDown.Minimum = 50;
        WeightUpDown.Maximum = 200;
        WeightUpDown.Value = 80;

        AgeUpDown.Minimum = 1;
        AgeUpDown.Maximum = MainWindow.Player.characterRace.maxAge;
        AgeUpDown.Value = 20;
    }

    private void NextButton_OnClick(object? sender, RoutedEventArgs e)
    {
        int _age = (int)(AgeUpDown.Value ?? 0);
        int _weight = (int)(WeightUpDown.Value ?? 0);
        int _height = (int)(HeightUpDown.Value ?? 0);
        
        MainWindow.Player.age = _age;
        MainWindow.Player.weight = _weight;
        MainWindow.Player.height = _height;
        
        var characterSheet = _playWindow.CharacterSheetWindow;
        characterSheet.ChangeHeight(MainWindow.Player.toMeters(_height));
        characterSheet.ChangeWeight(_weight);
        characterSheet.ChangeAge(_age);
        _playWindow.ShowCaracteristicsWindow();
    }
}