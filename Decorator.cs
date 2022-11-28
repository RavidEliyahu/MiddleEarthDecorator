namespace HeroesDecorator;

public class Decorator : IHero
{
    private readonly IHero _hero;

    protected Decorator(IHero hero)
    {
        _hero = hero;
    }
    public virtual string Equipment()
    {
        return _hero.Equipment();
    }

    public virtual int GetAttackPower()
    {
        return _hero.GetAttackPower();
    }

    public string GetRaceName()
    {
        return _hero.GetRaceName();
    }
}