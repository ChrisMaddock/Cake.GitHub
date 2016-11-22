using Cake.Core;
using Cake.Core.Annotations;
using Octokit;

namespace Cake.GitHub
{
    [CakeAliasCategory("GitHub")]
    public static class GitHubAliases
    {
        [CakeMethodAlias]
        [CakeAliasCategory("Issues")]
        public static void CreateIssue(this ICakeContext context, NewIssue issue, Model.GitHubRepository gitHubRepository)
        {
            //var client = new GitHubClient();
            OctocatClient client = null;
            client.Issue.Create(gitHubRepository.Owner, gitHubRepository.RepositoryName, issue).Wait();
        }
    }
}
