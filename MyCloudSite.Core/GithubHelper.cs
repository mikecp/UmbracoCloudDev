using System.Collections.Generic;
using Octokit;

namespace MyCloudSite.Core
{
    public class GithubHelper
    {
        public static IReadOnlyList<Repository> GetRepositories(string organisation)
        {
            var client1 = new GitHubClient(new ProductHeaderValue("my-cool-app"));
            return client1.Repository.GetAllForOrg(organisation).Result;
        }
    }
}
