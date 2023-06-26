using DesignPatterns.Builder.Samsung.Enums;

namespace DesignPatterns.Builder
{
    public interface ISamsung
    {
        string SetModel(string model);

        string SetUSBType(USB type);
        string SetSimtype(SIM type);
    }
}
