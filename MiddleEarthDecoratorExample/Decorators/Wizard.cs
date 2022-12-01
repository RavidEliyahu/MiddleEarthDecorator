using MiddleEarthDecorator.Components.Common;
using MiddleEarthDecorator.Decorators.Common;

namespace MiddleEarthDecorator.Decorators
{
    public class Wizard : Decorator
    {
        public Wizard(ICharacter character) : base(character)
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
}