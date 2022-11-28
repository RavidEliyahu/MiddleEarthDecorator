namespace HeroesDecorator;

public class Dwarf : IHero
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