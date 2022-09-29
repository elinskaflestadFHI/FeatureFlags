using Io.Rollout.Rox.Core.Entities;
using Io.Rollout.Rox.Server;
using Io.Rollout.Rox.Server.Flags;
using LaunchDarkly.Sdk;
using LaunchDarkly.Sdk.Server;
using Microsoft.Net.Http.Headers;

namespace FeatureFlags.FeatureFlags
{
    public class CloudBeeFeatureFlagHandler : IFeatureFlagHandler
    {
        private Flags _flags; 

        public CloudBeeFeatureFlagHandler()
        {
            Rox.Setup("63342bb6e5c2cef057b3f041", new RoxOptions(new RoxOptions.RoxOptionsBuilder { }));

            _flags = new Flags();
        }

        public bool IsEnabled(FeatureFlagName name, Models.User user, bool defaultValue)
        {
            switch (name)
            {
                case FeatureFlagName.ShowLogo:
                    return _flags.ShowLogo.IsEnabled();
                default:
                    return defaultValue;
            }
        }
    }

    public class Flags : IRoxContainer
    {
        public RoxFlag ShowLogo = new RoxFlag();
    }
}
