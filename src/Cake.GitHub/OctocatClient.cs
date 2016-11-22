using System.Reflection;
using Octokit;

namespace Cake.GitHub
{
    internal static class OctocatClient
    {
        private static string ProductName => Assembly.GetExecutingAssembly().FullName;

        public static GitHubClient Create(Credentials credentials = null)
        {
            var client = new GitHubClient(new ProductHeaderValue(ProductName));
            if (credentials != null) client.Credentials = credentials;
            return client;
        }
    }
}