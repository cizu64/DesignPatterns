using System.Linq;

namespace DesignPatterns.Prototype
{
    
    public interface IPrototype
    {
        int Add(params int[] nums);
        IPrototype Clone();
    }

    public class ConcretePrototype : IPrototype
    {
        public int Add(params int[] nums)
        {
            return nums.Sum();
        }
      
        public IPrototype Clone()
        {
            return new ConcretePrototype();
        }
    }

    public class ConcretePrototype2
    {
        public int Add(params int[] nums)
        {
            return nums.Sum();
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }


}
