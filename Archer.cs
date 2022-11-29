namespace MiddleEarthDecorator;

public class Archer : Decorator

{
    public Archer(ICharacter character) : base(character)
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