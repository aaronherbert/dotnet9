using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presso
{
    public class FeatureSwitching
    {
        public FeatureSwitching()
        {
            if (FeatureSwitch.IsFeatureEnabled)
            {
                Console.WriteLine("Hello, World!");
            }
        }
    }

    public class FeatureSwitch
    {
        [FeatureSwitchDefinition("myFeature")]
        internal static bool IsFeatureEnabled => AppContext.TryGetSwitch("myFeature", out var doTheThing) || false;




    }
}
