namespace FeatureFlags.FeatureFlags
{
    public interface IFeatureFlagHandler
    {
        bool IsEnabled(string featureFlagName, string userName, bool defaultValue);
    }
}
