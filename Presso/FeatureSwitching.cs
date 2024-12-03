using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsNew
{
    public class FeatureSwitching
    {
        public FeatureSwitching()
        {
            if (!FeatureSwitch.IsFeatureEnabled)
            {
                Console.WriteLine("Hello, World!");
            }
        }
    }

    public class FeatureSwitch
    {
        [FeatureSwitchDefinition("IsFeatureEnabled")]
        internal static bool IsFeatureEnabled => !AppContext.TryGetSwitch("IsFeatureEnabled", out var value) || false;




    }
}
