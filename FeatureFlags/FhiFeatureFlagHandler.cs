﻿using FeatureFlags.Models;
using Fhi.Hu.FeatureFlags.Contracts.v1;
using Refit;

namespace FeatureFlags.FeatureFlags
{
    public class FhiFeatureFlagHandler : IFeatureFlagHandler
    {
        private IFeatureFlags _featureFlagsClient;

        public FhiFeatureFlagHandler()
        {
            _featureFlagsClient = RestService.For<IFeatureFlags>("https://test-fhi-hu-featureflags-api.azurewebsites.net/");
        }

        public bool IsEnabled(string featureFlagName, User user, bool defaultValue)
        {
            try
            {
                return _featureFlagsClient.IsFeatureFlagEnabled(featureFlagName, user.UserName).Result;
            }
            catch (Exception)
            {
                return defaultValue; // if something fails, use featureflag defaultvalue
            }            
        }
    }
}
