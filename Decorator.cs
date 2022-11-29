namespace MiddleEarthDecorator
{
    public class Decorator : ICharacter
    {
        private readonly ICharacter _character;

        protected Decorator(ICharacter character)
        {
            _character = character;
        }
        public virtual string Equipment()
        {
            return _character.Equipment();
        }

        public virtual int GetAttackPower()
        {
            return _character.GetAttackPower();
        }

        public string GetRaceName()
        {
            return _character.GetRaceName();
        }
    }
}