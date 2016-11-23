#r "src/Cake.GitHub/bin/Debug/net45/Cake.GitHub.dll"
#r "src/Cake.GitHub/bin/Debug/net45/Octokit.dll"

using Octokit;
using Cake.GitHub;

var target = Argument("target", "Default");

Task("CreateIssue")
    .Does(() =>
{
    var credentials = new Credentials();
	var repository = new GitHubRepository("ChrisMaddock", "Cake.GitHub");
	
	var newIssue = new NewIssue("TestIssue1");

	CreateIssue(credentials, repository, newIssue);
});

Task("Default")
    .IsDependentOn("CreateIssue");

//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////

RunTarget(target);