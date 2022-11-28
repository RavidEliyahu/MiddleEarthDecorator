namespace HeroesDecorator;

public class Men : IHero
{
    public string GetRaceName()
    {
        return GetType().Name;
    }

    public virtual string Equipment()
    {
        return "* Sword";
    }

    public int GetAttackPower()
    {
        return 2;
    }
}