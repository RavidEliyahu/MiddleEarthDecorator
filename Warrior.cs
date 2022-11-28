namespace HeroesDecorator;

public class Warrior : Decorator
{
    public Warrior(IHero hero) : base(hero)
    {
    }

    public override string Equipment()
    {
        return base.Equipment() + "\n* Shield";
    }

    public override int GetAttackPower()
    {
        return base.GetAttackPower() + 3;
    }
}