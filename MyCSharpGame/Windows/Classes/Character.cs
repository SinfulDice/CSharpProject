using System.Collections.Generic;

namespace MyCSharpGame.Windows.Character;

public class Character
{
    public string name;
    public int height;
    public float weight;
    public int age;

    public int speed;
    public int hitPoint;
    public int initiative;
    public int armor;

    public int money;

    public int[] caracteristics;
    
    public CharacterClass characterClass;
    public CharacterRace characterRace;

    public List<Item> Inventory = new List<Item>();
    public List<Item> CombatInventory = new List<Item>();
    public List<Item> QuestInventory = new List<Item>();

    public Character()
    {
        money = 50;
        armor = 10;
    }

    public float toMeters(int centimeters)
    {
        return centimeters/100f;
    }

    public void AddToInventory(Item item)
    {
        Inventory.Add(item);
    }
    public void DeleteFromInventory(Item item)
    {
        if (Inventory.Contains(item))
        {
            Inventory.Remove(item);
        }
    }
    
    public void AddToCombatInventory(Item item)
    {
        CombatInventory.Add(item);
    }
    public void DeleteFromCombatInventory(Item item)
    {
        if (CombatInventory.Contains(item))
        {
            CombatInventory.Remove(item);
        }
    }
    
    public void AddToQuestInventory(Item item)
    {
        QuestInventory.Add(item);
    }
    public void DeleteFromQuestInventory(Item item)
    {
        if (QuestInventory.Contains(item))
        {
            QuestInventory.Remove(item);
        }
    }
}