using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace MyCSharpGame.Windows;

public partial class InfosWindow : UserControl
{
    private readonly PlayWindow _playWindow;
    public InfosWindow(PlayWindow playWindow)
    {
        InitializeComponent();
        _playWindow = playWindow;
    }

    private void NextButton_OnClick(object? sender, RoutedEventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(TextBox.Text))
        {
            var characterSheet = _playWindow.CharacterSheetWindow;
            characterSheet.ChangeName(TextBox.Text.Trim());
            MainWindow.Player.name = TextBox.Text;
            _playWindow.ShowRaceWindow();
        }
        else
        {
            TextBox.Text = "";
        }
        
        
    }
}