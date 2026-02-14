using System;

namespace MyCSharpGame.Windows.Character;

public class Item
{
    public static Random RNG = new Random();
    
    public string label;
    public EItemRarity rarity;

    public Item(string _label, EItemRarity _rarity)
    {
        label = _label;
        rarity = _rarity;
    }
    
    public string GetRarityColor(EItemRarity rarity)
    {
        return rarity switch
        {
            EItemRarity.Common => "White",
            EItemRarity.Uncommon => "Green",
            EItemRarity.Rare => "Blue",
            EItemRarity.Epic => "Purple",
            EItemRarity.Legendary => "Orange",
            _ => "Gray"
        };
    }
    
    public EItemRarity GetRandomRarity()
    {
        int roll = RNG.Next(1, 101);

        if (roll > 95) return EItemRarity.Legendary; // 5% de chance
        if (roll > 85) return EItemRarity.Epic;      // 10% de chance
        if (roll > 70) return EItemRarity.Rare;      // 15% de chance
        if (roll > 50) return EItemRarity.Uncommon;  // 20% de chance
        return EItemRarity.Common;                   // 50% de chance
    }
}