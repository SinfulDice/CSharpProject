using System;

namespace MyCSharpGame.Windows.Character;

public class CharacterRace
{
    public string label;
    public int minHeight;
    public int maxHeight;
    public int maxAge;
    public int speed;
    public int[] caracUp;
    public string infos;

    public CharacterRace(string _label, int _minHeight, int _maxHeight, int _maxAge, int _speed, int[] _caracUp, string _infos)
    {
        label = _label;
        minHeight = _minHeight;
        maxHeight = _maxHeight;
        maxAge = _maxAge;
        speed = _speed;
        caracUp = _caracUp;
        infos = _infos;
    }
}