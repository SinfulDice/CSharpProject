namespace MyCSharpGame.Windows.Character;

public class CharacterCaracteristics
{
    public int STR;
    public int DEX;
    public int CON;
    public int INT;
    public int WIS;
    public int CHA;

    public CharacterCaracteristics(int _str, int _dex, int _con, int _int, int _wis, int _cha)
    {
        STR = _str;
        DEX = _dex;
        CON = _con;
        INT = _int;
        WIS = _wis;
        CHA = _cha;
    }

    public void fromArray(int[] _array)
    {
        STR += _array[0];
        DEX += _array[1];
        CON += _array[2];
        INT += _array[3];
        WIS += _array[4];
        CHA += _array[5];
    }
}