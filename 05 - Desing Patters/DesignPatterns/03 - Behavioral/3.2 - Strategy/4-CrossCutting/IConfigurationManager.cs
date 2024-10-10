namespace DesignPatterns.Strategy
{
    public interface IConfigurationManager
    {
        string GetValue(string node);
    }
}