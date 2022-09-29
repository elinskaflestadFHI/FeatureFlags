using FeatureFlags.Models;

namespace FeatureFlags.FeatureFlags
{
    public interface IFeatureFlagHandler
    {
        bool IsEnabled(FeatureFlagName name, User user, bool defaultValue);
    }
}
