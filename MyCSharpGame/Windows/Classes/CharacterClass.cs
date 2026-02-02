namespace MyCSharpGame.Windows.Character;

public class CharacterClass
{
    public string label;
    public string hitDice; 
    public string infos;

    public CharacterClass(string _label, string _hitDice, string _infos)
    {
        label = _label;
        hitDice = _hitDice;
        infos = _infos;
    }
}