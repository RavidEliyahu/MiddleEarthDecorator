using MiddleEarthDecorator.Components.Common;
using MiddleEarthDecorator.Decorators.Common;

namespace MiddleEarthDecorator.Decorators;

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