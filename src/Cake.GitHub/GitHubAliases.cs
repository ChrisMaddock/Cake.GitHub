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
        public static void CreateIssue(this ICakeContext context, Credentials credentials, GitHubRepository repository, NewIssue issue)
        {
            var client = GitHubClientFactory.Create(credentials);
            client.Issue.Create(repository.Owner, repository.RepositoryName, issue).Wait();
        }

        [CakeMethodAlias]
        [CakeAliasCategory("Pull Requests")]
        public static void CreatePullRequest(this ICakeContext context, Credentials credentials,
            GitHubRepository repository, NewPullRequest pullRequest)
        {
            var client = GitHubClientFactory.Create(credentials);
            client.PullRequest.Create(repository.Owner, repository.RepositoryName, pullRequest);
        }
    }
}
