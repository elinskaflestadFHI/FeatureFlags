using LaunchDarkly.Sdk;
using LaunchDarkly.Sdk.Server;

namespace FeatureFlags.FeatureFlags
{
    public class LaunchDarklyFeatureFlagHandler : IFeatureFlagHandler
    {
        private LdClient _launchDarklyClient;

        public LaunchDarklyFeatureFlagHandler()
        {
            _launchDarklyClient = new LdClient("sdk-b06cfce9-8cc3-4a72-a9e9-b2799573ac40");
        }

        public bool IsEnabled(FeatureFlagName name, Models.User user, bool defaultValue)
        {
            var ldUser = User.Builder(user.UserName).Name(user.DisplayName).Build();     

            return _launchDarklyClient.BoolVariation(name.ToString(), ldUser, defaultValue);
        }
    }
}
