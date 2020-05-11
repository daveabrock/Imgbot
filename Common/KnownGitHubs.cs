namespace Common
{
    public static class KnownGitHubs
    {
        public const int AppId = 4706;

        public const string ImgBotLogin = "ImgBotApp";

        public const string ImgBotEmail = "ImgBotHelp@gmail.com";

        public const string DefaultCommitMessageTitle = "[ImgBot] Optimize images";

        public const string Username = "x-access-token";

        public const string BranchName = "imgbot";

        /// <summary>
        /// Represents the format of the access tokens url. {0} is the installation ID.
        /// </summary>
        public const string AccessTokensUrlFormat = "https://api.github.com/app/installations/{0}/access_tokens";
    }
}
