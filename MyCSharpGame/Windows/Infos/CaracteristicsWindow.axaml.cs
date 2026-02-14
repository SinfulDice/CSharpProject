using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Tmds.DBus.Protocol;

namespace MyCSharpGame.Windows.Infos;

public partial class CaracteristicsWindow : UserControl
{
    public static Random RNG = new Random();
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

        TextBlock.Text = "You may choose your character statistics here, but if you prefer, you can choose to gamble them, and roll with it. It is your choice." +
                         " If you want to choose them manually, there is a cost for all of those statistics. A stat of 8 or less will cost you 0, a stat of 9 will" +
                         " cost you 1, a stat of 10 will cost you 2, a stat of 11 will cost you 3, a stat of 12 will cost you 4, a stat of 13 will cost you 5," +
                         " a stat of 14 will cost you 7 and finally, a stat of 15 will cost you 9. You can't go beyond 15, it is against the rules, except with your" +
                         " racial bonus(es) of course.";
        
        _caracteristics = new int[6];

        InfoSTRTextBlock.Text = "Strength";
        BonusSTRTextBlock.Text = $"{MainWindow.Player.characterRace.caracUp[0]}";
        STRTextBlock.Text = $"{stats["STR"] + MainWindow.Player.characterRace.caracUp[0]}";
        
        InfoDEXTextBlock.Text = "Dexterity";
        BonusDEXTextBlock.Text = $"{MainWindow.Player.characterRace.caracUp[1]}";
        DEXTextBlock.Text = $"{stats["DEX"] + MainWindow.Player.characterRace.caracUp[1]}";
        
        InfoCONTextBlock.Text = "Constitution";
        BonusCONTextBlock.Text = $"{MainWindow.Player.characterRace.caracUp[2]}";
        CONTextBlock.Text = $"{stats["CON"] + MainWindow.Player.characterRace.caracUp[2]}";
        
        InfoINTTextBlock.Text = "Intelligence";
        BonusINTTextBlock.Text = $"{MainWindow.Player.characterRace.caracUp[3]}";
        INTTextBlock.Text = $"{stats["INT"] + MainWindow.Player.characterRace.caracUp[3]}";
        
        InfoWISTextBlock.Text = "Wisdom";
        BonusWISTextBlock.Text = $"{MainWindow.Player.characterRace.caracUp[4]}";
        WISTextBlock.Text = $"{stats["WIS"] + MainWindow.Player.characterRace.caracUp[4]}";
        
        InfoCHATextBlock.Text = "Charisma";
        BonusCHATextBlock.Text = $"{MainWindow.Player.characterRace.caracUp[5]}";
        CHATextBlock.Text = $"{stats["CHA"] + MainWindow.Player.characterRace.caracUp[5]}";

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
            RefreshUI();
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

    private void RandomButton_OnClick(object? sender, RoutedEventArgs e)
    {
        _isUpdating = true;
        
        string[] keys = { "STR", "DEX", "CON", "INT", "WIS", "CHA" };
        NumericUpDown[] ups = { STRUpDown, DEXUpDown, CONUpDown, INTUpDown, WISUpDown, CHAUpDown };

        for (int i = 0; i < keys.Length; i++)
        {
            int randomScore = RNG.Next(8, 16);
            stats[keys[i]] = randomScore;
            ups[i].Value = randomScore;
        }
        
        RefreshUI();
        _isUpdating = false;
    }
    
    private void RefreshUI()
    {
        string[] keys = { "STR", "DEX", "CON", "INT", "WIS", "CHA" };
        TextBlock[] texts = { STRTextBlock, DEXTextBlock, CONTextBlock, INTTextBlock, WISTextBlock, CHATextBlock };
        int pointsUsed = GetCurrentTotalCost();

        for (int i = 0; i < keys.Length; i++)
        {
            int baseStat = stats[keys[i]];
            int bonus = MainWindow.Player.characterRace.caracUp[i];
            texts[i].Text = (baseStat + bonus).ToString();
        }

        TotalPoints.Text = $"Points spent : {pointsUsed} / 27";
    }
    
    public int GetCurrentTotalCost()
    {
        int currentTotal = 0;
        foreach (var stat in stats)
        {
            currentTotal += valueCost[stat.Value];
        }
        return currentTotal;
    }
}