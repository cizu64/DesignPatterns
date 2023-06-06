using System.Linq;

namespace DesignPatterns.Prototype
{
    
    public interface Prototype
    {
        int Add(params int[] nums);
        Prototype Clone();
    }

    public class ConcretePrototype : Prototype
    {
        public int Add(params int[] nums)
        {
            return nums.Sum();
        }
      
        public Prototype Clone()
        {
            return new ConcretePrototype();
        }
    }
}
