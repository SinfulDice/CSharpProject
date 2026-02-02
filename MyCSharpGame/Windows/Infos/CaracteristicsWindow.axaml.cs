using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Tmds.DBus.Protocol;

namespace MyCSharpGame.Windows.Infos;

public partial class CaracteristicsWindow : UserControl
{
    public int total = 0;

    public Dictionary<string, int> stats = new()
    {
        {"Strength", 10},
        {"Dexterity", 10},
        {"Constitution", 10},
        {"Intelligence", 10},
        {"Wisdow", 10},
        {"Charisma", 10}
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
    
    public CaracteristicsWindow()
    {
        InitializeComponent();
        totalCaracteristicsCounter();
        
    }

    public void totalCaracteristicsCounter()
    {
        int _str = stats["Strength"];
        int _dex = stats["Dexterity"];
        int _con = stats["Constitution"];
        int _int = stats["Intelligence"];
        int _wis = stats["Wisdom"];
        int _cha = stats["Charisma"];

        total = _str + _dex + _con + _int + _wis + _cha;
    }

    private void STRUpDown_OnValueChanged(object? sender, NumericUpDownValueChangedEventArgs e)
    {
        totalCaracteristicsCounter();
        if (total > 27)
        {
            STRUpDown.Value -= 1;
            return;
        }

        stats["Strength"] = (int)(STRUpDown.Value ?? 0);
    }

    private void DEXUpDown_OnValueChanged(object? sender, NumericUpDownValueChangedEventArgs e)
    {
        totalCaracteristicsCounter();
        if (total > 27)
        {
            DEXUpDown.Value -= 1;
            return;
        }

        stats["Dexterity"] = (int)(DEXUpDown.Value ?? 0);
    }

    private void CONUpDown_OnValueChanged(object? sender, NumericUpDownValueChangedEventArgs e)
    {
        totalCaracteristicsCounter();
        if (total > 27)
        {
            CONUpDown.Value -= 1;
            return;
        }

        stats["Constitution"] = (int)(CONUpDown.Value ?? 0);
    }

    private void INTUpDown_OnValueChanged(object? sender, NumericUpDownValueChangedEventArgs e)
    {
        totalCaracteristicsCounter();
        if (total > 27)
        {
            INTUpDown.Value -= 1;
            return;
        }

        stats["Intelligence"] = (int)(INTUpDown.Value ?? 0);
    }

    private void WISUpDown_OnValueChanged(object? sender, NumericUpDownValueChangedEventArgs e)
    {
        totalCaracteristicsCounter();
        if (total > 27)
        {
            WISUpDown.Value -= 1;
            return;
        }

        stats["Wisdom"] = (int)(WISUpDown.Value ?? 0);
    }

    private void CHAUpDown_OnValueChanged(object? sender, NumericUpDownValueChangedEventArgs e)
    {
        totalCaracteristicsCounter();
        if (total > 27)
        {
            CHAUpDown.Value -= 1;
            return;
        }

        stats["Charisma"] = (int)(CHAUpDown.Value ?? 0);
    }
}