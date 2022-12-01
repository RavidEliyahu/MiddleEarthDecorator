using MiddleEarthDecorator.Decorators.Common;

namespace MiddleEarthDecorator.Decorators
{
    public class Warrior : Decorator
    {
        public Warrior(ICharacter character) : base(character)
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
}