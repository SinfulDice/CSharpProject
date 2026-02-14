namespace MyCSharpGame.Windows.Character;

public class CharacterClass
{
    public string label;
    public string hitDice; 
    public string infos;
    public string skillN1;
    public string infosSkillN1;

    public CharacterClass(string _label, string _hitDice, string _infos, string _skillN1, string _infosSkillN1)
    {
        label = _label;
        hitDice = _hitDice;
        infos = _infos;
        skillN1 = _skillN1;
        infosSkillN1 = _infosSkillN1;
    }
}