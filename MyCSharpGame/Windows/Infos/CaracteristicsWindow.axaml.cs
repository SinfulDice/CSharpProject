using System;
using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Tmds.DBus.Protocol;

namespace MyCSharpGame.Windows.Infos;

public partial class CaracteristicsWindow : UserControl
{
    public int total = 0;
    public bool _isUpdating = false;
    private readonly PlayWindow _playWindow;
    public int[] _caracteristics;
    
    public Dictionary<string, int> stats = new()
    {
        {"STR", 8},
        {"DEX", 8},
        {"CON", 8},
        {"INT", 8},
        {"WIS", 8},
        {"CHA", 8}
    };

    public Dictionary<int, int> valueCost = new()
    {
        {1, 0},
        {2, 0},
        {3, 0},
        {4, 0},
        {5, 0},
        {6, 0},
        {7, 0},
        {8, 0},
        {9, 1},
        {10, 2},
        {11, 3},
        {12, 4},
        {13, 5},
        {14, 7},
        {15, 9},
        
    };
    
    public CaracteristicsWindow(PlayWindow playWindow)
    {
        InitializeComponent();
        _playWindow = playWindow;

        InfoSTRTextBlock.Text = "test";
        BonusSTRTextBlock.Text = "test";
        STRTextBlock.Text = "test";
        
        InfoDEXTextBlock.Text = "test";
        BonusDEXTextBlock.Text = "test";
        DEXTextBlock.Text = "test";
        
        InfoCONTextBlock.Text = "test";
        BonusCONTextBlock.Text = "test";
        CONTextBlock.Text = "test";
        
        InfoINTTextBlock.Text = "test";
        BonusINTTextBlock.Text = "test";
        INTTextBlock.Text = "test";
        
        InfoWISTextBlock.Text = "test";
        BonusWISTextBlock.Text = "test";
        WISTextBlock.Text = "test";
        
        InfoCHATextBlock.Text = "test";
        BonusCHATextBlock.Text = "test";
        CHATextBlock.Text = "test";

        STRUpDown.Value = stats["STR"];
        DEXUpDown.Value = stats["DEX"];
        CONUpDown.Value = stats["CON"];
        INTUpDown.Value = stats["INT"];
        WISUpDown.Value = stats["WIS"];
        CHAUpDown.Value = stats["CHA"];
    }

    // public void totalCaracteristicsCounter()
    // {
    //     int _str = valueCost[stats["STR"]];
    //     int _dex = valueCost[stats["DEX"]];
    //     int _con = valueCost[stats["CON"]];
    //     int _int = valueCost[stats["INT"]];
    //     int _wis = valueCost[stats["WIS"]];
    //     int _cha = valueCost[stats["CHA"]];
    //
    //     total = _str + _dex + _con + _int + _wis + _cha;
    // }

    public int CalculateTotalWithChange(string statName, int newValue)
    {
        int potentialTotal = 0;
        foreach (var stat in stats)
        {
            int valueToCount = (stat.Key == statName) ? newValue : stat.Value;
            potentialTotal += valueCost[valueToCount];
        }
        return potentialTotal;
    }
    
    private void HandleStatChange(object? sender, NumericUpDownValueChangedEventArgs e)
    {
        if (_isUpdating || sender is not NumericUpDown control) return;
        
        string statName = control.Name.Replace("UpDown", ""); 
    
        int newValue = (int)(control.Value ?? 8);

        if (CalculateTotalWithChange(statName, newValue) > 27)
        {
            _isUpdating = true;
            control.Value = e.OldValue;
            _isUpdating = false;
        }
        else
        {
            stats[statName] = newValue;
        }
    }
    
    public void NextWindow(Dictionary<string, int> _Caracteristics)
    {
        var characterSheet = _playWindow.CharacterSheetWindow;
        characterSheet.ChangeCaracteristics(_Caracteristics);
        _playWindow.ShowCaracteristicsWindow();

        int i = 0;
        
        foreach (var stat in stats)
        {
            _caracteristics[i] = stat.Value;
            i++;
        }
    }

    private void NextButton_OnClick(object? sender, RoutedEventArgs e)
    {
        NextWindow(stats);
        MainWindow.Player.caracteristics = _caracteristics;
    }
}