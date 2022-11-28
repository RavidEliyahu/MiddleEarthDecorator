namespace HeroesDecorator;

public class Wizard : Decorator
{
    public Wizard(IHero hero) : base(hero)
    {
    }

    public override string Equipment()
    {
        return base.Equipment() + "\n* Staff";
    }

    public override int GetAttackPower()
    {
        return base.GetAttackPower() + 5;
    }
}