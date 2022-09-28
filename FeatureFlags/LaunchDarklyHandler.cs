using LaunchDarkly.Sdk;
using LaunchDarkly.Sdk.Server;

namespace FeatureFlags.FeatureFlags
{
    public class LaunchDarklyHandler : IFeatureFlagHandler
    {
        private LdClient _launchDarklyClient;

        public LaunchDarklyHandler()
        {
            _launchDarklyClient = new LdClient("sdk-b06cfce9-8cc3-4a72-a9e9-b2799573ac40");
        }

        public bool IsEnabled(string featureFlagName, string userName, bool defaultValue)
        {
            var user = User.Builder(userName).Build();

            return _launchDarklyClient.BoolVariation(featureFlagName, user, defaultValue);
        }
    }
}
