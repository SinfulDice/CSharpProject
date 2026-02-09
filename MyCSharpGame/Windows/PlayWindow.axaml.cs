using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using MyCSharpGame.Windows.Infos;

namespace MyCSharpGame.Windows;

public partial class PlayWindow : UserControl
{
    public InfosWindow InfosWindow;
    public CharacterSheetWindow CharacterSheetWindow = new CharacterSheetWindow();
    public RaceWindow RaceWindow;
    public ClassWindow ClassWindow;
    public HeightWeightAgeWindow HeightWeightAgeWindow;
    public CaracteristicsWindow CaracteristicsWindow;
    public PlayWindow()
    {
        InitializeComponent();
        InfosWindow = new InfosWindow(this);
        PlayPanel.Children.Add(InfosWindow);
        CharacterSheetPanel.Children.Add(CharacterSheetWindow);
    }

    public void ShowRaceWindow()
    {
        RaceWindow = new RaceWindow(this);
        PlayPanel.Children.Clear();
        PlayPanel.Children.Add(RaceWindow);
    }
    public void ShowClassWindow()
    {
        ClassWindow = new ClassWindow(this);
        PlayPanel.Children.Clear();
        PlayPanel.Children.Add(ClassWindow);
    }

    public void ShowHeightWeightAgeWindow()
    {
        HeightWeightAgeWindow = new HeightWeightAgeWindow(this);
        PlayPanel.Children.Clear();
        PlayPanel.Children.Add(HeightWeightAgeWindow);
    }

    public void ShowCaracteristicsWindow()
    {
        CaracteristicsWindow = new CaracteristicsWindow(this);
        PlayPanel.Children.Clear();
        PlayPanel.Children.Add(CaracteristicsWindow);
    }
}