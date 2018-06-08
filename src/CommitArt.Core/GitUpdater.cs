using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using LibGit2Sharp;
using LibGit2Sharp.Handlers;

namespace CommitArt.Core
{
    public class GitUpdater
    {
        private string repoPath = "localrepo";
        private string username = "";
        private string password = "";
        private string email = "";
        private string gitPath = "";
        //private GetFile
        //private UpdateFileText
        //private Commit File
        //private Push update

        public GitUpdater(string remoteGitPath, string gitusername, string gitpassword, string gitemail)
        {
            gitPath = remoteGitPath;
            username = gitusername;
            password = gitpassword;
            email = gitemail;
        }

        public void SyncLocalRepo()
        {
            CloneRepo();
            FetchRepoFiles(repoPath);
            Pull();
        }

        public void CloneRepo()
        {
            if (!Directory.Exists(repoPath))
            {
                var co = new CloneOptions();
                co.CredentialsProvider = (_url, _user, _cred) => new UsernamePasswordCredentials { Username = username, Password = password };
                Repository.Clone(gitPath, repoPath, co);
            }

            FetchRepoFiles(repoPath);
            Pull();
        }

        private static void FetchRepoFiles(string localRepoPath)
        {
            string logMessage = "";
            using (var repo = new Repository(localRepoPath))
            {
                foreach (Remote remote in repo.Network.Remotes)
                {
                    IEnumerable<string> refSpecs = remote.FetchRefSpecs.Select(x => x.Specification);
                    Commands.Fetch(repo, remote.Name, refSpecs, null, logMessage);
                }
            }
            Console.WriteLine(logMessage);
        }

        public void Pull()
        {
            using (var repo = new Repository(repoPath))
            {
                LibGit2Sharp.PullOptions options = new LibGit2Sharp.PullOptions();
                options.FetchOptions = new FetchOptions();
                options.FetchOptions.CredentialsProvider = new CredentialsHandler(
                    (url, usernameFromUrl, types) =>
                        new UsernamePasswordCredentials()
                        {
                            Username = username,
                            Password = password
                        });
                Commands.Pull(repo, new Signature(username, email, new DateTimeOffset(DateTime.Now)), options);
            }
        }

        public string GetDataFilePath()
        {
            string[] paths = new string[] { Directory.GetCurrentDirectory(), repoPath, "data", "data.txt" };
            string dataFilePath = Path.Combine(paths);
            return dataFilePath;
        }

        public void AppendLine()
        {
            string text = File.ReadAllText(GetDataFilePath());
            text = text + CreateRandomString() + Environment.NewLine;
            File.WriteAllText(GetDataFilePath(), text);
        }

        private string CreateRandomString()
        {
            //TODO: Get creative
            Random random = new Random();
            var builder = new StringBuilder(100);
            for (int i = 0; i < 100; i++)
            {
                builder.Append((char)random.Next(33, 125));
            }

            return builder.ToString();
        }
    }
}
