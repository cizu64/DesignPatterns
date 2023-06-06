using Newtonsoft.Json;

namespace DesignPatterns.Builder
{
    public class ConcreteAutomobile : IAutomobile
    {
        public string BuildHonda(Honda honda)
        {
            var result = JsonConvert.SerializeObject(honda);
            return result;
        }

        public string BuildToyota(Toyota toyota)
        {
            var result = JsonConvert.SerializeObject(toyota);
            return result;

        }
    }
}
