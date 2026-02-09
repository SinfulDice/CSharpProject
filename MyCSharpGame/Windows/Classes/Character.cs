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

    public Character()
    {
        money = 50;
        armor = 10;
    }

    public float toMeters(int centimeters)
    {
        return centimeters/100f;
    }
}