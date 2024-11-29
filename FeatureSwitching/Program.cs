using System.Diagnostics.CodeAnalysis;

namespace FeatureSwitching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (FeatureSwitch.IsFeatureEnabled)
            {
                Console.WriteLine("Hello, World!");
            }



        }
    }

    public class FeatureSwitch
    {
        [FeatureSwitchDefinition("doTheThing")]
        internal static bool IsFeatureEnabled => AppContext.TryGetSwitch("doTheThing", out var doTheThing) || false;




    }
}
