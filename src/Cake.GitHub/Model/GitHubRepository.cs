namespace Cake.GitHub.Model
{
    public struct GitHubRepository
    {
        public string Owner { get; }
        public string RepositoryName { get; }

        public GitHubRepository(string owner, string repositoryName)
        {
            Owner = owner;
            RepositoryName = repositoryName;
        }
    }
}
