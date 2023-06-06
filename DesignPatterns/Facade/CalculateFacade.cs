namespace DesignPatterns.Facade
{
    //Instead of using the subsystem object, use a facade to delegate access to a part of the subsystem
    public class CalculateFacade
    {
        private readonly Math math;

        public CalculateFacade(Math math)
        {
            this.math = math;
        }

        //The facade operation
        public int Addition(params int[] num)
        {
            return math.Sum(num);
        }
    }
}
