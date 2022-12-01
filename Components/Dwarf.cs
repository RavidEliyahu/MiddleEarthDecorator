namespace MiddleEarthDecorator.Components
{
    public class Dwarf : ICharacter
    {
        public string GetRaceName()
        {
            return GetType().Name;
        }
        public string Equipment()
        {
            return "* Hammer";
        }

        public int GetAttackPower()
        {
            return 1;
        }

        public void Mine()
        {
            Console.WriteLine("Mining the deeps of the Misty Mountains");
        }
    }
}