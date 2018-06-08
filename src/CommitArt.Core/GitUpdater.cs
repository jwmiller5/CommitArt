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

        public GitUpdater(string remoteGitPath, string gitusername, string gitpassword, string gitemail)
        {
            gitPath = remoteGitPath;
            username = gitusername;
            password = gitpassword;
            email = gitemail;
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

        private void Pull()
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

        private string GetDataFilePath()
        {
            string[] paths = new string[] { repoPath, "data", "data.txt" };
            string dataFilePath = Path.Combine(paths);
            return dataFilePath;
        }

        public void UpdateLocalDataFile()
        {
            GetDataFilePath().AppendLineToDataFile();
        }

        public void PushChangesToGithub()
        {
            Commit();
            Push();
        }

        private void Commit()
        {
            using (var repo = new Repository(repoPath))
            {

                // Stage the file
                Commands.Stage(repo, "data/data.txt");

                // Create the committer's signature and commit
                Signature author = new Signature("John", email, DateTime.Now);
                Signature committer = author;

                // Commit to the repository
                Commit commit = repo.Commit("Data file update", author, committer);
            }
        }

        private void Push()
        {
            using (var repo = new Repository(repoPath))
            {
                LibGit2Sharp.PushOptions options = new LibGit2Sharp.PushOptions();
                options.CredentialsProvider = new CredentialsHandler(
                    (url, usernameFromUrl, types) =>
                        new UsernamePasswordCredentials()
                        {
                            Username = username,
                            Password = password
                        });
                repo.Network.Push(repo.Branches["master"], options);
            }
        }
    }
}
