namespace MiddleEarthDecorator;

public class Dwarf : ICharacter
{
    public string GetRaceName()
    {
        return GetType().Name;
    }
    public string Equipment()
    {
        return "* Hammer";
    }

    public int GetAttackPower()
    {
        return 1;
    }
}