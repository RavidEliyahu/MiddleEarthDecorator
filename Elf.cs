namespace MiddleEarthDecorator
{
    public class Elf : ICharacter
    {
        public string GetRaceName()
        {
            return GetType().Name;
        }

        public string Equipment()
        {
            return "* Daggers";
        }

        public int GetAttackPower()
        {
            return 4;
        }
    }
}