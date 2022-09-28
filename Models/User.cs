namespace FeatureFlags.Models
{
    public class User
    {
        public User(string userName, string displayName)
        {
            UserName = userName;
            DisplayName = displayName;
        }

        public string UserName { get; set; }

        public string DisplayName { get; set; }
    }
}
