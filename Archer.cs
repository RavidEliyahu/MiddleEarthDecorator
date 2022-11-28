namespace HeroesDecorator;

public class Archer : Decorator

{
    public Archer(IHero hero) : base(hero)
    {
    }

    public override int GetAttackPower()
    {
        return base.GetAttackPower() + 2;
    }

    public override string Equipment()
    {
        return base.Equipment() + "\n* Bow";
    }
}