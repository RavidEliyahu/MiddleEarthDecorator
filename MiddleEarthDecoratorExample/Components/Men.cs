using MiddleEarthDecorator.Components.Common;

namespace MiddleEarthDecorator.Components
{
    public class Men : ICharacter
    {
        public string GetRaceName()
        {
            return GetType().Name;
        }

        public virtual string Equipment()
        {
            return "* Sword";
        }

        public int GetAttackPower()
        {
            return 2;
        }
        
        public void Greed()
        {
            Console.WriteLine("I want the one ring for myself!");
        }
    }
}