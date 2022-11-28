namespace HeroesDecorator;

public class Elf : IHero
{
    public string GetRaceName()
    {
        return GetType().Name;
    }

    public string Equipment()
    {
        return "* Daggers";
    }

    public int GetAttackPower()
    {
        return 4;
    }
}