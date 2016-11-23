using System.Reflection;
using Octokit;

namespace Cake.GitHub
{
    internal static class GitHubClientFactory
    {
        //TODO: Generate nicer
        private static string ProductName => "Cake.GitHub";

        public static GitHubClient Create(Credentials credentials = null)
        {
            var client = new GitHubClient(new ProductHeaderValue(ProductName)) { Credentials = credentials };
            return client;
        }
    }
}