using System.Linq;

namespace DesignPatterns.Facade
{

    //A complex subsystem
    public class Math
    {
        public int Sum(params int[] nums)
        {
            return nums.Sum();
        }

        public int Divide(int divideBy, params int[] nums)
        {
            int total = nums.Sum() / divideBy;
            return total;
        }

        public int Average(params int[] nums)
        {
            int avg = nums.Sum() / nums.Count();
            return avg;
        }
    }
}
