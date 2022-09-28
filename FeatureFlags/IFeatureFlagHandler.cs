using FeatureFlags.Models;

namespace FeatureFlags.FeatureFlags
{
    public interface IFeatureFlagHandler
    {
        bool IsEnabled(string featureFlagName, User user, bool defaultValue);
    }
}
